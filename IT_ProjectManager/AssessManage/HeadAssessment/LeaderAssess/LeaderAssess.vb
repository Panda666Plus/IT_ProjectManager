Public Class LeaderAssess
    Public autoid As Integer
    Public uid As String
    Public YearMonth As String
    Public ASSpost As String

    '' 关闭
    Private Sub tb_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Close.Click
        Me.Close()
    End Sub

    Private Sub tb_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_ok.Click
        SaveDataGradeValueFull()
    End Sub

#Region "考评管理 "
    ''' <summary>
    ''' 清空控件
    ''' </summary>
    ''' <remarks></remarks>
    Sub clearControl()
        If LeaderCommentAssess.Controls.Count > 0 Then
            DeleteRatingStar(LeaderCommentAssess, LabelControl1)
        End If
    End Sub
    ''' <summary>
    ''' 导入评分标准
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadGradeStandard()

        Dim lngCount As Long
        Dim dt As New DataTable
        Dim strSB As New System.Text.StringBuilder
        strSB.Append(" select *  from IT_AssessStandard where ")
        strSB.Append(" ASS_PID=(select ASS_ID from IT_AssessStandard where Ass_Name='" & ASSpost & "'")
        strSB.Append(" and ASS_PID='0' and ASS_Level='0')")

        If IsLeader Then
            strSB.Append(" and xtype='0'")
        ElseIf IsProjectManager Then
            strSB.Append(" and xtype='1'")
        End If

        dt = getDataTables(strSB.ToString())

        lngCount = dt.Rows.Count

        If lngCount > 0 Then

            For i As Integer = 0 To lngCount - 1
                '' 生成评分控件
                CreateRatingStar(dt.Rows(i).Item("ASS_ID").ToString, dt.Rows(i).Item("ASS_Name").ToString, dt.Rows(i).Item("ASS_Remark").ToString, 0, LeaderCommentAssess, LabelControl1)
            Next

        End If

        dt.Dispose()

    End Sub
    ''' <summary>
    ''' 保存所有评分数据
    ''' </summary>
    ''' <remarks></remarks>
    Sub SaveDataGradeValueFull()

        Dim strSB As New System.Text.StringBuilder
        Dim ASSID As String = Nothing
        strSB.Clear()

        '计算评分
        If Not SumGrade() Then
            MessageBox.Show("计算评分失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        '' 事务开头标识
        strSB.Append("Set   Xact_abort  on  begin tran ")

        strSB.Append("update IT_PerformanceManage set ")

        If IsLeader Then ''项目组长
            strSB.Append(" LeaderComment='" & AssessMemoEdit.Text.Trim() & "'")
        ElseIf IsProjectManager Then  '' 项目经理
            strSB.Append(" ProManagerComment='" & AssessMemoEdit.Text.Trim() & "'")
        End If

        strSB.Append(" where AutoID='" & autoid & "' and UserNo='" & uid & "' and YearMonth='" & YearMonth & "'")

        '' 保存数据
        Dim ctrl As Control

        For Each ctrl In Me.LeaderCommentAssess.Controls

            If TypeOf (ctrl) Is RatingStar Then

                Dim xx As RatingStar = ctrl

                If xx.intValue > 0 Then

                    If IsLeader Then ''项目组长
                        '' 删除之前旧数据
                        strSB.Append("delete IT_PeromanceGradeValue where  GS_UserNo='" & uid & "' and YearMonth='" & YearMonth & "' and ASS_ID='" & autoid & "' and GS_ID='" & xx.labID.Text & "'")
                        strSB.Append(" insert into IT_PeromanceGradeValue(GS_UserNo,YearMonth,ASS_ID,GS_ID,LeaderGradeValue) ")
                        strSB.Append("values ('" & uid & "','" & YearMonth & "','" & autoid & "','" & xx.labID.Text & "','" & xx.intValue & "')")

                    ElseIf IsProjectManager Then  '' 项目经理
                        strSB.Append(" update IT_PeromanceGradeValue set ProManagerValue='" & xx.intValue & "' ")
                        strSB.Append("where GS_UserNo='" & uid & "' and YearMonth='" & YearMonth & "' and ASS_ID='" & autoid & "' and GS_ID='" & xx.labID.Text & "'")
                    End If

                End If

            End If
        Next

        ''事务结束标识
        strSB.Append(" commit tran ")

        Try
            If ExecuteNonQuery(strSB.ToString()) > 0 Then
                MessageBox.Show("操作成功!", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                isRefresh = True
                clearControl()
                isRefresh = True
                Me.Close()
            Else
                MessageBox.Show("操作失败,未影响其他数据？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            result = False
        End Try

    End Sub


    ''' <summary>
    ''' 计算评分
    ''' 返回一个bool值
    ''' true表示成功
    ''' false表示失败
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function SumGrade() As Boolean

        result = True
        Dim ctrl As Control
        LabelControl9.Text = 0

        For Each ctrl In Me.LeaderCommentAssess.Controls

            Try
                If TypeOf (ctrl) Is RatingStar Then
                    Dim xx As RatingStar = ctrl
                    LabelControl9.Text = CLng(LabelControl9.Text) + CLng(xx.intValue)
                End If
            Catch ex As Exception
                ' MessageBox.Show(ex.Message, "请注意", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                result = False
            End Try

        Next

        cboAssGrade.EditValue = CStr(Math.Round((CLng(LabelControl9.Text) / (Me.LeaderCommentAssess.Controls.Count * 5)) * 5, 0))

        Return result

    End Function

#End Region

    Private Sub LeaderAssess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clearControl()
        LoadGradeStandard()
    End Sub
End Class