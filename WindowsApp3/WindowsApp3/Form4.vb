Public Class Form4
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer, s As String
        Randomize()
        a = Int(90 * Rnd() + 10)
        b = Int(90 * Rnd() + 10)
        c = a + b
        s = a & "+" & b & "+" & "=" & c
        TextBox1.Text = s
    End Sub
End Class