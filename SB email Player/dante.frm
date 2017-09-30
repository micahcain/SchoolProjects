VERSION 5.00
Begin VB.Form dante 
   BorderStyle     =   0  'None
   Caption         =   "Form1"
   ClientHeight    =   5640
   ClientLeft      =   180
   ClientTop       =   4605
   ClientWidth     =   7050
   LinkTopic       =   "Form1"
   ScaleHeight     =   5640
   ScaleWidth      =   7050
   ShowInTaskbar   =   0   'False
   Begin VB.Image Image1 
      Height          =   5865
      Left            =   0
      Picture         =   "dante.frx":0000
      Stretch         =   -1  'True
      Top             =   0
      Width           =   7020
   End
End
Attribute VB_Name = "dante"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Image1_Click()
Unload Me
End Sub
Private Sub dante_click()
Unload Me
End Sub
