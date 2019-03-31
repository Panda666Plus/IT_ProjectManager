Public Class BugFixProgress

    Public autoID As String = Nothing

    Public sysName As String = Nothing

    Public sysID As String = Nothing


    Private Sub LBCuploadList_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LBCuploadList.MouseDoubleClick

        '' 从FTP内下载文件，生成预览

        Me.Cursor = Cursors.WaitCursor

        Dim PreviewName As String = LBCuploadList.SelectedItem

        Dim ftpPreview As New FTPFielsManager

        ftpPreview.Preview(autoID, lblSysProName.Text, PreviewName)

        Me.Cursor = Cursors.Default

    End Sub
    '' 变更反馈信息
    Private Sub btBugEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBugEntry.Click

        If lblSpendTime.Text.Trim() <> "" Or lblSpendTime.Text.Trim() <> Nothing Then
            MessageBox.Show("Bug原因已经被回覆，无法修改？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim xx As New BugEntry
        xx.TestEdit = True
        xx.AutoID = autoID
        xx.ProjectID = sysID
        xx.btSave.Text = "修改"
        xx.Text = "Bug管理[数据修改]"
        xx.ShowDialog()

        Clearlbl()

        '' 决定是否需要刷新数据
        If Not isRefresh Then Exit Sub

        DinbingData()

    End Sub

    '' 变更处理信息
    Private Sub btBugDesignate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBugDesignate.Click

        If lblSpendTime.Text = "" Or lblSpendTime.Text = Nothing Then
            MessageBox.Show("没有可修改数据？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If lblConfirmResults.Text.Trim() <> "" Or lblConfirmResults.Text.Trim() <> Nothing Then
            MessageBox.Show("Bug原因已经被确认，无法修改？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim xx As New Designate
        xx.AutoID = autoID
        xx.sysID = sysID
        xx.btSave.Text = "修改"
        xx.Text = "Bug原因回覆[修改]"
        xx.ShowDialog()

        Clearlbl()

        '' 决定是否需要刷新数据
        If Not isRefresh Then Exit Sub

        DinbingData()

    End Sub
    '' 变更确认信息
    Private Sub btResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResults.Click
        If lblConfirmResults.Text = "" Or lblConfirmResults.Text = Nothing Then
            MessageBox.Show("没有可修改数据？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim xx As New ResultsConfirm
        xx.autoID = autoID
        xx.sysID = sysID
        xx.btSave.Text = "修改"
        xx.Text = "Bug回覆确认[修改]"
        xx.ShowDialog()
        Clearlbl()
        '' 决定是否需要刷新数据
        If Not isRefresh Then Exit Sub
        DinbingData()
    End Sub

    Private Sub BugFixProgress_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        sql = "select * from IT_DevelopBugManager where AutoID='" & autoID & "' and SysProID='" & sysID & "'"

        dt = getDataTables(sql)

        If dt.Rows.Count <= 0 Then Exit Sub
        If Testers Then
            btBugEntry.Visible = True
        End If
        GroupControl2.Text = "Bug反馈人：" & dt.Rows(0)("CreatedUname") & "     反馈日期：" & dt.Rows(0)("CreateTime")
        lblSysProName.Text = dt.Rows(0)("SysProName")
        lblBugName.Text = dt.Rows(0)("BugName")
        lblTestStandard.Text = dt.Rows(0)("TestStandard")
        lblTestNum.Text = dt.Rows(0)("TestNum")
        lblCategory.Text = dt.Rows(0)("Category")
        lblEmergency.Text = dt.Rows(0)("Emergency")
        lblBugType.Text = dt.Rows(0)("BugType")
        MEExceptions.Text = dt.Rows(0)("Exceptions")

        GetAttachmentList(LBCuploadList, autoID, lblSysProName.Text)

        If Not dt.Rows(0)("ReplyName") Is DBNull.Value Then
            GroupControl1.Text = "Bug处理人：" & dt.Rows(0)("ReplyName") & "       处理日期：" & dt.Rows(0)("ReplyDatetime")
            lblSpendTime.Text = dt.Rows(0)("SpendTime")
            lblImpactRemarks.Text = dt.Rows(0)("ImpactRemarks")
            METreatment.Text = dt.Rows(0)("Treatment")
        Else
            GroupControl1.Text = "待[" & dt.Rows(0)("ByDesigneeName") & "]回覆"
            btBugDesignate.Visible = False
        End If


        If Not dt.Rows(0)("ConfigName") Is DBNull.Value Then

            GroupControl3.Text = "Bug结果人：" & dt.Rows(0)("ConfigName") & "       确认日期：" & dt.Rows(0)("ConfigDatetime")
            lblConfirmResults.Text = dt.Rows(0)("ConfirmResults")
            MECloseRemarks.Text = dt.Rows(0)("CloseRemarks")
        Else
            If Not dt.Rows(0)("ResultsConfirmName") Is DBNull.Value Then
                GroupControl3.Text = "待[" & dt.Rows(0)("ResultsConfirmName") & "]确认"
            Else
                GroupControl3.Text = "待[" & dt.Rows(0)("ResultsConfirmName") & "]确认"
            End If
            btResults.Visible = False
        End If

    End Sub
    ''' <summary>
    ''' 清空数据
    ''' </summary>
    ''' <remarks></remarks>
    Sub Clearlbl()

        GroupControl2.Text = "Bug反馈信息"
        lblSysProName.Text = ""
        lblBugName.Text = ""
        lblTestStandard.Text = ""
        lblTestNum.Text = ""
        lblCategory.Text = ""
        lblEmergency.Text = ""
        lblBugType.Text = ""
        MEExceptions.Text = ""
        GetAttachmentList(LBCuploadList, autoID, sysName)

        GroupControl1.Text = "Bug处理信息"
        lblSpendTime.Text = ""
        lblImpactRemarks.Text = ""
        METreatment.Text = ""

        GroupControl3.Text = "Bug修复结果确认"
        lblConfirmResults.Text = ""
        MECloseRemarks.Text = ""
    End Sub

    Private Sub LBCuploadList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBCuploadList.SelectedIndexChanged

    End Sub
End Class