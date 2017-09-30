Public Class Form1
  Private scoreOne As Integer
  Private scoreTwo As Integer

  Private Sub AverageButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AverageButton.Click
    Dim scoreOne As Integer = InputBox("Enter Score One", "Score Averager", "Enter a score from 0 to 100")
    Dim scoreTwo As Integer = InputBox("Enter Score Two", "Score Averager", "Enter a score from 0 to 100")
    Dim scoreThree As Integer = InputBox("Enter Score Three", "Grade Averager", "Enter a score from 0 to 100")

    If scoreOne > scoreTwo Then
      If scoreTwo > scoreThree Then
        MessageBox.Show("The two highest scores are" & Environment.NewLine & scoreOne & _
        Environment.NewLine & "and" & Environment.NewLine & _
        scoreTwo & "." & Environment.NewLine & "The average is" & Environment.NewLine & (scoreOne + scoreTwo) / 2, "Score Averager", MessageBoxButtons.OK, _
        MessageBoxIcon.Information)
      Else
        MessageBox.Show("The two highest scores are" & Environment.NewLine & scoreOne & _
        Environment.NewLine & "and" & Environment.NewLine & _
        scoreThree & "." & Environment.NewLine & "The average is" & Environment.NewLine & (scoreOne + scoreThree) / 2, "Score Averager", MessageBoxButtons.OK, _
        MessageBoxIcon.Information)
      End If
    ElseIf scoreOne < scoreThree Then
      MessageBox.Show("The two highest scores are" & Environment.NewLine & scoreThree & _
        Environment.NewLine & "and" & Environment.NewLine & _
        scoreTwo & "." & Environment.NewLine & "The average is" & Environment.NewLine & (scoreThree + scoreTwo) / 2, "Score Averager", MessageBoxButtons.OK, _
        MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub LeapButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeapButton.Click
    Dim Year As Integer = InputBox("Enter a year", "Leap Year Calculator")

    If Year Mod 4 = 0 Then
      If Year Mod 100 > 0 Then
        MessageBox.Show("The year " & Year & " is a leap year.", "Leap Year Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information)
      ElseIf Year Mod 100 = 0 And Year Mod 400 = 0 Then
        MessageBox.Show("The year " & Year & " is a leap year.", "Leap Year Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Else
        MessageBox.Show("The year " & Year & " is not a leap year.", "Leap Year Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    Else
      MessageBox.Show("The year " & Year & " is not a leap year.", "Leap Year Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub
  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

  End Sub

  Private Sub StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click
    Dim holder As Integer
    CalculateButton.Visible = True
    Result.Visible = True
    TextBox1.Visible = True
    StartButton.Visible = False
    scoreOne = InputBox("Enter the first grade", "Highest Grades")
    scoreTwo = InputBox("Enter the second grade", "Highest Grades")

    If scoreOne > scoreTwo Then
      holder = scoreOne
      scoreOne = scoreTwo
      scoreTwo = holder
    End If
  End Sub

  Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
    Dim scoreNew As Integer = Integer.Parse(TextBox1.Text)
    If scoreNew < scoreOne And scoreNew < scoreTwo Then

    ElseIf scoreNew < scoreOne And scoreNew >= scoreTwo Then
      scoreTwo = scoreNew
    ElseIf scoreNew > scoreOne And scoreNew <= scoreTwo Then
      scoreOne = scoreNew
    ElseIf scoreNew > scoreOne And scoreNew >= scoreTwo Then
      scoreOne = scoreTwo
      scoreTwo = scoreNew
    End If
  End Sub

  Private Sub Result_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Result.Click
    MessageBox.Show("The Two Highest Scores Are" & Environment.NewLine & scoreOne & Environment.NewLine & scoreTwo, _
       "High Score", MessageBoxButtons.OK, MessageBoxIcon.Information)
    scoreOne = Nothing
    scoreTwo = Nothing
    TextBox1.Text = ""
    StartButton.Visible = True
  End Sub
End Class
