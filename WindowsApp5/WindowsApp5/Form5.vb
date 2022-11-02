Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        'TextBox1.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        TextBox1.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles RadioButton3.Click
        TextBox1.TextAlign = HorizontalAlignment.Right
    End Sub
End Class