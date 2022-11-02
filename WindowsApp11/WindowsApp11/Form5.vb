Public Class Form5
    '【例11.5】利用类编写一个校园卡支付和充值的程序。
    Dim WithEvents C1 As New Card
    '用WithEvents创建一个属于Card类的对象C1
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = C1.Cno
        AddHandler Button1.Click, Sub()
                                      MsgBox("Lambda caught event.")
                                  End Sub
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '支付
        Dim p As String, k As Decimal, f As Integer
        p = Trim(TextBox2.Text)
        k = Val(TextBox3.Text)
        If C1.Cpw <> p Then
            MsgBox("无效密码！")
            Exit Sub
        End If
        f = C1.Deduct(k)
        '调用对象C1的Deduct方法计算余额
        Label4.Text = "余额为：" & C1.Cye
        If f = -1 Then
            MsgBox("余额小于10元，请及时充值！")
        End If
    End Sub

    Private Sub C1_Overye0 Handles C1.Overye
        '对象C1的Overye事件过程
        MsgBox("超过余额（透支），操作失败！")
        TextBox3.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        C1.Recharge(Val(InputBox("输入充值款数"， "校园卡充值")))
        '调用对象CI的Recharge方法，为校园卡充值
        Label4.Text = "余额为：" & C1.Cye
        TextBox3.Text = ""
    End Sub
End Class

Public Class Card
    '创建一个Card类
    Dim No As String
    '声明字段变量
    Dim Pw As String
    Dim ye As Decimal
    Public Sub New()
        '定义构造函数
        No = "990002"
        '为字段指定初始值
        Pw = "lin408"
        ye = 200.0
    End Sub
    ReadOnly Property Cno() As String
        '定义只读属性Cno(卡号)
        Get
            Return No
        End Get
    End Property
    ReadOnly Property Cpw() As String
        '定义只读属性Cpw(密码)
        Get
            Return Pw
        End Get
    End Property
    Public Property Cye() As Decimal
        '定义读写属性Cye(余额)
        Get
            Return ye
        End Get
        Set(ByVal value As Decimal)
            ye = value
        End Set
    End Property

    Public Sub Recharge(ByVal inpye As Decimal)
        ye += inpye
    End Sub

    Public Event Overye()
    '声明事件Overye
    Public Function Deduct(ByVal inpkc As Decimal) As Integer
        If inpkc > ye Then
            RaiseEvent Overye()
            Exit Function
        End If
        ye -= inpkc
        If ye < 10 Then
            Return -1
        End If
    End Function
End Class