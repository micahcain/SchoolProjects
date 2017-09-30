Public Class Week2
  Private fixedCosts As Decimal = 5000
  Private pricePerUnit As Decimal = 8
  Private costPerUnit As Decimal = 6
  Private breakEvenPoint As Decimal = fixedCosts / (pricePerUnit - costPerUnit)
  Private firstMileage As Integer = 23352
  Private secondMileage As Integer = 23695
  Private gasGallons As Integer = 14
  Private Sub breakEven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    BreakEvenListBox.Items.Add("$" & breakEvenPoint)
  End Sub

  Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    BreakEvenListBox.Items.Clear()
    BreakEvenListBox.Items.Add((secondMileage - firstMileage) / gasGallons & " Miles per Gallon")
  End Sub
End Class
