<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.calculateButton = New System.Windows.Forms.Button
        Me.quotientLabel = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.Label
        Me.divisorTextBox = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.Label
        Me.dividendTextBox = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.Label
        Me.clearButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'calculateButton
        '
        Me.calculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(36, 198)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(96, 32)
        Me.calculateButton.TabIndex = 13
        Me.calculateButton.Text = "Calculate"
        '
        'quotientLabel
        '
        Me.quotientLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.quotientLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quotientLabel.Location = New System.Drawing.Point(160, 144)
        Me.quotientLabel.Name = "quotientLabel"
        Me.quotientLabel.Size = New System.Drawing.Size(100, 23)
        Me.quotientLabel.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(32, 144)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 23)
        Me.TextBox3.TabIndex = 11
        Me.TextBox3.Text = "Quotient"
        '
        'divisorTextBox
        '
        Me.divisorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divisorTextBox.Location = New System.Drawing.Point(160, 96)
        Me.divisorTextBox.Name = "divisorTextBox"
        Me.divisorTextBox.Size = New System.Drawing.Size(100, 26)
        Me.divisorTextBox.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(32, 96)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Text = "Divisor"
        '
        'dividendTextBox
        '
        Me.dividendTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dividendTextBox.Location = New System.Drawing.Point(160, 48)
        Me.dividendTextBox.Name = "dividendTextBox"
        Me.dividendTextBox.Size = New System.Drawing.Size(100, 26)
        Me.dividendTextBox.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(32, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "Dividend"
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(160, 198)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(96, 32)
        Me.clearButton.TabIndex = 14
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.quotientLabel)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.divisorTextBox)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.dividendTextBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "MainForm"
        Me.Text = "Division"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents quotientLabel As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.Label
    Friend WithEvents divisorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.Label
    Friend WithEvents dividendTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.Label
    Friend WithEvents clearButton As System.Windows.Forms.Button

End Class
