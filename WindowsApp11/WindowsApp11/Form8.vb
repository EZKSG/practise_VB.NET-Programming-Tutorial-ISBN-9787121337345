Public Class Form8
    '【例11.8】重载方法的使用示例。
    Dim OL1 As New OL
    '创建OL类的对象OL1
    Private Sub Forml_Click() Handles Me.Click
        Debug.Print(OL1.Cal(5, 10))
        '调用重载方法Cal,带2个参数
        Debug.Print(OL1.Cal(8))
        '调用重载方法Cl,带1个参数
    End Sub
End Class

Public Class OL
    '定义OL类，其中定义了两个重载方法Cal
    Public Function Cal(ByVal x As Integer, ByVal y As Integer) '含有2个参数
        Return x * y
        '用于计算x和y之积
    End Function
    Public Function Cal(ByVal x As Integer)
        '含有1个参数
        Return x * x
        '用于计算x的平方数
    End Function
End Class