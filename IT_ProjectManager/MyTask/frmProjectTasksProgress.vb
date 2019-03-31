Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class frmProjectTasksProgress

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private canusetime As Single
#Region "导入初始数据"

    ''' <summary>
    ''' 导入项目主资料
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadTasksDetail()

        On Error Resume Next

        Dim strSB As New System.Text.StringBuilder
        Dim dt As New DataTable
        If labName.Text.Contains("(终审)") Then
            strSB.Append("select  SchemeName ,SmStartDate ,SmEndDate,b.UserName    from IT_Scheme a inner join ")
            strSB.Append(" IT_PersonnelGroups b on a.SmFollow =b.UserNo")
            strSB.Append("  where id='" & labID.Text & "'")



            dt = getDataTables(strSB.ToString())
            strSB.Clear()

            If dt.Rows.Count > 0 Then
                txtAssName.Text = dt.Rows(0)("SchemeName")
                txtExplain.Visible = False
                txtActualStatdate.Text = Format$(dt.Rows(0)("SmStartDate"), "Short date")
                txtActualEndDate.Text = Format(dt.Rows(0)("SmEndDate"), "Short date")
                lblActualStatDate.Visible = False
                txtworkComplete.Visible = False
                txtAppointUid.Text = dt.Rows(0)("UserName")
                txtExplain.Visible = False
                dt.Dispose()
            End If
        Else

            strSB.Append("select  *,")
            strSB.Append(" (select SUM(IT_Schedule.FollowSch) from IT_Schedule where IT_Schedule.AssID =IT_Assignment.ID) as workComplete")
            strSB.Append("  from  it_assignment where id='" & labID.Text & "'")
            dt = getDataTables(strSB.ToString())
            strSB.Clear()

            If dt.Rows.Count > 0 Then
                txtAssName.Text = dt.Rows(0)("AssName")
                txtExplain.Text = dt.Rows(0)("Explain")
                txtActualStatdate.Text = Format$(dt.Rows(0)("PreStatDate"), "Short date")
                txtActualEndDate.Text = Format(dt.Rows(0)("PreEndDate"), "Short date")
                lblActualStatDate.Text = Format(dt.Rows(0)("ActualStatDate"), "Short date")
                txtworkComplete.Text = CLng(dt.Rows(0)("workComplete"))
                txtAppointUid.Text = dt.Rows(0)("AppointUid")
                txtExplain.Text = dt.Rows(0)("TaskDetail")
                dt.Dispose()
            End If

        End If

    End Sub

    ''' <summary>
    ''' 导入选择任务的进度资料
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadTasksProgress()

        Dim strSB As New System.Text.StringBuilder

        Dim dt As New DataTable

        strSB.Append("select ID,FollowSch,FollowDate,CumulativeTime,")
        strSB.Append(" (select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Schedule.FollowUID = ATL_HD_UserGroups.UserNo ) as FollowID ,")
        strSB.Append(" Remark from IT_Schedule where AssID = '" & labID.Text & "'")


        dt = getDataTables(strSB.ToString())
        Grid1.DataSource = dt
        dt.Dispose()


    End Sub

    ''' <summary>
    ''' 导入项目主资料
    ''' </summary>
    ''' <param name="strID"></param>
    ''' <remarks></remarks>
    Sub LoadTasksDetailEdit(ByVal strID As String)

        On Error Resume Next

        Dim strSB As New System.Text.StringBuilder
        strSB.Append("select FollowSch,FollowDate,CumulativeTime,)")
        strSB.Append(" (select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Schedule.FollowUID = ATL_HD_UserGroups.UserNo ) as FollowID ,")
        strSB.Append(" Remark from IT_Schedule where ID = '" & strID & "'")

        Dim dt As New DataTable

        dt = getDataTables(strSB.ToString())

        strSB.Clear()

        tbcCumulativeTime.Value = CLng(dt.Rows(0)("CumulativeTime"))
        tbcFollowSch.Value = CLng(dt.Rows(0)("FollowSch"))
        If Edit Then
            tbcFollowSch.Properties.Maximum = CLng(GridView2.GetFocusedRowCellValue("FollowSch"))
        Else

            If CLng(txtworkComplete.Text) = 100 Then
                tbcFollowSch.Properties.Maximum = CLng(dt.Rows(0)("FollowSch"))
            Else
                tbcFollowSch.Properties.Maximum = CLng(txtworkComplete.Text) + CLng(dt.Rows(0)("FollowSch"))    '最大值不能超过100
                '’ tbcFollowSch.Properties.Maximum = CLng(dt.Rows(0)("FollowSch"))
            End If
        End If
        txtRemark.Text = dt.Rows(0)("Remark")

        dt.Dispose()

    End Sub

#End Region

    Private Sub frmProjectTasksProgress_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtworkComplete.Text = 0

        Try


            '' 载入项目资料
            LoadTasksDetail()
            If Not labName.Text.Contains("(终审)") Then
                '' 载入进度详细
                LoadTasksProgress()
            End If
            tbcCumulativeTime.Value = 0
            tbcFollowSch.Value = 0
            txtRemark.Text = ""
            cmdAdd.Visible = False
            txtEvaluate.Text = ""
            cboAssGrade.EditValue = 3

            If strType = "评分" Then

                PanelControl2.Visible = False
                PanelControl4.Visible = True
                cmdSaveAssGrade.Visible = True
                cmdAdd.Visible = False
                '' 载入评分标准
                LoadData_AssGrade()

                Me.Width = 814
                GroupControl1.Visible = True

                '导入评分项目
                LoadGradeStandard(labGS_ID.Text)

            Else

                PanelControl2.Visible = True
                cmdAdd.Visible = False
                PanelControl4.Visible = False
                cmdSaveAssGrade.Visible = False

                If CLng(txtworkComplete.Text) = 100 Then
                    tbcFollowSch.Properties.Maximum = 0
                Else
                    tbcFollowSch.Properties.Maximum = (100 - CLng(txtworkComplete.Text))
                End If

                Me.Width = 504
                GroupControl1.Visible = False

                Dim params() As SqlParameter = {
      New SqlParameter("@useno", txtAppointUid.Text),
      New SqlParameter("@id", 0),
      New SqlParameter("@result", SqlDbType.Float, 8)
    }
                params(2).Direction = ParameterDirection.Output

                DbServices.DbHelperSQL.RunProcedure(String.Format("canUpdateProcess"),
                                                params)
                lbinfo.Text = "提示:您当前还可分配" & params(2).Value.ToString() & "小时"
                canusetime = params(2).Value
                Dim dt As Date = Date.Parse(DbServices.DbHelperSQL.Query("select convert(nvarchar(10),getdate(),120)").Tables(0).Rows(0)(0).ToString())
                If (dt >= Date.Parse(txtActualStatdate.Text)) And (dt <= Date.Parse(txtActualEndDate.Text)) Then
                    tbcFollowSch.Enabled = True
                    tbcCumulativeTime.Enabled = True
                Else
                    lbinfo.Text = "任务已过期，禁止修改!"
                    tbcFollowSch.Enabled = False
                    tbcCumulativeTime.Enabled = False
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub

    ''' <summary>
    ''' 更新状态为待审核
    ''' </summary>
    ''' <param name="strid"></param>
    ''' <param name="strValue"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function EditAssState(ByVal strid As String, ByVal strValue As String) As Boolean

        result = True
        Dim sql As String = Nothing
        If strValue = "1" Then      '待处理->处理中,更新实际开始时间
            sql = "UPDATE  IT_Assignment SET AssState='25',ActualStatDate='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "' where id=" & strid
        ElseIf strValue = "2" Then  '处理中->待审核
            sql = "UPDATE  IT_Assignment SET AssState='26' where id=" & strid
        ElseIf strValue = "3" Then  '直接从0到100的
            sql = "UPDATE  IT_Assignment SET AssState='26',ActualStatDate='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "' where id=" & strid
        End If

        Try
            ExecuteNonQuery(sql)

        Catch
            result = False
        End Try

        Return result

    End Function

    ''' <summary>
    ''' 保存新增数据
    ''' </summary>
    ''' <returns>返回一个Bool值，ture表示成功，false表示失败</returns>
    ''' <remarks></remarks>
    Function SaveDataNew() As Boolean

        result = True
        Dim sql As String = Nothing
        sql = "INSERT INTO IT_Schedule (AssID,FollowUID,FollowSch,CumulativeTime,Remark,Followdate) Values (" _
            & labID.Text & ",'" & UserID & "'," & tbcFollowSch.Value & "," & tbcCumulativeTime.Value / 2.0 & ",'" & txtRemark.Text & "','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "')"
        Try
            ExecuteNonQuery(sql)
        Catch
            result = False
        End Try

        If tbcFollowSch.Value + CLng(txtworkComplete.Text) = 100 Then
            '完成时更新状态为待审核
            If tbcFollowSch.Value = 100 And CLng(txtworkComplete.Text) = 0 Then
                EditAssState(labID.Text, "3") '更新状态为待审核,由0到100
            Else
                EditAssState(labID.Text, "2") '更新状态为待审核
            End If
        ElseIf CLng(txtworkComplete.Text) = 0 Then
            EditAssState(labID.Text, "1") '更新状态为处理中
        End If

        Return result

    End Function

    ''' <summary>
    ''' 保存修改资料
    ''' </summary>
    ''' <returns>返回一个bool值 ，ture表示成功，false表示失败</returns>
    ''' <remarks></remarks>
    Function SaveDataEdit() As Boolean

        result = True
        Dim sql As String = Nothing
        sql = "UPDATE IT_Schedule SET FollowUID='" & UserID & "',FollowSch=" & tbcFollowSch.Value & ",CumulativeTime=" & tbcCumulativeTime.Value / 2.0 & "," _
            & "Remark='" & txtRemark.Text & "',Followdate='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "' WHERE ID='" & labEditID.Text & "'"
        Try
            ExecuteNonQuery(sql)
        Catch
            result = False
        End Try

        If tbcFollowSch.Value + CLng(txtworkComplete.Text) = 100 Then
            '完成时更新状态为待审核
            If tbcFollowSch.Value = 100 And CLng(txtworkComplete.Text) = 0 Then
                EditAssState(labID.Text, "3") '更新状态为待审核,由0到100
            Else
                EditAssState(labID.Text, "2") '更新状态为待审核
            End If
        ElseIf CLng(txtworkComplete.Text) = 0 Then
            EditAssState(labID.Text, "1") '更新状态为处理中
        End If

        Return result

    End Function

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If tbcFollowSch.Value = 0 Then
            MessageBox.Show("任务进度为0，无法继续？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If tbcCumulativeTime.Value = 0 Then
            MessageBox.Show("花费时间为0，无法继续？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If txtRemark.EditValue.ToString().Trim() = "" Then
            MessageBox.Show("进度说明不能为空，无法继续？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Edit = False Then

            '保存新增数据
            If Not SaveDataNew() Then
                MessageBox.Show("保存新增数据失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                '' MessageBox.Show("数据保存成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                isRefresh = True
                tbcCumulativeTime.Value = 0
                tbcFollowSch.Value = 0
                txtRemark.Text = ""
                Me.Close()
            End If

        Else

            If labEditID.Text = "" Then Exit Sub

            If Not SaveDataEdit() Then
                MessageBox.Show("保存修改数据失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                isRefresh = True
                cmdAdd_Click(Nothing, Nothing)
                LoadTasksDetail()
                LoadTasksProgress()
                Me.Close()
            End If
            'Me.Close()
        End If

    End Sub

    Private Sub Grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        '双击变为修改状态
        If strType = "任务" Then
            Dim serverdate As String = DbServices.DbHelperSQL.Query("select getdate()").Tables(0).Rows(0)(0).ToString()
            If Date.Parse(GridView2.GetFocusedRowCellValue("FollowDate")).ToString("yyyy-MM-dd") < Date.Parse(serverdate).ToString("yyyy-MM-dd") Then
                Exit Sub
            End If
            If GridView2.RowCount = 0 Then Exit Sub
            labEditID.Text = GridView2.GetFocusedRowCellValue("ID")
            LoadTasksDetailEdit(labEditID.Text)
            Dim params() As SqlParameter = {
              New SqlParameter("@useno", txtAppointUid.Text),
              New SqlParameter("@id", labEditID.Text),
              New SqlParameter("@result", SqlDbType.Float, 8)
               }
            params(2).Direction = ParameterDirection.Output

            DbServices.DbHelperSQL.RunProcedure(String.Format("canUpdateProcess"),
                                            params)
            lbinfo.Text = "提示:您当前还可分配" & params(2).Value.ToString() & "小时"
            canusetime = params(2).Value
            tbcFollowSch.Properties.Maximum = 100
            Edit = True
            'cmdAdd.Visible = True
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Edit = False
        cmdAdd.Visible = False
        tbcCumulativeTime.Value = 0
        tbcFollowSch.Value = 0
        txtRemark.Text = ""
    End Sub

    '' 保存评分
    Private Sub cmdSaveAssGrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveAssGrade1.Click

        '保存评分数据
        If Not SaveDataAssGrade() Then
            MessageBox.Show("保存评分记录失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ''保存记录
        If Not SaveDataGradeValueFull() Then
            MessageBox.Show("评分失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.Close()


    End Sub

#Region "评分处理"

    ''' <summary>
    ''' 导入评分标准
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData_AssGrade()

        On Error Resume Next
        Dim sql As String = Nothing
        Dim dt As New DataTable
        sql = "SELECT *  FROM IT_ProStatus where ParentID='30' order by ID desc"
        dt = getDataTables(sql)

        If dt.Rows.Count = 0 Then
            cboAssGrade.Properties.DataSource = Nothing
        End If

        cboAssGrade.Properties.ValueMember = "ProStatus"
        cboAssGrade.Properties.DisplayMember = "Explain"
        cboAssGrade.Properties.DataSource = dt
        cboAssGrade.EditValue = 3
        dt.Dispose()

    End Sub

    ''' <summary>
    ''' 执行更新操作
    ''' 返回一个bool值
    ''' true表示成功 
    ''' false表示失败
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function SaveDataAssGrade() As Boolean

        Dim resutl As Boolean = True
        Dim sql As String = Nothing
        If (labName.Text.Contains("(初审)")) Then
            '更新评分,评价,类型为已完成,及实际完成日期
            sql = "UPDATE IT_Assignment SET AssGrade=" & cboAssGrade.EditValue & ",Evaluate='" & txtEvaluate.Text & "',AssState='27',AchualEndDate='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'  WHERE ID='" & labID.Text & "'  " &
                  "if not exists(select a.* from IT_Assignment a inner join IT_Project b on a.PrjID=b.ID   where a.AssState<>'27' and    b.ID in (select PrjID  from IT_Assignment where ID='" & labID.Text & "'))  " &
                   "update IT_Project set PrjStatus=27  from IT_Assignment where IT_Assignment.PrjID=IT_Project.ID and IT_Assignment.ID='" & labID.Text & "'"
        End If
        If (labName.Text.Contains("(终审)")) Then
            sql = "UPDATE  IT_Scheme  set SmStatus='17' WHERE id='" & labID.Text & "'"
        End If
        Try
            ExecuteNonQuery(sql)
            isRefresh = True
        Catch ex As Exception
            resutl = False
        End Try

        Return resutl

    End Function

    ''' <summary>
    ''' 导入评分标准
    ''' </summary>
    ''' <param name="strID"></param>
    ''' <remarks></remarks>
    Sub LoadGradeStandard(ByVal strID As String)

        Dim lngCount As Long
        Dim dt As New DataTable
        Dim strSB As New System.Text.StringBuilder

        strSB.Append("SELECT *  FROM IT_GradeStandard where ")

        If strID = "2" Then ''表示通用标准
            strSB.Append(" GS_PID='2' and GS_Level='2' Order by GS_PID")
        Else
            strSB.Append(" GS_ID='" & strID & "'  or( GS_PID='2' and GS_Level='2') Order by GS_ID")
        End If

        dt = getDataTables(strSB.ToString())
        strSB.Clear()
        '清除旧控件
        DeleteRatingStar(GroupControl1, LabelControl8)
        Try

            lngCount = dt.Rows.Count

            If lngCount > 0 Then

                For i As Integer = 0 To lngCount - 1
                    If dt.Rows(i)("GS_Name").ToString().Trim() <> "" Then
                        '' 生成评分控件
                        CreateRatingStar(dt.Rows(i).Item("GS_ID").ToString, dt.Rows(i).Item("GS_Name").ToString, dt.Rows(i).Item("GS_Remark").ToString, 0, GroupControl1, LabelControl8)
                    End If
                Next
            End If


            dt.Dispose()
        Catch
        End Try

    End Sub

    ''' <summary>
    ''' 计算评分
    ''' 返回一个bool值
    ''' true表示成功
    ''' false表示失败
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function SumGrade() As Boolean

        result = True
        Dim ctrl As Control
        LabelControl9.Text = 0

        For Each ctrl In Me.GroupControl1.Controls

            Try
                If TypeOf (ctrl) Is RatingStar Then
                    Dim xx As RatingStar = ctrl
                    LabelControl9.Text = CLng(LabelControl9.Text) + CLng(xx.intValue)
                End If
            Catch ex As Exception
                ' MessageBox.Show(ex.Message, "请注意", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                result = False
            End Try

        Next

        cboAssGrade.EditValue = CStr(Math.Round((CLng(LabelControl9.Text) / (Me.GroupControl1.Controls.Count * 5)) * 5, 0))
        Return result
    End Function

#End Region

    ''' <summary>
    ''' 保存所有评分数据
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function SaveDataGradeValueFull() As Boolean

        result = True

        '计算评分
        If Not SumGrade() Then
            MessageBox.Show("计算评分失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return result = False
            Exit Function
        End If

        '' 保存数据
        Dim ctrl As Control

        Dim strSB As New System.Text.StringBuilder

        strSB.Clear()

        For Each ctrl In Me.GroupControl1.Controls


            If TypeOf (ctrl) Is RatingStar Then

                Dim xx As RatingStar = ctrl

                strSB.Append("INSERT INTO IT_GradeValue (ASS_ID,GS_ID,GV_Value,GS_UserNo,CreatedTime) " &
                          "Values ('" & labID.Text & "','" & xx.labID.Text & "','" & xx.intValue & "','" & txtAppointUid.Text & "','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "')")

            End If

        Next

        Try
            ExecuteNonQuery(strSB.ToString())
            isRefresh = True
        Catch ex As Exception
            result = False
        End Try

        Return result

    End Function

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)

        '保存评分数据
        If Not SaveDataAssGrade() Then
            MessageBox.Show("保存评分记录失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ''保存记录
        If Not SaveDataGradeValueFull() Then
            MessageBox.Show("评分失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.Close()

    End Sub

    Private Sub BarButtonItem2_ItemClick()
        Dim sql As String = Nothing

        '设置项目为暂停

        If labName.Text.IndexOf("(终审)") = -1 Then
            MessageBox.Show("您没有权限暂停此项目!")
            Return
        End If

        If MessageBox.Show("您确定需要暂停此项目吗?", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            If (labName.Text.Contains("(终审)")) Then
                sql = "UPDATE  IT_Scheme  set SmStatus='18' WHERE SchemeName='" & txtAssName.Text.Trim() & "'"

                Try
                    ExecuteNonQuery(sql)
                    isRefresh = True
                Catch ex As Exception
                    MessageBox.Show("暂停此项目失败!")
                End Try
            End If
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick()
        Dim sql As String = Nothing

        '设置项目为暂停

        If labName.Text.IndexOf("(终审)") = -1 Then
            MessageBox.Show("您没有权限终止此项目!")
            Return
        End If

        If MessageBox.Show("您确定需要终止此项目吗?", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            If (labName.Text.Contains("(终审)")) Then
                sql = "UPDATE  IT_Scheme  set SmStatus='19' WHERE SchemeName='" & txtAssName.Text.Trim() & "'"
                Try
                    ExecuteNonQuery(sql)
                    isRefresh = True
                Catch ex As Exception
                    MessageBox.Show("终止此项目失败!")
                End Try
            End If
        End If
    End Sub

    Private Sub tbcCumulativeTime_EditValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles tbcCumulativeTime.EditValueChanging
        'If (Math.Round(tbcCumulativeTime.Value / 60, 1, MidpointRounding.AwayFromZero) > canusetime) Then
        '    e.Cancel = True
        'End If
    End Sub

    Private Sub tbcCumulativeTime_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbcCumulativeTime.EditValueChanged
        'Dim params() As SqlParameter = {
        '    New SqlParameter("@useno", txtAppointUid.Text),
        '    New SqlParameter("@id", 0),
        '    New SqlParameter("@result", SqlDbType.SmallInt, 1)
        '  }
        'params(1).Direction = ParameterDirection.Output

        'DbServices.DbHelperSQL.RunProcedure(String.Format("canUpdateProcess"),
        '                                params)

        If ((tbcCumulativeTime.Value / 2) > canusetime) Then
            tbcCumulativeTime.Value = tbcCumulativeTime.OldEditValue
        End If
    End Sub

    Private Sub ContextMenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        If e.ClickedItem.Text = "评分" Then

            '保存评分数据
            If Not SaveDataAssGrade() Then
                MessageBox.Show("保存评分记录失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ''保存记录
            If Not SaveDataGradeValueFull() Then
                MessageBox.Show("评分失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Me.Close()
        End If
        If e.ClickedItem.Text = "终止" Then
            BarButtonItem3_ItemClick()
        End If
        If e.ClickedItem.Text = "暂停" Then
            BarButtonItem2_ItemClick()
        End If
    End Sub

    Private Sub cmdSaveAssGrade_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdSaveAssGrade_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdSaveAssGrade.MouseDown

        '保存评分数据
        If Not SaveDataAssGrade() Then
            MessageBox.Show("保存评分记录失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ''保存记录
        If Not SaveDataGradeValueFull() Then
            MessageBox.Show("评分失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.Close()


        ' ContextMenuStrip1.Show(cmdSaveAssGrade, New Point(0, cmdSaveAssGrade.Height + 6))
    End Sub



End Class