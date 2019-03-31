Public Class MyTaskOrToDO
    ''' <summary>
    ''' 取得个人指定月份所参与任务
    ''' </summary>
    ''' <param name="dt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function MyTask(ByVal dt As String, ByVal uID As String) As DataTable

        Dim strSB As New System.Text.StringBuilder
        Try
            strSB.Append("select distinct IT_Project.ID,IT_Assignment.PrjID,IT_Scheme.SchemeName,IT_Project.PrjName,IT_Assignment.AssName,")
            strSB.Append(" IT_Assignment.ActualStatDate,IT_Assignment.AchualEndDate,")
            strSB.Append(" (select ATL_HD_Emergency.Value from ATL_HD_Emergency where ATL_HD_Emergency.Value=IT_Assignment.Emergency) as priority,")
            strSB.Append(" (select SUM(IT_Schedule.CumulativeTime) from  IT_Schedule where IT_Schedule.AssID =IT_Assignment.ID) as TotalTime,")
            strSB.Append(" (select sum(IT_Schedule.FollowSch) from IT_Schedule where IT_Schedule.AssID =IT_Assignment.ID) as workComplete")
            strSB.Append(" from IT_Assignment, IT_Project, IT_Scheme where IT_Project.ID = IT_Assignment.PrjID  ")
            strSB.Append(" and IT_Assignment.AppointUid='" & uID & "'  And IT_Project.SchemeID = IT_Scheme.ID ")
            strSB.Append(" and (year(IT_Scheme.SmStartDate)=year('" & dt & "')  and month(IT_Scheme.SmEndDate)=month('" & dt & "')) ")
            strSB.Append(" order by IT_Project.ID ASC ")

            Return getDataTables(strSB.ToString())
        Catch
            Return Nothing
        End Try
        strSB.Clear()
    End Function

    ''' <summary>
    ''' 取得指定个人某月待办事项 
    ''' </summary>
    ''' <param name="uID"></param>
    ''' <param name="dt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function myToDo(ByVal uID As String, ByVal dt As String) As DataTable

        Dim strSB As New System.Text.StringBuilder

        strSB.Clear()

        Try
            strSB.Append("select *,")
            strSB.Append("(select IT_Scheme.SchemeName from IT_Scheme where IT_Scheme.ID=IT_ToDo.SchemeID) as SchemeName,")
            strSB.Append("(select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_ToDo.TD_Context) as ContextName ")
            strSB.Append("from IT_ToDo where TD_UserNo='" & uID & "' and year(CreatedTime)=year('" & dt & "-01') ")
            strSB.Append("and month(CreatedTime)=month('" & dt & "-01')  order by TD_ID DESC")

            Return getDataTables(strSB.ToString())
        Catch
            Return Nothing
        End Try
        strSB.Clear()
    End Function
End Class

