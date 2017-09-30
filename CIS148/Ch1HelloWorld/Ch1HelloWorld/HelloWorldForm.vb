Public Class HelloWorldForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnglishButton.Click
        'This button will display the "Hello World" message in English

        MessageLabel.Text = "Hello World"
    End Sub

    Private Sub ItalianButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItalianButton.Click
        'This button will display the "Hello World" message in Italian

        MessageLabel.Text = "Ciao Mondo"
    End Sub

    Private Sub FrenchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrenchButton.Click
        'This button will display the "Hello World" mesage in French

        MessageLabel.Text = "Bonjour tout le monde"
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'This button will close the application

        Me.Close()
    End Sub
End Class
