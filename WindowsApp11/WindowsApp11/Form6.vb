Public Class Form6
    '【例11.6】定义派生类，并编写代码进行测试。
    Dim CC As New ChildClass
    '创建一个属于ChildClass类的对象CC
    Private Sub Form1_Click() Handles Me.Click
        Debug.Print(CC.s)
        '输出CC.s的值
        Debug.Print(CC.Getval())
        '调用CC.GetvalO方法，并输出返回值
    End Sub
End Class

Public Class BaseClass
    '定义BaseClass类，作为基类
    Public s As String = "VB.NET"
    '声明字段变量并指定初始值
    Public t As Integer = 5
    Public Function Getval()
        '定义Getval方法
        Return 3 * t
    End Function
End Class
Public Class ChildClass
    '定义派生类ChildClass
    Inherits BaseClass
    '指定基类BaseClass
End Class