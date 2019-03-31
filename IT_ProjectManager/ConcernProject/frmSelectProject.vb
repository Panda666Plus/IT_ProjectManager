Public Class frmSelectProject

    ''' <summary>
    ''' 导入项目资料
    ''' </summary>
    ''' <param name="strType"></param>
    ''' <remarks></remarks>
    Sub LoadProjectData(ByVal strType As Boolean)

        Dim dt As New DataTable
        Dim sql As String = Nothing

        If strType = True Then  '导入所有项目
            sql = "select *  from IT_Scheme where SmStatus not in ('17','19') order by ID"
        Else '’导入本人项目()
            sql = "select *  from IT_Scheme where SmStatus not in ('17','19') and SmFollow='" & UserID & "' order by ID"
        End If

        dt = getDataTables(sql)
        Grid1.DataSource = dt
        dt.Dispose()

    End Sub

    Private Sub rdbMy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbMy.CheckedChanged
        If rdbMy.Checked = True Then LoadProjectData(False)
    End Sub

    Private Sub rdbFull_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbFull.CheckedChanged
        If rdbFull.Checked = True Then LoadProjectData(True)
    End Sub

    Private Sub Grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        '' Dim frm As New frmMyTasks
        On Error Resume Next
        frmMyTasks.txtSchemeID.Text = GridView2.GetFocusedRowCellValue("ID")
        frmMyTasks.txtScheme.Text = GridView2.GetFocusedRowCellValue("SchemeName")
        Me.Close()
    End Sub

    Private Sub frmSelectProject_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtName.Text = ""
        GridView2.ActiveFilterString = ""
        rdbMy.Checked = True
        LoadProjectData(False)
    End Sub

    ''' <summary>
    ''' 刷新条件
    ''' </summary>
    ''' <remarks></remarks>
    Sub ChecksFilterValue()

        GridView2.ActiveFilterString = "[SchemeName] like '%" & txtName.Text & "%'"

    End Sub

    Private Sub txtName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.EditValueChanged

        If Len(txtName.Text) > 0 Then
            ChecksFilterValue()
        End If

    End Sub


End Class