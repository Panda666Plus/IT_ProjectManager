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
    ''' 是否处理修改状态
    ''' true表示编辑状态
    ''' false表示非编辑状态
    ''' </summary>
    ''' <remarks></remarks>
    Public TestEdit As Boolean = False

    ''' <summary>
    ''' 是否处理预览状态
    ''' true表示为预览模式
    ''' false表示非预览模式
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
    ''' 系统项目ID
    ''' </summary>
    ''' <remarks></remarks>
    Public ProjectID As String = Nothing

    Dim ProjectNaem As String = Nothing

    Public CurrentStatus As String = "待回覆"

#Region "附件上传  ， 保存  修改数据"

    '' 只允许输入数字
    Private Sub txtTestNum_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTestNum.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            'MessageBox.Show("非有效数值，请重新输入?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub BEUpFile_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles BEUpFile.ButtonClick
        Dim openFile As New OpenFileDialog

        openFile.Title = "测试异常问题附件上传"
        Dim strSB As New System.Text.StringBuilder
        strSB.Append("Office Documents(*.docx, *.xlsx, *.pptx, *.vsd, *.accdb)|*.docx;*.xlsx;*.pptx;*..vsd;*.accdb|")
        strSB.Append("PDF Files(*.pdf)|*.pdf|txt Files(*.txt)|*.txt|压缩文件(*.zip, *.7z, *.rar, *.RAR5)|*.zip;*.7z;*.rar;*.RAR5|")
        strSB.Append("Pic File (*.jpg, *.jpeg, *.gif, *.png, *.bmp)|*.jpg;*.jpeg;*.gi; *.png;*.bmp")
        openFile.Filter = strSB.ToString()
        strSB.Clear()
        openFile.Multiselect = True

        If openFile.ShowDialog() = DialogResult.OK Then

            '' 如果不为空则指行下一步操作
            If openFile.FileNames IsNot Nothing Then

                Dim filename As String

                For Each filename In openFile.FileNames

                    For i As Integer = 0 To LBCuploadList.Items.Count - 1 Step 1
                        If filename = LBCuploadList.Items(i).ToString().Trim() Then
                            MessageBox.Show("文件【" & Path.GetFileName(filename) & "】已经存在", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If
                    Next

                    LBCuploadList.Items.Add(filename)

                Next

            End If

        End If
    End Sub

    '' 查看附件
    Private Sub LBCuploadList_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LBCuploadList.MouseDoubleClick

        If LBCuploadList.SelectedIndex < 0 Then Exit Sub

        If isView Or isDesignate Then

            '' 预览模式
            '' 从FTP内下载文件，生成预览

            Me.Cursor = Cursors.WaitCursor

            Dim PreviewName As String = LBCuploadList.SelectedItem

            Dim ftpPreview As New FTPFielsManager

            ftpPreview.Preview(AutoID, LEProName.Text, PreviewName)

            Me.Cursor = Cursors.Default

        ElseIf TestEdit Then

            '' 编辑模式
            '' 移除选择项目

            Dim tempFileName As String = LBCuploadList.SelectedItem

            Dim result As New DialogResult

            result = MessageBox.Show("确定需要删除附件[" & tempFileName & "]吗？" & vbCrLf & "资料一旦删除则无法恢复，请慎重？", "项目管理系统",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If result = Windows.Forms.DialogResult.No Then Exit Sub

            Dim ftpMG As New FTPFielsManager

            ftpMG.DelFTPFile(AutoID, ProjectNaem, tempFileName)

            '' 移除list内容
            LBCuploadList.Items.Remove(tempFileName)

        End If
    End Sub

    '' 保存数据
    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click

        If isView Then Exit Sub

        If Not isDesignate Then
            '' 保存反馈数据
            If SaveData() Then
                MessageBox.Show("保存成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                lblClear()
                Me.Close()
            End If
        Else
            ''保存指派数据
            SaveDesignateData()

        End If

    End Sub

    '' 保存数据后继续增加
    Private Sub btContinueAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btContinueAdd.Click
        If SaveData() Then
            lblClear()
            MessageBox.Show("操作成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    ''' <summary>
    ''' 保存指派任务
    ''' </summary>
    ''' <remarks></remarks>
    Sub SaveDesignateData()

        If LUDesignate.Text = "" Then
            LUDesignate.Focus()
            MessageBox.Show("请选择受指派人？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If LUEResult.Text = "" Then
            LUEResult.Focus()
            MessageBox.Show("请选择验收人员？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If DEendDT.Text = "" Then
            DEendDT.Focus()
            MessageBox.Show("请选择预计完成期？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim strSB As New System.Text.StringBuilder

        strSB.Append("update IT_DevelopBugManager set CurrentStatus='待回覆',ByDesigneeName='" & LUDesignate.Text.Trim())
        strSB.Append("' ,ByDesigneeJog='" & LUDesignate.EditValue & "' , ResultsConfirmName='" & LUEResult.Text.Trim())
        strSB.Append("' ,ResultsConfirmJob='" & LUEResult.EditValue & "', ExpectedLife='" & DEendDT.Text.Trim())
        strSB.Append("',DesigneeRemarks='" & MERemarks.Text & "' where AutoID='" & AutoID & "' and SysProID='" & ProjectID & "'")

        Try
            If ExecuteNonQuery(strSB.ToString()) <> 1 Then
                MessageBox.Show("保存指派人数据失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                MessageBox.Show("保存成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                isRefresh = True
                lblClear()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("未知错误：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        strSB.Clear()

    End Sub

    ''' <summary>
    ''' 保存数据
    ''' </summary>
    ''' <remarks></remarks>
    Private Function SaveData() As Boolean

        SaveData = True

        If Len(LEProName.Text.Trim()) = 0 Then
            LEProName.Focus()
            MessageBox.Show("请选择系统名称？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveData = False
            Exit Function
        End If

        If Len(TestProModel.Text.Trim()) = 0 Then
            TestProModel.Focus()
            MessageBox.Show("请输入测试项目名称？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveData = False
            Exit Function
        End If

        If Len(txtTestStandard.Text.Trim()) = 0 Then
            txtTestStandard.Focus()
            MessageBox.Show("请输入测试标准？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveData = False
            Exit Function
        End If

        If Len(txtTestNum.Text.Trim()) = 0 Then
            txtTestNum.Focus()
            MessageBox.Show("请输入测试次数？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveData = False
            Exit Function
        End If

        If LECategory.Text = "" Then
            LECategory.Focus()
            MessageBox.Show("请选择组别？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveData = False
            Exit Function
        End If

        If cbEmergency.Text = "" Then
            cbEmergency.Focus()
            MessageBox.Show("请选择或输入严重程度？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveData = False
            Exit Function
        End If

        If cmPriority.Text = "" Then
            cmPriority.Focus()
            MessageBox.Show("请选择或输入优先级别？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveData = False
            Exit Function
        End If

        If LEBugType.Text = "" Then
            LEBugType.Focus()
            MessageBox.Show("请选择Bug类型？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveData = False
            Exit Function
        End If

        If Len(MEExceptions.Text.Trim()) = 0 Then
            MessageBox.Show("请输入异常描述？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveData = False
            Exit Function
        End If

        ''2014-06-03
        If LUDesignateA.Text = "" Then
            MessageBox.Show("请输入预受指派人？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveData = False
            LUDesignateA.Select()
            Exit Function
        End If

        Dim strSB As New System.Text.StringBuilder

        '' 生成日期   ByDesigneeJog='" & LUDesignate.EditValue & "'
        Dim CreateTimer As String = Nothing
        CreateTimer = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        If TestEdit Then  '' 生成修改语句

            strSB.Append("update IT_DevelopBugManager set SysProName='" & LEProName.Text & "',SysProID='" & ProjectID & "',BugName='" & TextEdit1.Text & TestProModel.Text)
            strSB.Append("',TestStandard='" & txtTestStandard.Text.Trim() & "',  TestNum='" & txtTestNum.Text & "', Category='" & LECategory.Text)
            strSB.Append("',Emergency='" & cbEmergency.Text.Trim() & "', BugType='" & LEBugType.Text & "', Exceptions='" & MEExceptions.Text.Trim())
            strSB.Append("', CreatedJob='" & UserID & "' ,CreatedUname='" & UserName & "', CreateTime='" & CreateTimer & "', Priority='" & cmPriority.Text & "',ByDesigneeJog='" & LUDesignateA.EditValue & "'")
            strSB.Append(" where AutoID='" & AutoID & "' and SysProID='" & ProjectID & "'")

        Else   '' 生成保存语句

            strSB.Append("insert into IT_DevelopBugManager")
            strSB.Append("(SysProName,SysProID,CurrentStatus,BugName,TestStandard,TestNum,Category,Emergency,Priority,BugType,Exceptions,CreatedJob,CreatedUname,CreateTime,ByDesigneeJog) ")
            strSB.Append(" values('" & LEProName.Text & "','" & ProjectID & "','待指派','" & TextEdit1.Text & TestProModel.Text & "','" & txtTestStandard.Text & "','" & txtTestNum.Text)
            strSB.Append("','" & LECategory.Text & "','" & cbEmergency.Text & "','" & cmPriority.Text & "','" & LEBugType.Text & "','" & MEExceptions.Text)
            strSB.Append("','" & UserID & "','" & UserName & "','" & CreateTimer & "','" & LUDesignateA.EditValue & "')")

        End If

        Try
            ExecuteNonQuery(strSB.ToString())
            strSB.Clear()
            isRefresh = True
        Catch
            MessageBox.Show("数据处理失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SaveData = False
            Exit Function
        End Try


        '' 数据插入成功後，开始上传附件
        If LBCuploadList.Items.Count > 0 Then

            '' 取得 AutoID
            Dim tempAutoID As String = Nothing
            Dim getAutoID As String = "select AutoID From IT_DevelopBugManager where SysProName='" & LEProName.Text & "' and SysProID='" & ProjectID & "' and  BugName='" & TextEdit1.Text & TestProModel.Text & "'"
            Dim dt As DataTable
            dt = getDataTables(getAutoID)

            If dt.Rows.Count <= 0 Then
                MessageBox.Show("获取关联ID失败,无法上传附件?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function
            End If

            tempAutoID = dt.Rows(0)(0)

            Dim upfile As New FTPFielsManager

            Dim rsult As Integer

            rsult = upfile.uploadFTPFile(tempAutoID, LEProName.Text.Trim(), UploadProgressBar, LBCuploadList)

            Select Case rsult

                Case -1
                    '' -1：ftp登录擒贼
                    '' 1：上传失败
                    '' 0：文档中包含非字符
                    '' 2：成功
                    SaveData = False
                    MessageBox.Show("FTP登录失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Function
                Case 1
                    MessageBox.Show("文件上传失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SaveData = False
                    Exit Function
                Case 0
                    MessageBox.Show("待上传文件中包含非字符？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SaveData = False
                    Exit Function
                    '’Case 2
                    '’MessageBox.Show("操作成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End Select

        End If

        Return SaveData

    End Function

#End Region

    Dim td1 As Threading.Thread
    Dim td2 As Threading.Thread
    Dim td3 As Threading.Thread
    Dim td4 As Threading.Thread

    Private Sub BugEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FormFormat()

    End Sub

#Region "绑定数据"

    ''' <summary>
    ''' 窗体模式
    ''' </summary>
    ''' <remarks></remarks>
    Sub FormFormat()

        If isDesignate Then ''指派模式

            ReadOnlyControl()



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

        '' 加载指派人与确认人名单
        td4 = New Threading.Thread(AddressOf loadDesignateData)
        td4.Start()

        If isView Then

            '' 预览模式

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
                '' 编辑模式
                LoadEditData()
            End If

        End If

    End Sub

    ''' <summary>
    ''' 加载编辑时数据
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadEditData()

        Dim dt As New DataTable

        Dim strSQL As String = Nothing

        strSQL = "select * from IT_DevelopBugManager where CurrentStatus='" & CurrentStatus & "' and AutoID='" & AutoID &
            "' and SysProID='" & ProjectID.Trim() & "' "

        dt = getDataTables(strSQL)

        If dt.Rows.Count <= 0 Then
            Me.Close()
            Exit Sub
        End If


        LEProName.Properties.ReadOnly = True
        ProjectNaem = dt.Rows(0)("SysProName")
        ProjectID = dt.Rows(0)("SysProID")
        LEProName.Text = ProjectNaem
        Dim temp As String = dt.Rows(0)("BugName").ToString()
        Dim i As Integer = temp.LastIndexOf("-") + 1

        TextEdit1.Text = temp.Substring(0, i)

        TestProModel.Text = temp.Substring(i, temp.Length() - i)
        txtTestStandard.Text = dt.Rows(0)("TestStandard")
        txtTestNum.Text = dt.Rows(0)("TestNum")
        LECategory.Properties.NullText = dt.Rows(0)("Category")
        cbEmergency.Text = dt.Rows(0)("Emergency")
        cmPriority.Text = dt.Rows(0)("Priority")
        LEBugType.Properties.NullText = dt.Rows(0)("BugType")
        MEExceptions.Text = dt.Rows(0)("Exceptions")

        LUDesignateA.EditValue = dt.Rows(0)("ByDesigneeJog")

        If LUDesignate.Text = "" Then
            LUDesignate.EditValue = dt.Rows(0)("ByDesigneeJog")
        End If

        dt.Clear()
        dt.Dispose()

        '' 载入所以附件

        GetAttachmentList(LBCuploadList, AutoID, LEProName.Text)

    End Sub
    ''' <summary>
    ''' 加载所有人员
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadDesignateData()

        Dim dt As New DataTable

        Dim strSQL As String = Nothing

        ' strSQL = "SELECT *  FROM ATL_HD_UserGroups where ServiceTypeID='1'  and IsDimission=0 order by userno"
        strSQL = "select * from IT_PersonnelGroups where Groups= 'DT部' and isjob =1 order by userno"

        dt = getDataTables(strSQL)

        If dt.Rows.Count > 0 Then

            Try
                SetLockUpEdit = New SetLockUpEditDelegate(AddressOf BindingData)
                'Me.Invoke(SetLockUpEdit, LUDesignate, dt)
                'Me.Invoke(SetLockUpEdit, LUEResult, dt)
                '2014-5-8
                SetGridLookUpEdit = New SetGridLookUpEditDelegate(AddressOf BindingGridData)
                Me.Invoke(SetGridLookUpEdit, LUDesignate, dt)
                Me.Invoke(SetGridLookUpEdit, LUEResult, dt)
                Me.Invoke(SetGridLookUpEdit, LUDesignateA, dt)

                If LUEResult.Text = "" Then
                    LUEResult.EditValue = UserID
                End If


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

                dt.Dispose()

            End If

        Catch ex As Exception
            ''MessageBox.Show(ex.Message)
        Finally
            td1.Abort()
        End Try

    End Sub

    ''' <summary>
    ''' 绑定组别名称
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
    ''' 加载Bug类型
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadLEBugTypeData()

        Dim dt As New DataTable
        Dim strSql As String = Nothing

        strSql = "select * from IT_ConfigParameters"
        ' strSql = " select (xName) as Bug类型 from IT_ConfigParameters"
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
    ''' 公共方法绑定数据
    ''' </summary>
    ''' <param name="LookUpEditControl">控件</param>
    ''' <param name="dt">数据集</param>
    ''' <remarks></remarks>
    Sub BindingData(ByVal LookUpEditControl As DevExpress.XtraEditors.LookUpEdit, ByVal dt As Object)

        Try

            LookUpEditControl.Properties.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub BindingGridData(ByVal GridLookUpEditControl As DevExpress.XtraEditors.GridLookUpEdit, ByVal dt As Object)

        Try

            GridLookUpEditControl.Properties.DataSource = dt

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

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        lblClear()
        Me.Close()
    End Sub

    Private Sub BugEntry_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        On Error Resume Next
        LEProName.Focus()
        LEProName.SelectAll()
    End Sub

    Private Sub Syslist_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles Syslist.FocusedNodeChanged

        ProjectID = e.Node.RootNode.GetValue("SystemID")

        LEProName.EditValue = ProjectID
        LEProName.Text = e.Node.RootNode.GetValue("SystemName")

        TextEdit1.Text = String.Empty
        TestProModel.Text = String.Empty
        GetParentNodes(e.Node, TextEdit1.Text)

        ''TestProModel.Focus()

        '' LEProName.ClosePopup()

        'If LEProName.IsPopupOpen Then
        '    LEProName.ClosePopup()
        'End If

    End Sub

    ''' <summary>
    ''' 递归取得父节点值
    ''' </summary>
    ''' <param name="node"></param>
    ''' <remarks></remarks>
    Sub GetParentNodes(ByVal node As TreeListNode, ByRef sysName As String)

        If node.ParentNode Is Nothing Then Exit Sub

        Dim strTemp As String = String.Empty

        If Not node Is Nothing Then

            sysName = node.GetValue("SystemName") & "-" & sysName

        End If

        GetParentNodes(node.ParentNode, sysName)

    End Sub

    Private Sub Syslist_GetStateImage(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.GetStateImageEventArgs) Handles Syslist.GetStateImage
        If e.Node Is Nothing Then Exit Sub
        Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
        node = e.Node
        Dim ID As Integer = e.Node.Level
        e.NodeImageIndex = ID
    End Sub

    Private Sub LBCuploadList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBCuploadList.SelectedIndexChanged

    End Sub

    ''' <summary>
    ''' 只有在指定模式下2014-6-3
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadLUDesignateAData()
        Dim dt As New DataTable
        Dim strSQL As String = Nothing

        strSQL = "select * from IT_DevelopBugManager where CurrentStatus='" & CurrentStatus & "' and AutoID='" & AutoID &
            "' and SysProID='" & ProjectID.Trim() & "' "

        dt = getDataTables(strSQL)

        If dt.Rows.Count <= 0 Then
            '    Me.Close()
            Exit Sub
        End If
        LUDesignateA.EditValue = dt.Rows(0)("ByDesigneeJog")

        dt.Clear()
        dt.Dispose()

    End Sub
End Class