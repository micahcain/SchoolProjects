Public Class Form1

  Private Sub InputButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton.Click
    Dim word As String

    word = InputBox("Enter a Word", "Length Calculator")
    HowLong(word)
    MessageBox.Show(word, "Word Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub

  Private Sub HowLong(ByRef word As String)
    Dim lettersNum As Integer

    lettersNum = word.Length
    word = word & " is " & lettersNum & " letters long."
  End Sub

  Private Sub AverageButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AverageButton.Click
    Dim total As Integer
    GetNumbers(total)
    GetNumbers(total)
    GetNumbers(total)
    Average(total)
    MessageBox.Show("The average is " & total & ".", "Averager", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub
  Private Sub GetNumbers(ByRef num As Integer)
    Dim newNum As Integer
    newNum = InputBox("Enter the next number.", "Averager")
    num = num + newNum
  End Sub
  Private Sub Average(ByRef num As Integer)
    num = num / 3
  End Sub

  Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
    Dim reader As IO.StreamReader = IO.File.OpenText("CHARGES.txt")

    ListBox1.Items.Add("Name              Final Balance")

    CustomerInfo(reader)
    CustomerInfo(reader)
    CustomerInfo(reader)
  End Sub

  Private Sub CustomerInfo(ByRef reader As IO.StreamReader)
    Dim name As String
    Dim initialbalance, purchases, payment, endOfMonthBalance As Decimal

    name = reader.ReadLine
    initialbalance = reader.ReadLine
    purchases = reader.ReadLine
    payment = reader.ReadLine
    endOfMonthBalance = ((0.015 * initialbalance) + initialbalance + purchases - payment)

    ListBox1.Items.Add(name & "               " & endOfMonthBalance.ToString("C"))

  End Sub
End Class
