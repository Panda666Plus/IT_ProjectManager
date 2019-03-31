Public Class mdlTestProblems

    Dim modelID As Integer

    Dim td As Threading.Thread = Nothing

    Dim td2 As Threading.Thread = Nothing

    Private Sub mdlTestProblems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        td = New Threading.Thread(AddressOf LoadDataBugRate)
        td.Start()

        td2 = New Threading.Thread(AddressOf loadItem)
        td2.Start()

        '' 如果是管理员则显示指派页面，反之隐藏。
        If IsProjectManager Or IsLeader Or Testers Then
            SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
        Else
            SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        End If

    End Sub

#Region "载入所有绑定数据"

    ''' <summary>
    ''' 载入Bug率
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadDataBugRate()

        Try

            Dim dt As New DataTable

            Dim dt1 As New DataTable

            dt = bindingSelectData("待指派")

            Threading.Thread.Sleep(500)

            dt1 = bindingSelectData("已验收")

            SetGridData = New SetGridViewDelegate(AddressOf bindingData)

            Me.Invoke(SetGridData, GdConductItems, dt)

            Threading.Thread.Sleep(500)

            SetGridData = New SetGridViewDelegate(AddressOf bindingData)

            Me.Invoke(SetGridData, CompletedBugManager, dt1)

            dt.Dispose()

            dt1.Dispose()

        Catch ex As Exception
            'MessageBox.Show("线程引发以下异常：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'td.Join()
            td.Abort()
        End Try

    End Sub

    ''' <summary>
    ''' 加载所有进行中项目
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadItem()

        Try
            Dim strSB As New System.Text.StringBuilder
            strSB.Append("select IT_SystemNameManager.SystemName,IT_SystemNameManager.SystemID,IT_DevelopBugManager.*  ")
            strSB.Append(" from IT_SystemNameManager, IT_DevelopBugManager ")
            strSB.Append(" where IT_DevelopBugManager.SysProID = IT_SystemNameManager.SystemID ")
            strSB.Append(" and IT_DevelopBugManager.CurrentStatus<>'待指派' and ")
            strSB.Append(" IT_DevelopBugManager.CurrentStatus<>'已验收'")

            Dim dt As New DataTable

            dt = getDataTables(strSB.ToString())

            SetGridData = New SetGridViewDelegate(AddressOf bindingData)

            Me.Invoke(SetGridData, GridControl1, dt)

            dt.Dispose()
            strSB.Clear()

        Catch ex As Exception
            'MessageBox.Show("线程引发以下异常：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'td2.Join()
            td2.Abort()
        End Try

    End Sub


    ''' <summary>
    ''' 载入主数据
    ''' </summary>
    ''' <remarks></remarks>
    Function bindingSelectData(ByVal CurrentStatus As String) As DataTable


        Dim strSB As New System.Text.StringBuilder
        strSB.Append("  select IT_SystemNameManager.SystemName,IT_SystemNameManager.SystemID,IT_DevelopBugManager.*   ")
        strSB.Append(" from IT_SystemNameManager, IT_DevelopBugManager ")
        strSB.Append(" where IT_DevelopBugManager.SysProID = IT_SystemNameManager.SystemID ")
        strSB.Append(" and CurrentStatus='" & CurrentStatus & "'")

        bindingSelectData = getDataTables(strSB.ToString())
        strSB.Clear()
        Return bindingSelectData

    End Function

