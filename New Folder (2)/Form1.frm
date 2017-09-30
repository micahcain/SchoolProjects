VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   3090
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3090
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "Command1"
      Height          =   615
      Left            =   840
      TabIndex        =   0
      Top             =   1080
      Width           =   1815
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'Author: Anonymous
'Author's email:
'Date Submitted: 1/1/1999
'Compatibility: VB 6,VB 5,VB 4/32

'Task: Make a form transparent

'Declarations
 Const GWL_EXSTYLE = (-20)
 Const WS_EX_TRANSPARENT = &H20&
 Const SWP_FRAMECHANGED = &H20
Const SWP_NOMOVE = &H2
 Const SWP_NOSIZE = &H1
 Const SWP_SHOWME = SWP_FRAMECHANGED Or _
SWP_NOMOVE Or SWP_NOSIZE
 Const HWND_NOTOPMOST = -2


Private Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hwnd As Long, ByVal nIndex As Long, ByVal dwNewLong As Long) As Long

Private Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Long, ByVal hWndInsertAfter As Long, ByVal x As Long, ByVal y As Long, ByVal cx As Long, ByVal cy As Long, ByVal wFlags As Long) As Long



Private Sub Command1_Click()
'Code:
SetWindowLong Me.hwnd, GWL_EXSTYLE, WS_EX_TRANSPARENT
SetWindowPos Me.hwnd, HWND_NOTOPMOST, 0&, 0&, 0&, 0&, SWP_SHOWME


End Sub
