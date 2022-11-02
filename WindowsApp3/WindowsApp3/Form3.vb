Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str1, str2, str3 As String
        str1 = Trim(TextBox1.Text)      '去空格
        str2 = Strings.Left(str1, 1)        '取左一
        str3 = Strings.Right(str1, 1)       '取右一
        TextBox2.Text = str2 & str3        '合并
    End Sub
End Class