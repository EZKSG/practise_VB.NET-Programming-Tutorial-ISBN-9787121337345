Public Class Form7
    '【例9.7】假设有以下一个窗体的CiCk事件过程：
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form7_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim a, b As Integer
        a = 8 / b
        MsgBox(a)
        '运行时单击窗体，弹出一个出错提示框，提示发生“算术运算导致溢出”的错误，
        '试模式。为了检查出错原因，可以在即时窗口中键入以下命令来检查变量b的值：？b
    End Sub
End Class