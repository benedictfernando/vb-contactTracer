﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.outerTable = New System.Windows.Forms.TableLayoutPanel()
        Me.innerTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.outerTable.SuspendLayout()
        Me.innerTable.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
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
        Me.innerTable.Controls.Add(Me.Label1, 0, 0)
        Me.innerTable.Controls.Add(Me.Label2, 0, 1)
        Me.innerTable.Controls.Add(Me.Label3, 3, 0)
        Me.innerTable.Controls.Add(Me.Label4, 0, 2)
        Me.innerTable.Controls.Add(Me.Label5, 1, 2)
        Me.innerTable.Controls.Add(Me.Label6, 2, 2)
        Me.innerTable.Controls.Add(Me.Label7, 0, 4)
        Me.innerTable.Controls.Add(Me.Label8, 0, 6)
        Me.innerTable.Controls.Add(Me.Label9, 0, 8)
        Me.innerTable.Controls.Add(Me.Label10, 0, 9)
        Me.innerTable.Controls.Add(Me.TableLayoutPanel1, 1, 4)
        Me.innerTable.Controls.Add(Me.TableLayoutPanel2, 1, 6)
        Me.innerTable.Controls.Add(Me.Label19, 1, 9)
        Me.innerTable.Controls.Add(Me.Label20, 2, 9)
        Me.innerTable.Controls.Add(Me.DateTimePicker1, 1, 3)
        Me.innerTable.Controls.Add(Me.TextBox1, 2, 3)
        Me.innerTable.Controls.Add(Me.CheckBox1, 1, 8)
        Me.innerTable.Controls.Add(Me.CheckBox2, 2, 8)
        Me.innerTable.Controls.Add(Me.CheckBox3, 3, 8)
        Me.innerTable.Controls.Add(Me.TextBox9, 1, 10)
        Me.innerTable.Controls.Add(Me.Button1, 3, 9)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.innerTable.SetColumnSpan(Me.Label1, 3)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(543, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tracing Application Form"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.innerTable.SetColumnSpan(Me.Label2, 3)
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(3, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(543, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Note: Please fill out all fields honestly. Also, kindly not forget to submit this" &
    " afterwards."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 27.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(552, 0)
        Me.Label3.Name = "Label3"
        Me.innerTable.SetRowSpan(Me.Label3, 4)
        Me.Label3.Size = New System.Drawing.Size(179, 145)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Time"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(3, 81)
        Me.Label4.Name = "Label4"
        Me.innerTable.SetRowSpan(Me.Label4, 2)
        Me.Label4.Size = New System.Drawing.Size(177, 64)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Current Data"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(3, 145)
        Me.Label7.Name = "Label7"
        Me.innerTable.SetRowSpan(Me.Label7, 2)
        Me.Label7.Size = New System.Drawing.Size(177, 64)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Personal Information"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(3, 209)
        Me.Label8.Name = "Label8"
        Me.innerTable.SetRowSpan(Me.Label8, 2)
        Me.Label8.Size = New System.Drawing.Size(177, 64)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Address"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(3, 273)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(177, 65)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Health Check"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(3, 338)
        Me.Label10.Name = "Label10"
        Me.innerTable.SetRowSpan(Me.Label10, 2)
        Me.Label10.Size = New System.Drawing.Size(177, 73)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Contact Details"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.innerTable.SetColumnSpan(Me.TableLayoutPanel1, 3)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.66!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.33!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.33!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox4, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.RadioButton1, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.RadioButton2, 4, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(186, 148)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.innerTable.SetRowSpan(Me.TableLayoutPanel1, 2)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(545, 58)
        Me.TableLayoutPanel1.TabIndex = 10
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
        'TextBox2
        '
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.Location = New System.Drawing.Point(3, 32)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PlaceholderText = "Ex: Dela Cruz"
        Me.TextBox2.Size = New System.Drawing.Size(175, 22)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox3.Location = New System.Drawing.Point(184, 32)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PlaceholderText = "Ex: Juan"
        Me.TextBox3.Size = New System.Drawing.Size(175, 22)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox4.Location = New System.Drawing.Point(365, 32)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(30, 22)
        Me.TextBox4.TabIndex = 5
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton1.Location = New System.Drawing.Point(401, 32)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(61, 23)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton2.Location = New System.Drawing.Point(468, 32)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(74, 23)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.innerTable.SetColumnSpan(Me.TableLayoutPanel2, 3)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label15, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label16, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label17, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label18, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox5, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox6, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox7, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox8, 3, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(186, 212)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.innerTable.SetRowSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(545, 58)
        Me.TableLayoutPanel2.TabIndex = 11
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
        'TextBox5
        '
        Me.TextBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox5.Location = New System.Drawing.Point(3, 32)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.PlaceholderText = "Ex: 123"
        Me.TextBox5.Size = New System.Drawing.Size(48, 22)
        Me.TextBox5.TabIndex = 8
        '
        'TextBox6
        '
        Me.TextBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox6.Location = New System.Drawing.Point(57, 32)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.PlaceholderText = "Ex: 25th Street"
        Me.TextBox6.Size = New System.Drawing.Size(157, 22)
        Me.TextBox6.TabIndex = 9
        '
        'TextBox7
        '
        Me.TextBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox7.Location = New System.Drawing.Point(220, 32)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.PlaceholderText = "Ex: BGC"
        Me.TextBox7.Size = New System.Drawing.Size(157, 22)
        Me.TextBox7.TabIndex = 10
        '
        'TextBox8
        '
        Me.TextBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox8.Location = New System.Drawing.Point(383, 32)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.PlaceholderText = "Ex: Taguig"
        Me.TextBox8.Size = New System.Drawing.Size(159, 22)
        Me.TextBox8.TabIndex = 11
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
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker1.CustomFormat = "ddd dd MMM yyyy"
        Me.DateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(186, 116)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(177, 22)
        Me.DateTimePicker1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(369, 116)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PlaceholderText = "Ex: 35.6"
        Me.TextBox1.Size = New System.Drawing.Size(177, 22)
        Me.TextBox1.TabIndex = 2
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox1.Location = New System.Drawing.Point(186, 276)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(177, 59)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Currently having fever?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox2.Location = New System.Drawing.Point(369, 276)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(177, 59)
        Me.CheckBox2.TabIndex = 13
        Me.CheckBox2.Text = "Currently having colds?"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox3.Location = New System.Drawing.Point(552, 276)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(179, 59)
        Me.CheckBox3.TabIndex = 14
        Me.CheckBox3.Text = "Currently having cough?"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox9.Location = New System.Drawing.Point(186, 373)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.PlaceholderText = "Ex: 0912 345 6789"
        Me.TextBox9.Size = New System.Drawing.Size(177, 22)
        Me.TextBox9.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(552, 341)
        Me.Button1.Name = "Button1"
        Me.innerTable.SetRowSpan(Me.Button1, 2)
        Me.Button1.Size = New System.Drawing.Size(179, 67)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents outerTable As TableLayoutPanel
    Friend WithEvents innerTable As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Button1 As Button
End Class
