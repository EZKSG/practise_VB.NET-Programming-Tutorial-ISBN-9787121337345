Public Class Form1
    '【例11.1】创建一个表示正方形的类Square,并定义一个表示边长的Side属性，编写一个
    '应用该类及其属性的程序。

    Dim S1 As New Square(10)
    '创建一个属于Square类的对象S1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '设置
        S1.Side = Val(TextBox1.Text)
        '用文本框的内容设置对象的Side属性
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '读出
        TextBox2.Text = S1.Side
        '读出对象的Side属性值
    End Sub

End Class

Public Class Square
    '创建一个Square类
    Public s As Single
    '声明字段s
    Public Sub New()

    End Sub
    Public Sub New(ByVal imps As Single)
        '定义构造函数
        s = imps
        '将输入值赋予字段s，即作为side属性值
    End Sub

    Public Property Side() As Single
        '定义属性Side
        Get
            '获取属性值
            Return s
            '将s的值作为属性值返回
        End Get
        Set(ByVal value As Single)
            '设置属性值
            s = value
            '用参数value的值设置属性值
        End Set
    End Property

    'Public Function Area() As Single
    '    '定义方法Area
    '    Return s * s
    '    '计算面积
    'End Function

    Public Event ErrSide()
    '声明事件ErrSide
    Public Function Area() As Single
        '定义方法Area0,用于计算面积
        If s < 0 Then
            RaiseEvent ErrSide()
            '引发ErrSide事件
            Return -1
        Else
            Return s * s
        End If
    End Function
End Class