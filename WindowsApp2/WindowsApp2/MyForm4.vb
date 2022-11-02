Public Class MyForm4
    Private Sub MyForm4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Hello"
    End Sub

    Private Sub MyForm4_Click(sender As Object, e As EventArgs) Handles Me.Click
        Button1.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Visible = True
        Label1.Text = "You have issued the display command"
    End Sub
End Class