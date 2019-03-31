<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deptinfo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.pupProjectDetail = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pupAddSub = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.pupDel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.uploadData = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CompanyNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.deptno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.deptname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.create_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.create_time = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.update_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.update_time = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pupProjectDetail.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GridControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 301)
        Me.Panel1.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.pupProjectDetail
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(568, 301)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'pupProjectDetail
        '
        Me.pupProjectDetail.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pupAddSub, Me.ToolStripSeparator1, Me.pupDel, Me.ToolStripMenuItem1, Me.uploadData})
        Me.pupProjectDetail.Name = "pupProjectDetail"
        Me.pupProjectDetail.Size = New System.Drawing.Size(125, 82)
        '
        'pupAddSub
        '
        Me.pupAddSub.Image = Global.IT_ProjectManager.My.Resources.Resources.OutlineExpand
        Me.pupAddSub.Name = "pupAddSub"
        Me.pupAddSub.Size = New System.Drawing.Size(124, 22)
        Me.pupAddSub.Text = "添加新行"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(121, 6)
        Me.ToolStripSeparator1.Visible = False
        '
        'pupDel
        '
        Me.pupDel.Image = Global.IT_ProjectManager.My.Resources.Resources.OutlineCollapse
        Me.pupDel.Name = "pupDel"
        Me.pupDel.Size = New System.Drawing.Size(124, 22)
        Me.pupDel.Text = "删除行"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(121, 6)
        '
        'uploadData
        '
        Me.uploadData.Image = Global.IT_ProjectManager.My.Resources.Resources.Repeat
        Me.uploadData.Name = "uploadData"
        Me.uploadData.Size = New System.Drawing.Size(124, 22)
        Me.uploadData.Text = "刷新"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.CompanyNo, Me.deptno, Me.deptname, Me.create_by, Me.create_time, Me.update_by, Me.update_time})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'CompanyNo
        '
        Me.CompanyNo.Caption = "厂区"
        Me.CompanyNo.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.CompanyNo.FieldName = "CompanyNo"
        Me.CompanyNo.Name = "CompanyNo"
        Me.CompanyNo.Visible = True
        Me.CompanyNo.VisibleIndex = 0
        Me.CompanyNo.Width = 54
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyNo", "公司编号"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "公司名称")})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "CompanyName"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "CompanyNo"
        '
        'deptno
        '
        Me.deptno.Caption = "部门编号"
        Me.deptno.FieldName = "deptno"
        Me.deptno.Name = "deptno"
        Me.deptno.Visible = True
        Me.deptno.VisibleIndex = 1
        Me.deptno.Width = 81
        '
        'deptname
        '
        Me.deptname.Caption = "部门名称"
        Me.deptname.FieldName = "deptname"
        Me.deptname.Name = "deptname"
        Me.deptname.Visible = True
        Me.deptname.VisibleIndex = 2
        Me.deptname.Width = 81
        '
        'create_by
        '
        Me.create_by.Caption = "创建人员"
        Me.create_by.FieldName = "create_by"
        Me.create_by.Name = "create_by"
        Me.create_by.OptionsColumn.AllowEdit = False
        Me.create_by.Visible = True
        Me.create_by.VisibleIndex = 3
        Me.create_by.Width = 66
        '
        'create_time
        '
        Me.create_time.Caption = "创建时间"
        Me.create_time.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.create_time.FieldName = "create_time"
        Me.create_time.Name = "create_time"
        Me.create_time.OptionsColumn.AllowEdit = False
        Me.create_time.Visible = True
        Me.create_time.VisibleIndex = 4
        Me.create_time.Width = 102
        '
        'update_by
        '
        Me.update_by.Caption = "更新人员"
        Me.update_by.FieldName = "update_by"
        Me.update_by.Name = "update_by"
        Me.update_by.OptionsColumn.AllowEdit = False
        Me.update_by.Visible = True
        Me.update_by.VisibleIndex = 5
        Me.update_by.Width = 62
        '
        'update_time
        '
        Me.update_time.Caption = "更新时间"
        Me.update_time.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.update_time.FieldName = "update_time"
        Me.update_time.Name = "update_time"
        Me.update_time.OptionsColumn.AllowEdit = False
        Me.update_time.Visible = True
        Me.update_time.VisibleIndex = 6
        Me.update_time.Width = 104
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmdSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 263)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(568, 38)
        Me.Panel2.TabIndex = 1
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(468, 7)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(73, 28)
        Me.cmdSave.TabIndex = 11
        Me.cmdSave.Text = "保存"
        '
        'deptinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "deptinfo"
        Me.Size = New System.Drawing.Size(568, 301)
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pupProjectDetail.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CompanyNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deptno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deptname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents create_by As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents create_time As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents update_by As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents update_time As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pupProjectDetail As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents pupAddSub As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents pupDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents uploadData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

End Class
