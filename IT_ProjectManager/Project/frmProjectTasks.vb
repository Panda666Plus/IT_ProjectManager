Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Text.RegularExpressions


Public Class frmProjectTasks
    Dim GS_ID As Integer
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

#Region "初始化各数据来源"
    ''' <summary>
    ''' 导入状态
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData_Status()

        Dim dt As New DataTable

        Dim sql As String = Nothing

        sql = "SELECT *  FROM IT_ProStatus where ParentID='23'"
        dt = getDataTables(sql)

        If dt.Rows.Count = 0 Then
            cboAssStatus.Properties.DataSource = Nothing
        End If

        cboAssStatus.Properties.ValueMember = "ID"
        cboAssStatus.Properties.DisplayMember = "ProStatus"
        cboAssStatus.Properties.DataSource = dt
        'cboPrjStatus.Properties.PopulateColumns()
        cboAssStatus.EditValue = 24
        dt.Dispose()

    End Sub
    ''' <summary>
    ''' 导入跟进人
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData_AppointUid()

        Dim dt As New DataTable

        Dim sql As String = Nothing

        sql = "SELECT *  FROM ATL_HD_UserGroups where ServiceTypeID='1' and IsDimission=0  order by userno"
        dt = getDataTables(sql)


        dt.Columns.Add("pingyin")

        For Each dr As DataRow In dt.Rows
            dr("pingyin") = clsReadWriteInI.PinYinHelper.GetChineseSpell(dr("UserName"))
        Next




        If dt.Rows.Count = 0 Then
            cboAppointUid.Properties.DataSource = Nothing
        End If

        cboAppointUid.Properties.ValueMember = "UserNo"
        cboAppointUid.Properties.DisplayMember = "UserName"
        cboAppointUid.Properties.DataSource = dt
        dt.Dispose()

    End Sub
    ''' <summary>
    ''' 导入评分标准
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData_GradeStandard()

        Dim dt As New DataTable

        Dim sql As String = Nothing

        sql = "SELECT *  FROM IT_GradeStandard where GS_PID<>'0' and GS_Level<>'0'"
        dt = getDataTables(sql)

        If dt.Rows.Count = 0 Then
            cboGradeStandard.DataSource = Nothing
        End If

        cboGradeStandard.DataSource = dt
        dt.Dispose()

    End Sub

