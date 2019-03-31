
Imports System.IO
Imports System.Text
Imports clsFTPHelper

Public Class UploadToFTP

    ''' <summary>
    ''' 文件信息状态
    ''' </summary>
    ''' <remarks></remarks>
    Dim FinfoStatus As Boolean = False
    Dim fInfo As FileInfo
    Public P_ID As Integer
    Public nodeid As Integer = 0

    Dim client As New FTPHelper

    ''' <summary>
    '''  储存项目名称
    ''' </summary>
    ''' <remarks></remarks>
    Public NodeRootName As String

    Private Sub HideInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideInfo.Click

        If FinfoStatus Then
            InfoControl.Height = 21
            Me.Height = 364
            FinfoStatus = False
            HideInfo.Text = "6"
            HideInfo.ToolTip = "展开文件信息"
            bt_OK.Location = New Point(446, 305)
            Uploadpro.Location = New Point(13, 310)
            btExit.Location = New Point(519, 305)
        Else
            InfoControl.Height = 149
            Me.Height = 491
            FinfoStatus = True
            HideInfo.Text = "5"
            HideInfo.ToolTip = "隐藏文件信息"
            bt_OK.Location = New System.Drawing.Point(446, 430)
            btExit.Location = New Point(519, 430)
            Uploadpro.Location = New Point(13, 435)
        End If

    End Sub

    '' 选择待上传之文档
    Private Sub ButtonEdit1_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit1.ButtonClick
        On Error Resume Next
        Dim fileList As New OpenFileDialog
        fileList.Title = "项目文档上传"
        fileList.Filter = "Office Documents(*.docx, *.xlsx, *.pptx, *.vsd, *.accdb)|*.docx;*.xlsx;*.pptx;*..vsd;*.accdb|" & _
        "PDF Files(*.pdf)|*.pdf|txt Files(*.txt)|*.txt|压缩文件(*.zip, *.7z, *.rar, *.RAR5)|*.zip;*.7z;*.rar;*.RAR5;|全部(*.*)|*.*;"
        fileList.Multiselect = True
        If fileList.ShowDialog() = DialogResult.OK Then

            '' 如果不为空则指行下一步操作
            If fileList.FileNames IsNot Nothing Then

                Dim filename As String

                For Each filename In fileList.FileNames

                    For i As Integer = 0 To ListBoxControl1.Items.Count - 1 Step 1

                        If filename = ListBoxControl1.Items(i).ToString().Trim() Then
                            MessageBox.Show("文件【" & Path.GetFileName(filename) & "】已经存在", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If

                    Next
                    ListBoxControl1.Items.Add(filename)
                Next

                HideInfo.PerformClick()

            End If
        End If

    End Sub

    '' 取得指定文件信息
    Private Sub ListBoxControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxControl1.SelectedIndexChanged

        If ListBoxControl1.SelectedIndex < 0 Then Exit Sub
        Dim Fname As String = ListBoxControl1.SelectedItem.ToString()
        fInfo = New FileInfo(ListBoxControl1.SelectedItem.ToString())
        lblFname.Text = fInfo.Name
        lblLastWrite.Text = fInfo.LastWriteTime
        lblFsize.Text = fInfo.Length & "KB"
        lblFcreateDT.Text = fInfo.CreationTime.ToString("yyyy-MM-dd HH:mm:ss")

    End Sub

    '' 关闭窗体
    Private Sub btExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExit.Click

        Me.Close()

    End Sub

    Private Sub bt_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_OK.Click

        If ListBoxControl1.Items.Count < 1 Then Exit Sub

        Me.Enabled = False

        ''ftp连接成功
        If (client.Login()) Then

            Dim i As Integer = 0
            Dim Fname As String = Nothing
            Dim GetFilesNames As String = Nothing
            Dim insert_sql As New StringBuilder

            ''初始化进度条
            Uploadpro.Properties.Minimum = 0
            Uploadpro.Properties.Maximum = ListBoxControl1.Items.Count - 1
            Uploadpro.Properties.Step = 1
            '' 创建文件
            client.CreateDirectory("/FilesManager/" & nodeid)

            '' FTP路径
            client.ChangeDirectory("/FilesManager/" & nodeid)

            insert_sql.Append(" delete IT_UploadFilesInfo where NodeID='" & nodeid & "' and ProjectName='" & lblProName.Text & "'")

            Dim temp As String = Nothing

            If Not Directory.Exists("C:\\Temp") Then
                Directory.CreateDirectory("C:\\Temp")
            End If

            For i = 0 To ListBoxControl1.Items.Count - 1

                ListBoxControl1.SelectedIndex = i
                '''' 检查待上传文件名称是否合法
                Fname = ListBoxControl1.Items(i).ToString()
                '' fff表示毫秒
                temp = DateTime.Now.ToString("yyyyMMddHHmmssfff")

                GetFilesNames = Path.GetFileName((Fname))

                '' 返回为true成功，false失败
                If client.IsValidFileName(GetFilesNames) Then

                    File.Copy(Fname, "C:\\Temp\\" + temp)

                    ''上传指定文件
                    If client.UploadFile("C:\\Temp\\" + temp) Then
                        '' 插入数据
                        insert_sql.Append("insert into IT_UploadFilesInfo values('" & nodeid & "','" & lblProName.Text & "','" & UserID & "','" &
                                          UserName & "','" & GetFilesNames & "','" & temp & _
                                          "','" & lblFsize.Text.Trim() & "','" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & _
                                          "','/FilesManager/" & nodeid & "')")
                    Else
                        MessageBox.Show("文档【" & GetFilesNames & "】上传失败？" & vbCrLf & "原因：文档名称请尽量不要使用中文命名。", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Enabled = True
                        Return
                    End If
                Else
                    MessageBox.Show(GetFilesNames & "，文档中包含非字符？" & vbCrLf & "文档中不能包含（\\/:*?\<>|""）特殊符号？", "项目管理系统",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Enabled = True
                    Return
                End If

                '' 处理进度条
                Uploadpro.PerformStep()
                Application.DoEvents()
                Uploadpro.Update()
                System.Threading.Thread.Sleep(500)

            Next

            '' 执行sql语句
            If ExecuteNonQuery(insert_sql.ToString()) = 0 Then
                MessageBox.Show("数据库更新失败", "项目管理系统")
            Else

                Me.Enabled = True
                Me.Close()
                MessageBox.Show("操作成功", "项目管理系统")

            End If
            Me.Enabled = True

        End If
    End Sub
    '' 移除选中项目
    Private Sub ListBoxControl1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxControl1.MouseDoubleClick

        '' 移除选择项目
        If ListBoxControl1.SelectedIndex < 0 Then Exit Sub

        Dim tempFileName As String = ListBoxControl1.SelectedItem

        Dim result As New DialogResult

        result = MessageBox.Show("确定需要删除附件[" & tempFileName & "]吗？" & vbCrLf & "资料一旦删除则无法恢复，请慎重？", "项目管理系统",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = Windows.Forms.DialogResult.No Then Exit Sub

        '' 删除FTP文件
        Dim ftpMG As New FTPFielsManager

        ftpMG.DelFTPFile(nodeid, lblProName.Text, tempFileName)

        '' 移除list内容
        ListBoxControl1.Items.Remove(ListBoxControl1.SelectedItem)

    End Sub

    Private Sub ButtonEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit1.EditValueChanged

    End Sub

    Private Sub UploadToFTP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class