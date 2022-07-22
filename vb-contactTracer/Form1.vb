Imports System.IO
Imports MessagingToolkit.QRCode.Codec
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class Form1
    Private Sub clock_Tick(sender As Object, e As EventArgs) Handles clock.Tick
        day.Value = DateTime.Now
        ' time.Text = DateTime.Now.ToShortTimeString()
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
        Dim timeDate As String = DateTime.Now.ToString(),
            temp As String = Me.temp.Text & " °C",
            fullName As String = $"{last.Text}, {first.Text} {middle.Text}",
            completeAddress As String = $"{house.Text} {street.Text} {barangay.Text}, {city.Text}",
            contacts As String = mobile.Text,
            gender As String = "",
            health As String = ""

        For Each checkbox In innerTable.Controls.OfType(Of CheckBox)()
            If checkbox.Checked Then
                If health = "" Then
                    health = $"Has {checkbox.Name}"
                Else
                    health += $", has {checkbox.Name}"
                End If
            End If
        Next

        If health = "" Then health = "No COVID-like symptoms"
        gender = If(male.Checked, "Male", "Female")

        ' Execute database entry based on initialized fields above
        databaseEnter(New List(Of String)() From {
            timeDate, temp, fullName, gender,
            completeAddress, health, contacts
        })

        ' Determine between form resubmission or application exit
        If MessageBox.Show($"Your form has successfully pushed through" &
            $", {first.Text}~ much thanks!" & vbLf & vbLf & $"Want to submit again?",
            "Submission Complete", MessageBoxButtons.YesNo,
            MessageBoxIcon.Asterisk) = DialogResult.No Then Application.[Exit]()

        ' Clear all fields
        clearAll(Me.innerTable)
    End Sub

    Private Sub databaseEnter(entries As List(Of String))

        ' Initialize database file & its directory
        Dim username As String = "Benedict"
        Dim database As String = $"C:\Users\{username}\Documents\CTDatabase.txt"
        ' Note: 'username' & 'database' can be changed depending on target

        Dim enter As String = ""
        For Each entry In entries
            enter += entry & vbLf
        Next

        ' If database specified above is found...
        If File.Exists(database) Then
            Using myFile = New StreamWriter(database, append:=True)
                myFile.NewLine = vbLf
                myFile.WriteLine(enter) ' Append to file
            End Using
        Else
            File.WriteAllText(database, enter & vbLf) ' Else, create new
        End If
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

    ' ------------- For QR Code functionality ------------- '

    Dim MyWebcam As VideoCaptureDevice
    Dim Reader As QRCodeDecoder

    Private Sub StartWebcam()
        Try
            Dim cameraOptions As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
            If cameraOptions.ShowDialog() = Windows.Forms.DialogResult.OK Then
                MyWebcam = cameraOptions.VideoDevice
                AddHandler MyWebcam.NewFrame, New NewFrameEventHandler(AddressOf Captured)
                MyWebcam.Start()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        camera.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub StopWebcam()
        Try
            MyWebcam.Stop()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles startButton.Click
        StartWebcam()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles scanButton.Click
        Try
            StopWebcam()
            Reader = New QRCodeDecoder
            Dim text As String = Reader.decode(New Data.QRCodeBitmapImage(camera.Image))

            MsgBox(text)
            ' MsgBox("QR Code scan successful! Details are now filled up. Please click submit.")
        Catch ex As Exception
            StartWebcam()
        End Try
    End Sub
End Class
