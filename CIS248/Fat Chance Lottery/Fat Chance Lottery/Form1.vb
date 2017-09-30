Public Class Form1
    
    Private Sub SelectNumbersButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    SelectNumbersButton.Click
        Dim LabelCurrent() As Label = {Label1, Label2, Label3, Label4, Label5, Label6, Label7, Label8, Label9, Label10, _
    Label11, Label12}
        Dim LabelNumber As Integer = 0
        Dim NumberCurrent As Integer = 0

        If SelectNumbersButton.Text = "Try Your Luck" Then
            getUserPick(NumberCurrent, LabelNumber, LabelCurrent)
        Else
            generateDailyPick(LabelNumber, LabelCurrent)
            didYouWin()
            reset(LabelCurrent)
        End If
    End Sub

    Private Sub getUserPick(ByVal numbercurrent, ByVal labelnumber, ByVal labelcurrent)
        Do
            Do
                numbercurrent = InputBox("Please enter your pick for number " & labelnumber + 1 & ".", "Fat Chance Lottery")
                If numbercurrent < 1 Or numbercurrent > 55 Then
                    MessageBox.Show("Numbers for the pick 5 must be between 1 and 55.", "Fat Chance Lottery", _
                     MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Exit Do
                End If
            Loop While numbercurrent < 1 Or numbercurrent > 55
            LabelCurrent(labelnumber).Text = numbercurrent
            labelnumber += 1
        Loop Until labelnumber = 5
        Do
            Label6.Text = InputBox("Please enter a number between 1 and 42 for the special pick.", "Fat Chance Lottery")
            If Integer.Parse(Label6.Text) < 1 Or Integer.Parse(Label6.Text) > 42 Then
                MessageBox.Show("Special pick must be between 1 and 42", "Fat Chance Lottery", MessageBoxButtons.OK, _
                 MessageBoxIcon.Error)
            End If
        Loop While Label6.Text < 1 Or Label6.Text > 42
        SelectNumbersButton.Text = "Today's Lotto Numbers Are..."
    End Sub

    Private Sub generateDailyPick(ByVal labelnumber, ByVal labelcurrent)
        Dim RandomLotto As Random = New Random(DateTime.Now.Millisecond)
        labelnumber = 6

        Do
            LabelCurrent(labelnumber).Text = RandomLotto.Next(1, 55)
            labelnumber += 1
        Loop Until labelnumber = 11
        LabelCurrent(11).Text = RandomLotto.Next(1, 42)
    End Sub

    Private Sub didYouWin()
        Dim NumArray() As Label = {Label1, Label2, Label3, Label4, Label5, Label6, Label7, Label8, Label9, Label10, _
    Label11, Label12}
        Dim UserPick As Integer = 0
        Dim LottoPick As Integer = 6

        Do
            If NumArray(UserPick).Text <> NumArray(LottoPick).Text Then
                MessageBox.Show("Don't worry, noone ever wins.", "Fat Chance Lottery", _
                                MessageBoxButtons.OK, MessageBoxIcon.None)
                Exit Do
            Else
                NumArray(UserPick).Text = "Y"
                UserPick += 1
                LottoPick += 1
            End If
        Loop Until UserPick = 5

        If UserPick = 5 Then
            MessageBox.Show("YOU WON THE LOTTERY!!!", "Fat Chance Lottery", MessageBoxButtons.OK, _
             MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub reset(ByVal labelcurrent)
        Dim arraySubCurrent As Integer = 0
        Do
            LabelCurrent(arraySubCurrent).Text = ""
            arraySubCurrent += 1
        Loop Until arraySubCurrent = 12
        SelectNumbersButton.Text = "Try Your Luck"
    End Sub
End Class
