Public Class ScoreSeting
    ''' <summary>
    ''' 是否處理修改狀態
    ''' true＝是
    ''' false=否
    ''' </summary>
    ''' <remarks></remarks>
    Dim isEdit As Boolean = False
    Dim GS_ID As Integer
    Dim GS_PID As Integer
    Dim level As Integer

    Private Sub ScoreSeting_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadData()
        Clearlb()
    End Sub

    ''' <summary>
    ''' 加載數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData()
        Dim sql As String = Nothing
        sql = "select * from IT_GradeStandard where GS_PID<>'0'"
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
    ''' 清空數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub Clearlb()
        txtGSName.Focus()
        txtRemark.Text = ""
        txtGSName.Text = ""
        tbSave.Text = "確認"
    End Sub
    '' 增加模塊
    Private Sub AddPro_Click(sender As System.Object, e As System.EventArgs) Handles AddPro.Click
        Panel.Enabled = True
        GS_PID = 1
        txtGSName.Focus()
    End Sub

    '' 保存數據
    Private Sub tbSave_Click(sender As System.Object, e As System.EventArgs) Handles tbSave.Click

        If Len(txtGSName.Text.Trim()) = 0 Then
            txtGSName.Focus()
            MessageBox.Show("請輸入標準名稱？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        SaveScore()

    End Sub

    ''' <summary>
    ''' 保存數據
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
                MessageBox.Show("操作失敗，影響多筆記錄？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("操作成功！", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                LoadData()
                Clearlb()
                Panel.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("未知錯誤：" & vbCrLf & ex.Message, "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    '' 增加項目
    Private Sub AddItems_Click(sender As System.Object, e As System.EventArgs) Handles AddItems.Click
        Panel.Enabled = True
        GS_PID = TlScore.FocusedNode.GetValue("GS_ID")
        level = TlScore.FocusedNode.Level
        txtGSName.Focus()
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Clearlb()
        Panel.Enabled = False
    End Sub
    '' 修改數據
    Private Sub Edit_Click(sender As System.Object, e As System.EventArgs) Handles Edit.Click
        Panel.Enabled = True
        isEdit = True
        GS_PID = TlScore.FocusedNode.GetValue("GS_PID")
        GS_ID = TlScore.FocusedNode.GetValue("GS_ID")
        level = TlScore.FocusedNode.Level
        tbSave.Text = "修改"
    End Sub
    '' 刪除
    Private Sub Del_Click(sender As System.Object, e As System.EventArgs) Handles Del.Click

        If TlScore.FocusedNode.Nodes.Count > 0 Then
            MessageBox.Show("此項目包含子節點，請選擇移除子項目？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        GS_ID = TlScore.FocusedNode.GetValue("GS_ID")
        GS_PID = TlScore.FocusedNode.GetValue("GS_PID")
        Dim name As String = TlScore.FocusedNode.GetValue("GS_Name")
        Dim result As New DialogResult

        result = MessageBox.Show("您確定需要刪除[" & name & "]相關數據嗎,資料一旦刪除則無法恢復？", "項目管理系統", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = Windows.Forms.DialogResult.No Then Exit Sub

        Dim sql As String = Nothing
        sql = "delete IT_GradeStandard where GS_ID='" & GS_ID & "' and GS_PID='" & GS_PID & "' and GS_Name='" & name & "'"

        Try
            If ExecuteNonQuery(sql) <> 1 Then
                MessageBox.Show("同存在多筆數據？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("刪除成功！", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                '' 移除指定行
                TlScore.Nodes.Remove(TlScore.FocusedNode)
            End If
        Catch ex As Exception
            MessageBox.Show("未知錯誤：" & vbCrLf & ex.Message, "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class