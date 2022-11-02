Public Class Form2
    '【例9.2】在例9.1所生成的Num2.txt文件中，已经存放了若干个能被7整除的数，
    '现要求再添加51~200范围内能被7整除的数，程序代码如下：
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form2_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim k As Integer
        FileOpen(1, "D:\VB\num2.txt", OpenMode.Append)
        For k = 51 To 200
            If k Mod 7 = 0 Then Write(1, k)
        Next k
        FileClose(1)
        Me.Close()
    End Sub
End Class