<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LeaderAssess
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
        Me.LeaderCommentAssess = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.AssessMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.tb_Close = New DevExpress.XtraEditors.SimpleButton()
        Me.tb_ok = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.cboAssGrade = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.AssessMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAssGrade.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LeaderCommentAssess
        '
        Me.LeaderCommentAssess.Location = New System.Drawing.Point(7, 7)
        Me.LeaderCommentAssess.Name = "LeaderCommentAssess"
        Me.LeaderCommentAssess.Size = New System.Drawing.Size(469, 314)
        Me.LeaderCommentAssess.TabIndex = 0
        '
        'AssessMemoEdit
        '
        Me.AssessMemoEdit.EditValue = ""
        Me.AssessMemoEdit.Location = New System.Drawing.Point(7, 348)
        Me.AssessMemoEdit.Name = "AssessMemoEdit"
        Me.AssessMemoEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssessMemoEdit.Properties.Appearance.Options.UseFont = True
        Me.AssessMemoEdit.Properties.MaxLength = 500
        Me.AssessMemoEdit.Size = New System.Drawing.Size(469, 101)
        Me.AssessMemoEdit.TabIndex = 1
        '
        'tb_Close
        '
        Me.tb_Close.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestDeny
        Me.tb_Close.Location = New System.Drawing.Point(411, 459)
        Me.tb_Close.Name = "tb_Close"
        Me.tb_Close.Size = New System.Drawing.Size(61, 28)
        Me.tb_Close.TabIndex = 2
        Me.tb_Close.Text = "关闭"
        '
        'tb_ok
        '
        Me.tb_ok.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ok.Appearance.Options.UseFont = True
        Me.tb_ok.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestAllow
        Me.tb_ok.Location = New System.Drawing.Point(327, 459)
        Me.tb_ok.Name = "tb_ok"
        Me.tb_ok.Size = New System.Drawing.Size(61, 28)
        Me.tb_ok.TabIndex = 3
        Me.tb_ok.Text = "确认"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl16.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl16.Location = New System.Drawing.Point(146, 467)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(6, 17)
        Me.LabelControl16.TabIndex = 61
        Me.LabelControl16.Text = "*"
        Me.LabelControl16.Visible = False
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(158, 467)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(39, 17)
        Me.LabelControl7.TabIndex = 60
        Me.LabelControl7.Text = "评分："
        Me.LabelControl7.Visible = False
        '
        'cboAssGrade
        '
        Me.cboAssGrade.EditValue = "3"
        Me.cboAssGrade.Location = New System.Drawing.Point(194, 463)
        Me.cboAssGrade.Name = "cboAssGrade"
        Me.cboAssGrade.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAssGrade.Properties.Appearance.Options.UseFont = True
        Me.cboAssGrade.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cboAssGrade.Properties.AppearanceDisabled.Options.UseFont = True
        Me.cboAssGrade.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAssGrade.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cboAssGrade.Properties.AppearanceFocused.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAssGrade.Properties.AppearanceFocused.Options.UseFont = True
        Me.cboAssGrade.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAssGrade.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.cboAssGrade.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAssGrade.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProStatus", "ProStatus", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Explain", "Explain")})
        Me.cboAssGrade.Properties.DisplayMember = "Explain"
        Me.cboAssGrade.Properties.NullText = ""
        Me.cboAssGrade.Properties.ShowFooter = False
        Me.cboAssGrade.Properties.ShowHeader = False
        Me.cboAssGrade.Properties.ShowLines = False
        Me.cboAssGrade.Properties.ShowPopupShadow = False
        Me.cboAssGrade.Properties.ValueMember = "ProStatus"
        Me.cboAssGrade.Size = New System.Drawing.Size(40, 24)
        Me.cboAssGrade.TabIndex = 59
        Me.cboAssGrade.Visible = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(130, 466)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(9, 19)
        Me.LabelControl9.TabIndex = 58
        Me.LabelControl9.Text = "0"
        Me.LabelControl9.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(117, 468)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(7, 14)
        Me.LabelControl1.TabIndex = 57
        Me.LabelControl1.Text = "3"
        Me.LabelControl1.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(9, 328)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(65, 17)
        Me.LabelControl2.TabIndex = 62
        Me.LabelControl2.Text = "考核评语："
        '
        'LeaderAssess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 493)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.cboAssGrade)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.tb_ok)
        Me.Controls.Add(Me.tb_Close)
        Me.Controls.Add(Me.AssessMemoEdit)
        Me.Controls.Add(Me.LeaderCommentAssess)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LeaderAssess"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "项目组长考评"
        CType(Me.AssessMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAssGrade.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LeaderCommentAssess As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents AssessMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents tb_Close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tb_ok As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboAssGrade As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
