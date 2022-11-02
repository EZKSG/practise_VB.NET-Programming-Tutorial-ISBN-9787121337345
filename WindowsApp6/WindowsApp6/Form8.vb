Public Class Form8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        '【例6.8】编制一个“加法器”程序，其作用是将每次输入的数累加。以-1作为输入结束标志。
        '利用InputBox函数输入数据并输出每次的累加数， 编写的程序代码如下
        Dim sum, x As Single, s As String
        sum = 0
        Do While True
            s = "累加数：" & sum & vbCrLf & "输入数据（-1）结束"
            x = Val(InputBox(s, "加法器"))
            If x = -1 Then Exit Do
            sum += x
        Loop
        MsgBox("累计计算结束")
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class