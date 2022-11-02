Public Class Form15
    '【例6.15】用递推法求x=√a,求平方根的递推公式为：xnl = (xn0 + a / xn0) / 2
    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, xn0, xn1 As Single
        '用xn0表示旧值， xn1表示新值
        a = Val(InputBox("请输入一个正数"))
        xn1 = a
        '以a作为x的初值
        Do
            xn0 = xn1
            '给定旧值
            xn1 = (xn0 + a / xn0) / 2
            '计算新值
        Loop While Math.Abs(xn0 - xn1) >= 0.00001
        '判断
        Debug.Print(a & "的平方根为" & xn1)
    End Sub
End Class