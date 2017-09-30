Public Class MainForm
    Private Sub calculateButton_Click(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles calculateButton.Click

        ' declare variables
        Dim quotient As Decimal
        Dim dividend As Decimal
        Dim divisor As Decimal

        ' input

        On Error Resume Next
        dividend = Convert.ToDecimal(dividendTextBox.Text())
        divisor = Convert.ToDecimal(divisorTextBox.Text())

        ' processing
        quotient = dividend / divisor

        Select Case Err.Number
            Case 0
            Case 6
                MessageBox.Show("The data you entered reported an error." & System.Environment.NewLine _
                & "Reason: A number was either too large or too small and caused an overflow." _
                & System.Environment.NewLine _
                & "Error Code: " & Convert.ToString(Err.Number), "ERROR", _
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dividendTextBox.Text = ""
                divisorTextBox.Text = ""
                quotientLabel.Text = ""
                Exit Sub

        End Select

        ' output
        quotientLabel.Text = Convert.ToString(quotient)

    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        dividendTextBox.Text = ""
        divisorTextBox.Text = ""
        quotientLabel.Text = ""
    End Sub
End Class