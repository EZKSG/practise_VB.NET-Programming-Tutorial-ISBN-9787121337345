<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 94)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "【例10.1】如图10.1所示，在窗体上添加1个文本框和1个标签，当在文本框中键入某一个字符时，在标签中显示该字符及其ASCⅡ码。"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(0, 93)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 94)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "【例10.2】编一程序段，使得文本框TextBox1(多行)中限定只能输入英文字母（含大、小写)及逗号，只能接收回车键及BackSpace键。"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(0, 193)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(153, 94)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "【例10.3】下列MouseDown事件过程实现命令按钮位置的移动。当单击鼠标左键时将按钮的位置移动到鼠标指针的位置，单击鼠标其他键（如右键）时把按钮的位置移动到" &
    "窗体的左上角(0,0)。事件过程代码如下："
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(0, 283)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(206, 155)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "【例10.4】编写程序，进行两个运算数的加、减运算练习。本例通过菜单栏向用户提供功能选择，包括运算数的位数，运算类型和退出程序。【例10.5】在例10.4的基础上" &
    "，为文本框TextBox1设计快捷菜单，实现对文本框内的文本颜色进行控制。【例10.6】在例10.4的基础上，增加一个工具栏，使之能快速提供““两位数””的位数和““" &
    "加法””运算类型（假设““两位数””及““加法””是常用命令）。操作步骤如下。"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(212, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(153, 94)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "【例10.7】如图10.12所示，在窗体上添加1个““打开文件””按钮和1个打开文件对话框控件，当单击该按钮时，将弹出一个““打开文件””对话框。"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(212, 100)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(153, 94)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "【例10.8】在窗体上添加1个文本框、1个““另存文件””按钮和1个另存为文件对话框控件，单击按钮时可打开““另存为””对话框，选择文件名及保存位置之后单击““保存””按钮，" &
    "可将文本框中的内容以文本文件的形式保存起来。"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(212, 200)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(153, 94)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "【例10.9】在窗体上添加1个文本框和1个““改变字体””按钮，单击该按钮可打开““字体””对话框，选定字体、字形、大小等之后，单击““确定””按钮，可使文本框中的字体属性发" &
    "生相应的变化。【例10.10】在窗体上添加1个文本框和1个““改变颜色””按钮，单击该按钮可打开““颜色””对话框，选定颜色之后单击““确定””按钮，可使文本框中的文字颜色" &
    "发生相应的变化。"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(212, 300)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(153, 94)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "【例10.11】利用单选按班和分组框径件设置义本框的子体及子号。"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
