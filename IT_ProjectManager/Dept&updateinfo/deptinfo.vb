Imports DevExpress.XtraEditors.Repository
Imports System.Data
Imports System.Linq
Imports System.Data.SqlClient

Public Class deptinfo

    Private Sub GridControl1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        bindgrid()

    End Sub

    Private Sub bindgrid()
        GridControl1.DataSource = DbServices.DbHelperSQL.Query(String.Format("SELECT rowID,CompanyNo ,deptno ,deptname,create_by,create_time,update_by ,update_time FROM   IT_DeptInfo order by create_time ")).Tables(0)
        Dim lookedit As RepositoryItemLookUpEdit = DirectCast(Me.GridView1.Columns(0).ColumnEdit, RepositoryItemLookUpEdit)
        lookedit.DataSource = DbServices.DbHelperSQL.Query(String.Format("select  ID,CompanyNo,CompanyName  from dbo.ATL_HD_Company")).Tables(0)
    End Sub

    Private Sub pupAddSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pupAddSub.Click
        GridView1.AddNewRow()
        GridView1.GetFocusedDataRow()(1) = ""

    End Sub

    Private Sub pupDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pupDel.Click
        If MessageBox.Show("您确定删除当前选中的行吗?", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            GridView1.DeleteRow(GridView1.FocusedRowHandle)
        End If
    End Sub

    Private Sub pupProjectDetail_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles pupProjectDetail.Opening

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        Dim dv As DataView = DirectCast(Me.GridView1.DataSource, DataView)
        Dim xml As String = "<rds>"
        Dim dr As DataRowView




        For Each dr In dv
            If dr.Row.RowState = DataRowState.Added Then
                xml = xml & "<rd  operation=""new"" rowID="""" CompanyNo=""" & dr("CompanyNo") &
                            """  deptno=""" & dr("deptno") & """  deptname=""" & dr("deptname") &
                            """/>"

            End If
            If dr.Row.RowState = DataRowState.Modified Then
                xml = xml & "<rd   operation=""modi""  rowID=""" & dr("rowID").ToString() & """ CompanyNo=""" & dr("CompanyNo") &
                            """  deptno=""" & dr("deptno") & """ deptname=""" & dr("deptname") &
                            """/>"

            End If
        Next

        dv.RowStateFilter = DataViewRowState.Deleted

        For Each dr In dv
            xml = xml & "<rd   operation=""del""  rowID=""" & dr("rowID").ToString() & """ CompanyNo=""" & dr("CompanyNo") &
                         """  deptno=""" & dr("deptno") & """ deptname=""" & dr("deptname") &
                         """/>"


        Next
        xml = xml & "</rds>"
        dv.RowStateFilter = DataViewRowState.CurrentRows
        Dim params() As SqlParameter = {
                 New SqlParameter("@xml", xml),
                 New SqlParameter("@username", UserName),
                 New SqlParameter("@msg", SqlDbType.NChar, 100)
               }
        params(2).Direction = ParameterDirection.Output
        Try
            DbServices.DbHelperSQL.RunProcedure("updatetdeptinfo", params)
            MessageBox.Show(params(2).Value, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If params(2).Value.ToString().Trim() = "更新成功" Then
                bindgrid()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub uploadData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uploadData.Click
        bindgrid()
    End Sub
End Class
