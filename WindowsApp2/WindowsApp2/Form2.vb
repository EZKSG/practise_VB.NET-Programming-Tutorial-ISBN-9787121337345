Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "load window"
        Me.BackColor = Color.Blue 'set window backcolor blue
    End Sub
    Private Sub Form2_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.Text = "click window"
        Me.Width = 400              'window 宽400高200
        Me.Height = 200
    End Sub
    Private Sub Form2_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick
        Me.Text = "double click window"
        Me.MaximizeBox = False          'hide max min box button
        Me.MinimizeBox = False
    End Sub
End Class