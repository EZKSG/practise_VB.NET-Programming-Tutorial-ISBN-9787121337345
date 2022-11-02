Public Class Form10
    '【例8.10】将判断一个数是否为素数编成一个函数，然后通过同用该函数求500~1000效
    '中的所有素数，把这些素数显示在列表框中。
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t As Integer
        ListBox1.Items.Clear()
        '清除列表框中的内容
        For t = 500 To 1000
            If FnPrime(t) Then
                '调用函数， 将根据t是否素数返回Tnue或False
                ListBox1.Items.Add(t)
                '若是素数， 则存入列表框中
            End If
        Next t
        Label1.Text = "500~1000数中共有" & vbCrLf & ListBox1.Items.Count & "个素数"
    End Sub
    Function FnPrime(ByVal m As Integer) As Boolean
        Dim k As Integer, f As Boolean
        f = True
        '设置f来表示判断状态， 初值为Tue
        For k = 2 To m - 1
            '从k = 2,3,4,…,m-1依次判断
            If m Mod k = 0 Then
                '判断m是否能被k整除
                f = False
                '若m能被k整除， 则置f为False
                Exit For
            End If
        Next k
        FnPrime = f
        '返回函数值
    End Function

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class