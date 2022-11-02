Public Class Form3
    '【例9.3】已知文件um2.txt中存放一批能被7整除的数（见例9.1及例9.2），现要求读出
    '这些数并显示出来，每行显示5个数。程序代码如下：
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form3_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim k, x As Integer
        FileOpen(1, "D:\VB\num2.txt", OpenMode.Input)
        Do While Not EOF(1)
            '文件未结束时， 维续循环
            Input(1, x)
            Debug.Write(x & Space(5))
            k = k + 1
            If k Mod 5 = 0 Then Debug.Write(vbCrLf)
        Loop
        FileClose(1)
    End Sub
End Class