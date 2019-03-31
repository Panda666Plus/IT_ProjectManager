Public Class mdlTestProblems

    Dim modelID As Integer

    Dim td As Threading.Thread = Nothing

    Dim td1 As Threading.Thread = Nothing

    Dim td2 As Threading.Thread = Nothing

    Private Sub mdlTestProblems_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        td = New Threading.Thread(AddressOf LoadDataBugRate)
        td.Start()
        Threading.Thread.Sleep(100)

        td1 = New Threading.Thread(AddressOf LoadAllBugItems)
        td1.Start()
        Threading.Thread.Sleep(100)

        td2 = New Threading.Thread(AddressOf loadItem)
        td2.Start()
        Threading.Thread.Sleep(100)

        '' 如果是管理員則顯示指派頁面，反之隱藏。
        If IsProjectManager Or IsLeader Then
            SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
        Else
            SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        End If

    End Sub

#Region "載入所有綁定數據"

    ''' <summary>
    ''' 載入Bug率
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadDataBugRate()

        Try

            Dim dt As New DataTable

            Dim dt1 As New DataTable

            dt = bindingSelectData("待指派")

            dt1 = bindingSelectData("已驗收")

            SetGridData = New SetGridViewDelegate(AddressOf bindingData)

            Me.Invoke(SetGridData, GdConductItems, dt)

            SetGridData = New SetGridViewDelegate(AddressOf bindingData)

            Me.Invoke(SetGridData, CompletedBugManager, dt1)

            dt.Dispose()

            dt1.Dispose()

        Catch ex As Exception
            'MessageBox.Show("線程引發以下異常：" & vbCrLf & ex.Message, "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'td.Join()
            td.Abort()
        End Try

    End Sub

    ''' <summary>
    ''' 取得所有系統名稱
    ''' 方便走線圖管理
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
            MessageBox.Show("線程引發以下異常：" & vbCrLf & ex.Message, "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'td1.Join()
            td1.Abort()
        End Try

    End Sub

    ''' <summary>
    ''' 加載所有進行中項目
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadItem()

        Try
            Dim sql As String = "select IT_SystemNameManager.SystemName,IT_SystemNameManager.SystemID,IT_DevelopBugManager.*  " &
                    " from IT_SystemNameManager, IT_DevelopBugManager " &
                    " where IT_DevelopBugManager.SysProID = IT_SystemNameManager.SystemID " &
                    " and IT_DevelopBugManager.CurrentStatus<>'待指派' and " &
                    " IT_DevelopBugManager.CurrentStatus<>'已驗收'"

            Dim dt As New DataTable

            dt = getDataTables(sql)

            SetGridData = New SetGridViewDelegate(AddressOf bindingData)

            Me.Invoke(SetGridData, GridControl1, dt)

            dt.Dispose()

        Catch ex As Exception
            'MessageBox.Show("線程引發以下異常：" & vbCrLf & ex.Message, "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'td2.Join()
            td2.Abort()
        End Try

    End Sub


    ''' <summary>
    ''' 載入主數據
    ''' </summary>
    ''' <remarks></remarks>
    Function bindingSelectData(ByVal CurrentStatus As String) As DataTable


        Dim tempsql As String = "  select IT_SystemNameManager.SystemName,IT_SystemNameManager.SystemID,IT_DevelopBugManager.*   " &
       " from IT_SystemNameManager, IT_DevelopBugManager " &
       " where IT_DevelopBugManager.SysProID = IT_SystemNameManager.SystemID " &
       " and CurrentStatus='" & CurrentStatus & "'"

        Return getDataTables(tempsql)

    End Function

#End Region

    '' 導出excel
    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click

        If GridView2.RowCount < 1 Then Exit Sub

        Dim save As New SaveFileDialog
        save.Filter = "Excel File(*.xlsx)|*.xlsx"
        save.FileName = "Bug管理"

        If save.ShowDialog = DialogResult.OK Then
            GridView2.ExportToXlsx(save.FileName)
            MessageBox.Show("導出數據成功！", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If

    End Sub

    '' 增加反饋數據
    Private Sub TestProAdd_Click(sender As System.Object, e As System.EventArgs) Handles TestProAdd.Click

        isRefresh = False
        Dim xx As New BugEntry
        xx.Text = "Bug管理[數據錄入模式]"
        xx.ShowDialog()

        '' 決定是否刷新數據
        If Not isRefresh Then Exit Sub

        td = New Threading.Thread(AddressOf LoadDataBugRate)
        td.Start()
        Threading.Thread.Sleep(100)

    End Sub

    '' 修改指定項目
    Private Sub GdSubjectDesignate_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GdConductItems.DoubleClick

        If GridView1.RowCount = 0 Or Len(GridView1.GetFocusedRowCellValue("AutoID")) = 0 Then Exit Sub

        isRefresh = False

        Dim AutoID As String = GridView1.GetFocusedRowCellValue("AutoID")
        Dim ProjectID As String = GridView1.GetFocusedRowCellValue("SysProID")

        If AutoID = "" Or ProjectID = "" Then Exit Sub

        Dim xx As New BugEntry
        xx.TestEdit = True
        xx.CurrentStatus = "待指派"
        xx.isDesignate = True
        xx.AutoID = AutoID
        xx.ProjectID = ProjectID
        xx.ToolTip.Text = "雙擊預覽附件"
        xx.Text = "Bug管理[任務指派]"
        xx.ShowDialog()

        '' 決定是否需要刷新數據
        If Not isRefresh Then Exit Sub

        td2 = New Threading.Thread(AddressOf LoadDataBugRate)
        td2.Start()
        Threading.Thread.Sleep(100)

        td1 = New Threading.Thread(AddressOf loadItem)
        td1.Start()

    End Sub


#Region "走路圖數據綁定"

    ''' <summary>
    ''' 加載路線圖數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub AddDate()

        Try

            ChartControl1.ClearCache()

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
            '為減少顯示的天數
            i = DateDiff("d", benginDate, Now)
            Select Case i
                Case Is <= 30 '天
                    strType = "day"
                    txtType.Text = "日視圖"
                Case 31 To 180  '周'
                    strType = "week"
                    txtType.Text = "周視圖"
                Case Is > 181   '月'
                    strType = "month"
                    txtType.Text = "月視圖"
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
            MessageBox.Show("未知錯誤：" & vbCrLf & ex.Message, "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try

    End Sub

    ''' <summary>
    '''  導入所有任務
    ''' </summary>
    ''' <param name="dteDate">查詢日期</param>
    ''' <param name="id">系統名稱ID</param>
    Sub LoadDemandFull(ByVal dteDate As String, ByVal id As String)

        Dim lngCount As Long

        Dim dt As New DataTable

        Dim sql As String = Nothing

        sql = "select count(AutoID) as Demand," &
                "(select count(AutoID)as Value from IT_DevelopBugManager where (SysProID='" & id & "' and convert(varchar(100),CreateTime,23) <= '" & dteDate & "') and CurrentStatus='待指派') as beAssigned ,  " &
                "(select count(AutoID)as Value from IT_DevelopBugManager where (SysProID='" & id & "' and convert(varchar(100),CreateTime,23) <= '" & dteDate & "' ) and CurrentStatus='待回覆') as SubjectReply," &
                "(select count(AutoID)as Value from IT_DevelopBugManager where (SysProID='" & id & "' and convert(varchar(100),ReplyDatetime,23) >= '" & dteDate & "'and convert(varchar(100),ReplyDatetime,23) <= '" & dteDate & "' ) and CurrentStatus='待驗收') as beClosed," &
                "(select count(AutoID)as Value from IT_DevelopBugManager where (SysProID='" & id & "' and convert(varchar(100),ConfigDatetime,23) >= '" & dteDate & "'and convert(varchar(100),ConfigDatetime,23) <= '" & dteDate & "') and CurrentStatus='已驗收') as Closed " &
                " from IT_DevelopBugManager where  convert(varchar(100),CreateTime,23) <=  '" & dteDate & "' and SysProID='" & id & "' "

        dt = getDataTables(sql)

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

    '' 顯示走線圖
    Private Sub sysName_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles LEsystemName.EditValueChanged
        AddDate()
    End Sub

