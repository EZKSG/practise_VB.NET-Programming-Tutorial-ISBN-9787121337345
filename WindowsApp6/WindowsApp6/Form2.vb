Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Form2_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '例6.2 求1~8之和。
        Dim s, k1 As Integer
        s = 0
        For k1 = 1 To 8
            s = s + k1
        Next k1
        Debug.Print("s=" & s)
    End Sub
End Class