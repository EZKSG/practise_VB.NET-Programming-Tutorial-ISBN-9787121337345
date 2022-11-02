Public Class MyForm2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r, a, p As Double
        r = Val(TextBox1.Text)
        a = Math.PI * r * r
        p = Math.PI * r * 2
        TextBox2.Text = p
        TextBox3.Text = a
    End Sub
End Class