<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDemo
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
        Me.btnRed = New System.Windows.Forms.Button
        Me.txtFirst = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnRed
        '
        Me.btnRed.ForeColor = System.Drawing.Color.Black
        Me.btnRed.Location = New System.Drawing.Point(403, 131)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(97, 52)
        Me.btnRed.TabIndex = 2
        Me.btnRed.Text = "Change Color to Red"
        Me.btnRed.UseVisualStyleBackColor = True
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(162, 180)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(100, 20)
        Me.txtFirst.TabIndex = 1
        '
        'frmDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 482)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.btnRed)
        Me.Name = "frmDemo"
        Me.Text = "Demonstration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRed As System.Windows.Forms.Button
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox

End Class
