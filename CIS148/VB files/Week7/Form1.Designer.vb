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
    Me.AverageButton = New System.Windows.Forms.Button
    Me.LeapButton = New System.Windows.Forms.Button
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.StartButton = New System.Windows.Forms.Button
    Me.TextBox1 = New System.Windows.Forms.TextBox
    Me.Result = New System.Windows.Forms.Button
    Me.CalculateButton = New System.Windows.Forms.Button
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'AverageButton
    '
    Me.AverageButton.Location = New System.Drawing.Point(197, 125)
    Me.AverageButton.Name = "AverageButton"
    Me.AverageButton.Size = New System.Drawing.Size(106, 54)
    Me.AverageButton.TabIndex = 0
    Me.AverageButton.Text = "Click Here to Enter Scores"
    Me.AverageButton.UseVisualStyleBackColor = True
    '
    'LeapButton
    '
    Me.LeapButton.Location = New System.Drawing.Point(477, 125)
    Me.LeapButton.Name = "LeapButton"
    Me.LeapButton.Size = New System.Drawing.Size(90, 54)
    Me.LeapButton.TabIndex = 1
    Me.LeapButton.Text = "Is it a Leap Year?"
    Me.LeapButton.UseVisualStyleBackColor = True
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.StartButton)
    Me.GroupBox1.Controls.Add(Me.TextBox1)
    Me.GroupBox1.Controls.Add(Me.Result)
    Me.GroupBox1.Controls.Add(Me.CalculateButton)
    Me.GroupBox1.Location = New System.Drawing.Point(197, 312)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(370, 211)
    Me.GroupBox1.TabIndex = 5
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Higest Grades"
    '
    'StartButton
    '
    Me.StartButton.Location = New System.Drawing.Point(121, 48)
    Me.StartButton.Name = "StartButton"
    Me.StartButton.Size = New System.Drawing.Size(140, 23)
    Me.StartButton.TabIndex = 8
    Me.StartButton.Text = "Begin Grade Calculations"
    Me.StartButton.UseVisualStyleBackColor = True
    '
    'TextBox1
    '
    Me.TextBox1.Location = New System.Drawing.Point(136, 77)
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.Size = New System.Drawing.Size(117, 20)
    Me.TextBox1.TabIndex = 7
    Me.TextBox1.Text = "Enter Grades Here"
    Me.TextBox1.Visible = False
    '
    'Result
    '
    Me.Result.Location = New System.Drawing.Point(107, 132)
    Me.Result.Name = "Result"
    Me.Result.Size = New System.Drawing.Size(164, 23)
    Me.Result.TabIndex = 6
    Me.Result.Text = "Display Two Highest Grades"
    Me.Result.UseVisualStyleBackColor = True
    Me.Result.Visible = False
    '
    'CalculateButton
    '
    Me.CalculateButton.Location = New System.Drawing.Point(150, 103)
    Me.CalculateButton.Name = "CalculateButton"
    Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
    Me.CalculateButton.TabIndex = 5
    Me.CalculateButton.Text = "Add Grade"
    Me.CalculateButton.UseVisualStyleBackColor = True
    Me.CalculateButton.Visible = False
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(749, 627)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.LeapButton)
    Me.Controls.Add(Me.AverageButton)
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents AverageButton As System.Windows.Forms.Button
  Friend WithEvents LeapButton As System.Windows.Forms.Button
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents StartButton As System.Windows.Forms.Button
  Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
  Friend WithEvents Result As System.Windows.Forms.Button
  Friend WithEvents CalculateButton As System.Windows.Forms.Button

End Class
