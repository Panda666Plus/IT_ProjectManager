Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class frmMyTasks

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click

        blnDel = False
        blnSave = False

        Me.Close()

    End Sub

    Private Sub chkComplete_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLabel.CheckedChanged

        If chkLabel.Checked = True Then
            chkLabel.Text = "已标注"
        Else
            chkLabel.Text = "未标注"
        End If

    End Sub

    ''' <summary>
    ''' 导入上下文
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData_Context()

        Dim dt As New DataTable
        Dim sql As String = Nothing
        sql = "SELECT *  FROM IT_ProStatus where ParentID='60'"
        dt = getDataTables(sql)

        If dt.Rows.Count = 0 Then
            txtContext.Properties.DataSource = Nothing
        End If

        txtContext.Properties.ValueMember = "ID"
        txtContext.Properties.DisplayMember = "ProStatus"
        txtContext.Properties.DataSource = dt
        txtContext.EditValue = 16

    End Sub

    Private Sub frmMyTasks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '初始化
        txtName.Text = ""
        StartDate.EditValue = DBNull.Value
        EndDate.EditValue = DBNull.Value
        txtSchemeID.Text = ""
        txtScheme.Text = ""
        txtContext.EditValue = ""
        txtRemark.Text = ""
        chkLabel.Checked = False
        chkComplete.Checked = False

        txtName.Focus()

        LoadData_Context()

        If Edit Then
            LoadEditData()
        End If

        txtName.Focus()

    End Sub

    ''' <summary>
    ''' 保存新增数据
    ''' </summary>
    ''' <returns>返回一个bool值 ，true表示成功，false表示失败</returns>
    ''' <remarks></remarks>
    Function SaveDataNew() As Boolean



        result = True
        Dim strYN As String
        Dim strStartDate As String
        Dim strEndDate As String
        Dim strComplete As String

        If StartDate.EditValue Is DBNull.Value Then
            strStartDate = "NULL"
        Else
            strStartDate = "'" & Format(StartDate.EditValue, "yyyy-MM-dd HH:mm:ss") & "'"
        End If

        If EndDate.EditValue Is DBNull.Value Then
            strEndDate = "NULL"
        Else
            strEndDate = "'" & Format(EndDate.EditValue, "yyyy-MM-dd HH:mm:ss") & "'"
        End If

        If chkLabel.Checked = True Then strYN = "1" Else strYN = "0"

        Dim strSB As New System.Text.StringBuilder

        If chkComplete.Checked = True Then
            strComplete = "1"
            strSB.Append("INSERT INTO IT_ToDo (TD_Name,TD_StartDate,TD_EndDate,SchemeID,TD_Context,TD_Remark,TD_Label,TD_UserNo,")
            strSB.Append("CreatedTime,TD_Completedate,TD_Complete) Values (")
            strSB.Append("'" & txtName.Text & "'," & strStartDate & "," & strEndDate & ",'" & txtSchemeID.Text & "','")
            strSB.Append(txtContext.EditValue & "','" & txtRemark.Text & "','" & strYN & "','" & UserID & "','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," & strComplete & ")")
        Else
            strComplete = "0"
            strSB.Append("INSERT INTO IT_ToDo (TD_Name,TD_StartDate,TD_EndDate,SchemeID,TD_Context,TD_Remark,TD_Label,TD_UserNo,CreatedTime,TD_Complete)")
            strSB.Append(" Values('" & txtName.Text & "'," & strStartDate & "," & strEndDate & ",'" & txtSchemeID.Text & "','")
            strSB.Append(txtContext.EditValue & "','" & txtRemark.Text & "','" & strYN & "','" & UserID & "','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," & strComplete & ")")
        End If

        Try
            ExecuteNonQuery(strSB.ToString())
            strSB.Clear()
        Catch
            result = False
        End Try

        Return result

    End Function

    ''' <summary>
    ''' 保存修改资料
    ''' </summary>
    ''' <returns>返回一个bool值 ，true表示成功，false表示失败</returns>
    ''' <remarks></remarks>
    Function SaveDataEdit() As Boolean

        result = True

        Dim strYN As String
        Dim strStartDate As String
        Dim strEndDate As String
        Dim strComplete As String

        If StartDate.EditValue Is DBNull.Value Then
            strStartDate = "NULL"
        Else
            strStartDate = "'" & Format(StartDate.EditValue, "yyyy-MM-dd HH:mm:ss") & "'"
        End If

        If EndDate.EditValue Is DBNull.Value Then
            strEndDate = "NULL"
        Else
            strEndDate = "'" & Format(EndDate.EditValue, "yyyy-MM-dd HH:mm:ss") & "'"
        End If

        If chkLabel.Checked = True Then strYN = "1" Else strYN = "0"

        Dim strSB As New System.Text.StringBuilder

        If chkComplete.Checked = True Then
            strComplete = "1"
            strSB.Append("UPDATE IT_ToDo SET TD_Name='" & txtName.Text & "',TD_StartDate=" & strStartDate & ",TD_EndDate=" & strEndDate & ",")
            strSB.Append("SchemeID='" & txtSchemeID.Text & "',TD_Context='" & txtContext.EditValue & "',TD_Remark='" & txtRemark.Text & "',TD_Label='" & strYN & "',")
            strSB.Append("TD_UserNo='" & UserID & "',CreatedTime='" & Format(Now, "yyyy-MM-dd HH:ss") & "',")
            strSB.Append("TD_Completedate='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "',TD_Complete=" & strComplete & " WHERE TD_ID='" & txtID.Text & "'")
        Else
            strComplete = "0"
            strSB.Append("UPDATE IT_ToDo SET TD_Name='" & txtName.Text & "',TD_StartDate=" & strStartDate & ",TD_EndDate=" & strEndDate & ",")
            strSB.Append("SchemeID='" & txtSchemeID.Text & "',TD_Context='" & txtContext.EditValue & "',TD_Remark='" & txtRemark.Text & "',TD_Label='" & strYN & "',")
            strSB.Append("TD_UserNo='" & UserID & "',CreatedTime='" & Format(Now, "yyyy-MM-dd HH:ss") & "',")
            strSB.Append("TD_Complete=" & strComplete & " WHERE TD_ID='" & txtID.Text & "'")
        End If

        Try
            ExecuteNonQuery(strSB.ToString())
            strSB.Clear()
        Catch
            result = False
        End Try

        Return result

    End Function

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        blnDel = False

        If StartDate.EditValue Is DBNull.Value And EndDate.EditValue Is DBNull.Value Then

        ElseIf StartDate.EditValue Is DBNull.Value Or EndDate.EditValue Is DBNull.Value Then

        Else

            If StartDate.EditValue > EndDate.EditValue Then
                MessageBox.Show("开始日期大於结束日期，不能保存！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        End If

        If Edit = False Then

            ''2014/12/16    DEVON
            Dim dt As New DataTable
            Dim sql As String = Nothing
            sql = "SELECT Count(*) FROM IT_ToDo where TD_Name=N'" & txtName.Text & "'"
            dt = getDataTables(sql)
            If dt.Rows(0)(0) > 0 Then
                MsgBox("项目：" & txtName.Text & "已存在，请重新命名!", 64, "提示")
                txtName.Focus()
                Exit Sub
            End If
            ''-----------------------------

            If SaveDataNew() Then
                ' MessageBox.Show("保存成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                isRefresh = True
            Else
                MessageBox.Show("保存失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else

            If SaveDataEdit() Then
                'MessageBox.Show("修改成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                isRefresh = True
            Else
                MessageBox.Show("修改失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If chkComplete.Checked = True Then blnDel = True

        End If
        blnSave = True

        ''2014/12/15   DEVON   修改完成恢复窗体原先状态，避免对下一个操作(可能是‘新增’)产生错误影响
        Edit = False
        ''------------------------------

        Me.Close()

    End Sub

    ''' <summary>
    ''' 导入任务资料
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadEditData()

        On Error Resume Next

        Dim strsql As String

        strsql = "select *,(select SchemeName from IT_Scheme where it_todo.SchemeID=IT_Scheme.ID ) as SchemeName  " _
            & "from IT_ToDo where IT_ToDo.TD_ID='" & txtID.Text & "'"
        Dim dt As New DataTable

        dt = getDataTables(strsql)

        txtName.Text = dt.Rows(0)("TD_Name")
        StartDate.EditValue = CDate(dt.Rows(0)("TD_StartDate"))
        EndDate.EditValue = CDate(dt.Rows(0)("TD_EndDate"))
        txtSchemeID.Text = dt.Rows(0)("SchemeID")
        txtScheme.Text = dt.Rows(0)("SchemeName")
        txtContext.EditValue = dt.Rows(0)("TD_Context")
        txtRemark.Text = dt.Rows(0)("TD_Remark")

        If dt.Rows(0)("TD_Complete") = True Then
            chkComplete.Checked = True
        Else
            chkComplete.Checked = False
        End If

        If dt.Rows(0)("TD_Label") = True Then
            chkLabel.Checked = True
        Else
            chkLabel.Checked = False
        End If

    End Sub

    Private Sub cmdScheme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdScheme.Click
        '' Dim frm As New frmSelectProject
        '' frm.ShowDialog()
        frmSelectProject.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        txtSchemeID.Text = ""
        txtScheme.Text = ""
    End Sub

    Private Sub StartDate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles StartDate.Click

        If Not StartDate.EditValue Is DBNull.Value Then
            StartDate.EditValue = Now
        End If

    End Sub

    Private Sub EndDate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EndDate.Click

        If StartDate.EditValue Is DBNull.Value Then

            If Now > CDate(Format(Now, "yyyy-MM-dd") & " 17:00") Then
                EndDate.EditValue = DateAdd("n", 15, Now)
            Else
                EndDate.EditValue = CDate(Format(Now, "yyyy-MM-dd") & " 17:00")
            End If

        Else

            If EndDate.EditValue Is DBNull.Value Then

                If StartDate.EditValue > CDate(Format(Now, "yyyy-MM-dd") & " 17:00") Then
                    EndDate.EditValue = DateAdd("n", 15, StartDate.EditValue)
                Else
                    EndDate.EditValue = CDate(Format(StartDate.EditValue, "yyyy-MM-dd") & " 17:00")
                End If

            End If

        End If

    End Sub

    '' 删除
    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click

        Dim dialog As New DialogResult

        Dim proName As String = txtName.Text.Trim()

        dialog = MessageBox.Show("请确认是否需要删除以下信息：" & vbCrLf & "项目名称：" & proName,
                                 "项目管理系统", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)

        If dialog = Windows.Forms.DialogResult.No Then Exit Sub

        Dim delSql As String = "delete IT_ToDo where TD_Name='" & proName & "' and TD_UserNo='" & UserID & "' and TD_Complete='0'"
        Dim index As Integer

        index = ExecuteNonQuery(delSql)

        If index <= 0 Then
            MessageBox.Show("删除失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("删除成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            isRefresh = True
            Me.Close()
        End If

    End Sub

End Class