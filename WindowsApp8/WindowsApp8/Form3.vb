Public Class Form3
    '【例8.3】将例8.2中求n!的Sub过程改成Function过程，实现同样的功能。
    '分析：在前面例8.2中，因为Sub过程名不能返回值，所以需要在形参表中引入另一个参数
    't来返回阶乘值。如果改成用Function过程实现，则阶乘值可由函数名返回，因此只需要设置一
    '个参数n。
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form3_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim s As Long
        s = Jc(5) + Jc(10)
        '函数调用
        Debug.Print("5! + 10!=" & s)
    End Sub
    Function Jc(ByVal n As Integer) As Long
        '返回值的数据类型为Long
        Dim i As Integer, t As Long
        t = 1
        For i = 1 To n
            t = t * i
        Next i
        Jc = t
        '返回值赋给函数名
    End Function
End Class