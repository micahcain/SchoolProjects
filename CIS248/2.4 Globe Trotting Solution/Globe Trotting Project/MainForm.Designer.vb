<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.instructionLabel = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.outputLabel1 = New System.Windows.Forms.Label
        Me.outputLabel2 = New System.Windows.Forms.Label
        Me.outputLabel3 = New System.Windows.Forms.Label
        Me.outputLabel4 = New System.Windows.Forms.Label
        Me.outputLabel5 = New System.Windows.Forms.Label
        Me.clearButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'instructionLabel
        '
        Me.instructionLabel.AutoSize = True
        Me.instructionLabel.Location = New System.Drawing.Point(31, 24)
        Me.instructionLabel.Name = "instructionLabel"
        Me.instructionLabel.Size = New System.Drawing.Size(238, 13)
        Me.instructionLabel.TabIndex = 0
        Me.instructionLabel.Text = "Check any or all destinations from New York City:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(57, 55)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "London"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(57, 78)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(49, 17)
        Me.CheckBox2.TabIndex = 3
        Me.CheckBox2.Text = "Paris"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(57, 101)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(54, 17)
        Me.CheckBox3.TabIndex = 4
        Me.CheckBox3.Text = "Rome"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(57, 124)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(66, 17)
        Me.CheckBox4.TabIndex = 5
        Me.CheckBox4.Text = "Moscow"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(57, 147)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox5.TabIndex = 6
        Me.CheckBox5.Text = "Bejing"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'outputLabel1
        '
        Me.outputLabel1.AutoSize = True
        Me.outputLabel1.Location = New System.Drawing.Point(146, 55)
        Me.outputLabel1.Name = "outputLabel1"
        Me.outputLabel1.Size = New System.Drawing.Size(0, 13)
        Me.outputLabel1.TabIndex = 7
        '
        'outputLabel2
        '
        Me.outputLabel2.AutoSize = True
        Me.outputLabel2.Location = New System.Drawing.Point(146, 82)
        Me.outputLabel2.Name = "outputLabel2"
        Me.outputLabel2.Size = New System.Drawing.Size(0, 13)
        Me.outputLabel2.TabIndex = 8
        '
        'outputLabel3
        '
        Me.outputLabel3.AutoSize = True
        Me.outputLabel3.Location = New System.Drawing.Point(146, 105)
        Me.outputLabel3.Name = "outputLabel3"
        Me.outputLabel3.Size = New System.Drawing.Size(0, 13)
        Me.outputLabel3.TabIndex = 9
        '
        'outputLabel4
        '
        Me.outputLabel4.AutoSize = True
        Me.outputLabel4.Location = New System.Drawing.Point(146, 128)
        Me.outputLabel4.Name = "outputLabel4"
        Me.outputLabel4.Size = New System.Drawing.Size(0, 13)
        Me.outputLabel4.TabIndex = 10
        '
        'outputLabel5
        '
        Me.outputLabel5.AutoSize = True
        Me.outputLabel5.Location = New System.Drawing.Point(146, 151)
        Me.outputLabel5.Name = "outputLabel5"
        Me.outputLabel5.Size = New System.Drawing.Size(0, 13)
        Me.outputLabel5.TabIndex = 11
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(166, 199)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 12
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 244)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.outputLabel5)
        Me.Controls.Add(Me.outputLabel4)
        Me.Controls.Add(Me.outputLabel3)
        Me.Controls.Add(Me.outputLabel2)
        Me.Controls.Add(Me.outputLabel1)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.instructionLabel)
        Me.Name = "MainForm"
        Me.Text = "Globe Trotting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents instructionLabel As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents outputLabel1 As System.Windows.Forms.Label
    Friend WithEvents outputLabel2 As System.Windows.Forms.Label
    Friend WithEvents outputLabel3 As System.Windows.Forms.Label
    Friend WithEvents outputLabel4 As System.Windows.Forms.Label
    Friend WithEvents outputLabel5 As System.Windows.Forms.Label
    Friend WithEvents clearButton As System.Windows.Forms.Button

End Class
