Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection

Public Class frmMain

    Private Sub nbiProject_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiProject.LinkClicked

        '项目管理
        Dim xx As New mdlProject
        GroupControl1.Controls.Clear()
        xx.Dock = System.Windows.Forms.DockStyle.Fill
        GroupControl1.Controls.Add(xx)
        LabelControl2.Text = "[项目管理]"

    End Sub

    Private Sub nbiPersonnel_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiPersonnel.LinkClicked

        '人员信息
        Dim xx As New mdlPersonnel
        GroupControl1.Controls.Clear()
        xx.Dock = System.Windows.Forms.DockStyle.Fill
        GroupControl1.Controls.Add(xx)
        LabelControl2.Text = "[人员信息]"

    End Sub

    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            NotifyIcon1.ShowBalloonTip(5, "项目管理系统", "程序已最小化於此！", ToolTipIcon.Info)
        End If

    End Sub

    Private Sub nbiGantt_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiGantt.LinkClicked

        '甘特图
        ' frmProjectDetail.txtID.Text = Me.GridView1.GetFocusedRowCellValue("ID")
        strGanttType = "项目"
        dteDate = Now
        Dim xx As New mdlGanttDetail
        GroupControl1.Controls.Clear()
        xx.Dock = System.Windows.Forms.DockStyle.Fill
        GroupControl1.Controls.Add(xx)
        LabelControl2.Text = "[甘特图管理]"
    End Sub

    Private Sub nbiPensonnelTasks_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiPensonnelView.LinkClicked

        '个人视图
        ShowmdlPersonnelTask()

        LabelControl2.Text = "[个人视图]"

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        '检查时间并提醒
        On Error Resume Next
        Timer1.Enabled = False
        'System.Threading.Interlocked.Increment(tickCounter as ref)
        Timer1.Interval = 30000
        If Format(Now, "HH:mm") = "17:25" Then
            AlertControl1.Show(Me, "亲：[ 现在时间：17:25 ]  繁忙一天又要结束了！", "今天的工作做了不少，请您去更新进度后休息下!")
        ElseIf Weekday(Now) = 7 And Format(Now, "HH:mm") = "12:10" Then '星期六
            AlertControl1.Show(Me, "亲：[ 现在时间：12:10 ]  繁忙一周又要结束了！", "今天的工作做了不少，请您去更新进度后休息下!")
        End If

        'MessageBox.Show(Format(Now, "hh:mm"))
        Timer1.Enabled = True

    End Sub

    Private Sub nbiDepartmentView_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiDepartmentView.LinkClicked
        '部门视图
        Dim xx As New mdlDepartmentView
        GroupControl1.Controls.Clear()
        xx.Dock = System.Windows.Forms.DockStyle.Fill
        GroupControl1.Controls.Add(xx)
        LabelControl2.Text = "[部门视图]"

    End Sub

    '' 定时刷新个人项目
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

