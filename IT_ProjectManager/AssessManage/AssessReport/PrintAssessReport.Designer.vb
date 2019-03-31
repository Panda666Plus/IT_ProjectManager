<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintAssessReport
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.YearMonth = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lb = New DevExpress.XtraEditors.LabelControl()
        Me.txtJob = New DevExpress.XtraEditors.LookUpEdit()
        Me.PrintDocument12 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.AssDataSet1 = New IT_ProjectManager.AssDataSet()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.YearMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJob.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.YearMonth)
        Me.GroupControl1.Controls.Add(Me.lb)
        Me.GroupControl1.Controls.Add(Me.txtJob)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(629, 61)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "个人考核报表预览"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl1.Location = New System.Drawing.Point(248, 33)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl1.TabIndex = 17
        Me.LabelControl1.Text = "考核月份:"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = Global.IT_ProjectManager.My.Resources.Resources.View
        Me.SimpleButton1.Location = New System.Drawing.Point(449, 29)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(81, 26)
        Me.SimpleButton1.TabIndex = 16
        Me.SimpleButton1.Text = "预览"
        '
        'YearMonth
        '
        Me.YearMonth.Location = New System.Drawing.Point(313, 29)
        Me.YearMonth.Name = "YearMonth"
        Me.YearMonth.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearMonth.Properties.Appearance.Options.UseFont = True
        Me.YearMonth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.YearMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.YearMonth.Size = New System.Drawing.Size(115, 26)
        Me.YearMonth.TabIndex = 15
        '
        'lb
        '
        Me.lb.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lb.Location = New System.Drawing.Point(10, 33)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(75, 19)
        Me.lb.TabIndex = 14
        Me.lb.Text = "考核对象："
        '
        'txtJob
        '
        Me.txtJob.Location = New System.Drawing.Point(85, 29)
        Me.txtJob.Name = "txtJob"
        Me.txtJob.Properties.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJob.Properties.Appearance.Options.UseFont = True
        Me.txtJob.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJob.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "姓名"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserNo", "职位编号")})
        Me.txtJob.Properties.NullText = ""
        Me.txtJob.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtJob.Size = New System.Drawing.Size(143, 26)
        Me.txtJob.TabIndex = 2
        '
        'PrintDocument2
        '
        '
        'AssDataSet1
        '
        Me.AssDataSet1.DataSetName = "AssDataSet"
        Me.AssDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrintAssessReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "PrintAssessReport"
        Me.Size = New System.Drawing.Size(629, 408)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.YearMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJob.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtJob As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lb As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents YearMonth As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents PrintDocument12 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents AssDataSet1 As IT_ProjectManager.AssDataSet

End Class
