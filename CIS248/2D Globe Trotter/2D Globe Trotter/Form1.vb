Public Class Form1
    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        Dim checkArray() As CheckBox = {CheckBox1, CheckBox2, CheckBox3, CheckBox4, CheckBox5}
        Dim arrayCurrent As Integer = 0

        Do
            checkArray(arrayCurrent).Checked = False
            arrayCurrent += 1
        Loop Until arrayCurrent = 5
    End Sub

    Private Sub displayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles displayButton.Click
        Dim fareInfo(,) As String = _
        {{CheckBox1.Text, "1000"}, _
        {CheckBox2.Text, "1200"}, _
        {CheckBox3.Text, "1400"}, _
        {CheckBox4.Text, "1200"}, _
        {CheckBox5.Text, "1000"}}
        Dim destSub As Integer = 0
        Dim numChecked As Integer = 0
        Dim boxSub As Integer = 0
        Dim boxArray() As CheckBox = {CheckBox1, CheckBox2, CheckBox3, CheckBox4, CheckBox5}
        Dim message As String = "The prices for your selected destination(s) are:" & System.Environment.NewLine

        Do
            If boxArray(boxSub).Checked = True Then
                message = message & fareInfo(destSub, 0) & ":                             " & _
                Integer.Parse(fareInfo(destSub, 1)).ToString("C2") & System.Environment.NewLine
            Else
                numChecked += 1
            End If
            destSub += 1
            boxSub += 1
        Loop Until destSub = 5
        If numChecked = 5 Then
            message = "There were no destinations selected."
        End If
        MessageBox.Show(message, "Globe Trotting", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
