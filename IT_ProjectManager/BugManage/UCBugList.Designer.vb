<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCBugList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCBugList))
        Me.ScrollableControl = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.SysList = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SystemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SystemID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UseCompany = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UseDepartments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UseRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TotalMonths = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TotalMonthsError = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TotalError = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FollowManName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ResponsibilityName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CompetenceName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SystemRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ToExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.ScrollableControl.SuspendLayout()
        CType(Me.SysList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScrollableControl
        '
        Me.ScrollableControl.Controls.Add(Me.SysList)
        Me.ScrollableControl.Controls.Add(Me.PanelControl1)
        Me.ScrollableControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScrollableControl.Location = New System.Drawing.Point(0, 0)
        Me.ScrollableControl.Name = "ScrollableControl"
        Me.ScrollableControl.Size = New System.Drawing.Size(756, 524)
        Me.ScrollableControl.TabIndex = 10
        '
        'SysList
        '
        Me.SysList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SysList.Location = New System.Drawing.Point(0, 52)
        Me.SysList.MainView = Me.GridView1
        Me.SysList.Name = "SysList"
        Me.SysList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoExEdit1})
        Me.SysList.Size = New System.Drawing.Size(756, 472)
        Me.SysList.TabIndex = 5
        Me.SysList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridView1.Appearance.Empty.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.Empty.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Blue
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Blue
        Me.GridView1.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Blue
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseFont = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.SystemName, Me.SystemID, Me.UseCompany, Me.UseDepartments, Me.UseRemarks, Me.StartDate, Me.TotalMonths, Me.TotalMonthsError, Me.TotalError, Me.FollowManName, Me.ResponsibilityName, Me.CompetenceName, Me.SystemRemarks})
        Me.GridView1.GridControl = Me.SysList
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.GridView1.OptionsPrint.AutoWidth = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'AutoID
        '
        Me.AutoID.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoID.AppearanceCell.Options.UseFont = True
        Me.AutoID.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoID.AppearanceHeader.Options.UseFont = True
        Me.AutoID.AppearanceHeader.Options.UseTextOptions = True
        Me.AutoID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AutoID.Caption = "ID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.AllowEdit = False
        Me.AutoID.OptionsColumn.AllowFocus = False
        Me.AutoID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.AutoID.OptionsColumn.AllowMove = False
        Me.AutoID.OptionsColumn.FixedWidth = True
        Me.AutoID.OptionsColumn.ReadOnly = True
        Me.AutoID.Visible = True
        Me.AutoID.VisibleIndex = 0
        Me.AutoID.Width = 40
        '
        'SystemName
        '
        Me.SystemName.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemName.AppearanceCell.Options.UseFont = True
        Me.SystemName.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemName.AppearanceHeader.Options.UseFont = True
        Me.SystemName.AppearanceHeader.Options.UseTextOptions = True
        Me.SystemName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SystemName.Caption = "系统名称"
        Me.SystemName.FieldName = "SystemName"
        Me.SystemName.Name = "SystemName"
        Me.SystemName.OptionsColumn.AllowEdit = False
        Me.SystemName.OptionsColumn.AllowFocus = False
        Me.SystemName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.SystemName.OptionsColumn.AllowMove = False
        Me.SystemName.OptionsColumn.FixedWidth = True
        Me.SystemName.OptionsColumn.ReadOnly = True
        Me.SystemName.Visible = True
        Me.SystemName.VisibleIndex = 1
        Me.SystemName.Width = 170
        '
        'SystemID
        '
        Me.SystemID.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemID.AppearanceCell.Options.UseFont = True
        Me.SystemID.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemID.AppearanceHeader.Options.UseFont = True
        Me.SystemID.AppearanceHeader.Options.UseTextOptions = True
        Me.SystemID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SystemID.Caption = "系统编码"
        Me.SystemID.FieldName = "SystemID"
        Me.SystemID.Name = "SystemID"
        Me.SystemID.OptionsColumn.AllowEdit = False
        Me.SystemID.OptionsColumn.AllowFocus = False
        Me.SystemID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.SystemID.OptionsColumn.AllowMove = False
        Me.SystemID.OptionsColumn.FixedWidth = True
        Me.SystemID.OptionsColumn.ReadOnly = True
        Me.SystemID.Visible = True
        Me.SystemID.VisibleIndex = 2
        Me.SystemID.Width = 120
        '
        'UseCompany
        '
        Me.UseCompany.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UseCompany.AppearanceCell.Options.UseFont = True
        Me.UseCompany.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UseCompany.AppearanceHeader.Options.UseFont = True
        Me.UseCompany.AppearanceHeader.Options.UseTextOptions = True
        Me.UseCompany.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.UseCompany.Caption = "使用公司"
        Me.UseCompany.FieldName = "UseCompany"
        Me.UseCompany.Name = "UseCompany"
        Me.UseCompany.OptionsColumn.AllowEdit = False
        Me.UseCompany.OptionsColumn.AllowFocus = False
        Me.UseCompany.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.UseCompany.OptionsColumn.AllowMove = False
        Me.UseCompany.OptionsColumn.FixedWidth = True
        Me.UseCompany.OptionsColumn.ReadOnly = True
        Me.UseCompany.Visible = True
        Me.UseCompany.VisibleIndex = 3
        Me.UseCompany.Width = 150
        '
        'UseDepartments
        '
        Me.UseDepartments.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UseDepartments.AppearanceCell.Options.UseFont = True
        Me.UseDepartments.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UseDepartments.AppearanceHeader.Options.UseFont = True
        Me.UseDepartments.AppearanceHeader.Options.UseTextOptions = True
        Me.UseDepartments.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.UseDepartments.Caption = "使用部门"
        Me.UseDepartments.FieldName = "UseDepartments"
        Me.UseDepartments.Name = "UseDepartments"
        Me.UseDepartments.OptionsColumn.AllowEdit = False
        Me.UseDepartments.OptionsColumn.AllowFocus = False
        Me.UseDepartments.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.UseDepartments.OptionsColumn.AllowMove = False
        Me.UseDepartments.OptionsColumn.FixedWidth = True
        Me.UseDepartments.OptionsColumn.ReadOnly = True
        Me.UseDepartments.Visible = True
        Me.UseDepartments.VisibleIndex = 4
        Me.UseDepartments.Width = 120
        '
        'UseRemarks
        '
        Me.UseRemarks.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UseRemarks.AppearanceCell.Options.UseFont = True
        Me.UseRemarks.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UseRemarks.AppearanceHeader.Options.UseFont = True
        Me.UseRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.UseRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.UseRemarks.Caption = "用途"
        Me.UseRemarks.FieldName = "UseRemarks"
        Me.UseRemarks.Name = "UseRemarks"
        Me.UseRemarks.OptionsColumn.AllowEdit = False
        Me.UseRemarks.OptionsColumn.AllowFocus = False
        Me.UseRemarks.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.UseRemarks.OptionsColumn.AllowMove = False
        Me.UseRemarks.OptionsColumn.FixedWidth = True
        Me.UseRemarks.OptionsColumn.ReadOnly = True
        Me.UseRemarks.Visible = True
        Me.UseRemarks.VisibleIndex = 5
        Me.UseRemarks.Width = 160
        '
        'StartDate
        '
        Me.StartDate.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDate.AppearanceCell.Options.UseFont = True
        Me.StartDate.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDate.AppearanceHeader.Options.UseFont = True
        Me.StartDate.AppearanceHeader.Options.UseTextOptions = True
        Me.StartDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.StartDate.Caption = "推行日期"
        Me.StartDate.DisplayFormat.FormatString = "d"
        Me.StartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.StartDate.FieldName = "StartDate"
        Me.StartDate.Name = "StartDate"
        Me.StartDate.OptionsColumn.AllowEdit = False
        Me.StartDate.OptionsColumn.AllowFocus = False
        Me.StartDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.StartDate.OptionsColumn.AllowMove = False
        Me.StartDate.OptionsColumn.FixedWidth = True
        Me.StartDate.OptionsColumn.ReadOnly = True
        Me.StartDate.Visible = True
        Me.StartDate.VisibleIndex = 6
        Me.StartDate.Width = 90
        '
        'TotalMonths
        '
        Me.TotalMonths.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TotalMonths.AppearanceCell.ForeColor = System.Drawing.Color.Blue
        Me.TotalMonths.AppearanceCell.Options.UseFont = True
        Me.TotalMonths.AppearanceCell.Options.UseForeColor = True
        Me.TotalMonths.AppearanceCell.Options.UseTextOptions = True
        Me.TotalMonths.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TotalMonths.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalMonths.AppearanceHeader.Options.UseFont = True
        Me.TotalMonths.AppearanceHeader.Options.UseTextOptions = True
        Me.TotalMonths.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TotalMonths.Caption = "已推行月数"
        Me.TotalMonths.FieldName = "TotalMonths"
        Me.TotalMonths.Name = "TotalMonths"
        Me.TotalMonths.OptionsColumn.AllowEdit = False
        Me.TotalMonths.OptionsColumn.AllowFocus = False
        Me.TotalMonths.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.TotalMonths.OptionsColumn.AllowMove = False
        Me.TotalMonths.OptionsColumn.FixedWidth = True
        Me.TotalMonths.OptionsColumn.ReadOnly = True
        Me.TotalMonths.Visible = True
        Me.TotalMonths.VisibleIndex = 7
        Me.TotalMonths.Width = 100
        '
        'TotalMonthsError
        '
        Me.TotalMonthsError.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TotalMonthsError.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.TotalMonthsError.AppearanceCell.Options.UseFont = True
        Me.TotalMonthsError.AppearanceCell.Options.UseForeColor = True
        Me.TotalMonthsError.AppearanceCell.Options.UseTextOptions = True
        Me.TotalMonthsError.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TotalMonthsError.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalMonthsError.AppearanceHeader.Options.UseFont = True
        Me.TotalMonthsError.AppearanceHeader.Options.UseTextOptions = True
        Me.TotalMonthsError.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TotalMonthsError.Caption = "当月Bug次数"
        Me.TotalMonthsError.FieldName = "TotalMonthsError"
        Me.TotalMonthsError.Name = "TotalMonthsError"
        Me.TotalMonthsError.OptionsColumn.AllowEdit = False
        Me.TotalMonthsError.OptionsColumn.AllowFocus = False
        Me.TotalMonthsError.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.TotalMonthsError.OptionsColumn.AllowMove = False
        Me.TotalMonthsError.OptionsColumn.FixedWidth = True
        Me.TotalMonthsError.OptionsColumn.ReadOnly = True
        Me.TotalMonthsError.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalMonthsError", "Total:{0}")})
        Me.TotalMonthsError.Visible = True
        Me.TotalMonthsError.VisibleIndex = 8
        Me.TotalMonthsError.Width = 100
        '
        'TotalError
        '
        Me.TotalError.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TotalError.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.TotalError.AppearanceCell.Options.UseFont = True
        Me.TotalError.AppearanceCell.Options.UseForeColor = True
        Me.TotalError.AppearanceCell.Options.UseTextOptions = True
        Me.TotalError.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TotalError.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalError.AppearanceHeader.Options.UseFont = True
        Me.TotalError.AppearanceHeader.Options.UseTextOptions = True
        Me.TotalError.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TotalError.Caption = "累计Bug次数"
        Me.TotalError.FieldName = "TotalError"
        Me.TotalError.Name = "TotalError"
        Me.TotalError.OptionsColumn.AllowEdit = False
        Me.TotalError.OptionsColumn.AllowFocus = False
        Me.TotalError.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.TotalError.OptionsColumn.AllowMove = False
        Me.TotalError.OptionsColumn.FixedWidth = True
        Me.TotalError.OptionsColumn.ReadOnly = True
        Me.TotalError.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalError", "Tatal:{0}")})
        Me.TotalError.Visible = True
        Me.TotalError.VisibleIndex = 9
        Me.TotalError.Width = 100
        '
        'FollowManName
        '
        Me.FollowManName.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FollowManName.AppearanceCell.Options.UseFont = True
        Me.FollowManName.AppearanceCell.Options.UseTextOptions = True
        Me.FollowManName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FollowManName.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FollowManName.AppearanceHeader.Options.UseFont = True
        Me.FollowManName.AppearanceHeader.Options.UseTextOptions = True
        Me.FollowManName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FollowManName.Caption = "跟进人"
        Me.FollowManName.FieldName = "FollowManName"
        Me.FollowManName.Name = "FollowManName"
        Me.FollowManName.OptionsColumn.AllowEdit = False
        Me.FollowManName.OptionsColumn.AllowFocus = False
        Me.FollowManName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.FollowManName.OptionsColumn.AllowMove = False
        Me.FollowManName.OptionsColumn.FixedWidth = True
        Me.FollowManName.OptionsColumn.ReadOnly = True
        Me.FollowManName.Visible = True
        Me.FollowManName.VisibleIndex = 10
        Me.FollowManName.Width = 80
        '
        'ResponsibilityName
        '
        Me.ResponsibilityName.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResponsibilityName.AppearanceCell.Options.UseFont = True
        Me.ResponsibilityName.AppearanceCell.Options.UseTextOptions = True
        Me.ResponsibilityName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ResponsibilityName.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResponsibilityName.AppearanceHeader.Options.UseFont = True
        Me.ResponsibilityName.AppearanceHeader.Options.UseTextOptions = True
        Me.ResponsibilityName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ResponsibilityName.Caption = "负责人"
        Me.ResponsibilityName.FieldName = "ResponsibilityName"
        Me.ResponsibilityName.Name = "ResponsibilityName"
        Me.ResponsibilityName.OptionsColumn.AllowEdit = False
        Me.ResponsibilityName.OptionsColumn.AllowFocus = False
        Me.ResponsibilityName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.ResponsibilityName.OptionsColumn.AllowMove = False
        Me.ResponsibilityName.OptionsColumn.FixedWidth = True
        Me.ResponsibilityName.OptionsColumn.ReadOnly = True
        Me.ResponsibilityName.Visible = True
        Me.ResponsibilityName.VisibleIndex = 11
        Me.ResponsibilityName.Width = 80
        '
        'CompetenceName
        '
        Me.CompetenceName.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompetenceName.AppearanceCell.Options.UseFont = True
        Me.CompetenceName.AppearanceCell.Options.UseTextOptions = True
        Me.CompetenceName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CompetenceName.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompetenceName.AppearanceHeader.Options.UseFont = True
        Me.CompetenceName.AppearanceHeader.Options.UseTextOptions = True
        Me.CompetenceName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CompetenceName.Caption = "用户权限管理员"
        Me.CompetenceName.FieldName = "CompetenceName"
        Me.CompetenceName.Name = "CompetenceName"
        Me.CompetenceName.OptionsColumn.AllowEdit = False
        Me.CompetenceName.OptionsColumn.AllowFocus = False
        Me.CompetenceName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.CompetenceName.OptionsColumn.AllowMove = False
        Me.CompetenceName.OptionsColumn.FixedWidth = True
        Me.CompetenceName.OptionsColumn.ReadOnly = True
        Me.CompetenceName.Visible = True
        Me.CompetenceName.VisibleIndex = 12
        Me.CompetenceName.Width = 100
        '
        'SystemRemarks
        '
        Me.SystemRemarks.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemRemarks.AppearanceCell.Options.UseFont = True
        Me.SystemRemarks.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemRemarks.AppearanceHeader.Options.UseFont = True
        Me.SystemRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.SystemRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SystemRemarks.Caption = "备注"
        Me.SystemRemarks.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.SystemRemarks.FieldName = "SystemRemarks"
        Me.SystemRemarks.Name = "SystemRemarks"
        Me.SystemRemarks.OptionsColumn.FixedWidth = True
        Me.SystemRemarks.OptionsColumn.ReadOnly = True
        Me.SystemRemarks.Visible = True
        Me.SystemRemarks.VisibleIndex = 13
        Me.SystemRemarks.Width = 200
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.DateEdit1)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.ToExcel)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(756, 52)
        Me.PanelControl1.TabIndex = 4
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = New Date(2013, 11, 26, 16, 58, 0, 461)
        Me.DateEdit1.Location = New System.Drawing.Point(109, 12)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.NullDate = New Date(2013, 11, 26, 16, 57, 30, 758)
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(110, 26)
        Me.DateEdit1.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(8, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(96, 20)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "指定统计月份"
        '
        'ToExcel
        '
        Me.ToExcel.Image = CType(resources.GetObject("ToExcel.Image"), System.Drawing.Image)
        Me.ToExcel.Location = New System.Drawing.Point(225, 9)
        Me.ToExcel.Name = "ToExcel"
        Me.ToExcel.Size = New System.Drawing.Size(91, 33)
        Me.ToExcel.TabIndex = 0
        Me.ToExcel.Text = "导出Excel"
        '
        'UCBugList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ScrollableControl)
        Me.Name = "UCBugList"
        Me.Size = New System.Drawing.Size(756, 524)
        Me.ScrollableControl.ResumeLayout(False)
        CType(Me.SysList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ScrollableControl As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents SysList As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SystemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SystemID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UseCompany As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UseDepartments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UseRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TotalMonths As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TotalMonthsError As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TotalError As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FollowManName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ResponsibilityName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompetenceName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SystemRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ToExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit

End Class
