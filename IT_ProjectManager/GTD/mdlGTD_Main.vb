Imports System.Data
Imports System.Data.SqlClient
Imports System.Threading

Public Class mdlGTD_Main
    Dim td1 As Thread = Nothing
    Dim td2 As Thread = Nothing
    Dim td3 As Thread = Nothing
    Dim td4 As Thread = Nothing
    Dim td5 As Thread = Nothing
    Dim td6 As Thread = Nothing

#Region "委托传参"

    ''' <summary>
    ''' 公共委托绑定数据方法
    ''' </summary>
    ''' <param name="GridControl">Grid控件</param>
    ''' <param name="DataSource">DT数据集</param>
    ''' <remarks></remarks>
    Sub SetParameter(ByVal GridControl As DevExpress.XtraGrid.GridControl, ByVal DataSource As Object)
        Try
            If Not DataSource Is DBNull.Value Then
                GridControl.DataSource = DataSource
            Else
                GridControl.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

#End Region

    ''' <summary>
    ''' 获取个人任务
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadMyToDo()

        Try
            Dim dt As New DataTable
            Dim strSB As New System.Text.StringBuilder
            strSB.Append("select *,(select IT_Scheme.SchemeName from IT_Scheme where IT_Scheme.ID=IT_ToDo.SchemeID) as SchemeName,")
            strSB.Append(" (select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_ToDo.TD_Context) as ContextName ")
            strSB.Append(" from IT_ToDo where TD_UserNo='" & UserID & "'  and TD_Complete=0 order by TD_StartDate, TD_ID DESC")
            dt = getDataTables(strSB.ToString())
            SetGridData = New SetGridViewDelegate(AddressOf Me.SetParameter)
            Me.Invoke(SetGridData, GridMyToDo, dt)
            dt.Dispose()
            strSB.Clear()
        Catch ex As Exception
            'MessageBox.Show("线程处理引发以下错误：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            td5.Abort()
        End Try

    End Sub
    ''' <summary>
    ''' 获取个人任务,附加查询条件
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadMyToDoSeek(ByVal strsqlWhere As String)

        Try
            Dim dt As New DataTable
            Dim strSB As New System.Text.StringBuilder
            strSB.Append("select *,(select IT_Scheme.SchemeName from IT_Scheme where IT_Scheme.ID=IT_ToDo.SchemeID) as SchemeName,")
            strSB.Append(" (select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_ToDo.TD_Context) as ContextName ")
            strSB.Append(" from IT_ToDo where TD_UserNo='" & UserID & "'  and TD_Complete=0 and " & strsqlWhere & " order by TD_StartDate,TD_ID DESC")
            dt = getDataTables(strSB.ToString())
            SetGridData = New SetGridViewDelegate(AddressOf Me.SetParameter)
            Me.Invoke(SetGridData, GridMyToDo, dt)
            dt.Dispose()
            strSB.Clear()
        Catch ex As Exception
            'MessageBox.Show("线程处理引发以下错误：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            td5.Abort()
        End Try

    End Sub

    Private Sub mdlGTD_Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Application.DoEvents()

        '' 个人待办事项
        td5 = New Thread(AddressOf LoadMyToDo)
        td5.Start()
        Thread.Sleep(10)

        LoadData_Context()
        LoadData_Project()
        LoadGetDate()


    End Sub

    '' 编辑待办事项
    Private Sub GridMyToDo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridMyToDo.DoubleClick
        If GridView2.RowCount = 0 Or Len(GridView2.GetFocusedRowCellValue("TD_ID")) = 0 Then Exit Sub
        Edit = True
        isRefresh = False

        '' 显示编辑窗体
        frmMyTasks.txtID.Text = GridView2.GetFocusedRowCellValue("TD_ID")
        frmMyTasks.ShowDialog()

        Try
            '' 是否刷新数据
            If Not isRefresh Then Exit Sub

            '' 个人待办事项
            td5 = New Thread(AddressOf LoadMyToDo)
            td5.Start()

        Catch ex As Exception

            ' MessageBox.Show("未知错误，请将此问题反馈到管理员处，谢谢？" & vbCrLf & ex.Message,
            '"项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '' 回车增加待办事项
    Private Sub txtToDoName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtToDoName.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtToDoName.Text) = 0 Then Exit Sub
            If checkValue(txtToDoName.Text) Then
                txtToDoName.Focus()
                txtToDoName.SelectAll()
                MessageBox.Show("待办事项[" & txtToDoName.Text & "]已存在？", "项目管理系统",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            ''保存记录
            SaveNewToDo(txtToDoName.Text)

            '' 载入新数据
            LoadMyToDo()

            txtToDoName.Text = ""
            txtToDoName.Focus()

        End If
    End Sub

    ''' <summary>
    ''' 检查当前增加待办事是否已经存在
    ''' </summary>
    ''' <param name="strName">项目名称</param>
    ''' <returns>返回一个Bool值，true表示已经存在，false表示不存在</returns>
    ''' <remarks></remarks>
    ''' 
    Function checkValue(ByVal strName As String) As Boolean

        Application.DoEvents()
        Dim sql As String = Nothing
        result = True
        sql = "select * from IT_ToDo where TD_Name='" & strName & "' and TD_Complete='0'"
        Try
            Dim i As Integer
            i = ExecuteScalar(sql)
            If i > 0 Then
                result = True
            Else
                result = False
            End If
        Catch ex As Exception
            result = False
        End Try
        Return result
    End Function

    ''' <summary>
    ''' 保存新增数据
    ''' </summary>
    ''' <param name="strName"></param>
    ''' <remarks></remarks>
    Sub SaveNewToDo(ByVal strName As String)

        Dim sql As String = Nothing
        sql = "INSERT INTO IT_ToDo (TD_Name,TD_Label,TD_UserNo,CreatedTime,TD_Complete) Values (" _
        & "'" & strName & "','0','" & UserID & "','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "',0)"

        Try
            ExecuteNonQuery(sql)
        Catch

        End Try

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        'lstContext.Items.Add("所有")
        'MsgBox(lstContext.SelectedValue)

        frmMyTasks.ShowDialog()

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        'GridView2.Columns("ContextName").GroupIndex = -1
        'GridView2.Columns("SchemeName").GroupIndex = -1


        ' LoadMyToDoSeek(" (IT_ToDo.SchemeID='' or ID_ToDo.SchemeID is null) and (IT_ToDo.TD_Context='' or IT_ToDo.TD_Context is null) ")
        LoadMyToDo()

    End Sub

    Private Sub CheckButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckButton1.CheckedChanged

        LoadMyToDoSeek("TD_label=1")
    End Sub


    ''' <summary>
    ''' 导入上下文
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData_Context()

        Dim dt As New DataTable
        Dim sql As String = Nothing
        sql = "select TD_Context,(select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_ToDo.TD_Context) as ContextName,count(TD_Context) as ContextCount " _
           & " from IT_ToDo where TD_UserNo='" & UserID & "' and TD_Complete=0 and   TD_Context is not null GROUP BY TD_Context"

        'sql = "SELECT *  FROM IT_ProStatus where ParentID='60'"
        dt = getDataTables(sql)

        If dt.Rows.Count = 0 Then
            lstContext.DataSource = Nothing
        End If

        lstContext.ValueMember = "TD_Context"
        lstContext.DisplayMember = "ContextName"
        lstContext.DataSource = dt
        'lstContext.EditValue = 16
        dt = Nothing
    End Sub

    ''' <summary>
    ''' 导入项目
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData_Project()

        Dim dt As New DataTable
        Dim sql As String = Nothing


        sql = "select SchemeID,(select IT_Scheme.SchemeName from IT_Scheme where IT_Scheme.ID=IT_ToDo.SchemeID) as SchemeName,count(SchemeID) as SchemeCount " _
            & " from IT_ToDo where TD_UserNo='" & UserID & "' and TD_Complete=0 and  SchemeID is not null GROUP BY SchemeID"

        dt = getDataTables(sql)

        If dt.Rows.Count = 0 Then
            lstProject.DataSource = Nothing
        End If

        lstProject.ValueMember = "SchemeID"
        lstProject.DisplayMember = "SchemeName"
        lstProject.DataSource = dt
        'lstContext.EditValue = 16
        dt = Nothing
    End Sub

    Private Sub lstContext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstContext.Click
        On Error Resume Next

        LoadMyToDoSeek("TD_Context='" & lstContext.SelectedValue & "'")
    End Sub

    Private Sub lstProject_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstProject.Click
        On Error Resume Next
        LoadMyToDoSeek("SchemeID='" & lstProject.SelectedValue & "'")

    End Sub

    Private Sub chkComplete_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkComplete.CheckedChanged
        On Error Resume Next

        If chkComplete.ValueChecked = True Then
            '完成任务UpdateToDoComplete
            UpdateToDoComplete(GridView2.GetFocusedRowCellValue("TD_ID"))
            '隐藏此记录
            GridView2.DeleteSelectedRows()
        End If
    End Sub

    ''' <summary>
    ''' 保存修改资料
    ''' </summary>
    ''' <param name="strId">Id_id</param>
    ''' <remarks></remarks>
    Function UpdateToDoComplete(ByVal strId As String) As Boolean

        result = True
        Dim sql As String = Nothing
        sql = "UPDATE IT_ToDo SET TD_Complete=1,TD_CompleteDate='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "' WHERE " _
            & "TD_ID='" & strId & "'"

        Try
            ExecuteNonQuery(sql)
        Catch
            result = False
        End Try

        Return result

    End Function

    ''' <summary>
    ''' 获取最近日期  2014/07/08 杨
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadGetDate()
        '读取日期
        LabelControl2.Text = Format(DateAdd(DateInterval.Day, 0, Now), "MM-dd")
        LabelControl6.Text = Format(DateAdd(DateInterval.Day, 1, Now), "MM-dd")
        LabelControl10.Text = Format(DateAdd(DateInterval.Day, 2, Now), "MM-dd")
        LabelControl13.Text = Format(DateAdd(DateInterval.Day, 3, Now), "MM-dd")
        LabelControl16.Text = Format(DateAdd(DateInterval.Day, 4, Now), "MM-dd")
        LabelControl19.Text = Format(DateAdd(DateInterval.Day, 5, Now), "MM-dd")
        LabelControl22.Text = Format(DateAdd(DateInterval.Day, 6, Now), "MM-dd")
        '读取星期
        LabelControl5.Text = SelectWeek(CDate(Format(DateAdd(DateInterval.Day, 0, Now), "MM-dd")).DayOfWeek)
        LabelControl9.Text = SelectWeek(CDate(Format(DateAdd(DateInterval.Day, 1, Now), "MM-dd")).DayOfWeek)
        LabelControl12.Text = SelectWeek(CDate(Format(DateAdd(DateInterval.Day, 2, Now), "MM-dd")).DayOfWeek)
        LabelControl15.Text = SelectWeek(CDate(Format(DateAdd(DateInterval.Day, 3, Now), "MM-dd")).DayOfWeek)
        LabelControl18.Text = SelectWeek(CDate(Format(DateAdd(DateInterval.Day, 4, Now), "MM-dd")).DayOfWeek)
        LabelControl21.Text = SelectWeek(CDate(Format(DateAdd(DateInterval.Day, 5, Now), "MM-dd")).DayOfWeek)
        LabelControl24.Text = SelectWeek(CDate(Format(DateAdd(DateInterval.Day, 6, Now), "MM-dd")).DayOfWeek)

    End Sub

    ''' <summary>
    ''' 判断每天属於星期几   2014/07/08 杨
    ''' </summary>
    ''' <param name="strInt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function SelectWeek(ByVal strInt As Integer)

        Select Case strInt
            Case 0
                SelectWeek = "星期天"
            Case 1
                SelectWeek = "星期一"
            Case 2
                SelectWeek = "星期二"
            Case 3
                SelectWeek = "星期三"
            Case 4
                SelectWeek = "星期四"
            Case 5
                SelectWeek = "星期五"
            Case 6
                SelectWeek = "星期六"
            Case Else
                SelectWeek = "无效"
        End Select

    End Function

    ''' <summary>
    ''' 得到每天代办事宜记录数   2014/07/08 杨
    ''' </summary>
    ''' <param name="strDate"></param>
    ''' <remarks></remarks>
    Sub LoadDayCount(ByVal strDate As Date)

    End Sub

#Region "显示待办事项事件  2014/12/15"

    ''' <summary>
    ''' 显示过去待办事项
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BeforeToday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl7.Click, RectangleShape2.Click, LabelControl1.Click, PanelControl2.Click
        LoadMyToDoSeek("datediff(D,TD_StartDate ,getdate())>0")
    End Sub

    ''' <summary>
    ''' 显示今天待办事项
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Today_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl3.Click, LabelControl5.Click, LabelControl2.Click, RectangleShape10.Click
        LoadMyToDoSeek("datediff(D,TD_StartDate ,getdate())=0")
    End Sub

    ''' <summary>
    ''' 显示明天待办事项
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TodayPlusOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl8.Click, RectangleShape3.Click, LabelControl9.Click, LabelControl6.Click, PanelControl4.Click
        LoadMyToDoSeek("datediff(D,TD_StartDate ,getdate())=-1")
    End Sub

    ''' <summary>
    ''' 显示後天待办事项
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TodayPlusTwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl11.Click, RectangleShape4.Click, LabelControl12.Click, LabelControl10.Click, PanelControl5.Click
        LoadMyToDoSeek("datediff(D,TD_StartDate ,getdate())=-2")
    End Sub

    ''' <summary>
    ''' 显示大後天待办事项
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TodayPlusThree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl14.Click, RectangleShape5.Click, LabelControl15.Click, LabelControl13.Click, PanelControl6.Click
        LoadMyToDoSeek("datediff(D,TD_StartDate ,getdate())=-3")
    End Sub

    ''' <summary>
    ''' 显示大大後天待办事项
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TodayPlusFour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl17.Click, RectangleShape6.Click, LabelControl18.Click, LabelControl16.Click, PanelControl7.Click
        LoadMyToDoSeek("datediff(D,TD_StartDate ,getdate())=-4")
    End Sub

    ''' <summary>
    ''' 显示大大大後天待办事项
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TodayPlusFive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl20.Click, RectangleShape7.Click, LabelControl21.Click, LabelControl19.Click, PanelControl8.Click
        LoadMyToDoSeek("datediff(D,TD_StartDate ,getdate())=-5")
    End Sub

    ''' <summary>
    ''' 显示大大大大後天待办事项
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub LabelControl23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl23.Click, RectangleShape8.Click, LabelControl24.Click, LabelControl22.Click, PanelControl9.Click
        LoadMyToDoSeek("datediff(D,TD_StartDate ,getdate())=-6")
    End Sub

    ''' <summary>
    ''' 显示将来待办事项
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Furture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl26.Click, RectangleShape9.Click, LabelControl27.Click, PanelControl10.Click
        LoadMyToDoSeek("datediff(D,TD_StartDate ,getdate())<-6")
    End Sub

#End Region


End Class
