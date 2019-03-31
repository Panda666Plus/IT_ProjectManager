<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup5 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.nbSystemManager = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem7 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem8 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem9 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem10 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem12 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.nbiGTD = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiPensonnelView = New DevExpress.XtraNavBar.NavBarItem()
        Me.mbiProjectView = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiDepartmentView = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiGantt = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiProject = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem11 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup4 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.nbTestProblems = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.nbiPersonnel = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbFilesManager = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lblGroup = New DevExpress.XtraEditors.LabelControl()
        Me.lblAdmin = New DevExpress.XtraEditors.LabelControl()
        Me.labUserName = New DevExpress.XtraEditors.LabelControl()
        Me.txtTime = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AlertControl1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.nbiReport = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiTypeManager = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiAssessMg = New DevExpress.XtraNavBar.NavBarItem()
        Me.AssDataSet1 = New IT_ProjectManager.AssDataSet()
        Me.AssDataSet2 = New IT_ProjectManager.AssDataSet()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
        Me.NavBarControl1.Appearance.GroupHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NavBarControl1.Appearance.GroupHeader.Options.UseFont = True
        Me.NavBarControl1.Appearance.Item.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarControl1.Appearance.Item.Options.UseFont = True
        Me.NavBarControl1.Appearance.NavigationPaneHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NavBarControl1.Appearance.NavigationPaneHeader.ForeColor = System.Drawing.Color.Green
        Me.NavBarControl1.Appearance.NavigationPaneHeader.Options.UseFont = True
        Me.NavBarControl1.Appearance.NavigationPaneHeader.Options.UseForeColor = True
        Me.NavBarControl1.Appearance.NavigationPaneHeader.Options.UseTextOptions = True
        Me.NavBarControl1.Appearance.NavigationPaneHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavBarControl1.ExplorerBarShowGroupButtons = False
        Me.NavBarControl1.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NavBarControl1.ForeColor = System.Drawing.Color.Blue
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1, Me.NavBarGroup2, Me.NavBarGroup4, Me.NavBarGroup3, Me.NavBarGroup5})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.nbiProject, Me.nbiPersonnel, Me.nbiGantt, Me.nbiPensonnelView, Me.nbiDepartmentView, Me.mbiProjectView, Me.nbFilesManager, Me.nbTestProblems, Me.nbSystemManager, Me.NavBarItem2, Me.NavBarItem3, Me.NavBarItem4, Me.NavBarItem5, Me.NavBarItem6, Me.NavBarItem7, Me.NavBarItem8, Me.NavBarItem9, Me.NavBarItem10, Me.NavBarItem11, Me.nbiGTD, Me.NavBarItem12})
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 39)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 111
        Me.NavBarControl1.Size = New System.Drawing.Size(111, 498)
        Me.NavBarControl1.TabIndex = 0
        Me.NavBarControl1.Text = "NavBarControl1"
        Me.NavBarControl1.View = New DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator()
        '
        'NavBarGroup5
        '
        Me.NavBarGroup5.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NavBarGroup5.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.NavBarGroup5.Appearance.Options.UseFont = True
        Me.NavBarGroup5.Appearance.Options.UseForeColor = True
        Me.NavBarGroup5.Appearance.Options.UseTextOptions = True
        Me.NavBarGroup5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NavBarGroup5.Caption = "系统维护"
        Me.NavBarGroup5.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText
        Me.NavBarGroup5.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nbSystemManager), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem7), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem8), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem9), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem10), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem12)})
        Me.NavBarGroup5.Name = "NavBarGroup5"
        '
        'nbSystemManager
        '
        Me.nbSystemManager.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.nbSystemManager.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.nbSystemManager.Appearance.Options.UseFont = True
        Me.nbSystemManager.Appearance.Options.UseForeColor = True
        Me.nbSystemManager.Appearance.Options.UseTextOptions = True
        Me.nbSystemManager.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nbSystemManager.AppearanceDisabled.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nbSystemManager.AppearanceDisabled.Options.UseFont = True
        Me.nbSystemManager.Caption = "系统名称管理"
        Me.nbSystemManager.LargeImage = Global.IT_ProjectManager.My.Resources.Resources.sysName
        Me.nbSystemManager.Name = "nbSystemManager"
        '
        'NavBarItem7
        '
        Me.NavBarItem7.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NavBarItem7.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.NavBarItem7.Appearance.Options.UseFont = True
        Me.NavBarItem7.Appearance.Options.UseForeColor = True
        Me.NavBarItem7.Appearance.Options.UseTextOptions = True
        Me.NavBarItem7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NavBarItem7.Caption = "评分标准管理"
        Me.NavBarItem7.LargeImage = Global.IT_ProjectManager.My.Resources.Resources.Score
        Me.NavBarItem7.Name = "NavBarItem7"
        '
        'NavBarItem8
        '
        Me.NavBarItem8.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NavBarItem8.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.NavBarItem8.Appearance.Options.UseFont = True
        Me.NavBarItem8.Appearance.Options.UseForeColor = True
        Me.NavBarItem8.Appearance.Options.UseTextOptions = True
        Me.NavBarItem8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NavBarItem8.Caption = "Bug类型管理"
        Me.NavBarItem8.LargeImage = Global.IT_ProjectManager.My.Resources.Resources.Bug1
        Me.NavBarItem8.Name = "NavBarItem8"
        '
        'NavBarItem9
        '
        Me.NavBarItem9.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NavBarItem9.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.NavBarItem9.Appearance.Options.UseFont = True
        Me.NavBarItem9.Appearance.Options.UseForeColor = True
        Me.NavBarItem9.Appearance.Options.UseTextOptions = True
        Me.NavBarItem9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NavBarItem9.Caption = "组别管理"
        Me.NavBarItem9.LargeImage = Global.IT_ProjectManager.My.Resources.Resources.Groups
        Me.NavBarItem9.Name = "NavBarItem9"
        '
        'NavBarItem10
        '
        Me.NavBarItem10.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NavBarItem10.Appearance.Options.UseFont = True
        Me.NavBarItem10.Caption = "考核标准管理"
        Me.NavBarItem10.LargeImage = Global.IT_ProjectManager.My.Resources.Resources.assess
        Me.NavBarItem10.Name = "NavBarItem10"
        '
        'NavBarItem12
        '
        Me.NavBarItem12.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!)
        Me.NavBarItem12.Appearance.Options.UseFont = True
        Me.NavBarItem12.Caption = "部门设置"
        Me.NavBarItem12.LargeImage = Global.IT_ProjectManager.My.Resources.Resources.Category
        Me.NavBarItem12.Name = "NavBarItem12"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NavBarGroup1.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.NavBarGroup1.Appearance.Options.UseFont = True
        Me.NavBarGroup1.Appearance.Options.UseForeColor = True
        Me.NavBarGroup1.Appearance.Options.UseTextOptions = True
        Me.NavBarGroup1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NavBarGroup1.Caption = "项目菜单"
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText
        Me.NavBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiGTD), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiPensonnelView), New DevExpress.XtraNavBar.NavBarItemLink(Me.mbiProjectView), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiDepartmentView), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiGantt), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiProject)})
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'nbiGTD
        '
        Me.nbiGTD.Appearance.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nbiGTD.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.nbiGTD.Appearance.Options.UseFont = True
        Me.nbiGTD.Appearance.Options.UseForeColor = True
        Me.nbiGTD.Caption = "GTD"
        Me.nbiGTD.LargeImage = Global.IT_ProjectManager.My.Resources.Resources.Category
        Me.nbiGTD.Name = "nbiGTD"
        '
        'nbiPensonnelView
        '
        Me.nbiPensonnelView.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.nbiPensonnelView.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.nbiPensonnelView.Appearance.Options.UseFont = True
        Me.nbiPensonnelView.Appearance.Options.UseForeColor = True
        Me.nbiPensonnelView.Caption = "个人视图"
        Me.nbiPensonnelView.LargeImage = CType(resources.GetObject("nbiPensonnelView.LargeImage"), System.Drawing.Image)
        Me.nbiPensonnelView.Name = "nbiPensonnelView"
        '
        'mbiProjectView
        '
        Me.mbiProjectView.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.mbiProjectView.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.mbiProjectView.Appearance.Options.UseFont = True
        Me.mbiProjectView.Appearance.Options.UseForeColor = True
        Me.mbiProjectView.Caption = "项目视图"
        Me.mbiProjectView.LargeImage = CType(resources.GetObject("mbiProjectView.LargeImage"), System.Drawing.Image)
        Me.mbiProjectView.Name = "mbiProjectView"
        '
        'nbiDepartmentView
        '
        Me.nbiDepartmentView.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.nbiDepartmentView.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.nbiDepartmentView.Appearance.Options.UseFont = True
        Me.nbiDepartmentView.Appearance.Options.UseForeColor = True
        Me.nbiDepartmentView.Caption = "部门视图"
        Me.nbiDepartmentView.LargeImage = CType(resources.GetObject("nbiDepartmentView.LargeImage"), System.Drawing.Image)
        Me.nbiDepartmentView.Name = "nbiDepartmentView"
        '
        'nbiGantt
        '
        Me.nbiGantt.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.nbiGantt.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.nbiGantt.Appearance.Options.UseFont = True
        Me.nbiGantt.Appearance.Options.UseForeColor = True
        Me.nbiGantt.AppearanceDisabled.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nbiGantt.AppearanceDisabled.Options.UseFont = True
        Me.nbiGantt.Caption = "甘特图"
        Me.nbiGantt.LargeImage = CType(resources.GetObject("nbiGantt.LargeImage"), System.Drawing.Image)
        Me.nbiGantt.Name = "nbiGantt"
        '
        'nbiProject
        '
        Me.nbiProject.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.nbiProject.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.nbiProject.Appearance.Options.UseFont = True
        Me.nbiProject.Appearance.Options.UseForeColor = True
        Me.nbiProject.Caption = "项目管理"
        Me.nbiProject.LargeImage = CType(resources.GetObject("nbiProject.LargeImage"), System.Drawing.Image)
        Me.nbiProject.Name = "nbiProject"
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NavBarGroup2.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.NavBarGroup2.Appearance.Options.UseBackColor = True
        Me.NavBarGroup2.Appearance.Options.UseBorderColor = True
        Me.NavBarGroup2.Appearance.Options.UseFont = True
        Me.NavBarGroup2.Appearance.Options.UseForeColor = True
        Me.NavBarGroup2.Appearance.Options.UseTextOptions = True
        Me.NavBarGroup2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NavBarGroup2.Caption = "考核管理"
        Me.NavBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText
        Me.NavBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem3), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem11)})
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'NavBarItem2
        '
        Me.NavBarItem2.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarItem2.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.NavBarItem2.Appearance.Options.UseFont = True
        Me.NavBarItem2.Appearance.Options.UseForeColor = True
        Me.NavBarItem2.Caption = "个人自评"
        Me.NavBarItem2.LargeImage = CType(resources.GetObject("NavBarItem2.LargeImage"), System.Drawing.Image)
        Me.NavBarItem2.Name = "NavBarItem2"
        '
        'NavBarItem3
        '
        Me.NavBarItem3.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarItem3.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.NavBarItem3.Appearance.Options.UseFont = True
        Me.NavBarItem3.Appearance.Options.UseForeColor = True
        Me.NavBarItem3.Caption = "主管考核"
        Me.NavBarItem3.LargeImage = CType(resources.GetObject("NavBarItem3.LargeImage"), System.Drawing.Image)
        Me.NavBarItem3.Name = "NavBarItem3"
        '
        'NavBarItem11
        '
        Me.NavBarItem11.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarItem11.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.NavBarItem11.Appearance.Options.UseFont = True
        Me.NavBarItem11.Appearance.Options.UseForeColor = True
        Me.NavBarItem11.Caption = "考核报表"
        Me.NavBarItem11.LargeImage = Global.IT_ProjectManager.My.Resources.Resources.report
        Me.NavBarItem11.Name = "NavBarItem11"
        '
        'NavBarGroup4
        '
        Me.NavBarGroup4.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NavBarGroup4.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.NavBarGroup4.Appearance.Options.UseFont = True
        Me.NavBarGroup4.Appearance.Options.UseForeColor = True
        Me.NavBarGroup4.Appearance.Options.UseTextOptions = True
        Me.NavBarGroup4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NavBarGroup4.Caption = "Bug管理"
        Me.NavBarGroup4.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText
        Me.NavBarGroup4.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nbTestProblems), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem5), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem6)})
        Me.NavBarGroup4.Name = "NavBarGroup4"
        '
        'nbTestProblems
        '
        Me.nbTestProblems.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.nbTestProblems.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.nbTestProblems.Appearance.Options.UseFont = True
        Me.nbTestProblems.Appearance.Options.UseForeColor = True
        Me.nbTestProblems.AppearanceDisabled.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nbTestProblems.AppearanceDisabled.Options.UseFont = True
        Me.nbTestProblems.Caption = "Bug数据管理"
        Me.nbTestProblems.LargeImage = Global.IT_ProjectManager.My.Resources.Resources.Bug2
        Me.nbTestProblems.Name = "nbTestProblems"
        '
        'NavBarItem5
        '
        Me.NavBarItem5.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NavBarItem5.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.NavBarItem5.Appearance.Options.UseFont = True
        Me.NavBarItem5.Appearance.Options.UseForeColor = True
        Me.NavBarItem5.Caption = "Bug率统计"
        Me.NavBarItem5.LargeImage = Global.IT_ProjectManager.My.Resources.Resources.BugStatistics
        Me.NavBarItem5.Name = "NavBarItem5"
        '
        'NavBarItem6
        '
        Me.NavBarItem6.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NavBarItem6.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.NavBarItem6.Appearance.Options.UseFont = True
        Me.NavBarItem6.Appearance.Options.UseForeColor = True
        Me.NavBarItem6.Caption = "Bug视图"
        Me.NavBarItem6.LargeImage = Global.IT_ProjectManager.My.Resources.Resources.BugMap
        Me.NavBarItem6.Name = "NavBarItem6"
        '
        'NavBarGroup3
        '
        Me.NavBarGroup3.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NavBarGroup3.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.NavBarGroup3.Appearance.Options.UseFont = True
        Me.NavBarGroup3.Appearance.Options.UseForeColor = True
        Me.NavBarGroup3.Appearance.Options.UseTextOptions = True
        Me.NavBarGroup3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NavBarGroup3.Caption = "综合管理"
        Me.NavBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText
        Me.NavBarGroup3.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiPersonnel), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbFilesManager)})
        Me.NavBarGroup3.Name = "NavBarGroup3"
        '
        'nbiPersonnel
        '
        Me.nbiPersonnel.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.nbiPersonnel.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.nbiPersonnel.Appearance.Options.UseFont = True
        Me.nbiPersonnel.Appearance.Options.UseForeColor = True
        Me.nbiPersonnel.Caption = "人员管理"
        Me.nbiPersonnel.LargeImage = CType(resources.GetObject("nbiPersonnel.LargeImage"), System.Drawing.Image)
        Me.nbiPersonnel.Name = "nbiPersonnel"
        '
        'nbFilesManager
        '
        Me.nbFilesManager.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.nbFilesManager.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.nbFilesManager.Appearance.Options.UseFont = True
        Me.nbFilesManager.Appearance.Options.UseForeColor = True
        Me.nbFilesManager.AppearanceDisabled.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nbFilesManager.AppearanceDisabled.Options.UseFont = True
        Me.nbFilesManager.Caption = "文档管理"
        Me.nbFilesManager.LargeImage = CType(resources.GetObject("nbFilesManager.LargeImage"), System.Drawing.Image)
        Me.nbFilesManager.Name = "nbFilesManager"
        '
        'NavBarItem4
        '
        Me.NavBarItem4.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarItem4.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.NavBarItem4.Appearance.Options.UseFont = True
        Me.NavBarItem4.Appearance.Options.UseForeColor = True
        Me.NavBarItem4.Caption = "考核報表"
        Me.NavBarItem4.LargeImage = Global.IT_ProjectManager.My.Resources.Resources.report
        Me.NavBarItem4.Name = "NavBarItem4"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.lblGroup)
        Me.PanelControl1.Controls.Add(Me.lblAdmin)
        Me.PanelControl1.Controls.Add(Me.labUserName)
        Me.PanelControl1.Controls.Add(Me.txtTime)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.PictureEdit1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(841, 39)
        Me.PanelControl1.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl4.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelControl4.Location = New System.Drawing.Point(708, 9)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(48, 21)
        Me.LabelControl4.TabIndex = 16
        Me.LabelControl4.Text = "组别："
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl7.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelControl7.Location = New System.Drawing.Point(579, 9)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(48, 21)
        Me.LabelControl7.TabIndex = 14
        Me.LabelControl7.Text = "权限："
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl3.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelControl3.Location = New System.Drawing.Point(435, 9)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(80, 21)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "当前用户："
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl2.Location = New System.Drawing.Point(244, 7)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(90, 24)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "[项目管理]"
        '
        'lblGroup
        '
        Me.lblGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGroup.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblGroup.Appearance.ForeColor = System.Drawing.Color.Green
        Me.lblGroup.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblGroup.Location = New System.Drawing.Point(755, 9)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(10, 21)
        Me.lblGroup.TabIndex = 15
        Me.lblGroup.Text = "1"
        '
        'lblAdmin
        '
        Me.lblAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAdmin.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblAdmin.Appearance.ForeColor = System.Drawing.Color.Green
        Me.lblAdmin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAdmin.Location = New System.Drawing.Point(626, 9)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(10, 21)
        Me.lblAdmin.TabIndex = 13
        Me.lblAdmin.Text = "1"
        '
        'labUserName
        '
        Me.labUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labUserName.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.labUserName.Appearance.ForeColor = System.Drawing.Color.Green
        Me.labUserName.Cursor = System.Windows.Forms.Cursors.Default
        Me.labUserName.Location = New System.Drawing.Point(513, 9)
        Me.labUserName.Name = "labUserName"
        Me.labUserName.Size = New System.Drawing.Size(10, 21)
        Me.labUserName.TabIndex = 9
        Me.labUserName.Text = "1"
        '
        'txtTime
        '
        Me.txtTime.EditValue = "0"
        Me.txtTime.Location = New System.Drawing.Point(63, 9)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(23, 20)
        Me.txtTime.TabIndex = 8
        Me.txtTime.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl1.Location = New System.Drawing.Point(52, 7)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(175, 24)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "项目管理系统 V4.0.0"
        Me.LabelControl1.ToolTip = "版本升級說明"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(4, 3)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Size = New System.Drawing.Size(42, 33)
        Me.PictureEdit1.TabIndex = 5
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "项目管理系统"
        Me.NotifyIcon1.Visible = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 30000
        '
        'AlertControl1
        '
        Me.AlertControl1.AutoFormDelay = 70000
        '
        'Timer2
        '
        Me.Timer2.Interval = 30000
        '
        'Timer3
        '
        Me.Timer3.Interval = 5000
        '
        'Timer4
        '
        Me.Timer4.Interval = 1800000
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NavBarItem1.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.NavBarItem1.Appearance.Options.UseFont = True
        Me.NavBarItem1.Appearance.Options.UseForeColor = True
        Me.NavBarItem1.Caption = "個人視圖"
        Me.NavBarItem1.LargeImage = CType(resources.GetObject("NavBarItem1.LargeImage"), System.Drawing.Image)
        Me.NavBarItem1.Name = "NavBarItem1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(111, 39)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(730, 498)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "GroupControl1"
        '
        'nbiReport
        '
        Me.nbiReport.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.nbiReport.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.nbiReport.Appearance.Options.UseFont = True
        Me.nbiReport.Appearance.Options.UseForeColor = True
        Me.nbiReport.Caption = "報表管理"
        Me.nbiReport.LargeImage = CType(resources.GetObject("nbiReport.LargeImage"), System.Drawing.Image)
        Me.nbiReport.Name = "nbiReport"
        '
        'nbiTypeManager
        '
        Me.nbiTypeManager.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.nbiTypeManager.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.nbiTypeManager.Appearance.Options.UseFont = True
        Me.nbiTypeManager.Appearance.Options.UseForeColor = True
        Me.nbiTypeManager.Caption = "考核管理"
        Me.nbiTypeManager.LargeImage = CType(resources.GetObject("nbiTypeManager.LargeImage"), System.Drawing.Image)
        Me.nbiTypeManager.Name = "nbiTypeManager"
        '
        'nbiAssessMg
        '
        Me.nbiAssessMg.Appearance.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.nbiAssessMg.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.nbiAssessMg.Appearance.Options.UseFont = True
        Me.nbiAssessMg.Appearance.Options.UseForeColor = True
        Me.nbiAssessMg.Caption = "個人自評(月)"
        Me.nbiAssessMg.LargeImage = CType(resources.GetObject("nbiAssessMg.LargeImage"), System.Drawing.Image)
        Me.nbiAssessMg.Name = "nbiAssessMg"
        '
        'AssDataSet1
        '
        Me.AssDataSet1.DataSetName = "AssDataSet"
        Me.AssDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AssDataSet2
        '
        Me.AssDataSet2.DataSetName = "AssDataSet"
        Me.AssDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 537)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.NavBarControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "项目管理系统 V4.0.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents nbiProject As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiPersonnel As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiGantt As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nbiPensonnelView As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents nbiDepartmentView As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents AlertControl1 As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents txtTime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents labUserName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nbFilesManager As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAdmin As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nbTestProblems As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbSystemManager As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents mbiProjectView As DevExpress.XtraNavBar.NavBarItem
    Public WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblGroup As DevExpress.XtraEditors.LabelControl
    Private WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroup4 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem4 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem3 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem5 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiReport As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiTypeManager As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiAssessMg As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroup5 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem6 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem7 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem8 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem9 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem10 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem11 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiGTD As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem12 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents AssDataSet1 As IT_ProjectManager.AssDataSet
    Friend WithEvents AssDataSet2 As IT_ProjectManager.AssDataSet

End Class