l:
        Timer2.Enabled = False
        txtTime.Text = txtTime.Text + 1

        If txtTime.Text = 10 Then   '5分锺=10
            'Print("a")   '需要运行什麽程序自己设
            ShowToDoMsgbox()
        End If

        If txtTime.Text = 11 Then
            txtTime.Text = 0       '归零。。
            GoTo l
        End If

        Timer2.Enabled = True

    End Sub

    ''' <summary>
    ''' 导入所有项目
    ''' </summary>
    ''' <remarks></remarks>
    Sub ShowToDoMsgbox()

        On Error Resume Next

        Dim lngCount As Long

        Dim dt As New DataTable
        Dim sql As String = Nothing

        sql = "SELECT * FROM IT_ToDo where TD_UserNo='" & UserID & "' and TD_Complete=0"

        dt = getDataTables(sql)

        lngCount = dt.Rows.Count

        If lngCount > 0 Then

            For i As Integer = 0 To lngCount - 1
                '显示提示
                If Not dt.Rows(i).Item("TD_EndDate").ToString Is DBNull.Value Then
                    Dim lngTime As Long
                    '取得时间差，>0 and <5 '提前5分锺提示
                    lngTime = DateDiff("n", CDate(dt.Rows(i).Item("TD_EndDate").ToString), Now)

                    If lngTime > 0 And lngTime < 6 Then
                        AlertControl1.Show(Me, dt.Rows(i).Item("TD_Name").ToString, dt.Rows(i).Item("TD_Remark").ToString)

                    End If

                End If

            Next

        End If

        dt.Dispose()

    End Sub

    Private Sub AlertControl1_AlertClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Alerter.AlertClickEventArgs) Handles AlertControl1.AlertClick

        Me.ShowInTaskbar = True
        Me.Show()
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub mbiProjectView_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles mbiProjectView.LinkClicked

        '个人视图
        Dim xx As New mdlProjectView
        GroupControl1.Controls.Clear()
        xx.Dock = System.Windows.Forms.DockStyle.Fill
        GroupControl1.Controls.Add(xx)
        LabelControl2.Text = "[项目视图]"

    End Sub

    ''' <summary>
    ''' 文档管理模组
    ''' 增加人:曹成波,日期:20131021
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub nbFilesManager_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbFilesManager.LinkClicked

        Dim tabPage As New FTPFilesManager
        GroupControl1.Controls.Clear()
        tabPage.Dock = System.Windows.Forms.DockStyle.Fill
        GroupControl1.Controls.Add(tabPage)
        LabelControl2.Text = "[文档管理]"
    End Sub

    Private Sub NotifyIcon1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyIcon1.Click

        Me.ShowInTaskbar = True
        Me.Show()
        Me.WindowState = FormWindowState.Maximized

    End Sub
    '' 释放资源
    Private Sub frmMain_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        If System.IO.Directory.Exists("C:\temp") Then
            Dim a() As String = IO.Directory.GetFiles("C:\temp\")
            Dim i As Integer
            For Each a(i) In a
                System.IO.File.Delete(a(i))
            Next
            System.IO.Directory.Delete("C:\temp")
        End If

        NotifyIcon1.Visible = False

        '' 强制回收垃圾
        FlushMemory()
        On Error Resume Next
        Application.Exit()
        Me.Close()
        Me.Dispose()
        System.Environment.Exit(System.Environment.ExitCode)

    End Sub

    Private Sub LabelControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl1.Click
        UpdateList.ShowDialog()
    End Sub

    ''' <summary>
    ''' 显示个人视图
    ''' </summary>
    ''' <remarks></remarks>
    Sub ShowmdlPersonnelTask()

        Try

            Dim xx As New mdlPersonnelTask
            GroupControl1.Controls.Clear()
            xx.Dock = DockStyle.Fill
            GroupControl1.Controls.Add(xx)
            xx.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' 显示GTD
    ''' </summary>
    ''' <remarks></remarks>
    Sub ShowmdlGTD()

        Try

            Dim xx As New mdlGTD_Main
            GroupControl1.Controls.Clear()
            xx.Dock = DockStyle.Fill
            GroupControl1.Controls.Add(xx)
            xx.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' 通过委托方式显示自定义窗体
    ''' </summary>
    ''' <param name="UCfrm"></param>
    ''' <remarks></remarks>
    Public Sub ShowForm(ByVal UCfrm As System.Windows.Forms.UserControl)

        Try
            GroupControl1.Controls.Clear()
            UCfrm.Dock = DockStyle.Fill
            GroupControl1.Controls.Add(UCfrm)
            UCfrm.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ''窗体初始化
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor

        If (Not IsProjectManager) And (Not IsLeader) Then
            HideControl()
        End If

        Application.DoEvents()

        'ShowmdlPersonnelTask()
        '加载GTD
        ShowmdlGTD()

        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        Timer4.Enabled = True

        Me.Cursor = Cursors.Default

    End Sub
    ''' <summary>
    ''' 隐藏指定项目
    ''' </summary>
    ''' <remarks></remarks>
    Sub HideControl()
        'NavBarItem3.Visible = False
        'NavBarItem4.Visible = False
        'nbiPersonnel.Visible = False
        'If UserID.Trim() <> "11100032" Then
        '    nbSystemManager.Visible = False
        '    NavBarGroup5.Visible = False
        '    NavBarItem12.Visible = False

        'End If

        'NavBarItem7.Visible = False
        'NavBarItem8.Visible = False
        'NavBarItem9.Visible = False
        'NavBarItem10.Visible = False
        'NavBarItem11.Visible = False
    End Sub


#Region "清空内存"

    '' 定时清理内存
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        FlushMemory()
    End Sub
#End Region


    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick

        Timer4.Enabled = False

        ' '' 定时检查是否有更新项目
        'killApp("AutoUpdate.exe")

        'Threading.Thread.Sleep(1000)

        ' '' 启动一个自动更新程序
        'StartApp("AutoUpdate.exe", False)

        Threading.Thread.Sleep(1000)

        RemindBug()

        Timer4.Enabled = True

    End Sub
    ''' <summary>
    '''  提醒是否有待处理Bug
    ''' </summary>
    ''' <remarks></remarks>
    Sub RemindBug()

        Dim sql As String = Nothing

        sql = "select IT_DevelopBugManager.*,IT_SystemNameManager.SystemName,IT_SystemNameManager.SystemID " &
          " from IT_DevelopBugManager, IT_SystemNameManager " &
          " where IT_SystemNameManager.SystemID=IT_DevelopBugManager.SysProID and " &
          " IT_SystemNameManager.SystemName=IT_DevelopBugManager.SysProName and " &
          " (ByDesigneeJog='" & UserID & "' or ResultsConfirmJob='" & UserID & "') and ExpectedLife='" & DateTime.Now.ToString("yyyy-MM-dd") & "' and CurrentStatus<>'已验收'"

        Dim dt As New DataTable

        dt = getDataTables(sql)
        Dim index As Integer = dt.Rows.Count

        If index > 0 Then
            AlertControl1.Show(Me, "亲：您今天有 " & index & " 笔待处理Bug资料！", "请您及时处理!")
        End If

    End Sub

