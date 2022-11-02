Public Class MyForm8
    Private Sub MyForm8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '猜数字
        Dim a, b, c, d As Double
        Dim e1 As Integer = 1000
        For e1 = 1000 To 9999
            a = e1 \ 1000
            d = e1 Mod 10
            b = (e1 \ 100) Mod 10
            c = (e1 Mod 100) \ 10
            If ((a * 1000 + b * 100 + c * 10 + d) - (1000 * b + 100 * a + 10 * a + c) = (d * 100 + d * 10 + a)) Then
                Debug.Print(a)
                Debug.Print(b)
                Debug.Print(c)
                Debug.Print(d)
            End If
            e1 += 1
        Next
    End Sub
End Class