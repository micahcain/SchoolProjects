Public Class SummaryForm

    Private Sub SummaryForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Get Data

        TotalSalesTextBox.Text = BillingForm.GrandTotalDecimal.ToString("C")
        AverageSalesTextBox.Text = BillingForm.AverageDecimal.ToString("C")
        NumberCustomersTextBox.Text = BillingForm.CustomerCountInteger.ToString()
    End Sub

    Private Sub SummaryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Hide()
    End Sub
End Class