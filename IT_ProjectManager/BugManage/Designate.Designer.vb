<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Designate
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
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtImpactRemarks = New DevExpress.XtraEditors.TextEdit()
        Me.chIsAffect = New DevExpress.XtraEditors.CheckEdit()
        Me.txtSpandTime = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.METreatment = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LBCuploadList = New DevExpress.XtraEditors.ListBoxControl()
        Me.ToolTip = New DevExpress.XtraEditors.LabelControl()
        Me.btSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btClose = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtImpactRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chIsAffect.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSpandTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.METreatment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBCuploadList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Blue
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.txtImpactRemarks)
        Me.GroupControl2.Controls.Add(Me.chIsAffect)
        Me.GroupControl2.Controls.Add(Me.txtSpandTime)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Controls.Add(Me.METreatment)
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.Controls.Add(Me.LBCuploadList)
        Me.GroupControl2.Controls.Add(Me.ToolTip)
        Me.GroupControl2.Location = New System.Drawing.Point(6, 6)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(515, 356)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Bug原因回覆"
        '
        'txtImpactRemarks
        '
        Me.txtImpactRemarks.Location = New System.Drawing.Point(247, 139)
        Me.txtImpactRemarks.Name = "txtImpactRemarks"
        Me.txtImpactRemarks.Properties.MaxLength = 100
        Me.txtImpactRemarks.Size = New System.Drawing.Size(261, 20)
        Me.txtImpactRemarks.TabIndex = 24
        Me.txtImpactRemarks.Visible = False
        '
        'chIsAffect
        '
        Me.chIsAffect.Location = New System.Drawing.Point(174, 140)
        Me.chIsAffect.Name = "chIsAffect"
        Me.chIsAffect.Properties.Caption = "影响模块"
        Me.chIsAffect.Size = New System.Drawing.Size(72, 19)
        Me.chIsAffect.TabIndex = 23
        '
        'txtSpandTime
        '
        Me.txtSpandTime.Location = New System.Drawing.Point(76, 139)
        Me.txtSpandTime.Name = "txtSpandTime"
        Me.txtSpandTime.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSpandTime.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtSpandTime.Properties.MaxLength = 3
        Me.txtSpandTime.Size = New System.Drawing.Size(89, 20)
        Me.txtSpandTime.TabIndex = 22
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(7, 142)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl10.TabIndex = 21
        Me.LabelControl10.Text = "完成时数："
        '
        'METreatment
        '
        Me.METreatment.Location = New System.Drawing.Point(76, 172)
        Me.METreatment.Name = "METreatment"
        Me.METreatment.Properties.MaxLength = 500
        Me.METreatment.Size = New System.Drawing.Size(431, 176)
        Me.METreatment.TabIndex = 20
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(7, 172)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl9.TabIndex = 19
        Me.LabelControl9.Text = "处理方式："
        '
        'LBCuploadList
        '
        Me.LBCuploadList.Location = New System.Drawing.Point(76, 30)
        Me.LBCuploadList.Name = "LBCuploadList"
        Me.LBCuploadList.Size = New System.Drawing.Size(428, 99)
        Me.LBCuploadList.TabIndex = 25
        '
        'ToolTip
        '
        Me.ToolTip.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.ToolTip.Location = New System.Drawing.Point(1, 32)
        Me.ToolTip.Name = "ToolTip"
        Me.ToolTip.Size = New System.Drawing.Size(72, 14)
        Me.ToolTip.TabIndex = 26
        Me.ToolTip.Text = "双击预览附件"
        '
        'btSave
        '
        Me.btSave.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestAllow
        Me.btSave.Location = New System.Drawing.Point(354, 369)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(66, 27)
        Me.btSave.TabIndex = 27
        Me.btSave.Text = "确认"
        '
        'btClose
        '
        Me.btClose.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestDeny
        Me.btClose.Location = New System.Drawing.Point(451, 369)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(66, 27)
        Me.btClose.TabIndex = 28
        Me.btClose.Text = "关闭"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = Global.IT_ProjectManager.My.Resources.Resources.Flag_blueHS
        Me.SimpleButton1.Location = New System.Drawing.Point(6, 368)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(87, 28)
        Me.SimpleButton1.TabIndex = 29
        Me.SimpleButton1.Text = "反馈信息"
        '
        'Designate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 404)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.GroupControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Designate"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bug原因回覆"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtImpactRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chIsAffect.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSpandTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.METreatment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBCuploadList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtImpactRemarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chIsAffect As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtSpandTime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents METreatment As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LBCuploadList As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents ToolTip As DevExpress.XtraEditors.LabelControl
End Class
