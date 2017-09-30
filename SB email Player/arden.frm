VERSION 5.00
Begin VB.Form arden 
   BorderStyle     =   0  'None
   Caption         =   "Form1"
   ClientHeight    =   4485
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   3555
   LinkTopic       =   "Form1"
   ScaleHeight     =   4485
   ScaleWidth      =   3555
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.Image Image1 
      Height          =   4500
      Left            =   0
      Picture         =   "arden.frx":0000
      Top             =   0
      Width           =   3570
   End
End
Attribute VB_Name = "arden"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Image1_Click()
Unload Me
End Sub
