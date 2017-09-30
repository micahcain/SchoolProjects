Public Class Form1

  
  Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
    OutputLabel.Text = (FirstNumber.Text & " + " & SecondNumber.Text & " = " & (Decimal.Parse(FirstNumber.Text) _
   + Decimal.Parse(SecondNumber.Text)))

  End Sub

  Private Sub SubtactButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubtactButton.Click
    OutputLabel.Text = (FirstNumber.Text & " - " & SecondNumber.Text & " = " & (Decimal.Parse(FirstNumber.Text) _
   - Decimal.Parse(SecondNumber.Text)))

  End Sub

  Private Sub MultiplyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultiplyButton.Click
    OutputLabel.Text = (FirstNumber.Text & " x " & SecondNumber.Text & " = " & (Decimal.Parse(FirstNumber.Text) _
   * Decimal.Parse(SecondNumber.Text)))

  End Sub

  Private Sub FirstNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirstNumber.TextChanged
    OutputLabel.Text = ""
  End Sub

  Private Sub SecondNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecondNumber.TextChanged
    OutputLabel.Text = ""
  End Sub
End Class
