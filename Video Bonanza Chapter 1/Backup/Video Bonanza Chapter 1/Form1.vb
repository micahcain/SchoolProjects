Imports Microsoft.VisualBasic.PowerPacks.Printing
Imports System.Drawing
''Programmer: Micah Cain
''Date: 8.25.2011
''Class: CS288
''Project: Chapter 1 Video Bonanza
Public Class Form1
    '' Global controls are declared
    '' and instatiated here
    Dim categories(5) As String
    Dim infoLabel As Label = New Label
    Dim printForm1 As PrintForm = New PrintForm

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''Call the method to put the controls on the form
        buildFormControls()
        ''Disable the maximize button
        Me.MaximizeBox = False
    End Sub
   
    Private Sub buildFormControls()
        ''Building the controls that will populate the form
        ''This includes position, text values, and event handlers.
        ''Also the String array which contains the categories and locations
        ''Is populated here
        Dim catButtons(5) As Button
        infoLabel.Location() = New System.Drawing.Point(200, 100)
        Me.Controls.Add(infoLabel)

        categories(0) = "Comedy|Aisle 1"
        categories(1) = "Drama|Aisle 2"
        categories(2) = "Action|Aisle 3"
        categories(3) = "Sci-Fi|Aisle 4"
        categories(4) = "Horror|Aisle 5"
        categories(5) = "New Releases|Back Wall"

        Dim index As Integer = 0
        Dim initialHeight = 0

        For Each catButton As Button In catButtons
            catButton = New Button
            catButton.Name = "catButton" + index.ToString()
            AddHandler catButton.Click, AddressOf catButtonClick
            catButton.Location() = New Point(0, initialHeight)
            catButton.Width = 125
            Me.Controls.Add(catButton)
            catButton.Text = categories(index).Split(CType("|", Char))(0)

            index += 1
            initialHeight += 30
        Next


        Dim exitButton As Button = New Button
        exitButton.Location() = New Point(5, 300)
        exitButton.Text = "EXIT"
        Me.Controls.Add(exitButton)
        AddHandler exitButton.Click, AddressOf exitButtonClick

        Dim printButton As Button = New Button
        printButton.Location() = New Point(85, 300)
        printButton.Text = "PRINT"
        Me.Controls.Add(printButton)
        AddHandler printButton.Click, AddressOf printForm
    End Sub

    ''Event methods for the button array, printButton, and exitButton
    Private Sub catButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim name As String = CType(sender, Button).Name.ToString
        name = name.Substring(9)
        infoLabel.Text = categories(CType(name, Integer)).Split(CType("|", Char))(1)
    End Sub
    Private Sub printForm(ByVal sender As Object, ByVal e As EventArgs)
        printForm1.PrintAction = Printing.PrintAction.PrintToPreview
        printForm1.Form = Me
        printForm1.Print()
    End Sub
    Private Sub exitButtonClick()
        Me.Close()
    End Sub
End Class
