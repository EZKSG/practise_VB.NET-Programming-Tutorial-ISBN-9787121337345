Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        '后测型Do循环语句
        '例6.7 输入两个正整数，求它们的最大公约数。
        Dim m, n, p As Integer
        m = Val(TextBox1.Text)
        n = Val(TextBox2.Text)
        Do
            p = m Mod n
            m = n
            n = p
        Loop While p <> 0
        TextBox3.Text = m

    End Sub
End Class