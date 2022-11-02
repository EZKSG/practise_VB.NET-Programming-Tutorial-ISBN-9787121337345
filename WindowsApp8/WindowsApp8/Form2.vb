Public Class Form2
    '【例8.2】计算51+10！。
    '因为计算5！和10！都要用到阶乘n!,所以把计算n编成Sub过程。
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form2_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim y, s As Long
        Call Je(5, y)
        s = y
        Call Je(10, y)
        Debug.Print("5!+10!=" & s + y)
    End Sub
    Private Sub Je(ByVal n As Integer, ByRef t As Long)
        '参数：  t   用于返回阶乘值
        Dim i As Integer
        t = 1
        For i = 1 To n
            t = t * i
        Next i
    End Sub
End Class