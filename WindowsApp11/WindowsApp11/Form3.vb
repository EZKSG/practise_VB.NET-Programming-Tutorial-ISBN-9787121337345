Public Class Form3
    '【例11.3】在例11.2定义的Square类中，定义一个ErrSide事件，当给定的正方形边长小于
    '0时，引发该事件，并返回错误码“-1”。然后编写对象的ErrSide事件过程实现，当边长小于0
    '时，用消息框给出提示。
    Dim WithEvents S1 As New Square
    '用WithEvents创建一个属于Square类的对象Sl
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '计算
        S1.Side = Val(TextBox1.Text)
        '用TextBox1的内容设置对象的Side属性
        TextBox2.Text = S1.Area()
        '调用Area()方法计算面积
    End Sub
    Private Sub S1_ErrSide() Handles S1.ErrSide
        '对象S1的ErrSide事件过程
        MsgBox("非法边长，请检查！")
    End Sub
End Class