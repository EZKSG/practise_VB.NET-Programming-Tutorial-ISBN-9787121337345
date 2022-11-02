Public Class Form1
    '【例7.1】输入某小组5名同学的成绩，计算总分和平均分（取小数后一位数字）。
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d(5) As Integer
        Dim total, i As Integer, average As Single
        For i = 1 To 5
            '输入成绩
            d(i) = Val(InputBox("输入第" & i & "名学生的成绩"， "输入成绩"))
        Next i
        total = 0
        For i = 1 To 5
            '计算总分
            total = total + d(i)
        Next i
        average = total /5
        '计算平均分
        Debug.Print("总分： " & total)
        Debug.Print("平均分：" & Format(average, "##.0"))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
