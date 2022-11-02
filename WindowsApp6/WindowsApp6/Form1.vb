Imports System.ComponentModel

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '例6.1 输出2~10之间的偶数的平方数。
        Dim k As Integer
        For k = 2 To 10 Step 2
            Debug.Print(k * k)
        Next k
        '注意，退出循环时，循环变量k的值是12而不是10。
    End Sub
End Class
