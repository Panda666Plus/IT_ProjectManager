Public Class frmProjectTasksToDo

    ''' <summary>
    ''' 导入个人待办事项
    ''' </summary>
    ''' <param name="strUserID"></param>
    ''' <param name="dteDate"></param>
    ''' <remarks></remarks>
    Sub LoadMyToDo(ByVal strUserID As String, ByVal dteDate As DateTime)

        '' On Error Resume Next

        Dim dt As New DataTable
        Dim StartDateTime As String
        Dim EndDateTime As String
        Dim strSB As New System.Text.StringBuilder

        StartDateTime = Format(dteDate, "yyyy-MM-dd") & " 00:00:00"
        EndDateTime = Format(dteDate, "yyyy-MM-dd") & " 23:59:59"

        ' sql = "select *  from IT_ToDo where TD_UserNo='" & UserID & "' and TD_Complete=0 order by TD_ID DESC"
        strSB.Append("select *,(select IT_Scheme.SchemeName from IT_Scheme where IT_Scheme.ID=IT_ToDo.SchemeID) as SchemeName,")
        strSB.Append("(select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_ToDo.TD_Context) as ContextName ")
        strSB.Append("from IT_ToDo where TD_UserNo='" & strUserID & "' and TD_Complete=1 and TD_CompleteDate  ")
        strSB.Append(" between '" & StartDateTime & "' and '" & EndDateTime & "'order by TD_CompleteDate")

        dt = getDataTables(strSB.ToString())
        GridMyToDo.DataSource = dt
        dt.Dispose()
        strSB.Clear()

    End Sub

    Private Sub frmProjectTasksToDo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        LoadMyToDo(UserID, CDate(txtDate.Text))

    End Sub

    Private Sub GridMyToDo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridMyToDo.DoubleClick
        'On Error Resume Next
        'If GridView1.RowCount = 0 Or Len(GridView1.GetFocusedRowCellValue("TD_ID")) = 0 Then Exit Sub
        'Edit = True
        'frmMyTasks.txtID.Text = GridView1.GetFocusedRowCellValue("TD_ID")
        'frmMyTasks.ShowDialog()
        ''显示修改过的内容
        'If blnSave = True Then
        '    GridView1.GetFocusedDataRow("TD_Name") = frmMyTasks.txtName.Text
        '    If Len(frmMyTasks.txtScheme.Text) > 0 Then GridView1.GetFocusedDataRow("SchemeName") = frmMyTasks.txtScheme.Text
        '    If Len(frmMyTasks.txtContext.Text) > 0 Then GridView1.GetFocusedDataRow("ContextName") = frmMyTasks.txtContext.Text
        '    If Len(frmMyTasks.txtRemark.Text) > 0 Then GridView1.GetFocusedDataRow("TD_Remark") = frmMyTasks.txtRemark.Text       
        'End If
    End Sub
End Class