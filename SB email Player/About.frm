VERSION 5.00
Begin VB.Form About 
   Caption         =   "About Strong Bad's Email Player"
   ClientHeight    =   8880
   ClientLeft      =   4065
   ClientTop       =   375
   ClientWidth     =   8325
   ControlBox      =   0   'False
   Icon            =   "About.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Moveable        =   0   'False
   ScaleHeight     =   8880
   ScaleWidth      =   8325
   Begin VB.CommandButton back 
      Caption         =   "B&ACK"
      Height          =   975
      Left            =   3240
      TabIndex        =   0
      Top             =   7560
      Width           =   1575
   End
   Begin VB.Image Image2 
      BorderStyle     =   1  'Fixed Single
      Height          =   3015
      Left            =   360
      Picture         =   "About.frx":628A
      Stretch         =   -1  'True
      ToolTipText     =   "Micah"
      Top             =   4320
      Width           =   3615
   End
   Begin VB.Image Image1 
      BorderStyle     =   1  'Fixed Single
      Height          =   2925
      Left            =   4440
      Picture         =   "About.frx":AEA0
      Stretch         =   -1  'True
      ToolTipText     =   "The Brothers Chaps"
      Top             =   4320
      Width           =   3600
   End
   Begin VB.Label Label2 
      BorderStyle     =   1  'Fixed Single
      Height          =   2655
      Left            =   2160
      TabIndex        =   2
      ToolTipText     =   "There may or may not be an easter egg LEFT. You just have to stay on TOP of things."
      Top             =   960
      Width           =   3735
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Strong Bad's Email Player"
      Height          =   375
      Left            =   1200
      TabIndex        =   1
      Top             =   120
      Width           =   5655
   End
End
Attribute VB_Name = "About"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub back_Click()
SbEmailPlayer.SBEMAIL.Play
Unload Me
End Sub

Private Sub Bioflame_Click()
bio.Show
End Sub

Private Sub dantesrage_Click()
dante.Show
End Sub

Private Sub Command1_Click()
dante.Show
End Sub

Private Sub Form_Load()
Label2.Caption = "Thank you for using Strong Bad's Email Player. As a long time fan of the site, I thought I would make this software as a kind of tribute to the legacy. Most of the credit for this software belongs to the Chapman brothers themselves. It's true, the code is mine, but the inspiration comes from Mike, Matt, and of course Strong Bad himself. I hope you have as much fun using this software as I had making it. If you have any questions, email me @ cain.micah@gmail.com, and as allways, keep emailing Strong Bad."
End Sub

Private Sub Label3_Click()

End Sub
