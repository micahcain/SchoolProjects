Attribute VB_Name = "Public"
Private Declare Function URLDownloadToFile Lib "urlmon" Alias "URLDownloadToFileA" _
        (ByVal pCaller As Long, ByVal szURL As String, ByVal szFileName As String, _
         ByVal dwReserved As Long, ByVal lpfnCB As Long) As Long
Public Function DownloadFile(URL As String, LocalFilename As String) As Boolean
    Dim lngRetVal As Long
   
    lngRetVal = URLDownloadToFile(0, URL, LocalFilename, 0, 0)
    If lngRetVal = 0 Then DownloadFile = True

End Function
Public Function emailNet(email As Integer)
If Not emailNum = 100 Or emailNum = 118 Then
If SbEmailPlayer.SBEMAIL100.Visible = True Then
SbEmailPlayer.SBEMAIL100.stop
SbEmailPlayer.SBEMAIL100.Visible = False
End If
SbEmailPlayer.SBEMAIL.Movie = "http://www.homestarrunner.com/sbemail" & emailNum & ".swf"
SbEmailPlayer.SBEMAIL.Visible = True
SbEmailPlayer.SBEMAIL.Play
Else
If SbEmailPlayer.SBEMAIL.Visible = True Then
SbEmailPlayer.SBEMAIL.stop
SbEmailPlayer.SBEMAIL.Visible = False
End If
If emailNum = 100 Then
SbEmailPlayer.SBEMAIL100.Movie = "http://www.homestarrunner.com/sbemailahundred.swf"
SbEmailPlayer.SBEMAIL100.Visible = True
SbEmailPlayer.SBEMAIL100.Play
ElseIf emailNum = 118 Then
SbEmailPlayer.SBEMAIL100.Movie = "http://www.homestarrunner.com/sbemail118.swf"
SbEmailPlayer.SBEMAIL100.Visible = True
SbEmailPlayer.SBEMAIL100.Play
End If
End If
If SbEmailPlayer.SBEMAIL.Movie = Null Then
MsgBox "Ok man, try making sure there's like an email there first. I can't play that nothing you gave me", vbOKOnly + vbCritical, "Strong Bad's Email Player"
End If
End Function
Public Function emailFile(email As Integer)
If email = 100 Or email = 118 Then
If SbEmailPlayer.SBEMAIL.Visible = True Then
SbEmailPlayer.SBEMAIL.Visible = False
SbEmailPlayer.SBEMAIL.stop
End If
SbEmailPlayer.SBEMAIL100.Movie = App.Path & "\emails\sbemail" & email & ".sbe"
SbEmailPlayer.SBEMAIL100.Visible = True
SbEmailPlayer.SBEMAIL100.Play
Else
If SbEmailPlayer.SBEMAIL100.Visible = True Then
SbEmailPlayer.SBEMAIL100.Visible = flse
SbEmailPlayer.SBEMAIL100.stop
End If
SbEmailPlayer.SBEMAIL.Movie = App.Path & "\emails\sbemail" & email & ".sbe"
SbEmailPlayer.SBEMAIL.Visible = True
SbEmailPlayer.SBEMAIL.Play
End If
End Function
Public Function chooserClear(chooserCount As Integer)
For intI = 1 To chooserCount
    SbEmailPlayer.Chooser.RemoveItem 0
    Next intI
End Function
Public Function addNewEmail(emailName As String)
Open "archive.dat" For Append As 1
Write #1, emailName
End Function
Public Function saveNewEmail()
Dim count As Integer
count = SbEmailPlayer.Chooser.ListCount + 1
DownloadFile "http://www.homestarrunner.com/sbemail" & count & ".swf", App.Path & "\emails\sbemail" & count & ".sbe"
End Function

Public Function updateSingle()
Dim upNum As Integer
upNum = InputBox("Enter the number of the email you would like to update", "Strong Bad's Email Player")
If upNum = 100 Then
DownloadFile "http://www.homestarrunner.com/sbemailahundred.swf", App.Path & "\emails\sbemail" & upNum & "\.sbe"
ElseIf upNum = 126 Then
DownloadFile "http://www.homestarrunner.com/sbemail126_mx.swf", App.Path & "\emails\sbemail" & upNum & "\.sbe"
Else
DownloadFile "http://www.homestarrunner.com/sbemail" & upNum & ".swf", App.Path & "\emails\sbemail" & upNum & "\.sbe"
End If
End Function

Public Function updateCurrent()
If SbEmailPlayer.Chooser.ListIndex + 1 = 100 Then
DownloadFile "http://www.homestarrunner.com/sbemailahundred.swf", App.Path & "\emails\sbemail" & SbEmailPlayer.Chooser.ListIndex + 1 & "\.sbe"
ElseIf SbEmailPlayer.Chooser.ListIndex + 1 = 126 Then
DownloadFile "http://www.homestarrunner.com/sbemail126_mx.swf", App.Path & "\emails\sbemail" & SbEmailPlayer.Chooser.ListIndex + 1 & "\.sbe"
Else
DownloadFile "http://www.homestarrunner.com/sbemail" & SbEmailPlayer.Chooser.ListIndex + 1 & ".swf", App.Path & "\emails\sbemail" & SbEmailPlayer.Chooser.ListIndex + 1 & "\.sbe"
End If
End Function

Public Function updateAll()
Kill (App.Path & "\emails\*.sbe")
Call getAllEmails
End Function
