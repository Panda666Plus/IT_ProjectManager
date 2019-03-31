<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UploadToFTP
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UploadToFTP))
        Me.InfoControl = New DevExpress.XtraEditors.GroupControl()
        Me.lblLastWrite = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.HideInfo = New DevExpress.XtraEditors.SimpleButton()
        Me.lblFcreateDT = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lblFsize = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lblFname = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lbltooltip = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.lblProName = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.ListBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
        Me.ButtonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
        Me.bt_OK = New DevExpress.XtraEditors.SimpleButton()
        Me.btExit = New DevExpress.XtraEditors.SimpleButton()
        Me.Uploadpro = New DevExpress.XtraEditors.ProgressBarControl()
        CType(Me.InfoControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InfoControl.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Uploadpro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InfoControl
        '
        Me.InfoControl.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoControl.AppearanceCaption.ForeColor = System.Drawing.Color.Blue
        Me.InfoControl.AppearanceCaption.Options.UseFont = True
        Me.InfoControl.AppearanceCaption.Options.UseForeColor = True
        Me.InfoControl.AppearanceCaption.Options.UseTextOptions = True
        Me.InfoControl.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.InfoControl.Controls.Add(Me.lblLastWrite)
        Me.InfoControl.Controls.Add(Me.LabelControl3)
        Me.InfoControl.Controls.Add(Me.HideInfo)
        Me.InfoControl.Controls.Add(Me.lblFcreateDT)
        Me.InfoControl.Controls.Add(Me.LabelControl8)
        Me.InfoControl.Controls.Add(Me.lblFsize)
        Me.InfoControl.Controls.Add(Me.LabelControl4)
        Me.InfoControl.Controls.Add(Me.lblFname)
        Me.InfoControl.Controls.Add(Me.LabelControl1)
        Me.InfoControl.Location = New System.Drawing.Point(9, 274)
        Me.InfoControl.Name = "InfoControl"
        Me.InfoControl.Size = New System.Drawing.Size(573, 21)
        Me.InfoControl.TabIndex = 0
        Me.InfoControl.Text = "文件信息"
        '
        'lblLastWrite
        '
        Me.lblLastWrite.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastWrite.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLastWrite.Location = New System.Drawing.Point(65, 125)
        Me.lblLastWrite.Name = "lblLastWrite"
        Me.lblLastWrite.Size = New System.Drawing.Size(13, 14)
        Me.lblLastWrite.TabIndex = 10
        Me.lblLastWrite.Text = "文"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(6, 125)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "修改日期："
        '
        'HideInfo
        '
        Me.HideInfo.Appearance.Font = New System.Drawing.Font("Webdings", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.HideInfo.Appearance.ForeColor = System.Drawing.Color.Teal
        Me.HideInfo.Appearance.Options.UseFont = True
        Me.HideInfo.Appearance.Options.UseForeColor = True
        Me.HideInfo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.HideInfo.Location = New System.Drawing.Point(549, 1)
        Me.HideInfo.Name = "HideInfo"
        Me.HideInfo.Size = New System.Drawing.Size(23, 20)
        Me.HideInfo.TabIndex = 8
        Me.HideInfo.Text = "6"
        Me.HideInfo.ToolTip = "展開文件信息"
        '
        'lblFcreateDT
        '
        Me.lblFcreateDT.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFcreateDT.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFcreateDT.Location = New System.Drawing.Point(64, 96)
        Me.lblFcreateDT.Name = "lblFcreateDT"
        Me.lblFcreateDT.Size = New System.Drawing.Size(13, 14)
        Me.lblFcreateDT.TabIndex = 7
        Me.lblFcreateDT.Text = "文"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(5, 96)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl8.TabIndex = 6
        Me.LabelControl8.Text = "創建日期："
        '
        'lblFsize
        '
        Me.lblFsize.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFsize.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFsize.Location = New System.Drawing.Point(64, 64)
        Me.lblFsize.Name = "lblFsize"
        Me.lblFsize.Size = New System.Drawing.Size(13, 14)
        Me.lblFsize.TabIndex = 3
        Me.lblFsize.Text = "文"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(5, 64)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl4.TabIndex = 2
        Me.LabelControl4.Text = "文件大小："
        '
        'lblFname
        '
        Me.lblFname.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFname.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFname.Location = New System.Drawing.Point(64, 32)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(13, 14)
        Me.lblFname.TabIndex = 1
        Me.lblFname.Text = "文"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "文件名稱："
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Blue
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl1.Controls.Add(Me.lbltooltip)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.lblProName)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Location = New System.Drawing.Point(9, 9)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(573, 88)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "项目信息"
        '
        'lbltooltip
        '
        Me.lbltooltip.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lbltooltip.Location = New System.Drawing.Point(70, 56)
        Me.lbltooltip.Name = "lbltooltip"
        Me.lbltooltip.Size = New System.Drawing.Size(12, 14)
        Me.lbltooltip.TabIndex = 4
        Me.lbltooltip.Text = "模"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(9, 56)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(52, 14)
        Me.LabelControl12.TabIndex = 3
        Me.LabelControl12.Text = "项目名称:"
        '
        'lblProName
        '
        Me.lblProName.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblProName.Location = New System.Drawing.Point(70, 31)
        Me.lblProName.Name = "lblProName"
        Me.lblProName.Size = New System.Drawing.Size(12, 14)
        Me.lblProName.TabIndex = 2
        Me.lblProName.Text = "模"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(9, 31)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl9.TabIndex = 1
        Me.LabelControl9.Text = "项目名称："
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.ListBoxControl1)
        Me.GroupControl2.Controls.Add(Me.ButtonEdit1)
        Me.GroupControl2.Location = New System.Drawing.Point(9, 102)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(573, 165)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "文档上传"
        '
        'ListBoxControl1
        '
        Me.ListBoxControl1.HorizontalScrollbar = True
        Me.ListBoxControl1.Location = New System.Drawing.Point(9, 61)
        Me.ListBoxControl1.Name = "ListBoxControl1"
        Me.ListBoxControl1.Size = New System.Drawing.Size(557, 95)
        Me.ListBoxControl1.TabIndex = 1
        '
        'ButtonEdit1
        '
        Me.ButtonEdit1.EditValue = "点击此处增加文件"
        Me.ButtonEdit1.Location = New System.Drawing.Point(9, 25)
        Me.ButtonEdit1.Name = "ButtonEdit1"
        Me.ButtonEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.ButtonEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ButtonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.[Default], Global.IT_ProjectManager.My.Resources.Resources.Open, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, Nothing, True, Nothing, False)})
        Me.ButtonEdit1.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ButtonEdit1.Properties.ReadOnly = True
        Me.ButtonEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ButtonEdit1.Size = New System.Drawing.Size(557, 30)
        Me.ButtonEdit1.TabIndex = 0
        '
        'bt_OK
        '
        Me.bt_OK.Location = New System.Drawing.Point(444, 305)
        Me.bt_OK.Name = "bt_OK"
        Me.bt_OK.Size = New System.Drawing.Size(60, 27)
        Me.bt_OK.TabIndex = 3
        Me.bt_OK.Text = "确认"
        '
        'btExit
        '
        Me.btExit.Location = New System.Drawing.Point(517, 305)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(60, 27)
        Me.btExit.TabIndex = 4
        Me.btExit.Text = "关闭"
        '
        'Uploadpro
        '
        Me.Uploadpro.Location = New System.Drawing.Point(13, 310)
        Me.Uploadpro.Name = "Uploadpro"
        Me.Uploadpro.Properties.ShowTitle = True
        Me.Uploadpro.Properties.Step = 1
        Me.Uploadpro.Size = New System.Drawing.Size(427, 18)
        Me.Uploadpro.TabIndex = 5
        '
        'UploadToFTP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 339)
        Me.Controls.Add(Me.Uploadpro)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.bt_OK)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.InfoControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UploadToFTP"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "文档管理【文档上传】"
        CType(Me.InfoControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InfoControl.ResumeLayout(False)
        Me.InfoControl.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Uploadpro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InfoControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblFcreateDT As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFsize As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFname As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents HideInfo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblProName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ButtonEdit1 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents lbltooltip As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ListBoxControl1 As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents lblLastWrite As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bt_OK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Uploadpro As DevExpress.XtraEditors.ProgressBarControl
End Class
