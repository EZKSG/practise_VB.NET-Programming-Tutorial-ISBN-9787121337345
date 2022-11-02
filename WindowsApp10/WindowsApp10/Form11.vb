Public Class Form11
    '【例10.11】利用单选按班和分组框径件设置义本框的子体及子号。
    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click,
        RadioButton2.Click, RadioButton3.Click
        Select Case True
            Case RadioButton1.Checked
                TextBox1.Font = New Font("宋体"， TextBox1.Font.Size)
            Case RadioButton2.Checked
                TextBox1.Font = New Font("楷体"， TextBox1.Font.Size)
            Case Else
                TextBox1.Font = New Font("隶书"， TextBox1.Font.Size)
        End Select
    End Sub

    Private Sub RadioButton4_Click(sender As Object, e As EventArgs) Handles RadioButton4.Click,
        RadioButton5.Click, RadioButton6.Click
        Select Case True
            Case RadioButton4.Checked
                TextBox1.Font = New Font(TextBox1.Font.Name, 12)
            Case RadioButton5.Checked
                TextBox1.Font = New Font(TextBox1.Font.Name, 14)
            Case Else
                TextBox1.Font = New Font(TextBox1.Font.Name, 16)
        End Select
    End Sub
End Class