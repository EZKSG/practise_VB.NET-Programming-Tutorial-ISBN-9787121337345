Public Class Form9
    Dim t As Integer
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        t = Val(TextBox1.Text) * 60 + Val(TextBox2.Text)
        If t = 0 Then
            MsgBox("Please input countdown number")
            Exit Sub
        End If
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim m, s As Integer
        t -= 1
        m = t \ 60
        s = t Mod 60
        TextBox1.Text = Format(m, "00")
        TextBox2.Text = Format(s, "00")
        If t = 0 Then
            Timer1.Enabled = False
            MsgBox("Time out！")
        End If
    End Sub
End Class