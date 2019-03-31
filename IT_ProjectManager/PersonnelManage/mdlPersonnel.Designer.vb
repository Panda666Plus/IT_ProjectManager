<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdlPersonnel
    Inherits System.Windows.Forms.UserControl

    'UserControl 覆寫 Dispose 以清除元件清單。
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
        Me.Grid1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.pName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pPost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.employeeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.workPlace = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
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
        Me.RepositoryItemProgressBar2 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.assID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.SplitContainerControl3 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.Grid2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.FollowDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FollowID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CumulativeTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FollowSch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Remark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.RepositoryItemProgressBar3 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl3.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar1, Me.RepositoryItemDateEdit1})
        Me.Grid1.Size = New System.Drawing.Size(242, 512)
        Me.Grid1.TabIndex = 2
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.pName, Me.pPost, Me.employeeID, Me.workPlace})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'pName
        '
        Me.pName.AppearanceHeader.Options.UseTextOptions = True
        Me.pName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.pName.Caption = "姓名"
        Me.pName.FieldName = "pName"
        Me.pName.Name = "pName"
        Me.pName.OptionsColumn.AllowEdit = False
        Me.pName.OptionsColumn.AllowFocus = False
        Me.pName.OptionsColumn.AllowMove = False
        Me.pName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "pName", "{0}")})
        Me.pName.Visible = True
        Me.pName.VisibleIndex = 0
        Me.pName.Width = 76
        '
        'pPost
        '
        Me.pPost.AppearanceHeader.Options.UseTextOptions = True
        Me.pPost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.pPost.Caption = "职位"
        Me.pPost.FieldName = "pPost"
        Me.pPost.Name = "pPost"
        Me.pPost.OptionsColumn.AllowEdit = False
        Me.pPost.OptionsColumn.AllowFocus = False
        Me.pPost.OptionsColumn.AllowMove = False
        Me.pPost.Visible = True
        Me.pPost.VisibleIndex = 1
        Me.pPost.Width = 84
        '
        'employeeID
        '
        Me.employeeID.Caption = "职员代码"
        Me.employeeID.FieldName = "employeeID"
        Me.employeeID.Name = "employeeID"
        Me.employeeID.OptionsColumn.AllowEdit = False
        Me.employeeID.OptionsColumn.AllowFocus = False
        Me.employeeID.OptionsColumn.AllowMove = False
        '
        'workPlace
        '
        Me.workPlace.AppearanceHeader.Options.UseTextOptions = True
        Me.workPlace.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.workPlace.Caption = "所属公司"
        Me.workPlace.FieldName = "workPlace"
        Me.workPlace.Name = "workPlace"
        Me.workPlace.OptionsColumn.AllowEdit = False
        Me.workPlace.OptionsColumn.AllowFocus = False
        Me.workPlace.OptionsColumn.AllowMove = False
        Me.workPlace.Visible = True
        Me.workPlace.VisibleIndex = 2
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.EndColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        Me.RepositoryItemProgressBar1.ReadOnly = True
        Me.RepositoryItemProgressBar1.ShowTitle = True
        Me.RepositoryItemProgressBar1.StartColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RepositoryItemProgressBar1.UseParentBackground = True
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.Mask.EditMask = "yyyy/MM/dd"
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Grid1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SplitContainerControl2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(702, 512)
        Me.SplitContainerControl1.SplitterPosition = 242
        Me.SplitContainerControl1.TabIndex = 3
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
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
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.SplitContainerControl3)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainerControl2.Size = New System.Drawing.Size(455, 512)
        Me.SplitContainerControl2.SplitterPosition = 160
        Me.SplitContainerControl2.TabIndex = 2
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'TreeList1
        '
        Me.TreeList1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeList1.Appearance.HeaderPanel.Options.UseFont = True
        Me.TreeList1.Appearance.Row.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeList1.Appearance.Row.Options.UseFont = True
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.IDName, Me.priority, Me.PrincipalUID, Me.FollowUID, Me.ActualStatDate, Me.AchualEndDate, Me.TotalTime, Me.AssGrade, Me.workComplete, Me.assID})
        Me.TreeList1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeList1.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TreeList1.KeyFieldName = "CID"
        Me.TreeList1.Location = New System.Drawing.Point(0, 0)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.OptionsView.AutoWidth = False
        Me.TreeList1.OptionsView.EnableAppearanceEvenRow = True
        Me.TreeList1.OptionsView.ShowHorzLines = False
        Me.TreeList1.OptionsView.ShowIndicator = False
        Me.TreeList1.OptionsView.ShowSummaryFooter = True
        Me.TreeList1.OptionsView.ShowVertLines = False
        Me.TreeList1.ParentFieldName = "PID"
        Me.TreeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar2})
        Me.TreeList1.Size = New System.Drawing.Size(455, 347)
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
        Me.IDName.OptionsColumn.AllowSort = False
        Me.IDName.Visible = True
        Me.IDName.VisibleIndex = 0
        Me.IDName.Width = 212
        '
        'priority
        '
        Me.priority.Caption = "！"
        Me.priority.FieldName = "priority"
        Me.priority.Name = "priority"
        Me.priority.OptionsColumn.AllowEdit = False
        Me.priority.OptionsColumn.AllowFocus = False
        Me.priority.OptionsColumn.AllowMove = False
        Me.priority.OptionsColumn.AllowSort = False
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
        Me.PrincipalUID.Width = 72
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
        Me.FollowUID.Width = 57
        '
        'ActualStatDate
        '
        Me.ActualStatDate.Caption = "开始时间"
        Me.ActualStatDate.FieldName = "ActualStatDate"
        Me.ActualStatDate.Format.FormatString = "yyyy/MM/dd"
        Me.ActualStatDate.Format.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ActualStatDate.Name = "ActualStatDate"
        Me.ActualStatDate.OptionsColumn.AllowEdit = False
        Me.ActualStatDate.OptionsColumn.AllowFocus = False
        Me.ActualStatDate.OptionsColumn.AllowMove = False
        Me.ActualStatDate.Visible = True
        Me.ActualStatDate.VisibleIndex = 4
        Me.ActualStatDate.Width = 80
        '
        'AchualEndDate
        '
        Me.AchualEndDate.Caption = "结束时间"
        Me.AchualEndDate.FieldName = "AchualEndDate"
        Me.AchualEndDate.Format.FormatString = "yyyy/MM/dd"
        Me.AchualEndDate.Format.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.AchualEndDate.Name = "AchualEndDate"
        Me.AchualEndDate.OptionsColumn.AllowEdit = False
        Me.AchualEndDate.OptionsColumn.AllowFocus = False
        Me.AchualEndDate.OptionsColumn.AllowMove = False
        Me.AchualEndDate.Visible = True
        Me.AchualEndDate.VisibleIndex = 5
        Me.AchualEndDate.Width = 80
        '
        'TotalTime
        '
        Me.TotalTime.Caption = "总时间"
        Me.TotalTime.FieldName = "TotalTime"
        Me.TotalTime.Name = "TotalTime"
        Me.TotalTime.OptionsColumn.AllowEdit = False
        Me.TotalTime.OptionsColumn.AllowFocus = False
        Me.TotalTime.OptionsColumn.AllowMove = False
        Me.TotalTime.OptionsColumn.AllowSort = False
        Me.TotalTime.RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Sum
        Me.TotalTime.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum
        Me.TotalTime.Visible = True
        Me.TotalTime.VisibleIndex = 6
        Me.TotalTime.Width = 61
        '
        'AssGrade
        '
        Me.AssGrade.Caption = "评分"
        Me.AssGrade.FieldName = "AssGrade"
        Me.AssGrade.Name = "AssGrade"
        Me.AssGrade.OptionsColumn.AllowEdit = False
        Me.AssGrade.OptionsColumn.AllowFocus = False
        Me.AssGrade.OptionsColumn.AllowMove = False
        Me.AssGrade.OptionsColumn.AllowSort = False
        Me.AssGrade.Visible = True
        Me.AssGrade.VisibleIndex = 7
        Me.AssGrade.Width = 38
        '
        'workComplete
        '
        Me.workComplete.Caption = "任务进度"
        Me.workComplete.ColumnEdit = Me.RepositoryItemProgressBar2
        Me.workComplete.FieldName = "workComplete"
        Me.workComplete.Name = "workComplete"
        Me.workComplete.OptionsColumn.AllowEdit = False
        Me.workComplete.OptionsColumn.AllowFocus = False
        Me.workComplete.OptionsColumn.AllowMove = False
        Me.workComplete.Visible = True
        Me.workComplete.VisibleIndex = 8
        Me.workComplete.Width = 64
        '
        'RepositoryItemProgressBar2
        '
        Me.RepositoryItemProgressBar2.Name = "RepositoryItemProgressBar2"
        Me.RepositoryItemProgressBar2.ReadOnly = True
        Me.RepositoryItemProgressBar2.ShowTitle = True
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
        'SplitContainerControl3
        '
        Me.SplitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl3.Name = "SplitContainerControl3"
        Me.SplitContainerControl3.Panel1.Controls.Add(Me.MemoEdit1)
        Me.SplitContainerControl3.Panel1.Text = "Panel1"
        Me.SplitContainerControl3.Panel2.Controls.Add(Me.Grid2)
        Me.SplitContainerControl3.Panel2.Text = "Panel2"
        Me.SplitContainerControl3.Size = New System.Drawing.Size(455, 160)
        Me.SplitContainerControl3.SplitterPosition = 202
        Me.SplitContainerControl3.TabIndex = 0
        Me.SplitContainerControl3.Text = "SplitContainerControl3"
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
        Me.MemoEdit1.Size = New System.Drawing.Size(202, 160)
        Me.MemoEdit1.TabIndex = 0
        '
        'Grid2
        '
        Me.Grid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid2.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid2.Location = New System.Drawing.Point(0, 0)
        Me.Grid2.MainView = Me.GridView2
        Me.Grid2.Name = "Grid2"
        Me.Grid2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar3, Me.RepositoryItemMemoExEdit1})
        Me.Grid2.Size = New System.Drawing.Size(248, 160)
        Me.Grid2.TabIndex = 3
        Me.Grid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridView2.Appearance.Row.Options.UseFont = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.FollowDate, Me.FollowID, Me.CumulativeTime, Me.FollowSch, Me.Remark})
        Me.GridView2.GridControl = Me.Grid2
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
        'RepositoryItemProgressBar3
        '
        Me.RepositoryItemProgressBar3.EndColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RepositoryItemProgressBar3.Name = "RepositoryItemProgressBar3"
        Me.RepositoryItemProgressBar3.ReadOnly = True
        Me.RepositoryItemProgressBar3.ShowTitle = True
        Me.RepositoryItemProgressBar3.StartColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RepositoryItemProgressBar3.UseParentBackground = True
        '
        'mdlPersonnel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "mdlPersonnel"
        Me.Size = New System.Drawing.Size(702, 512)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl3.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
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
    Friend WithEvents RepositoryItemProgressBar2 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents assID As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents SplitContainerControl3 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Grid2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FollowDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FollowID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CumulativeTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FollowSch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemProgressBar3 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents pName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pPost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents employeeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents workPlace As DevExpress.XtraGrid.Columns.GridColumn

End Class
