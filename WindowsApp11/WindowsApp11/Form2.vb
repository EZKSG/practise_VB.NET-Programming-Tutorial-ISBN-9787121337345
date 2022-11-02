Public Class Form2
    '【例11.2】在例11.1定义的Square类中，给类定义一个计算正方形面积的方法Area0,并
    '使用该方法来计算某正方形的面积。
    Dim S1 As New Square
    '创建一个属于Square类的对象S1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        S1.Side = Val(TextBox1.Text)
        '用TextBoxl的内容设置对象的Side属性
        TextBox2.Text = S1.Area()
        '调用Area((方法计算面积
    End Sub
End Class