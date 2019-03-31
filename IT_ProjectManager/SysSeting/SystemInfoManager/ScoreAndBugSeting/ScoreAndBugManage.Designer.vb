<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScoreAndBugManage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScoreAndBugManage))
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GradeStandard = New DevExpress.XtraTab.XtraTabPage()
        Me.gridGradeStandard = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GS_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GS_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GS_Remark = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.gridAssess = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btSave = New DevExpress.XtraEditors.SimpleButton()
        Me.lblRemarks = New DevExpress.XtraEditors.LabelControl()
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        Me.lblName = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradeStandard.SuspendLayout()
        CType(Me.gridGradeStandard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtControl.SuspendLayout()
        Me.BugType.SuspendLayout()
        CType(Me.BugManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Assess.SuspendLayout()
        CType(Me.gridAssess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
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
        'GradeStandard
        '
        Me.GradeStandard.Controls.Add(Me.gridGradeStandard)
        Me.GradeStandard.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GradeStandard.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GradeStandard.Name = "GradeStandard"
        Me.GradeStandard.Size = New System.Drawing.Size(544, 376)
        Me.GradeStandard.Text = "評分類型管理"
        '
        'gridGradeStandard
        '
        Me.gridGradeStandard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridGradeStandard.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gridGradeStandard.Location = New System.Drawing.Point(0, 0)
        Me.gridGradeStandard.MainView = Me.GridView1
        Me.gridGradeStandard.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gridGradeStandard.Name = "gridGradeStandard"
        Me.gridGradeStandard.Size = New System.Drawing.Size(544, 376)
        Me.gridGradeStandard.TabIndex = 1
        Me.gridGradeStandard.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GS_ID, Me.GS_Name, Me.GS_Remark})
        Me.GridView1.GridControl = Me.gridGradeStandard
        Me.GridView1.GroupPanelText = "Delete：刪除（選中某筆數據，按下鍵盤Delete鍵執行刪除操作）；雙擊修改選中項"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'GS_ID
        '
        Me.GS_ID.AppearanceHeader.Font = New System.Drawing.Font("微軟正黑體", 9.0!)
        Me.GS_ID.AppearanceHeader.Options.UseFont = True
        Me.GS_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GS_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GS_ID.Caption = "ID"
        Me.GS_ID.FieldName = "GS_ID"
        Me.GS_ID.Name = "GS_ID"
        Me.GS_ID.Visible = True
        Me.GS_ID.VisibleIndex = 0
        Me.GS_ID.Width = 40
        '
        'GS_Name
        '
        Me.GS_Name.AppearanceHeader.Font = New System.Drawing.Font("微軟正黑體", 9.0!)
        Me.GS_Name.AppearanceHeader.Options.UseFont = True
        Me.GS_Name.AppearanceHeader.Options.UseTextOptions = True
        Me.GS_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GS_Name.Caption = "評分名稱"
        Me.GS_Name.FieldName = "GS_Name"
        Me.GS_Name.Name = "GS_Name"
        Me.GS_Name.OptionsColumn.AllowEdit = False
        Me.GS_Name.OptionsColumn.AllowFocus = False
        Me.GS_Name.OptionsColumn.FixedWidth = True
        Me.GS_Name.OptionsColumn.ReadOnly = True
        Me.GS_Name.Visible = True
        Me.GS_Name.VisibleIndex = 1
        Me.GS_Name.Width = 250
        '
        'GS_Remark
        '
        Me.GS_Remark.AppearanceHeader.Font = New System.Drawing.Font("微軟正黑體", 9.0!)
        Me.GS_Remark.AppearanceHeader.Options.UseFont = True
        Me.GS_Remark.AppearanceHeader.Options.UseTextOptions = True
        Me.GS_Remark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GS_Remark.Caption = "備註"
        Me.GS_Remark.FieldName = "GS_Remark"
        Me.GS_Remark.Name = "GS_Remark"
        Me.GS_Remark.OptionsColumn.AllowFocus = False
        Me.GS_Remark.OptionsColumn.FixedWidth = True
        Me.GS_Remark.OptionsColumn.ReadOnly = True
        Me.GS_Remark.Visible = True
        Me.GS_Remark.VisibleIndex = 2
        Me.GS_Remark.Width = 250
        '
        'xtControl
        '
        Me.xtControl.Appearance.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtControl.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.xtControl.Appearance.Options.UseFont = True
        Me.xtControl.Appearance.Options.UseForeColor = True
        Me.xtControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.xtControl.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.xtControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtControl.Location = New System.Drawing.Point(0, 165)
        Me.xtControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.xtControl.Name = "xtControl"
        Me.xtControl.SelectedTabPage = Me.GradeStandard
        Me.xtControl.Size = New System.Drawing.Size(552, 407)
        Me.xtControl.TabIndex = 0
        Me.xtControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.GradeStandard, Me.BugType, Me.Assess})
        '
        'BugType
        '
        Me.BugType.Controls.Add(Me.BugManager)
        Me.BugType.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BugType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BugType.Name = "BugType"
        Me.BugType.Size = New System.Drawing.Size(544, 376)
        Me.BugType.Text = "Bug類型管理"
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
        Me.BugManager.Size = New System.Drawing.Size(544, 376)
        Me.BugManager.TabIndex = 3
        Me.BugManager.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView3.GridControl = Me.BugManager
        Me.GridView3.GroupPanelText = "Delete：刪除（選中某筆數據，按下鍵盤Delete鍵執行刪除操作）,雙擊修改選中項"
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.RowAutoHeight = True
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Bug類型"
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
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "備註"
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
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "創建人"
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
        Me.Assess.Controls.Add(Me.gridAssess)
        Me.Assess.Name = "Assess"
        Me.Assess.Size = New System.Drawing.Size(544, 376)
        Me.Assess.Text = "考核類型管理"
        '
        'gridAssess
        '
        Me.gridAssess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridAssess.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gridAssess.Location = New System.Drawing.Point(0, 0)
        Me.gridAssess.MainView = Me.GridView2
        Me.gridAssess.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gridAssess.Name = "gridAssess"
        Me.gridAssess.Size = New System.Drawing.Size(544, 376)
        Me.gridAssess.TabIndex = 2
        Me.gridAssess.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.GridView2.GridControl = Me.gridAssess
        Me.GridView2.GroupPanelText = "Delete：刪除（選中某筆數據，按下鍵盤Delete鍵執行刪除操作）；雙擊修改選中項"
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("微軟正黑體", 9.0!)
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "ID"
        Me.GridColumn5.FieldName = "GS_ID"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        Me.GridColumn5.Width = 40
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("微軟正黑體", 9.0!)
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "考核名稱"
        Me.GridColumn6.FieldName = "GS_Name"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.AllowFocus = False
        Me.GridColumn6.OptionsColumn.FixedWidth = True
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 250
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("微軟正黑體", 9.0!)
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "備註"
        Me.GridColumn7.FieldName = "GS_Remark"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowFocus = False
        Me.GridColumn7.OptionsColumn.FixedWidth = True
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        Me.GridColumn7.Width = 250
        '
        'PanelControl1
        '
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
        'btClose
        '
        Me.btClose.Appearance.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btClose.Appearance.Options.UseFont = True
        Me.btClose.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestDeny
        Me.btClose.Location = New System.Drawing.Point(460, 129)
        Me.btClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(80, 29)
        Me.btClose.TabIndex = 5
        Me.btClose.Text = "關閉"
        '
        'btSave
        '
        Me.btSave.Appearance.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btSave.Appearance.Options.UseFont = True
        Me.btSave.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestAllow
        Me.btSave.Location = New System.Drawing.Point(351, 129)
        Me.btSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(80, 29)
        Me.btSave.TabIndex = 4
        Me.btSave.Text = "確認"
        '
        'lblRemarks
        '
        Me.lblRemarks.Appearance.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemarks.Location = New System.Drawing.Point(7, 49)
        Me.lblRemarks.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(48, 16)
        Me.lblRemarks.TabIndex = 3
        Me.lblRemarks.Text = "備        註"
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
        Me.lblName.Appearance.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(7, 16)
        Me.lblName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "評分標準 "
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
        'ScoreAndBugManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 572)
        Me.Controls.Add(Me.xtControl)
        Me.Controls.Add(Me.PanelControl1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ScoreAndBugManage"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "系統資料管理"
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradeStandard.ResumeLayout(False)
        CType(Me.gridGradeStandard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtControl.ResumeLayout(False)
        Me.BugType.ResumeLayout(False)
        CType(Me.BugManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Assess.ResumeLayout(False)
        CType(Me.gridAssess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GradeStandard As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gridGradeStandard As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblRemarks As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GS_Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GS_ID As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents gridAssess As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
End Class
