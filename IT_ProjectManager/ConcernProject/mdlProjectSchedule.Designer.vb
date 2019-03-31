<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdlProjectSchedule
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
        Dim PointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim PointOptions1 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim PointOptions2 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim LineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PointSeriesLabel2 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim PointOptions3 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim PointOptions4 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim LineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PointSeriesLabel3 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim PointOptions5 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim LineSeriesView3 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim PointSeriesLabel4 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim PointOptions6 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim LineSeriesView4 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Me.dst = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataTable3 = New System.Data.DataTable()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtType = New DevExpress.XtraEditors.LabelControl()
        Me.txtDate = New DevExpress.XtraEditors.LabelControl()
        Me.txtID = New DevExpress.XtraEditors.LabelControl()
        CType(Me.dst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dst
        '
        Me.dst.DataSetName = "NewDataSet"
        Me.dst.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable2, Me.DataTable3})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2})
        Me.DataTable1.TableName = "Demand"
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
        Me.DataTable2.TableName = "Complete"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "CreatedDate"
        Me.DataColumn3.DataType = GetType(Date)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Value"
        Me.DataColumn4.DataType = GetType(Integer)
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn5, Me.DataColumn6})
        Me.DataTable3.TableName = "Unfinished"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "CreatedDate"
        Me.DataColumn5.DataType = GetType(Date)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Value"
        Me.DataColumn6.DataType = GetType(Integer)
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.Location = New System.Drawing.Point(175, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(324, 55)
        Me.ListView1.TabIndex = 9
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "日期"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "总需求"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "已完成"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "未完成"
        '
        'ChartControl1
        '
        Me.ChartControl1.AppearanceNameSerializable = "Light"
        Me.ChartControl1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ChartControl1.CrosshairOptions.ArgumentLineColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ChartControl1.CrosshairOptions.ValueLineColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ChartControl1.DataSource = Me.dst
        XyDiagram1.AxisX.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[False]
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
        Me.ChartControl1.Location = New System.Drawing.Point(2, 22)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.PaletteName = "Solstice"
        Me.ChartControl1.SeriesDataMember = "Table2.CreatedDate"
        Series1.ArgumentDataMember = "Demand.CreatedDate"
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        PointSeriesLabel1.Font = New System.Drawing.Font("Microsoft JhengHei", 8.0!)
        PointSeriesLabel1.LineVisible = True
        PointOptions1.ArgumentDateTimeOptions.Format = DevExpress.XtraCharts.DateTimeFormat.MonthAndDay
        PointOptions1.ArgumentDateTimeOptions.FormatString = "d"
        PointOptions1.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PointSeriesLabel1.PointOptions = PointOptions1
        Series1.Label = PointSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        PointOptions2.ArgumentDateTimeOptions.FormatString = "MM/dd"
        PointOptions2.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PointOptions2.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Series1.LegendPointOptions = PointOptions2
        Series1.LegendText = "总需求"
        Series1.Name = "Demand"
        Series1.SynchronizePointOptions = False
        Series1.ValueDataMembersSerializable = "Demand.Value"
        LineSeriesView1.LineMarkerOptions.BorderVisible = False
        LineSeriesView1.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Square
        LineSeriesView1.LineMarkerOptions.Visible = True
        LineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.View = LineSeriesView1
        Series2.ArgumentDataMember = "Complete.CreatedDate"
        Series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        PointSeriesLabel2.LineVisible = True
        PointOptions3.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PointOptions3.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PointSeriesLabel2.PointOptions = PointOptions3
        Series2.Label = PointSeriesLabel2
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        PointOptions4.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PointOptions4.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Series2.LegendPointOptions = PointOptions4
        Series2.LegendText = "已完成"
        Series2.Name = "Complete"
        Series2.SynchronizePointOptions = False
        Series2.ValueDataMembersSerializable = "Complete.Value"
        LineSeriesView2.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series2.View = LineSeriesView2
        Series3.ArgumentDataMember = "Unfinished.CreatedDate"
        Series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        PointSeriesLabel3.LineVisible = True
        PointOptions5.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PointOptions5.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PointSeriesLabel3.PointOptions = PointOptions5
        Series3.Label = PointSeriesLabel3
        Series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series3.LegendText = "未完成"
        Series3.Name = "Unfinished"
        Series3.ValueDataMembersSerializable = "Unfinished.Value"
        LineSeriesView3.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Triangle
        LineSeriesView3.LineMarkerOptions.Visible = True
        LineSeriesView3.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series3.View = LineSeriesView3
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2, Series3}
        PointSeriesLabel4.LineVisible = True
        PointOptions6.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PointOptions6.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PointSeriesLabel4.PointOptions = PointOptions6
        Me.ChartControl1.SeriesTemplate.Label = PointSeriesLabel4
        Me.ChartControl1.SeriesTemplate.View = LineSeriesView4
        Me.ChartControl1.SeriesTemplate.Visible = False
        Me.ChartControl1.Size = New System.Drawing.Size(633, 340)
        Me.ChartControl1.TabIndex = 8
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.ListView1)
        Me.GroupControl1.Controls.Add(Me.txtType)
        Me.GroupControl1.Controls.Add(Me.txtDate)
        Me.GroupControl1.Controls.Add(Me.txtID)
        Me.GroupControl1.Controls.Add(Me.ChartControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(637, 364)
        Me.GroupControl1.TabIndex = 10
        Me.GroupControl1.Text = "项目名称"
        '
        'txtType
        '
        Me.txtType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtType.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtType.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtType.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtType.Location = New System.Drawing.Point(564, 98)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(48, 20)
        Me.txtType.TabIndex = 13
        Me.txtType.Text = "日视图"
        '
        'txtDate
        '
        Me.txtDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDate.Location = New System.Drawing.Point(539, 3)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(64, 14)
        Me.txtDate.TabIndex = 12
        Me.txtDate.Text = "2013-08-24"
        Me.txtDate.Visible = False
        '
        'txtID
        '
        Me.txtID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtID.Location = New System.Drawing.Point(621, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(7, 14)
        Me.txtID.TabIndex = 11
        Me.txtID.Text = "0"
        Me.txtID.Visible = False
        '
        'mdlProjectSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "mdlProjectSchedule"
        Me.Size = New System.Drawing.Size(637, 364)
        CType(Me.dst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dst As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtType As DevExpress.XtraEditors.LabelControl

End Class
