<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectProject2
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
        Me.Grid1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TD_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TD_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemProgressBar2 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.RepositoryItemMemoExEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.chkComplete = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.rdbMy = New System.Windows.Forms.RadioButton()
        Me.rdbFull = New System.Windows.Forms.RadioButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkComplete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.DataMember = "Resources"
        Me.Grid1.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White
        Me.Grid1.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.Grid1.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.Grid1.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(3, 39)
        Me.Grid1.MainView = Me.GridView2
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar2, Me.RepositoryItemMemoExEdit4, Me.chkComplete, Me.RepositoryItemImageComboBox1})
        Me.Grid1.Size = New System.Drawing.Size(480, 250)
        Me.Grid1.TabIndex = 9
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.Empty.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridView2.Appearance.Empty.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.FocusedRow.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridView2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GridView2.Appearance.GroupRow.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridView2.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GridView2.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupRow.Options.UseFont = True
        Me.GridView2.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView2.Appearance.HideSelectionRow.Options.UseFont = True
        Me.GridView2.Appearance.Row.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridView2.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridView2.Appearance.Row.Options.UseBackColor = True
        Me.GridView2.Appearance.Row.Options.UseFont = True
        Me.GridView2.Appearance.Row.Options.UseForeColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TD_Name, Me.TD_ID})
        Me.GridView2.GridControl = Me.Grid1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowColumnHeaders = False
        Me.GridView2.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsView.ShowIndicator = False
        Me.GridView2.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'TD_Name
        '
        Me.TD_Name.Caption = "项目名称"
        Me.TD_Name.FieldName = "SchemeName"
        Me.TD_Name.Name = "TD_Name"
        Me.TD_Name.OptionsColumn.AllowEdit = False
        Me.TD_Name.OptionsColumn.AllowFocus = False
        Me.TD_Name.OptionsColumn.AllowMove = False
        Me.TD_Name.OptionsColumn.AllowSize = False
        Me.TD_Name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.TD_Name.OptionsColumn.ReadOnly = True
        Me.TD_Name.Visible = True
        Me.TD_Name.VisibleIndex = 0
        Me.TD_Name.Width = 450
        '
        'TD_ID
        '
        Me.TD_ID.Caption = "TD_ID"
        Me.TD_ID.FieldName = "ID"
        Me.TD_ID.Name = "TD_ID"
        '
        'RepositoryItemProgressBar2
        '
        Me.RepositoryItemProgressBar2.Name = "RepositoryItemProgressBar2"
        Me.RepositoryItemProgressBar2.ShowTitle = True
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
        '
        'chkComplete
        '
        Me.chkComplete.AutoHeight = False
        Me.chkComplete.Name = "chkComplete"
        Me.chkComplete.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", True, 5), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", False, -1)})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'rdbMy
        '
        Me.rdbMy.AutoSize = True
        Me.rdbMy.Checked = True
        Me.rdbMy.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdbMy.ForeColor = System.Drawing.Color.Navy
        Me.rdbMy.Location = New System.Drawing.Point(5, 5)
        Me.rdbMy.Name = "rdbMy"
        Me.rdbMy.Size = New System.Drawing.Size(117, 23)
        Me.rdbMy.TabIndex = 6
        Me.rdbMy.TabStop = True
        Me.rdbMy.Text = "本人跟进项目"
        Me.rdbMy.UseVisualStyleBackColor = True
        '
        'rdbFull
        '
        Me.rdbFull.AutoSize = True
        Me.rdbFull.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdbFull.ForeColor = System.Drawing.Color.Navy
        Me.rdbFull.Location = New System.Drawing.Point(128, 5)
        Me.rdbFull.Name = "rdbFull"
        Me.rdbFull.Size = New System.Drawing.Size(57, 23)
        Me.rdbFull.TabIndex = 7
        Me.rdbFull.Text = "所有"
        Me.rdbFull.UseVisualStyleBackColor = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.txtName)
        Me.PanelControl1.Controls.Add(Me.rdbMy)
        Me.PanelControl1.Controls.Add(Me.rdbFull)
        Me.PanelControl1.Location = New System.Drawing.Point(3, 3)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(480, 33)
        Me.PanelControl1.TabIndex = 10
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(194, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Properties.Appearance.Options.UseFont = True
        Me.txtName.Size = New System.Drawing.Size(280, 26)
        Me.txtName.TabIndex = 9
        '
        'frmSelectProject2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 292)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelectProject2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "选择项目"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkComplete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TD_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TD_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemProgressBar2 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents RepositoryItemMemoExEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents chkComplete As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents rdbMy As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFull As System.Windows.Forms.RadioButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
End Class
