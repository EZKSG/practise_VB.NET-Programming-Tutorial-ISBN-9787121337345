Public Class Form6
    '【例7.6】用For Each…Next语句，求1！+2！+…+10！的值。
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a(10), sum, t As Long, n As Integer
        t = 1
        For n = 1 To 10
            t = t * n
            a(n) = t
        Next n
        sum = 0
        For Each x In a
            sum = sum + x
        Next x
        Debug.Print("1！+2!+3!+…+10！=" & sum)
    End Sub
End Class