Public Class Form8_3
    Private Sub Form8_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '加法
        TextBox1.Text = X + Y
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '乘法
        TextBox1.Text = X * Y
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '返回
        Me.Hide()
        '隐藏“计算”窗体
        Form1.Show()
        '显示主窗体
    End Sub
End Class