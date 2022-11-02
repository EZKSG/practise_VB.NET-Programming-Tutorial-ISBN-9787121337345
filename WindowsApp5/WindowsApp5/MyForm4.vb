Public Class MyForm4
    Private Sub MyForm4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        a = Val(TextBox1.Text)
        Select Case a
            Case 300 To 1000 And a <> 1000
                a *= 0.03
            Case 1000 To 5000 And a <> 5000
                a *= 0.05
            Case 5000 To 20000 And a <> 20000
                a *= 0.1
            Case Is <= 20000
                a *= 0.15
            Case Else
                MsgBox("出错")
                End
        End Select
        TextBox2.Text = a
    End Sub
End Class