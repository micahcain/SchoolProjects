VERSION 5.00
Begin VB.Form frmFolder 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Browse"
   ClientHeight    =   5700
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   3480
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmFolder.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5700
   ScaleWidth      =   3480
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   Begin VB.DriveListBox drvFolder 
      Height          =   315
      Left            =   0
      TabIndex        =   3
      Top             =   0
      Width           =   3495
   End
   Begin VB.DirListBox dirFolder 
      Height          =   4815
      Left            =   0
      TabIndex        =   2
      Top             =   360
      Width           =   3495
   End
   Begin VB.CommandButton cmdOk 
      Caption         =   "Ok"
      Height          =   375
      Left            =   480
      TabIndex        =   1
      Top             =   5280
      Width           =   1215
   End
   Begin VB.CommandButton cmdCancel 
      Caption         =   "Cancel"
      Height          =   375
      Left            =   1800
      TabIndex        =   0
      Top             =   5280
      Width           =   1215
   End
End
Attribute VB_Name = "frmFolder"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdCancel_Click()
    Unload Me
End Sub

Private Sub cmdOk_Click()
Dim qFolder As String
    qFolder = dirFolder.Path

    frmMain.CheckDirectory qFolder
    Unload Me
End Sub

Private Sub drvFolder_Change()
    dirFolder.Path = drvFolder.Drive
End Sub

Private Sub Form_Load()
Dim I As Integer

    drvFolder.Drive = Mid(frmMain.txtDirectory.Text, 1, 3)
    If Right(frmMain.txtDirectory.Text, 1) <> "\" Then
        dirFolder.Path = frmMain.txtDirectory.Text & "\"
    Else
        dirFolder.Path = frmMain.txtDirectory.Text
    End If
End Sub

