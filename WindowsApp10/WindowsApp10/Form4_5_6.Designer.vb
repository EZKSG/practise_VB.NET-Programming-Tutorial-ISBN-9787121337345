<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4_5_6
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4_5_6))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mn10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn20 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn21 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn22 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn30 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.红色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.绿色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.蓝色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.but1 = New System.Windows.Forms.ToolStripButton()
        Me.but2 = New System.Windows.Forms.ToolStripButton()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mn10, Me.mn20, Me.mn30})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mn10
        '
        Me.mn10.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mn11, Me.mn12})
        Me.mn10.Name = "mn10"
        Me.mn10.Size = New System.Drawing.Size(43, 20)
        Me.mn10.Text = "位数"
        '
        'mn11
        '
        Me.mn11.Name = "mn11"
        Me.mn11.Size = New System.Drawing.Size(110, 22)
        Me.mn11.Text = "一位数"
        '
        'mn12
        '
        Me.mn12.Name = "mn12"
        Me.mn12.Size = New System.Drawing.Size(110, 22)
        Me.mn12.Text = "两位数"
        '
        'mn20
        '
        Me.mn20.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mn21, Me.mn22})
        Me.mn20.Name = "mn20"
        Me.mn20.Size = New System.Drawing.Size(43, 20)
        Me.mn20.Text = "运算"
        '
        'mn21
        '
        Me.mn21.Name = "mn21"
        Me.mn21.Size = New System.Drawing.Size(98, 22)
        Me.mn21.Text = "加法"
        '
        'mn22
        '
        Me.mn22.Name = "mn22"
        Me.mn22.Size = New System.Drawing.Size(98, 22)
        Me.mn22.Text = "减法"
        '
        'mn30
        '
        Me.mn30.Name = "mn30"
        Me.mn30.Size = New System.Drawing.Size(43, 20)
        Me.mn30.Text = "退出"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'TextBox1
        '
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox1.Location = New System.Drawing.Point(15, 98)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(75, 19)
        Me.TextBox1.TabIndex = 3
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.红色ToolStripMenuItem, Me.绿色ToolStripMenuItem, Me.蓝色ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(99, 70)
        '
        '红色ToolStripMenuItem
        '
        Me.红色ToolStripMenuItem.Name = "红色ToolStripMenuItem"
        Me.红色ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.红色ToolStripMenuItem.Text = "红色"
        '
        '绿色ToolStripMenuItem
        '
        Me.绿色ToolStripMenuItem.Name = "绿色ToolStripMenuItem"
        Me.绿色ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.绿色ToolStripMenuItem.Text = "绿色"
        '
        '蓝色ToolStripMenuItem
        '
        Me.蓝色ToolStripMenuItem.Name = "蓝色ToolStripMenuItem"
        Me.蓝色ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.蓝色ToolStripMenuItem.Text = "蓝色"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(115, 98)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(75, 19)
        Me.TextBox2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "命题"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(115, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "答题"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.but1, Me.but2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 38)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'but1
        '
        Me.but1.Image = CType(resources.GetObject("but1.Image"), System.Drawing.Image)
        Me.but1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.but1.Name = "but1"
        Me.but1.Size = New System.Drawing.Size(47, 35)
        Me.but1.Text = "两位数"
        Me.but1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'but2
        '
        Me.but2.Image = CType(resources.GetObject("but2.Image"), System.Drawing.Image)
        Me.but2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.but2.Name = "but2"
        Me.but2.Size = New System.Drawing.Size(35, 35)
        Me.but2.Text = "加法"
        Me.but2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(242, 49)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(321, 106)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.Text = "【例10.4】编写程序，进行两个运算数的加、减运算练习。本例通过菜单栏向用户提供功能选择，包括运算数的位数，运算类型和退出程序。【例10.5】在例10.4的基础上" &
    "，为文本框TextBox1设计快捷菜单，实现对文本框内的文本颜色进行控制。【例10.6】在例10.4的基础上，增加一个工具栏，使之能快速提供““两位数””的位数和““" &
    "加法””运算类型（假设““两位数””及““加法””是常用命令）。操作步骤如下。"
        '
        'Form4_5_6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form4_5_6"
        Me.Text = "Form4"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mn10 As ToolStripMenuItem
    Friend WithEvents mn11 As ToolStripMenuItem
    Friend WithEvents mn12 As ToolStripMenuItem
    Friend WithEvents mn20 As ToolStripMenuItem
    Friend WithEvents mn21 As ToolStripMenuItem
    Friend WithEvents mn22 As ToolStripMenuItem
    Friend WithEvents mn30 As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 红色ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 绿色ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 蓝色ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents but1 As ToolStripButton
    Friend WithEvents but2 As ToolStripButton
    Friend WithEvents TextBox3 As TextBox
End Class
