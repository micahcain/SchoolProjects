VERSION 5.00
Object = "{D27CDB6B-AE6D-11CF-96B8-444553540000}#1.0#0"; "FlDbg9c.ocx"
Begin VB.Form SbEmailPlayer 
   BackColor       =   &H80000006&
   Caption         =   "Strong Bad's Email Player"
   ClientHeight    =   9420
   ClientLeft      =   1200
   ClientTop       =   1455
   ClientWidth     =   13230
   Icon            =   "SbEmailPlayer.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MouseIcon       =   "SbEmailPlayer.frx":628A
   MousePointer    =   99  'Custom
   ScaleHeight     =   9420
   ScaleWidth      =   13230
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton getTheEmails 
      Caption         =   "&Get ALL the emails"
      Height          =   855
      Left            =   5708
      TabIndex        =   8
      Top             =   8400
      Width           =   1815
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H80000008&
      Caption         =   "Email Chooser"
      BeginProperty Font 
         Name            =   "Unreal Tournament"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   975
      Left            =   5348
      TabIndex        =   3
      Top             =   0
      Width           =   2535
      Begin VB.OptionButton optNet 
         BackColor       =   &H80000007&
         Caption         =   "H*R.com"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   1440
         TabIndex        =   6
         Top             =   600
         Width           =   975
      End
      Begin VB.OptionButton optFile 
         BackColor       =   &H80000007&
         Caption         =   "From File"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   5
         Top             =   600
         Width           =   1095
      End
      Begin VB.ComboBox Chooser 
         Height          =   315
         ItemData        =   "SbEmailPlayer.frx":C514
         Left            =   120
         List            =   "SbEmailPlayer.frx":C516
         TabIndex        =   4
         Text            =   "TOTAL EMAILS MAN"
         Top             =   240
         Width           =   2295
      End
   End
   Begin VB.CommandButton stop 
      Caption         =   "ST&OP"
      Height          =   615
      Left            =   8640
      TabIndex        =   2
      Top             =   8400
      Width           =   1095
   End
   Begin VB.CommandButton start 
      BackColor       =   &H00000000&
      Caption         =   "ST&ART"
      Height          =   615
      Left            =   3360
      MaskColor       =   &H00000000&
      TabIndex        =   1
      Top             =   8400
      Width           =   1095
   End
   Begin ShockwaveFlashObjectsCtl.ShockwaveFlash SBEMAIL 
      Height          =   6855
      Left            =   1995
      TabIndex        =   0
      Top             =   1320
      Width           =   9255
      _cx             =   16325
      _cy             =   12091
      FlashVars       =   ""
      Movie           =   ""
      Src             =   ""
      WMode           =   "Window"
      Play            =   0   'False
      Loop            =   -1  'True
      Quality         =   "High"
      SAlign          =   ""
      Menu            =   -1  'True
      Base            =   ""
      AllowScriptAccess=   "always"
      Scale           =   "NoBorder"
      DeviceFont      =   0   'False
      EmbedMovie      =   0   'False
      BGColor         =   "FFFFFF"
      SWRemote        =   ""
      MovieData       =   ""
      SeamlessTabbing =   -1  'True
      Profile         =   -1  'True
      ProfileAddress  =   ""
      ProfilePort     =   1634887535
      AllowNetworking =   "all"
      AllowFullScreen =   "false"
   End
   Begin ShockwaveFlashObjectsCtl.ShockwaveFlash SBEMAIL100 
      Height          =   6255
      Left            =   795
      TabIndex        =   7
      Top             =   1560
      Width           =   11655
      _cx             =   20558
      _cy             =   11033
      FlashVars       =   ""
      Movie           =   ""
      Src             =   ""
      WMode           =   "Window"
      Play            =   0   'False
      Loop            =   -1  'True
      Quality         =   "High"
      SAlign          =   ""
      Menu            =   -1  'True
      Base            =   ""
      AllowScriptAccess=   "always"
      Scale           =   "NoBorder"
      DeviceFont      =   0   'False
      EmbedMovie      =   0   'False
      BGColor         =   "FFFFFF"
      SWRemote        =   ""
      MovieData       =   ""
      SeamlessTabbing =   -1  'True
      Profile         =   0   'False
      ProfileAddress  =   ""
      ProfilePort     =   0
      AllowNetworking =   "all"
      AllowFullScreen =   "false"
   End
   Begin VB.Label Label1 
      BackColor       =   &H00000000&
      Height          =   375
      Left            =   0
      TabIndex        =   9
      ToolTipText     =   "^_^"
      Top             =   0
      Width           =   495
   End
   Begin VB.Menu File 
      Caption         =   "Actions"
      Begin VB.Menu Check 
         Caption         =   "Check For New Email"
         Shortcut        =   ^C
      End
      Begin VB.Menu Reset 
         Caption         =   "Reset Chooser"
         Shortcut        =   ^R
      End
      Begin VB.Menu Edit 
         Caption         =   "Edit Emails"
         Shortcut        =   ^E
      End
      Begin VB.Menu Update 
         Caption         =   "Update Emails"
         Begin VB.Menu upOne 
            Caption         =   "One"
         End
         Begin VB.Menu upAll 
            Caption         =   "All"
         End
         Begin VB.Menu upCur 
            Caption         =   "Current"
         End
      End
      Begin VB.Menu AboutUp 
         Caption         =   "About"
         Shortcut        =   ^A
      End
   End
