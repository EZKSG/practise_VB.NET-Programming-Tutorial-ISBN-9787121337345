Public Class Form11
    '【例6.11】编写程序，找出4位数中能被16整除的完全
    '平方数，把这些4位数显示在列表框中，其个数显示在标签中。
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "找出4位数中能被16" & vbCrLf & "整除的完全平方数"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '显示
        Dim n As Integer
        ListBox1.Items.Clear()
        For n = 1000 To 9999
            If (n Mod 16 = 0) And Math.Sqrt(n) = Int(Math.Sqrt(n)) Then
                ListBox1.Items.Add(n)
            End If
        Next n
        Label1.Text = "符合条件的4位数" & vbCrLf & "个数为：" & ListBox1.Items.Count
    End Sub
End Class