<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogo))
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtPsw = New DevExpress.XtraEditors.TextEdit()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        Me.ckRememberPwd = New DevExpress.XtraEditors.CheckEdit()
        Me.AssDataSet1 = New IT_ProjectManager.AssDataSet()
        CType(Me.txtPsw.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckRememberPwd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(105, 76)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(73, 28)
        Me.cmdSave.TabIndex = 16
        Me.cmdSave.Text = "登入"
        '
        'txtPsw
        '
        Me.txtPsw.EditValue = ""
        Me.txtPsw.Location = New System.Drawing.Point(58, 33)
        Me.txtPsw.Name = "txtPsw"
        Me.txtPsw.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPsw.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtPsw.Properties.Appearance.Options.UseFont = True
        Me.txtPsw.Properties.Appearance.Options.UseForeColor = True
        Me.txtPsw.Properties.MaxLength = 50
        Me.txtPsw.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPsw.Size = New System.Drawing.Size(200, 24)
        Me.txtPsw.TabIndex = 13
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Location = New System.Drawing.Point(196, 76)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(73, 28)
        Me.cmdExit.TabIndex = 17
        Me.cmdExit.Text = "退出"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txtPsw)
        Me.PanelControl1.Controls.Add(Me.txtID)
        Me.PanelControl1.Location = New System.Drawing.Point(5, 6)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(266, 64)
        Me.PanelControl1.TabIndex = 23
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Location = New System.Drawing.Point(3, 37)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(6, 17)
        Me.LabelControl3.TabIndex = 53
        Me.LabelControl3.Text = "*"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 37)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(39, 17)
        Me.LabelControl1.TabIndex = 52
        Me.LabelControl1.Text = "密码："
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl8.Location = New System.Drawing.Point(2, 7)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(6, 17)
        Me.LabelControl8.TabIndex = 51
        Me.LabelControl8.Text = "*"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(12, 7)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 17)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "帐号："
        '
        'txtID
        '
        Me.txtID.EditValue = ""
        Me.txtID.Location = New System.Drawing.Point(58, 3)
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtID.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtID.Properties.Appearance.Options.UseFont = True
        Me.txtID.Properties.Appearance.Options.UseForeColor = True
        Me.txtID.Properties.MaxLength = 50
        Me.txtID.Size = New System.Drawing.Size(200, 24)
        Me.txtID.TabIndex = 0
        '
        'ckRememberPwd
        '
        Me.ckRememberPwd.Location = New System.Drawing.Point(5, 80)
        Me.ckRememberPwd.Name = "ckRememberPwd"
        Me.ckRememberPwd.Properties.Caption = "记住密码"
        Me.ckRememberPwd.Size = New System.Drawing.Size(78, 19)
        Me.ckRememberPwd.TabIndex = 24
        '
        'AssDataSet1
        '
        Me.AssDataSet1.DataSetName = "AssDataSet"
        Me.AssDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmLogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 109)
        Me.Controls.Add(Me.ckRememberPwd)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "登入帐号v4.0.0"
        Me.TopMost = True
        CType(Me.txtPsw.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckRememberPwd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPsw As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckRememberPwd As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents AssDataSet1 As IT_ProjectManager.AssDataSet
End Class
