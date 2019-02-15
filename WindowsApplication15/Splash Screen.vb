Public Class Splash_Screen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            LogIn.Show()
            Me.Hide()
        End If
    End Sub
End Class