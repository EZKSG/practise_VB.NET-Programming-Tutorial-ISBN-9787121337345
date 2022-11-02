Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '例6.4 用级数π/4 =1-1/3+1/5-1/7 ... 求π的近似值，要求取前5000项来计算。
        Dim pi As Single, c, s3 As Integer
        pi = 0
        s3 = 1
        For c = 1 To 9999 Step 2
            pi += s3 / c
            s3 = -s3
        Next c
        Debug.Print("π= " & 4 * pi)
        '编程时要尽量采用运算强度弱的语句，能用加减，就不用乘除，尽量避免使用乘方运算。
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class