End
Attribute VB_Name = "SbEmailPlayer"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub About_Click()
Dim emailNum As Integer
emailNum = Chooser.ListIndex + 1
If optFile = True Then
emailFile (emailNum)
ElseIf optNet = True Then
If emailNum = 100 Then
SBEMAIL.Movie = "http://www.homestarrunner.com/emailahundred.swf"
Else
SBEMAIL.Movie = "http://www.homestarrunner.com/" & emailNum & ".swf"
End If
End If
If SBEMAIL.Movie = Null Then
MsgBox "Ok man, try making sure there's like an email there first. I can't play nothing man", vbOKOnly + vbCritical, "Strong Bad's Email Player"
Else
SBEMAIL.Visible = True
SBEMAIL.Play
End If
End Sub
Private Sub Aboutbutton_Click()
SBEMAIL.stop
About.Show
End Sub
Private Sub add_Click()
Dim inqir As Integer
Dim chooserStr As String
chooserStr = InputBox("Now Put In Some Crap That You Want Be In The Email Chooser", "Strong Bad's Email Player")
If (chooserStr = Empty) Then
MsgBox "Hey, Why Don't You Try Maybe Putting In Some Names And Crap?", vbOKOnly + vbExclamation, "Strong Bad's Email Player"
Else
inqir = MsgBox("Add This Email?", vbYesNo + vbQuestion, "Strong Bad's Email Player")
If inqir = 7 Then
MsgBox "Email Not Added", vbOKOnly + vbInformation, "Strong Bad's Email Player"
Else
Open "archive.dat" For Append As 1
Write #1, (chooserStr)
Close 1
MsgBox "Email Added Successfully", vbOKOnly + vbInformation, "Strong Bad's Email Player"
End If
End If
End Sub

Private Sub AboutUp_Click()
SBEMAIL.stop
About.Show
End Sub

Private Sub Check_Click()
saveNewEmail
If (Dir(App.Path & "\emails\sbemail" & Chooser.ListCount + 1 & ".sbe")) = "sbemail" & Chooser.ListCount + 1 & ".sbe" Then
SBEMAIL.Visible = True
SBEMAIL.Movie = (App.Path & "\emails\sbemail" & Chooser.ListCount + 1 & ".sbe")
SBEMAIL.Play
MsgBox "Please help an old wintergreen to add this re-male.", vbOKOnly, "Strong Bad's Email Player"
frmEdit.Show
Call frmEdit.addEmail_Click
Else
MsgBox "Strong Bad says no new email.", vbOKOnly + vbInformation, "Strong Bad's Email Player"
End If
End Sub

Private Sub Chooser_KeyPress(KeyAscii As Integer)
If KeyAscii = 13 Then
Dim emailNum As Integer
emailNum = Chooser.ListIndex + 1
If optFile = True Then
emailFile (emailNum)
ElseIf optNet = True Then
If Not emailNum = 100 Then
SBEMAIL.Movie = "http://www.homestarrunner.com/sbemail" & emailNum & ".swf"
SBEMAIL.Visible = True
SBEMAIL.Play
Else
SBEMAIL100.Movie = "http://www.homestarrunner.com/sbemailahundred.swf"
SBEMAIL100.Visible = True
SBEMAIL100.Play
End If
End If
If SBEMAIL.Movie = Null Then
MsgBox "Ok man, try making sure there's like an email there first. I can't play nothing man", vbOKOnly + vbCritical, "Strong Bad's Email Player"
End If
End If
End Sub

