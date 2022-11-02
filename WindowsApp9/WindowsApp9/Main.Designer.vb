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
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 90)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "【例9.1】把1一50的50个整数，以及这些数中能被7整除的数分别存入两个文件中，文件"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(0, 110)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 90)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "【例9.2】在例9.1所生成的Num2.txt文件中，已经存放了若干个能被7整除的数，现要求再添加51~200范围内能被7整除的数，程序代码如下："
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(0, 217)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 90)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "【例9.3】已知文件um2.txt中存放一批能被7整除的数（见例9.1及例9.2），现要求读出这些数并显示出来，每行显示5个数。程序代码如下："
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(0, 329)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(140, 90)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "【例9.4】建立一个随机文件""data1.dat"",文件中包含10条记录，每条记录由3个数据项组成。第1条记录存放数值1的平方数、立方数和开方根数，第2条记录存放" &
    "数值2的平方数、立方数和开方根数，其余类推，以该数值作为记录号。存入全部记录后，再读出记录号为2、6、10的3条记录。"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(182, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(140, 90)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "【例9.5】用随机文件处理学生资料。"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(182, 110)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(140, 90)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "【例9.6】把两个字符串写入二进制文件""biny.dat"",从第50字节起写入第1个字符串""Visual Basic.NET"",从第100字节起写入第2个字符串""" &
    "程序设计"""
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(182, 217)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(140, 90)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "【例9.7】假设有以下一个窗体的CiCk事件过程："
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(182, 329)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(140, 90)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "【例9.8】计算t=0.1+0.2+0.3+…+0.9+1,编写的程序代码如下："
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(358, 0)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(149, 90)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "【例9.9】使用On Error…Resume示例。主要针对""数组下标越界""错误的处理，代码如下："
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(358, 110)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(149, 90)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "【例9.10】使用Try..Case…Finally结构示例。类似例9.9，主要针对""数组下标越界""错误的处理，代码如下："
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
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
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
End Class
