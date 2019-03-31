
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class frmSelectProject2

    ''' <summary>
    ''' 导入项目资料
    ''' </summary>
    ''' <param name="strType"></param>
    ''' <remarks></remarks>
    Sub LoadProjectData(ByVal strType As Boolean)

        Try
            Dim dt As New DataTable
            Dim strSB As New System.Text.StringBuilder

            If strType = True Then  '导入所有项目
                strSB.Append("select *  from IT_Scheme where SmStatus not in ('17','19') and ID not in ")
                strSB.Append("(select SchemeID from it_project_attention where userno='" & UserID & "' ) order by ID")
            Else '’导入本人项目()
                strSB.Append("select *  from IT_Scheme where SmStatus not in ('17','19') and SmFollow='" & UserID)
                strSB.Append("' and ID not in (select SchemeID from it_project_attention where userno='" & UserID & "' )  order by ID")
            End If

            dt = getDataTables(strSB.ToString())
            Grid1.DataSource = dt
            dt.Dispose()
            strSB.Clear()
        Catch ex As Exception
            MessageBox.Show("操作收发异常:" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub

    Private Sub rdbMy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbMy.CheckedChanged
        If rdbMy.Checked = True Then LoadProjectData(False)
    End Sub

    Private Sub rdbFull_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbFull.CheckedChanged
        If rdbFull.Checked = True Then LoadProjectData(True)
    End Sub

    Private Sub Grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick

        SaveDataNew()   '保存数据

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

    ''' <summary>
    ''' 保存新增数据
    ''' </summary>
    ''' <remarks></remarks>
    Sub SaveDataNew()

        Dim sql As String = Nothing

        sql = "INSERT INTO IT_Project_Attention (SchemeID,UserNo) Values (" _
            & "'" & GridView2.GetFocusedRowCellValue("ID") & "','" & UserID & "')"

        Try
            ExecuteNonQuery(sql)
            isRefresh = True
        Catch ex As Exception
            MessageBox.Show("操作收发异常:" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub

End Class