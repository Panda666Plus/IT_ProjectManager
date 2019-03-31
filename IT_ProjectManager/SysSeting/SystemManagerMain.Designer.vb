<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SystemManagerMain
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.NavigationActionContainer1 = New DevExpress.ExpressApp.Win.Templates.ActionContainers.NavigationActionContainer()
        Me.NavigationActionContainer2 = New DevExpress.ExpressApp.Win.Templates.ActionContainers.NavigationActionContainer()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.nbiSystem = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiTypeManager = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiBugType = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiStaffGroup = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiGroupsManage = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiAssess = New DevExpress.XtraNavBar.NavBarItem()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        Me.NavigationActionContainer1.SuspendLayout()
        Me.NavigationActionContainer2.SuspendLayout()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.NavigationActionContainer1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(592, 550)
        Me.SplitContainerControl1.SplitterPosition = 132
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'NavigationActionContainer1
        '
        Me.NavigationActionContainer1.Controls.Add(Me.NavigationActionContainer2)
        Me.NavigationActionContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationActionContainer1.Location = New System.Drawing.Point(0, 0)
        Me.NavigationActionContainer1.Model = Nothing
        Me.NavigationActionContainer1.Name = "NavigationActionContainer1"
        Me.NavigationActionContainer1.Size = New System.Drawing.Size(132, 550)
        Me.NavigationActionContainer1.TabIndex = 0
        '
        'NavigationActionContainer2
        '
        Me.NavigationActionContainer2.Controls.Add(Me.NavBarControl1)
        Me.NavigationActionContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationActionContainer2.Location = New System.Drawing.Point(0, 0)
        Me.NavigationActionContainer2.Model = Nothing
        Me.NavigationActionContainer2.Name = "NavigationActionContainer2"
        Me.NavigationActionContainer2.Size = New System.Drawing.Size(132, 550)
        Me.NavigationActionContainer2.TabIndex = 0
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
        Me.NavBarControl1.Appearance.GroupHeader.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NavBarControl1.Appearance.GroupHeader.Options.UseFont = True
        Me.NavBarControl1.Appearance.Item.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarControl1.Appearance.Item.Options.UseFont = True
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavBarControl1.ExplorerBarShowGroupButtons = False
        Me.NavBarControl1.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.nbiSystem, Me.nbiTypeManager, Me.nbiBugType, Me.nbiStaffGroup, Me.nbiAssess, Me.nbiGroupsManage})
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 132
        Me.NavBarControl1.Size = New System.Drawing.Size(132, 550)
        Me.NavBarControl1.TabIndex = 1
        Me.NavBarControl1.Text = "NavBarControl1"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Appearance.BackColor = System.Drawing.Color.White
        Me.NavBarGroup1.Appearance.BackColor2 = System.Drawing.Color.White
        Me.NavBarGroup1.Appearance.BorderColor = System.Drawing.Color.White
        Me.NavBarGroup1.Appearance.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NavBarGroup1.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.NavBarGroup1.Appearance.Options.UseBackColor = True
        Me.NavBarGroup1.Appearance.Options.UseBorderColor = True
        Me.NavBarGroup1.Appearance.Options.UseFont = True
        Me.NavBarGroup1.Appearance.Options.UseForeColor = True
        Me.NavBarGroup1.Appearance.Options.UseTextOptions = True
        Me.NavBarGroup1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NavBarGroup1.AppearanceBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NavBarGroup1.AppearanceBackground.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NavBarGroup1.AppearanceBackground.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NavBarGroup1.AppearanceBackground.Options.UseBackColor = True
        Me.NavBarGroup1.AppearanceBackground.Options.UseBorderColor = True
        Me.NavBarGroup1.AppearanceHotTracked.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NavBarGroup1.AppearanceHotTracked.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NavBarGroup1.AppearanceHotTracked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NavBarGroup1.AppearanceHotTracked.Options.UseBackColor = True
        Me.NavBarGroup1.AppearanceHotTracked.Options.UseBorderColor = True
        Me.NavBarGroup1.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NavBarGroup1.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NavBarGroup1.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NavBarGroup1.AppearancePressed.Options.UseBackColor = True
        Me.NavBarGroup1.AppearancePressed.Options.UseBorderColor = True
        Me.NavBarGroup1.Caption = "系統管理"
        Me.NavBarGroup1.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText
        Me.NavBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiSystem), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiTypeManager), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiBugType), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiStaffGroup), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiGroupsManage), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiAssess)})
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'nbiSystem
        '
        Me.nbiSystem.Appearance.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.nbiSystem.Appearance.Options.UseFont = True
        Me.nbiSystem.Caption = "系統名稱管理"
        Me.nbiSystem.LargeImage = Global.IT_ProjectManager.My.Resources.Resources.sysName
        Me.nbiSystem.Name = "nbiSystem"
        '
        'nbiTypeManager
        '
        Me.nbiTypeManager.Appearance.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.nbiTypeManager.Appearance.Options.UseFont = True
        Me.nbiTypeManager.Caption = "評分標準管理"
        Me.nbiTypeManager.LargeImage = Global.IT_ProjectManager.My.Resources.Resources.Score
        Me.nbiTypeManager.Name = "nbiTypeManager"
        '
        'nbiBugType
        '
        Me.nbiBugType.Appearance.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.nbiBugType.Appearance.Options.UseFont = True
        Me.nbiBugType.Caption = "Bug類型管理"
        Me.nbiBugType.LargeImage = Global.IT_ProjectManager.My.Resources.Resources.Bug1
        Me.nbiBugType.Name = "nbiBugType"
        '
        'nbiStaffGroup
        '
        Me.nbiStaffGroup.Appearance.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.nbiStaffGroup.Appearance.Options.UseFont = True
        Me.nbiStaffGroup.Caption = "人員組別權限"
        Me.nbiStaffGroup.LargeImage = Global.IT_ProjectManager.My.Resources.Resources.Category
        Me.nbiStaffGroup.Name = "nbiStaffGroup"
        Me.nbiStaffGroup.Visible = False
        '
        'nbiGroupsManage
        '
        Me.nbiGroupsManage.Caption = "組別管理"
        Me.nbiGroupsManage.LargeImage = Global.IT_ProjectManager.My.Resources.Resources.Groups
        Me.nbiGroupsManage.Name = "nbiGroupsManage"
        '
        'nbiAssess
        '
        Me.nbiAssess.Appearance.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nbiAssess.Appearance.Options.UseFont = True
        Me.nbiAssess.Caption = "考核標準管理"
        Me.nbiAssess.LargeImage = Global.IT_ProjectManager.My.Resources.Resources.assess
        Me.nbiAssess.Name = "nbiAssess"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(455, 550)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "GroupControl1"
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Appearance.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarItem1.Appearance.Options.UseFont = True
        Me.NavBarItem1.Caption = "系統名稱管理"
        Me.NavBarItem1.LargeImage = Global.IT_ProjectManager.My.Resources.Resources.sysName
        Me.NavBarItem1.Name = "NavBarItem1"
        '
        'SystemManagerMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "SystemManagerMain"
        Me.Size = New System.Drawing.Size(592, 550)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.NavigationActionContainer1.ResumeLayout(False)
        Me.NavigationActionContainer2.ResumeLayout(False)
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents NavigationActionContainer1 As DevExpress.ExpressApp.Win.Templates.ActionContainers.NavigationActionContainer
    Friend WithEvents NavigationActionContainer2 As DevExpress.ExpressApp.Win.Templates.ActionContainers.NavigationActionContainer
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents nbiSystem As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiTypeManager As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiBugType As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiStaffGroup As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents nbiAssess As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiGroupsManage As DevExpress.XtraNavBar.NavBarItem

End Class
