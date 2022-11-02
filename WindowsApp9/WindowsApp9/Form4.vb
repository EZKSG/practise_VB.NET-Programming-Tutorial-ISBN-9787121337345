Public Class Form4
    '【例9.4】建立一个随机文件“data1.dat”,文件中包含10条记录，每条记录由3个数据项
    '组成。第1条记录存放数值1的平方数、立方数和开方根数，第2条记录存放数值2的平方数、
    '立方数和开方根数，其余类推，以该数值作为记录号。存入全部记录后，再读出记录号为2、6、
    '10的3条记录。
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Structure Numval
        '声明一个结构类型Numval
        Dim Squre As Integer
        '定义数据成员
        Dim Cube As Long
        Dim Sqroot As Single
    End Structure
    Dim nv As Numval
    '定义一个Numval类型的变量nv
    Private Sub Form4_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim k As Integer
        FileOpen(1, "D:\VB datal.dat", OpenMode.Random, , , Len(nv))
        For k = 1 To 10
            '写入10条记录
            nv.Squre = k * k
            nv.Cube = k * k * k
            nv.Sqroot = Math.Sqrt(k)
            FilePut(1, nv, k)
        Next k
        For k = 2 To 10 Step 4
            '读出3条记录
            FileGet(1, nv, k)
            Debug.Print(k & "号i记录：" & nv.Squre & ”," & nv.Cube & "," & nv.Sqroot)
        Next k
        FileClose(1)
    End Sub
End Class