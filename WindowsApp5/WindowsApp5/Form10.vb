Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.PasswordChar = "*"
        TextBox1.Text = ""
        TextBox1.MaxLength = 6
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As Integer
        If Trim(TextBox1.Text) = "123456" Then
            MsgBox("欢迎您用机！")
        Else
            p = MsgBox("密码错误！", 5 + 48, "输入密码")
            If p = 4 Then
                TextBox1.Focus()
            Else
                MsgBox("密码错误，不重试了！")
                'TextBox1.Focus()
                End
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class