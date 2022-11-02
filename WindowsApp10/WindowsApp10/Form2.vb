Public Class Form2
    '【例10.2】编一程序段，使得文本框TextBox1(多行)中限定只能输入英文字母（含大、
    '小写)及逗号，只能接收回车键及BackSpace键。
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim kasc As Integer
        kasc = Asc(e.KeyChar)
        Select Case kasc
            Case 65 To 90, 97 To 122, 44, 8, 13
                '有效字符，可以继续输入
            Case Else
                e.Handled = True
                '去除无效字符，重新输入
        End Select
    End Sub
End Class