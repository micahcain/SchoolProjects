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
    Me.txtFirst = New System.Windows.Forms.TextBox
    Me.txtSecond = New System.Windows.Forms.TextBox
    Me.btnRed = New System.Windows.Forms.Button
    Me.Label1 = New System.Windows.Forms.Label
    Me.btnButton = New System.Windows.Forms.Button
    Me.txtBox3 = New System.Windows.Forms.TextBox
    Me.SuspendLayout()
    '
    'txtFirst
    '
    Me.txtFirst.Location = New System.Drawing.Point(174, 168)
    Me.txtFirst.Name = "txtFirst"
    Me.txtFirst.Size = New System.Drawing.Size(229, 20)
    Me.txtFirst.TabIndex = 0
    '
    'txtSecond
    '
    Me.txtSecond.Location = New System.Drawing.Point(178, 219)
    Me.txtSecond.Name = "txtSecond"
    Me.txtSecond.Size = New System.Drawing.Size(229, 20)
    Me.txtSecond.TabIndex = 1
    '
    'btnRed
    '
    Me.btnRed.Location = New System.Drawing.Point(157, 274)
    Me.btnRed.Name = "btnRed"
    Me.btnRed.Size = New System.Drawing.Size(200, 23)
    Me.btnRed.TabIndex = 2
    Me.btnRed.Text = "Change Color to Red"
    Me.btnRed.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(157, 86)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(39, 13)
    Me.Label1.TabIndex = 3
    Me.Label1.Text = "Label1"
    '
    'btnButton
    '
    Me.btnButton.Location = New System.Drawing.Point(120, 38)
    Me.btnButton.Name = "btnButton"
    Me.btnButton.Size = New System.Drawing.Size(75, 23)
    Me.btnButton.TabIndex = 4
    Me.btnButton.Text = "Button1"
    Me.btnButton.UseVisualStyleBackColor = True
    '
    'txtBox3
    '
    Me.txtBox3.Location = New System.Drawing.Point(280, 53)
    Me.txtBox3.Name = "txtBox3"
    Me.txtBox3.Size = New System.Drawing.Size(100, 20)
    Me.txtBox3.TabIndex = 5
    '
    'frmDemo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(515, 458)
    Me.Controls.Add(Me.txtBox3)
    Me.Controls.Add(Me.btnButton)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btnRed)
    Me.Controls.Add(Me.txtSecond)
    Me.Controls.Add(Me.txtFirst)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Name = "frmDemo"
    Me.Text = "Demonstration"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtFirst As System.Windows.Forms.TextBox
  Friend WithEvents txtSecond As System.Windows.Forms.TextBox
  Friend WithEvents btnRed As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents btnButton As System.Windows.Forms.Button
  Friend WithEvents txtBox3 As System.Windows.Forms.TextBox

End Class
