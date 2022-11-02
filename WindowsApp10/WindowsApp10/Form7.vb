Public Class Form7
    '【例10.7】如图10.12所示，在窗体上添加1个“打开文件”按钮和1个打开文件对话框控
    '件，当单击该按钮时，将弹出一个“打开文件”对话框。
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '打开文件
        OpenFileDialog1.Title = "打开文件"
        '设置对话框的标题
        OpenFileDialog1.Filter = "全部文件|*.*|文本文件|*.txt"
        '设置文件过滤器，共两项
        OpenFileDialog1.InitialDirectory = "D:\VB"
        '设置默认文件夹
        OpenFileDialog1.ShowDialog()
        '显示打开对话框
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class