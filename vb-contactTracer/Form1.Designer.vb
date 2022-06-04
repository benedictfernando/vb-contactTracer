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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.outerTable = New System.Windows.Forms.TableLayoutPanel()
        Me.innerTable = New System.Windows.Forms.TableLayoutPanel()
        Me.headingTable = New System.Windows.Forms.TableLayoutPanel()
        Me.outerTable.SuspendLayout()
        Me.innerTable.SuspendLayout()
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
        Me.innerTable.ColumnCount = 4
        Me.innerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.innerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.innerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.innerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.innerTable.Controls.Add(Me.headingTable, 0, 0)
        Me.innerTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.innerTable.Location = New System.Drawing.Point(23, 23)
        Me.innerTable.Name = "innerTable"
        Me.innerTable.RowCount = 10
        Me.innerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
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
        'headingTable
        '
        Me.headingTable.ColumnCount = 1
        Me.innerTable.SetColumnSpan(Me.headingTable, 3)
        Me.headingTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.headingTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.headingTable.Location = New System.Drawing.Point(3, 3)
        Me.headingTable.Name = "headingTable"
        Me.headingTable.RowCount = 2
        Me.headingTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.headingTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.headingTable.Size = New System.Drawing.Size(543, 76)
        Me.headingTable.TabIndex = 0
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents outerTable As TableLayoutPanel
    Friend WithEvents innerTable As TableLayoutPanel
    Friend WithEvents headingTable As TableLayoutPanel
End Class
