Public Class Form6
    '【例9.6】把两个字符串写入二进制文件“biny.dat”,从第50字节起写入第1个字符串
    '“Visual Basic.NET”,从第100字节起写入第2个字符串“程序设计”

    Private Sub Form6_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim txt1, txt2 As String
        FileOpen(1, "D:\VB\biny.dat", OpenMode.Binary)
        txt1 = "Visual Basic.NET"
        txt2 = "程序设计"
        FilePut(1, txt1, 50)
        FilePut(1, txt2, 100)
        FileClose(1)
    End Sub
End Class