#End Region

#Region "grid數據管理"


#Region "展開節點"
    '' 展開節點
    Private Sub GridView1_EndGrouping(sender As System.Object, e As System.EventArgs) Handles GridView1.EndGrouping
        GridView1.ExpandAllGroups()
    End Sub
    '' 展開節點
    Private Sub GridView2_EndGrouping(sender As System.Object, e As System.EventArgs) Handles GridView2.EndGrouping
        GridView2.ExpandAllGroups()
    End Sub
    '' 展開節點
    Private Sub GridView3_EndGrouping(sender As System.Object, e As System.EventArgs) Handles GridView3.EndGrouping
        GridView3.ExpandAllGroups()
    End Sub

#End Region

    '' 顯示待回覆數據
    Private Sub CESubjectReply_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CESubjectReply.CheckedChanged
        If CESubjectReply.Checked Then
            GridControl1.DataSource = bindingSelectData("待回覆")
        End If
    End Sub
    '' 顯示待驗收數據
    Private Sub CEbeClosed_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CEbeClosed.CheckedChanged
        If CEbeClosed.Checked Then
            GridControl1.DataSource = bindingSelectData("待驗收")
        End If
    End Sub

    '' 顯示任務進度狀態
    Private Sub GridControl1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GridControl1.DoubleClick

        If GridView3.RowCount = 0 Or Len(GridView3.GetFocusedRowCellValue("AutoID")) = 0 Then Exit Sub

        isRefresh = False

        Dim xx As New BugFixProgress
        xx.autoID = GridView3.GetFocusedRowCellValue("AutoID")
        xx.sysID = GridView3.GetFocusedRowCellValue("SysProID")
        xx.Text = "Bug管理[狀態預覽]"
        xx.ShowDialog()

        If Not isRefresh Then Exit Sub

        td2 = New Threading.Thread(AddressOf loadItem)
        td2.Start()
        Threading.Thread.Sleep(100)

    End Sub

