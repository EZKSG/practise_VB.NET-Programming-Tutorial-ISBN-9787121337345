Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '例6.3 求8的阶乘。
        Dim s1, k2 As Integer
        s1 = 1
        For k2 = 1 To 8
            s1 *= k2
        Next k2
        Debug.Print("s1=" & s1)
    End Sub
End Class