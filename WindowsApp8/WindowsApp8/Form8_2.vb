Public Class Form8_2
    Private Sub Form8_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form8_2_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '返回
        X = Val(TextBox1.Text)
        Y = Val(TextBox2.Text)
        Me.Hide()
        '隐藏“输入数据”窗体
        Form8.Show()
    End Sub
End Class