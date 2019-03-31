Imports System.Data.SqlClient

Public Class GroupManage

    ''' <summary>
    ''' 是否为编辑状态
    ''' true:是
    ''' false:否
    ''' </summary>
    ''' <remarks></remarks>
    Dim IsEdit As Boolean = False

    Dim ID As String = Nothing

    Dim uNo As String = Nothing
    ''' <summary>
    ''' 加载所有
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadData()
        Dim sql As String = Nothing
        sql = "select a.* ,b.isshow from IT_PersonnelGroups a left join ATL_HD_UserGroups b on a.userno=b.userno where a.isjob=1"
        Dim dt As New DataTable
        dt = getDataTables(sql)
        If dt.Rows.Count > 0 Then
            AssessControl.DataSource = dt
        Else
            AssessControl.DataSource = Nothing
        End If
        dt.Dispose()
    End Sub

    ''' <summary>
    ''' 取得人员信息
    ''' </summary>
    ''' <remarks>返回当前人员信息</remarks>
    Sub userInfo()

        Dim strSB As New System.Text.StringBuilder
        strSB.Append("select distinct 姓名 as pName,职位 as pPost,职员代码 as employeeID,(select ATL_HD_Company.CompanyName  ")
        strSB.Append(" from ATL_HD_Company where ATL_HD_Company.CompanyNo =HR_V_AllEmp_Info.工作地点 ) as workPlace ")
        strSB.Append(" from HR_V_AllEmp_Info where 组织单元 = 'DT部' and 员工状态 = '在职' or 姓名 in ")
        strSB.Append(" (select 姓名 from HR_V_AllEmp_Info where 职员代码='00061' or 职员代码='00089') order by employeeID asc ")

        Dim dt As New DataTable

        dt = getDataTables(strSB.ToString())
        strSB.Clear()
        If dt.Rows.Count > 0 Then
            txtJob.Properties.DataSource = dt
            txtJob.Properties.ValueMember = "employeeID"
            txtJob.Properties.DisplayMember = "pName"
        Else
            txtJob.Properties.DataSource = Nothing
        End If

    End Sub
    '' 绘制颜色
    Private Sub GridView1_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GridView1.CustomDrawCell
        CustomDrawCell(e)
    End Sub
    ''' <summary>
    ''' 清空控件
    ''' </summary>
    ''' <remarks></remarks>
    Sub Clearlb()
        txtJob.Text = ""
        lblUserName.Text = ""
        lblPost.Text = ""
        lblworkPlace.Text = ""
        CBEGroups.Text = ""
        CBEGroups.Enabled = False
        CKIsLeader.Checked = False
        CKIsLeader.Enabled = False
        CKIsLeader.Checked = False
        CEIsProManager.Enabled = False
        ckiSReceive.Enabled = False
        CBGroups.Enabled = False
        ckiSReceive.Checked = False
        CEIsGlobaluser.Checked = False
        CEisshow.Checked = False
        CEIsGlobaluser.Enabled = False
        CEisshow.Enabled = False
        txtMail.Properties.ReadOnly = True
        txtMail.Text = ""
        CBGroups.Text = ""
        tbSave.Text = "确认"
        tb_close.Text = "关闭"
        IsEdit = False
    End Sub

    Private Sub GroupManage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clearlb()
        loadData()
        userInfo()
    End Sub

    Private Sub tbSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSave.Click

        If Len(txtJob.Text.Trim()) = 0 Then
            txtJob.Focus()
            MessageBox.Show("请输入人员工号？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If lblUserName.Text.Trim() = "" Or lblPost.Text.Trim() = "" Or lblworkPlace.Text.Trim() = "" Then
            MessageBox.Show("人员信息不完整，无法保存？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If CBGroups.Text = "" Then
            CBGroups.Focus()
            MessageBox.Show("请选择人员组别？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If CKIsLeader.Checked Then
            If CBEGroups.Text.Trim() = "" Then
                CBEGroups.Focus()
                MessageBox.Show("请选择所管理的组别？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        SaveData()

        'Try
        '    Dim xml As String
        '    xml = String.Format("<rd><Alias>'{0}'</Alias><name>'{1}'</name><email>'{2}'</email></rd>",
        '                          lblUserName.Text,
        '                          txtJob.Text,
        '                          txtMail.Text
        '                          )

        '    Dim params() As SqlParameter = {
        '        New SqlParameter("@xml", Xml),
        '         New SqlParameter("@msg", SqlDbType.NChar, 100)
        '        }
        '    params(1).Direction = ParameterDirection.Output

        '    DbServices.DbHelperSQL.RunProcedure(String.Format("updateemail"),
        '                                    params)
        '    MessageBox.Show(params(1).Value, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Catch ex As Exception
        '    MessageBox.Show("更新Email失败？原因如下:" + ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try


    End Sub
    ''' <summary>
    ''' 保存数据
    ''' </summary>
    ''' <remarks></remarks>
    Sub SaveData()

        '' 项目组长
        Dim IsLeaderid As Integer
        If CKIsLeader.Checked Then
            IsLeaderid = 1
        Else
            IsLeaderid = 0
        End If

        '' 项目经理
        Dim IsProManager As Integer

        If CEIsProManager.Checked Then
            IsProManager = 1
        Else
            IsProManager = 0
        End If

        '' 全局用户
        Dim Isglobaluser As Integer

        If CEIsGlobaluser.Checked Then
            Isglobaluser = 1
        Else
            Isglobaluser = 0
        End If

        '' 组别
        Dim groups As String
        If CBEGroups.Text = "" Then
            groups = 0
        Else
            groups = CBEGroups.Text
        End If

        '' 是否接收超期项目邮件通知
        Dim isReceive As Integer
        Dim SendMailTime As String
        If ckiSReceive.Checked Then
            isReceive = 1
            SendMailTime = CDate(TESendMailTime.EditValue).ToString("HH:mm:ss")
        Else
            isReceive = 0
            SendMailTime = Nothing
        End If


        Dim strSB As New System.Text.StringBuilder

        If IsEdit Then
            strSB.Append("update IT_PersonnelGroups set ManageGroups='" & groups & "' ,IsLeader='" & IsLeaderid & "',isglobaluser='" & Isglobaluser)
            strSB.Append("', IsProjectManager='" & IsProManager & "',Groups='" & CBGroups.Text & "', pPost='" & lblPost.Text)
            strSB.Append("', iSReceive='" & isReceive & "',SendMailTime='" & SendMailTime & "' where AutoID='" & ID & "' and UserNo='" & uNo & "'")
            If (CEisshow.Checked) Then
                strSB.Append("   update ATL_HD_UserGroups set isshow=1  where UserNo='" & uNo & "'")
            Else
                strSB.Append("   update ATL_HD_UserGroups set isshow=0  where UserNo='" & uNo & "'")
            End If
        Else
            'strSB.Append("insert into IT_PersonnelGroups (UserNo,UserName,ManageGroups,IsLeader,IsProjectManager,Groups,pPost,iSReceive,SendMailTime,isglobaluser) values")
            'strSB.Append("('" & lblUserName.Text.Trim() & "','" & txtJob.Text.Trim() & "','" & groups & "','" & IsLeaderid)
            'strSB.Append("','" & IsProManager & "','" & CBGroups.Text & "','" & lblPost.Text & "','" & isReceive & "','" & SendMailTime & "','" & Isglobaluser & "')")

            ''2016-07-30 23:46 Dave
            'strSB.Append("insert into IT_PersonnelGroups (UserName, Password, UserNo, groups, pPost, IsProjectManager, IsLeader, isReceive, SendMailTime, ManageGroups, isMustEnter, isjob, Isglobaluser, isShowGroupManage) values")
            'strSB.Append("('" & txtJob.Text.Trim() & "','123','" & lblUserName.Text.Trim() & "','" & CBGroups.Text & "','" & lblPost.Text)
            'strSB.Append("','0','0','1','" & SendMailTime & "','0','" & CEIsGlobaluser.Checked & "','" & CEIsGlobaluser.Checked & "','" & Isglobaluser & "','" & CEIsProManager.Checked & "')")
            ''2016-07-30 0:09 Dave
            strSB.Append("update IT_PersonnelGroups set UserName = '" & txtJob.Text.Trim() & "',groups= '" & CBGroups.Text & "', pPost = '" & lblPost.Text & "', isReceive ='1', SendMailTime ='" & SendMailTime & "', ManageGroups ='0',isMustEnter ='" & CEIsGlobaluser.Checked & "',isjob= '" & CEIsGlobaluser.Checked & "',Isglobaluser='" & Isglobaluser & "' where UserName ='" & txtJob.Text.Trim() & "'")

        End If

        Try
            If ExecuteNonQuery(strSB.ToString()) = 0 Then
                MessageBox.Show("操作失败", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                '' MessageBox.Show("操作成功", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Clearlb()
                loadData()
            End If
        Catch ex As Exception
            MessageBox.Show("未知错误：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    '' 双击修改
    Private Sub AssessControl_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssessControl.DoubleClick

        Try
            Clearlb()
            IsEdit = True
            ID = GridView1.GetFocusedRowCellValue("AutoID")
            uNo = GridView1.GetFocusedRowCellValue("UserNo")
            tbSave.Text = "修改"
            tb_close.Text = "取消"
            txtJob.Text = GridView1.GetFocusedRowCellValue("UserName")
            'lblUserName.Text = uNo
            CBGroups.Text = GridView1.GetFocusedRowCellValue("Groups")
            CEIsProManager.Checked = CInt(GridView1.GetFocusedRowCellValue("IsProjectManager"))
            CKIsLeader.Checked = CInt(GridView1.GetFocusedRowCellValue("IsLeader"))
            CEIsGlobaluser.Checked = CInt(GridView1.GetFocusedRowCellValue("isglobaluser"))
            CEisshow.Checked = CInt(GridView1.GetFocusedRowCellValue("isshow"))
            CBEGroups.Text = GridView1.GetFocusedRowCellValue("ManageGroups")
            ckiSReceive.Checked = CInt(GridView1.GetFocusedRowCellValue("iSReceive"))
            If Not GridView1.GetFocusedRowCellValue("SendMailTime") Is DBNull.Value Then
                TESendMailTime.EditValue = GridView1.GetFocusedRowCellValue("SendMailTime")
            End If
        Catch
            IsEdit = False
            MessageBox.Show("加载处理数据失败？ " & vbCrLf & "请重新选择需要处理的数据？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtJob_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtJob.KeyDown

        If e.KeyCode = Keys.Enter Then

            If Len(txtJob.Text.Trim()) = 0 Then
                txtJob.Focus()
                MessageBox.Show("请输入人员工号？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            uNo = txtJob.Text.Trim()

        End If

    End Sub
    '' 取得人员信息
    Private Sub txtJob_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJob.EditValueChanged
        lblUserName.Text = txtJob.GetColumnValue("employeeID").ToString()
        lblPost.Text = txtJob.GetColumnValue("pPost").ToString()
        lblworkPlace.Text = txtJob.GetColumnValue("workPlace").ToString()
        CKIsLeader.Enabled = True
        CEIsProManager.Enabled = True
        CEIsGlobaluser.Enabled = True
        CEisshow.Enabled = True
        CBGroups.Enabled = True
        ckiSReceive.Enabled = True
        txtMail.Properties.ReadOnly = False
        CBGroups.Focus()
    End Sub

    Private Sub CKIsLeader_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CKIsLeader.CheckedChanged
        If CKIsLeader.Checked Then
            CBEGroups.Enabled = True
            CBEGroups.Focus()
        Else
            CBEGroups.Enabled = False
        End If
    End Sub

    '' 关闭窗体或取消编辑
    Private Sub tb_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_close.Click
        If IsEdit Then
            Clearlb()
        Else
            Me.Close()
        End If
    End Sub
    '' 是否接收邮件提醒
    Private Sub ckiSReceive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckiSReceive.CheckedChanged
        If ckiSReceive.Checked Then
            TESendMailTime.Enabled = True
            getMailaddress(txtJob.EditValue)
        Else
            TESendMailTime.Enabled = False
            txtMail.Text = ""
        End If
    End Sub

    Sub getMailaddress(ByVal uid As String)

        Dim sql As String = "  select Email from NewEmailList where  Alias='" & uid & "'"
        Dim dt As New DataTable
        dt = getDataTables(sql)

        If dt.Rows.Count > 0 Then
            If Not IsDBNull(dt.Rows(0)("Email")) Then
                If Not String.IsNullOrEmpty(dt.Rows(0)("Email")) Then
                    txtMail.Text = dt.Rows(0)("Email")
                    Exit Sub
                End If
            End If
        End If

        Dim result As New DialogResult
        result = MessageBox.Show(txtJob.Text + "人员还没有邮件信息，是否立即增加？", "项目管理系统", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = Windows.Forms.DialogResult.No Then
            ckiSReceive.Checked = False
            Exit Sub
        End If

        Dim eMailAddress As String

        eMailAddress = InputBox("邮件格式:" + "itd-m33@megapt.com.cn", "请输入您的邮件地址")

        If eMailAddress = "" Then Exit Sub

        If eMailAddress.IndexOf("@") < 0 Then
            MessageBox.Show("邮件地址输入错误，无法操作?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ckiSReceive.Checked = False
            Exit Sub
        End If

        '' 保存邮件

        Dim strSB As New System.Text.StringBuilder
        strSB.Append("  delete NewEmailList where Alias='" & txtJob.EditValue & "'")
        'strSB.Append("  delete NewEmailList where Alias='" & txtJob.EditValue & "' and Name='" & txtJob.Text & "'")
        strSB.Append("insert into  NewEmailList(Alias,Name,Email) values('" & txtJob.EditValue & "','" & txtJob.Text & "','" & eMailAddress.Trim() & "')")

        If ExecuteNonQuery(strSB.ToString()) > 0 Then
            txtMail.Text = eMailAddress.Trim()
            MessageBox.Show("邮件地址更新成功？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            MessageBox.Show("邮件更新失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ckiSReceive.Checked = False
        End If

    End Sub

    Private Sub btupdateemployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btupdateemployee.Click
        Try


            Dim params() As SqlParameter = {
                 New SqlParameter("@msg", SqlDbType.NChar, 100)
                }
            params(0).Direction = ParameterDirection.Output

            DbServices.DbHelperSQL.RunProcedure(String.Format("updateEmployee"),
                                            params)
            MessageBox.Show(params(0).Value, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("更新人事资料失败？原因如下:" + ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class