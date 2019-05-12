; Installer file

;----------------------------

!define BUILDTARGET "Release"

!define PRODUCT_VERSION "1.1.0"
!define PRODUCT_WEB_SITE "https://github.com/rasmusolle/ddsviewer"

;----------------------------

SetCompressor /SOLID LZMA

Name "DDS Viewer"
OutFile "DDSViewerSetup.exe"
BrandingText " "

LicenseData "LICENSE"

Icon "icon/icon.ico"
UninstallIcon "icon/uninst_icon.ico"

InstallDir "$PROGRAMFILES\DDSViewer"
InstallDirRegKey HKLM "Software\DDSViewer" "Install_Dir"

RequestExecutionLevel admin

;----------------------------

Page license
Page components
Page directory
Page instfiles

UninstPage uninstConfirm
UninstPage instfiles

;----------------------------

Section "Main" SecMain
	SectionIn RO
	
	SetOutPath $INSTDIR
	File "bin\${BUILDTARGET}\DDSViewer.exe"
	File "help.html"
	File "LICENSE"

	;Uninstaller work
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\DDSViewer\" "DisplayName" "DDS Viewer"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\DDSViewer\" "UninstallString" "$INSTDIR\Uninstall.exe"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\DDSViewer\" "NoModify" 1
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\DDSViewer\" "NoRepair" 1
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\DDSViewer\" "DisplayVersion" "${PRODUCT_VERSION}"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\DDSViewer\" "URLInfoAbout" "${PRODUCT_WEB_SITE}"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\DDSViewer\" "Publisher" "RasmusOlle"
	WriteUninstaller "$INSTDIR\Uninstall.exe"
SectionEnd

Section "Assign .DDS extension" SecExt
	WriteRegStr HKCR ".dds" "" "DDS"
	WriteRegStr HKCR ".dds" "PerceivedType" "Image"
	WriteRegStr HKCR "DDS" "" "DDS File"
	WriteRegStr HKCR "DDS\DefaultIcon" "" "$INSTDIR\DDSViewer.exe,0"
	WriteRegStr HKCR "DDS\shell\open\command" "" '"$INSTDIR\DDSViewer.exe" "%1"'
SectionEnd

Section "Start Menu Shortcut" SecSMShortcut
	CreateDirectory "$SMPROGRAMS\DDS Viewer"
	CreateShortCut "$SMPROGRAMS\DDS Viewer\DDS Viewer.lnk" "$INSTDIR\DDSViewer.exe"
	CreateShortCut "$SMPROGRAMS\DDS Viewer\Uninstall.lnk" "$INSTDIR\Uninstall.exe"
SectionEnd

Section "Desktop Shortcut" SecDesktopShortcut
	CreateShortCut "$DESKTOP\DDS Viewer.lnk" "$INSTDIR\DDSViewer.exe"
SectionEnd

Section "Uninstall"
	Delete "$INSTDIR\Uninstall.exe"
	Delete "$INSTDIR\DDSViewer.exe"
	Delete "$INSTDIR\help.html"
	Delete "$INSTDIR\LICENSE"
	
	RMDir "$SMPROGRAMS\DDS Viewer"
	
	Delete "$DESKTOP\DDS Viewer.lnk"
	
	DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\DDSViewer\"
	DeleteRegKey HKLM "SOFTWARE\DDSViewer"
	DeleteRegKey HKCR "DDS"
SectionEnd






























