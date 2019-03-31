Imports System.Data
Imports System.Data.SqlClient
Imports System.Threading

Public Class mdlPersonnelTask

    Dim td1 As Thread = Nothing
    Dim td2 As Thread = Nothing
    Dim td3 As Thread = Nothing
    Dim td4 As Thread = Nothing
    Dim td5 As Thread = Nothing
    Dim td6 As Thread = Nothing


#Region "委托传参"

    ''' <summary>
    ''' 公共委托绑定数据方法
    ''' </summary>
    ''' <param name="GridControl">Grid控件</param>
    ''' <param name="DataSource">DT数据集</param>
    ''' <remarks></remarks>
    Sub SetParameter(ByVal GridControl As DevExpress.XtraGrid.GridControl, ByVal DataSource As Object)
        Try
            If Not DataSource Is DBNull.Value Then
                GridControl.DataSource = DataSource
            Else
                GridControl.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

#End Region

    ''' <summary>
    ''' 获取个人任务
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadMyTasks()

        Try

            Dim dt As New DataTable

            Dim sql As String = Nothing

            sql = "select  a.*,(select PrjName from IT_Project  where IT_Project.ID =a.PrjID) as PrjName," &
                  " (select (select SchemeName from IT_Scheme where IT_Project.SchemeID =IT_Scheme.ID) as SchemeName from IT_Project  " &
                  " where IT_Project.ID =a.PrjID) as SchemeName,(select SUM(IT_Schedule.FollowSch) from IT_Schedule where " &
                  " IT_Schedule.AssID =a.ID) as workComplete from  it_assignment a  inner join IT_Project b on  a.PrjID =b.ID inner join IT_Scheme c on b.SchemeID =c.ID  where a.appointuid='" & UserID & "' " &
                  " and a.AssState not in ('27') or c.SmStatus='16'" ' and c.SmStatus='16'

            dt = getDataTables(sql)

            SetGridData = New SetGridViewDelegate(AddressOf Me.SetParameter)

            Me.Invoke(SetGridData, GridMyTasks, dt)

            dt.Dispose()

        Catch ex As Exception
            'MessageBox.Show("线程处理引发以下错误：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            td1.Abort()
        End Try

    End Sub


    ''' <summary>
    ''' 导入待个人审批任务
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadMyTaskCheck()
        Try
            Dim dt As New DataTable

            Dim strSB As New System.Text.StringBuilder

            'strSB.Append("select  *,")
            'strSB.Append("(select PrjName from IT_Project  where IT_Project.ID =IT_Assignment.PrjID) as PrjName, ")
            'strSB.Append(" (select (select SchemeName from IT_Scheme where IT_Project.SchemeID =IT_Scheme.ID) as SchemeName from IT_Project ")
            'strSB.Append(" where IT_Project.ID =IT_Assignment.PrjID) as SchemeName,(select SUM(IT_Schedule.FollowSch) ")
            'strSB.Append(" from IT_Schedule where  IT_Schedule.AssID =IT_Assignment.ID) as workComplete ")
            'strSB.Append(" from  it_assignment where AssState ='26' and PrjID in ")
            'strSB.Append(" (select ID from IT_Project where FollowUID ='" & UserID & "')")

            'dt = getDataTables(strSB.ToString())

            strSB.Append(String.Format("getWaitVerify '{0}'", UserID))

            dt = getDataTables(strSB.ToString())
            SetGridData = New SetGridViewDelegate(AddressOf Me.SetParameter)

            Me.Invoke(SetGridData, GridMyTaskCheck, dt)

            dt.Dispose()
            strSB.Clear()

        Catch ex As Exception
            'MessageBox.Show("线程处理引发以下错误：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            td4.Abort()
        End Try


    End Sub

    ''' <summary>
    ''' 导入个人模块
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadMySub()

        Try
            Dim dt As New DataTable

            Dim strSB As New System.Text.StringBuilder
            strSB.Append("select *,")
            strSB.Append("(select V_IT_Project.Progress from V_IT_Project where V_IT_Project.ID=IT_Project.ID) as workComplete ,")
            strSB.Append(" (select ProStatus from IT_ProStatus where IT_Project.PrjStatus=IT_ProStatus.ID ) as PrjStatusName,")
            strSB.Append("(select SchemeName from IT_Scheme where IT_Project.SchemeID=IT_Scheme.ID) as SchemeName ")
            strSB.Append("from IT_Project  where FollowUID='" & UserID & "'  and PrjStatus <>'27' order by FollowUID")

            dt = getDataTables(strSB.ToString())
            Dim dv As DataView = dt.DefaultView
            dv.RowFilter = "workComplete<100"
            SetGridData = New SetGridViewDelegate(AddressOf Me.SetParameter)

            Me.Invoke(SetGridData, GridMySub, dv)

            dt.Dispose()

            strSB.Clear()

        Catch ex As Exception
            ' MessageBox.Show("线程处理引发以下错误：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            td2.Abort()
        End Try

    End Sub

    ''' <summary>
    ''' 导入个人项目
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadMyProject()

        Try

            Dim dt As New DataTable
            Dim strSB As New System.Text.StringBuilder

            strSB.Append("select ID,SchemeName  ,")
            strSB.Append("(select Progress FROM V_IT_Scheme where V_IT_Scheme.ID = IT_Scheme.ID ) as complete, ")
            strSB.Append(" (select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_Scheme.SmStatus) as ssStatus ")
            strSB.Append(" from IT_Scheme where  SmStatus not in('17','19') and SmFollow='" & UserID & "' order by id")

            dt = getDataTables(strSB.ToString())

            SetGridData = New SetGridViewDelegate(AddressOf Me.SetParameter)

            Me.Invoke(SetGridData, GridMyProject, dt)

            dt.Dispose()

            strSB.Clear()

        Catch ex As Exception
            'MessageBox.Show("线程处理引发以下错误：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            td3.Abort()
        End Try

    End Sub

    ''' <summary>
    ''' 导入个人待办事项
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadMyToDo()

        Try
            Dim dt As New DataTable
            Dim strSB As New System.Text.StringBuilder

            strSB.Append("select *,(select IT_Scheme.SchemeName from IT_Scheme where IT_Scheme.ID=IT_ToDo.SchemeID) as SchemeName,")
            strSB.Append(" (select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_ToDo.TD_Context) as ContextName ")
            strSB.Append(" from IT_ToDo where TD_UserNo='" & UserID & "'  and TD_Complete=0 order by TD_ID DESC")

            dt = getDataTables(strSB.ToString())

            SetGridData = New SetGridViewDelegate(AddressOf Me.SetParameter)

            Me.Invoke(SetGridData, GridMyToDo, dt)

            dt.Dispose()

            strSB.Clear()

        Catch ex As Exception
            'MessageBox.Show("线程处理引发以下错误：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            td5.Abort()
        End Try

    End Sub
    ''' <summary>
    ''' 个人待处理Bug
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadMyBug()

        On Error Resume Next

        Dim strSB As New System.Text.StringBuilder

        strSB.Append("select IT_DevelopBugManager.*,IT_SystemNameManager.SystemName,IT_SystemNameManager.SystemID ")
        strSB.Append(" from IT_DevelopBugManager, IT_SystemNameManager ")
        strSB.Append(" where IT_SystemNameManager.SystemID=IT_DevelopBugManager.SysProID and ")
        strSB.Append(" IT_SystemNameManager.SystemName=IT_DevelopBugManager.SysProName and ")
        strSB.Append(" (ByDesigneeJog='" & UserID & "' or ResultsConfirmJob='" & UserID & "') and CurrentStatus<>'已验收'")

        Dim dt As New DataTable

        dt = getDataTables(strSB.ToString())

        If dt.Rows.Count > 0 Then

            Dim i As Integer

            For i = dt.Rows.Count - 1 To 0 Step -1

                If dt.Rows(i)("CurrentStatus") = "待回覆" Then
                    If dt.Rows(i)("ByDesigneeJog").ToString() <> UserID Then
                        dt.Rows.RemoveAt(i)
                    End If
                End If

                If dt.Rows(i)("CurrentStatus") = "待验收" Then
                    If dt.Rows(i)("ResultsConfirmJob").ToString() <> UserID Then
                        dt.Rows.RemoveAt(i)
                    End If
                End If

            Next

        End If

        GridMyBug.DataSource = dt
        strSB.Clear()

    End Sub

    ''' <summary>
    ''' 保存新增数据
    ''' </summary>
    ''' <param name="strName"></param>
    ''' <remarks></remarks>
    Sub SaveNewToDo(ByVal strName As String)

        Dim sql As String = Nothing
        sql = "INSERT INTO IT_ToDo (TD_Name,TD_Label,TD_UserNo,CreatedTime,TD_Complete) Values (" _
        & "'" & strName & "','0','" & UserID & "','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "',0)"

        Try
            ExecuteNonQuery(sql)
        Catch

        End Try

    End Sub
    ''' <summary>
    ''' 检查当前增加待办事是否已经存在
    ''' </summary>
    ''' <param name="strName">项目名称</param>
    ''' <returns>返回一个Bool值，true表示已经存在，false表示不存在</returns>
    ''' <remarks></remarks>
    Function checkValue(ByVal strName As String) As Boolean

        Application.DoEvents()
        Dim sql As String = Nothing
        result = True
        sql = "select * from IT_ToDo where TD_Name='" & strName & "' and TD_Complete='0'"

        Try
            Dim i As Integer
            i = ExecuteScalar(sql)
            If i > 0 Then
                result = True
            Else
                result = False
            End If
        Catch ex As Exception
            result = False
        End Try

        Return result

    End Function

    Private Sub mdlPersonnelTask_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Application.DoEvents()

        If IsLeader Or IsProjectManager Then
            '' 待审核任务
            td4 = New Thread(AddressOf LoadMyTaskCheck)
            td4.Start()
            Thread.Sleep(10)
            '' 个人模块
            td2 = New Thread(AddressOf LoadMySub)
            td2.Start()
            Thread.Sleep(10)
            '' 个人项目
            td3 = New Thread(AddressOf LoadMyProject)
            td3.Start()
            Thread.Sleep(10)

        Else
            SplitContainerControl5.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            SplitContainerControl2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        End If

        '' 个人任务
        td1 = New Thread(AddressOf LoadMyTasks)
        td1.Start()
        Thread.Sleep(10)

        '' 个人待办事项
        td5 = New Thread(AddressOf LoadMyToDo)
        td5.Start()
        Thread.Sleep(10)

        '' 个人待处理Bug
        loadMyBug()

    End Sub

    Private Sub GridMyTasks_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridMyTasks.DoubleClick

        If GridView1.RowCount = 0 Or Len(GridView1.GetFocusedRowCellValue("ID")) = 0 Then Exit Sub
        isRefresh = False
        Edit = False
        strType = "任务"
        Dim frm As New frmProjectTasksProgress
        frm.labID.Text = GridView1.GetFocusedRowCellValue("ID")
        frm.labName.Text = GridView1.GetFocusedRowCellValue("SchemeName") & "[" & GridView1.GetFocusedRowCellValue("PrjName") & "]"
        frm.ShowDialog()

        If Not isRefresh Then Exit Sub

        '' 个人任务
        td1 = New Thread(AddressOf LoadMyTasks)
        td1.Start()
        Thread.Sleep(10)

        '' 待审核任务
        td4 = New Thread(AddressOf LoadMyTaskCheck)
        td4.Start()
        Thread.Sleep(10)

    End Sub

    Private Sub GridMyProject_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridMyProject.DoubleClick

        If GridView3.RowCount = 0 Then Exit Sub
        isRefresh = False
        Dim frm As New frmProjectDetail
        frm.txtID.Text = Me.GridView3.GetFocusedRowCellValue("ID")
        frm.ShowDialog()

        '' 是否刷新数据
        If Not isRefresh Then Exit Sub

        LoadMyProject()


    End Sub

    Private Sub GridView1_EndGrouping(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.EndGrouping
        GridView1.ExpandAllGroups()
    End Sub

    Private Sub GridView4_EndGrouping(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView4.EndGrouping
        GridView4.ExpandAllGroups()
    End Sub

    Private Sub GridView5_EndGrouping(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView5.EndGrouping
        GridView5.ExpandAllGroups()
    End Sub

    Private Sub GridView7_EndGrouping(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView7.EndGrouping
        GridView7.ExpandAllGroups()
    End Sub

    Private Sub GridMyTaskCheck_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridMyTaskCheck.DoubleClick

        If GridView4.RowCount = 0 Or Len(GridView4.GetFocusedRowCellValue("ID")) = 0 Then Exit Sub

        Edit = True

        strType = "评分"

        isRefresh = False

        Dim frm As New frmProjectTasksProgress

        frm.labID.Text = GridView4.GetFocusedRowCellValue("ID")
        'frm.txtAppointUid_1.Text = GridView4.GetFocusedRowCellValue("followman")
        '2016-07-31 16:53 Dave
        frm.txtAppointUid_1.Text = GridView4.GetFocusedRowCellValue("followID")

        '' 评分标准
        If GridView4.GetFocusedRowCellValue("GS_ID") Is DBNull.Value Then
            frm.labGS_ID.Text = 2
        Else
            frm.labGS_ID.Text = GridView4.GetFocusedRowCellValue("GS_ID")
        End If
        If GridView4.GetFocusedRowCellValue("SchemeName").ToString().Contains("(终审)") Then
            frm.labName.Text = GridView4.GetFocusedRowCellValue("SchemeName")
        Else
            frm.labName.Text = GridView4.GetFocusedRowCellValue("SchemeName") & "[" & GridView4.GetFocusedRowCellValue("PrjName") & "]"
        End If

        frm.ShowDialog()

        '' 是否刷新数据
        If Not isRefresh Then Exit Sub

        '刷新待审任务
        td4 = New Thread(AddressOf LoadMyTaskCheck)
        td4.Start()

    End Sub

    Private Sub GridMySub_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridMySub.DoubleClick

        '导入模块
        If GridView5.RowCount = 0 Or Len(GridView5.GetFocusedRowCellValue("ID")) = 0 Then Exit Sub
        Edit = False
        isRefresh = False
        Dim frm As New frmProjectSubDetail
        frm.txtID.Text = GridView5.GetFocusedRowCellValue("ID")
        frm.ShowDialog()

        '' 是否刷新数据
        If Not isRefresh Then Exit Sub

        '' 个人待办事项
        td2 = New Thread(AddressOf LoadMySub)
        td2.Start()

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        If RadioButton1.Checked = True Then
            '本月时间
            Dim xx As New mdlPerWorkTime
            DeleteTempControls()
            xx.Top = 20
            xx.Dock = System.Windows.Forms.DockStyle.Fill
            GroupControl5.Controls.Add(xx)

        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged

        If RadioButton3.Checked = True Then
            '本月时间
            Dim xx As New mdlPerDimensionality
            DeleteTempControls()
            xx.Top = 20
            xx.Dock = System.Windows.Forms.DockStyle.Fill
            GroupControl5.Controls.Add(xx)
        End If

    End Sub

    ''' <summary>
    ''' 清除控件
    ''' </summary>
    ''' <remarks></remarks>
    Sub DeleteTempControls()

        Dim ctrl As Control
        Dim i As Integer
        For i = 1 To Me.GroupControl5.Controls.Count

            For Each ctrl In Me.GroupControl5.Controls

                Try

                    If TypeOf (ctrl) Is mdlPerWorkTime Or TypeOf (ctrl) Is mdlPerDimensionality Or TypeOf (ctrl) Is mdlPerContent Then
                        GroupControl5.Controls.Remove(ctrl)
                    End If

                Catch ex As Exception
                    ' MessageBox.Show(ex.Message, "请注意", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End Try

            Next

        Next

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked = True Then
            '本月时间
            Dim xx As New mdlPerContent
            DeleteTempControls()
            xx.Top = 20
            xx.Dock = System.Windows.Forms.DockStyle.Fill
            GroupControl5.Controls.Add(xx)

        End If

    End Sub

    Private Sub chkComplete_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkComplete.CheckedChanged

        If chkComplete.ValueChecked = True Then
            '完成任务UpdateToDoComplete
            UpdateToDoComplete(GridView2.GetFocusedRowCellValue("TD_ID"))
            '隐藏此记录
            GridView2.DeleteSelectedRows()
        End If

    End Sub

    ''' <summary>
    ''' 保存修改资料
    ''' </summary>
    ''' <param name="strId">Id_id</param>
    ''' <remarks></remarks>
    Function UpdateToDoComplete(ByVal strId As String) As Boolean

        result = True
        Dim sql As String = Nothing
        sql = "UPDATE IT_ToDo SET TD_Complete=1,TD_CompleteDate='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "' WHERE " _
            & "TD_ID='" & strId & "'"

        Try
            ExecuteNonQuery(sql)
        Catch
            result = False
        End Try

        Return result

    End Function
    '' 编辑待办事项
    Private Sub GridMyToDo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridMyToDo.DoubleClick

        If GridView2.RowCount = 0 Or Len(GridView2.GetFocusedRowCellValue("TD_ID")) = 0 Then Exit Sub

        Edit = True

        isRefresh = False

        '' 显示编辑窗体
        frmMyTasks.txtID.Text = GridView2.GetFocusedRowCellValue("TD_ID")
        frmMyTasks.ShowDialog()

        Try
            '' 是否刷新数据
            If Not isRefresh Then Exit Sub

            '' 个人待办事项
            td5 = New Thread(AddressOf LoadMyToDo)
            td5.Start()

        Catch ex As Exception

            ' MessageBox.Show("未知错误，请将此问题反馈到管理员处，谢谢？" & vbCrLf & ex.Message,
            '"项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    '' 回车增加待办事项
    Private Sub txtToDoName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtToDoName.KeyDown

        If e.KeyCode = Keys.Enter Then

            If Len(txtToDoName.Text) = 0 Then Exit Sub

            If checkValue(txtToDoName.Text) Then
                txtToDoName.Focus()
                txtToDoName.SelectAll()
                MessageBox.Show("待办事项[" & txtToDoName.Text & "]已存在？", "项目管理系统",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            ''保存记录
            SaveNewToDo(txtToDoName.Text)

            '' 载入新数据
            LoadMyToDo()

            txtToDoName.Text = ""
            txtToDoName.Focus()

        End If

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged

        If RadioButton4.Checked = True Then
            GridView2.Columns("ContextName").GroupIndex = 0
            GridView2.Columns("SchemeName").GroupIndex = -1
        End If

    End Sub

    Private Sub GridView2_EndGrouping(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView2.EndGrouping
        GridView2.ExpandAllGroups()
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        'On Error Resume Next
        If RadioButton6.Checked = True Then
            GridView2.Columns("ContextName").GroupIndex = -1
            GridView2.Columns("SchemeName").GroupIndex = 0
            GridView2.Columns("SchemeName").SortOrder = SortOrder.Descending
        End If

    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged

        If RadioButton5.Checked = True Then
            GridView2.Columns("ContextName").GroupIndex = -1
            GridView2.Columns("SchemeName").GroupIndex = -1
        End If
    End Sub

    '' 刷新个人视图
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        '' 个人任务
        td1 = New Thread(AddressOf LoadMyTasks)
        td1.Start()
        Thread.Sleep(10)
    End Sub
    ''刷新跟进模块
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        '' 个人模块
        td2 = New Thread(AddressOf LoadMySub)
        td2.Start()
        Thread.Sleep(10)
    End Sub
    '刷新待审任务
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Thread.Sleep(10)
        '' 待审核任务
        td4 = New Thread(AddressOf LoadMyTaskCheck)
        td4.Start()
        Thread.Sleep(10)
    End Sub
    '' 刷新个人待办事项
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        '' 个人待办事项
        td5 = New Thread(AddressOf LoadMyToDo)
        td5.Start()
    End Sub
    '' 刷新个人跟进项目 
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        '' 个人项目
        td3 = New Thread(AddressOf LoadMyProject)
        td3.Start()
    End Sub
    '' 刷新待修复Bug任务
    Private Sub btRefBug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRefBug.Click
        '' 个人待处理Bug
        loadMyBug()

    End Sub
    '' 双击管理Bug管理
    Private Sub GridMyBug_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridMyBug.DoubleClick

        If GridView7.RowCount = 0 Or Len(GridView7.GetFocusedRowCellValue("AutoID")) = 0 Then Exit Sub

        Dim getResult As String = GridView7.GetFocusedRowCellValue("CurrentStatus").ToString().Trim()

        Dim autoid As String = GridView7.GetFocusedRowCellValue("AutoID")

        Dim ProjectID As String = GridView7.GetFocusedRowCellValue("SysProID")

        isRefresh = False

        Select Case getResult

            Case "待指派"

                Dim xx As New BugEntry
                xx.isDesignate = True
                xx.AutoID = autoid
                xx.ProjectID = ProjectID
                xx.CurrentStatus = "待指派"
                xx.ToolTip.Text = "双击预览附件"
                xx.Text = "Bug管理[指派模式]"
                xx.ShowDialog()

            Case "待回覆"

                Dim xx As New Designate
                xx.AutoID = autoid
                xx.sysID = ProjectID
                xx.Text = "Bug管理[Bug异常回覆模式]"
                xx.ShowDialog()

            Case "待验收"

                Dim xx As New ResultsConfirm
                xx.autoID = autoid
                xx.sysID = ProjectID
                xx.Text = "Bug管理[Bug修复结果确认]"
                xx.ShowDialog()

        End Select

        If Not isRefresh Then Exit Sub

        '' 个人待处理Bug
        loadMyBug()

    End Sub


End Class
