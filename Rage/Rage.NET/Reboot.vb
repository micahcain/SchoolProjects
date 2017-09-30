Option Strict Off
Option Explicit On
Module rEsTaRt
	'this is a mod that restarts the users computer
	'written by Marty
	
	
	Private Declare Function ExitWindowsEx Lib "user32" (ByVal uFlags As Integer, ByVal dwReserved As Integer) As Integer
	Private Const ENDSESSION_LOGOFF As Integer = &H80000000
	
	Public Enum EShutDownTypes
		_First = 0
		'Graceful exit options:
		'give applications the chance run their own
		'shutdown procedures
		'
		EWX_LOGOFF = 0
		EWX_SHUTDOWN = 1
		EWX_REBOOT = 2
		'Force Options: Terminate all processes
		'without giving applications a chance to respond.
		'Use Cautiously
		EWX_FORCELOGOFF = 4
		EWX_FORCESHUTDOWN = 5
		EWX_FORCEREBOOT = 6
		EWX_POWEROFF = 8
		EWX_FORCEIFHUNG = 10 ' NT5 only
		_Last = &H20 - 1
	End Enum
	
	Public Enum EShutDownErrorBaseConstant
		eeSSDErrorBase = vbObjectError Or (1048 + &H210s)
	End Enum
	
	
	Private Structure OSVERSIONINFO
		Dim dwOSVersionInfoSize As Integer
		Dim dwMajorVersion As Integer
		Dim dwMinorVersion As Integer
		Dim dwBuildNumber As Integer
		Dim dwPlatformId As Integer
		<VBFixedString(128),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=128)> Public szCSDVersion As String
	End Structure
	
	'UPGRADE_WARNING: Structure OSVERSIONINFO may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function GetVersionEx Lib "kernel32"  Alias "GetVersionExA"(ByRef lpVersionInformation As OSVERSIONINFO) As Integer
	
	Private Const VER_PLATFORM_WIN32_NT As Short = 2
	Private Const VER_PLATFORM_WIN32_WINDOWS As Short = 1
	Private Const VER_PLATFORM_WIN32s As Short = 0
	
	
	Private Const FORMAT_MESSAGE_ALLOCATE_BUFFER As Short = &H100s
	Private Const FORMAT_MESSAGE_ARGUMENT_ARRAY As Short = &H2000s
	Private Const FORMAT_MESSAGE_FROM_HMODULE As Short = &H800s
	Private Const FORMAT_MESSAGE_FROM_STRING As Short = &H400s
	Private Const FORMAT_MESSAGE_FROM_SYSTEM As Short = &H1000s
	Private Const FORMAT_MESSAGE_IGNORE_INSERTS As Short = &H200s
	Private Const FORMAT_MESSAGE_MAX_WIDTH_MASK As Short = &HFFs
	
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	Private Declare Function FormatMessage Lib "kernel32"  Alias "FormatMessageA"(ByVal dwFlags As Integer, ByRef lpSource As Any, ByVal dwMessageId As Integer, ByVal dwLanguageId As Integer, ByVal lpBuffer As String, ByVal nSize As Integer, ByRef Arguments As Integer) As Integer
	
	
	Private Structure LARGE_INTEGER
		Dim LowPart As Integer
		Dim HighPart As Integer
	End Structure
	
	Private Structure LUID
		Dim LowPart As Integer
		Dim HighPart As Integer
	End Structure
	
	Private Structure LUID_AND_ATTRIBUTES
		Dim pLuid As LUID
		Dim Attributes As Integer
	End Structure
	
	Private Structure TOKEN_PRIVILEGES
		Dim PrivilegeCount As Integer
		<VBFixedArray(0)> Dim Privileges() As LUID_AND_ATTRIBUTES
		
		'UPGRADE_TODO: "Initialize" must be called to initialize instances of this structure. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1026"'
		Public Sub Initialize()
			ReDim Privileges(0)
		End Sub
	End Structure
	
	Private Declare Function GetCurrentProcess Lib "kernel32" () As Integer
	Private Declare Function OpenProcessToken Lib "advapi32.dll" (ByVal ProcessHandle As Integer, ByVal DesiredAccess As Integer, ByRef TokenHandle As Integer) As Integer
	Private Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Integer) As Integer
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	Private Declare Function GetTokenInformation Lib "advapi32.dll" (ByVal TokenHandle As Integer, ByRef TokenInformationClass As Short, ByRef TokenInformation As Any, ByVal TokenInformationLength As Integer, ByRef ReturnLength As Integer) As Integer
	'UPGRADE_WARNING: Structure TOKEN_PRIVILEGES may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	'UPGRADE_WARNING: Structure TOKEN_PRIVILEGES may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function AdjustTokenPrivileges Lib "advapi32.dll" (ByVal TokenHandle As Integer, ByVal DisableAllPrivileges As Integer, ByRef NewState As TOKEN_PRIVILEGES, ByVal BufferLength As Integer, ByRef PreviousState As TOKEN_PRIVILEGES, ByRef ReturnLength As Integer) As Integer
	'UPGRADE_WARNING: Structure LUID may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function LookupPrivilegeValue Lib "advapi32.dll"  Alias "LookupPrivilegeValueA"(ByVal lpSystemName As String, ByVal lpName As String, ByRef lpLuid As LUID) As Integer
	
	Private Const SE_SHUTDOWN_NAME As String = "SeShutdownPrivilege"
	Private Const SE_PRIVILEGE_ENABLED As Short = &H2s
	
	Private Const READ_CONTROL As Integer = &H20000
	Private Const STANDARD_RIGHTS_ALL As Integer = &H1F0000
	Private Const STANDARD_RIGHTS_EXECUTE As Integer = (READ_CONTROL)
	Private Const STANDARD_RIGHTS_READ As Integer = (READ_CONTROL)
	Private Const STANDARD_RIGHTS_REQUIRED As Integer = &HF0000
	Private Const STANDARD_RIGHTS_WRITE As Integer = (READ_CONTROL)
	
	Private Const TOKEN_ASSIGN_PRIMARY As Short = &H1s
	Private Const TOKEN_DUPLICATE As Short = (&H2s)
	Private Const TOKEN_IMPERSONATE As Short = (&H4s)
	Private Const TOKEN_QUERY As Short = (&H8s)
	Private Const TOKEN_QUERY_SOURCE As Short = (&H10s)
	Private Const TOKEN_ADJUST_PRIVILEGES As Short = (&H20s)
	Private Const TOKEN_ADJUST_GROUPS As Short = (&H40s)
	Private Const TOKEN_ADJUST_DEFAULT As Short = (&H80s)
	Private Const TOKEN_ALL_ACCESS As Boolean = (STANDARD_RIGHTS_REQUIRED Or TOKEN_ASSIGN_PRIMARY Or TOKEN_DUPLICATE Or TOKEN_IMPERSONATE Or TOKEN_QUERY Or TOKEN_QUERY_SOURCE Or TOKEN_ADJUST_PRIVILEGES Or TOKEN_ADJUST_GROUPS Or TOKEN_ADJUST_DEFAULT)
	Private Const TOKEN_READ As Boolean = (STANDARD_RIGHTS_READ Or TOKEN_QUERY)
	Private Const TOKEN_WRITE As Boolean = (STANDARD_RIGHTS_WRITE Or TOKEN_ADJUST_PRIVILEGES Or TOKEN_ADJUST_GROUPS Or TOKEN_ADJUST_DEFAULT)
	Private Const TOKEN_EXECUTE As Object = (STANDARD_RIGHTS_EXECUTE)
	Private Const TokenImpersonationLevel As Short = 9
	Private Const TokenOwner As Short = 4
	Private Const TokenUser As Short = 1
	Private Const TokenPrimaryGroup As Short = 5
	Private Const TokenStatistics As Short = 10
	Private Const TokenType As Short = 8
	Private Const TokenPrivileges As Short = 3
	Private Const TokenSource As Short = 7
	Private Const TokenDefaultDacl As Short = 6
	Private Const TokenGroups As Short = 2
	
	Public Function WinError(ByVal lLastDLLError As Integer) As String
		
		
		Dim sBuff As String
		Dim lCount As Integer
		
		
		sBuff = Space(255)
		lCount = FormatMessage(FORMAT_MESSAGE_FROM_SYSTEM Or FORMAT_MESSAGE_IGNORE_INSERTS, 0, lLastDLLError, 0, sBuff, Len(sBuff), 0)
		
		
		If lCount Then
			WinError = Left(sBuff, lCount)
		End If
		
	End Function
	
	Public Function IsNT() As Boolean
		
		
		Static bOnce As Boolean
		Static bValue As Boolean
		
		Dim tVI As OSVERSIONINFO
		If Not (bOnce) Then
			
			tVI.dwOSVersionInfoSize = Len(tVI)
			
			If (GetVersionEx(tVI) <> 0) Then
				bValue = (tVI.dwPlatformId = VER_PLATFORM_WIN32_NT)
				bOnce = True
			End If
		End If
		
		IsNT = bValue
		
	End Function
	
	Private Function NTEnableShutDown(ByRef sMsg As String) As Boolean
		
		Dim tLUID As LUID
		Dim hProcess As Integer
		Dim hToken As Integer
		'UPGRADE_WARNING: Arrays in structure tTP may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1063"'
		Dim tTP As TOKEN_PRIVILEGES
		'UPGRADE_WARNING: Arrays in structure tTPOld may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1063"'
		Dim tTPOld As TOKEN_PRIVILEGES
		Dim lTpOld As Integer
		Dim lR As Integer
		
		lR = LookupPrivilegeValue(vbNullString, SE_SHUTDOWN_NAME, tLUID)
		
		If (lR <> 0) Then
			
			hProcess = GetCurrentProcess()
			If (hProcess <> 0) Then
				lR = OpenProcessToken(hProcess, TOKEN_ADJUST_PRIVILEGES Or TOKEN_QUERY, hToken)
				If (lR <> 0) Then
					
					With tTP
						.PrivilegeCount = 1
						With .Privileges(0)
							.Attributes = SE_PRIVILEGE_ENABLED
							.pLuid.HighPart = tLUID.HighPart
							.pLuid.LowPart = tLUID.LowPart
						End With
					End With
					
					lR = AdjustTokenPrivileges(hToken, 0, tTP, Len(tTP), tTPOld, lTpOld)
					
					If (lR <> 0) Then
						NTEnableShutDown = True
					Else
						Err.Raise(EShutDownErrorBaseConstant.eeSSDErrorBase + 6, VB6.GetExeName() & ".mShutDown", "Can't enable shutdown: You do not have the privileges to " & "shutdown this system. [" & WinError(Err.LastDllError) & "]")
					End If
					
					CloseHandle(hToken)
				Else
					Err.Raise(EShutDownErrorBaseConstant.eeSSDErrorBase + 6, VB6.GetExeName() & ".mShutDown", "Can't enable shutdown: You do not have the privileges to " & "shutdown this system. [" & WinError(Err.LastDllError) & "]")
				End If
			Else
				Err.Raise(EShutDownErrorBaseConstant.eeSSDErrorBase + 5, VB6.GetExeName() & ".mShutDown", "Can't enable shutdown: Can't determine the current process. [" & WinError(Err.LastDllError) & "]")
			End If
		Else
			Err.Raise(EShutDownErrorBaseConstant.eeSSDErrorBase + 4, VB6.GetExeName() & ".mShutDown", "Can't enable shutdown: Can't find the SE_SHUTDOWN_NAME privilege value. [" & WinError(Err.LastDllError) & "]")
		End If
		
	End Function
	
	Public Function ShutdownSystem(Optional ByVal eType As EShutDownTypes = EShutDownTypes.EWX_SHUTDOWN) As Boolean
		
		Dim yesno As Short
		
		
		
		Dim lR As Integer
		Dim sMsg As String
		
		
		If (eType < EShutDownTypes._First And eType > EShutDownTypes._Last) Then
			Err.Raise(EShutDownErrorBaseConstant.eeSSDErrorBase + 7, VB6.GetExeName() & ".mShutDown", "Invalid parameter to ShutdownSystem: " & eType, MsgBoxStyle.Information)
			Exit Function
		End If
		
		
		If (IsNT) Then
			If Not (NTEnableShutDown(sMsg)) Then
				Exit Function
			End If
		End If
		
		lR = ExitWindowsEx(eType, &HFFFFFFFF)
		
		If (lR = 0) Then
			Err.Raise(EShutDownErrorBaseConstant.eeSSDErrorBase + 3, VB6.GetExeName() & ".mShutDown", "ShutdownSystem failed: " & WinError(Err.LastDllError))
		Else
			ShutdownSystem = True
		End If
		
		
		
	End Function
End Module