Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb


Public Class frmProjectSubDetail

    ''' <summary>
    ''' 导入数据
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadAssData()

        Dim dt As New DataTable
        Dim sql As String = Nothing
        sql = "SELECT IT_Assignment.*,ATL_HD_UserGroups.UserName FROM IT_Assignment INNER JOIN ATL_HD_UserGroups ON IT_Assignment.AppointUid = ATL_HD_UserGroups.UserNo where IT_Assignment.PrjID='" & txtID.Text & "'"
        dt = getDataTables(sql)

        If dt.Rows.Count = 0 Then
            GridAss.DataSource = Nothing
        End If

        GridAss.DataSource = dt
        dt.Dispose()

    End Sub

    ''' <summary>
    ''' 导入选择任务的详细资料
    ''' </summary>
    ''' <param name="strID"></param>
    ''' <remarks></remarks>
    Sub LoadSelectAss(ByVal strID As String)

        Dim dt As New DataTable
        Dim sql As String = Nothing
        sql = "select FollowSch,FollowDate,CumulativeTime,(select ATL_HD_UserGroups.UserName from ATL_HD_UserGroups where IT_Schedule.FollowUID = ATL_HD_UserGroups.UserNo ) as FollowID ,Remark from IT_Schedule where AssID = '" & strID & "'"
        dt = getDataTables(sql)

        Grid1.DataSource = dt
        dt.Dispose()

    End Sub

    ''' <summary>
    ''' 导入项目主资料
    ''' </summary>
    ''' <param name="strID"></param>
    ''' <remarks></remarks>
    Sub LoadProjectData(ByVal strID As String)

        Dim strsql As String

        strsql = "select * from IT_Project where  ID='" & strID & "'"
        Dim dt As New DataTable

        Try
            dt = getDataTables(strsql)

            txtPrjName.Text = dt.Rows(0)("PrjName")
            txtPreStartDate.Text = Format(dt.Rows(0)("PreStatDate"), "yyyy-MM-dd")
            txtPrjEndDate.Text = Format(dt.Rows(0)("PreEndDate"), "yyyy-MM-dd")
            txtPriority.Text = dt.Rows(0)("Prioity")
            editExplain.Text = dt.Rows(0)("Explain")
        Catch

        Finally
            dt.Dispose()
        End Try
    End Sub

    Private Sub frmProjectSubDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadProjectData(txtID.Text)
        LoadAssData()
    End Sub

    Private Sub GridAss_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridAss.Click

        If GridView1.RowCount = 0 Or Len(GridView1.GetFocusedRowCellValue("ID")) = 0 Then Exit Sub
        LoadSelectAss(GridView1.GetFocusedRowCellValue("ID"))

    End Sub

    Private Sub pupAddTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pupAddTask.Click
        isRefresh = False
        '增加任务
        Edit = False
        frmProjectTasks.txtID.Text = txtID.Text
        frmProjectTasks.labName.Text = txtPrjName.Text   '模块名称
        frmProjectTasks.ShowDialog()

        '' 决定是否需要刷新数据
        If Not isRefresh Then Exit Sub

        '刷新数据
        LoadAssData()
    End Sub

    Private Sub pupEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pupEdit.Click

        '修改
        If GridView1.RowCount = 0 Then Exit Sub
        isRefresh = False
        Edit = True
        '任务,减222222222
        frmProjectTasks.txtID.Text = GridView1.GetFocusedRowCellValue("ID")  '项目ID
        frmProjectTasks.labName.Text = txtPrjName.Text     '项目名称
        frmProjectTasks.ShowDialog()
        '' 决定是否需要刷新数据
        If Not isRefresh Then Exit Sub
        '刷新数据
        LoadAssData()

    End Sub
End Class