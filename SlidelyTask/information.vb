Public Class information
    Private Sub information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim count As Integer
        For counter = 0 To 100 Step 10
            count = counter
            Me.Opacity = count / 100
            Me.Refresh()
            Threading.Thread.Sleep(100)

        Next counter

        Threading.Thread.Sleep(3000)

        For counters = 100 To 0 Step -10
            count = counters
            Me.Opacity = count / 100
            Me.Refresh()
            Threading.Thread.Sleep(100)

        Next counters

        Me.Dispose()
    End Sub
End Class