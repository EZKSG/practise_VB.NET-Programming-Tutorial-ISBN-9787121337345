Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "禅"
        Timer1.Enabled = True
        Timer1.Interval = 80
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Font.Size < 100 Then
            Label1.Font = New Font(Label1.Font.Name, Label1.Font.Size * 1.2)
        Else
            Label1.Font = New Font(Label1.Font.Name, 8)
        End If
    End Sub
End Class