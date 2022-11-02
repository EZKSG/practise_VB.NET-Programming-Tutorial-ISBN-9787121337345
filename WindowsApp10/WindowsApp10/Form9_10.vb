Public Class Form9_10
    '【例10.9】在窗体上添加1个文本框和1个“改变字体”按钮，单击该按钮可打开“字体”
    '对话框，选定字体、字形、大小等之后，单击“确定”按钮，可使文本框中的字体属性发生相应
    '的变化。
    '【例10.10】在窗体上添加1个文本框和1个“改变颜色”按钮，单击该按钮可打开“颜色”
    '对话框，选定颜色之后单击“确定”按钮，可使文本框中的文字颜色发生相应的变化。
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ColorDialog1.ShowDialog()
        TextBox2.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FontDialog1.ShowDialog()
        TextBox1.Font = FontDialog1.Font
    End Sub
End Class