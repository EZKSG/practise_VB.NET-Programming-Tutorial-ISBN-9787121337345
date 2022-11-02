Public Class Form14
    '【例6.14】百元买百鸡问题。用100元买100只鸡，母鸡3元1只，小鸡1元3只，问各应买多少只？
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y As Integer
        For x = 1 To 30
            y = 100 - x
            If 3 * x + y / 3 = 100 Then
                Debug.Print("母鸡只数为：" & x)
                Debug.Print("小鸡只数为：" & y)
            End If
        Next x
    End Sub
End Class