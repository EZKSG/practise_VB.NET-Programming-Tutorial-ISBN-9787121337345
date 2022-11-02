Public Class Form17
    '【例6.17】求解s=1!+2!+3!+…+10!的值。
    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s, t As Long, j, k As Integer
        s = 0
        For j = 1 To 10
            '计算10次阶乘
            t = 1
            '计算1次阶乘前， 先赋初值
            For k = 1 To j
                '计算j, 需要循环j次
                t = t * k
                '连乘j次
            Next k
            s = s + t
            '把每次计算得到的阶乘值t累加
        Next j
        Debug.Print(s)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim s, t As Long, k As Integer
        s = 0 : t = 1
        For k = 1 To 10
            '循环10次， 每次求1个阶乘
            t = t * k
            '求k!, 其值等于(k - 1)k, 即t * k
            s = s + t
            '每次加入一个阶乘值t
        Next k
        Debug.Print(s)
    End Sub
End Class