Public Class Form1
    Private Sub clock_Tick(sender As Object, e As EventArgs) Handles clock.Tick
        day.Value = DateTime.Now
        time.Text = DateTime.Now.ToShortTimeString()
    End Sub
End Class
