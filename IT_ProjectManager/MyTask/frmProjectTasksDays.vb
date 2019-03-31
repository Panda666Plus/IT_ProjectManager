Public Class frmProjectTasksDays

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub frmProjectTasksDays_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'sql = "SELECT dbo.IT_Scheme.SchemeName, dbo.IT_Project.PrjName, dbo.IT_Assignment.AssName, dbo.IT_Schedule.ID, dbo.IT_Schedule.Remark," _
        '    & "dbo.IT_Schedule.CumulativeTime, dbo.IT_Schedule.FollowSch, dbo.IT_Schedule.FollowUID, dbo.IT_Schedule.FollowDate " _
        '    & "FROM dbo.IT_Project INNER JOIN dbo.IT_Scheme ON dbo.IT_Project.SchemeID = dbo.IT_Scheme.ID INNER JOIN " _
        '    & "dbo.IT_Assignment ON dbo.IT_Project.ID = dbo.IT_Assignment.PrjID INNER JOIN " _
        '    & "dbo.IT_Schedule ON dbo.IT_Assignment.ID = dbo.IT_Schedule.AssID where dbo.IT_Schedule.FollowUID='0110746' and  dbo.IT_Schedule.FollowDate='2010-1-1'"

        LoadMyDaysTasks(UserID, CDate(txtDate.Text))

    End Sub

    ''' <summary>
    ''' 导入当日资料
    ''' </summary>
    ''' <param name="strUserID"></param>
    ''' <param name="dteDate"></param>
    ''' <remarks></remarks>
    Sub LoadMyDaysTasks(ByVal strUserID As String, ByVal dteDate As DateTime)


        Dim dt As New DataTable
        Dim StartDateTime As String
        Dim EndDateTime As String
        StartDateTime = Format(dteDate, "yyyy-MM-dd") & " 00:00:00"
        EndDateTime = Format(dteDate, "yyyy-MM-dd") & " 23:59:59"
        Dim strSB As New System.Text.StringBuilder
        'sql = "select *,(select V_IT_Project.Progress from V_IT_Project where V_IT_Project.ID=IT_Project.ID) as workComplete ,(select ProStatus from IT_ProStatus where IT_Project.PrjStatus=IT_ProStatus.ID ) as PrjStatusName,(select SchemeName from IT_Scheme where IT_Project.SchemeID=IT_Scheme.ID) as SchemeName from IT_Project  where FollowUID='" & UserID & "' and PrjStatus <>'27' order by FollowUID"
        strSB.Append("SELECT dbo.IT_Scheme.SchemeName, dbo.IT_Project.PrjName, dbo.IT_Assignment.AssName, dbo.IT_Schedule.ID, dbo.IT_Schedule.Remark,")
        strSB.Append(" dbo.IT_Schedule.CumulativeTime, dbo.IT_Schedule.FollowSch, dbo.IT_Schedule.FollowUID, dbo.IT_Schedule.FollowDate ")
        strSB.Append(" FROM dbo.IT_Project INNER JOIN dbo.IT_Scheme ON dbo.IT_Project.SchemeID = dbo.IT_Scheme.ID INNER JOIN ")
        strSB.Append(" dbo.IT_Assignment ON dbo.IT_Project.ID = dbo.IT_Assignment.PrjID INNER JOIN ")
        strSB.Append(" dbo.IT_Schedule ON dbo.IT_Assignment.ID = dbo.IT_Schedule.AssID where ")
        strSB.Append(" dbo.IT_Schedule.FollowUID='" & strUserID & "' and  dbo.IT_Schedule.FollowDate between '" & StartDateTime & "' and '" & EndDateTime & "'")

        dt = getDataTables(strSB.ToString())
        strSB.Clear()
        GridMyTasks.DataSource = dt
        dt.Dispose()

    End Sub

    Private Sub GridView1_EndGrouping(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.EndGrouping

        GridView1.ExpandAllGroups()

    End Sub

End Class