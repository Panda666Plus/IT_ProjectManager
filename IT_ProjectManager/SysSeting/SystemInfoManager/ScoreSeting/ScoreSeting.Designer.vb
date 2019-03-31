<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScoreSeting
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
        Me.components = New System.ComponentModel.Container()
        Me.TlScore = New DevExpress.XtraTreeList.TreeList()
        Me.GS_Name = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.GS_Remark = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddPro = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddItems = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Edit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Del = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtRemark = New DevExpress.XtraEditors.MemoEdit()
        Me.txtGSName = New DevExpress.XtraEditors.TextEdit()
        Me.tbSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.TlScore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel.SuspendLayout()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGSName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TlScore
        '
        Me.TlScore.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.GS_Name, Me.GS_Remark})
        Me.TlScore.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TlScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlScore.KeyFieldName = "GS_ID"
        Me.TlScore.Location = New System.Drawing.Point(0, 172)
        Me.TlScore.Name = "TlScore"
        Me.TlScore.OptionsView.AutoWidth = False
        Me.TlScore.OptionsView.ShowIndicator = False
        Me.TlScore.ParentFieldName = "GS_PID"
        Me.TlScore.Size = New System.Drawing.Size(433, 318)
        Me.TlScore.TabIndex = 0
        '
        'GS_Name
        '
        Me.GS_Name.AppearanceCell.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GS_Name.AppearanceCell.Options.UseFont = True
        Me.GS_Name.AppearanceHeader.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GS_Name.AppearanceHeader.Options.UseFont = True
        Me.GS_Name.AppearanceHeader.Options.UseTextOptions = True
        Me.GS_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GS_Name.Caption = "標準名稱"
        Me.GS_Name.FieldName = "GS_Name"
        Me.GS_Name.Name = "GS_Name"
        Me.GS_Name.OptionsColumn.AllowEdit = False
        Me.GS_Name.OptionsColumn.AllowFocus = False
        Me.GS_Name.OptionsColumn.FixedWidth = True
        Me.GS_Name.OptionsColumn.ReadOnly = True
        Me.GS_Name.Visible = True
        Me.GS_Name.VisibleIndex = 0
        Me.GS_Name.Width = 192
        '
        'GS_Remark
        '
        Me.GS_Remark.AppearanceCell.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GS_Remark.AppearanceCell.Options.UseFont = True
        Me.GS_Remark.AppearanceHeader.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GS_Remark.AppearanceHeader.Options.UseFont = True
        Me.GS_Remark.AppearanceHeader.Options.UseTextOptions = True
        Me.GS_Remark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GS_Remark.Caption = "標準備註"
        Me.GS_Remark.FieldName = "GS_Remark"
        Me.GS_Remark.Name = "GS_Remark"
        Me.GS_Remark.OptionsColumn.AllowEdit = False
        Me.GS_Remark.OptionsColumn.AllowFocus = False
        Me.GS_Remark.OptionsColumn.FixedWidth = True
        Me.GS_Remark.OptionsColumn.ReadOnly = True
        Me.GS_Remark.Visible = True
        Me.GS_Remark.VisibleIndex = 1
        Me.GS_Remark.Width = 352
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AddPro, Me.ToolStripMenuItem2, Me.AddItems, Me.ToolStripMenuItem3, Me.Edit, Me.ToolStripMenuItem4, Me.Del, Me.ToolStripMenuItem5})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(137, 122)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(133, 6)
        '
        'AddPro
        '
        Me.AddPro.Image = Global.IT_ProjectManager.My.Resources.Resources.OutlineExpand
        Me.AddPro.Name = "AddPro"
        Me.AddPro.Size = New System.Drawing.Size(136, 22)
        Me.AddPro.Text = "增加項目"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(133, 6)
        '
        'AddItems
        '
        Me.AddItems.Image = Global.IT_ProjectManager.My.Resources.Resources.QueryAppend
        Me.AddItems.Name = "AddItems"
        Me.AddItems.Size = New System.Drawing.Size(136, 22)
        Me.AddItems.Text = "增加子項目"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(133, 6)
        '
        'Edit
        '
        Me.Edit.Image = Global.IT_ProjectManager.My.Resources.Resources.Repeat
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(136, 22)
        Me.Edit.Text = "修改"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(133, 6)
        '
        'Del
        '
        Me.Del.Image = Global.IT_ProjectManager.My.Resources.Resources.OutlineCollapse
        Me.Del.Name = "Del"
        Me.Del.Size = New System.Drawing.Size(136, 22)
        Me.Del.Text = "刪除"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(133, 6)
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.LabelControl3)
        Me.Panel.Controls.Add(Me.SimpleButton1)
        Me.Panel.Controls.Add(Me.txtRemark)
        Me.Panel.Controls.Add(Me.txtGSName)
        Me.Panel.Controls.Add(Me.tbSave)
        Me.Panel.Controls.Add(Me.LabelControl2)
        Me.Panel.Controls.Add(Me.LabelControl1)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel.Enabled = False
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(433, 172)
        Me.Panel.TabIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestDeny
        Me.SimpleButton1.Location = New System.Drawing.Point(358, 134)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(63, 28)
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "取消"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(70, 45)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Properties.MaxLength = 240
        Me.txtRemark.Size = New System.Drawing.Size(351, 80)
        Me.txtRemark.TabIndex = 5
        '
        'txtGSName
        '
        Me.txtGSName.Location = New System.Drawing.Point(70, 10)
        Me.txtGSName.Name = "txtGSName"
        Me.txtGSName.Properties.MaxLength = 99
        Me.txtGSName.Size = New System.Drawing.Size(351, 20)
        Me.txtGSName.TabIndex = 4
        '
        'tbSave
        '
        Me.tbSave.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestAllow
        Me.tbSave.Location = New System.Drawing.Point(271, 134)
        Me.tbSave.Name = "tbSave"
        Me.tbSave.Size = New System.Drawing.Size(63, 28)
        Me.tbSave.TabIndex = 2
        Me.tbSave.Text = "確認"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(8, 43)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "標準備註："
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(8, 13)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "標準名稱："
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl3.Location = New System.Drawing.Point(21, 140)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(78, 17)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "注：右鍵管理"
        '
        'ScoreSeting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 490)
        Me.Controls.Add(Me.TlScore)
        Me.Controls.Add(Me.Panel)
        Me.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScoreSeting"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.TlScore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGSName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TlScore As DevExpress.XtraTreeList.TreeList
    Friend WithEvents Panel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tbSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtGSName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GS_Name As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents GS_Remark As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddPro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddItems As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Edit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Del As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
