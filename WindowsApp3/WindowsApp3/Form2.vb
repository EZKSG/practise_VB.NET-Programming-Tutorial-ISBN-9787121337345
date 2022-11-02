Imports System.Math
Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y As Single
        x = Val(TextBox1.Text)          'Val是转换函数，将数字字符串转换为数值
        y = Sqrt(x ^ 2 + x ^ 3)
        TextBox2.Text = y
    End Sub
End Class
