Public Class Form12

    '【例6.12】设计一个选课程序。
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("电子商务")
        '添加一批课程名
        ListBox1.Items.Add("网页制作")
        ListBox1.Items.Add("Internet简明教程")
        ListBox1.Items.Add("计算机网络基础")
        ListBox1.Items.Add("多媒体技术")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '选定
        Dim i As Integer
        For i = 0 To ListBox1.Items.Count - 1
            '逐项判断
            If ListBox1.GetSelected(i) Then
                '选中为真
                ListBox2.Items.Add(ListBox1.Items(i))
            End If
        Next i
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '清除
        ListBox2.Items.Clear()
        '清除列表框中的内容
    End Sub
End Class