Public Class Form16
    '【例6.16】输入一个正整数，然后把该数的每位数字按逆序输出。例如，输入3485，则输
    '出5843；输入100000，则输出000001。
    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '数值处理方法
        Dim x As Long
        x = Val(InputBox("请输入一个正整数"))
        Do While x >= 10
            Debug.Write(x Mod 10)
            x = x \ 10
        Loop
        Debug.Write(x)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '字符串处理方法
        Dim x As String, k As Integer
        x = InputBox("输入一个正整数")
        '把该数以字符串方式赋值给变量x
        For k = Len(x) To 1 Step -1
            Debug.Write(Mid(x, k, 1))
            '从后部往前逐个取出字符并显示
        Next k
    End Sub
End Class