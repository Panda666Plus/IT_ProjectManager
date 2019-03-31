
'这个类支持以下FTP命令：
'-Upload 一个文件
'-Download一个文件
'-Create 一个目录
'-Remove 一个目录
'-改变目录
'-Remove 一个文件
'-Rename 一个文件
'-Set 远程用户的用户名
'-Set 远程用户的密码

Imports System
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Net.Sockets

''' <summary>
''' FTP 类
''' </summary>
''' <remarks></remarks>
Public Class FTPHelper

#Region "检查待上传文件是否合法"

    Public Function IsValidFileName(ByVal fileName As String) As Boolean

        IsValidFileName = True

        Dim errChar As String = "\\/:*?\<>|"""

        If fileName Is Nothing Then
            IsValidFileName = False
        Else
            Dim i As Integer = 0
            For i = 0 To errChar.Length - 1
                If fileName.Contains(errChar(i).ToString()) Then
                    IsValidFileName = False
                    Exit For
                End If
            Next
        End If

        Return IsValidFileName

    End Function

#End Region

#Region "类变量声明"

    Public m_sRemotePath, m_sRemoteUser As String
    Public m_sRemoteHost As String
    Private m_sRemotePassword, m_sMess As String
    Private m_iRemotePort, m_iBytes As Int32
    Private m_objClientSocket As Socket
    Private m_iRetValue As Int32
    Private m_bLoggedIn As Boolean
    Private m_sMes, m_sReply As String

    '设置用户来对FTP服务器读取和写入数据的数据包的大小
    '对下列具伐大小
    Public Const BLOCK_SIZE = 512
    Private m_aBuffer(BLOCK_SIZE) As Byte
    Private GB2312 As Encoding = Encoding.GetEncoding("gb2312")
    Public flag_bool As Boolean
    '如通变量定义
    Private m_sMessageString As String
#End Region

#Region "连线类"

    ''' <summary>
    ''' Main类的构造函数
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        m_sRemoteHost = "192.168.10.21"
        '' 正在路径
        m_sRemotePath = "/FilesManager/localuser"
        m_sRemoteUser = "ftpuser"
        m_sRemotePassword = "Ftp@pass"
        m_sMessageString = ""
        'm_iRemotePort = 101
        m_iRemotePort = "21"
        m_bLoggedIn = False
    End Sub

    ''' <summary>
    ''' 参数化的构造函数
    ''' </summary>
    ''' <param name="sRemoteHost"></param>
    ''' <param name="sRemotePath"></param>
    ''' <param name="sRemoteUser"></param>
    ''' <param name="sRemotePassword"></param>
    ''' <param name="iRemotePort"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal sRemoteHost As String, _
    ByVal sRemotePath As String, _
    ByVal sRemoteUser As String, _
    ByVal sRemotePassword As String, _
    ByVal iRemotePort As Int32)

        m_sRemoteHost = sRemoteHost
        m_sRemotePath = sRemotePath
        m_sRemoteUser = sRemoteUser
        m_sRemotePassword = sRemotePassword
        m_sMessageString = ""
        m_iRemotePort = 21
        m_bLoggedIn = False

    End Sub

#End Region

#Region "公共属性"

    ''' <summary>
    ''' 设置或得到你想链接的FTP服务器的名称
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Property RemoteHostFTPServer() As String
        '得到FTP服务器的名称
        Get
            Return m_sRemoteHost
        End Get

        '设置FTP服务器的名称

        Set(ByVal Value As String)
            m_sRemoteHost = Value
        End Set
    End Property



    ''' <summary>
    ''' 设置或得到你想链接的FTP服务器的FTP端口
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Property RemotePort() As Int32

        '得到FTP端口号

        Get
            Return m_iRemotePort
        End Get

        '设置FTP端口数号

        Set(ByVal Value As Int32)
            m_iRemotePort = Value
        End Set
    End Property

    ''' <summary>
    ''' 设置或得到你想链接的FTP服务器的远程路径
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Property RemotePath() As String

        '得到远程路径
        Get
            Return m_sRemotePath
        End Get
        '设置远程路径
        Set(ByVal Value As String)
            m_sRemotePath = Value
        End Set
    End Property

    ''' <summary>
    ''' 设置你想链接的远程FTP服务器的密码
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Property RemotePassword() As String
        Get
            Return m_sRemotePassword
        End Get
        Set(ByVal Value As String)
            m_sRemotePassword = Value
        End Set
    End Property

    ''' <summary>
    ''' 设置或得到链接远程的FTP服务器的用户
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Property RemoteUser() As String
        Get
            Return m_sRemoteUser
        End Get

        Set(ByVal Value As String)
            m_sRemoteUser = Value
        End Set
    End Property

    ''' <summary>
    ''' 设置messagestring类
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Property MessageString() As String
        Get
            Return m_sMessageString
        End Get

        Set(ByVal Value As String)
            m_sMessageString = Value
        End Set
    End Property

