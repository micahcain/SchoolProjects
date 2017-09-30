Public Class MainForm

    Private Sub VisibleCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisibleCheckBox.CheckedChanged
        'hides and unhides the department picture

        If VisibleCheckBox.Checked = True Then
            DepartmentPictureBox.Visible = True
        Else
            DepartmentPictureBox.Visible = False
        End If
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'ask the user if they want to exit the application

        Dim leaveChoice As Integer

        leaveChoice = MsgBox("Do you really want to leave?", MsgBoxStyle.OkCancel, "R 'n R--For Reading and Refreshment")

        If leaveChoice = 1 Then
            Me.Close()
        End If
    End Sub

    Private Sub SignInButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignInButton.Click
        If (NameTextBox.Text = "") Or (MemberIDMaskedTextBox.Text = "") Then
            MsgBox("Please enter a valid name and ID.", MsgBoxStyle.Critical, "R 'n R--For Reading and Refreshment")
        Else
            'display welcome message


            WelcomeRichTextBox.Text = "Welcome Member #" & MemberIDMaskedTextBox.Text _
            & Environment.NewLine & NameTextBox.Text

            'hide the sign in group
            'activate the department group
            'clear login fields
            'unhide the department picture, promotion text box, and visibility check box

            NameTextBox.Text = ""
            MemberIDMaskedTextBox.Text = ""
            CheckInGroupBox.Enabled = False
            PromotionTextBox.Visible = True
            DepartmentPictureBox.Visible = True
            VisibleCheckBox.Visible = True
            DepartmentGroupBox.Enabled = True
        End If
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        'ask the user if they would like a preview
        'ask the user if they want to print to the printer

        Dim printDecision As String
        printDecision = MsgBox("Would you like to preview the printed form?", MsgBoxStyle.YesNo, "R 'n R--For Reading and Refreshment")
        If printDecision = 6 Then
            PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
            PrintForm1.Print()
        End If
        printDecision = MsgBox("Okay to print?", MsgBoxStyle.YesNo, "R 'n R--For Reading and Refreshment")
        If printDecision = 6 Then
            PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter
            PrintForm1.Print()
        End If
    End Sub

    Private Sub BooksRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BooksRadioButton.CheckedChanged
        'display the promotion and image for the books department

        If BooksRadioButton.Checked = True Then
            DepartmentPictureBox.Image = My.Resources.pile_of_books
            PromotionTextBox.Text = "Buy two, get the second one for half price."
        End If
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        VisibleCheckBox.Checked = True
        VisibleCheckBox.Visible = False
        DepartmentPictureBox.Visible = False
        PromotionTextBox.Visible = False
    End Sub

    Private Sub MusicRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MusicRadioButton.CheckedChanged
        'display the promotion and image for the music department

        If MusicRadioButton.Checked = True Then
            DepartmentPictureBox.Image = My.Resources.video_ipod
            PromotionTextBox.Text = "Get a free MP3 download with purchase of a CD."
        End If
    End Sub

    Private Sub PeriodicalsRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeriodicalsRadioButton.CheckedChanged
        'display the promotion and image for the periodicals department

        If PeriodicalsRadioButton.Checked = True Then
            DepartmentPictureBox.Image = My.Resources.morocco_library_330x225_periodicals
            PromotionTextBox.Text = "Ellite members recieve 10% off every purchase."
        End If
    End Sub

    Private Sub CoffeeBarRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoffeeBarRadioButton.CheckedChanged
        'display the promotion and image for the coffee bar department

        If CoffeeBarRadioButton.Checked = True Then
            DepartmentPictureBox.Image = My.Resources._22847346
            PromotionTextBox.Text = "Celebrate the season with 20% off specialty drinks."
        End If
    End Sub
End Class
