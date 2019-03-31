<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssessReport
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写 Dispose，以清理组件列表。
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lb = New DevExpress.XtraEditors.LabelControl()
        Me.txtJob = New DevExpress.XtraEditors.LookUpEdit()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtJob.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.lb)
        Me.GroupControl1.Controls.Add(Me.txtJob)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(507, 61)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "個人考核報表預覽"
        '
        'lb
        '
        Me.lb.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lb.Location = New System.Drawing.Point(10, 36)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(60, 14)
        Me.lb.TabIndex = 14
        Me.lb.Text = "查看對象："
        '
        'txtJob
        '
        Me.txtJob.Location = New System.Drawing.Point(75, 33)
        Me.txtJob.Name = "txtJob"
        Me.txtJob.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJob.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("pName", "姓名"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("employeeID", "職位編號")})
        Me.txtJob.Properties.NullText = ""
        Me.txtJob.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtJob.Size = New System.Drawing.Size(129, 20)
        Me.txtJob.TabIndex = 2
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 61)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(507, 347)
        Me.CrystalReportViewer1.TabIndex = 1
        '
        'AssessReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "AssessReport"
        Me.Size = New System.Drawing.Size(507, 408)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtJob.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtJob As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lb As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer

End Class
