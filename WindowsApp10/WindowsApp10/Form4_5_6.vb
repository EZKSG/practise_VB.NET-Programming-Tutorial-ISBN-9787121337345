Public Class Form4_5_6
    '【例10.4】编写程序，进行两个运算数的加、减运算练习。本例通过菜单栏向用户提供功
    '能选择，包括运算数的位数，运算类型和退出程序。
    '【例10.5】在例10.4的基础上，为文本框TextBox1设计快捷菜单，实现对文本框内的文本
    '颜色进行控制。
    '【例10.6】在例10.4的基础上，增加一个工具栏，使之能快速提供“两位数”的位数和“加
    '法”运算类型（假设“两位数”及“加法”是常用命令）。操作步骤如下。
    Dim sel1 As Integer = 0, sel2 As String = ""
    '模块级变量
    Dim r1 As Long
    Private Sub 绿色ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 绿色ToolStripMenuItem.Click
        '绿色
        TextBox1.ForeColor = Color.Green
    End Sub

    Private Sub 红色ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 红色ToolStripMenuItem.Click
        '红色
        TextBox1.ForeColor = Color.Red
    End Sub

    Private Sub 蓝色ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 蓝色ToolStripMenuItem.Click
        '蓝色
        TextBox1.ForeColor = Color.Blue
    End Sub

    Private Sub mn11_Click(sender As Object, e As EventArgs) Handles mn11.Click
        '一位数
        '设置位数标记
        sel1 = 1
    End Sub

    Private Sub mn12_Click(sender As Object, e As EventArgs) Handles mn12.Click, but1.Click
        '两位数
        sel1 = 10
    End Sub

    Private Sub mn21_Click(sender As Object, e As EventArgs) Handles mn21.Click, but2.Click
        '加法
        '设置运算标记
        sel2 = "+"
    End Sub

    Private Sub mn22_Click(sender As Object, e As EventArgs) Handles mn22.Click
        '减法
        sel2 = "-"
    End Sub

    Private Sub mn30_Click(sender As Object, e As EventArgs) Handles mn30.Click
        '退出
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '命题
        Dim a, b As Integer
        Randomize()
        If sel1 = 0 Or sel2 = "" Then
            MsgBox("先选择运算数的位数和运算类型")
            Exit Sub
        End If
        a = sel1 + Int(9 * sel1 * Rnd())
        '根据指定位数，随机产生运算数
        b = sel1 + Int(9 * sel1 * Rnd())
        TextBox1.Text = a & sel2 & b & "="
        '根据运算数及运算类型组成算式
        Select Case sel2
        '根据运算类型，求运算结果1
            Case "+"
                r1 = a + b
            Case "-"
                r1 = a - b
        End Select
        TextBox2.Text = ""
        TextBox2.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '答案
        Dim r2 As Long
        r2 = Val(TextBox2.Text)
        '读取用户输入的答案
        If r1 = r2 Then
            '判断答案
            MsgBox("回答正确！")
        Else
            MsgBox("回答错误！")
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class