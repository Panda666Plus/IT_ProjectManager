Imports System.Data
Imports System.Data.SqlClient

Public Class mdlPerDimensionality


    ''' <summary>
    ''' 导入评分
    ''' </summary>
    ''' <param name="strUserNo"></param>
    ''' <remarks></remarks>
    Sub LoadGrade(ByVal strUserNo As String)
        '
        Dim lngCount As Long
        Dim dt As New DataTable
        Dim strSB As New System.Text.StringBuilder
        '显示详细打分项目
        strSB.Append("SELECT IT_GradeStandard.GS_Name,sum(IT_GradeValue.GV_Value) as GV_Value FROM IT_GradeStandard INNER JOIN ")
        strSB.Append("IT_GradeValue ON IT_GradeStandard.GS_ID = IT_GradeValue.GS_ID ")
        strSB.Append("WHERE IT_GradeValue.GS_UserNo='" & strUserNo & "' group by IT_GradeStandard.GS_Name")

        dt = getDataTables(strSB.ToString())

        lngCount = dt.Rows.Count

        If lngCount > 0 Then

            dst.Tables("GS").Clear()

            For i As Integer = 0 To lngCount - 1
                Dim rs = dst.Tables("GS").NewRow
                rs("Name") = dt.Rows(i).Item("GS_Name").ToString
                rs("Value") = CLng(dt.Rows(i).Item("GV_Value").ToString)
                dst.Tables("GS").Rows.Add(rs)
            Next

        End If

        dt.Dispose()
        strSB.Clear()

    End Sub

    Private Sub mdlPerDimensionality_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadGrade(UserID)
    End Sub
End Class
