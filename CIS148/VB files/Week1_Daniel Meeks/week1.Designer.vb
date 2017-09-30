<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColorsTextBox
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
        Me.btnBlue = New System.Windows.Forms.Button
        Me.btnWhite = New System.Windows.Forms.Button
        Me.btnYellow = New System.Windows.Forms.Button
        Me.lblBack = New System.Windows.Forms.Label
        Me.lblFore = New System.Windows.Forms.Label
        Me.txtBox = New System.Windows.Forms.TextBox
        Me.txtBox2 = New System.Windows.Forms.TextBox
        Me.btnDisable = New System.Windows.Forms.Button
        Me.btnEnable = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnRed
        '
        Me.btnRed.Location = New System.Drawing.Point(124, 45)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(75, 23)
        Me.btnRed.TabIndex = 0
        Me.btnRed.Text = "Red"
        Me.btnRed.UseVisualStyleBackColor = True
        '
        'btnBlue
        '
        Me.btnBlue.Location = New System.Drawing.Point(249, 44)
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.Size = New System.Drawing.Size(75, 23)
        Me.btnBlue.TabIndex = 1
        Me.btnBlue.Text = "Blue"
        Me.btnBlue.UseVisualStyleBackColor = True
        '
        'btnWhite
        '
        Me.btnWhite.Location = New System.Drawing.Point(124, 100)
        Me.btnWhite.Name = "btnWhite"
        Me.btnWhite.Size = New System.Drawing.Size(75, 23)
        Me.btnWhite.TabIndex = 3
        Me.btnWhite.Text = "White"
        Me.btnWhite.UseVisualStyleBackColor = True
        '
        'btnYellow
        '
        Me.btnYellow.Location = New System.Drawing.Point(249, 100)
        Me.btnYellow.Name = "btnYellow"
        Me.btnYellow.Size = New System.Drawing.Size(75, 23)
        Me.btnYellow.TabIndex = 4
        Me.btnYellow.Text = "Yellow"
        Me.btnYellow.UseVisualStyleBackColor = True
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.Location = New System.Drawing.Point(31, 54)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(65, 13)
        Me.lblBack.TabIndex = 5
        Me.lblBack.Text = "Background"
        '
        'lblFore
        '
        Me.lblFore.AutoSize = True
        Me.lblFore.Location = New System.Drawing.Point(34, 109)
        Me.lblFore.Name = "lblFore"
        Me.lblFore.Size = New System.Drawing.Size(61, 13)
        Me.lblFore.TabIndex = 6
        Me.lblFore.Text = "Foreground"
        '
        'txtBox
        '
        Me.txtBox.Location = New System.Drawing.Point(34, 74)
        Me.txtBox.Name = "txtBox"
        Me.txtBox.Size = New System.Drawing.Size(290, 20)
        Me.txtBox.TabIndex = 2
        Me.txtBox.Text = "Beautiful Day"
        Me.txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBox2
        '
        Me.txtBox2.Location = New System.Drawing.Point(114, 224)
        Me.txtBox2.Name = "txtBox2"
        Me.txtBox2.Size = New System.Drawing.Size(209, 20)
        Me.txtBox2.TabIndex = 7
        '
        'btnDisable
        '
        Me.btnDisable.Location = New System.Drawing.Point(114, 250)
        Me.btnDisable.Name = "btnDisable"
        Me.btnDisable.Size = New System.Drawing.Size(209, 20)
        Me.btnDisable.TabIndex = 8
        Me.btnDisable.Text = "Disable Text Box"
        Me.btnDisable.UseVisualStyleBackColor = True
        '
        'btnEnable
        '
        Me.btnEnable.Location = New System.Drawing.Point(114, 276)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.Size = New System.Drawing.Size(209, 20)
        Me.btnEnable.TabIndex = 9
        Me.btnEnable.Text = "Enable Text Box"
        Me.btnEnable.UseVisualStyleBackColor = True
        '
        'frmColorsTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 334)
        Me.Controls.Add(Me.btnEnable)
        Me.Controls.Add(Me.btnDisable)
        Me.Controls.Add(Me.txtBox2)
        Me.Controls.Add(Me.txtBox)
        Me.Controls.Add(Me.lblFore)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.btnYellow)
        Me.Controls.Add(Me.btnWhite)
        Me.Controls.Add(Me.btnBlue)
        Me.Controls.Add(Me.btnRed)
        Me.Name = "frmColorsTextBox"
        Me.Text = "Colorful Text and Text Box"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRed As System.Windows.Forms.Button
    Friend WithEvents btnBlue As System.Windows.Forms.Button
    Friend WithEvents btnWhite As System.Windows.Forms.Button
    Friend WithEvents btnYellow As System.Windows.Forms.Button
    Friend WithEvents lblBack As System.Windows.Forms.Label
    Friend WithEvents lblFore As System.Windows.Forms.Label
    Friend WithEvents txtBox As System.Windows.Forms.TextBox
    Friend WithEvents txtBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnDisable As System.Windows.Forms.Button
    Friend WithEvents btnEnable As System.Windows.Forms.Button

End Class
