VERSION 5.00
Begin VB.Form frmMain 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Picture Viewer"
   ClientHeight    =   6150
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   8295
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmMain.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6150
   ScaleWidth      =   8295
   StartUpPosition =   2  'CenterScreen
   Begin VB.ListBox lstFakeList 
      Height          =   450
      Left            =   10920
      TabIndex        =   19
      Top             =   2400
      Width           =   1215
   End
   Begin VB.ListBox lstFake 
      Height          =   450
      Left            =   9600
      TabIndex        =   18
      Top             =   2400
      Width           =   1215
   End
   Begin VB.Frame fraDirectory 
      Height          =   1215
      Left            =   0
      TabIndex        =   11
      Top             =   0
      Width           =   8295
      Begin VB.TextBox txtDirectory 
         Height          =   315
         Left            =   120
         Locked          =   -1  'True
         TabIndex        =   17
         Text            =   "C:\"
         Top             =   480
         Width           =   6735
      End
      Begin VB.CommandButton cmdBrowse 
         Caption         =   "Browse"
         Height          =   315
         Left            =   6960
         TabIndex        =   16
         Top             =   480
         Width           =   1215
      End
      Begin VB.CheckBox chkSubDirectory 
         Caption         =   "Check Subdirectories"
         Height          =   255
         Left            =   120
         TabIndex        =   15
         Top             =   840
         Width           =   1815
      End
      Begin VB.CheckBox chkJPEG 
         Caption         =   "JPEG"
         Height          =   255
         Left            =   2880
         TabIndex        =   14
         Top             =   840
         Width           =   735
      End
      Begin VB.CheckBox chkGIF 
         Caption         =   "GIF"
         Height          =   255
         Left            =   3720
         TabIndex        =   13
         Top             =   840
         Width           =   735
      End
      Begin VB.CheckBox chkBMP 
         Caption         =   "BMP"
         Height          =   255
         Left            =   4440
         TabIndex        =   12
         Top             =   840
         Width           =   735
      End
      Begin VB.Label lblDirectory 
         AutoSize        =   -1  'True
         Caption         =   "Directory"
         Height          =   195
         Left            =   120
         TabIndex        =   0
         Top             =   240
         Width           =   660
      End
   End
   Begin VB.Frame fraPicturePreview 
      Height          =   3615
      Left            =   4560
      TabIndex        =   10
      Top             =   1200
      Width           =   3735
      Begin VB.Image imgPicture 
         Height          =   3255
         Left            =   120
         Top             =   240
         Width           =   3495
      End
   End
   Begin VB.Frame fraFileInfo 
      Height          =   1335
      Left            =   4560
      TabIndex        =   3
      Top             =   4800
      Width           =   3735
      Begin VB.Label lblFileT 
         AutoSize        =   -1  'True
         Caption         =   "File Type -"
         Height          =   195
         Left            =   120
         TabIndex        =   9
         Top             =   240
         Width           =   750
      End
      Begin VB.Label lblFileD 
         AutoSize        =   -1  'True
         Caption         =   "File Dimensions -"
         Height          =   195
         Left            =   120
         TabIndex        =   8
         Top             =   720
         Width           =   1185
      End
      Begin VB.Label lblFileS 
         AutoSize        =   -1  'True
         Caption         =   "File Size -"
         Height          =   195
         Left            =   120
         TabIndex        =   7
         Top             =   960
         Width           =   675
      End
      Begin VB.Label lblFileT_Show 
         AutoSize        =   -1  'True
         Caption         =   "UnKnown"
         Height          =   195
         Left            =   1560
         TabIndex        =   6
         Top             =   240
         Width           =   675
      End
      Begin VB.Label lblFileD_Show 
         AutoSize        =   -1  'True
         Caption         =   "0x0"
         Height          =   195
         Left            =   1560
         TabIndex        =   5
         Top             =   720
         Width           =   270
      End
      Begin VB.Label lblFileS_Show 
         AutoSize        =   -1  'True
         Caption         =   "0 kB"
         Height          =   195
         Left            =   1560
         TabIndex        =   4
         Top             =   960
         Width           =   300
      End
      Begin VB.Image imgD 
         Height          =   255
         Left            =   2160
         Top             =   600
         Visible         =   0   'False
         Width           =   255
      End
   End
   Begin VB.Frame fraPictures 
      Height          =   4935
      Left            =   0
      TabIndex        =   1
      Top             =   1200
      Width           =   4455
      Begin VB.ListBox lstPictures 
         Height          =   4545
         Left            =   120
         TabIndex        =   2
         Top             =   240
         Width           =   4215
      End
   End
   Begin Project1.PictureDetails PD 
      Left            =   9600
      Top             =   1920
      _ExtentX        =   3175
      _ExtentY        =   503
   End
   Begin Project1.SFFF SFFF 
      Left            =   9600
      Top             =   1680
      _ExtentX        =   4075
      _ExtentY        =   503
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim BMPImages As Boolean, GIFImages As Boolean, JPGImages As Boolean

Private Sub chkBMP_Click()
    If chkBMP.Value = 1 Then
        BMPImages = True
    Else
        BMPImages = False
    End If
    CheckPicture
End Sub

