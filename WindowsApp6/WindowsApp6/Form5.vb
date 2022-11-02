Public Class Form5

    '前测型Do循环语句
    '例6.5 分别利用Do循环语句和For循环语句，计算s=2^2+4^2+6^2+...+100^2。
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '采用Do循环语句：
        Dim n As Integer, s As Long
        n = 2 : s = 0
        Do While n <= 100
            s += n * n
            n += 2
        Loop
        Debug.Print("s=" & s)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '采用For循环语句：
        Dim n1 As Integer, s2 As Long
        s2 = 0
        For n1 = 2 To 100 Step 2
            s2 += n1 * n1
        Next n1
        Debug.Print("s=" & s2)
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class