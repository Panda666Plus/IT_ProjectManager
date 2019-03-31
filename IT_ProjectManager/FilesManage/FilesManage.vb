
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports clsFTPHelper

Public Class FTPFilesManager

    Dim FocusedNodeProName As String = Nothing
    Dim FocusedNodeProtooltip As String = Nothing
    Dim FocusedNodeRoot As String = Nothing
    Dim SelectNodeID As Integer = 0
    Dim Level As Integer
    Public xtype As Boolean = False
    Public SchemeName As String

    Dim client As New FTPHelper

    Dim td As Threading.Thread = Nothing

#Region "gridview管理"
    '' 处理奇偶行,交替颜色相差
    Private Sub GridView1_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GridView1.CustomDrawCell
        CustomDrawCell(e)
    End Sub
    ''行号
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator

        e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        If e.Info.IsRowIndicator Then

            If e.RowHandle >= 0 Then

                e.Info.DisplayText = (e.RowHandle + 1).ToString()

            ElseIf (e.RowHandle < 0 And e.RowHandle > -1000) Then

                e.Info.Appearance.BackColor = System.Drawing.Color.AntiqueWhite
                e.Info.DisplayText = e.RowHandle.ToString()

            End If
        End If

    End Sub

#End Region

#Region "treelist管理"

    ''' <summary>
    ''' 加载数据
    ''' </summary>
    ''' <remarks></remarks>
    Sub loalData()

        Application.DoEvents()

        Try
            Dim sql As String = " SELECT * FROM IT_FilesManager WHERE 1=1"

            If xtype Then

                sql = sql & " and p_id in (select  NodeID from IT_FilesManager where SchemeName like '%" & SchemeName & "%')" & _
                      " or NodeID in (select  NodeID from IT_FilesManager where SchemeName like '%" & SchemeName & "%')"
            End If

            Dim dt As New DataTable

            dt = getDataTables(sql)

            SetTreeList = New SetTreeListDelegate(AddressOf Me.bindingTreelistData)

            Me.Invoke(SetTreeList, FilesManagerNode, dt)

            dt.Dispose()

        Catch ex As Exception
            'MessageBox.Show("线程引发以下异常:" & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ''td.Join()
            td.Abort()
        End Try

    End Sub
    ''' <summary>
    ''' 为treelist委托绑定数据
    ''' </summary>
    ''' <param name="treelist"></param>
    ''' <param name="dt"></param>
    ''' <remarks></remarks>
    Sub bindingTreelistData(ByVal treelist As DevExpress.XtraTreeList.TreeList, ByVal dt As DataTable)
        Try

            treelist.Nodes.Clear()

            If dt.Rows.Count > 0 Then
                treelist.DataSource = dt
                treelist.RefreshDataSource()
                '' treelist.ExpandAll()
            End If

            dt.Dispose()

        Catch ex As Exception
            MessageBox.Show("委托引发以下异常:" & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    '' 增加项目明细
    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click

        Dim frm As New frmProjectManage
        frm.NodeID = 0
        frm.Level = 0
        frm.Text = "项目管理【增加项目】"
        frm.ShowDialog()

        td = New Threading.Thread(AddressOf loalData)
        td.Start()

    End Sub

    ''取得选择中内容与节点级别
    Private Sub FilesManagerNode_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles FilesManagerNode.FocusedNodeChanged

        If e.Node IsNot Nothing Then
            ''模块名称
            FocusedNodeProName = e.Node.GetValue("ProjectName").ToString()
            ''备注
            FocusedNodeProtooltip = e.Node.GetValue("tooltip").ToString()
            MemoEdit1.Text = FocusedNodeProtooltip
            ''项目名称
            FocusedNodeRoot = e.Node.RootNode.GetValue("ProjectName").ToString()
            '' 项目ID
            SelectNodeID = e.Node.GetValue("NodeID").ToString()
            '' 级别
            Level = e.Node.Level

            bindingData()

        End If

    End Sub
    '' 增加模块
    Private Sub AddModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddModel.Click

        If FocusedNodeProName Is Nothing Or FocusedNodeProName Is Nothing Then
            MessageBox.Show("请选择需要操作的内容？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        SelectNodeID = FilesManagerNode.FocusedNode.GetValue("NodeID").ToString()
        Dim frm As New frmProjectManage

        frm.NodeID = SelectNodeID
        'frm.Level = Level

        ''-----------2014/12/12      DEVON  该树节点从0开始，当“增加模块”时（即增加当前选中节点的子节点），新增节点的‘层数’为选中节点层数加1（即frm.Level = Level + 1）
        frm.Level = Level + 1
        ''-----------------------------------------

        frm.xtype = False
        frm.Text = "项目管理【增加模块】"
        frm.ShowDialog()

        td = New Threading.Thread(AddressOf loalData)
        td.Start()

    End Sub
    '' 修改项目
    Private Sub EditNode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditNode.Click
        'SelectNodeID = FilesManagerNode.FocusedNode.GetValue("NodeID").ToString()

        If FocusedNodeProName Is Nothing Or FocusedNodeProName Is Nothing Then
            MessageBox.Show("请选择需要操作的内容？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim NodeLavel As String = FilesManagerNode.FocusedNode.Level

        Dim frm As New frmProjectManage
        frm.NodeID = SelectNodeID
        frm.Level = Level
        frm.IsEdit = True
        frm.oldNodeName = FocusedNodeProName
        frm.txtPnmae.Text = FocusedNodeProName.ToString()
        frm.txttooltip.Text = FocusedNodeProtooltip.ToString()

        frm.Text = "项目管理【修改】"
        frm.ShowDialog()

        td = New Threading.Thread(AddressOf loalData)
        td.Start()

    End Sub
    '' 删除项目
    Private Sub DeleteNode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteNode.Click

        If FocusedNodeProName Is Nothing Or FocusedNodeProName Is Nothing Then
            MessageBox.Show("请选择需要操作的内容？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If FilesManagerNode.FocusedNode.Nodes.Count > 0 Then
            MessageBox.Show("该项目包含有子项目，请选择移除子项目？", "项目管理系统",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If GridView1.RowCount > 0 Then
            MessageBox.Show("该项目包含有上传一个或多个文档，是否移除所有附件？", "项目管理系统",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim _pid As String = FilesManagerNode.FocusedNode.GetValue("P_ID").ToString()

        Dim _level As Integer = Int16.Parse(FilesManagerNode.FocusedNode.Level)

        Dim result As New DialogResult

        result = MessageBox.Show("您确定需要删除以下项目信息吗？" & vbCrLf & "资料一旦删除则无法恢复，请选择？" & _
                               vbCrLf & "项目名称：" & FocusedNodeProName, "项目管理系统", MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                               MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then

            Dim del_sql = "delete IT_FilesManager where P_ID='" & _pid & "' and ProjectName='" & FocusedNodeProName & "' and LevelId='" & _level & "'"

            If ExecuteNonQuery(del_sql) <> 1 Then
                MessageBox.Show("删除数据失败", "项目管理系统")
            Else
                ''移除指定数据
                FilesManagerNode.FocusedNode.Nodes.Remove(FilesManagerNode.FocusedNode.Nodes.ParentNode)
                MessageBox.Show("删除数据成功", "项目管理系统")
            End If

        End If

    End Sub

    ''上传文件至FTP
    Private Sub uploadFTPFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uploadFTPFiles.Click

        If FocusedNodeProName Is Nothing Or FocusedNodeProName Is Nothing Then
            MessageBox.Show("请选择需要操作的内容？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim UPFiles As New UploadToFTP
        UploadToFTP.lblProName.Text = FocusedNodeProName.ToString()
        UploadToFTP.lbltooltip.Text = FocusedNodeProtooltip.ToString()
        UploadToFTP.P_ID = FilesManagerNode.FocusedNode.GetValue("P_ID").ToString()
        UploadToFTP.nodeid = SelectNodeID
        UploadToFTP.NodeRootName = FocusedNodeRoot
        UploadToFTP.ShowDialog()

        ''--------------------2014/12/12   DEVON 
        UploadToFTP.Dispose()          ''释放窗体UploadToFTP
        ''-----------------------------
        '' 刷新数据
        bindingData()

    End Sub
    ''' <summary>
    ''' 数据绑定
    ''' </summary>
    ''' <remarks></remarks>
    Sub bindingData()
        Try
            Dim SQL As String = "select * from IT_UploadFilesInfo where NodeID='" & SelectNodeID & "' and ProjectName='" & FocusedNodeProName & "'"
            Dim DT As New DataTable
            DT = getDataTables(SQL)
            GridControl1.DataSource = DT

            If xtype Then
                GridView1.Columns(1).Visible = False
                GridView1.Columns(0).Visible = False
                GridView1.Columns(3).Visible = False
                GridView1.Columns(4).Visible = False
                GridView1.Columns(5).Visible = False
                GridView1.Columns(6).Visible = False
            End If
            DT.Dispose()
        Catch

        End Try
    End Sub

    '' 修改附件信息
    Private Sub updataFTPFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If FocusedNodeProName Is Nothing Or FocusedNodeProName Is Nothing Then
            MessageBox.Show("请选择需要操作的内容？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim UPFiles As New UploadToFTP
        UPFiles.lblProName.Text = FocusedNodeProName.ToString()
        UPFiles.lbltooltip.Text = FocusedNodeProtooltip.ToString()
        UPFiles.P_ID = FilesManagerNode.FocusedNode.GetValue("P_ID").ToString()
        UPFiles.NodeRootName = FocusedNodeRoot
        UPFiles.ShowDialog()


    End Sub

    '' 删除单个附件
    Private Sub dellFTPFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dellFTPFiles.Click

        If GridView1.RowCount <= 0 Then
            MessageBox.Show("没有可操作的数据？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim gridFileNames As String = GridView1.GetFocusedRowCellValue("FileNames").ToString()

        Dim getFTPPaht As String = GridView1.GetFocusedRowCellValue("FTPFilesPath").ToString()

        Dim tempName As String = GridView1.GetFocusedRowCellValue("FTPFileName").ToString()

        If gridFileNames Is Nothing Or getFTPPaht Is Nothing Or tempName Is Nothing Then
            MessageBox.Show("请选择需要删除的项目？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim result As New DialogResult

        result = MessageBox.Show("确定需要删除附件[" & gridFileNames & "]吗？" & vbCrLf & "资料一旦删除则无法恢复，请慎重？", "项目管理系统",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = Windows.Forms.DialogResult.No Then Exit Sub

        '' 删除FTP文件
        Dim ftpMG As New FTPFielsManager

        ftpMG.DelFTPFile(SelectNodeID, FocusedNodeProName, gridFileNames)

        '' 删除GRIDVIEW中指定行
        Me.GridView1.DeleteRow(GridView1.FocusedRowHandle)

    End Sub

    '' 删除指定模块中所有附件
    Private Sub delFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delFiles.Click

        Dim result As New DialogResult

        If GridView1.RowCount < 1 Then
            MessageBox.Show("没有可操作数据？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        result = MessageBox.Show("请注意，您正试图删除指定信息？" & vbCrLf & "项目名称【" & FocusedNodeRoot & "】;" & vbCrLf & _
             "模块名称【" & FocusedNodeProName & "】", "项目管理系统", MessageBoxButtons.YesNo,
             MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)

        If result = DialogResult.No Then Exit Sub

        Dim sql As String = "select FileNames,FTPFileName,FTPFilesPath from IT_UploadFilesInfo where NodeID='" & SelectNodeID & "' and ProjectName='" & FocusedNodeProName & "'"

        Dim FtpPaht As String = Nothing

        Dim dt As New DataTable
        dt = getDataTables(sql)
        If dt.Rows.Count < 1 Then
            MessageBox.Show("批量删除附件失败，原因：获取FTP路径失败？", "项目管理系统")
            Return
        Else

            FtpPaht = dt.Rows(0)(2).ToString()

            client.ChangeDirectory(FtpPaht)

            For i As Integer = 0 To dt.Rows.Count - 1 Step 1

                '' 删除文件
                client.DeleteFile(dt.Rows(i)(1).ToString())
            Next

            '' 移除文件夹
            client.RemoveDirectory(FtpPaht)

            '' 删除记录信息
            Dim del As String = "delete IT_UploadFilesInfo where NodeID='" & SelectNodeID & "' and ProjectName='" & FocusedNodeProName & "'"
            '' 执行sql
            ExecuteNonQuery(del)
            '' 清空数据
            GridControl1.DataSource = Nothing

            MessageBox.Show("批量删除指定附件成功！" & vbCrLf & "项目名称【" & FocusedNodeRoot & "】" & _
                            vbCrLf & "模块名称【" & FocusedNodeProName & "】", "项目管理系统")

        End If

    End Sub

    '' 显示图片
    Private Sub FilesManagerNode_GetSelectImage(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.GetSelectImageEventArgs) Handles FilesManagerNode.GetSelectImage

        If e.Node Is Nothing Then Exit Sub
        Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
        node = e.Node
        Dim ID As Integer = e.Node.Level
        e.NodeImageIndex = ID

    End Sub

#End Region

#Region "附件下载"

    '' 下载模板
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        Dim save As New FolderBrowserDialog

        If save.ShowDialog() = DialogResult.OK Then

            Me.Cursor = Cursors.WaitCursor

            Dim localPath As String = Nothing

            localPath = save.SelectedPath

            client.ChangeDirectory("/FilesManager/FilesTemplate")

            '' 判断FTP文件是否存在
            client.DownloadFile("01.docx", localPath + "\" + "系统需求表.docx")
            client.DownloadFile("02.docx", localPath + "\" + "系统需求实现分析表.docx")
            client.DownloadFile("03.doc", localPath + "\" + "数据字典表结构.doc")
            client.DownloadFile("04.vsd", localPath + "\" + "文档管理模块.vsd")
            MessageBox.Show("下载成功？" & vbCrLf & "目录：" & localPath, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cursor = Cursors.Default

        End If
    End Sub

    ''' <summary>
    ''' 附件预览
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ViewFtpFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewFtpFile.Click, GridControl1.MouseDoubleClick

        If GridView1.RowCount < 1 Then Exit Sub

        Dim gridFileNames As String = GridView1.GetFocusedRowCellValue("FileNames").ToString()

        Dim NODEID As String = GridView1.GetFocusedRowCellValue("NodeID").ToString()

        Dim ProjectName As String = GridView1.GetFocusedRowCellValue("ProjectName").ToString()

        If gridFileNames Is Nothing Or NODEID Is Nothing Or ProjectName Is Nothing Then
            MessageBox.Show("选择需要流览的附件？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim PreviewFtpFile As New FTPFielsManager

        If Not PreviewFtpFile.Preview(NODEID, ProjectName, gridFileNames) Then
            MessageBox.Show("生成预览失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Me.Cursor = Cursors.Default

    End Sub
    '' 下一个或多个附件
    Private Sub DownFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownFile.Click

        If GridView1.RowCount < 1 Then Exit Sub

        Dim gridFileNames As String = GridView1.GetFocusedRowCellValue("FileNames").ToString()

        Dim tempName As String = GridView1.GetFocusedRowCellValue("FTPFileName").ToString()

        Dim getFTPPaht As String = GridView1.GetFocusedRowCellValue("FTPFilesPath").ToString()

        If gridFileNames Is Nothing Or getFTPPaht Is Nothing Then
            MessageBox.Show("请选择需要下载的附件？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim save As New FolderBrowserDialog

        If save.ShowDialog() = DialogResult.OK Then

            Me.Cursor = Cursors.WaitCursor

            Dim localPath As String = Nothing

            localPath = save.SelectedPath

            client.ChangeDirectory(getFTPPaht)

            '' 判断FTP文件是否存在

            If client.DownloadFile(tempName, localPath + "\" + gridFileNames) Then
                MessageBox.Show("下载成功？" & vbCrLf & "目录：" & localPath, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("下载失败，请与管理员联系？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Me.Cursor = Cursors.Default

        End If

    End Sub

    '' 批量下载
    Private Sub DownAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownAll.Click
        Dim downFile As New FTPFielsManager
        downFile.ShowDownFileResult(FocusedNodeProName, SelectNodeID)
    End Sub

#End Region

    ''载入文档项目树
    Private Sub FTPFilesManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '' 登录权限验证
        Dim root As New CheckRoot
        Dim rsult As Boolean = root.RootManager(UserName, UserID, SelectNodeID)

        If Not IsProjectManager And Not IsLeader And Not rsult Then
            EditNode.Visible = False
            DeleteNode.Visible = False
            uploadFTPFiles.Visible = False
            delFiles.Visible = False
            dellFTPFiles.Visible = False
        End If

        td = New Threading.Thread(AddressOf loalData)
        td.Start()

    End Sub


End Class

