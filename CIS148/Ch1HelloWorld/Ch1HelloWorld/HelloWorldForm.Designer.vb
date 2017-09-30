<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelloWorldForm
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
        Me.ByLineLabel = New System.Windows.Forms.Label
        Me.EnglishButton = New System.Windows.Forms.Button
        Me.FrenchButton = New System.Windows.Forms.Button
        Me.ItalianButton = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.MessageLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ByLineLabel
        '
        Me.ByLineLabel.AutoSize = True
        Me.ByLineLabel.Location = New System.Drawing.Point(262, 293)
        Me.ByLineLabel.Name = "ByLineLabel"
        Me.ByLineLabel.Size = New System.Drawing.Size(136, 13)
        Me.ByLineLabel.TabIndex = 0
        Me.ByLineLabel.Text = "Programmed by Micah Cain"
        '
        'EnglishButton
        '
        Me.EnglishButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnglishButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EnglishButton.Location = New System.Drawing.Point(74, 167)
        Me.EnglishButton.Name = "EnglishButton"
        Me.EnglishButton.Size = New System.Drawing.Size(75, 23)
        Me.EnglishButton.TabIndex = 1
        Me.EnglishButton.Text = "English"
        Me.EnglishButton.UseVisualStyleBackColor = True
        '
        'FrenchButton
        '
        Me.FrenchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrenchButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrenchButton.Location = New System.Drawing.Point(74, 226)
        Me.FrenchButton.Name = "FrenchButton"
        Me.FrenchButton.Size = New System.Drawing.Size(75, 23)
        Me.FrenchButton.TabIndex = 2
        Me.FrenchButton.Text = "French"
        Me.FrenchButton.UseVisualStyleBackColor = True
        '
        'ItalianButton
        '
        Me.ItalianButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItalianButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ItalianButton.Location = New System.Drawing.Point(237, 167)
        Me.ItalianButton.Name = "ItalianButton"
        Me.ItalianButton.Size = New System.Drawing.Size(75, 23)
        Me.ItalianButton.TabIndex = 3
        Me.ItalianButton.Text = "Italian"
        Me.ItalianButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(237, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MessageLabel
        '
        Me.MessageLabel.AutoSize = True
        Me.MessageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MessageLabel.Location = New System.Drawing.Point(169, 50)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(0, 13)
        Me.MessageLabel.TabIndex = 5
        '
        'HelloWorldForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 325)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ItalianButton)
        Me.Controls.Add(Me.FrenchButton)
        Me.Controls.Add(Me.EnglishButton)
        Me.Controls.Add(Me.ByLineLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Name = "HelloWorldForm"
        Me.Text = "Hello World by Micah Cain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ByLineLabel As System.Windows.Forms.Label
    Friend WithEvents EnglishButton As System.Windows.Forms.Button
    Friend WithEvents FrenchButton As System.Windows.Forms.Button
    Friend WithEvents ItalianButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MessageLabel As System.Windows.Forms.Label

End Class
