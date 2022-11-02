Public Class Form18
    '【例6.18】取1元、2元、5元的硬币共15枚，付给30元钱，问有多少种不同的取法？
    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n,a,b,c As Integer,s As String=Space(5)
        Label1.Text = "取一元、二元、五元的硬币共l5枚，" & vbCrLf
        Label1.Text = Label1.Text & "付给30元钱，有多少种不同的取法？"
        Label2.Text="取法" & s & "5元"& s & "2元" & s & "1元" & vbCrLf
n=0
'记录解的组数
For a=0 To 15
            For b = 0 To 15
                c = 15 - b - a
                If a + 2 * b + 5 * c = 30 And c >= 0 Then
                    n = n + 1
                    Label2.Text &= "(" & n & ")" & Space(7) & c & Space(6) & b & Space(7) & a & vbCrLf
                End If
        Next b, a
        '合并两条Next语句
    End Sub
End Class