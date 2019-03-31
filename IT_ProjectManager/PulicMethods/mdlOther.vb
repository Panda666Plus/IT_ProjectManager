Module mdlOther

    Public strProjectID As String
    Public strGanttType As String
    Public dteDate As Date
    Public UserID As String = Nothing
    Public UserName As String = Nothing
    ''' <summary>
    ''' 是否为项目经理
    ''' </summary>
    ''' <remarks></remarks>
    Public IsProjectManager As Boolean
    ''' <summary>
    ''' 是否为全局用户
    ''' </summary>
    ''' <remarks></remarks>
    Public Isglobaluser As Boolean
    ''' <summary>
    ''' 是否为项目组长
    ''' </summary>
    ''' <remarks></remarks>
    Public IsLeader As Boolean
    ''' <summary>
    ''' 是否为测试有员
    ''' </summary>
    ''' <remarks></remarks>
    Public Testers As Boolean
    ''' <summary>
    ''' 判断新增或修改
    ''' </summary>
    ''' <remarks></remarks>
    Public Edit As Boolean
    ''' <summary>
    ''' 返回一个处理状态
    ''' </summary>
    ''' <remarks></remarks>
    Public result As Boolean = True
    Public strType As String
    Public blnDel As Boolean
    Public blnSave As Boolean
    ''' <summary>
    ''' 职称
    ''' </summary>
    ''' <remarks></remarks>
    Public pPost As String = Nothing

    ''' <summary>
    ''' 是否刷新数据
    ''' true：执行
    ''' false:不执行
    ''' </summary>
    ''' <remarks></remarks>
    Public isRefresh As Boolean = False

    ''' <summary>
    ''' 启动外部应用程序
    ''' </summary>
    ''' <param name="AppName">应用程序路径名称</param>
    ''' <returns></returns>
    ''' <remarks>true表示成功，false表示失败</remarks>
    Public Function StartApp(ByVal AppName As String, ByVal b As Boolean) As Boolean

        Dim p As New Process()
        p.StartInfo.FileName = AppName  ''exe,bat and so on
        If b Then
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        Else
            p.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        End If
        Try
            p.Start()
            p.WaitForExit()
            ''如果这个外部程序没有结束运行则对其强行终止
            If (p.HasExited = False) Then
                p.Kill()
            Else
                p.Close()
            End If

            p.Dispose()

        Catch e As Exception
            Return False
        End Try

        Return True

    End Function
    ''' <summary>
    ''' 删除指定进程中程序
    ''' </summary>
    ''' <param name="ApppName"></param>
    ''' <remarks></remarks>
    Public Sub killApp(ByVal ApppName As String)
        Dim ps As Process()
        ps = Process.GetProcesses()

        For Each item As Process In ps

            If item.ProcessName = ApppName Then

                item.Kill()
                item.Dispose()
            End If

        Next

    End Sub

    ''' <summary>
    ''' 判断进程指定程序是否存在
    ''' </summary>
    ''' <param name="AppName">进程程序名</param>
    ''' <returns>返回一个Bool值 ，reun表示存在，false表示不存在</returns>
    ''' <remarks></remarks>
    Public Function ExistsThreadName(ByVal AppName As String) As Boolean

        ExistsThreadName = False

        Dim pro() As Process = System.Diagnostics.Process.GetProcesses()

        For Each p As Process In pro

            If p.ProcessName = AppName Then
                ExistsThreadName = True
                Exit For
                Exit Function
            End If

        Next

        Return ExistsThreadName

    End Function

    ''' <summary>
    ''' 取得所有附件列表公共方法
    ''' </summary>
    ''' <param name="list">绑定控件名称</param>
    ''' <param name="NodeID">附件ID</param>
    ''' <param name="ProjectName">项目名称</param>
    ''' <returns>返回一个list集合</returns>
    ''' <remarks></remarks>
    Public Function GetAttachmentList(ByRef list As DevExpress.XtraEditors.ListBoxControl, ByVal NodeID As String, ByVal ProjectName As String)

        Dim strSQL As String = Nothing
        strSQL = Nothing
        Dim dt As New DataTable


        dt = getDataTables("select FileNames from IT_UploadFilesInfo where NodeID='" & NodeID & "' AND ProjectName='" & ProjectName & "'")

        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1 Step 1
                list.Items.Add(dt.Rows(i)("FileNames"))
            Next
        End If

        dt.Dispose()

        Return list

    End Function

#Region "释放内存资源"

    Declare Function SetProcessWorkingSetSize Lib "kernel32" Alias "SetProcessWorkingSetSize" _
       (ByVal hProcess As IntPtr, ByVal minSize As Integer, ByVal maxSize As Integer) As Long

    ''' <summary>
    ''' 在占用大量内在的窗体关闭时执行，释放内在
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub FlushMemory()

        Try

            GC.Collect()
            GC.WaitForPendingFinalizers()

            If Environment.OSVersion.Platform = PlatformID.Win32NT Then
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

#End Region


#Region "建立一个方法来加载Bug数据"
    ' ''' <summary>
    ' ''' 返回一个Datatable数据集合
    ' ''' </summary>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    'Public Function loadBugData(ByVal isCheck As Boolean) As DataTable

    '    Dim sql As String = Nothing

    '    sql = "select IT_DevelopBugManager.*,IT_SystemNameManager.SystemName,IT_SystemNameManager.SystemID " &
    '       " from IT_DevelopBugManager, IT_SystemNameManager " &
    '       " where IT_SystemNameManager.SystemID=IT_DevelopBugManager.SysProID and " &
    '       " IT_SystemNameManager.SystemName=IT_DevelopBugManager.SysProName and " &
    '       " (ByDesigneeJog='" & UserID & "' or ResultsConfirmJob='" & UserID & "') and ExpectedLife='" & DateTime.Now.ToString("yyyy-MM-dd") & "' and CurrentStatus<>'已验收'"

    '    Dim dt As New DataTable

    '    dt = getDataTables(sql)

    '    For i As Integer = 0 To dt.Rows.Count - 1 Step 1

    '        Dim CurrentStatus As String = dt.Rows(i)("CurrentStatus")

    '        Select Case CurrentStatus

    '            Case "待回覆"
    '                If dt.Rows(i)("ByDesigneeJog") <> UserID Then
    '                    dt.Rows.RemoveAt(i)
    '                End If

    '            Case "待验收"

    '                If dt.Rows(i)("ResultsConfirmJob") <> UserID Then
    '                    dt.Rows.RemoveAt(i)
    '                End If

    '        End Select

    '    Next

    '    Return dt

    '    End Function

#End Region

#Region "GRID绘制颜色"

    ''' <summary>
    ''' 公共方法
    ''' 为GRIDVIEW八绘制颜色
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Sub CustomDrawCell(ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs)

        '' 奇偶行颜色交替
        If e.RowHandle = Nothing Then Return

        Dim tempInt As Integer = e.RowHandle

        If Convert.ToInt32(tempInt) Mod 2 = 1 Then

            'e.Appearance.BackColor = Color.MistyRose
            e.Appearance.BackColor = Color.LightGray
        End If

    End Sub

#End Region



End Module
