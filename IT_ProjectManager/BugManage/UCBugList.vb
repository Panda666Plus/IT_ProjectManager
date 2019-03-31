Public Class UCBugList

    ''' <summary>
    ''' 加载Bug率
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadData()

        Dim strSB As New System.Text.StringBuilder

        Dim dt As String = Format(DateEdit1.EditValue, "yyyy-MM-dd")

        strSB.Append("select distinct  ")
        strSB.Append(" (select  count(IT_DevelopBugManager.AutoID) FROM IT_DevelopBugManager ")
        strSB.Append(" where  IT_SystemNameManager.SystemName =IT_DevelopBugManager.SysProName ) as TotalError, ")
        strSB.Append(" (select  count(IT_DevelopBugManager.AutoID) FROM IT_DevelopBugManager ")
        strSB.Append(" where(IT_SystemNameManager.SystemName = IT_DevelopBugManager.SysProName) ")
        strSB.Append(" and (month(IT_DevelopBugManager.CreateTime)=month('" & dt & "'))) as TotalMonthsError,")
        strSB.Append(" datediff(month,StartDate,'" & dt & "') as TotalMonths, ")
        strSB.Append(" IT_SystemNameManager.*  from IT_SystemNameManager, IT_DevelopBugManager ")

        Dim dataTable As New DataTable

        dataTable = getDataTables(strSB.ToString())

        If dataTable.Rows.Count > 0 Then

            SysList.DataSource = dataTable

        Else
            SysList.DataSource = Nothing

        End If
        strSB.Clear()
        dataTable.Dispose()
    End Sub



    '' 绘制行颜色
    Private Sub GridView1_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GridView1.CustomDrawCell
        CustomDrawCell(e)
    End Sub

    ''导出Excel
    Private Sub ToExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToExcel.Click

        If GridView1.RowCount <= 0 Then Exit Sub

        Dim save As New SaveFileDialog
        save.Filter = "Excel 2007(*.xlsx)|*.xlsx"
        save.Title = "系统清单导出"
        save.FileName = CDate(DateEdit1.EditValue).Date.ToString("yyyyMMdd") & "份系统清单明细.xlsx"
        If save.ShowDialog = DialogResult.OK Then
            GridView1.ExportToXlsx(save.FileName)
            MessageBox.Show("导出成功！", "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            StartApp(save.FileName, False)
        End If
    End Sub

    Private Sub UCBugList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateEdit1.EditValue = Date.Now()
        loadData()
        AddHandler DateEdit1.EditValueChanged, AddressOf DateEditValueChanged
    End Sub

    '' 查询
    Sub DateEditValueChanged()
        If DateEdit1.EditValue <> Nothing Then
            loadData()
        End If
    End Sub
End Class
