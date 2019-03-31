Public Class ScoreSeting
    ''' <summary>
    ''' 是否处理修改状态
    ''' true＝是
    ''' false=否
    ''' </summary>
    ''' <remarks></remarks>
    Dim isEdit As Boolean = False
    Dim GS_ID As Integer
    Dim GS_PID As Integer
    Dim level As Integer

    Private Sub ScoreSeting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadData()
        Clearlb()
    End Sub

    ''' <summary>
    ''' 加载数据
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData()
        Dim sql As String = Nothing
        sql = "select * from IT_GradeStandard"
        Dim dt As New DataTable
        dt = getDataTables(sql)
        If dt.Rows.Count > 0 Then
            TlScore.DataSource = dt
        Else
            TlScore.DataSource = Nothing
        End If
        dt.Dispose()
    End Sub
    ''' <summary>
    ''' 清空数据
    ''' </summary>
    ''' <remarks></remarks>
    Sub Clearlb()
        txtGSName.Focus()
        txtRemark.Text = ""
        txtGSName.Text = ""
        tbSave.Text = "确认"
    End Sub
    '' 增加模块
    Private Sub AddPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPro.Click
        Panel.Enabled = True
        GS_PID = 2
        level = 2
        txtGSName.Focus()
    End Sub

    '' 保存数据
    Private Sub tbSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSave.Click

        If Len(txtGSName.Text.Trim()) = 0 Then
            txtGSName.Focus()
            MessageBox.Show("请输入标准名称？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        SaveScore()

    End Sub

    ''' <summary>
    ''' 保存数据
    ''' </summary>
    ''' <remarks></remarks>
    Sub SaveScore()
        Dim sql As String = Nothing

        If isEdit Then
            sql = "update IT_GradeStandard set GS_Name='" & txtGSName.Text.Trim() & "' ,GS_Remark='" & txtRemark.Text.Trim() &
                "' where GS_ID='" & GS_ID & "' and GS_PID='" & GS_PID & "'"
        Else
            sql = "insert into IT_GradeStandard (GS_PID,GS_Level,GS_Name,GS_Remark) values('" & GS_PID & "','" & level &
                "','" & txtGSName.Text.Trim() & "','" & txtRemark.Text.Trim() & "')"
        End If

        Try
            If ExecuteNonQuery(sql) <> 1 Then
                MessageBox.Show("操作失败，影响多笔记录？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("操作成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                LoadData()
                Clearlb()
                Panel.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("未知错误：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    '' 增加项目
    Private Sub AddItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddItems.Click
        Panel.Enabled = True
        GS_PID = 1
        level = 1
        txtGSName.Focus()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        If Not isEdit Then
            Me.Close()
        Else
            Clearlb()
            Panel.Enabled = False
        End If
    End Sub
    '' 修改数据
    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        Panel.Enabled = True
        isEdit = True
        GS_PID = TlScore.FocusedNode.GetValue("GS_PID")
        GS_ID = TlScore.FocusedNode.GetValue("GS_ID")
        level = TlScore.FocusedNode.Level
        tbSave.Text = "修改"
    End Sub
    '' 删除
    Private Sub Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Del.Click

        If TlScore.FocusedNode.Nodes.Count > 0 Then
            MessageBox.Show("此项目包含子节点，请选择移除子项目？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        GS_ID = TlScore.FocusedNode.GetValue("GS_ID")
        GS_PID = TlScore.FocusedNode.GetValue("GS_PID")
        Dim name As String = TlScore.FocusedNode.GetValue("GS_Name")
        Dim result As New DialogResult

        result = MessageBox.Show("您确定需要删除[" & name & "]相关数据吗,资料一旦删除则无法恢复？", "项目管理系统", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = Windows.Forms.DialogResult.No Then Exit Sub

        Dim sql As String = Nothing
        sql = "delete IT_GradeStandard where GS_ID='" & GS_ID & "' and GS_PID='" & GS_PID & "' and GS_Name='" & name & "'"

        Try
            If ExecuteNonQuery(sql) <> 1 Then
                MessageBox.Show("同存在多笔数据？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("删除成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                '' 移除指定行
                TlScore.Nodes.Remove(TlScore.FocusedNode)
            End If
        Catch ex As Exception
            MessageBox.Show("未知错误：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub TlScore_GetStateImage(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.GetStateImageEventArgs) Handles TlScore.GetStateImage
        If e.Node Is Nothing Then Exit Sub
        Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
        node = e.Node
        Dim ID As Integer = e.Node.Level
        e.NodeImageIndex = ID
    End Sub
End Class