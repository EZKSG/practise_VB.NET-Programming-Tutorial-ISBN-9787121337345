Public Class Form5
    '【例9.5】用随机文件处理学生资料。
    Structure student
        '声明一个结构类型student
        <VBFixedString(6)> Dim xh As String
        '本结构包含xh、xm、cj三个成员
        <VBFixedString(8)> Dim xm As String
        Dim cj As Integer
    End Structure
    Dim st As student
    '定义一个student类型的变量st
    Dim no As Integer
    '声明记录号n0为模块级变量
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "D:\VB\stu.dat", OpenMode.Random, , , Len(st))
        '打开文件
        If LOF(1) = 0 Then
            no = 0
            Label4.Text = "文件中没有记录”
        Else
            no = 1
            Call GetRec()
            '调用通用过程GetRec()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '新增记录
        st.xh = TextBox1.Text
        st.xm = TextBox2.Text
        st.cj = Val(TextBox3.Text)
        no = LOF(1) / Len(st) + 1
        FilePut(1, st, no)
        Label4.Text = "新增第" & no & "条记录"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '修改记录
        st.xh = TextBox1.Text
        st.xm = TextBox2.Text
        st.cj = Val(TextBox3.Text)
        FilePut(1, st, no)
        Label4.Text = "修改第" & no & "条记录"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '结束
        FileClose(1)
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '首记录
        If LOF(1) = 0 Then
            Label4.Text = "文件中没有记录"
            Exit Sub
        End If
        no = 1
        Call GetRec()
        '调用通用过程GetRec()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '后移
        If no = LOF(1) / Len(st) Then
            Label4.Text = "没有下一条记录"
            Exit Sub
        End If
        no += 1
        Call GetRec()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '前移
        If no <= 1 Then
            Label4.Text = "没有上一条记录"
            Exit Sub
        End If
        no -= 1
        Call GetRec()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '末记录
        If LOF(1) / Len(st) = 0 Then
            Label4.Text = "文件中没有记录"
            Exit Sub
        End If
        no = LOF(1) / Len(st)
        Call GetRec()
        '调用通用过程GetRec()
    End Sub
    Sub GetRec()
        FileGet(1, st, no)
        TextBox1.Text = st.xh
        TextBox2.Text = st.xm
        TextBox3.Text = st.cj
        Label4.Text = "第" & no & "条记录(共" & LOF(1) / Len(st) & "条)"
    End Sub
End Class