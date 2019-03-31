Imports System.Data
Imports System.Data.SqlClient

Public Class mdlGanttDetail



    Private Sub mdlGanttDetail_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        SplitContainerControl1.Visible = False

        SchedulerControl2.Start = dteDate

        '' 加载人员
        localLognUser()

        Select Case strGanttType
            Case "项目"
                GeneratePersonalView(UserID)
            Case "详细"
                LoadProjectSub(strProjectID)
        End Select

        SplitContainerControl1.Visible = True

        GeneratePersonalView(UserID)

        AddHandler LUtxtID.EditValueChanged, AddressOf txtIDEditValueChanged

    End Sub

#Region "数据绑定"

    ''' <summary>
    ''' 导入所有项目模块
    ''' </summary>
    ''' <param name="ProjectID"></param>
    ''' <remarks></remarks>
    Sub LoadProjectSub(ByVal ProjectID As String)
        Try

            Dim lngCount As Long
            Dim dt As New DataTable
            Dim strSB As New System.Text.StringBuilder
            '实际开始\结束时间'
            'sql = "select null as ActualStatDate,null as AchualEndDate,null as TotalTime, null as AssGrade,Explain as Evaluate, PrjName as IDName,'0' as PID,ID+ '111111111' as CID, PrincipalUID,(select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Project.FollowUID = ATL_HD_UserGroups.UserNo ) as FollowUID,cast(Priority as nvarchar(50)) as priority,0 as assID,(select V_IT_Project.Progress from V_IT_Project where V_IT_Project.ID=IT_Project.ID) as workComplete from IT_Project where SchemeID = '" & ProjectID & "' "
            'sql = sql + "  UNION select ActualStatDate,AchualEndDate,(select SUM(IT_Schedule.CumulativeTime) from IT_Schedule where IT_Schedule.AssID =IT_Assignment.ID) as TotalTime, AssGrade,Evaluate, AssName as IDName,PrjID + '111111111' as PID,ID + '222222222' as CID, (select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Assignment.AppointUid = ATL_HD_UserGroups.UserNo ) as PrincipalUID,(select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Assignment.AppointUid = ATL_HD_UserGroups.UserNo ) as FollowUID,(select ATL_HD_Emergency.Value from ATL_HD_Emergency where ATL_HD_Emergency.Value=IT_Assignment.Emergency) as priority,ID AS assID,(select SUM(IT_Schedule.FollowSch) from IT_Schedule where IT_Schedule.AssID =IT_Assignment.ID) as workComplete from IT_Assignment where PrjID in (select ID as CID from IT_Project where SchemeID ='" & ProjectID & "') order by CID asc "
            '更换为计划开始\结束时间
            strSB.Append("select null as PreStatDate,null as PreEndDate,null as ActualStatDate,null as AchualEndDate,null as TotalTime,")
            strSB.Append(" null as AssGrade,Explain as Evaluate, PrjName as IDName,'0' as PID,ID+ '111111111' as CID, PrincipalUID,")
            strSB.Append(" (select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Project.FollowUID = ATL_HD_UserGroups.UserNo ) as FollowUID,")
            strSB.Append(" cast(Priority as nvarchar(50)) as priority,0 as assID,'")
            strSB.Append(" (select V_IT_Project.Progress from V_IT_Project where V_IT_Project.ID=IT_Project.ID) as workComplete")
            strSB.Append(" from IT_Project where SchemeID = '" & ProjectID & "' ")
            strSB.Append(" UNION select PreStatDate,PreEndDate,ActualStatDate,AchualEndDate,")
            strSB.Append(" (select SUM(IT_Schedule.CumulativeTime) from IT_Schedule where IT_Schedule.AssID =IT_Assignment.ID) as TotalTime, ")
            strSB.Append(" AssGrade,Evaluate, AssName as IDName,PrjID + '111111111' as PID,ID + '222222222' as CID,")
            strSB.Append(" (select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Assignment.AppointUid = ATL_HD_UserGroups.UserNo ) as PrincipalUID,")
            strSB.Append(" (select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Assignment.AppointUid = ATL_HD_UserGroups.UserNo ) as FollowUID,")
            strSB.Append(" (select ATL_HD_Emergency.Value from ATL_HD_Emergency where ATL_HD_Emergency.Value=IT_Assignment.Emergency) as priority,ID AS assID,")
            strSB.Append(" (select SUM(IT_Schedule.FollowSch) from IT_Schedule where IT_Schedule.AssID =IT_Assignment.ID) as workComplete ")
            strSB.Append(" from IT_Assignment where PrjID in (select ID as CID from IT_Project where SchemeID ='" & ProjectID & "') order by CID asc ")

            dt = getDataTables(strSB.ToString())
            strSB.Clear()
            lngCount = dt.Rows.Count

            If lngCount > 0 Then
                For i As Integer = 0 To lngCount - 1
                    '    Dim rs = ds.Tables("Resources").NewRow
                    '    rs("Id") = CLng(dst.Tables("Project").Rows(i).Item("CID").ToString)
                    '    rs("ParentId") = CLng(dst.Tables("Project").Rows(i).Item("PID").ToString)
                    '    rs("Description") = dst.Tables("Project").Rows(i).Item("IDName")
                    '    rs("DaysPlanned") = 2
                    '    ds.Tables("Resources").Rows.Add(rs)

                    Dim rs1 = ds.Tables("Resources").NewRow
                    rs1("Id") = CLng(dt.Rows(i).Item("CID").ToString)
                    rs1("ParentId") = CLng(dt.Rows(i).Item("PID").ToString)
                    rs1("Description") = dt.Rows(i).Item("IDName")
                    rs1("DaysPlanned") = 2
                    ds.Tables("Resources").Rows.Add(rs1)

                    If dt.Rows(i).Item("PID").ToString <> "0" Then

                        Dim rs = ds.Tables("Tasks").NewRow
                        rs("Id") = CLng(dt.Rows(i).Item("CID").ToString)
                        rs("ResourceId") = CLng(dt.Rows(i).Item("CID").ToString)
                        rs("Subject") = dt.Rows(i).Item("IDName")
                        rs("Description") = dt.Rows(i).Item("Evaluate")
                        rs("StartTime") = CDate(dt.Rows(i).Item("PreStatDate").ToString)
                        rs("EndTime") = CDate(dt.Rows(i).Item("PreEndDate").ToString)
                        rs("AllDay") = True
                        rs("Label") = 3
                        rs("Location") = ""
                        rs("PercentComplete") = CLng(dt.Rows(i).Item("workComplete").ToString)
                        rs("RecurrenceInfo") = ""
                        rs("ReminderInfo") = ""
                        rs("EventType") = 0
                        ds.Tables("Tasks").Rows.Add(rs)

                    End If

                Next

            End If
            dt.Dispose()
        Catch ex As Exception
            MessageBox.Show("操作收发异常:" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub

    Sub LoadProjectTasks(ByVal ProjectID As String)
        '导入所有项目模块

        Dim lngCount As Long
        Dim dt As New DataTable
        Dim strSB As New System.Text.StringBuilder
        'sql = "select null as ActualStatDate,null as AchualEndDate,null as TotalTime, null as AssGrade,Explain as Evaluate, PrjName as IDName,'0' as PID,ID+ '111111111' as CID, PrincipalUID,(select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Project.FollowUID = ATL_HD_UserGroups.UserNo ) as FollowUID,cast(Priority as nvarchar(50)) as priority,0 as assID,(select V_IT_Project.Progress from V_IT_Project where V_IT_Project.ID=IT_Project.ID) as workComplete from IT_Project where SchemeID = '" & ProjectID & "' "
        'sql = sql + "  UNION select ActualStatDate,AchualEndDate,(select SUM(IT_Schedule.CumulativeTime) from IT_Schedule where IT_Schedule.AssID =IT_Assignment.ID) as TotalTime, AssGrade,Evaluate, AssName as IDName,PrjID + '111111111' as PID,ID + '222222222' as CID, (select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Assignment.AppointUid = ATL_HD_UserGroups.UserNo ) as PrincipalUID,(select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Assignment.AppointUid = ATL_HD_UserGroups.UserNo ) as FollowUID,(select ATL_HD_Emergency.Value from ATL_HD_Emergency where ATL_HD_Emergency.Value=IT_Assignment.Emergency) as priority,ID AS assID,(select SUM(IT_Schedule.FollowSch) from IT_Schedule where IT_Schedule.AssID =IT_Assignment.ID) as workComplete from IT_Assignment where PrjID in (select ID as CID from IT_Project where SchemeID ='" & ProjectID & "') order by CID asc "
        Try
            strSB.Append("select null as PreStatDate,null as PreEndDate,null as ActualStatDate,null as AchualEndDate,null as TotalTime,")
            strSB.Append(" null as AssGrade,Explain as Evaluate, PrjName as IDName,'0' as PID,ID+ '111111111' as CID, PrincipalUID,")
            strSB.Append(" (select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Project.FollowUID = ATL_HD_UserGroups.UserNo ) as FollowUID,")
            strSB.Append(" cast(Priority as nvarchar(50)) as priority,0 as assID,")
            strSB.Append(" (select V_IT_Project.Progress from V_IT_Project where V_IT_Project.ID=IT_Project.ID) as workComplete")
            strSB.Append(" from IT_Project where SchemeID = '" & ProjectID & "' ")

            strSB.Append("  UNION select PreStatDate,PreEndDate,ActualStatDate,AchualEndDate,")
            strSB.Append(" (select SUM(IT_Schedule.CumulativeTime) from IT_Schedule where IT_Schedule.AssID =IT_Assignment.ID) as TotalTime, ")
            strSB.Append(" AssGrade,Evaluate, AssName as IDName,PrjID + '111111111' as PID,ID + '222222222' as CID, ")
            strSB.Append(" (select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Assignment.AppointUid = ATL_HD_UserGroups.UserNo ) as PrincipalUID,")
            strSB.Append(" (select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Assignment.AppointUid = ATL_HD_UserGroups.UserNo ) as FollowUID,")
            strSB.Append(" (select ATL_HD_Emergency.Value from ATL_HD_Emergency where ATL_HD_Emergency.Value=IT_Assignment.Emergency) as priority,")
            strSB.Append(" ID AS assID,(select SUM(IT_Schedule.FollowSch) from IT_Schedule where IT_Schedule.AssID =IT_Assignment.ID) as workComplete")
            strSB.Append(" from IT_Assignment where PrjID in (select ID as CID from IT_Project where SchemeID ='" & ProjectID & "') order by CID asc ")

            dt = getDataTables(strSB.ToString())
            strSB.Clear()
            lngCount = dt.Rows.Count

            If lngCount > 0 Then
                For i As Integer = 0 To lngCount - 1
                    If dt.Rows(i).Item("PID").ToString <> "0" Then
                        Dim rs = ds.Tables("Tasks").NewRow
                        rs("Id") = CLng(dt.Rows(i).Item("CID").ToString)
                        rs("ResourceId") = CLng(dt.Rows(i).Item("CID").ToString)
                        rs("Subject") = dt.Rows(i).Item("IDName")
                        rs("Description") = dt.Rows(i).Item("Evaluate")
                        rs("StartTime") = CDate(dt.Rows(i).Item("PreStatDate").ToString)
                        rs("EndTime") = CDate(dt.Rows(i).Item("PreEndDate").ToString)
                        rs("AllDay") = True
                        rs("Label") = 3
                        rs("Location") = ""
                        rs("PercentComplete") = CLng(dt.Rows(i).Item("workComplete").ToString)
                        rs("RecurrenceInfo") = ""
                        rs("ReminderInfo") = ""
                        rs("EventType") = 0
                        ds.Tables("Tasks").Rows.Add(rs)
                    End If
                Next

            End If
            dt.Dispose()
        Catch ex As Exception
            MessageBox.Show("操作收发异常:" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    ''' <summary>
    ''' 生成个人视图
    ''' </summary>
    ''' <param name="Uid">用户工号</param>
    ''' <remarks></remarks>
    Sub GeneratePersonalView(ByVal Uid As String)

        Dim strSB As New System.Text.StringBuilder

        strSB.Append("select * ,")
        strSB.Append("(select Progress FROM V_IT_Scheme where V_IT_Scheme.ID = IT_Scheme.ID ) as complete, ")
        strSB.Append("(select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Scheme.SmFollow = ATL_HD_UserGroups.UserNo ) as SmFollow1,")
        strSB.Append("(select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_Scheme.SmType) as sm1Type, ")
        strSB.Append("(select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_Scheme.SmStatus) as sm1Status, ")
        strSB.Append("(select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_Scheme.Important) as important1, ")
        strSB.Append("(select ATL_HD_Emergency.Value from ATL_HD_Emergency where ATL_HD_Emergency.Value=IT_Scheme.Emergency) as emergency1 ")
        strSB.Append("  from IT_Scheme where SmPrincipal='" & Uid & "'")

        LoadProject(strSB.ToString())

        strSB.Clear()

    End Sub

    ''' <summary>
    ''' 生成所有视图
    ''' </summary>
    ''' <remarks></remarks>
    Sub GenerateAllView()

        Dim strSB As New System.Text.StringBuilder

        strSB.Append("select * ,")
        strSB.Append("(select Progress FROM V_IT_Scheme where V_IT_Scheme.ID = IT_Scheme.ID ) as complete, ")
        strSB.Append("(select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Scheme.SmFollow = ATL_HD_UserGroups.UserNo ) as SmFollow1,")
        strSB.Append("(select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_Scheme.SmType) as sm1Type, ")
        strSB.Append("(select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_Scheme.SmStatus) as sm1Status, ")
        strSB.Append("(select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_Scheme.Important) as important1, ")
        strSB.Append("(select ATL_HD_Emergency.Value from ATL_HD_Emergency where ATL_HD_Emergency.Value=IT_Scheme.Emergency) as emergency1 ")
        strSB.Append(" from IT_Scheme")

        LoadProject(strSB.ToString())

        strSB.Clear()

    End Sub

    Sub LoadProject(ByVal sql As String)

        '导入所有项目
        Dim lngCount As Long = 0
        Dim dt As New DataTable

        SchedulerStorage1.AppointmentDependencies.Clear()
        SchedulerStorage1.Appointments.Clear()
        SchedulerStorage1.Resources.Clear()
        proControl.Properties.Maximum = 0
        proControl.Text = 0

        dt = getDataTables(sql)

        lngCount = dt.Rows.Count

        If lngCount > 0 Then

            proControl.Properties.Minimum = 0
            proControl.Properties.Maximum = lngCount
            proControl.Properties.Step = 1
            proControl.Visible = True
            For i As Integer = 0 To lngCount - 1

                Dim rs1 = ds.Tables("Resources").NewRow
                rs1("Id") = CLng(dt.Rows(i).Item("ID").ToString)
                'rs1("ParentId") = CLng(dt.Rows(i).Item("PID").ToString)
                rs1("Description") = dt.Rows(i).Item("SchemeName")
                rs1("DaysPlanned") = 2
                ds.Tables("Resources").Rows.Add(rs1)


                Dim rs = ds.Tables("Tasks").NewRow
                rs("Id") = CLng(dt.Rows(i).Item("ID").ToString)
                rs("ResourceId") = CLng(dt.Rows(i).Item("ID").ToString)
                rs("Subject") = dt.Rows(i).Item("SchemeName")
                rs("Description") = dt.Rows(i).Item("Explain")
                rs("StartTime") = CDate(dt.Rows(i).Item("SmStartdate").ToString)
                rs("EndTime") = CDate(dt.Rows(i).Item("SmEndDate").ToString)
                rs("AllDay") = True
                rs("Label") = 3
                rs("Location") = ""
                rs("PercentComplete") = CLng(dt.Rows(i).Item("Complete").ToString)
                rs("RecurrenceInfo") = ""
                rs("ReminderInfo") = ""
                rs("EventType") = 0
                ds.Tables("Tasks").Rows.Add(rs)

                Application.DoEvents()
                proControl.PerformStep()
                proControl.Update()
                ''frmMain.LabelControl2.Text = "任务 " & dt.Rows(i).Item("SchemeName") & " 加载完成."
                Threading.Thread.Sleep(10)

            Next

        End If

        proControl.Visible = False
        dt.Dispose()
    End Sub
    Private Sub SchedulerControl2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles SchedulerControl2.DoubleClick

        On Error Resume Next

        Select Case strGanttType

            Case "项目"
                frmProjectDetail.txtID.Text = SchedulerControl2.SelectedAppointments.Item(0).Id
                frmProjectDetail.ShowDialog()

            Case "详细"
                frmProjectTasks.txtID.Text = Mid(SchedulerControl2.SelectedAppointments.Item(0).Id, 7)
                frmProjectTasks.ShowDialog()

        End Select
