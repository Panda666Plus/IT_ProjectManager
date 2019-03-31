Public Class nblSystemNameManage

    Private Sub nblSystemNameManage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Sub loadData()

        Dim sql As String = Nothing

        sql = "select datediff(month,StartDate,'" & DateTime.Now.Date.ToString("yyyy-MM-dd") & "') as TotalMonths," &
              " IT_SystemNameManager.* from IT_SystemNameManager "

        Dim dt As New DataTable

        dt = getDataTables(sql)

        If dt.Rows.Count > 0 Then
            Syslist.DataSource = dt
            Syslist.ExpandAll()
        Else
            SysList.DataSource = Nothing
        End If

        dt.Dispose()

    End Sub

    '' 修改
    Private Sub edit_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem8.Click
        isRefresh = False
        Dim frm As New SystemList
        frm.AutoID = Syslist.FocusedNode.GetValue("AutoID")
        frm.SysNameID = Syslist.FocusedNode.GetValue("SystemID")
        frm.SysName = Syslist.FocusedNode.GetValue("SystemName")
        frm.TempPlD = Syslist.FocusedNode.GetValue("PID")
        frm.IsEdit = True
        frm.ShowDialog()
        '' 決定是否需要刷新數據
        If Not isRefresh Then Exit Sub
        loadData()
    End Sub
    '' 增加
    Private Sub Add_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem7.Click
        isRefresh = False
        Dim frm As New SystemList
        frm.AutoID = Syslist.FocusedNode.GetValue("AutoID")
        frm.ShowDialog()
        '' 決定是否需要刷新數據
        If Not isRefresh Then Exit Sub
        loadData()
    End Sub

    '' 刪除
    Private Sub Dll_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem9.Click

        If Syslist.FocusedNode.Nodes.Count > 0 Then
            MessageBox.Show("項目系統中還包含有子系統，請先移除子系統？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim AutoID As String = Syslist.FocusedNode.GetValue("AutoID")
        Dim SysNameID As String = Syslist.FocusedNode.GetValue("SystemID")
        Dim SysName As String = Syslist.FocusedNode.GetValue("SystemName")

        If AutoID = "" Or SysNameID = "" Or SysName = "" Then
            MessageBox.Show("請選擇需要刪除的數據？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim result As New DialogResult
        result = MessageBox.Show("您確認需要刪除系統[" & SysName & "]相關數據碼？" & vbCrLf & "資料一旦刪除則無法恢復。",
                                "項目管理系統", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.No Then Exit Sub

        Dim sql As String = "delete IT_SystemNameManager where AutoID='" & AutoID & "' And SystemID='" & SysNameID &
            "' and SystemName='" & SysName & "'"
        If ExecuteNonQuery(sql) <> 1 Then
            MessageBox.Show("刪除失敗？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("刪除成功!", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            '' 移除行
            Syslist.Nodes.Remove(Syslist.FocusedNode)
        End If

    End Sub
    '' 繪製行顏色
    Private Sub GridView1_CustomDrawCell(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs)
        CustomDrawCell(e)
    End Sub

    ''導出Excel
    Private Sub ToExcel_Click(sender As System.Object, e As System.EventArgs) Handles toExcles.Click

        Dim save As New SaveFileDialog
        save.Filter = "Excel 2007(*.xlsx)|*.xlsx"
        save.Title = "系統清單導出"
        save.FileName = "系統清單明細.xlsx"
        If save.ShowDialog = DialogResult.OK Then
            Syslist.ExportToXlsx(save.FileName)
            MessageBox.Show("導出成功！", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            StartApp(save.FileName)
        End If
    End Sub
    '' 加載圖片
    Private Sub Syslist_GetSelectImage(sender As System.Object, e As DevExpress.XtraTreeList.GetSelectImageEventArgs) Handles Syslist.GetSelectImage
        If e.Node Is Nothing Then Exit Sub
        Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
        node = e.Node
        Dim ID As Integer = e.Node.Level
        e.NodeImageIndex = ID
    End Sub
    '' 查看
    Private Sub ToolStripMenuItem10_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem10.Click
        isRefresh = False
        Dim frm As New SystemList
        frm.AutoID = Syslist.FocusedNode.GetValue("AutoID")
        frm.SysNameID = Syslist.FocusedNode.GetValue("SystemID")
        frm.SysName = Syslist.FocusedNode.GetValue("SystemName")
        frm.IsView = True
        frm.ShowDialog()
        '' 決定是否需要刷新數據
        If Not isRefresh Then Exit Sub
        loadData()
    End Sub
    '' 增加項目
    Private Sub AddPro_Click(sender As System.Object, e As System.EventArgs) Handles AddPro.Click
        Dim frm As New SystemList
        frm.AutoID = 0
        frm.ShowDialog()
        '' 決定是否需要刷新數據
        If Not isRefresh Then Exit Sub
        loadData()
    End Sub

End Class
