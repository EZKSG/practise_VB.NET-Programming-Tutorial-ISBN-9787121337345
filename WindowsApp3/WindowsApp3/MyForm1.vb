Public Class MyForm1
    Private Sub MyForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MyForm1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim d As Date = Today
        blkYear.Text = Year(d)
        blkMonth.Text = Month(d)
        blkDay.Text = DateAndTime.Day(d)
        blkWeek.Text = Weekday(d) - 1
        blkTime.Text = TimeOfDay
    End Sub
End Class