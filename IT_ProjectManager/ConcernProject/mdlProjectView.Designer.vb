<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdlProjectView
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.cmdDel = New DevExpress.XtraEditors.SimpleButton()
        Me.txtType = New DevExpress.XtraEditors.LabelControl()
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SchemeName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SmPrincipal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SmStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SmEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SmFollow1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sm1Type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sm1Status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.important1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.emergency1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.complete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid1 = New DevExpress.XtraGrid.GridControl()
        Me.RepositoryItemProgressBar2 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid2 = New DevExpress.XtraGrid.GridControl()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.ShowCaption = False
        Me.GroupControl2.Size = New System.Drawing.Size(756, 173)
        Me.GroupControl2.TabIndex = 2
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl3)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(756, 307)
        Me.SplitContainerControl1.SplitterPosition = 165
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
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.SplitContainerControl1)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(756, 485)
        Me.SplitContainerControl2.SplitterPosition = 173
        Me.SplitContainerControl2.TabIndex = 4
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("PMingLiU", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(319, 4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl1.Location = New System.Drawing.Point(333, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(78, 17)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "个人关注项目"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("PMingLiU", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(472, 5)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl2.Location = New System.Drawing.Point(486, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(52, 17)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "所有项目"
        '
        'cmdAdd
        '
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.cmdAdd.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.cmdAdd.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.cmdAdd.Appearance.Options.UseBackColor = True
        Me.cmdAdd.Appearance.Options.UseBorderColor = True
        Me.cmdAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.cmdAdd.Image = Global.IT_ProjectManager.My.Resources.Resources.OutlineExpand
        Me.cmdAdd.Location = New System.Drawing.Point(577, 3)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(24, 18)
        Me.cmdAdd.TabIndex = 8
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.Appearance.Options.UseForeColor = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.cmdDel)
        Me.GroupControl1.Controls.Add(Me.txtType)
        Me.GroupControl1.Controls.Add(Me.cmdAdd)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.RadioButton2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.RadioButton1)
        Me.GroupControl1.Controls.Add(Me.Grid1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(586, 307)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "关注项目( 请配置需关注的项目)"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.Grid2)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(165, 307)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "本项目参与人员及时间"
        '
        'cmdDel
        '
        Me.cmdDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDel.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.cmdDel.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.cmdDel.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.cmdDel.Appearance.Options.UseBackColor = True
        Me.cmdDel.Appearance.Options.UseBorderColor = True
        Me.cmdDel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.cmdDel.Image = Global.IT_ProjectManager.My.Resources.Resources.OutlineCollapse
        Me.cmdDel.Location = New System.Drawing.Point(605, 3)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(24, 18)
        Me.cmdDel.TabIndex = 15
        '
        'txtType
        '
        Me.txtType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtType.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtType.Location = New System.Drawing.Point(491, 3)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(84, 16)
        Me.txtType.TabIndex = 14
        Me.txtType.Text = "配置关注项目："
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
        'GridView1
        '
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridView1.Appearance.Empty.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.Empty.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Blue
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Blue
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseFont = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ID, Me.SchemeName, Me.SmPrincipal, Me.SmStartDate, Me.SmEndDate, Me.SmFollow1, Me.sm1Type, Me.sm1Status, Me.important1, Me.emergency1, Me.complete})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'ID
        '
        Me.ID.AppearanceCell.Options.UseTextOptions = True
        Me.ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ID.AppearanceHeader.Options.UseTextOptions = True
        Me.ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ID.Caption = "ID"
        Me.ID.FieldName = "ID"
        Me.ID.Name = "ID"
        Me.ID.OptionsColumn.AllowEdit = False
        Me.ID.OptionsColumn.AllowFocus = False
        Me.ID.OptionsColumn.AllowMove = False
        Me.ID.Visible = True
        Me.ID.VisibleIndex = 0
        Me.ID.Width = 36
        '
        'SchemeName
        '
        Me.SchemeName.AppearanceCell.Options.UseTextOptions = True
        Me.SchemeName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SchemeName.AppearanceHeader.Options.UseTextOptions = True
        Me.SchemeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SchemeName.Caption = "名称"
        Me.SchemeName.FieldName = "SchemeName"
        Me.SchemeName.Name = "SchemeName"
        Me.SchemeName.OptionsColumn.AllowEdit = False
        Me.SchemeName.OptionsColumn.AllowFocus = False
        Me.SchemeName.OptionsColumn.AllowMove = False
        Me.SchemeName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SchemeName", "{0}")})
        Me.SchemeName.Visible = True
        Me.SchemeName.VisibleIndex = 1
        Me.SchemeName.Width = 227
        '
        'SmPrincipal
        '
        Me.SmPrincipal.AppearanceCell.Options.UseTextOptions = True
        Me.SmPrincipal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SmPrincipal.AppearanceHeader.Options.UseTextOptions = True
        Me.SmPrincipal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SmPrincipal.Caption = "负责人"
        Me.SmPrincipal.FieldName = "SmPrincipal"
        Me.SmPrincipal.Name = "SmPrincipal"
        Me.SmPrincipal.OptionsColumn.AllowEdit = False
        Me.SmPrincipal.OptionsColumn.AllowFocus = False
        Me.SmPrincipal.OptionsColumn.AllowMove = False
        Me.SmPrincipal.Visible = True
        Me.SmPrincipal.VisibleIndex = 2
        Me.SmPrincipal.Width = 79
        '
        'SmStartDate
        '
        Me.SmStartDate.AppearanceCell.Options.UseTextOptions = True
        Me.SmStartDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SmStartDate.AppearanceHeader.Options.UseTextOptions = True
        Me.SmStartDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SmStartDate.Caption = "开始时间"
        Me.SmStartDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.SmStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.SmStartDate.FieldName = "SmStartDate"
        Me.SmStartDate.Name = "SmStartDate"
        Me.SmStartDate.OptionsColumn.AllowEdit = False
        Me.SmStartDate.OptionsColumn.AllowFocus = False
        Me.SmStartDate.OptionsColumn.AllowMove = False
        Me.SmStartDate.OptionsColumn.AllowSize = False
        Me.SmStartDate.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Max)})
        Me.SmStartDate.Visible = True
        Me.SmStartDate.VisibleIndex = 3
        Me.SmStartDate.Width = 92
        '
        'SmEndDate
        '
        Me.SmEndDate.AppearanceCell.Options.UseTextOptions = True
        Me.SmEndDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SmEndDate.AppearanceHeader.Options.UseTextOptions = True
        Me.SmEndDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SmEndDate.Caption = "結束時間"
        Me.SmEndDate.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.SmEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.SmEndDate.FieldName = "SmEndDate"
        Me.SmEndDate.Name = "SmEndDate"
        Me.SmEndDate.OptionsColumn.AllowEdit = False
        Me.SmEndDate.OptionsColumn.AllowFocus = False
        Me.SmEndDate.OptionsColumn.AllowMove = False
        Me.SmEndDate.OptionsColumn.AllowSize = False
        Me.SmEndDate.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Min)})
        Me.SmEndDate.Visible = True
        Me.SmEndDate.VisibleIndex = 4
        Me.SmEndDate.Width = 90
        '
        'SmFollow1
        '
        Me.SmFollow1.AppearanceCell.Options.UseTextOptions = True
        Me.SmFollow1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SmFollow1.AppearanceHeader.Options.UseTextOptions = True
        Me.SmFollow1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SmFollow1.Caption = "跟进人"
        Me.SmFollow1.FieldName = "SmFollow1"
        Me.SmFollow1.Name = "SmFollow1"
        Me.SmFollow1.OptionsColumn.AllowEdit = False
        Me.SmFollow1.OptionsColumn.AllowFocus = False
        Me.SmFollow1.OptionsColumn.AllowMove = False
        Me.SmFollow1.OptionsColumn.AllowSize = False
        Me.SmFollow1.Visible = True
        Me.SmFollow1.VisibleIndex = 5
        Me.SmFollow1.Width = 80
        '
        'sm1Type
        '
        Me.sm1Type.AppearanceCell.Options.UseTextOptions = True
        Me.sm1Type.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.sm1Type.AppearanceHeader.Options.UseTextOptions = True
        Me.sm1Type.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.sm1Type.Caption = "类别"
        Me.sm1Type.FieldName = "sm1Type"
        Me.sm1Type.Name = "sm1Type"
        Me.sm1Type.OptionsColumn.AllowEdit = False
        Me.sm1Type.OptionsColumn.AllowFocus = False
        Me.sm1Type.OptionsColumn.AllowMove = False
        Me.sm1Type.OptionsColumn.AllowSize = False
        Me.sm1Type.Visible = True
        Me.sm1Type.VisibleIndex = 6
        Me.sm1Type.Width = 50
        '
        'sm1Status
        '
        Me.sm1Status.AppearanceCell.Options.UseTextOptions = True
        Me.sm1Status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.sm1Status.AppearanceHeader.Options.UseTextOptions = True
        Me.sm1Status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.sm1Status.Caption = "进度"
        Me.sm1Status.FieldName = "sm1Status"
        Me.sm1Status.Name = "sm1Status"
        Me.sm1Status.OptionsColumn.AllowEdit = False
        Me.sm1Status.OptionsColumn.AllowFocus = False
        Me.sm1Status.OptionsColumn.AllowMove = False
        Me.sm1Status.OptionsColumn.AllowSize = False
        Me.sm1Status.Visible = True
        Me.sm1Status.VisibleIndex = 7
        Me.sm1Status.Width = 55
        '
        'important1
        '
        Me.important1.AppearanceCell.Options.UseTextOptions = True
        Me.important1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.important1.AppearanceHeader.Options.UseTextOptions = True
        Me.important1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.important1.Caption = "重要度"
        Me.important1.FieldName = "important1"
        Me.important1.Name = "important1"
        Me.important1.OptionsColumn.AllowEdit = False
        Me.important1.OptionsColumn.AllowFocus = False
        Me.important1.OptionsColumn.AllowMove = False
        Me.important1.OptionsColumn.AllowSize = False
        Me.important1.Visible = True
        Me.important1.VisibleIndex = 8
        Me.important1.Width = 60
        '
        'emergency1
        '
        Me.emergency1.AppearanceCell.Options.UseTextOptions = True
        Me.emergency1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.emergency1.AppearanceHeader.Options.UseTextOptions = True
        Me.emergency1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.emergency1.Caption = "！"
        Me.emergency1.FieldName = "emergency1"
        Me.emergency1.Name = "emergency1"
        Me.emergency1.OptionsColumn.AllowEdit = False
        Me.emergency1.OptionsColumn.AllowFocus = False
        Me.emergency1.OptionsColumn.AllowMove = False
        Me.emergency1.OptionsColumn.AllowSize = False
        Me.emergency1.Visible = True
        Me.emergency1.VisibleIndex = 9
        Me.emergency1.Width = 35
        '
        'complete
        '
        Me.complete.AppearanceCell.Options.UseTextOptions = True
        Me.complete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.complete.AppearanceHeader.Options.UseTextOptions = True
        Me.complete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.complete.Caption = "完成度"
        Me.complete.ColumnEdit = Me.RepositoryItemProgressBar1
        Me.complete.FieldName = "complete"
        Me.complete.Name = "complete"
        Me.complete.OptionsColumn.AllowEdit = False
        Me.complete.OptionsColumn.AllowFocus = False
        Me.complete.OptionsColumn.AllowMove = False
        Me.complete.OptionsColumn.AllowSize = False
        Me.complete.Visible = True
        Me.complete.VisibleIndex = 10
        Me.complete.Width = 70
        '
        'Grid1
        '
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid1.Location = New System.Drawing.Point(2, 25)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar1, Me.RepositoryItemDateEdit1})
        Me.Grid1.Size = New System.Drawing.Size(582, 280)
        Me.Grid1.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Grid1, "單擊：查看月視圖。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "雙擊：查看項目詳細。")
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.RepositoryItemDateEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit2.Mask.EditMask = "yyyy/MM/dd"
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        Me.RepositoryItemDateEdit2.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'GridView2
        '
        Me.GridView2.Appearance.Empty.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridView2.Appearance.Empty.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.FocusedRow.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Blue
        Me.GridView2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Blue
        Me.GridView2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView2.Appearance.HideSelectionRow.Options.UseFont = True
        Me.GridView2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.GridView2.GridControl = Me.Grid2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "工号"
        Me.GridColumn1.FieldName = "followuid"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        Me.GridColumn1.OptionsColumn.AllowMove = False
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "followuid", "參與人數：{0}")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 102
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "姓名"
        Me.GridColumn2.FieldName = "UserName"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.AllowFocus = False
        Me.GridColumn2.OptionsColumn.AllowMove = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 78
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "时间"
        Me.GridColumn3.DisplayFormat.FormatString = "{0}"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "cumulativeTime"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.AllowFocus = False
        Me.GridColumn3.OptionsColumn.AllowMove = False
        Me.GridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cumulativeTime", "合計耗時：{0}")})
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 103
        '
        'Grid2
        '
        Me.Grid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid2.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Grid2.Location = New System.Drawing.Point(2, 22)
        Me.Grid2.MainView = Me.GridView2
        Me.Grid2.Name = "Grid2"
        Me.Grid2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar2, Me.RepositoryItemDateEdit2})
        Me.Grid2.Size = New System.Drawing.Size(161, 283)
        Me.Grid2.TabIndex = 3
        Me.Grid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'mdlProjectView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainerControl2)
        Me.Name = "mdlProjectView"
        Me.Size = New System.Drawing.Size(756, 485)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtType As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SchemeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SmPrincipal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SmStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SmEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SmFollow1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sm1Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sm1Status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents important1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents emergency1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents complete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Grid2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemProgressBar2 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit

End Class
