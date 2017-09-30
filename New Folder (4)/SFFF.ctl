VERSION 5.00
Begin VB.UserControl SFFF 
   ClientHeight    =   300
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   2370
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   InvisibleAtRuntime=   -1  'True
   ScaleHeight     =   300
   ScaleWidth      =   2370
   Begin VB.FileListBox filFolder 
      Height          =   480
      Left            =   8160
      TabIndex        =   3
      Top             =   3360
      Width           =   1215
   End
   Begin VB.DirListBox dirFolder 
      Height          =   315
      Left            =   8160
      TabIndex        =   2
      Top             =   3000
      Width           =   1215
   End
   Begin VB.ListBox lstFakeDir 
      Height          =   450
      Left            =   8160
      TabIndex        =   1
      Top             =   2520
      Width           =   1215
   End
   Begin VB.ListBox lstFake 
      Height          =   450
      Left            =   8160
      TabIndex        =   0
      Top             =   2040
      Width           =   1215
   End
   Begin VB.Label lblCaption 
      AutoSize        =   -1  'True
      Caption         =   "SubFolder File Find"
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
      TabIndex        =   4
      Top             =   0
      Width           =   2310
   End
End
Attribute VB_Name = "SFFF"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'SubFolder File Search
'=====================

Dim FolderDirectory As String
Dim FilesFound As Integer
Dim CheckSubDirectories As Boolean

Public Property Get BasePath() As String
    BasePath = FolderDirectory
End Property

Public Property Let BasePath(vData As String)
    FolderDirectory = vData
    SearchContent
End Property


Public Property Get CheckSubDirectory() As Boolean
    CheckSubDirectory = CheckSubDirectories
End Property

Public Property Let CheckSubDirectory(vData As Boolean)
    CheckSubDirectories = vData
End Property


Public Property Get TotalFiles() As Integer
    TotalFiles = FilesFound
End Property

Public Property Get FileName(vID As Integer) As String
Dim V As Integer
    V = vID - 1
    FileName = lstFake.List(V)
End Property

Public Property Get FileDirectory(vID As Integer) As String
Dim V As Integer
    V = vID - 1
    FileDirectory = lstFakeDir.List(V)
End Property


Private Sub SearchContent()
On Error Resume Next

Dim I As Integer, InSub_Count As Integer
Dim InSub_No(1000) As Integer
Dim iFound As Integer

    dirFolder.Path = FolderDirectory
    filFolder.Path = FolderDirectory

Check_For_Content:
    For I = 0 To filFolder.ListCount - 1
        If filFolder.List(I) <> ".." And filFolder.List(I) <> "." Then
            lstFake.AddItem filFolder.List(I)
            If Right(filFolder.Path, 1) <> "\" Then
                lstFakeDir.AddItem filFolder.Path & "\"
            Else
                lstFakeDir.AddItem filFolder.Path
            End If
            iFound = iFound + 1
        End If
    Next I

    If CheckSubDirectories = True Then
Recheck_PreDirectory:
        If InSub_Count > 0 Then
            dirFolder.Path = BackDirectory(dirFolder.Path)
            InSub_Count = InSub_Count - 1
        End If

Recheck_For_SubDirectories:
        If InSub_No(InSub_Count) < dirFolder.ListCount Then
            dirFolder.Path = dirFolder.List(InSub_No(InSub_Count))
            filFolder.Path = dirFolder.Path
            InSub_No(InSub_Count) = InSub_No(InSub_Count) + 1

            InSub_Count = InSub_Count + 1
            InSub_No(InSub_Count) = 0

            If InSub_No(InSub_Count) < dirFolder.ListCount Then GoTo Recheck_For_SubDirectories
            GoTo Check_For_Content
        ElseIf InSub_Count > 0 Then
            GoTo Recheck_PreDirectory
        End If
    End If

    FilesFound = iFound
End Sub

Private Function BackDirectory(qPath As String) As String
Dim I As Integer

    If qPath = Empty Then Exit Function

    If Right(qPath, 1) = "\" Then qPath = Mid(qPath, 1, Len(qPath) - 1)
    For I = Len(qPath) To 1 Step -1
        If Mid(qPath, I, 1) = "\" Then
            BackDirectory = Mid(qPath, 1, I)
            Exit Function
        End If
    Next I
End Function

Private Sub UserControl_Resize()
    UserControl.Width = lblCaption.Width
    UserControl.Height = lblCaption.Height
End Sub
