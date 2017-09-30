Public Class Form1

    Private Sub USARadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USARadioButton.CheckedChanged
        If USARadioButton.Checked = True Then
            FlagPictureBox.Image = My.Resources.american_flag
            CountryLabel.Text = "United States"
        End If
    End Sub

    Private Sub JapanRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JapanRadioButton.CheckedChanged
        If JapanRadioButton.Checked = True Then
            FlagPictureBox.Image = My.Resources.japanese_flag1
            CountryLabel.Text = "Japan"
        End If
    End Sub

    Private Sub IrelandRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IrelandRadioButton.CheckedChanged
        If IrelandRadioButton.Checked = True Then
            FlagPictureBox.Image = My.Resources.irish_flag
            CountryLabel.Text = "Ireland"
        End If
    End Sub

    Private Sub StrongBadianRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StrongBadianRadioButton.CheckedChanged
        If StrongBadianRadioButton.Checked = True Then
            FlagPictureBox.Image = My.Resources.strongbadian_flag
            CountryLabel.Text = "Strong Badia"
        End If
    End Sub

    Private Sub TitleCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitleCheckBox.CheckedChanged
        If TitleCheckBox.Checked = False Then
            Me.Text = ""
        Else
            Me.Text = "Flag Viewer by Micah Cain"
        End If
    End Sub

    Private Sub CountryCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountryCheckBox.CheckedChanged
        If CountryCheckBox.Checked = False Then
            CountryLabel.Visible = False
        Else
            CountryLabel.Visible = True
        End If
    End Sub

    Private Sub ProgrammerCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgrammerCheckBox.CheckedChanged
        If ProgrammerCheckBox.Checked = False Then
            ByLineLabel.Visible = False
        Else
            ByLineLabel.Visible = True
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Dim exitCheck As Integer

        'Ask the user if they want to exit

        exitCheck = MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel, "Flag Viewer")

        If exitCheck = 1 Then
            Me.Close()
        End If
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        Dim previewCheck As Integer
        Dim printCheck As Integer

        'ask the user if they would like to preview

        previewCheck = MsgBox("Would you like to preview?", MsgBoxStyle.YesNo, "Flag Viewer")

        If previewCheck = 6 Then
            PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
            PrintForm1.Print()
        End If

        'ask the user if they would like to send to printer

        printCheck = MsgBox("Okay to print?", MsgBoxStyle.YesNo, "Flag Viewer")

        If printCheck = 6 Then
            PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter
            PrintForm1.Print()
        End If
    End Sub
End Class
