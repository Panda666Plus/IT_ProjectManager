<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMyTasks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMyTasks))
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        Me.txtRemark = New DevExpress.XtraEditors.MemoEdit()
        Me.txtScheme = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSchemeID = New DevExpress.XtraEditors.LabelControl()
        Me.txtID = New DevExpress.XtraEditors.LabelControl()
        Me.chkComplete = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdScheme = New DevExpress.XtraEditors.SimpleButton()
        Me.txtContext = New DevExpress.XtraEditors.LookUpEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.StartDate = New DevExpress.XtraEditors.TimeEdit()
        Me.EndDate = New DevExpress.XtraEditors.TimeEdit()
        Me.chkLabel = New DevExpress.XtraEditors.CheckButton()
        Me.cmdDel = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtScheme.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.chkComplete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContext.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Location = New System.Drawing.Point(2, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtName.Properties.Appearance.Options.UseFont = True
        Me.txtName.Properties.Appearance.Options.UseForeColor = True
        Me.txtName.Size = New System.Drawing.Size(526, 26)
        Me.txtName.TabIndex = 0
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(57, 126)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemark.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRemark.Properties.Appearance.Options.UseFont = True
        Me.txtRemark.Properties.Appearance.Options.UseForeColor = True
        Me.txtRemark.Size = New System.Drawing.Size(472, 129)
        Me.txtRemark.TabIndex = 5
        '
        'txtScheme
        '
        Me.txtScheme.Location = New System.Drawing.Point(57, 68)
        Me.txtScheme.Name = "txtScheme"
        Me.txtScheme.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScheme.Properties.Appearance.Options.UseFont = True
        Me.txtScheme.Properties.ReadOnly = True
        Me.txtScheme.Size = New System.Drawing.Size(378, 26)
        Me.txtScheme.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(4, 7)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "標題："
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(5, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "开始："
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(284, 41)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "截止："
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(5, 71)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl4.TabIndex = 12
        Me.LabelControl4.Text = "项目："
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(5, 128)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "备注："
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtName)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(1, 2)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(530, 33)
        Me.PanelControl1.TabIndex = 21
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(2, 102)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(52, 17)
        Me.LabelControl7.TabIndex = 25
        Me.LabelControl7.Text = "上下文："
        '
        'txtSchemeID
        '
        Me.txtSchemeID.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchemeID.Location = New System.Drawing.Point(5, 254)
        Me.txtSchemeID.Name = "txtSchemeID"
        Me.txtSchemeID.Size = New System.Drawing.Size(0, 19)
        Me.txtSchemeID.TabIndex = 26
        Me.txtSchemeID.Visible = False
        '
        'txtID
        '
        Me.txtID.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(5, 165)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(15, 19)
        Me.txtID.TabIndex = 10
        Me.txtID.Text = "ID"
        Me.txtID.Visible = False
        '
        'chkComplete
        '
        Me.chkComplete.Location = New System.Drawing.Point(56, 267)
        Me.chkComplete.Name = "chkComplete"
        Me.chkComplete.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkComplete.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.chkComplete.Properties.Appearance.Options.UseFont = True
        Me.chkComplete.Properties.Appearance.Options.UseForeColor = True
        Me.chkComplete.Properties.Caption = "完成"
        Me.chkComplete.Size = New System.Drawing.Size(66, 25)
        Me.chkComplete.TabIndex = 27
        '
        'cmdScheme
        '
        Me.cmdScheme.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdScheme.Appearance.Options.UseFont = True
        Me.cmdScheme.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdScheme.Image = Global.IT_ProjectManager.My.Resources.Resources.OrganizerHS
        Me.cmdScheme.Location = New System.Drawing.Point(460, 68)
        Me.cmdScheme.Name = "cmdScheme"
        Me.cmdScheme.Size = New System.Drawing.Size(69, 26)
        Me.cmdScheme.TabIndex = 8
        Me.cmdScheme.Text = "项目"
        '
        'txtContext
        '
        Me.txtContext.EditValue = "24"
        Me.txtContext.Location = New System.Drawing.Point(57, 97)
        Me.txtContext.Name = "txtContext"
        Me.txtContext.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtContext.Properties.Appearance.Options.UseFont = True
        Me.txtContext.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtContext.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtContext.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContext.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtContext.Properties.AppearanceFocused.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContext.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtContext.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContext.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtContext.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtContext.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProStatus", "ProStatus")})
        Me.txtContext.Properties.DisplayMember = "ProStatus"
        Me.txtContext.Properties.NullText = ""
        Me.txtContext.Properties.ShowFooter = False
        Me.txtContext.Properties.ShowHeader = False
        Me.txtContext.Properties.ShowLines = False
        Me.txtContext.Properties.ShowPopupShadow = False
        Me.txtContext.Properties.ValueMember = "ID"
        Me.txtContext.Size = New System.Drawing.Size(473, 26)
        Me.txtContext.TabIndex = 29
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton1.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestDeny
        Me.SimpleButton1.Location = New System.Drawing.Point(437, 68)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(24, 26)
        Me.SimpleButton1.TabIndex = 30
        '
        'StartDate
        '
        Me.StartDate.EditValue = Nothing
        Me.StartDate.Location = New System.Drawing.Point(57, 38)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.StartDate.Properties.Appearance.Options.UseFont = True
        Me.StartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.StartDate.Properties.DisplayFormat.FormatString = "g"
        Me.StartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.StartDate.Properties.EditFormat.FormatString = "g"
        Me.StartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.StartDate.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.StartDate.Properties.Mask.EditMask = "g"
        Me.StartDate.Size = New System.Drawing.Size(199, 26)
        Me.StartDate.TabIndex = 1
        '
        'EndDate
        '
        Me.EndDate.EditValue = Nothing
        Me.EndDate.Location = New System.Drawing.Point(332, 38)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.EndDate.Properties.Appearance.Options.UseFont = True
        Me.EndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.EndDate.Properties.DisplayFormat.FormatString = "g"
        Me.EndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.EndDate.Properties.EditFormat.FormatString = "g"
        Me.EndDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.EndDate.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.EndDate.Properties.Mask.EditMask = "g"
        Me.EndDate.Size = New System.Drawing.Size(199, 26)
        Me.EndDate.TabIndex = 2
        '
        'chkLabel
        '
        Me.chkLabel.Appearance.BorderColor = System.Drawing.Color.White
        Me.chkLabel.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLabel.Appearance.ForeColor = System.Drawing.Color.Red
        Me.chkLabel.Appearance.Options.UseBorderColor = True
        Me.chkLabel.Appearance.Options.UseFont = True
        Me.chkLabel.Appearance.Options.UseForeColor = True
        Me.chkLabel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.chkLabel.Image = Global.IT_ProjectManager.My.Resources.Resources.Flag_redHS
        Me.chkLabel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.chkLabel.Location = New System.Drawing.Point(128, 264)
        Me.chkLabel.Name = "chkLabel"
        Me.chkLabel.Size = New System.Drawing.Size(69, 31)
        Me.chkLabel.TabIndex = 1
        Me.chkLabel.Text = "未标注"
        '
        'cmdDel
        '
        Me.cmdDel.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdDel.Appearance.Options.UseFont = True
        Me.cmdDel.Image = CType(resources.GetObject("cmdDel.Image"), System.Drawing.Image)
        Me.cmdDel.Location = New System.Drawing.Point(262, 264)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(77, 31)
        Me.cmdDel.TabIndex = 22
        Me.cmdDel.Text = "删除"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(356, 264)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(77, 31)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "保存"
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(449, 264)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(77, 31)
        Me.cmdExit.TabIndex = 19
        Me.cmdExit.Text = "退出"
        '
        'frmMyTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.txtContext)
        Me.Controls.Add(Me.chkComplete)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.chkLabel)
        Me.Controls.Add(Me.txtSchemeID)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.cmdDel)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cmdScheme)
        Me.Controls.Add(Me.txtScheme)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.StartDate)
        Me.Controls.Add(Me.EndDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMyTasks"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "待办事项"
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtScheme.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.chkComplete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContext.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkLabel As DevExpress.XtraEditors.CheckButton
    Friend WithEvents txtRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtScheme As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdScheme As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSchemeID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkComplete As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtContext As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents StartDate As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents EndDate As DevExpress.XtraEditors.TimeEdit
End Class