#End Region

#Region "公共函数"

    ''' <summary>
    ''' 从文件系统中返回一个文件列表。在string()函数中返回文件。
    ''' </summary>
    ''' <param name="sMask"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetFileList(ByVal sMask As String) As String()
        Dim cSocket As Socket
        Dim bytes As Int32
        Dim seperator As Char = ControlChars.Lf
        Dim mess() As String

        m_sMes = ""

        Try

            '检查你是否登录到FTP服务器上
            If (Not (m_bLoggedIn)) Then
                Login()
            End If

            cSocket = CreateDataSocket()
            '发送FTP命令

            SendCommand("NLST " & sMask)
            If (Not (m_iRetValue = 150 Or m_iRetValue = 125)) Then
                MessageString = m_sReply
                Throw New IOException(m_sReply.Substring(4))
            End If
            m_sMes = ""
            Do While (True)
                m_aBuffer.SetValue(m_aBuffer, 0, m_aBuffer.Length)
                bytes = cSocket.Receive(m_aBuffer, m_aBuffer.Length, 0)
                m_sMes += GB2312.GetString(m_aBuffer, 0, bytes)

                If (bytes < m_aBuffer.Length) Then
                    Exit Do
                End If
            Loop

            mess = m_sMes.Split(seperator)
            cSocket.Close()
            ReadReply()

            If (m_iRetValue <> 226) Then
                MessageString = m_sReply
                Throw New IOException(m_sReply.Substring(4))
            End If

        Catch
            mess = Nothing
        End Try

        Return mess

    End Function

    ''' <summary>
    ''' 得到FTP服务器上的文件大小
    ''' </summary>
    ''' <param name="sFileName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetFileSize(ByVal sFileName As String) As Long
        Dim size As Long

        If (Not (m_bLoggedIn)) Then
            Login()
        End If

        '发送一个FTP命令
        SendCommand("SIZE " & sFileName)
        size = 0

        If (m_iRetValue = 213) Then
            size = Int64.Parse(m_sReply.Substring(4))
        Else
            MessageString = m_sReply
            Throw New IOException(m_sReply.Substring(4))
        End If

        Return size

    End Function

    ''' <summary>
    ''' 登录FTP服务器
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Login() As Boolean

        m_objClientSocket = _
         New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Dim ep As New IPEndPoint(IPAddress.Parse(m_sRemoteHost), m_iRemotePort)

        Try
            m_objClientSocket.Connect(ep)
        Catch ex As Exception
            MessageString = m_sReply
            Throw New IOException("Cannot connect to the remote server")
        End Try

        ReadReply()
        If (m_iRetValue <> 220) Then
            CloseConnection()
            MessageString = m_sReply
            Throw New IOException(m_sReply.Substring(4))
        End If

        '为了发送一个对服务器的用户登录ID，发送一个FTP命令

        SendCommand("USER " & m_sRemoteUser)

        If (Not (m_iRetValue = 331 Or m_iRetValue = 230)) Then
            Cleanup()
            MessageString = m_sReply
            Throw New IOException(m_sReply.Substring(4))
        End If

        If (m_iRetValue <> 230) Then
            '为了发送一个对服务器的用户密码，发送一个FTP命令
            SendCommand("PASS " & m_sRemotePassword)
            If (Not (m_iRetValue = 230 Or m_iRetValue = 202)) Then
                Cleanup()
                MessageString = m_sReply
                Throw New IOException(m_sReply.Substring(4))
            End If
        End If

        m_bLoggedIn = True
        '为了改变映射的远程服务器的文件夹的目录，调用用户定义的ChangeDirectory函数
        ChangeDirectory(m_sRemotePath)

        '返回最终结果
        Return m_bLoggedIn
    End Function

    ''' <summary>
    ''' 如果模式值为真，对下载设置为二进制模式。否则，设置为GB2312模式
    ''' </summary>
    ''' <param name="bMode"></param>
    ''' <remarks></remarks>
    Public Sub SetBinaryMode(ByVal bMode As Boolean)
        If (bMode) Then
            '发送FTP命令，设置为二进制模式
            '(TYPE是一种用作说明??类型的FTP命令.)
            SendCommand("TYPE I")
        Else
            '发送FTP命令，设置GB2312模式。
            '(TYPE是一种用作说明??类型的FTP命令。)
            SendCommand("TYPE A")
        End If
        If (m_iRetValue <> 200) Then
            MessageString = m_sReply
            Throw New IOException(m_sReply.Substring(4))
        End If
    End Sub

    ''' <summary>
    ''' 向配置好的本地目录下载一个文件。保持文件名一样。
    ''' 默认当前程序目录
    ''' </summary>
    ''' <param name="sFileName">文件名</param>
    ''' <remarks></remarks>
    Public Sub DownloadFile(ByVal sFileName As String)
        DownloadFiles(sFileName, My.Computer.FileSystem.CurrentDirectory + "\\", False)
    End Sub

    ''' <summary>
    ''' 指定的本地文件夹下载一个远程文件。保持文件名一样。
    ''' </summary>
    ''' <param name="sFileName"></param>
    ''' <param name="bResume"></param>
    ''' <remarks></remarks>
    Public Sub DownloadFile(ByVal sFileName As String, ByVal sLocalFileName As String, ByVal bResume As Boolean)

        DownloadFiles(sFileName, sLocalFileName, bResume)

    End Sub

    ''' <summary>
    '''    对本地文件名下载一个远程文件。你必须配置一个路径。
    '''    本地文件名将会创建或者将会被重写，但是路径必须存在。
    ''' </summary>
    ''' <param name="sFileName">FTP文件名称</param>
    ''' <param name="sLocalFileName">保存在本地时名称</param>
    ''' <remarks></remarks>
    Public Function DownloadFile(ByVal sFileName As String, ByVal sLocalFileName As String) As Boolean

        If Not DirectoryExist(sFileName) Then Return False

        If DownloadFiles(sFileName, sLocalFileName, False) Then
            Return True
        Else
            Return False
        End If


    End Function

    ''' <summary>
    ''' 对一个本地文件名下载一个远程文件。必须包含一个路径。
    ''' 设置恢复标志。本地文件名将会被创建或被重写，但是本地路径必须存在。
    ''' </summary>
    ''' <param name="sFileName">文件名</param>
    ''' <param name="sLocalFileName">本地路径</param>
    ''' <param name="bResume">是否恢复</param>
    ''' <remarks></remarks>
    Private Function DownloadFiles(ByVal sFileName As String, ByVal sLocalFileName As String, ByVal bResume As Boolean) As Boolean

        DownloadFiles = True

        Dim st As Stream
        Dim output As FileStream
        Dim cSocket As Socket
        Dim offset, npos As Long

        If (Not (m_bLoggedIn)) Then
            Login()
        End If

        '' 设置模式
        SetBinaryMode(True)

        Dim localPath As String = sLocalFileName

        If (Not (File.Exists(localPath))) Then
            st = File.Create(localPath)
            st.Close()
        End If

        output = New FileStream(localPath, FileMode.Open, FileAccess.Write)
        cSocket = CreateDataSocket()
        offset = 0

        If (bResume) Then

            offset = output.Length

            If (offset > 0) Then
                '发送一个FTP命令重新启动
                SendCommand("REST " & offset)
                If (m_iRetValue <> 350) Then
                    offset = 0
                End If
            End If

            If (offset > 0) Then
                npos = output.Seek(offset, SeekOrigin.Begin)
            End If
        End If

        '发送一个FTP命令重新找到一个文件。
        SendCommand("RETR " & sFileName)

        If (Not (m_iRetValue = 150 Or m_iRetValue = 125)) Then
            MessageString = m_sReply
            '' Throw New IOException(m_sReply.Substring(4))
            DownloadFiles = False
        End If

        Do While (True)
            ''m_aBuffer.SetValue(m_aBuffer, 0, m_aBuffer.Length)
            m_iBytes = cSocket.Receive(m_aBuffer, m_aBuffer.Length, 0)
            output.Write(m_aBuffer, 0, m_iBytes)

            If (m_iBytes <= 0) Then
                Exit Do
            End If
        Loop

        output.Close()
        If (cSocket.Connected) Then
            cSocket.Close()
        End If

        ReadReply()

        If (Not (m_iRetValue = 226 Or m_iRetValue = 250)) Then
            MessageString = m_sReply
            DownloadFiles = False
            ''Throw New IOException(m_sReply.Substring(4))
        End If

        Return DownloadFiles

    End Function

    ''' <summary>
    ''' 本地硬盘上向FTP文件夹中上载文件的函数
    ''' </summary>
    ''' <param name="sFileName"></param>
    ''' <remarks></remarks>
    Public Function UploadFile(ByVal sFileName As String) As Boolean
        If UploadFile(sFileName, False) Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' 上传指定文件
    ''' </summary>
    ''' <param name="sFileName">文件名称</param>
    ''' <param name="bResume">是否获取文件大小</param>
    ''' <remarks></remarks>
    Private Function UploadFile(ByVal sFileName As String, ByVal bResume As Boolean) As Boolean

        UploadFile = False

        Dim cSocket As Socket
        Dim offset As Long
        Dim input As FileStream
        Dim bFileNotFound As Boolean

        ''判断FTP是否处於连线状态
        If (Not (m_bLoggedIn)) Then
            Login()
        End If

        '' 创建数据传送
        cSocket = CreateDataSocket()
        offset = 0

        '' 取得文件大小
        If (bResume) Then
            Try
                SetBinaryMode(True)
                offset = GetFileSize(sFileName)
            Catch ex As Exception ''文件大小获取失则
                offset = 0
                UploadFile = False
            End Try
        End If

        If (offset > 0) Then
            SendCommand("REST " & offset)
            If (m_iRetValue <> 350) Then
                '远程服务器可能不支持恢复。
                offset = 0
                UploadFile = False
            End If
        End If

        '发送一个FTP命令，存储一个文件。 
        SendCommand("STOR " & Path.GetFileName(sFileName))

        If (Not (m_iRetValue = 125 Or m_iRetValue = 150)) Then
            MessageString = m_sReply
            Return False
            '’ Throw New IOException(m_sReply.Substring(4))
        End If

        '检查上传文件是否存在，如果存在则上传

        bFileNotFound = False

        If (File.Exists(sFileName)) Then

            '读取文件流
            input = New FileStream(sFileName, FileMode.Open, FileAccess.Read)
            If (offset <> 0) Then
                input.Seek(offset, SeekOrigin.Begin)
            End If

            '上载这个文件
            m_iBytes = input.Read(m_aBuffer, 0, m_aBuffer.Length)
            Do While (m_iBytes > 0)
                cSocket.Send(m_aBuffer, m_iBytes, 0)
                m_iBytes = input.Read(m_aBuffer, 0, m_aBuffer.Length)
            Loop
            input.Close()
        Else
            bFileNotFound = True
        End If

        If (cSocket.Connected) Then
            cSocket.Close()
        End If

        '如果找不到文件，检查返回值
        If (bFileNotFound) Then
            MessageString = m_sReply
            Return False
            ''Throw New IOException("文件: " & sFileName & " 没有成功将文件上传到FTP站点")
        End If

        ReadReply()

        If (Not (m_iRetValue = 226 Or m_iRetValue = 250)) Then
            MessageString = m_sReply
            Return False
            ''Throw New IOException(m_sReply.Substring(4))
        End If

        Return True

    End Function

    ''' <summary>
    ''' 从远程FTP服务器上删除单个文件。
    ''' </summary>
    ''' <param name="sFileName">文件名</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DeleteFile(ByVal sFileName As String) As Boolean
        Dim bResult As Boolean

        bResult = True
        If (Not (m_bLoggedIn)) Then
            Login()
        End If
        '发送一个FTP命令，删除一个文件。
        SendCommand("DELE " & sFileName.Trim())
        If (m_iRetValue <> 250) Then
            bResult = False
            MessageString = m_sReply
        End If

        '返回最终结果
        Return bResult

    End Function

    ''' <summary>
    ''' 在远程FTP服务器上重命名一个文件
    ''' </summary>
    ''' <param name="sOldFileName">旧文件名</param>
    ''' <param name="sNewFileName">新文件名</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function RenameFile(ByVal sOldFileName As String, ByVal sNewFileName As String) As Boolean

        Dim bResult As Boolean
        bResult = True
        If (Not (m_bLoggedIn)) Then
            Login()
        End If
        '发送一个FTP命令，对一个文件重命名
        SendCommand("RNFR " & sOldFileName)
        If (m_iRetValue <> 350) Then
            MessageString = m_sReply
            Throw New IOException(m_sReply.Substring(4))
        End If

        '发送一个FTP命令，对一个文件更改为新名称
        '如果新的文件名存在，会被覆盖。
        SendCommand("RNTO " & sNewFileName)
        If (m_iRetValue <> 250) Then
            MessageString = m_sReply
            Throw New IOException(m_sReply.Substring(4))
        End If
        '返回最终结果
        Return bResult
    End Function

    ''' <summary>
    ''' 在远程服务器上创建目录的函数
    ''' </summary>
    ''' <param name="sDirName">路径</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CreateDirectory(ByVal sDirName As String) As Boolean

        Dim bResult As Boolean

        bResult = True

        If (Not (m_bLoggedIn)) Then
            Login()
        End If
        '发送一个FTP命令，在FTP服务器上制作一个目录
        SendCommand("MKD " & sDirName)
        If (m_iRetValue <> 257) Then
            bResult = False
            MessageString = m_sReply
        End If

        '返回最终结果
        Return bResult

    End Function

    ''' <summary>
    ''' 删除FTP目录文件
    ''' </summary>
    ''' <param name="sDirName">路径</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function RemoveDirectory(ByVal sDirName As String) As Boolean

        Dim bResult As Boolean
        bResult = True
        '检查是否已登录FTP服务器
        If (Not (m_bLoggedIn)) Then
            Login()
        End If
        '发送一个FTP命令，删除在FTP服务器上的目录
        SendCommand("RMD " & sDirName)
        If (m_iRetValue <> 250) Then
            bResult = False
            MessageString = m_sReply
        End If

        '返回最终结果
        Return bResult
    End Function

    ''' <summary>
    ''' 变更FTP文件路径
    ''' </summary>
    ''' <param name="sDirName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ChangeDirectory(ByVal sDirName As String) As Boolean

        Dim bResult As Boolean

        bResult = True
        '检查你是否在根目录
        If (sDirName.Equals(".")) Then
            Return bResult
        End If
        '检查是否已登录FTP服务器
        If (Not (m_bLoggedIn)) Then
            Login()
        End If
        '发送FTP命令，改变在FTP服务器上的目录。
        SendCommand("CWD " & sDirName)
        If (m_iRetValue <> 250) Then
            bResult = False
            MessageString = m_sReply
        End If

        Me.m_sRemotePath = sDirName

        '返回最终结果
        Return bResult
    End Function

    ''' <summary>
    ''' 关闭远程服务器的FTP链接
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CloseConnection()
        If (Not (m_objClientSocket Is Nothing)) Then
            '发送一个FTP命令，结束FTP服务系统。
            SendCommand("QUIT")
        End If

        Cleanup()
    End Sub

