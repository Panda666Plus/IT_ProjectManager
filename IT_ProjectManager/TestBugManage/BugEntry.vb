Imports System.IO
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes

Public Class BugEntry

    ''' <summary>
    ''' AutoID唯一 
    ''' </summary>
    ''' <remarks></remarks>
    Public AutoID As Integer



    ''' <summary>
    ''' 是否處理修改狀態
    ''' true表示編輯狀態
    ''' false表示非編輯狀態
    ''' </summary>
    ''' <remarks></remarks>
    Public TestEdit As Boolean = False

    ''' <summary>
    ''' 是否處理預覽狀態
    ''' true表示為預覽模式
    ''' false表示非預覽模式
    ''' </summary>
    ''' <remarks></remarks>
    Public isView As Boolean = False

    ''' <summary>
    ''' 是否为指派状态
    ''' true:表示为指派状态
    ''' false:表示为非指派状态
    ''' </summary>
    ''' <remarks></remarks>
    Public isDesignate As Boolean = False

    ''' <summary>
    ''' 系統項目ID
    ''' </summary>
    ''' <remarks></remarks>
    Public ProjectID As String = Nothing

    Dim ProjectNaem As String = Nothing

    Public CurrentStatus As String = "待回覆"

#Region "附件上傳  ， 保存  修改數據"

    '' 只允許輸入數字
    Private Sub txtTestNum_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTestNum.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            'MessageBox.Show("非有效數值，請重新輸入?", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub BEUpFile_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles BEUpFile.ButtonClick
        Dim openFile As New OpenFileDialog

        openFile.Title = "測試異常問題附件上傳"

        openFile.Filter = "Office Documents(*.docx, *.xlsx, *.pptx, *.vsd, *.accdb)|*.docx;*.xlsx;*.pptx;*..vsd;*.accdb|" & _
            "PDF Files(*.pdf)|*.pdf|txt Files(*.txt)|*.txt|壓縮文件(*.zip, *.7z, *.rar, *.RAR5)|*.zip;*.7z;*.rar;*.RAR5|" &
            "Pic File (*.jpg, *.jpeg, *.gif, *.png, *.bmp)|*.jpg;*.jpeg;*.gi; *.png;*.bmp"

        openFile.Multiselect = True

        If openFile.ShowDialog() = DialogResult.OK Then

            '' 如果不為空則指行下一步操作
            If openFile.FileNames IsNot Nothing Then

                Dim filename As String

                For Each filename In openFile.FileNames

                    For i As Integer = 0 To LBCuploadList.Items.Count - 1 Step 1
                        If filename = LBCuploadList.Items(i).ToString().Trim() Then
                            MessageBox.Show("文件【" & Path.GetFileName(filename) & "】已經存在", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If
                    Next

                    LBCuploadList.Items.Add(filename)

                Next

            End If

        End If
    End Sub

    '' 查看附件
    Private Sub LBCuploadList_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles LBCuploadList.MouseDoubleClick

        If LBCuploadList.SelectedIndex < 0 Then Exit Sub

        If isView Or isDesignate Then

            '' 預覽模式
            '' 從FTP內下載文件，生成預覽

            Me.Cursor = Cursors.WaitCursor

            Dim PreviewName As String = LBCuploadList.SelectedItem

            Dim ftpPreview As New FTPFielsManager

            ftpPreview.Preview(AutoID, LEProName.Text, PreviewName)

            Me.Cursor = Cursors.Default

        ElseIf TestEdit Then

            '' 編輯模式
            '' 移除選擇項目

            Dim tempFileName As String = LBCuploadList.SelectedItem

            Dim result As New DialogResult

            result = MessageBox.Show("確定需要刪除附件[" & tempFileName & "]嗎？" & vbCrLf & "資料一旦刪除則無法恢復，請慎重？", "項目管理系統",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If result = Windows.Forms.DialogResult.No Then Exit Sub

            Dim ftpMG As New FTPFielsManager

            ftpMG.DelFTPFile(AutoID, ProjectNaem, tempFileName)

            '' 移除list內容
            LBCuploadList.Items.Remove(tempFileName)

        End If
    End Sub

    '' 保存數據
    Private Sub btSave_Click(sender As System.Object, e As System.EventArgs) Handles btSave.Click

        If isView Then Exit Sub

        If Not isDesignate Then
            '' 保存反饋數據
            If SaveData() Then
                MessageBox.Show("保存成功！", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                lblClear()
                Me.Close()
            End If
        Else
            ''保存指派數據
            SaveDesignateData()

        End If

    End Sub

    '' 保存数据后继续增加
    Private Sub btContinueAdd_Click(sender As System.Object, e As System.EventArgs) Handles btContinueAdd.Click
        If SaveData() Then
            lblClear()
            MessageBox.Show("操作成功！", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    ''' <summary>
    ''' 保存指派任務
    ''' </summary>
    ''' <remarks></remarks>
    Sub SaveDesignateData()

        If LUDesignate.Text = "" Then
            LUDesignate.Focus()
            MessageBox.Show("請選擇受指派人？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If LUEResult.Text = "" Then
            LUEResult.Focus()
            MessageBox.Show("請選擇驗收人員？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If DEendDT.Text = "" Then
            DEendDT.Focus()
            MessageBox.Show("請選擇預計完成期？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim strSQL As String = Nothing

        strSQL = "update IT_DevelopBugManager set CurrentStatus='待回覆',ByDesigneeName='" & LUDesignate.Text.Trim() &
            "' ,ByDesigneeJog='" & LUDesignate.EditValue & "' , ResultsConfirmName='" & LUEResult.Text.Trim() &
            "' ,ResultsConfirmJob='" & LUEResult.EditValue & "', ExpectedLife='" & DEendDT.Text.Trim() &
            "',DesigneeRemarks='" & MERemarks.Text & "' where AutoID='" & AutoID & "' and SysProID='" & ProjectID & "'"

        Try
            If ExecuteNonQuery(strSQL) <> 1 Then
                MessageBox.Show("保存指派人數據失敗？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                MessageBox.Show("保存成功！", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                isRefresh = True
                lblClear()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("未知錯誤：" & vbCrLf & ex.Message, "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    ''' <summary>
    ''' 保存數據
    ''' </summary>
    ''' <remarks></remarks>
    Private Function SaveData() As Boolean

        SaveData = True

        If Len(LEProName.Text.Trim()) = 0 Then
            LEProName.Focus()
            MessageBox.Show("請選擇系統名稱？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveData = False
            Exit Function
        End If

        If Len(TestProModel.Text.Trim()) = 0 Then
            TestProModel.Focus()
            MessageBox.Show("請輸入測試項目名稱？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveData = False
            Exit Function
        End If

        If Len(txtTestStandard.Text.Trim()) = 0 Then
            txtTestStandard.Focus()
            MessageBox.Show("請輸入測試標準？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveData = False
            Exit Function
        End If

        If Len(txtTestNum.Text.Trim()) = 0 Then
            txtTestNum.Focus()
            MessageBox.Show("請輸入測試次數？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveData = False
            Exit Function
        End If

        If LECategory.Text = "" Then
            LECategory.Focus()
            MessageBox.Show("請選擇組別？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveData = False
            Exit Function
        End If

        If cbEmergency.Text = "" Then
            cbEmergency.Focus()
            MessageBox.Show("請選擇或輸入嚴重程度？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveData = False
            Exit Function
        End If

        If cmPriority.Text = "" Then
            cmPriority.Focus()
            MessageBox.Show("請選擇或輸入優先級別？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveData = False
            Exit Function
        End If

        If LEBugType.Text = "" Then
            LEBugType.Focus()
            MessageBox.Show("請選擇Bug類型？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveData = False
            Exit Function
        End If

        If Len(MEExceptions.Text.Trim()) = 0 Then
            MessageBox.Show("請輸入異常描述？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveData = False
            Exit Function
        End If

        Dim tempsql As String = Nothing
        Dim sql As String = Nothing

        '' 生成日期
        Dim CreateTimer As String = Nothing
        CreateTimer = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        If TestEdit Then  '' 生成修改語句

            tempsql = "update IT_DevelopBugManager set SysProName='" & LEProName.Text & "',SysProID='" & ProjectID & "',BugName='" & getSystempName & TestProModel.Text & "',TestStandard='" & txtTestStandard.Text.Trim() &
                "',  TestNum='" & txtTestNum.Text & "', Category='" & LECategory.Text & "',Emergency='" & cbEmergency.Text.Trim() &
                "', BugType='" & LEBugType.Text & "', Exceptions='" & MEExceptions.Text.Trim() & "', CreatedJob='" & UserID & "' ,CreatedUname='" & UserName & "', CreateTime='" & CreateTimer &
                "', Priority='" & cmPriority.Text & "'"

            sql = tempsql & " where AutoID='" & AutoID & "' and SysProID='" & ProjectID & "'"

        Else   '' 生成保存語句

            tempsql = "insert into IT_DevelopBugManager(SysProName,SysProID,CurrentStatus,BugName,TestStandard,TestNum,Category,Emergency,Priority,BugType,Exceptions,CreatedJob,CreatedUname,CreateTime) "

            sql = tempsql & " values('" & LEProName.Text & "','" & ProjectID & "','待指派','" & getSystempName & TestProModel.Text & "','" & txtTestStandard.Text & "','" & txtTestNum.Text & "','" & LECategory.Text &
              "','" & cbEmergency.Text & "','" & cmPriority.Text & "','" & LEBugType.Text & "','" & MEExceptions.Text & "','" & UserID & "','" & UserName & "','" & CreateTimer &
              "')"
        End If

        Try
            ExecuteNonQuery(sql)
            isRefresh = True
        Catch
            MessageBox.Show("數據處理失敗？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveData = False
            Exit Function
        End Try


        '' 數據插入成功後，開始上傳附件
        If LBCuploadList.Items.Count > 0 Then

            '' 取得 AutoID
            Dim tempAutoID As String = Nothing
            Dim getAutoID As String = "select AutoID From IT_DevelopBugManager where SysProID='" & LEProName.EditValue & "' and  BugName='" & TestProModel.Text & "'"
            Dim dt As DataTable
            dt = getDataTables(getAutoID)

            If dt.Rows.Count > 0 Then
                tempAutoID = dt.Rows(0)(0)
            End If

            Dim upfile As New FTPFielsManager

            Dim rsult As Integer

            rsult = upfile.uploadFTPFile(tempAutoID, LEProName.Text.Trim(), UploadProgressBar, LBCuploadList)

            Select Case rsult

                Case -1
                    '' -1：ftp登錄擒賊
                    '' 1：上传失败
                    '' 0：文档中包含非字符
                    '' 2：成功
                    SaveData = False
                    MessageBox.Show("FTP登錄失敗？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Function
                Case 1
                    MessageBox.Show("文件上传失败？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SaveData = False
                    Exit Function
                Case 0
                    MessageBox.Show("待上傳文件中包含非字符？", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SaveData = False
                    Exit Function
                    '’Case 2
                    '’MessageBox.Show("操作成功！", "項目管理系統", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End Select

        End If

        Return SaveData

    End Function

#End Region

    Dim td1 As Threading.Thread
    Dim td2 As Threading.Thread
    Dim td3 As Threading.Thread
    Dim td4 As Threading.Thread

    Private Sub BugEntry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        FormFormat()

    End Sub

#Region "綁定數據"

    ''' <summary>
    ''' 窗體模式
    ''' </summary>
    ''' <remarks></remarks>
    Sub FormFormat()

        If isDesignate Then ''指派模式

            ReadOnlyControl()

            '' 加載指派人與確認人名單
            td4 = New Threading.Thread(AddressOf loadDesignateData)
            td4.Start()

            btContinueAdd.Visible = False
            gcDesignate.Visible = True
            gcDesignate.Location = New Point(3, 469)
            Me.Height = 654
            PanelControl1.Location = New Point(3, 578)

        Else ''非指派模式
            gcDesignate.Visible = False
            PanelControl1.Location = New Point(3, 470)
            Me.Height = 544

        End If

        If isView Then

            '' 預覽模式

            LoadEditData()

            ReadOnlyControl()


        ElseIf Not isDesignate Or TestEdit Then

            '' 正常操作模式
            td1 = New Threading.Thread(AddressOf loadSystemName)
            td1.Start()

            td2 = New Threading.Thread(AddressOf loadCategoryData)
            td2.Start()

            td3 = New Threading.Thread(AddressOf loadLEBugTypeData)
            td3.Start()

            If TestEdit Then
                '' 編輯模式
                LoadEditData()

            End If

        End If

    End Sub

    ''' <summary>
    ''' 加載編輯時數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadEditData()

        Dim dt As New DataTable

        Dim strSQL As String = Nothing

        strSQL = "select * from IT_DevelopBugManager where CurrentStatus='" & CurrentStatus & "' and AutoID='" & AutoID & "' and SysProID='" & ProjectID.Trim() & "' "

        dt = getDataTables(strSQL)

        If dt.Rows.Count <= 0 Then
            Me.Close()
            Exit Sub
        End If


        LEProName.Properties.ReadOnly = True
        ProjectNaem = dt.Rows(0)("SysProName")
        ProjectID = dt.Rows(0)("SysProID")
        LEProName.Text = ProjectNaem
        TestProModel.Text = dt.Rows(0)("BugName")
        txtTestStandard.Text = dt.Rows(0)("TestStandard")
        txtTestNum.Text = dt.Rows(0)("TestNum")
        LECategory.Properties.NullText = dt.Rows(0)("Category")
        cbEmergency.Text = dt.Rows(0)("Emergency")
        cmPriority.Text = dt.Rows(0)("Priority")
        LEBugType.Properties.NullText = dt.Rows(0)("BugType")
        MEExceptions.Text = dt.Rows(0)("Exceptions")


        dt.Clear()
        dt.Dispose()

        '' 載入所以附件

        GetAttachmentList(LBCuploadList, AutoID, LEProName.Text)

        dt.Clear()
        dt.Dispose()

    End Sub
    ''' <summary>
    ''' 加載所有人員
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadDesignateData()

        Dim dt As New DataTable

        Dim strSQL As String = Nothing

        strSQL = "SELECT *  FROM ATL_HD_UserGroups where ServiceTypeID='1'  and IsDimission=0 order by userno"

        dt = getDataTables(strSQL)

        If dt.Rows.Count > 0 Then

            Try
                SetLockUpEdit = New SetLockUpEditDelegate(AddressOf BindingData)

                Me.Invoke(SetLockUpEdit, LUDesignate, dt)

                Me.Invoke(SetLockUpEdit, LUEResult, dt)

            Catch ex As Exception

                '' MessageBox.Show(ex.Message)

            Finally

                td4.Abort()

            End Try

        End If

    End Sub

    ''' <summary>
    ''' 加载系统名称
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadSystemName()

        Dim dt As New DataTable
        Dim strSql As String = Nothing

        strSql = "select * from IT_SystemNameManager"

        dt = getDataTables(strSql)

        Try

            If dt.Rows.Count > 0 Then

                Syslist.DataSource = dt

                'SetLockUpEdit = New SetLockUpEditDelegate(AddressOf BindingData)

                'Me.Invoke(SetLockUpEdit, Syslist, dt)

                dt.Dispose()

            End If

        Catch ex As Exception

            ''MessageBox.Show(ex.Message)

        Finally
            td1.Abort()
        End Try

    End Sub

    ''' <summary>
    ''' 綁定組別名稱
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadCategoryData()

        Dim dt As New DataTable
        Dim strSql As String = Nothing

        strSql = "SELECT *  FROM IT_Member where ParentID='1'"

        dt = getDataTables(strSql)

        Try

            If dt.Rows.Count > 0 Then
                SetLockUpEdit = New SetLockUpEditDelegate(AddressOf BindingData)

                Me.Invoke(SetLockUpEdit, LECategory, dt)

                dt.Dispose()

            End If

        Catch ex As Exception
            '' MessageBox.Show(ex.Message)

        Finally
            td2.Abort()
        End Try

    End Sub

    ''' <summary>
    ''' 加載Bug類型
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadLEBugTypeData()

        Dim dt As New DataTable
        Dim strSql As String = Nothing

        strSql = "select * from IT_ConfigParameters"

        dt = getDataTables(strSql)

        Try

            If dt.Rows.Count > 0 Then

                SetLockUpEdit = New SetLockUpEditDelegate(AddressOf BindingData)

                Me.Invoke(SetLockUpEdit, LEBugType, dt)

                dt.Dispose()

            End If

        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        Finally
            td3.Abort()
        End Try
    End Sub

    ''' <summary>
    ''' 公共方法綁定數據
    ''' </summary>
    ''' <param name="LookUpEditControl">控件</param>
    ''' <param name="dt">數據集</param>
    ''' <remarks></remarks>
    Sub BindingData(ByVal LookUpEditControl As DevExpress.XtraEditors.LookUpEdit, ByVal dt As Object)

        Try

            LookUpEditControl.Properties.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    ''' <summary>
    ''' 清空控件
    ''' </summary>
    ''' <remarks></remarks>
    Sub lblClear()
        LEProName.Focus()
        LEProName.Text = ""
        TestProModel.Text = ""
        txtTestStandard.Text = ""
        LECategory.Text = ""
        cbEmergency.Text = ""
        LEBugType.Text = ""
        MEExceptions.Text = ""
        LBCuploadList.Items.Clear()
    End Sub
    ''' <summary>
    ''' 锁定控件
    ''' </summary>
    ''' <remarks></remarks>
    Sub ReadOnlyControl()
        btContinueAdd.Visible = False
        txtTestNum.Properties.ReadOnly = True
        LEProName.Properties.ReadOnly = True
        TestProModel.Properties.ReadOnly = True
        txtTestStandard.Properties.ReadOnly = True
        LECategory.Properties.ReadOnly = True
        cbEmergency.Properties.ReadOnly = True
        LEBugType.Properties.ReadOnly = True
        MEExceptions.Properties.ReadOnly = True
        BEUpFile.Enabled = False
        cmPriority.Properties.ReadOnly = True
    End Sub

#End Region

    Private Sub btClose_Click(sender As System.Object, e As System.EventArgs) Handles btClose.Click
        lblClear()
        Me.Close()
    End Sub

    Private Sub BugEntry_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        On Error Resume Next
        LEProName.Focus()
        LEProName.SelectAll()
    End Sub
    Dim getSystempName As String = Nothing
    Private Sub Syslist_FocusedNodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles Syslist.FocusedNodeChanged

        getSystempName = Nothing

        ProjectID = e.Node.GetValue("SystemID")

        LEProName.Text = e.Node.GetValue("SystemName")

        GetParentNodes(e.Node)

        getSystempName = e.Node.RootNode.GetValue("SystemName") & "-" & getSystempName



        '’MessageBox.Show(e.Node.RootNode.GetValue("SystemName") & "-" & getSystempName)

    End Sub

    ''' <summary>
    ''' 遞歸取得父節點值
    ''' </summary>
    ''' <param name="node"></param>
    ''' <remarks></remarks>
    Sub GetParentNodes(ByVal node As TreeListNode)

        If node.ParentNode Is Nothing Then Exit Sub

        Dim strTemp As String = String.Empty

        If Not node Is Nothing Then

            getSystempName = node.GetValue("SystemName") & "-" & getSystempName

        End If

        GetParentNodes(node.ParentNode)

    End Sub
End Class