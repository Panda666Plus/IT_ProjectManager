Public Class ResultsConfirm

    Public autoID As String = Nothing

    Public sysID As String = Nothing

    Public isView As Boolean = False

    '' 加載反饋信息
    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Dim xx As New BugEntry
        xx.isView = True
        xx.CurrentStatus = "待驗收"
        xx.ToolTip.Text = "雙擊預覽"
        xx.AutoID = autoID
        xx.ProjectID = sysID
        xx.ShowDialog()
    End Sub

    '' 加載回覆信息
    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton2.Click
        Dim xx As New Designate
        xx.isView = True
        xx.AutoID = autoID
        xx.sysID = sysID
        xx.SimpleButton1.Visible = False
        xx.ShowDialog()
    End Sub

    Private Sub ResultsConfirm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Clearlbl()
        loadEditData()
    End Sub

    ''' <summary>
    ''' 加載編輯與查看數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadEditData()

        Dim dt As New DataTable
        Dim sql As String = Nothing

        sql = "select * from IT_DevelopBugManager where AutoID='" & autoID & "' and SysProID='" & sysID & "'  and CurrentStatus='已驗收'"

        dt = getDataTables(sql)

        If dt.Rows.Count <= 0 Then Exit Sub

        txtSpandTime.Text = dt.Rows(0)("ConfirmResults")

        METreatment.Text = dt.Rows(0)("CloseRemarks")

        If isView Then
            GroupControl2.Text = "確認人：" & dt.Rows(0)("ConfigName") & "     確認時間：" & dt.Rows(0)("ConfigDatetime")
            txtSpandTime.Properties.ReadOnly = True
            METreatment.Properties.ReadOnly = True
        End If

    End Sub

    Private Sub btSave_Click(sender As System.Object, e As System.EventArgs) Handles btSave.Click

        If isView Then Exit Sub

        If Len(txtSpandTime.Text.Trim()) = 0 Then
            txtSpandTime.Focus()
            MessageBox.Show("請輸入確認結果？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim sql As String = Nothing
        sql = "update IT_DevelopBugManager set CurrentStatus='已驗收',"
        sql = sql & " ConfirmResults='" & txtSpandTime.Text & "' , CloseRemarks='" & METreatment.Text.Trim() &
            "', ConfigName='" & UserName & "',ConfigJob='" & UserID & "' ,ConfigDatetime='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") &
            "' where AutoID='" & autoID & "' and SysProID='" & sysID & "'"

        If ExecuteNonQuery(sql) = 1 Then
            MessageBox.Show("確認成功！", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            MessageBox.Show("確認失敗？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        isRefresh = True
        Clearlbl()
        Me.Close()

    End Sub
    ''' <summary>
    ''' 清空數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub Clearlbl()
        txtSpandTime.Text = ""
        METreatment.Text = ""
    End Sub

    Private Sub btClose_Click(sender As System.Object, e As System.EventArgs) Handles btClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ResultsConfirm_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        On Error Resume Next
        txtSpandTime.Focus()
        txtSpandTime.SelectAll()
    End Sub
End Class