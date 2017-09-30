VERSION 5.00
Begin VB.Form frmShapedForm 
   BorderStyle     =   0  'None
   ClientHeight    =   4635
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   5790
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   ScaleHeight     =   4635
   ScaleWidth      =   5790
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command0 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Shaped form"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   840
      TabIndex        =   2
      Top             =   840
      Width           =   3945
   End
   Begin VB.TextBox Text1 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2085
      Left            =   840
      MultiLine       =   -1  'True
      TabIndex        =   1
      Text            =   "ShapedForm.frx":0000
      Top             =   1380
      Width           =   3945
   End
   Begin VB.CommandButton Command1 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Exit"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   345
      Left            =   2370
      Style           =   1  'Graphical
      TabIndex        =   0
      Top             =   3630
      Width           =   945
   End
End
Attribute VB_Name = "frmShapedForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' ShapedForm.frm
'
' By Herman Liu

Option Explicit
Dim mChildFormRegion As Long



Private Sub Form_Load()
    Dim i, j
    
    Me.WindowState = vbNormal
    Me.Text1.Text = "A demonstration of a shaped form." & vbCrLf & _
       "Unlike transparent form, you can" & vbCrLf & _
       "now drag on the visible parts of the" & vbCrLf & _
       "shaped form."
    
      
    If mShape = 1 Then
          '  Respectively (x,y) upperleft, (x,y) lowerright, ellipse height, ellipsewidth
        mChildFormRegion = CreateRoundRectRgn(0, 0, Me.Width / xp, Me.Height / yp, 40, 40)
    Else
        mChildFormRegion = CreateEllipticRgn(0, 0, Me.Width / xp, Me.Height / yp)
    End If
    
    SetWindowRgn Me.hwnd, mChildFormRegion, False
End Sub


Private Sub Command1_Click()
    Unload Me
End Sub



Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
    SetWindowRgn Me.hwnd, 0, False
    DeleteObject mChildFormRegion
End Sub



' Unlike frmTransparent, the frmShapedForm is not transparent, we can
' drag the form itself without relying on the presence of Command0.
Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    If Button <> vbLeftButton Then
         Exit Sub
    End If
    ReleaseCapture
    SendMessage Me.hwnd, WM_NCLBUTTONDOWN, HTCAPTION, 0&
End Sub



Private Sub Command0_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    If Button <> vbLeftButton Then
         Exit Sub
    End If
    ReleaseCapture
    SendMessage Me.hwnd, WM_NCLBUTTONDOWN, HTCAPTION, 0&
End Sub

