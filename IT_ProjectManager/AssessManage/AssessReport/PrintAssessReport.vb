Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports
Imports System.Data.SqlClient

Public Class PrintAssessReport

    Sub TextEditChange()
        Try
            If CrystalReportViewer1 IsNot Nothing AndAlso CrystalReportViewer1.ReportSource IsNot Nothing Then
                ' CrystalReportViewer1.ReportSource =
                YearMonth.Properties.Items.Clear()
                CrystalReportViewer1.ReportSource = Nothing
                ' Dim sql As String = "select distinct YearMonth from IT_PerformanceManage where UserNo='" & txtJob.EditValue & "' and  ProManagerComment<>''"
                Dim sql As String = "select distinct YearMonth from IT_PerformanceManage where UserNo='" & txtJob.EditValue & "' and  LeaderComment is not null"

                Dim dt As New DataTable
                dt = getDataTables(sql)
                YearMonth.Properties.Items.Clear()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1 Step 1
                        YearMonth.Properties.Items.Add(dt.Rows(i)("YearMonth"))
                    Next
                End If
                dt.Dispose()
            End If
        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' 取得人员信息
    ''' </summary>
    ''' <remarks>返回当前人员信息</remarks>
    Sub userInfo()

        Dim sql As String = "select distinct UserNo,UserName from IT_PerformanceManage "
        Dim dt As New DataTable
        dt = getDataTables(sql)
        If dt.Rows.Count > 0 Then
            txtJob.Properties.DataSource = dt
            txtJob.Properties.ValueMember = "UserNo"
            txtJob.Properties.DisplayMember = "UserName"
        End If

    End Sub

    ''' <summary>
    ''' 生成个人报表信息
    ''' </summary>
    ''' <remarks></remarks>
    Sub printReport()

        Dim rePortDoc As New AssessReport2

        Dim strSB As New System.Text.StringBuilder

        Dim dt As New DataTable

        Dim dst As New AssDataSet

        '' 待办事项
        strSB.Append("select TD_Name,CreatedTime,TD_CompleteDate from IT_ToDo where TD_UserNo='" & txtJob.EditValue & "'")
        strSB.Append(" and year(CreatedTime)=year('" & YearMonth.Text & "-01') and month(CreatedTime)=month('" & YearMonth.Text & "-01')")
        dt = getDataTables(strSB.ToString())

        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1 Step 1
                Dim rs = dst.Tables("IT_ToDo").NewRow
                rs("TD_Name") = dt.Rows(i)("TD_Name")
                rs("CreatedTime") = CDate(dt.Rows(i)("CreatedTime")).ToString("yyyy/MM/dd HH:mm:ss")
                If Not IsDBNull(dt.Rows(i)("TD_CompleteDate")) Then
                    rs("TD_CompleteDate") = CDate(dt.Rows(i)("TD_CompleteDate")).ToString("yyyy/MM/dd HH:mm:ss")
                End If

                dst.Tables("IT_ToDo").Rows.Add(rs)
            Next
        End If


        '' 项目模块
        strSB.Clear()
        strSB.Append("select distinct IT_Assignment.AssName,")
        strSB.Append("(select SUM(IT_Schedule.CumulativeTime) from  IT_Schedule where IT_Schedule.AssID =IT_Assignment.ID) as TotalTime")
        strSB.Append(" from  IT_Assignment")
        strSB.Append(" where  IT_Assignment.AppointUid='" & txtJob.EditValue & "'  ")
        strSB.Append(" and (year(IT_Assignment.PreStatDate)=year('" & YearMonth.Text & "-01')  and month(IT_Assignment.PreEndDate)=month('" & YearMonth.Text & "-01'))")
        dt.Clear()
        dt = getDataTables(strSB.ToString())
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1 Step 1
                Dim rs = dst.Tables("IT_Project").NewRow
                rs("AssName") = dt.Rows(i)("AssName")
                rs("TotalTime") = dt.Rows(i)("TotalTime")
                dst.Tables("IT_Project").Rows.Add(rs)
            Next
        End If


        '' 考核信息
        strSB.Clear()
        strSB.Append("select IT_PerformanceManage.*,IT_PeromanceGradeValue.LeaderGradeValue, ")
        strSB.Append("  IT_PeromanceGradeValue.ProManagerValue, IT_AssessStandard.ASS_Name, IT_AssessStandard.ASS_Remark ")
        strSB.Append("  from IT_PeromanceGradeValue, IT_PerformanceManage, IT_AssessStandard  ")
        strSB.Append(" where IT_PeromanceGradeValue.ASS_ID = IT_PerformanceManage.AutoID  ")
        strSB.Append(" and IT_PerformanceManage.UserNo='" & txtJob.EditValue & "' and IT_PerformanceManage.YearMonth='" & YearMonth.Text & "'")
        strSB.Append(" and IT_AssessStandard.ASS_ID=IT_PeromanceGradeValue.GS_ID ")
        strSB.Append(" and IT_AssessStandard.xtype='0'")

        dt = getDataTables(strSB.ToString())
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1 Step 1
                Dim rs = dst.Tables("LeaderManger").NewRow
                rs("UserNo") = dt.Rows(i)("UserNo")
                rs("UserName") = dt.Rows(i)("UserName")
                rs("YearMonth") = dt.Rows(i)("YearMonth")
                rs("IndividualReviews") = dt.Rows(i)("IndividualReviews")
                rs("LeaderComment") = dt.Rows(i)("LeaderComment")
                rs("LeaderGradeValue") = dt.Rows(i)("LeaderGradeValue")
                rs("ASS_Name") = dt.Rows(i)("ASS_Name")
                rs("ASS_Remark") = dt.Rows(i)("ASS_Remark")
                dst.Tables("LeaderManger").Rows.Add(rs)
            Next
        End If

        '' 项目经理
        strSB.Remove(strSB.Length - 31, 31)
        dt.Clear()
        strSB.Append(" and IT_AssessStandard.xtype='1'")
        dt = getDataTables(strSB.ToString())
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1 Step 1
                Dim rs = dst.Tables("PeromanceManger").NewRow
                rs("ProManagerComment") = dt.Rows(i)("ProManagerComment")
                rs("ProManagerValue") = dt.Rows(i)("ProManagerValue")
                rs("ASS_Name") = dt.Rows(i)("ASS_Name")
                rs("ASS_Remark") = dt.Rows(i)("ASS_Remark")
                dst.Tables("PeromanceManger").Rows.Add(rs)
            Next
        End If

        strSB.Clear()
        dt.Dispose()

        rePortDoc.Database.Tables("LeaderManger").SetDataSource(dst.Tables("LeaderManger"))
        rePortDoc.Database.Tables("PeromanceManger").SetDataSource(dst.Tables("PeromanceManger"))
        rePortDoc.Database.Tables("IT_Project").SetDataSource(dst.Tables("IT_Project"))
        rePortDoc.Database.Tables("IT_ToDo").SetDataSource(dst.Tables("IT_ToDo"))

        CrystalReportViewer1.ReportSource = rePortDoc
        CrystalReportViewer1.RefreshReport()

        dst.Clear()

    End Sub

    Private Sub AssessReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next


        Clearlb()

        userInfo()

        AddHandler txtJob.EditValueChanged, AddressOf TextEditChange

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        If Len(txtJob.Text.Trim) <= 0 Then
            txtJob.Focus()
            MessageBox.Show("请选择预览对象?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Len(YearMonth.Text.Trim()) <= 0 Then
            YearMonth.Focus()
            MessageBox.Show("请选择月份?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        printReport()
    End Sub

    Sub Clearlb()
        txtJob.Properties.DataSource = Nothing
        YearMonth.Properties.Items.Clear()
        Dim i As Integer = 0
        For i = 0 To 11
            YearMonth.Properties.Items.Add(Now.AddMonths(-i).ToString("yyyy-MM"))
        Next
        YearMonth.SelectedItem = 0
        CrystalReportViewer1.ReportSource = Nothing
    End Sub

    Private Sub GroupControl1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupControl1.Paint

    End Sub

   
    Private Sub PrintDocument2_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage

    End Sub
End Class
