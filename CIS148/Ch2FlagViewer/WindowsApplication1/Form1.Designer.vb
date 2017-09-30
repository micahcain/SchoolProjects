<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CountryGroupBox = New System.Windows.Forms.GroupBox
        Me.StrongBadianRadioButton = New System.Windows.Forms.RadioButton
        Me.IrelandRadioButton = New System.Windows.Forms.RadioButton
        Me.JapanRadioButton = New System.Windows.Forms.RadioButton
        Me.USARadioButton = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.DisplayGroupBox = New System.Windows.Forms.GroupBox
        Me.ProgrammerCheckBox = New System.Windows.Forms.CheckBox
        Me.CountryCheckBox = New System.Windows.Forms.CheckBox
        Me.TitleCheckBox = New System.Windows.Forms.CheckBox
        Me.FlagPictureBox = New System.Windows.Forms.PictureBox
        Me.CountryLabel = New System.Windows.Forms.Label
        Me.PrintButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.ByLineLabel = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.CountryGroupBox.SuspendLayout()
        Me.DisplayGroupBox.SuspendLayout()
        CType(Me.FlagPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CountryGroupBox
        '
        Me.CountryGroupBox.Controls.Add(Me.StrongBadianRadioButton)
        Me.CountryGroupBox.Controls.Add(Me.IrelandRadioButton)
        Me.CountryGroupBox.Controls.Add(Me.JapanRadioButton)
        Me.CountryGroupBox.Controls.Add(Me.USARadioButton)
        Me.CountryGroupBox.Location = New System.Drawing.Point(12, 25)
        Me.CountryGroupBox.Name = "CountryGroupBox"
        Me.CountryGroupBox.Size = New System.Drawing.Size(169, 153)
        Me.CountryGroupBox.TabIndex = 0
        Me.CountryGroupBox.TabStop = False
        Me.CountryGroupBox.Text = "Country"
        '
        'StrongBadianRadioButton
        '
        Me.StrongBadianRadioButton.AutoSize = True
        Me.StrongBadianRadioButton.Location = New System.Drawing.Point(11, 88)
        Me.StrongBadianRadioButton.Name = "StrongBadianRadioButton"
        Me.StrongBadianRadioButton.Size = New System.Drawing.Size(86, 17)
        Me.StrongBadianRadioButton.TabIndex = 11
        Me.StrongBadianRadioButton.TabStop = True
        Me.StrongBadianRadioButton.Text = "Strong &Badia"
        Me.ToolTip1.SetToolTip(Me.StrongBadianRadioButton, "Select to see the Strong Badian flag and marvel at its awesomeness!")
        Me.StrongBadianRadioButton.UseVisualStyleBackColor = True
        '
        'IrelandRadioButton
        '
        Me.IrelandRadioButton.AutoSize = True
        Me.IrelandRadioButton.Location = New System.Drawing.Point(11, 65)
        Me.IrelandRadioButton.Name = "IrelandRadioButton"
        Me.IrelandRadioButton.Size = New System.Drawing.Size(57, 17)
        Me.IrelandRadioButton.TabIndex = 10
        Me.IrelandRadioButton.TabStop = True
        Me.IrelandRadioButton.Text = "&Ireland"
        Me.ToolTip1.SetToolTip(Me.IrelandRadioButton, "Select to see the Irish flag")
        Me.IrelandRadioButton.UseVisualStyleBackColor = True
        '
        'JapanRadioButton
        '
        Me.JapanRadioButton.AutoSize = True
        Me.JapanRadioButton.Location = New System.Drawing.Point(11, 42)
        Me.JapanRadioButton.Name = "JapanRadioButton"
        Me.JapanRadioButton.Size = New System.Drawing.Size(54, 17)
        Me.JapanRadioButton.TabIndex = 9
        Me.JapanRadioButton.TabStop = True
        Me.JapanRadioButton.Text = "&Japan"
        Me.ToolTip1.SetToolTip(Me.JapanRadioButton, "Select to see the Japanese flag")
        Me.JapanRadioButton.UseVisualStyleBackColor = True
        '
        'USARadioButton
        '
        Me.USARadioButton.AutoSize = True
        Me.USARadioButton.Location = New System.Drawing.Point(11, 19)
        Me.USARadioButton.Name = "USARadioButton"
        Me.USARadioButton.Size = New System.Drawing.Size(89, 17)
        Me.USARadioButton.TabIndex = 8
        Me.USARadioButton.TabStop = True
        Me.USARadioButton.Text = "&United States"
        Me.ToolTip1.SetToolTip(Me.USARadioButton, "Select to see the United States flag")
        Me.USARadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Flag Viewer"
        '
        'DisplayGroupBox
        '
        Me.DisplayGroupBox.Controls.Add(Me.ProgrammerCheckBox)
        Me.DisplayGroupBox.Controls.Add(Me.CountryCheckBox)
        Me.DisplayGroupBox.Controls.Add(Me.TitleCheckBox)
        Me.DisplayGroupBox.Location = New System.Drawing.Point(412, 25)
        Me.DisplayGroupBox.Name = "DisplayGroupBox"
        Me.DisplayGroupBox.Size = New System.Drawing.Size(180, 153)
        Me.DisplayGroupBox.TabIndex = 2
        Me.DisplayGroupBox.TabStop = False
        Me.DisplayGroupBox.Text = "Display"
        '
        'ProgrammerCheckBox
        '
        Me.ProgrammerCheckBox.AutoSize = True
        Me.ProgrammerCheckBox.Checked = True
        Me.ProgrammerCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ProgrammerCheckBox.Location = New System.Drawing.Point(18, 67)
        Me.ProgrammerCheckBox.Name = "ProgrammerCheckBox"
        Me.ProgrammerCheckBox.Size = New System.Drawing.Size(82, 17)
        Me.ProgrammerCheckBox.TabIndex = 10
        Me.ProgrammerCheckBox.Text = "Programmer"
        Me.ToolTip1.SetToolTip(Me.ProgrammerCheckBox, "Show/Hide programmer name")
        Me.ProgrammerCheckBox.UseVisualStyleBackColor = True
        '
        'CountryCheckBox
        '
        Me.CountryCheckBox.AutoSize = True
        Me.CountryCheckBox.Checked = True
        Me.CountryCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CountryCheckBox.Location = New System.Drawing.Point(18, 44)
        Me.CountryCheckBox.Name = "CountryCheckBox"
        Me.CountryCheckBox.Size = New System.Drawing.Size(93, 17)
        Me.CountryCheckBox.TabIndex = 9
        Me.CountryCheckBox.Text = "C&ountry Name"
        Me.ToolTip1.SetToolTip(Me.CountryCheckBox, "Show/Hide country name")
        Me.CountryCheckBox.UseVisualStyleBackColor = True
        '
        'TitleCheckBox
        '
        Me.TitleCheckBox.AutoSize = True
        Me.TitleCheckBox.Checked = True
        Me.TitleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TitleCheckBox.Location = New System.Drawing.Point(18, 21)
        Me.TitleCheckBox.Name = "TitleCheckBox"
        Me.TitleCheckBox.Size = New System.Drawing.Size(46, 17)
        Me.TitleCheckBox.TabIndex = 8
        Me.TitleCheckBox.Text = "Title"
        Me.ToolTip1.SetToolTip(Me.TitleCheckBox, "Show/Hide title bar")
        Me.TitleCheckBox.UseVisualStyleBackColor = True
        '
        'FlagPictureBox
        '
        Me.FlagPictureBox.Location = New System.Drawing.Point(209, 46)
        Me.FlagPictureBox.Name = "FlagPictureBox"
        Me.FlagPictureBox.Size = New System.Drawing.Size(184, 132)
        Me.FlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FlagPictureBox.TabIndex = 3
        Me.FlagPictureBox.TabStop = False
        '
        'CountryLabel
        '
        Me.CountryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CountryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryLabel.Location = New System.Drawing.Point(241, 191)
        Me.CountryLabel.Name = "CountryLabel"
        Me.CountryLabel.Size = New System.Drawing.Size(131, 23)
        Me.CountryLabel.TabIndex = 4
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(344, 258)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 22)
        Me.PrintButton.TabIndex = 5
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(446, 257)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ByLineLabel
        '
        Me.ByLineLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ByLineLabel.Location = New System.Drawing.Point(23, 267)
        Me.ByLineLabel.Name = "ByLineLabel"
        Me.ByLineLabel.Size = New System.Drawing.Size(147, 23)
        Me.ByLineLabel.TabIndex = 7
        Me.ByLineLabel.Text = "Programmed by Micah Cain"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(618, 322)
        Me.Controls.Add(Me.ByLineLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.CountryLabel)
        Me.Controls.Add(Me.FlagPictureBox)
        Me.Controls.Add(Me.DisplayGroupBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CountryGroupBox)
        Me.Name = "Form1"
        Me.Text = "Flag Viewer by Micah Cain"
        Me.CountryGroupBox.ResumeLayout(False)
        Me.CountryGroupBox.PerformLayout()
        Me.DisplayGroupBox.ResumeLayout(False)
        Me.DisplayGroupBox.PerformLayout()
        CType(Me.FlagPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CountryGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DisplayGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents FlagPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents CountryLabel As System.Windows.Forms.Label
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents StrongBadianRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents IrelandRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents JapanRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents USARadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ProgrammerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CountryCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TitleCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ByLineLabel As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
