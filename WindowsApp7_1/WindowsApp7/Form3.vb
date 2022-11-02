Public Class Form3
    '【例7.3】利用多行文本框输入一系列数字数据，数据之间以逗号“，”为分隔符，输入完成
    '后将数据按分隔符分离并保存在数组中。
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As String, p As Integer
        s = TextBox1.Text
        ListBox1.Items.Clear()
        p = InStr(s, ",")
        '查找逗号“，”
        Do While p > 0
            '找到逗号时执行循环
            ListBox1.Items.Add(Strings.Left(s, p - 1))
            '取出前面一个数据，添加到列表框中
            s = Mid(s, p + 1)
            '获取剩余数字串
            p = InStr(s, ",")
            '再找逗号“，”
        Loop
        ListBox1.Items.Add(s)
        '保存最后一项
        Label3.Text = "数据个数：" & ListBox1.Items.Count
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class