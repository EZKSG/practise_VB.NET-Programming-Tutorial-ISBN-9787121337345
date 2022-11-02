Public Class MyForm2
    Private Sub MyForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t As Integer, p As String
        t = Val(Mid(TextBox1.Text, 5, 1))
        Select Case t
            Case 2
                p = "博士生"
            Case 3
                p = "硕士生"
            Case 4
                p = "本科生"
            Case 5
                p = "专科生"
            Case Else
                p = "无效学号"
        End Select
        TextBox2.Text = Strings.Left(TextBox1.Text, 2) & "级" & p
    End Sub
End Class