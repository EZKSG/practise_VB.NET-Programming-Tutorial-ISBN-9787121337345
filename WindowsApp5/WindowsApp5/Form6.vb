Public Class Form6
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    '
    '
    ' 摘要:
    '     使用指定的大小初始化新 System.Drawing.Font。
    '
    ' 参数:
    '   family:
    '     新 System.Drawing.Font 的 System.Drawing.FontFamily。
    '
    '   emSize:
    '     新字体的全身大小（以磅为单位）。
    '
    ' 异常:
    '   T:System.ArgumentException:
    '     emSize 是小于或等于 0，计算结果为无穷大，或者不是有效的数字。
    'Public Sub New(family As FontFamily, emSize As Single)
    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked Then
            TextBox1.Font = New Font("楷体", TextBox1.Font.Size)
        Else
        TextBox1.Font = New Font("宋体", TextBox1.Font.Size)
        End If
    End Sub

    Private Sub CheckBox2_Click(sender As Object, e As EventArgs) Handles CheckBox2.Click
        If CheckBox2.Checked Then
            TextBox1.Font = New Font(TextBox1.Font.Name, 16)
        Else
            TextBox1.Font = New Font(TextBox1.Font.Name, 12)
        End If
    End Sub

    Private Sub CheckBox3_Click(sender As Object, e As EventArgs) Handles CheckBox3.Click
        If CheckBox3.Checked Then
            TextBox1.ForeColor = Color.Red
        Else
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class