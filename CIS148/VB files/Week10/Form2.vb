Public Class Form2

  Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Label1.Text = "Here is a game that is 50% skill, 49% luck, and 1% breaking your computer. You" & _
     "start the game with a number of sticks between 5 and 50. Then, you and the computer take turns picking up" & _
      " one, two, or three sticks per turn. The object of the game is to not be the one to pick up the last remaining stick." & _
     " Can you beat the computer? I kinda doubt it."
  End Sub

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    Me.Close()
  End Sub
End Class