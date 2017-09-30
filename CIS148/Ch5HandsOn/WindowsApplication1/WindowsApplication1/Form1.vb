' Program Name: Ch5HandsOn
' Programmer:   Micah Cain
' Date:         11.06.2008
' Description:  This program will calculate the ammount
'               due on a customer's purchase as well as
'               the total summary
Public Class Form1
    'Module level constants
    Const TAX_RATE_Decimal As Decimal = 0.08D
    Const CAPPUCCINO_PRICE_Decimal As Decimal = 2D
    Const ESPRESSO_PRICE_Decimal As Decimal = 2.25D
    Const LATTE_PRICE_Decimal As Decimal = 1.75D
    Const ICED_PRICE_Decimal As Decimal = 2.5D

    ' Declare module level variables
    Private SubtotalDecimal, TotalDecimal, GrandTotalDecimal As Decimal
    Private CustomerCountInteger As Integer


    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        'Calculate and display current amounts
        'Add to totals

        Dim PriceDecimal, TaxDecimal, ItemAmountDecimal As Decimal
        Dim QuantityInteger As Integer

        'Find the price
        If CappuccinoRadioButton.Checked Then
            PriceDecimal = CAPPUCCINO_PRICE_Decimal
        ElseIf EspressoRadioButton.Checked Then
            PriceDecimal = ESPRESSO_PRICE_Decimal
        ElseIf LatteRadioButton.Checked Then
            PriceDecimal = LATTE_PRICE_Decimal
        ElseIf IcedCappuccinoRadioButton.Checked Or _
        IcedLatteRadioButton.Checked Then
            PriceDecimal = ICED_PRICE_Decimal
        End If

        'calculate extended price and add to total
        Try
            QuantityInteger = Integer.Parse(QuantityTextBox.Text)
            ItemAmountDecimal = PriceDecimal * QuantityInteger
            SubtotalDecimal += ItemAmountDecimal
            If TaxCheckBox.Checked Then
                TaxDecimal = SubtotalDecimal * TAX_RATE_Decimal
            Else
                TaxDecimal = 0
            End If
            TotalDecimal = SubtotalDecimal + TaxDecimal
            ItemAmountTextBox.Text = ItemAmountDecimal.ToString("C")
            SubTotalTextBox.Text = SubtotalDecimal.ToString("N")
            TaxTextBox.Text = TaxDecimal.ToString("N")
            TotalTextBox.Text = TotalDecimal.ToString("C")
            TaxCheckBox.Enabled = False
            ClearButton.Enabled = True
            NewOrderButton.Enabled = True
            NewOrderToolStripMenuItem.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Quantity must be numeric.", "Data Entry Error", _
            MessageBoxButtons.OK, MessageBoxIcon.Information)
            With QuantityTextBox
                .Focus()
                .SelectAll()
            End With
        End Try
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ' clear neccessary controls

        CappuccinoRadioButton.Checked = True
        ItemAmountTextBox.Clear()
        With QuantityTextBox
            .Focus()
            .Clear()
        End With
    End Sub

    Private Sub NewOrderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewOrderButton.Click
        'clear the order and add totals

        Dim ReturnDialogResult As DialogResult
        Dim MessageString As String

        'Confirmation message stating order has been cleared
        MessageString = "Clear the current order?"
        ReturnDialogResult = MessageBox.Show(MessageString, "Clear Order?", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
        MessageBoxDefaultButton.Button2)

        If ReturnDialogResult = Windows.Forms.DialogResult.Yes Then
            ClearButton_Click(sender, e)
            SubTotalTextBox.Clear()
            TaxTextBox.Clear()
            TotalTextBox.Clear()

            'Add totals if there is no new order
            If SubtotalDecimal <> 0 Then
                GrandTotalDecimal += TotalDecimal
                CustomerCountInteger += 1
                'Reset totals
                SubtotalDecimal = 0
                TotalDecimal = 0
            End If
            With TaxCheckBox
                .Enabled = True
                .Checked = False
            End With
            ClearButton.Enabled = False
            NewOrderButton.Enabled = False
            NewOrderToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub SummaryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryButton.Click
        'Display the daily totals

        Dim AverageDecimal As Decimal
        Dim MessageString As String

        If TotalDecimal <> 0 Then
            NewOrderButton_Click(sender, e)
        End If

        If CustomerCountInteger > 0 Then
            AverageDecimal = GrandTotalDecimal / CustomerCountInteger

            MessageString = "Number of Orders: " _
            & CustomerCountInteger.ToString() _
            & Environment.NewLine & Environment.NewLine _
            & "Total Sales: " & GrandTotalDecimal.ToString("C") _
            & Environment.NewLine & Environment.NewLine _
            & "Average: " & AverageDecimal.ToString("C")
            MessageBox.Show(MessageString, "Coffee Sales Summary", _
            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageString = "No Sales Data to Summarize."
            MessageBox.Show(MessageString, "Coffee Sales Summary", _
            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        ' Exit the application

        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NewOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewOrderToolStripMenuItem.Click
        Call NewOrderButton_Click(sender, e)
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        Call SummaryButton_Click(sender, e)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CalculateSelectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateSelectionToolStripMenuItem.Click
        Call CalculateButton_Click(sender, e)
    End Sub

    Private Sub ClearItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearItemToolStripMenuItem.Click
        Call ClearButton_Click(sender, e)
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        With FontDialog1
            .Font = SubTotalTextBox.Font
            .ShowDialog()
            SubTotalTextBox.Font = .Font
            TaxTextBox.Font = .Font
            TotalTextBox.Font = .Font
        End With
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        With ColorDialog1
            .Color = SubTotalTextBox.ForeColor
            .ShowDialog()
            SubTotalTextBox.ForeColor = .Color
            TaxTextBox.ForeColor = .Color
            TotalTextBox.ForeColor = .Color
        End With
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub
End Class
