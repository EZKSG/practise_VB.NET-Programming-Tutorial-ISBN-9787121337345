Public Class Form9
    '【例8.9】输入一个十进制正整数，将其转换成二进制数、八进制数和十六进制数，如图8.8
    '所示。
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d As Long
        d = Val(TextBox1.Text)
        TextBox2.Text = Fntran(d, 2)
        '调用函数Fntran,转换为二进制数
        TextBox3.Text = Fntran(d, 8)
        '调用函数Fntran,转换为八进制数
        TextBox4.Text = Fntran(d, 16)
        '调用函数Fntran,转换为十六进制数
    End Sub
    Function Fntran(ByVal d As Long, ByVal r As Integer) As String
        Dim t As String, n As Integer
        t = ""
        Do While d > 0
            '直到商为0
            n = d Mod r
            '取余数
            d = d \ r
            '求商
            If n > 9 Then
                '超过9时转换成对应的A一F十六进制数码
                t = Chr(n + 55) & t
                '换码为字母（如10换码为A),反序加入
            Else
                t = n & t
                '反序加入
            End If
        Loop
        Fntran = t
    End Function
End Class