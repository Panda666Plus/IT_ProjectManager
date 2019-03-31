<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssessAndBugManage
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssessAndBugManage))
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.xtControl = New DevExpress.XtraTab.XtraTabControl()
        Me.BugType = New DevExpress.XtraTab.XtraTabPage()
        Me.BugManager = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Assess = New DevExpress.XtraTab.XtraTabPage()
        Me.AssessTreelist = New DevExpress.XtraTreeList.TreeList()
        Me.ASS_Name = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.ASS_Remark = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddPro = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddItems = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Edit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Del = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.nodeImage = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.btClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btSave = New DevExpress.XtraEditors.SimpleButton()
        Me.lblRemarks = New DevExpress.XtraEditors.LabelControl()
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        Me.lblName = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtControl.SuspendLayout()
        Me.BugType.SuspendLayout()
        CType(Me.BugManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Assess.SuspendLayout()
        CType(Me.AssessTreelist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'xtControl
        '
        Me.xtControl.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtControl.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.xtControl.Appearance.Options.UseFont = True
        Me.xtControl.Appearance.Options.UseForeColor = True
        Me.xtControl.AppearancePage.Header.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.xtControl.AppearancePage.Header.Options.UseFont = True
        Me.xtControl.AppearancePage.PageClient.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtControl.AppearancePage.PageClient.Options.UseFont = True
        Me.xtControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.xtControl.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.xtControl.Dock = System.Windows.Forms.DockStyle.Right
        Me.xtControl.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.xtControl.Location = New System.Drawing.Point(0, 165)
        Me.xtControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.xtControl.Name = "xtControl"
        Me.xtControl.SelectedTabPage = Me.BugType
        Me.xtControl.Size = New System.Drawing.Size(552, 375)
        Me.xtControl.TabIndex = 0
        Me.xtControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.BugType, Me.Assess})
        '
        'BugType
        '
        Me.BugType.Controls.Add(Me.BugManager)
        Me.BugType.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BugType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BugType.Name = "BugType"
        Me.BugType.Size = New System.Drawing.Size(544, 341)
        Me.BugType.Text = "Bug类型管理"
        '
        'BugManager
        '
        Me.BugManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BugManager.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BugManager.Location = New System.Drawing.Point(0, 0)
        Me.BugManager.MainView = Me.GridView3
        Me.BugManager.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BugManager.Name = "BugManager"
        Me.BugManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit2})
        Me.BugManager.Size = New System.Drawing.Size(544, 341)
        Me.BugManager.TabIndex = 3
        Me.BugManager.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Appearance.Empty.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridView3.Appearance.Empty.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.Silver
        Me.GridView3.Appearance.FocusedRow.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Blue
        Me.GridView3.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView3.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Silver
        Me.GridView3.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Blue
        Me.GridView3.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView3.Appearance.HideSelectionRow.Options.UseFont = True
        Me.GridView3.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView3.GridControl = Me.BugManager
        Me.GridView3.GroupPanelText = "Delete：删除（选中某笔数据，按下键盘Delete键执行删除操作）,双击修改选中项"
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.RowAutoHeight = True
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "AutoID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.FixedWidth = True
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 40
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Bug类型"
        Me.GridColumn2.FieldName = "xName"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.FixedWidth = True
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 200
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "备注"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.GridColumn3.FieldName = "Remarks"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.FixedWidth = True
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 230
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "创建人"
        Me.GridColumn4.FieldName = "CreateUname"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.FixedWidth = True
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 70
        '
        'Assess
        '
        Me.Assess.Controls.Add(Me.AssessTreelist)
        Me.Assess.Name = "Assess"
        Me.Assess.Size = New System.Drawing.Size(544, 341)
        Me.Assess.Text = "考核标准管理"
        '
        'AssessTreelist
        '
        Me.AssessTreelist.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.ASS_Name, Me.ASS_Remark})
        Me.AssessTreelist.ContextMenuStrip = Me.ContextMenuStrip1
        Me.AssessTreelist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AssessTreelist.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.AssessTreelist.KeyFieldName = "ASS_ID"
        Me.AssessTreelist.Location = New System.Drawing.Point(0, 0)
        Me.AssessTreelist.Name = "AssessTreelist"
        Me.AssessTreelist.OptionsView.AutoWidth = False
        Me.AssessTreelist.OptionsView.ShowIndicator = False
        Me.AssessTreelist.ParentFieldName = "ASS_PID"
        Me.AssessTreelist.Size = New System.Drawing.Size(544, 341)
        Me.AssessTreelist.StateImageList = Me.nodeImage
        Me.AssessTreelist.TabIndex = 1
        '
        'ASS_Name
        '
        Me.ASS_Name.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ASS_Name.AppearanceCell.Options.UseFont = True
        Me.ASS_Name.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ASS_Name.AppearanceHeader.Options.UseFont = True
        Me.ASS_Name.AppearanceHeader.Options.UseTextOptions = True
        Me.ASS_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ASS_Name.Caption = "标准名称"
        Me.ASS_Name.FieldName = "ASS_Name"
        Me.ASS_Name.MinWidth = 33
        Me.ASS_Name.Name = "ASS_Name"
        Me.ASS_Name.OptionsColumn.AllowEdit = False
        Me.ASS_Name.OptionsColumn.AllowFocus = False
        Me.ASS_Name.OptionsColumn.FixedWidth = True
        Me.ASS_Name.OptionsColumn.ReadOnly = True
        Me.ASS_Name.Visible = True
        Me.ASS_Name.VisibleIndex = 0
        Me.ASS_Name.Width = 230
        '
        'ASS_Remark
        '
        Me.ASS_Remark.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ASS_Remark.AppearanceCell.Options.UseFont = True
        Me.ASS_Remark.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ASS_Remark.AppearanceHeader.Options.UseFont = True
        Me.ASS_Remark.AppearanceHeader.Options.UseTextOptions = True
        Me.ASS_Remark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ASS_Remark.Caption = "标准备注"
        Me.ASS_Remark.FieldName = "ASS_Remark"
        Me.ASS_Remark.Name = "ASS_Remark"
        Me.ASS_Remark.OptionsColumn.AllowEdit = False
        Me.ASS_Remark.OptionsColumn.AllowFocus = False
        Me.ASS_Remark.OptionsColumn.FixedWidth = True
        Me.ASS_Remark.OptionsColumn.ReadOnly = True
        Me.ASS_Remark.Visible = True
        Me.ASS_Remark.VisibleIndex = 1
        Me.ASS_Remark.Width = 312
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AddPro, Me.ToolStripMenuItem2, Me.AddItems, Me.ToolStripMenuItem3, Me.Edit, Me.ToolStripMenuItem4, Me.Del, Me.ToolStripMenuItem5})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(137, 122)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(133, 6)
        '
        'AddPro
        '
        Me.AddPro.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.AddPro.Image = Global.IT_ProjectManager.My.Resources.Resources.OutlineExpand
        Me.AddPro.Name = "AddPro"
        Me.AddPro.Size = New System.Drawing.Size(136, 22)
        Me.AddPro.Text = "增加项目"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(133, 6)
        '
        'AddItems
        '
        Me.AddItems.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.AddItems.Image = Global.IT_ProjectManager.My.Resources.Resources.QueryAppend
        Me.AddItems.Name = "AddItems"
        Me.AddItems.Size = New System.Drawing.Size(136, 22)
        Me.AddItems.Text = "增加子项目"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(133, 6)
        '
        'Edit
        '
        Me.Edit.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Edit.Image = Global.IT_ProjectManager.My.Resources.Resources.Repeat
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(136, 22)
        Me.Edit.Text = "修改"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(133, 6)
        '
        'Del
        '
        Me.Del.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Del.Image = Global.IT_ProjectManager.My.Resources.Resources.OutlineCollapse
        Me.Del.Name = "Del"
        Me.Del.Size = New System.Drawing.Size(136, 22)
        Me.Del.Text = "删除"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(133, 6)
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
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.CheckEdit2)
        Me.PanelControl1.Controls.Add(Me.CheckEdit1)
        Me.PanelControl1.Controls.Add(Me.btClose)
        Me.PanelControl1.Controls.Add(Me.btSave)
        Me.PanelControl1.Controls.Add(Me.lblRemarks)
        Me.PanelControl1.Controls.Add(Me.txtName)
        Me.PanelControl1.Controls.Add(Me.lblName)
        Me.PanelControl1.Controls.Add(Me.txtRemarks)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(552, 165)
        Me.PanelControl1.TabIndex = 0
        '
        'CheckEdit2
        '
        Me.CheckEdit2.Location = New System.Drawing.Point(178, 132)
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit2.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit2.Properties.Caption = "项目经理"
        Me.CheckEdit2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CheckEdit2.Properties.RadioGroupIndex = 0
        Me.CheckEdit2.Size = New System.Drawing.Size(75, 22)
        Me.CheckEdit2.TabIndex = 7
        Me.CheckEdit2.TabStop = False
        Me.CheckEdit2.Visible = False
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(71, 132)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "项目组长"
        Me.CheckEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CheckEdit1.Properties.RadioGroupIndex = 0
        Me.CheckEdit1.Size = New System.Drawing.Size(75, 22)
        Me.CheckEdit1.TabIndex = 6
        Me.CheckEdit1.TabStop = False
        Me.CheckEdit1.Visible = False
        '
        'btClose
        '
        Me.btClose.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btClose.Appearance.Options.UseFont = True
        Me.btClose.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestDeny
        Me.btClose.Location = New System.Drawing.Point(468, 129)
        Me.btClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(75, 29)
        Me.btClose.TabIndex = 5
        Me.btClose.Text = "关闭"
        '
        'btSave
        '
        Me.btSave.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btSave.Appearance.Options.UseFont = True
        Me.btSave.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestAllow
        Me.btSave.Location = New System.Drawing.Point(359, 129)
        Me.btSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(75, 29)
        Me.btSave.TabIndex = 4
        Me.btSave.Text = "确认"
        '
        'lblRemarks
        '
        Me.lblRemarks.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemarks.Location = New System.Drawing.Point(7, 49)
        Me.lblRemarks.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(48, 16)
        Me.lblRemarks.TabIndex = 3
        Me.lblRemarks.Text = "备        注"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(71, 12)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.MaxLength = 100
        Me.txtName.Size = New System.Drawing.Size(474, 20)
        Me.txtName.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(7, 16)
        Me.lblName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "评分标准 "
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(71, 49)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Properties.MaxLength = 200
        Me.txtRemarks.Size = New System.Drawing.Size(474, 76)
        Me.txtRemarks.TabIndex = 2
        '
        'AssessAndBugManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 540)
        Me.Controls.Add(Me.xtControl)
        Me.Controls.Add(Me.PanelControl1)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AssessAndBugManage"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "系统资料管理"
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtControl.ResumeLayout(False)
        Me.BugType.ResumeLayout(False)
        CType(Me.BugManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Assess.ResumeLayout(False)
        CType(Me.AssessTreelist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents xtControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblRemarks As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BugType As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents BugManager As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents Assess As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents AssessTreelist As DevExpress.XtraTreeList.TreeList
    Friend WithEvents ASS_Name As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents ASS_Remark As DevExpress.XtraTreeList.Columns.TreeListColumn
    Private WithEvents nodeImage As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddPro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddItems As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Edit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Del As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
End Class
