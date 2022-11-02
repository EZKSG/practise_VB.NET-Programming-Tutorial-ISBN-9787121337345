Public Class Form8
    '【例7.8】查找最大数和最小数。
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '查找
        Dim t() As Integer = {89, 96, 81, 67, 79, 90, 63, 85, 95, 83}
        '原始数据
        Dim max, min, i As Integer
        max = t(0)
        '设定初值
        min = t(0)
        For i = 1 To UBound(t)
            '与后面的数据逐一比较
            If max < t(i） Then
                '找最大数
                max = t(i)
            End If
            If min > t(i) Then
                '找最小数
                min = t(i)
            End If
        Next i
        Label1.Text = "最大数：" & max & vbCrLf & "最小数：" & min
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class