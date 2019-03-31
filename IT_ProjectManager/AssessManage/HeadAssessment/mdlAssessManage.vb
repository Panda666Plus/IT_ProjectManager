Public Class mdlAssessManage

    Dim GV_type As Integer

    Dim tL As Boolean = False

    '' 加载考评信息
    Private Sub mdlAssessManage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clearControl()
        loadAll()
    End Sub
    ''' <summary>
    ''' 初始化进度
    ''' </summary>
    ''' <remarks></remarks>
    Sub DefaultSchedule()
        LabelControl2.Visible = False
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

    Private Sub YearMonthList_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles YearMonthList.MouseUp

        If e.Button = Windows.Forms.MouseButtons.Left Then

            If YearMonthList.Items.Count < 1 Then Exit Sub

            Me.Cursor = Cursors.WaitCursor

            tL = False

            Dim tempdt As String = Nothing

            tempdt = YearMonthList.SelectedItem

            If tempdt = "" Then Exit Sub

            '' 初始化进度信息
            DefaultSchedule()

            GroupControl4.Text = uName & "[" & tempdt & "]个人自评"

            If tempdt = Nothing Then Exit Sub

            GroupControl2.Text = tempdt & "月任务明细"
            '' 加载个人参与的所有任务 
            loadMyProject(tempdt & "-01")
            '' 待事项
            loadmyToDo(tempdt)

            If GridView1.RowCount > 0 Or GridView3.RowCount > 0 Then

                '' 清空评分控件
                If ProManagerCommentAssess.Controls.Count > 0 Then
                    DeleteRatingStar(ProManagerCommentAssess, LabelControl1)
                End If

                If LeaderCommentAssess.Controls.Count > 0 Then
                    DeleteRatingStar(LeaderCommentAssess, LabelControl1)
                End If

                ProAssess.Visible = True
                '' 加载考评信息
                loadMyAssess(tempdt)

            End If

            Me.Cursor = Cursors.Default

        End If

    End Sub

#Region "加载数据"

    ''' <summary>
    ''' 加载所有人员
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadAll()

        Dim sql As String = Nothing
        sql = "select * from IT_PersonnelGroups where isjob=1"
        Dim dt As New DataTable
        dt = getDataTables(sql)
        If dt.Rows.Count > 0 Then
            lbPersonnelDetails.DataSource = dt
        Else
            lbPersonnelDetails.DataSource = Nothing
        End If
        dt.Dispose()

    End Sub

    ''' <summary>
    ''' 加载年月
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadYearMonth(ByVal uid As String, ByVal uName As String)

        Dim sql As String = Nothing

        Dim l As Integer

        Dim tempdt As String = DateTime.Now.ToString("yyyy-MM")

        sql = "select YearMonth from IT_PerformanceManage where UserNo='" & uid & "' and UserName='" & uName & "'"

        Dim dt As New DataTable

        dt = getDataTables(sql)

        l = dt.Rows.Count

        YearMonthList.Items.Clear()

        If l > 0 Then

            For i As Integer = 0 To l - 1 Step 1
                YearMonthList.Items.Add(dt.Rows(i)("YearMonth").ToString())
            Next
        End If

        dt.Dispose()

    End Sub

