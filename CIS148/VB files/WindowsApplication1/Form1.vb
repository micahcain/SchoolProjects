Public Class Form1

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    Dim last, i As Double
    last = -2
    i = 0
    Do While (i <= last)
      ListBox1.Items.Add(i)
      i += 1
    Loop

  End Sub
End Class
