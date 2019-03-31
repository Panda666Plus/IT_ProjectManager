<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GroupManage
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
        Me.AssessControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.AutoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UserName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Groups = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsLeader = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ManageGroups = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsProjectManager = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.iSReceive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SendMailTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.isglobaluser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.CEisshow = New DevExpress.XtraEditors.CheckEdit()
        Me.CEIsGlobaluser = New DevExpress.XtraEditors.CheckEdit()
        Me.btupdateemployee = New DevExpress.XtraEditors.SimpleButton()
        Me.txtMail = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TESendMailTime = New DevExpress.XtraEditors.TimeEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.ckiSReceive = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_close = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.CBGroups = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.tbSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lb = New DevExpress.XtraEditors.LabelControl()
        Me.CBEGroups = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblworkPlace = New DevExpress.XtraEditors.LabelControl()
        Me.lblPost = New DevExpress.XtraEditors.LabelControl()
        Me.CEIsProManager = New DevExpress.XtraEditors.CheckEdit()
        Me.CKIsLeader = New DevExpress.XtraEditors.CheckEdit()
        Me.lblUserName = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtJob = New DevExpress.XtraEditors.LookUpEdit()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        CType(Me.AssessControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.CEisshow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEIsGlobaluser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESendMailTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckiSReceive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBGroups.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBEGroups.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEIsProManager.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CKIsLeader.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJob.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AssessControl
        '
        Me.AssessControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AssessControl.Location = New System.Drawing.Point(0, 166)
        Me.AssessControl.MainView = Me.GridView1
        Me.AssessControl.Name = "AssessControl"
        Me.AssessControl.Size = New System.Drawing.Size(597, 298)
        Me.AssessControl.TabIndex = 1
        Me.AssessControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Empty.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Empty.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AutoID, Me.UserName, Me.Groups, Me.IsLeader, Me.ManageGroups, Me.IsProjectManager, Me.iSReceive, Me.SendMailTime, Me.isglobaluser})
        Me.GridView1.GridControl = Me.AssessControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'AutoID
        '
        Me.AutoID.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.AutoID.AppearanceCell.Options.UseFont = True
        Me.AutoID.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.AutoID.AppearanceHeader.Options.UseFont = True
        Me.AutoID.AppearanceHeader.Options.UseTextOptions = True
        Me.AutoID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AutoID.Caption = "ID"
        Me.AutoID.FieldName = "AutoID"
        Me.AutoID.Name = "AutoID"
        Me.AutoID.OptionsColumn.AllowEdit = False
        Me.AutoID.OptionsColumn.FixedWidth = True
        Me.AutoID.OptionsColumn.ReadOnly = True
        Me.AutoID.Visible = True
        Me.AutoID.VisibleIndex = 0
        Me.AutoID.Width = 50
        '
        'UserName
        '
        Me.UserName.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.UserName.AppearanceCell.Options.UseFont = True
        Me.UserName.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.UserName.AppearanceHeader.Options.UseFont = True
        Me.UserName.AppearanceHeader.Options.UseTextOptions = True
        Me.UserName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.UserName.Caption = "姓名"
        Me.UserName.FieldName = "UserName"
        Me.UserName.Name = "UserName"
        Me.UserName.OptionsColumn.AllowEdit = False
        Me.UserName.OptionsColumn.FixedWidth = True
        Me.UserName.OptionsColumn.ReadOnly = True
        Me.UserName.Visible = True
        Me.UserName.VisibleIndex = 1
        Me.UserName.Width = 100
        '
        'Groups
        '
        Me.Groups.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Groups.AppearanceCell.Options.UseFont = True
        Me.Groups.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Groups.AppearanceHeader.Options.UseFont = True
        Me.Groups.AppearanceHeader.Options.UseTextOptions = True
        Me.Groups.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Groups.Caption = "所属组别"
        Me.Groups.FieldName = "Groups"
        Me.Groups.Name = "Groups"
        Me.Groups.OptionsColumn.AllowEdit = False
        Me.Groups.OptionsColumn.FixedWidth = True
        Me.Groups.OptionsColumn.ReadOnly = True
        Me.Groups.Visible = True
        Me.Groups.VisibleIndex = 2
        Me.Groups.Width = 100
        '
        'IsLeader
        '
        Me.IsLeader.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.IsLeader.AppearanceCell.ForeColor = System.Drawing.Color.Blue
        Me.IsLeader.AppearanceCell.Options.UseFont = True
        Me.IsLeader.AppearanceCell.Options.UseForeColor = True
        Me.IsLeader.AppearanceCell.Options.UseTextOptions = True
        Me.IsLeader.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.IsLeader.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.IsLeader.AppearanceHeader.Options.UseFont = True
        Me.IsLeader.AppearanceHeader.Options.UseTextOptions = True
        Me.IsLeader.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.IsLeader.Caption = "项目组长"
        Me.IsLeader.FieldName = "IsLeader"
        Me.IsLeader.Name = "IsLeader"
        Me.IsLeader.OptionsColumn.AllowEdit = False
        Me.IsLeader.OptionsColumn.FixedWidth = True
        Me.IsLeader.OptionsColumn.ReadOnly = True
        Me.IsLeader.Visible = True
        Me.IsLeader.VisibleIndex = 3
        Me.IsLeader.Width = 61
        '
        'ManageGroups
        '
        Me.ManageGroups.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ManageGroups.AppearanceCell.Options.UseFont = True
        Me.ManageGroups.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ManageGroups.AppearanceHeader.Options.UseFont = True
        Me.ManageGroups.AppearanceHeader.Options.UseTextOptions = True
        Me.ManageGroups.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ManageGroups.Caption = "管理组别"
        Me.ManageGroups.FieldName = "ManageGroups"
        Me.ManageGroups.Name = "ManageGroups"
        Me.ManageGroups.OptionsColumn.AllowEdit = False
        Me.ManageGroups.OptionsColumn.AllowFocus = False
        Me.ManageGroups.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.ManageGroups.OptionsColumn.FixedWidth = True
        Me.ManageGroups.OptionsColumn.ReadOnly = True
        Me.ManageGroups.Visible = True
        Me.ManageGroups.VisibleIndex = 4
        Me.ManageGroups.Width = 95
        '
        'IsProjectManager
        '
        Me.IsProjectManager.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.IsProjectManager.AppearanceCell.ForeColor = System.Drawing.Color.Blue
        Me.IsProjectManager.AppearanceCell.Options.UseFont = True
        Me.IsProjectManager.AppearanceCell.Options.UseForeColor = True
        Me.IsProjectManager.AppearanceCell.Options.UseTextOptions = True
        Me.IsProjectManager.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.IsProjectManager.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.IsProjectManager.AppearanceHeader.Options.UseFont = True
        Me.IsProjectManager.AppearanceHeader.Options.UseTextOptions = True
        Me.IsProjectManager.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.IsProjectManager.Caption = "项目经理"
        Me.IsProjectManager.FieldName = "IsProjectManager"
        Me.IsProjectManager.Name = "IsProjectManager"
        Me.IsProjectManager.OptionsColumn.AllowEdit = False
        Me.IsProjectManager.OptionsColumn.FixedWidth = True
        Me.IsProjectManager.OptionsColumn.ReadOnly = True
        Me.IsProjectManager.Visible = True
        Me.IsProjectManager.VisibleIndex = 5
        Me.IsProjectManager.Width = 63
        '
        'iSReceive
        '
        Me.iSReceive.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.iSReceive.AppearanceCell.Options.UseFont = True
        Me.iSReceive.AppearanceCell.Options.UseTextOptions = True
        Me.iSReceive.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.iSReceive.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.iSReceive.AppearanceHeader.Options.UseFont = True
        Me.iSReceive.AppearanceHeader.Options.UseTextOptions = True
        Me.iSReceive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.iSReceive.Caption = "接收邮件"
        Me.iSReceive.FieldName = "iSReceive"
        Me.iSReceive.Name = "iSReceive"
        Me.iSReceive.OptionsColumn.AllowEdit = False
        Me.iSReceive.OptionsColumn.AllowFocus = False
        Me.iSReceive.OptionsColumn.AllowSize = False
        Me.iSReceive.OptionsColumn.FixedWidth = True
        Me.iSReceive.OptionsColumn.ReadOnly = True
        Me.iSReceive.Visible = True
        Me.iSReceive.VisibleIndex = 6
        Me.iSReceive.Width = 61
        '
        'SendMailTime
        '
        Me.SendMailTime.AppearanceCell.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SendMailTime.AppearanceCell.Options.UseFont = True
        Me.SendMailTime.AppearanceCell.Options.UseTextOptions = True
        Me.SendMailTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.SendMailTime.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SendMailTime.AppearanceHeader.Options.UseFont = True
        Me.SendMailTime.AppearanceHeader.Options.UseTextOptions = True
        Me.SendMailTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SendMailTime.Caption = "发送时间 "
        Me.SendMailTime.FieldName = "SendMailTime"
        Me.SendMailTime.Name = "SendMailTime"
        Me.SendMailTime.OptionsColumn.AllowEdit = False
        Me.SendMailTime.OptionsColumn.AllowFocus = False
        Me.SendMailTime.OptionsColumn.AllowSize = False
        Me.SendMailTime.OptionsColumn.FixedWidth = True
        Me.SendMailTime.OptionsColumn.ReadOnly = True
        Me.SendMailTime.Visible = True
        Me.SendMailTime.VisibleIndex = 7
        Me.SendMailTime.Width = 63
        '
        'isglobaluser
        '
        Me.isglobaluser.Caption = "全局用户"
        Me.isglobaluser.FieldName = "isglobaluser"
        Me.isglobaluser.Name = "isglobaluser"
        Me.isglobaluser.Visible = True
        Me.isglobaluser.VisibleIndex = 8
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.CEisshow)
        Me.PanelControl1.Controls.Add(Me.CEIsGlobaluser)
        Me.PanelControl1.Controls.Add(Me.btupdateemployee)
        Me.PanelControl1.Controls.Add(Me.txtMail)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.TESendMailTime)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.ckiSReceive)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.tb_close)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.CBGroups)
        Me.PanelControl1.Controls.Add(Me.tbSave)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.lb)
        Me.PanelControl1.Controls.Add(Me.CBEGroups)
        Me.PanelControl1.Controls.Add(Me.lblworkPlace)
        Me.PanelControl1.Controls.Add(Me.lblPost)
        Me.PanelControl1.Controls.Add(Me.CEIsProManager)
        Me.PanelControl1.Controls.Add(Me.CKIsLeader)
        Me.PanelControl1.Controls.Add(Me.lblUserName)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtJob)
        Me.PanelControl1.Controls.Add(Me.ShapeContainer1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(597, 166)
        Me.PanelControl1.TabIndex = 2
        '
        'CEisshow
        '
        Me.CEisshow.Location = New System.Drawing.Point(301, 42)
        Me.CEisshow.Name = "CEisshow"
        Me.CEisshow.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CEisshow.Properties.Appearance.Options.UseFont = True
        Me.CEisshow.Properties.Caption = "显示"
        Me.CEisshow.Size = New System.Drawing.Size(47, 22)
        Me.CEisshow.TabIndex = 30
        '
        'CEIsGlobaluser
        '
        Me.CEIsGlobaluser.Location = New System.Drawing.Point(222, 60)
        Me.CEIsGlobaluser.Name = "CEIsGlobaluser"
        Me.CEIsGlobaluser.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CEIsGlobaluser.Properties.Appearance.Options.UseFont = True
        Me.CEIsGlobaluser.Properties.Caption = "全局用户"
        Me.CEIsGlobaluser.Size = New System.Drawing.Size(73, 22)
        Me.CEIsGlobaluser.TabIndex = 29
        '
        'btupdateemployee
        '
        Me.btupdateemployee.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btupdateemployee.Appearance.Options.UseFont = True
        Me.btupdateemployee.Image = Global.IT_ProjectManager.My.Resources.Resources.QueryAppend
        Me.btupdateemployee.Location = New System.Drawing.Point(291, 132)
        Me.btupdateemployee.Name = "btupdateemployee"
        Me.btupdateemployee.Size = New System.Drawing.Size(96, 27)
        Me.btupdateemployee.TabIndex = 28
        Me.btupdateemployee.Text = "更新资料"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(426, 91)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtMail.Properties.Appearance.Options.UseFont = True
        Me.txtMail.Properties.ReadOnly = True
        Me.txtMail.Size = New System.Drawing.Size(165, 24)
        Me.txtMail.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(394, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "邮件"
        '
        'TESendMailTime
        '
        Me.TESendMailTime.EditValue = New Date(2013, 12, 18, 12, 0, 0, 0)
        Me.TESendMailTime.Enabled = False
        Me.TESendMailTime.Location = New System.Drawing.Point(291, 93)
        Me.TESendMailTime.Name = "TESendMailTime"
        Me.TESendMailTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TESendMailTime.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.TESendMailTime.Size = New System.Drawing.Size(97, 20)
        Me.TESendMailTime.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "何时接收："
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(5, 95)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(65, 17)
        Me.LabelControl6.TabIndex = 22
        Me.LabelControl6.Text = "邮件提醒："
        '
        'ckiSReceive
        '
        Me.ckiSReceive.Location = New System.Drawing.Point(72, 92)
        Me.ckiSReceive.Name = "ckiSReceive"
        Me.ckiSReceive.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ckiSReceive.Properties.Appearance.Options.UseFont = True
        Me.ckiSReceive.Properties.Caption = "接收超期项目通知(天)"
        Me.ckiSReceive.Size = New System.Drawing.Size(148, 22)
        Me.ckiSReceive.TabIndex = 21
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl5.Location = New System.Drawing.Point(12, 137)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(153, 19)
        Me.LabelControl5.TabIndex = 20
        Me.LabelControl5.Text = "注：双击修改选中数据."
        '
        'tb_close
        '
        Me.tb_close.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_close.Appearance.Options.UseFont = True
        Me.tb_close.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestDeny
        Me.tb_close.Location = New System.Drawing.Point(515, 132)
        Me.tb_close.Name = "tb_close"
        Me.tb_close.Size = New System.Drawing.Size(67, 27)
        Me.tb_close.TabIndex = 19
        Me.tb_close.Text = "关闭"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(5, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(65, 17)
        Me.LabelControl2.TabIndex = 18
        Me.LabelControl2.Text = "所属组别："
        '
        'CBGroups
        '
        Me.CBGroups.Location = New System.Drawing.Point(72, 51)
        Me.CBGroups.Name = "CBGroups"
        Me.CBGroups.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CBGroups.Properties.Appearance.Options.UseFont = True
        Me.CBGroups.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CBGroups.Properties.Items.AddRange(New Object() {"DT部", "维护组", "软件组"})
        Me.CBGroups.Size = New System.Drawing.Size(125, 24)
        Me.CBGroups.TabIndex = 17
        '
        'tbSave
        '
        Me.tbSave.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSave.Appearance.Options.UseFont = True
        Me.tbSave.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestAllow
        Me.tbSave.Location = New System.Drawing.Point(426, 132)
        Me.tbSave.Name = "tbSave"
        Me.tbSave.Size = New System.Drawing.Size(67, 27)
        Me.tbSave.TabIndex = 16
        Me.tbSave.Text = "确认"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(482, 15)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(39, 17)
        Me.LabelControl4.TabIndex = 15
        Me.LabelControl4.Text = "公司："
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(348, 15)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(39, 17)
        Me.LabelControl3.TabIndex = 14
        Me.LabelControl3.Text = "职称："
        '
        'lb
        '
        Me.lb.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lb.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lb.Location = New System.Drawing.Point(224, 15)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(39, 17)
        Me.lb.TabIndex = 13
        Me.lb.Text = "工号："
        '
        'CBEGroups
        '
        Me.CBEGroups.Location = New System.Drawing.Point(424, 51)
        Me.CBEGroups.Name = "CBEGroups"
        Me.CBEGroups.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CBEGroups.Properties.Appearance.Options.UseFont = True
        Me.CBEGroups.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CBEGroups.Properties.Items.AddRange(New Object() {"软件组(C/S)", "软件组(B/S)", "测试组", "维护组"})
        Me.CBEGroups.Size = New System.Drawing.Size(168, 24)
        Me.CBEGroups.TabIndex = 12
        '
        'lblworkPlace
        '
        Me.lblworkPlace.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblworkPlace.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblworkPlace.Location = New System.Drawing.Point(519, 15)
        Me.lblworkPlace.Name = "lblworkPlace"
        Me.lblworkPlace.Size = New System.Drawing.Size(26, 17)
        Me.lblworkPlace.TabIndex = 10
        Me.lblworkPlace.Text = "公司"
        '
        'lblPost
        '
        Me.lblPost.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPost.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblPost.Location = New System.Drawing.Point(386, 15)
        Me.lblPost.Name = "lblPost"
        Me.lblPost.Size = New System.Drawing.Size(26, 17)
        Me.lblPost.TabIndex = 9
        Me.lblPost.Text = "职称"
        '
        'CEIsProManager
        '
        Me.CEIsProManager.Location = New System.Drawing.Point(222, 42)
        Me.CEIsProManager.Name = "CEIsProManager"
        Me.CEIsProManager.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CEIsProManager.Properties.Appearance.Options.UseFont = True
        Me.CEIsProManager.Properties.Caption = "项目经理"
        Me.CEIsProManager.Size = New System.Drawing.Size(75, 22)
        Me.CEIsProManager.TabIndex = 5
        '
        'CKIsLeader
        '
        Me.CKIsLeader.Location = New System.Drawing.Point(345, 52)
        Me.CKIsLeader.Name = "CKIsLeader"
        Me.CKIsLeader.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CKIsLeader.Properties.Appearance.Options.UseFont = True
        Me.CKIsLeader.Properties.Caption = "项目组长"
        Me.CKIsLeader.Size = New System.Drawing.Size(75, 22)
        Me.CKIsLeader.TabIndex = 4
        '
        'lblUserName
        '
        Me.lblUserName.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblUserName.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblUserName.Location = New System.Drawing.Point(261, 15)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(26, 17)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.Text = "工号"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(5, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(57, 17)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "姓      名："
        '
        'txtJob
        '
        Me.txtJob.Location = New System.Drawing.Point(72, 11)
        Me.txtJob.Name = "txtJob"
        Me.txtJob.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtJob.Properties.Appearance.Options.UseFont = True
        Me.txtJob.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJob.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("pName", "姓名"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("employeeID", "职位编号")})
        Me.txtJob.Properties.NullText = ""
        Me.txtJob.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtJob.Size = New System.Drawing.Size(125, 24)
        Me.txtJob.TabIndex = 1
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(2, 2)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(593, 162)
        Me.ShapeContainer1.TabIndex = 25
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.Green
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = -2
        Me.LineShape3.X2 = 594
        Me.LineShape3.Y1 = 121
        Me.LineShape3.Y2 = 121
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Green
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = -2
        Me.LineShape2.X2 = 594
        Me.LineShape2.Y1 = 38
        Me.LineShape2.Y2 = 38
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Green
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -2
        Me.LineShape1.X2 = 594
        Me.LineShape1.Y1 = 80
        Me.LineShape1.Y2 = 80
        '
        'GroupManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 464)
        Me.Controls.Add(Me.AssessControl)
        Me.Controls.Add(Me.PanelControl1)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GroupManage"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "人员组别管理"
        CType(Me.AssessControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.CEisshow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEIsGlobaluser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESendMailTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckiSReceive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBGroups.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBEGroups.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEIsProManager.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CKIsLeader.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJob.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AssessControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CKIsLeader As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblUserName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CEIsProManager As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblPost As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblworkPlace As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CBEGroups As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lb As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tbSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AutoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Groups As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsLeader As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsProjectManager As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtJob As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CBGroups As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ManageGroups As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tb_close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckiSReceive As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TESendMailTime As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents iSReceive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SendMailTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btupdateemployee As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CEIsGlobaluser As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents isglobaluser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CEisshow As DevExpress.XtraEditors.CheckEdit
End Class
