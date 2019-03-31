<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectDetail
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
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.SplitContainerControl5 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.MemoEdit2 = New DevExpress.XtraEditors.MemoEdit()
        Me.Grid1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.FollowDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FollowID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CumulativeTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FollowSch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Remark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.RepositoryItemProgressBar2 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList()
        Me.IDName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.priority = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.PrincipalUID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.FollowUID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.ActualStatDate = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.AchualEndDate = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TotalTime = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.AssGrade = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.workComplete = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.assID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.CID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.PID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.pupProjectDetail = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pupAddSub = New System.Windows.Forms.ToolStripMenuItem()
        Me.pupAddTask = New System.Windows.Forms.ToolStripMenuItem()
        Me.pupEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.pupDel = New System.Windows.Forms.ToolStripMenuItem()
        Me.pupToExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.uploadData = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtSmStatus = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmergency = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtImport = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSchemeName = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtID = New DevExpress.XtraEditors.LabelControl()
        Me.txtSmStartDate = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSmPrincipal = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSmEndDate = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSmFollow = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDepartment = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLinkman = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSmType = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCompany = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.editExplain = New DevExpress.XtraEditors.MemoEdit()
        Me.GridMyToDo = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkComplete = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.TD_StartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TD_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.TD_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemProgressBar3 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.SplitContainerControl3 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.SplitContainerControl4 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl5.SuspendLayout()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pupProjectDetail.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.editExplain.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridMyToDo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkComplete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl3.SuspendLayout()
        CType(Me.SplitContainerControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl4.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.MemoEdit1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SplitContainerControl5)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(573, 160)
        Me.SplitContainerControl1.SplitterPosition = 175
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit1.Location = New System.Drawing.Point(0, 0)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.MemoEdit1.Properties.Appearance.Options.UseFont = True
        Me.MemoEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.MemoEdit1.Properties.ReadOnly = True
        Me.MemoEdit1.Size = New System.Drawing.Size(175, 160)
        Me.MemoEdit1.TabIndex = 0
        '
        'SplitContainerControl5
        '
        Me.SplitContainerControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl5.Name = "SplitContainerControl5"
        Me.SplitContainerControl5.Panel1.Controls.Add(Me.MemoEdit2)
        Me.SplitContainerControl5.Panel1.Text = "Panel1"
        Me.SplitContainerControl5.Panel2.Controls.Add(Me.Grid1)
        Me.SplitContainerControl5.Panel2.Text = "Panel2"
        Me.SplitContainerControl5.Size = New System.Drawing.Size(393, 160)
        Me.SplitContainerControl5.SplitterPosition = 200
        Me.SplitContainerControl5.TabIndex = 0
        Me.SplitContainerControl5.Text = "SplitContainerControl5"
        '
        'MemoEdit2
        '
        Me.MemoEdit2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit2.Location = New System.Drawing.Point(0, 0)
        Me.MemoEdit2.Name = "MemoEdit2"
        Me.MemoEdit2.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemoEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.MemoEdit2.Properties.Appearance.Options.UseFont = True
        Me.MemoEdit2.Properties.Appearance.Options.UseForeColor = True
        Me.MemoEdit2.Properties.ReadOnly = True
        Me.MemoEdit2.Size = New System.Drawing.Size(200, 160)
        Me.MemoEdit2.TabIndex = 1
        '
        'Grid1
        '
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView2
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar2, Me.RepositoryItemMemoExEdit1})
        Me.Grid1.Size = New System.Drawing.Size(188, 160)
        Me.Grid1.TabIndex = 4
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
        Me.FollowDate.Width = 80
        '
        'FollowID
        '
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
        '
        'CumulativeTime
        '
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
        '
        'FollowSch
        '
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
        '
        'Remark
        '
        Me.Remark.Caption = "备注"
        Me.Remark.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.Remark.FieldName = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.OptionsColumn.AllowMove = False
        Me.Remark.OptionsColumn.AllowSize = False
        Me.Remark.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Remark.Visible = True
        Me.Remark.VisibleIndex = 4
        Me.Remark.Width = 141
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
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl2.Horizontal = False
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.TreeList1)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.SplitContainerControl1)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainerControl2.Size = New System.Drawing.Size(573, 412)
        Me.SplitContainerControl2.SplitterPosition = 160
        Me.SplitContainerControl2.TabIndex = 1
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'TreeList1
        '
        Me.TreeList1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeList1.Appearance.HeaderPanel.Options.UseFont = True
        Me.TreeList1.Appearance.Row.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeList1.Appearance.Row.Options.UseFont = True
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.IDName, Me.priority, Me.PrincipalUID, Me.FollowUID, Me.ActualStatDate, Me.AchualEndDate, Me.TotalTime, Me.AssGrade, Me.workComplete, Me.assID, Me.CID, Me.PID})
        Me.TreeList1.ContextMenuStrip = Me.pupProjectDetail
        Me.TreeList1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeList1.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TreeList1.KeyFieldName = "CID"
        Me.TreeList1.Location = New System.Drawing.Point(0, 0)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.OptionsPrint.AutoWidth = False
        Me.TreeList1.OptionsView.AutoWidth = False
        Me.TreeList1.OptionsView.ShowHorzLines = False
        Me.TreeList1.OptionsView.ShowIndicator = False
        Me.TreeList1.OptionsView.ShowSummaryFooter = True
        Me.TreeList1.OptionsView.ShowVertLines = False
        Me.TreeList1.ParentFieldName = "PID"
        Me.TreeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar1})
        Me.TreeList1.Size = New System.Drawing.Size(573, 247)
        Me.TreeList1.TabIndex = 0
        '
        'IDName
        '
        Me.IDName.Caption = "系统名称"
        Me.IDName.FieldName = "IDName"
        Me.IDName.Name = "IDName"
        Me.IDName.OptionsColumn.AllowEdit = False
        Me.IDName.OptionsColumn.AllowFocus = False
        Me.IDName.OptionsColumn.AllowMove = False
        Me.IDName.Visible = True
        Me.IDName.VisibleIndex = 0
        Me.IDName.Width = 250
        '
        'priority
        '
        Me.priority.Caption = "！"
        Me.priority.FieldName = "priority"
        Me.priority.Name = "priority"
        Me.priority.OptionsColumn.AllowEdit = False
        Me.priority.OptionsColumn.AllowFocus = False
        Me.priority.OptionsColumn.AllowMove = False
        Me.priority.Visible = True
        Me.priority.VisibleIndex = 1
        Me.priority.Width = 30
        '
        'PrincipalUID
        '
        Me.PrincipalUID.Caption = "负责人"
        Me.PrincipalUID.FieldName = "PrincipalUID"
        Me.PrincipalUID.Name = "PrincipalUID"
        Me.PrincipalUID.OptionsColumn.AllowEdit = False
        Me.PrincipalUID.OptionsColumn.AllowFocus = False
        Me.PrincipalUID.OptionsColumn.AllowMove = False
        Me.PrincipalUID.Visible = True
        Me.PrincipalUID.VisibleIndex = 2
        Me.PrincipalUID.Width = 80
        '
        'FollowUID
        '
        Me.FollowUID.Caption = "跟进人"
        Me.FollowUID.FieldName = "FollowUID"
        Me.FollowUID.Name = "FollowUID"
        Me.FollowUID.OptionsColumn.AllowEdit = False
        Me.FollowUID.OptionsColumn.AllowFocus = False
        Me.FollowUID.OptionsColumn.AllowMove = False
        Me.FollowUID.Visible = True
        Me.FollowUID.VisibleIndex = 3
        Me.FollowUID.Width = 80
        '
        'ActualStatDate
        '
        Me.ActualStatDate.Caption = "开始时间"
        Me.ActualStatDate.FieldName = "PreStatDate"
        Me.ActualStatDate.Format.FormatString = "yyyy/MM/dd"
        Me.ActualStatDate.Format.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ActualStatDate.Name = "ActualStatDate"
        Me.ActualStatDate.OptionsColumn.AllowEdit = False
        Me.ActualStatDate.OptionsColumn.AllowFocus = False
        Me.ActualStatDate.OptionsColumn.AllowMove = False
        Me.ActualStatDate.Visible = True
        Me.ActualStatDate.VisibleIndex = 4
        Me.ActualStatDate.Width = 100
        '
        'AchualEndDate
        '
        Me.AchualEndDate.Caption = "结束时间"
        Me.AchualEndDate.FieldName = "PreEndDate"
        Me.AchualEndDate.Format.FormatString = "yyyy/MM/dd"
        Me.AchualEndDate.Format.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.AchualEndDate.Name = "AchualEndDate"
        Me.AchualEndDate.OptionsColumn.AllowEdit = False
        Me.AchualEndDate.OptionsColumn.AllowFocus = False
        Me.AchualEndDate.OptionsColumn.AllowMove = False
        Me.AchualEndDate.Visible = True
        Me.AchualEndDate.VisibleIndex = 5
        Me.AchualEndDate.Width = 100
        '
        'TotalTime
        '
        Me.TotalTime.Caption = "总时间"
        Me.TotalTime.FieldName = "TotalTime"
        Me.TotalTime.Name = "TotalTime"
        Me.TotalTime.OptionsColumn.AllowEdit = False
        Me.TotalTime.OptionsColumn.AllowFocus = False
        Me.TotalTime.OptionsColumn.AllowMove = False
        Me.TotalTime.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum
        Me.TotalTime.Visible = True
        Me.TotalTime.VisibleIndex = 6
        Me.TotalTime.Width = 100
        '
        'AssGrade
        '
        Me.AssGrade.Caption = "评分"
        Me.AssGrade.FieldName = "AssGrade"
        Me.AssGrade.Name = "AssGrade"
        Me.AssGrade.OptionsColumn.AllowEdit = False
        Me.AssGrade.OptionsColumn.AllowFocus = False
        Me.AssGrade.OptionsColumn.AllowMove = False
        Me.AssGrade.Visible = True
        Me.AssGrade.VisibleIndex = 7
        Me.AssGrade.Width = 50
        '
        'workComplete
        '
        Me.workComplete.Caption = "任务进度"
        Me.workComplete.ColumnEdit = Me.RepositoryItemProgressBar1
        Me.workComplete.FieldName = "workComplete"
        Me.workComplete.Name = "workComplete"
        Me.workComplete.OptionsColumn.AllowEdit = False
        Me.workComplete.OptionsColumn.AllowFocus = False
        Me.workComplete.OptionsColumn.AllowMove = False
        Me.workComplete.Visible = True
        Me.workComplete.VisibleIndex = 8
        Me.workComplete.Width = 70
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        Me.RepositoryItemProgressBar1.ReadOnly = True
        Me.RepositoryItemProgressBar1.ShowTitle = True
        '
        'assID
        '
        Me.assID.Caption = "任务ID"
        Me.assID.FieldName = "assID"
        Me.assID.Name = "assID"
        Me.assID.OptionsColumn.AllowEdit = False
        Me.assID.OptionsColumn.AllowFocus = False
        Me.assID.OptionsColumn.AllowMove = False
        Me.assID.OptionsColumn.AllowSort = False
        '
        'CID
        '
        Me.CID.Caption = "CID"
        Me.CID.FieldName = "CID"
        Me.CID.Name = "CID"
        '
        'PID
        '
        Me.PID.Caption = "PID"
        Me.PID.FieldName = "PID"
        Me.PID.Name = "PID"
        '
        'pupProjectDetail
        '
        Me.pupProjectDetail.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pupAddSub, Me.pupAddTask, Me.pupEdit, Me.ToolStripSeparator1, Me.pupDel, Me.pupToExcel, Me.ToolStripMenuItem1, Me.uploadData})
        Me.pupProjectDetail.Name = "pupProjectDetail"
        Me.pupProjectDetail.Size = New System.Drawing.Size(125, 148)
        '
        'pupAddSub
        '
        Me.pupAddSub.Image = Global.IT_ProjectManager.My.Resources.Resources.OutlineExpand
        Me.pupAddSub.Name = "pupAddSub"
        Me.pupAddSub.Size = New System.Drawing.Size(124, 22)
        Me.pupAddSub.Text = "添加模块"
        '
        'pupAddTask
        '
        Me.pupAddTask.Image = Global.IT_ProjectManager.My.Resources.Resources.QueryAppend
        Me.pupAddTask.Name = "pupAddTask"
        Me.pupAddTask.Size = New System.Drawing.Size(124, 22)
        Me.pupAddTask.Text = "添加任务"
        '
        'pupEdit
        '
        Me.pupEdit.Image = Global.IT_ProjectManager.My.Resources.Resources.Repeat
        Me.pupEdit.Name = "pupEdit"
        Me.pupEdit.Size = New System.Drawing.Size(124, 22)
        Me.pupEdit.Text = "修改"
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
        Me.pupDel.Text = "删除"
        '
        'pupToExcel
        '
        Me.pupToExcel.Image = Global.IT_ProjectManager.My.Resources.Resources.OrganizerHS
        Me.pupToExcel.Name = "pupToExcel"
        Me.pupToExcel.Size = New System.Drawing.Size(124, 22)
        Me.pupToExcel.Text = "导出数据"
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
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.txtSmStatus)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.txtEmergency)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txtImport)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.txtSchemeName)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(2, 3)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(978, 31)
        Me.PanelControl1.TabIndex = 2
        '
        'txtSmStatus
        '
        Me.txtSmStatus.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSmStatus.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtSmStatus.Location = New System.Drawing.Point(689, 7)
        Me.txtSmStatus.Name = "txtSmStatus"
        Me.txtSmStatus.Size = New System.Drawing.Size(26, 17)
        Me.txtSmStatus.TabIndex = 10
        Me.txtSmStatus.Text = "进行"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(621, 7)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(65, 17)
        Me.LabelControl7.TabIndex = 9
        Me.LabelControl7.Text = "进度状态："
        '
        'txtEmergency
        '
        Me.txtEmergency.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtEmergency.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtEmergency.Location = New System.Drawing.Point(594, 7)
        Me.txtEmergency.Name = "txtEmergency"
        Me.txtEmergency.Size = New System.Drawing.Size(16, 17)
        Me.txtEmergency.TabIndex = 8
        Me.txtEmergency.Text = "30"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(539, 7)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(52, 17)
        Me.LabelControl5.TabIndex = 7
        Me.LabelControl5.Text = "紧急度："
        '
        'txtImport
        '
        Me.txtImport.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtImport.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtImport.Location = New System.Drawing.Point(517, 7)
        Me.txtImport.Name = "txtImport"
        Me.txtImport.Size = New System.Drawing.Size(13, 17)
        Me.txtImport.TabIndex = 6
        Me.txtImport.Text = "中"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(461, 7)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(52, 17)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "重要度："
        '
        'txtSchemeName
        '
        Me.txtSchemeName.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSchemeName.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtSchemeName.Location = New System.Drawing.Point(84, 6)
        Me.txtSchemeName.Name = "txtSchemeName"
        Me.txtSchemeName.Size = New System.Drawing.Size(60, 19)
        Me.txtSchemeName.TabIndex = 4
        Me.txtSchemeName.Text = "方案名称"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(6, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(75, 19)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "方案名称："
        '
        'txtID
        '
        Me.txtID.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtID.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtID.Location = New System.Drawing.Point(654, 41)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(15, 19)
        Me.txtID.TabIndex = 11
        Me.txtID.Text = "ID"
        Me.txtID.Visible = False
        '
        'txtSmStartDate
        '
        Me.txtSmStartDate.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSmStartDate.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtSmStartDate.Location = New System.Drawing.Point(83, 40)
        Me.txtSmStartDate.Name = "txtSmStartDate"
        Me.txtSmStartDate.Size = New System.Drawing.Size(52, 17)
        Me.txtSmStartDate.TabIndex = 12
        Me.txtSmStartDate.Text = "重要度："
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(12, 40)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(65, 17)
        Me.LabelControl10.TabIndex = 11
        Me.LabelControl10.Text = "开始时间："
        '
        'txtSmPrincipal
        '
        Me.txtSmPrincipal.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSmPrincipal.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtSmPrincipal.Location = New System.Drawing.Point(225, 41)
        Me.txtSmPrincipal.Name = "txtSmPrincipal"
        Me.txtSmPrincipal.Size = New System.Drawing.Size(52, 17)
        Me.txtSmPrincipal.TabIndex = 14
        Me.txtSmPrincipal.Text = "重要度："
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl12.Location = New System.Drawing.Point(167, 40)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(52, 17)
        Me.LabelControl12.TabIndex = 13
        Me.LabelControl12.Text = "负责人："
        '
        'txtSmEndDate
        '
        Me.txtSmEndDate.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSmEndDate.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtSmEndDate.Location = New System.Drawing.Point(83, 63)
        Me.txtSmEndDate.Name = "txtSmEndDate"
        Me.txtSmEndDate.Size = New System.Drawing.Size(52, 17)
        Me.txtSmEndDate.TabIndex = 16
        Me.txtSmEndDate.Text = "重要度："
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl14.Location = New System.Drawing.Point(12, 63)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(65, 17)
        Me.LabelControl14.TabIndex = 15
        Me.LabelControl14.Text = "结束时间："
        '
        'txtSmFollow
        '
        Me.txtSmFollow.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSmFollow.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtSmFollow.Location = New System.Drawing.Point(225, 65)
        Me.txtSmFollow.Name = "txtSmFollow"
        Me.txtSmFollow.Size = New System.Drawing.Size(52, 17)
        Me.txtSmFollow.TabIndex = 18
        Me.txtSmFollow.Text = "重要度："
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl16.Location = New System.Drawing.Point(167, 64)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(52, 17)
        Me.LabelControl16.TabIndex = 17
        Me.LabelControl16.Text = "跟进人："
        '
        'txtDepartment
        '
        Me.txtDepartment.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtDepartment.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtDepartment.Location = New System.Drawing.Point(385, 41)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(52, 17)
        Me.txtDepartment.TabIndex = 20
        Me.txtDepartment.Text = "重要度："
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl18.Location = New System.Drawing.Point(327, 40)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(65, 17)
        Me.LabelControl18.TabIndex = 19
        Me.LabelControl18.Text = "对象部门："
        '
        'txtLinkman
        '
        Me.txtLinkman.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtLinkman.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtLinkman.Location = New System.Drawing.Point(385, 66)
        Me.txtLinkman.Name = "txtLinkman"
        Me.txtLinkman.Size = New System.Drawing.Size(52, 17)
        Me.txtLinkman.TabIndex = 22
        Me.txtLinkman.Text = "重要度："
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl20.Location = New System.Drawing.Point(327, 65)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(52, 17)
        Me.LabelControl20.TabIndex = 21
        Me.LabelControl20.Text = "联系人："
        '
        'txtSmType
        '
        Me.txtSmType.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtSmType.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtSmType.Location = New System.Drawing.Point(546, 41)
        Me.txtSmType.Name = "txtSmType"
        Me.txtSmType.Size = New System.Drawing.Size(52, 17)
        Me.txtSmType.TabIndex = 24
        Me.txtSmType.Text = "重要度："
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl22.Location = New System.Drawing.Point(488, 40)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(39, 17)
        Me.LabelControl22.TabIndex = 23
        Me.LabelControl22.Text = "类别："
        '
        'txtCompany
        '
        Me.txtCompany.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtCompany.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtCompany.Location = New System.Drawing.Point(546, 67)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(52, 17)
        Me.txtCompany.TabIndex = 26
        Me.txtCompany.Text = "重要度："
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl24.Location = New System.Drawing.Point(488, 66)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(39, 17)
        Me.LabelControl24.TabIndex = 25
        Me.LabelControl24.Text = "公司："
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl25.Location = New System.Drawing.Point(12, 86)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(63, 17)
        Me.LabelControl25.TabIndex = 27
        Me.LabelControl25.Text = "说        明："
        '
        'editExplain
        '
        Me.editExplain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editExplain.Location = New System.Drawing.Point(83, 87)
        Me.editExplain.Name = "editExplain"
        Me.editExplain.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.editExplain.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editExplain.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.editExplain.Properties.Appearance.Options.UseBackColor = True
        Me.editExplain.Properties.Appearance.Options.UseFont = True
        Me.editExplain.Properties.Appearance.Options.UseForeColor = True
        Me.editExplain.Properties.ReadOnly = True
        Me.editExplain.Size = New System.Drawing.Size(894, 64)
        Me.editExplain.TabIndex = 28
        '
        'GridMyToDo
        '
        Me.GridMyToDo.DataMember = "Resources"
        Me.GridMyToDo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMyToDo.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White
        Me.GridMyToDo.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridMyToDo.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.GridMyToDo.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.GridMyToDo.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridMyToDo.Location = New System.Drawing.Point(0, 0)
        Me.GridMyToDo.MainView = Me.GridView1
        Me.GridMyToDo.Name = "GridMyToDo"
        Me.GridMyToDo.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar3, Me.RepositoryItemMemoExEdit4, Me.chkComplete, Me.RepositoryItemImageComboBox1})
        Me.GridMyToDo.Size = New System.Drawing.Size(397, 193)
        Me.GridMyToDo.TabIndex = 29
        Me.GridMyToDo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn17, Me.TD_StartDate, Me.TD_Name, Me.GridColumn1, Me.TD_ID, Me.GridColumn2})
        Me.GridView1.GridControl = Me.GridMyToDo
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "#"
        Me.GridColumn17.ColumnEdit = Me.chkComplete
        Me.GridColumn17.FieldName = "TD_Complete"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.OptionsColumn.AllowFocus = False
        Me.GridColumn17.OptionsColumn.AllowMove = False
        Me.GridColumn17.OptionsColumn.AllowSize = False
        Me.GridColumn17.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 0
        Me.GridColumn17.Width = 21
        '
        'chkComplete
        '
        Me.chkComplete.AutoHeight = False
        Me.chkComplete.Name = "chkComplete"
        Me.chkComplete.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'TD_StartDate
        '
        Me.TD_StartDate.Caption = "时间"
        Me.TD_StartDate.DisplayFormat.FormatString = "g"
        Me.TD_StartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TD_StartDate.FieldName = "TD_CompleteDate"
        Me.TD_StartDate.Name = "TD_StartDate"
        Me.TD_StartDate.OptionsColumn.AllowEdit = False
        Me.TD_StartDate.OptionsColumn.AllowFocus = False
        Me.TD_StartDate.OptionsColumn.AllowSize = False
        Me.TD_StartDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.TD_StartDate.Visible = True
        Me.TD_StartDate.VisibleIndex = 1
        Me.TD_StartDate.Width = 111
        '
        'TD_Name
        '
        Me.TD_Name.Caption = "跟进事项"
        Me.TD_Name.FieldName = "TD_Name"
        Me.TD_Name.Name = "TD_Name"
        Me.TD_Name.OptionsColumn.AllowEdit = False
        Me.TD_Name.OptionsColumn.AllowFocus = False
        Me.TD_Name.OptionsColumn.AllowMove = False
        Me.TD_Name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.TD_Name.OptionsColumn.ReadOnly = True
        Me.TD_Name.Visible = True
        Me.TD_Name.VisibleIndex = 2
        Me.TD_Name.Width = 160
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "备注"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemMemoExEdit4
        Me.GridColumn1.FieldName = "TD_Remark"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowSize = False
        Me.GridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 3
        Me.GridColumn1.Width = 46
        '
        'RepositoryItemMemoExEdit4
        '
        Me.RepositoryItemMemoExEdit4.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemMemoExEdit4.Appearance.Options.UseFont = True
        Me.RepositoryItemMemoExEdit4.AppearanceDisabled.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemMemoExEdit4.AppearanceDisabled.Options.UseFont = True
        Me.RepositoryItemMemoExEdit4.AppearanceDropDown.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemMemoExEdit4.AppearanceDropDown.Options.UseFont = True
        Me.RepositoryItemMemoExEdit4.AppearanceFocused.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemMemoExEdit4.AppearanceFocused.Options.UseFont = True
        Me.RepositoryItemMemoExEdit4.AutoHeight = False
        Me.RepositoryItemMemoExEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit4.Name = "RepositoryItemMemoExEdit4"
        Me.RepositoryItemMemoExEdit4.ReadOnly = True
        '
        'TD_ID
        '
        Me.TD_ID.Caption = "TD_ID"
        Me.TD_ID.FieldName = "TD_ID"
        Me.TD_ID.Name = "TD_ID"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "跟进人"
        Me.GridColumn2.FieldName = "UserName"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.AllowFocus = False
        Me.GridColumn2.OptionsColumn.AllowSize = False
        Me.GridColumn2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 4
        Me.GridColumn2.Width = 56
        '
        'RepositoryItemProgressBar3
        '
        Me.RepositoryItemProgressBar3.Name = "RepositoryItemProgressBar3"
        Me.RepositoryItemProgressBar3.ShowTitle = True
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", True, 5), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", False, -1)})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'SplitContainerControl3
        '
        Me.SplitContainerControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl3.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl3.Location = New System.Drawing.Point(2, 157)
        Me.SplitContainerControl3.Name = "SplitContainerControl3"
        Me.SplitContainerControl3.Panel1.Controls.Add(Me.SplitContainerControl2)
        Me.SplitContainerControl3.Panel1.Text = "Panel1"
        Me.SplitContainerControl3.Panel2.Controls.Add(Me.SplitContainerControl4)
        Me.SplitContainerControl3.Panel2.Text = "Panel2"
        Me.SplitContainerControl3.Size = New System.Drawing.Size(975, 412)
        Me.SplitContainerControl3.SplitterPosition = 397
        Me.SplitContainerControl3.TabIndex = 30
        Me.SplitContainerControl3.Text = "SplitContainerControl3"
        '
        'SplitContainerControl4
        '
        Me.SplitContainerControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl4.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.SplitContainerControl4.Horizontal = False
        Me.SplitContainerControl4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl4.Name = "SplitContainerControl4"
        Me.SplitContainerControl4.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl4.Panel1.Text = "Panel1"
        Me.SplitContainerControl4.Panel2.Controls.Add(Me.GridMyToDo)
        Me.SplitContainerControl4.Panel2.Text = "Panel2"
        Me.SplitContainerControl4.Size = New System.Drawing.Size(397, 412)
        Me.SplitContainerControl4.SplitterPosition = 214
        Me.SplitContainerControl4.TabIndex = 30
        Me.SplitContainerControl4.Text = "SplitContainerControl4"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(397, 214)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "GroupControl1"
        '
        'frmProjectDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 572)
        Me.Controls.Add(Me.SplitContainerControl3)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.editExplain)
        Me.Controls.Add(Me.LabelControl25)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.LabelControl24)
        Me.Controls.Add(Me.txtSmType)
        Me.Controls.Add(Me.LabelControl22)
        Me.Controls.Add(Me.txtLinkman)
        Me.Controls.Add(Me.LabelControl20)
        Me.Controls.Add(Me.txtDepartment)
        Me.Controls.Add(Me.LabelControl18)
        Me.Controls.Add(Me.txtSmFollow)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.txtSmEndDate)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.txtSmPrincipal)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.txtSmStartDate)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl10)
        Me.Name = "frmProjectDetail"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "项目详细"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl5.ResumeLayout(False)
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pupProjectDetail.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.editExplain.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridMyToDo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkComplete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl3.ResumeLayout(False)
        CType(Me.SplitContainerControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl4.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSchemeName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSmStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmergency As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtImport As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSmStartDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSmPrincipal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSmEndDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSmFollow As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDepartment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLinkman As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSmType As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCompany As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents editExplain As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents IDName As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents priority As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents PrincipalUID As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents FollowUID As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents ActualStatDate As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents AchualEndDate As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TotalTime As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents AssGrade As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents workComplete As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents assID As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents txtID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pupProjectDetail As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents pupAddSub As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pupAddTask As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pupEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents pupDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CID As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents PID As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents GridMyToDo As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkComplete As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents TD_StartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TD_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TD_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemProgressBar3 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents RepositoryItemMemoExEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents SplitContainerControl3 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents SplitContainerControl4 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents pupToExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents uploadData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainerControl5 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents MemoEdit2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FollowDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FollowID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CumulativeTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FollowSch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemProgressBar2 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
End Class
