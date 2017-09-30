Public Class Form1

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    Dim square As Decimal
    Dim num As Decimal
    square = Math.Sqrt(num)
    
    For num = 1 To 100
      If Math.Sqrt(num).ToString.IndexOf(".") <> 1 Then
        ListBox1.Items.Add(num)
      End If
    Next
  End Sub

  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

  End Sub

  Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    Dim balance As Decimal = 15000
    Const INTEREST_RATE As Decimal = 0.05
    Const YEARLY_WITHDRAW As Decimal = 1000
    Dim years As Integer

    Do Until balance <= 0
      balance = balance + (balance * INTEREST_RATE)
      balance -= YEARLY_WITHDRAW
      years += 1
      ListBox2.Items.Add(balance.ToString("C"))
    Loop
    Label2.Text = "The savings account will be depleted in " & years - 1 & " years."
    ListBox2.Items.RemoveAt(years - 1)
  End Sub
End Class
