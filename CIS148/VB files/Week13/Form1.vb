Public Class Form1

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Dim file As IO.StreamReader = IO.File.OpenText("SALES.txt")
    Dim SalesPerson As String
    Dim finalPriceString As String
    Dim dealerCostString As String
    Dim finalPrice As Decimal
    Dim dealerCost As Decimal
    Dim grossSales As Decimal
    Dim commission As Decimal
    Const COMMISSION_RATE As Decimal = 0.15

    Do
      SalesPerson = file.ReadLine
      If SalesPerson = "EOF" Then
        Exit Do
      Else
        Do

          finalPriceString = (file.ReadLine)
          dealerCostString = (file.ReadLine)
          If finalPriceString = "0" And dealerCostString = "0" Then
            Exit Do
          ElseIf finalPriceString = "EOF" Then
            Exit Sub
          Else
            finalPrice = Decimal.Parse(finalPriceString)
            dealerCost = Decimal.Parse(dealerCostString)
            grossSales = finalPrice - dealerCost
            commission += grossSales
          End If
        Loop While finalPrice <> 0
        ListBox1.Items.Add(SalesPerson & "            " & (commission * COMMISSION_RATE).ToString("C"))
      End If
    Loop Until (SalesPerson = "")
  End Sub

  Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    Dim file As IO.StreamReader = IO.File.OpenText("CRAYONS.txt")
    Dim colorIn As String
    Dim colorUser As String = TextBox1.Text

    Do
      colorIn = file.ReadLine
      If colorIn = colorUser.ToLower.Trim Then
        Exit Do
      End If
    Loop Until colorIn = "EOF"

    If IsCrayola(colorIn, colorUser) Then
      MessageBox.Show("The color " & colorUser & " is a valid crayola color.", "Color Finder", MessageBoxButtons.OK, MessageBoxIcon.Information)
    Else
      MessageBox.Show("The color " & colorUser & " is not a valid crayola color.", "Color Finder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub

  Private Function IsCrayola(ByVal input As String, ByVal user As String) As Boolean
    If input <> "EOF" Then
      Return True
    Else
      Return False
    End If
  End Function
End Class
