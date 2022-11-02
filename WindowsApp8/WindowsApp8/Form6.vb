Public Class Form6
    '【例8.6】数组作为参数的示例。
    '编写一个Function过程FnsumO,求任意一维数组中各元素的n次方之和。调用该过程并输
    '出结果。
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form6_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim n As Integer = 3
        '求3次方
        Dim x() As Single = {1.2, 1.3, 1.4, 1.5, 1.6, 1.7}
        '数组初始化赋值
        Debug.Print(Fnsum(x, n))
        '调用函数过程Fnsum, 其中x为数组实参
    End Sub
    Function Fnsum(ByRef y() As Single, ByVal n As Integer) As Single
        'y0为数组形参
        Dim s As Single, k As Integer
        s = 0
        For k = 0 To UBound(y)
            s = s + y(k) ^ n
        Next k
        Return s
        '返回s值
    End Function
End Class