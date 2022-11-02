Public Class Form4
    '【例8.4】输入3个数，求出它们的最大数，将求2个数中的大数编成Function过程，过程
    '名为Max。
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form4_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim a, b, c, s As Single
        a = Val(InputBox("输入第一个数"))
        b = Val(InputBox("输入第二个数"))
        c = Val(InputBox("输入第三个数"))
        s = Max(a, b)
        Debug.Print("最大数是：" & Max(s, c))
    End Sub
    Function Max(ByVal m As Single, ByVal n As Single) As Single
        If m > n Then
            Max = m
        Else
            Max = n
        End If
    End Function
End Class