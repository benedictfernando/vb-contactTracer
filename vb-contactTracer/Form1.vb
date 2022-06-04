Public Class Form1
    Private Sub clock_Tick(sender As Object, e As EventArgs) Handles clock.Tick
        day.Value = DateTime.Now
        time.Text = DateTime.Now.ToShortTimeString()
    End Sub

    ' Clear all fields recursively
    Private Sub clearAll(ByVal table As Control)
        For Each control In table.Controls
            If TypeOf control Is TextBox Then
                TryCast(control, TextBox).Text = String.Empty
            ElseIf TypeOf control Is RadioButton Then
                TryCast(control, RadioButton).Checked = False
            ElseIf TypeOf control Is CheckBox Then
                TryCast(control, CheckBox).Checked = False
            ElseIf TypeOf control Is TableLayoutPanel Then
                clearAll(TryCast(control, TableLayoutPanel))
            End If
        Next
    End Sub

    ' Warn user before application closing
    Private Sub appClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim msg = "Thank you for using C#'s Contact Tracer~ keep safe!"

        If MessageBox.Show("Are you really sure to exit?",
            "Exit Program", MessageBoxButtons.YesNo,
            MessageBoxIcon.[Stop]) = DialogResult.Yes Then
            MessageBox.Show(msg)
        Else
            e.Cancel = True
        End If
    End Sub
End Class
