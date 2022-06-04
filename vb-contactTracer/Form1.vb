Public Class Form1
    Private Sub clock_Tick(sender As Object, e As EventArgs) Handles clock.Tick
        day.Value = DateTime.Now
        time.Text = DateTime.Now.ToShortTimeString()
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim emptyFields = New List(Of String)()

        ' Recursively check for any empty fields present on submit
        For Each ctrl In Me.innerTable.Controls

            ' For textboxes
            If TypeOf ctrl Is TextBox Then
                Dim tb = TryCast(ctrl, TextBox)

                If String.IsNullOrEmpty(tb.Text.Trim()) Then
                    If tb.Name = "temp" Then
                        emptyFields.Add("Temperature")
                    ElseIf tb.Name = "mobile" Then
                        emptyFields.Add("Phone Number")
                    End If
                End If

                ' For table panel layouts
            ElseIf TypeOf ctrl Is TableLayoutPanel Then
                Dim tlp = TryCast(ctrl, TableLayoutPanel)

                If tlp.Name = "addressTable" Then
                    Dim addressINC = False

                    For Each textbox In tlp.Controls.OfType(Of TextBox)()
                        If String.IsNullOrEmpty(textbox.Text.Trim()) Then
                            addressINC = True
                            Exit For
                        End If
                    Next

                    If addressINC Then emptyFields.Add("Complete Address")

                ElseIf tlp.Name = "infoTable" Then
                    Dim infoINC = False

                    For Each textbox In tlp.Controls.OfType(Of TextBox)()
                        If textbox.Name <> "middle" AndAlso String.IsNullOrEmpty(textbox.Text.Trim()) Then
                            infoINC = True
                            Exit For
                        End If
                    Next

                    If infoINC Then emptyFields.Add("Full Name")
                End If
            End If
        Next

        ' For radio buttons, 'gender' fields in particular
        If Not male.Checked AndAlso Not female.Checked Then emptyFields.Add("Gender")

        ' Determine path depending on number of items in 'emptyFields'
        If emptyFields Is Nothing OrElse Not emptyFields.Any() Then
            processData()
        Else
            Dim list As String = ""
            emptyFields.Sort()

            For Each item In emptyFields
                list += vbLf & "- " & item
            Next

            MessageBox.Show("Please fill out all form fields:" & list,
                "Submission Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Process data if all fields are filled up
    Private Sub processData()

    End Sub

    ' Clear all fields recursively
    Private Sub clearAll(table As Control)
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
