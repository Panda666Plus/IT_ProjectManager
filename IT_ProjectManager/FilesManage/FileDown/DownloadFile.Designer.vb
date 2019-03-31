<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DownloadFile
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lblFTPPaht = New DevExpress.XtraEditors.LabelControl()
        Me.lblFTPFilesName = New DevExpress.XtraEditors.LabelControl()
        Me.lblFilesSize = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lblResult = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.DownPro = New DevExpress.XtraEditors.ProgressBarControl()
        CType(Me.DownPro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(10, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(57, 14)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "FTP路径："
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(10, 46)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "文件名称："
        '
        'lblFTPPaht
        '
        Me.lblFTPPaht.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblFTPPaht.Location = New System.Drawing.Point(72, 15)
        Me.lblFTPPaht.Name = "lblFTPPaht"
        Me.lblFTPPaht.Size = New System.Drawing.Size(2, 14)
        Me.lblFTPPaht.TabIndex = 2
        Me.lblFTPPaht.Text = "l"
        '
        'lblFTPFilesName
        '
        Me.lblFTPFilesName.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblFTPFilesName.Location = New System.Drawing.Point(72, 46)
        Me.lblFTPFilesName.Name = "lblFTPFilesName"
        Me.lblFTPFilesName.Size = New System.Drawing.Size(2, 14)
        Me.lblFTPFilesName.TabIndex = 3
        Me.lblFTPFilesName.Text = "l"
        '
        'lblFilesSize
        '
        Me.lblFilesSize.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblFilesSize.Location = New System.Drawing.Point(72, 79)
        Me.lblFilesSize.Name = "lblFilesSize"
        Me.lblFilesSize.Size = New System.Drawing.Size(2, 14)
        Me.lblFilesSize.TabIndex = 5
        Me.lblFilesSize.Text = "l"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(10, 79)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "文件大小："
        '
        'lblResult
        '
        Me.lblResult.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblResult.Location = New System.Drawing.Point(72, 113)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(2, 14)
        Me.lblResult.TabIndex = 7
        Me.lblResult.Text = "l"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(10, 113)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl6.TabIndex = 6
        Me.LabelControl6.Text = "下载状态："
        '
        'DownPro
        '
        Me.DownPro.Location = New System.Drawing.Point(10, 143)
        Me.DownPro.Name = "DownPro"
        Me.DownPro.Properties.ShowTitle = True
        Me.DownPro.Properties.Step = 1
        Me.DownPro.Size = New System.Drawing.Size(578, 24)
        Me.DownPro.TabIndex = 8
        '
        'DownloadFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 175)
        Me.Controls.Add(Me.DownPro)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.lblFilesSize)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.lblFTPFilesName)
        Me.Controls.Add(Me.lblFTPPaht)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DownloadFile"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "项目文档下载"
        CType(Me.DownPro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFTPPaht As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFTPFilesName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFilesSize As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblResult As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DownPro As DevExpress.XtraEditors.ProgressBarControl
End Class
