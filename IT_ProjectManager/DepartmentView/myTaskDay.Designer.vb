<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myTaskDay
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.MyTask = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PrjName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AssName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Remark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.CumulativeTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FollowSch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.RepositoryItemMarqueeProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar()
        CType(Me.MyTask, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MyTask
        '
        Me.MyTask.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.MyTask.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.MyTask.Location = New System.Drawing.Point(0, 0)
        Me.MyTask.MainView = Me.GridView1
        Me.MyTask.Name = "MyTask"
        Me.MyTask.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemMarqueeProgressBar1})
        Me.MyTask.Size = New System.Drawing.Size(660, 438)
        Me.MyTask.TabIndex = 1
        Me.MyTask.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGray
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Blue
        Me.GridView1.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PrjName, Me.AssName, Me.Remark, Me.CumulativeTime, Me.FollowSch})
        Me.GridView1.GridControl = Me.MyTask
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.PrjName, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'PrjName
        '
        Me.PrjName.Caption = "项目名称"
        Me.PrjName.FieldName = "PrjName"
        Me.PrjName.Name = "PrjName"
        Me.PrjName.Visible = True
        Me.PrjName.VisibleIndex = 0
        '
        'AssName
        '
        Me.AssName.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssName.AppearanceCell.Options.UseFont = True
        Me.AssName.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssName.AppearanceHeader.Options.UseFont = True
        Me.AssName.AppearanceHeader.Options.UseTextOptions = True
        Me.AssName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AssName.Caption = "日工作明细"
        Me.AssName.FieldName = "AssName"
        Me.AssName.Name = "AssName"
        Me.AssName.OptionsColumn.AllowEdit = False
        Me.AssName.OptionsColumn.AllowFocus = False
        Me.AssName.OptionsColumn.FixedWidth = True
        Me.AssName.OptionsColumn.ReadOnly = True
        Me.AssName.Visible = True
        Me.AssName.VisibleIndex = 0
        Me.AssName.Width = 336
        '
        'Remark
        '
        Me.Remark.AppearanceHeader.Options.UseTextOptions = True
        Me.Remark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Remark.Caption = "完成备注"
        Me.Remark.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.Remark.FieldName = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.Visible = True
        Me.Remark.VisibleIndex = 2
        Me.Remark.Width = 141
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'CumulativeTime
        '
        Me.CumulativeTime.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CumulativeTime.AppearanceCell.Options.UseFont = True
        Me.CumulativeTime.AppearanceCell.Options.UseTextOptions = True
        Me.CumulativeTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CumulativeTime.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CumulativeTime.AppearanceHeader.ForeColor = System.Drawing.Color.Blue
        Me.CumulativeTime.AppearanceHeader.Options.UseFont = True
        Me.CumulativeTime.AppearanceHeader.Options.UseForeColor = True
        Me.CumulativeTime.AppearanceHeader.Options.UseTextOptions = True
        Me.CumulativeTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CumulativeTime.Caption = "所需时间"
        Me.CumulativeTime.FieldName = "CumulativeTime"
        Me.CumulativeTime.Name = "CumulativeTime"
        Me.CumulativeTime.OptionsColumn.AllowEdit = False
        Me.CumulativeTime.OptionsColumn.AllowFocus = False
        Me.CumulativeTime.OptionsColumn.FixedWidth = True
        Me.CumulativeTime.OptionsColumn.ReadOnly = True
        Me.CumulativeTime.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CumulativeTime", "{0}")})
        Me.CumulativeTime.Visible = True
        Me.CumulativeTime.VisibleIndex = 1
        Me.CumulativeTime.Width = 90
        '
        'FollowSch
        '
        Me.FollowSch.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FollowSch.AppearanceCell.Options.UseFont = True
        Me.FollowSch.AppearanceCell.Options.UseTextOptions = True
        Me.FollowSch.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FollowSch.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FollowSch.AppearanceHeader.Options.UseFont = True
        Me.FollowSch.AppearanceHeader.Options.UseTextOptions = True
        Me.FollowSch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FollowSch.Caption = "进度"
        Me.FollowSch.ColumnEdit = Me.RepositoryItemProgressBar1
        Me.FollowSch.FieldName = "FollowSch"
        Me.FollowSch.Name = "FollowSch"
        Me.FollowSch.OptionsColumn.AllowEdit = False
        Me.FollowSch.OptionsColumn.AllowFocus = False
        Me.FollowSch.OptionsColumn.FixedWidth = True
        Me.FollowSch.OptionsColumn.ReadOnly = True
        Me.FollowSch.Visible = True
        Me.FollowSch.VisibleIndex = 3
        Me.FollowSch.Width = 87
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        Me.RepositoryItemProgressBar1.ReadOnly = True
        Me.RepositoryItemProgressBar1.ShowTitle = True
        '
        'RepositoryItemMarqueeProgressBar1
        '
        Me.RepositoryItemMarqueeProgressBar1.Name = "RepositoryItemMarqueeProgressBar1"
        '
        'myTaskDay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 438)
        Me.Controls.Add(Me.MyTask)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "myTaskDay"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "个人日工作进度明细"
        CType(Me.MyTask, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MyTask As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PrjName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AssName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CumulativeTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FollowSch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemMarqueeProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar
End Class
