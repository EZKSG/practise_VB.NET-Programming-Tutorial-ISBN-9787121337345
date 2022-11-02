Public Class MyForm1
    Private Sub MyForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MyForm1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim a, b, c, min As Single
        a = Val(InputBox("输入第1个数"))
        b = Val(InputBox("输入第2个数"))
        c = Val(InputBox("输入第3个数"))
        min = c
        If b < min Then min = b
        If a < min Then min = a
        MsgBox("最小数为：" & min)
    End Sub
End Class