Imports System.IO
Imports System.Text

''' <summary>
''' 增加项目名称
''' </summary>
''' <remarks></remarks>
Public Class frmProjectManage

    Public NodeID As Integer
    ''' <summary>
    ''' 操作状态
    ''' true==Add
    ''' False=Edit
    ''' </summary>
    ''' <remarks></remarks>
    Public IsEdit As Boolean = False

    Public Level As Integer

    Public oldNodeName As String
    ''' <summary>
    ''' 增加类型，true:项目，false:模块
    ''' </summary>
    ''' <remarks></remarks>
    Public xtype As Boolean = True

    Private Sub bt_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_OK.Click

        If txtPnmae.Text.Trim() = Nothing Then
            txtPnmae.Focus()
            MessageBox.Show("请输入项目名称？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim Sql As New StringBuilder
        Dim MaxNodeid As Integer

        '' 获取所有项目
        Dim ProList As New StringBuilder

        For i As Integer = 0 To ProjectList.Items.Count - 1

            ProList.Append(ProjectList.Items(i).ToString().Trim() & ",")

        Next

        If Not IsEdit Then

            '' 检查此项目是否已经存在
            Dim check_sql As String = "select ProjectName from IT_FilesManager where ProjectName='" & txtPnmae.Text.Trim() & "'"
            Dim dt As New DataTable
            dt = getDataTables(check_sql)

            If dt.Rows.Count > 0 Then
                MessageBox.Show("增加的项目名称已存在，请确认？" & vbCrLf & "项目名称：" + txtPnmae.Text.Trim(), "项目管理系统",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            '' 插入新数据
            Sql.Append("insert into IT_FilesManager values('" & NodeID & "','" & Level & "','" & txtPnmae.Text.Trim() & _
                       "','" & ProList.ToString() & "','" & txttooltip.Text.Trim() & "')")

            '' 执行sql语句
            If ExecuteNonQuery(Sql.ToString()) < 1 Then
                MessageBox.Show("操作失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Else

                Sql.Clear()

                If xtype Then
                    '' 取得最大的nodeid
                    Dim select_sql As String = Nothing
                    select_sql = "select max(Nodeid) as MaxNodeid from IT_FilesManager"
                    Dim temptb As New DataTable
                    temptb = getDataTables(select_sql)
                    If temptb.Rows.Count < 1 Then
                        MessageBox.Show("取得最大节点值失败，程序无法自动生成子项目", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    Else
                        MaxNodeid = Convert.ToInt16(temptb.Rows(0)(0).ToString())
                    End If

                    '' 自动生成四个子项目
                    Sql.Append("insert into IT_FilesManager values('" & MaxNodeid & "','" & Level + 1 & "','系统需求表','','用於分析整理客户需求部分')")
                    Sql.Append("insert into IT_FilesManager values('" & MaxNodeid & "','" & Level + 1 & "','系统需求实现分析表','','针对系统需求表进行详细分析如何实现客户需求的一个概括性描述')")
                    Sql.Append("insert into IT_FilesManager values('" & MaxNodeid & "','" & Level + 1 & "','数据字典表结构','','数据字典表结构')")
                    Sql.Append("insert into IT_FilesManager values('" & MaxNodeid & "','" & Level + 1 & "','文档管理业务流程图','','文档管理业务流程图')")
                    Sql.Append("insert into IT_FilesManager values('" & MaxNodeid & "','" & Level + 1 & "','模块间功能流程图','','模块间功能流程图')")

                    '' 执行sql语句
                    'If ExecuteNonQuery(Sql.ToString()) < 1 Then
                    '    MessageBox.Show("操作失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'End If

                End If

                ''MessageBox.Show("项目名称【" & txtPnmae.Text.Trim() & "】操作成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()

            End If

        Else
            '' 更新数据
            Sql.Append("update IT_FilesManager set ProjectName='" & txtPnmae.Text.Trim() & "',SchemeName='" & ProList.ToString() & _
                       "' where NodeID='" & NodeID & "' and LevelId='" & Level & "' and  ProjectName='" & oldNodeName & "'")

            '' 执行sql语句
            If ExecuteNonQuery(Sql.ToString()) < 1 Then
                MessageBox.Show("操作失败？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                '' MessageBox.Show("项目名称【" & txtPnmae.Text.Trim() & "】操作成功！", "项目管理系统",
                ''                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If

        End If

    End Sub

    Private Sub btExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExit.Click
        Me.Close()

    End Sub

    '' 双击移除项目
    Private Sub ListBoxControl1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ProjectList.MouseDoubleClick
        If ProjectList.SelectedIndex <> -1 Then
            ProjectList.Items.Remove(ProjectList.SelectedItem)
        End If
    End Sub
    '' 载入所有项目名称
    Private Sub frmProjectManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim sql As String = "select SchemeName  from IT_Scheme"
        Dim dt As New DataTable
        dt = getDataTables(sql)
        LUERelevance.Properties.DataSource = dt
        LUERelevance.Properties.DisplayMember = "SchemeName"
        LUERelevance.Properties.ValueMember = "SchemeName"

        '' 修改时加载项目名称
        If IsEdit And Level = 0 Then

            Dim list_sql As String = "select SchemeName from  IT_FilesManager  where NodeID='" & NodeID &
                "' and LevelID='" & Level & "' and ProjectName='" & oldNodeName & "'"

            Dim dt_list As New DataTable
            Dim SchemeName As String() = Nothing
            dt_list = getDataTables(list_sql)

            If dt_list.Rows.Count > 0 Then

                For i As Integer = 0 To dt_list.Rows.Count - 1 Step 1

                    SchemeName = dt_list.Rows(i)(0).ToString().Trim().Split(",")

                    For Each Name As String In SchemeName
                        If Name.Trim() <> Nothing Then
                            ProjectList.Items.Add(Name)
                        End If
                    Next

                Next

            End If

        ElseIf xtype And Not IsEdit Then

            ProjectList.Enabled = True
            LUERelevance.Enabled = True

        Else

            ProjectList.Enabled = False
            LUERelevance.Enabled = False

        End If

    End Sub

    Private Sub LUERelevance_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LUERelevance.EditValueChanged

        Dim checkProList As String = Nothing
        Dim selectItem As String = LUERelevance.Text

        For i As Integer = 0 To ProjectList.Items.Count - 1
            If selectItem = ProjectList.Items(i).ToString() Then
                MessageBox.Show("项目" & ProjectList.Items(1) & "】已经存在？", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next

        ProjectList.Items.Add(selectItem)

    End Sub
End Class