Public Class frmDemo

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'experimental project

    End Sub

    Private Sub txtFirst_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFirst.Leave
        txtFirst.ForeColor = Color.Black
    End Sub

    Private Sub txtFirst_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirst.TextChanged
    txtFirst.ForeColor = Color.Blue
    End Sub

    Private Sub btnRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRed.Click
        txtFirst.ForeColor = Color.Red
    End Sub

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnButton.Click
    txtFirst.Clear()
  End Sub

  Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBox3.TextChanged
    txtBox3.Text = "hello"
  End Sub

  Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
    Label1.Text = "hello"
  End Sub
End Class