Private Sub chkGIF_Click()
    If chkGIF.Value = 1 Then
        GIFImages = True
    Else
        GIFImages = False
    End If
    CheckPicture
End Sub

Private Sub chkJPEG_Click()
    If chkJPEG.Value = 1 Then
        JPGImages = True
    Else
        JPGImages = False
    End If
    CheckPicture
End Sub

Private Sub chkSubDirectory_Click()
    If chkSubDirectory.Value = 1 Then
        SFFF.CheckSubDirectory = True
    Else
        SFFF.CheckSubDirectory = False
    End If
End Sub

Private Sub cmdBrowse_Click()
    frmFolder.Show 1, Me
End Sub

Private Sub Form_Load()
On Error GoTo ErrHandler
    LoadData

    If txtDirectory.Text = Empty Then GoTo ErrHandler
    Exit Sub

ErrHandler:
    'Had To Add This Here, cause Hotmails anti-virus says the file
    'pictureviewer creates is a virus. Very annoying, if you think
    'that it could be a virus, the read the SaveData and LoadData
    'sections at the bottom of this form/module.
    txtDirectory.Text = "C:\"
End Sub

Private Sub Form_Unload(Cancel As Integer)
    SaveData
End Sub

Private Sub lstPictures_Click()
Dim I As Integer, qI As Integer

    For I = 0 To lstPictures.ListCount - 1
        If lstPictures.Selected(I) = True Then
            qI = lstFakeList.List(I)
            ViewPicture SFFF.FileName(qI + 1), SFFF.FileDirectory(qI + 1)
            Exit For
        End If
    Next I
End Sub

Private Sub ViewPicture(qFile As String, qPath As String)
    imgPicture.Stretch = False
    imgPicture.Picture = LoadPicture(qPath & qFile)
    If imgPicture.Width > 3495 Then
        imgPicture.Stretch = True
        imgPicture.Width = 3495
    End If
    If imgPicture.Height > 3255 Then
        imgPicture.Stretch = True
        imgPicture.Height = 3255
    End If

    imgPicture.Left = ((3615 / 2) - (imgPicture.Width / 2)) + 60
    imgPicture.Top = ((3495 / 2) - (imgPicture.Height / 2)) + 120

    PD.PictureName = qFile
    PD.PictureDirectory = qPath

    lblFileT_Show.Caption = PD.Format
    lblFileS_Show.Caption = PD.Size & " KB"
    lblFileD_Show.Caption = PD.Dimension_Width & "x" & PD.Dimension_Height
End Sub

Public Sub CheckDirectory(sDirectory As String)
Dim I As Integer

    txtDirectory.Text = sDirectory
    lstFake.Clear

    SFFF.BasePath = sDirectory
    If SFFF.TotalFiles = 0 Then Exit Sub

    For I = 1 To SFFF.TotalFiles
        lstFake.AddItem SFFF.FileName(I)
        DoEvents
        DoEvents
    Next I

    CheckPicture
End Sub

Public Sub CheckPicture()
Dim I As Integer

    lstPictures.Clear
    lstFakeList.Clear
    For I = 0 To lstFake.ListCount - 1
        If BMPImages = True And Right(UCase(lstFake.List(I)), 4) = ".BMP" Then
            lstPictures.AddItem lstFake.List(I)
            lstFakeList.AddItem I
        ElseIf GIFImages = True And Right(UCase(lstFake.List(I)), 4) = ".GIF" Then
            lstPictures.AddItem lstFake.List(I)
            lstFakeList.AddItem I
        ElseIf JPGImages = True And (Right(UCase(lstFake.List(I)), 4) = ".JPG" Or Right(UCase(lstFake.List(I)), 5) = ".JPEG") Then
            lstPictures.AddItem lstFake.List(I)
            lstFakeList.AddItem I
        End If
    Next I
End Sub



Private Sub SaveData()
Dim FF As Integer, sData As String
    FF = FreeFile

    Open App.Path & "\Data.Bin" For Random As FF
    sData = txtDirectory.Text
    Put #FF, 1, sData
    If chkSubDirectory.Value = 1 Then sData = "T" Else sData = "F"
    Put #FF, 2, sData
    If chkBMP.Value = 1 Then sData = "T" Else sData = "F"
    Put #FF, 3, sData
    If chkGIF.Value = 1 Then sData = "T" Else sData = "F"
    Put #FF, 4, sData
    If chkJPEG.Value = 1 Then sData = "T" Else sData = "F"
    Put #FF, 5, sData
End Sub

Private Sub LoadData()
Dim FF As Integer, sData As String
    FF = FreeFile

    Open App.Path & "\Data.Bin" For Random As FF
    Get #FF, 1, sData
    txtDirectory.Text = sData
    Get #FF, 2, sData
    If sData = "T" Then chkSubDirectory.Value = 1 Else chkSubDirectory.Value = 0
    Get #FF, 3, sData
    If sData = "T" Then chkBMP.Value = 1 Else chkBMP.Value = 0
    Get #FF, 4, sData
    If sData = "T" Then chkGIF.Value = 1 Else chkGIF.Value = 0
    Get #FF, 5, sData
    If sData = "T" Then chkJPEG.Value = 1 Else chkJPEG.Value = 0
    Close FF
End Sub
