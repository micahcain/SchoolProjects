VERSION 5.00
Begin VB.Form AddEmail 
   Caption         =   "Add an Email"
   ClientHeight    =   1425
   ClientLeft      =   5370
   ClientTop       =   4125
   ClientWidth     =   7020
   ControlBox      =   0   'False
   Icon            =   "Email Player.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   ScaleHeight     =   1425
   ScaleWidth      =   7020
   ShowInTaskbar   =   0   'False
   Begin VB.CommandButton addemail 
      Caption         =   "Add Email"
      Height          =   495
      Left            =   1920
      TabIndex        =   2
      Top             =   840
      Width           =   2655
   End
   Begin VB.TextBox chosername 
      Height          =   375
      Left            =   3480
      TabIndex        =   1
      Top             =   240
      Width           =   2175
   End
   Begin VB.TextBox filename 
      Height          =   375
      Left            =   600
      TabIndex        =   0
      Top             =   240
      Width           =   2175
   End
End
Attribute VB_Name = "AddEmail"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub addemail_Click()
Dim outFile As Integer
outFile = FreeFile
Open "emails.sbe" For Append As outFile
Dim addAnother As Integer
If (filename.Text & chosername.Text) = "" Then
MsgBox "Please Enter An Email To Add", vbOKOnly + vbExclamation, "It's Like The Crap In Your Brains Has Crap For Brains"
Else
Write #outFile, filename.Text & "/" & chosername.Text
filename.Text = ""
chosername.Text = ""
MsgBox "Email Successfully Added", vbOKOnly, "Strong Bad's Email Player"
addAnother = MsgBox("Add Another Email", vbYesNo + vbQuestion + vbDefaultButton1, "Strong Bad's Email Player")
If addAnother = 7 Then
Close outFile
End If
Unload Me
End If
End Sub

