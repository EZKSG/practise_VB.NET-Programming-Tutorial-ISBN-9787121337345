Public Class Form8
    '【例9.8】计算t=0.1+0.2+0.3+…+0.9+1,编写的程序代码如下：
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t, i As Single
        t = 0
        For i = 0.1 To 1 Step 0.1
            t += i
        Next i
        Debug.Print("总和：" & t)
        'Next i 处断点
        '经过上述跟踪检测，可以发现上述循环语句本来应该循环10次，这里却只循环9次。这是
        '由于小数在机器内存储和处理会发生微小误差，当执行到第9次循环时，循环变量ⅰ的值为
        '0.9000001,再加上步长值0.1时，已经超过1，往下就不再执行循环体了。所以实际上才循环9
        '次，即只计算0.1+0.2+0.3+…+0.9(=4.5)。
        '当步长值为小数时，为了防止丢失循环次数，在编写代码时可将终值适当增加，一般是加上
        '步长值的一半，例如：
        'For i=0.1 To 1.05 Step 0.1
        '调试程序往往比写程序更难。希望读者通过实践逐步摸索，掌握调试程序的方法及技巧。
    End Sub
End Class