Private Sub Command1_Click()
Call stop_Click
frmEdit.Show
End Sub

Private Sub Command2_Click()
Call checkFirstRun
End Sub

Private Sub Edit_Click()
Call stop_Click
frmEdit.Show
End Sub

Private Sub Form_KeyPress(KeyAscii As Integer)
If KeyAscii = 37 Then
SBEMAIL.Rewind
ElseIf KeyAscii = 39 Then
SBEMAIL.Forward
End If
End Sub

Private Sub Form_Load()
Call prevInstance
If (Dir(App.Path & "\urn.dat")) = "urn.dat" Then
Call checkFirstRun
Else
getTheEmails.Visible = False
End If
SBEMAIL.Movie = Command
SBEMAIL100.Visible = False
SBEMAIL.Visible = False
optFile = True
Dim chooserCrnt As String
Dim chooserNum As Integer
On Error GoTo noFile
Open "archive.dat" For Input As 1
chooserNum = 0
Do While Not EOF(1)
chooserNum = chooserNum + 1
Input #1, chooserCrnt
Chooser.AddItem chooserNum & ". " & chooserCrnt
Loop
Close 1
Exit Sub
noFile:
    MsgBox "The application failed to load because file ""archive.dat"" was not found. Reinstalling the application may resolve this problem.", vbOKOnly + vbCritical, "Strong Bad's Email Player"
    End
End Sub

Private Sub getTheEmails_Click()
MsgBox "Oh NOW you want the emails. Well too bad, I'm not gonna download them.", vbOKOnly + vbCritical, "Strong Bad's Email Player"
MsgBox "Just kidding, nobody should be denied the greatness of the Strong Bad!", vbOKOnly, "Strong Bad's Email Player"
Call getAllEmails
getTheEmails.Visible = False
End Sub

Private Sub Label1_Click()
MsgBox "The password is ""hello there"" password is case sensitive no purchase neccessary void where prohibited see stores for details.", vbOKOnly + vbInformation, "Strong Bad's Email Player"
End Sub

Private Sub newEmail_Click()
saveNewEmail
If (Dir(App.Path & "\emails\sbemail" & Chooser.ListCount + 1 & ".sbe")) = "sbemail" & Chooser.ListCount + 1 & ".sbe" Then
SBEMAIL.Movie = "http://www.homestarrunner.com/sbemail" & Chooser.ListCount + 1 & ".swf"
SBEMAIL.Visible = True
SBEMAIL.Play
MsgBox "Please help an old wintergreen to add this re-male.", vbOKOnly, "Strong Bad's Email Player"
frmEdit.Show
Call frmEdit.addEmail_Click
Else
MsgBox "Strong Bad says no new email.", vbOKOnly + vbInformation, "Strong Bad's Email Player"
End If
End Sub

Private Sub Reset_Click()
Dim intTotal As Integer
intTotal = Chooser.ListCount
chooserClear (intTotal)
Call Form_Load
Chooser.Text = "TOTAL EMAILS MAN"
SBEMAIL.Visible = True
End Sub

Public Sub setChooser_Click()
Dim intTotal As Integer
intTotal = Chooser.ListCount
chooserClear (intTotal)
Call Form_Load
Chooser.Text = "TOTAL EMAILS MAN"
SBEMAIL.Visible = True
End Sub

Private Sub start_Click()
Dim emailNum As Integer
emailNum = Chooser.ListIndex + 1
If optFile = True Then
Call emailFile(emailNum)
ElseIf optNet = True Then
Call emailNet(emailNum)
End If
End Sub
Private Sub stop_Click()
If SBEMAIL100.Playing = True Then
SBEMAIL100.stop
ElseIf SBEMAIL.Playing = True Then
SBEMAIL.stop
End If
End Sub

Private Sub Timer1_Timer()
getTheEmails.Top = getTheEmails.Top + 1
End Sub

Private Sub upAll_Click()
Call updateAll
End Sub

Private Sub upCur_Click()
Call updateCurrent
End Sub

Private Sub upOne_Click()
Call updateSingle
End Sub
