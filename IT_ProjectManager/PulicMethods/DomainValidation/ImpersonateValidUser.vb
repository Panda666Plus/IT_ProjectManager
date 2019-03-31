Imports System.IO
Imports System.DirectoryServices

Public Class mdlmain

    ''' <summary>
    ''' 取得本机域帐号
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getADLoginName() As String

        Dim UserIdentityInfo As System.Security.Principal.WindowsIdentity
        Dim strInfo As String
        UserIdentityInfo = System.Security.Principal.WindowsIdentity.GetCurrent()
        strInfo = UserIdentityInfo.Name
        '取域名後的工号
        Dim strTmp() As String = strInfo.Split(New [Char]() {"\"})
        getADLoginName = strTmp(1)

    End Function

    ''' <summary>
    '''  域账号验证
    ''' </summary>
    ''' <param name="userName">登录账号</param>
    ''' <param name="password">登录密码</param>
    ''' <returns></returns>
    ''' <remarks>返回一个Boolean值，true 表示成功，false：表示失败</remarks>
    Public Function impersonateValidUser(ByVal userName As String, ByVal password As String) As Boolean

        impersonateValidUser = False

        ' Dim strPath As String

        ' strPath = "LDAP://mega.cn/DC=mega,DC=CN"

        'Dim sql As String

        'sql = "select * from IT_PersonnelGroups"

        'Dim dt As New DataTable

        'dt = getDataTables(sql)

        'Dim strPath As String

        'strPath = dt

        Try

            Dim dirEntry As DirectoryEntry

            dirEntry = New DirectoryEntry(userName, password, AuthenticationTypes.Secure)

            impersonateValidUser = True

            'Dim CheckID As String

            'CheckID = dirEntry.Guid.ToString

        Catch

            impersonateValidUser = False

        End Try

        Return impersonateValidUser

    End Function

End Class
