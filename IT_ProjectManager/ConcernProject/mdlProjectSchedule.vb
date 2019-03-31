Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.ListViewItem

Public Class mdlProjectSchedule

#Region "导入项目数据"

    Sub AddDate()

        Try

            Dim benginDate As Date
            benginDate = CDate(txtDate.Text)

            Dim ProjectId As String
            ProjectId = txtID.Text

            Dim tempDate As String
            Dim strType As String = Nothing
            Dim intDateNum
            Dim i As Long

            '为减少显示的天数
            i = DateDiff("d", benginDate, Now)
            Select Case i
                Case Is <= 30 '天
                    strType = "day"
                    txtType.Text = "日视图"
                Case 31 To 180  '周'
                    strType = "week"
                    txtType.Text = "周视图"
                Case Is > 181   '月'
                    strType = "month"
                    txtType.Text = "月视图"
            End Select

            intDateNum = DateDiff("d", benginDate, Now)

            For loopi = 0 To intDateNum

                tempDate = Format(DateAdd("d", loopi, benginDate), "yyyy-MM-dd")

                Select Case strType

                    Case "day"

                    Case "week"

                        If CDate(tempDate).DayOfWeek <> 1 Then

                            If loopi = intDateNum Then

                                If CDate(Now).DayOfWeek > 1 Then

                                Else
                                    Continue For
                                End If

                            Else
                                Continue For
                            End If

                        End If

                    Case "month"

                        If CDate(tempDate).Day <> 1 Then

                            If loopi = intDateNum Then

                                If CDate(Now).Day > 1 Then

                                Else
                                    Continue For
                                End If

                            Else
                                Continue For
                            End If

                        End If

                End Select

                LoadDemandFull(tempDate, ProjectId)

                Threading.Thread.Sleep(10)

            Next

        Catch ex As Exception
            MessageBox.Show("未知错误：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ''' <summary>
    ''' 导入所有任务
    ''' </summary>
    ''' <param name="dteDate"></param>
    ''' <param name="PrjID"></param>
    ''' <remarks></remarks>
    Sub LoadDemandFull(ByVal dteDate As String, ByVal PrjID As String)

        Dim dt As New DataTable

        Dim strSB As New System.Text.StringBuilder

        Try

            strSB.Append("select count(ID)as Demand,")
            strSB.Append("(select count(ID)as Value from V_IT_Assignment_Demand where SchemeID='" & PrjID & "' and convert(varchar(100),AchualEndDate,23) <= '" & dteDate & "' ) as Complete,")
            strSB.Append("(select count(ID)as Value from V_IT_Assignment_Demand where (SchemeID='" & PrjID & "'  and convert(varchar(100),AchualEndDate,23) > '" & dteDate & "'  and ")
            strSB.Append(" convert(varchar(100),CreatedTime,23)<= '" & dteDate & "')  or ( AchualEndDate is null  and  SchemeID='" & PrjID & "' and convert(varchar(100),CreatedTime,23)<= '" & dteDate & "')) as Unfinished")
            strSB.Append(" from V_IT_Assignment_Demand where SchemeID='" & PrjID & "' and convert(varchar(100),CreatedTime,23) <=  '" & dteDate & "'")

            dt = getDataTables(strSB.ToString())
            strSB.Clear()
            If dt.Rows.Count > 0 Then

                Dim rs = dst.Tables("Demand").NewRow
                rs("CreatedDate") = CDate(dteDate)
                rs("Value") = CLng(dt.Rows(0).Item("Demand").ToString)
                dst.Tables("Demand").Rows.Add(rs)

                Dim rs1 = dst.Tables("Complete").NewRow
                rs1("CreatedDate") = CDate(dteDate)
                rs1("Value") = CLng(dt.Rows(0).Item("Complete").ToString)
                dst.Tables("Complete").Rows.Add(rs1)

                Dim rs2 = dst.Tables("Unfinished").NewRow
                rs2("CreatedDate") = CDate(dteDate)
                rs2("Value") = CLng(dt.Rows(0).Item("Unfinished").ToString)
                dst.Tables("Unfinished").Rows.Add(rs2)

            End If

        Catch ex As Exception
            MessageBox.Show("操作收发异常:" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub


#End Region

    Private Sub mdlProjectSchedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Application.DoEvents()

        Me.Show()

        AddDate()
    End Sub
End Class
