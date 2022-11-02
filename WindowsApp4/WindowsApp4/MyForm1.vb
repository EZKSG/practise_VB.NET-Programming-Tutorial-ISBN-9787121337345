Public Class MyForm1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, d, f As Integer
        a = Val(TextBox1.Text)
        b = a \ 100
        Debug.Print(b)
        c = (a Mod 100) \ 10
        Debug.Print(c)
        d = a Mod 10
        f = 100 * d + 10 * c + b
        TextBox2.Text = f
    End Sub

    Private Sub MyForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class