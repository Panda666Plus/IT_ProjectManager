Public Class RatingStar
    ''' <summary>
    ''' 图片之间的 间距
    ''' </summary>
    Private _spareWidth As Integer = 3
    ''' <summary>
    ''' 是否显示 文本提示
    ''' </summary>
    Private _isShowText As Boolean = True

    'Public intValue As Integer = 0

    ''' <summary>
    ''' 当前选择 星 对应的索引,默认为 -1
    ''' </summary>
    Private _SelectedStarIndex As Integer = -1
    ''' <summary>
    ''' 编号
    ''' </summary>
    Private _strID As String = Nothing
    ''' <summary>
    ''' 名称
    ''' </summary>
    Private _strName As String = Nothing
    ''' <summary>
    ''' 是否显示 文本提示
    ''' </summary>
    Private _strRemark As String = Nothing
    ''' <summary>
    ''' 当前值，0
    ''' </summary>
    Private _Value As Integer = 0
    ''' <summary>
    ''' 当前值，0
    ''' </summary>
    Public intValue As Integer = 0

    Private _starTextArrary As String() = Nothing

    Public Sub New(ByVal strID As String, ByVal strName As String, ByVal strRemark As String, ByVal intValue As Integer)
        Me._strID = strID
        Me._strName = strName
        Me._strRemark = strRemark
        Me._Value = intValue
        InitializeComponent()
    End Sub

    ''' <summary>
    ''' 获得当前选择星 对应的 文本
    ''' </summary>
    Public ReadOnly Property Value() As Long
        Get
            ' Return If(Me._lblText Is Nothing, String.Empty, Me._lblText.Text)
            Return intValue
        End Get
    End Property

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RatingStar))
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.labID = New DevExpress.XtraEditors.LabelControl()
        Me.labRemark = New DevExpress.XtraEditors.LabelControl()
        Me.labName = New DevExpress.XtraEditors.LabelControl()
        Me.picYes = New System.Windows.Forms.PictureBox()
        Me.picNO = New System.Windows.Forms.PictureBox()
        Me.pic4 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pic5 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.picYes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl3.Controls.Add(Me.labID)
        Me.PanelControl3.Controls.Add(Me.labRemark)
        Me.PanelControl3.Controls.Add(Me.labName)
        Me.PanelControl3.Location = New System.Drawing.Point(1, 1)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(473, 173)
        Me.PanelControl3.TabIndex = 9
        '
        'labID
        '
        Me.labID.Appearance.Font = New System.Drawing.Font("微软正黑体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labID.Location = New System.Drawing.Point(106, 4)
        Me.labID.Name = "labID"
        Me.labID.Size = New System.Drawing.Size(38, 16)
        Me.labID.TabIndex = 4
        Me.labID.Text = "Name:"
        Me.labID.Visible = False
        '
        'labRemark
        '
        Me.labRemark.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labRemark.Appearance.Font = New System.Drawing.Font("微软正黑体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labRemark.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.labRemark.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.labRemark.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.labRemark.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.labRemark.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopLeft
        Me.labRemark.Location = New System.Drawing.Point(5, 26)
        Me.labRemark.Name = "labRemark"
        Me.labRemark.Size = New System.Drawing.Size(464, 144)
        Me.labRemark.TabIndex = 3
        Me.labRemark.Text = "Value"
        '
        'labName
        '
        Me.labName.Appearance.Font = New System.Drawing.Font("微软正黑体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labName.Location = New System.Drawing.Point(5, 4)
        Me.labName.Name = "labName"
        Me.labName.Size = New System.Drawing.Size(38, 16)
        Me.labName.TabIndex = 2
        Me.labName.Text = "Name:"
        '
        'picYes
        '
        Me.picYes.Image = CType(resources.GetObject("picYes.Image"), System.Drawing.Image)
        Me.picYes.Location = New System.Drawing.Point(182, 95)
        Me.picYes.Name = "picYes"
        Me.picYes.Size = New System.Drawing.Size(39, 29)
        Me.picYes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picYes.TabIndex = 7
        Me.picYes.TabStop = False
        Me.picYes.Visible = False
        '
        'picNO
        '
        Me.picNO.Image = CType(resources.GetObject("picNO.Image"), System.Drawing.Image)
        Me.picNO.Location = New System.Drawing.Point(142, 95)
        Me.picNO.Name = "picNO"
        Me.picNO.Size = New System.Drawing.Size(34, 29)
        Me.picNO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picNO.TabIndex = 6
        Me.picNO.TabStop = False
        Me.picNO.Visible = False
        '
        'pic4
        '
        Me.pic4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic4.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.pic4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic4.Image = CType(resources.GetObject("pic4.Image"), System.Drawing.Image)
        Me.pic4.InitialImage = CType(resources.GetObject("pic4.InitialImage"), System.Drawing.Image)
        Me.pic4.Location = New System.Drawing.Point(422, 3)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(27, 25)
        Me.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic4.TabIndex = 5
        Me.pic4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pic4, "4分")
        '
        'pic3
        '
        Me.pic3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.pic3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic3.Image = CType(resources.GetObject("pic3.Image"), System.Drawing.Image)
        Me.pic3.InitialImage = CType(resources.GetObject("pic3.InitialImage"), System.Drawing.Image)
        Me.pic3.Location = New System.Drawing.Point(398, 3)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(27, 25)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic3.TabIndex = 4
        Me.pic3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pic3, "3分")
        '
        'pic2
        '
        Me.pic2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.pic2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic2.Image = CType(resources.GetObject("pic2.Image"), System.Drawing.Image)
        Me.pic2.InitialImage = CType(resources.GetObject("pic2.InitialImage"), System.Drawing.Image)
        Me.pic2.Location = New System.Drawing.Point(373, 3)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(27, 25)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic2.TabIndex = 3
        Me.pic2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pic2, "2分")
        '
        'pic1
        '
        Me.pic1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.pic1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic1.Image = CType(resources.GetObject("pic1.Image"), System.Drawing.Image)
        Me.pic1.Location = New System.Drawing.Point(350, 3)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(27, 25)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic1.TabIndex = 2
        Me.pic1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pic1, "1分")
        '
        'pic5
        '
        Me.pic5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic5.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.pic5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic5.Image = CType(resources.GetObject("pic5.Image"), System.Drawing.Image)
        Me.pic5.InitialImage = CType(resources.GetObject("pic5.InitialImage"), System.Drawing.Image)
        Me.pic5.Location = New System.Drawing.Point(446, 3)
        Me.pic5.Name = "pic5"
        Me.pic5.Size = New System.Drawing.Size(27, 25)
        Me.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic5.TabIndex = 0
        Me.pic5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pic5, "5分")
        '
        'RatingStar
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Controls.Add(Me.picYes)
        Me.Controls.Add(Me.picNO)
        Me.Controls.Add(Me.pic4)
        Me.Controls.Add(Me.pic3)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.pic5)
        Me.Controls.Add(Me.PanelControl3)
        Me.Name = "RatingStar"
        Me.Size = New System.Drawing.Size(477, 177)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.picYes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private Sub pic1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic1.Click
        'If pic1.Image Is picNO.Image Then '灰色
        If intValue = 1 Then
            pic1.Image = picNO.Image
            pic2.Image = picNO.Image
            pic3.Image = picNO.Image
            pic4.Image = picNO.Image
            pic5.Image = picNO.Image
            intValue = 0

        Else
            pic1.Image = picYes.Image
            pic2.Image = picNO.Image
            pic3.Image = picNO.Image
            pic4.Image = picNO.Image
            pic5.Image = picNO.Image
            intValue = 1
        End If

        ' Else
        'pic1.Image = picNO.Image
        ' End If
    End Sub

    Private Sub pic2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic2.Click
        pic1.Image = picYes.Image
        pic2.Image = picYes.Image
        pic3.Image = picNO.Image
        pic4.Image = picNO.Image
        pic5.Image = picNO.Image
        intValue = 2
    End Sub

    Private Sub pic3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic3.Click
        pic1.Image = picYes.Image
        pic2.Image = picYes.Image
        pic3.Image = picYes.Image
        pic4.Image = picNO.Image
        pic5.Image = picNO.Image
        intValue = 3
    End Sub

    Private Sub pic4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic4.Click
        pic1.Image = picYes.Image
        pic2.Image = picYes.Image
        pic3.Image = picYes.Image
        pic4.Image = picYes.Image
        pic5.Image = picNO.Image
        intValue = 4
    End Sub

    Private Sub pic5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic5.Click
        pic1.Image = picYes.Image
        pic2.Image = picYes.Image
        pic3.Image = picYes.Image
        pic4.Image = picYes.Image
        pic5.Image = picYes.Image
        intValue = 5
    End Sub

#Region " 鼠标"
    'Private Sub pic5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic5.MouseHover
    '    pic1.Image = picYes.Image
    '    pic2.Image = picYes.Image
    '    pic3.Image = picYes.Image
    '    pic4.Image = picYes.Image
    '    pic5.Image = picYes.Image
    'End Sub
    'Private Sub pic4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic4.MouseHover
    '    pic1.Image = picYes.Image
    '    pic2.Image = picYes.Image
    '    pic3.Image = picYes.Image
    '    pic4.Image = picYes.Image
    '    pic5.Image = picNO.Image
    'End Sub
    'Private Sub pic3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic3.MouseHover
    '    pic1.Image = picYes.Image
    '    pic2.Image = picYes.Image
    '    pic3.Image = picYes.Image
    '    pic4.Image = picNO.Image
    '    pic5.Image = picNO.Image
    'End Sub
    'Private Sub pic2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic2.MouseHover
    '    pic1.Image = picYes.Image
    '    pic2.Image = picYes.Image
    '    pic3.Image = picNO.Image
    '    pic4.Image = picNO.Image
    '    pic5.Image = picNO.Image
    'End Sub
    'Private Sub pic1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic1.MouseHover
    '    pic1.Image = picYes.Image
    '    pic2.Image = picNO.Image
    '    pic3.Image = picNO.Image
    '    pic4.Image = picNO.Image
    '    pic5.Image = picNO.Image
    'End Sub
    'Private Sub pic5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic5.MouseLeave
    '    Select Case labValue.Text
    '        Case 5
    '            pic5_Click(Nothing, Nothing)
    '        Case 4
    '            pic4_Click(Nothing, Nothing)
    '        Case 3
    '            pic3_Click(Nothing, Nothing)
    '        Case 2
    '            pic2_Click(Nothing, Nothing)
    '        Case 1
    '            pic1_Click(Nothing, Nothing)
    '    End Select
    'End Sub
    'Private Sub pic4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic4.MouseLeave
    '    Select Case labValue.Text
    '        Case 5
    '            pic5_Click(Nothing, Nothing)
    '        Case 4
    '            pic4_Click(Nothing, Nothing)
    '        Case 3
    '            pic3_Click(Nothing, Nothing)
    '        Case 2
    '            pic2_Click(Nothing, Nothing)
    '        Case 1
    '            pic1_Click(Nothing, Nothing)
    '    End Select
    'End Sub
    'Private Sub pic3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic3.MouseLeave
    '    Select Case labValue.Text
    '        Case 5
    '            pic5_Click(Nothing, Nothing)
    '        Case 4
    '            pic4_Click(Nothing, Nothing)
    '        Case 3
    '            pic3_Click(Nothing, Nothing)
    '        Case 2
    '            pic2_Click(Nothing, Nothing)
    '        Case 1
    '            pic1_Click(Nothing, Nothing)
    '    End Select
    'End Sub
    'Private Sub pic2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic2.MouseLeave
    '    Select Case labValue.Text
    '        Case 5
    '            pic5_Click(Nothing, Nothing)
    '        Case 4
    '            pic4_Click(Nothing, Nothing)
    '        Case 3
    '            pic3_Click(Nothing, Nothing)
    '        Case 2
    '            pic2_Click(Nothing, Nothing)
    '        Case 1
    '            pic1_Click(Nothing, Nothing)
    '    End Select
    'End Sub
    'Private Sub pic1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic1.MouseLeave
    '    Select Case labValue.Text
    '        Case 5
    '            pic5_Click(Nothing, Nothing)
    '        Case 4
    '            pic4_Click(Nothing, Nothing)
    '        Case 3
    '            pic3_Click(Nothing, Nothing)
    '        Case 2
    '            pic2_Click(Nothing, Nothing)
    '        Case 1
    '            pic1_Click(Nothing, Nothing)
    '    End Select
    'End Sub
#End Region

    Public Sub SetValue()
        '更新状态
        Select Case intValue
            Case 5
                pic5_Click(Nothing, Nothing)
            Case 4
                pic4_Click(Nothing, Nothing)
            Case 3
                pic3_Click(Nothing, Nothing)
            Case 2
                pic2_Click(Nothing, Nothing)
            Case 1
                intValue = 0
                pic1_Click(Nothing, Nothing)
            Case 0
                intValue = 1
                pic1_Click(Nothing, Nothing)
        End Select
    End Sub

    Private Sub RatingStar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        On Error Resume Next
        labID.Text = Me._strID
        labName.Text = Me._strName
        labRemark.Text = Me._strRemark
        '测试初始值
        intValue = _Value
        SetValue()
    End Sub
End Class
