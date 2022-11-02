Public Class Form12
    '【例8.12】加密和解密。
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '加密
        Dim s As String
        s = Trim(TextBox1.Text)
        TextBox2.Text = FnTr(1, s)
        '显示加密结果
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '解密
        Dim s As String
        s = Trim(TextBox2.Text)
        TextBox3.Text = FnTr(-1, s)
        '显示解密结果
    End Sub

    Function FnTr(ByVal t As Integer, ByVal x As String) As String
        'FnTr函数过程
        Dim k, tasc As Integer, s, code As String
        code = ""
        For k = 1 To Len(x)
            s = Mid(x, k, 1)
            Select Case s
                Case "A" To "Z"
                    '处理大写字母
                    tasc = Asc(s) + 4 * t
                    '通过t来控制加密（+4）或解密（-4）操作
                    If tasc < Asc("A") Or tasc > Asc("Z") Then tasc -= 26 * t
                    code = code & Chr(tasc)
                Case "a" To "z"
                    '处理小写字母
                    tasc = Asc(s) + 3 * t
                    If tasc < Asc("a") Or tasc > Asc("z") Then tasc -= 26 * t
                    code = code & Chr(tasc)
                Case "0" To "9"
                    '处理数字字符
                    tasc = Asc(s) + 2 * t
                    If tasc < Asc("0") Or tasc > Asc("9") Then tasc -= 10 * t
                    code = code & Chr(tasc)
                Case Else
                    '其他字符，不处理
                    code = code & s
            End Select
        Next
        FnTr = code
    End Function
End Class