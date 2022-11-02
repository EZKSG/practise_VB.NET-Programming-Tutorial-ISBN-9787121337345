Public Class Form9
    '【例9.9】使用On Error…Resume示例。主要针对“数组下标越界”错误的处理，代码如下：
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form9_Click(sender As Object, e As EventArgs) Handles Me.Click
        On Error GoTo errln
        '以下代码出错时转移至errln
        Dim d(5), k As Integer
        k = 6
        d(k) = 99
        MsgBox(d(k))
        Exit Sub
errln:
        Select Case Err.Number
        '根据错误类型，进行不同处理
            Case 9
                '数组下标越界错误码为9
                ReDim Preserve d(10)
                '若是，则重新定义数组，保留原数据
                Resume
                '返回到原出错位置
            Case 6
                '算术运算导致溢出错误码为6
                MsgBox(Err.Number)
                '显示错误码
            Case Else
                '若其他错误，则显示相关信息
                MsgBox("错误发生在" & Err.Source & ",代码为" &
                       Err.Number & "，即" & Err.Description)
        End Select
    End Sub
End Class