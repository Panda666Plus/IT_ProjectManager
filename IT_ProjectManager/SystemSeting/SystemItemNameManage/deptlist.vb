Public Class deptlist
    Private Sub bindgrid()
        Me.GridControl1.DataSource =
            DbServices.DbHelperSQL.Query("SELECT cast(0 as bit) sel, b.CompanyName,a.deptno,a.deptname from dbo.IT_DeptInfo a inner join dbo.ATL_HD_Company b on a.CompanyNo=b.CompanyNo ").Tables(0)
    End Sub

    Private Sub deptlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bindgrid()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Public s As String = ""
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Me.GridView1.CloseEditor()
        s = ""
        For Each i As DataRowView In DirectCast(GridView1.DataSource, DataView)
            If (i("sel") = True) Then
                s = s & i("deptname") & ","
            End If
        Next
        If s.Length > 0 Then
            s = s.Substring(0, s.Length - 1)
        End If
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class