Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a, b, Min As Integer
        a = 1
        b = 2
        Min = IIf(a < b, a, b)
        Debug.Print(Min)
    End Sub

    Private Sub Form3_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim h As Integer
        h = Hour(TimeOfDay)
        If h < 12 Then
            Debug.Print("good morning!")
        ElseIf h < 18 Then
            Debug.Print("good afternoon!")
        Else
            Debug.Print("good evening!")
        End If
        Select Case h
            Case Is < 12
                Debug.Print("good morning!")
            Case Is < 18
                Debug.Print("good afternoon!")
            Case Else
                Debug.Print("good evening!")
        End Select
    End Sub
End Class