Public Class Form1
    Structure Flight
        Public flightNumber As String
        Public departureCity As String
        Public arrivalCity As String
        Public flightTime As Double
        Public airFare As Double
    End Structure

    Private Sub displayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles displayButton.Click
        Dim travel(,) As Integer = {{1000, 1200, 500}, {2500, 3000, 3500}, {1300, 2000, 2500}}
        Dim time(,) As Double = {{15, 21.5, 10}, {13, 17, 30}, {10, 15.8, 35.6}}
        Dim flightNo(,) As String = {{1841, 1941, 2041}, {1841, 1942, 2042}, {1843, 1943, 2043}}
        Dim userPlan As Flight

        userPlan.flightNumber = flightNo(destinationListBox.SelectedIndex, originListBox.SelectedIndex)
        userPlan.departureCity = originListBox.SelectedItem
        userPlan.arrivalCity = destinationListBox.SelectedItem
        userPlan.flightTime = time(destinationListBox.SelectedIndex, originListBox.SelectedIndex)
        If roundTripCheckBox.Checked = True Then
            userPlan.airFare = 2 * (travel(destinationListBox.SelectedIndex, originListBox.SelectedIndex))
        Else
            userPlan.airFare = travel(destinationListBox.SelectedIndex, originListBox.SelectedIndex)
        End If
        If roundTripCheckBox.Checked = True Then
            userPlan.flightTime = 2 * (time(destinationListBox.SelectedIndex, originListBox.SelectedIndex))
        Else
            userPlan.flightTime = time(destinationListBox.SelectedIndex, originListBox.SelectedIndex)
        End If

        MessageBox.Show("Your flight information is as follows:" & System.Environment.NewLine _
        & "------------------------------------" & System.Environment.NewLine _
        & "Departing from: " & userPlan.departureCity & System.Environment.NewLine _
        & "Arriving at        : " & userPlan.arrivalCity & System.Environment.NewLine _
        & "Travel time       : " & userPlan.flightTime & " hours" & System.Environment.NewLine _
        & "Flight No.         : " & userPlan.flightNumber & System.Environment.NewLine _
        & "------------------------------------" & System.Environment.NewLine _
        & "                                    Price: " & userPlan.airFare.ToString("C2"), "Flight Booking", MessageBoxButtons.OK, _
         MessageBoxIcon.Information)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles roundTripCheckBox.CheckedChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
