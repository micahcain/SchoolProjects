Public Class Form1
  Public matches As Integer
  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  End Sub

  Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    Button2.Enabled = False
    matches = InputBox("How many match sticks will we use?", "Pick up Sticks")
    Do While matches < 5 Or matches > 50
      MessageBox.Show("Match Sticks Must Be Between 5 and 50.", "Pick up Sticks", MessageBoxButtons.OK, MessageBoxIcon.Error)
      matches = InputBox("How many match sticks will we use?", "Pick up Sticks")
    Loop
    If matches Mod 4 = 1 Then
      MessageBox.Show("Alright, you go first", "Pick up Sticks", MessageBoxButtons.OK, MessageBoxIcon.None)
    Else
      MessageBox.Show("Alright, I'll go first", "Pick up Sticks", MessageBoxButtons.OK, MessageBoxIcon.None)
      computer_turn(matches, 0)
    End If
    sticksLabel.Text = matches
  End Sub

  Private Sub computer_turn(ByRef matches As Integer, ByVal playerChoice As Integer)

    If playerChoice = 1 Then
      matches -= 3
    ElseIf playerChoice = 2 Then
      matches -= 2
    ElseIf playerChoice = 3 Then
      matches -= 1
    ElseIf playerChoice = 0 Then
      If matches Mod 4 = 2 Then
        matches -= 1
      ElseIf matches Mod 4 = 3 Then
        matches -= 2
      ElseIf matches Mod 4 = 0 Then
        matches -= 3
      End If
    End If

    If matches = 1 Then
      MessageBox.Show("I win", "Pick up Sticks", MessageBoxButtons.OK, MessageBoxIcon.None)
      Button2.Enabled = True
    End If
    sticksLabel.Text = matches
  End Sub

  Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    Dim numberTake As Integer = 1
    matches = matches - 1
    sticksLabel.Text = matches
    computer_turn(matches, numberTake)
  End Sub

  Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
    Dim numberTake As Integer = 2
    matches = matches - 2
    sticksLabel.Text = matches
    computer_turn(matches, numberTake)
  End Sub

  Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
    Dim NumberTake As Integer = 3
    matches = matches - 3
    sticksLabel.Text = matches
    computer_turn(matches, numberTake)
  End Sub

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    Form2.ShowDialog()
  End Sub
End Class
