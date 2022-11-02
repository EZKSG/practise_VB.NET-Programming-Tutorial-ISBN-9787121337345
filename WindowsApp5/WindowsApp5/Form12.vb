Public Class Form12
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim y, m, d As Integer
        y = Val(TextBox1.Text)
        m = Val(TextBox2.Text)
        Select Case m
            Case 1, 3, 5, 7, 8, 10, 12
                d = 31
            Case 4, 6, 9, 11
                d = 30
            Case 2
                If (y Mod 4 = 0 And y Mod 100 <> 0) Or (y Mod 400 = 0) Then
                    d = 29
                Else
                    d = 28
                End If
            Case Else
                TextBox3.Text = "非法月份！"
                Exit Sub
        End Select
        TextBox3.Text = d
    End Sub
End Class