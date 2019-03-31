
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports System.Security.Principal

Module DBHelper


    ''' <summary>
    ''' '
    ''' </summary>
    ''' <remarks></remarks>
    Public ConnStr As String = "server=192.168.10.21;database=HelpDeskDB140917;uid=sa;pwd=123456"
    '测试环
    'Public ConnStr As String = "server=(local);database=HelpDeskDB140917;uid=sa;pwd=123"

    ''' <summary>
    '''Dataset
    ''' </summary>
    ''' <param name="sql">sql字符</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DataSet(ByVal sql As String) As DataSet

        Dim ds As New DataSet
        Dim conn As SqlConnection
        Dim da As SqlDataAdapter
        conn = New SqlConnection
        conn.ConnectionString = ConnStr
        conn.Open()
        da = New SqlDataAdapter(sql, conn)
        da.Fill(ds, "table")
        da.Dispose()
        conn.Close()
        Return ds

    End Function

    ''' <summary>
    ''' 执行SQL语句返回一个datatable集合
    ''' 增加人:曹成波,时间:2013-10-21
    ''' </summary>
    ''' <param name="sql">sql执行</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getDataTables(ByVal sql As String) As DataTable
        '' 如果处理失败则返回一个空的DT集合
        Try

            Dim dt As New DataTable
            Dim conn As SqlConnection
            Dim da As SqlDataAdapter
            conn = New SqlConnection
            conn.ConnectionString = ConnStr
            conn.Open()
            da = New SqlDataAdapter(sql, conn)
            dt = New DataTable("Table")
            da.Fill(dt)
            da.Dispose()
            conn.Close()
            Return dt
        Catch
            Return Nothing
        End Try

    End Function

    ''' <summary>
    ''' 返回一个Dateset集合
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="table">指定表名</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataSet(ByVal sql As String, ByVal table As String) As DataSet

        Dim ds As New DataSet
        Dim conn As SqlConnection
        Dim da As SqlDataAdapter
        conn = New SqlConnection
        conn.ConnectionString = ConnStr
        conn.Open()
        da = New SqlDataAdapter(sql, conn)
        da.Fill(ds, table)
        da.Dispose()
        conn.Close()
        Return ds
    End Function

    ''' <summary>
    ''' 执行sql语句
    ''' 增加人：曹成波，增加日期：20131021
    ''' </summary>
    ''' <param name="cmdText">sql语句</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ExecuteNonQuery(ByVal cmdText As String) As Integer

        Dim result As Integer
        Dim cn As SqlConnection = New SqlConnection(ConnStr)
        cn.Open()
        Dim cmd = New SqlCommand(cmdText, cn)
        result = cmd.ExecuteNonQuery()
        cn.Dispose()
        Return result
    End Function

    ''' <summary>
    ''' 执行select语句，返回记录条数
    ''' </summary>
    ''' <param name="cmdTest">指令</param>
    ''' <returns>返回一个int型，0表示没有可用数据，大於0则表示返回行</returns>
    ''' <remarks></remarks>
    Public Function ExecuteScalar(ByVal cmdTest As String) As Integer

        Dim count As Integer
        Dim cn As SqlConnection = New SqlConnection(ConnStr)
        cn.Open()
        Dim cmd As SqlCommand = New SqlCommand(cmdTest, cn)
        cmd.CommandType = CommandType.Text
        count = cmd.ExecuteScalar()
        cn.Dispose()
        Return count

    End Function

End Module
