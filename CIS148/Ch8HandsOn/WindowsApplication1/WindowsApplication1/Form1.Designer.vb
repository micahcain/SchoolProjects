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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ExitButton = New System.Windows.Forms.Button
        Me.PrintButton = New System.Windows.Forms.Button
        Me.ClearButton = New System.Windows.Forms.Button
        Me.FindPriceButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.PriceTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CoffeeTypeComboBox = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.FullPoundRadioButton = New System.Windows.Forms.RadioButton
        Me.HalfPoundRadioButton = New System.Windows.Forms.RadioButton
        Me.QuarterPoundRadioButton = New System.Windows.Forms.RadioButton
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ExitButton)
        Me.GroupBox1.Controls.Add(Me.PrintButton)
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Controls.Add(Me.FindPriceButton)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PriceTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CoffeeTypeComboBox)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 201)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Coffee Prices"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(308, 163)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(207, 163)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 7
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(111, 163)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 6
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'FindPriceButton
        '
        Me.FindPriceButton.Location = New System.Drawing.Point(17, 163)
        Me.FindPriceButton.Name = "FindPriceButton"
        Me.FindPriceButton.Size = New System.Drawing.Size(75, 23)
        Me.FindPriceButton.TabIndex = 5
        Me.FindPriceButton.Text = "&Find Price"
        Me.FindPriceButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Price"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(308, 81)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Type"
        '
        'CoffeeTypeComboBox
        '
        Me.CoffeeTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CoffeeTypeComboBox.FormattingEnabled = True
        Me.CoffeeTypeComboBox.Location = New System.Drawing.Point(287, 34)
        Me.CoffeeTypeComboBox.Name = "CoffeeTypeComboBox"
        Me.CoffeeTypeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CoffeeTypeComboBox.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.FullPoundRadioButton)
        Me.GroupBox2.Controls.Add(Me.HalfPoundRadioButton)
        Me.GroupBox2.Controls.Add(Me.QuarterPoundRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(142, 88)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Quantity"
        '
        'FullPoundRadioButton
        '
        Me.FullPoundRadioButton.AutoSize = True
        Me.FullPoundRadioButton.Location = New System.Drawing.Point(6, 65)
        Me.FullPoundRadioButton.Name = "FullPoundRadioButton"
        Me.FullPoundRadioButton.Size = New System.Drawing.Size(75, 17)
        Me.FullPoundRadioButton.TabIndex = 3
        Me.FullPoundRadioButton.TabStop = True
        Me.FullPoundRadioButton.Text = "Fu&ll Pound"
        Me.FullPoundRadioButton.UseVisualStyleBackColor = True
        '
        'HalfPoundRadioButton
        '
        Me.HalfPoundRadioButton.AutoSize = True
        Me.HalfPoundRadioButton.Location = New System.Drawing.Point(6, 42)
        Me.HalfPoundRadioButton.Name = "HalfPoundRadioButton"
        Me.HalfPoundRadioButton.Size = New System.Drawing.Size(78, 17)
        Me.HalfPoundRadioButton.TabIndex = 2
        Me.HalfPoundRadioButton.TabStop = True
        Me.HalfPoundRadioButton.Text = "&Half Pound"
        Me.HalfPoundRadioButton.UseVisualStyleBackColor = True
        '
        'QuarterPoundRadioButton
        '
        Me.QuarterPoundRadioButton.AutoSize = True
        Me.QuarterPoundRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.QuarterPoundRadioButton.Name = "QuarterPoundRadioButton"
        Me.QuarterPoundRadioButton.Size = New System.Drawing.Size(94, 17)
        Me.QuarterPoundRadioButton.TabIndex = 1
        Me.QuarterPoundRadioButton.TabStop = True
        Me.QuarterPoundRadioButton.Text = "&Quarter Pound"
        Me.QuarterPoundRadioButton.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 233)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "R 'n R -- For Reading and Refreshment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents HalfPoundRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents QuarterPoundRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents FindPriceButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CoffeeTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FullPoundRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog

End Class
