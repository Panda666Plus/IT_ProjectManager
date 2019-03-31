Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class frmProjectSub

#Region "回车键处理"
    Private Sub txtPrjName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPrjName.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboDisGroup.Focus()
        End If
    End Sub
    Private Sub cboDisGroup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboDisGroup.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboPrjStatus.Focus()
        End If
    End Sub
    Private Sub cboPrjStatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPrjStatus.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboPriority.Focus()
        End If
    End Sub
    Private Sub cboPriority_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPriority.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtForLinkman.Focus()
        End If
    End Sub
    Private Sub txtForLinkman_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtForLinkman.KeyDown
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
            cboFollowUID.Focus()
        End If
    End Sub
    Private Sub cboFollowUID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboFollowUID.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboPrincipalUID.Focus()
        End If
    End Sub
    Private Sub cboPrincipalUID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPrincipalUID.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRemark.Focus()
        End If
    End Sub
#End Region

#Region "初始化各数据来源"
    ''' <summary>
    ''' 导入状态
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData_PrjStatus()

        Dim dt As New DataTable
        Dim sql As String
        sql = "SELECT *  FROM IT_ProStatus where ParentID='23'"
        dt = getDataTables(sql)

        If dt.Rows.Count = 0 Then
            cboPrjStatus.Properties.DataSource = Nothing
        End If

        cboPrjStatus.Properties.ValueMember = "ID"
        cboPrjStatus.Properties.DisplayMember = "ProStatus"
        cboPrjStatus.Properties.DataSource = dt
        'cboPrjStatus.Properties.PopulateColumns()
        cboPrjStatus.EditValue = 24
        dt.Dispose()

    End Sub
    ''' <summary>
    ''' 导入组别
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData_DisGroup()

        Dim dt As New DataTable
        Dim sql As String = Nothing
        sql = "SELECT *  FROM IT_Member where ParentID='1'"
        dt = getDataTables(sql)

        If dt.Rows.Count = 0 Then
            cboDisGroup.Properties.DataSource = Nothing
        End If

        cboDisGroup.Properties.ValueMember = "ID"
        cboDisGroup.Properties.DisplayMember = "GName"
        cboDisGroup.Properties.DataSource = dt
        ' cboDisGroup.Properties.PopulateColumns()
        'cboPrjStatus.EditValue = 27
        dt.Dispose()

    End Sub
    ''' <summary>
    ''' 导入跟进人
    ''' 导入负责人
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData_FollowUID()

        Dim dt As New DataTable
        Dim sql As String = Nothing
        sql = "SELECT *  FROM ATL_HD_UserGroups where ServiceTypeID='1' and IsDimission=0  order by userno"

        dt = getDataTables(sql)

        If dt.Rows.Count = 0 Then
            cboFollowUID.Properties.DataSource = Nothing
            cboPrincipalUID.Properties.DataSource = Nothing
        End If

        cboFollowUID.Properties.ValueMember = "UserNo"
        cboFollowUID.Properties.DisplayMember = "UserName"
        cboFollowUID.Properties.DataSource = dt

        cboPrincipalUID.Properties.ValueMember = "UserName"
        cboPrincipalUID.Properties.DisplayMember = "UserName"
        cboPrincipalUID.Properties.DataSource = dt

        dt.Dispose()

    End Sub

#End Region

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub frmProjectSub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        lblClear()

        LoadData_PrjStatus()
        LoadData_DisGroup()
        LoadData_FollowUID()


        If Edit = False Then
            cmdAdd.Visible = True
        Else
            LoadEditData()
            cmdAdd.Visible = False
        End If

        txtPrjName.Focus()

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click

        If Len(txtPrjName.Text) = 0 Then
            MessageBox.Show("请输入名称？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPrjName.Focus()
            Exit Sub
        End If

        If Len(cboDisGroup.EditValue) = 0 Then
            MessageBox.Show("请选择组别?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboDisGroup.Focus()
            Exit Sub
        End If

        If Len(cboFollowUID.EditValue) = 0 Then
            MessageBox.Show("请选择项目跟进人?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboFollowUID.Focus()
            Exit Sub
        End If

        If Len(cboPriority.EditValue) = 0 Then
            MessageBox.Show("请输入负责人?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboPriority.Focus()
            Exit Sub
        End If

        If Len(cboPrincipalUID.EditValue) = 0 Then
            MessageBox.Show("请输入项目重要度?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboPrincipalUID.Focus()
            Exit Sub
        End If

        If Len(cboPrjStatus.EditValue) = 0 Then
            MessageBox.Show("请输入状态?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboPrjStatus.Focus()
            Exit Sub
        End If

        '  If DateDiff("d", StartDate.DateTime, EndDate.DateTime) < -1 Then
        If CDate(Format(StartDate.DateTime, "yyyy-MM-dd")) > CDate(Format(EndDate.DateTime, "yyyy-MM-dd")) Then
            MessageBox.Show("开始日期大於结束日期，不能保存?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If SaveDataNew() Then

            lblClear()

            txtPrjName.Focus()

            isRefresh = True

            MessageBox.Show("保存成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Else
            MessageBox.Show("保存失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    ''' <summary>
    ''' 初始化
    ''' </summary>
    ''' <remarks></remarks>
    Sub lblClear()

        txtPrjName.Text = ""
        cboDisGroup.EditValue = ""
        cboPrjStatus.EditValue = ""
        cboPriority.EditValue = 30
        txtForLinkman.Text = ""
        StartDate.DateTime = Now
        EndDate.DateTime = DateAdd("d", 7, Now)
        cboFollowUID.EditValue = ""
        cboPrincipalUID.EditValue = ""
        txtRemark.EditValue = ""

    End Sub
    ''' <summary>
    ''' 保存新增数据
    ''' </summary>
    ''' <remarks></remarks>
    Function SaveDataNew() As Boolean

        result = True
        Dim sql As String = Nothing
        sql = "INSERT INTO IT_Project (SchemeID,PrjName,DisGroup,PreStatDate,PreEndDate,PrjStatus,Priority,PrincipalUID,FollowUID,ForLinkman,Explain,CreatedBy,CreatedTime) Values (" _
        & txtID.Text & ",'" & txtPrjName.Text & "','" & cboDisGroup.EditValue & "','" & Format(StartDate.DateTime, "yyyy-MM-dd HH:mm:ss") & "'," _
        & "'" & Format(EndDate.DateTime, "yyyy-MM-dd HH:mm:ss") & "'," & cboPrjStatus.EditValue & ",'" & cboPriority.Text & "','" & cboPrincipalUID.EditValue & "'," _
        & "'" & cboFollowUID.EditValue & "','" & txtForLinkman.Text & "','" & txtRemark.Text & "','" & UserID & "','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "')  "
        Try
            ExecuteNonQuery(sql)
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
        Dim sql As String = Nothing
        sql = "UPDATE IT_Project SET PrjName='" & txtPrjName.Text & "',DisGroup='" & cboDisGroup.EditValue & "',PreStatDate='" & Format(StartDate.DateTime, "yyyy-MM-dd HH:mm:ss") & "'," _
            & "PreEndDate='" & Format(EndDate.DateTime, "yyyy-MM-dd HH:mm:ss") & "',PrjStatus=" & cboPrjStatus.EditValue & ",Priority='" & cboPriority.Text & "'," _
            & "PrincipalUID='" & cboPrincipalUID.EditValue & "',FollowUID='" & cboFollowUID.EditValue & "',ForLinkman='" & txtForLinkman.Text & "',Explain='" & txtRemark.Text & "'," _
            & "ModifiedBy='" & UserID & "',ModifiedTime='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "' where id='" & txtID.Text & "'"
        Try

            ExecuteNonQuery(sql)

        Catch
            result = False
        End Try

        Return result

    End Function

    ''' <summary>
    ''' 导入项目资料
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadEditData()
        '
        Dim strsql As String

        strsql = "select *  from IT_Project where ID='" & txtID.Text & "'"
        Dim intresult As Integer = -1
        Dim dt As New DataTable

        dt = getDataTables(strsql)

        txtPrjName.Text = dt.Rows(0)("PrjName")
        If (Integer.TryParse(dt.Rows(0)("DisGroup"), intresult)) Then
            cboDisGroup.EditValue = intresult
        End If
        cboPrjStatus.EditValue = dt.Rows(0)("PrjStatus")
        cboPriority.EditValue = dt.Rows(0)("Priority")
        txtForLinkman.Text = dt.Rows(0)("ForLinkman")
        StartDate.DateTime = CDate(dt.Rows(0)("PreStatDate"))
        EndDate.DateTime = CDate(dt.Rows(0)("PreEndDate"))
        cboFollowUID.EditValue = dt.Rows(0)("FollowUID")
        cboPrincipalUID.EditValue = dt.Rows(0)("PrincipalUID")
        txtRemark.EditValue = dt.Rows(0)("Explain")

        dt.Dispose()

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If Len(txtPrjName.Text) = 0 Then
            MessageBox.Show("请输入名称?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPrjName.Focus()
            Exit Sub
        End If

        If Len(cboDisGroup.EditValue) = 0 Then
            MessageBox.Show("请选择组别?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboDisGroup.Focus()
            Exit Sub
        End If

        If Len(cboFollowUID.EditValue) = 0 Then
            MessageBox.Show("请选择项目跟进人?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboFollowUID.Focus()
            Exit Sub
        End If

        If Len(cboPriority.EditValue) = 0 Then
            MessageBox.Show("请输入负责人?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboPriority.Focus()
            Exit Sub
        End If

        If Len(cboPrincipalUID.EditValue) = 0 Then
            MessageBox.Show("请输入项目重要度?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboPrincipalUID.Focus()
            Exit Sub
        End If

        If Len(cboPrjStatus.EditValue) = 0 Then
            MessageBox.Show("请输入状态?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboPrjStatus.Focus()
            Exit Sub
        End If

        ' If DateDiff("d", StartDate.DateTime, EndDate.DateTime) < -1 Then
        If CDate(Format(StartDate.DateTime, "yyyy-MM-dd")) > CDate(Format(EndDate.DateTime, "yyyy-MM-dd")) Then
            MessageBox.Show("开始日期大於结束日期，不能保存?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim SmEndDate As DateTime = Nothing
        If (labName.Text = "新增模块") Then
            SmEndDate = DbServices.DbHelperSQL.Query(String.Format("select a.SmEndDate from IT_Scheme a where a.ID={0}",
                                                          txtID.Text)).Tables(0).Rows(0)(0)
        Else

            SmEndDate = DbServices.DbHelperSQL.Query(String.Format("select a.SmEndDate from IT_Scheme a inner join IT_Project b on a.ID =b.SchemeID  where b.ID={0}",
                                                          txtID.Text)).Tables(0).Rows(0)(0)
        End If
        If CDate(Format(SmEndDate, "yyyy-MM-dd")) < CDate(Format(EndDate.DateTime, "yyyy-MM-dd")) Then
            MessageBox.Show("结束日期大於项目结束日期" & Format(SmEndDate, "yyyy-MM-dd") & "，不能保存?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

End Class