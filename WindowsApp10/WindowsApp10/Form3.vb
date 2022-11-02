Public Class Form3
    '【例10.3】下列MouseDown事件过程实现命令按钮位置的移动。当单击鼠标左键时将按钮
    '的位置移动到鼠标指针的位置，单击鼠标其他键（如右键）时把按钮的位置移动到窗体的左上角
    '(0,0)。事件过程代码如下
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form3_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            Button1.Left = e.X
            Button1.Top = e.Y
        Else
            Button1.Left = 0
            Button1.Top = 0
        End If
    End Sub
End Class