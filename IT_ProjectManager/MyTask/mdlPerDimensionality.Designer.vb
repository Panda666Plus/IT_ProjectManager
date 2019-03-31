<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdlPerDimensionality
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
        Dim RadarDiagram1 As DevExpress.XtraCharts.RadarDiagram = New DevExpress.XtraCharts.RadarDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim RadarPointSeriesLabel1 As DevExpress.XtraCharts.RadarPointSeriesLabel = New DevExpress.XtraCharts.RadarPointSeriesLabel()
        Dim PointOptions1 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim PointOptions2 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim RadarAreaSeriesView1 As DevExpress.XtraCharts.RadarAreaSeriesView = New DevExpress.XtraCharts.RadarAreaSeriesView()
        Dim RadarPointSeriesLabel2 As DevExpress.XtraCharts.RadarPointSeriesLabel = New DevExpress.XtraCharts.RadarPointSeriesLabel()
        Dim PointOptions3 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim PointOptions4 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim RadarAreaSeriesView2 As DevExpress.XtraCharts.RadarAreaSeriesView = New DevExpress.XtraCharts.RadarAreaSeriesView()
        Me.ChartControl2 = New DevExpress.XtraCharts.ChartControl()
        Me.dst = New System.Data.DataSet()
        Me.DataTable3 = New System.Data.DataTable()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RadarDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RadarPointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RadarAreaSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RadarPointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RadarAreaSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartControl2
        '
        Me.ChartControl2.AppearanceNameSerializable = "Chameleon"
        Me.ChartControl2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ChartControl2.BorderOptions.Visible = False
        Me.ChartControl2.CrosshairOptions.ArgumentLineColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ChartControl2.CrosshairOptions.ValueLineColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ChartControl2.DataSource = Me.dst
        RadarDiagram1.AxisX.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        RadarDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = False
        RadarDiagram1.AxisY.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        RadarDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
        RadarDiagram1.AxisY.Range.SideMarginsEnabled = True
        RadarDiagram1.BorderVisible = False
        Me.ChartControl2.Diagram = RadarDiagram1
        Me.ChartControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl2.EmptyChartText.Antialiasing = False
        Me.ChartControl2.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl2.Name = "ChartControl2"
        Series1.ArgumentDataMember = "GS.Name"
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        RadarPointSeriesLabel1.Font = New System.Drawing.Font("微軟正黑體", 8.0!)
        RadarPointSeriesLabel1.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        RadarPointSeriesLabel1.LineLength = 30
        RadarPointSeriesLabel1.LineVisible = True
        PointOptions1.ArgumentDateTimeOptions.Format = DevExpress.XtraCharts.DateTimeFormat.MonthAndDay
        PointOptions1.ArgumentDateTimeOptions.FormatString = "d"
        PointOptions1.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        RadarPointSeriesLabel1.PointOptions = PointOptions1
        RadarPointSeriesLabel1.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Series1.Label = RadarPointSeriesLabel1
        PointOptions2.ArgumentDateTimeOptions.FormatString = "MM/dd"
        PointOptions2.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PointOptions2.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
        PointOptions2.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Series1.LegendPointOptions = PointOptions2
        Series1.Name = "Series 4"
        Series1.ShowInLegend = False
        Series1.SynchronizePointOptions = False
        Series1.ValueDataMembersSerializable = "GS.Value"
        RadarAreaSeriesView1.MarkerOptions.BorderVisible = False
        'RadarAreaSeriesView1.MarkerOptions.Visible = True
        RadarAreaSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.View = RadarAreaSeriesView1
        Me.ChartControl2.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.ChartControl2.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        RadarPointSeriesLabel2.LineVisible = True
        PointOptions3.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PointOptions3.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        RadarPointSeriesLabel2.PointOptions = PointOptions3
        Me.ChartControl2.SeriesTemplate.Label = RadarPointSeriesLabel2
        PointOptions4.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PointOptions4.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
        PointOptions4.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Me.ChartControl2.SeriesTemplate.LegendPointOptions = PointOptions4
        Me.ChartControl2.SeriesTemplate.ShowInLegend = False
        Me.ChartControl2.SeriesTemplate.SynchronizePointOptions = False
        Me.ChartControl2.SeriesTemplate.View = RadarAreaSeriesView2
        Me.ChartControl2.SeriesTemplate.Visible = False
        Me.ChartControl2.Size = New System.Drawing.Size(600, 415)
        Me.ChartControl2.SmallChartText.Antialiasing = False
        Me.ChartControl2.TabIndex = 9
        '
        'dst
        '
        Me.dst.DataSetName = "NewDataSet"
        Me.dst.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn5, Me.DataColumn6})
        Me.DataTable3.TableName = "GS"
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "Name"
        Me.DataColumn5.ColumnName = "Name"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Value"
        Me.DataColumn6.DataType = GetType(Integer)
        '
        'mdlPerDimensionality
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ChartControl2)
        Me.Name = "mdlPerDimensionality"
        Me.Size = New System.Drawing.Size(600, 415)
        CType(RadarDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RadarPointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RadarAreaSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RadarPointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RadarAreaSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChartControl2 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents dst As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn

End Class
