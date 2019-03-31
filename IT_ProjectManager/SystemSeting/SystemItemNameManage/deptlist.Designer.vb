<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deptlist
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.deptno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.deptname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(358, 243)
        Me.Panel1.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(358, 243)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.CompanyName, Me.deptno, Me.deptname, Me.sel})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'CompanyName
        '
        Me.CompanyName.Caption = "厂区"
        Me.CompanyName.FieldName = "CompanyName"
        Me.CompanyName.Name = "CompanyName"
        Me.CompanyName.OptionsColumn.AllowEdit = False
        Me.CompanyName.Visible = True
        Me.CompanyName.VisibleIndex = 1
        Me.CompanyName.Width = 71
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
        Me.deptno.OptionsColumn.AllowEdit = False
        Me.deptno.Visible = True
        Me.deptno.VisibleIndex = 2
        Me.deptno.Width = 107
        '
        'deptname
        '
        Me.deptname.Caption = "部门名称"
        Me.deptname.FieldName = "deptname"
        Me.deptname.Name = "deptname"
        Me.deptname.OptionsColumn.AllowEdit = False
        Me.deptname.Visible = True
        Me.deptname.VisibleIndex = 3
        Me.deptname.Width = 110
        '
        'sel
        '
        Me.sel.Caption = "选择"
        Me.sel.FieldName = "sel"
        Me.sel.Name = "sel"
        Me.sel.Visible = True
        Me.sel.VisibleIndex = 0
        Me.sel.Width = 52
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmdExit)
        Me.Panel2.Controls.Add(Me.cmdSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 205)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(358, 38)
        Me.Panel2.TabIndex = 1
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(281, 7)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(73, 28)
        Me.cmdExit.TabIndex = 14
        Me.cmdExit.Text = "退出"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(188, 7)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(73, 28)
        Me.cmdSave.TabIndex = 13
        Me.cmdSave.Text = "保存"
        '
        'deptlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 243)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "deptlist"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "部门选择"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CompanyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents deptno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deptname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
End Class
