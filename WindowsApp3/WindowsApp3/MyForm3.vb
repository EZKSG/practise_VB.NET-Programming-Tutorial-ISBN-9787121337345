Public Class MyForm3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s, s1 As String
        s = TextBox1.Text
        s1 = Strings.Right(Strings.Left(s, s.Length - 1), s.Length - 2)
        TextBox2.Text = s1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Copy()
        TextBox2.Paste()
    End Sub

    Private Sub MyForm3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class