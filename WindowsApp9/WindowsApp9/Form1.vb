Public Class Form1
    '【例9.1】把1一50的50个整数，以及这些数中能被7整除的数分别存入两个文件中，文件
    '名为numl和num2,文件存放在“DVB”文件夹下。
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim k As Integer
        FileOpen(1, "D:\VB'numl.txt", OpenMode.Output)
        FileOpen(2, "D:VBinum2.txt", OpenMode.Output)
        For k = 1 To 50
            Write(1, k)
            If k Mod 7 = 0 Then Write(2, k)
        Next k
        FileClose(1, 2)
        Me.Close()
    End Sub
End Class
