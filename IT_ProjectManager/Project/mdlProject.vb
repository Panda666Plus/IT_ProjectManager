Public Class mdlProject

    Dim td As Threading.Thread = Nothing
    Private Sub mdlProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Application.DoEvents()


        Me.Cursor = Cursors.WaitCursor

        td = New Threading.Thread(AddressOf LoadProjectData)
        td.Start()
        Threading.Thread.Sleep(100)
        '' 
        ChecksFilterValue()
        If Isglobaluser Or IsProjectManager Or IsLeader Then
            CheckEdit1.Enabled = True
            CheckEdit2.Enabled = True
            CheckEdit3.Enabled = True
            CheckEdit4.Enabled = True
            CheckEdit5.Enabled = True
            CheckEdit6.Enabled = True
            chkName.Enabled = True
            txtLike.Enabled = True
        Else
            CheckEdit1.Enabled = False
            CheckEdit2.Enabled = False
            CheckEdit3.Enabled = False
            CheckEdit4.Enabled = False
            CheckEdit5.Enabled = False
            CheckEdit6.Enabled = False
            chkName.Enabled = False
            txtLike.Enabled = False
        End If
        Me.Cursor = Cursors.Default

    End Sub
    ''' <summary>
    ''' 加载超期项目
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadExtendedData(ByVal id As UInt16)
        Dim sql As String = "select * from IT_PrjReplyExtended where Scheme_ID='" & id & "'"
        Dim dt As New DataTable
        dt = getDataTables(sql)
        If dt.Rows.Count > 0 Then
            Grid.DataSource = dt
        Else
            Grid.DataSource = Nothing
        End If
        dt.Dispose()
    End Sub

    ''' <summary>
    ''' 导入项目资料
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadProjectData()

        Try
            Dim dt As New DataTable
            Dim strSB As New System.Text.StringBuilder

            strSB.Append("select a.ID,a.SchemeName,a.SmPrincipal,a.SmStartDate,a.SmEndDate, ")
            strSB.Append(" (select Progress FROM V_IT_Scheme where ID = a.ID ) as complete, ")
            strSB.Append(" (select UserName from ATL_HD_UserGroups where a.SmFollow = ATL_HD_UserGroups.UserNo ) as SmFollow1, ")
            strSB.Append(" (select ProStatus from IT_ProStatus where ID=a.SmType) as sm1Type, ")
            strSB.Append(" (select ProStatus from IT_ProStatus where ID=a.SmStatus) as sm1Status,")
            strSB.Append(" (select ProStatus from IT_ProStatus where ID=a.Important) as important1,")
            strSB.Append(" (select Value from ATL_HD_Emergency where ATL_HD_Emergency.Value=a.Emergency) as emergency1")
            strSB.Append(" from IT_Scheme a  left join IT_Project b on a.id=b.SchemeID left join IT_Assignment c on b.id=c.PrjID ")

            '' 非管理员和全局用户只显示与自己相关数据
            If Not Isglobaluser And Not IsProjectManager Then
                strSB.Append("where a.SmPrincipal='" & UserName & "' or a.SmFollow='" & UserID & "'")
                strSB.Append("or  b.PrincipalUID='" & UserName & "' or b.FollowUID='" & UserID & "'")
                strSB.Append("or  c.AppointUid='" & UserID & "'")
            End If

            strSB.Append("group by  a.ID,a.SchemeName,a.SmPrincipal,a.SmStartDate,a.SmEndDate,a.SmFollow,a.SmType,a.SmStatus,a.Important,a.Emergency")
            strSB.Append(" order by a.ID ASC")

            dt = getDataTables(strSB.ToString())

            SetGridData = New SetGridViewDelegate(AddressOf dinbingData)

            ' Me.Invoke(SetGridData, GridControl, dt)
            Me.Invoke(SetGridData, Grid1, dt)

            dt.Dispose()
            strSB.Clear()
        Catch

        Finally
            td.Abort()
        End Try

    End Sub


    ''' <summary>
    ''' 委托传参
    ''' </summary>
    ''' <param name="GridControl"></param>
    ''' <param name="DataSource"></param>
    ''' <remarks></remarks>
    Sub dinbingData(ByVal Grid1 As DevExpress.XtraGrid.GridControl, ByVal DataSource As DataTable)

        Try
            If DataSource.Rows.Count > 0 Then
                'Grid1.Update()
                ' Grid1.Controls.Clear()

                Grid1.DataSource = DataSource

                'Grid1.MainView.PopulateColumns()
            Else
                Grid1.DataSource = Nothing
            End If

        Catch ex As Exception

        End Try
        '自动调整所有字段宽度
        GridView1.BestFitColumns()
    End Sub

    Private Sub Grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim frm As New frmProjectDetail
        frm.txtID.Text = Me.GridView1.GetFocusedRowCellValue("ID")
        frm.ShowDialog()

    End Sub

    ''' <summary>
    ''' 刷新条件
    ''' </summary>
    ''' <remarks></remarks>
    Sub ChecksFilterValue()
        '
        Dim strFilterString As String = String.Empty

        Dim lsBox As New ListBox

        'OR
        If CheckEdit1.Checked = True Then lsBox.Items.Add("[sm1Status]='进行'")
        If CheckEdit2.Checked = True Then lsBox.Items.Add("[sm1Status]='排期'")
        If CheckEdit3.Checked = True Then lsBox.Items.Add("[sm1Status]='暂停'")
        If CheckEdit4.Checked = True Then lsBox.Items.Add("[sm1Status]='立项'")
        If CheckEdit5.Checked = True Then lsBox.Items.Add("[sm1Status]='完成'")
        If CheckEdit6.Checked = True Then lsBox.Items.Add("[sm1Status]='终止'")

        For i As Integer = 0 To lsBox.Items.Count - 1

            If i = 0 Then
                strFilterString = lsBox.Items(i).ToString
            Else
                strFilterString = strFilterString & " or " & lsBox.Items(i).ToString
            End If

        Next
        'AND
        lsBox.Items.Clear()

        If Len(txtLike.Text) > 0 And chkName.Checked = True Then
            lsBox.Items.Add("[SchemeName] like '%" & txtLike.Text & "%'")
        ElseIf Len(txtLike.Text) = 0 And chkName.Checked = True Then
            strFilterString = ""
        End If

        For i As Integer = 0 To lsBox.Items.Count - 1

            If Len(strFilterString) = 0 Then
                strFilterString = lsBox.Items(i).ToString
            Else
                strFilterString = strFilterString & " AND " & lsBox.Items(i).ToString
            End If

        Next

        GridView1.ActiveFilterString = strFilterString
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never

    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        ChecksFilterValue()
    End Sub

    Private Sub CheckEdit2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckEdit2.CheckedChanged
        ChecksFilterValue()
    End Sub

    Private Sub CheckEdit3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit3.CheckedChanged
        ChecksFilterValue()
    End Sub

    Private Sub CheckEdit4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit4.CheckedChanged
        ChecksFilterValue()
    End Sub

    Private Sub CheckEdit5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit5.CheckedChanged
        ChecksFilterValue()
    End Sub

    Private Sub CheckEdit6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit6.CheckedChanged
        ChecksFilterValue()
    End Sub

    ''' <summary>
    ''' 给过期的和紧急度高的项目特殊颜色
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GridView1_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs)

        If e.Column.FieldName = "sm1Status" Then

            Select Case e.DisplayText 'e.CellValue

                Case "立项"
                    e.Appearance.ForeColor = Color.Tan
                Case "排期"
                    e.Appearance.ForeColor = Color.DarkTurquoise
                Case "进行"

                    If Date.Today.Date > Format$(GridView1.GetRowCellValue(e.RowHandle, "SmEndDate"), "short date") Then
                        ' e.Appearance.ForeColor = Color.Red
                        '' e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
                    Else
                        ' e.Appearance.ForeColor = Color.LimeGreen
                    End If

                Case "暂停"
                    e.Appearance.ForeColor = Color.DarkOrange
                Case "终止"
                    e.Appearance.ForeColor = Color.Crimson
                Case "完成"
                    e.Appearance.ForeColor = Color.Blue
            End Select

        End If

        If e.Column.FieldName = "emergency1" Then
            If e.CellValue >= 40 Then
                ''e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
                e.Appearance.ForeColor = Color.Red
            End If
        End If

    End Sub

    Private Sub RefreshRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshRToolStripMenuItem.Click
        LoadProjectData()
    End Sub
    '' 导出Excel
    Private Sub OutAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutAToolStripMenuItem.Click

        If GridView1.RowCount = 0 Then Exit Sub

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Title = "导出Excel"
        saveFileDialog.Filter = "Excel2003文件(*.xls)|*.xls"
        Dim dialogResult__1 As DialogResult = saveFileDialog.ShowDialog(Me)
        If dialogResult__1 = Windows.Forms.DialogResult.OK Then
            GridView1.BestFitColumns()
            GridView1.ExportToXls(saveFileDialog.FileName)
            MessageBox.Show("保存成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information)
            StartApp(saveFileDialog.FileName, False)
        End If

    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged

        If e.Page.Name = "XtraTabControl3" Then
            strGanttType = "详细"
            strProjectID = Me.GridView1.GetFocusedRowCellValue("ID")
            dteDate = CDate(Me.GridView1.GetFocusedRowCellValue("SmStartDate"))
            Dim xx As New mdlProjectSchedule
            xx.txtID.Text = Me.GridView1.GetFocusedRowCellValue("ID")
            xx.txtDate.Text = Format(CDate(Me.GridView1.GetFocusedRowCellValue("SmStartDate")), "yyyy-MM-dd")
            xx.GroupControl1.Text = Me.GridView1.GetFocusedRowCellValue("SchemeName")
            GroupControl2.Controls.Clear()
            xx.Dock = System.Windows.Forms.DockStyle.Fill
            GroupControl2.Controls.Add(xx)
        End If

    End Sub


    Private Sub txtLike_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLike.EditValueChanged

        If Len(txtLike.Text) > 0 Then
            chkName.Checked = True
            'ChecksFilterValue()
        Else
            chkName.Checked = False
        End If
    End Sub

    Private Sub chkName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkName.CheckedChanged

        If chkName.Checked = True Then
            CheckEdit1.Checked = False
            CheckEdit2.Checked = False
            CheckEdit3.Checked = False
            CheckEdit4.Checked = False
            CheckEdit5.Checked = False
            CheckEdit6.Checked = False
            ChecksFilterValue()
        End If

    End Sub
    Private Sub txtLike_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLike.KeyDown

        If e.KeyCode = Keys.Enter Then
            ChecksFilterValue()
        End If

    End Sub

    Private Sub pupAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pupAdd.Click
        isRefresh = False
        Edit = False
        Dim xx As New frmProjectEdit
        xx.Width = 447
        xx.Height = 484
        xx.ShowDialog()
        '' 决定是否需要刷新数据
        If Not isRefresh Then Exit Sub
        LoadProjectData()
    End Sub

    Private Sub pupEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pupEdit.Click

        'If GridView1.GetFocusedRowCellValue("sm1Status") = "完成" Or GridView1.GetFocusedRowCellValue("sm1Status") = "进行" Then
        '    MessageBox.Show("已完成或进行中的项目不能修改，如需修改请选择变更完成日期功能项！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        isRefresh = False
        Edit = True
        Dim xx As New frmProjectEdit
        xx.Width = 447
        xx.cmdSave.Visible = True
        xx.cmdExit.Visible = True
        xx.Height = 484
        xx.labID.Text = GridView1.GetFocusedRowCellValue("ID")
        xx.ShowDialog()
        '' 决定是否需要刷新数据
        If Not isRefresh Then Exit Sub
        LoadProjectData()
    End Sub

    Private Sub Grid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim PrjStatus As String = GridView1.GetFocusedRowCellValue("sm1Status").ToString
        If GridView1.GetFocusedRowCellValue("sm1Status") = "完成" Or PrjStatus = "进行" Then
            pupEdit.Visible = False
        Else
            If (GridView1.GetFocusedRowCellValue("SmPrincipal") = UserName) Then
                pupEdit.Visible = True
            Else
                pupEdit.Visible = False
            End If
        End If

        Dim endDate As Date = GridView1.GetFocusedRowCellValue("SmEndDate")
        If PrjStatus = "进行" And endDate < Date.Now Then
            Reply.Visible = True
        Else
            Reply.Visible = False
        End If
        '' 加载超期明细
        Dim id As UInt16 = GridView1.GetFocusedRowCellValue("ID")
        If id > 0 Then
            loadExtendedData(id)
        End If

        '' 加载文档信息
        Dim tabPage As New FTPFilesManager
        GroupControl1.Controls.Clear()
        tabPage.Dock = System.Windows.Forms.DockStyle.Fill
        tabPage.SimpleButton1.Visible = False
        tabPage.xtype = True
        tabPage.SchemeName = GridView1.GetFocusedRowCellValue("SchemeName")
        GroupControl1.Controls.Add(tabPage)

        ContextMenuStrip1.Show(Grid1, MousePosition.X + 200, MousePosition.Y)

    End Sub
    '' 超期回覆
    Private Sub Reply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reply.Click

        isRefresh = False
        Edit = True
        Dim xx As New frmProjectEdit
        xx.replyExtended = True
        xx.cmdSave.Visible = False
        xx.cmdExit.Visible = False
        xx.labID.Text = GridView1.GetFocusedRowCellValue("ID")
        xx.ShowDialog()
        '' 决定是否需要刷新数据
        If Not isRefresh Then Exit Sub
        LoadProjectData()

    End Sub

    Private Sub GridView2_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GridView2.CustomDrawCell
        CustomDrawCell(e)
    End Sub

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Private Sub Grid1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim PrjStatus As String = GridView1.GetFocusedRowCellValue("sm1Status")
        If GridView1.GetFocusedRowCellValue("sm1Status") = "完成" Or PrjStatus = "进行" Then
            pupEdit.Enabled = False

        End If

        If (GridView1.GetFocusedRowCellValue("SmPrincipal") = UserName) Or IsProjectManager Then
            Reply.Enabled = True
            OutAToolStripMenuItem.Enabled = True
            StripMenuItem.Enabled = True
        Else
            Reply.Enabled = False
            OutAToolStripMenuItem.Enabled = False
            StripMenuItem.Enabled = False
        End If
        If IsProjectManager Or UserID = "09120026" Then
            pupAdd.Enabled = True
            pupEdit.Enabled = True
            stopprj.Enabled = True
            endprj.Enabled = True
        Else
            pupAdd.Enabled = False
            pupEdit.Enabled = False
            stopprj.Enabled = False
            endprj.Enabled = False
        End If
        If (GridView1.GetFocusedRowCellValue("SmPrincipal") = UserName) Or IsProjectManager Or Isglobaluser Then
            OutAToolStripMenuItem.Enabled = True
        Else
            OutAToolStripMenuItem.Enabled = False
        End If
        Dim endDate As Date = GridView1.GetFocusedRowCellValue("SmEndDate")
        If PrjStatus = "进行" And endDate < Date.Now And
            ((GridView1.GetFocusedRowCellValue("SmPrincipal") = UserName) Or IsProjectManager) Then
            Reply.Enabled = True
        Else
            Reply.Enabled = False
        End If
        '' 加载超期明细
        Dim id As UInt16 = GridView1.GetFocusedRowCellValue("ID")
        If id > 0 Then
            loadExtendedData(id)
        End If

        '' 加载文档信息
        Dim tabPage As New FTPFilesManager
        GroupControl1.Controls.Clear()
        tabPage.Dock = System.Windows.Forms.DockStyle.Fill
        tabPage.SimpleButton1.Visible = False
        tabPage.xtype = True
        tabPage.SchemeName = GridView1.GetFocusedRowCellValue("SchemeName")
        GroupControl1.Controls.Add(tabPage)

        ' ContextMenuStrip1.Show(Grid1, MousePosition.X + 200, MousePosition.Y)

    End Sub


    Private Sub ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StripMenuItem.Click
        isRefresh = False
        Edit = True
        Dim xx As New frmProjectEdit(1)
        xx.replyExtended = True
        xx.cmdSave.Visible = False
        xx.cmdExit.Visible = False
        xx.labID.Text = GridView1.GetFocusedRowCellValue("ID")
        xx.ShowDialog()
        '' 决定是否需要刷新数据
        If Not isRefresh Then Exit Sub
        LoadProjectData()
    End Sub

    Private Sub endprj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles endprj.Click
        Dim sql As String = Nothing

        '设置项目为终止



        If MessageBox.Show("您确定需要终止此项目吗?", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

            sql = "UPDATE  IT_Scheme  set SmStatus='19' WHERE ID=" & GridView1.GetFocusedRowCellValue("ID")
            Try
                ExecuteNonQuery(sql)
                LoadProjectData()
                'MessageBox.Show("此项目已终止!")
            Catch ex As Exception
                MessageBox.Show("终止此项目失败!")
            End Try

        End If
    End Sub

    Private Sub stopprj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stopprj.Click


        Dim sql As String = Nothing
        If MessageBox.Show("您确定需要暂停此项目吗?", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

            sql = "UPDATE  IT_Scheme  set SmStatus='18' WHERE ID=" & GridView1.GetFocusedRowCellValue("ID")

            Try
                ExecuteNonQuery(Sql)
                LoadProjectData()
                'MessageBox.Show("此项目暂停!")
            Catch ex As Exception
                MessageBox.Show("暂停此项目失败!")
            End Try
        End If

    End Sub
End Class
