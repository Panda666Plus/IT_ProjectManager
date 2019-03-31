Public Class nblSystemNameManage

    Private Sub nblSystemNameManage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        isRefresh = False
        Dim frm As New SystemList
        frm.AutoID = Syslist.FocusedNode.GetValue("AutoID")
        frm.SysNameID = Syslist.FocusedNode.GetValue("SystemID")
        frm.SysName = Syslist.FocusedNode.GetValue("SystemName")
        frm.TempPlD = Syslist.FocusedNode.GetValue("PID")

        ''----2014/12/08        DEVON
        frm.gluSystemType.Text = IIf(IsDBNull(Syslist.FocusedNode.GetValue("SystemType")), Nothing, Syslist.FocusedNode.GetValue("SystemType"))
        ''---------------------

        frm.IsEdit = True
        frm.ShowDialog()
        '' 决定是否需要刷新数据
        If Not isRefresh Then Exit Sub
        loadData()
    End Sub

    '' 增加
    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        isRefresh = False
        Dim frm As New SystemList
        frm.AutoID = Syslist.FocusedNode.GetValue("AutoID")
        frm.ShowDialog()
        '' 决定是否需要刷新数据
        If Not isRefresh Then Exit Sub
        loadData()
    End Sub

    '' 删除
    Private Sub Dll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click

        If Syslist.FocusedNode.Nodes.Count > 0 Then
            MessageBox.Show("项目系统中还包含有子系统，请先移除子系统？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim AutoID As String = Syslist.FocusedNode.GetValue("AutoID")
        Dim SysNameID As String = Syslist.FocusedNode.GetValue("SystemID")
        Dim SysName As String = Syslist.FocusedNode.GetValue("SystemName")

        If AutoID = "" Or SysNameID = "" Or SysName = "" Then
            MessageBox.Show("请选择需要删除的数据？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim result As New DialogResult
        result = MessageBox.Show("您确认需要删除系统[" & SysName & "]相关数据码？" & vbCrLf & "资料一旦删除则无法恢复。",
                                "项目管理系统", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.No Then Exit Sub

        Dim sql As String = "delete IT_SystemNameManager where AutoID='" & AutoID & "' And SystemID='" & SysNameID &
            "' and SystemName='" & SysName & "'"
        If ExecuteNonQuery(sql) <> 1 Then
            MessageBox.Show("删除失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("删除成功!", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            '' 移除行
            Syslist.Nodes.Remove(Syslist.FocusedNode)
        End If

    End Sub
    '' 绘制行颜色
    Private Sub GridView1_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs)
        CustomDrawCell(e)
    End Sub

    ''导出Excel
    Private Sub ToExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toExcles.Click

        Dim save As New SaveFileDialog
        save.Filter = "Excel 2007(*.xlsx)|*.xlsx"
        save.Title = "系统清单导出"
        save.FileName = "系统清单明细.xlsx"
        If save.ShowDialog = DialogResult.OK Then
            Syslist.ExportToXlsx(save.FileName)
            MessageBox.Show("导出成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            StartApp(save.FileName, False)
        End If
    End Sub
    '' 加载图片
    Private Sub Syslist_GetSelectImage(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.GetSelectImageEventArgs)
        If e.Node Is Nothing Then Exit Sub
        Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
        node = e.Node
        Dim ID As Integer = e.Node.Level
        e.NodeImageIndex = ID
    End Sub
    '' 查看
    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        isRefresh = False
        Dim frm As New SystemList
        frm.AutoID = Syslist.FocusedNode.GetValue("AutoID")
        frm.SysNameID = Syslist.FocusedNode.GetValue("SystemID")
        frm.SysName = Syslist.FocusedNode.GetValue("SystemName")
        frm.IsView = True
        frm.ShowDialog()
        '' 决定是否需要刷新数据
        If Not isRefresh Then Exit Sub
        loadData()
    End Sub
    '' 增加项目
    Private Sub AddPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPro.Click
        Dim frm As New SystemList
        frm.AutoID = 0
        frm.ShowDialog()
        '' 决定是否需要刷新数据
        If Not isRefresh Then Exit Sub
        loadData()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Panel1.Visible = False
    End Sub

    Private Sub Syslist_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Syslist.DoubleClick
        Dim str As String
        If Syslist.FocusedNode.Level = 0 Then
            str = Syslist.FocusedNode.GetDisplayText("SystemID")
        Else
            str = Syslist.FocusedNode.ParentNode.GetDisplayText("SystemID")
        End If
        If (str <> Nothing) Then
            Panel1.Visible = True
            bindgrid(str)
        End If

    End Sub

    Private Sub bindgrid(ByVal systemID As System.String)

        Me.GridControl1.DataSource =
            DbServices.DbHelperSQL.Query(String.Format(" select a.*,b.SystemName from dbo.IT_SoftIssueTrace  a inner join " &
                                                       " IT_SystemNameManager b on a.projectNo=b.SystemID  where projectNo='{0}' order by [verNo] DESC", systemID)).Tables(0)

    End Sub

    Private Sub Syslist_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles Syslist.FocusedNodeChanged
        If Me.Panel1.Visible Then
            Dim str As String
            If e.Node.Level = 0 Then
                str = e.Node.GetDisplayText("SystemID")
            Else
                str = e.Node.ParentNode.GetDisplayText("SystemID")
            End If
            bindgrid(str)
        End If
    End Sub

    Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem13.Click
        Dim xx As New SoftIssueTrace(Me.Syslist.FocusedNode.GetValue("SystemID"),
                                     Me.Syslist.FocusedNode.GetValue("SystemName"), True, "",
                                     Me.Syslist.FocusedNode.GetValue("UseDepartments"))
        xx.Text = "新增项目更新记录"
        If xx.ShowDialog() = DialogResult.OK Then
            Dim str As String
            If Syslist.FocusedNode.Level = 0 Then
                str = Syslist.FocusedNode.GetDisplayText("SystemID")
            Else
                str = Syslist.FocusedNode.ParentNode.GetDisplayText("SystemID")
            End If
            bindgrid(str)
        End If



    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        Dim xx As New SoftIssueTrace(Me.Syslist.FocusedNode.GetValue("SystemID"),
                                    Me.Syslist.FocusedNode.GetValue("SystemName"), False, DirectCast(GridView1.GetFocusedRow(), DataRowView).Row("rowGuid").ToString(),
                                    Me.Syslist.FocusedNode.GetValue("UseDepartments"))

        xx.Text = "修改项目更新记录"
        If xx.ShowDialog() = DialogResult.OK Then
            Dim str As String
            If Syslist.FocusedNode.Level = 0 Then
                str = Syslist.FocusedNode.GetDisplayText("SystemID")
            Else
                str = Syslist.FocusedNode.ParentNode.GetDisplayText("SystemID")
            End If
            bindgrid(str)
        End If
    End Sub

    Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem16.Click
        If MessageBox.Show("您确定删除当前选中的行吗?", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            DbServices.DbHelperSQL.ExecuteSql(String.Format("delete dbo.IT_SoftIssueTrace where rowGuid='{0}'",
             DirectCast(GridView1.GetFocusedRow(), DataRowView).Row("rowGuid").ToString()))
            Dim str As String
            If Syslist.FocusedNode.Level = 0 Then
                str = Syslist.FocusedNode.GetDisplayText("SystemID")
            Else
                str = Syslist.FocusedNode.ParentNode.GetDisplayText("SystemID")
            End If
            bindgrid(str)
        End If
    End Sub

    Private Sub ToolStripMenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem18.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Me.GridView1.ExportToXls(SaveFileDialog1.FileName)
            MessageBox.Show("导成文件成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub
End Class

