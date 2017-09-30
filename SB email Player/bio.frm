VERSION 5.00
Begin VB.Form bio 
   BorderStyle     =   0  'None
   Caption         =   "Form1"
   ClientHeight    =   5970
   ClientLeft      =   8430
   ClientTop       =   4605
   ClientWidth     =   6360
   LinkTopic       =   "Form1"
   ScaleHeight     =   5970
   ScaleWidth      =   6360
   ShowInTaskbar   =   0   'False
   Begin VB.Image Image1 
      Height          =   6000
      Left            =   0
      Picture         =   "bio.frx":0000
      Stretch         =   -1  'True
      Top             =   0
      Width           =   6360
   End
End
Attribute VB_Name = "bio"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Image1_Click()
Unload Me
End Sub
Private Sub bio_click()
Unload Me
End Sub
