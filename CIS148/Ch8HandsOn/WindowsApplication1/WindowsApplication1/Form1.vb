Public Class Form1

    ' Program:           Ch8HandsOn
    ' Programmer:        Micah Cain
    ' Date:              11.21.2008

    Structure CoffeeSale
        Dim TypeString As String
        Dim QuantityString As String
        Dim PriceDecimal As Decimal
    End Structure

    Private TransactionCoffeeSale(20) As CoffeeSale
    Private NumberTransactionsInteger As Integer
    Private PriceDecimal(,) As Decimal = _
    {{2.6D, 2.9D, 3.25D}, {4.9D, 5.6D, 6.1D}, {8.75D, 9.75D, 11.25D}}
    Private SelectedButtonString As String

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        QuarterPoundRadioButton.Checked = True
        CoffeeTypeComboBox.SelectedIndex = -1
        PriceTextBox.Text = ""
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Dim ResponseDialogResult As DialogResult

        ResponseDialogResult = MessageBox.Show("Print the report?", _
            "Terminate the Application", MessageBoxButtons.YesNo, _
          MessageBoxIcon.Question)
        If ResponseDialogResult = DialogResult.Yes Then
            PrintButton_Click(sender, e)
        End If
        Me.Close()
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub FindPriceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindPriceButton.Click
        Dim RowInteger, ColumnInteger As Integer
        Dim SalePriceDecimal As Decimal
        If NumberTransactionsInteger < 20 Then
            ColumnInteger = CoffeeTypeComboBox.SelectedIndex
            If ColumnInteger <> -1 Then
                Select Case SelectedButtonString
                    Case "QuaterPoundRadioButton"
                        RowInteger = 0
                        TransactionCoffeeSale(NumberTransactionsInteger).QuantityString _
                        = "Quarter Pound"
                    Case "HalfPoundRadioButton"
                        RowInteger = 1
                        TransactionCoffeeSale(NumberTransactionsInteger).QuantityString _
                        = "Half Pound"
                    Case "FullPoundRadioButton"
                        RowInteger = 2
                        TransactionCoffeeSale(NumberTransactionsInteger).QuantityString _
                        = "Full Pound"
                    Case Else
                        RowInteger = 0
                        TransactionCoffeeSale(NumberTransactionsInteger).QuantityString _
                        = "Quarter Pound"
                End Select

                SalePriceDecimal = PriceDecimal(RowInteger, ColumnInteger)
                PriceTextBox.Text = SalePriceDecimal.ToString("C")
                TransactionCoffeeSale(NumberTransactionsInteger).TypeString _
                = CoffeeTypeComboBox.Text
                TransactionCoffeeSale(NumberTransactionsInteger).PriceDecimal _
                = SalePriceDecimal
                NumberTransactionsInteger += 1
            Else
                MessageBox.Show("Select the coffee type.", "Selection Incomplete", _
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Sorry, only 20 transactions allowed.")
        End If
    End Sub


    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim Column1HorizontalLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim Column2HorizontalLocationSingle As Single = 300
        Dim Column3horizontalLocationSingle As Single
        Dim PrintLineString As String
        Dim FontSizeF As New SizeF
        Dim FormattedPriceString As String

        PrintLineString = "R 'n R Coffee Sales"
        e.Graphics.DrawString(PrintLineString, HeadingFont, _
        Brushes.Black, Column2HorizontalLocationSingle, VerticalPrintLocationSingle)
        PrintLineString = "by Micah Cain"
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString(PrintLineString, PrintFont, _
        Brushes.Black, Column2HorizontalLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle * 2

        For Each IndividualCoffeeSale As CoffeeSale In TransactionCoffeeSale
            If IndividualCoffeeSale.QuantityString <> "" Then
                e.Graphics.DrawString(IndividualCoffeeSale.QuantityString, PrintFont, _
                Brushes.Black, Column1HorizontalLocationSingle, _
                VerticalPrintLocationSingle)

                e.Graphics.DrawString(IndividualCoffeeSale.TypeString, PrintFont, _
                 Brushes.Black, Column2HorizontalLocationSingle, _
                 VerticalPrintLocationSingle)

                FormattedPriceString = FormatNumber(IndividualCoffeeSale.PriceDecimal)
                FontSizeF = e.Graphics.MeasureString(FormattedPriceString, PrintFont)
                Column3horizontalLocationSingle = 550 - FontSizeF.Width
                e.Graphics.DrawString(FormattedPriceString, PrintFont, _
                Brushes.Black, Column3horizontalLocationSingle, _
                VerticalPrintLocationSingle)

                VerticalPrintLocationSingle += LineHeightSingle * 2
            End If
        Next
    End Sub

    Private Sub QuarterPoundRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles QuarterPoundRadioButton.CheckedChanged, _
    FullPoundRadioButton.CheckedChanged, _
    HalfPoundRadioButton.CheckedChanged

        SelectedButtonString = CType(sender, RadioButton).Name
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With CoffeeTypeComboBox
            .Items.Add("Regular")
            .Items.Add("Decaffinated")
            .Items.Add("Special Blend")
        End With
    End Sub
End Class
