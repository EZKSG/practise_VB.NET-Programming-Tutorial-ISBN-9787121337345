Public Class Form5
    '【例7.5】ReDim语句应用示例。
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a(5), k, x, j As Integer
        ReDim a(500)
        '动态改变数组a的大小
        k = 0
        For x = 1000 To 2000 Step 3
            If x Mod 8 = 0 Then
                k = k + 1
                a(k) = x
                '存入数据
            End If
        Next x
        ReDim Preserve a(k)
        '重新定义数组a,并保留原有数据
        For j = 1 To k
            Debug.Write(a(j) & Space(2))
            If j Mod 10 = 0 Then Debug.Write(vbCrLf)
        Next j
    End Sub
End Class