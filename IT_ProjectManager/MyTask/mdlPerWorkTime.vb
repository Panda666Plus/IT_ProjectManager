Imports System.Data
Imports System.Data.SqlClient

Public Class mdlPerWorkTime

    Dim td1 As Threading.Thread = Nothing

    Dim td2 As Threading.Thread = Nothing

#Region "线程加载数据"

    ''' <summary>
    ''' 导入用户当月工作时间
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadMyTasksMonth()

        Dim dt As New DataTable
        Dim strSB As New System.Text.StringBuilder

        Dim StartDate As String = Format(DateAdd("d", -30, Now), "yyyy-MM-dd") & " 00:00:00"
        Dim EndDate As String = Format(Now, "yyyy-MM-dd") & " 23:59:59"


        strSB.Append("select convert(varchar(100),FollowDate,23)as CreatedDate,")
        strSB.Append(" SUM(CumulativeTime)as Value from IT_Schedule where FollowUID='")
        strSB.Append(UserID & "'  and FollowDate between '" & StartDate & "' and '" & EndDate)
        strSB.Append("'  group by  convert(varchar(100),FollowDate,23) order by CreatedDate")

        dt = getDataTables(strSB.ToString())

        Try

            SetDataSet = New SetDataSetDelegate(AddressOf Me.bindingDataset)

            Me.Invoke(SetDataSet, dst.Tables(0), dt)

            dt.Dispose()

        Catch ex As Exception
            'MessageBox.Show("委托引发以下异常：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ''td1.Join()
            td1.Abort()
        End Try

        strSB.Clear()

    End Sub

    ''' <summary>
    ''' 导入用户当月工作时间
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadMyToDoMonth()

        Dim dt As New DataTable
        Dim strSB As New System.Text.StringBuilder

        Dim StartDate As String = Format(DateAdd("d", -30, Now), "yyyy-MM-dd") & " 00:00:00"

        Dim EndDate As String = Format(Now, "yyyy-MM-dd") & " 23:59:59"

        strSB.Append("select convert(varchar(100),TD_CompleteDate,23)as CreatedDate,")
        strSB.Append(" Count(TD_ID)as Value from IT_ToDo where TD_UserNo='")
        strSB.Append(UserID & "'  and TD_Complete=1 and TD_CompleteDate between '" & StartDate)
        strSB.Append("' and '" & EndDate & "'  group by  convert(varchar(100),TD_CompleteDate,23) order by CreatedDate")

        dt = getDataTables(strSB.ToString())

        Try

            SetDataSet = New SetDataSetDelegate(AddressOf Me.bindingDataset)

            Me.Invoke(SetDataSet, dst.Tables(1), dt)

            dt.Dispose()

        Catch ex As Exception
            ' MessageBox.Show("委托引发以下异常：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ''td2.Join()
            td2.Abort()
        End Try
        strSB.Clear()
    End Sub

    ''' <summary>
    ''' 利用委托方法执行传值
    ''' </summary>
    ''' <param name="ds">DataSet数据集合</param>
    ''' <param name="dt">DataTable数据集合</param>
    ''' <remarks></remarks>
    Sub bindingDataset(ByVal ds As DataTable, ByVal dt As DataTable)

        Try

            For i = 0 To dt.Rows.Count - 1 Step 1

                Dim rs = ds.NewRow
                rs("CreatedDate") = CDate(dt.Rows(i).Item("CreatedDate").ToString)
                rs("Value") = CLng(dt.Rows(i).Item("Value").ToString)
                ds.Rows.Add(rs)

            Next

            dt.Dispose()

        Catch ex As Exception
            'MessageBox.Show("委托引发以下异常：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

    Private Sub mdlPerWorkTime_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Application.DoEvents()

        dst.Tables(0).Clear()
        dst.Tables(1).Clear()

        td1 = New Threading.Thread(AddressOf LoadMyTasksMonth)
        td1.Start()
        Threading.Thread.Sleep(10)

        td2 = New Threading.Thread(AddressOf LoadMyToDoMonth)
        td2.Start()
        Threading.Thread.Sleep(10)

    End Sub

    Private Sub ChartControl1_ObjectSelected(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.HotTrackEventArgs) Handles ChartControl1.ObjectSelected

        On Error Resume Next

        If e.HitInfo.SeriesPoint.Argument = Nothing Then Exit Sub

        If e.HitInfo.Series.ToString = Nothing Then Exit Sub

        Select Case e.HitInfo.Series.ToString
            Case "Project"
                Dim frm As New frmProjectTasksDays
                frm.txtDate.Text = CDate(e.HitInfo.SeriesPoint.Argument)
                frm.ShowDialog()
            Case "ToDo"
                Dim frm As New frmProjectTasksToDo
                frm.txtDate.Text = CDate(e.HitInfo.SeriesPoint.Argument)
                frm.ShowDialog()
        End Select

    End Sub

End Class
