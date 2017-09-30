' Project:          Ch3HandsOn
' Date:             10.20.2008
' Programmer:       Micah Cain
' Description:      This project inputs sales information for books.
'                   It calculates the extended price and discount for a sale
'                   and maintains summary information for all sales.
'                   It uses variables, constants, calculations, error handling,
'                   and a message box to the user.
Public Class Form1
    'Declare local variables and constants
    Private QuantitySumInteger, SaleCountInteger As Integer
    Private DiscountSumDecimal, DiscountedPriceSumDecimal As Decimal
    Const DISCOUNT_RATE_Decimal As Decimal = 0.15D

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        ' Print the form in the print preview window

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        ' Calculates the price and discount
        Dim QuantityInteger As Integer
        Dim PriceDecimal, ExtendedPriceDecimal, DiscountDecimal, _
        DiscountedPriceDecimal, AverageDiscountDecimal As Decimal

        Try
            'Convert quantity to numeric variable.
            QuantityInteger = Integer.Parse(QuantityTextBox.Text)
            Try
                'Convert price if quantity was successful.
                PriceDecimal = Decimal.Parse(PriceTextBox.Text)
                'Calculate values for sale.
                ExtendedPriceDecimal = QuantityInteger * PriceDecimal
                DiscountDecimal = Decimal.Round( _
                (ExtendedPriceDecimal * DISCOUNT_RATE_Decimal), 2)
                DiscountedPriceDecimal = ExtendedPriceDecimal - DiscountDecimal

                ' Calculate summary values
                QuantitySumInteger += QuantityInteger
                DiscountSumDecimal += DiscountDecimal
                DiscountedPriceSumDecimal += DiscountedPriceDecimal
                SaleCountInteger += 1
                AverageDiscountDecimal = DiscountSumDecimal / SaleCountInteger

                ' Format and display answers for the sale
                ExtendedPriceTextBox.Text = ExtendedPriceDecimal.ToString("C")
                DiscountTextBox.Text = DiscountDecimal.ToString("N")
                DiscountedPriceTextBox.Text = DiscountedPriceDecimal.ToString("C")

                ' Format and display summary values
                QuantitySumTextBox.Text = QuantitySumInteger.ToString()
                DiscountSumTextBox.Text = DiscountSumDecimal.ToString("C")
                DiscountedAmountSumTextBox.Text = DiscountedPriceSumDecimal.ToString("C")
                AverageDiscountTextBox.Text = AverageDiscountDecimal.ToString("C")

            Catch ex As Exception
                ' Exception handler for price
                MessageBox.Show("Price Must Be Numeric.", "Data Entry Error", _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With PriceTextBox
                    .Focus()
                    .SelectAll()
                End With
            End Try
        Catch ex As Exception
            ' Exception handler for quantity
            MessageBox.Show("Quantity Must Be Numeric.", "Data Entry Error", _
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With QuantityTextBox
                .Focus()
                .SelectAll()
            End With

        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ' Clear the form

        TitleTextBox.Clear()
        PriceTextBox.Clear()
        ExtendedPriceTextBox.Clear()
        DiscountedPriceTextBox.Clear()
        DiscountTextBox.Clear()
        With QuantityTextBox
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'Exit the application

        Me.Close()
    End Sub
End Class
