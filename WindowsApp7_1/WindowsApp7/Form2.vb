Public Class Form2
    '【例7.2】产生一批50~100随机数，作为表7.1中10名学生5门课的成绩，
    '然后算出每门课的平均分。
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a(10,5),i,j,s As Integer
        '二维数组a存放成绩数据
        Dim ke() As String = {"语文"， "外语"， "数学"， "物理"， "化学"}
        '存放课程名
        Randomize()
        For i = 1 To 10
            '控制行数
            For j = 1 To 5
                '控制列数
                a(i, j) = Int(51 * Rnd() + 50)
                '随机数存放在数组的第ⅰ行j列中
            Next j
        Next i
        For j = 1 To 5
            '控制列数
            s = 0
            '累加前清0
            For i = 1 To 10
                '控制行数
                s = s + a(i, j)
                '累加同一列数组元素值
            Next i
            Debug.Print(ke(j - 1) & "科的平均分：" & Format(s / 10, "##.0"))
        Next j
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class