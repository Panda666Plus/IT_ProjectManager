Imports System.IO
Imports System.Text
Imports clsFTPHelper

Public Class FTPFielsManager

    Dim client As New FTPHelper



    ''' <summary>
    ''' '上伟FTP文件及插入数据
    ''' -1：ftp登录擒贼
    ''' 1：上传失败
    ''' 0：文档中包含非字符
    ''' 2：成功
    ''' </summary>
    ''' <param name="AutoID">ID号</param>
    ''' <param name="ProName">项目名称</param>
    ''' <param name="UploadProgressBar">进度控件</param>
    ''' <param name="uploadList">listbox控件</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function uploadFTPFile(ByVal AutoID As String, ByVal ProName As String, ByVal UploadProgressBar As DevExpress.XtraEditors.ProgressBarControl, ByVal uploadList As DevExpress.XtraEditors.ListBoxControl) As Integer

        ''ftp连接成功
        If (client.Login()) Then
            '' 取得登录信息

            Dim i As Integer = 0
            Dim Fname As String = Nothing
            Dim GetFilesNames As String = Nothing
            Dim insert_sql As New StringBuilder

            UploadProgressBar.Visible = True
            ''初始化进度条
            UploadProgressBar.Properties.Minimum = 0
            UploadProgressBar.Properties.Maximum = uploadList.Items.Count - 1
            UploadProgressBar.Properties.Step = 1
            '' 创建文件
            client.CreateDirectory("/FilesManager/" & AutoID)

            '' FTP路径
            client.ChangeDirectory("/FilesManager/" & AutoID)

            insert_sql.Append(" delete IT_UploadFilesInfo where NodeID='" & AutoID & "' and ProjectName='" & ProName & "'")

            Dim temp As String = Nothing
            '' 计算文件大小
            Dim tempFileSize As String = Nothing
            Dim fInfo As FileInfo

            If Not IO.Directory.Exists("C:\\Temp") Then
                Directory.CreateDirectory("C:\\Temp")
            End If

            For i = 0 To uploadList.Items.Count - 1

                uploadList.SelectedIndex = i
                '''' 检查待上传文件名称是否合法
                Fname = uploadList.Items(i).ToString()

                If File.Exists(Fname) Then  ''判断文件是否存在，如不存在则不上传

                    '' fff表示毫秒
                    temp = DateTime.Now.ToString("yyyyMMddHHmmssfff")

                    GetFilesNames = Path.GetFileName((Fname))

                    ''取得文件大小
                    fInfo = New FileInfo(uploadList.SelectedItem.ToString())
                    tempFileSize = fInfo.Length & "KB"

                    '' 返回为true成功，false失败
                    If client.IsValidFileName(GetFilesNames) Then

                        File.Copy(Fname, "C:\\Temp\\" + temp)

                        ''上传指定文件
                        If client.UploadFile("C:\\Temp\\" + temp) Then

                            '' 插入数据
                            insert_sql.Append("insert into IT_UploadFilesInfo values('" & AutoID & "','" & ProName & "','" & UserID & "','" &
                                              UserName & "','" & GetFilesNames & "','" & temp & _
                                              "','" & tempFileSize.Trim() & "','" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & _
                                              "','/FilesManager/" & AutoID & "')")

                        Else
                            Return 1  '文档名称请尽量不要使用中文命名
                        End If
                    Else
                        Return 0 '文档中包含非字符
                    End If

                End If

                '' 处理进度条
                UploadProgressBar.PerformStep()
                Application.DoEvents()
                UploadProgressBar.Update()
                System.Threading.Thread.Sleep(500)

            Next

            UploadProgressBar.Visible = False

            '' 执行sql语句
            If ExecuteNonQuery(insert_sql.ToString()) = 0 Then
                'MessageBox.Show("数据库更新失败", "项目管理系统")
                Return 0
            End If
        Else
            Return -1 '' FTP登录失败
        End If

        Return 2

    End Function

    ''' <summary>
    ''' 预览FTP文件
    ''' </summary>
    ''' <param name="AutoID">Nodeid</param>
    ''' <param name="ProjectName">项目名称</param>
    ''' <param name="FileNames">保存在本地的文件名</param>
    ''' <returns>返回一个bool值，true成功，false失败</returns>
    ''' <remarks></remarks>
    Public Function Preview(ByVal AutoID As String, ByVal ProjectName As String, ByVal FileNames As String) As Boolean

        Preview = True

        Dim dt As New DataTable
        dt = getDataTables("select * from IT_UploadFilesInfo where NodeID='" & AutoID & "' AND ProjectName='" & ProjectName &
                           "' and FileNames='" & FileNames & "'")

        If dt.Rows.Count <> 1 Then
            MessageBox.Show("无法生成预览，原因：存在多个相同文件？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        Dim ftpPaht As String = Nothing
        Dim FtpName As String = Nothing
        Dim localFileName As String = Nothing

        ftpPaht = dt.Rows(0)("FTPFilesPath").ToString()
        FtpName = dt.Rows(0)("FTPFileName").ToString()
        localFileName = dt.Rows(0)("FileNames").ToString()

        If Not System.IO.Directory.Exists("C:\temp") Then
            System.IO.Directory.CreateDirectory("C:\temp")
        End If

        Dim localPath As String = "C:\temp\"

        client.ChangeDirectory(ftpPaht)

        If client.DownloadFile(FtpName, localPath + "\" + localFileName) Then

            Dim OpenToExcelFile = New System.Diagnostics.Process()
            Dim myProcessStartInfo = New System.Diagnostics.ProcessStartInfo(localPath & "\" & FileNames)
            OpenToExcelFile.StartInfo = myProcessStartInfo
            OpenToExcelFile.Start()

        Else
            ''MessageBox.Show("生成预览失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Preview = False
        End If

        Return Preview

    End Function

    ''' <summary>
    ''' 显示下载保存对话框
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ShowDownFileResult(ByVal ProName As String, ByVal id As String)

        Dim save As New SaveFileDialog

        save.Title = "附件下载"

        save.FileName = ProName

        If save.ShowDialog() = DialogResult.OK Then

            Dim localPath As String = Nothing

            localPath = save.FileName

            '' 创建一个文件夹
            If Not System.IO.Directory.Exists(localPath) Then
                System.IO.Directory.CreateDirectory(localPath)
            End If

            Dim down As New DownloadFile
            down.NodeID = id
            down.ProjectName = ProName
            down.localPaht = localPath
            down.ShowDialog()

        End If

    End Sub

    ''' <summary>
    ''' 删除指定FTP文件
    ''' </summary>
    ''' <param name="id">ID号</param>
    ''' <param name="ProName">项目名称</param>
    ''' <param name="delFileName">待删除文件</param>
    ''' <remarks></remarks>
    Public Sub DelFTPFile(ByVal id As String, ByVal ProName As String, ByVal delFileName As String)

        '' 取得FTP文件数据
        Dim sql As String = "select FileNames,FTPFileName,FTPFilesPath from IT_UploadFilesInfo where NodeID='" & id & "' and ProjectName='" & ProName &
            "' and FileNames='" & delFileName & "'"

        Dim dt As New DataTable
        dt = getDataTables(sql)

        If dt.Rows.Count <> 1 Then
            ' MessageBox.Show("无法删除，原因同时存在多个相同文件？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim gridFileNames As String = dt.Rows(0)("FileNames").ToString()

        Dim getFTPPaht As String = dt.Rows(0)("FTPFilesPath").ToString()

        Dim tempName As String = dt.Rows(0)("FTPFileName").ToString()

        If gridFileNames Is Nothing Or getFTPPaht Is Nothing Or tempName Is Nothing Then
            ' MessageBox.Show("获取移除附件信息失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If

        Dim delsql As String = "delete IT_UploadFilesInfo Where NodeID='" & id & "' and ProjectName='" & ProName &
            "' and FileNames='" & gridFileNames & "' "

        ExecuteNonQuery(delsql)

        '' 改变FTP路径
        client.ChangeDirectory(getFTPPaht)

        '' 删除指定文件
        client.DeleteFile(tempName)

        '' 删除整个资料夹，如果有子文件是不会删除的，
        ''只有文件夹为空时删除才会删除成功()
        client.RemoveDirectory(getFTPPaht)

    End Sub

End Class
