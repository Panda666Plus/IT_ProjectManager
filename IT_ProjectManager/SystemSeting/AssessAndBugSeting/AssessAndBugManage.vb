Public Class AssessAndBugManage

#Region "属性"

    ''' <summary>
    ''' 临时名称
    ''' </summary>
    ''' <remarks></remarks>
    Dim TempName As String = Nothing
    ''' <summary>
    ''' 临时备注
    ''' </summary>
    ''' <remarks></remarks>
    Dim TempRemarks As String = Nothing

    '' 记录临时ID
    Dim TempAutoID As String = Nothing

    ''' <summary>
    ''' bug类型管理是否为编辑状态
    ''' true 为是
    ''' false为否
    ''' </summary>
    ''' <remarks></remarks>
    Dim BugManagerEdit As Boolean = False

    ''' <summary>
    ''' 考核类型管理
    ''' true为编辑状态
    ''' false非编辑状态
    ''' </summary>
    ''' <remarks></remarks>
    Dim AssessEdit As Boolean = False


#End Region

#Region "载入数据"

    Private Sub frmSysSeting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadBugTypeManager()

        loadAccessData()

    End Sub

    ''' <summary>
    ''' 载入Bug类型名称数据
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
    ''' 加载考核数据
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadAccessData()
        Try

            Dim sql As String = Nothing

            sql = "select * from IT_AssessStandard"

            Dim dt As New DataTable

            dt = getDataTables(sql)

            If dt.Rows.Count > 0 Then
                AssessTreelist.DataSource = dt
            Else
                AssessTreelist.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' 通过委托绑定数据
    ''' </summary>
    ''' <param name="gridControl">控件</param>
    ''' <param name="dt">数据集</param>
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

