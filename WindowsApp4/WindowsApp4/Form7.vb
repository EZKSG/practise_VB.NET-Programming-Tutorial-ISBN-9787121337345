Public Class Form7
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, a, b As String, p As Integer
        x = Trim(TextBox1.Text)
        p = InStr(x, "@")
        a = Strings.Left(x, p - 1)
        b = Mid(x, p + 1)
        TextBox2.Text = a
        TextBox3.Text = b
    End Sub
End Class