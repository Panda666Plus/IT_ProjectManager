<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FTPFilesManager

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FTPFilesManager))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.FilesManagerNode = New DevExpress.XtraTreeList.TreeList()
        Me.FilesManager = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.rightManager = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.YToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditNode = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteNode = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.附件管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.uploadFTPFiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.delFiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.DownAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.nodeImage = New System.Windows.Forms.ImageList(Me.components)
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.gridRightManager = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewFtpFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.dellFTPFiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.DownFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ProjectName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FTPFileName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FileNames = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FilesSize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UploadDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UploadedUserID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UploadedUserNname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FTPFilesPath = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.FilesManagerNode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rightManager.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridRightManager.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SplitContainerControl2)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GridControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(572, 353)
        Me.SplitContainerControl1.SplitterPosition = 197
        Me.SplitContainerControl1.TabIndex = 1
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl2.Horizontal = False
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.SimpleButton1)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.FilesManagerNode)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.MemoEdit1)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(197, 353)
        Me.SplitContainerControl2.SplitterPosition = 80
        Me.SplitContainerControl2.TabIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Location = New System.Drawing.Point(141, 1)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(55, 21)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "模板下载"
        '
        'FilesManagerNode
        '
        Me.FilesManagerNode.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.FilesManager})
        Me.FilesManagerNode.ContextMenuStrip = Me.rightManager
        Me.FilesManagerNode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FilesManagerNode.KeyFieldName = "NodeID"
        Me.FilesManagerNode.Location = New System.Drawing.Point(0, 0)
        Me.FilesManagerNode.Name = "FilesManagerNode"
        Me.FilesManagerNode.OptionsView.ShowIndicator = False
        Me.FilesManagerNode.ParentFieldName = "P_ID"
        Me.FilesManagerNode.SelectImageList = Me.nodeImage
        Me.FilesManagerNode.Size = New System.Drawing.Size(197, 268)
        Me.FilesManagerNode.TabIndex = 0
        '
        'FilesManager
        '
        Me.FilesManager.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilesManager.AppearanceHeader.Options.UseFont = True
        Me.FilesManager.AppearanceHeader.Options.UseTextOptions = True
        Me.FilesManager.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FilesManager.Caption = "文档管理"
        Me.FilesManager.FieldName = "ProjectName"
        Me.FilesManager.MinWidth = 33
        Me.FilesManager.Name = "FilesManager"
        Me.FilesManager.OptionsColumn.AllowEdit = False
        Me.FilesManager.OptionsColumn.AllowSort = False
        Me.FilesManager.OptionsColumn.FixedWidth = True
        Me.FilesManager.OptionsColumn.ReadOnly = True
        Me.FilesManager.Visible = True
        Me.FilesManager.VisibleIndex = 0
        '
        'rightManager
        '
        Me.rightManager.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.YToolStripMenuItem, Me.ToolStripMenuItem1, Me.附件管理ToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.rightManager.Name = "rightManager"
        Me.rightManager.Size = New System.Drawing.Size(125, 66)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(121, 6)
        '
        'YToolStripMenuItem
        '
        Me.YToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Add, Me.ToolStripMenuItem6, Me.AddModel, Me.EditNode, Me.DeleteNode})
        Me.YToolStripMenuItem.Name = "YToolStripMenuItem"
        Me.YToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.YToolStripMenuItem.Text = "项目管理"
        '
        'Add
        '
        Me.Add.Image = Global.IT_ProjectManager.My.Resources.Resources.OutlineExpand
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(124, 22)
        Me.Add.Text = "增加项目"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(121, 6)
        '
        'AddModel
        '
        Me.AddModel.Image = Global.IT_ProjectManager.My.Resources.Resources.QueryAppend
        Me.AddModel.Name = "AddModel"
        Me.AddModel.Size = New System.Drawing.Size(124, 22)
        Me.AddModel.Text = "增加模块"
        '
        'EditNode
        '
        Me.EditNode.Image = Global.IT_ProjectManager.My.Resources.Resources.Repeat
        Me.EditNode.Name = "EditNode"
        Me.EditNode.Size = New System.Drawing.Size(124, 22)
        Me.EditNode.Text = "修改"
        '
        'DeleteNode
        '
        Me.DeleteNode.Image = Global.IT_ProjectManager.My.Resources.Resources.OutlineCollapse
        Me.DeleteNode.Name = "DeleteNode"
        Me.DeleteNode.Size = New System.Drawing.Size(124, 22)
        Me.DeleteNode.Text = "删除"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(121, 6)
        '
        '附件管理ToolStripMenuItem
        '
        Me.附件管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.uploadFTPFiles, Me.ToolStripMenuItem7, Me.delFiles, Me.ToolStripMenuItem8, Me.DownAll})
        Me.附件管理ToolStripMenuItem.Name = "附件管理ToolStripMenuItem"
        Me.附件管理ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.附件管理ToolStripMenuItem.Text = "附件管理"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(121, 6)
        '
        'uploadFTPFiles
        '
        Me.uploadFTPFiles.Image = Global.IT_ProjectManager.My.Resources.Resources.Down
        Me.uploadFTPFiles.Name = "uploadFTPFiles"
        Me.uploadFTPFiles.Size = New System.Drawing.Size(152, 22)
        Me.uploadFTPFiles.Text = "上传附件"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(121, 6)
        '
        'delFiles
        '
        Me.delFiles.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestDeny
        Me.delFiles.Name = "delFiles"
        Me.delFiles.Size = New System.Drawing.Size(152, 22)
        Me.delFiles.Text = "删除附件"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(121, 6)
        '
        'DownAll
        '
        Me.DownAll.Image = Global.IT_ProjectManager.My.Resources.Resources.down1
        Me.DownAll.Name = "DownAll"
        Me.DownAll.Size = New System.Drawing.Size(152, 22)
        Me.DownAll.Text = "批量下载"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(121, 6)
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
        'MemoEdit1
        '
        Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit1.Location = New System.Drawing.Point(0, 0)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.MemoEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.MemoEdit1.Properties.ReadOnly = True
        Me.MemoEdit1.Size = New System.Drawing.Size(197, 80)
        Me.MemoEdit1.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.gridRightManager
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(370, 353)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridRightManager
        '
        Me.gridRightManager.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewFtpFile, Me.ToolStripSeparator1, Me.dellFTPFiles, Me.ToolStripSeparator4, Me.DownFile, Me.ToolStripMenuItem5})
        Me.gridRightManager.Name = "rightManager"
        Me.gridRightManager.Size = New System.Drawing.Size(125, 88)
        '
        'ViewFtpFile
        '
        Me.ViewFtpFile.Image = Global.IT_ProjectManager.My.Resources.Resources.View
        Me.ViewFtpFile.Name = "ViewFtpFile"
        Me.ViewFtpFile.Size = New System.Drawing.Size(124, 22)
        Me.ViewFtpFile.Text = "预览附件"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(121, 6)
        '
        'dellFTPFiles
        '
        Me.dellFTPFiles.Image = Global.IT_ProjectManager.My.Resources.Resources.OutlineCollapse
        Me.dellFTPFiles.Name = "dellFTPFiles"
        Me.dellFTPFiles.Size = New System.Drawing.Size(124, 22)
        Me.dellFTPFiles.Text = "删除附件"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(121, 6)
        '
        'DownFile
        '
        Me.DownFile.Image = Global.IT_ProjectManager.My.Resources.Resources.down1
        Me.DownFile.Name = "DownFile"
        Me.DownFile.Size = New System.Drawing.Size(124, 22)
        Me.DownFile.Text = "附件下载"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(121, 6)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ProjectName, Me.FTPFileName, Me.FileNames, Me.FilesSize, Me.UploadDate, Me.UploadedUserID, Me.UploadedUserNname, Me.FTPFilesPath})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "右键管理项目"
        Me.GridView1.IndicatorWidth = 30
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'ProjectName
        '
        Me.ProjectName.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjectName.AppearanceHeader.Options.UseFont = True
        Me.ProjectName.AppearanceHeader.Options.UseTextOptions = True
        Me.ProjectName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ProjectName.Caption = "项目名称"
        Me.ProjectName.FieldName = "ProjectName"
        Me.ProjectName.Name = "ProjectName"
        Me.ProjectName.OptionsColumn.FixedWidth = True
        Me.ProjectName.OptionsColumn.ReadOnly = True
        Me.ProjectName.Visible = True
        Me.ProjectName.VisibleIndex = 0
        Me.ProjectName.Width = 140
        '
        'FTPFileName
        '
        Me.FTPFileName.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FTPFileName.AppearanceHeader.Options.UseFont = True
        Me.FTPFileName.AppearanceHeader.Options.UseTextOptions = True
        Me.FTPFileName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FTPFileName.Caption = "FTP名称"
        Me.FTPFileName.FieldName = "FTPFileName"
        Me.FTPFileName.Name = "FTPFileName"
        Me.FTPFileName.OptionsColumn.FixedWidth = True
        Me.FTPFileName.OptionsColumn.ReadOnly = True
        Me.FTPFileName.Width = 100
        '
        'FileNames
        '
        Me.FileNames.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileNames.AppearanceHeader.Options.UseFont = True
        Me.FileNames.AppearanceHeader.Options.UseTextOptions = True
        Me.FileNames.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FileNames.Caption = "文件名称"
        Me.FileNames.FieldName = "FileNames"
        Me.FileNames.Name = "FileNames"
        Me.FileNames.OptionsColumn.AllowEdit = False
        Me.FileNames.OptionsColumn.FixedWidth = True
        Me.FileNames.OptionsColumn.ReadOnly = True
        Me.FileNames.Visible = True
        Me.FileNames.VisibleIndex = 1
        Me.FileNames.Width = 130
        '
        'FilesSize
        '
        Me.FilesSize.AppearanceCell.Options.UseTextOptions = True
        Me.FilesSize.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.FilesSize.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilesSize.AppearanceHeader.Options.UseFont = True
        Me.FilesSize.AppearanceHeader.Options.UseTextOptions = True
        Me.FilesSize.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FilesSize.Caption = "文件大小"
        Me.FilesSize.FieldName = "FilesSize"
        Me.FilesSize.Name = "FilesSize"
        Me.FilesSize.OptionsColumn.AllowEdit = False
        Me.FilesSize.OptionsColumn.FixedWidth = True
        Me.FilesSize.OptionsColumn.ReadOnly = True
        Me.FilesSize.Visible = True
        Me.FilesSize.VisibleIndex = 2
        Me.FilesSize.Width = 70
        '
        'UploadDate
        '
        Me.UploadDate.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadDate.AppearanceHeader.Options.UseFont = True
        Me.UploadDate.AppearanceHeader.Options.UseTextOptions = True
        Me.UploadDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.UploadDate.Caption = "上传日期"
        Me.UploadDate.FieldName = "UploadDate"
        Me.UploadDate.Name = "UploadDate"
        Me.UploadDate.OptionsColumn.AllowEdit = False
        Me.UploadDate.OptionsColumn.FixedWidth = True
        Me.UploadDate.OptionsColumn.ReadOnly = True
        Me.UploadDate.Visible = True
        Me.UploadDate.VisibleIndex = 3
        Me.UploadDate.Width = 120
        '
        'UploadedUserID
        '
        Me.UploadedUserID.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadedUserID.AppearanceHeader.Options.UseFont = True
        Me.UploadedUserID.AppearanceHeader.Options.UseTextOptions = True
        Me.UploadedUserID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.UploadedUserID.Caption = "上伟者工号"
        Me.UploadedUserID.FieldName = "UploadedUserID"
        Me.UploadedUserID.Name = "UploadedUserID"
        Me.UploadedUserID.OptionsColumn.AllowEdit = False
        Me.UploadedUserID.OptionsColumn.FixedWidth = True
        Me.UploadedUserID.OptionsColumn.ReadOnly = True
        Me.UploadedUserID.Visible = True
        Me.UploadedUserID.VisibleIndex = 4
        Me.UploadedUserID.Width = 100
        '
        'UploadedUserNname
        '
        Me.UploadedUserNname.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadedUserNname.AppearanceHeader.Options.UseFont = True
        Me.UploadedUserNname.AppearanceHeader.Options.UseTextOptions = True
        Me.UploadedUserNname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.UploadedUserNname.Caption = "上传者姓名"
        Me.UploadedUserNname.FieldName = "UploadedUserNname"
        Me.UploadedUserNname.Name = "UploadedUserNname"
        Me.UploadedUserNname.OptionsColumn.AllowEdit = False
        Me.UploadedUserNname.OptionsColumn.FixedWidth = True
        Me.UploadedUserNname.OptionsColumn.ReadOnly = True
        Me.UploadedUserNname.Visible = True
        Me.UploadedUserNname.VisibleIndex = 5
        Me.UploadedUserNname.Width = 100
        '
        'FTPFilesPath
        '
        Me.FTPFilesPath.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FTPFilesPath.AppearanceHeader.Options.UseFont = True
        Me.FTPFilesPath.AppearanceHeader.Options.UseTextOptions = True
        Me.FTPFilesPath.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FTPFilesPath.Caption = "FTP路径"
        Me.FTPFilesPath.FieldName = "FTPFilesPath"
        Me.FTPFilesPath.Name = "FTPFilesPath"
        Me.FTPFilesPath.OptionsColumn.AllowEdit = False
        Me.FTPFilesPath.OptionsColumn.FixedWidth = True
        Me.FTPFilesPath.OptionsColumn.ReadOnly = True
        '
        'FTPFilesManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "FTPFilesManager"
        Me.Size = New System.Drawing.Size(572, 353)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.FilesManagerNode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rightManager.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridRightManager.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents FilesManagerNode As DevExpress.XtraTreeList.TreeList
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FileNames As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FilesSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UploadDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UploadedUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UploadedUserNname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FTPFilesPath As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rightManager As System.Windows.Forms.ContextMenuStrip
    Private WithEvents nodeImage As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents gridRightManager As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dellFTPFiles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProjectName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DownFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents YToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteNode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Add As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddModel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditNode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 附件管理ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents uploadFTPFiles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents delFiles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DownAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewFtpFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilesManager As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents FTPFileName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton

End Class
