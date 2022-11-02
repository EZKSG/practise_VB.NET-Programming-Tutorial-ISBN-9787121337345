Public Class Form10
    '【例9.10】使用Try..Case…Finally结构示例。类似例9.9，主要针对“数组下标越界”错误
    '的处理，代码如下：
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form10_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim d(5), k As Integer
        Try
            k = 6
            d(k) = 0
        Catch ex As IndexOutOfRangeException
            '数组下标越界异常
            ReDim Preserve d(10)
            '若是，则重新定义数组，保留原数据
        Catch ex As ArithmeticException
            '算术运算导致溢出
            MsgBox(ex.Message)
            '显示错误信息
        Catch ex As Exception
            '普通错误，即其他没有考虑到的错误
            MsgBox(ex.Message)
        Finally
            d(k) = 99
            MsgBox(d(k))
        End Try
    End Sub
End Class