#Region "系统名称管理"

    ''' <summary>
    ''' 保存或修改数据系统名称信息
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
                MessageBox.Show("操作失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Claerlbl()
                MessageBox.Show("操作成功？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MessageBox.Show("未知错误：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


#End Region

#Region "为GRIDVIEW绘制颜色"

    Private Sub GridView1_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GridView3.CustomDrawCell

        CustomDrawCell(e)

    End Sub

#End Region

#Region "管理Grid双击"

    '' 改变处理模块
    Private Sub xtControl_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtControl.SelectedPageChanged

        Claerlbl()

        Select Case CInt(xtControl.SelectedTabPageIndex)

            Case 0
                lblName.Text = "Bug类型"
                CheckEdit1.Visible = False
                CheckEdit2.Visible = False
            Case 1
                lblName.Text = "考核类型"
                CheckEdit1.Visible = True
                CheckEdit2.Visible = True
        End Select

        BugManagerEdit = False
        AssessEdit = False

    End Sub
    ''' <summary>
    ''' 清空控件内容
    ''' </summary>
    ''' <remarks></remarks>
    Sub Claerlbl()
        txtName.Focus()
        TempName = Nothing
        TempRemarks = Nothing
        txtName.Text = ""
        txtRemarks.Text = ""
        btSave.Text = "保存"
        btClose.Text = "关闭"
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

    '' 修改Bug类型
    Private Sub BugManager_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BugManager.DoubleClick


        Claerlbl()

        TempAutoID = GridView3.GetFocusedRowCellValue("AutoID")
        TempName = GridView3.GetFocusedRowCellValue("xName")
        TempRemarks = GridView3.GetFocusedRowCellValue("Remarks")

        SetText()

        BugManagerEdit = True

        AssessEdit = False

    End Sub

#End Region

    '' 保存数据
    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click

        If Len(txtName.Text.Trim()) = 0 Then
            txtName.Focus()
            MessageBox.Show("请输入内容？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Select Case CInt(xtControl.SelectedTabPageIndex)
            Case 0  '' Bug类型管理

                If BugManagerEdit Then ''修改Bug类型

                    SaveInfo(False)

                Else '' 保存Bug类型管理

                    SaveInfo(True)

                End If

                '' 刷新数据
                LoadBugTypeManager()

            Case 1 ''考核信息

                EditGradeStandardData()

                '' 刷新数据
                loadAccessData()

        End Select

    End Sub

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click

        If btClose.Text = "取消" Then
            Claerlbl()
        Else
            Me.Close()
        End If

    End Sub

#Region "删除数据"

    '' 删除指定资料
    Private Sub BugManager_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BugManager.KeyDown

        If e.KeyCode = Keys.Delete Then

            Claerlbl()

            TempAutoID = GridView3.GetFocusedRowCellValue("AutoID")
            TempName = GridView3.GetFocusedRowCellValue("xName")

            If DelData(TempName, TempAutoID) Then
                GridView3.DeleteRow(GridView3.FocusedRowHandle)
            End If

        End If

    End Sub

    ''' <summary>
    ''' 删除指定资料
    ''' </summary>
    ''' <param name="name">名称</param>
    ''' <param name="id">id</param>
    ''' <remarks></remarks>
    Function DelData(ByVal name As String, ByVal id As String) As Boolean

        DelData = True

        Try

            If name <> "" Or id <> "" Then

                Dim sql As String = Nothing

                sql = "delete IT_ConfigParameters where AutoID='" & id & "' and xName='" & name & "'"

                Dim result As New DialogResult

                result = MessageBox.Show("您确定需要删除[" & name & "]数据吗？", "项目管理系统", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If result = DialogResult.No Then Exit Function

                If ExecuteNonQuery(sql) <> 1 Then
                    MessageBox.Show("删除失败，存在多笔相同数据？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("删除成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

            End If

        Catch
            DelData = False
        End Try

        Return DelData

    End Function

    ''' <summary>
    ''' 删除指定数据
    ''' </summary>
    ''' <param name="GS_Name">类型名</param>
    ''' <param name="GS_ID">类型ID</param>
    ''' <param name="AssessID"></param>
    ''' <remarks></remarks>
    Function DelData(ByVal GS_Name As String, ByVal GS_ID As Integer, ByVal AssessID As Integer) As Boolean

        DelData = True

        Try

            If GS_Name <> "" Or GS_ID <> 0 Then

                Claerlbl()
                Dim result As New DialogResult

                result = MessageBox.Show("您确定需要删除指定数据[" & GS_Name & "]吗？", "项目管理系统", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If result = DialogResult.No Then Exit Function

                Dim sql As String = Nothing

                sql = "delete IT_GradeStandard where GS_ID='" & GS_ID & "' and GS_PID='0' and GS_Level='0' and GS_Name='" & GS_Name & "' "


                If ExecuteNonQuery(sql) <> 1 Then
                    MessageBox.Show("删除失败，存在多笔相同数据？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("删除成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

            End If

        Catch ex As Exception
            DelData = False
        End Try

        Return DelData

    End Function


#End Region

#Region "考核模块"

    Dim pid As Integer = 0, level As Integer = 0
    Dim Kid As Integer
    '' 加载图标
    Private Sub AssessTreelist_GetStateImage(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.GetStateImageEventArgs) Handles AssessTreelist.GetStateImage
        If e.Node Is Nothing Then Exit Sub
        Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
        node = e.Node
        Dim ID As Integer = e.Node.Level
        e.NodeImageIndex = ID
    End Sub

    ''增加主项目
    Private Sub AddPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPro.Click
        Kid = 0
        pid = 0
        txtName.Focus()
        btClose.Text = "取消"
    End Sub
    ' 增加子项目
    Private Sub AddItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddItems.Click
        pid = AssessTreelist.FocusedNode.GetValue("ASS_ID")
        level = AssessTreelist.FocusedNode.Level
        txtName.Focus()
        btClose.Text = "取消"
    End Sub

    '' 修改
    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        AssessEdit = True
        pid = AssessTreelist.FocusedNode.GetValue("ASS_PID")
        level = AssessTreelist.FocusedNode.Level
        Kid = AssessTreelist.FocusedNode.GetValue("ASS_ID")
        txtName.Text = AssessTreelist.FocusedNode.GetValue("ASS_Name")
        txtRemarks.Text = AssessTreelist.FocusedNode.GetValue("ASS_Remark")
        btSave.Text = "修改"
        btClose.Text = "取消"
    End Sub
    '' 删除
    Private Sub Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Del.Click

        If AssessTreelist.FocusedNode.Nodes.Count > 0 Then
            MessageBox.Show("此项目包含子节点，请选择移除子项目？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Kid = AssessTreelist.FocusedNode.GetValue("ASS_ID")
        pid = AssessTreelist.FocusedNode.GetValue("ASS_PID")
        Dim name As String = AssessTreelist.FocusedNode.GetValue("ASS_Name")
        Dim result As New DialogResult

        result = MessageBox.Show("您确定需要删除[" & name & "]相关数据吗,资料一旦删除则无法恢复？", "项目管理系统", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = Windows.Forms.DialogResult.No Then Exit Sub ''退出

        Dim sql As String = Nothing
        sql = "delete IT_AssessStandard where ASS_ID='" & Kid & "' and ASS_PID='" & pid & "' and ASS_Name='" & name & "'"

        Try
            If ExecuteNonQuery(sql) <> 1 Then
                MessageBox.Show("同存在多笔数据？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("删除成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                '' 移除指定行
                AssessTreelist.Nodes.Remove(AssessTreelist.FocusedNode)
            End If
        Catch ex As Exception
            MessageBox.Show("未知错误：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ''' <summary>
    ''' 更新数据
    ''' </summary>
    ''' <remarks></remarks>
    Sub EditGradeStandardData()

        If Not CheckEdit1.Checked And Not CheckEdit2.Checked Then
            MessageBox.Show("请选择考核主管对象?", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim strSB As New System.Text.StringBuilder

        If AssessEdit Then
            strSB.Append("update IT_AssessStandard set ASS_Name='" & txtName.Text.Trim() & "',ASS_Remark='" & txtRemarks.Text.Trim())
            strSB.Append("' where ASS_ID='" & Kid & "' AND ASS_PID='" & pid & "'")
        Else
            strSB.Append("insert into  IT_AssessStandard values('" & pid & "','" & level & "','" & txtName.Text.Trim() & "','" & txtRemarks.Text.Trim & "',")
            If CheckEdit1.Checked Then
                strSB.Append("'0')")
            ElseIf CheckEdit2.Checked Then
                strSB.Append("'1')")
            End If
        End If

        Try

            If ExecuteNonQuery(strSB.ToString()) <> 1 Then
                MessageBox.Show("数据处理失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("数据处理成功？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Claerlbl()
            End If

        Catch ex As Exception
            MessageBox.Show("未知错误：" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        strSB.Clear()

    End Sub


#End Region

End Class