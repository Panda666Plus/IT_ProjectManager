Public Class SystemList

    ''' <summary>
    ''' 是否為修改狀態
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
    '' 關閉窗體
    Private Sub btClose_Click(sender As System.Object, e As System.EventArgs) Handles btClose.Click
        Clearlbl()
        Me.Close()
    End Sub

    '' 保存數據
    Private Sub btSave_Click(sender As System.Object, e As System.EventArgs) Handles btSave.Click

        If IsView Then Exit Sub

        If SaveData() Then
            Me.Close()
        End If

    End Sub

    ''' <summary>
    ''' 保存新數據
    ''' </summary>
    ''' <remarks></remarks>
    Function SaveData() As Boolean

        SaveData = False

        If Len(txtSysName.Text) = 0 Then
            txtSysName.Focus()
            MessageBox.Show("請輸入系統名稱？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        If Len(LUCompany.Text) = 0 Then
            MessageBox.Show("請選擇適用公司？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LUCompany.Focus()
            Exit Function
        End If

        If Len(SatartDT.Text) = 0 Then
            SatartDT.Focus()
            MessageBox.Show("請選擇開始日期？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        If Len(LEFollowManName.Text) = 0 Then
            LEFollowManName.Focus()
            MessageBox.Show("請選擇跟進人？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        If Len(LEResponsibilityName.Text) = 0 Then
            LEResponsibilityName.Focus()
            MessageBox.Show("請選擇負責人？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        If Len(LECompetenceName.Text) = 0 Then
            LECompetenceName.Focus()
            MessageBox.Show("請選擇權限管理員？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        If Len(txtUseCompany.Text) = 0 Then
            txtUseCompany.Focus()
            MessageBox.Show("請輸入公司名稱？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        If Len(txtUseDepartments.Text) = 0 Then
            txtUseDepartments.Focus()
            MessageBox.Show("請輸入部門名稱？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        Dim sql As String = Nothing

        If Not IsEdit Then
            sql = "insert into IT_SystemNameManager values" &
                "('" & AutoID & "','" & lblnum.Text & "','" & txtSysName.Text.Trim() & "','" & LUCompany.Text & "','" & SatartDT.Text & "','" & LEFollowManName.Text.Trim() &
                "','" & LEFollowManName.EditValue & "','" & LEResponsibilityName.Text.Trim() & "','" & LEResponsibilityName.EditValue &
                "','" & LECompetenceName.Text.Trim() & "','" & LECompetenceName.EditValue & "','" & txtUseCompany.Text.Trim() &
                "','" & txtUseDepartments.Text & "','" & meUseRemarks.Text.Trim() & "','" & meSystemRemarks.Text.Trim() & "')"
        Else
            sql = "update IT_SystemNameManager set " &
                    " FollowManName='" & LEFollowManName.Text.Trim() & "', FollowManJob='" & LEFollowManName.EditValue & "', ResponsibilityName='" & LEResponsibilityName.Text.Trim() &
                    "', ResponsibilityJob='" & LEResponsibilityName.EditValue & "', CompetenceName='" & LECompetenceName.Text.Trim() &
                    "', CompetenceJob='" & LECompetenceName.EditValue & "', UseCompany='" & txtUseCompany.Text & "', UseDepartments='" & txtUseDepartments.Text &
                    "', UseRemarks='" & meUseRemarks.Text.Trim() & "', SystemRemarks='" & meSystemRemarks.Text.Trim() & "'" &
                    ",Company='" & LUCompany.Text & "',SystemID='" & lblnum.Text & "' where AutoID='" & AutoID & "'and PID='" & TempPlD & "' and SystemID='" & SysNameID & "' and SystemName='" & txtSysName.Text & "'"
        End If

        Try
            If ExecuteNonQuery(sql) <> 1 Then
                MessageBox.Show("數據處理失敗？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("操作成功！", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                isRefresh = True
                Clearlbl()
                SaveData = True
            End If

        Catch ex As Exception
            MessageBox.Show("未知錯誤：" & vbCrLf & ex.Message, "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try

        Return SaveData

    End Function
    ''' <summary>
    ''' 更新數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub updataData()

        Dim updata As String = Nothing

        Try
            If ExecuteNonQuery(updata) <> 1 Then
                MessageBox.Show("插入數據失敗？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("操作成功！", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("未知錯誤：" & vbCrLf & ex.Message, "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try

    End Sub

    '' 保存繼續
    Private Sub btAdds_Click(sender As System.Object, e As System.EventArgs) Handles btAdds.Click
        SaveData()
        '' 計算新的編號
        CalculateNum(lblnum.Text, SystemID)
        lblnum.Text = SystemID
        txtSysName.Focus()
    End Sub

    '' 綁定數據
    Private Sub SysListManager_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If IsView Then

            loadEditData()

            ReadOnlyControl()

        ElseIf IsEdit Then

            loadEditData()
            loadAllUser()
            LoadCompany()
        Else
            loadAllUser()
  
            LoadCompany()

            '' 計算ID
            getLastNum()

        End If

    End Sub

    ''' <summary>
    ''' 鎖定控件
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
    ''' 加載所有用戶
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadAllUser()

        Dim sql As String = Nothing
        sql = "SELECT *  FROM ATL_HD_UserGroups where ServiceTypeID='1' order by userno"
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
    ''' 加載公司名稱
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
            MessageBox.Show("線程引發異常：" & vbCrLf & ex.Message, "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    ''' <summary>
    ''' 計算編號
    ''' </summary>
    ''' <remarks></remarks>
    Sub getLastNum()

        '' 取得最後一筆記錄
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
    ''' 計算一個新編號
    ''' </summary>
    ''' <param name="OldNum"></param>
    ''' <param name="NewNum"></param>
    ''' <remarks></remarks>
    Sub CalculateNum(ByVal OldNum As String, ByRef NewNum As String)

        Try

            Dim i As String = OldNum.Substring(3, 3)

            Dim n As String = Format(i + 1, "000")

            NewNum = "LF-" & n
        Catch
            NewNum = "LF-001"
        End Try

    End Sub
    ''' <summary>
    ''' 加載編輯數據
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

    Private Sub LUCompany_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles LUCompany.EditValueChanged
        Try
            If LUCompany.EditValue <> Nothing Then
                lblnum.Text = SystemID & "-" & LUCompany.EditValue
            End If
        Catch
        End Try
    End Sub

End Class