#End Region

    '' 查看詳細
    Private Sub CompletedBugManager_DoubleClick(sender As System.Object, e As System.EventArgs) Handles CompletedBugManager.DoubleClick

        If GridView2.RowCount = 0 Or Len(GridView2.GetFocusedRowCellValue("AutoID")) = 0 Then Exit Sub

        Dim xx As New BugFixProgress
        xx.autoID = GridView2.GetFocusedRowCellValue("AutoID")
        xx.sysID = GridView2.GetFocusedRowCellValue("SysProID")
        xx.btBugDesignate.Visible = False
        xx.btBugEntry.Visible = False
        xx.btResults.Visible = False
        xx.Text = "Bug管理[狀態預覽]"
        xx.ShowDialog()

    End Sub

#Region "委託"
    ''' <summary>
    ''' 利用委托傳參
    ''' </summary>
    ''' <param name="GridControl"></param>
    ''' <param name="dt"></param>
    ''' <remarks></remarks>
    Sub bindingData(ByVal GridControl As DevExpress.XtraGrid.GridControl, ByVal dt As DataTable)
        Try

            If dt.Rows.Count > 0 Then
                GridControl.DataSource = dt
            Else
                GridControl.DataSource = Nothing
            End If

            dt.Dispose()

        Catch ex As Exception
            MessageBox.Show("委託引發以下異常：" & vbCrLf & ex.Message, "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' 利用委託傳參
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
            MessageBox.Show("委託引發以下異常：" & vbCrLf & ex.Message, "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "bug率管理"

    ''' <summary>
    ''' 加載Bug率
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadData()

        Dim sql As String = Nothing

        Dim dt As String = Format(DateEdit1.EditValue, "yyyy-MM-dd")

        sql = "select distinct  " &
            " (select  count(IT_DevelopBugManager.AutoID) FROM IT_DevelopBugManager " &
            " where  IT_SystemNameManager.SystemName =IT_DevelopBugManager.SysProName ) as TotalError, " &
            " (select  count(IT_DevelopBugManager.AutoID) FROM IT_DevelopBugManager " &
            "  where(IT_SystemNameManager.SystemName = IT_DevelopBugManager.SysProName) " &
            " and (month(IT_DevelopBugManager.CreateTime)=month('" & dt & "'))) as TotalMonthsError," &
            " datediff(month,StartDate,'" & dt & "') as TotalMonths, " &
            " IT_SystemNameManager.*  from IT_SystemNameManager, IT_DevelopBugManager "

        Dim dataTable As New DataTable

        dataTable = getDataTables(sql)

        If dataTable.Rows.Count > 0 Then

            SysList.DataSource = dataTable

        Else
            SysList.DataSource = Nothing

        End If

    End Sub

    '' 繪製行顏色
    Private Sub GridView1_CustomDrawCell(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GridView1.CustomDrawCell, GridView4.CustomDrawCell
        CustomDrawCell(e)
    End Sub
    '' 查詢
    Private Sub DateEdit1_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles DateEdit1.EditValueChanged
        If DateEdit1.EditValue <> Nothing Then
            loadData()
        End If
    End Sub

    ''導出Excel
    Private Sub ToExcel_Click(sender As System.Object, e As System.EventArgs) Handles ToExcel.Click

        If GridView1.RowCount <= 0 Then Exit Sub

        Dim save As New SaveFileDialog
        save.Filter = "Excel 2007(*.xlsx)|*.xlsx"
        save.Title = "系統清單導出"
        save.FileName = CDate(DateEdit1.EditValue).Date.ToString("yyyyMMdd") & "份系統清單明細.xlsx"
        If save.ShowDialog = DialogResult.OK Then
            GridView1.ExportToXlsx(save.FileName)
            MessageBox.Show("導出成功！", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            StartApp(save.FileName)
        End If
    End Sub

#End Region

    Private Sub Editbug_Click(sender As System.Object, e As System.EventArgs) Handles Editbug.Click

        If GridView1.RowCount = 0 Or Len(GridView1.GetFocusedRowCellValue("AutoID")) = 0 Then Exit Sub
        isRefresh = False
        Dim xx As New BugEntry
        xx.TestEdit = True
        xx.btContinueAdd.Visible = False
        xx.btSave.Text = "修改"
        xx.AutoID = GridView1.GetFocusedRowCellValue("AutoID")
        xx.ProjectID = GridView1.GetFocusedRowCellValue("SysProID")
        xx.CurrentStatus = "待指派"
        xx.Text = "Bug管理[數據修改]"
        xx.ShowDialog()

        '' 決定是否需要刷新數據
        If Not isRefresh Then Exit Sub

        td2 = New Threading.Thread(AddressOf LoadDataBugRate)
        td2.Start()
        Threading.Thread.Sleep(100)

    End Sub

End Class
