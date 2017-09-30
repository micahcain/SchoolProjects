<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.DepartmentGroupBox = New System.Windows.Forms.GroupBox
        Me.CoffeeBarRadioButton = New System.Windows.Forms.RadioButton
        Me.PeriodicalsRadioButton = New System.Windows.Forms.RadioButton
        Me.MusicRadioButton = New System.Windows.Forms.RadioButton
        Me.BooksRadioButton = New System.Windows.Forms.RadioButton
        Me.CheckInGroupBox = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.MemberIDMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.NameTextBox = New System.Windows.Forms.TextBox
        Me.DepartmentPictureBox = New System.Windows.Forms.PictureBox
        Me.WelcomeRichTextBox = New System.Windows.Forms.RichTextBox
        Me.SignInButton = New System.Windows.Forms.Button
        Me.PrintButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.VisibleCheckBox = New System.Windows.Forms.CheckBox
        Me.PromotionTextBox = New System.Windows.Forms.TextBox
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.DepartmentGroupBox.SuspendLayout()
        Me.CheckInGroupBox.SuspendLayout()
        CType(Me.DepartmentPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DepartmentGroupBox
        '
        Me.DepartmentGroupBox.Controls.Add(Me.CoffeeBarRadioButton)
        Me.DepartmentGroupBox.Controls.Add(Me.PeriodicalsRadioButton)
        Me.DepartmentGroupBox.Controls.Add(Me.MusicRadioButton)
        Me.DepartmentGroupBox.Controls.Add(Me.BooksRadioButton)
        Me.DepartmentGroupBox.Enabled = False
        Me.DepartmentGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.DepartmentGroupBox.Name = "DepartmentGroupBox"
        Me.DepartmentGroupBox.Size = New System.Drawing.Size(234, 113)
        Me.DepartmentGroupBox.TabIndex = 4
        Me.DepartmentGroupBox.TabStop = False
        Me.DepartmentGroupBox.Text = "Department"
        '
        'CoffeeBarRadioButton
        '
        Me.CoffeeBarRadioButton.AutoSize = True
        Me.CoffeeBarRadioButton.Location = New System.Drawing.Point(6, 88)
        Me.CoffeeBarRadioButton.Name = "CoffeeBarRadioButton"
        Me.CoffeeBarRadioButton.Size = New System.Drawing.Size(75, 17)
        Me.CoffeeBarRadioButton.TabIndex = 3
        Me.CoffeeBarRadioButton.TabStop = True
        Me.CoffeeBarRadioButton.Text = "&Coffee Bar"
        Me.CoffeeBarRadioButton.UseVisualStyleBackColor = True
        '
        'PeriodicalsRadioButton
        '
        Me.PeriodicalsRadioButton.AutoSize = True
        Me.PeriodicalsRadioButton.Location = New System.Drawing.Point(6, 65)
        Me.PeriodicalsRadioButton.Name = "PeriodicalsRadioButton"
        Me.PeriodicalsRadioButton.Size = New System.Drawing.Size(76, 17)
        Me.PeriodicalsRadioButton.TabIndex = 2
        Me.PeriodicalsRadioButton.TabStop = True
        Me.PeriodicalsRadioButton.Text = "Perio&dicals"
        Me.PeriodicalsRadioButton.UseVisualStyleBackColor = True
        '
        'MusicRadioButton
        '
        Me.MusicRadioButton.AutoSize = True
        Me.MusicRadioButton.Location = New System.Drawing.Point(6, 42)
        Me.MusicRadioButton.Name = "MusicRadioButton"
        Me.MusicRadioButton.Size = New System.Drawing.Size(53, 17)
        Me.MusicRadioButton.TabIndex = 1
        Me.MusicRadioButton.TabStop = True
        Me.MusicRadioButton.Text = "&Music"
        Me.MusicRadioButton.UseVisualStyleBackColor = True
        '
        'BooksRadioButton
        '
        Me.BooksRadioButton.AutoSize = True
        Me.BooksRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.BooksRadioButton.Name = "BooksRadioButton"
        Me.BooksRadioButton.Size = New System.Drawing.Size(55, 17)
        Me.BooksRadioButton.TabIndex = 0
        Me.BooksRadioButton.TabStop = True
        Me.BooksRadioButton.Text = "&Books"
        Me.BooksRadioButton.UseVisualStyleBackColor = True
        '
        'CheckInGroupBox
        '
        Me.CheckInGroupBox.Controls.Add(Me.Label2)
        Me.CheckInGroupBox.Controls.Add(Me.Label1)
        Me.CheckInGroupBox.Controls.Add(Me.MemberIDMaskedTextBox)
        Me.CheckInGroupBox.Controls.Add(Me.NameTextBox)
        Me.CheckInGroupBox.Location = New System.Drawing.Point(263, 12)
        Me.CheckInGroupBox.Name = "CheckInGroupBox"
        Me.CheckInGroupBox.Size = New System.Drawing.Size(256, 113)
        Me.CheckInGroupBox.TabIndex = 0
        Me.CheckInGroupBox.TabStop = False
        Me.CheckInGroupBox.Text = "Elite Member Check In"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Member &ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Name"
        '
        'MemberIDMaskedTextBox
        '
        Me.MemberIDMaskedTextBox.Location = New System.Drawing.Point(100, 55)
        Me.MemberIDMaskedTextBox.Mask = "00000"
        Me.MemberIDMaskedTextBox.Name = "MemberIDMaskedTextBox"
        Me.MemberIDMaskedTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.MemberIDMaskedTextBox.Size = New System.Drawing.Size(37, 20)
        Me.MemberIDMaskedTextBox.TabIndex = 3
        Me.MemberIDMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(100, 29)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(150, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'DepartmentPictureBox
        '
        Me.DepartmentPictureBox.Location = New System.Drawing.Point(18, 149)
        Me.DepartmentPictureBox.Name = "DepartmentPictureBox"
        Me.DepartmentPictureBox.Size = New System.Drawing.Size(210, 128)
        Me.DepartmentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DepartmentPictureBox.TabIndex = 2
        Me.DepartmentPictureBox.TabStop = False
        '
        'WelcomeRichTextBox
        '
        Me.WelcomeRichTextBox.Location = New System.Drawing.Point(272, 131)
        Me.WelcomeRichTextBox.Name = "WelcomeRichTextBox"
        Me.WelcomeRichTextBox.Size = New System.Drawing.Size(247, 47)
        Me.WelcomeRichTextBox.TabIndex = 5
        Me.WelcomeRichTextBox.Text = ""
        '
        'SignInButton
        '
        Me.SignInButton.Location = New System.Drawing.Point(418, 196)
        Me.SignInButton.Name = "SignInButton"
        Me.SignInButton.Size = New System.Drawing.Size(75, 23)
        Me.SignInButton.TabIndex = 1
        Me.SignInButton.Text = "&Sign In"
        Me.SignInButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(418, 225)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 2
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(418, 254)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'VisibleCheckBox
        '
        Me.VisibleCheckBox.AutoSize = True
        Me.VisibleCheckBox.Location = New System.Drawing.Point(247, 229)
        Me.VisibleCheckBox.Name = "VisibleCheckBox"
        Me.VisibleCheckBox.Size = New System.Drawing.Size(88, 17)
        Me.VisibleCheckBox.TabIndex = 6
        Me.VisibleCheckBox.Text = "Image &Visible"
        Me.VisibleCheckBox.UseVisualStyleBackColor = True
        '
        'PromotionTextBox
        '
        Me.PromotionTextBox.Location = New System.Drawing.Point(12, 297)
        Me.PromotionTextBox.Name = "PromotionTextBox"
        Me.PromotionTextBox.Size = New System.Drawing.Size(316, 20)
        Me.PromotionTextBox.TabIndex = 7
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(363, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Programmed by Micah Cain"
        '
        'MainForm
        '
        Me.AcceptButton = Me.SignInButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(544, 329)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PromotionTextBox)
        Me.Controls.Add(Me.VisibleCheckBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.SignInButton)
        Me.Controls.Add(Me.WelcomeRichTextBox)
        Me.Controls.Add(Me.DepartmentPictureBox)
        Me.Controls.Add(Me.CheckInGroupBox)
        Me.Controls.Add(Me.DepartmentGroupBox)
        Me.Name = "MainForm"
        Me.Text = "R 'n R--For Reading and Refreshment by Micah Cain"
        Me.DepartmentGroupBox.ResumeLayout(False)
        Me.DepartmentGroupBox.PerformLayout()
        Me.CheckInGroupBox.ResumeLayout(False)
        Me.CheckInGroupBox.PerformLayout()
        CType(Me.DepartmentPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DepartmentGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CheckInGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepartmentPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MemberIDMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents WelcomeRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents SignInButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents VisibleCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PromotionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CoffeeBarRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PeriodicalsRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MusicRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents BooksRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
