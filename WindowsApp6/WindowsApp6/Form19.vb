Public Class Form19
    '【例6.19】编制程序，把一批课程名放入组合框中，再对
    '组合框进行列表项显示、添加、删除、全部删除等操作。
    Private Sub Form19_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("电子商务")
        '添加一批课程名
        ComboBox1.Items.Add("网页制作")
        ComboBox1.Items.Add("Internet简明教程")
        ComboBox1.Items.Add("计算机网络基础")
        ComboBox1.Items.Add("多媒体技术")
        ComboBox1.Text = ""
        '置空值
        TextBox1.Text = ComboBox1.Items.Count
        '列表项总数
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '全清
        ComboBox1.Items.Clear()
        TextBox1.Text = 0
        ComboBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '删除
        Dim ind As Integer
        ind = ComboBox1.SelectedIndex
        If ind <> -1 Then
            '-1表示未选定列表项
            ComboBox1.Items.RemoveAt(ind)
            '删除已选定的列表项
            TextBox1.Text = ComboBox1.Items.Count
        End If
        ComboBox1.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '添加        
        If Len(ComboBox1.Text) > 0 Then
            ComboBox1.Items.Add(ComboBox1.Text)
            TextBox1.Text = ComboBox1.Items.Count
        End If
        ComboBox1.Text = ""
        ComboBox1.Focus()
    End Sub
End Class