Public Class myTaskDay
    Public tempUname As String
    Public tempDay As String
    Private Sub myTaskDay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadMyTaskDay(tempUname, tempDay)
    End Sub
    ''' <summary>
    ''' 取得个人日工作明细
    ''' </summary>
    ''' <param name="uName"></param>
    ''' <param name="day"></param>
    ''' <remarks></remarks>
    Sub loadMyTaskDay(ByVal uName As String, ByVal day As String)

        Dim strSB As New System.Text.StringBuilder
        strSB.Append("SELECT CumulativeTime,FollowSch,Remark,")
        strSB.Append("(select PrjName from IT_Project where IT_Project.ID=(select PrjID from IT_Assignment where IT_Assignment.ID=IT_Schedule.AssID)) AS PrjName,")
        strSB.Append("(select AssName from IT_Assignment where IT_Assignment.ID=IT_Schedule.AssID) AS AssName,")
        strSB.Append("(select TaskDetail from  IT_Assignment where IT_Assignment.ID=IT_Schedule.AssID) AS TaskDetail ")
        strSB.Append(" FROM IT_Schedule ")
        strSB.Append(" where FollowDate between '" & day & " 00:00:00' and '" & day & " 23:59:59'")
        strSB.Append(" and FollowUID=(select UserNo from ATL_HD_UserGroups where ATL_HD_UserGroups.UserName='" & uName & "')")

        Dim dt As New DataTable
        dt = getDataTables(strSB.ToString())
        strSB.Clear()
        If dt.Rows.Count > 0 Then
            MyTask.DataSource = dt
        Else
            MyTask.DataSource = Nothing
        End If

        dt.Dispose()

    End Sub

    Private Sub GridView1_EndGrouping(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.EndGrouping
        GridView1.ExpandAllGroups()
    End Sub

End Class