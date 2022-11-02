Module Module1
    Public X As Integer
    Public Y As Integer
End Module
Public Class Form8
    '【例8.8】计算两数之和与积。
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '输入数据
        Me.Hide()
        '隐藏主窗体
        Form8_2.Show()
        '显示“输入数据”窗体
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '计算
        Me.Hide()
        '隐藏主窗体
        Form8_3.Show()
        '显示“计算”窗体
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '结束
        Me.Close()
        '在结束运行之前， 先关闭所有已打开的窗体
        Form8_2.Close()
        Form8_3.Close()
        End
    End Sub
End Class