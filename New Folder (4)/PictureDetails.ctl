VERSION 5.00
Begin VB.UserControl PictureDetails 
   ClientHeight    =   7380
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   7260
   InvisibleAtRuntime=   -1  'True
   ScaleHeight     =   7380
   ScaleWidth      =   7260
   Begin VB.Label lblCaption 
      AutoSize        =   -1  'True
      Caption         =   "Picture Details"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   1800
   End
   Begin VB.Image imgD 
      Height          =   375
      Left            =   4800
      Top             =   4800
      Visible         =   0   'False
      Width           =   375
   End
End
Attribute VB_Name = "PictureDetails"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Dim FileName As String
Dim FileDirectory As String

Public Property Let PictureName(vData As String)
    FileName = vData
End Property

Public Property Get PictureName() As String
    PictureName = FileName
End Property

Public Property Let PictureDirectory(vData As String)
    FileDirectory = vData
End Property

Public Property Get PictureDirectory() As String
    PictureDirectory = FileDirectory
End Property


Public Property Get Format() As String
On Error GoTo ErrHandler

    If Right(UCase(FileName), 4) = ".JPG" Or Right(UCase(FileName), 5) = ".JPEG" Then
        Format = "JPEG"
    ElseIf Right(UCase(FileName), 4) = ".BMP" Then
        Format = "Bitmap"
    ElseIf Right(UCase(FileName), 4) = ".GIF" Then
        Format = "GIF"
    Else
        Format = "UnKnown"
    End If
    Exit Property

ErrHandler:
    Format = "ERROR"
End Property

Public Property Get Dimension_Width() As Integer
On Error GoTo ErrHandler

    imgD.Picture = LoadPicture(FileDirectory & FileName)
    Dimension_Width = imgD.Width / 15
    Exit Property

ErrHandler:
    Dimension_Width = 0
End Property

Public Property Get Dimension_Height() As Integer
On Error GoTo ErrHandler

    imgD.Picture = LoadPicture(FileDirectory & FileName)
    Dimension_Height = imgD.Height / 15
    Exit Property

ErrHandler:
    Dimension_Height = 0
End Property

Public Property Get Size() As Integer
On Error GoTo ErrHandler

    Size = Int(FileLen(FileDirectory & FileName) / 1024)
    Exit Property

ErrHandler:
    Size = 0
End Property

Private Sub UserControl_Resize()
    UserControl.Width = lblCaption.Width
    UserControl.Height = lblCaption.Height
End Sub
