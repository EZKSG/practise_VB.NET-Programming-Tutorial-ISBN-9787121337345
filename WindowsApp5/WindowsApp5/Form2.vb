Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, m As Integer
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)
        If a > b Then
            m = a
        Else
            m = b
        End If
        If c > m Then m = c
        TextBox4.Text = m
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class