Public Class AssessAndBugManage

#Region "屬性"

    ''' <summary>
    ''' 臨時名稱
    ''' </summary>
    ''' <remarks></remarks>
    Dim TempName As String = Nothing
    ''' <summary>
    ''' 臨時備註
    ''' </summary>
    ''' <remarks></remarks>
    Dim TempRemarks As String = Nothing

    '' 記錄臨時ID
    Dim TempAutoID As String = Nothing

    ''' <summary>
    ''' bug類型管理是否為編輯狀態
    ''' true 為是
    ''' false為否
    ''' </summary>
    ''' <remarks></remarks>
    Dim BugManagerEdit As Boolean = False

    ''' <summary>
    ''' 考核類型管理
    ''' true為編輯狀態
    ''' false非編輯狀態
    ''' </summary>
    ''' <remarks></remarks>
    Dim AssessEdit As Boolean = False


#End Region

#Region "載入數據"

    Private Sub frmSysSeting_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        LoadBugTypeManager()

        loadAccessData()

    End Sub

    ''' <summary>
    ''' 載入Bug類型名稱數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadBugTypeManager()

        Try
            Dim sql As String = Nothing

            sql = " select * from IT_ConfigParameters"

            Dim dt As New DataTable

            dt = getDataTables(sql)

            If dt.Rows.Count > 0 Then

                BugManager.DataSource = dt

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    ''' <summary>
    ''' 加載考核數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadAccessData()
        Try

            Dim sql As String = Nothing

            sql = "select * from IT_GradeStandard where GS_PID='0'"

            Dim dt As New DataTable

            dt = getDataTables(sql)

            If dt.Rows.Count > 0 Then
                gridAssess.DataSource = dt
            Else
                gridAssess.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' 通過委託綁定數據
    ''' </summary>
    ''' <param name="gridControl">控件</param>
    ''' <param name="dt">數據集</param>
    ''' <remarks></remarks>
    Sub BindingData(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal dt As Object)
        Try
            gridControl.DataSource = dt
            System.Threading.Thread.Sleep(100)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "管理"

    ''' <summary>
    ''' 更新數據
    ''' </summary>
    ''' <param name="edit">是否為編輯狀態</param>
    ''' <param name="id">id號，1表示項目結案評分類型，3表示考核評分類型</param>
    ''' <remarks></remarks>
    Sub EditGradeStandardData(ByVal edit As Boolean, ByVal id As Integer)

        Dim sql As String = Nothing

        If edit Then
            sql = "update IT_GradeStandard set GS_Name='" & txtName.Text.Trim() & "',GS_Remark='" & txtRemarks.Text.Trim() &
                "' where GS_ID='" & TempAutoID & "' AND GS_PID='" & id & "'"
        Else
            sql = "insert into  IT_GradeStandard values('" & id & "','" & id & "','" & txtName.Text.Trim() & "','" & txtRemarks.Text.Trim & "')"
        End If

        Try

            If ExecuteNonQuery(sql) <> 1 Then
                MessageBox.Show("數據處理失敗？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("數據處理成功？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Claerlbl()
            End If

        Catch ex As Exception
            MessageBox.Show("未知錯誤：" & vbCrLf & ex.Message, "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "系統名稱管理"

    ''' <summary>
    ''' 保存或修改數據系統名稱信息
    ''' </summary>
    ''' <remarks></remarks>
    Sub SaveInfo(ByVal Save As Boolean)

        Dim DateTimes As String
        DateTimes = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        Dim sql As String = Nothing

        If Save Then

            sql = "  insert into IT_ConfigParameters values('" & txtName.Text.Trim() & "','" & txtRemarks.Text.Trim() &
                "','" & UserName & "','" & DateTimes & "','" & DateTimes & "')"
        Else
            sql = "  update IT_ConfigParameters set xName='" & txtName.Text.Trim() & "',Remarks='" & txtRemarks.Text.Trim() &
                  "',CreateUname='" & UserName & "',ModificaDateTime='" & DateTimes & "' where AutoID='" & TempAutoID &
                  "' and xName='" & TempName & "'"

        End If

        Try
            If ExecuteNonQuery(sql) <> 1 Then
                MessageBox.Show("操作失敗？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Claerlbl()
                MessageBox.Show("操作成功？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MessageBox.Show("未知錯誤：" & vbCrLf & ex.Message, "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


#End Region

#Region "為GRIDVIEW繪製顏色"

    Private Sub GridView1_CustomDrawCell(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GridView2.CustomDrawCell, GridView3.CustomDrawCell

        CustomDrawCell(e)

    End Sub



#End Region

#Region "管理Grid雙擊"

    '' 改變處理模塊
    Private Sub xtControl_SelectedPageChanged(sender As System.Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtControl.SelectedPageChanged

        Claerlbl()

        Select Case CInt(xtControl.SelectedTabPageIndex)

            Case 0
                lblName.Text = "評分標準"

            Case 1
                lblName.Text = "Bug類型"

            Case 2
                lblName.Text = "考核類型"
        End Select

        BugManagerEdit = False
        AssessEdit = False

    End Sub

    '' 雙擊考核管理
    Private Sub gridAssess_DoubleClick(sender As System.Object, e As System.EventArgs) Handles gridAssess.DoubleClick

        Claerlbl()

        TempAutoID = GridView2.GetFocusedRowCellValue("GS_ID")
        TempName = GridView2.GetFocusedRowCellValue("GS_Name")
        TempRemarks = GridView2.GetFocusedRowCellValue("GS_Remark")

        SetText()

        BugManagerEdit = False

        AssessEdit = True


    End Sub
    ''' <summary>
    ''' 清空控件內容
    ''' </summary>
    ''' <remarks></remarks>
    Sub Claerlbl()
        txtName.Focus()
        TempName = Nothing
        TempRemarks = Nothing
        txtName.Text = ""
        txtRemarks.Text = ""
        btSave.Text = "保存"
        btClose.Text = "關閉"
        TempAutoID = Nothing
        BugManagerEdit = False
        AssessEdit = False
    End Sub

    Sub SetText()

        txtName.Text = TempName
        txtRemarks.Text = TempRemarks

        btSave.Text = "修改"
        btClose.Text = "取消"

    End Sub

    '' 修改Bug類型
    Private Sub BugManager_DoubleClick(sender As System.Object, e As System.EventArgs) Handles BugManager.DoubleClick


        Claerlbl()

        TempAutoID = GridView3.GetFocusedRowCellValue("AutoID")
        TempName = GridView3.GetFocusedRowCellValue("xName")
        TempRemarks = GridView3.GetFocusedRowCellValue("Remarks")

        SetText()

        BugManagerEdit = True

        AssessEdit = False

    End Sub

#End Region

    '' 保存數據
    Private Sub btSave_Click(sender As System.Object, e As System.EventArgs) Handles btSave.Click

        If Len(txtName.Text.Trim()) = 0 Then
            txtName.Focus()
            MessageBox.Show("請輸入內容？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Select Case CInt(xtControl.SelectedTabPageIndex)
            Case 0  '' Bug類型管理

                If BugManagerEdit Then ''修改Bug類型

                    SaveInfo(False)

                Else '' 保存Bug類型管理

                    SaveInfo(True)

                End If

                '' 刷新數據
                LoadBugTypeManager()

            Case 1 ''考核信息

                If AssessEdit Then ''修改考核類型
                    EditGradeStandardData(True, "0")
                Else '' 保存考核類型管理
                    EditGradeStandardData(False, "0")
                End If

                '' 刷新數據
                loadAccessData()

        End Select

    End Sub

    Private Sub btClose_Click(sender As System.Object, e As System.EventArgs) Handles btClose.Click

        If btClose.Text = "取消" Then
            Claerlbl()
        Else
            Me.Close()
        End If

    End Sub

#Region "刪除數據"

    '' 刪除指定資料
    Private Sub BugManager_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles BugManager.KeyDown

        If e.KeyCode = Keys.Delete Then

            Claerlbl()

            TempAutoID = GridView3.GetFocusedRowCellValue("AutoID")
            TempName = GridView3.GetFocusedRowCellValue("xName")

            If DelData(TempName, TempAutoID) Then
                GridView3.DeleteRow(GridView3.FocusedRowHandle)
            End If

        End If

    End Sub

    '' 刪除數據
    Private Sub gridAssess_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles gridAssess.KeyDown

        If e.KeyCode = Keys.Delete Then

            TempAutoID = GridView2.GetFocusedRowCellValue("GS_ID")
            TempName = GridView2.GetFocusedRowCellValue("GS_Name")

            If DelData(TempName, TempAutoID, "3") Then
                GridView2.DeleteRow(GridView2.FocusedRowHandle)
            End If

        End If

    End Sub

    ''' <summary>
    ''' 刪除指定資料
    ''' </summary>
    ''' <param name="name">名稱</param>
    ''' <param name="id">id</param>
    ''' <remarks></remarks>
    Function DelData(ByVal name As String, ByVal id As String) As Boolean

        DelData = True

        Try

            If name <> "" Or id <> "" Then

                Dim sql As String = Nothing

                sql = "delete IT_ConfigParameters where AutoID='" & id & "' and xName='" & name & "'"

                Dim result As New DialogResult

                result = MessageBox.Show("您確定需要刪除[" & name & "]數據嗎？", "項目管理系統", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If result = DialogResult.No Then Exit Function

                If ExecuteNonQuery(sql) <> 1 Then
                    MessageBox.Show("刪除失敗，存在多筆相同數據？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("刪除成功！", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

            End If

        Catch
            DelData = False
        End Try

        Return DelData

    End Function

    ''' <summary>
    ''' 刪除指定數據
    ''' </summary>
    ''' <param name="GS_Name">類型名</param>
    ''' <param name="GS_ID">類型ID</param>
    ''' <param name="AssessID"></param>
    ''' <remarks></remarks>
    Function DelData(ByVal GS_Name As String, ByVal GS_ID As Integer, ByVal AssessID As Integer) As Boolean

        DelData = True

        Try

            If GS_Name <> "" Or GS_ID <> 0 Then

                Claerlbl()
                Dim result As New DialogResult

                result = MessageBox.Show("您確定需要刪除指定數據[" & GS_Name & "]嗎？", "項目管理系統", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If result = DialogResult.No Then Exit Function

                Dim sql As String = Nothing

                sql = "delete IT_GradeStandard where GS_ID='" & GS_ID & "' and GS_PID='0' and GS_Level='0' and GS_Name='" & GS_Name & "' "


                If ExecuteNonQuery(sql) <> 1 Then
                    MessageBox.Show("刪除失敗，存在多筆相同數據？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("刪除成功！", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

            End If

        Catch ex As Exception
            DelData = False
        End Try

        Return DelData

    End Function


#End Region

End Class