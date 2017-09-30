VERSION 5.00
Begin VB.Form frmSplash 
   BackColor       =   &H00000000&
   BorderStyle     =   0  'None
   ClientHeight    =   6810
   ClientLeft      =   210
   ClientTop       =   1365
   ClientWidth     =   9465
   ClipControls    =   0   'False
   ControlBox      =   0   'False
   Icon            =   "frmSplash.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Moveable        =   0   'False
   ScaleHeight     =   6810
   ScaleWidth      =   9465
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.Timer Timer1 
      Interval        =   5000
      Left            =   120
      Top             =   6360
   End
   Begin VB.Label Label2 
      BackColor       =   &H00000000&
      Caption         =   "   EMAIL PLAYER"
      BeginProperty Font 
         Name            =   "Unreal Tournament"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   2415
      Left            =   7320
      TabIndex        =   1
      Top             =   3960
      Width           =   1695
   End
   Begin VB.Label Label1 
      BackColor       =   &H00000000&
      Caption         =   " STRONG BAD'S"
      BeginProperty Font 
         Name            =   "Unreal Tournament"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   2415
      Left            =   360
      TabIndex        =   0
      Top             =   3960
      Width           =   1695
   End
   Begin VB.Image Image3 
      Height          =   3855
      Left            =   2280
      Picture         =   "frmSplash.frx":000C
      Stretch         =   -1  'True
      Top             =   2880
      Width           =   4815
   End
   Begin VB.Image Image2 
      Height          =   3855
      Left            =   4680
      Picture         =   "frmSplash.frx":D23EA
      Stretch         =   -1  'True
      Top             =   0
      Width           =   4815
   End
   Begin VB.Image Image1 
      Height          =   3855
      Left            =   0
      Picture         =   "frmSplash.frx":1A4074
      Stretch         =   -1  'True
      Top             =   0
      Width           =   4455
   End
End
Attribute VB_Name = "frmSplash"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False



Private Sub Timer1_Timer()
SbEmailPlayer.Show
Unload Me
End Sub
