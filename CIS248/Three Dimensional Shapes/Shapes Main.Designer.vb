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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tetraRadioButton = New System.Windows.Forms.RadioButton
        Me.cubeRadioButton = New System.Windows.Forms.RadioButton
        Me.sphereRadioButton = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.side2TextBox = New System.Windows.Forms.TextBox
        Me.side1TextBox = New System.Windows.Forms.TextBox
        Me.radiusTextBox = New System.Windows.Forms.TextBox
        Me.calculateButton = New System.Windows.Forms.Button
        Me.resetButton = New System.Windows.Forms.Button
        Me.exitButton = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tetraRadioButton)
        Me.GroupBox1.Controls.Add(Me.cubeRadioButton)
        Me.GroupBox1.Controls.Add(Me.sphereRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Shapes"
        '
        'tetraRadioButton
        '
        Me.tetraRadioButton.AutoSize = True
        Me.tetraRadioButton.Location = New System.Drawing.Point(6, 65)
        Me.tetraRadioButton.Name = "tetraRadioButton"
        Me.tetraRadioButton.Size = New System.Drawing.Size(83, 17)
        Me.tetraRadioButton.TabIndex = 2
        Me.tetraRadioButton.TabStop = True
        Me.tetraRadioButton.Text = "Tetrahedron"
        Me.tetraRadioButton.UseVisualStyleBackColor = True
        '
        'cubeRadioButton
        '
        Me.cubeRadioButton.AutoSize = True
        Me.cubeRadioButton.Location = New System.Drawing.Point(6, 42)
        Me.cubeRadioButton.Name = "cubeRadioButton"
        Me.cubeRadioButton.Size = New System.Drawing.Size(50, 17)
        Me.cubeRadioButton.TabIndex = 1
        Me.cubeRadioButton.TabStop = True
        Me.cubeRadioButton.Text = "Cube"
        Me.cubeRadioButton.UseVisualStyleBackColor = True
        '
        'sphereRadioButton
        '
        Me.sphereRadioButton.AutoSize = True
        Me.sphereRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.sphereRadioButton.Name = "sphereRadioButton"
        Me.sphereRadioButton.Size = New System.Drawing.Size(59, 17)
        Me.sphereRadioButton.TabIndex = 0
        Me.sphereRadioButton.TabStop = True
        Me.sphereRadioButton.Text = "Sphere"
        Me.sphereRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.side2TextBox)
        Me.GroupBox2.Controls.Add(Me.side1TextBox)
        Me.GroupBox2.Controls.Add(Me.radiusTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(186, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(211, 105)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dimensions"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Radius"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Side 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Side 2"
        '
        'side2TextBox
        '
        Me.side2TextBox.Location = New System.Drawing.Point(96, 68)
        Me.side2TextBox.Name = "side2TextBox"
        Me.side2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.side2TextBox.TabIndex = 5
        '
        'side1TextBox
        '
        Me.side1TextBox.Location = New System.Drawing.Point(96, 42)
        Me.side1TextBox.Name = "side1TextBox"
        Me.side1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.side1TextBox.TabIndex = 4
        '
        'radiusTextBox
        '
        Me.radiusTextBox.Location = New System.Drawing.Point(96, 16)
        Me.radiusTextBox.Name = "radiusTextBox"
        Me.radiusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.radiusTextBox.TabIndex = 3
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(26, 181)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 2
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'resetButton
        '
        Me.resetButton.Location = New System.Drawing.Point(155, 181)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(75, 23)
        Me.resetButton.TabIndex = 3
        Me.resetButton.Text = "&Reset"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(282, 181)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 232)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Time to get into S.H.A.P.E."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tetraRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents cubeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents sphereRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents side2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents side1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents radiusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents resetButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
