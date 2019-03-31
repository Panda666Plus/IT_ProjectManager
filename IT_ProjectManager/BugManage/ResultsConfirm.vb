Public Class ResultsConfirm

    Public autoID As String = Nothing

    Public sysID As String = Nothing

    Public isView As Boolean = False

    '' 加载反馈信息
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim xx As New BugEntry
        xx.isView = True
        xx.CurrentStatus = "待验收"
        xx.ToolTip.Text = "双击预览"
        xx.AutoID = autoID
        xx.ProjectID = sysID
        xx.ShowDialog()
    End Sub

    '' 加载回覆信息
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Dim xx As New Designate
        xx.isView = True
        xx.AutoID = autoID
        xx.sysID = sysID
        xx.SimpleButton1.Visible = False
        xx.ShowDialog()
    End Sub

    Private Sub ResultsConfirm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clearlbl()
        loadEditData()
    End Sub
    Dim pName As String = String.Empty

    ''' <summary>
    ''' 加载编辑与查看数据
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadEditData()

        Dim dt As New DataTable
        Dim sql As String = Nothing

        sql = "select * from IT_DevelopBugManager where AutoID='" & autoID & "' and SysProID='" & sysID & "'"

        dt = getDataTables(sql)

        If dt.Rows.Count <= 0 Then Exit Sub

        '' 载入所以附件
        pName = dt.Rows(0)("SysProName")

        GetAttachmentList(LBCuploadList, autoID, pName)

        dt.Dispose()

    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click

        If isView Then Exit Sub

        If Len(txtSpandTime.Text.Trim()) = 0 Then
            txtSpandTime.Focus()
            MessageBox.Show("请输入确认结果？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim strSB As New System.Text.StringBuilder
        strSB.Append("update IT_DevelopBugManager set CurrentStatus='已验收',")
        strSB.Append(" ConfirmResults='" & txtSpandTime.Text & "' , CloseRemarks='" & METreatment.Text.Trim())
        strSB.Append("', ConfigName='" & UserName & "',ConfigJob='" & UserID & "' ,ConfigDatetime='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
        strSB.Append("' where AutoID='" & autoID & "' and SysProID='" & sysID & "'")

        If ExecuteNonQuery(strSB.ToString()) = 1 Then
            MessageBox.Show("确认成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            MessageBox.Show("确认失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        strSB.Clear()
        isRefresh = True
        Clearlbl()
        Me.Close()

    End Sub
    ''' <summary>
    ''' 清空数据
    ''' </summary>
    ''' <remarks></remarks>
    Sub Clearlbl()
        txtSpandTime.Text = ""
        METreatment.Text = ""
    End Sub

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ResultsConfirm_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        On Error Resume Next
        txtSpandTime.Focus()
        txtSpandTime.SelectAll()
    End Sub

    Private Sub LBCuploadList_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBCuploadList.DoubleClick
        If LBCuploadList.SelectedIndex < 0 Then Exit Sub

        '' 预览模式
        '' 从FTP内下载文件，生成预览

        Me.Cursor = Cursors.WaitCursor

        Dim PreviewName As String = LBCuploadList.SelectedItem

        Dim ftpPreview As New FTPFielsManager

        ftpPreview.Preview(autoID, pName, PreviewName)

        Me.Cursor = Cursors.Default

    End Sub

End Class