Public Class MyForm5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        a = 0 : b = 0 : c = 0
        If CheckBox1.Checked Then
            a = 255
        End If
        If CheckBox2.Checked Then
            b = 255
        End If
        If CheckBox3.Checked Then
            c = 255
        End If
        BackColor = Color.FromArgb(a, b, c)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub MyForm5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class