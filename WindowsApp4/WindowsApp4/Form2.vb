Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f, c As Single, s As String
        f = Val(InputBox("输入华氏温度"))
        c = 5 / 9 * (f - 32)
        s = "输入的华氏温度为:" & Format(f, "00.00") & vbCrLf
        s = s & "转换成摄氏温度为:" & Format(c, "00.00")
        Label1.Text = s
    End Sub
End Class