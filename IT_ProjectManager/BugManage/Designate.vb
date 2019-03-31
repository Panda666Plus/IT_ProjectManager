Public Class Designate

    Public AutoID As String = Nothing
    ''' <summary>
    ''' 系统名称ID
    ''' </summary>
    ''' <remarks></remarks>
    Public sysID As String = Nothing

    Public isView As Boolean = False

    Dim pName As String = String.Empty


    '' 保存Bug回覆数据
    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click

        If isView Then Exit Sub

        If Len(txtSpandTime.Text.Trim()) = 0 Then
            MessageBox.Show("请输入所需时间？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If chIsAffect.Checked Then
            If Len(txtImpactRemarks.Text.Trim()) = 0 Then
                MessageBox.Show("请输入影响模块", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        If Len(METreatment.Text.Trim()) = 0 Then
            MessageBox.Show("请输入处理方式", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim checkValue As Integer

        If chIsAffect.Checked Then
            checkValue = 1
        Else
            checkValue = 0
        End If

        Dim strSB As New System.Text.StringBuilder

        '' 保存处理後数据
        strSB.Append("update IT_DevelopBugManager set CurrentStatus='待验收',")
        strSB.Append(" SpendTime='" & txtSpandTime.Text.Trim() & "',IsAffect='" & checkValue)
        strSB.Append("',ImpactRemarks='" & txtImpactRemarks.Text.Trim() & "',Treatment='" & METreatment.Text.Trim())
        strSB.Append("',ReplyName='" & UserName & "',ReplyJob='" & UserID & "',ReplyDatetime='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "'")
        strSB.Append(" where AutoID='" & AutoID & "' and SysProID='" & sysID & "'")

        If ExecuteNonQuery(strSB.ToString()) = 1 Then
            MessageBox.Show("保存成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            isRefresh = True
        Else
            MessageBox.Show("处理数据保存失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        strSB.Clear()
        Clearlbl()
        Me.Close()

    End Sub
    '' 决定是否影响其他模块
    Private Sub chIsAffect_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chIsAffect.CheckedChanged
        txtImpactRemarks.Text = Nothing

        If chIsAffect.Checked Then
            txtImpactRemarks.Visible = True
            txtImpactRemarks.Focus()
        Else
            txtImpactRemarks.Visible = False
        End If

    End Sub

    Private Sub Designate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Clearlbl()

        DinbingData()

    End Sub
    ''' <summary>
    ''' 绑定数据
    ''' </summary>
    ''' <remarks></remarks>
    Sub DinbingData()

        Dim dt As New DataTable
        Dim sql As String = Nothing
        sql = "select * from IT_DevelopBugManager where AutoID='" & AutoID & "' and SysProID='" & sysID & "' and  CurrentStatus='待验收'"

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

        pName = dt.Rows(0)("SysProName")

        '' 载入所以附件

        GetAttachmentList(LBCuploadList, AutoID, pName)

    End Sub
    ''' <summary>
    ''' 锁定控件
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

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        Dim xx As New BugEntry
        xx.isView = True
        xx.AutoID = AutoID
        xx.ProjectID = sysID
        xx.ToolTip.Text = "双击预览"
        xx.ShowDialog()

    End Sub

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Designate_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
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

        ftpPreview.Preview(AutoID, pName, PreviewName)

        Me.Cursor = Cursors.Default

    End Sub

End Class