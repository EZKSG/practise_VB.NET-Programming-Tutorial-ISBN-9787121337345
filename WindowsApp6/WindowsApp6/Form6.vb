Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        '例6.6 我国有13亿人口，按人口数年平均增长率0.57%计算，多少年后我国人口数超过20亿。
        '计算公式：20=13*(1+0.0057)^n
        Dim s4 As Single, n2 As Integer
        s4 = 13 : n2 = 0
        Do While s4 < 20
            s4 *= 1.0057
            n2 += 1
        Loop
        Debug.Print(n2 & "年后我国人口达到" & s4)
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class