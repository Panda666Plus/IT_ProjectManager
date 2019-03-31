Imports System.Data
Imports System.Data.SqlClient

Public Class mdlPerContent


    ''' <summary>
    ''' 导入评分
    ''' </summary>
    ''' <param name="strUserNo"></param>
    ''' <param name="StartDate"></param>
    ''' <param name="EndDate"></param>
    ''' <remarks></remarks>
    Sub LoadGrade(ByVal strUserNo As String, ByVal StartDate As String, ByVal EndDate As String)
        On Error Resume Next
        Dim lngCount As Long
        Dim dt As New DataTable
        Dim strSB As New System.Text.StringBuilder
        StartDate = StartDate & " 00:00:00"
        EndDate = EndDate & " 23:59:59"
        '显示详细打分项目
        'sql = "select  *,(select PrjName from IT_Project  where IT_Project.ID =IT_Assignment.PrjID) as PrjName,(select (select SchemeName from IT_Scheme where IT_Project.SchemeID =IT_Scheme.ID) as SchemeName from IT_Project  where IT_Project.ID =IT_Assignment.PrjID) as SchemeName,(select SUM(IT_Schedule.FollowSch) from IT_Schedule where IT_Schedule.AssID =IT_Assignment.ID) as workComplete from  it_assignment where appointuid='" & UserID & "' and AssState not in ('27')"
        strSB.Append("SELECTSUM(IT_Schedule.CumulativeTime) AS SumTime, IT_Scheme.SchemeName,IT_Scheme.ID ")
        strSB.Append("FROM  IT_Scheme INNER JOIN IT_Project ON dbo.IT_Scheme.ID = dbo.IT_Project.SchemeID INNER JOIN ")
        strSB.Append("IT_Assignment ON dbo.IT_Project.ID = dbo.IT_Assignment.PrjID INNER JOIN IT_Schedule ON IT_Assignment.ID = IT_Schedule.AssID ")
        strSB.Append("WHERE (IT_Schedule.FollowDate BETWEEN '" & StartDate & "' AND '" & EndDate & "') AND (IT_Schedule.FollowUID = N'" & strUserNo & "') ")
        strSB.Append("GROUP BY dbo.IT_Scheme.SchemeName,IT_Scheme.ID")

        dt = getDataTables(strSB.ToString())

        lngCount = dt.Rows.Count

        If lngCount > 0 Then
            For i As Integer = 0 To lngCount - 1
                Dim rs = dst.Tables("GS").NewRow
                rs("Name") = "[" & dt.Rows(i).Item("ID").ToString & "]" & dt.Rows(i).Item("SchemeName").ToString
                rs("Value") = CLng(dt.Rows(i).Item("SumTime").ToString)
                dst.Tables("GS").Rows.Add(rs)
            Next

        End If

        dt.Dispose()
        strSB.Clear()

    End Sub

    Private Sub mdlPerContent_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        LoadGrade(UserID, Format(Now, "yyyy-MM") & "-1", Format(DateAdd("d", -1, CDate(Format(DateAdd("M", 1, Now), "yyyy-MM") & "-1")), "yyyy-MM-dd"))
    End Sub
End Class
