Public Class Form4
    '【例7.4】调用Split函数来实现例7.3的程序功能。
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '分离
        Dim t() As String
        '声明数组t,供SplitO函数使用
        Dim i As Integer
        ListBox1.Items.Clear()
        t = Split(TextBox1.Text, ",")
        '以逗号为分隔符分离，子串放入数组t中
        For i = 0 To UBound(t)
            'UBound()函数返回数组t的下标上界值
            ListBox1.Items.Add(t(i))
        Next i
        Label3.Text = "数据个数：" & UBound(t) + 1
    End Sub
End Class