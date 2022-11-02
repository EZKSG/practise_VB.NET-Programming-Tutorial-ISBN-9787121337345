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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 105)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "【例11.1】创建一个表示正方形的类Square,并定义一个表示边长的Side属性，编写一个应用该类及其属性的程序。"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(0, 111)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 72)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "【例11.2】在例11.1定义的Square类中，给类定义一个计算正方形面积的方法Area0,并使用该方法来计算某正方形的面积。"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(0, 189)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(163, 82)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "【例11.3】在例11.2定义的Square类中，定义一个ErrSide事件，当给定的正方形边长小于0时，引发该事件，并返回错误码""-1""。然后编写对象的ErrS" &
    "ide事件过程实现，当边长小于0时，用消息框给出提示。"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(0, 287)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(163, 82)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "【例11.4】为例11.1中的Square类添加构造函数，给Side属性赋予初值10，使用的代码如下："
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(213, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(163, 82)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "【例11.5】利用类编写一个校园卡支付和充值的程序。"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(213, 101)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(163, 82)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "【例11.6】定义派生类，并编写代码进行测试。"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(213, 200)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(163, 82)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "【例11.7】在正方形Square类（见例11.3）的基础上，派生出一个表示正方体的类Cube,再添加计算正方体体积的方法，并编写代码进行测试。"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(213, 303)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(163, 82)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "【例11.8】重载方法的使用示例。"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(419, 0)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(163, 82)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "【例11.9】重写方法的使用示例。"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
End Class
