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
    Me.InputButton = New System.Windows.Forms.Button
    Me.AverageButton = New System.Windows.Forms.Button
    Me.ListBox1 = New System.Windows.Forms.ListBox
    Me.CalculateButton = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'InputButton
    '
    Me.InputButton.Location = New System.Drawing.Point(51, 81)
    Me.InputButton.Name = "InputButton"
    Me.InputButton.Size = New System.Drawing.Size(97, 23)
    Me.InputButton.TabIndex = 0
    Me.InputButton.Text = "Word Please"
    Me.InputButton.UseVisualStyleBackColor = True
    '
    'AverageButton
    '
    Me.AverageButton.Location = New System.Drawing.Point(432, 81)
    Me.AverageButton.Name = "AverageButton"
    Me.AverageButton.Size = New System.Drawing.Size(116, 23)
    Me.AverageButton.TabIndex = 1
    Me.AverageButton.Text = "Average Numbers"
    Me.AverageButton.UseVisualStyleBackColor = True
    '
    'ListBox1
    '
    Me.ListBox1.FormattingEnabled = True
    Me.ListBox1.Location = New System.Drawing.Point(34, 300)
    Me.ListBox1.Name = "ListBox1"
    Me.ListBox1.Size = New System.Drawing.Size(580, 160)
    Me.ListBox1.TabIndex = 2
    '
    'CalculateButton
    '
    Me.CalculateButton.Location = New System.Drawing.Point(253, 500)
    Me.CalculateButton.Name = "CalculateButton"
    Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
    Me.CalculateButton.TabIndex = 3
    Me.CalculateButton.Text = "Balance"
    Me.CalculateButton.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(652, 584)
    Me.Controls.Add(Me.CalculateButton)
    Me.Controls.Add(Me.ListBox1)
    Me.Controls.Add(Me.AverageButton)
    Me.Controls.Add(Me.InputButton)
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents InputButton As System.Windows.Forms.Button
  Friend WithEvents AverageButton As System.Windows.Forms.Button
  Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
  Friend WithEvents CalculateButton As System.Windows.Forms.Button

End Class
