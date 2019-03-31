<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BugFixProgress
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
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.btBugEntry = New DevExpress.XtraEditors.SimpleButton()
        Me.lblTestStandard = New DevExpress.XtraEditors.LabelControl()
        Me.lblBugName = New DevExpress.XtraEditors.LabelControl()
        Me.lblSysProName = New DevExpress.XtraEditors.LabelControl()
        Me.lblEmergency = New DevExpress.XtraEditors.LabelControl()
        Me.lblCategory = New DevExpress.XtraEditors.LabelControl()
        Me.lblTestNum = New DevExpress.XtraEditors.LabelControl()
        Me.lblBugType = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.MEExceptions = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LBCuploadList = New DevExpress.XtraEditors.ListBoxControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lblImpactRemarks = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.lblSpendTime = New DevExpress.XtraEditors.LabelControl()
        Me.btBugDesignate = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.METreatment = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.btResults = New DevExpress.XtraEditors.SimpleButton()
        Me.lblConfirmResults = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.MECloseRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.MEExceptions.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBCuploadList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.METreatment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.MECloseRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl2.Appearance.Options.UseForeColor = True
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Controls.Add(Me.btBugEntry)
        Me.GroupControl2.Controls.Add(Me.lblTestStandard)
        Me.GroupControl2.Controls.Add(Me.lblBugName)
        Me.GroupControl2.Controls.Add(Me.lblSysProName)
        Me.GroupControl2.Controls.Add(Me.lblEmergency)
        Me.GroupControl2.Controls.Add(Me.lblCategory)
        Me.GroupControl2.Controls.Add(Me.lblTestNum)
        Me.GroupControl2.Controls.Add(Me.lblBugType)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.MEExceptions)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.LBCuploadList)
        Me.GroupControl2.Location = New System.Drawing.Point(6, 7)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(551, 347)
        Me.GroupControl2.TabIndex = 40
        Me.GroupControl2.Text = "反馈人：xxx"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(8, 294)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(48, 14)
        Me.LabelControl10.TabIndex = 38
        Me.LabelControl10.Text = "双击预览"
        '
        'btBugEntry
        '
        Me.btBugEntry.Image = Global.IT_ProjectManager.My.Resources.Resources.Repeat
        Me.btBugEntry.Location = New System.Drawing.Point(501, 0)
        Me.btBugEntry.Name = "btBugEntry"
        Me.btBugEntry.Size = New System.Drawing.Size(49, 21)
        Me.btBugEntry.TabIndex = 37
        Me.btBugEntry.Text = "变更"
        Me.btBugEntry.ToolTip = "修改反馈信息"
        Me.btBugEntry.Visible = False
        '
        'lblTestStandard
        '
        Me.lblTestStandard.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblTestStandard.Location = New System.Drawing.Point(68, 88)
        Me.lblTestStandard.Name = "lblTestStandard"
        Me.lblTestStandard.Size = New System.Drawing.Size(57, 14)
        Me.lblTestStandard.TabIndex = 36
        Me.lblTestStandard.Text = "Bug类型："
        '
        'lblBugName
        '
        Me.lblBugName.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblBugName.Location = New System.Drawing.Point(68, 59)
        Me.lblBugName.Name = "lblBugName"
        Me.lblBugName.Size = New System.Drawing.Size(57, 14)
        Me.lblBugName.TabIndex = 35
        Me.lblBugName.Text = "Bug类型："
        '
        'lblSysProName
        '
        Me.lblSysProName.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblSysProName.Location = New System.Drawing.Point(68, 31)
        Me.lblSysProName.Name = "lblSysProName"
        Me.lblSysProName.Size = New System.Drawing.Size(57, 14)
        Me.lblSysProName.TabIndex = 34
        Me.lblSysProName.Text = "Bug类型："
        '
        'lblEmergency
        '
        Me.lblEmergency.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblEmergency.Location = New System.Drawing.Point(68, 149)
        Me.lblEmergency.Name = "lblEmergency"
        Me.lblEmergency.Size = New System.Drawing.Size(57, 14)
        Me.lblEmergency.TabIndex = 33
        Me.lblEmergency.Text = "Bug类型："
        '
        'lblCategory
        '
        Me.lblCategory.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblCategory.Location = New System.Drawing.Point(206, 119)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(57, 14)
        Me.lblCategory.TabIndex = 32
        Me.lblCategory.Text = "Bug类型："
        '
        'lblTestNum
        '
        Me.lblTestNum.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblTestNum.Location = New System.Drawing.Point(68, 119)
        Me.lblTestNum.Name = "lblTestNum"
        Me.lblTestNum.Size = New System.Drawing.Size(57, 14)
        Me.lblTestNum.TabIndex = 31
        Me.lblTestNum.Text = "Bug类型："
        '
        'lblBugType
        '
        Me.lblBugType.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblBugType.Location = New System.Drawing.Point(68, 179)
        Me.lblBugType.Name = "lblBugType"
        Me.lblBugType.Size = New System.Drawing.Size(57, 14)
        Me.lblBugType.TabIndex = 30
        Me.lblBugType.Text = "Bug类型："
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(8, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "系统名称："
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(8, 119)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl5.TabIndex = 9
        Me.LabelControl5.Text = "测试次数："
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(8, 179)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(57, 14)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Bug类型："
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(8, 209)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl7.TabIndex = 13
        Me.LabelControl7.Text = "异常描述："
        '
        'MEExceptions
        '
        Me.MEExceptions.Location = New System.Drawing.Point(68, 209)
        Me.MEExceptions.Name = "MEExceptions"
        Me.MEExceptions.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.MEExceptions.Properties.Appearance.Options.UseForeColor = True
        Me.MEExceptions.Properties.MaxLength = 1000
        Me.MEExceptions.Properties.ReadOnly = True
        Me.MEExceptions.Size = New System.Drawing.Size(477, 58)
        Me.MEExceptions.TabIndex = 14
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(8, 149)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "严重程度："
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(8, 274)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(52, 14)
        Me.LabelControl8.TabIndex = 15
        Me.LabelControl8.Text = "附    件："
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(8, 88)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl9.TabIndex = 23
        Me.LabelControl9.Text = "测试标准："
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(8, 59)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "测试项目："
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(171, 119)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(36, 14)
        Me.LabelControl6.TabIndex = 21
        Me.LabelControl6.Text = "组别："
        '
        'LBCuploadList
        '
        Me.LBCuploadList.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LBCuploadList.Appearance.Options.UseForeColor = True
        Me.LBCuploadList.Location = New System.Drawing.Point(68, 274)
        Me.LBCuploadList.Name = "LBCuploadList"
        Me.LBCuploadList.Size = New System.Drawing.Size(477, 67)
        Me.LBCuploadList.TabIndex = 17
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl1.Appearance.Options.UseForeColor = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.lblImpactRemarks)
        Me.GroupControl1.Controls.Add(Me.LabelControl20)
        Me.GroupControl1.Controls.Add(Me.lblSpendTime)
        Me.GroupControl1.Controls.Add(Me.btBugDesignate)
        Me.GroupControl1.Controls.Add(Me.LabelControl17)
        Me.GroupControl1.Controls.Add(Me.METreatment)
        Me.GroupControl1.Controls.Add(Me.LabelControl18)
        Me.GroupControl1.Location = New System.Drawing.Point(6, 360)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(551, 121)
        Me.GroupControl1.TabIndex = 41
        Me.GroupControl1.Text = "Bug修复人：xxxx"
        '
        'lblImpactRemarks
        '
        Me.lblImpactRemarks.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblImpactRemarks.Location = New System.Drawing.Point(161, 33)
        Me.lblImpactRemarks.Name = "lblImpactRemarks"
        Me.lblImpactRemarks.Size = New System.Drawing.Size(60, 14)
        Me.lblImpactRemarks.TabIndex = 41
        Me.lblImpactRemarks.Text = "影响模块："
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(102, 33)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl20.TabIndex = 40
        Me.LabelControl20.Text = "影响模块："
        '
        'lblSpendTime
        '
        Me.lblSpendTime.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblSpendTime.Location = New System.Drawing.Point(68, 33)
        Me.lblSpendTime.Name = "lblSpendTime"
        Me.lblSpendTime.Size = New System.Drawing.Size(12, 14)
        Me.lblSpendTime.TabIndex = 39
        Me.lblSpendTime.Text = "完"
        '
        'btBugDesignate
        '
        Me.btBugDesignate.Image = Global.IT_ProjectManager.My.Resources.Resources.Repeat
        Me.btBugDesignate.Location = New System.Drawing.Point(501, 1)
        Me.btBugDesignate.Name = "btBugDesignate"
        Me.btBugDesignate.Size = New System.Drawing.Size(49, 20)
        Me.btBugDesignate.TabIndex = 38
        Me.btBugDesignate.Text = "变更"
        Me.btBugDesignate.ToolTip = "修改回覆信息，前提是确认人未确认"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(7, 33)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl17.TabIndex = 21
        Me.LabelControl17.Text = "完成时数："
        '
        'METreatment
        '
        Me.METreatment.Location = New System.Drawing.Point(66, 59)
        Me.METreatment.Name = "METreatment"
        Me.METreatment.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.METreatment.Properties.Appearance.Options.UseForeColor = True
        Me.METreatment.Properties.MaxLength = 500
        Me.METreatment.Properties.ReadOnly = True
        Me.METreatment.Size = New System.Drawing.Size(479, 58)
        Me.METreatment.TabIndex = 20
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(7, 59)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl18.TabIndex = 19
        Me.LabelControl18.Text = "处理方式："
        '
        'GroupControl3
        '
        Me.GroupControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl3.Appearance.Options.UseForeColor = True
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.btResults)
        Me.GroupControl3.Controls.Add(Me.lblConfirmResults)
        Me.GroupControl3.Controls.Add(Me.LabelControl22)
        Me.GroupControl3.Controls.Add(Me.MECloseRemarks)
        Me.GroupControl3.Controls.Add(Me.LabelControl23)
        Me.GroupControl3.Location = New System.Drawing.Point(6, 487)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(551, 116)
        Me.GroupControl3.TabIndex = 42
        Me.GroupControl3.Text = "Bug确认人"
        '
        'btResults
        '
        Me.btResults.Image = Global.IT_ProjectManager.My.Resources.Resources.Repeat
        Me.btResults.Location = New System.Drawing.Point(501, 0)
        Me.btResults.Name = "btResults"
        Me.btResults.Size = New System.Drawing.Size(49, 20)
        Me.btResults.TabIndex = 39
        Me.btResults.Text = "变更"
        Me.btResults.ToolTip = "修改确认信息"
        '
        'lblConfirmResults
        '
        Me.lblConfirmResults.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblConfirmResults.Location = New System.Drawing.Point(63, 32)
        Me.lblConfirmResults.Name = "lblConfirmResults"
        Me.lblConfirmResults.Size = New System.Drawing.Size(12, 14)
        Me.lblConfirmResults.TabIndex = 22
        Me.lblConfirmResults.Text = "确"
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(4, 32)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl22.TabIndex = 21
        Me.LabelControl22.Text = "验收结果："
        '
        'MECloseRemarks
        '
        Me.MECloseRemarks.Location = New System.Drawing.Point(61, 55)
        Me.MECloseRemarks.Name = "MECloseRemarks"
        Me.MECloseRemarks.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.MECloseRemarks.Properties.Appearance.Options.UseForeColor = True
        Me.MECloseRemarks.Properties.MaxLength = 500
        Me.MECloseRemarks.Properties.ReadOnly = True
        Me.MECloseRemarks.Size = New System.Drawing.Size(483, 55)
        Me.MECloseRemarks.TabIndex = 20
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(4, 55)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl23.TabIndex = 19
        Me.LabelControl23.Text = "备      注："
        '
        'BugFixProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(563, 614)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BugFixProgress"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bug处理进度"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.MEExceptions.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBCuploadList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.METreatment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.MECloseRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblTestStandard As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblBugName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSysProName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEmergency As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCategory As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTestNum As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblBugType As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MEExceptions As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LBCuploadList As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents btBugEntry As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblImpactRemarks As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSpendTime As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btBugDesignate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents METreatment As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btResults As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblConfirmResults As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MECloseRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
End Class
