Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports
Imports System.Data.SqlClient

Public Class AssessReport

    Private Sub txtJob_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtJob.EditValueChanged

    End Sub
    Sub printReport()
        Dim ReportDoc As New ReportDocument
        '' Dim logonInfo As New TableLogOnInfo
        Dim path As String = Application.StartupPath & "\Report\AssReport.rpt"
        If Not System.IO.File.Exists(path) Then Exit Sub
        Dim strSB As New System.Text.StringBuilder
        'strSB.Append("Select distinct")
        'strSB.Append(" IT_PerformanceManage.UserNo,IT_PerformanceManage.UserName,IT_PerformanceManage.YearMonth,")
        'strSB.Append(" IT_Scheme.SchemeName,")
        'strSB.Append(" IT_PerformanceManage.IndividualReviews,IT_PerformanceManage.LeaderComment,IT_PerformanceManage.ProManagerComment,")
        'strSB.Append(" IT_PeromanceGradeValue.LeaderGradeValue,IT_PeromanceGradeValue.ProManagerValue,IT_AssessStandard.ASS_NAME")

        'strSB.Append(" from IT_Assignment, IT_Scheme, IT_PerformanceManage")
        'strSB.Append(" ,IT_PeromanceGradeValue,IT_AssessStandard")

        'strSB.Append(" where IT_Assignment.AppointUid='13041012'  ")
        'strSB.Append(" and (year(IT_Scheme.SmStartDate)=year('2013-11-01')  and month(IT_Scheme.SmEndDate)=month('2013-11-01'))")
        'strSB.Append(" and IT_PerformanceManage.UserNo=IT_Assignment.AppointUid")
        'strSB.Append(" and IT_PerformanceManage.YearMonth='2013-11'")
        'strSB.Append(" and IT_PeromanceGradeValue.ASS_ID=IT_PerformanceManage.AutoID")
        'strSB.Append(" and IT_AssessStandard.ASS_ID=IT_PeromanceGradeValue.GS_ID")

        Dim ds As New DataSet
        Dim conn As SqlConnection
        Dim da As SqlDataAdapter
        conn = New SqlConnection
        conn.ConnectionString = ConnStr
        conn.Open()



        '' 待辦事項
        strSB.Append("select TD_Name from IT_ToDo where TD_UserNo='13041012'")
        strSB.Append(" and year(CreatedTime)=year('2013-09-01') and month(CreatedTime)=month('2013-09-01')")

        da = New SqlDataAdapter(strSB.ToString(), conn)
        da.Fill(ds, "IT_ToDo")

        '' 項目模塊
        strSB.Clear()
        strSB.Append("select distinct IT_Project.PrjName,")
        strSB.Append("(select SUM(IT_Schedule.CumulativeTime) from  IT_Schedule where IT_Schedule.AssID =IT_Assignment.ID) as TotalTime")
        strSB.Append(" from  IT_Assignment, IT_Project, IT_Scheme ")
        strSB.Append(" where IT_Project.ID = IT_Assignment.PrjID  and IT_Assignment.AppointUid='13041012' And IT_Project.SchemeID = IT_Scheme.ID   ")
        strSB.Append(" and (year(IT_Scheme.SmStartDate)=year('2013-11-01')  and month(IT_Scheme.SmEndDate)=month('2013-11-01'))  ")

        da = New SqlDataAdapter(strSB.ToString(), conn)
        da.Fill(ds, "IT_Scheme")

        '' 考核信息
        strSB.Clear()
        strSB.Append("select IT_PeromanceGradeValue.GS_ID,IT_PeromanceGradeValue.LeaderGradeValue, ")
        strSB.Append("  IT_PeromanceGradeValue.ProManagerValue, IT_AssessStandard.ASS_Name, IT_AssessStandard.ASS_Remark ")
        strSB.Append("  from IT_PeromanceGradeValue, IT_PerformanceManage, IT_AssessStandard ")
        strSB.Append(" where IT_PeromanceGradeValue.ASS_ID = IT_PerformanceManage.AutoID ")
        strSB.Append(" and IT_PerformanceManage.UserNo='13041012' and IT_PerformanceManage.YearMonth='2013-11'")
        strSB.Append(" and IT_AssessStandard.ASS_ID=IT_PeromanceGradeValue.GS_ID ")

        da = New SqlDataAdapter(strSB.ToString(), conn)
        da.Fill(ds, "IT_PerformanceManage")

        strSB.Clear()
        da.Dispose()
        conn.Close()

        '加载你事先做好的Crystal Report报表文件
        ReportDoc.Load(path)
        '设置报表源
        CrystalReportViewer1.ReportSource = ReportDoc
        '表示一个报表，并且包含定义、格式化、加载、导出和打印该报表的属性和方法。

        '报表依据的显示的表 设定显示的table，dt为DataTable，也可以为ds.Tables(0)
        ReportDoc.SetDataSource(ds)
        '控件加载报表，并显示
        CrystalReportViewer1.ReportSource = ReportDoc


    End Sub

    Sub getData()

    End Sub

    Private Sub AssessReport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        printReport()
    End Sub
End Class
