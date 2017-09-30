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
    Me.Label1 = New System.Windows.Forms.Label
    Me.Button2 = New System.Windows.Forms.Button
    Me.ListBox1 = New System.Windows.Forms.ListBox
    Me.SuspendLayout()
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(229, 57)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(83, 23)
    Me.Button1.TabIndex = 0
    Me.Button1.Text = "Enter Data"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.Label1.Location = New System.Drawing.Point(127, 137)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(285, 23)
    Me.Label1.TabIndex = 1
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(171, 286)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(177, 23)
    Me.Button2.TabIndex = 2
    Me.Button2.Text = "Display Account Summary"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'ListBox1
    '
    Me.ListBox1.FormattingEnabled = True
    Me.ListBox1.Location = New System.Drawing.Point(44, 382)
    Me.ListBox1.Name = "ListBox1"
    Me.ListBox1.Size = New System.Drawing.Size(452, 121)
    Me.ListBox1.TabIndex = 3
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(580, 613)
    Me.Controls.Add(Me.ListBox1)
    Me.Controls.Add(Me.Button2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Button1)
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Button2 As System.Windows.Forms.Button
  Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
