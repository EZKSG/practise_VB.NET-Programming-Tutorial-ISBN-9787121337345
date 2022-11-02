Public Class Form1
    '【例8.1】Sub过程的示例。
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Call Mysub1(30)
        Call Mysub2()
        Call Mysub2()
        Call Mysub2()
        Call Mysub1(30)
    End Sub

    Private Sub Mysub1(ByVal n As Integer)
        Debug.Print(StrDup(n, "*"))
        '输出连续n个"*"号
    End Sub
    Private Sub Mysub2()
        Debug.Print("*" & Space(28) & "*")
        '输出头尾各一个"*"号
    End Sub
End Class
