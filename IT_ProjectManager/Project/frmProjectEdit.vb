Imports System.IO
Imports System.Text
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class frmProjectEdit

    Dim Tlist As New StringBuilder
    ''' <summary>
    ''' 是否处理超期项目
    ''' </summary>
    ''' <remarks></remarks>
    Public replyExtended As Boolean = False
    Private mode As Integer = 0

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

#Region "导入初始数据"

    ''' <summary>
    ''' 导入公司
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData_Company()

        Dim dt As New DataTable
        Dim sql As String = Nothing
        sql = "SELECT *  FROM ATL_HD_Company order  by CompanyNo"
        dt = getDataTables(sql)

        If dt.Rows.Count = 0 Then
            cboCompany.Properties.DataSource = Nothing
        End If

        cboCompany.Properties.ValueMember = "ID"
        cboCompany.Properties.DisplayMember = "CompanyName"
        cboCompany.Properties.DataSource = dt
        'cboPrjStatus.Properties.PopulateColumns()
        cboCompany.EditValue = 2
        dt.Dispose()

    End Sub
    ''' <summary>
    ''' 导入跟进人
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData_SmFollow()

        Dim dt As New DataTable
        Dim sql As String = Nothing
        sql = "SELECT *  FROM ATL_HD_UserGroups where ServiceTypeID='1'  and IsDimission=0 order by userno"
        dt = getDataTables(sql)

        If dt.Rows.Count = 0 Then
            cboSmFollow.Properties.DataSource = Nothing
        End If

        cboSmFollow.Properties.ValueMember = "UserNo"
        cboSmFollow.Properties.DisplayMember = "UserName"
        cboSmFollow.Properties.DataSource = dt
        dt.Dispose()

    End Sub
    ''' <summary>
    ''' 导入负责人
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData_SmPrincipal()

        Dim dt As New DataTable
        Dim sql As String = Nothing
        sql = "SELECT *  FROM ATL_HD_UserGroups where ServiceTypeID='1' and IsDimission=0 order by userno"
        dt = getDataTables(sql)

        If dt.Rows.Count = 0 Then
            cboSmPrincipal.Properties.DataSource = Nothing
        End If

        cboSmPrincipal.Properties.ValueMember = "UserName"
        cboSmPrincipal.Properties.DisplayMember = "UserName"
        cboSmPrincipal.Properties.DataSource = dt
        dt.Dispose()

    End Sub
    ''' <summary>
    ''' 导入重要度
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData_Important()

        Dim dt As New DataTable
        Dim sql As String = Nothing
        sql = "SELECT *  FROM IT_ProStatus where ParentID='4'"
        dt = getDataTables(sql)

        If dt.Rows.Count = 0 Then
            cboImportant.Properties.DataSource = Nothing
        End If

        cboImportant.Properties.ValueMember = "ID"
        cboImportant.Properties.DisplayMember = "ProStatus"
        cboImportant.Properties.DataSource = dt
        cboImportant.EditValue = 21
        dt.Dispose()

    End Sub
    ''' <summary>
    ''' 导入进度状态
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData_smStatus()

        Dim dt As New DataTable
        Dim sql As String = Nothing
        sql = "SELECT *  FROM IT_ProStatus where ParentID='3' and ProStatus<>'完成'"
        dt = getDataTables(sql)

        If dt.Rows.Count = 0 Then
            cbosmStatus.Properties.DataSource = Nothing
        End If

        cbosmStatus.Properties.ValueMember = "ID"
        cbosmStatus.Properties.DisplayMember = "ProStatus"
        cbosmStatus.Properties.DataSource = dt
        cbosmStatus.EditValue = 16
        dt.Dispose()

    End Sub
    ''' <summary>
    ''' 导入类别
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData_SmType()

        Dim dt As New DataTable
        Dim sql As String = Nothing
        sql = "SELECT *  FROM IT_ProStatus where ParentID='2'"
        dt = getDataTables(sql)

        If dt.Rows.Count = 0 Then
            cboSmType.Properties.DataSource = Nothing
        End If

        cboSmType.Properties.ValueMember = "ID"
        cboSmType.Properties.DisplayMember = "ProStatus"
        cboSmType.Properties.DataSource = dt
        cboSmType.EditValue = 16
        dt.Dispose()

    End Sub

    ''' <summary>
    ''' 载入文档列表
    ''' 曹成波，20131014
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoalData_FileList()

        Dim sql As String = "select ProjectName from IT_FilesManager where P_ID='0'"
        Dim dt As New DataTable

        dt = getDataTables(sql)
        LUEProlist.Properties.DataSource = dt
        LUEProlist.Properties.DisplayMember = "ProjectName"
        LUEProlist.Properties.ValueMember = "ProjectName"
        dt.Dispose()
    End Sub
    ''' <summary>
    ''' 保存新增数据
    ''' </summary>
    ''' <remarks></remarks>
    Function SaveDataNew() As Boolean

        result = True
        Dim sql As String = Nothing
        sql = "INSERT INTO IT_Scheme (SchemeName,SmPrincipal,SmFollow,SmType,SmStatus,Important,Emergency," _
             & "Company,Department,Linkman,SmstartDate,SmEndDate,Explain,CreatedBy,CreatedTime) Values ('" _
        & txtSchemeName.Text & "','" & cboSmPrincipal.EditValue & "','" & cboSmFollow.EditValue & "','" & cboSmType.EditValue & "'," _
         & cbosmStatus.EditValue & ",'" & cboImportant.EditValue & "','" & cboEmergency.EditValue & "','" & cboCompany.EditValue & "','" _
      & txtDepartment.Text & "','" & txtLinkman.Text & "','" & Format(SmStartDate.DateTime, "yyyy-MM-dd HH:mm:ss") & "'," _
        & "'" & Format(SmEndDate.DateTime, "yyyy-MM-dd HH:mm:ss") & "','" & txtExplain.Text & "','" & UserID & "','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "')"

        Try
            ExecuteNonQuery(sql)
        Catch
            result = False
        End Try

        Return result

    End Function
    ''' <summary>
    ''' 保存修改数据
    ''' </summary>
    ''' <remarks></remarks>
    Function SaveDataEdit() As Boolean

        result = True
        Dim sql As String = Nothing
        sql = "UPDATE IT_Scheme SET SchemeName='" & txtSchemeName.Text & "',SmPrincipal='" & cboSmPrincipal.EditValue & "',SmFollow='" & cboSmFollow.EditValue & "'," _
            & "SmType='" & cboSmType.EditValue & "',SmStatus=" & cbosmStatus.EditValue & ",Important='" & cboImportant.EditValue & "',Emergency='" & cboEmergency.EditValue & "'," _
             & "Company='" & cboCompany.EditValue & "',Department='" & txtDepartment.Text & "',Linkman='" & txtLinkman.Text & "',SmstartDate='" & Format(SmStartDate.DateTime, "yyyy-MM-dd HH:mm:ss") & "'," _
             & "SmEndDate='" & Format(SmEndDate.DateTime, "yyyy-MM-dd HH:mm:ss") & "',Explain='" & txtExplain.Text & "',ModifiedBy='" & UserID & "',ModifiedTime='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "' " _
             & " where id=" & labID.Text
        Try
            ExecuteNonQuery(sql)
        Catch
            result = False
        End Try

        Return result

    End Function
    ''' <summary>
    ''' 加载超期回覆信息
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadRelpy()
        Dim sql As String = " select * from IT_PrjReplyExtended where Scheme_ID='" & labID.Text & "'"
        Dim dt As New DataTable
        dt = getDataTables(sql)
        If dt.Rows.Count > 0 Then
            Grid.DataSource = dt
        Else
            Grid.DataSource = Nothing
        End If
        dt.Dispose()
    End Sub

#End Region

    Private Sub frmProjectEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '初始化
        lblClear()

        LoadData_smStatus()
        LoadData_Important()
        LoadData_SmPrincipal()
        LoadData_SmFollow()
        LoadData_Company()
        LoadData_SmType()
        LoalData_FileList()
        If (Me.mode = 0) Then
            LabelControl31.Visible = False
            LabelControl32.Visible = False
            replyStartDate.Visible = False
        End If
        If replyExtended Then ''超期回覆
            gcDesignate.Visible = True
            PanelControl1.Enabled = False
            PanelControl2.Enabled = False
            PanelControl3.Enabled = False
            LoadEditData()
            loadRelpy()
            replyEndDate.Focus()
        ElseIf Edit Then '' 修改
            LoadEditData()
        End If

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If Len(txtSchemeName.Text) = 0 Then
            MessageBox.Show("请输入项目名称!", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSchemeName.Focus()
            Exit Sub
        End If

        If Len(cboCompany.EditValue) = 0 Then
            MessageBox.Show("请选择公司!", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboCompany.Focus()
            Exit Sub
        End If

        If Len(cboSmFollow.EditValue) = 0 Then
            MessageBox.Show("请选择项目跟进人!", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboSmFollow.Focus()
            Exit Sub
        End If

        If Len(cboSmPrincipal.EditValue) = 0 Then
            MessageBox.Show("请选择项目负责人!", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboSmPrincipal.Focus()
            Exit Sub
        End If

        If Len(cboSmType.EditValue) = 0 Then
            MessageBox.Show("请输入项目类型!", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboSmType.Focus()
            Exit Sub
        End If

        If Len(cboImportant.EditValue) = 0 Then
            MessageBox.Show("请输入项目重要度!", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboImportant.Focus()
            Exit Sub
        End If

        If Len(cbosmStatus.EditValue) = 0 Then
            MessageBox.Show("请输入项目状态!", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbosmStatus.Focus()
            Exit Sub
        End If

        If Len(cboEmergency.EditValue) = 0 Then
            MessageBox.Show("请输入项目优先度!", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboEmergency.Focus()
            Exit Sub
        End If

        If CDate(Format(SmStartDate.DateTime, "yyyy-MM-dd")) > CDate(Format(SmEndDate.DateTime, "yyyy-MM-dd")) Then
            MessageBox.Show("开始日期大於结束日期，不能保存！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If ProList.Items.Count > 0 Then

            '' 插入关联数据
            For i As Integer = 0 To ProList.Items.Count - 1 Step 1

                Tlist.Append(" update IT_FilesManager set SchemeName='" & txtSchemeName.Text.Trim() & _
                             "' where ProjectName='" & ProList.Items(i).ToString().Trim() & "'")
            Next

            ''执行SQL
            If ExecuteNonQuery(Tlist.ToString()) < 1 Then
                MessageBox.Show("文档与项目之间关联失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        End If

        If Edit = False Then
            If SaveDataNew() Then
                MessageBox.Show("保存成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                isRefresh = True
                lblClear()
                Me.Close()
            Else
                MessageBox.Show("保存失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If SaveDataEdit() Then
                MessageBox.Show("修改成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                isRefresh = True
                lblClear()
                Me.Close()
            Else
                MessageBox.Show("修改失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub
    ''' <summary>
    ''' 清空控件
    ''' </summary>
    ''' <remarks></remarks>
    Sub lblClear()
        txtSchemeName.Text = ""
        txtDepartment.Text = ""
        txtLinkman.Text = ""
        txtExplain.Text = ""
        cboCompany.EditValue = ""
        cboSmFollow.EditValue = ""
        cboSmPrincipal.EditValue = ""
        cboSmType.EditValue = ""
        cboImportant.EditValue = ""
        cbosmStatus.EditValue = ""
        cboEmergency.EditValue = ""
        ProList.Items.Clear()
    End Sub
    ''' <summary>
    ''' 导入项目资料
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadEditData()

        Dim strsql As String
        strsql = "select *  from IT_Scheme where ID='" & labID.Text & "'"
        Dim dt As New DataTable

        dt = getDataTables(strsql)

        txtSchemeName.Text = dt.Rows(0)("SchemeName")
        txtDepartment.Text = dt.Rows(0)("Department")
        txtLinkman.Text = dt.Rows(0)("Linkman")
        txtExplain.Text = dt.Rows(0)("Explain")
        cboCompany.EditValue = dt.Rows(0)("Company")
        cboSmFollow.EditValue = dt.Rows(0)("SmFollow")
        cboSmPrincipal.EditValue = dt.Rows(0)("SmPrincipal")
        cboSmType.EditValue = dt.Rows(0)("SmType")
        cboImportant.EditValue = dt.Rows(0)("Important")
        cbosmStatus.EditValue = dt.Rows(0)("smStatus")
        cboEmergency.EditValue = dt.Rows(0)("Emergency")
        SmStartDate.DateTime = CDate(dt.Rows(0)("SmStartDate"))
        SmEndDate.DateTime = CDate(dt.Rows(0)("SmEndDate"))


        ''编辑状态 载入关联文档
        Dim sql As String = Nothing
        sql = "select ProjectName from IT_FilesManager where SchemeName='" & txtSchemeName.Text & "' "
        Dim dt1 As New DataTable

        dt1 = getDataTables(sql)
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt1.Rows.Count - 1 Step 1
                ProList.Items.Add(dt1.Rows(i)(0).ToString.Trim())
            Next
        End If

        dt.Dispose()
        dt1.Dispose()

    End Sub

#Region "回车键处理"
    Private Sub txtSchemeName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSchemeName.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboCompany.Focus()
        End If
    End Sub

    Private Sub cboCompany_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCompany.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboSmFollow.Focus()
        End If
    End Sub

    Private Sub cboSmFollow_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSmFollow.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboSmPrincipal.Focus()
        End If
    End Sub

    Private Sub cboSmPrincipal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSmPrincipal.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboSmType.Focus()
        End If
    End Sub

    Private Sub cboSmType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSmType.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboImportant.Focus()
        End If
    End Sub

    Private Sub cboImportant_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboImportant.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDepartment.Focus()
        End If
    End Sub

    Private Sub txtDepartment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDepartment.KeyDown
        If e.KeyCode = Keys.Enter Then
            SmStartDate.Focus()
        End If
    End Sub

    Private Sub SmStartDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SmStartDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SmEndDate.Focus()
        End If
    End Sub

    Private Sub SmEndDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SmEndDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbosmStatus.Focus()
        End If
    End Sub

    Private Sub cbosmStatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbosmStatus.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboEmergency.Focus()
        End If
    End Sub

    Private Sub cboEmergency_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboEmergency.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtLinkman.Focus()
        End If
    End Sub

    Private Sub txtLinkman_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLinkman.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtExplain.Focus()
        End If
    End Sub
#End Region

    '' 增加文档清单
    Private Sub LUEProlist_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LUEProlist.EditValueChanged

        Dim proName As String = Nothing
        proName = LUEProlist.Text.Trim()

        For i As Integer = 0 To ProList.Items.Count - 1 Step 1
            If proName = ProList.Items(i).ToString().Trim() Then
                MessageBox.Show("文档名称【" & ProList.Items(i).ToString() & "】已存在？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ProList.SelectedIndex = i
                Return
            End If
        Next

        ProList.Items.Add(proName)
    End Sub

    '' 关闭窗体
    Private Sub btExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExit.Click
        Me.Close()
    End Sub

    Private Sub btReply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReply.Click

        If replyEndDate.EditValue = Nothing Then
            replyEndDate.Focus()
            MessageBox.Show("请选择调整日期？", "项目管理管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If replyStartDate.Visible Then
            If replyStartDate.EditValue = Nothing Then
                replyStartDate.Focus()
                MessageBox.Show("请选择调整日期？", "项目管理管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If



            If CDate(replyEndDate.EditValue) < SmEndDate.EditValue Then
                replyEndDate.Focus()
                MessageBox.Show("调整后的计划完成日期不能小於计划日期？", "项目管理管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        '''''''''''''''''''''''''' 超期处理
        If (Me.mode = 0) Then
            If Len(txtreply.Text.Trim()) = 0 Then
                txtreply.Focus()
                MessageBox.Show("请回覆超期原因？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            '' 保存数据处理 
            Dim strSB As New System.Text.StringBuilder
            '' 事务开始
            strSB.Append("Set   Xact_abort  on  begin tran")

            '' 更新项目结束日期
            strSB.Append(" update  IT_Scheme set SmEndDate='" & replyEndDate.EditValue & "'  where ID='" & labID.Text & "'")
            ''插入超期版本
            strSB.Append("   insert into IT_PrjReplyExtended (Scheme_ID,EndTime,ExtendedRemark)")
            strSB.Append(" values('" & labID.Text & "','" & replyEndDate.EditValue & "','" & txtreply.Text & "')")

            ''事务结束标识
            strSB.Append(" commit tran ")

            Try
                If ExecuteNonQuery(strSB.ToString()) > 0 Then
                    isRefresh = True
                    MessageBox.Show("超期处理成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.Close()
                Else
                    MessageBox.Show("超期处理失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("超期处理未知错误？" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        '''''''''''''''''''''''''' 计划完成日期调时处理
        If (Me.mode = 1) Then
            If CDate(replyEndDate.EditValue) < replyStartDate.EditValue Then
                replyStartDate.Focus()
                MessageBox.Show("调整后的计划完成日期不能小於开始日期？", "项目管理管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim strSB As New System.Text.StringBuilder
            '' 事务开始
            strSB.Append("Set   Xact_abort  on  begin tran")

            '' 更新项目结束日期
            strSB.Append(" update  IT_Scheme set  SmStartDate='" & replyStartDate.EditValue & "', SmEndDate='" & replyEndDate.EditValue & "'  where ID='" & labID.Text & "'")


            ''事务结束标识
            strSB.Append(" commit tran ")

            Try
                If ExecuteNonQuery(strSB.ToString()) > 0 Then
                    isRefresh = True
                    MessageBox.Show("调整计划完成日期成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.Close()
                Else
                    MessageBox.Show("调整计划完成日期失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("调整计划完成日期未知错误？" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


    End Sub

    Public Sub New(ByVal _mode As Integer)

        ' 此调用是设计器所必需的。
        InitializeComponent()
        mode = _mode
        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub
End Class