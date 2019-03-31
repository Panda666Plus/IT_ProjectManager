Public Class Designate

    Public AutoID As String = Nothing
    ''' <summary>
    ''' 系統名稱ID
    ''' </summary>
    ''' <remarks></remarks>
    Public sysID As String = Nothing

    Public isView As Boolean = False



    '' 保存Bug回覆數據
    Private Sub btSave_Click(sender As System.Object, e As System.EventArgs) Handles btSave.Click

        If isView Then Exit Sub

        If Len(txtSpandTime.Text.Trim()) = 0 Then
            MessageBox.Show("請輸入所需時間？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If chIsAffect.Checked Then
            If Len(txtImpactRemarks.Text.Trim()) = 0 Then
                MessageBox.Show("請輸入影響模塊", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        If Len(METreatment.Text.Trim()) = 0 Then
            MessageBox.Show("請輸入處理方式", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim checkValue As Integer

        If chIsAffect.Checked Then
            checkValue = 1
        Else
            checkValue = 0
        End If

        Dim tempsql As String = Nothing

        Dim sql As String = Nothing

        '' 保存處理後數據
        tempsql = "update IT_DevelopBugManager set CurrentStatus='待驗收',"

        tempsql = tempsql & " SpendTime='" & txtSpandTime.Text.Trim() & "',IsAffect='" & checkValue &
            "',ImpactRemarks='" & txtImpactRemarks.Text.Trim() & "',Treatment='" & METreatment.Text.Trim() &
            "',ReplyName='" & UserName & "',ReplyJob='" & UserID & "',ReplyDatetime='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "'"

        sql = tempsql & " where AutoID='" & AutoID & "' and SysProID='" & sysID & "'"

        If ExecuteNonQuery(sql) = 1 Then
            MessageBox.Show("保存成功！", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            isRefresh = True
        Else
            MessageBox.Show("處理數據保存失敗？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Clearlbl()
        Me.Close()

    End Sub
    '' 決定是否影響其他模塊
    Private Sub chIsAffect_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chIsAffect.CheckedChanged
        txtImpactRemarks.Text = Nothing

        If chIsAffect.Checked Then
            txtImpactRemarks.Visible = True
            txtImpactRemarks.Focus()
        Else
            txtImpactRemarks.Visible = False
        End If

    End Sub

    Private Sub Designate_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Clearlbl()

        DinbingData()

    End Sub
    ''' <summary>
    ''' 綁定數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub DinbingData()

        Dim dt As New DataTable
        Dim sql As String = Nothing
        sql = "select * from IT_DevelopBugManager where AutoID='" & AutoID & "' and SysProID='" & sysID & "' and  CurrentStatus='待驗收'"

        dt = getDataTables(sql)

        If dt.Rows.Count <= 0 Then Exit Sub

        txtSpandTime.Text = dt.Rows(0)("SpendTime")
        chIsAffect.Checked = CInt(dt.Rows(0)("IsAffect"))
        txtImpactRemarks.Text = dt.Rows(0)("ImpactRemarks")
        METreatment.Text = dt.Rows(0)("Treatment")

        If isView Then
            GroupControl2.Text = "回覆人：" & dt.Rows(0)("ReplyName") & "        回覆日期：" & dt.Rows(0)("ReplyDatetime")
            ReadOnlyControl()
        End If

    End Sub
    ''' <summary>
    ''' 鎖定控件
    ''' </summary>
    ''' <remarks></remarks>
    Sub ReadOnlyControl()
        txtSpandTime.Properties.ReadOnly = True
        chIsAffect.Properties.ReadOnly = True
        txtImpactRemarks.Properties.ReadOnly = True
        METreatment.Properties.ReadOnly = True
    End Sub

    ''' <summary>
    ''' 清空控件
    ''' </summary>
    ''' <remarks></remarks>
    Sub Clearlbl()
        txtSpandTime.Text = ""
        txtImpactRemarks.Text = ""
        METreatment.Text = ""
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click

        Dim xx As New BugEntry
        xx.isView = True
        xx.AutoID = AutoID
        xx.ProjectID = sysID
        xx.ToolTip.Text = "雙擊預覽"
        xx.ShowDialog()

    End Sub

    Private Sub btClose_Click(sender As System.Object, e As System.EventArgs) Handles btClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Designate_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        On Error Resume Next
        txtSpandTime.Focus()
        txtSpandTime.SelectAll()
    End Sub
End Class