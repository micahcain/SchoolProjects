Public Class MainForm

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromotionLabel.Click

    End Sub

    Private Sub BooksButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BooksButton.Click
        'This button will display the promotion and promotion code for books

        PromotionLabel.Text = "Buy two, get the second one for half price"
        PromotionCodelabel.Text = "B608"
    End Sub

    Private Sub MusicButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MusicButton.Click
        'This button will display the promotion and promotion code for music

        PromotionLabel.Text = "Get a free MP3 download with purchase of a CD"
        PromotionCodelabel.Text = "M608"
    End Sub

    Private Sub PeriodicalsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeriodicalsButton.Click
        'This button will display the promotion and promotion code for periodicals

        PromotionLabel.Text = "Elite members recieve 10% off every purchase"
        PromotionCodelabel.Text = "P608"
    End Sub

    Private Sub CoffeeBarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoffeeBarButton.Click
        'This button will display the promotion and promotion code for the coffee bar

        PromotionLabel.Text = "Celebrate the seasson with 20% off specialty drinks"
        PromotionCodelabel.Text = "C608"
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        'This button will print the form

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'This button will terminate the application

        Me.Close()
    End Sub
End Class
