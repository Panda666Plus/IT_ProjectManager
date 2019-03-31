<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdlGanttDetail
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
        Me.components = New System.ComponentModel.Container()
        Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeScaleYear1 As DevExpress.XtraScheduler.TimeScaleYear = New DevExpress.XtraScheduler.TimeScaleYear()
        Dim TimeScaleQuarter1 As DevExpress.XtraScheduler.TimeScaleQuarter = New DevExpress.XtraScheduler.TimeScaleQuarter()
        Dim TimeScaleMonth1 As DevExpress.XtraScheduler.TimeScaleMonth = New DevExpress.XtraScheduler.TimeScaleMonth()
        Dim TimeScaleWeek1 As DevExpress.XtraScheduler.TimeScaleWeek = New DevExpress.XtraScheduler.TimeScaleWeek()
        Dim TimeScaleDay1 As DevExpress.XtraScheduler.TimeScaleDay = New DevExpress.XtraScheduler.TimeScaleDay()
        Dim TimeScaleHour1 As DevExpress.XtraScheduler.TimeScaleHour = New DevExpress.XtraScheduler.TimeScaleHour()
        Dim TimeScale15Minutes1 As DevExpress.XtraScheduler.TimeScale15Minutes = New DevExpress.XtraScheduler.TimeScale15Minutes()
        Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Me.SchedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.ds = New IT_ProjectManager.TasksDataSet()
        Me.SchedulerControl2 = New DevExpress.XtraScheduler.SchedulerControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.ResourcesTree1 = New DevExpress.XtraScheduler.UI.ResourcesTree()
        Me.colDescription = New DevExpress.XtraScheduler.Native.ResourceTreeColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.proControl = New DevExpress.XtraEditors.ProgressBarControl()
        Me.LUtxtID = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.ResourcesTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.proControl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LUtxtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SchedulerStorage1
        '
        Me.SchedulerStorage1.AppointmentDependencies.DataMember = "TaskDependencies"
        Me.SchedulerStorage1.AppointmentDependencies.DataSource = Me.ds
        Me.SchedulerStorage1.AppointmentDependencies.Mappings.DependentId = "Dependent"
        Me.SchedulerStorage1.AppointmentDependencies.Mappings.ParentId = "Parent"
        Me.SchedulerStorage1.AppointmentDependencies.Mappings.Type = "Type"
        Me.SchedulerStorage1.Appointments.DataMember = "Tasks"
        Me.SchedulerStorage1.Appointments.DataSource = Me.ds
        Me.SchedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
        Me.SchedulerStorage1.Appointments.Mappings.AppointmentId = "Id"
        Me.SchedulerStorage1.Appointments.Mappings.Description = "Description"
        Me.SchedulerStorage1.Appointments.Mappings.End = "EndTime"
        Me.SchedulerStorage1.Appointments.Mappings.Label = "Label"
        Me.SchedulerStorage1.Appointments.Mappings.Location = "Location"
        Me.SchedulerStorage1.Appointments.Mappings.PercentComplete = "PercentComplete"
        Me.SchedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
        Me.SchedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
        Me.SchedulerStorage1.Appointments.Mappings.ResourceId = "ResourceId"
        Me.SchedulerStorage1.Appointments.Mappings.Start = "StartTime"
        Me.SchedulerStorage1.Appointments.Mappings.Subject = "Subject"
        Me.SchedulerStorage1.Appointments.Mappings.Type = "EventType"
        Me.SchedulerStorage1.EnableReminders = False
        Me.SchedulerStorage1.Resources.DataMember = "Resources"
        Me.SchedulerStorage1.Resources.DataSource = Me.ds
        Me.SchedulerStorage1.Resources.Mappings.Caption = "Description"
        Me.SchedulerStorage1.Resources.Mappings.Id = "Id"
        Me.SchedulerStorage1.Resources.Mappings.ParentId = "ParentId"
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SchedulerControl2
        '
        Me.SchedulerControl2.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Gantt
        Me.SchedulerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SchedulerControl2.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SchedulerControl2.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
        Me.SchedulerControl2.Location = New System.Drawing.Point(0, 44)
        Me.SchedulerControl2.Name = "SchedulerControl2"
        Me.SchedulerControl2.OptionsBehavior.RecurrentAppointmentDeleteAction = DevExpress.XtraScheduler.RecurrentAppointmentAction.Cancel
        Me.SchedulerControl2.OptionsBehavior.RecurrentAppointmentEditAction = DevExpress.XtraScheduler.RecurrentAppointmentAction.Cancel
        Me.SchedulerControl2.OptionsBehavior.RemindersFormDefaultAction = DevExpress.XtraScheduler.RemindersFormDefaultAction.Custom
        Me.SchedulerControl2.OptionsBehavior.ShowRemindersForm = False
        Me.SchedulerControl2.OptionsCustomization.AllowAppointmentConflicts = DevExpress.XtraScheduler.AppointmentConflictsMode.Forbidden
        Me.SchedulerControl2.OptionsCustomization.AllowAppointmentCopy = DevExpress.XtraScheduler.UsedAppointmentType.None
        Me.SchedulerControl2.OptionsCustomization.AllowAppointmentCreate = DevExpress.XtraScheduler.UsedAppointmentType.None
        Me.SchedulerControl2.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.None
        Me.SchedulerControl2.OptionsCustomization.AllowAppointmentDrag = DevExpress.XtraScheduler.UsedAppointmentType.None
        Me.SchedulerControl2.OptionsCustomization.AllowAppointmentDragBetweenResources = DevExpress.XtraScheduler.UsedAppointmentType.None
        Me.SchedulerControl2.OptionsCustomization.AllowAppointmentEdit = DevExpress.XtraScheduler.UsedAppointmentType.None
        Me.SchedulerControl2.OptionsCustomization.AllowAppointmentMultiSelect = False
        Me.SchedulerControl2.OptionsCustomization.AllowAppointmentResize = DevExpress.XtraScheduler.UsedAppointmentType.None
        Me.SchedulerControl2.OptionsCustomization.AllowDisplayAppointmentDependencyForm = DevExpress.XtraScheduler.AllowDisplayAppointmentDependencyForm.Never
        Me.SchedulerControl2.OptionsCustomization.AllowDisplayAppointmentForm = DevExpress.XtraScheduler.AllowDisplayAppointmentForm.Never
        Me.SchedulerControl2.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.None
        Me.SchedulerControl2.Size = New System.Drawing.Size(507, 473)
        Me.SchedulerControl2.Start = New Date(2010, 7, 4, 0, 0, 0, 0)
        Me.SchedulerControl2.Storage = Me.SchedulerStorage1
        Me.SchedulerControl2.TabIndex = 11
        Me.SchedulerControl2.Text = "SchedulerControl2"
        Me.SchedulerControl2.Views.DayView.Enabled = False
        TimeRuler1.TimeZone.Id = "Russian Standard Time"
        TimeRuler1.UseClientTimeZone = False
        Me.SchedulerControl2.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.SchedulerControl2.Views.GanttView.AppointmentDisplayOptions.ShowRecurrence = False
        Me.SchedulerControl2.Views.GanttView.AppointmentDisplayOptions.ShowReminder = False
        Me.SchedulerControl2.Views.GanttView.ResourcesPerPage = 15
        TimeScaleYear1.Enabled = False
        TimeScaleQuarter1.Enabled = False
        TimeScaleMonth1.Enabled = False
        TimeScaleDay1.Width = 60
        TimeScaleHour1.Enabled = False
        TimeScale15Minutes1.Enabled = False
        Me.SchedulerControl2.Views.GanttView.Scales.Add(TimeScaleYear1)
        Me.SchedulerControl2.Views.GanttView.Scales.Add(TimeScaleQuarter1)
        Me.SchedulerControl2.Views.GanttView.Scales.Add(TimeScaleMonth1)
        Me.SchedulerControl2.Views.GanttView.Scales.Add(TimeScaleWeek1)
        Me.SchedulerControl2.Views.GanttView.Scales.Add(TimeScaleDay1)
        Me.SchedulerControl2.Views.GanttView.Scales.Add(TimeScaleHour1)
        Me.SchedulerControl2.Views.GanttView.Scales.Add(TimeScale15Minutes1)
        Me.SchedulerControl2.Views.GanttView.ShowResourceHeaders = False
        Me.SchedulerControl2.Views.GanttView.WorkTime.End = System.TimeSpan.Parse("18:00:00")
        Me.SchedulerControl2.Views.GanttView.WorkTime.Start = System.TimeSpan.Parse("08:30:00")
        Me.SchedulerControl2.Views.MonthView.Enabled = False
        Me.SchedulerControl2.Views.TimelineView.Enabled = False
        Me.SchedulerControl2.Views.WeekView.Enabled = False
        Me.SchedulerControl2.Views.WorkWeekView.Enabled = False
        TimeRuler2.TimeZone.Id = "Russian Standard Time"
        TimeRuler2.UseClientTimeZone = False
        Me.SchedulerControl2.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ResourcesTree1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SchedulerControl2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.PanelControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(722, 517)
        Me.SplitContainerControl1.SplitterPosition = 210
        Me.SplitContainerControl1.TabIndex = 12
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'ResourcesTree1
        '
        Me.ResourcesTree1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colDescription})
        Me.ResourcesTree1.CustomizationRowCount = 20
        Me.ResourcesTree1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResourcesTree1.KeyFieldName = "Id"
        Me.ResourcesTree1.Location = New System.Drawing.Point(0, 0)
        Me.ResourcesTree1.Name = "ResourcesTree1"
        Me.ResourcesTree1.ParentFieldName = "ParentId"
        Me.ResourcesTree1.SchedulerControl = Me.SchedulerControl2
        Me.ResourcesTree1.Size = New System.Drawing.Size(210, 517)
        Me.ResourcesTree1.TabIndex = 0
        Me.ResourcesTree1.VertScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never
        '
        'colDescription
        '
        Me.colDescription.AppearanceHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDescription.AppearanceHeader.Options.UseFont = True
        Me.colDescription.AppearanceHeader.Options.UseTextOptions = True
        Me.colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDescription.Caption = "项目描述"
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsColumn.AllowEdit = False
        Me.colDescription.OptionsColumn.AllowFocus = False
        Me.colDescription.OptionsColumn.AllowMove = False
        Me.colDescription.OptionsColumn.AllowSort = False
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 0
        Me.colDescription.Width = 258
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.RadioButton2)
        Me.PanelControl1.Controls.Add(Me.RadioButton1)
        Me.PanelControl1.Controls.Add(Me.proControl)
        Me.PanelControl1.Controls.Add(Me.LUtxtID)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(507, 44)
        Me.PanelControl1.TabIndex = 13
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(260, 14)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.Text = "所有"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(16, 14)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(59, 16)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.Text = "负责人"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'proControl
        '
        Me.proControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.proControl.Location = New System.Drawing.Point(323, 12)
        Me.proControl.Name = "proControl"
        Me.proControl.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText
        Me.proControl.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
        Me.proControl.Properties.ShowTitle = True
        Me.proControl.Properties.Step = 1
        Me.proControl.Size = New System.Drawing.Size(169, 20)
        Me.proControl.TabIndex = 6
        Me.proControl.Visible = False
        '
        'LUtxtID
        '
        Me.LUtxtID.Enabled = False
        Me.LUtxtID.Location = New System.Drawing.Point(79, 12)
        Me.LUtxtID.Name = "LUtxtID"
        Me.LUtxtID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LUtxtID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "UserName")})
        Me.LUtxtID.Properties.NullText = ""
        Me.LUtxtID.Properties.PopupSizeable = False
        Me.LUtxtID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LUtxtID.Size = New System.Drawing.Size(155, 20)
        Me.LUtxtID.TabIndex = 2
        '
        'mdlGanttDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "mdlGanttDetail"
        Me.Size = New System.Drawing.Size(722, 517)
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.ResourcesTree1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.proControl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LUtxtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents SchedulerControl2 As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents ResourcesTree1 As DevExpress.XtraScheduler.UI.ResourcesTree
    Friend WithEvents ds As IT_ProjectManager.TasksDataSet
    Friend WithEvents colDescription As DevExpress.XtraScheduler.Native.ResourceTreeColumn
    Private WithEvents SchedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LUtxtID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents proControl As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton

End Class
