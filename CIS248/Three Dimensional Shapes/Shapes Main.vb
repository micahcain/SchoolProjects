Public Class Form1

    Private Sub resetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetButton.Click
        sphereRadioButton.Checked = False
        cubeRadioButton.Checked = False
        tetraRadioButton.Checked = False
        radiusTextBox.Text = String.Empty
        side1TextBox.Text = String.Empty
        side2TextBox.Text = String.Empty

    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Dim response As DialogResult

        response = MessageBox.Show("Do you really want to exit?", "Three Dimensional Shapes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click
        If sphereRadioButton.Checked = True Then
            Dim aSphere As New Shpere(Decimal.Parse(radiusTextBox.Text))
            MessageBox.Show(aSphere.ToString, "Geometric Shapes", MessageBoxButtons.OK)
        ElseIf cubeRadioButton.Checked = True Then
            Dim aCube As New Cube(Decimal.Parse(side1TextBox.Text))
            MessageBox.Show(aCube.ToString, "Three Dimensional Shapes", MessageBoxButtons.OK)
        ElseIf tetraRadioButton.Checked = True Then
            Dim aTetraHedron As New Tetrahedron(Decimal.Parse(side1TextBox.Text))
            MessageBox.Show(aTetraHedron.ToString, "Three Dimensional Shapes", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub sphereRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sphereRadioButton.CheckedChanged
        If sphereRadioButton.Checked = True Then
            side1TextBox.Enabled = False
            side2TextBox.Enabled = False
        Else
            side1TextBox.Enabled = True
            side2TextBox.Enabled = True
        End If
    End Sub

    Private Sub cubeRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cubeRadioButton.CheckedChanged
        If cubeRadioButton.Checked = True Then
            radiusTextBox.Enabled = False
        Else
            radiusTextBox.Enabled = True
        End If
    End Sub

    Private Sub tetraRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tetraRadioButton.CheckedChanged
        If tetraRadioButton.Checked = True Then
            radiusTextBox.Enabled = False
            side2TextBox.Enabled = False
        Else
            radiusTextBox.Enabled = True
            side2TextBox.Enabled = True
        End If
    End Sub
End Class
