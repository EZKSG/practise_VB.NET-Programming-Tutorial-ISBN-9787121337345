Public Class Form9
    '【例11.9】重写方法的使用示例。
    Dim C1 As New CClass
    '创建CClass类的对象C1
    Private Sub Forml_Click() Handles Me.Click
        C1.r = 5
        '赋值给字段变量r
        Debug.Print(C1.Area())
        '调用Area()方法
    End Sub
End Class
Public Class BClass
    '定义BClass类
    Public r As Single
    Public Overridable Function Area()
        '定义Area()方法，计算正方形的面积
        Return r * r
        '返回正方形的面积
    End Function
End Class
Public Class CClass
    '定义派生类CClass
    Inherits BClass
    '指定基类BClass
    Public Overrides Function Area()
        '重写基类的Area(方法，改为求圆的面积
        Return Math.PI * r ^ 2
        '返回圆的面积
    End Function
End Class