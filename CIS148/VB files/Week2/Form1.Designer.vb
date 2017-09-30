<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week2
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
    Me.BreakEvenListBox = New System.Windows.Forms.ListBox
    Me.Button1 = New System.Windows.Forms.Button
    Me.Button2 = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'BreakEvenListBox
    '
    Me.BreakEvenListBox.FormattingEnabled = True
    Me.BreakEvenListBox.Location = New System.Drawing.Point(268, 57)
    Me.BreakEvenListBox.Name = "BreakEvenListBox"
    Me.BreakEvenListBox.Size = New System.Drawing.Size(120, 95)
    Me.BreakEvenListBox.TabIndex = 0
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(174, 215)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(75, 23)
    Me.Button1.TabIndex = 1
    Me.Button1.Text = "Break Even"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(428, 215)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(75, 23)
    Me.Button2.TabIndex = 2
    Me.Button2.Text = "Gas Mileage"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'Week2
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(720, 523)
    Me.Controls.Add(Me.Button2)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.BreakEvenListBox)
    Me.Name = "Week2"
    Me.Text = "Week2"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents BreakEvenListBox As System.Windows.Forms.ListBox
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
