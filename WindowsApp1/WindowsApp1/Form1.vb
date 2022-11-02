Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'This program wil display Hello World
        TextBox1.Text = "欢迎来到VB.NET 的世界！"
        Console.WriteLine("Hello World")
        'Console.ReadKey()
        '最后一行Console.ReadKey（）是用于VS.NET用户的。 这将阻止屏幕从Visual Studio .NET启动时快速运行和关闭。
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ffform2 As New Form2
        'Dim bflyform As New Form1
        ffform2.Show()
        'Dim ffform3 As New Form3
        'ffform3.Show()
        'ffform2.Close()

        'Me.Close()
    End Sub
End Class