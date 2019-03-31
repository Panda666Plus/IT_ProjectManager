Module AssessPublicModel
    ''' <summary>
    ''' 清除控件
    ''' </summary>
    ''' <param name="Assess">控件名称</param>
    ''' <remarks></remarks>
    Sub DeleteRatingStar(ByVal Assess As DevExpress.XtraEditors.XtraScrollableControl, ByRef label As DevExpress.XtraEditors.LabelControl)

        Dim ctrl As New Control

        Dim i As Integer

        For i = 0 To Assess.Controls.Count

            label.Text = 3

            For Each ctrl In Assess.Controls

                Try
                    If TypeOf (ctrl) Is RatingStar Then
                        Assess.Controls.Remove(ctrl)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "请注意", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End Try

            Next

        Next

    End Sub

    ''' <summary>
    ''' 建立控件
    ''' </summary>
    ''' <param name="strID"></param>
    ''' <param name="strName"></param>
    ''' <param name="strRemark"></param>
    ''' <param name="lngValue"></param>
    ''' <remarks></remarks>
    Sub CreateRatingStar(ByVal strID As String, ByVal strName As String, ByVal strRemark As String, ByVal lngValue As Long,
                         ByVal Assess As DevExpress.XtraEditors.XtraScrollableControl, ByRef label As DevExpress.XtraEditors.LabelControl)

        Dim xx As New RatingStar(strID, strName, strRemark, lngValue)
        xx.Top = label.Text
        xx.Left = 3
        xx.Width = 298
        xx.Height = 50
        xx.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
        Assess.Controls.Add(xx)
        label.Text = CLng(label.Text) + 49

    End Sub

End Module
