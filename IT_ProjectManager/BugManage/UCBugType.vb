Public Class UCBugType
    Dim td1 As Threading.Thread = Nothing

    Private Sub UCBugList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        td1 = New Threading.Thread(AddressOf LoadAllBugItems)
        td1.Start()
        Threading.Thread.Sleep(100)

        DateEdit2.EditValue = Date.Now

        AddHandler LEsystemName.EditValueChanged, AddressOf EditValueChanged
        AddHandler DateEdit2.EditValueChanged, AddressOf BugView

    End Sub

    Sub EditValueChanged()
        AddDate()
    End Sub

    Sub BugView()
        If DateEdit2.EditValue <> Nothing Then
            loadBugView(DateEdit2.EditValue)
        End If
    End Sub
    ''' <summary>
    ''' 取得所有系统名称
    ''' 方便走线图管理
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadAllBugItems()

        Try
            Dim sql As String = Nothing

            sql = "select distinct SySProName,SysProID FROM IT_DevelopBugManager"

            Dim dt As New DataTable

            dt = getDataTables(sql)

            SetLockUpEdit = New SetLockUpEditDelegate(AddressOf bindingLookUpEdit)

            Me.Invoke(SetLockUpEdit, LEsystemName, dt)

            dt.Dispose()

        Catch ex As Exception
            'MessageBox.Show("线程引发以下异常：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'td1.Join()
            td1.Abort()
        End Try

    End Sub
    ''' <summary>
    ''' 显示指定月的Bug统计
    ''' </summary>
    ''' <param name="dt"></param>
    ''' <remarks></remarks>
    Sub loadBugView(ByVal dt As String)

        Dim StrSB As New System.Text.StringBuilder()
        StrSB.Append("select distinct  ")
        StrSB.Append(" (select  count(IT_DevelopBugManager.AutoID) FROM IT_DevelopBugManager  where(IT_SystemNameManager.SystemName = IT_DevelopBugManager.SysProName) ")
        StrSB.Append(" and (month(IT_DevelopBugManager.CreateTime)=month('" & CDate(dt).ToString("yyyy-MM-dd") & "'))) as TotalMonthsError,")
        StrSB.Append(" IT_SystemNameManager.SystemName from IT_SystemNameManager, IT_DevelopBugManager ")

        Dim d As New DataTable
        d = getDataTables(StrSB.ToString())
        If d.Rows.Count > 0 Then
            ChartControl2.DataSource = d
        Else
            ChartControl2.DataSource = Nothing
        End If
        d.Dispose()
    End Sub

    ''' <summary>
    ''' 利用委托传参
    ''' </summary>
    ''' <param name="LookUpEdit"></param>
    ''' <param name="dt"></param>
    ''' <remarks></remarks>
    Sub bindingLookUpEdit(ByVal LookUpEdit As DevExpress.XtraEditors.LookUpEdit, ByVal dt As DataTable)
        Try
            If dt.Rows.Count > 0 Then
                LookUpEdit.Properties.DataSource = dt
            Else
                LookUpEdit.Properties.DataSource = Nothing
            End If
            dt.Dispose()
        Catch ex As Exception
            MessageBox.Show("委托引发以下异常：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "走路图数据绑定"

    ''' <summary>
    ''' 加载路线图数据
    ''' </summary>
    ''' <remarks></remarks>
    Sub AddDate()

        Try
            ChartControl1.ClearCache()
            dst.Clear()

            Dim ProjectId As String
            ProjectId = LEsystemName.EditValue
            If ProjectId = "" Or ProjectId = Nothing Then Exit Sub


            Dim getStartDT As String
            getStartDT = "select distinct CreateTime FROM IT_DevelopBugManager where SysProID='" & ProjectId & "'"
            Dim dt As New DataTable
            dt = getDataTables(getStartDT)
            If dt.Rows.Count <= 0 Then Exit Sub
            Dim benginDate As Date
            benginDate = CDate(dt.Rows(0)(0))

            Dim tempDate As String
            'benginDate = CDate("2013-8-24")
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
                            'If Weekday(CDate(tempDate)) = 1 Then
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

            Next

        Catch ex As Exception
            MessageBox.Show("未知错误：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try

    End Sub

    ''' <summary>
    '''  导入所有任务
    ''' </summary>
    ''' <param name="dteDate">查询日期</param>
    ''' <param name="id">系统名称ID</param>
    Sub LoadDemandFull(ByVal dteDate As String, ByVal id As String)

        Dim lngCount As Long

        Dim dt As New DataTable

        Dim strSB As New System.Text.StringBuilder

        strSB.Append("select count(AutoID) as Demand,")
        strSB.Append("(select count(AutoID)as Value from IT_DevelopBugManager where (SysProID='" & id & "' and convert(varchar(100),CreateTime,23) <= '" & dteDate & "') and CurrentStatus='待指派') as beAssigned ,  ")
        strSB.Append("(select count(AutoID)as Value from IT_DevelopBugManager where (SysProID='" & id & "' and convert(varchar(100),CreateTime,23) <= '" & dteDate & "' ) and CurrentStatus='待回覆') as SubjectReply,")
        strSB.Append("(select count(AutoID)as Value from IT_DevelopBugManager where (SysProID='" & id & "' and convert(varchar(100),ReplyDatetime,23) >= '" & dteDate & "'and convert(varchar(100),ReplyDatetime,23) <= '" & dteDate & "' ) and CurrentStatus='待验收') as beClosed,")
        strSB.Append("(select count(AutoID)as Value from IT_DevelopBugManager where (SysProID='" & id & "' and convert(varchar(100),ConfigDatetime,23) >= '" & dteDate & "'and convert(varchar(100),ConfigDatetime,23) <= '" & dteDate & "') and CurrentStatus='已验收') as Closed ")
        strSB.Append(" from IT_DevelopBugManager where  convert(varchar(100),CreateTime,23) <=  '" & dteDate & "' and SysProID='" & id & "' ")

        dt = getDataTables(strSB.ToString())

        strSB.Clear()

        lngCount = dt.Rows.Count

        If lngCount > 0 Then

            Dim rs = dst.Tables("Demand").NewRow
            rs("CreatedDate") = CDate(dteDate)
            rs("Value") = CLng(dt.Rows(0).Item("Demand").ToString)
            dst.Tables("Demand").Rows.Add(rs)

            Dim rs1 = dst.Tables("beAssigned").NewRow
            rs1("CreatedDate") = CDate(dteDate)
            rs1("Value") = CLng(dt.Rows(0).Item("beAssigned").ToString)
            dst.Tables("beAssigned").Rows.Add(rs1)


            Dim rs2 = dst.Tables("SubjectReply").NewRow
            rs2("CreatedDate") = CDate(dteDate)
            rs2("Value") = CLng(dt.Rows(0).Item("SubjectReply").ToString)
            dst.Tables("SubjectReply").Rows.Add(rs2)

            Dim rs3 = dst.Tables("beClosed").NewRow
            rs3("CreatedDate") = CDate(dteDate)
            rs3("Value") = CLng(dt.Rows(0).Item("beClosed").ToString)
            dst.Tables("beClosed").Rows.Add(rs3)

            Dim rs4 = dst.Tables("Closed").NewRow
            rs4("CreatedDate") = CDate(dteDate)
            rs4("Value") = CLng(dt.Rows(0).Item("Closed").ToString)
            dst.Tables("Closed").Rows.Add(rs4)

        End If

    End Sub

#End Region

End Class
