Imports clsRSAEncryption
Imports clsReadWriteInI
Imports System.Threading

Public Class frmLogo

    Dim INI As New ReadWriteINI

    Dim RSA As New RSAEncryption
    Dim Password As Object

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click

        ExitApp()

    End Sub

#Region "登录验证"

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If Len(Trim(txtID.Text)) = 0 Then
            txtID.Focus()
            MessageBox.Show("请输入登录账号？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Len(Trim(txtPsw.Text)) = 0 Then
            txtPsw.Focus()
            MessageBox.Show("请输入域登录密码？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If



        '  Dim handle As Integer = clsReadWriteInI.NativeApiHelper.CreateEvent(0, True, False, txtID.Text)


        Try

            Application.DoEvents()

            '' 取得数据信息
            Dim sql As String = Nothing

            sql = "select * from IT_PersonnelGroups where UserNo='" & txtID.Text.Trim() & "' and Password ='" & txtPsw.Text.Trim() & "'"

            Dim dt As New DataTable

            dt = getDataTables(sql)

            If dt.Rows.Count <= 0 Then
                MessageBox.Show("登录失败,非金百泽DT部同事账号？ ", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim Check As New mdlmain

            '' 域账号验证登录
            If Not Check.impersonateValidUser(txtID.EditValue, txtPsw.Text.Trim()) Then
                MessageBox.Show("账号验证失败，请确认自己的域密码是否输入正确？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim mutex As Integer = clsReadWriteInI.NativeApiHelper.CreateMutex(0, True, txtID.Text)

            Dim isresult As Integer = clsReadWriteInI.NativeApiHelper.GetLastError()

            If (isresult = 183) Then
                MessageBox.Show("当前用户" + txtID.Text + "已登录了系统", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Application.Exit()
            End If

            Me.Hide()

            Dim frm As New frmMain

            Me.Cursor = Cursors.WaitCursor

            If dt.Rows(0)("IsProjectManager").ToString() = 1 And dt.Rows(0)("IsLeader").ToString() = 1 Then
                IsProjectManager = True
                IsLeader = True
                frm.lblAdmin.Text = "超级管理员"
                frm.lblGroup.Text = dt.Rows(0)("Groups").ToString()
            ElseIf dt.Rows(0)("IsProjectManager").ToString() = 1 Then '' 是否为项目经理
                IsProjectManager = True
                frm.lblAdmin.Text = "项目经理"
                frm.lblGroup.Text = dt.Rows(0)("Groups").ToString()
            ElseIf dt.Rows(0)("IsLeader").ToString() = 1 Then '' 是否为项目组长
                IsLeader = True
                frm.lblAdmin.Text = "项目组长"
                frm.lblGroup.Text = dt.Rows(0)("Groups").ToString()
            ElseIf dt.Rows(0)("Groups").ToString() = "测试组" Then
                frm.lblAdmin.Text = "测试员"
                Testers = True
                frm.lblGroup.Text = dt.Rows(0)("Groups").ToString()
            Else
                frm.lblAdmin.Text = "操作员"
                frm.lblGroup.Text = dt.Rows(0)("Groups").ToString()
            End If

            If dt.Rows(0)("isglobaluser").ToString() = 1 Then
                Isglobaluser = True
            Else
                Isglobaluser = False
            End If

            ''职级
            pPost = dt.Rows(0)("pPost")
            UserName = dt.Rows(0)(1).ToString()
            UserID = txtID.EditValue

            frm.labUserName.Text = UserName

            dt.Dispose()

            If ckRememberPwd.Checked Then
                '' 记录密码
                '' 加密登录密码
                Dim DePassword As String = Nothing
                DePassword = RSA.Encryption(txtPsw.Text)
                ''写入INi中
                INI.Writue("Enter", "Password", DePassword, Application.StartupPath & "\Elogin.set")
                INI.Writue("Enter", "UserName", txtID.Text, Application.StartupPath & "\Elogin.set")
            Else ''写入一个空的资料
                INI.Writue("Enter", "Password", "", Application.StartupPath & "\Elogin.set")
                INI.Writue("Enter", "UserName", "", Application.StartupPath & "\Elogin.set")
            End If

            Me.Cursor = Cursors.Default

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

#End Region

    Private Sub txtPsw_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPsw.KeyDown

        If e.KeyCode = Keys.Enter Then

            cmdSave.PerformClick()

        End If

    End Sub

    Private Sub txtID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyDown

        If e.KeyCode = Keys.Enter Then

            If Len(txtID.Text) = 0 Then
                txtID.Focus()
                MessageBox.Show("请输入登录账号！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            txtPsw.Focus()
            txtPsw.SelectAll()

        End If
    End Sub

    Private Sub frmLogo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load





        '' 定时检查是否有更新项目
        killApp("AutoUpdate.exe")



        '' 启动一个自动更新程序
        StartApp("AutoUpdate.exe", False)

        Dim BatPath As String = Application.StartupPath & "\Rename.bat"
        If System.IO.File.Exists(BatPath) Then
            ''执行批处理文件
            StartApp(BatPath, True)
            Threading.Thread.Sleep(500)
        End If

        '' 启动一个自动更新程序
        StartApp(Application.StartupPath & "\AutoUpdate.exe", False)

        '' 取得INI中的密码
        Dim tempPassword As String = Nothing
        tempPassword = INI.ReadValue("Enter", "Password", Application.StartupPath & "\Elogin.set")
        Dim name As String = INI.ReadValue("Enter", "UserName", Application.StartupPath & "\Elogin.set")
        '' 取得登录密码後进行解密
        If tempPassword <> Nothing Or tempPassword <> "" Then
            txtPsw.Text = RSA.Decryption(tempPassword)
            txtID.Text = name
            ckRememberPwd.Checked = True
        Else
            '' 取得本机域账号名称
            Dim CHECK As New mdlmain
            txtID.Text = CHECK.getADLoginName()
        End If

    End Sub

    Private Sub frmLogo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ExitApp()
    End Sub
    ''' <summary>
    ''' 退出程序
    ''' </summary>
    ''' <remarks></remarks>
    Sub ExitApp()
        GC.Collect()
        ' Me.Close()
        Me.Dispose()
        Application.Exit()
        System.Environment.Exit(System.Environment.ExitCode)
    End Sub
End Class