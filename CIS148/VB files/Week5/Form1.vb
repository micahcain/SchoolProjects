Public Class Form1

  Private Sub CovertButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CovertButton.Click
    Dim totalInches As Decimal = 63360 * Decimal.Parse(MilesTextBox.Text) + 36 * Decimal.Parse(YardsTextBox.Text) + 12 * _
    Decimal.Parse(FeetTextBox.Text) + Decimal.Parse(InchesTextBox.Text)
    Dim totalMeters As Decimal = totalInches / 39.37
    Dim kilometers As Decimal = Int(totalMeters / 1000)
    Dim meters As Decimal = Int(totalMeters - (kilometers * 1000))
    Dim centimeters As Decimal = (totalMeters - meters - (kilometers * 1000)) * 100

    OutPutListBox.Items.Add("The metric length is")
    OutPutListBox.Items.Add(kilometers & " kilometers")
    OutPutListBox.Items.Add(meters & " meters")
    OutPutListBox.Items.Add(centimeters.ToString("F1") & " centimeters")
  End Sub
End Class
