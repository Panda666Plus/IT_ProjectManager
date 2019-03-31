Public Class CheckRoot


    ''' <summary>
    ''' 检查当前操作人是否有权限进行操作
    ''' </summary>
    ''' <param name="Uname">姓名</param>
    ''' <param name="Ujob">工号</param>
    ''' <param name="NodeID">节点ID</param>
    ''' <param name="FileName">文件名称</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function RootManager(ByVal Uname As String, ByVal Ujob As String, ByVal NodeID As String, ByVal FileName As String) As Boolean
        Dim sql As String = Nothing
        sql = "select * from IT_UploadFilesInfo where UploadedUserID='" & Ujob & "' AND UploadedUserNname='" & Uname & _
            "' and NodeID='" & NodeID & "' and FileNames='" & FileName & "'"
        Dim dt As New DataTable
        dt = getDataTables(sql)
        If dt.Rows.Count > 0 Then
            Return True  ''有权限
        Else
            Return False ''无权限
        End If
    End Function

    ''' <summary>
    ''' 检查当前操作人是否有权限进行操作
    ''' </summary>
    ''' <param name="Uname">姓名</param>
    ''' <param name="Ujob">工号</param>
    ''' <param name="NodeID">节点ID</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function RootManager(ByVal Uname As String, ByVal Ujob As String, ByVal NodeID As String) As Boolean
        Dim sql As String = Nothing
        sql = "select * from IT_UploadFilesInfo where UploadedUserID='" & Ujob & "' AND UploadedUserNname='" & Uname & _
            "' and NodeID='" & NodeID & "'"
        Dim dt As New DataTable
        dt = getDataTables(sql)
        If dt.Rows.Count > 0 Then
            Return True  ''有权限
        Else
            Return False ''无权限
        End If
    End Function

End Class
