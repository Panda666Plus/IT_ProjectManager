<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectTasksDays
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtDate = New DevExpress.XtraEditors.LabelControl()
        Me.GridMyTasks = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AssName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Remark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.CumulativeTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FollowSch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.AssID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridMyTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupControl1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.Appearance.Options.UseForeColor = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.txtDate)
        Me.GroupControl1.Controls.Add(Me.GridMyTasks)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(496, 267)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "当日完成任务进度："
        '
        'txtDate
        '
        Me.txtDate.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(130, 4)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(26, 17)
        Me.txtDate.TabIndex = 36
        Me.txtDate.Text = "日期"
        '
        'GridMyTasks
        '
        Me.GridMyTasks.DataMember = "Resources"
        Me.GridMyTasks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMyTasks.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White
        Me.GridMyTasks.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridMyTasks.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.GridMyTasks.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.GridMyTasks.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridMyTasks.Location = New System.Drawing.Point(2, 25)
        Me.GridMyTasks.MainView = Me.GridView1
        Me.GridMyTasks.Name = "GridMyTasks"
        Me.GridMyTasks.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemTextEdit1})
        Me.GridMyTasks.Size = New System.Drawing.Size(492, 240)
        Me.GridMyTasks.TabIndex = 3
        Me.GridMyTasks.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGray
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.AssName, Me.GridColumn6, Me.Remark, Me.CumulativeTime, Me.FollowSch, Me.AssID, Me.GridColumn5})
        Me.GridView1.GridControl = Me.GridMyTasks
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowColumnHeaders = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn5, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "时间"
        Me.GridColumn1.DisplayFormat.FormatString = "HH:mm"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn1.FieldName = "FollowDate"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        Me.GridColumn1.OptionsColumn.AllowSize = False
        Me.GridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 68
        '
        'AssName
        '
        Me.AssName.Caption = "任务名称"
        Me.AssName.FieldName = "AssName"
        Me.AssName.Name = "AssName"
        Me.AssName.OptionsColumn.AllowEdit = False
        Me.AssName.OptionsColumn.AllowFocus = False
        Me.AssName.OptionsColumn.AllowMove = False
        Me.AssName.OptionsColumn.AllowSize = False
        Me.AssName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.AssName.OptionsColumn.ReadOnly = True
        Me.AssName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.AssName.Visible = True
        Me.AssName.VisibleIndex = 1
        Me.AssName.Width = 200
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "模块"
        Me.GridColumn6.FieldName = "PrjName"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.AllowFocus = False
        Me.GridColumn6.OptionsColumn.AllowMove = False
        Me.GridColumn6.OptionsColumn.AllowSize = False
        Me.GridColumn6.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        Me.GridColumn6.Width = 95
        '
        'Remark
        '
        Me.Remark.Caption = "进度说明"
        Me.Remark.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.Remark.FieldName = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.OptionsColumn.ReadOnly = True
        Me.Remark.Visible = True
        Me.Remark.VisibleIndex = 3
        Me.Remark.Width = 40
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemMemoExEdit1.Appearance.Options.UseFont = True
        Me.RepositoryItemMemoExEdit1.AppearanceDisabled.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemMemoExEdit1.AppearanceDisabled.Options.UseFont = True
        Me.RepositoryItemMemoExEdit1.AppearanceDropDown.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemMemoExEdit1.AppearanceDropDown.Options.UseFont = True
        Me.RepositoryItemMemoExEdit1.AppearanceFocused.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemMemoExEdit1.AppearanceFocused.Options.UseFont = True
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'CumulativeTime
        '
        Me.CumulativeTime.AppearanceCell.Options.UseTextOptions = True
        Me.CumulativeTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CumulativeTime.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.CumulativeTime.Caption = "用时"
        Me.CumulativeTime.DisplayFormat.FormatString = "n0"
        Me.CumulativeTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CumulativeTime.FieldName = "CumulativeTime"
        Me.CumulativeTime.Name = "CumulativeTime"
        Me.CumulativeTime.OptionsColumn.AllowEdit = False
        Me.CumulativeTime.OptionsColumn.AllowFocus = False
        Me.CumulativeTime.OptionsColumn.AllowMove = False
        Me.CumulativeTime.OptionsColumn.AllowSize = False
        Me.CumulativeTime.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.CumulativeTime.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CumulativeTime", "{0}")})
        Me.CumulativeTime.Visible = True
        Me.CumulativeTime.VisibleIndex = 4
        Me.CumulativeTime.Width = 38
        '
        'FollowSch
        '
        Me.FollowSch.Caption = "进度"
        Me.FollowSch.ColumnEdit = Me.RepositoryItemProgressBar1
        Me.FollowSch.FieldName = "FollowSch"
        Me.FollowSch.Name = "FollowSch"
        Me.FollowSch.OptionsColumn.AllowEdit = False
        Me.FollowSch.OptionsColumn.AllowFocus = False
        Me.FollowSch.OptionsColumn.AllowMove = False
        Me.FollowSch.OptionsColumn.AllowSize = False
        Me.FollowSch.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.FollowSch.OptionsColumn.ReadOnly = True
        Me.FollowSch.Visible = True
        Me.FollowSch.VisibleIndex = 5
        Me.FollowSch.Width = 45
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        Me.RepositoryItemProgressBar1.ShowTitle = True
        '
        'AssID
        '
        Me.AssID.Caption = "ID"
        Me.AssID.FieldName = "ID"
        Me.AssID.Name = "AssID"
        Me.AssID.OptionsColumn.AllowEdit = False
        Me.AssID.OptionsColumn.AllowMove = False
        Me.AssID.OptionsColumn.AllowSize = False
        Me.AssID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.AssID.OptionsColumn.ReadOnly = True
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = " "
        Me.GridColumn5.FieldName = "SchemeName"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.AllowFocus = False
        Me.GridColumn5.OptionsColumn.AllowMove = False
        Me.GridColumn5.OptionsColumn.AllowSize = False
        Me.GridColumn5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Location = New System.Drawing.Point(381, 270)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(73, 28)
        Me.cmdExit.TabIndex = 35
        Me.cmdExit.Text = "退出"
        '
        'frmProjectTasksDays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 267)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProjectTasksDays"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "当日完成任务进度"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GridMyTasks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridMyTasks As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AssName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FollowSch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents AssID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents CumulativeTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
