<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectTasksToDo
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
        Me.GridMyToDo = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkComplete = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.TD_StartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TD_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.TD_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemProgressBar3 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtDate = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridMyToDo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkComplete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupControl1.Controls.Add(Me.GridMyToDo)
        Me.GroupControl1.Controls.Add(Me.txtDate)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(621, 430)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "当日完成待辦事項："
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
        Me.GridMyToDo.Location = New System.Drawing.Point(2, 25)
        Me.GridMyToDo.MainView = Me.GridView1
        Me.GridMyToDo.Name = "GridMyToDo"
        Me.GridMyToDo.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar3, Me.RepositoryItemMemoExEdit4, Me.chkComplete, Me.RepositoryItemImageComboBox1, Me.RepositoryItemTextEdit1, Me.RepositoryItemMemoEdit1})
        Me.GridMyToDo.Size = New System.Drawing.Size(617, 403)
        Me.GridMyToDo.TabIndex = 37
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn17, Me.TD_StartDate, Me.TD_Name, Me.GridColumn2, Me.GridColumn3, Me.GridColumn1, Me.TD_ID})
        Me.GridView1.GridControl = Me.GridMyToDo
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
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
        Me.GridColumn17.Width = 25
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
        Me.TD_StartDate.DisplayFormat.FormatString = "t"
        Me.TD_StartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TD_StartDate.FieldName = "TD_CompleteDate"
        Me.TD_StartDate.Name = "TD_StartDate"
        Me.TD_StartDate.OptionsColumn.AllowEdit = False
        Me.TD_StartDate.OptionsColumn.AllowFocus = False
        Me.TD_StartDate.OptionsColumn.AllowSize = False
        Me.TD_StartDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.TD_StartDate.Visible = True
        Me.TD_StartDate.VisibleIndex = 1
        Me.TD_StartDate.Width = 85
        '
        'TD_Name
        '
        Me.TD_Name.Caption = "跟进事项"
        Me.TD_Name.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.TD_Name.FieldName = "TD_Name"
        Me.TD_Name.Name = "TD_Name"
        Me.TD_Name.OptionsColumn.AllowEdit = False
        Me.TD_Name.OptionsColumn.AllowFocus = False
        Me.TD_Name.OptionsColumn.AllowMove = False
        Me.TD_Name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.TD_Name.OptionsColumn.ReadOnly = True
        Me.TD_Name.Visible = True
        Me.TD_Name.VisibleIndex = 2
        Me.TD_Name.Width = 209
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        Me.RepositoryItemMemoEdit1.ReadOnly = True
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "项目"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.GridColumn2.FieldName = "SchemeName"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.AllowFocus = False
        Me.GridColumn2.OptionsColumn.AllowMove = False
        Me.GridColumn2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 142
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "上下文"
        Me.GridColumn3.FieldName = "ContextName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.AllowFocus = False
        Me.GridColumn3.OptionsColumn.AllowMove = False
        Me.GridColumn3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        Me.GridColumn3.Width = 97
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
        Me.GridColumn1.VisibleIndex = 5
        Me.GridColumn1.Width = 59
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
        Me.RepositoryItemMemoExEdit4.ShowIcon = False
        '
        'TD_ID
        '
        Me.TD_ID.Caption = "TD_ID"
        Me.TD_ID.FieldName = "TD_ID"
        Me.TD_ID.Name = "TD_ID"
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
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
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
        'frmProjectTasksToDo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 430)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProjectTasksToDo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "当日完成待办事项"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GridMyToDo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkComplete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridMyToDo As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkComplete As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents TD_StartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TD_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents TD_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemProgressBar3 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
End Class
