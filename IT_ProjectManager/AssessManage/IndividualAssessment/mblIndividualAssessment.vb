Public Class mblIndividualAssessment

    Dim isEdit As Boolean = False

    Dim myInfo As New MyTaskOrToDO

    Private Sub mblIndividualAssessment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearData()
        loadYearMonth()
    End Sub
    ''' <summary>
    ''' 清空数据
    ''' </summary>
    ''' <remarks></remarks>
    Sub ClearData()

        MEassessment.Enabled = True
        MEassessment.Text = String.Empty
        SplitContainerControl2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        btSave.Visible = True
        btSave.Text = "确认"
        isEdit = False
        LabelControl1.Visible = False
        Panel1.Visible = False
        PictureBox1.Enabled = False
        PictureBox2.Enabled = False
        OvalShape1.FillColor = Color.MediumSlateBlue
        OvalShape1.BackColor = Color.MediumSlateBlue
        OvalShape1.SelectionColor = Color.MediumSlateBlue
        OvalShape2.FillColor = Color.MediumSlateBlue
        OvalShape2.BackColor = Color.MediumSlateBlue
        OvalShape2.SelectionColor = Color.MediumSlateBlue
        OvalShape3.FillColor = Color.MediumSlateBlue
        OvalShape3.BackColor = Color.MediumSlateBlue
        OvalShape3.SelectionColor = Color.MediumSlateBlue
    End Sub

    ''' <summary>
    ''' 加载年月
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadYearMonth()

        Dim sql As String = Nothing

        Dim l As Integer

        Dim i As Integer

        Dim tempdt As String = DateTime.Now.ToString("yyyy-MM")

        sql = "select YearMonth from IT_PerformanceManage where UserNo='" & UserID & "' and UserName='" & UserName & "'"

        Dim dt As New DataTable

        dt = getDataTables(sql)

        l = dt.Rows.Count

        YearMonthList.Items.Clear()

        If l > 0 Then

            Dim tDT As String = dt.Rows(i)("YearMonth").ToString()

            '' 计算之间相差几个月
            Dim df As Integer = DateDiff("m", tDT, Date.Now)

            For II As Integer = 0 To df Step 1
                YearMonthList.Items.Add(CDate(tDT).AddMonths(II).ToString("yyyy-MM"))
            Next

        Else
            '' 增加固定值
            Dim df As Integer = DateDiff("m", "2013-05", Date.Now)

            For II As Integer = 0 To df Step 1
                YearMonthList.Items.Add(CDate("2013-05").AddMonths(II).ToString("yyyy-MM"))
            Next
        End If

    End Sub

    ''' <summary>
    ''' 加载个有项目
    ''' </summary>
    ''' <param name="de">查询年月</param>
    ''' <remarks></remarks>
    Sub loadMyProject(ByVal de As String)

        Dim dt As New DataTable

        dt = myInfo.MyTask(de, UserID)

        Try
            If dt.Rows.Count > 0 Then
                MyTask.DataSource = dt
                SplitContainerControl2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
            Else
                MyTask.DataSource = Nothing
                SplitContainerControl2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            End If
        Catch

        End Try

        dt.Dispose()

    End Sub
    ''' <summary>
    ''' 个人待办事项
    ''' </summary>
    ''' <param name="de"></param>
    ''' <remarks></remarks>
    Sub loadMyToDo(ByVal de As String)

        Dim dt As New DataTable

        dt = myInfo.myToDo(UserID, de)

        Try

            If dt.Rows.Count > 0 Then
                GridMyToDo.DataSource = dt
            Else
                GridMyToDo.DataSource = Nothing
            End If

        Catch

        End Try

        dt.Dispose()

    End Sub

    ''' <summary>
    ''' 加载个人自评信息
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadMyAssess(ByVal dt As String)

        Dim sql As String = Nothing

        sql = "select IndividualReviews,LeaderComment,ProManagerComment from IT_PerformanceManage " &
              " where YearMonth='" & dt & "' and UserNo='" & UserID & "'"

        Dim d As New DataTable

        d = getDataTables(sql)

        Try

            If d.Rows.Count > 0 Then

                Panel1.Visible = True
                LabelControl1.Visible = True
                If Not d.Rows(0)("IndividualReviews") Is DBNull.Value Then
                    btSave.Text = "修改"
                    isEdit = True
                    OvalShape1.FillColor = Color.Lime
                    OvalShape1.BackColor = Color.Lime
                    OvalShape1.SelectionColor = Color.Lime
                    PictureBox1.Enabled = True
                    GroupControl1.Text = "个人[" & Strings.Left(dt, 7) & "]自评"
                    MEassessment.Text = d.Rows(0)("IndividualReviews")
                Else
                    GroupControl1.Text = "在此处写入个人[" & Strings.Left(dt, 6) & "]自评"
                    btSave.Text = "保存"
                End If


                If Not d.Rows(0)("LeaderComment") Is DBNull.Value Then
                    '' 禁止修改,因为项目组长已经审核
                    btSave.Visible = False
                    MEassessment.Enabled = False
                    OvalShape2.FillColor = Color.Lime
                    OvalShape2.BackColor = Color.Lime
                    OvalShape2.SelectionColor = Color.Lime
                    PictureBox2.Enabled = True
                End If

                If Not d.Rows(0)("ProManagerComment") Is DBNull.Value Then
                    '' 禁止修改,因为项目组长,经理已经审核
                    btSave.Visible = False
                    MEassessment.Enabled = False
                    OvalShape3.FillColor = Color.Lime
                    OvalShape3.BackColor = Color.Lime
                    OvalShape3.SelectionColor = Color.Lime
                End If

            Else
                isEdit = False
            End If

        Catch

        End Try

        d.Dispose()

    End Sub

    '' 保存数据
    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click

        If Len(MEassessment.Text.Trim()) = 0 Then
            MEassessment.Focus()
            MessageBox.Show("请填写自我考评？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim strSB As New System.Text.StringBuilder

        If isEdit Then
            strSB.Append("update IT_PerformanceManage set IndividualReviews='" & MEassessment.Text.Trim() & "'")
            strSB.Append(" where UserNo='" & UserID & "' and UserName='" & UserName & "' and YearMonth='" & YearMonthList.Text.Trim() & "'")
        Else

            '' 不允许重复插入数据
            strSB.Append("select YearMonth from IT_PerformanceManage where YearMonth='" & YearMonthList.SelectedItem & "'")
            strSB.Append(" and UserNo='" & UserID & "'")

            Dim dt As New DataTable
            dt = getDataTables(strSB.ToString())
            If dt.Rows.Count > 0 Then
                MessageBox.Show("[" & YearMonthList.SelectedItem & "月份]已经自评，请勿重复自评？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            '' 插入数据
            strSB.Append("insert into IT_PerformanceManage(UserNo,UserName,YearMonth,IndividualReviews)")
            strSB.Append(" values('" & UserID & "','" & UserName & "','" & YearMonthList.SelectedItem & "','" & MEassessment.Text.Trim() & "')")

        End If

        If ExecuteNonQuery(strSB.ToString()) = 1 Then
            ClearData()
            MessageBox.Show("操作成功？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            MessageBox.Show("操作失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        MEassessment.Text = Nothing

    End Sub

    Private Sub YearMonthList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearMonthList.Click

        If YearMonthList.Items.Count < 0 Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        ClearData()
        Dim tempdt As String = Nothing
        tempdt = YearMonthList.SelectedItem
        If tempdt = Nothing Then Exit Sub
        GCYearMonthList.Text = tempdt & "月任务明细"
        '' 加载个人参与的所有任务 
        loadMyProject(tempdt & "-01")

        If GridView1.RowCount > 0 Then
            '' 加载个人自评
            loadMyAssess(tempdt)
            loadMyToDo(tempdt)
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged

        If RadioButton5.Checked = True Then
            GridView2.Columns("ContextName").GroupIndex = -1
            GridView2.Columns("SchemeName").GroupIndex = -1
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            GridView2.Columns("ContextName").GroupIndex = -1
            GridView2.Columns("SchemeName").GroupIndex = 0
            GridView2.Columns("SchemeName").SortOrder = SortOrder.Descending
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            GridView2.Columns("ContextName").GroupIndex = 0
            GridView2.Columns("SchemeName").GroupIndex = -1
        End If
    End Sub

    Private Sub GridView1_EndGrouping(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.EndGrouping
        GridView1.ExpandAllGroups()
    End Sub

    Private Sub GridView2_EndGrouping(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView2.EndGrouping
        GridView2.ExpandAllGroups()
    End Sub
End Class
