
Imports System.Data
Imports System.Data.SqlClient

Public Class mdlDepartmentView

#Region "数据绑定"
    ''' <summary>
    ''' 导入所有项目
    ''' </summary>
    ''' <param name="StartDate"></param>
    ''' <param name="EndDate"></param>
    ''' <remarks></remarks>
    Sub LoadMyTasksMonth(ByVal StartDate As String, ByVal EndDate As String)

        On Error Resume Next
        Dim dt As New DataTable
        Dim strSB As New System.Text.StringBuilder

        GroupControl5.Text = "本月工作用时 [" & StartDate & "-" & EndDate & "]"
        StartDate = StartDate & " 00:00:00"
        EndDate = EndDate & " 23:59:59"

        strSB.Append("select SUM(cumulativetime) as CumulativeTime,followuid,")
        strSB.Append(" (select Username from ATL_HD_UserGroups where ATL_HD_UserGroups.UserNo=IT_Schedule.FollowUID and IsDimission=0 and isshow=1 ) as UserName")
        strSB.Append(" from IT_Schedule where FollowDate between '" & StartDate & "' and '" & EndDate & "'")
        strSB.Append(" group by followuid order by followuid")

        dt = getDataTables(strSB.ToString())

        If dt.Rows.Count > 0 Then
            ChartControl1.DataSource = dt
        Else
            ChartControl1.DataSource = Nothing
        End If

        dt.Dispose()
        strSB.Clear()

    End Sub

    ''' <summary>
    ''' 导入本月所有项目汇总，只显前10项目，其他合计
    ''' </summary>
    ''' <param name="StartDate"></param>
    ''' <param name="EndDate"></param>
    ''' <remarks></remarks>
    Sub LoadMyTasksMonth2(ByVal StartDate As String, ByVal EndDate As String)

        Dim lngCount As Long
        Dim dt As New DataTable
        Dim l As Integer
        On Error Resume Next
        GroupControl1.Text = "本月项目 [" & StartDate & "-" & EndDate & "]"
        StartDate = StartDate & " 00:00:00"
        EndDate = EndDate & " 23:59:59"

        Dim strSB As New System.Text.StringBuilder

        strSB.Append(" SELECT  SUM(IT_Schedule.CumulativeTime) AS CumulativeTime,IT_Scheme.SchemeName,IT_Scheme.ID ")
        strSB.Append(" FROM  IT_Schedule INNER JOIN  IT_Scheme INNER JOIN   IT_Assignment INNER JOIN ")
        strSB.Append(" IT_Project ON IT_Assignment.PrjID = IT_Project.ID ON IT_Scheme.ID=IT_Project.SchemeID ON ")
        strSB.Append(" IT_Schedule.AssID=IT_Assignment.ID   WHERE IT_Schedule.FollowDate between '" & StartDate & "' and '" & EndDate)
        strSB.Append("' GROUP BY IT_Scheme.ID,IT_Scheme.SchemeName order by CumulativeTime desc")

        dt = getDataTables(strSB.ToString())

        strSB.Clear()

        lngCount = dt.Rows.Count

        l = 0
        '清除旧数据
        dst.Tables(1).Clear()
        If lngCount > 0 Then
            For i As Integer = 0 To lngCount - 1
                l = l + 1
                If l <= 10 Then
                    Dim rs = dst.Tables(1).NewRow
                    rs("CreatedDate") = "[" & dt.Rows(i).Item("ID").ToString & "]" & dt.Rows(i).Item("SchemeName").ToString
                    rs("Value") = CLng(dt.Rows(i).Item("CumulativeTime").ToString)
                    dst.Tables(1).Rows.Add(rs)
                ElseIf l = 11 Then
                    Dim rs = dst.Tables(1).NewRow
                    rs("CreatedDate") = "其他"
                    rs("Value") = CLng(dt.Rows(i).Item("CumulativeTime").ToString)
                    dst.Tables(1).Rows.Add(rs)
                Else
                    dst.Tables(1).Rows(10).Item("Value") = CLng(dst.Tables(1).Rows(10).Item("Value") + CLng(dt.Rows(i).Item("CumulativeTime").ToString))
                End If
            Next
            dst.Tables(1).Rows(10).Item("CreatedDate") = "其他项目(" & (l - 10) & ")"
        End If
        dt.Dispose()

    End Sub

    ' ''' <summary>
    ' ''' 每日工作进度
    ' ''' </summary>
    ' ''' <param name="StartDate"></param>
    ' ''' <param name="EndDate"></param>
    ' ''' <remarks></remarks>
    'Sub LoadMyTasksMonth3(ByVal StartDate As String, ByVal EndDate As String)

    '    Dim lngCount As Long
    '    Dim dt As New DataTable

    '    GroupControl2.Text = "每日工作进度"
    '    StartDate = StartDate & " 00:00:00"
    '    EndDate = EndDate & " 23:59:59"

    '    Dim strSB As New System.Text.StringBuilder
    '    '旧SQL：只显示有回复进度人员
    '    'strSB.Append("select SUM(cumulativetime) as CumulativeTime,followuid,")
    '    'strSB.Append(" (select Username from ATL_HD_UserGroups where ATL_HD_UserGroups.UserNo=IT_Schedule.FollowUID ) as UserName ")
    '    'strSB.Append(" from IT_Schedule where FollowDate between '" & StartDate & "' and '" & EndDate & "'")
    '    'strSB.Append(" group by followuid order by followuid")
    '    '新SQL：显示所有回复和未回复人员
    '    strSB.Append("select  isNull((select SUM(cumulativetime) as CumulativeTime from IT_Schedule where FollowDate between  '" & StartDate & "' and '" & EndDate & "'")
    '    strSB.Append(" and IT_Schedule.followuid=IT_Assignment.AppointUid  group by followuid),0) as CumulativeTime")
    '    strSB.Append(",AppointUid as followuid, ")
    '    strSB.Append(" (select Username from ATL_HD_UserGroups where ATL_HD_UserGroups.UserNo=IT_Assignment.AppointUid ) as UserName ")
    '    strSB.Append(" from IT_Assignment where  PreStatDate < '" & EndDate & "' and ModifiedTime is null")
    '    strSB.Append(" and AppointUid in( select UserNo from dbo.ATL_HD_UserGroups where IsDimission ='0')")
    '    strSB.Append("  group by AppointUid ")

    '    dt = getDataTables(strSB.ToString())
    '        '清除旧有数据
    '    strSB.Clear()
    '    ' dt.Clear()
    '    lngCount = dt.Rows.Count

    '    If lngCount > 0 Then
    '        ChartControl3.DataSource = dt
    '    Else
    '        ChartControl3.DataSource = Nothing
    '        End If

    '    dt.Dispose()

    'End Sub


    Sub LoadMyTasksMonth3(ByVal StartDate As String, ByVal EndDate As String)
        Dim lngCount As Long
        Dim dt As New DataTable

        GroupControl2.Text = "每日工作进度"
        StartDate = StartDate & " 00:00:00"
        EndDate = EndDate & " 23:59:59"

        Dim strSB As New System.Text.StringBuilder
        '旧SQL：只显示有回复进度人员
        'strSB.Append("select SUM(cumulativetime) as CumulativeTime,followuid,")
        'strSB.Append(" (select Username from ATL_HD_UserGroups where ATL_HD_UserGroups.UserNo=IT_Schedule.FollowUID ) as UserName ")
        'strSB.Append(" from IT_Schedule where FollowDate between '" & StartDate & "' and '" & EndDate & "'")
        'strSB.Append(" group by followuid order by followuid")
        '新SQL：显示所有回复和未回复人员
        strSB.Append(" select b.UserNo as appointUid ,c.CumulativeTime,b.UserName   from ATL_HD_UserGroups b left join (")
        strSB.Append(" select * from( ")
        strSB.Append("select  IT_Assignment.AppointUid,isNull((select SUM(cumulativetime) as CumulativeTime from IT_Schedule where FollowDate between  '" & StartDate & "' and '" & EndDate & "'")
        strSB.Append(" and IT_Schedule.followuid=IT_Assignment.AppointUid  group by followuid),0) as CumulativeTime,")
        ' strSB.Append(",AppointUid as followuid, ")
        strSB.Append(" (select Username from ATL_HD_UserGroups where ATL_HD_UserGroups.UserNo=IT_Assignment.AppointUid and IsDimission=0 and isshow=1) as UserName ")
        strSB.Append(" from IT_Assignment where  PreStatDate < '" & EndDate & "' and ModifiedTime is null")
        strSB.Append(" and AppointUid in(select UserNo from IT_PersonnelGroups where isMustEnter =1)")
        strSB.Append("  group by AppointUid ")
        strSB.Append(") a where  a.UserName is not null ) c   on b.userno=c.appointUid where  IsDimission=0 and isshow=1")
        dt = getDataTables(strSB.ToString())
        '清除旧有数据
        strSB.Clear()

        ''载入待办事项目记录--------------------------------------------------
        Dim dt1 As New DataTable
        strSB.Append("  select  COUNT(*) AS CumulativeTime,")
        strSB.Append(" (select distinct UserName  from IT_PersonnelGroups where UserNo=IT_ToDo.TD_UserNo ) as UserName")
        strSB.Append(" from IT_ToDo")
        strSB.Append(" where TD_CompleteDate  between  '" & StartDate & "' and '" & EndDate & "' ")
        strSB.Append("and  TD_UserNo in( select UserNo from IT_PersonnelGroups where isMustEnter =1) GROUP BY TD_UserNo ")

        dt1 = getDataTables(strSB.ToString())
        strSB.Clear()
        '清除旧有数据
        Dim DS As New DataSet
        dt.TableName = "T1"
        DS.Tables.Add(dt)
        dt1.TableName = "T2"
        DS.Tables.Add(dt1)

        ChartControl3.DataSource = DS
        lngCount = dt.Rows.Count
        dt.Dispose()
    End Sub

    Private Sub mdlDepartmentView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpDate.Value = Now

        If Date.Now.ToString("HH:dd") > "18:00" Then
            DateEdit1.DateTime = Date.Now
        Else
            DateEdit1.DateTime = Date.Now.AddDays(-1)
        End If

        LoadMyTasksMonth(Format(Now, "yyyy-MM") & "-1", Format(DateAdd("d", -1, CDate(Format(DateAdd("M", 1, Now), "yyyy-MM") & "-1")), "yyyy-MM-dd"))
        LoadMyTasksMonth2(Format(Now, "yyyy-MM") & "-1", Format(DateAdd("d", -1, CDate(Format(DateAdd("M", 1, Now), "yyyy-MM") & "-1")), "yyyy-MM-dd"))
        LoadMyTasksMonth3(Format(DateEdit1.DateTime, "yyyy-MM-dd"), Format(DateEdit1.DateTime, "yyyy-MM-dd"))
        LoadGrade(Format(Now, "yyyy-MM") & "-1", Format(DateAdd("d", -1, CDate(Format(DateAdd("M", 1, Now), "yyyy-MM") & "-1")), "yyyy-MM-dd"))
        '' 为editvaluechanged绑定一个事件,避免dateedit editvaluechanged事件触发时重复加载数据
        AddHandler DateEdit1.EditValueChanged, AddressOf DateEdit1EditValueChanged

    End Sub

    ''' <summary>
    ''' 导入评分
    ''' </summary>
    ''' <param name="StartDate"></param>
    ''' <param name="EndDate"></param>
    ''' <remarks></remarks>
    Sub LoadGrade(ByVal StartDate As String, ByVal EndDate As String)

        Dim lngCount As Long
        Dim dt As New DataTable
        Dim l As Long

        '' On Error Resume Next

        StartDate = StartDate & " 00:00:00"
        EndDate = EndDate & " 23:59:59"

        Dim strSB As New System.Text.StringBuilder

        strSB.Append(" SELECT ATL_HD_UserGroups.UserName, ")
        strSB.Append(" SUM(dbo.IT_Assignment.AssGrade) AS AssGrade,")
        strSB.Append(" COUNT(dbo.IT_Assignment.id) as AssCount, dbo.ATL_HD_UserGroups.UserNo ")
        strSB.Append(" FROM  dbo.IT_Assignment INNER JOIN dbo.ATL_HD_UserGroups ON dbo.IT_Assignment.AppointUid = dbo.ATL_HD_UserGroups.UserNo ")
        strSB.Append(" WHERE(Not (dbo.IT_Assignment.AssGrade Is NULL) and IsDimission=0 and isshow=1 and  IT_Assignment.AchualEndDate between '" & StartDate)
        strSB.Append("' and '" & EndDate & "')  GROUP BY dbo.ATL_HD_UserGroups.UserNo, dbo.ATL_HD_UserGroups.UserName ")
        strSB.Append(" order by AssGrade desc")

        dt = getDataTables(strSB.ToString())

        dst.Tables(3).Rows.Clear()

        lngCount = dt.Rows.Count

        l = 0

        If lngCount > 0 Then

            For i As Integer = 0 To lngCount - 1

                Dim rs = dst.Tables(3).NewRow

                rs("UserName") = dt.Rows(i).Item("UserName").ToString

                rs("Value") = Math.Round(CSng(dt.Rows(i).Item("AssGrade").ToString) / CSng(dt.Rows(i).Item("AssCount").ToString), 2)

                dst.Tables(3).Rows.Add(rs)
            Next

        End If

        dt.Dispose()


    End Sub
