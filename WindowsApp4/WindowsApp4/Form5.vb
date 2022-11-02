Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form5_Click(sender As Object, e As EventArgs) Handles Me.Click
        Debug.Print("Print 方法将表达式的值输出到即时窗口上")
        Debug.Print("welcome" & StrDup(5, "*") & "使用")
        Debug.Print("welcome" & Space(5) & "使用")
    End Sub
End Class