Imports System.Data.SqlClient
Public Class SoftIssueTrace

    Private Sub getdate()
        Dim ds As DataSet = DbServices.DbHelperSQL.Query(String.Format("select * from dbo.IT_SoftIssueTrace where rowguid='{0}'", _rowid))
        If (IsNothing(ds)) Then
            Return
        End If

        Dim dr As DataRow = ds.Tables(0).Rows(0)
        tb_verNo.Text = dr("verNo").ToString()
        tb_issueNo.Text = dr("issueNo").ToString()
        lp_applyissuer.EditValue = dr("applyissuer").ToString()
        If dr("applyDate").ToString() <> "" Then
            tb_applyDate.EditValue = dr("applyDate")
        End If
        If dr("applyissueDate").ToString() <> "" Then
            tb_applyissueDate.EditValue = dr("applyissueDate")
        End If

        me_issueReason.Text = dr("issueReason")
        be_issueArea.Text = dr("issueArea")
        me_ps.EditValue = dr("PS").ToString()
        lp_issuer.EditValue = dr("issuer").ToString()
        If dr("issueDate").ToString() <> "" Then
            tb_issueDate.EditValue = dr("issueDate")
        End If

        me_issurDesc.EditValue = dr("issueDesc").ToString()





    End Sub

    Private Sub loaddata()
        SystemName.Text = _tSystemName

        If (_flag) Then


            Dim sstr As String = Integer.Parse(DbServices.DbHelperSQL.Query("select count(*) from dbo.IT_SoftIssueTrace where convert(nvarchar(10),create_time,120)=convert(nvarchar(10),getdate(),120)").Tables(0).Rows(0)(0) + 1).ToString()

            tb_issueNo.Text = Now.Year.ToString() &
                             ("00" & Now.Month.ToString()).Substring(("00" & Now.Month.ToString()).Length - 2) &
                             ("00" & Now.Day.ToString()).Substring(("00" & Now.Day.ToString()).Length - 2) &
                              ("000" & sstr).Substring(("000" & sstr).Length - 3)

            Dim iver As Single = Single.Parse(DbServices.DbHelperSQL.Query(String.Format("select isnull(max(verNo),0) from dbo.IT_SoftIssueTrace where projectNo='{0}'", _tSystemID)).Tables(0).Rows(0)(0).ToString())
            If iver = 0 Then
                tb_verNo.Text = "1.0"
            Else
                tb_verNo.Text = Math.Round((iver + 0.1), 1).ToString()
            End If
            be_issueArea.EditValue = _area
            tb_applyDate.Text = Now.ToString("yyyy-MM-dd")
        Else
            getdate()
        End If

        lp_applyissuer.Properties.ValueMember = "UserName"
        lp_applyissuer.Properties.DisplayMember = "UserName"
        lp_applyissuer.Properties.DataSource = DbServices.DbHelperSQL.Query("   select UserName from IT_PersonnelGroups where isjob=1").Tables(0)

        lp_issuer.Properties.ValueMember = "UserName"
        lp_issuer.Properties.DisplayMember = "UserName"
        lp_issuer.Properties.DataSource = DbServices.DbHelperSQL.Query("   select UserName from IT_PersonnelGroups where isjob=1").Tables(0)

    End Sub
    Private _tSystemName As String
    Private _tSystemID As String
    Private _flag As Boolean
    Private _rowid As String
    Private _area As String
    Public Sub New()
        InitializeComponent()
    End Sub
    Sub New(ByVal tSystemID As String, ByVal tSystemName As String, ByVal flag As Boolean, ByVal rowid As String, ByVal area As String)
        InitializeComponent()
        _tSystemID = tSystemID
        _tSystemName = tSystemName
        _flag = flag
        _rowid = rowid
        _area = area
    End Sub

    Private Sub SoftIssueTrace_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub be_issueArea_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles be_issueArea.ButtonClick
        Dim xx As New deptlist
        If xx.ShowDialog() = DialogResult.OK Then
            be_issueArea.Text = xx.s
        End If

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click

        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim xml As String
        xml = "<rd>"
        If _flag Then
            xml = xml & "<operation>new</operation>"
        Else
            xml = xml & "<operation>modi</operation>"
        End If
        xml = xml & "<rowid>" & Me._rowid & "</rowid>" &
                "<projectName>" & SystemName.Text & "</projectName>" &
               "<issueNo>" & tb_issueNo.Text & "</issueNo>" &
                "<verNo>" & tb_verNo.Text & "</verNo>" &
                "<applyissuer>" & lp_applyissuer.Text & "</applyissuer>" &
                "<applyDate>" & tb_applyDate.Text & "</applyDate>" &
                "<applyissueDate>" & tb_applyissueDate.Text & "</applyissueDate>" &
                "<issueReason>" & me_issueReason.Text & "</issueReason>" &
                 "<issueArea>" & be_issueArea.Text & "</issueArea>" &
                "<ps>" & me_ps.Text & "</ps>" &
                "<issuer>" & lp_issuer.Text & "</issuer>" &
                "<issueDate>" & tb_issueDate.Text & "</issueDate>" &
                "<issueDesc>" & me_issurDesc.Text & "</issueDesc>" &
                "</rd>"
        ' MessageBox.Show(xml)
        Dim params() As SqlParameter = {
                New SqlParameter("@xml", xml),
                New SqlParameter("@username", UserName),
                New SqlParameter("@msg", SqlDbType.NChar, 100)
              }
        params(2).Direction = ParameterDirection.Output

        Try
            DbServices.DbHelperSQL.RunProcedure("dbo.updatetSoftIssueTrace", params)
            MessageBox.Show(params(2).Value, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "项目管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class