#End Region

    Private Sub DateEdit1EditValueChanged()
        LoadMyTasksMonth3(Format(DateEdit1.DateTime, "yyyy-MM-dd"), Format(DateEdit1.DateTime, "yyyy-MM-dd"))
    End Sub
    ''取得当天任务信息
    Private Sub ChartControl3_ObjectSelected(ByVal sender As System.Object, ByVal e As DevExpress.XtraCharts.HotTrackEventArgs)

        On Error Resume Next

        If e.HitInfo.SeriesPoint.Argument = Nothing Then Exit Sub

        If e.HitInfo.Series.ToString = Nothing Then Exit Sub

        Select Case e.HitInfo.Series.ToString
            Case "Series 4"
                Dim frm As New myTaskDay
                Dim day As String = DateEdit1.Text.Trim()
                Dim name As String = e.HitInfo.SeriesPoint.Argument

                If day = "" Or name = "" Then
                    MessageBox.Show("获取个人日工作明细失败?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                frm.tempDay = day
                frm.tempUname = name
                frm.ShowDialog()
        End Select

    End Sub







    Private Sub dtpDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDate.ValueChanged
        On Error Resume Next
        '依选择的月份导入每月项目汇总
        LoadMyTasksMonth2(Format(CDate(dtpDate.Value), "yyyy-MM") & "-1", Format(DateAdd("d", -1, CDate(Format(DateAdd("M", 1, CDate(dtpDate.Value)), "yyyy-MM") & "-1")), "yyyy-MM-dd"))

    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Timer4.Enabled = False
        '' 定时刷新数据
        mdlDepartmentView_Load(Nothing, Nothing)
        Threading.Thread.Sleep(1000)
        Timer4.Enabled = True

    End Sub

    Private Sub ChartControl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChartControl2.Click

    End Sub

    Private Sub GroupControl2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupControl2.Paint

    End Sub
End Class
