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
    Me.Button1 = New System.Windows.Forms.Button
    Me.Button2 = New System.Windows.Forms.Button
    Me.Label1 = New System.Windows.Forms.Label
    Me.Button3 = New System.Windows.Forms.Button
    Me.Button4 = New System.Windows.Forms.Button
    Me.Button5 = New System.Windows.Forms.Button
    Me.Label2 = New System.Windows.Forms.Label
    Me.sticksLabel = New System.Windows.Forms.Label
    Me.SuspendLayout()
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(12, 12)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(147, 35)
    Me.Button1.TabIndex = 0
    Me.Button1.Text = "Give the rules of the game"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(305, 12)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(147, 35)
    Me.Button2.TabIndex = 1
    Me.Button2.Text = "Begin a new Game"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(9, 61)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(138, 30)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "How many matchsticks would you like to pick up?"
    '
    'Button3
    '
    Me.Button3.Location = New System.Drawing.Point(192, 61)
    Me.Button3.Name = "Button3"
    Me.Button3.Size = New System.Drawing.Size(56, 30)
    Me.Button3.TabIndex = 3
    Me.Button3.Text = "One"
    Me.Button3.UseVisualStyleBackColor = True
    '
    'Button4
    '
    Me.Button4.Location = New System.Drawing.Point(266, 61)
    Me.Button4.Name = "Button4"
    Me.Button4.Size = New System.Drawing.Size(56, 30)
    Me.Button4.TabIndex = 4
    Me.Button4.Text = "Two"
    Me.Button4.UseVisualStyleBackColor = True
    '
    'Button5
    '
    Me.Button5.Location = New System.Drawing.Point(348, 61)
    Me.Button5.Name = "Button5"
    Me.Button5.Size = New System.Drawing.Size(56, 30)
    Me.Button5.TabIndex = 5
    Me.Button5.Text = "Three"
    Me.Button5.UseVisualStyleBackColor = True
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(9, 109)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(86, 36)
    Me.Label2.TabIndex = 6
    Me.Label2.Text = "Current Status of the Pile"
    '
    'sticksLabel
    '
    Me.sticksLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.sticksLabel.Location = New System.Drawing.Point(129, 118)
    Me.sticksLabel.Name = "sticksLabel"
    Me.sticksLabel.Size = New System.Drawing.Size(373, 23)
    Me.sticksLabel.TabIndex = 7
    Me.sticksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(528, 154)
    Me.Controls.Add(Me.sticksLabel)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Button5)
    Me.Controls.Add(Me.Button4)
    Me.Controls.Add(Me.Button3)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Button2)
    Me.Controls.Add(Me.Button1)
    Me.Name = "Form1"
    Me.Text = "Five Six Pick up Sticks"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents Button2 As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Button3 As System.Windows.Forms.Button
  Friend WithEvents Button4 As System.Windows.Forms.Button
  Friend WithEvents Button5 As System.Windows.Forms.Button
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents sticksLabel As System.Windows.Forms.Label

End Class
