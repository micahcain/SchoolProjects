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
    Me.AddButton = New System.Windows.Forms.Button
    Me.SubtactButton = New System.Windows.Forms.Button
    Me.MultiplyButton = New System.Windows.Forms.Button
    Me.FirstNumber = New System.Windows.Forms.TextBox
    Me.SecondNumber = New System.Windows.Forms.TextBox
    Me.OutputLabel = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.SuspendLayout()
    '
    'AddButton
    '
    Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.AddButton.Location = New System.Drawing.Point(172, 26)
    Me.AddButton.Name = "AddButton"
    Me.AddButton.Size = New System.Drawing.Size(75, 35)
    Me.AddButton.TabIndex = 0
    Me.AddButton.Text = "+"
    Me.AddButton.UseVisualStyleBackColor = True
    '
    'SubtactButton
    '
    Me.SubtactButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SubtactButton.Location = New System.Drawing.Point(172, 101)
    Me.SubtactButton.Name = "SubtactButton"
    Me.SubtactButton.Size = New System.Drawing.Size(75, 35)
    Me.SubtactButton.TabIndex = 1
    Me.SubtactButton.Text = "-"
    Me.SubtactButton.UseVisualStyleBackColor = True
    '
    'MultiplyButton
    '
    Me.MultiplyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MultiplyButton.Location = New System.Drawing.Point(172, 177)
    Me.MultiplyButton.Name = "MultiplyButton"
    Me.MultiplyButton.Size = New System.Drawing.Size(75, 35)
    Me.MultiplyButton.TabIndex = 2
    Me.MultiplyButton.Text = "X"
    Me.MultiplyButton.UseVisualStyleBackColor = True
    '
    'FirstNumber
    '
    Me.FirstNumber.Location = New System.Drawing.Point(23, 103)
    Me.FirstNumber.Name = "FirstNumber"
    Me.FirstNumber.Size = New System.Drawing.Size(100, 20)
    Me.FirstNumber.TabIndex = 3
    '
    'SecondNumber
    '
    Me.SecondNumber.Location = New System.Drawing.Point(296, 103)
    Me.SecondNumber.Name = "SecondNumber"
    Me.SecondNumber.Size = New System.Drawing.Size(100, 20)
    Me.SecondNumber.TabIndex = 4
    '
    'OutputLabel
    '
    Me.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.OutputLabel.Location = New System.Drawing.Point(81, 232)
    Me.OutputLabel.Name = "OutputLabel"
    Me.OutputLabel.Size = New System.Drawing.Size(246, 15)
    Me.OutputLabel.TabIndex = 5
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(20, 84)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(66, 13)
    Me.Label2.TabIndex = 6
    Me.Label2.Text = "First Number"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(293, 84)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(84, 13)
    Me.Label3.TabIndex = 7
    Me.Label3.Text = "Second Number"
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(423, 266)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.OutputLabel)
    Me.Controls.Add(Me.SecondNumber)
    Me.Controls.Add(Me.FirstNumber)
    Me.Controls.Add(Me.MultiplyButton)
    Me.Controls.Add(Me.SubtactButton)
    Me.Controls.Add(Me.AddButton)
    Me.Name = "Form1"
    Me.Text = "Calculator"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents AddButton As System.Windows.Forms.Button
  Friend WithEvents SubtactButton As System.Windows.Forms.Button
  Friend WithEvents MultiplyButton As System.Windows.Forms.Button
  Friend WithEvents FirstNumber As System.Windows.Forms.TextBox
  Friend WithEvents SecondNumber As System.Windows.Forms.TextBox
  Friend WithEvents OutputLabel As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
