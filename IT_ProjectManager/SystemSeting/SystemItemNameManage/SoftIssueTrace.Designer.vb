<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SoftIssueTrace
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.be_issueArea = New DevExpress.XtraEditors.ButtonEdit()
        Me.lp_issuer = New DevExpress.XtraEditors.LookUpEdit()
        Me.lp_applyissuer = New DevExpress.XtraEditors.LookUpEdit()
        Me.me_ps = New DevExpress.XtraEditors.MemoEdit()
        Me.me_issurDesc = New DevExpress.XtraEditors.MemoEdit()
        Me.tb_issueDate = New DevExpress.XtraEditors.DateEdit()
        Me.me_issueReason = New DevExpress.XtraEditors.MemoEdit()
        Me.tb_applyissueDate = New DevExpress.XtraEditors.DateEdit()
        Me.tb_applyDate = New DevExpress.XtraEditors.DateEdit()
        Me.tb_verNo = New System.Windows.Forms.TextBox()
        Me.tb_issueNo = New System.Windows.Forms.TextBox()
        Me.SystemName = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1.SuspendLayout()
        CType(Me.be_issueArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lp_issuer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lp_applyissuer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.me_ps.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.me_issurDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_issueDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_issueDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.me_issueReason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_applyissueDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_applyissueDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_applyDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_applyDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.be_issueArea)
        Me.Panel1.Controls.Add(Me.lp_issuer)
        Me.Panel1.Controls.Add(Me.lp_applyissuer)
        Me.Panel1.Controls.Add(Me.me_ps)
        Me.Panel1.Controls.Add(Me.me_issurDesc)
        Me.Panel1.Controls.Add(Me.tb_issueDate)
        Me.Panel1.Controls.Add(Me.me_issueReason)
        Me.Panel1.Controls.Add(Me.tb_applyissueDate)
        Me.Panel1.Controls.Add(Me.tb_applyDate)
        Me.Panel1.Controls.Add(Me.tb_verNo)
        Me.Panel1.Controls.Add(Me.tb_issueNo)
        Me.Panel1.Controls.Add(Me.SystemName)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(564, 411)
        Me.Panel1.TabIndex = 0
        '
        'be_issueArea
        '
        Me.be_issueArea.Location = New System.Drawing.Point(389, 123)
        Me.be_issueArea.Name = "be_issueArea"
        Me.be_issueArea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.be_issueArea.Size = New System.Drawing.Size(163, 20)
        Me.be_issueArea.TabIndex = 29
        '
        'lp_issuer
        '
        Me.lp_issuer.Location = New System.Drawing.Point(93, 216)
        Me.lp_issuer.Name = "lp_issuer"
        Me.lp_issuer.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lp_issuer.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lp_issuer.Properties.Appearance.Options.UseFont = True
        Me.lp_issuer.Properties.Appearance.Options.UseForeColor = True
        Me.lp_issuer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lp_issuer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "UserName"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserNo", "UserNo", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.lp_issuer.Properties.NullText = ""
        Me.lp_issuer.Properties.PopupSizeable = False
        Me.lp_issuer.Properties.ShowFooter = False
        Me.lp_issuer.Properties.ShowHeader = False
        Me.lp_issuer.Properties.ShowLines = False
        Me.lp_issuer.Properties.ShowPopupShadow = False
        Me.lp_issuer.Size = New System.Drawing.Size(165, 24)
        Me.lp_issuer.TabIndex = 28
        '
        'lp_applyissuer
        '
        Me.lp_applyissuer.Location = New System.Drawing.Point(95, 90)
        Me.lp_applyissuer.Name = "lp_applyissuer"
        Me.lp_applyissuer.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lp_applyissuer.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lp_applyissuer.Properties.Appearance.Options.UseFont = True
        Me.lp_applyissuer.Properties.Appearance.Options.UseForeColor = True
        Me.lp_applyissuer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lp_applyissuer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "UserName"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserNo", "UserNo", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.lp_applyissuer.Properties.NullText = ""
        Me.lp_applyissuer.Properties.PopupSizeable = False
        Me.lp_applyissuer.Properties.ShowFooter = False
        Me.lp_applyissuer.Properties.ShowHeader = False
        Me.lp_applyissuer.Properties.ShowLines = False
        Me.lp_applyissuer.Properties.ShowPopupShadow = False
        Me.lp_applyissuer.Size = New System.Drawing.Size(165, 24)
        Me.lp_applyissuer.TabIndex = 27
        '
        'me_ps
        '
        Me.me_ps.Location = New System.Drawing.Point(92, 305)
        Me.me_ps.Name = "me_ps"
        Me.me_ps.Size = New System.Drawing.Size(461, 53)
        Me.me_ps.TabIndex = 26
        '
        'me_issurDesc
        '
        Me.me_issurDesc.Location = New System.Drawing.Point(91, 246)
        Me.me_issurDesc.Name = "me_issurDesc"
        Me.me_issurDesc.Size = New System.Drawing.Size(461, 53)
        Me.me_issurDesc.TabIndex = 25
        '
        'tb_issueDate
        '
        Me.tb_issueDate.EditValue = Nothing
        Me.tb_issueDate.Location = New System.Drawing.Point(389, 220)
        Me.tb_issueDate.Name = "tb_issueDate"
        Me.tb_issueDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tb_issueDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.tb_issueDate.Size = New System.Drawing.Size(163, 20)
        Me.tb_issueDate.TabIndex = 24
        '
        'me_issueReason
        '
        Me.me_issueReason.Location = New System.Drawing.Point(95, 153)
        Me.me_issueReason.Name = "me_issueReason"
        Me.me_issueReason.Size = New System.Drawing.Size(457, 53)
        Me.me_issueReason.TabIndex = 22
        '
        'tb_applyissueDate
        '
        Me.tb_applyissueDate.EditValue = Nothing
        Me.tb_applyissueDate.Location = New System.Drawing.Point(95, 127)
        Me.tb_applyissueDate.Name = "tb_applyissueDate"
        Me.tb_applyissueDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tb_applyissueDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.tb_applyissueDate.Size = New System.Drawing.Size(163, 20)
        Me.tb_applyissueDate.TabIndex = 21
        '
        'tb_applyDate
        '
        Me.tb_applyDate.EditValue = Nothing
        Me.tb_applyDate.Location = New System.Drawing.Point(389, 96)
        Me.tb_applyDate.Name = "tb_applyDate"
        Me.tb_applyDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tb_applyDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.tb_applyDate.Size = New System.Drawing.Size(163, 20)
        Me.tb_applyDate.TabIndex = 20
        '
        'tb_verNo
        '
        Me.tb_verNo.Location = New System.Drawing.Point(92, 50)
        Me.tb_verNo.Name = "tb_verNo"
        Me.tb_verNo.Size = New System.Drawing.Size(168, 21)
        Me.tb_verNo.TabIndex = 18
        '
        'tb_issueNo
        '
        Me.tb_issueNo.Location = New System.Drawing.Point(380, 22)
        Me.tb_issueNo.Name = "tb_issueNo"
        Me.tb_issueNo.ReadOnly = True
        Me.tb_issueNo.Size = New System.Drawing.Size(168, 21)
        Me.tb_issueNo.TabIndex = 17
        '
        'SystemName
        '
        Me.SystemName.Location = New System.Drawing.Point(92, 22)
        Me.SystemName.Name = "SystemName"
        Me.SystemName.ReadOnly = True
        Me.SystemName.Size = New System.Drawing.Size(168, 21)
        Me.SystemName.TabIndex = 16
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(24, 364)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(540, 2)
        Me.Button3.TabIndex = 15
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(12, 212)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(540, 2)
        Me.Button2.TabIndex = 14
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(12, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(540, 2)
        Me.Button1.TabIndex = 13
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(30, 270)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 12)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "发布说明:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(318, 225)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 12)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "发布日期:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(30, 223)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 12)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "发布人:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(42, 330)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 12)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "备注:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(306, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 12)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "发布区域:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 12)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "发布原因:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 12)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "申请发布日期:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(306, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 12)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "申请日期:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 12)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "申请发布人:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "版本号:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(318, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "更新编号:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "项目名称:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmdExit)
        Me.Panel2.Controls.Add(Me.cmdSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 372)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(564, 39)
        Me.Panel2.TabIndex = 1
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestDeny
        Me.cmdExit.Location = New System.Drawing.Point(479, 8)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(73, 28)
        Me.cmdExit.TabIndex = 16
        Me.cmdExit.Text = "退出"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestAllow
        Me.cmdSave.Location = New System.Drawing.Point(386, 8)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(73, 28)
        Me.cmdSave.TabIndex = 15
        Me.cmdSave.Text = "保存"
        '
        'SoftIssueTrace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 411)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SoftIssueTrace"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SoftIssueTrace"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.be_issueArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lp_issuer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lp_applyissuer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.me_ps.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.me_issurDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_issueDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_issueDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.me_issueReason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_applyissueDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_applyissueDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_applyDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_applyDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents me_ps As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents me_issurDesc As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents tb_issueDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents me_issueReason As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents tb_applyissueDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tb_applyDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tb_verNo As System.Windows.Forms.TextBox
    Friend WithEvents tb_issueNo As System.Windows.Forms.TextBox
    Friend WithEvents SystemName As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lp_applyissuer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lp_issuer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents be_issueArea As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
End Class
