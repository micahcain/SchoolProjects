

Public Class Form1
    Private newLoan As Loan

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Dim confirm As DialogResult
        confirm = MessageBox.Show("Are you sure you want to exit?", "Easy loan calculator", MessageBoxButtons.YesNo, _
        MessageBoxIcon.Exclamation)

        If confirm = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub resetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetButton.Click
        amountTextBox.Text = String.Empty
        interestTextBox.Text = String.Empty
        termTextBox.Text = String.Empty
        Label4.Text = String.Empty
    End Sub

    Private Sub calcButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calcButton.Click
        Dim amount As Double = Double.Parse(amountTextBox.Text)
        Dim interest As Double = Double.Parse(interestTextBox.Text)
        Dim term As Double = Double.Parse(termTextBox.Text)

        newLoan = New Loan(amount, interest, term)

        Label4.Text = "The monthly payment on this loan is " & _
        System.Environment.NewLine & (newLoan.calculateMonthlyPayment).ToString("C")
    End Sub
End Class
