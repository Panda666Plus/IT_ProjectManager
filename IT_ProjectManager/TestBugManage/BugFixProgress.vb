Public Class BugFixProgress

    Public autoID As String = Nothing

    Public sysName As String = Nothing

    Public sysID As String = Nothing


    Private Sub LBCuploadList_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles LBCuploadList.MouseDoubleClick

        '' 從FTP內下載文件，生成預覽

        Me.Cursor = Cursors.WaitCursor

        Dim PreviewName As String = LBCuploadList.SelectedItem

        Dim ftpPreview As New FTPFielsManager

        ftpPreview.Preview(autoID, lblSysProName.Text, PreviewName)

        Me.Cursor = Cursors.Default

    End Sub
    '' 變更反饋信息
    Private Sub btBugEntry_Click(sender As System.Object, e As System.EventArgs) Handles btBugEntry.Click

        If lblSpendTime.Text.Trim() <> "" Or lblSpendTime.Text.Trim() <> Nothing Then
            MessageBox.Show("Bug原因已經被回覆，無法修改？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim xx As New BugEntry
        xx.TestEdit = True
        xx.AutoID = autoID
        xx.ProjectID = sysID
        xx.btSave.Text = "修改"
        xx.ShowDialog()

        Clearlbl()

        '' 決定是否需要刷新數據
        If Not isRefresh Then Exit Sub

        DinbingData()

    End Sub

    '' 變更處理信息
    Private Sub btBugDesignate_Click(sender As System.Object, e As System.EventArgs) Handles btBugDesignate.Click

        If lblSpendTime.Text = "" Or lblSpendTime.Text = Nothing Then
            MessageBox.Show("沒有可修改數據？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If lblConfirmResults.Text.Trim() <> "" Or lblConfirmResults.Text.Trim() <> Nothing Then
            MessageBox.Show("Bug原因已經被確認，無法修改？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim xx As New Designate
        xx.AutoID = autoID
        xx.sysID = sysID
        xx.btSave.Text = "修改"
        xx.ShowDialog()

        Clearlbl()

        '' 決定是否需要刷新數據
        If Not isRefresh Then Exit Sub

        DinbingData()

    End Sub
    '' 變更確認信息
    Private Sub btResults_Click(sender As System.Object, e As System.EventArgs) Handles btResults.Click
        If lblConfirmResults.Text = "" Or lblConfirmResults.Text = Nothing Then
            MessageBox.Show("沒有可修改數據？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim xx As New ResultsConfirm
        xx.autoID = autoID
        xx.sysID = sysID
        xx.btSave.Text = "修改"
        xx.ShowDialog()
        Clearlbl()
        '' 決定是否需要刷新數據
        If Not isRefresh Then Exit Sub
        DinbingData()
    End Sub

    Private Sub BugFixProgress_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

        sql = "select * from IT_DevelopBugManager where AutoID='" & autoID & "' and SysProID='" & sysID & "'"

        dt = getDataTables(sql)

        If dt.Rows.Count <= 0 Then Exit Sub

        GroupControl2.Text = "Bug反饋人：" & dt.Rows(0)("CreatedUname") & "     反饋日期：" & dt.Rows(0)("CreateTime")
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
            GroupControl1.Text = "Bug處理人：" & dt.Rows(0)("ReplyName") & "       處理日期：" & dt.Rows(0)("ReplyDatetime")
            lblSpendTime.Text = dt.Rows(0)("SpendTime")
            lblImpactRemarks.Text = dt.Rows(0)("ImpactRemarks")
            METreatment.Text = dt.Rows(0)("Treatment")
        Else
            GroupControl1.Text = "待[" & dt.Rows(0)("ByDesigneeName") & "]回覆"
            btBugDesignate.Visible = False
        End If


        If Not dt.Rows(0)("ConfigName") Is DBNull.Value Then

            GroupControl3.Text = "Bug結果人：" & dt.Rows(0)("ConfigName") & "       確認日期：" & dt.Rows(0)("ConfigDatetime")
            lblConfirmResults.Text = dt.Rows(0)("ConfirmResults")
            MECloseRemarks.Text = dt.Rows(0)("CloseRemarks")
        Else
            If Not dt.Rows(0)("ResultsConfirmName") Is DBNull.Value Then
                GroupControl3.Text = "待[" & dt.Rows(0)("ResultsConfirmName") & "]確認"
            Else
                GroupControl3.Text = "待[" & dt.Rows(0)("ResultsConfirmName") & "]確認"
            End If
            btResults.Visible = False
        End If

    End Sub
    ''' <summary>
    ''' 清空數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub Clearlbl()

        GroupControl2.Text = "Bug反饋信息"
        lblSysProName.Text = ""
        lblBugName.Text = ""
        lblTestStandard.Text = ""
        lblTestNum.Text = ""
        lblCategory.Text = ""
        lblEmergency.Text = ""
        lblBugType.Text = ""
        MEExceptions.Text = ""
        GetAttachmentList(LBCuploadList, autoID, sysName)

        GroupControl1.Text = "Bug處理信息"
        lblSpendTime.Text = ""
        lblImpactRemarks.Text = ""
        METreatment.Text = ""

        GroupControl3.Text = "Bug修復結果確認"
        lblConfirmResults.Text = ""
        MECloseRemarks.Text = ""
    End Sub
End Class