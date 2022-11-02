Public Class Form13
    '【例6.13】使用3个不同样式的组合框，分别用于选择学校、专业和学历。
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = ComboBox1.Items(0)
        ComboBox2.Text = ComboBox2.Items(0)
        ComboBox3.Text = ComboBox3.Items(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ComboBox1.Text & ComboBox2.Text & ComboBox3.Text
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class