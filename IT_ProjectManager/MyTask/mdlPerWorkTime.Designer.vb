<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdlPerWorkTime
    Inherits System.Windows.Forms.UserControl

    'UserControl 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim PointOptions1 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim PointOptions2 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim PointOptions3 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim PointOptions4 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim SideBySideBarSeriesLabel3 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim PointOptions5 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Me.dst = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        CType(Me.dst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dst
        '
        Me.dst.DataSetName = "NewDataSet"
        Me.dst.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable2})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "CreatedDate"
        Me.DataColumn1.ColumnName = "CreatedDate"
        Me.DataColumn1.DataType = GetType(Date)
        '
        'DataColumn2
        '
        Me.DataColumn2.Caption = "Value"
        Me.DataColumn2.ColumnName = "Value"
        Me.DataColumn2.DataType = GetType(Integer)
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn3, Me.DataColumn4})
        Me.DataTable2.TableName = "ToDo"
        '
        'DataColumn3
        '
        Me.DataColumn3.Caption = "CreatedDate"
        Me.DataColumn3.ColumnName = "CreatedDate"
        Me.DataColumn3.DataType = GetType(Date)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Value"
        Me.DataColumn4.DataType = GetType(Integer)
        '
        'ChartControl1
        '
        Me.ChartControl1.AppearanceNameSerializable = "Gray"
        Me.ChartControl1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ChartControl1.CrosshairOptions.ArgumentLineColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ChartControl1.CrosshairOptions.ValueLineColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ChartControl1.DataSource = Me.dst
        XyDiagram1.AxisX.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        XyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram1.AxisX.Range.SideMarginsEnabled = True
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        XyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram1.AxisY.Range.SideMarginsEnabled = True
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.PaneDistance = 11
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl1.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.PaletteName = "Median"
        Me.ChartControl1.SeriesDataMember = "Table1.CreatedDate"
        Series1.ArgumentDataMember = "Table1.CreatedDate"
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        SideBySideBarSeriesLabel1.Font = New System.Drawing.Font("Microsoft JhengHei", 8.0!)
        SideBySideBarSeriesLabel1.LineVisible = True
        PointOptions1.ArgumentDateTimeOptions.Format = DevExpress.XtraCharts.DateTimeFormat.MonthAndDay
        PointOptions1.ArgumentDateTimeOptions.FormatString = "d"
        PointOptions1.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PointOptions1.Pattern = "{V} H"
        PointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        SideBySideBarSeriesLabel1.PointOptions = PointOptions1
        SideBySideBarSeriesLabel1.ShowForZeroValues = True
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        PointOptions2.ArgumentDateTimeOptions.FormatString = "MM/dd"
        PointOptions2.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PointOptions2.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Series1.LegendPointOptions = PointOptions2
        Series1.LegendText = "項目"
        Series1.Name = "Project"
        Series1.SynchronizePointOptions = False
        Series1.ValueDataMembersSerializable = "Table1.Value"
        Series2.ArgumentDataMember = "ToDo.CreatedDate"
        Series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        SideBySideBarSeriesLabel2.LineVisible = True
        PointOptions3.ArgumentDateTimeOptions.Format = DevExpress.XtraCharts.DateTimeFormat.MonthAndDay
        PointOptions3.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PointOptions3.Pattern = "{V}P"
        PointOptions3.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        SideBySideBarSeriesLabel2.PointOptions = PointOptions3
        Series2.Label = SideBySideBarSeriesLabel2
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        PointOptions4.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PointOptions4.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Series2.LegendPointOptions = PointOptions4
        Series2.LegendText = "其他事项"
        Series2.Name = "ToDo"
        Series2.SynchronizePointOptions = False
        Series2.ValueDataMembersSerializable = "ToDo.Value"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
        SideBySideBarSeriesLabel3.LineVisible = True
        PointOptions5.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PointOptions5.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        SideBySideBarSeriesLabel3.PointOptions = PointOptions5
        Me.ChartControl1.SeriesTemplate.Label = SideBySideBarSeriesLabel3
        Me.ChartControl1.SeriesTemplate.Visible = False
        Me.ChartControl1.Size = New System.Drawing.Size(649, 355)
        Me.ChartControl1.TabIndex = 2
        '
        'mdlPerWorkTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ChartControl1)
        Me.Name = "mdlPerWorkTime"
        Me.Size = New System.Drawing.Size(649, 355)
        CType(Me.dst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dst As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn

End Class