#End Region

    Private Sub frmProjectTasks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '' 载入状态
        LoadData_Status()
        '' 载入跟进人
        LoadData_AppointUid()
        '' 载入评分项目
        LoadData_GradeStandard()

        lblClear()

        If Edit = False Then
            cmdAdd.Visible = True
        Else
            cmdAdd.Visible = False
            LoadEditData()

        End If
        BarEditItem1.EditValue = Color.Black
        Me.BarEditItem3.EditValue = "SimSun"
        Me.BarEditItem4.EditValue = 10
        txtAssName.Focus()

    End Sub
    ''' <summary>
    ''' 初始化
    ''' </summary>
    ''' <remarks></remarks>
    Sub lblClear()

        txtAssName.Text = ""
        cboAppointUid.EditValue = ""
        cboEmergency.EditValue = 30
        StartDate.DateTime = Now
        EndDate.DateTime = DateAdd("d", 7, Now)
        cboAssStatus.EditValue = ""
        txtTaskDetail.Text = ""
        txtRemark.Text = ""

    End Sub
    ''' <summary>
    ''' 保存新增数据
    ''' </summary>
    ''' <remarks></remarks>
    Function SaveDataNew() As Boolean

        result = True

        Dim ms As New MemoryStream
        Me.txtTaskDetail.SaveFile(ms, RichTextBoxStreamType.RichText)
        Dim bp As Byte() = ms.GetBuffer()
        Dim sql As String = Nothing

        sql = "INSERT INTO IT_Assignment (PrjID,AssName,AppointUid,PreStatDate,PreEndDate,Emergency,AssState,TaskDetail,Explain,CreatedBy,CreatedTime,GS_ID) Values (" _
        & txtID.Text & ",'" & txtAssName.Text & "','" & cboAppointUid.EditValue & "','" & Format(StartDate.DateTime, "yyyy-MM-dd HH:mm:ss") & "'," _
        & "'" & Format(EndDate.DateTime, "yyyy-MM-dd HH:mm:ss") & "'," & cboEmergency.EditValue & ",'" & cboAssStatus.EditValue & "'," _
        & "'" & txtTaskDetail.Text & "','" & txtRemark.Text & "','" & UserID & "','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & GS_ID & "')" _
        & "update IT_Project set PrjStatus=25 where id='" & txtID.Text & "'"

        Try
            ExecuteNonQuery(sql)
            Dim params() As SqlParameter = {
                   New SqlParameter("@taskM", bp),
                   New SqlParameter("@id", txtID.Text)
            }



            DbServices.DbHelperSQL.ExecuteSql("UPDATE IT_Assignment SET TaskDetailM=@taskM where  ID=@id",
                                                      params)
        Catch
            result = False
        End Try

        Return result

    End Function

    ''' <summary>
    ''' 保存修改资料
    ''' </summary>
    ''' <remarks></remarks>
    Function SaveDataEdit() As Boolean

        result = True

        Dim ms As New MemoryStream
        Me.txtTaskDetail.SaveFile(ms, RichTextBoxStreamType.RichText)
        Dim bp As Byte() = ms.GetBuffer()
        Dim sql As String = Nothing
        sql = "UPDATE IT_Assignment SET AssName='" & txtAssName.Text & "',AppointUid='" & cboAppointUid.EditValue & "'," _
            & "PreStatDate='" & Format(StartDate.DateTime, "yyyy-MM-dd HH:mm:ss") & "',PreEndDate='" & Format(EndDate.DateTime, "yyyy-MM-dd HH:mm:ss") & "'," _
            & "Emergency=" & cboEmergency.EditValue & ",AssState='" & cboAssStatus.EditValue & "',TaskDetail='" & txtTaskDetail.Text & "'," _
            & "Explain='" & txtRemark.Text & "',CreatedBy='" & UserID & "',CreatedTime='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "',GS_ID='" & GS_ID & "' WHERE ID=" & txtID.Text
        Try
            ExecuteNonQuery(sql)

            Dim params() As SqlParameter = {
                   New SqlParameter("@taskM", bp),
                   New SqlParameter("@id", txtID.Text)
            }



            DbServices.DbHelperSQL.ExecuteSql("UPDATE IT_Assignment SET TaskDetailM=@taskM where  ID=@id",
                                                      params)

        Catch
            result = False
        End Try

        Return result

    End Function

    ''' <summary>
    ''' 导入任务资料
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadEditData()

        Dim strsql As String

        strsql = String.Format("select IT_Assignment.*,IT_GradeStandard.GS_Name  from IT_Assignment left join IT_GradeStandard  on IT_Assignment.GS_ID=IT_GradeStandard.GS_ID  where ID='{0}'",
                               txtID.Text)
        Dim dt As New DataTable

        dt = getDataTables(strsql)

        txtAssName.Text = dt.Rows(0)("AssName")
        cboAssStatus.EditValue = dt.Rows(0)("AssState")
        cboEmergency.EditValue = dt.Rows(0)("Emergency")

        StartDate.DateTime = CDate(dt.Rows(0)("PreStatDate"))
        EndDate.DateTime = CDate(dt.Rows(0)("PreEndDate"))
        cboAppointUid.EditValue = dt.Rows(0)("AppointUid")
        txtRemark.EditValue = dt.Rows(0)("Explain")
        Try
            Dim mstream As MemoryStream
            If Not IsDBNull(dt.Rows(0)("TaskDetailM")) Then
                mstream = New MemoryStream(DirectCast(dt.Rows(0)("TaskDetailM"), Byte()))
                txtTaskDetail.LoadFile(mstream, RichTextBoxStreamType.RichText)
            End If

        Finally

            Try
                If (txtTaskDetail.Text.Trim() = "") Then
                    txtTaskDetail.Text = dt.Rows(0)("TaskDetail")
                End If
            Catch ex As Exception

            End Try

            getcboGradeStandardValue.EditValue = dt.Rows


            If Not IsDBNull(dt.Rows(0)("GS_ID")) Then
                GS_ID = dt.Rows(0)("GS_ID")
            End If
            If Not IsDBNull(dt.Rows(0)("GS_Name")) Then
                getcboGradeStandardValue.Text = dt.Rows(0)("GS_Name")
            Else
                getcboGradeStandardValue.Text = ""
            End If
            dt.Dispose()
            BarEditItem1.EditValue = Color.Black
            Me.BarEditItem3.EditValue = "SimSun"
            Me.BarEditItem4.EditValue = 10
            txtAssName.Focus()
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If Len(txtAssName.Text) = 0 Then
            MessageBox.Show("请输入名称!", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAssName.Focus()
            Exit Sub
        End If

        If Len(cboAppointUid.EditValue) = 0 Then
            MessageBox.Show("请选择项目跟进人!", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboAppointUid.Focus()
            Exit Sub
        End If

        If Len(cboEmergency.EditValue) = 0 Then
            MessageBox.Show("请输入项目重要度!", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboEmergency.Focus()
            Exit Sub
        End If

        If Len(cboAssStatus.EditValue) = 0 Then
            MessageBox.Show("请输入状态!", "a")
            cboAssStatus.Focus()
            Exit Sub
        End If

        If CDate(Format(StartDate.DateTime, "yyyy-MM-dd")) > CDate(Format(EndDate.DateTime, "yyyy-MM-dd")) Then
            MessageBox.Show("开始日期大於结束日期，不能保存！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim PreEndDate As DateTime = Nothing
        If (Me.Text = "添加任务") Then
            PreEndDate = DbServices.DbHelperSQL.Query(String.Format("select b.PreEndDate  from  IT_Project b where   b.id={0}",
                                                       txtID.Text)).Tables(0).Rows(0)(0)
        Else
            Dim ds As New DataSet
            ds = DbServices.DbHelperSQL.Query(String.Format("select b.PreEndDate  from IT_Assignment a inner join IT_Project b on a.PrjID  =b.ID and  a.id={0}",
                                                         txtID.Text))

            If ds.Tables.Count > 0 Then
                If ds.Tables(0).Rows.Count > 0 Then
                    PreEndDate = ds.Tables(0).Rows(0)(0)   'and  a.id={0}
                End If


            End If


        End If
        'If CDate(Format(PreEndDate, "yyyy-MM-dd")) < CDate(Format(EndDate.DateTime, "yyyy-MM-dd")) Then
        '    MessageBox.Show("结束日期大于模块结束日期" & Format(PreEndDate, "yyyy-MM-dd") & "，不能保存?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        If Len(txtTaskDetail.Text) = 0 Then
            MessageBox.Show("请输入任务详细!", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTaskDetail.Focus()
            Exit Sub
        End If

        If Edit = False Then
            If Not SaveDataNew() Then
                MessageBox.Show("保存失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            If Not SaveDataEdit() Then
                MessageBox.Show("修改失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        MessageBox.Show("操作成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        isRefresh = True

        lblClear()
        Me.Close()


    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click

        If Len(txtAssName.Text) = 0 Then
            MessageBox.Show("请输入名称？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAssName.Focus()
            Exit Sub
        End If

        If Len(cboAppointUid.EditValue) = 0 Then
            MessageBox.Show("请选择项目跟进人？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboAppointUid.Focus()
            Exit Sub
        End If

        If Len(cboEmergency.EditValue) = 0 Then
            MessageBox.Show("请输入优先度？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboEmergency.Focus()
            Exit Sub
        End If

        If Len(cboAssStatus.EditValue) = 0 Then
            MessageBox.Show("请输入状态？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboAssStatus.Focus()
            Exit Sub
        End If

        If Len(txtTaskDetail.Text) = 0 Then
            MessageBox.Show("请输入任务详细？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTaskDetail.Focus()
            Exit Sub
        End If

        If CDate(Format(StartDate.DateTime, "yyyy-MM-dd")) > CDate(Format(EndDate.DateTime, "yyyy-MM-dd")) Then
            MessageBox.Show("开始日期大於结束日期，不能保存？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If SaveDataNew() Then
            isRefresh = True
            lblClear()
            txtAssName.Focus()
        Else
            MessageBox.Show("保存失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

#Region "回车键处理"
    Private Sub txtAssName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAssName.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboAppointUid.Focus()
        End If
    End Sub

    Private Sub cboAppointUid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboAppointUid.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboAssStatus.Focus()
        End If
        Dim regex As New Regex("^[a-zA-Z]$")
        If regex.Match(e.KeyCode.ToString()).Success Then
            cboAppointUid.Tag = cboAppointUid.Tag + e.KeyCode.ToString()
            Dim dt As DataTable = DirectCast(cboAppointUid.Properties.DataSource, DataTable)
            dt.DefaultView.RowFilter = String.Format("pingyin like '{0}%'", cboAppointUid.Tag.ToString())
            cboAppointUid.ClosePopup()
            cboAppointUid.ShowPopup()

        End If
        If e.KeyValue = 8 Then
            If cboAppointUid.Tag.ToString().Length > 0 Then
                cboAppointUid.Tag = cboAppointUid.Tag.ToString().Substring(0, cboAppointUid.Tag.ToString().Length - 1)
                Dim dt As DataTable = DirectCast(cboAppointUid.Properties.DataSource, DataTable)
                dt.DefaultView.RowFilter = String.Format("pingyin like '{0}%'", cboAppointUid.Tag.ToString())
                cboAppointUid.ClosePopup()
                cboAppointUid.ShowPopup()
            End If
        End If
        If e.KeyValue = 27 Then
            cboAppointUid.Tag = ""
            Dim dt As DataTable = DirectCast(cboAppointUid.Properties.DataSource, DataTable)
            dt.DefaultView.RowFilter = String.Format("pingyin like '{0}%'", cboAppointUid.Tag.ToString())
            cboAppointUid.ClosePopup()
            cboAppointUid.ShowPopup()
        End If





    End Sub

    Private Sub cboAssStatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboAssStatus.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboEmergency.Focus()
        End If
    End Sub

    Private Sub cboEmergency_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboEmergency.KeyDown
        If e.KeyCode = Keys.Enter Then
            StartDate.Focus()
        End If
    End Sub

    Private Sub StartDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles StartDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            EndDate.Focus()
        End If
    End Sub

    Private Sub EndDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles EndDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboGradeStandard.Focus()
        End If
    End Sub
#End Region

    Private Sub cboGradeStandard_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtTaskDetail.Focus()
        End If
    End Sub

    Private Sub cboGradeStandard_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles cboGradeStandard.FocusedNodeChanged
        GS_ID = cboGradeStandard.FocusedNode.GetValue("GS_ID")
        getcboGradeStandardValue.Text = cboGradeStandard.FocusedNode.GetValue("GS_Name")
    End Sub


    Private Sub BarEditItem1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarEditItem1.EditValueChanged
        txtTaskDetail.SelectionColor = BarEditItem1.EditValue
    End Sub

    Private Sub BarEditItem2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarEditItem2.EditValueChanged
        txtTaskDetail.SelectionBackColor = BarEditItem2.EditValue
    End Sub

    Private Sub BarCheckItem1_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem1.CheckedChanged
        Dim fontold As Font = txtTaskDetail.SelectionFont
        Dim fontnew As Font
        If IsNothing(fontold) Then
            fontold = Me.txtTaskDetail.Font
        End If
        If (BarCheckItem1.Checked) Then
            fontnew = New Font(fontold, FontStyle.Bold)
        Else
            fontnew = New Font(fontold, fontold.Style And (Not FontStyle.Bold))
        End If
        txtTaskDetail.SelectionFont = fontnew
    End Sub

    Private Sub BarEditItem3_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarEditItem3.EditValueChanged
        Dim fontold As Font = txtTaskDetail.SelectionFont
        Dim fontnew As Font
        If IsNothing(fontold) Then
            fontold = Me.txtTaskDetail.Font
        End If
        fontnew = New Font(DirectCast(BarEditItem3.EditValue, String), fontold.Size, fontold.Style)
        txtTaskDetail.SelectionFont = fontnew
    End Sub

    Private Sub BarEditItem4_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarEditItem4.EditValueChanged
        Dim fontold As Font = txtTaskDetail.SelectionFont
        Dim fontnew As Font
        If IsNothing(fontold) Then
            fontold = Me.txtTaskDetail.Font
        End If
        fontnew = New Font(fontold.FontFamily, BarEditItem4.EditValue, fontold.Style)
        txtTaskDetail.SelectionFont = fontnew
    End Sub


End Class