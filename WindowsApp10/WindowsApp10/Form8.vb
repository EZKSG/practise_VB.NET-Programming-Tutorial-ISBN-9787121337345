Public Class Form8
    '【例10.8】在窗体上添加1个文本框、1个“另存文件”按钮和1个另存为文件对话框控件，
    '单击按钮时可打开“另存为”对话框，选择文件名及保存位置之后单击“保存”按钮，可将文本
    '框中的内容以文本文件的形式保存起来。
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '另存文件
        SaveFileDialog1.InitialDirectory = "D:\VB"
        '设置默认的文件夹
        SaveFileDialog1.FileName = "txtname.txt"
        '设置默认的文件名
        SaveFileDialog1.DefaultExt = "txt"
        '设置默认扩展名
        SaveFileDialog1.ShowDialog()
        '打开另存为对话框
        FileOpen(1, SaveFileDialog1.FileName, OpenMode.Output)
        '打开FileName属性值指定的文本文件
        Write(1, TextBox1.Text)
        '将文本框中的内容写入文件
        FileClose(1)
        '关闭文本文件
    End Sub

End Class