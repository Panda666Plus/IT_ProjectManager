Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports DevExpress.XtraPrinting

Public Class frmProjectDetail

    Dim strID As String

#Region "载入数据"
    ''' <summary>
    ''' 导入项目主资料
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadProjectDetail()

        On Error Resume Next

        Dim strSB As New System.Text.StringBuilder
        strSB.Append("select * ,")
        strSB.Append(" (select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Scheme.SmFollow = ATL_HD_UserGroups.UserNo ) as SmFollow1,")
        strSB.Append(" (select ATL_HD_Company.CompanyName  from ATL_HD_Company where ATL_HD_Company.ID=IT_Scheme.Company ) as company1,")
        strSB.Append(" (select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_Scheme.SmType) as sm1Type,")
        strSB.Append(" (select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_Scheme.SmStatus) as sm1Status,")
        strSB.Append(" (select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_Scheme.Important) as important1,")
        strSB.Append(" (select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_Scheme.Emergency) as emergency1 ")
        strSB.Append(" from IT_Scheme where ID='" & strID & "'")
        Dim dt As New DataTable

        dt = getDataTables(strSB.ToString())

        If dt.Rows.Count <= 0 Then Exit Sub

        txtSchemeName.Text = dt.Rows(0)("SchemeName")
        txtSmStatus.Text = dt.Rows(0)("sm1Status")
        txtSmStartDate.Text = Format$(dt.Rows(0)("SmStartDate"), "Short date")
        txtSmEndDate.Text = Format$(dt.Rows(0)("SmEndDate"), "Short date")
        txtSmType.Text = dt.Rows(0)("sm1Type")
        txtSmFollow.Text = dt.Rows(0)("SmFollow1")
        txtSmPrincipal.Text = dt.Rows(0)("SmPrincipal")
        txtImport.Text = dt.Rows(0)("important1")
        txtEmergency.Text = dt.Rows(0)("emergency")
        txtCompany.Text = dt.Rows(0)("company1")
        txtDepartment.Text = dt.Rows(0)("Department")
        txtLinkman.Text = dt.Rows(0)("Linkman")
        editExplain.Text = dt.Rows(0)("Explain")

        dt.Dispose()
        strSB.Clear()
    End Sub

    ''' <summary>
    ''' 导入数据
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData()

        ''On Error Resume Next

        Dim dt As New DataTable

        Dim strSB As New System.Text.StringBuilder

        TreeList1.Nodes.Clear()
        If (IsProjectManager) Or (Isglobaluser) Or (txtSmPrincipal.Text = UserName) Or (txtSmFollow.Text = UserName) Then
            strSB.Append("select null as PreStatDate,null as PreEndDate,null as ActualStatDate,null as AchualEndDate,null as TotalTime, ")
            strSB.Append(" null as AssGrade,Explain as Evaluate, PrjName as IDName,'0' as PID,ID+ '111111111' as CID, PrincipalUID,")
            strSB.Append(" (select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Project.FollowUID = ATL_HD_UserGroups.UserNo ) as FollowUID,")
            strSB.Append(" cast(Priority as nvarchar(50)) as priority,0 as assID,(select V_IT_Project.Progress from V_IT_Project")
            strSB.Append(" where V_IT_Project.ID=IT_Project.ID) as workComplete from IT_Project where SchemeID = '" & strID & "' ")
            strSB.Append("  UNION select PreStatDate,PreEndDate,ActualStatDate,AchualEndDate,")
            strSB.Append(" (select SUM(IT_Schedule.CumulativeTime) from IT_Schedule where IT_Schedule.AssID =IT_Assignment.ID) as TotalTime, ")
            strSB.Append("AssGrade,Evaluate, AssName as IDName,PrjID + '111111111' as PID,ID + '222222222' as CID, ")
            strSB.Append("(select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Assignment.AppointUid = ATL_HD_UserGroups.UserNo ) as PrincipalUID,")
            strSB.Append("(select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Assignment.AppointUid = ATL_HD_UserGroups.UserNo ) as FollowUID,")
            strSB.Append("(select ATL_HD_Emergency.Value from ATL_HD_Emergency where ATL_HD_Emergency.Value=IT_Assignment.Emergency) as priority,")
            strSB.Append(" ID AS assID,(select SUM(IT_Schedule.FollowSch) from IT_Schedule where IT_Schedule.AssID =IT_Assignment.ID) as workComplete")
            strSB.Append(" from IT_Assignment where PrjID in (select ID as CID from IT_Project where SchemeID ='" & strID & "' ) order by CID asc ")
        Else
            strSB.Append("select null as PreStatDate,null as PreEndDate,null as ActualStatDate,null as AchualEndDate,null as TotalTime, ")
            strSB.Append(" null as AssGrade,Explain as Evaluate, PrjName as IDName,'0' as PID,ID+ '111111111' as CID, PrincipalUID,")
            strSB.Append(" (select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Project.FollowUID = ATL_HD_UserGroups.UserNo ) as FollowUID,")
            strSB.Append(" cast(Priority as nvarchar(50)) as priority,0 as assID,(select V_IT_Project.Progress from V_IT_Project")
            strSB.Append(" where V_IT_Project.ID=IT_Project.ID) as workComplete from IT_Project where SchemeID = '" & strID & "' and ( PrincipalUID='" & UserName & "' or   FollowUID='" & UserID & "') ")
            strSB.Append("  UNION select PreStatDate,PreEndDate,ActualStatDate,AchualEndDate,")
            strSB.Append(" (select SUM(IT_Schedule.CumulativeTime) from IT_Schedule where IT_Schedule.AssID =IT_Assignment.ID) as TotalTime, ")
            strSB.Append("AssGrade,Evaluate, AssName as IDName,PrjID + '111111111' as PID,ID + '222222222' as CID, ")
            strSB.Append("(select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Assignment.AppointUid = ATL_HD_UserGroups.UserNo ) as PrincipalUID,")
            strSB.Append("(select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Assignment.AppointUid = ATL_HD_UserGroups.UserNo ) as FollowUID,")
            strSB.Append("(select ATL_HD_Emergency.Value from ATL_HD_Emergency where ATL_HD_Emergency.Value=IT_Assignment.Emergency) as priority,")
            strSB.Append(" ID AS assID,(select SUM(IT_Schedule.FollowSch) from IT_Schedule where IT_Schedule.AssID =IT_Assignment.ID) as workComplete")
            strSB.Append(" from IT_Assignment where PrjID in (select ID as CID from IT_Project where SchemeID ='" & strID & "' and ( PrincipalUID='" & UserName.Trim & "' or   FollowUID='" & UserID & "') )  order by CID asc ")
        End If


        dt = getDataTables(strSB.ToString())

        If dt.Rows.Count <= 0 Then
            TreeList1.DataSource = Nothing
        Else
            TreeList1.DataSource = dt
            TreeList1.ExpandAll()
        End If

        dt.Dispose()
        strSB.Clear()

    End Sub

    ''' <summary>
    ''' 显示FTP文档管理显示
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadFiles()

        Try

            Dim tabPage As New FTPFilesManager
            GroupControl1.Controls.Clear()
            tabPage.Dock = System.Windows.Forms.DockStyle.Fill
            tabPage.xtype = True
            tabPage.SchemeName = txtSchemeName.Text
            GroupControl1.Controls.Add(tabPage)

        Catch ex As Exception
            MessageBox.Show("数据绑定异常:" & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

    Private Sub frmProjectDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        strID = txtID.Text

        Application.DoEvents()

        LoadProjectDetail()

        LoadData()

        LoadMyToDo()

        LoadFiles()

        AddHandler TreeList1.FocusedNodeChanged, AddressOf TreeListFocusedNodeChanged

    End Sub

    Private Sub TreeList1_CustomDrawNodeCell(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs) Handles TreeList1.CustomDrawNodeCell
        '依情况变动色彩
        If e.Column.FieldName = "AchualEndDate" Then
            If IsDBNull(e.CellValue) = False Then
                If Date.Today.Date > Format$(e.CellValue, "short date") Then
                    If e.Node.GetValue("workComplete") = 100 Then
                    Else
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
                If IIf(IsDBNull(e.Node.GetValue("workComplete")), 0, e.Node.GetValue("workComplete")) = 100 Then
                Else
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

    Sub TreeListFocusedNodeChanged()
        '导入选择任务的详细资料

        If TreeList1.FocusedNode Is Nothing Then Exit Sub

        Dim dt As New DataTable
        Dim strSB As New System.Text.StringBuilder

        Try

            strSB.Append("select FollowSch,FollowDate,CumulativeTime,")
            strSB.Append(" (select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Schedule.FollowUID = ATL_HD_UserGroups.UserNo ) as FollowID ,")
            strSB.Append(" Remark from IT_Schedule where AssID = '" & TreeList1.FocusedNode.GetValue("assID") & "'")

            dt = getDataTables(strSB.ToString())
            Grid1.DataSource = dt

            If TreeList1.FocusedNode.GetValue("Evaluate") Is DBNull.Value Then
                MemoEdit1.Text = Nothing
            Else
                MemoEdit1.Text = "备注:" & vbCrLf & TreeList1.FocusedNode.GetValue("Evaluate")
            End If

            dt = Nothing
            strSB.Clear()
            strSB.Append(" select TaskDetail from dbo.IT_Assignment where ID='" & CLng(TreeList1.FocusedNode.GetValue("CID")) - 222222222 & "'")
            dt = getDataTables(strSB.ToString())
            If dt.Rows.Count <= 0 Then Exit Sub

            If Not dt.Rows(0)("TaskDetail") Is DBNull.Value Then
                MemoEdit2.Text = "任务明细:" & vbCrLf & dt.Rows(0)("TaskDetail")
            Else
                MemoEdit2.Text = Nothing
            End If

        Catch ex As Exception
            ''MessageBox.Show("未知错误:" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        dt.Dispose()
        strSB.Clear()
    End Sub

    Private Sub pupAddSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pupAddSub.Click

        isRefresh = False

        Dim frm As New frmProjectSub
        Edit = False
        frm.txtID.Text = Me.txtID.Text    '项目编号
        frm.labName.Text = "新增模块" 'TreeList1.FocusedNode.GetValue("IDName")   '项目名称
        frm.ShowDialog()
        '刷新数据

        '' 决定是否需要刷新数据
        If Not isRefresh Then Exit Sub

        LoadData()

    End Sub

    Private Sub pupAddTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pupAddTask.Click

        '增加任务

        isRefresh = False

        Try
            Edit = False

            Dim frm As New frmProjectTasks

            If TreeList1.FocusedNode.GetValue("PID") = 0 Then
                frm.txtID.Text = CLng(TreeList1.FocusedNode.GetValue("CID")) - 111111111    '项目ID
            Else
                frm.txtID.Text = TreeList1.FocusedNode.GetValue("PID") - 111111111   '项目ID
            End If

            frm.Text = "添加任务"

            frm.labName.Text = TreeList1.FocusedNode.GetValue("IDName")   '项目名称
            frm.ShowDialog()


            '' 决定是否需要刷新数据
            If Not isRefresh Then Exit Sub
            '刷新数据
            LoadData()

        Catch
            ' MessageBox.Show(")
        End Try

    End Sub

    Private Sub pupEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pupEdit.Click

        isRefresh = False

        '修改
        If TreeList1.Nodes.Count = 0 Then
            MessageBox.Show("没有可操作数据？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Edit = True

        If TreeList1.FocusedNode.GetValue("PID") = 0 Then
            '模块，减111111111
            Dim frm As New frmProjectSub
            frm.txtID.Text = CLng(TreeList1.FocusedNode.GetValue("CID")) - 111111111
            frm.labName.Text = TreeList1.FocusedNode.GetValue("IDName")
            frm.cmdSave.Text = "修改"
            frm.Text = "修改模块"
            frm.ShowDialog()
        Else
            '任务,减222222222
            Dim frm As New frmProjectTasks
            frm.txtID.Text = CLng(TreeList1.FocusedNode.GetValue("CID")) - 222222222    '项目ID
            frm.labName.Text = TreeList1.FocusedNode.GetValue("IDName")   '项目名称
            frm.cmdSave.Text = "修改"
            frm.Text = "修改任务"
            frm.ShowDialog()

        End If

        '' 决定是否需要刷新数据
        If Not isRefresh Then Exit Sub

        '刷新数据
        LoadData()

    End Sub

    ''' <summary>
    ''' 导入个人待办事项s
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadMyToDo()

        On Error Resume Next

        Dim dt As New DataTable
        Dim strSB As New System.Text.StringBuilder

        strSB.Append("select *,")
        strSB.Append(" (select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where ATL_HD_UserGroups.UserNo=IT_ToDo.TD_UserNo ) as UserName ")
        strSB.Append(" from IT_ToDo where TD_UserNo='" & UserID & "' and SchemeID='" & txtID.Text & "' order by TD_CompleteDate")

        dt = getDataTables(strSB.ToString())

        If dt.Rows.Count > 0 Then

            GridMyToDo.DataSource = dt
        Else
            GridMyToDo.DataSource = Nothing

        End If

        dt.Dispose()
        strSB.Clear()
    End Sub

    Private Sub pupToExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pupToExcel.Click

        If TreeList1.Nodes.Count < 1 Then
            MessageBox.Show("没有可导出数据？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim savePath As New SaveFileDialog
        savePath.FileName = txtSchemeName.Text & ".xls"
        savePath.Title = "项目明细导出"
        savePath.Filter = "Excel File(*.xls)|*.xls"

        If savePath.ShowDialog() = DialogResult.OK Then
            Dim options As New XlsExportOptions()
            options.ShowGridLines = False
            options.TextExportMode = TextExportMode.Text
            options.ExportMode = XlsExportMode.SingleFile
            TreeList1.ExportToXls(savePath.FileName.ToString(), options)
            MessageBox.Show("数据导出成功！", "项目管理系统")
            StartApp(savePath.FileName, False)
        End If

    End Sub

    '' 删除
    Private Sub pupDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pupDel.Click

        Dim Cid As String = Nothing, IDname As String = Nothing

        Dim sql As String = Nothing

        IDname = TreeList1.FocusedNode.GetValue("IDName")   '项目名称

        If TreeList1.FocusedNode.GetValue("PID") = 0 Then
            '模块，减111111111
            Cid = CLng(TreeList1.FocusedNode.GetValue("CID")) - 111111111
            sql = " delete IT_Project where PrjName='" & IDname.Trim() & "' and ID='" & Cid.Trim() & "'"

        Else
            '任务,减222222222
            Cid = CLng(TreeList1.FocusedNode.GetValue("CID")) - 222222222    '项目ID
            sql = " delete IT_Assignment where AssName='" & IDname.Trim() & "' and ID='" & Cid.Trim() & "'"

        End If

        If Cid = "" Or IDname = "" Then
            MessageBox.Show("请选择需要删除任务", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If

        Dim result As DialogResult

        result = MessageBox.Show("您确定需要删除任务[" & IDname & "]记录吗？", "项目管理系统", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = DialogResult.No Then Exit Sub

        If ExecuteNonQuery(sql) <= 0 Then
            MessageBox.Show("删除失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("删除成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            '刷新数据
            LoadData()
        End If

    End Sub

    '' 更新数据
    Private Sub uploadData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uploadData.Click
        '刷新数据
        LoadData()
    End Sub

    Private Sub TreeList1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeList1.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Dim PrincipalUID As String = ""
            Dim FollowUID As String = ""
            If Not IsNothing(TreeList1.FocusedNode) Then
                FollowUID = TreeList1.FocusedNode.Item("FollowUID")
            End If
            If Not IsNothing(TreeList1.FocusedNode) Then
                If TreeList1.FocusedNode.Level = 0 Then
                    PrincipalUID = TreeList1.FocusedNode.Item("PrincipalUID")
                End If
                If TreeList1.FocusedNode.Level = 1 Then
                    PrincipalUID = TreeList1.FocusedNode.ParentNode.Item("PrincipalUID")
                End If
            End If
            If txtSmPrincipal.Text = UserName Or IsProjectManager Or PrincipalUID = UserName Then
                pupProjectDetail.Enabled = True
            Else
                pupProjectDetail.Enabled = False
            End If

            pupAddTask.Visible = True
            Dim SmPrincipal As String = DbServices.DbHelperSQL.Query(String.Format("select SmPrincipal from IT_Scheme where ID={0}",
                                                 txtID.Text)).Tables(0).Rows(0)(0)
            If (PrincipalUID = UserName) Or (txtSmFollow.Text.Trim() = UserName) Or
                (SmPrincipal = UserName) Or IsProjectManager Or Isglobaluser Or (FollowUID = UserName) Then
                pupAddTask.Visible = True
                If TreeList1.Nodes.Count <= 0 Then
                    pupEdit.Visible = False
                    pupDel.Visible = False
                    pupToExcel.Visible = False

                Else
                    pupAddSub.Visible = True
                    pupEdit.Visible = True
                    pupDel.Visible = True

                End If
                pupToExcel.Visible = True
                pupProjectDetail.Enabled = True
            Else
                pupAddTask.Visible = False
                pupAddSub.Visible = False
                pupEdit.Visible = False
                pupDel.Visible = False
                pupProjectDetail.Enabled = False
            End If

        End If

    End Sub


    Private Sub pupProjectDetail_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles pupProjectDetail.Opening

    End Sub
End Class