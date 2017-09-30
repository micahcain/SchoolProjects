Public Class Form1

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    ListBox1.Items.Clear()
    Dim file As IO.StreamReader = IO.File.OpenText("GIFTS.txt")
    Dim gift As String
    Dim price As Decimal
    Dim dayTotal As Decimal
    Dim day As Integer = InputBox("Enter a day of Christmas.", "12 days of Christmas")
    If day < 1 Or day > 12 Then
      Do
        MessageBox.Show("Value must be between 1 and 12.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        day = InputBox("Enter a day of Christmas.", "12 days of Christmas")
      Loop Until day > 1 And day < 12
    End If

    ListBox1.Items.Add("The gifts for day " & day & " are.")
    For count = 1 To day
      gift = file.ReadLine
      price = file.ReadLine
      price = price * count
      dayTotal += price
      ListBox1.Items.Add(count & " " & gift)
    Next
    ListBox1.Items.Add("The total for day " & day & " is " & dayTotal.ToString("C"))
    ListBox1.Items.Add("The total cost for all twelve days is:")
    dayTotal = 0
    file.Close()
    file = IO.File.OpenText("GIFTS.txt")
    day = 1
    For count = 12 To 1 Step -1
      gift = file.ReadLine
      price = file.ReadLine
      price = price * day
      dayTotal += (price * count)
      day += 1
    Next
    ListBox1.Items.Add(dayTotal.ToString("C"))
    price = 0
    dayTotal = 0
  End Sub

  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ListBox1.BackColor = Color.Green
    ListBox1.ForeColor = Color.Red
  End Sub

  Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim phrase As String = InputBox("Please enter a phrase to be tested", "Palindrome")
    If IsPalindrome(phrase) Then
      MessageBox.Show("The phrase """ & phrase & """ is a palindrome.", "Palindrome Fun", MessageBoxButtons.OK, MessageBoxIcon.Information)
    Else
      MessageBox.Show("The phrase """ & phrase & """ is not a palindrome.", "Palindrome Fun", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Function IsPalindrome(ByVal phrase As String) As Boolean
    Dim letter As Integer
    Dim reverse As String = ""
    Dim noWhite As String = ""

    phrase = phrase.ToUpper.Trim
    letter = phrase.Length

    For count = 0 To letter - 1
      If phrase.Substring(count, 1) <> " " Then
        If phrase.Substring(count, 1) >= "A" And phrase.Substring(count, 1) <= "Z" Then
          noWhite &= phrase.Substring(count, 1)
        End If
      End If
    Next

    For count = letter - 1 To 0 Step -1
      If phrase.Substring(count, 1) <> " " Then
        If phrase.Substring(count, 1) >= "A" And phrase.Substring(count, 1) <= "Z" Then
          reverse &= phrase.Substring(count, 1)
        End If
      End If
    Next
    If noWhite = reverse Then
      Return True
    End If
  End Function
End Class