#End Region

    '' 导出excel
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        If GridView2.RowCount < 1 Then Exit Sub

        Dim save As New SaveFileDialog
        save.Filter = "Excel File(*.xlsx)|*.xlsx"
        save.FileName = "Bug管理"

        If save.ShowDialog = DialogResult.OK Then
            GridView2.ExportToXlsx(save.FileName)
            MessageBox.Show("导出数据成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            StartApp(save.FileName, False)
        End If

    End Sub

    '' 增加反馈数据
    Private Sub TestProAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestProAdd.Click

        isRefresh = False
        Dim xx As New BugEntry
        xx.Text = "Bug管理[数据录入模式]"
        xx.ShowDialog()

        '' 决定是否刷新数据
        If Not isRefresh Then Exit Sub

        td = New Threading.Thread(AddressOf LoadDataBugRate)
        td.Start()
        Threading.Thread.Sleep(100)

    End Sub

    '' 修改指定项目
    Private Sub GdSubjectDesignate_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GdConductItems.DoubleClick


        If GridView1.RowCount = 0 Or Len(GridView1.GetFocusedRowCellValue("AutoID")) = 0 Then Exit Sub

        '' 如果是测试人员不执行操作
        If Testers = True Then Exit Sub

        isRefresh = False

        Dim AutoID As String = GridView1.GetFocusedRowCellValue("AutoID")
        Dim ProjectID As String = GridView1.GetFocusedRowCellValue("SysProID")

        If AutoID = "" Or ProjectID = "" Then Exit Sub

        Dim xx As New BugEntry
        xx.TestEdit = True
        xx.CurrentStatus = "待指派"
        xx.isDesignate = True
        xx.AutoID = AutoID
        xx.ProjectID = ProjectID
        xx.ToolTip.Text = "双击预览附件"
        xx.Text = "Bug管理[任务指派]"
        xx.ShowDialog()

        '' 决定是否需要刷新数据
        If Not isRefresh Then Exit Sub

        td = New Threading.Thread(AddressOf LoadDataBugRate)
        td.Start()
        Threading.Thread.Sleep(500)

        td2 = New Threading.Thread(AddressOf loadItem)
        td2.Start()

    End Sub

#Region "grid数据管理"

    '' 显示任务进度状态
    Private Sub GridControl1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick

        If GridView3.RowCount = 0 Or Len(GridView3.GetFocusedRowCellValue("AutoID")) = 0 Then Exit Sub

        isRefresh = False

        Dim xx As New BugFixProgress
        xx.autoID = GridView3.GetFocusedRowCellValue("AutoID")
        xx.sysID = GridView3.GetFocusedRowCellValue("SysProID")
        xx.Text = "Bug管理[状态预览]"
        xx.ShowDialog()

        If Not isRefresh Then Exit Sub

        td2 = New Threading.Thread(AddressOf loadItem)
        td2.Start()
        Threading.Thread.Sleep(100)

    End Sub


    Private Sub GridView1_EndGrouping(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.EndGrouping
        GridView1.ExpandAllGroups()
    End Sub

#End Region

    '' 查看详细
    Private Sub CompletedBugManager_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompletedBugManager.DoubleClick

        If GridView2.RowCount = 0 Or Len(GridView2.GetFocusedRowCellValue("AutoID")) = 0 Then Exit Sub

        Dim xx As New BugFixProgress
        xx.autoID = GridView2.GetFocusedRowCellValue("AutoID")
        xx.sysID = GridView2.GetFocusedRowCellValue("SysProID")
        xx.btBugDesignate.Visible = False
        xx.btBugEntry.Visible = False
        xx.btResults.Visible = False
        xx.Text = "Bug管理[状态预览]"
        xx.ShowDialog()

    End Sub

#Region "委托"

    ''' <summary>
    ''' 利用委托传参
    ''' </summary>
    ''' <param name="GridControl"></param>
    ''' <param name="dt"></param>
    ''' <remarks></remarks>
    Sub bindingData(ByVal GridControl As DevExpress.XtraGrid.GridControl, ByVal dt As DataTable)
        Try

            If dt.Rows.Count > 0 Then
                GridControl.DataSource = dt
            Else
                GridControl.DataSource = Nothing
            End If

            dt.Dispose()

        Catch ex As Exception
            MessageBox.Show("委托引发以下异常：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


#End Region

#Region "功能菜单"

    Private Sub Editbug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editbug.Click

        If GridView1.RowCount = 0 Or Len(GridView1.GetFocusedRowCellValue("AutoID")) = 0 Then Exit Sub
        isRefresh = False
        Dim xx As New BugEntry
        xx.TestEdit = True
        xx.btContinueAdd.Visible = False
        xx.btSave.Text = "修改"
        xx.AutoID = GridView1.GetFocusedRowCellValue("AutoID")
        xx.ProjectID = GridView1.GetFocusedRowCellValue("SysProID")
        xx.CurrentStatus = "待指派"
        xx.Text = "Bug管理[数据修改]"
        xx.ShowDialog()

        '' 决定是否需要刷新数据
        If Not isRefresh Then Exit Sub

        td2 = New Threading.Thread(AddressOf LoadDataBugRate)
        td2.Start()
        Threading.Thread.Sleep(100)

    End Sub

    '' 删除指定数据
    Private Sub delBug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delBug.Click

        If GridView1.RowCount = 0 Or Len(GridView1.GetFocusedRowCellValue("AutoID")) = 0 Then Exit Sub

        Dim id As Integer = GridView1.GetFocusedRowCellValue("AutoID")

        Dim pName As String = GridView1.GetFocusedRowCellValue("SysProName").ToString()

        Dim BugName As String = GridView1.GetFocusedRowCellValue("BugName").ToString()

        Dim result As New DialogResult

        result = MessageBox.Show("确定需要删除以下资料吗?" & vbCrLf & "系统名称:" & pName & vbCrLf & "Bug名称:" & BugName, "项目管理系统",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = DialogResult.No Then Exit Sub

        Dim sql As String = "delete IT_DevelopBugManager where AutoID='" & id & "' and SysProName='" & pName & "' and BugName='" & BugName & "'"

        Try
            If ExecuteNonQuery(sql) > 0 Then
                GridView1.DeleteSelectedRows()
                '' MessageBox.Show("删除成功!", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("删除失败?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try

    End Sub


#End Region

#Region "刷新条件"

    '' 待验收
    Private Sub CEbeClosed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEbeClosed.CheckedChanged
        If CEbeClosed.Checked Then
            ChecksFilterValue()
        End If
    End Sub
    '' 待回覆
    Private Sub CESubjectReply_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CESubjectReply.CheckedChanged
        If CESubjectReply.Checked Then
            ChecksFilterValue()
        End If
    End Sub

    '' 显示所有项
    Private Sub CEAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEAll.CheckedChanged
        If CEAll.Checked Then
            ChecksFilterValue()
        End If
    End Sub
    ''' <summary>
    ''' 刷新条件
    ''' </summary>
    ''' <remarks></remarks>
    Sub ChecksFilterValue()
        '
        Dim strFilterString As String
        Dim lt As New ListBox
        strFilterString = ""
        lt.Items.Clear()

        'OR
        If CEbeClosed.Checked = True Then lt.Items.Add("[CurrentStatus]='待验收'")
        If CESubjectReply.Checked = True Then lt.Items.Add("[CurrentStatus]='待回覆'")
        If CEAll.Checked = True Then lt.Items.Add("")

        For i As Integer = 0 To lt.Items.Count - 1

            If i = 0 Then
                strFilterString = lt.Items(i).ToString
            Else
                strFilterString = strFilterString & " or " & lt.Items(i).ToString
            End If

        Next

        GridView3.ActiveFilterString = strFilterString

    End Sub

#End Region

#Region "已经完成的记录筛选"

    Private Sub cbEmergency_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEmergency.SelectedIndexChanged
        CompletedBugFilterValue(True, cbEmergency.SelectedItem)
    End Sub

    Private Sub cmPriority_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmPriority.SelectedIndexChanged
        CompletedBugFilterValue(False, cmPriority.SelectedItem)
    End Sub

    ''' <summary>
    ''' 刷新条件
    ''' </summary>
    ''' <remarks></remarks>
    Sub CompletedBugFilterValue(ByVal b As Boolean, ByVal str As String)
        '
        Dim strFilterString As String
        Dim lt As New ListBox
        strFilterString = ""
        lt.Items.Clear()

        If b Then
            '严重程度
            If str = "所有" Then
                lt.Items.Add("[Emergency] =")
            Else
                lt.Items.Add("[Emergency] like '%" & str & "%'")
            End If
        Else
            ' 优先级
            If str = "所有" Then
                lt.Items.Add("[Priority] = ")
            Else
                lt.Items.Add("[Priority] like '%" & str & "%'")
            End If
        End If

        For i As Integer = 0 To lt.Items.Count - 1

            If i = 0 Then
                strFilterString = lt.Items(i).ToString
            Else
                strFilterString = strFilterString & " or " & lt.Items(i).ToString
            End If

        Next

        GridView2.ActiveFilterString = strFilterString

    End Sub

#End Region

End Class
