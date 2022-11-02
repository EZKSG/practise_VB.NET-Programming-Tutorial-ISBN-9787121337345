Public Class Form7
    '【例8.7】输入两个数n、m,求组合数n!/m!*(n-m)!的
    '值。
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form7_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim m,n As Integer
        m = Val(InputBox("输入m的值"))
        n = Val(InputBox("输入n的值"))
        If m>n Then
            MsgBox("输入数据错误”， 0， "检查错误")
            End
        End If
        Debug.Print("组合数是：" & Calcomb(n, m))
    End Sub
    Private Function Calcomb(ByVal n, ByVal m)
        Calcomb = Jc(n) / (Jc(m) * Jc(n - m))
    End Function
    Private Function Jc(ByVal x)
        Dim i As Integer, t As Long
        t = 1
        For i = 1 To x
            t = t * i
        Next i
        Jc = t
    End Function
    '程序代码中，采用了过程的嵌套调用方式。在事件过程Forml Click中调用了Calcomb过程，
    '而在Calcomb过程中先后调用了3次Jc过程。
End Class