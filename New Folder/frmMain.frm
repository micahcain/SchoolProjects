VERSION 5.00
Object = "{F69B97A5-881D-4BE3-9E17-9822F6DA9683}#8.0#0"; "Transparenter.ocx"
Begin VB.Form Form1 
   BackColor       =   &H00800000&
   BorderStyle     =   0  'None
   Caption         =   "Transparenter Example"
   ClientHeight    =   5820
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   9480
   LinkTopic       =   "Form1"
   ScaleHeight     =   5820
   ScaleWidth      =   9480
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin FormTransparenter®.FormTransparenter FormTransparenter1 
      Left            =   4185
      Top             =   450
      _ExtentX        =   900
      _ExtentY        =   900
   End
   Begin VB.CommandButton Command2 
      BackColor       =   &H001E3557&
      Caption         =   "Computer"
      Height          =   285
      Left            =   3285
      Style           =   1  'Graphical
      TabIndex        =   6
      ToolTipText     =   "This is a tooltiptext"
      Top             =   4275
      Width           =   960
   End
   Begin VB.CheckBox chkOntop 
      BackColor       =   &H00800000&
      Caption         =   "Always on top"
      ForeColor       =   &H0000FF00&
      Height          =   240
      Left            =   180
      TabIndex        =   5
      Top             =   4320
      Width           =   1365
   End
   Begin VB.CommandButton cmdUnhideForm 
      Caption         =   "UnhideForm"
      Height          =   465
      Left            =   7560
      TabIndex        =   4
      Top             =   5085
      Width           =   1770
   End
   Begin VB.CommandButton cmdShowColorWithConrols 
      Caption         =   "ShowColorWithConrols"
      Height          =   465
      Left            =   5715
      TabIndex        =   3
      Top             =   5085
      Width           =   1770
   End
   Begin VB.CommandButton cmdShowColor 
      Caption         =   "ShowColor"
      Height          =   465
      Left            =   3870
      TabIndex        =   2
      Top             =   5085
      Width           =   1770
   End
   Begin VB.CommandButton cmdHideFormWithControls 
      Caption         =   "HideFormWithControls"
      Height          =   465
      Left            =   2025
      TabIndex        =   1
      Top             =   5085
      Width           =   1770
   End
   Begin VB.CommandButton cmdHideForm 
      Caption         =   "HideForm"
      Height          =   465
      Left            =   180
      TabIndex        =   0
      Top             =   5085
      Width           =   1770
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   $"frmMain.frx":0000
      ForeColor       =   &H00C00000&
      Height          =   510
      Left            =   225
      TabIndex        =   7
      Top             =   135
      Width           =   9030
   End
   Begin VB.Shape Moon 
      BackColor       =   &H0080FF80&
      BackStyle       =   1  'Opaque
      Height          =   1005
      Left            =   7920
      Shape           =   3  'Circle
      Top             =   765
      Width           =   1140
   End
   Begin VB.Image Image3 
      Height          =   750
      Left            =   3600
      Picture         =   "frmMain.frx":00A5
      Top             =   3015
      Width           =   1800
   End
   Begin VB.Image Image2 
      Height          =   3600
      Left            =   2295
      Picture         =   "frmMain.frx":A4CE
      Top             =   1740
      Width           =   4800
   End
   Begin VB.Image Image1 
      Height          =   1245
      Left            =   1710
      Picture         =   "frmMain.frx":D0FF
      Top             =   1305
      Width           =   5925
   End
   Begin VB.Shape Shape1 
      BackColor       =   &H0080FF80&
      BackStyle       =   1  'Opaque
      Height          =   870
      Left            =   45
      Shape           =   4  'Rounded Rectangle
      Top             =   4860
      Width           =   9375
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub chkOntop_Click()
FormTransparenter1.AlwaysOnTop = chkOntop.Value
End Sub

Private Sub cmdHideForm_Click()
FormTransparenter1.HideForm (Me.hWnd)
End Sub

Private Sub cmdHideFormWithControls_Click()
FormTransparenter1.HideFormWithControls (Me.hWnd)
End Sub

Private Sub cmdShowColor_Click()
FormTransparenter1.ShowColor Me.hWnd, Moon.BackColor
End Sub

Private Sub cmdShowColorWithConrols_Click()
FormTransparenter1.ShowColorWithControls Me.hWnd, Moon.BackColor
End Sub

Private Sub cmdUnhideForm_Click()
FormTransparenter1.UnhideForm (Me.hWnd)
End Sub
