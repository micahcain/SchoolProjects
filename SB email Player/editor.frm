VERSION 5.00
Begin VB.Form frmEdit 
   Caption         =   "Email Editor"
   ClientHeight    =   7170
   ClientLeft      =   11535
   ClientTop       =   1170
   ClientWidth     =   2880
   Icon            =   "editor.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   7170
   ScaleWidth      =   2880
   Begin VB.CheckBox Check3 
      Caption         =   "Check1"
      Enabled         =   0   'False
      Height          =   255
      Left            =   2520
      TabIndex        =   11
      Top             =   6000
      Width           =   255
   End
   Begin VB.CheckBox Check2 
      Caption         =   "Check1"
      Enabled         =   0   'False
      Height          =   255
      Left            =   2520
      TabIndex        =   10
      Top             =   5640
      Width           =   255
   End
   Begin VB.CheckBox Check1 
      Caption         =   "Check1"
      Enabled         =   0   'False
      Height          =   255
      Left            =   2520
      TabIndex        =   9
      Top             =   5280
      Width           =   255
   End
   Begin VB.Frame secretThing 
      Caption         =   "Maybe A Secret"
      Height          =   735
      Left            =   240
      TabIndex        =   5
      Top             =   5160
      Width           =   2175
      Begin VB.OptionButton secret3 
         Caption         =   "Option1"
         Height          =   375
         Left            =   1800
         TabIndex        =   8
         Top             =   240
         Width           =   255
      End
      Begin VB.OptionButton secret2 
         Caption         =   "Option1"
         Height          =   375
         Left            =   960
         TabIndex        =   7
         Top             =   240
         Width           =   255
      End
      Begin VB.OptionButton secret1 
         Caption         =   "Option1"
         Height          =   375
         Left            =   120
         TabIndex        =   6
         Top             =   240
         Width           =   255
      End
   End
   Begin VB.CommandButton addEmail 
      Caption         =   "Add"
      Height          =   495
      Left            =   960
      TabIndex        =   3
      Top             =   3840
      Width           =   855
   End
   Begin VB.CommandButton editEmail 
      Caption         =   "Edit"
      Height          =   495
      Left            =   0
      TabIndex        =   2
      Top             =   3840
      Width           =   855
   End
   Begin VB.CommandButton saveEmails 
      Caption         =   "Save"
      Height          =   495
      Left            =   1920
      TabIndex        =   1
      Top             =   3840
      Width           =   855
   End
   Begin VB.ListBox emailEditor 
      Height          =   3375
      ItemData        =   "editor.frx":628A
      Left            =   120
      List            =   "editor.frx":628C
      TabIndex        =   0
      Top             =   240
      Width           =   2655
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      Height          =   495
      Left            =   600
      TabIndex        =   4
      Top             =   6120
      Width           =   1575
   End
End
Attribute VB_Name = "frmEdit"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public Sub addEmail_Click()
Dim addEmail As String
addEmail = InputBox("Type the new email name here", "Strong Bad's Email Player")
emailEditor.AddItem (addEmail)
End Sub
Private Sub delEmail_Click()
Dim emailSelected As Integer
emailSelected = emailEditor.ListIndex
Dim delOrNot As Integer
delOrNot = MsgBox("Are You Sure You Want To Delete This Email?", vbOKCancel + vbQuestion, "Strong Bad's Email Player")
If delOrNot = 1 Then
emailEditor.RemoveItem (emailSelected)
emailEditor.AddItem "", emailSelected
End If
End Sub
Public Sub editEmail_Click()
If emailEditor.Text = "" Then
MsgBox "You know, sometimes it helps to actualy select something before you try to edit it", vbOKOnly + vbCritical, "Strong Bad's Email Player"
Else
emailEditor.DataChanged = True
Dim newName As String
Dim editNum As Integer
editNum = emailEditor.ListIndex
newName = InputBox("Fine then, change the name. See if I care.", "Strong Bad's Email Player.")
If newName = "hello there" Then
secretThing.Visible = True
Check1.Visible = True
Check2.Visible = True
Check3.Visible = True
Else
If newName = "" Then
MsgBox "Strong Bad wouldn't like you tryin to name his emails nothing.", vbOKOnly, "Strong Bad's Email Player"
Else
emailEditor.RemoveItem editNum
emailEditor.AddItem newName, editNum
End If
End If
End If
End Sub

Private Sub Form_Load()
secretThing.Visible = False
Check1.Visible = False
Check2.Visible = False
Check3.Visible = False
Dim editCrnt As String
Dim editNum As Integer
Open "archive.dat" For Input As 1
chooserNum = 0
Do While Not EOF(1)
editNum = editNum + 1
Input #1, editCrnt
emailEditor.AddItem editCrnt
Loop
Close 1
End Sub

Private Sub saveEmails_Click()
Dim wannaSave As Integer
wannaSave = MsgBox("Look man, do you really wanna do this?", vbOKCancel + vbQuestion, "Strong Bad's Email Player")
If wannaSave = 1 Then
Dim writeNum As Integer
writeNum = 0
Open "archive.dat" For Output As 1
Do Until writeNum = emailEditor.ListCount
Print #1, emailEditor.List(writeNum)
writeNum = writeNum + 1
Loop
Close 1
Call SbEmailPlayer.setChooser_Click
Unload frmEdit
Else
MsgBox "Fine Then", vbOKOnly, "Strong Bad's Email Player"
End If
End Sub

Private Sub secret1_Click()
If Check1.Value = 1 Then
Check2.Value = 1
Else
Check1.Value = 0
End If
End Sub

Private Sub secret2_Click()
If Check1.Value = 1 And Check2.Value = 1 Then
Check3.Value = 1
Label1.Caption = "YOU'VE FOUND THE HIDDEN SECRET!!!!"
Else
Check1.Value = 0
Check2.Value = 0
End If
End Sub

Private Sub secret3_Click()
If Check1.Value = 1 And Check2.Value = 1 And Check3.Value = 1 Then
Check1.Value = 0
Check2.Value = 0
Check3.Value = 0
Label1.Caption = ""
End If
Check1.Value = 1
End Sub

