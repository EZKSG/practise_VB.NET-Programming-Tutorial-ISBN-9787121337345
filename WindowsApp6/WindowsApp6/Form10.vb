Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '【例6.10】输出如图6.5所示的九九乘法表。
        Dim i, j, k As Integer, s, x As String
        s = Space(28) & "9*9" & vbCrLf
        For i = 1 To 9
            For j = i To 9
                x = i & " * " & j & " = " & i * j       '用字符串生成一项：被乘数*乘数=积
                s = s & x & Space(15 - Len(x))       '显示一个项，每项占15个位
            Next j                                                  '通过Space函数生成一定数目的空格
            k = i * 10                                             '使用vbCrLf强制换行
            'k += 7
            s = s & vbCrLf & StrDup(k, "*")
        Next i
        Label1.Text = s
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class