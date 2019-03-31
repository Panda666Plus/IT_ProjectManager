Public Class mdlPersonnel



    ''' <summary>
    ''' 导入职员资料
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadPersonnelData()
        '
        Dim sql As String
        Dim dt As New DataTable

        sql = "select distinct 姓名 as pName,职位 as pPost,职员代码 as employeeID,(select ATL_HD_Company.CompanyName  from ATL_HD_Company" &
            " where ATL_HD_Company.CompanyNo =HR_V_AllEmp_Info.工作地点 ) as workPlace from HR_V_AllEmp_Info where 组织单元 = 'DT部' " &
            " and 员工状态 = '在职' or 姓名 in(select 姓名 from HR_V_AllEmp_Info where 职员代码='00061' or 职员代码='00089') order by employeeID asc  "
        dt = getDataTables(sql)
        Grid1.DataSource = dt
        dt.Dispose()

    End Sub
    ''' <summary>
    ''' 导入选择员工的任务资料
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadPersonnelSelectData()
        '
        Dim dt As New DataTable

        Dim str1 As String = GridView1.GetFocusedRowCellValue("employeeID")
        Dim str2 As String = GridView1.GetFocusedRowCellValue("pName")
        Dim sql As String = Nothing
        sql = "select SmStartDate  as ActualStatDate,SmEndDate  as AchualEndDate,null as TotalTime, null as AssGrade,Explain as Evaluate,SchemeName  as IDName,'0' as PID, ID+ '111111111' as CID,SmPrincipal as PrincipalUID, (select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Scheme.SmFollow  = ATL_HD_UserGroups.UserNo ) as FollowUID, (select ATL_HD_Emergency.Value from ATL_HD_Emergency where ATL_HD_Emergency.Value=IT_Scheme.Emergency) as priority, 0 as assID,(select V_IT_Scheme .Progress from V_IT_Scheme  where V_IT_Scheme .ID=IT_Scheme .ID) as workComplete from IT_Scheme    where SmPrincipal   = '" + str2 + "' or SmFollow ='" + str1 + "'"
        sql = sql + "  UNION select null as ActualStatDate,null as AchualEndDate,null as TotalTime, null as AssGrade,Explain as Evaluate,PrjName as IDName,SchemeID + '111111111' as PID,ID+ '222222222' as CID, PrincipalUID,(select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Project.FollowUID = ATL_HD_UserGroups.UserNo ) as FollowUID, cast(Priority as nvarchar(50)) as priority, 0 as assID, (select V_IT_Project.Progress from V_IT_Project where V_IT_Project.ID=IT_Project.ID) as workComplete from IT_Project  where PrincipalUID  = '" + str2 + "' or FollowUID ='" + str1 + "'"
        sql = sql + "  UNION select  ActualStatDate, AchualEndDate, (select SUM(IT_Schedule.CumulativeTime) from IT_Schedule where IT_Schedule.AssID =IT_Assignment.ID) as TotalTime, AssGrade,  Evaluate,  AssName as IDName,  PrjID + '222222222' as PID, ID + '333333333' as CID,  (select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Assignment.AppointUid = ATL_HD_UserGroups.UserNo ) as PrincipalUID,  (select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Assignment.AppointUid = ATL_HD_UserGroups.UserNo ) as FollowUID, (select ATL_HD_Emergency.Value from ATL_HD_Emergency where ATL_HD_Emergency.Value=IT_Assignment.Emergency) as priority,ID AS assID, (select SUM(IT_Schedule.FollowSch) from IT_Schedule where IT_Schedule.AssID =IT_Assignment.ID) as workComplete  from IT_Assignment  where AppointUid  ='" + str1 + "'"

        dt = getDataTables(sql)


        If dt.Rows.Count = 0 Then
            TreeList1.DataSource = Nothing
        End If

        TreeList1.Nodes.Clear()
        TreeList1.DataSource = dt
        TreeList1.ExpandAll()
        dt.Dispose()

    End Sub

    Private Sub mdlPersonnel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        LoadPersonnelData()

    End Sub

    Private Sub Grid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid1.Click
        LoadPersonnelSelectData()
        DirectCast(Me.ParentForm, frmMain).LabelControl2.Text = "[人员信息-" & GridView1.GetFocusedRowCellValue("pName") & "]"
    End Sub


    Private Sub TreeList1_CustomDrawNodeCell(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs) Handles TreeList1.CustomDrawNodeCell
        '依情况变动色彩
        If e.Column.FieldName = "AchualEndDate" Then

            If IsDBNull(e.CellValue) = False Then

                If Date.Today.Date > Format$(e.CellValue, "short date") Then

                    If e.Node.GetValue("workComplete") <> 100 Then
                        e.Appearance.BackColor = Color.Red
                    End If

                Else

                    If Date.Today.Date.AddDays(1) >= Format$(e.Node.GetValue("AchualEndDate"), "short date") Then
                        e.Appearance.BackColor = Color.Yellow
                    Else

                        If Date.Today.Date >= Format$(e.Node.GetValue("ActualStatDate"), "short date") Then
                            If e.Node.GetValue("workComplete") = 100 Then
                            Else
                                e.Appearance.BackColor = Color.LightGreen
                            End If
                        End If

                    End If

                End If

            Else

                If IIf(IsDBNull(e.Node.GetValue("workComplete")), 0, e.Node.GetValue("workComplete")) <> 100 Then
                    'e.Appearance.BackColor = Color.LightGreen
                    e.Appearance.BackColor = Color.White
                End If

            End If

        End If

        If e.Column.FieldName = "ActualStatDate" Then

            If IsDBNull(e.CellValue) = True Then
                ' e.Appearance.BackColor = Color.White
            Else

                If Date.Today.Date.AddDays(1) >= Format$(e.CellValue, "short date") And Date.Today.Date < Format$(e.CellValue, "short date") Then
                    e.Appearance.BackColor = Color.Yellow
                End If

            End If

        End If

        If e.Column.FieldName = "priority" Then

            If e.CellValue >= 40 Then
                ' e.Appearance.BackColor = Color.Red
                e.Appearance.ForeColor = Color.Red
            End If

        End If

    End Sub

    Private Sub TreeList1_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList1.FocusedNodeChanged
        On Error Resume Next
        '导入选择任务的详细资料
        Dim dt As New DataTable
        Dim strSB As New System.Text.StringBuilder
        strSB.Append("select FollowSch,FollowDate,CumulativeTime,")
        strSB.Append(" (select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Schedule.FollowUID = ATL_HD_UserGroups.UserNo ) as FollowID ,")
        strSB.Append(" Remark from IT_Schedule where AssID = '" & e.Node.GetValue("assID") & "'")

        dt = getDataTables(strSB.ToString())
        Grid2.DataSource = dt

        If e.Node.GetValue("Evaluate") Is DBNull.Value Then
            MemoEdit1.Text = ""
        Else
            MemoEdit1.Text = e.Node.GetValue("Evaluate")
        End If
        dt.Dispose()
        strSB.Clear()
    End Sub



End Class
