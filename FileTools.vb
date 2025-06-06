Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports System.IO
Imports System.Text

Public Class FileTools
    Private Const CFG_FILE_NAME As String = "VtMBTranslator.cfg"

    Public strGlobalPath As String

    Public strPrimaryDLGPath, strSecondaryDLGPath As String
    Public strLipsFolder, strIndividualLipsFolder, strVCDFolder, strMP3Folder, strResultFolder As String
    Public bCaseSensitive, bUnicode As Boolean
    Public iClansDataWidth, iClansDataHeight, iClansDataXPos, iClansDataYPos As Integer
    Public iIndividualLipsEditorWidth, iIndividualLipsEditorHeight, iIndividualLipsEditorXPos, iIndividualLipsEditorYPos As Integer
    Public strTargetLang As String

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

        ' Write VtMBTranslator.cfg
        For Each strCFGKey In lstCFGKeys
            sbCFGLines.AppendLine(strCFGKey.Key & "=" & strCFGKey.Value)
        Next

        File.WriteAllText(strCFGFileName, sbCFGLines.ToString())
    End Sub
End Class
