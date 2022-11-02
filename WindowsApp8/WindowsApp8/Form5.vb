Public Class Form5
    '【例8.5】参数传递方式示例。
    '设置两个通用过程Test1和Tst2,分别按值传递参数和按地址传递参数。
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form5_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim x As Integer = 5
        Debug.Print("执行Testl前，x=" & x)
        Call Test1(x)
        Debug.Print("执行Testl后，Test2前，x=" & x)
        Call Test2(x)
        Debug.Print("执行Test2后，x=" & x)
    End Sub
    Sub Test1(ByVal t As Integer)
        t = t + 5
    End Sub
    Sub Test2(ByRef s As Integer)
        s = s - 5
    End Sub
End Class