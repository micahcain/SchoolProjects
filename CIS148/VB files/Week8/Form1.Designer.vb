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
    Me.Translate = New System.Windows.Forms.Button
    Me.TextBox1 = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.CalculateBtn = New System.Windows.Forms.Button
    Me.TextBox2 = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.SuspendLayout()
    '
    'Translate
    '
    Me.Translate.Location = New System.Drawing.Point(62, 150)
    Me.Translate.Name = "Translate"
    Me.Translate.Size = New System.Drawing.Size(100, 23)
    Me.Translate.TabIndex = 0
    Me.Translate.Text = "Translate"
    Me.Translate.UseVisualStyleBackColor = True
    '
    'TextBox1
    '
    Me.TextBox1.Location = New System.Drawing.Point(62, 59)
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.Size = New System.Drawing.Size(100, 20)
    Me.TextBox1.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(93, 106)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(0, 13)
    Me.Label1.TabIndex = 2
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(47, 24)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(141, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Enter a medical abbreviation"
    '
    'CalculateBtn
    '
    Me.CalculateBtn.Location = New System.Drawing.Point(405, 150)
    Me.CalculateBtn.Name = "CalculateBtn"
    Me.CalculateBtn.Size = New System.Drawing.Size(75, 23)
    Me.CalculateBtn.TabIndex = 4
    Me.CalculateBtn.Text = "Calculate Tax"
    Me.CalculateBtn.UseVisualStyleBackColor = True
    '
    'TextBox2
    '
    Me.TextBox2.Location = New System.Drawing.Point(405, 59)
    Me.TextBox2.Name = "TextBox2"
    Me.TextBox2.Size = New System.Drawing.Size(100, 20)
    Me.TextBox2.TabIndex = 5
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(402, 24)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(111, 13)
    Me.Label3.TabIndex = 6
    Me.Label3.Text = "Enter Taxable Income"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(423, 106)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(0, 13)
    Me.Label4.TabIndex = 7
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(659, 578)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.TextBox2)
    Me.Controls.Add(Me.CalculateBtn)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.TextBox1)
    Me.Controls.Add(Me.Translate)
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Translate As System.Windows.Forms.Button
  Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents CalculateBtn As System.Windows.Forms.Button
  Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
