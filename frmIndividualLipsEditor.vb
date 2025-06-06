Imports Microsoft.WindowsAPICodePack.Dialogs
Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmIndividualLipsEditor
    Public txtChanged As Boolean = False
    Public imageList As ImageList
    Public formLoaded As Boolean = False
    Public strLipLines() As String
    Public iPHRASENumLine, iSpeakernameNumLine As Integer
    Public speakernameOriginal As String
    Public previousNode As TreeNode

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If txtChanged Then
            If MsgBox("The PHRASE or Speaker Name texts have been changed. Do you want to close Individual Lip Editor form?", vbOKCancel, "Warning") = vbCancel Then
                Exit Sub
            End If
        End If

        frmVtMBTranslator.IndividualLipsEditorActive = False
        Me.Close()
    End Sub


    Private Sub AddDirectories(parentNode As TreeNode)
        ' Get the path of the parent node
        Dim path = DirectCast(parentNode.Tag, String)

        ' Get the directories in the current path
        Dim directories = Directory.GetDirectories(path)

        ' Add child nodes for each directory
        For Each dir As String In directories
            Dim directoryNode = New TreeNode(IO.Path.GetFileName(dir)) With {
                                                                                .Tag = dir,
                                                                                .ImageIndex = 0,
                                                                                .SelectedImageIndex = 0,
                                                                                .ForeColor = Color.MidnightBlue
                                                                            }

            parentNode.Nodes.Add(directoryNode)

            Try
                ' Recursively add child nodes for subdirectories
                AddDirectories(directoryNode)

                ' Get the files in the current directory
                Dim files = IO.Directory.GetFiles(dir, "*.lip")

                ' Add child nodes for each file
                For Each file In files
                    Dim fileNode = New TreeNode(IO.Path.GetFileName(file)) With {
                                                                                    .Tag = file,
                                                                                    .ImageIndex = 2,
                                                                                    .SelectedImageIndex = 2,
                                                                                    .ForeColor = Color.DarkGreen
                                                                                }
                    directoryNode.Nodes.Add(fileNode)
                Next

            Catch invalidAccessEx As UnauthorizedAccessException
                directoryNode.ForeColor = Color.Red
            End Try
        Next
    End Sub


    Public Sub PrepareTVIndividualLips()
        If txtIndividualLipsPath.Text.Length > 0 Then

            ' Clear the TreeView control
            tvLipsEditor.Nodes.Clear()

            ' Create the root node for the TreeView
            Dim rootNode = New TreeNode(txtIndividualLipsPath.Text) With {.Tag = txtIndividualLipsPath.Text}
            tvLipsEditor.Nodes.Add(rootNode)

            ' Recursively add child nodes for directories and their files
            AddDirectories(rootNode)

            ' Select first node
            tvLipsEditor.SelectedNode = tvLipsEditor.Nodes(0)
        End If
    End Sub


    Private Sub btnLipsPath_Click(sender As Object, e As EventArgs) Handles btnLipsPath.Click
        Dim cofdLipsPath As CommonOpenFileDialog = New CommonOpenFileDialog()

        cofdLipsPath.Title = "Select Individual Lips path"
        cofdLipsPath.IsFolderPicker = True

        If txtIndividualLipsPath.Text.Length > 0 And DirectoryExists(txtIndividualLipsPath.Text) Then
            cofdLipsPath.InitialDirectory = txtIndividualLipsPath.Text
        Else
            cofdLipsPath.InitialDirectory = frmVtMBTranslator.FT.strGlobalPath
        End If

        If cofdLipsPath.ShowDialog() = CommonFileDialogResult.Ok Then
            txtIndividualLipsPath.Text = cofdLipsPath.FileName

            frmVtMBTranslator.FT.strIndividualLipsFolder = txtIndividualLipsPath.Text
            frmVtMBTranslator.FT.WriteCFGFile()

            ' Now we need to prepare the TreeView
            PrepareTVIndividualLips()
        End If

        Me.Focus()
    End Sub


    Private Sub frmIndividualLipsEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set Icon
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)

        ' Set config values
        Me.Width = frmVtMBTranslator.FT.iIndividualLipsEditorWidth
        Me.Height = frmVtMBTranslator.FT.iIndividualLipsEditorHeight

        If frmVtMBTranslator.FT.iIndividualLipsEditorXPos <> -1 And frmVtMBTranslator.FT.iIndividualLipsEditorYPos <> -1 Then
            Me.StartPosition = FormStartPosition.Manual
            Me.Location = New Point(frmVtMBTranslator.FT.iIndividualLipsEditorXPos, frmVtMBTranslator.FT.iIndividualLipsEditorYPos)
        Else
            Me.StartPosition = FormStartPosition.CenterScreen
        End If

        ' Load TreeView Icons
        imageList = New ImageList()
        imageList.Images.Add(My.Resources.folderclosed)
        imageList.Images.Add(My.Resources.folderopen)
        imageList.Images.Add(My.Resources.document)

        tvLipsEditor.ImageList = imageList

        If Not frmVtMBTranslator.FT.strIndividualLipsFolder Is Nothing Then
            If frmVtMBTranslator.FT.strIndividualLipsFolder.Length > 0 Then
                If DirectoryExists(frmVtMBTranslator.FT.strIndividualLipsFolder) Then
                    txtIndividualLipsPath.Text = frmVtMBTranslator.FT.strIndividualLipsFolder

                    PrepareTVIndividualLips()

                    previousNode = tvLipsEditor.SelectedNode

                End If
            End If
        End If

        formLoaded = True
    End Sub

    Private Sub frmIndividualLipsEditor_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.Opacity = 1
    End Sub

    Private Sub frmIndividualLipsEditor_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        Me.Owner = frmVtMBTranslator
    End Sub

    Private Sub frmIndividualLipsEditor_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        Me.BringToFront()
    End Sub

    Private Sub tvLipsEditor_AfterExpand(sender As Object, e As TreeViewEventArgs) Handles tvLipsEditor.AfterExpand
        e.Node.ImageIndex = 1
        e.Node.SelectedImageIndex = 1
    End Sub

    Private Sub tvLipsEditor_AfterCollapse(sender As Object, e As TreeViewEventArgs) Handles tvLipsEditor.AfterCollapse
        e.Node.ImageIndex = 0
        e.Node.SelectedImageIndex = 0
    End Sub


    Private Sub txtTranslatePHRASE_Leave(sender As Object, e As EventArgs) Handles txtTranslatePHRASE.Leave
        If txtTranslatePHRASE.Text <> txtOriginalPHRASE.Text Or txtSpeakerName.Text <> speakernameOriginal Then
            txtChanged = True
        Else
            txtChanged = False
        End If

        UpdateBtnValidate()
    End Sub

    Private Sub txtSpeakerName_Leave(sender As Object, e As EventArgs) Handles txtSpeakerName.Leave
        If txtTranslatePHRASE.Text <> txtOriginalPHRASE.Text Or txtSpeakerName.Text <> speakernameOriginal Then
            txtChanged = True
        Else
            txtChanged = False
        End If

        UpdateBtnValidate()
    End Sub


    Private Sub frmIndividualLipsEditor_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
        If Not formLoaded Then Return

        ' Save values in settings
        If Me.Location.X > 0 Then frmVtMBTranslator.FT.iIndividualLipsEditorXPos = Me.Location.X
        If Me.Location.Y > 0 Then frmVtMBTranslator.FT.iIndividualLipsEditorYPos = Me.Location.Y

        frmVtMBTranslator.FT.WriteCFGFile()
    End Sub

    Private Sub frmIndividualLipsEditor_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Not formLoaded Then Return

        ' Save values in settings
        If Me.Width > 0 Then frmVtMBTranslator.FT.iIndividualLipsEditorWidth = Me.Width
        If Me.Height > 0 Then frmVtMBTranslator.FT.iIndividualLipsEditorHeight = Me.Height

        frmVtMBTranslator.FT.WriteCFGFile()
    End Sub


    Private Sub tvLipsEditor_BeforeSelect(sender As Object, e As TreeViewCancelEventArgs) Handles tvLipsEditor.BeforeSelect
        If Not CanWeChangeNode(e.Node.Tag) Then
            e.Cancel = True
        End If

        If Not previousNode Is Nothing Then
            If File.Exists(e.Node.Tag) Then
                previousNode.ForeColor = Color.DarkGreen
                previousNode.BackColor = Color.AliceBlue
            End If
        End If
    End Sub


    Private Sub tvLipsEditor_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvLipsEditor.AfterSelect
        txtFilePath.Text = ""
        txtTranslatePHRASE.Text = ""
        txtOriginalPHRASE.Text = ""
        txtSpeakerName.Text = ""
        speakernameOriginal = ""

        If Not previousNode Is Nothing Then
            If File.Exists(e.Node.Tag) Then
                previousNode = e.Node
                e.Node.ForeColor = Color.Moccasin
                e.Node.BackColor = Color.DarkSlateGray
            End If
        End If

        PrepareSelectedNode(e.Node.Tag)
    End Sub


    Public Function CanWeChangeNode(ByVal strNodeTag As String) As Boolean
        Dim bCanWeChangeNode As Boolean = True
        Dim msgboxResult As MsgBoxResult

        ' Here we will check if we have some of the weird lip files like the "radio_loop" lip files.
        If InStr(strNodeTag, "radio_loop") > 0 Then
            MsgBox("The radio_loop lip files are not supported by this tool.", vbOKOnly, "Information")

            bCanWeChangeNode = False
        End If

        If txtChanged Then
            ' Question if you want to save the lip file before changing it
            msgboxResult = MsgBox("The PHRASE or Speaker Name texts have been changed. " + vbCrLf +
                                  "Do you want to save the file and select the new item (Yes), don't save the file " +
                                  "and select the new item (No) or continue editing the actual item (Cancel)?",
                                  vbYesNoCancel,
                                  "Question")

            If msgboxResult = MsgBoxResult.Yes Then
                btnValidate.PerformClick()
            Else
                If msgboxResult = MsgBoxResult.No Then
                    txtChanged = False
                    UpdateBtnValidate()
                Else
                    bCanWeChangeNode = False
                End If
            End If
        End If

        Return bCanWeChangeNode
    End Function


    Public Function GetPHRASEText(ByVal strLipLine As String) As String
        Dim strPHRASEText As String = ""
        Dim indexIni, indexEnd As Integer

        ' Let's see if we must read an unicode string or char
        If InStr(strLipLine, "char") Then
            indexIni = InStr(strLipLine, """")
            indexEnd = InStrRev(strLipLine, """")
        Else
            ' This will help to erase the nulls when using unicode characters.
            ' Maybe we should treat that nulls, but as I'm not sure, I decided
            ' to leave it as is.
            strLipLine = strLipLine.Replace(vbNullChar, "")
            indexIni = InStr(16, strLipLine, " ")
            indexEnd = InStrRev(strLipLine, " ") - 1
            indexEnd = InStrRev(strLipLine, " ", indexEnd)
        End If

        strPHRASEText = strLipLine.Substring(indexIni, indexEnd - indexIni - 1)

        Return strPHRASEText
    End Function


    Public Sub PrepareSelectedNode(ByVal strNodeTag As String)

        Try
            If FileExists(strNodeTag) Then
                ' Set the name in filename text box
                txtFilePath.Text = strNodeTag

                ' Open lip file and show the PHRASE in text box
                strLipLines = File.ReadAllLines(strNodeTag,
                                                System.Text.Encoding.GetEncoding(frmVtMBTranslator.ISO_8859_1))

                ' Now we search the line we need to update (search PHRASE word)
                iPHRASENumLine = frmLipsUpdater.GetPHRASELine(strLipLines)

                If iPHRASENumLine > -1 Then

                    txtTranslatePHRASE.Text = GetPHRASEText(strLipLines(iPHRASENumLine))
                    txtOriginalPHRASE.Text = txtTranslatePHRASE.Text

                    ' Now we need to get the Speaker
                    iSpeakernameNumLine = frmLipsUpdater.GetSpeakerLine(strLipLines)

                    If iSpeakernameNumLine > -1 Then
                        txtSpeakerName.Text = frmLipsUpdater.GetSpeakerNameText(strLipLines)
                        speakernameOriginal = txtSpeakerName.Text
                    Else
                        Throw New ArgumentException("The speaker_name keyword has not been found.")
                    End If
                Else
                    Throw New ArgumentException("The PHRASE keyword has not been found.")
                End If
            End If
        Catch ex As Exception
            MsgBox("There has been some problem when reading the .lip file: " + strNodeTag + vbCrLf +
                   ex.Message,
                   vbOKOnly,
                   "Exception")

            Return
        End Try
    End Sub

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        ' Here we will save the lips file
        ' First we need to know if there is any file loaded.
        ' We can do that checking the length of the original text string (supposedly we have loaded text)
        Try
            If txtOriginalPHRASE.Text.Length > 0 Then
                ' First we update the PHRASE
                strLipLines(iPHRASENumLine) = frmLipsUpdater.SetPHRASELine(txtTranslatePHRASE.Text, strLipLines(iPHRASENumLine).Split(" "))

                ' Second we update the Speaker Name
                strLipLines(iSpeakernameNumLine) = "speaker_name" + " " + txtSpeakerName.Text

                ' Finally se save the lip file
                frmLipsUpdater.WriteLipFile(txtFilePath.Text, strLipLines)

                ' Update some vars and things
                txtOriginalPHRASE.Text = txtTranslatePHRASE.Text
                speakernameOriginal = txtSpeakerName.Text
                txtChanged = False
                UpdateBtnValidate()

                tvLipsEditor.Focus()
            End If
        Catch ex As Exception
            MsgBox("There has been some problem validating the .lip file: " + txtFilePath.Text + vbCrLf +
                   ex.Message,
                   vbOK,
                   "Exception")

            Return
        End Try
    End Sub

    Private Sub btnTranslateDeepL_Click(sender As Object, e As EventArgs) Handles btnTranslateDeepL.Click
        Dim strTranslatedResult As String = ""

        If txtTranslatePHRASE.Text.Length > 0 Then
            strTranslatedResult = frmVtMBTranslator.TranslateDEEPL(txtTranslatePHRASE.Text)
        End If

        If strTranslatedResult <> "" Then
            txtTranslatePHRASE.Text = strTranslatedResult

            If Text <> txtOriginalPHRASE.Text Or txtSpeakerName.Text <> speakernameOriginal Then
                txtChanged = True
            Else
                txtChanged = False
            End If

            UpdateBtnValidate()

            txtTranslatePHRASE.Focus()
        End If
    End Sub



    Private Sub UpdateBtnValidate()
        If txtChanged Then
            btnValidate.Text = "Validate (*)"
        Else
            btnValidate.Text = "Validate"
        End If

    End Sub
End Class