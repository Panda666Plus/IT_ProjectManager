''' <summary>
'''系统类型设置  2014/12/11  DEVON
''' </summary>
''' <remarks></remarks>
Public Class frmSystemType_Add
    Dim ds As New DataSet
    'Private m_dt As DataTable
    Public m_dt As DataTable

    ''' <summary>
    ''' 构造函数实现不同窗体间 数据传递 或 数据共享
    ''' </summary>
    ''' <param name="dt"></param>
    ''' <remarks></remarks>
    Sub New(ByRef dt As DataTable)
        ' 此为设计工具所需的呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入任何初始设定。
        m_dt = dt
    End Sub

    Private Sub frmSystemType_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadSystemType()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        txtType.Enabled = True
        txtType.Focus()
    End Sub

    ''' <summary>
    ''' 载入父窗体中的 系统类型
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadSystemType()
        Try
            If m_dt.Rows.Count > 0 Then
                GridControl1.DataSource = m_dt
            Else
                GridControl1.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("线程引发异常：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' 新增
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdSava_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSava.Click
        Dim row As DataRow = m_dt.NewRow()
        row("SystemType") = txtType.Text.Trim()
        m_dt.Rows.Add(row)
        txtType.Text = String.Empty
    End Sub

    ''' <summary>
    ''' 删除
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If m_dt.Rows.Count = 0 Then Exit Sub
        m_dt.Rows.RemoveAt(GridView1.FocusedRowHandle)
    End Sub

    ''' <summary>
    ''' 关闭窗口
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

End Class