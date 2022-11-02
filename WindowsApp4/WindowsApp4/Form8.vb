Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "红字文本框"
        TextBox2.Text = "绿字文本框"
        TextBox1.ForeColor = Color.Red
        TextBox2.ForeColor = Color.Green
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txt As String, col
        txt = TextBox1.Text
        TextBox1.Text = TextBox2.Text
        TextBox2.Text = txt
        col = TextBox1.ForeColor
        TextBox1.ForeColor = TextBox2.ForeColor
        TextBox2.ForeColor = col
    End Sub
End Class