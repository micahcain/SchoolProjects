VERSION 5.00
Begin VB.Form frmTranspForm 
   BackColor       =   &H00C0C0C0&
   BorderStyle     =   1  'Fixed Single
   ClientHeight    =   4650
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   6765
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   310
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   451
   Begin VB.CommandButton Command2 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Frame"
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
      Left            =   840
      Style           =   1  'Graphical
      TabIndex        =   5
      ToolTipText     =   "Toggle displaying form frame"
      Top             =   3990
      Width           =   945
   End
   Begin VB.CommandButton Command0 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Transparent form"
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
      Left            =   420
      TabIndex        =   4
      Top             =   240
      Width           =   5895
   End
   Begin VB.CommandButton Command3 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Shape 2"
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
      Index           =   0
      Left            =   3270
      Style           =   1  'Graphical
      TabIndex        =   3
      ToolTipText     =   "Show a shaped child form - Eclliptic"
      Top             =   3990
      Width           =   945
   End
   Begin VB.CommandButton Command3 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Shape 1"
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
      Index           =   1
      Left            =   2250
      Style           =   1  'Graphical
      TabIndex        =   2
      ToolTipText     =   "Show a shaped child form - Rectangle with rounded corners"
      Top             =   3990
      Width           =   945
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
      Left            =   4680
      Style           =   1  'Graphical
      TabIndex        =   0
      Top             =   3990
      Width           =   945
   End
   Begin VB.TextBox Text1 
      BackColor       =   &H00E0E0E0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2895
      Left            =   390
      MultiLine       =   -1  'True
      TabIndex        =   1
      Text            =   "TranspForm.frx":0000
      Top             =   810
      Width           =   5925
   End
End
Attribute VB_Name = "frmTranspForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' TranspForm.frm
'
' By Herman Liu

Option Explicit
Dim withFrameFlag As Boolean
Dim mFormRegion As Long


Private Sub Form_Load()
    Me.ScaleMode = vbPixels
    Text1.Text = "You only see the header, this textbox and the" & vbCrLf & _
       "command buttons; so you can tell that the form" & vbCrLf & _
       "is transparent. (If you still want to make sure," & vbCrLf & _
       "drag the header - the only place to drag this" & vbCrLf & _
       "transparent form if without frame)" & vbCrLf & vbCrLf & _
       "Try Frame and Shape buttons to toggle frame" & vbCrLf & _
       "and to display shaped forms respectively."
    withFrameFlag = True
    toggleFrame withFrameFlag
End Sub
    
    
    
Private Sub toggleFrame(inFlag As Boolean)
    Dim w As Single, h As Single
    Dim edge As Single, topEdge As Single
    Dim mLeft, mTop
    Dim i As Integer
    Dim r As Long
    Dim outer As Long, inner As Long
    
    mFormRegion = CreateRectRgn(0, 0, 0, 0)
       ' Put width/height in same denomination of scalewidth/scaleheight
    w = ScaleX(Width, vbTwips, vbPixels)
    h = ScaleY(Height, vbTwips, vbPixels)
       ' Frame edges measurement
    edge = (w - ScaleWidth) / 2
    topEdge = h - edge - ScaleHeight
       ' Get frame
    If inFlag Then
        outer = CreateRectRgn(0, 0, w, h)
        inner = CreateRectRgn(edge, topEdge, w - edge, h - edge)
        CombineRgn mFormRegion, outer, inner, RGN_DIFF
    End If
       ' Combine regions of controls on form
    For i = 0 To Me.Controls.Count - 1
        mLeft = ScaleX(Me.Controls(i).Left, Me.ScaleMode, vbPixels) + edge
        mTop = ScaleX(Me.Controls(i).Top, Me.ScaleMode, vbPixels) + topEdge
        r = CreateRectRgn(mLeft, mTop, _
             ScaleX((Me.Controls(i).Width), Me.ScaleMode, vbPixels) + mLeft, _
             ScaleY((Me.Controls(i).Height), Me.ScaleMode, vbPixels) + mTop)
        CombineRgn mFormRegion, r, mFormRegion, RGN_OR
    Next
       ' We allow toggle
    SetWindowRgn hwnd, mFormRegion, True
End Sub


Private Sub Command1_Click()
    End
End Sub


Private Sub command2_Click()
    withFrameFlag = Not withFrameFlag
    toggleFrame withFrameFlag
End Sub


Private Sub command3_Click(Index As Integer)
    mShape = Index
    UnloadIfExist "frmShapedForm"
    frmShapedForm.Show
End Sub


Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
    SetWindowRgn hwnd, 0, False
    DeleteObject mFormRegion
End Sub


' Unlike frmShapedForm, since frmTransparent is transparent, we have to
' provide a place for user to drag if without frame, so Command0 is used.
Private Sub Command0_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    If Button <> vbLeftButton Then
         Exit Sub
    End If
    ReleaseCapture
    SendMessage Me.hwnd, WM_NCLBUTTONDOWN, HTCAPTION, 0&
End Sub

