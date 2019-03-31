<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nblSystemNameManage
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nblSystemNameManage))
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddPro = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.toExcles = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Add = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.edit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Dll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.view = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Syslist = New DevExpress.XtraTreeList.TreeList()
        Me.SystemName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.SystemID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.StartDate = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.Company = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.UseDepartments = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.UseRemarks = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.SystemRemarks = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.nodeImage = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.Syslist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.AddPro, Me.ToolStripMenuItem12, Me.ToolStripMenuItem7, Me.ToolStripSeparator2, Me.ToolStripMenuItem8, Me.ToolStripSeparator3, Me.ToolStripMenuItem9, Me.ToolStripSeparator4, Me.ToolStripMenuItem10, Me.ToolStripSeparator5, Me.toExcles, Me.ToolStripMenuItem11})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(130, 178)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(126, 6)
        '
        'AddPro
        '
        Me.AddPro.Image = Global.IT_ProjectManager.My.Resources.Resources.OutlineExpand
        Me.AddPro.Name = "AddPro"
        Me.AddPro.Size = New System.Drawing.Size(129, 22)
        Me.AddPro.Text = "增加模塊"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(126, 6)
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Image = Global.IT_ProjectManager.My.Resources.Resources.QueryAppend
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripMenuItem7.Text = "增加項目"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(126, 6)
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Image = Global.IT_ProjectManager.My.Resources.Resources.Repeat
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripMenuItem8.Text = "修改"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(126, 6)
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Image = Global.IT_ProjectManager.My.Resources.Resources.OutlineCollapse
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripMenuItem9.Text = "刪除"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(126, 6)
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Image = Global.IT_ProjectManager.My.Resources.Resources.View
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripMenuItem10.Text = "詳細"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(126, 6)
        '
        'toExcles
        '
        Me.toExcles.Image = Global.IT_ProjectManager.My.Resources.Resources.ToExcel
        Me.toExcles.Name = "toExcles"
        Me.toExcles.Size = New System.Drawing.Size(129, 22)
        Me.toExcles.Text = "導出Excel"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(126, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(149, 6)
        '
        'Add
        '
        Me.Add.Image = Global.IT_ProjectManager.My.Resources.Resources.OutlineExpand
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(152, 22)
        Me.Add.Text = "增加"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'edit
        '
        Me.edit.Image = Global.IT_ProjectManager.My.Resources.Resources.Repeat
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(152, 22)
        Me.edit.Text = "修改"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(149, 6)
        '
        'Dll
        '
        Me.Dll.Image = Global.IT_ProjectManager.My.Resources.Resources.OutlineCollapse
        Me.Dll.Name = "Dll"
        Me.Dll.Size = New System.Drawing.Size(152, 22)
        Me.Dll.Text = "刪除"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(149, 6)
        '
        'view
        '
        Me.view.Image = Global.IT_ProjectManager.My.Resources.Resources.View
        Me.view.Name = "view"
        Me.view.Size = New System.Drawing.Size(152, 22)
        Me.view.Text = "詳細"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(149, 6)
        '
        'ToExcel
        '
        Me.ToExcel.Image = Global.IT_ProjectManager.My.Resources.Resources.ToExcel
        Me.ToExcel.Name = "ToExcel"
        Me.ToExcel.Size = New System.Drawing.Size(152, 22)
        Me.ToExcel.Text = "導出Excel"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(149, 6)
        '
        'Syslist
        '
        Me.Syslist.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.SystemName, Me.SystemID, Me.StartDate, Me.Company, Me.UseDepartments, Me.UseRemarks, Me.SystemRemarks})
        Me.Syslist.ContextMenuStrip = Me.ContextMenuStrip2
        Me.Syslist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Syslist.KeyFieldName = "AutoID"
        Me.Syslist.Location = New System.Drawing.Point(0, 0)
        Me.Syslist.Name = "Syslist"
        Me.Syslist.OptionsView.AutoWidth = False
        Me.Syslist.OptionsView.ShowIndicator = False
        Me.Syslist.ParentFieldName = "PID"
        Me.Syslist.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit1, Me.RepositoryItemMemoExEdit2})
        Me.Syslist.SelectImageList = Me.nodeImage
        Me.Syslist.Size = New System.Drawing.Size(683, 445)
        Me.Syslist.TabIndex = 1
        '
        'SystemName
        '
        Me.SystemName.AppearanceHeader.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemName.AppearanceHeader.Options.UseFont = True
        Me.SystemName.AppearanceHeader.Options.UseTextOptions = True
        Me.SystemName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SystemName.Caption = "系統名稱"
        Me.SystemName.FieldName = "SystemName"
        Me.SystemName.MinWidth = 33
        Me.SystemName.Name = "SystemName"
        Me.SystemName.OptionsColumn.AllowEdit = False
        Me.SystemName.OptionsColumn.AllowFocus = False
        Me.SystemName.OptionsColumn.AllowSize = False
        Me.SystemName.OptionsColumn.FixedWidth = True
        Me.SystemName.OptionsColumn.ReadOnly = True
        Me.SystemName.Visible = True
        Me.SystemName.VisibleIndex = 0
        Me.SystemName.Width = 200
        '
        'SystemID
        '
        Me.SystemID.AppearanceHeader.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemID.AppearanceHeader.Options.UseFont = True
        Me.SystemID.AppearanceHeader.Options.UseTextOptions = True
        Me.SystemID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SystemID.Caption = "系統編碼"
        Me.SystemID.FieldName = "SystemID"
        Me.SystemID.Name = "SystemID"
        Me.SystemID.OptionsColumn.AllowEdit = False
        Me.SystemID.OptionsColumn.AllowFocus = False
        Me.SystemID.OptionsColumn.FixedWidth = True
        Me.SystemID.OptionsColumn.ReadOnly = True
        Me.SystemID.Visible = True
        Me.SystemID.VisibleIndex = 1
        Me.SystemID.Width = 100
        '
        'StartDate
        '
        Me.StartDate.AppearanceHeader.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDate.AppearanceHeader.Options.UseFont = True
        Me.StartDate.AppearanceHeader.Options.UseTextOptions = True
        Me.StartDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.StartDate.Caption = "推行日期"
        Me.StartDate.FieldName = "StartDate"
        Me.StartDate.Name = "StartDate"
        Me.StartDate.OptionsColumn.AllowEdit = False
        Me.StartDate.OptionsColumn.AllowFocus = False
        Me.StartDate.OptionsColumn.FixedWidth = True
        Me.StartDate.OptionsColumn.ReadOnly = True
        Me.StartDate.Visible = True
        Me.StartDate.VisibleIndex = 2
        Me.StartDate.Width = 100
        '
        'Company
        '
        Me.Company.AppearanceHeader.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Company.AppearanceHeader.Options.UseFont = True
        Me.Company.AppearanceHeader.Options.UseTextOptions = True
        Me.Company.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Company.Caption = "適用公司"
        Me.Company.FieldName = "Company"
        Me.Company.Name = "Company"
        Me.Company.OptionsColumn.AllowEdit = False
        Me.Company.OptionsColumn.AllowFocus = False
        Me.Company.OptionsColumn.AllowSize = False
        Me.Company.OptionsColumn.FixedWidth = True
        Me.Company.OptionsColumn.ReadOnly = True
        Me.Company.Visible = True
        Me.Company.VisibleIndex = 3
        '
        'UseDepartments
        '
        Me.UseDepartments.AppearanceHeader.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UseDepartments.AppearanceHeader.Options.UseFont = True
        Me.UseDepartments.AppearanceHeader.Options.UseTextOptions = True
        Me.UseDepartments.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.UseDepartments.Caption = "部門"
        Me.UseDepartments.FieldName = "UseDepartments"
        Me.UseDepartments.Name = "UseDepartments"
        Me.UseDepartments.OptionsColumn.AllowEdit = False
        Me.UseDepartments.OptionsColumn.AllowFocus = False
        Me.UseDepartments.OptionsColumn.FixedWidth = True
        Me.UseDepartments.OptionsColumn.ReadOnly = True
        Me.UseDepartments.Visible = True
        Me.UseDepartments.VisibleIndex = 4
        Me.UseDepartments.Width = 120
        '
        'UseRemarks
        '
        Me.UseRemarks.AppearanceHeader.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UseRemarks.AppearanceHeader.Options.UseFont = True
        Me.UseRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.UseRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.UseRemarks.Caption = "用途"
        Me.UseRemarks.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.UseRemarks.FieldName = "UseRemarks"
        Me.UseRemarks.Name = "UseRemarks"
        Me.UseRemarks.OptionsColumn.FixedWidth = True
        Me.UseRemarks.OptionsColumn.ReadOnly = True
        Me.UseRemarks.Visible = True
        Me.UseRemarks.VisibleIndex = 5
        Me.UseRemarks.Width = 250
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'SystemRemarks
        '
        Me.SystemRemarks.AppearanceHeader.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemRemarks.AppearanceHeader.Options.UseFont = True
        Me.SystemRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.SystemRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SystemRemarks.Caption = "備註"
        Me.SystemRemarks.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.SystemRemarks.FieldName = "SystemRemarks"
        Me.SystemRemarks.Name = "SystemRemarks"
        Me.SystemRemarks.OptionsColumn.AllowSize = False
        Me.SystemRemarks.OptionsColumn.FixedWidth = True
        Me.SystemRemarks.OptionsColumn.ReadOnly = True
        Me.SystemRemarks.Visible = True
        Me.SystemRemarks.VisibleIndex = 6
        Me.SystemRemarks.Width = 300
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'nodeImage
        '
        Me.nodeImage.ImageStream = CType(resources.GetObject("nodeImage.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.nodeImage.TransparentColor = System.Drawing.Color.Transparent
        Me.nodeImage.Images.SetKeyName(0, "pro.png")
        Me.nodeImage.Images.SetKeyName(1, "node_list1.png")
        Me.nodeImage.Images.SetKeyName(2, "node_list2.png")
        Me.nodeImage.Images.SetKeyName(3, "node_list3.png")
        Me.nodeImage.Images.SetKeyName(4, "node_list4.png")
        Me.nodeImage.Images.SetKeyName(5, "node_list5.png")
        Me.nodeImage.Images.SetKeyName(6, "node_list6.png")
        Me.nodeImage.Images.SetKeyName(7, "node_list7.png")
        Me.nodeImage.Images.SetKeyName(8, "node_list8.png")
        Me.nodeImage.Images.SetKeyName(9, "node_list9.png")
        Me.nodeImage.Images.SetKeyName(10, "node_list10.png")
        '
        'nblSystemNameManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Syslist)
        Me.Name = "nblSystemNameManage"
        Me.Size = New System.Drawing.Size(683, 445)
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.Syslist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Add As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents edit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Dll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents view As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toExcles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Syslist As DevExpress.XtraTreeList.TreeList
    Friend WithEvents SystemName As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents SystemID As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents StartDate As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents Company As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents SystemRemarks As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Private WithEvents nodeImage As System.Windows.Forms.ImageList
    Friend WithEvents UseRemarks As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents UseDepartments As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents AddPro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripSeparator

End Class
