Public Class Form1

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    Dim number As Double = InputBox("Enter a number from 1 to 30.", "Add or Multiply")
    Dim mathType As String
    Dim result As Double

    Do While number < 1 Or number > 30
      MessageBox.Show("Number must be between 1 and 30.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      number = InputBox("Enter a number from 1 to 30.", "Add or Multiply")
    Loop

    mathType = InputBox("Enter ""P"" for product or ""S"" for sum.", "Select Math Type")
    Do Until (mathType.ToUpper = "S") Or (mathType.ToUpper = "P")
      MessageBox.Show("You must enter an ""S"" or a ""P""", "Invalid Math Type", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      mathType = InputBox("Enter ""P"" for product or ""S"" for sum.", "Select Math Type")
    Loop

    If mathType.ToUpper = "S" Then
      result = AddNumbers(number)
      TextBox1.Text = "The total from 1 to " & number & " is " & result
    Else
      result = MultiplyNumbers(number)
      TextBox1.Text = "The product from 1 to " & number & " is " & result
    End If

  End Sub

  Private Function AddNumbers(ByRef Number As Integer) As Double
    Dim Total As Double = 1
    For count = 1 To Number
      Total = Total + count
    Next
    Total -= 1
    Return Total
  End Function

  Private Function MultiplyNumbers(ByRef Number As Integer) As Double
    Dim Total As Double = 1
    For count = 1 To Number
      Total = Total * count
    Next
    TextBox1.Text = Total
    Return Total
  End Function

  Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    Dim file As IO.StreamReader = IO.File.OpenText("IPOD_SALES.txt")
    Dim starsString As String = ""
    Dim year As String
    Dim ipods As Integer
    Dim numberOfStars As Integer

    year = file.ReadLine
    ListBox1.Items.Add(year)
    ListBox1.Items.Add("")
    ListBox1.Items.Add("")

    Do Until year = "EOF"
      year = file.ReadLine
      If year = "EOF" Then
        Exit Do
      End If
      ipods = file.ReadLine
      numberOfStars = ipods
      For count = 1 To numberOfStars
        starsString += "*"
      Next
      ListBox1.Items.Add(year & "  " & starsString & "   " & ipods)
      starsString = ""
    Loop

  End Sub
End Class
