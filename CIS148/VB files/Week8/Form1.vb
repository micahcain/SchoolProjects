Public Class Form1

  Private Sub Translate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Translate.Click
    Select Case TextBox1.Text.ToUpper
      Case "AC"
        Label1.Text = TextBox1.Text & " translates to ""Before Meals"""
      Case "AD LIB"
        Label1.Text = TextBox1.Text & " translates to ""Freely as needed"""
      Case "BID"
        Label1.Text = TextBox1.Text & " translates to ""Twice daily"""
      Case "GTT"
        Label1.Text = TextBox1.Text & " translates to ""A drop"""
      Case "HS"
        Label1.Text = TextBox1.Text & " translates to ""At bedtime"""
      Case "QID"
        Label1.Text = TextBox1.Text & " translates to ""Four times a day"""
      Case Else
        Label1.Text = "This abbreviation is not in the database."
    End Select
  End Sub

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateBtn.Click
    Dim income As Decimal = Decimal.Parse(TextBox2.Text)
    Select Case Decimal.Parse(TextBox2.Text)
      Case 0 To 7825
        Label4.Text = (income * 0.1).ToString("C")
      Case 7825.01 To 31850
        Label4.Text = (782.5 + (income * 0.15)).ToString("C")
      Case 31850.01 To 77100
        Label4.Text = (4386.25 + (income * 0.25)).ToString("C")
      Case 77100.01 To 160850
        Label4.Text = (15698.75 + (income * 0.28)).ToString("C")
      Case 160850.01 To 349700
        Label4.Text = (39148.74 + (income * 0.33)).ToString("C")
      Case Is >= 349700.01
        Label4.Text = (101469.25 + (income * 0.35)).ToString("C")
    End Select
  End Sub
End Class
