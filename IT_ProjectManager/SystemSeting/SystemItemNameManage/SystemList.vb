Public Class SystemList

    ''' <summary>
    ''' 是否为修改状态
    ''' true表示是
    ''' false表示否
    ''' </summary>
    ''' <remarks></remarks>
    Public IsEdit As Boolean = False

    Public AutoID As String = Nothing

    Public TempPlD As Integer

    Public SysNameID As String = Nothing

    Public SysName As String = Nothing

    Public IsView As Boolean = False

    Dim SystemID As String = Nothing

    ''-----------2014/12/10       DEVON
    Dim ds As New DataSet
    ''------------------------------------

    ''' <summary>
    ''' 清空控件
    ''' </summary>
    ''' <remarks></remarks>
    Sub Clearlbl()
        txtSysName.Text = ""
        LUCompany.Text = ""
        lblnum.Text = ""
        SatartDT.Text = ""
        LEFollowManName.Properties.NullText = ""
        LUCompany.Properties.NullText = ""
        LEResponsibilityName.Properties.NullText = ""
        LECompetenceName.Properties.NullText = ""
        txtUseCompany.Text = ""
        txtUseDepartments.Text = ""
        meUseRemarks.Text = ""
        meSystemRemarks.Text = ""
    End Sub

    ''' <summary>
    ''' 关闭窗体
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Clearlbl()
        Me.Close()
    End Sub

    ''' <summary>
    ''' 保存数据
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click

        If IsView Then Exit Sub

        If SaveData() Then
            Me.Close()
        End If

    End Sub

    ''' <summary>
    ''' 保存新数据
    ''' </summary>
    ''' <remarks></remarks>
    Function SaveData() As Boolean

        SaveData = False

        If Len(txtSysName.Text) = 0 Then
            txtSysName.Focus()
            MessageBox.Show("请输入系统名称？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        If Len(LUCompany.Text) = 0 Then
            MessageBox.Show("请选择适用公司？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LUCompany.Focus()
            Exit Function
        End If

        If Len(SatartDT.Text) = 0 Then
            SatartDT.Focus()
            MessageBox.Show("请选择开始日期？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        If Len(LEFollowManName.Text) = 0 Then
            LEFollowManName.Focus()
            MessageBox.Show("请选择跟进人？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        If Len(LEResponsibilityName.Text) = 0 Then
            LEResponsibilityName.Focus()
            MessageBox.Show("请选择负责人？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        If Len(LECompetenceName.Text) = 0 Then
            LECompetenceName.Focus()
            MessageBox.Show("请选择权限管理员？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        If Len(txtUseCompany.Text) = 0 Then
            txtUseCompany.Focus()
            MessageBox.Show("请输入公司名称？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        If Len(txtUseDepartments.Text) = 0 Then
            txtUseDepartments.Focus()
            MessageBox.Show("请输入部门名称？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        ''-------2014/12/01 DEVON------------------
        If Len(lblnum.Text) = 0 Then
            lblnum.Focus()
            MessageBox.Show("请输入系统代号？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        If Len(Trim(gluSystemType.Text)) = 0 Then
            gluSystemType.Focus()
            MessageBox.Show("请输入系统类型？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        ''系统代号存在判断
        If Not IsEdit Then
            Dim sql As String = Nothing
            sql = "select * from IT_SystemNameManager where SystemID='" & lblnum.Text.Trim() & "'"
            Dim dt As New DataTable
            dt = getDataTables(sql)
            If dt.Rows.Count > 0 Then
                MessageBox.Show("系统代号： " & lblnum.Text.Trim() & " 已存在，请重新输入！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lblnum.Focus()
                Exit Function
            End If
        End If
        ''-----------------------------------------
        Dim number As Int16 = 17

        Dim strSB As New System.Text.StringBuilder

        If Not IsEdit Then
            strSB.Append("insert into IT_SystemNameManager values")
            'strSB.Append(" ('" & AutoID & "','" & lblnum.Text & "','" & txtSysName.Text.Trim() & "','" & LUCompany.Text & "','" & SatartDT.Text & "','" & LEFollowManName.Text.Trim())
            ''---2014/12/08    DEVON
            strSB.Append(" ('" & AutoID & "','" & lblnum.Text & "','" & number & "','" & txtSysName.Text.Trim() & "','" & gluSystemType.Text.Trim & "','" & LUCompany.Text.Trim() & "','" & SatartDT.Text & "','" & LEFollowManName.Text.Trim())
            strSB.Append("','" & LEFollowManName.EditValue & "','" & LEResponsibilityName.Text.Trim() & "','" & LEResponsibilityName.EditValue)
            strSB.Append("','" & LECompetenceName.Text.Trim() & "','" & LECompetenceName.EditValue & "','" & txtUseCompany.Text.Trim())
            strSB.Append("','" & txtUseDepartments.Text & "','" & meUseRemarks.Text.Trim() & "','" & meSystemRemarks.Text.Trim() & "')")
        Else
            strSB.Append("update IT_SystemNameManager set ")
            strSB.Append("   FollowManName='" & LEFollowManName.Text.Trim() & "', FollowManJob='" & LEFollowManName.EditValue & "', ResponsibilityName='" & LEResponsibilityName.Text.Trim())
            strSB.Append("', ResponsibilityJob='" & LEResponsibilityName.EditValue & "', CompetenceName='" & LECompetenceName.Text.Trim())
            strSB.Append("', CompetenceJob='" & LECompetenceName.EditValue & "', UseCompany='" & txtUseCompany.Text & "', UseDepartments='" & txtUseDepartments.Text)
            strSB.Append("', UseRemarks='" & meUseRemarks.Text.Trim() & "', SystemRemarks='" & meSystemRemarks.Text.Trim() & "'")
            ' strSB.Append(",  Company='" & LUCompany.Text & "',SystemID='" & lblnum.Text & "' where AutoID='" & AutoID & "'and PID='" & TempPlD & "' and SystemID='" & SysNameID & "' and SystemName='" & txtSysName.Text & "'")
            ' ''---2014/12/08    DEVON
            strSB.Append(",  Company='" & LUCompany.Text & "',SystemType='" & gluSystemType.Text.Trim() & "',SystemID='" & lblnum.Text & "' where AutoID='" & AutoID & "'and PID='" & TempPlD & "' and SystemID='" & SysNameID & "' and SystemName='" & txtSysName.Text & "'")
        End If

        Try
            If ExecuteNonQuery(strSB.ToString()) <> 1 Then
                MessageBox.Show("数据处理失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("操作成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                isRefresh = True
                Clearlbl()
                SaveData = True
            End If

        Catch ex As Exception
            MessageBox.Show("未知错误：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try
        strSB.Clear()
        Return SaveData

    End Function

    ''' <summary>
    ''' 更新数据
    ''' </summary>
    ''' <remarks></remarks>
    Sub updataData()

        Dim updata As String = Nothing

        Try
            If ExecuteNonQuery(updata) <> 1 Then
                MessageBox.Show("插入数据失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("操作成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("未知错误：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try

    End Sub

    ''' <summary>
    ''' 保存继续
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btAdds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdds.Click
        SaveData()
        '' 计算新的编号
        CalculateNum(lblnum.Text, SystemID)
        lblnum.Text = SystemID
        txtSysName.Focus()
    End Sub

    ''' <summary>
    '''  绑定数据
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SysListManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''-----------2014/12/08     DEVON
        CreateTable()
        ''-----------------------------------

        If IsView Then
            loadEditData()
            ReadOnlyControl()
        ElseIf IsEdit Then
            loadEditData()
            loadAllUser()
            LoadCompany()
            ''-----------2014/12/08     DEVON
            LoadSystemType()
            ''-----------------------------------
        Else
            loadAllUser()
            LoadCompany()
            ''-----------2014/12/08     DEVON
            LoadSystemType()
            ''-----------------------------------
            '' 计算ID
            getLastNum()
        End If

    End Sub

    ''-----------2014/12/08     DEVON
    ''' <summary>
    ''' 临时表
    ''' </summary>
    ''' <remarks></remarks>
    Sub CreateTable()
        ds.Clear()
        With ds.Tables.Add("SysType").Columns
            .Add("SystemType")
        End With
        gluSystemType.Properties.DataSource = ds.Tables("SysType")
    End Sub
    ''-----------------------------------

    ''' <summary>
    ''' 锁定控件
    ''' </summary>
    ''' <remarks></remarks>
    Sub ReadOnlyControl()
        txtSysName.Properties.ReadOnly = True
        LUCompany.Properties.ReadOnly = True
        SatartDT.Enabled = False
        LEFollowManName.Properties.ReadOnly = True
        LEResponsibilityName.Properties.ReadOnly = True
        LECompetenceName.Properties.ReadOnly = True
        txtUseCompany.Properties.ReadOnly = True
        txtUseDepartments.Properties.ReadOnly = True
        meUseRemarks.Properties.ReadOnly = True
        meSystemRemarks.Properties.ReadOnly = True
    End Sub

    ''' <summary>
    ''' 加载所有用户
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadAllUser()

        Dim sql As String = Nothing
        sql = "SELECT *  FROM ATL_HD_UserGroups where ServiceTypeID='1' and  IsDimission=0 order by userno"
        Dim dt As New DataTable

        dt = getDataTables(sql)

        Try

            If dt.Rows.Count > 0 Then

                LEResponsibilityName.Properties.DataSource = dt
                LEFollowManName.Properties.DataSource = dt
                LECompetenceName.Properties.DataSource = dt

            End If
            dt.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' 加载公司名称
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadCompany()

        Try

            Dim sql As String = "select * from ATL_HD_Company "

            Dim dt As New DataTable

            dt = getDataTables(sql)

            If dt.Rows.Count > 0 Then
                LUCompany.Properties.DataSource = dt
                LUCompany.Properties.ValueMember = "CompanyNo"
                LUCompany.Properties.DisplayMember = "CompanyName"
            Else
                LUCompany.Properties.DataSource = Nothing
            End If

            dt.Dispose()

        Catch ex As Exception
            MessageBox.Show("线程引发异常：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ''' <summary>
    ''' 加载系统类型
    ''' 2014/12/08    DEVON
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadSystemType()
        Try
            Dim sql As String = "select distinct SystemType from IT_SystemNameManager where len(SystemType)>0 "
            Dim ds As New DataSet
            ds = GetDataSet(sql, "SysType")
            If ds.Tables("SysType").Rows.Count > 0 Then
                gluSystemType.Properties.DataSource = ds.Tables("SysType")
                gluSystemType.Properties.ValueMember = "SystemType"
                gluSystemType.Properties.DisplayMember = "SystemType"
            Else
                gluSystemType.Properties.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("线程引发异常：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ''' <summary>
    ''' 计算编号
    ''' </summary>
    ''' <remarks></remarks>
    Sub getLastNum()

        '' 取得最後一笔记录
        Dim sql As String = "select top 1 SystemID from IT_SystemNameManager order by AutoID desc"
        Dim dt As New DataTable
        dt = getDataTables(sql)

        If dt.Rows.Count = 1 Then
            CalculateNum(dt.Rows(0)("SystemID"), SystemID)
            lblnum.Text = SystemID
        End If

        dt.Dispose()

    End Sub

    ''' <summary>
    ''' 计算一个新编号
    ''' </summary>
    ''' <param name="OldNum"></param>
    ''' <param name="NewNum"></param>
    ''' <remarks></remarks>
    Sub CalculateNum(ByVal OldNum As String, ByRef NewNum As String)

        Try

            Dim i As String = OldNum.Substring(3, 3)

            Dim n As String = Format(i + 1, "000")

            NewNum = "KB-" & n
        Catch
            NewNum = "KB-001"
        End Try

    End Sub

    ''' <summary>
    ''' 加载编辑数据
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadEditData()

        ' On Error Resume Next

        Dim sql As String = Nothing
        sql = "  select * from IT_SystemNameManager where AutoID='" & AutoID & "' And SystemID='" & SysNameID & "' and SystemName='" & SysName & "'"
        Dim dt As New DataTable
        dt = getDataTables(sql)
        If dt.Rows.Count > 0 Then
            txtSysName.Text = dt.Rows(0)("SystemName")
            txtSysName.Properties.ReadOnly = True
            SystemID = dt.Rows(0)("SystemID").ToString().Substring(0, 6)
            lblnum.Text = dt.Rows(0)("SystemID")
            SatartDT.Text = dt.Rows(0)("StartDate")
            LUCompany.Properties.NullText = dt.Rows(0)("Company")
            SatartDT.Properties.ReadOnly = True
            LEFollowManName.Properties.NullText = dt.Rows(0)("FollowManName")
            LEFollowManName.EditValue = dt.Rows(0)("FollowManJob")
            LEResponsibilityName.Properties.NullText = dt.Rows(0)("ResponsibilityName")
            LEResponsibilityName.EditValue = dt.Rows(0)("ResponsibilityJob")
            LECompetenceName.Properties.NullText = dt.Rows(0)("CompetenceName")
            LECompetenceName.EditValue = dt.Rows(0)("CompetenceJob")
            txtUseCompany.Text = dt.Rows(0)("UseCompany")
            txtUseDepartments.Text = dt.Rows(0)("UseDepartments")
            meUseRemarks.Text = dt.Rows(0)("UseRemarks")
            meSystemRemarks.Text = dt.Rows(0)("SystemRemarks")
        End If

    End Sub

    Private Sub LUCompany_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LUCompany.EditValueChanged
        Try
            If LUCompany.EditValue <> Nothing Then
                lblnum.Text = SystemID & "-" & LUCompany.EditValue
            End If
        Catch
        End Try
    End Sub

    Private Sub txtUseDepartments_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtUseDepartments.ButtonClick
        Dim xx As New deptlist
        If xx.ShowDialog() = DialogResult.OK Then
            txtUseDepartments.EditValue = xx.s
        End If
    End Sub

    ''' <summary>
    ''' 系统类型 添加
    ''' 2014/12/10   DEVON
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnTypeAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTypeAdd.Click
        Dim dtTemp As DataTable = gluSystemType.Properties.DataSource
        Dim frm As New frmSystemType_Add(dtTemp)
        frm.ShowDialog()
    End Sub

End Class