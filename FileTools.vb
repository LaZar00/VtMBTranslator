Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports System.IO
Imports System.Text

Public Class FileTools
    Private Const CFG_FILE_NAME As String = "VtMBTranslator.cfg"

    Public strGlobalPath As String

    Public strPrimaryDLGPath, strSecondaryDLGPath As String
    Public strLipsFolder, strIndividualLipsFolder, strVCDFolder, strMP3Folder, strResultFolder As String
    Public bCaseSensitive, bUnicode, bCodepageVerified, bMaximized As Boolean
    Public iClansDataWidth, iClansDataHeight, iClansDataXPos, iClansDataYPos As Integer
    Public iIndividualLipsEditorWidth, iIndividualLipsEditorHeight, iIndividualLipsEditorXPos, iIndividualLipsEditorYPos As Integer
    Public strTargetLang As String
    Public iCodepageDLGLanguage As Integer
    Public strColumnsdgvDLG1Widths As String

    Public lstCFGKeys As Hashtable = New Hashtable()

    Public Sub PrepareCFGKeys()
        lstCFGKeys.Add("PRIMARY_FOLDER", "")
        lstCFGKeys.Add("SECONDARY_FOLDER", "")

        lstCFGKeys.Add("LIPS_FOLDER", "")
        lstCFGKeys.Add("VCD_FOLDER", "")
        lstCFGKeys.Add("MP3_FOLDER", "")
        lstCFGKeys.Add("RESULT_FOLDER", "")

        lstCFGKeys.Add("CASESENSITIVE_SEARCH", "")

        lstCFGKeys.Add("INDIVIDUAL_LIPS_PATH", "")

        lstCFGKeys.Add("CLANSWINDOW_WIDTH", "")
        lstCFGKeys.Add("CLANSWINDOW_HEIGHT", "")
        lstCFGKeys.Add("CLANSWINDOW_XPOS", "")
        lstCFGKeys.Add("CLANSWINDOW_YPOS", "")

        lstCFGKeys.Add("INDLIPSEDITOR_WIDTH", "")
        lstCFGKeys.Add("INDLIPSEDITOR_HEIGHT", "")
        lstCFGKeys.Add("INDLIPSEDITOR_XPOS", "")
        lstCFGKeys.Add("INDLIPSEDITOR_YPOS", "")

        lstCFGKeys.Add("ENCODING_UNICODE", "")

        lstCFGKeys.Add("DEEPL_TARGET_LANGUAGE", "")
        lstCFGKeys.Add("CODEPAGE_DLG_LANGUAGE", "")
        lstCFGKeys.Add("CODEPAGE_VERIFIED", "")

        lstCFGKeys.Add("DGVDLG1_COLUMNS_WIDTH", "")
        lstCFGKeys.Add("MAXIMIZED", "")
    End Sub


    Public Sub PrepareColumnsdgvDLG1Widths()
        strColumnsdgvDLG1Widths = ""

        For i = 1 To frmVtMBTranslator.dgvDLG1.ColumnCount - 1
            strColumnsdgvDLG1Widths += frmVtMBTranslator.dgvDLG1.Columns(i).Width.ToString()

            If (i < frmVtMBTranslator.dgvDLG1.ColumnCount - 1) Then strColumnsdgvDLG1Widths += "#"
        Next
    End Sub


    Public Sub SetDefaultValues()
        strPrimaryDLGPath = ""
        strSecondaryDLGPath = ""

        strLipsFolder = ""
        strVCDFolder = ""
        strMP3Folder = ""
        strResultFolder = ""

        strIndividualLipsFolder = ""

        iClansDataWidth = frmClansData.MinimumSize.Width
        iClansDataHeight = frmClansData.MinimumSize.Height
        iClansDataXPos = -1
        iClansDataYPos = 0.1

        iIndividualLipsEditorWidth = frmIndividualLipsEditor.MinimumSize.Width
        iIndividualLipsEditorHeight = frmIndividualLipsEditor.MinimumSize.Height
        iIndividualLipsEditorXPos = -1
        iIndividualLipsEditorYPos = -1

        bCaseSensitive = False
        bUnicode = False

        strTargetLang = "ES"
        iCodepageDLGLanguage = My.Computer.Registry.GetValue(
                                    "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Nls\CodePage", "ACP", Nothing)
        bCodepageVerified = 0

        bMaximized = 0

        PrepareColumnsdgvDLG1Widths()

    End Sub

    Public Sub ReadCFGFile()
        Dim strCFGFileName As String = strGlobalPath + "\" + CFG_FILE_NAME
        Dim lines() As String

        PrepareCFGKeys()

        ' If VtMBTranslator.cfg exists, let's read the keys
        If FileExists(strCFGFileName) Then
            lines = File.ReadAllLines(strCFGFileName)

            For Each strLine In lines
                If (strLine.Length > 0) Then
                    Dim strLineSplit() As String = strLine.Split("=")

                    If (strLineSplit.Length > 1) Then
                        lstCFGKeys(strLineSplit(0)) = strLineSplit(1)
                    End If
                End If
            Next

            strPrimaryDLGPath = lstCFGKeys("PRIMARY_FOLDER").ToString()
            strSecondaryDLGPath = lstCFGKeys("SECONDARY_FOLDER").ToString()

            strLipsFolder = lstCFGKeys("LIPS_FOLDER").ToString()
            strVCDFolder = lstCFGKeys("VCD_FOLDER").ToString()
            strMP3Folder = lstCFGKeys("MP3_FOLDER").ToString()
            strResultFolder = lstCFGKeys("RESULT_FOLDER").ToString()

            strIndividualLipsFolder = lstCFGKeys("INDIVIDUAL_LIPS_PATH").ToString()

            If Not (Int32.TryParse(lstCFGKeys("CLANSWINDOW_WIDTH").ToString(), iClansDataWidth)) Then
                iClansDataWidth = frmClansData.MinimumSize.Width
            End If

            If Not (Int32.TryParse(lstCFGKeys("CLANSWINDOW_HEIGHT").ToString(), iClansDataHeight)) Then
                iClansDataHeight = frmClansData.MinimumSize.Height
            End If

            If Not (Int32.TryParse(lstCFGKeys("CLANSWINDOW_XPOS").ToString(), iClansDataXPos)) Then iClansDataXPos = -1
            If Not (Int32.TryParse(lstCFGKeys("CLANSWINDOW_YPOS").ToString(), iClansDataYPos)) Then iClansDataYPos = -1

            If Not (Int32.TryParse(lstCFGKeys("INDLIPSEDITOR_WIDTH").ToString(), iIndividualLipsEditorWidth)) Then
                iIndividualLipsEditorWidth = frmIndividualLipsEditor.MinimumSize.Width
            End If

            If Not (Int32.TryParse(lstCFGKeys("INDLIPSEDITOR_HEIGHT").ToString(), iIndividualLipsEditorHeight)) Then
                iIndividualLipsEditorHeight = frmIndividualLipsEditor.MinimumSize.Height
            End If

            If Not (Int32.TryParse(lstCFGKeys("INDLIPSEDITOR_XPOS").ToString(), iIndividualLipsEditorXPos)) Then iIndividualLipsEditorXPos = -1
            If Not (Int32.TryParse(lstCFGKeys("INDLIPSEDITOR_YPOS").ToString(), iIndividualLipsEditorYPos)) Then iIndividualLipsEditorYPos = -1

            If lstCFGKeys("CASESENSITIVE_SEARCH").ToString() = "1" Then
                bCaseSensitive = True
            Else
                bCaseSensitive = False
            End If

            If lstCFGKeys("ENCODING_UNICODE").ToString() = "1" Then
                bUnicode = True
            Else
                bUnicode = False
            End If

            strTargetLang = lstCFGKeys("DEEPL_TARGET_LANGUAGE").ToString()

            If Not (Int32.TryParse(lstCFGKeys("CODEPAGE_DLG_LANGUAGE").ToString(), iCodepageDLGLanguage)) Then iCodepageDLGLanguage = 1252

            If lstCFGKeys("CODEPAGE_VERIFIED").ToString() = "1" Then
                bCodepageVerified = True
            Else
                bCodepageVerified = False
            End If

            If ((My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Nls\CodePage",
                                              "ACP", Nothing) <> iCodepageDLGLanguage) And (Not bCodepageVerified)) Then
                If (MsgBox("The codepage set in the VtMBTranslator tool differs from the one of this system. Do you want to continue and leave that codepage?" + vbCrLf + vbCrLf +
                           "(NOTE: This will not be asked again. You can always change the codepage in .CFG file.)",
                           MessageBoxButtons.YesNo,
                           "Question") = MsgBoxResult.No) Then

                    iCodepageDLGLanguage = My.Computer.Registry.
                                                GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Nls\CodePage",
                                                         "ACP", Nothing)

                End If

                bCodepageVerified = True

                WriteCFGFile()
            End If

            strColumnsdgvDLG1Widths = lstCFGKeys("DGVDLG1_COLUMNS_WIDTH").ToString()

            If (strColumnsdgvDLG1Widths = "") Then
                PrepareColumnsdgvDLG1Widths()
                WriteCFGFile()
            End If

            If (lstCFGKeys("MAXIMIZED").ToString() = "1") Then
                bMaximized = True
            Else
                bMaximized = False
            End If

        Else
            SetDefaultValues()
            WriteCFGFile()
        End If
    End Sub

    Public Sub WriteCFGFile()
        Dim strCFGFileName As String = strGlobalPath + "\" + CFG_FILE_NAME
        Dim sbCFGLines As StringBuilder = New StringBuilder()

        lstCFGKeys("PRIMARY_FOLDER") = strPrimaryDLGPath
        lstCFGKeys("SECONDARY_FOLDER") = strSecondaryDLGPath

        lstCFGKeys("LIPS_FOLDER") = strLipsFolder
        lstCFGKeys("VCD_FOLDER") = strVCDFolder
        lstCFGKeys("MP3_FOLDER") = strMP3Folder
        lstCFGKeys("RESULT_FOLDER") = strResultFolder

        lstCFGKeys("INDIVIDUAL_LIPS_PATH") = strIndividualLipsFolder

        lstCFGKeys("CLANSWINDOW_WIDTH") = iClansDataWidth.ToString()
        lstCFGKeys("CLANSWINDOW_HEIGHT") = iClansDataHeight.ToString()
        lstCFGKeys("CLANSWINDOW_XPOS") = iClansDataXPos.ToString()
        lstCFGKeys("CLANSWINDOW_YPOS") = iClansDataYPos.ToString()

        lstCFGKeys("INDLIPSEDITOR_WIDTH") = iIndividualLipsEditorWidth.ToString()
        lstCFGKeys("INDLIPSEDITOR_HEIGHT") = iIndividualLipsEditorHeight.ToString()
        lstCFGKeys("INDLIPSEDITOR_XPOS") = iIndividualLipsEditorXPos.ToString()
        lstCFGKeys("INDLIPSEDITOR_YPOS") = iIndividualLipsEditorYPos.ToString()

        If bCaseSensitive Then
            lstCFGKeys("CASESENSITIVE_SEARCH") = "1"
        Else
            lstCFGKeys("CASESENSITIVE_SEARCH") = "0"
        End If


        If bUnicode Then
            lstCFGKeys("ENCODING_UNICODE") = "1"
        Else
            lstCFGKeys("ENCODING_UNICODE") = "0"
        End If

        lstCFGKeys("DEEPL_TARGET_LANGUAGE") = strTargetLang
        lstCFGKeys("CODEPAGE_DLG_LANGUAGE") = iCodepageDLGLanguage

        If bCodepageVerified Then
            lstCFGKeys("CODEPAGE_VERIFIED") = "1"
        Else
            lstCFGKeys("CODEPAGE_VERIFIED") = "0"
        End If

        lstCFGKeys("DGVDLG1_COLUMNS_WIDTH") = strColumnsdgvDLG1Widths

        If bMaximized Then
            lstCFGKeys("MAXIMIZED") = "1"
        Else
            lstCFGKeys("MAXIMIZED") = "0"
        End If

        ' Write VtMBTranslator.cfg
        For Each strCFGKey In lstCFGKeys
            sbCFGLines.AppendLine(strCFGKey.Key & "=" & strCFGKey.Value)
        Next

        File.WriteAllText(strCFGFileName, sbCFGLines.ToString())
    End Sub
End Class