#Region "考核管理"

    '' 个人自评
    Private Sub nbiAssessMg_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiAssessMg.LinkClicked, NavBarItem2.LinkClicked
        Dim frm As New mblIndividualAssessment
        GroupControl1.Controls.Clear()
        frm.Dock = System.Windows.Forms.DockStyle.Fill
        LabelControl2.Text = "考核管理[个人自评]"
        GroupControl1.Controls.Add(frm)
    End Sub

    '' 所有人员考核
    Private Sub nbiTypeManager_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiTypeManager.LinkClicked, NavBarItem3.LinkClicked
        Dim frm As New mdlAssessManage
        GroupControl1.Controls.Clear()
        frm.Dock = System.Windows.Forms.DockStyle.Fill
        LabelControl2.Text = "考核管理[主管考核]"
        GroupControl1.Controls.Add(frm)
    End Sub

    '' 个人报表
    Private Sub NavBarItem11_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem11.LinkClicked
        Dim frm As New PrintAssessReport
        GroupControl1.Controls.Clear()
        frm.Dock = System.Windows.Forms.DockStyle.Fill
        LabelControl2.Text = "考核管理[个人报表]"
        GroupControl1.Controls.Add(frm)
    End Sub

#End Region

#Region "Bug菜单"

    '' Bug管理
    Private Sub nbTestProblems_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbTestProblems.LinkClicked
        Dim xx As New mdlTestProblems
        GroupControl1.Controls.Clear()
        xx.Dock = System.Windows.Forms.DockStyle.Fill
        GroupControl1.Controls.Add(xx)
        LabelControl2.Text = "Bug管理[数据管理]"
    End Sub
    Private Sub NavBarItem5_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem5.LinkClicked
        Dim frm As New UCBugList
        GroupControl1.Controls.Clear()
        frm.Dock = System.Windows.Forms.DockStyle.Fill
        LabelControl2.Text = "Bug管理[Bug率统计]"
        GroupControl1.Controls.Add(frm)
    End Sub

    Private Sub NavBarItem6_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem6.LinkClicked
        Dim frm As New UCBugType
        GroupControl1.Controls.Clear()
        frm.Dock = System.Windows.Forms.DockStyle.Fill
        LabelControl2.Text = "Bug管理[Bug率视图]"
        GroupControl1.Controls.Add(frm)
    End Sub

#End Region

#Region "系统维护菜单"

    '' 系统维护
    Private Sub nbSystemManager_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbSystemManager.LinkClicked
        Dim ucFrm As New nblSystemNameManage
        GroupControl1.Controls.Clear()
        ucFrm.Dock = DockStyle.Fill
        GroupControl1.Controls.Add(ucFrm)
        LabelControl2.Text = "系统维护[名称管理]"
        ucFrm.Show()
    End Sub

    Private Sub NavBarItem7_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem7.LinkClicked
        Dim frm As New ScoreSeting
        LabelControl2.Text = "[系统维护]"
        frm.ShowDialog()
    End Sub

    Private Sub NavBarItem8_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem8.LinkClicked

        Dim frm As New AssessAndBugManage
        frm.xtControl.SelectedTabPageIndex = 0
        LabelControl2.Text = "[系统维护]"
    End Sub

    Private Sub NavBarItem9_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem9.LinkClicked
        Dim frm As New GroupManage
        LabelControl2.Text = "[系统维护]"
        frm.ShowDialog()

    End Sub

    Private Sub NavBarItem10_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem10.LinkClicked
        Dim frm As New AssessAndBugManage
        frm.xtControl.SelectedTabPageIndex = 1
        LabelControl2.Text = "[系统维护]"
        frm.ShowDialog()
    End Sub
#End Region


    Private Sub nbiGTD_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiGTD.LinkClicked
        '人员信息
        Dim xx As New mdlGTD_Main
        GroupControl1.Controls.Clear()
        xx.Dock = System.Windows.Forms.DockStyle.Fill
        GroupControl1.Controls.Add(xx)
        LabelControl2.Text = "[GTD]"
    End Sub

    Private Sub NavBarItem12_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem12.LinkClicked
        '部门信息
        Dim xx As New deptinfo
        GroupControl1.Controls.Clear()
        xx.Dock = System.Windows.Forms.DockStyle.Fill
        GroupControl1.Controls.Add(xx)
        LabelControl2.Text = "部门信息"
    End Sub
End Class
