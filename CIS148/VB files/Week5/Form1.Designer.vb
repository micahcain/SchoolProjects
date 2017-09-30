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
    Me.CovertButton = New System.Windows.Forms.Button
    Me.OutPutListBox = New System.Windows.Forms.ListBox
    Me.MilesTextBox = New System.Windows.Forms.TextBox
    Me.YardsTextBox = New System.Windows.Forms.TextBox
    Me.InchesTextBox = New System.Windows.Forms.TextBox
    Me.FeetTextBox = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.SuspendLayout()
    '
    'CovertButton
    '
    Me.CovertButton.Location = New System.Drawing.Point(269, 53)
    Me.CovertButton.Name = "CovertButton"
    Me.CovertButton.Size = New System.Drawing.Size(120, 23)
    Me.CovertButton.TabIndex = 0
    Me.CovertButton.Text = "Convert to Metric"
    Me.CovertButton.UseVisualStyleBackColor = True
    '
    'OutPutListBox
    '
    Me.OutPutListBox.FormattingEnabled = True
    Me.OutPutListBox.Location = New System.Drawing.Point(269, 104)
    Me.OutPutListBox.Name = "OutPutListBox"
    Me.OutPutListBox.Size = New System.Drawing.Size(120, 95)
    Me.OutPutListBox.TabIndex = 1
    '
    'MilesTextBox
    '
    Me.MilesTextBox.Location = New System.Drawing.Point(109, 53)
    Me.MilesTextBox.Name = "MilesTextBox"
    Me.MilesTextBox.Size = New System.Drawing.Size(100, 20)
    Me.MilesTextBox.TabIndex = 2
    '
    'YardsTextBox
    '
    Me.YardsTextBox.Location = New System.Drawing.Point(109, 91)
    Me.YardsTextBox.Name = "YardsTextBox"
    Me.YardsTextBox.Size = New System.Drawing.Size(100, 20)
    Me.YardsTextBox.TabIndex = 3
    '
    'InchesTextBox
    '
    Me.InchesTextBox.Location = New System.Drawing.Point(109, 179)
    Me.InchesTextBox.Name = "InchesTextBox"
    Me.InchesTextBox.Size = New System.Drawing.Size(100, 20)
    Me.InchesTextBox.TabIndex = 4
    '
    'FeetTextBox
    '
    Me.FeetTextBox.Location = New System.Drawing.Point(109, 135)
    Me.FeetTextBox.Name = "FeetTextBox"
    Me.FeetTextBox.Size = New System.Drawing.Size(100, 20)
    Me.FeetTextBox.TabIndex = 5
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 53)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(34, 13)
    Me.Label1.TabIndex = 6
    Me.Label1.Text = "Miles:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 91)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(37, 13)
    Me.Label2.TabIndex = 7
    Me.Label2.Text = "Yards:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 135)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(31, 13)
    Me.Label3.TabIndex = 8
    Me.Label3.Text = "Feet:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(12, 179)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(42, 13)
    Me.Label4.TabIndex = 9
    Me.Label4.Text = "Inches:"
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(451, 266)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.FeetTextBox)
    Me.Controls.Add(Me.InchesTextBox)
    Me.Controls.Add(Me.YardsTextBox)
    Me.Controls.Add(Me.MilesTextBox)
    Me.Controls.Add(Me.OutPutListBox)
    Me.Controls.Add(Me.CovertButton)
    Me.Name = "Form1"
    Me.Text = "Length Conversion"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents CovertButton As System.Windows.Forms.Button
  Friend WithEvents OutPutListBox As System.Windows.Forms.ListBox
  Friend WithEvents MilesTextBox As System.Windows.Forms.TextBox
  Friend WithEvents YardsTextBox As System.Windows.Forms.TextBox
  Friend WithEvents InchesTextBox As System.Windows.Forms.TextBox
  Friend WithEvents FeetTextBox As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
