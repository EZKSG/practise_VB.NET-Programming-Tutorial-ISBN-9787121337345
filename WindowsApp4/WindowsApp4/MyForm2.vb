Public Class MyForm2
    Private Sub MyForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MyForm2_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim a, b, c As Double
        a = Val(InputBox("笔试", "hello"))
        b = Val(InputBox("机试", "hello"))
        c = a * 0.6 + b * 0.4
        TextBox1.Text = "总评：" & c & " （笔试：" & a & "，机试：" & b & "）"
    End Sub
End Class