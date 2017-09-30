' Exercise 02.04 VB Reloaded Advanced

Option Explicit On
Option Strict On

Public Class MainForm
    Private destinations() As String = _
        {"London", "Paris", "Rome", "Moscow", "Beijing"}
    Private fares() As Double = {1000, 1200, 1400, 1200, 1000}
    Private origination As String = " from New York City to "

    Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            outputLabel1.Text = fares(0).ToString("C2") & origination & destinations(0)
        Else
            outputLabel1.Text = String.Empty
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            outputLabel2.Text = fares(1).ToString("C2") & origination & destinations(1)
        Else
            outputLabel2.Text = String.Empty
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            outputLabel3.Text = fares(2).ToString("C2") & origination & destinations(2)
        Else
            outputLabel3.Text = String.Empty
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            outputLabel4.Text = fares(3).ToString("C2") & origination & destinations(3)
        Else
            outputLabel4.Text = String.Empty
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            outputLabel5.Text = fares(4).ToString("C2") & origination & destinations(4)
        Else
            outputLabel5.Text = String.Empty
        End If
    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles clearButton.Click
        outputLabel1.Text = String.Empty
        outputLabel2.Text = String.Empty
        outputLabel3.Text = String.Empty
        outputLabel4.Text = String.Empty
        outputLabel5.Text = String.Empty

        CheckBox1.CheckState = CheckState.Unchecked
        CheckBox2.CheckState = CheckState.Unchecked
        CheckBox3.CheckState = CheckState.Unchecked
        CheckBox4.CheckState = CheckState.Unchecked
        CheckBox5.CheckState = CheckState.Unchecked
    End Sub
End Class