err:
        Exit Sub

    End Sub

    Private Sub SchedulerControl2_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PopupMenuShowingEventArgs) Handles SchedulerControl2.PopupMenuShowing
        e.Menu.Dispose()
    End Sub

    ''' <summary>
    ''' 载入所有用户
    ''' </summary>
    ''' <remarks></remarks>
    Sub localLognUser()

        Dim dt As New DataTable
        Dim sql As String = Nothing
        sql = "SELECT *  FROM ATL_HD_UserGroups WHERE ServiceTypeID='1' and IsDimission=0 Order By UserNo"

        dt = getDataTables(sql)

        LUtxtID.Properties.ValueMember = "UserName"
        LUtxtID.Properties.DisplayMember = "UserName"
        LUtxtID.Properties.DataSource = dt

        dt.Dispose()

    End Sub

#End Region

    '' 加载个人资料
    Sub txtIDEditValueChanged()

        Dim Uid As String
        Uid = LUtxtID.EditValue
        If Uid <> "" Then
            GeneratePersonalView(Uid.Trim())
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        If RadioButton1.Checked Then
            LUtxtID.Enabled = True
            LUtxtID.EditValue = Nothing
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked Then
            LUtxtID.Enabled = False
            RadioButton1.Enabled = False
            GenerateAllView()
            RadioButton1.Enabled = True
        End If

    End Sub
End Class
