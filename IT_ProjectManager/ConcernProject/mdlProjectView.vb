Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class mdlProjectView

    Dim td As Threading.Thread = Nothing

    Dim ProjId As String = Nothing

    Private Sub mdlProjectView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Application.DoEvents()

        td = New Threading.Thread(AddressOf LoadProjectData)
        td.Start()

    End Sub

    ''' <summary>
    ''' 导入项目资料
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadProjectData()

        Application.DoEvents()

        Dim dt As New DataTable

        Dim strSB As New System.Text.StringBuilder

        strSB.Append("select * ,(select Progress FROM V_IT_Scheme where V_IT_Scheme.ID = IT_Scheme.ID ) as complete,")
        strSB.Append(" (select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Scheme.SmFollow = ATL_HD_UserGroups.UserNo ) as SmFollow1,")
        strSB.Append(" (select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_Scheme.SmType) as sm1Type,")
        strSB.Append(" (select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_Scheme.SmStatus) as sm1Status,")
        strSB.Append(" (select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_Scheme.Important) as important1,")
        strSB.Append(" (select ATL_HD_Emergency.Value from ATL_HD_Emergency where ATL_HD_Emergency.Value=IT_Scheme.Emergency) as emergency1 ")
        strSB.Append(" from IT_Scheme where ID in (select SchemeID from IT_Project_Attention where UserNO='" & UserID & "')")

        Try

            dt = getDataTables(strSB.ToString())
            strSB.Clear()
            SetGridData = New SetGridViewDelegate(AddressOf Me.bindingData)

            Me.Invoke(SetGridData, Grid1, dt)

            Threading.Thread.Sleep(100)

            dt.Dispose()

        Catch ex As Exception
            ' MessageBox.Show("线程收发以下异常:" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            td.Abort()
        End Try

    End Sub

    ''' <summary>
    ''' 导入项目资料－所有
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadProjectDataFull()

        Try

            Application.DoEvents()

            Dim dt As New DataTable
            Dim strSB As New System.Text.StringBuilder

            strSB.Append("select * ,(select Progress FROM V_IT_Scheme where V_IT_Scheme.ID = IT_Scheme.ID ) as complete,")
            strSB.Append(" (select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Scheme.SmFollow = ATL_HD_UserGroups.UserNo ) as SmFollow1,")
            strSB.Append(" (select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_Scheme.SmType) as sm1Type,")
            strSB.Append(" (select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_Scheme.SmStatus) as sm1Status, ")
            strSB.Append(" (select IT_ProStatus.ProStatus from IT_ProStatus where IT_ProStatus.ID=IT_Scheme.Important) as important1, ")
            strSB.Append("(select ATL_HD_Emergency.Value from ATL_HD_Emergency where ATL_HD_Emergency.Value=IT_Scheme.Emergency) as emergency1 ")
            strSB.Append(" from IT_Scheme where SmStatus not in ('17','19') ")

            dt = getDataTables(strSB.ToString())

            SetGridData = New SetGridViewDelegate(AddressOf Me.bindingData)

            Me.Invoke(SetGridData, Grid1, dt)

            Threading.Thread.Sleep(100)

            dt.Dispose()

            strSB.Clear()

        Catch ex As Exception
            'MessageBox.Show("线程收发以下异常:" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            td.Abort()
        End Try

    End Sub
    ''' <summary>
    ''' 导入项目参与人员资料
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadProjectPersonnelData()

        Application.DoEvents()

        Try

            Dim dt As New DataTable

            Dim strSB As New System.Text.StringBuilder

            strSB.Append(" select followuid,SUM(cumulativeTime) as cumulativeTime ,")
            strSB.Append(" (select username from ATL_HD_UserGroups where ATL_HD_UserGroups.UserNo=IT_Schedule.FollowUID ) as UserName ")
            strSB.Append(" from IT_Schedule ")
            strSB.Append(" where AssID in (select ID from V_IT_Assignment_Demand where SchemeID='" & ProjId & "') ")
            strSB.Append(" group by FollowUID ")

            dt = getDataTables(strSB.ToString())

            SetGridData = New SetGridViewDelegate(AddressOf Me.bindingData)

            Me.Invoke(SetGridData, Grid2, dt)

            Threading.Thread.Sleep(100)

            dt.Dispose()
            strSB.Clear()

        Catch ex As Exception
            ' MessageBox.Show("线程收发以下异常:" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            td.Abort()
        End Try

    End Sub
    ''' <summary>
    ''' 委托处理
    ''' </summary>
    ''' <param name="gridControl"></param>
    ''' <param name="dt"></param>
    ''' <remarks></remarks>
    Sub bindingData(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal dt As DataTable)

        Try

            gridControl.DataSource = Nothing

            If Not dt Is DBNull.Value Then

                If dt.Rows.Count > 0 Then
                    gridControl.DataSource = dt
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("委托处理引发以下:" & vbCrLf & ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Grid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid1.Click

        '项目视图
        If GridView1.RowCount = 0 Then Exit Sub

        Me.Cursor = Cursors.WaitCursor

        Grid1.Enabled = False

        ProjId = Me.GridView1.GetFocusedRowCellValue("ID")

        Dim xx As New mdlProjectSchedule

        GroupControl2.Controls.Clear()

        xx.Dock = System.Windows.Forms.DockStyle.Fill
        xx.txtID.Text = ProjId
        xx.GroupControl1.Text = Me.GridView1.GetFocusedRowCellValue("SchemeName")
        xx.txtDate.Text = Format(Me.GridView1.GetFocusedRowCellValue("SmStartDate"), "yyyy-MM-dd")
        GroupControl2.Controls.Add(xx)

        '' 刷新数据
        td = New Threading.Thread(AddressOf LoadProjectPersonnelData)
        td.Start()

        Me.Cursor = Cursors.Default
        Me.Grid1.Enabled = True

    End Sub

    Private Sub Grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick

        If GridView1.RowCount = 0 Then Exit Sub

        frmProjectDetail.txtID.Text = ProjId
        frmProjectDetail.ShowDialog()

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        If RadioButton1.Checked = True Then

            td = New Threading.Thread(AddressOf LoadProjectData)
            td.Start()

        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked = True Then

            td = New Threading.Thread(AddressOf LoadProjectDataFull)
            td.Start()

        End If

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click

        frmSelectProject2.ShowDialog()

        If RadioButton1.Checked = True Then

            td = New Threading.Thread(AddressOf LoadProjectData)
            td.Start()

        End If

    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click

        If RadioButton1.Checked = False Or GridView1.RowCount = 0 Then Exit Sub

        DelData()

        If RadioButton1.Checked = True Then
            '隐藏此记录
            GridView1.DeleteSelectedRows()
        End If

    End Sub

    ''' <summary>
    ''' 删除关注项目
    ''' </summary>
    ''' <remarks></remarks>
    Sub DelData()

        Dim sql As String = Nothing

        sql = "DELETE  FROM IT_Project_Attention WHERE SchemeID='" & GridView1.GetFocusedRowCellValue("ID") & "' AND " _
            & "UserNo='" & UserID & "'"

        Try
            ExecuteNonQuery(sql)
        Catch
            MessageBox.Show("移除指定关注项目失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#Region "GRID 绘制颜色"

    Private Sub GridView2_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GridView2.CustomDrawCell
        CustomDrawCell(e)
    End Sub

    Private Sub GridView1_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GridView1.CustomDrawCell
        CustomDrawCell(e)
    End Sub

#End Region

End Class