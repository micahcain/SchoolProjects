Public Class Form1
    ' Project:          Ch7HandsOn
    ' Programmer:       Micah Cain
    ' Date:             11.17.2008

    Private Sub AddCoffeeFlavorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCoffeeFlavorToolStripMenuItem.Click
        With CoffeeComboBox
            If .Text <> "" Then
                Dim ItemFoundBoolean As Boolean
                Dim ItemIndexInteger As Integer
                Do Until ItemFoundBoolean Or ItemIndexInteger = .Items.Count
                    If .Text = .Items(ItemIndexInteger).ToString() Then
                        ItemFoundBoolean = True
                        Exit Do
                    Else
                        ItemIndexInteger += 1
                    End If
                Loop
                If ItemFoundBoolean Then
                    MessageBox.Show("Duplicate Item.", "Add Failed", _
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    .Items.Add(.Text)
                    .Text = ""
                End If
            Else
                MessageBox.Show("Enter a coffee flavor to add", _
                    "Missing Data", MessageBoxButtons.OK, _
                    MessageBoxIcon.Exclamation)
            End If
            .Focus()
        End With
    End Sub

    Private Sub PrintAllFlavorsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintAllFlavorsToolStripMenuItem.Click
        PrintAllPrintDocument.Print()
    End Sub
    Private Sub PreviewAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviewAllToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintAllPrintDocument
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintSelectedFlavorsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSelectedFlavorsToolStripMenuItem.Click
        If SyrupListBox.SelectedIndex = -1 Then
            SyrupListBox.SelectedIndex = 0
        End If
        If CoffeeComboBox.SelectedIndex <> -1 Then
            PrintSelectedPrintDocument.Print()
        Else
            MessageBox.Show("Select a flavor from the coffee list", _
                "Print Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub PreviewSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviewSelectedToolStripMenuItem.Click
        If SyrupListBox.SelectedIndex = -1 Then
            SyrupListBox.SelectedIndex = 0
        End If
        If CoffeeComboBox.SelectedIndex <> -1 Then
            PrintPreviewDialog1.Document = PrintSelectedPrintDocument
            PrintPreviewDialog1.ShowDialog()
        Else
            MessageBox.Show("Select a flavor from the coffee list.", "Print Selection", _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub printallprintdocument_printpage(ByVal sender As Object, _
    ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
    Handles PrintAllPrintDocument.PrintPage

        Dim printfont As New Font("Arial", 12)
        Dim LineHeightsSingle As Single = printfont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim PrintLineString As String

        Using HeadingFont As New Font("Arial", 14, FontStyle.Bold)
            e.Graphics.DrawString("Flavors", HeadingFont, _
                Brushes.Black, HorizontalPrintLocationSingle, _
                VerticalPrintLocationSingle)
        End Using

        For ListIndexInteger As Integer = 0 To CoffeeComboBox.Items.Count - 1
            VerticalPrintLocationSingle += LineHeightsSingle

            PrintLineString = CoffeeComboBox.Items(ListIndexInteger).ToString()

            e.Graphics.DrawString(PrintLineString, printfont, _
                Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        Next ListIndexInteger
    End Sub

    Private Sub PrintSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSelectedToolStripMenuItem.Click
        If SyrupListBox.SelectedIndex = -1 Then
            SyrupListBox.SelectedIndex = 0
        End If
        If CoffeeComboBox.SelectedIndex <> -1 Then
            PrintSelectedPrintDocument.Print()
        Else
            MessageBox.Show("Select a flavor from the coffee list.", _
                "Print Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub ClearCoffeeListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearCoffeeListToolStripMenuItem.Click
        Dim ResponseDialogResult As DialogResult

        ResponseDialogResult = MessageBox.Show("Clear the coffee flavor list?", _
            "Clear coffee list", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ResponseDialogResult = Windows.Forms.DialogResult.Yes Then
            CoffeeComboBox.Items.Clear()
        End If
    End Sub

    Private Sub RemoveCoffeeFlavorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveCoffeeFlavorToolStripMenuItem.Click
        With CoffeeComboBox
            If .SelectedIndex <> -1 Then
                .Items.RemoveAt(.SelectedIndex)
            Else
                MessageBox.Show("First select the coffee to remove", _
                    "No selection made", MessageBoxButtons.OK, _
                    MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

    Private Sub DisplayCoffeeCountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayCoffeeCountToolStripMenuItem.Click
        Dim MessageString As String

        MessageString = "The number of coffee types is " & _
        CoffeeComboBox.Items.Count & "."
        MessageBox.Show(MessageString, "R 'n R Coffee Type Count", _
            MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With CoffeeComboBox
            .Items.Add("Chocolate Almond")
            .Items.Add("Espresso Roast")
            .Items.Add("Jamaica Blue Mountain")
            .Items.Add("Kona Blend")
            .Items.Add("Vanilla Nut")
        End With
        With SyrupListBox
            .Items.Add("(None)")
            .Items.Add("Chocolate")
            .Items.Add("Hazelnut")
            .Items.Add("Irish Creme")
            .Items.Add("Orange")
        End With
    End Sub

    Private Sub PrintSelectedPrintDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintSelectedPrintDocument.PrintPage
        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim PrintLineString As String

        PrintLineString = "Print Selected Item"
        e.Graphics.DrawString(PrintLineString, HeadingFont, _
            Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

        VerticalPrintLocationSingle += LineHeightSingle * 2

        PrintLineString = "Coffee: " & CoffeeComboBox.Text & _
        "      Syrup: " & SyrupListBox.Text

        e.Graphics.DrawString(PrintLineString, PrintFont, _
            Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
    End Sub
End Class
