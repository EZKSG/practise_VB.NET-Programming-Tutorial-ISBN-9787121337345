Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form3_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim x As String
        x = InputBox("Input your name.", "What is your name?")
        MsgBox(x & " sir : good luck!")
    End Sub
End Class