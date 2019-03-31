<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdlPerContent
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
        Dim SimpleDiagram1 As DevExpress.XtraCharts.SimpleDiagram = New DevExpress.XtraCharts.SimpleDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PieSeriesLabel1 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
        Dim PiePointOptions1 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions()
        Dim PiePointOptions2 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions()
        Dim PieSeriesView1 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim PieSeriesLabel2 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
        Dim PiePointOptions3 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions()
        Dim PiePointOptions4 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions()
        Dim PieSeriesView2 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Me.dst = New System.Data.DataSet()
        Me.DataTable3 = New System.Data.DataTable()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.ChartControl2 = New DevExpress.XtraCharts.ChartControl()
        CType(Me.dst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SimpleDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ChartControl2
        '
        Me.ChartControl2.AppearanceNameSerializable = "Chameleon"
        Me.ChartControl2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ChartControl2.BorderOptions.Visible = False
        Me.ChartControl2.CrosshairOptions.ArgumentLineColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ChartControl2.CrosshairOptions.ValueLineColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ChartControl2.DataSource = Me.dst
        SimpleDiagram1.CustomPanel = Nothing
        SimpleDiagram1.EqualPieSize = False
        Me.ChartControl2.Diagram = SimpleDiagram1
        Me.ChartControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl2.EmptyChartText.Antialiasing = False
        Me.ChartControl2.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl2.Name = "ChartControl2"
        Series1.ArgumentDataMember = "GS.Name"
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        PieSeriesLabel1.Font = New System.Drawing.Font("微軟正黑體", 8.0!)
        PieSeriesLabel1.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        PieSeriesLabel1.LineLength = 30
        PieSeriesLabel1.LineVisible = True
        PiePointOptions1.ArgumentDateTimeOptions.Format = DevExpress.XtraCharts.DateTimeFormat.MonthAndDay
        PiePointOptions1.ArgumentDateTimeOptions.FormatString = "d"
        PiePointOptions1.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PiePointOptions1.Pattern = "{A}: {V}H"
        PiePointOptions1.PercentOptions.ValueAsPercent = False
        PiePointOptions1.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
        PiePointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PieSeriesLabel1.PointOptions = PiePointOptions1
        PieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns
        PieSeriesLabel1.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Series1.Label = PieSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        PiePointOptions2.ArgumentDateTimeOptions.FormatString = "MM/dd"
        PiePointOptions2.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PiePointOptions2.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
        PiePointOptions2.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Series1.LegendPointOptions = PiePointOptions2
        Series1.Name = "Series 4"
        Series1.ShowInLegend = False
        Series1.SynchronizePointOptions = False
        Series1.ValueDataMembersSerializable = "GS.Value"
        PieSeriesView1.RuntimeExploding = False
        Series1.View = PieSeriesView1
        Me.ChartControl2.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.ChartControl2.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        PieSeriesLabel2.LineVisible = True
        PiePointOptions3.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PiePointOptions3.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PieSeriesLabel2.PointOptions = PiePointOptions3
        Me.ChartControl2.SeriesTemplate.Label = PieSeriesLabel2
        PiePointOptions4.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PiePointOptions4.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
        PiePointOptions4.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Me.ChartControl2.SeriesTemplate.LegendPointOptions = PiePointOptions4
        Me.ChartControl2.SeriesTemplate.ShowInLegend = False
        Me.ChartControl2.SeriesTemplate.SynchronizePointOptions = False
        PieSeriesView2.RuntimeExploding = False
        Me.ChartControl2.SeriesTemplate.View = PieSeriesView2
        Me.ChartControl2.SeriesTemplate.Visible = False
        Me.ChartControl2.Size = New System.Drawing.Size(389, 305)
        Me.ChartControl2.SmallChartText.Antialiasing = False
        Me.ChartControl2.TabIndex = 10
        '
        'mdlPerContent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ChartControl2)
        Me.Name = "mdlPerContent"
        Me.Size = New System.Drawing.Size(389, 305)
        CType(Me.dst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SimpleDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dst As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents ChartControl2 As DevExpress.XtraCharts.ChartControl

End Class
