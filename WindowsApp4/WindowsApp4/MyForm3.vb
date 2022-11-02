Public Class MyForm3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s1, s2, s3 As String
        s1 = TextBox1.Text
        's2 = InStr(s1, "*")
        Dim a As Integer = TextBox1.Text.Length()
        Debug.Print(a)
        s2 = Strings.Right(s1, s1.Length - InStr(1, s1, "*"))
        s3 = Strings.Left(s2, InStr(s2, "*") - 1)
        TextBox2.Text = s3
    End Sub

    Private Sub MyForm3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = Strings.Left(Strings.Right(TextBox1.Text, TextBox1.Text.Length() - InStr(TextBox1.Text, "*")), (InStr(Strings.Right(TextBox1.Text, (TextBox1.Text.Length() - InStr(TextBox1.Text, "*"))), "*") - 1))
    End Sub
End Class