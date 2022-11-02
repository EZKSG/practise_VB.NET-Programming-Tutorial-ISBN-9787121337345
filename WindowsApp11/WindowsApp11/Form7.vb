Public Class Form7
    '【例11.7】在正方形Square类（见例11.3）的基础上，派生出一个表示正方体的类Cube,
    '再添加计算正方体体积的方法，并编写代码进行测试。
    Dim WithEvents S1 As New Cube
    '创建一个属于Cube类的对象S1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '计算
        S1.Side = Val(TextBox1.Text)
        '设置Side属性
        TextBox2.Text = S1.Area()
        '调用Area()方法计算底面积
        TextBox3.Text = S1.Volume()
        '调用Volume()方法计算体积
    End Sub
    Private Sub S1_ErrSide() Handles S1.ErrSide
        '对象S1的ErrSide事件过程
        MsgBox("非法边长，请检查！")
    End Sub

End Class

Public Class Cube
    '定义派生类Cube
    Inherits Square
    '指定基类Square
    Public Function Volume(） As Single
        '增设方法Volume,用于计算体积
        Return s ^ 3
    End Function
End Class