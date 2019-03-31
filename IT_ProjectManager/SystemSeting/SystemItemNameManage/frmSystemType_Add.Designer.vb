<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemType_Add
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSystemTypeA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtType = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdSava = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(6, 3)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(247, 239)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSystemTypeA})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colSystemTypeA
        '
        Me.colSystemTypeA.Caption = "系统类型"
        Me.colSystemTypeA.FieldName = "SystemType"
        Me.colSystemTypeA.Name = "colSystemTypeA"
        Me.colSystemTypeA.Visible = True
        Me.colSystemTypeA.VisibleIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtType)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(6, 248)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 47)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "新增必填"
        '
        'txtType
        '
        Me.txtType.Enabled = False
        Me.txtType.Location = New System.Drawing.Point(62, 15)
        Me.txtType.Name = "txtType"
        Me.txtType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtType.Properties.Appearance.Options.UseFont = True
        Me.txtType.Size = New System.Drawing.Size(177, 24)
        Me.txtType.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("PMingLiU", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(2, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(1)
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "类型(&C):"
        '
        'cmdSava
        '
        Me.cmdSava.Location = New System.Drawing.Point(259, 213)
        Me.cmdSava.Name = "cmdSava"
        Me.cmdSava.Size = New System.Drawing.Size(69, 29)
        Me.cmdSava.TabIndex = 90
        Me.cmdSava.Text = "保存(&S)"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(259, 45)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(69, 29)
        Me.cmdDelete.TabIndex = 89
        Me.cmdDelete.Text = "删除(&D)"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(258, 259)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(69, 29)
        Me.cmdExit.TabIndex = 88
        Me.cmdExit.Text = "关闭(&C)"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(259, 3)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(69, 29)
        Me.cmdAdd.TabIndex = 87
        Me.cmdAdd.Text = "新增(&A)"
        '
        'frmSystemType_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 299)
        Me.Controls.Add(Me.cmdSava)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GridControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSystemType_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "系统类型设置"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSystemTypeA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtType As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdSava As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
End Class
