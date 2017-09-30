Attribute VB_Name = "firstRun"
Public Function prevInstance()
If App.prevInstance Then
MsgBox "Another instance of Strong Bad's Email Player is currently running", vbOKOnly + vbCritical, "Strong Bad's Email Player"
End
End If
End Function

Public Function getAllEmails()
Dim emailNum As Integer
Dim emailString As String
For emailNum = 1 To 99
DownloadFile "http://www.homestarrunner.com/sbemail" & emailNum & ".swf", App.Path & "\emails\sbemail" & emailNum & ".sbe"
Next emailNum
DownloadFile "http://www.homestarrunner.com/sbemailahundred.swf", App.Path & "\emails\sbemail100.sbe"
For emailNum = 101 To 125
DownloadFile "http://www.homestarrunner.com/sbemail" & emailNum & ".swf", App.Path & "\emails\sbemail" & emailNum & ".sbe"
Next emailNum
DownloadFile "http://www.homestarrunner.com/sbemail126_mx.swf", App.Path & "\emails\sbemail126.sbe"
emailNum = 127
DownloadFile "http://www.homestarrunner.com/sbemail" & emailNum & ".swf", App.Path & "\emails\sbemail" & emailNum & ".sbe"
Do While (Dir(App.Path & "\emails\sbemail" & emailNum & ".sbe")) = "sbemail" & emailNum & ".sbe"
emailNum = emailNum + 1
DownloadFile "http://www.homestarrunner.com/sbemail" & emailNum & ".swf", App.Path & "\emails\sbemail" & emailNum & ".sbe"
Loop
Kill (App.Path & "\urn.dat")
End Function

Public Function checkFirstRun()
Dim checkFirstR As Integer

If (Dir(App.Path & "\urn.dat")) = "urn.dat" Then
Open "urn.dat" For Input As 1
Input #1, checkFirstR
Close #1
Else
Exit Function
End If

If checkFirstR <> 1 Then
dnld = MsgBox("This is your first time using Strong Bad's Email Player. Would you like to download all the emails?", vbYesNo + vbQuestion, "Strong Bad's Email Player")
End If

If dnld = vbYes Then
Call getAllEmails
SbEmailPlayer.getTheEmails.Visible = False
Else
If (Dir(App.Path & "\urn.dat")) = "urn.dat" Then
Open "urn.dat" For Output As 1
Write #1, 1
Close #1
End If
End If
End Function
Public Function compareEmails()

End Function

Public Function insertBlanks()
Dim blankNum As Integer
Dim emailTotal As Integer
emailTotal = compareEmails
Open "archive.dat" For Append As 1
For blankNum = SbEmailPlayer.Chooser.ListCount To emailTotal
Write #1, "BLANK"
Next
End Function

Public Function missingEmails()

End Function
