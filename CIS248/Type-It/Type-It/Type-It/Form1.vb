Public Class Form1

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim appMdiChildForm As New MdiChildForm
        appMdiChildForm.MdiParent = Me
        appMdiChildForm.Show()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        Dim activeChild As Form = Me.ActiveMdiChild
        If (Not activeChild Is Nothing) Then
            Try
                Dim theBox As RichTextBox = CType(activeChild.ActiveControl, RichTextBox)
                If (Not theBox Is Nothing) Then
                    theBox.Focus()
                    theBox.SelectAll()
                End If
            Catch
                MessageBox.Show("You need to select a RichTextBox.")
            End Try
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        If Convert.ToString(Me.ActiveMdiChild) = Nothing Then
            MessageBox.Show("No active windows", "Type-It")
        Else
            Me.ActiveMdiChild.Close()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Dim activeChild As Form = Me.ActiveMdiChild
        If (activeChild Is Nothing) Then
            MessageBox.Show("There is no active window.", "Type-It")
        Else
            Dim theBox As RichTextBox = CType(activeChild.ActiveControl, RichTextBox)
            If (Not theBox.SelectedText = "") Then
                theBox.Copy()
            Else
                MessageBox.Show("There is no text selected")
            End If
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        Dim activeChild As Form = Me.ActiveMdiChild

        If (Not activeChild Is Nothing) Then
            Try
                Dim theBox As RichTextBox = CType(activeChild.ActiveControl, RichTextBox)
                If (Not theBox Is Nothing) Then
                    Dim data As IDataObject = Clipboard.GetDataObject()
                    If (data.GetDataPresent(DataFormats.Text)) Then
                        theBox.SelectedText = data.GetData(DataFormats.Text).ToString()
                    End If
                End If
            Catch
                MessageBox.Show("You need to select a RichTextBox.")
            End Try
        End If

    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        Dim activeChild As Form = Me.ActiveMdiChild
        If (activeChild Is Nothing) Then
            MessageBox.Show("There is no active window.", "Type-It")
        Else
            Dim theBox As RichTextBox = CType(activeChild.ActiveControl, RichTextBox)
            If (Not theBox.SelectedText = "") Then
                theBox.Cut()
            Else
                MessageBox.Show("There is no text selected")
            End If
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        Dim activeChild As Form = Me.ActiveMdiChild
        Dim theBox As RichTextBox = CType(activeChild.ActiveControl, RichTextBox)
        With FontDialog1
            .Font = theBox.Font
            .ShowDialog()
            theBox.Font = .Font
        End With
    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordWrapToolStripMenuItem.Click
        Dim activeChild As Form = Me.ActiveMdiChild
        Dim theBox As RichTextBox = CType(activeChild.ActiveControl, RichTextBox)
        If WordWrapToolStripMenuItem.Checked = True Then
            theBox.WordWrap = True
        Else
            theBox.WordWrap = False
        End If
    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFileToolStripMenuItem.Click
        Dim appMdiChildForm As New MdiChildForm
        appMdiChildForm.MdiParent = Me
        appMdiChildForm.Show()
        Dim activeChild As Form = Me.ActiveMdiChild
        Dim theBox As RichTextBox = CType(activeChild.ActiveControl, RichTextBox)
        Dim fileText As IO.StreamReader

        OpenFileDialog1.ShowDialog()

        fileText = IO.File.OpenText(OpenFileDialog1.FileName)
        While fileText.Peek > -1
            theBox.Text &= fileText.ReadLine & System.Environment.NewLine
        End While
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim activeChild As Form = Me.ActiveMdiChild
        Dim theBox As RichTextBox = CType(activeChild.ActiveControl, RichTextBox)

        SaveFileDialog1.ShowDialog()
        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, theBox.Text, False)
    End Sub
End Class
