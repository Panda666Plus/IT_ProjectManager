<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultsConfirm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResultsConfirm))
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtSpandTime = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.METreatment = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.btSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btClose = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtSpandTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.METreatment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Blue
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.txtSpandTime)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Controls.Add(Me.METreatment)
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.Location = New System.Drawing.Point(4, 8)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(515, 337)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "Bug修復確認"
        '
        'txtSpandTime
        '
        Me.txtSpandTime.Location = New System.Drawing.Point(66, 29)
        Me.txtSpandTime.Name = "txtSpandTime"
        Me.txtSpandTime.Properties.MaxLength = 50
        Me.txtSpandTime.Size = New System.Drawing.Size(442, 20)
        Me.txtSpandTime.TabIndex = 22
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(4, 32)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl10.TabIndex = 21
        Me.LabelControl10.Text = "驗收結果："
        '
        'METreatment
        '
        Me.METreatment.Location = New System.Drawing.Point(66, 59)
        Me.METreatment.Name = "METreatment"
        Me.METreatment.Properties.MaxLength = 500
        Me.METreatment.Size = New System.Drawing.Size(442, 273)
        Me.METreatment.TabIndex = 20
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(4, 59)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl9.TabIndex = 19
        Me.LabelControl9.Text = "備      註："
        '
        'btSave
        '
        Me.btSave.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestAllow
        Me.btSave.Location = New System.Drawing.Point(353, 356)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(68, 28)
        Me.btSave.TabIndex = 5
        Me.btSave.Text = "確認"
        '
        'btClose
        '
        Me.btClose.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestDeny
        Me.btClose.Location = New System.Drawing.Point(444, 356)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(68, 28)
        Me.btClose.TabIndex = 6
        Me.btClose.Text = "關閉"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(7, 356)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(87, 28)
        Me.SimpleButton1.TabIndex = 23
        Me.SimpleButton1.Text = "反饋信息"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(126, 356)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(87, 28)
        Me.SimpleButton2.TabIndex = 24
        Me.SimpleButton2.Text = "回覆信息"
        '
        'ResultsConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 395)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.GroupControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ResultsConfirm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bug修復結果驗收 "
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtSpandTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.METreatment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtSpandTime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents METreatment As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
