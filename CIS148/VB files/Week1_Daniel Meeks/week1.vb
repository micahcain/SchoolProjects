Public Class frmColorsTextBox

    Private Sub btnBlue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBlue.Click
        txtBox.BackColor = Color.Blue
    End Sub

    Private Sub btnRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRed.Click
        txtBox.BackColor = Color.Red
    End Sub

    Private Sub btnWhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWhite.Click
        txtBox.ForeColor = Color.White
    End Sub

    Private Sub btnYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYellow.Click
        txtBox.ForeColor = Color.Yellow
    End Sub

    Private Sub btnDisable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisable.Click
        'not sure what to do to disable text box???
    End Sub

    Private Sub btnEnable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnable.Click
        txtBox2.Focus()
    End Sub
End Class
