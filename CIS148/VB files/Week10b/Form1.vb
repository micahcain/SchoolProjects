Public Class Form1

  Private Sub InterstButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InterstButton.Click
    Dim depositAmount As Decimal = InputBox("Enter the deposit amount.", "Interesting Interest")
    Dim totalMonth As Decimal
    ListBox1.Items.Add("Month1 " & depositAmount.ToString("C"))
    totalMonth = 1.005 * totalMonth + depositAmount

    For i As Integer = 1 To 3
      totalMonth = 1.005 * totalMonth + depositAmount
      ListBox1.Items.Add("Month" & i + 1 & " " & totalMonth.ToString("C"))
    Next

  End Sub
End Class
