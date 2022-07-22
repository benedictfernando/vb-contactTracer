<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.outerTable = New System.Windows.Forms.TableLayoutPanel()
        Me.innerTable = New System.Windows.Forms.TableLayoutPanel()
        Me.heading = New System.Windows.Forms.Label()
        Me.note = New System.Windows.Forms.Label()
        Me.dataLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.infoLabel = New System.Windows.Forms.Label()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.checkLabel = New System.Windows.Forms.Label()
        Me.detailsLabel = New System.Windows.Forms.Label()
        Me.infoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.last = New System.Windows.Forms.TextBox()
        Me.first = New System.Windows.Forms.TextBox()
        Me.middle = New System.Windows.Forms.TextBox()
        Me.male = New System.Windows.Forms.RadioButton()
        Me.female = New System.Windows.Forms.RadioButton()
        Me.addressTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.house = New System.Windows.Forms.TextBox()
        Me.street = New System.Windows.Forms.TextBox()
        Me.barangay = New System.Windows.Forms.TextBox()
        Me.city = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.day = New System.Windows.Forms.DateTimePicker()
        Me.temp = New System.Windows.Forms.TextBox()
        Me.fever = New System.Windows.Forms.CheckBox()
        Me.colds = New System.Windows.Forms.CheckBox()
        Me.cough = New System.Windows.Forms.CheckBox()
        Me.mobile = New System.Windows.Forms.TextBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.camera = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.startButton = New System.Windows.Forms.Button()
        Me.scanButton = New System.Windows.Forms.Button()
        Me.clock = New System.Windows.Forms.Timer(Me.components)
        Me.outerTable.SuspendLayout()
        Me.innerTable.SuspendLayout()
        Me.infoTable.SuspendLayout()
        Me.addressTable.SuspendLayout()
        CType(Me.camera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'outerTable
        '
        Me.outerTable.ColumnCount = 3
        Me.outerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.outerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.outerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.outerTable.Controls.Add(Me.innerTable, 1, 1)
        Me.outerTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.outerTable.Location = New System.Drawing.Point(0, 0)
        Me.outerTable.Name = "outerTable"
        Me.outerTable.RowCount = 3
        Me.outerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.outerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.outerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.outerTable.Size = New System.Drawing.Size(780, 457)
        Me.outerTable.TabIndex = 0
        '
        'innerTable
        '
        Me.innerTable.BackColor = System.Drawing.SystemColors.Control
        Me.innerTable.ColumnCount = 4
        Me.innerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.innerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.innerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.innerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.innerTable.Controls.Add(Me.heading, 0, 0)
        Me.innerTable.Controls.Add(Me.note, 0, 1)
        Me.innerTable.Controls.Add(Me.dataLabel, 0, 2)
        Me.innerTable.Controls.Add(Me.Label5, 1, 2)
        Me.innerTable.Controls.Add(Me.Label6, 2, 2)
        Me.innerTable.Controls.Add(Me.infoLabel, 0, 4)
        Me.innerTable.Controls.Add(Me.addressLabel, 0, 6)
        Me.innerTable.Controls.Add(Me.checkLabel, 0, 8)
        Me.innerTable.Controls.Add(Me.detailsLabel, 0, 9)
        Me.innerTable.Controls.Add(Me.infoTable, 1, 4)
        Me.innerTable.Controls.Add(Me.addressTable, 1, 6)
        Me.innerTable.Controls.Add(Me.Label19, 1, 9)
        Me.innerTable.Controls.Add(Me.Label20, 2, 9)
        Me.innerTable.Controls.Add(Me.day, 1, 3)
        Me.innerTable.Controls.Add(Me.temp, 2, 3)
        Me.innerTable.Controls.Add(Me.fever, 1, 8)
        Me.innerTable.Controls.Add(Me.colds, 2, 8)
        Me.innerTable.Controls.Add(Me.cough, 3, 8)
        Me.innerTable.Controls.Add(Me.mobile, 1, 10)
        Me.innerTable.Controls.Add(Me.submit, 3, 9)
        Me.innerTable.Controls.Add(Me.camera, 3, 0)
        Me.innerTable.Controls.Add(Me.TableLayoutPanel1, 3, 3)
        Me.innerTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.innerTable.Location = New System.Drawing.Point(23, 23)
        Me.innerTable.Name = "innerTable"
        Me.innerTable.RowCount = 11
        Me.innerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.innerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.innerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.innerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.innerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.innerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.innerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.innerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.innerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.innerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.innerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.innerTable.Size = New System.Drawing.Size(734, 411)
        Me.innerTable.TabIndex = 0
        '
        'heading
        '
        Me.heading.AutoSize = True
        Me.innerTable.SetColumnSpan(Me.heading, 3)
        Me.heading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.heading.Font = New System.Drawing.Font("Century Gothic", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.heading.Location = New System.Drawing.Point(3, 0)
        Me.heading.Name = "heading"
        Me.heading.Size = New System.Drawing.Size(543, 57)
        Me.heading.TabIndex = 0
        Me.heading.Text = "Tracing Application Form"
        Me.heading.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'note
        '
        Me.note.AutoSize = True
        Me.innerTable.SetColumnSpan(Me.note, 3)
        Me.note.Dock = System.Windows.Forms.DockStyle.Fill
        Me.note.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.note.Location = New System.Drawing.Point(3, 57)
        Me.note.Name = "note"
        Me.note.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.note.Size = New System.Drawing.Size(543, 24)
        Me.note.TabIndex = 1
        Me.note.Text = "Note: Please fill out all fields honestly. Also, kindly not forget to submit this" &
    " afterwards."
        Me.note.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dataLabel
        '
        Me.dataLabel.AutoSize = True
        Me.dataLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataLabel.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.dataLabel.Location = New System.Drawing.Point(3, 81)
        Me.dataLabel.Name = "dataLabel"
        Me.innerTable.SetRowSpan(Me.dataLabel, 2)
        Me.dataLabel.Size = New System.Drawing.Size(177, 64)
        Me.dataLabel.TabIndex = 3
        Me.dataLabel.Text = "Current Data"
        Me.dataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(186, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 32)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(369, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 32)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Temperature (°C)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'infoLabel
        '
        Me.infoLabel.AutoSize = True
        Me.infoLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.infoLabel.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.infoLabel.Location = New System.Drawing.Point(3, 145)
        Me.infoLabel.Name = "infoLabel"
        Me.innerTable.SetRowSpan(Me.infoLabel, 2)
        Me.infoLabel.Size = New System.Drawing.Size(177, 64)
        Me.infoLabel.TabIndex = 6
        Me.infoLabel.Text = "Personal Information"
        Me.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'addressLabel
        '
        Me.addressLabel.AutoSize = True
        Me.addressLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addressLabel.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.addressLabel.Location = New System.Drawing.Point(3, 209)
        Me.addressLabel.Name = "addressLabel"
        Me.innerTable.SetRowSpan(Me.addressLabel, 2)
        Me.addressLabel.Size = New System.Drawing.Size(177, 64)
        Me.addressLabel.TabIndex = 7
        Me.addressLabel.Text = "Address"
        Me.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'checkLabel
        '
        Me.checkLabel.AutoSize = True
        Me.checkLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.checkLabel.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.checkLabel.Location = New System.Drawing.Point(3, 273)
        Me.checkLabel.Name = "checkLabel"
        Me.checkLabel.Size = New System.Drawing.Size(177, 65)
        Me.checkLabel.TabIndex = 8
        Me.checkLabel.Text = "Health Check"
        Me.checkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'detailsLabel
        '
        Me.detailsLabel.AutoSize = True
        Me.detailsLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.detailsLabel.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.detailsLabel.Location = New System.Drawing.Point(3, 338)
        Me.detailsLabel.Name = "detailsLabel"
        Me.innerTable.SetRowSpan(Me.detailsLabel, 2)
        Me.detailsLabel.Size = New System.Drawing.Size(177, 73)
        Me.detailsLabel.TabIndex = 9
        Me.detailsLabel.Text = "Contact Details"
        Me.detailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'infoTable
        '
        Me.infoTable.ColumnCount = 5
        Me.innerTable.SetColumnSpan(Me.infoTable, 3)
        Me.infoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34!))
        Me.infoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34!))
        Me.infoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.66!))
        Me.infoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.33!))
        Me.infoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.33!))
        Me.infoTable.Controls.Add(Me.Label11, 0, 0)
        Me.infoTable.Controls.Add(Me.Label12, 1, 0)
        Me.infoTable.Controls.Add(Me.Label13, 2, 0)
        Me.infoTable.Controls.Add(Me.Label14, 3, 0)
        Me.infoTable.Controls.Add(Me.last, 0, 1)
        Me.infoTable.Controls.Add(Me.first, 1, 1)
        Me.infoTable.Controls.Add(Me.middle, 2, 1)
        Me.infoTable.Controls.Add(Me.male, 3, 1)
        Me.infoTable.Controls.Add(Me.female, 4, 1)
        Me.infoTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.infoTable.Location = New System.Drawing.Point(186, 148)
        Me.infoTable.Name = "infoTable"
        Me.infoTable.RowCount = 2
        Me.innerTable.SetRowSpan(Me.infoTable, 2)
        Me.infoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.infoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.infoTable.Size = New System.Drawing.Size(545, 58)
        Me.infoTable.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Location = New System.Drawing.Point(3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(175, 29)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Surname"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Location = New System.Drawing.Point(184, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(175, 29)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Given Name"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Location = New System.Drawing.Point(365, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 29)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "M.I."
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Location = New System.Drawing.Point(401, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 29)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Gender"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'last
        '
        Me.last.Dock = System.Windows.Forms.DockStyle.Fill
        Me.last.Location = New System.Drawing.Point(3, 32)
        Me.last.Name = "last"
        Me.last.PlaceholderText = "Ex: Dela Cruz"
        Me.last.Size = New System.Drawing.Size(175, 22)
        Me.last.TabIndex = 3
        '
        'first
        '
        Me.first.Dock = System.Windows.Forms.DockStyle.Fill
        Me.first.Location = New System.Drawing.Point(184, 32)
        Me.first.Name = "first"
        Me.first.PlaceholderText = "Ex: Juan"
        Me.first.Size = New System.Drawing.Size(175, 22)
        Me.first.TabIndex = 4
        '
        'middle
        '
        Me.middle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.middle.Location = New System.Drawing.Point(365, 32)
        Me.middle.Name = "middle"
        Me.middle.Size = New System.Drawing.Size(30, 22)
        Me.middle.TabIndex = 5
        '
        'male
        '
        Me.male.AutoSize = True
        Me.male.Dock = System.Windows.Forms.DockStyle.Fill
        Me.male.Location = New System.Drawing.Point(401, 32)
        Me.male.Name = "male"
        Me.male.Size = New System.Drawing.Size(61, 23)
        Me.male.TabIndex = 6
        Me.male.TabStop = True
        Me.male.Text = "Male"
        Me.male.UseVisualStyleBackColor = True
        '
        'female
        '
        Me.female.AutoSize = True
        Me.female.Dock = System.Windows.Forms.DockStyle.Fill
        Me.female.Location = New System.Drawing.Point(468, 32)
        Me.female.Name = "female"
        Me.female.Size = New System.Drawing.Size(74, 23)
        Me.female.TabIndex = 7
        Me.female.TabStop = True
        Me.female.Text = "Female"
        Me.female.UseVisualStyleBackColor = True
        '
        'addressTable
        '
        Me.addressTable.ColumnCount = 4
        Me.innerTable.SetColumnSpan(Me.addressTable, 3)
        Me.addressTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.addressTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.addressTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.addressTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.addressTable.Controls.Add(Me.Label15, 0, 0)
        Me.addressTable.Controls.Add(Me.Label16, 1, 0)
        Me.addressTable.Controls.Add(Me.Label17, 2, 0)
        Me.addressTable.Controls.Add(Me.Label18, 3, 0)
        Me.addressTable.Controls.Add(Me.house, 0, 1)
        Me.addressTable.Controls.Add(Me.street, 1, 1)
        Me.addressTable.Controls.Add(Me.barangay, 2, 1)
        Me.addressTable.Controls.Add(Me.city, 3, 1)
        Me.addressTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addressTable.Location = New System.Drawing.Point(186, 212)
        Me.addressTable.Name = "addressTable"
        Me.addressTable.RowCount = 2
        Me.innerTable.SetRowSpan(Me.addressTable, 2)
        Me.addressTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.addressTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.addressTable.Size = New System.Drawing.Size(545, 58)
        Me.addressTable.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Location = New System.Drawing.Point(3, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 29)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "No."
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Location = New System.Drawing.Point(57, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(157, 29)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Street"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Location = New System.Drawing.Point(220, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(157, 29)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Subdivision/District"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Location = New System.Drawing.Point(383, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(159, 29)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "City"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'house
        '
        Me.house.Dock = System.Windows.Forms.DockStyle.Fill
        Me.house.Location = New System.Drawing.Point(3, 32)
        Me.house.Name = "house"
        Me.house.PlaceholderText = "Ex: 123"
        Me.house.Size = New System.Drawing.Size(48, 22)
        Me.house.TabIndex = 8
        '
        'street
        '
        Me.street.Dock = System.Windows.Forms.DockStyle.Fill
        Me.street.Location = New System.Drawing.Point(57, 32)
        Me.street.Name = "street"
        Me.street.PlaceholderText = "Ex: 25th Street"
        Me.street.Size = New System.Drawing.Size(157, 22)
        Me.street.TabIndex = 9
        '
        'barangay
        '
        Me.barangay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.barangay.Location = New System.Drawing.Point(220, 32)
        Me.barangay.Name = "barangay"
        Me.barangay.PlaceholderText = "Ex: BGC"
        Me.barangay.Size = New System.Drawing.Size(157, 22)
        Me.barangay.TabIndex = 10
        '
        'city
        '
        Me.city.Dock = System.Windows.Forms.DockStyle.Fill
        Me.city.Location = New System.Drawing.Point(383, 32)
        Me.city.Name = "city"
        Me.city.PlaceholderText = "Ex: Taguig"
        Me.city.Size = New System.Drawing.Size(159, 22)
        Me.city.TabIndex = 11
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label19.Location = New System.Drawing.Point(186, 338)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(177, 32)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Phone. No."
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label20.Location = New System.Drawing.Point(369, 338)
        Me.Label20.Name = "Label20"
        Me.innerTable.SetRowSpan(Me.Label20, 2)
        Me.Label20.Size = New System.Drawing.Size(177, 73)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "By submitting, you agree to allow us store and use your data for tracking purpose" &
    "s, to keep us safe in this COVID-19 pandemic."
        '
        'day
        '
        Me.day.CalendarFont = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.day.CustomFormat = "ddd dd MMM yyyy"
        Me.day.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.day.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.day.Location = New System.Drawing.Point(186, 116)
        Me.day.Name = "day"
        Me.day.Size = New System.Drawing.Size(177, 22)
        Me.day.TabIndex = 1
        '
        'temp
        '
        Me.temp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.temp.Location = New System.Drawing.Point(369, 116)
        Me.temp.Name = "temp"
        Me.temp.PlaceholderText = "Ex: 35.6"
        Me.temp.Size = New System.Drawing.Size(177, 22)
        Me.temp.TabIndex = 2
        '
        'fever
        '
        Me.fever.AutoSize = True
        Me.fever.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fever.Location = New System.Drawing.Point(186, 276)
        Me.fever.Name = "fever"
        Me.fever.Size = New System.Drawing.Size(177, 59)
        Me.fever.TabIndex = 12
        Me.fever.Text = "Currently having fever?"
        Me.fever.UseVisualStyleBackColor = True
        '
        'colds
        '
        Me.colds.AutoSize = True
        Me.colds.Dock = System.Windows.Forms.DockStyle.Fill
        Me.colds.Location = New System.Drawing.Point(369, 276)
        Me.colds.Name = "colds"
        Me.colds.Size = New System.Drawing.Size(177, 59)
        Me.colds.TabIndex = 13
        Me.colds.Text = "Currently having colds?"
        Me.colds.UseVisualStyleBackColor = True
        '
        'cough
        '
        Me.cough.AutoSize = True
        Me.cough.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cough.Location = New System.Drawing.Point(552, 276)
        Me.cough.Name = "cough"
        Me.cough.Size = New System.Drawing.Size(179, 59)
        Me.cough.TabIndex = 14
        Me.cough.Text = "Currently having cough?"
        Me.cough.UseVisualStyleBackColor = True
        '
        'mobile
        '
        Me.mobile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mobile.Location = New System.Drawing.Point(186, 373)
        Me.mobile.Name = "mobile"
        Me.mobile.PlaceholderText = "Ex: 0912 345 6789"
        Me.mobile.Size = New System.Drawing.Size(177, 22)
        Me.mobile.TabIndex = 15
        '
        'submit
        '
        Me.submit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.submit.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.submit.Location = New System.Drawing.Point(552, 341)
        Me.submit.Name = "submit"
        Me.innerTable.SetRowSpan(Me.submit, 2)
        Me.submit.Size = New System.Drawing.Size(179, 67)
        Me.submit.TabIndex = 16
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'camera
        '
        Me.camera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.camera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.camera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.camera.Location = New System.Drawing.Point(552, 3)
        Me.camera.Name = "camera"
        Me.innerTable.SetRowSpan(Me.camera, 3)
        Me.camera.Size = New System.Drawing.Size(179, 107)
        Me.camera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.camera.TabIndex = 19
        Me.camera.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.startButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.scanButton, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(552, 116)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(179, 26)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'startButton
        '
        Me.startButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.startButton.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.startButton.Location = New System.Drawing.Point(3, 3)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(83, 20)
        Me.startButton.TabIndex = 0
        Me.startButton.Text = "Start Cam"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'scanButton
        '
        Me.scanButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scanButton.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.scanButton.Location = New System.Drawing.Point(92, 3)
        Me.scanButton.Name = "scanButton"
        Me.scanButton.Size = New System.Drawing.Size(84, 20)
        Me.scanButton.TabIndex = 2
        Me.scanButton.Text = "Scan QR"
        Me.scanButton.UseVisualStyleBackColor = True
        '
        'clock
        '
        Me.clock.Enabled = True
        Me.clock.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(780, 457)
        Me.Controls.Add(Me.outerTable)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contact Tracer"
        Me.outerTable.ResumeLayout(False)
        Me.innerTable.ResumeLayout(False)
        Me.innerTable.PerformLayout()
        Me.infoTable.ResumeLayout(False)
        Me.infoTable.PerformLayout()
        Me.addressTable.ResumeLayout(False)
        Me.addressTable.PerformLayout()
        CType(Me.camera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents outerTable As TableLayoutPanel
    Friend WithEvents innerTable As TableLayoutPanel
    Friend WithEvents heading As Label
    Friend WithEvents note As Label
    Friend WithEvents dataLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents infoLabel As Label
    Friend WithEvents addressLabel As Label
    Friend WithEvents checkLabel As Label
    Friend WithEvents detailsLabel As Label
    Friend WithEvents infoTable As TableLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents addressTable As TableLayoutPanel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents last As TextBox
    Friend WithEvents first As TextBox
    Friend WithEvents middle As TextBox
    Friend WithEvents male As RadioButton
    Friend WithEvents female As RadioButton
    Friend WithEvents house As TextBox
    Friend WithEvents street As TextBox
    Friend WithEvents barangay As TextBox
    Friend WithEvents city As TextBox
    Friend WithEvents day As DateTimePicker
    Friend WithEvents temp As TextBox
    Friend WithEvents fever As CheckBox
    Friend WithEvents colds As CheckBox
    Friend WithEvents cough As CheckBox
    Friend WithEvents mobile As TextBox
    Friend WithEvents submit As Button
    Friend WithEvents clock As Timer
    Friend WithEvents camera As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents startButton As Button
    Friend WithEvents scanButton As Button
End Class
