Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form6_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim x, a, b, c As Integer
        x = Val(InputBox("输入一个两位数"))
        a = Int(x / 10)
        b = x Mod 10
        c = b * 10 + a
        Debug.Print("处理结果：" & c)
    End Sub
End Class