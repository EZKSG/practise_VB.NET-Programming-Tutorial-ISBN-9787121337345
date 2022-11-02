Public Class Form1
    '【例10.1】如图10.1所示，在窗体上添加1个文本框和1个标签，当在文本框中键入某一
    '个字符时，在标签中显示该字符及其ASCⅡ码。
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim kasc As Integer
        kasc = Asc(e.KeyChar)
        TextBox1.Text = ""
        Label1.Text = e.KeyChar & "的ASCII码是：" & kasc
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
