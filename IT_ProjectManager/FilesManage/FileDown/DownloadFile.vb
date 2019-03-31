
Imports System.Threading
Imports clsFTPHelper
Public Class DownloadFile

    Public ProjectName As String = Nothing

    Public NodeID As String = Nothing

    Public localPaht As String = Nothing



    Private Sub DownloadFile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Show()
        DownloadFile()

    End Sub


    ''' <summary>
    ''' 下载文件
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub DownloadFile()

        Dim sql As String = "select FileNames,FTPFileName,FTPFilesPath from IT_UploadFilesInfo where NodeID='" & NodeID & "' and ProjectName='" & ProjectName & "'"

        Dim FtpPaht As String = Nothing

        Dim dt As New DataTable
        dt = getDataTables(sql)

        If dt.Rows.Count > 0 Then

            DownPro.Properties.Minimum = 0
            DownPro.Properties.Maximum = dt.Rows.Count
            DownPro.Properties.Step = 1

            FtpPaht = dt.Rows(0)(2).ToString()

            Dim client As New FTPHelper

            client.ChangeDirectory(FtpPaht)

            lblFTPPaht.Text = FtpPaht

            Dim DownFileName As String = Nothing

            Dim loadFileName As String = Nothing

            For i As Integer = 0 To dt.Rows.Count - 1 Step 1

                DownFileName = dt.Rows(i)(1).ToString()

                loadFileName = dt.Rows(i)(0).ToString()

                '' 文件名
                lblFTPFilesName.Text = loadFileName

                '' 文件大小
                lblFilesSize.Text = client.GetFileSize(DownFileName)

                '' 下载文件
                If client.DownloadFile(DownFileName, localPaht & "\" + loadFileName) Then
                    lblResult.ForeColor = Color.Blue
                    lblResult.Text = "下载成功"
                Else
                    lblResult.ForeColor = Color.Red
                    lblResult.Text = "下载失败"
                End If

                DownPro.PerformStep()
                DownPro.Update()

                Application.DoEvents()
                Thread.Sleep(500)

            Next

            MessageBox.Show("下载指定附件成功！" & vbCrLf & "保存至:" & localPaht + "\", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Else
            MessageBox.Show("没有可下载附件？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If

        Me.Close()

    End Sub

End Class