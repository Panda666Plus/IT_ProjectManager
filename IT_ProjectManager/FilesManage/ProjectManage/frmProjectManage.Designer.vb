<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectManage
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
        Me.btExit = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_OK = New DevExpress.XtraEditors.SimpleButton()
        Me.txtPnmae = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txttooltip = New DevExpress.XtraEditors.MemoEdit()
        Me.LUERelevance = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.ProjectList = New DevExpress.XtraEditors.ListBoxControl()
        CType(Me.txtPnmae.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttooltip.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LUERelevance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btExit
        '
        Me.btExit.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestDeny
        Me.btExit.Location = New System.Drawing.Point(396, 262)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(60, 27)
        Me.btExit.TabIndex = 5
        Me.btExit.Text = "关闭"
        '
        'bt_OK
        '
        Me.bt_OK.Image = Global.IT_ProjectManager.My.Resources.Resources.SharingRequestAllow
        Me.bt_OK.Location = New System.Drawing.Point(323, 262)
        Me.bt_OK.Name = "bt_OK"
        Me.bt_OK.Size = New System.Drawing.Size(60, 27)
        Me.bt_OK.TabIndex = 4
        Me.bt_OK.Text = "确认"
        '
        'txtPnmae
        '
        Me.txtPnmae.Location = New System.Drawing.Point(70, 21)
        Me.txtPnmae.Name = "txtPnmae"
        Me.txtPnmae.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtPnmae.Size = New System.Drawing.Size(385, 20)
        Me.txtPnmae.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(8, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "项目名称："
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(8, 177)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "项目备注："
        '
        'txttooltip
        '
        Me.txttooltip.Location = New System.Drawing.Point(70, 177)
        Me.txttooltip.Name = "txttooltip"
        Me.txttooltip.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txttooltip.Size = New System.Drawing.Size(385, 71)
        Me.txttooltip.TabIndex = 3
        '
        'LUERelevance
        '
        Me.LUERelevance.Location = New System.Drawing.Point(70, 55)
        Me.LUERelevance.Name = "LUERelevance"
        Me.LUERelevance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LUERelevance.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SchemeName", "項目名稱", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[False])})
        Me.LUERelevance.Properties.NullText = "在此選擇項目"
        Me.LUERelevance.Size = New System.Drawing.Size(385, 20)
        Me.LUERelevance.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(8, 58)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "关联项目："
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(8, 95)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(52, 14)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "已关联项:"
        '
        'ProjectList
        '
        Me.ProjectList.HorizontalScrollbar = True
        Me.ProjectList.Location = New System.Drawing.Point(70, 95)
        Me.ProjectList.Name = "ProjectList"
        Me.ProjectList.Size = New System.Drawing.Size(385, 67)
        Me.ProjectList.TabIndex = 2
        Me.ProjectList.ToolTip = "双击移除选择项目"
        '
        'frmProjectManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 297)
        Me.Controls.Add(Me.ProjectList)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LUERelevance)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtPnmae)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.bt_OK)
        Me.Controls.Add(Me.txttooltip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmProjectManage"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "项目管理【增加】"
        CType(Me.txtPnmae.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttooltip.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LUERelevance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bt_OK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPnmae As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txttooltip As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LUERelevance As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ProjectList As DevExpress.XtraEditors.ListBoxControl
End Class
