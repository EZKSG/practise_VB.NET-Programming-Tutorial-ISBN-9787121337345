Public Class Form11
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Strings.Space(12) & "考一考你" & vbCrLf & vbCrLf &
            "今有雉兔同笼，上有二十三头，下有五十六足，问雉兔各几何？" & vbCrLf
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim h, f, x, y, x1, y1 As Integer
        h = 23 : f = 56
        x = (4 * h - f) / 2
        y = (f - 2 * h) / 2
        x1 = Val(InputBox("鸡的只数是多少？"， "请回答"))
        y1 = Val(InputBox("兔的只数是多少？"， "请回答"))
        Debug.Print(x)
        Debug.Print(y)
        Select Case True
            Case x = x1 And y = y1
                MsgBox("回答完全正确!")
            Case x = x1
                MsgBox("鸡数回答正确，但兔数不对!")
            Case y = y1
                MsgBox("兔数回答正确，但鸡数不对!")
            Case Else
                MsgBox("回答错误！")
        End Select
    End Sub
End Class