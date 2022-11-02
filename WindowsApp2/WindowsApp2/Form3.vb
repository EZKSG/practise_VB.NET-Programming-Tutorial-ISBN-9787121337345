Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Label1.Text = "computer program design"
        Label1.BackColor = Color.Yellow
        Label1.Font = New Font("宋体", 18)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r, g, b As Integer
        r = Int(255 * Rnd())
        g = Int(255 * Rnd())
        b = Int(255 * Rnd())
        Label1.ForeColor = Color.FromArgb(r, g, b)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Visible = True
    End Sub
End Class