#End Region

#Region "私有函数"

    ''' <summary>
    ''' 从FTP服务器得到回应。
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ReadReply()
        Try
            m_sMes = ""
            m_sReply = ReadLine()
            m_iRetValue = Int32.Parse(m_sReply.Substring(0, 3))
        Catch
            m_iRetValue = 0
        End Try
    End Sub

    ''' <summary>
    ''' 移除一些变量
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Cleanup()
        If Not (m_objClientSocket Is Nothing) Then
            m_objClientSocket.Close()
            m_objClientSocket = Nothing
        End If

        m_bLoggedIn = False
    End Sub

    ''' <summary>
    ''' 从FTP服务器读写一行。
    ''' </summary>
    ''' <param name="bClearMes"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ReadLine(Optional ByVal bClearMes As Boolean = False) As String

        Try

            Dim seperator As Char = ControlChars.Lf
            Dim mess() As String

            If (bClearMes) Then
                m_sMes = ""
            End If

            Do While (True)
                ' m_aBuffer.SetValue(m_aBuffer, 0, BLOCK_SIZE)
                m_iBytes = m_objClientSocket.Receive(m_aBuffer, m_aBuffer.Length, 0)
                m_sMes += GB2312.GetString(m_aBuffer, 0, m_iBytes)
                If (m_iBytes < m_aBuffer.Length) Then
                    Exit Do
                End If
            Loop

            mess = m_sMes.Split(seperator)
            If (m_sMes.Length > 2) Then
                m_sMes = mess(mess.Length - 2)
            Else
                m_sMes = mess(0)
            End If

            If (Not (m_sMes.Substring(3, 1).Equals(" "))) Then
                Return ReadLine(True)
            End If

            Return m_sMes

        Catch
            Return m_sMes = ""
        End Try

    End Function

    ''' <summary>
    ''' 链接FTP服务器用於发送命令的函数
    ''' </summary>
    ''' <param name="sCommand">TCP FTP指令码</param>
    ''' <remarks></remarks>
    Private Sub SendCommand(ByVal sCommand As String)
        sCommand = sCommand & ControlChars.CrLf
        Dim cmdbytes As Byte() = GB2312.GetBytes(sCommand)
        m_objClientSocket.Send(cmdbytes, cmdbytes.Length, 0)
        ReadReply()
    End Sub

    ''' <summary>
    ''' 创建一个数据包
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CreateDataSocket() As Socket

        Dim index1, index2, len As Int32
        Dim partCount, i, port As Int32
        Dim ipData, buf, ReipAddress As String
        Dim parts(6) As Int32
        Dim ch As Char
        Dim s As Socket
        Dim ep As IPEndPoint

        '发送一个FTP命令，用於被动数据链接
        SendCommand("PASV")
        If (m_iRetValue <> 227) Then
            MessageString = m_sReply
            Throw New IOException(m_sReply.Substring(4))
        End If

        index1 = m_sReply.IndexOf("(")
        index2 = m_sReply.IndexOf(")")
        ipData = m_sReply.Substring(index1 + 1, index2 - index1 - 1)
        len = ipData.Length
        partCount = 0
        buf = ""

        For i = 0 To ((len - 1) And partCount <= 6)
            ch = Char.Parse(ipData.Substring(i, 1))
            If (Char.IsDigit(ch)) Then
                buf += ch
            ElseIf (ch <> ",") Then
                MessageString = m_sReply
                Throw New IOException("Malformed PASV reply: " & m_sReply)
            End If

            If ((ch = ",") Or (i + 1 = len)) Then
                Try
                    parts(partCount) = Int32.Parse(buf)
                    partCount += 1
                    buf = ""
                Catch ex As Exception
                    MessageString = m_sReply
                    Throw New IOException("Malformed PASV reply: " & m_sReply)
                End Try

            End If

        Next

        ''重建FTP地址
        ReipAddress = parts(0) & "." & parts(1) & "." & parts(2) & "." & parts(3)

        '想移动8位。必须将此数乘2的8次方。
        '端口=parts(4)*(2^8)

        port = parts(4) << 8
        '确定数据端口数
        port = port + parts(5)
        s = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        ep = New IPEndPoint(IPAddress.Parse(m_sRemoteHost), port)
        Try
            s.Connect(ep)
        Catch ex As Exception
            MessageString = m_sReply
            Throw New IOException("Cannot connect to remote server.")
            '如果你不能链接到特定的FTP服务器，也就是说，将.布尔值设置为false。
            flag_bool = False
        End Try

        '如果你能够链接到特定的FTP服务器，将布尔值设置为true。
        flag_bool = True
        Return s

    End Function

#End Region

#Region "查看指定FTP文件是否存在"

    ''' <summary>
    ''' 判断FTP指定文件是否存在
    ''' TRUE 表示存在，False表示不存在
    ''' </summary>
    ''' <param name="FileName">文件名</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DirectoryExist(ByVal FileName As String)

        '检查你是否登录到FTP服务器上
        If (Not (m_bLoggedIn)) Then
            Login()
        End If

        Try
            Dim strFiles As String

            strFiles = GetFileSize(FileName)

            If (strFiles.Length > 1) Then

                Return True

            Else

                Return False

            End If

        Catch

            Return False

        End Try

    End Function

#End Region

End Class
