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
        Me.originListBox = New System.Windows.Forms.ListBox
        Me.destinationListBox = New System.Windows.Forms.ListBox
        Me.displayButton = New System.Windows.Forms.Button
        Me.roundTripCheckBox = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'originListBox
        '
        Me.originListBox.FormattingEnabled = True
        Me.originListBox.Items.AddRange(New Object() {"Atlanta", "Huston", "Los Angeles"})
        Me.originListBox.Location = New System.Drawing.Point(12, 49)
        Me.originListBox.Name = "originListBox"
        Me.originListBox.Size = New System.Drawing.Size(120, 95)
        Me.originListBox.TabIndex = 0
        '
        'destinationListBox
        '
        Me.destinationListBox.FormattingEnabled = True
        Me.destinationListBox.Items.AddRange(New Object() {"Tokyo", "Moscow", "Madrid"})
        Me.destinationListBox.Location = New System.Drawing.Point(243, 49)
        Me.destinationListBox.Name = "destinationListBox"
        Me.destinationListBox.Size = New System.Drawing.Size(120, 95)
        Me.destinationListBox.TabIndex = 1
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(72, 196)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(234, 23)
        Me.displayButton.TabIndex = 2
        Me.displayButton.Text = "Display"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'roundTripCheckBox
        '
        Me.roundTripCheckBox.AutoSize = True
        Me.roundTripCheckBox.Location = New System.Drawing.Point(147, 49)
        Me.roundTripCheckBox.Name = "roundTripCheckBox"
        Me.roundTripCheckBox.Size = New System.Drawing.Size(85, 17)
        Me.roundTripCheckBox.TabIndex = 3
        Me.roundTripCheckBox.Text = "Round Trip?"
        Me.roundTripCheckBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 279)
        Me.Controls.Add(Me.roundTripCheckBox)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.destinationListBox)
        Me.Controls.Add(Me.originListBox)
        Me.Name = "Form1"
        Me.Text = "Long way from Harlem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents originListBox As System.Windows.Forms.ListBox
    Friend WithEvents destinationListBox As System.Windows.Forms.ListBox
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents roundTripCheckBox As System.Windows.Forms.CheckBox

End Class
