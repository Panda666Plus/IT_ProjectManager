<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SystemList
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
        Me.txtSysName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txxy = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUseDepartments = New DevExpress.XtraEditors.TextEdit()
        Me.meUseRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.SatartDT = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LEResponsibilityName = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.meSystemRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.btSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btClose = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btAdds = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUseCompany = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.LUCompany = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblnum = New DevExpress.XtraEditors.LabelControl()
        Me.LEFollowManName = New DevExpress.XtraEditors.LookUpEdit()
        Me.LECompetenceName = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.txtSysName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUseDepartments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meUseRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SatartDT.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SatartDT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LEResponsibilityName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meSystemRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtUseCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LUCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LEFollowManName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LECompetenceName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSysName
        '
        Me.txtSysName.Location = New System.Drawing.Point(75, 20)
        Me.txtSysName.Name = "txtSysName"
        Me.txtSysName.Properties.MaxLength = 50
        Me.txtSysName.Size = New System.Drawing.Size(490, 20)
        Me.txtSysName.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl1.Location = New System.Drawing.Point(6, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(6, 16)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "*"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(14, 23)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "系統名稱："
        '
        'txxy
        '
        Me.txxy.Location = New System.Drawing.Point(14, 57)
        Me.txxy.Name = "txxy"
        Me.txxy.Size = New System.Drawing.Size(60, 14)
        Me.txxy.TabIndex = 14
        Me.txxy.Text = "適用公司："
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Location = New System.Drawing.Point(6, 56)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(6, 16)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "*"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(208, 57)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl4.TabIndex = 16
        Me.LabelControl4.Text = "使用部門："
        '
        'txtUseDepartments
        '
        Me.txtUseDepartments.Location = New System.Drawing.Point(270, 54)
        Me.txtUseDepartments.Name = "txtUseDepartments"
        Me.txtUseDepartments.Properties.MaxLength = 100
        Me.txtUseDepartments.Size = New System.Drawing.Size(107, 20)
        Me.txtUseDepartments.TabIndex = 2
        '
        'meUseRemarks
        '
        Me.meUseRemarks.Location = New System.Drawing.Point(75, 171)
        Me.meUseRemarks.Name = "meUseRemarks"
        Me.meUseRemarks.Properties.MaxLength = 500
        Me.meUseRemarks.Size = New System.Drawing.Size(490, 112)
        Me.meUseRemarks.TabIndex = 8
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(14, 171)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl5.TabIndex = 22
        Me.LabelControl5.Text = "用      途："
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(395, 57)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl6.TabIndex = 16
        Me.LabelControl6.Text = "推行日期："
        '
        'SatartDT
        '
        Me.SatartDT.EditValue = Nothing
        Me.SatartDT.Location = New System.Drawing.Point(458, 54)
        Me.SatartDT.Name = "SatartDT"
        Me.SatartDT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SatartDT.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SatartDT.Size = New System.Drawing.Size(107, 20)
        Me.SatartDT.TabIndex = 3
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(14, 95)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl7.TabIndex = 17
        Me.LabelControl7.Text = "跟 進 人 ："
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(208, 95)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl8.TabIndex = 18
        Me.LabelControl8.Text = "負 責 人 ："
        '
        'LEResponsibilityName
        '
        Me.LEResponsibilityName.Location = New System.Drawing.Point(270, 92)
        Me.LEResponsibilityName.Name = "LEResponsibilityName"
        Me.LEResponsibilityName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LEResponsibilityName.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "姓名")})
        Me.LEResponsibilityName.Properties.DisplayMember = "UserName"
        Me.LEResponsibilityName.Properties.NullText = ""
        Me.LEResponsibilityName.Properties.ValueMember = "UserNo"
        Me.LEResponsibilityName.Size = New System.Drawing.Size(100, 20)
        Me.LEResponsibilityName.TabIndex = 5
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(395, 95)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl9.TabIndex = 19
        Me.LabelControl9.Text = "權限管理："
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(14, 295)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(56, 14)
        Me.LabelControl10.TabIndex = 23
        Me.LabelControl10.Text = "備     注："
        '
        'meSystemRemarks
        '
        Me.meSystemRemarks.Location = New System.Drawing.Point(75, 295)
        Me.meSystemRemarks.Name = "meSystemRemarks"
        Me.meSystemRemarks.Properties.MaxLength = 500
        Me.meSystemRemarks.Size = New System.Drawing.Size(490, 112)
        Me.meSystemRemarks.TabIndex = 9
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl13.Location = New System.Drawing.Point(387, 56)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(6, 16)
        Me.LabelControl13.TabIndex = 23
        Me.LabelControl13.Text = "*"
        '
        'btSave
        '
        Me.btSave.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestAllow
        Me.btSave.Location = New System.Drawing.Point(310, 7)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(75, 27)
        Me.btSave.TabIndex = 11
        Me.btSave.Text = "保存"
        '
        'btClose
        '
        Me.btClose.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestDeny
        Me.btClose.Location = New System.Drawing.Point(405, 7)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(75, 27)
        Me.btClose.TabIndex = 12
        Me.btClose.Text = "關閉"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btAdds)
        Me.PanelControl1.Controls.Add(Me.btClose)
        Me.PanelControl1.Controls.Add(Me.btSave)
        Me.PanelControl1.Location = New System.Drawing.Point(75, 419)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(491, 41)
        Me.PanelControl1.TabIndex = 26
        '
        'btAdds
        '
        Me.btAdds.Image = Global.IT_ProjectManager.My.Resources.Resources.QueryAppend
        Me.btAdds.Location = New System.Drawing.Point(7, 7)
        Me.btAdds.Name = "btAdds"
        Me.btAdds.Size = New System.Drawing.Size(75, 27)
        Me.btAdds.TabIndex = 10
        Me.btAdds.Text = "保存繼續"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl14.Location = New System.Drawing.Point(198, 94)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(6, 16)
        Me.LabelControl14.TabIndex = 27
        Me.LabelControl14.Text = "*"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl15.Location = New System.Drawing.Point(387, 94)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(6, 16)
        Me.LabelControl15.TabIndex = 28
        Me.LabelControl15.Text = "*"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl16.Location = New System.Drawing.Point(199, 56)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(6, 16)
        Me.LabelControl16.TabIndex = 29
        Me.LabelControl16.Text = "*"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl17.Location = New System.Drawing.Point(6, 94)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(6, 16)
        Me.LabelControl17.TabIndex = 30
        Me.LabelControl17.Text = "*"
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl18.Location = New System.Drawing.Point(6, 135)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(6, 16)
        Me.LabelControl18.TabIndex = 33
        Me.LabelControl18.Text = "*"
        '
        'txtUseCompany
        '
        Me.txtUseCompany.Location = New System.Drawing.Point(74, 133)
        Me.txtUseCompany.Name = "txtUseCompany"
        Me.txtUseCompany.Properties.MaxLength = 100
        Me.txtUseCompany.Size = New System.Drawing.Size(491, 20)
        Me.txtUseCompany.TabIndex = 7
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(14, 136)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl19.TabIndex = 20
        Me.LabelControl19.Text = "適用範圍："
        '
        'LUCompany
        '
        Me.LUCompany.Location = New System.Drawing.Point(75, 54)
        Me.LUCompany.Name = "LUCompany"
        Me.LUCompany.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LUCompany.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "公司名稱")})
        Me.LUCompany.Properties.MaxLength = 10
        Me.LUCompany.Properties.NullText = ""
        Me.LUCompany.Size = New System.Drawing.Size(57, 20)
        Me.LUCompany.TabIndex = 1
        '
        'lblnum
        '
        Me.lblnum.Appearance.ForeColor = System.Drawing.Color.Green
        Me.lblnum.Location = New System.Drawing.Point(137, 57)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(14, 14)
        Me.lblnum.TabIndex = 34
        Me.lblnum.Text = "11"
        '
        'LEFollowManName
        '
        Me.LEFollowManName.Location = New System.Drawing.Point(75, 92)
        Me.LEFollowManName.Name = "LEFollowManName"
        Me.LEFollowManName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LEFollowManName.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "姓名")})
        Me.LEFollowManName.Properties.DisplayMember = "UserName"
        Me.LEFollowManName.Properties.NullText = ""
        Me.LEFollowManName.Properties.ValueMember = "UserNo"
        Me.LEFollowManName.Size = New System.Drawing.Size(100, 20)
        Me.LEFollowManName.TabIndex = 35
        '
        'LECompetenceName
        '
        Me.LECompetenceName.Location = New System.Drawing.Point(458, 92)
        Me.LECompetenceName.Name = "LECompetenceName"
        Me.LECompetenceName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LECompetenceName.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "姓名")})
        Me.LECompetenceName.Properties.DisplayMember = "UserName"
        Me.LECompetenceName.Properties.NullText = ""
        Me.LECompetenceName.Properties.ValueMember = "UserNo"
        Me.LECompetenceName.Size = New System.Drawing.Size(108, 20)
        Me.LECompetenceName.TabIndex = 36
        '
        'SystemList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 468)
        Me.Controls.Add(Me.LECompetenceName)
        Me.Controls.Add(Me.LEFollowManName)
        Me.Controls.Add(Me.lblnum)
        Me.Controls.Add(Me.LabelControl18)
        Me.Controls.Add(Me.txtUseCompany)
        Me.Controls.Add(Me.LabelControl19)
        Me.Controls.Add(Me.LabelControl17)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.meSystemRemarks)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LEResponsibilityName)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.SatartDT)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.meUseRemarks)
        Me.Controls.Add(Me.txtUseDepartments)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txxy)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtSysName)
        Me.Controls.Add(Me.LUCompany)
        Me.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SystemList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "系統名稱維護[數據錄入]"
        CType(Me.txtSysName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUseDepartments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meUseRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SatartDT.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SatartDT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LEResponsibilityName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meSystemRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.txtUseCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LUCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LEFollowManName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LECompetenceName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSysName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txxy As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUseDepartments As DevExpress.XtraEditors.TextEdit
    Friend WithEvents meUseRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SatartDT As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LEResponsibilityName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents meSystemRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btAdds As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUseCompany As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LUCompany As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblnum As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LEFollowManName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LECompetenceName As DevExpress.XtraEditors.LookUpEdit
End Class
