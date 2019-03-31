Public Class SystemManagerMain
    '' 系統項目名稱管理
    Private Sub nbiSystem_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiSystem.LinkClicked

        Dim ucFrm As New nblSystemNameManage
        GroupControl1.Controls.Clear()
        ucFrm.Dock = DockStyle.Fill
        GroupControl1.Controls.Add(ucFrm)
        ucFrm.Show()

    End Sub
    '' Bug類型管理
    Private Sub nbiBugType_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiBugType.LinkClicked

        Dim frm As New AssessAndBugManage
        frm.xtControl.SelectedTabPageIndex = 0
        frm.ShowDialog()

    End Sub
    '' 載入系統項目名稱
    Private Sub SystemManagerMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        nbiSystem_LinkClicked(Nothing, Nothing)
    End Sub
    '' 顯示考核頁面
    Private Sub nbiAssess_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiAssess.LinkClicked
        Dim frm As New AssessAndBugManage
        frm.xtControl.SelectedTabPageIndex = 1
        frm.ShowDialog()
    End Sub
    '' 組別管理
    Private Sub nbiGroupsManage_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiGroupsManage.LinkClicked
        Dim frm As New GroupManage
        frm.ShowDialog()
    End Sub
    '' 評分標準 
    Private Sub nbiTypeManager_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiTypeManager.LinkClicked
        Dim frm As New ScoreSeting
        frm.ShowDialog()
    End Sub
End Class
