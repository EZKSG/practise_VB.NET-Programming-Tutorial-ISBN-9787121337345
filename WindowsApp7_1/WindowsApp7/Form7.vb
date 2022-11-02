Public Class Form7
    '【例7.7】根据上述定义的结构类型，利用结构数组，输入不超过200名学生的基本信息，
    '并能显示已输入的所有信息。
    Structure StuType
        '在窗体模块的声明段中定义，结构类型名为StuType
        Dim no As String
        '学号
        Dim name As String
        '姓名
        Dim sex As Char
        '性别
        Dim tel As String
        '电话号码
    End Structure
    Dim Stud(199) As StuType
    '声明结构数组Stud,下标0~199
    Dim num As Integer
    '声明num为模块级变量
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '输入
        If num > 199 Then
            '超过199时退出
            Exit Sub
        End If
        With Stud(num)
            .no = Trim(TextBox1.Text)
            .name = Trim(TextBox2.Text)
            If RadioButton1.Checked Then
                .sex = "男"
            Else
                .sex = "女"
            End If
            .tel = Trim(TextBox3.Text)
        End With
        TextBox1.Text = "" : TextBox2.Text = "" : TextBox3.Text = ""
        num = num+1
        Label6.Text = "输入数：" & num
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim k As Integer, n, s As String
        Label5.Text = "学号           姓名      性别      电话”
        ListBox1.Items.Clear()
        For k = 0 To num - 1
            With Stud(k)
                n = .name & Space(10 - Len(.name) * 2)
                '为输出格式整齐，对姓名段定长10个位
                s = .no & Space(2) & n & .sex & Space(2) & .tel
                ListBox1.Items.Add(s)
            End With
        Next k
    End Sub
End Class