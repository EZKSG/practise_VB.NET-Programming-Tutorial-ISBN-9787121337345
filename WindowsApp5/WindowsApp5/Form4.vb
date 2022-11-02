Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double, b As String
        a = Val(TextBox1.Text)
        Select Case a
            Case Is < 60
                b = "不及格"
            Case Is > 79
                b = "优良"
            Case 60 To 80
                b = "及格"
            Case Else
                b = "Error"
        End Select
        Label2.Text = "成绩等级为：" & b
    End Sub
End Class