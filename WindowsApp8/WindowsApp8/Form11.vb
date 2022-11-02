Public Class Form11
    '【例8.11】动态文字。

    Dim txt As String, n, k As Integer
    '声明模块级变量
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n = 0
        txt = "过程是程序中一个相对独立的程序段”
        k = Len(txt)
        TextBox1.ForeColor = Color.FromArgb(255, 0, 0)
        '红色
        TextBox2.ForeColor = Color.FromArgb(0, 0, 0)
        '黑色
        TextBox3.ForeColor = Color.FromArgb(0, 0, 255)
        '蓝色
    End Sub
    Private Sub Timer1_Tick() Handles Timer1.Tick
        n = n + 1
        '变量n用于控制每次要获取的文字长度
        If n <= k Then
            TextBox1.Text = Strings.Left(txt, n)
            '逐次取n个字符
            TextBox2.Text = Space(2 * (k - n)) + Strings.Left(txt, n)
        Else
            n = 0
            TextBox1.Text = ""
            TextBox2.Text = ""
    End If
        If n Mod 2 = 0 Then
            '以2个时间间隔为1个周期，显示及清除交替进行
            TextBox3.Text = txt
            'n为偶数时显示
        Else
            TextBox3.Text = ""
            'n为奇数时清除
        End If
    End Sub
End Class