#Region "取得指定月考评"

    ''' <summary>
    ''' 加载个人自评信息
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadMyAssess(ByVal dt As String)

        Dim strSB As New System.Text.StringBuilder

        strSB.Append("select * from IT_PerformanceManage where UserNo='" & uID & "' and YearMonth='" & dt & "' ")

        Dim d As New DataTable

        d = getDataTables(strSB.ToString())

        Dim lngCount As Integer

        lngCount = d.Rows.Count

        Try

            If lngCount > 0 Then

                SplitContainerControl5.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both

                SplitContainerControl2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1

                SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both

                autoid = d.Rows(0)("AutoID")
                '' 取得个人自评
                IndividualReviews.Text = d.Rows(0)("IndividualReviews")

                LabelControl2.Visible = True
                Panel1.Visible = True
                PictureBox1.Enabled = True
                OvalShape1.FillColor = Color.Lime
                OvalShape1.BackColor = Color.Lime
                OvalShape1.SelectionColor = Color.Lime

                ''没有项目组长考核信息
                If (d.Rows(0)("LeaderComment") Is DBNull.Value) Then
                    ContextMenuStrip1.Show(YearMonthList, Control.MousePosition.X, Control.MousePosition.Y)
                    tL = True
                    Exit Sub
                End If

                '' 加载项目主管考核信息
                Dim post As String = GridView2.GetFocusedRowCellValue("pPost")

                '' 取得评分记录
                Dim tempDT As New DataTable

                strSB.Clear()
                strSB.Append("select IT_PeromanceGradeValue.GS_ID,IT_PeromanceGradeValue.LeaderGradeValue, ")
                strSB.Append("  IT_PeromanceGradeValue.ProManagerValue, IT_AssessStandard.ASS_Name, IT_AssessStandard.ASS_Remark ")
                strSB.Append("  from IT_PeromanceGradeValue, IT_PerformanceManage, IT_AssessStandard ")
                strSB.Append(" where IT_PeromanceGradeValue.ASS_ID = IT_PerformanceManage.AutoID ")
                strSB.Append(" and IT_PerformanceManage.UserNo='" & uID & "' and IT_PerformanceManage.YearMonth='" & dt & "'")
                strSB.Append(" and IT_AssessStandard.ASS_ID=IT_PeromanceGradeValue.GS_ID ")

                tempDT = getDataTables(strSB.ToString())

                strSB.Clear()

                If tempDT.Rows.Count <= 0 Then Exit Sub

                '' 加载项目组长数据
                SplitContainerControl2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
                LabelControl1.Text = 3
                For ii As Integer = 0 To tempDT.Rows.Count - 1 Step 1
                    '' 生成评分控件
                    CreateRatingStar(tempDT.Rows(ii)("GS_ID"), tempDT.Rows(ii)("ASS_Name"), tempDT.Rows(ii)("ASS_Remark"), tempDT.Rows(ii)("LeaderGradeValue"), LeaderCommentAssess, LabelControl1)
                Next

                ''显示项目组长的评语
                LeaderComment.Text = d.Rows(0)("LeaderComment")
                PictureBox2.Enabled = True
                OvalShape2.FillColor = Color.Lime
                OvalShape2.BackColor = Color.Lime
                OvalShape2.SelectionColor = Color.Lime

                ''没有项目经理已经完成考评
                If d.Rows(0)("ProManagerComment") Is DBNull.Value Then
                    SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
                    ContextMenuStrip1.Show(YearMonthList, Control.MousePosition.X, Control.MousePosition.Y)
                    ''项目经理已经完成考评，所以不在显示
                    Exit Sub
                Else   ''项目经理已经完成考评,不允许在修改
                    OvalShape3.FillColor = Color.Lime
                    OvalShape3.BackColor = Color.Lime
                    OvalShape3.SelectionColor = Color.Lime
                End If

                '' 加载项目经理数据
                If IsProjectManager Then

                    ''没有项目经理已经完成考评
                    If d.Rows(0)("ProManagerComment") Is DBNull.Value Then
                        ContextMenuStrip1.Show(YearMonthList, Control.MousePosition.X, Control.MousePosition.Y)
                    End If

                    '' 显示项目经理评语
                    ProManagerComment.Text = d.Rows(0)("ProManagerComment")

                    LabelControl1.Text = 3

                    For iii As Integer = 0 To tempDT.Rows.Count - 1 Step 1
                        If Not tempDT.Rows(iii)("ProManagerValue") Is DBNull.Value Then
                            '' 生成评分控件
                            CreateRatingStar(tempDT.Rows(iii)("GS_ID"), tempDT.Rows(iii)("ASS_Name"), tempDT.Rows(iii)("ASS_Remark"),
                                             tempDT.Rows(iii)("ProManagerValue"), ProManagerCommentAssess, LabelControl1)
                        End If
                    Next

                Else
                    SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
                End If

                tempDT.Dispose()

            Else
                SplitContainerControl5.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            End If

        Catch ex As Exception
            MessageBox.Show("未知错误：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        d.Dispose()

    End Sub

#End Region

    ''' <summary>
    ''' 加载个有项目
    ''' </summary>
    ''' <param name="dt">查询年月</param>
    ''' <remarks></remarks>
    Sub loadMyProject(ByVal dt As String)

        Dim myInfo As New MyTaskOrToDO

        Dim d As New DataTable

        d = myInfo.MyTask(dt, uID)

        Try
            If d.Rows.Count > 0 Then
                GridMyTask.DataSource = d
            Else
                GridMyTask.DataSource = Nothing
                SplitContainerControl5.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            End If
        Catch

        End Try

        d.Dispose()

    End Sub

    ''' <summary>
    ''' 取得指定人指定月待办事项
    ''' </summary>
    ''' <param name="dt"></param>
    ''' <remarks></remarks>
    Sub loadmyToDo(ByVal dt As String)

        Dim getMyToDo As New MyTaskOrToDO

        Dim d As New DataTable

        d = getMyToDo.myToDo(uID, dt)

        If d.Rows.Count > 0 Then
            GridMyToDo.DataSource = d
        Else
            GridMyToDo.DataSource = Nothing
        End If

        d.Dispose()

    End Sub

    ''' <summary>
    ''' 清空控件
    ''' </summary>
    ''' <remarks></remarks>
    Sub clearControl()

        YearMonthList.Items.Clear()
        GridMyTask.DataSource = Nothing
        IndividualReviews.Text = ""
        LeaderComment.Text = ""
        SplitContainerControl5.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1

        If ProManagerCommentAssess.Controls.Count > 0 Then
            DeleteRatingStar(ProManagerCommentAssess, LabelControl1)
        End If

        If LeaderCommentAssess.Controls.Count > 0 Then
            DeleteRatingStar(LeaderCommentAssess, LabelControl1)
        End If

    End Sub

#End Region

    Dim uID As String
    Dim uName As String
    Dim autoid As Integer
    Private Sub lbPersonnelDetails_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbPersonnelDetails.Click

        If GridView2.RowCount < 1 Then Exit Sub

        DefaultSchedule()
        clearControl()
        uID = GridView2.GetFocusedRowCellValue("UserNo")
        uName = GridView2.GetFocusedRowCellValue("UserName")

        If uID = "" Or uName = "" Then
            MessageBox.Show("请选择需要考核的人员？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            Exit Sub
        End If

        loadYearMonth(uID, uName)

    End Sub

    '' 加载考评窗体 
    Private Sub ProAssess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProAssess.Click

        If Not IsProjectManager And Not IsLeader Then
            MessageBox.Show("您非项目经理或项目组长，无法进行考评？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If tL And Not IsLeader Then
            MessageBox.Show("项目组长还未考评？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        isRefresh = False

        Dim frm As New LeaderAssess
        frm.YearMonth = YearMonthList.SelectedValue
        frm.autoid = autoid
        frm.uid = uID
        frm.ASSpost = GridView2.GetFocusedRowCellValue("pPost")

        If IsProjectManager Then
            frm.Text = "项目经理考评"
        Else
            frm.Text = "项目组长考评"
        End If

        frm.ShowDialog()

        If isRefresh = True Then
            '' 加载考评信息
            loadMyAssess(YearMonthList.SelectedValue)
        End If
    End Sub

#Region "GRID绘制颜色"
    Private Sub GridView1_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs)
        CustomDrawCell(e)
    End Sub

    Private Sub GridView2_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GridView2.CustomDrawCell
        CustomDrawCell(e)
    End Sub
#End Region

#Region "刷新条件"

    ''' <summary>
    ''' 刷新条件
    ''' </summary>
    ''' <remarks></remarks>
    Sub ChecksFilterValue()
        '
        Dim strFilterString As String
        Dim lt As New ListBox
        strFilterString = ""
        lt.Items.Clear()

        'OR
        If CheckEdit2.Checked = True Then lt.Items.Add("[Groups]='程序组'")
        If CheckEdit1.Checked = True Then lt.Items.Add("[Groups]='维护组'")
        If CheckEdit3.Checked = True Then lt.Items.Add("")

        'If ckName.Checked = True Then ListBox1.Items.Add("[SmFollow1]='肖海龙' or [SmPrincipal]='肖海龙'")
        For i As Integer = 0 To lt.Items.Count - 1

            If i = 0 Then
                strFilterString = lt.Items(i).ToString
            Else
                strFilterString = strFilterString & " or " & lt.Items(i).ToString
            End If

        Next

        GridView2.ActiveFilterString = strFilterString

    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        ChecksFilterValue()
    End Sub
    Private Sub CheckEdit2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit2.CheckedChanged
        ChecksFilterValue()
    End Sub
    Private Sub CheckEdit3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit3.CheckedChanged
        ChecksFilterValue()
    End Sub
#End Region

    Private Sub GridView1_EndGrouping(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.EndGrouping
        GridView1.ExpandAllGroups()
    End Sub

    Private Sub GridView3_EndGrouping(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView3.EndGrouping
        GridView2.ExpandAllGroups()
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            GridView3.Columns("ContextName").GroupIndex = -1
            GridView3.Columns("SchemeName").GroupIndex = -1
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            GridView3.Columns("ContextName").GroupIndex = -1
            GridView3.Columns("SchemeName").GroupIndex = 0
            GridView3.Columns("SchemeName").SortOrder = SortOrder.Descending
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            GridView3.Columns("ContextName").GroupIndex = 0
            GridView3.Columns("SchemeName").GroupIndex = -1
        End If
    End Sub
End Class
