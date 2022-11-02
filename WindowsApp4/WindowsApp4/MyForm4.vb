Public Class MyForm4
    Private Sub MyForm4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Text = Space(11) & StrDup(1, "*") & vbCrLf &
            Space(10) & StrDup(3, "*") & vbCrLf &
            Space(9) & StrDup(5, "*") & vbCrLf &
            Space(8) & StrDup(7, "*") & vbCrLf &
            Space(7) & StrDup(9, "*") & vbCrLf
    End Sub
End Class