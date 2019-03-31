<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectSubDetail
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pupProjectDetail = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pupAddTask = New System.Windows.Forms.ToolStripMenuItem()
        Me.pupEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtID = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPriority = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPrjEndDate = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPrjName = New DevExpress.XtraEditors.LabelControl()
        Me.txtPreStartDate = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.FollowSch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Remark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.RepositoryItemProgressBar2 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GridAss = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.AssName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Emergency = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UserName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PreStatDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ActualStatDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PreEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AchualEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AssState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TaskDetail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemProgressBar3 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.Grid1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.FollowDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FollowID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CumulativeTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.editExplain = New DevExpress.XtraEditors.MemoEdit()
        Me.pupProjectDetail.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.GridAss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editExplain.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pupProjectDetail
        '
        Me.pupProjectDetail.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pupAddTask, Me.pupEdit, Me.ToolStripSeparator1})
        Me.pupProjectDetail.Name = "pupProjectDetail"
        Me.pupProjectDetail.Size = New System.Drawing.Size(101, 54)
        '
        'pupAddTask
        '
        Me.pupAddTask.Image = Global.IT_ProjectManager.My.Resources.Resources.OutlineExpand
        Me.pupAddTask.Name = "pupAddTask"
        Me.pupAddTask.Size = New System.Drawing.Size(100, 22)
        Me.pupAddTask.Text = "新增"
        '
        'pupEdit
        '
        Me.pupEdit.Image = Global.IT_ProjectManager.My.Resources.Resources.Repeat
        Me.pupEdit.Name = "pupEdit"
        Me.pupEdit.Size = New System.Drawing.Size(100, 22)
        Me.pupEdit.Text = "修改"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(97, 6)
        '
        'txtID
        '
        Me.txtID.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtID.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtID.Location = New System.Drawing.Point(683, 7)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(15, 19)
        Me.txtID.TabIndex = 32
        Me.txtID.Text = "ID"
        Me.txtID.Visible = False
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl25.Location = New System.Drawing.Point(12, 66)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(63, 17)
        Me.LabelControl25.TabIndex = 48
        Me.LabelControl25.Text = "说        明："
        '
        'txtPriority
        '
        Me.txtPriority.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPriority.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtPriority.Location = New System.Drawing.Point(419, 42)
        Me.txtPriority.Name = "txtPriority"
        Me.txtPriority.Size = New System.Drawing.Size(16, 17)
        Me.txtPriority.TabIndex = 8
        Me.txtPriority.Text = "30"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(364, 42)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(52, 17)
        Me.LabelControl5.TabIndex = 7
        Me.LabelControl5.Text = "优先度："
        '
        'txtPrjEndDate
        '
        Me.txtPrjEndDate.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPrjEndDate.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtPrjEndDate.Location = New System.Drawing.Point(256, 42)
        Me.txtPrjEndDate.Name = "txtPrjEndDate"
        Me.txtPrjEndDate.Size = New System.Drawing.Size(52, 17)
        Me.txtPrjEndDate.TabIndex = 37
        Me.txtPrjEndDate.Text = "计划结束"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl14.Location = New System.Drawing.Point(192, 42)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(65, 17)
        Me.LabelControl14.TabIndex = 36
        Me.LabelControl14.Text = "结束时间："
        '
        'txtPrjName
        '
        Me.txtPrjName.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPrjName.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtPrjName.Location = New System.Drawing.Point(82, 6)
        Me.txtPrjName.Name = "txtPrjName"
        Me.txtPrjName.Size = New System.Drawing.Size(60, 19)
        Me.txtPrjName.TabIndex = 4
        Me.txtPrjName.Text = "模块名称"
        '
        'txtPreStartDate
        '
        Me.txtPreStartDate.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPreStartDate.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtPreStartDate.Location = New System.Drawing.Point(83, 42)
        Me.txtPreStartDate.Name = "txtPreStartDate"
        Me.txtPreStartDate.Size = New System.Drawing.Size(52, 17)
        Me.txtPreStartDate.TabIndex = 33
        Me.txtPreStartDate.Text = "计划开始"
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.txtID)
        Me.PanelControl1.Controls.Add(Me.txtPrjName)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(5, 5)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(707, 31)
        Me.PanelControl1.TabIndex = 30
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(7, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(75, 19)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "模块名称："
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(12, 42)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(65, 17)
        Me.LabelControl10.TabIndex = 31
        Me.LabelControl10.Text = "开始时间："
        '
        'FollowSch
        '
        Me.FollowSch.AppearanceHeader.Options.UseTextOptions = True
        Me.FollowSch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FollowSch.Caption = "进度"
        Me.FollowSch.DisplayFormat.FormatString = "{0}%"
        Me.FollowSch.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FollowSch.FieldName = "FollowSch"
        Me.FollowSch.Name = "FollowSch"
        Me.FollowSch.OptionsColumn.AllowEdit = False
        Me.FollowSch.OptionsColumn.AllowFocus = False
        Me.FollowSch.OptionsColumn.AllowMove = False
        Me.FollowSch.OptionsColumn.AllowSize = False
        Me.FollowSch.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.FollowSch.Visible = True
        Me.FollowSch.VisibleIndex = 3
        Me.FollowSch.Width = 84
        '
        'Remark
        '
        Me.Remark.AppearanceHeader.Options.UseTextOptions = True
        Me.Remark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Remark.Caption = "备注"
        Me.Remark.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.Remark.FieldName = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.OptionsColumn.AllowMove = False
        Me.Remark.OptionsColumn.AllowSize = False
        Me.Remark.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Remark.Visible = True
        Me.Remark.VisibleIndex = 4
        Me.Remark.Width = 368
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemMemoExEdit1.Appearance.Options.UseFont = True
        Me.RepositoryItemMemoExEdit1.AppearanceDisabled.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemMemoExEdit1.AppearanceDisabled.Options.UseFont = True
        Me.RepositoryItemMemoExEdit1.AppearanceDropDown.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemMemoExEdit1.AppearanceDropDown.Options.UseFont = True
        Me.RepositoryItemMemoExEdit1.AppearanceFocused.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemMemoExEdit1.AppearanceFocused.Options.UseFont = True
        Me.RepositoryItemMemoExEdit1.AppearanceReadOnly.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemMemoExEdit1.AppearanceReadOnly.Options.UseFont = True
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ReadOnly = True
        Me.RepositoryItemMemoExEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepositoryItemProgressBar2
        '
        Me.RepositoryItemProgressBar2.EndColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RepositoryItemProgressBar2.Name = "RepositoryItemProgressBar2"
        Me.RepositoryItemProgressBar2.ReadOnly = True
        Me.RepositoryItemProgressBar2.ShowTitle = True
        Me.RepositoryItemProgressBar2.StartColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RepositoryItemProgressBar2.UseParentBackground = True
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl2.Horizontal = False
        Me.SplitContainerControl2.Location = New System.Drawing.Point(5, 133)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.GridAss)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.Grid1)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainerControl2.Size = New System.Drawing.Size(707, 406)
        Me.SplitContainerControl2.SplitterPosition = 160
        Me.SplitContainerControl2.TabIndex = 29
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'GridAss
        '
        Me.GridAss.ContextMenuStrip = Me.pupProjectDetail
        Me.GridAss.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAss.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridAss.Location = New System.Drawing.Point(0, 0)
        Me.GridAss.MainView = Me.GridView1
        Me.GridAss.Name = "GridAss"
        Me.GridAss.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar3, Me.RepositoryItemMemoExEdit2})
        Me.GridAss.Size = New System.Drawing.Size(707, 241)
        Me.GridAss.TabIndex = 4
        Me.GridAss.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Blue
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Blue
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseFont = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AssName, Me.Emergency, Me.UserName, Me.PreStatDate, Me.ActualStatDate, Me.PreEndDate, Me.AchualEndDate, Me.AssState, Me.TaskDetail, Me.ID})
        Me.GridView1.GridControl = Me.GridAss
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'AssName
        '
        Me.AssName.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssName.AppearanceHeader.Options.UseFont = True
        Me.AssName.AppearanceHeader.Options.UseTextOptions = True
        Me.AssName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AssName.Caption = "任务名称"
        Me.AssName.FieldName = "AssName"
        Me.AssName.Name = "AssName"
        Me.AssName.OptionsColumn.AllowEdit = False
        Me.AssName.OptionsColumn.AllowFocus = False
        Me.AssName.OptionsColumn.AllowMove = False
        Me.AssName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.AssName.Visible = True
        Me.AssName.VisibleIndex = 0
        Me.AssName.Width = 230
        '
        'Emergency
        '
        Me.Emergency.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emergency.AppearanceHeader.Options.UseFont = True
        Me.Emergency.AppearanceHeader.Options.UseTextOptions = True
        Me.Emergency.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Emergency.Caption = "！"
        Me.Emergency.FieldName = "Emergency"
        Me.Emergency.Name = "Emergency"
        Me.Emergency.OptionsColumn.AllowEdit = False
        Me.Emergency.OptionsColumn.AllowFocus = False
        Me.Emergency.OptionsColumn.AllowMove = False
        Me.Emergency.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.Emergency.Visible = True
        Me.Emergency.VisibleIndex = 1
        Me.Emergency.Width = 30
        '
        'UserName
        '
        Me.UserName.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName.AppearanceHeader.Options.UseFont = True
        Me.UserName.AppearanceHeader.Options.UseTextOptions = True
        Me.UserName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.UserName.Caption = "跟进人"
        Me.UserName.FieldName = "UserName"
        Me.UserName.Name = "UserName"
        Me.UserName.OptionsColumn.AllowEdit = False
        Me.UserName.OptionsColumn.AllowFocus = False
        Me.UserName.OptionsColumn.AllowMove = False
        Me.UserName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.UserName.Visible = True
        Me.UserName.VisibleIndex = 2
        Me.UserName.Width = 60
        '
        'PreStatDate
        '
        Me.PreStatDate.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreStatDate.AppearanceHeader.Options.UseFont = True
        Me.PreStatDate.AppearanceHeader.Options.UseTextOptions = True
        Me.PreStatDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PreStatDate.Caption = "计划开始"
        Me.PreStatDate.DisplayFormat.FormatString = "d"
        Me.PreStatDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PreStatDate.FieldName = "PreStatDate"
        Me.PreStatDate.Name = "PreStatDate"
        Me.PreStatDate.OptionsColumn.AllowEdit = False
        Me.PreStatDate.OptionsColumn.AllowFocus = False
        Me.PreStatDate.OptionsColumn.AllowMove = False
        Me.PreStatDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.PreStatDate.Visible = True
        Me.PreStatDate.VisibleIndex = 3
        '
        'ActualStatDate
        '
        Me.ActualStatDate.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualStatDate.AppearanceHeader.Options.UseFont = True
        Me.ActualStatDate.AppearanceHeader.Options.UseTextOptions = True
        Me.ActualStatDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ActualStatDate.Caption = "实际开始"
        Me.ActualStatDate.DisplayFormat.FormatString = "d"
        Me.ActualStatDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ActualStatDate.FieldName = "ActualStatDate"
        Me.ActualStatDate.Name = "ActualStatDate"
        Me.ActualStatDate.OptionsColumn.AllowEdit = False
        Me.ActualStatDate.OptionsColumn.AllowFocus = False
        Me.ActualStatDate.OptionsColumn.AllowMove = False
        Me.ActualStatDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.ActualStatDate.Visible = True
        Me.ActualStatDate.VisibleIndex = 4
        '
        'PreEndDate
        '
        Me.PreEndDate.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreEndDate.AppearanceHeader.Options.UseFont = True
        Me.PreEndDate.AppearanceHeader.Options.UseTextOptions = True
        Me.PreEndDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PreEndDate.Caption = "计划结束"
        Me.PreEndDate.DisplayFormat.FormatString = "d"
        Me.PreEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PreEndDate.FieldName = "PreEndDate"
        Me.PreEndDate.Name = "PreEndDate"
        Me.PreEndDate.OptionsColumn.AllowEdit = False
        Me.PreEndDate.OptionsColumn.AllowFocus = False
        Me.PreEndDate.OptionsColumn.AllowMove = False
        Me.PreEndDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.PreEndDate.Visible = True
        Me.PreEndDate.VisibleIndex = 5
        Me.PreEndDate.Width = 81
        '
        'AchualEndDate
        '
        Me.AchualEndDate.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AchualEndDate.AppearanceHeader.Options.UseFont = True
        Me.AchualEndDate.AppearanceHeader.Options.UseTextOptions = True
        Me.AchualEndDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AchualEndDate.Caption = "实际结束"
        Me.AchualEndDate.DisplayFormat.FormatString = "d"
        Me.AchualEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.AchualEndDate.FieldName = "AchualEndDate"
        Me.AchualEndDate.Name = "AchualEndDate"
        Me.AchualEndDate.OptionsColumn.AllowEdit = False
        Me.AchualEndDate.OptionsColumn.AllowFocus = False
        Me.AchualEndDate.OptionsColumn.AllowMove = False
        Me.AchualEndDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.AchualEndDate.Visible = True
        Me.AchualEndDate.VisibleIndex = 6
        Me.AchualEndDate.Width = 79
        '
        'AssState
        '
        Me.AssState.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssState.AppearanceHeader.Options.UseFont = True
        Me.AssState.AppearanceHeader.Options.UseTextOptions = True
        Me.AssState.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AssState.Caption = "状态"
        Me.AssState.FieldName = "AssState"
        Me.AssState.Name = "AssState"
        '
        'TaskDetail
        '
        Me.TaskDetail.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskDetail.AppearanceHeader.Options.UseFont = True
        Me.TaskDetail.AppearanceHeader.Options.UseTextOptions = True
        Me.TaskDetail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TaskDetail.Caption = "任务详细"
        Me.TaskDetail.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.TaskDetail.FieldName = "TaskDetail"
        Me.TaskDetail.Name = "TaskDetail"
        Me.TaskDetail.Visible = True
        Me.TaskDetail.VisibleIndex = 7
        Me.TaskDetail.Width = 71
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemMemoExEdit2.Appearance.Options.UseFont = True
        Me.RepositoryItemMemoExEdit2.AppearanceDisabled.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemMemoExEdit2.AppearanceDisabled.Options.UseFont = True
        Me.RepositoryItemMemoExEdit2.AppearanceDropDown.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemMemoExEdit2.AppearanceDropDown.Options.UseFont = True
        Me.RepositoryItemMemoExEdit2.AppearanceFocused.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemMemoExEdit2.AppearanceFocused.Options.UseFont = True
        Me.RepositoryItemMemoExEdit2.AppearanceReadOnly.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemMemoExEdit2.AppearanceReadOnly.Options.UseFont = True
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ReadOnly = True
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'ID
        '
        Me.ID.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.AppearanceHeader.Options.UseFont = True
        Me.ID.AppearanceHeader.Options.UseTextOptions = True
        Me.ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ID.Caption = "ID"
        Me.ID.FieldName = "ID"
        Me.ID.Name = "ID"
        '
        'RepositoryItemProgressBar3
        '
        Me.RepositoryItemProgressBar3.EndColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RepositoryItemProgressBar3.Name = "RepositoryItemProgressBar3"
        Me.RepositoryItemProgressBar3.ReadOnly = True
        Me.RepositoryItemProgressBar3.ShowTitle = True
        Me.RepositoryItemProgressBar3.StartColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RepositoryItemProgressBar3.UseParentBackground = True
        '
        'Grid1
        '
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView2
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar2, Me.RepositoryItemMemoExEdit1})
        Me.Grid1.Size = New System.Drawing.Size(707, 160)
        Me.Grid1.TabIndex = 3
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridView2.Appearance.Row.Options.UseFont = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.FollowDate, Me.FollowID, Me.CumulativeTime, Me.FollowSch, Me.Remark})
        Me.GridView2.GridControl = Me.Grid1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'FollowDate
        '
        Me.FollowDate.AppearanceHeader.Options.UseTextOptions = True
        Me.FollowDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FollowDate.Caption = "跟进日期"
        Me.FollowDate.FieldName = "FollowDate"
        Me.FollowDate.Name = "FollowDate"
        Me.FollowDate.OptionsColumn.AllowEdit = False
        Me.FollowDate.OptionsColumn.AllowFocus = False
        Me.FollowDate.OptionsColumn.AllowMove = False
        Me.FollowDate.OptionsColumn.AllowSize = False
        Me.FollowDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.FollowDate.Visible = True
        Me.FollowDate.VisibleIndex = 0
        Me.FollowDate.Width = 94
        '
        'FollowID
        '
        Me.FollowID.AppearanceHeader.Options.UseTextOptions = True
        Me.FollowID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FollowID.Caption = "跟进人"
        Me.FollowID.FieldName = "FollowID"
        Me.FollowID.Name = "FollowID"
        Me.FollowID.OptionsColumn.AllowEdit = False
        Me.FollowID.OptionsColumn.AllowFocus = False
        Me.FollowID.OptionsColumn.AllowMove = False
        Me.FollowID.OptionsColumn.AllowSize = False
        Me.FollowID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.FollowID.Visible = True
        Me.FollowID.VisibleIndex = 1
        Me.FollowID.Width = 91
        '
        'CumulativeTime
        '
        Me.CumulativeTime.AppearanceHeader.Options.UseTextOptions = True
        Me.CumulativeTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CumulativeTime.Caption = "时间"
        Me.CumulativeTime.FieldName = "CumulativeTime"
        Me.CumulativeTime.Name = "CumulativeTime"
        Me.CumulativeTime.OptionsColumn.AllowEdit = False
        Me.CumulativeTime.OptionsColumn.AllowFocus = False
        Me.CumulativeTime.OptionsColumn.AllowMove = False
        Me.CumulativeTime.OptionsColumn.AllowSize = False
        Me.CumulativeTime.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.CumulativeTime.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.CumulativeTime.Visible = True
        Me.CumulativeTime.VisibleIndex = 2
        Me.CumulativeTime.Width = 92
        '
        'editExplain
        '
        Me.editExplain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editExplain.Location = New System.Drawing.Point(81, 65)
        Me.editExplain.Name = "editExplain"
        Me.editExplain.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.editExplain.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editExplain.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.editExplain.Properties.Appearance.Options.UseBackColor = True
        Me.editExplain.Properties.Appearance.Options.UseFont = True
        Me.editExplain.Properties.Appearance.Options.UseForeColor = True
        Me.editExplain.Properties.ReadOnly = True
        Me.editExplain.Size = New System.Drawing.Size(629, 62)
        Me.editExplain.TabIndex = 49
        '
        'frmProjectSubDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 542)
        Me.Controls.Add(Me.txtPriority)
        Me.Controls.Add(Me.txtPreStartDate)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl25)
        Me.Controls.Add(Me.txtPrjEndDate)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.SplitContainerControl2)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.editExplain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProjectSubDetail"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "模块详细"
        Me.pupProjectDetail.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.GridAss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editExplain.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pupProjectDetail As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents pupAddTask As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pupEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPriority As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrjEndDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrjName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPreStartDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FollowSch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemProgressBar2 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FollowDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FollowID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CumulativeTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents editExplain As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GridAss As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AssName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Emergency As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PreStatDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ActualStatDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PreEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AchualEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TaskDetail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemProgressBar3 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents AssState As DevExpress.XtraGrid.Columns.GridColumn
End Class
