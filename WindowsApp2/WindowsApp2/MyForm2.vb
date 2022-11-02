Public Class MyForm2
    Private Sub MyForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 400
        Me.Width = 400
        Me.Top = 50
        Me.Left = 50
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Height += 50
        Me.Width += 50
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Height -= 50
        Me.Width -= 50
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class