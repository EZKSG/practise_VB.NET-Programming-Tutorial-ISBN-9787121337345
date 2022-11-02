Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '【例6.9】多重循环程序示例。
        Dim i, j As Integer
        For i = 1 To 3
            '外循环
            For j = 5 To 7
                '内循环
                Debug.Print(i & Space(2) & j)
                '中间加入2个空格
            Next j
        Next i
    End Sub
End Class