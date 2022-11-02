Public Class MyForm3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, d As Integer, t As String
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)
        If a < b Then
            If b < c Then
                t = a & "<" & b & "<" & c
            ElseIf c < a Then
                t = c & "<" & a & "<" & b
            Else
                t = a & "<" & c & "<" & b
            End If
        Else
            If a < c Then
                t = b & "<" & a & "<" & c
            ElseIf c < b Then
                t = c & "<" & b & "<" & a
            Else
                t = b & "<" & c & "<" & a
            End If

        End If
        TextBox4.Text = t
    End Sub
End Class