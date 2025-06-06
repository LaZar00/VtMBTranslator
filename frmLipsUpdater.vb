Imports Microsoft.WindowsAPICodePack.Dialogs
Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Imports System.Text.RegularExpressions


Public Class frmLipsUpdater
    Public Const dialogueStaticPath As String = "\sound\character\dlg"

    Public strLipsFullPath As String = String.Empty
    Public strVCDFullPath As String = String.Empty
    Public strMP3FullPath As String = String.Empty
    Public strResultFullPath As String = String.Empty


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmVtMBTranslator.LipsUpdaterActive = False

        Me.Close()
    End Sub


    Private Sub btnLipsPath_Click(sender As Object, e As EventArgs) Handles btnLipsPath.Click
        Dim cofdLipsFolder As CommonOpenFileDialog = New CommonOpenFileDialog()

        cofdLipsFolder.Title = "Select Lips folder"
        cofdLipsFolder.IsFolderPicker = True

        If txtLipsPath.Text.Length > 0 And DirectoryExists(txtLipsPath.Text) Then
            cofdLipsFolder.InitialDirectory = txtLipsPath.Text
        Else
            cofdLipsFolder.InitialDirectory = frmVtMBTranslator.FT.strGlobalPath
        End If

        If cofdLipsFolder.ShowDialog() = CommonFileDialogResult.Ok Then
            txtLipsPath.Text = cofdLipsFolder.FileName

            frmVtMBTranslator.FT.strLipsFolder = txtLipsPath.Text
            frmVtMBTranslator.FT.WriteCFGFile()

            btnTranslateLips.Enabled = False
        End If
    End Sub


    Private Sub btnVCDPath_Click(sender As Object, e As EventArgs) Handles btnVCDPath.Click
        Dim cofdVCDFolder As CommonOpenFileDialog = New CommonOpenFileDialog()

        cofdVCDFolder.Title = "Select VCD folder"
        cofdVCDFolder.IsFolderPicker = True

        If txtVCDPath.Text.Length > 0 And DirectoryExists(txtVCDPath.Text) Then
            cofdVCDFolder.InitialDirectory = txtVCDPath.Text
        Else
            cofdVCDFolder.InitialDirectory = frmVtMBTranslator.FT.strGlobalPath
        End If

        If cofdVCDFolder.ShowDialog() = CommonFileDialogResult.Ok Then
            txtVCDPath.Text = cofdVCDFolder.FileName

            frmVtMBTranslator.FT.strVCDFolder = txtVCDPath.Text
            frmVtMBTranslator.FT.WriteCFGFile()

            btnTranslateLips.Enabled = False
        End If
    End Sub


    Private Sub btnMP3Path_Click(sender As Object, e As EventArgs) Handles btnMP3Path.Click
        Dim cofdMP3Folder As CommonOpenFileDialog = New CommonOpenFileDialog()

        cofdMP3Folder.Title = "Select MP3 folder"
        cofdMP3Folder.IsFolderPicker = True

        If txtMP3Path.Text.Length > 0 And DirectoryExists(txtMP3Path.Text) Then
            cofdMP3Folder.InitialDirectory = txtMP3Path.Text
        Else
            cofdMP3Folder.InitialDirectory = frmVtMBTranslator.FT.strGlobalPath
        End If

        If cofdMP3Folder.ShowDialog() = CommonFileDialogResult.Ok Then
            txtMP3Path.Text = cofdMP3Folder.FileName

            frmVtMBTranslator.FT.strMP3Folder = txtMP3Path.Text
            frmVtMBTranslator.FT.WriteCFGFile()

            btnTranslateLips.Enabled = False
        End If
    End Sub


    Private Sub btnResultPath_Click(sender As Object, e As EventArgs) Handles btnResultPath.Click
        Dim cofdResultFolder As CommonOpenFileDialog = New CommonOpenFileDialog()

        cofdResultFolder.Title = "Select Result folder"
        cofdResultFolder.IsFolderPicker = True

        If txtResultPath.Text.Length > 0 And DirectoryExists(txtResultPath.Text) Then
            cofdResultFolder.InitialDirectory = txtResultPath.Text
        Else
            cofdResultFolder.InitialDirectory = frmVtMBTranslator.FT.strGlobalPath
        End If

        If cofdResultFolder.ShowDialog() = CommonFileDialogResult.Ok Then
            txtResultPath.Text = cofdResultFolder.FileName

            frmVtMBTranslator.FT.strResultFolder = txtResultPath.Text
            frmVtMBTranslator.FT.WriteCFGFile()

            btnTranslateLips.Enabled = False
        End If
    End Sub


    Public Function GetSpeakerNameText(ByVal strLipLines() As String) As String
        Dim numline As Integer
        Dim found As Boolean
        Dim strLine() As String
        Dim resultSpeakerNameText As String = ""

        If strLipLines.Count > 0 Then
            numline = strLipLines.Count - 1

            While numline >= 0 And Not found
                strLine = strLipLines(numline).Split(" ")

                If strLine(0).ToLower() = "speaker_name" Then
                    resultSpeakerNameText = strLipLines(numline).Substring(InStr(Trim(strLipLines(numline).Replace(vbTab, "")), " "))
                    found = True
                End If

                If Not found Then numline -= 1
            End While
        End If

        If Not found Then resultSpeakerNameText = "-1"

        Return resultSpeakerNameText
    End Function


    Public Function GetSpeakerName(ByVal strSpeakerNameFile As String) As String
        Dim strFileName As ObjectModel.ReadOnlyCollection(Of String)
        Dim strLipLines() As String
        Dim strSpeakerName As String = String.Empty
        Dim found As Boolean = False

        ' Get First File 
        Try
            strFileName = GetFiles(strSpeakerNameFile, FileIO.SearchOption.SearchTopLevelOnly, "*.lip")

            If strFileName.Count > 0 Then
                If Not strFileName.First Is String.Empty Then
                    ' We found something, now read the file
                    strLipLines = File.ReadAllLines(strFileName.First,
                                                    System.Text.Encoding.GetEncoding(frmVtMBTranslator.ISO_8859_1))

                    ' Now get the speaker name
                    If strLipLines.Count > 0 Then
                        strSpeakerName = GetSpeakerNameText(strLipLines)
                    End If
                End If
            Else
                MsgBox("There is not any .lip file where to find the Speaker Name in the folder: " + vbCrLf +
                       strSpeakerNameFile + vbCrLf +
                       "Setting Speaker Name as empty text.")

                strSpeakerName = ""
            End If
        Catch ex As Exception
            MsgBox("There has been some error trying to get the Speaker Name." + vbCrLf +
                   "Exception: " + ex.Message)

            strSpeakerName = ""
        End Try

        Return strSpeakerName
    End Function


    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim checkLips, checkVCD, checkMP3, checkResult As Boolean
        Dim strSpeakerName, strSpeakerNameFolder As String

        ' Here we will check different aspects of this updater
        txtReport.Clear()
        checkLips = False
        checkVCD = False
        checkMP3 = False
        checkResult = False

        ' Check Lips folder
        If DirectoryExists(txtLipsPath.Text + dialogueStaticPath) And Trim(txtLipsPath.Text).Length > 0 Then
            txtReport.Text += "Lips Path: " + txtLipsPath.Text + vbCrLf
            checkLips = True
        Else
            txtReport.Text += "Lips Path: NOT FOUND" + vbCrLf
        End If

        ' Check VCD folder
        If DirectoryExists(txtVCDPath.Text + dialogueStaticPath) And Trim(txtVCDPath.Text).Length > 0 Then
            txtReport.Text += "VCD Path: " + txtVCDPath.Text + vbCrLf
            checkVCD = True
        Else
            txtReport.Text += "VCD Path: NOT FOUND" + vbCrLf
        End If

        ' Check MP3 folder
        If DirectoryExists(txtMP3Path.Text + dialogueStaticPath) And Trim(txtMP3Path.Text).Length > 0 Then
            txtReport.Text += "MP3 Path: " + txtMP3Path.Text + vbCrLf
            checkMP3 = True
        Else
            txtReport.Text += "MP3 Path: NOT FOUND" + vbCrLf
        End If

        ' Check Result folder
        If DirectoryExists(txtResultPath.Text + dialogueStaticPath) And Trim(txtResultPath.Text).Length > 0 Then
            txtReport.Text += "Result Path: " + txtResultPath.Text + vbCrLf
            checkResult = True
        Else
            If MsgBox("The folder structure for the results is inexistant." + vbCrLf +
                      "Do you want to create the folder structure in result folder?",
                      vbYesNo,
                      "Create folder structure") = vbYes Then
                ' Create structure
                If DirectoryExists(txtResultPath.Text) Then
                    Try
                        CreateDirectory(txtResultPath.Text + "\result" + dialogueStaticPath)
                        txtResultPath.Text = txtResultPath.Text + "\result"

                        txtReport.Text += "Result Path: " + txtResultPath.Text + vbCrLf
                        checkResult = True
                    Catch ex As Exception
                        MsgBox("There has been some type of issue creating the folder structure for the result folder." + vbCrLf +
                               "Exception: " + ex.Message, vbOK, "Warning")
                    End Try
                Else
                    Try
                        CreateDirectory(Application.StartupPath + "\result" + dialogueStaticPath)
                        txtResultPath.Text = Application.StartupPath + "\result"

                        txtReport.Text += "Result Path: " + txtResultPath.Text + vbCrLf
                        checkResult = True
                    Catch ex As Exception
                        MsgBox("There has been some type of issue creating the folder structure for the result folder." + vbCrLf +
                               "Exception: " + ex.Message, vbOK, "Warning")
                    End Try
                End If
            Else
                txtReport.Text += "Result Path: NOT FOUND" + vbCrLf
            End If
        End If

        If checkLips And checkVCD And checkMP3 And checkResult Then
            btnTranslateLips.Enabled = True

            ' We can get here the Speaker Name also
            strSpeakerNameFolder = txtLipsPath.Text +
                                   dialogueStaticPath + "\" +
                                   New DirectoryInfo(Path.GetDirectoryName(frmVtMBTranslator.txtDLG1.Text)).Name + "\" +
                                   Path.GetFileNameWithoutExtension(frmVtMBTranslator.txtDLG1.Text)

            ' We will check if exists the .lips folder for the edited dialogue file.
            ' If it does not exists, we will cancel this process.
            If Not DirectoryExists(strSpeakerNameFolder) Then
                txtReport.Text += "ERROR: Inexistant Lips folder for opened dialogue file:" + vbCrLf
                txtReport.Text += strSpeakerNameFolder + vbCrLf

                btnTranslateLips.Enabled = False

                Return
            End If

            strSpeakerName = GetSpeakerName(strSpeakerNameFolder)

            If Not strSpeakerName Is Nothing And strSpeakerName <> "-1" Then
                If strSpeakerName.Length > 0 Then
                    txtSpeakerName.Text = strSpeakerName
                    txtSpeakerName.Enabled = True

                    txtReport.Text += "SPEAKER NAME FOUND: " + strSpeakerName + vbCrLf
                End If
            Else
                txtReport.Text += "WARNING: SPEAKER NAME NOT FOUND" + vbCrLf
                'MsgBox("The Speaker Name has not been found for this dialogue file in folder: " +
                'strSpeakerNameFolder, vbOK, "Warning")
            End If

            ' Let's see if we have also a translated Speaker Name in Result folder.
            btnCopySpeakerName.Enabled = False

            strSpeakerNameFolder = txtResultPath.Text +
                                   dialogueStaticPath + "\" +
                                   New DirectoryInfo(Path.GetDirectoryName(frmVtMBTranslator.txtDLG1.Text)).Name + "\" +
                                   Path.GetFileNameWithoutExtension(frmVtMBTranslator.txtDLG1.Text)

            If Not DirectoryExists(strSpeakerNameFolder) Then
                txtReport.Text += "INFO: Not found resultant Lips folder for translated Speaker Name." + vbCrLf
                txtReport.Text += strSpeakerNameFolder + vbCrLf

                Return
            End If

            strSpeakerName = GetSpeakerName(strSpeakerNameFolder)

            If Not strSpeakerName Is Nothing And strSpeakerName <> "-1" Then
                If strSpeakerName.Length > 0 Then
                    txtSpeakerNameTrans.Text = strSpeakerName
                    btnCopySpeakerName.Enabled = True
                End If
            End If

        End If

    End Sub


    Public Function PreProcessText(ByVal strText As String) As String
        Dim strTextTemp As String = String.Empty
        Dim pattern = "\[.*?\]"

        strTextTemp = Regex.Replace(strText, pattern, "")
        strTextTemp = Trim(strTextTemp.Replace(vbTab, ""))

        Return strTextTemp
    End Function


    Public Function GetPHRASELine(ByVal strLipLines() As String) As Integer
        Dim resultNumLine As Integer = -1
        Dim numLine = 0
        Dim found As Boolean

        While numLine < strLipLines.Count And Not found
            If InStr(strLipLines(numLine), "PHRASE") Then
                found = True
                resultNumLine = numLine
            End If

            If Not found Then numLine += 1
        End While

        Return resultNumLine
    End Function

    Public Function GetSpeakerLine(ByVal strLipLines() As String) As Integer
        Dim resultNumLine As Integer = -1
        Dim numLine = 0
        Dim found As Boolean

        numLine = strLipLines.Count - 1
        found = False

        While numLine >= 0 And Not found
            If InStr(strLipLines(numLine), "speaker_name") Then
                found = True
                resultNumLine = numLine
            End If

            If Not found Then numLine -= 1
        End While

        Return resultNumLine
    End Function


    Public Function SetPHRASELine(ByVal strPHRASEText As String, ByVal strSplit() As String) As String
        Dim strLine As String
        Dim bUnicode As Boolean = Convert.ToBoolean(frmVtMBTranslator.cbEncoding.SelectedIndex)

        If Not bUnicode Then
            strLine = "PHRASE" + " " +
                      "char" + " " +
                      (strPHRASEText.Length + 2).ToString + " " +
                      """" + strPHRASEText + """" + " " +
                      strSplit(strSplit.Count - 2) + " " +
                      strSplit(strSplit.Count - 1)
        Else
            Dim finaltext As String = ""

            For i As Integer = 0 To strPHRASEText.Length - 1
                finaltext &= strPHRASEText(i) + vbNullChar
            Next

            strLine = "PHRASE" + " " +
                      "unicode" + " " +
                      (finaltext.Length).ToString + " " +
                      finaltext + " " +
                      strSplit(strSplit.Count - 2) + " " +
                      strSplit(strSplit.Count - 1)
        End If


        Return strLine
    End Function


    Public Sub WriteLipFile(ByVal strLipOutputFileName As String, ByVal strLipLines() As String)
        Using fDLG As StreamWriter = New StreamWriter(File.Open(strLipOutputFileName, FileMode.Create),
                                  System.Text.Encoding.GetEncoding(frmVtMBTranslator.ISO_8859_1))
            For Each strLipLine In strLipLines
                fDLG.WriteLine(strLipLine)
            Next
        End Using
    End Sub


    Public Sub Translate(ByVal strLipInputFileName As String, ByVal strLipOutputFileName As String, ByVal strText As String)
        Dim numLine As Integer = 0

        Dim strLipLines() As String = File.ReadAllLines(strLipInputFileName,
                                                        System.Text.Encoding.GetEncoding(frmVtMBTranslator.ISO_8859_1))

        Try
            '''''''''''''' Update PHRASE
            ' Now we search the line we need to update (search PHRASE word)
            numLine = GetPHRASELine(strLipLines)

            ' We put the new line (theorically, it is mandatory to find the PHRASE)
            ' but, we will check just in case
            If numLine > -1 Then
                strLipLines(numLine) = SetPHRASELine(strText, strLipLines(numLine).Split(" "))

                '''''''''''''' Update speaker_name
                ' Now we search the line we need to update (search speaker_name word)
                numLine = GetSpeakerLine(strLipLines)

                If numLine > -1 Then
                    strLipLines(numLine) = "speaker_name" + " " + txtSpeakerName.Text
                End If

                '                ' We write the new file
                '                WriteLipFile(strLipOutputFileName, strLipLines)
            End If

            ' We write the new file even there is no PHRASE word. Some .lip files has not it.
            WriteLipFile(strLipOutputFileName, strLipLines)
        Catch ex As Exception
            MsgBox("There has been some problem when creating the .lip file: " + strLipOutputFileName,
                   vbOK,
                   "Exception")
            Return
        End Try

    End Sub


    Public Sub ProcessVCD(ByVal strVCDFullPath As String, ByVal strMP3FullPath As String, ByVal strResultFullPath As String,
                          ByVal linenum As Integer)
        ' Here we need to do some steps, in case we add a new female line, but it is inexistant
        ' in the game, like create its female .vcd/mp3 files and update the new female .vcd
        ' appointing to the supposed female .mp3/.wav.
        Dim numlines As Integer
        Dim found As Boolean = False

        ' First we will "create" the VCD file by using thee male file and writing it with
        ' the _col_e.wav part changed to female.
        ' So we ned to edit the female .vcd line appointing to the female .mp3/.wav
        Dim strVCDLines() As String = File.ReadAllLines(strVCDFullPath + "e.vcd",
                                                        System.Text.Encoding.GetEncoding(frmVtMBTranslator.ISO_8859_1))

        While numlines < strVCDLines.Count And Not found
            If InStr(strVCDLines(numlines), "_col_e.") Then
                strVCDLines(numlines) = Strings.Replace(strVCDLines(numlines), "_col_e.", "_col_f.", 1)

                found = True
            End If

            If Not found Then numlines += 1
        End While

        ' Write new file
        Using fDLG As StreamWriter = New StreamWriter(File.Open(strResultFullPath + "f.vcd", FileMode.Create),
                                                                System.Text.Encoding.GetEncoding(frmVtMBTranslator.ISO_8859_1))
            For Each strVCDLine In strVCDLines
                fDLG.WriteLine(strVCDLine)
            Next
        End Using

        ' Now we need to look if female .mp3/.wav file exists.
        ' If not, we will need to copy a new female .mp3/.wav file.
        If Not FileExists(strMP3FullPath + "f.mp3") Or Not FileExists(strMP3FullPath + "f.wav") Then
            If FileExists(strMP3FullPath + "e.mp3") Then
                CopyFile(strMP3FullPath + "e.mp3", strResultFullPath + "f.mp3")
                txtReport.Text += "PROCESS VCD: New female .MP3 file created for line: " + linenum.ToString() + vbCrLf
            ElseIf FileExists(strMP3FullPath + "e.wav") Then
                CopyFile(strMP3FullPath + "e.wav", strResultFullPath + "f.wav")
                txtReport.Text += "PROCESS VCD: New female .WAV file created for line: " + linenum.ToString() + vbCrLf
            Else
                txtReport.Text += "ERROR PROCESSING VCD: There is not male .MP3/.WAV file for create the female one for line: " +
                                  linenum.ToString() + vbCrLf
            End If
        End If

    End Sub


    Private Sub btnTranslateLips_Click(sender As Object, e As EventArgs) Handles btnTranslateLips.Click
        Dim strDLGFileName As String = String.Empty
        Dim strDLGRelativePath As String = String.Empty
        Dim strMaleText, strFemaleText As String
        Dim numrows As Integer = 0
        Dim linenum As Integer = 0

        Dim foundLip, foundVCD, foundLipFem, foundVCDFem As Boolean

        ' We confirm we can begin the process...
        If btnTranslateLips.Enabled Then
            ' First we need to check and find the Lips and VCD folders/files of the .dlg file we want to translate.
            ' Let's get the name of the file
            strDLGRelativePath = New DirectoryInfo(Path.GetDirectoryName(frmVtMBTranslator.txtDLG1.Text)).Name
            strDLGFileName = Path.GetFileNameWithoutExtension(frmVtMBTranslator.txtDLG1.Text)

            strLipsFullPath = txtLipsPath.Text + dialogueStaticPath + "\" + strDLGRelativePath + "\" + strDLGFileName + "\"
            strVCDFullPath = txtVCDPath.Text + dialogueStaticPath + "\" + strDLGRelativePath + "\" + strDLGFileName + "\"
            strMP3FullPath = txtMP3Path.Text + dialogueStaticPath + "\" + strDLGRelativePath + "\" + strDLGFileName + "\"
            strResultFullPath = txtResultPath.Text + dialogueStaticPath + "\" + strDLGRelativePath + "\" + strDLGFileName + "\"

            txtReport.Clear()

            ' Let's check if folder exists
            If DirectoryExists(Path.GetDirectoryName(strResultFullPath)) Then
                DeleteDirectory(Path.GetDirectoryName(strResultFullPath), DeleteDirectoryOption.DeleteAllContents)
            End If

            ' We create it
            CreateDirectory(Path.GetDirectoryName(strResultFullPath))

            ' Ok, now we can begin to translate Lips files
            ' We will get the list of the files
            'Dim listLipFiles = GetFiles(strLipsFullPath)

            Try
                For numrows = 0 To frmVtMBTranslator.dgvDLG1.RowCount - 1
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    ''' This part is for everyone (male/female) lines
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    ' Now for each dialogue line, we have some things to do:
                    ' Normally the lines that we should check has a Jump value of '#'
                    ' 1.- Check if there should be a male and female lines (because male and female lines in .dlg are different)
                    ' 2.- If both files should exists (male and female text is different), 
                    '    a.- Check that there are lips files for both dialogues, if not, create the remaining one.
                    '        This is create the 'col_e' or 'col_f' files for lips type of that line.
                    '        For lip file we will use the .dlg text, for vcd file we will copy the existing one to the new gender.
                    '    b.- Check that there are vcd files for both dialogues, if not, create the remaining one with the one existant.
                    '        This is create the 'col_e' or 'col_f' files for vcd type of that line.
                    '        For vcd file we will use one existant .vcd file for the new gender (using the existant mp3 audio voice).
                    ' 3.- If we only need one file (male and female text is the same)
                    '    a.- Check that there is lip file.
                    '        For lip file we will use the .dlg text
                    '    b.- Check that there is or not vcd file for the dialogue, and show message in report file saying so.

                    ' Check if we need to process the line
                    If Trim(frmVtMBTranslator.dgvDLG1.Rows(numrows).Cells(3).Value.Replace(vbTab, "")) = "#" Then
                        linenum = Trim(frmVtMBTranslator.dgvDLG1.Rows(numrows).Cells(0).Value.Replace(vbTab, ""))

                        ' Prepare male line that should have voiced dialogue
                        ' We need also to delete the parts of text with '[' and ']'.
                        ' We don't want them to appear in the speeches.
                        strMaleText = PreProcessText(frmVtMBTranslator.dgvDLG1.Rows(numrows).Cells(1).Value)

                        ' Case we have "...", this have no lips/mp3/vcd files.
                        If strMaleText = "..." Then Continue For

                        If Not strMaleText Is Nothing Then
                            ' Prepare female line that should have voiced dialogue
                            ' We need also to delete the parts of text with '[' and ']'.
                            ' We don't want them to appear in the speeches.
                            strFemaleText = PreProcessText(frmVtMBTranslator.dgvDLG1.Rows(numrows).Cells(2).Value)

                            ' Check that lip and vcd files exist
                            ' We will use them in any case
                            foundLip = FileExists(strLipsFullPath + "line" + linenum.ToString() + "_col_e.lip")
                            foundVCD = FileExists(strVCDFullPath + "line" + linenum.ToString() + "_col_e.vcd")

                            ' Check that lip and vcd files exist for female
                            foundLipFem = FileExists(strLipsFullPath + "line" + linenum.ToString() + "_col_f.lip")
                            foundVCDFem = FileExists(strVCDFullPath + "line" + linenum.ToString() + "_col_f.vcd")

                            If (strMaleText = strFemaleText) Or strFemaleText Is Nothing Or strFemaleText.Length = 0 Then
                                ''''''''' We have the same dialogue for male and female

                                If foundLip And foundVCD Then
                                    'txtReport.Text += "FOUND: Lip and VCD files for line: " + linenum.ToString() + vbCrLf

                                    ' We need to translate the lip file
                                    Translate(strLipsFullPath + "line" + linenum.ToString() + "_col_e.lip",
                                              strResultFullPath + "line" + linenum.ToString() + "_col_e.lip",
                                              strMaleText)

                                    ' I found in very specific cases or because of the spanish translation,
                                    ' that there is female file (although in spanish we don't need it).
                                    ' We will translate it anyway just in case.
                                    If foundLipFem Then
                                        Translate(strLipsFullPath + "line" + linenum.ToString() + "_col_f.lip",
                                                  strResultFullPath + "line" + linenum.ToString() + "_col_f.lip",
                                                  strFemaleText)

                                        txtReport.Text += "TRANSLATED EXCEPTION: Lip Female file for line: " + linenum.ToString() + vbCrLf
                                    End If

                                    txtReport.Text += "TRANSLATED EQUAL: Lip Male file for line: " + linenum.ToString() + vbCrLf
                                Else
                                    If Not foundLip And Not foundVCD Then
                                        If strMaleText.Length > 0 Or strFemaleText.Length > 0 Then
                                            txtReport.Text += "NOT FOUND: Lip and VCD files for line: " + linenum.ToString() + vbCrLf
                                        End If
                                    Else
                                        If foundVCD Then
                                            ' If both texts (everybody, female) have no text, we will not write the issue.
                                            If frmVtMBTranslator.dgvDLG1.Rows(numrows).Cells(1).Value.Length <> 0 Or
                                               frmVtMBTranslator.dgvDLG1.Rows(numrows).Cells(2).Value.Length <> 0 Then

                                                txtReport.Text += "ISSUE: Found VCD (but NOT Lip) file for line: " + linenum.ToString() + vbCrLf
                                            End If
                                        Else
                                            txtReport.Text += "ISSUE: Found Lip (but NOT VCD) file for line: " + linenum.ToString() + vbCrLf

                                            ' We need to translate the lip file
                                            Translate(strLipsFullPath + "line" + linenum.ToString() + "_col_e.lip",
                                                      strResultFullPath + "line" + linenum.ToString() + "_col_e.lip",
                                                      strMaleText)

                                            txtReport.Text += "TRANSLATED EQUAL: Lip Male file for line: " + linenum.ToString() + vbCrLf

                                            ' We should create the VCD file? This should happen?
                                        End If
                                    End If
                                End If
                            Else
                                ''''''''' We have different dialogue for male and female

                                ' Check female lip file. If there is not, duplicate the male lip file.
                                If Not foundLipFem Then
                                    ' Check if male lip file. If there is not, show message
                                    If Not foundLip Then
                                        If strMaleText.Length > 0 Or strFemaleText.Length > 0 Then
                                            txtReport.Text += "NOT FOUND: Lip Male AND Female files for line: " + linenum.ToString() + vbCrLf
                                        End If
                                    Else
                                        ' We translate the male lip file with the female dialogue line and save it as female lip file
                                        Translate(strLipsFullPath + "line" + linenum.ToString() + "_col_e.lip",
                                                strResultFullPath + "line" + linenum.ToString() + "_col_f.lip",
                                                strFemaleText)

                                        ' We translate also the male lip file with the male dialogue line and save it as male lip file
                                        Translate(strLipsFullPath + "line" + linenum.ToString() + "_col_e.lip",
                                                  strResultFullPath + "line" + linenum.ToString() + "_col_e.lip",
                                                  strMaleText)

                                        ' We need to copy also the VCD file for female.
                                        If Not foundVCDFem Then
                                            ProcessVCD(strVCDFullPath + "line" + linenum.ToString() + "_col_",
                                                       strMP3FullPath + "line" + linenum.ToString() + "_col_",
                                                       strResultFullPath + "line" + linenum.ToString() + "_col_",
                                                       linenum)
                                            'CopyFile(strVCDFullPath + "line" + linenum.ToString() + "_col_e.vcd",
                                            '         strResultFullPath + "line" + linenum.ToString() + "_col_f.vcd")
                                        End If

                                        txtReport.Text += "TRANSLATED DISTINCT: Lip Male AND Female (From Female) files for line: " + linenum.ToString() + vbCrLf
                                    End If
                                Else
                                    ' We translate the female lip file with the female dialogue line and save it as female lip file
                                    Translate(strLipsFullPath + "line" + linenum.ToString() + "_col_f.lip",
                                              strResultFullPath + "line" + linenum.ToString() + "_col_f.lip",
                                              strFemaleText)

                                    If foundLip Then
                                        ' There is also male lip file.
                                        ' We translate the male lip file with the male dialogue line and save it as male lip file
                                        Translate(strLipsFullPath + "line" + linenum.ToString() + "_col_e.lip",
                                                  strResultFullPath + "line" + linenum.ToString() + "_col_e.lip",
                                                  strMaleText)

                                        txtReport.Text += "TRANSLATED DISTINCT: Lip Male AND Female files for line: " + linenum.ToString() + vbCrLf
                                    Else
                                        ' There is only female lip file.
                                        ' Here we don't translate antyhing, only add the report line
                                        txtReport.Text += "TRANSLATED ONLY: Lip Female file for line: " + linenum.ToString() + vbCrLf
                                    End If

                                    ' We check just in case if there is VCD file for female dialogue.
                                    ' If not, we will copy also the VCD Male file for VCD Female.
                                    If Not foundVCDFem Then
                                        ProcessVCD(strVCDFullPath + "line" + linenum.ToString() + "_col_",
                                                   strMP3FullPath + "line" + linenum.ToString() + "_col_",
                                                   strResultFullPath + "line" + linenum.ToString() + "_col_",
                                                   linenum)

                                    End If

                                End If

                            End If
                        End If

                        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        ' This part is for clans lines
                        ' Here there are not male/female lines. So, we will do one-step processing
                        ' We weill do this ONLY for Nosferatu and Ventrue lines (seems there are only this ones)
                        ' Nosferatu (column 8, begin with 0) and Ventrue (column 11, begin with 0)
                        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                        ' This is for Ventrue
                        If Trim(frmVtMBTranslator.dgvDLG1.Rows(numrows).Cells(11).Value.Replace(vbTab, "")).Length > 0 Then
                            ' Found line that should have voiced dialogue
                            strMaleText = PreProcessText(frmVtMBTranslator.dgvDLG1.Rows(numrows).Cells(11).Value)

                            ' Check that lip and vcd files exist
                            ' We will use them in any case
                            foundLip = FileExists(strLipsFullPath + "line" + linenum.ToString() + "_col_m.lip")

                            If foundLip Then
                                ' We translate the lip file
                                Translate(strLipsFullPath + "line" + linenum.ToString() + "_col_m.lip",
                                          strResultFullPath + "line" + linenum.ToString() + "_col_m.lip",
                                          strMaleText)

                                txtReport.Text += "TRANSLATED VENTRUE: Lip file for line: " + linenum.ToString() + vbCrLf
                            End If
                        End If

                        ' This is for Malkavian
                        If Trim(frmVtMBTranslator.dgvDLG1.Rows(numrows).Cells(12).Value.Replace(vbTab, "")).Length > 0 Then
                            ' Found line that should have voiced dialogue
                            strMaleText = PreProcessText(frmVtMBTranslator.dgvDLG1.Rows(numrows).Cells(12).Value)

                            ' Check that lip and vcd files exist
                            ' We will use them in any case
                            foundLip = FileExists(strLipsFullPath + "line" + linenum.ToString() + "_col_n.lip")

                            If foundLip Then
                                ' We translate the lip file
                                Translate(strLipsFullPath + "line" + linenum.ToString() + "_col_n.lip",
                                          strResultFullPath + "line" + linenum.ToString() + "_col_n.lip",
                                          strMaleText)

                                txtReport.Text += "TRANSLATED MALKAVIAN: Lip file for line: " + linenum.ToString() + vbCrLf
                            End If
                        End If
                    End If
                Next
            Catch ex As Exception
                MsgBox("There has been some issue translating the Lips files." + vbCrLf +
                       "Exception: " + ex.Message,
                       vbOK,
                       "Exception")
                Return
            End Try

        End If
    End Sub

    Private Sub frmLipsUpdater_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)

        If Not frmVtMBTranslator.FT.strLipsFolder Is Nothing And frmVtMBTranslator.FT.strLipsFolder.Length > 0 Then
            If DirectoryExists(frmVtMBTranslator.FT.strLipsFolder) Then
                txtLipsPath.Text = frmVtMBTranslator.FT.strLipsFolder
            End If
        End If

        If Not frmVtMBTranslator.FT.strVCDFolder Is Nothing And frmVtMBTranslator.FT.strVCDFolder.Length > 0 Then
            If DirectoryExists(frmVtMBTranslator.FT.strVCDFolder) Then
                txtVCDPath.Text = frmVtMBTranslator.FT.strVCDFolder
            End If
        End If

        If Not frmVtMBTranslator.FT.strMP3Folder Is Nothing And frmVtMBTranslator.FT.strMP3Folder.Length > 0 Then
            If DirectoryExists(frmVtMBTranslator.FT.strMP3Folder) Then
                txtMP3Path.Text = frmVtMBTranslator.FT.strMP3Folder
            End If
        End If

        If Not frmVtMBTranslator.FT.strResultFolder Is Nothing And frmVtMBTranslator.FT.strResultFolder.Length > 0 Then
            If DirectoryExists(frmVtMBTranslator.FT.strResultFolder) Then
                txtResultPath.Text = frmVtMBTranslator.FT.strResultFolder
            End If
        End If
    End Sub

    Private Sub frmLipsUpdater_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.Opacity = 1
    End Sub

    Private Sub frmEveryoneData_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        Me.Owner = frmVtMBTranslator
    End Sub

    Private Sub frmLipsUpdater_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        Me.BringToFront()
    End Sub

    Private Sub btnCopySpeakerName_Click(sender As Object, e As EventArgs) Handles btnCopySpeakerName.Click
        txtSpeakerName.Text = txtSpeakerNameTrans.Text
    End Sub
End Class