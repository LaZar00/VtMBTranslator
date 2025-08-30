Option Explicit On
Imports System.ComponentModel
Imports System.IO
Imports System.Net.Http
Imports System.Reflection
Imports System.Text.Json


Public Class frmVtMBTranslator

    Public Const ISO_8859_1 As Integer = 28591
    Public FT As New FileTools

    ' Global variables file

    Public NUM_COLUMNS As Integer = 13
    Public numRowsDLG1, numRowsDLG2, rightclickRow As Integer
    Public col1CompareString, col2CompareString As Integer
    Public scrollDLG1, scrollDLG2, DLGFile, dgvDLG1Changed As Boolean
    Public EditEveryoneActive, EditClansActive, EditClans, LookUpReferentsActive, LipsUpdaterActive, IndividualLipsEditorActive As Boolean
    Public frmActivateMouse As Boolean = False
    Public formLoaded As Boolean = False

    ' Find string values
    Public searchRow, oldsearchRow As Integer
    Public searchText As String = String.Empty
    Public cbSearchEnabled As Boolean = False


    Private Function downloadAssembly(
        ByVal sender As Object,
        ByVal args As System.ResolveEventArgs) As System.Reflection.Assembly

        Dim resourceName As String = "AssemblyLoadingAndReflection." &
                                            New AssemblyName(args.Name).Name & ".dll"

        ' Avoid find "Microsoft.WindowsAPICodePack" dlls
        If InStr(resourceName, "Microsoft.WindowsAPICodePack") = 0 Then
            Using stream = System.Reflection.Assembly.GetExecutingAssembly() _
                                                .GetManifestResourceStream(resourceName)

                Dim assemblyData(CInt(stream.Length - 1)) As Byte

                stream.Read(assemblyData, 0, assemblyData.Length)

                Return System.Reflection.Assembly.Load(assemblyData)

            End Using
        End If
    End Function


    Public Sub EnableDoubleBuffered(ByVal dgv As DataGridView)

        Dim dgvType As Type = dgv.[GetType]()
        Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered",
                                                     BindingFlags.Instance Or BindingFlags.NonPublic)

        pi.SetValue(dgv, True, Nothing)

    End Sub


    Private Sub frmVtMBTranslator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Resolve assemblies
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf Me.downloadAssembly

        ' Set Icon
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)

        scrollDLG1 = False
        scrollDLG2 = False
        dgvDLG1Changed = False

        EnableDoubleBuffered(dgvDLG1)
        EnableDoubleBuffered(dgvDLG2)

        ' Set .CFG file settings
        FT.strGlobalPath = Application.StartupPath
        FT.ReadCFGFile()

        If FT.bUnicode Then
            cbEncoding.SelectedIndex = 1
        Else
            cbEncoding.SelectedIndex = 0
        End If

        If (cbCodepage.Items.IndexOf(FT.iCodepageDLGLanguage.ToString()) <> -1) Then
            cbCodepage.SelectedIndex = cbCodepage.Items.IndexOf(FT.iCodepageDLGLanguage.ToString())
        ElseIf (cbCodepage.Items.IndexOf(My.Computer.Registry.
                                                GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Nls\CodePage",
                                                         "ACP", Nothing).ToString()) <> -1) Then
            cbCodepage.SelectedIndex = cbCodepage.Items.IndexOf(My.Computer.Registry.
                                                GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Nls\CodePage",
                                                         "ACP", Nothing).ToString())
        Else    ' We will use as Default Windows-1252
            cbCodepage.SelectedIndex = cbCodepage.Items.IndexOf("1252")
        End If

        For i = 1 To dgvDLG1.ColumnCount - 1
            dgvDLG1.Columns(i).Width = FT.strColumnsdgvDLG1Widths.Split("#")(i - 1)
        Next

        If (FT.bMaximized) Then
            Me.WindowState = FormWindowState.Maximized

            splcontDGV.SplitterDistance = 'dgvDLG1.Columns(0).Width +
                                          dgvDLG1.Columns(1).Width +
                                          dgvDLG1.Columns(2).Width +
                                          dgvDLG1.Columns(3).Width +
                                          dgvDLG1.Columns(4).Width +
                                          dgvDLG1.Columns(5).Width +
                                          dgvDLG1.Columns(6).Width +
                                          dgvDLG1.Columns(7).Width +
                                          dgvDLG1.Columns(8).Width +
                                          dgvDLG1.Columns(9).Width +
                                          dgvDLG1.Columns(10).Width +
                                          dgvDLG1.Columns(11).Width +
                                          dgvDLG1.Columns(12).Width + 10 + 80
        Else
            Me.WindowState = FormWindowState.Normal

            splcontDGV.SplitterDistance = (splcontDGV.Width / 2) - (splcontDGV.SplitterWidth / 2)
        End If

        formLoaded = True

    End Sub


    Public Sub CheckLineOpenings(ByVal strLine As String, ByVal row As Integer)
        Dim i, openCounter, closeCounter As Integer
        Dim inconsistenceFound As Boolean

        openCounter = 0
        closeCounter = 0
        inconsistenceFound = False

        While Not inconsistenceFound And i < strLine.Length
            If strLine(i) = "{" Then
                openCounter = openCounter + 1
            End If

            If strLine(i) = "}" Then
                closeCounter = closeCounter + 1

                If (openCounter - closeCounter) <> 0 Then
                    inconsistenceFound = True
                End If
            End If

            i = i + 1
        End While

        If inconsistenceFound Then
            txtReport.AppendText("Possible syntax inconsistence found in row: " +
                                 (row + 1).ToString() + ".  Opened left brackeds: " + openCounter.ToString() +
                                 ".  Closed right brackets: " + closeCounter.ToString() + vbCrLf)
        End If
    End Sub


    Function CheckClansText(line As Array) As Boolean
        Dim result As Boolean
        result = False

        If line(6).ToString().Length > 3 Or line(7).ToString().Length Or
           line(8).ToString().Length > 3 Or line(9).ToString().Length Or
           line(10).ToString().Length > 3 Or line(11).ToString().Length Or
           line(12).ToString().Length > 3 Then

            result = True
        End If

        Return result
    End Function


    Public Sub putDLGinGRID(ByVal loadDLG As String, ByRef dgvDLG As DataGridView, ByRef numRows As Integer)
        Dim nColumn As Integer
        Dim strLine As String

        ' Clear DataGridView
        dgvDLG.Rows.Clear()
        EditClans = False

        ' Dim strLines() As String = File.ReadAllLines(loadDLG, System.Text.Encoding.GetEncoding(ISO_8859_1))
        Dim strLines() As String = File.ReadAllLines(loadDLG, System.Text.Encoding.GetEncoding(FT.iCodepageDLGLanguage))

        dgvDLG.RowHeadersVisible = False
        numRows = 0

        For Each strLine In strLines
            CheckLineOpenings(strLine, numRows)

            ' Check if we have a line with data
            If Trim(strLine.Replace(vbTab, "")).Length > 0 Then
                strLine = strLine.Replace("{", "")
                Dim line = strLine.Split(CChar("}")).ToArray

                nColumn = 0

                ' Create new Row
                Dim row As New DataGridViewRow
                With row
                    .CreateCells(dgvDLG)
                    .Cells(0).Value = DBNull.Value
                End With
                dgvDLG.Rows.Add(row)

                For nColumn = 0 To NUM_COLUMNS - 1
                    dgvDLG.Rows(numRows).Cells(nColumn).Value = Trim(line(nColumn).Replace(vbTab, ""))
                Next

                If Not EditClans Then
                    EditClans = CheckClansText(line)
                End If

                'dgvDLG.Rows(numRows).HeaderCell.Value = (numRows + 1).ToString()
                numRows = numRows + 1
            End If
        Next

        dgvDLG.CurrentCell = dgvDLG.Rows(0).Cells(0)

        txtLoadingLine.Text = numRows

        'dgvDLG.RowHeadersVisible = True

    End Sub


    Private Sub btnLoadDLG1_Click(sender As Object, e As EventArgs) Handles btnLoadDLG1.Click
        If dgvDLG1Changed Then
            If MsgBox("Data in Primary grid has changed and it has not been saved. Do you really want to load another file?", vbOKCancel, "Warning") = vbCancel Then
                Exit Sub
            End If
        End If

        ' Set filter options and filter index.
        loadDLG.Title = "Open DLG"
        loadDLG.Filter = "DLG Files (*.DLG)|*.DLG|All Files (*.*)|*.*"
        loadDLG.FilterIndex = 1
        loadDLG.FileName = Nothing

        loadDLG.InitialDirectory = FT.strGlobalPath

        If Not FT.strPrimaryDLGPath Is Nothing Then
            loadDLG.InitialDirectory = FT.strPrimaryDLGPath
        End If

        Try
            ' Process input if the user clicked OK.
            If loadDLG.ShowDialog = DialogResult.OK Then
                If (Path.GetExtension(loadDLG.FileName) = ".dlg") Then
                    col1CompareString = 1
                    col2CompareString = 2

                    DLGFile = True

                    ' Update columns name.
                    With dgvDLG1
                        .Columns(0).HeaderText = "Num"
                        .Columns(1).HeaderText = "Male"
                        .Columns(2).HeaderText = "Female"
                        .Columns(3).HeaderText = "Jump"
                        .Columns(4).HeaderText = "Condition"
                        .Columns(5).HeaderText = "ExecPy"
                        .Columns(6).HeaderText = "Brujah"
                        .Columns(7).HeaderText = "Gangrel"
                        .Columns(8).HeaderText = "Nosferatu"
                        .Columns(9).HeaderText = "Toreador"
                        .Columns(10).HeaderText = "Tremere"
                        .Columns(11).HeaderText = "Ventrue"
                        .Columns(12).HeaderText = "Malkavian"
                    End With

                    With dgvDLG2
                        .Columns(0).HeaderText = "Num"
                        .Columns(1).HeaderText = "Male"
                        .Columns(2).HeaderText = "Female"
                        .Columns(3).HeaderText = "Jump"
                        .Columns(4).HeaderText = "Condition"
                        .Columns(5).HeaderText = "ExecPy"
                        .Columns(6).HeaderText = "Brujah"
                        .Columns(7).HeaderText = "Gangrel"
                        .Columns(8).HeaderText = "Nosferatu"
                        .Columns(9).HeaderText = "Toreador"
                        .Columns(10).HeaderText = "Tremere"
                        .Columns(11).HeaderText = "Ventrue"
                        .Columns(12).HeaderText = "Malkavian"
                    End With
                Else
                    MsgBox("The file is not a .DLG. You should open another.", , "Warning")
                    Exit Sub
                End If

                If File.Exists(loadDLG.FileName) Then
                    scrollDLG1 = False

                    putDLGinGRID(loadDLG.FileName, dgvDLG1, numRowsDLG1)

                    If Not scrollDLG2 Then btnCompClans.Enabled = False

                    FT.strPrimaryDLGPath = Path.GetDirectoryName(loadDLG.FileName)
                    FT.WriteCFGFile()
                    txtDLG1.Text = loadDLG.FileName

                    ' Activate more things
                    scrollDLG1 = True
                    EditEveryoneActive = False
                    EditClansActive = False
                    LipsUpdaterActive = False
                    LookUpReferentsActive = False
                    IndividualLipsEditorActive = False

                    txtSections.Text = NUM_COLUMNS

                    dgvDLG1Changed = False
                    btnLoadDLG2.Enabled = True

                    btnEditEveryone.Enabled = True
                    btnEditClans.Enabled = EditClans

                    btnSaveAsDLG1.Enabled = True
                    btnSaveDLG1.Enabled = True
                    btnUpdateLips.Enabled = True
                    cmsdgvDLG1.Enabled = True
                    btnGTCL.Enabled = True
                    btnFS.Enabled = True
                    cmsdgvDLG1.Items(0).Enabled = True
                    cmsdgvDLG1.Items(1).Enabled = True
                    cmsdgvDLG1.Items(2).Enabled = True
                    cmsdgvDLG1.Items(3).Enabled = True

                    ' Other forms initializations
                    frmLipsUpdater.btnTranslateLips.Enabled = False
                    frmLipsUpdater.txtSpeakerName.Text = ""
                    frmLipsUpdater.txtSpeakerName.Enabled = False
                    frmLipsUpdater.txtReport.Clear()

                    ' Synchronize Datagrids Selection
                    dgvDLG1.FirstDisplayedScrollingRowIndex = 0
                    If (numRowsDLG2 > 0) Then
                        dgvDLG2.FirstDisplayedScrollingRowIndex = 0
                        dgvDLG2.CurrentCell = dgvDLG2.Rows(dgvDLG1.CurrentRow.Index).Cells(dgvDLG1.CurrentCell.ColumnIndex)
                        dgvDLG2.FirstDisplayedScrollingColumnIndex = dgvDLG1.FirstDisplayedScrollingColumnIndex
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error loading Dialog .DLG File." + vbCrLf +
                   "Reading Row: " + numRowsDLG1.ToString() + ".", , "Error")
        End Try
    End Sub


    Private Sub btnLoadDLG2_Click(sender As Object, e As EventArgs) Handles btnLoadDLG2.Click
        ' Set filter options and filter index.
        loadDLG.Title = "Open DLG Secondary File"
        loadDLG.Filter = "DLG Files (*.DLG)|*.DLG|All Files (*.*)|*.*"
        loadDLG.FilterIndex = 1
        loadDLG.FileName = Nothing

        loadDLG.InitialDirectory = FT.strGlobalPath

        If Not FT.strSecondaryDLGPath Is Nothing Then
            loadDLG.InitialDirectory = FT.strSecondaryDLGPath
        End If

        Try
            ' Process input if the user clicked OK.
            If loadDLG.ShowDialog = DialogResult.OK Then
                If File.Exists(loadDLG.FileName) Then
                    scrollDLG2 = False

                    putDLGinGRID(loadDLG.FileName, dgvDLG2, numRowsDLG2)
                    btnCompClans.Enabled = False

                    FT.strSecondaryDLGPath = Path.GetDirectoryName(loadDLG.FileName)
                    FT.WriteCFGFile()
                    txtDLG2.Text = loadDLG.FileName

                    ' Activate things
                    scrollDLG2 = True

                    btnCompEveryone.Enabled = True

                    If EditClans Then
                        btnCompClans.Enabled = EditClans
                    End If

                    btnOPENTE.Enabled = True

                    frmGTCL_FS.cbSearchSecondary.Enabled = True

                    ' Synchronize Datagrids Selection
                    dgvDLG2.FirstDisplayedScrollingRowIndex = dgvDLG1.FirstDisplayedScrollingRowIndex

                    If dgvDLG1.CurrentRow.Index < dgvDLG2.RowCount Then
                        dgvDLG2.CurrentCell = dgvDLG2.Rows(dgvDLG1.CurrentRow.Index).Cells(dgvDLG1.CurrentCell.ColumnIndex)
                        dgvDLG2.FirstDisplayedScrollingColumnIndex = dgvDLG1.FirstDisplayedScrollingColumnIndex
                    End If
                Else
                    MsgBox("Error loading Dialog .DLG File.", , "Error")
                End If
            End If
        Catch
            MsgBox("Error loading Dialog .DLG File." + vbCrLf +
                   "Reading Row: " + numRowsDLG2.ToString() + ".", , "Error")
        End Try

    End Sub


    Public Function CheckSameNumLines() As Boolean
        If (dgvDLG1.RowCount = dgvDLG2.RowCount) Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub CompareNums()
        Dim row As Integer
        Dim resultCompNumOK As Boolean

        resultCompNumOK = True

        For row = 0 To dgvDLG1.RowCount - 1
            If (dgvDLG1.Rows(row).Cells(0).Value <> dgvDLG2.Rows(row).Cells(0).Value) Then
                txtReport.AppendText("Compare Nums: Different Number found [Row: " +
                                     (row + 1).ToString() + "]." + vbTab + vbTab +
                                     "DATA 1: " + dgvDLG1.Rows(row).Cells(0).Value + vbTab +
                                     "DATA 2: " + dgvDLG2.Rows(row).Cells(0).Value + vbCrLf)

                dgvDLG1.Item(0, row).Style.BackColor = Color.LightCoral

                resultCompNumOK = False
            Else
                dgvDLG1.Item(0, row).Style.BackColor = Color.White
            End If
        Next

        If (resultCompNumOK) Then
            txtReport.AppendText("Compare Nums: No issues found." + vbCrLf)
        End If
    End Sub


    Private Sub CompareExtras()
        Dim row As Integer
        Dim resultCompExtrasOK As Boolean

        resultCompExtrasOK = True

        For row = 0 To dgvDLG1.RowCount - 1
            If (dgvDLG1.Rows(row).Cells(7).Value <> dgvDLG2.Rows(row).Cells(7).Value) Then
                txtReport.AppendText("Compare Extras: Different Extras found [Row: " +
                                     (row + 1).ToString() + "]." + vbTab + vbTab +
                                     "DATA 1: " + dgvDLG1.Rows(row).Cells(7).Value + vbTab +
                                     "DATA 2: " + dgvDLG2.Rows(row).Cells(7).Value + vbCrLf)

                resultCompExtrasOK = False
            End If
        Next

        If (resultCompExtrasOK) Then
            txtReport.AppendText("Compare Extras: No issues found." + vbCrLf)
        End If
    End Sub


    Private Sub CompareEveryone()
        Dim row As Integer
        Dim resultCompStringsOK As Boolean
        Dim strDLG1Value, strDLG2Value As String

        resultCompStringsOK = True

        For row = 0 To dgvDLG1.RowCount - 1
            If (row < dgvDLG1.Rows.Count) Then
                If (row < dgvDLG2.Rows.Count) Then
                    strDLG1Value = dgvDLG1.Rows(row).Cells(col1CompareString).Value
                    strDLG2Value = dgvDLG2.Rows(row).Cells(col1CompareString).Value

                    If (Not strDLG1Value Is Nothing And Not strDLG2Value Is Nothing) Then
                        If strDLG1Value <> strDLG2Value Then
                            txtReport.AppendText("Compare Strings: Different Strings maybe found [Row: " +
                                                 (row + 1).ToString() + ", Col: 1, Male]." + vbTab + vbTab +
                                                 "DATA 1: " + dgvDLG1.Rows(row).Cells(col1CompareString).Value + vbTab +
                                                 "DATA 2: " + dgvDLG2.Rows(row).Cells(col1CompareString).Value + vbCrLf)

                            dgvDLG1.Item(col1CompareString, row).Style.BackColor = Color.Violet

                            resultCompStringsOK = False
                        Else
                            dgvDLG1.Item(col1CompareString, row).Style.BackColor = Color.White
                        End If

                        If DLGFile Then
                            strDLG1Value = dgvDLG1.Rows(row).Cells(col2CompareString).Value
                            strDLG2Value = dgvDLG2.Rows(row).Cells(col2CompareString).Value

                            If strDLG1Value <> strDLG2Value Then
                                txtReport.AppendText("Compare Strings: Different Strings maybe found [Row: " +
                                                     (row + 1).ToString() + ", Col: 1, Female]." + vbTab + vbTab +
                                                     "DATA 1: " + dgvDLG1.Rows(row).Cells(col2CompareString).Value + vbTab +
                                                     "DATA 2: " + dgvDLG2.Rows(row).Cells(col2CompareString).Value + vbCrLf)

                                dgvDLG1.Item(col2CompareString, row).Style.BackColor = Color.Violet

                                resultCompStringsOK = False
                            Else
                                dgvDLG1.Item(col2CompareString, row).Style.BackColor = Color.White
                            End If

                        End If
                    End If
                Else
                    strDLG1Value = dgvDLG1.Rows(row).Cells(col1CompareString).Value

                    If (Not strDLG1Value Is Nothing) Then
                        txtReport.AppendText("Compare Strings: String only existant in Left table [Row: " +
                                             (row + 1).ToString() + ", Col: 1, Male]." + vbTab + vbTab +
                                             "DATA 1: " + dgvDLG1.Rows(row).Cells(col1CompareString).Value + vbCrLf)

                        dgvDLG1.Item(col1CompareString, row).Style.BackColor = Color.Violet

                        resultCompStringsOK = False
                    Else
                        dgvDLG1.Item(col1CompareString, row).Style.BackColor = Color.White
                    End If

                    If DLGFile Then
                        strDLG1Value = dgvDLG1.Rows(row).Cells(col2CompareString).Value

                        If Not strDLG1Value Is Nothing Then
                            txtReport.AppendText("Compare Strings: Different Strings maybe found [Row: " +
                                                 (row + 1).ToString() + ", Col: 1, Female]." + vbTab + vbTab +
                                                 "DATA 1: " + dgvDLG1.Rows(row).Cells(col2CompareString).Value + vbCrLf)

                            dgvDLG1.Item(col2CompareString, row).Style.BackColor = Color.Violet

                            resultCompStringsOK = False
                        Else
                            dgvDLG1.Item(col2CompareString, row).Style.BackColor = Color.White
                        End If

                    End If
                End If
            End If
        Next

        If resultCompStringsOK Then
            txtReport.AppendText("Compare Strings: Not found issues with empty strings and/or sizes." + vbCrLf)
        End If
    End Sub

    Private Sub btnCompClans_Click(sender As Object, e As EventArgs) Handles btnCompClans.Click
        Dim row, col As Integer
        Dim resultCompClansOK As Boolean
        Dim strDLG1Value, strDLG2Value As String

        resultCompClansOK = True

        ' Let's look each row if clans (cols from 6 to 12) are equal or not
        For row = 0 To dgvDLG1.RowCount - 1

            If row < dgvDLG2.RowCount Then
                For col = 6 To dgvDLG1.ColumnCount - 1
                    strDLG1Value = dgvDLG1.Rows(row).Cells(col).Value
                    strDLG2Value = dgvDLG2.Rows(row).Cells(col).Value

                    If strDLG1Value <> strDLG2Value Then
                        txtReport.AppendText("Compare Clans: Different Clans maybe found [Row: " +
                                             (row + 1).ToString() + ", Col: " + (col + 1).ToString() + ", Male]." + vbTab + vbTab +
                                             "DATA 1: " + dgvDLG1.Rows(row).Cells(col).Value + vbTab +
                                             "DATA 2: " + dgvDLG2.Rows(row).Cells(col).Value + vbCrLf)

                        dgvDLG1.Item(col, row).Style.BackColor = Color.Violet

                        resultCompClansOK = False
                    Else
                        dgvDLG1.Item(col, row).Style.BackColor = Color.White
                    End If
                Next
            End If
        Next

        If resultCompClansOK Then
            txtReport.AppendText("Compare Clans: Not found issues with empty strings and/or sizes." + vbCrLf)
        End If
    End Sub


    Private Sub btnEDIT_Click(sender As Object, e As EventArgs) Handles btnOPENTE.Click
        ' This will open file in text editor
        Try
            If numRowsDLG1 > 0 And numRowsDLG2 > 0 Then
                If File.Exists(txtDLG1.Text) = True And
                   File.Exists(txtDLG2.Text) = True Then
                    Process.Start(txtDLG1.Text.ToString())
                    Process.Start(txtDLG2.Text.ToString())
                Else
                    MsgBox("Error opening with text editor some of the .DLG/.MES Files.", , "Error")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error opening with text editor some of the .DLG/.MES Files. Maybe there is not associated application with the extension.", , "Error")
        End Try
    End Sub

    Private Sub btnCompEveryone_Click(sender As Object, e As EventArgs) Handles btnCompEveryone.Click
        txtReport.Clear()
        'If CheckSameNumLines() Then
        CompareEveryone()
        'Else
        'txtReport.AppendText("Compare Strings: There are not the same number of rows." + vbCrLf)
        'End If
    End Sub

    Private Sub btnRefresh1_Click(sender As Object, e As EventArgs) Handles btnRefresh1.Click
        If txtDLG1.Text.Length > 0 Then
            If File.Exists(txtDLG1.Text) Then
                scrollDLG1 = False
                putDLGinGRID(txtDLG1.Text, dgvDLG1, numRowsDLG1)
                dgvDLG1.FirstDisplayedScrollingRowIndex = 0
                scrollDLG1 = True
            Else
                MsgBox("Primary File does not exists, it has been deleted or moved. You must open a new one.", , "Warning")
            End If
        End If
    End Sub


    Private Sub btnRefresh2_Click(sender As Object, e As EventArgs) Handles btnRefresh2.Click
        If txtDLG2.Text.Length > 0 Then
            If File.Exists(txtDLG2.Text) Then
                scrollDLG2 = False
                putDLGinGRID(txtDLG2.Text, dgvDLG2, numRowsDLG2)
                dgvDLG2.FirstDisplayedScrollingRowIndex = 0
                scrollDLG2 = True
            Else
                MsgBox("Secondary File does not exists, it has been deleted or moved. You must open a new one.", , "Warning")
            End If
        End If
    End Sub


    Private Sub btnEditEveryone_Click(sender As Object, e As EventArgs) Handles btnEditEveryone.Click
        Dim rowindex As Integer

        If numRowsDLG1 > 0 Then
            rowindex = dgvDLG1.CurrentRow.Index

            If dgvDLG1.Rows(rowindex).Cells.Count > 0 Then
                ' Line Number
                frmEveryoneData.txt_lnumENG.Text = dgvDLG1.Rows(rowindex).Cells(0).Value

                ' Male Text
                frmEveryoneData.txt_mtextENG.Text = dgvDLG1.Rows(rowindex).Cells(1).Value
                frmEveryoneData.maleString = frmEveryoneData.txt_mtextENG.Text

                ' Female Text
                frmEveryoneData.txt_ftextENG.Text = dgvDLG1.Rows(rowindex).Cells(2).Value
                frmEveryoneData.femaleString = frmEveryoneData.txt_ftextENG.Text

                ' Jump to Line
                frmEveryoneData.txt_jumplineENG.Text = dgvDLG1.Rows(rowindex).Cells(3).Value

                ' Line Condition
                frmEveryoneData.txt_lconditionENG.Text = dgvDLG1.Rows(rowindex).Cells(4).Value

                ' Set Flags
                frmEveryoneData.txt_setflagsENG.Text = dgvDLG1.Rows(rowindex).Cells(5).Value

                frmEveryoneData.txt_rownum.Text = dgvDLG1.CurrentCell.RowIndex + 1
            End If
        End If

        If numRowsDLG2 > 0 And rowindex < numRowsDLG2 Then
            If dgvDLG2.Rows(rowindex).Cells.Count > 0 Then
                ' Line Number
                frmEveryoneData.txt_lnum.Text = dgvDLG2.Rows(rowindex).Cells(0).Value

                ' Male Text
                frmEveryoneData.txt_mtext.Text = dgvDLG2.Rows(rowindex).Cells(1).Value

                ' Female Text
                frmEveryoneData.txt_ftext.Text = dgvDLG2.Rows(rowindex).Cells(2).Value

                ' Jump to Line
                frmEveryoneData.txt_jumpline.Text = dgvDLG2.Rows(rowindex).Cells(3).Value
                frmEveryoneData.txt_jumpline.BackColor = SystemColors.Control
                If frmEveryoneData.txt_jumplineENG.Text <> frmEveryoneData.txt_jumpline.Text Then
                    frmEveryoneData.txt_jumpline.BackColor = Color.DarkSalmon
                End If

                ' Line Condition
                frmEveryoneData.txt_lcondition.Text = dgvDLG2.Rows(rowindex).Cells(4).Value
                frmEveryoneData.txt_lcondition.BackColor = SystemColors.Control
                If frmEveryoneData.txt_lconditionENG.Text <> frmEveryoneData.txt_lcondition.Text Then
                    frmEveryoneData.txt_lcondition.BackColor = Color.DarkSalmon
                End If

                ' Set Flags
                frmEveryoneData.txt_setflags.Text = dgvDLG2.Rows(rowindex).Cells(5).Value
                frmEveryoneData.txt_setflags.BackColor = SystemColors.Control
                If frmEveryoneData.txt_setflagsENG.Text <> frmEveryoneData.txt_setflags.Text Then
                    frmEveryoneData.txt_setflags.BackColor = Color.DarkSalmon
                End If

                ' Check english male and female lines equality.
                frmEveryoneData.txt_ftext.BackColor = SystemColors.Control
                If frmEveryoneData.txt_ftext.Text.Length > 2 Then
                    If frmEveryoneData.txt_mtext.Text <> frmEveryoneData.txt_ftext.Text Then
                        frmEveryoneData.txt_ftext.BackColor = Color.Orchid
                    End If
                End If

                ' Check translated male and female lines existance.
                frmEveryoneData.txt_mtextENG.BackColor = Color.White
                If frmEveryoneData.txt_mtext.Text.Length > 2 And
                   frmEveryoneData.txt_mtextENG.Text.Length = 0 Then

                    frmEveryoneData.txt_mtextENG.BackColor = Color.Goldenrod
                End If

                frmEveryoneData.txt_ftextENG.BackColor = Color.White
                If frmEveryoneData.txt_ftext.Text.Length > 0 And
                   frmEveryoneData.txt_ftextENG.Text.Length = 0 Then

                    frmEveryoneData.txt_ftextENG.BackColor = Color.Goldenrod
                End If
            End If
        End If

        EditEveryoneActive = True

        frmEveryoneData.Show()
        frmEveryoneData.BringToFront()
        frmEveryoneData.txt_mtextENG.Focus()
    End Sub


    Public Sub saveDLGofGRID(ByRef FileName As String, ByRef dgvDLG As DataGridView, ByRef numRows As Integer)
        Dim i, numCol As Integer
        Dim strLine, individualCell As String

        'Using fDLG As StreamWriter = New StreamWriter(File.Open(FileName, FileMode.Create),
        '                                              System.Text.Encoding.GetEncoding(ISO_8859_1))
        Using fDLG As StreamWriter = New StreamWriter(File.Open(FileName, FileMode.Create),
                                                      System.Text.Encoding.GetEncoding(FT.iCodepageDLGLanguage))

            For i = 0 To numRows - 1
                strLine = ""

                If dgvDLG.Rows(i).Cells(0).Value <> "" Then
                    For numCol = 0 To NUM_COLUMNS - 1
                        individualCell = dgvDLG.Rows(i).Cells(numCol).Value.ToString()

                        strLine += "{" + vbTab

                        If individualCell.Length > 0 Then
                            strLine += individualCell + vbTab
                        End If

                        strLine += "}"
                    Next
                Else
                    strLine = ""
                End If

                fDLG.WriteLine(strLine)

            Next
        End Using
    End Sub


    Private Sub btnSaveAsDLG1_Click(sender As Object, e As EventArgs) Handles btnSaveAsDLG1.Click
        ' Set filter options and filter index.
        saveDLG.Title = "Save DLG Primary File"
        saveDLG.Filter = "DLG (*.DLG)|*.DLG|All Files (*.*)|*.*"
        saveDLG.InitialDirectory = FT.strPrimaryDLGPath
        saveDLG.FilterIndex = 1
        saveDLG.FileName = txtDLG1.Text

        Try
            ' Process input if the user clicked OK.
            If (Path.GetExtension(saveDLG.FileName) = ".dlg") Then
                If saveDLG.ShowDialog = DialogResult.OK Then
                    scrollDLG1 = False

                    saveDLGofGRID(saveDLG.FileName, dgvDLG1, numRowsDLG1)

                    ' Activate more things
                    scrollDLG1 = True
                    dgvDLG1Changed = False

                    MsgBox("File: " + saveDLG.FileName + " saved.", , "Information")
                End If
            Else
                If saveDLG.ShowDialog = DialogResult.OK Then
                    scrollDLG1 = False

                    saveDLGofGRID(saveDLG.FileName, dgvDLG1, numRowsDLG1)

                    ' Activate more things
                    scrollDLG1 = True
                    dgvDLG1Changed = False

                    MsgBox("File: " + saveDLG.FileName + " saved.", , "Information")
                    'MsgBox("The file is not of .DLG type. Only .DLG files are permitted to save.", , "Warning")
                    'Exit Sub
                End If
            End If
        Catch
            MsgBox("Error saving Dialog .DLG File.", , "Error")
        End Try
    End Sub


    Private Sub btnSaveDLG1_Click(sender As Object, e As EventArgs) Handles btnSaveDLG1.Click
        Try
            ' Process input if the user clicked OK.
            If (Path.GetExtension(txtDLG1.Text) = ".dlg") Then
                scrollDLG1 = False

                saveDLGofGRID(txtDLG1.Text, dgvDLG1, numRowsDLG1)

                ' Activate more things
                scrollDLG1 = True
                dgvDLG1Changed = False
            Else
                scrollDLG1 = False

                saveDLGofGRID(txtDLG1.Text, dgvDLG1, numRowsDLG1)

                ' Activate more things
                scrollDLG1 = True
                dgvDLG1Changed = False
            End If

            If btnSaveDLG1.Tag <> " " Then
                MsgBox("File: " + txtDLG1.Text + " saved.", , "Information")
            Else
                btnSaveDLG1.Tag = ""
            End If
        Catch
            MsgBox("Error saving Dialog .DLG File.", , "Error")
        End Try
    End Sub


    Private Sub dgvDLG1_Scroll(sender As Object, e As ScrollEventArgs) Handles dgvDLG1.Scroll
        'Dim cellindex As Integer
        Try
            If (scrollDLG1 And scrollDLG2) Then
                'If dgvDLG1.FirstDisplayedScrollingRowIndex < dgvDLG2.RowCount Then
                scrollDLG2 = False

                If dgvDLG1.CurrentRow.Index < dgvDLG2.RowCount And
                   dgvDLG1.FirstDisplayedScrollingRowIndex < dgvDLG2.RowCount Then
                    dgvDLG2.FirstDisplayedScrollingRowIndex = dgvDLG1.FirstDisplayedScrollingRowIndex
                    'dgvDLG2.HorizontalScrollingOffset = dgvDLG1.HorizontalScrollingOffset
                    'dgvDLG2.CurrentCell = dgvDLG2.Rows(dgvDLG1.CurrentRow.Index).Cells(dgvDLG1.CurrentCell.ColumnIndex)

                    'cellindex = dgvDLG1.CurrentCell.ColumnIndex

                    'If cellindex < dgvDLG2.Columns.Count Then
                    '    dgvDLG2.CurrentCell = dgvDLG2.Rows(dgvDLG2.FirstDisplayedScrollingRowIndex).Cells(cellindex)
                    'Else
                    '    dgvDLG2.CurrentCell = dgvDLG2.Rows(dgvDLG2.FirstDisplayedScrollingRowIndex).Cells(0)
                    'End If

                    'dgvDLG2.Rows(dgvDLG2.FirstDisplayedScrollingRowIndex).Selected = True
                End If

                scrollDLG2 = True
            End If
        Catch ex As Exception
            MsgBox("There has been an exception error when scrolling datagrid 1." + vbCrLf +
                   "Exception: " + ex.Message, vbOK, "Exception")
        End Try
    End Sub


    Private Sub dgvDLG2_Scroll(sender As Object, e As ScrollEventArgs) Handles dgvDLG2.Scroll
        'Dim cellindex As Integer
        Try
            If (scrollDLG1 And scrollDLG2) Then
                scrollDLG1 = False

                'If dgvDLG2.FirstDisplayedScrollingRowIndex < dgvDLG1.RowCount Then
                If dgvDLG2.CurrentRow.Index < dgvDLG1.RowCount And
                   dgvDLG2.FirstDisplayedScrollingRowIndex < dgvDLG1.RowCount Then
                    dgvDLG1.FirstDisplayedScrollingRowIndex = dgvDLG2.FirstDisplayedScrollingRowIndex
                    'dgvDLG1.HorizontalScrollingOffset = dgvDLG2.HorizontalScrollingOffset
                    'dgvDLG1.CurrentCell = dgvDLG1.Rows(dgvDLG2.CurrentRow.Index).Cells(dgvDLG2.CurrentCell.ColumnIndex)

                    'cellindex = dgvDLG2.CurrentCell.ColumnIndex

                    'If cellindex < dgvDLG1.Columns.Count Then
                    'dgvDLG1.CurrentCell = dgvDLG1.Rows(dgvDLG2.FirstDisplayedScrollingRowIndex).Cells(cellindex)
                    '    Else
                    '        dgvDLG1.CurrentCell = dgvDLG1.Rows(dgvDLG2.FirstDisplayedScrollingRowIndex).Cells(0)
                    '    End If

                    '    dgvDLG1.Rows(dgvDLG1.FirstDisplayedScrollingRowIndex).Selected = True
                End If

                scrollDLG1 = True
            End If
        Catch ex As Exception
            MsgBox("There has been an exception error when scrolling datagrid 2." + vbCrLf +
                   "Exception: " + ex.Message, vbOK, "Exception")
        End Try

    End Sub


    Private Sub dgvDLG1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDLG1.CellClick
        Dim rowindex As Integer
        Dim cellindex As Integer

        If scrollDLG1 And scrollDLG2 Then
            If dgvDLG1.CurrentRow.Index < dgvDLG2.Rows.Count Then
                dgvDLG2.ClearSelection()

                dgvDLG2.Rows(dgvDLG1.CurrentRow.Index).Selected = True
                dgvDLG2.CurrentCell = dgvDLG2.Rows(dgvDLG1.CurrentRow.Index).Cells(dgvDLG1.CurrentCell.ColumnIndex)
            End If

            'rowindex = dgvDLG1.CurrentRow.Index
            'cellindex = dgvDLG1.CurrentCell.ColumnIndex

            'If rowindex < dgvDLG2.Rows.Count Then
            '    dgvDLG2.ClearSelection()

            '    If cellindex < dgvDLG2.Columns.Count Then
            '        dgvDLG2.CurrentCell = dgvDLG2.Rows(rowindex).Cells(cellindex)
            '    Else
            '        dgvDLG2.CurrentCell = dgvDLG2.Rows(rowindex).Cells(0)
            '    End If

            '    dgvDLG2.Rows(rowindex).Selected = True
            'End If
        End If
    End Sub


    Private Sub dgvDLG2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDLG2.CellClick
        Dim rowindex As Integer
        Dim cellindex As Integer

        If scrollDLG1 And scrollDLG2 Then
            If dgvDLG2.CurrentRow.Index < dgvDLG1.Rows.Count Then
                dgvDLG1.ClearSelection()

                dgvDLG1.Rows(dgvDLG2.CurrentRow.Index).Selected = True
                dgvDLG1.CurrentCell = dgvDLG1.Rows(dgvDLG2.CurrentRow.Index).Cells(dgvDLG2.CurrentCell.ColumnIndex)
            End If

            '    rowindex = dgvDLG2.CurrentRow.Index
            '    cellindex = dgvDLG2.CurrentCell.ColumnIndex

            '    If rowindex < dgvDLG1.Rows.Count Then
            '        dgvDLG1.ClearSelection()

            '        If cellindex < dgvDLG2.Columns.Count Then
            '            dgvDLG1.CurrentCell = dgvDLG1.Rows(rowindex).Cells(cellindex)
            '        Else
            '            dgvDLG1.CurrentCell = dgvDLG1.Rows(rowindex).Cells(0)
            '        End If

            '        dgvDLG1.Rows(rowindex).Selected = True
            '    End If
        End If
    End Sub


    Private Sub btnNormalizeRows_Click(sender As Object, e As EventArgs)
        Dim numRow1, numRow2 As Integer
        Dim iCell As Integer

        numRow1 = 0
        numRow2 = 0

        dgvDLG1.RowHeadersVisible = False

        While numRow2 < dgvDLG2.Rows.Count
            If numRow2 < dgvDLG1.Rows.Count Then
                If dgvDLG1.Rows(numRow1).Cells(0).Value <> "" Then
                    If dgvDLG2.Rows(numRow2).Cells(0).Value <> "" And IsNumeric(dgvDLG2.Rows(numRow2).Cells(0).Value) Then
                        If CInt(dgvDLG1.Rows(numRow1).Cells(0).Value) < CInt(dgvDLG2.Rows(numRow2).Cells(0).Value) Then
                            dgvDLG1.Rows.RemoveAt(numRow1)
                        ElseIf CInt(dgvDLG1.Rows(numRow1).Cells(0).Value) = CInt(dgvDLG2.Rows(numRow2).Cells(0).Value) Then
                            numRow1 = numRow1 + 1
                            numRow2 = numRow2 + 1
                        Else
                            dgvDLG1.Rows.Insert(numRow1)

                            iCell = 0
                            For Each cell In dgvDLG2.Rows(numRow2).Cells
                                dgvDLG1.Rows(numRow1).Cells(iCell).Value = cell.Value
                                iCell = iCell + 1
                            Next

                            numRow1 = numRow1 + 1
                            numRow2 = numRow2 + 1
                        End If
                    Else
                        dgvDLG1.Rows.Insert(numRow1)

                        If dgvDLG2.Rows(numRow2).Cells(0).Value <> "" Then
                            iCell = 0
                            For Each cell In dgvDLG2.Rows(numRow2).Cells
                                dgvDLG1.Rows(numRow1).Cells(iCell).Value = cell.Value
                                iCell = iCell + 1
                            Next
                        End If

                        numRow1 = numRow1 + 1
                        numRow2 = numRow2 + 1
                    End If
                Else
                    iCell = 0

                    For Each cell In dgvDLG2.Rows(numRow2).Cells
                        dgvDLG1.Rows(numRow1).Cells(iCell).Value = cell.Value
                        iCell = iCell + 1
                    Next

                    numRow1 = numRow1 + 1
                    numRow2 = numRow2 + 1
                End If
            Else
                dgvDLG1.Rows.Add()

                If dgvDLG2.Rows(numRow2).Cells(0).Value <> "" Then
                    iCell = 0

                    For Each cell In dgvDLG2.Rows(numRow2).Cells
                        dgvDLG1.Rows(numRow1).Cells(iCell).Value = cell.Value
                        iCell = iCell + 1
                    Next
                End If
            End If
        End While

        ' Check last rows
        If dgvDLG1.Rows.Count > dgvDLG2.Rows.Count Then
            While dgvDLG1.Rows.Count > dgvDLG2.Rows.Count
                dgvDLG1.Rows(numRow1).Selected = True
                dgvDLG1.Rows.Remove(dgvDLG1.SelectedRows(0))
            End While
        ElseIf dgvDLG1.Rows.Count < dgvDLG2.Rows.Count Then
            While dgvDLG1.Rows.Count < dgvDLG2.Rows.Count
                dgvDLG1.Rows.Add()

                If dgvDLG2.Rows(numRow2).Cells(0).Value <> "" Then
                    iCell = 0

                    For Each cell In dgvDLG2.Rows(numRow2).Cells
                        dgvDLG1.Rows(numRow1).Cells(iCell).Value = cell.Value
                        iCell = iCell + 1
                    Next
                End If

                numRow1 = numRow1 + 1
                numRow2 = numRow2 + 1
            End While
        End If

        ' Renumber the Row Headers.
        For numRow1 = 0 To dgvDLG1.Rows.Count - 1
            dgvDLG1.Rows(numRow1).HeaderCell.Value = (numRow1 + 1).ToString()
        Next
        numRowsDLG1 = numRow1

        dgvDLG1.RowHeadersVisible = True
    End Sub


    Private Sub frmVtMBTranslator_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If dgvDLG1Changed Then
            If MsgBox("Data in Primary grid has changed and has not been saved. Do you really want to close the application?", vbOKCancel, "Warning") = vbCancel Then
                e.Cancel = True
            End If
        End If
    End Sub


    Private Sub btnEditClans_Click(sender As Object, e As EventArgs) Handles btnEditClans.Click
        Dim rowindex As Integer

        If numRowsDLG1 > 0 Then
            rowindex = dgvDLG1.CurrentRow.Index

            If dgvDLG1.Rows(rowindex).Cells.Count > 0 Then
                ' Brujah
                frmClansData.txtBrujahENG.Text = dgvDLG1.Rows(rowindex).Cells(6).Value
                frmClansData.brujahString = dgvDLG1.Rows(rowindex).Cells(6).Value

                ' Gangrel
                frmClansData.txtGangrelENG.Text = dgvDLG1.Rows(rowindex).Cells(7).Value
                frmClansData.gangrelString = dgvDLG1.Rows(rowindex).Cells(7).Value

                ' Nosferatu
                frmClansData.txtNosferatuENG.Text = dgvDLG1.Rows(rowindex).Cells(8).Value
                frmClansData.nosferatuString = dgvDLG1.Rows(rowindex).Cells(8).Value

                ' Toreador
                frmClansData.txtToreadorENG.Text = dgvDLG1.Rows(rowindex).Cells(9).Value
                frmClansData.toreadorString = dgvDLG1.Rows(rowindex).Cells(9).Value

                ' Tremere
                frmClansData.txtTremereENG.Text = dgvDLG1.Rows(rowindex).Cells(10).Value
                frmClansData.tremereString = dgvDLG1.Rows(rowindex).Cells(10).Value

                ' Ventrue
                frmClansData.txtVentrueENG.Text = dgvDLG1.Rows(rowindex).Cells(11).Value
                frmClansData.ventrueString = dgvDLG1.Rows(rowindex).Cells(11).Value

                ' Malkavian
                frmClansData.txtMalkavianENG.Text = dgvDLG1.Rows(rowindex).Cells(12).Value
                frmClansData.malkavianString = dgvDLG1.Rows(rowindex).Cells(12).Value

                frmClansData.txt_lnumENG.Text = dgvDLG1.Rows(rowindex).Cells(0).Value
                frmClansData.txt_rownum.Text = dgvDLG1.CurrentCell.RowIndex + 1
            End If
        End If

        If numRowsDLG2 > 0 And rowindex < numRowsDLG2 Then
            If dgvDLG2.Rows(rowindex).Cells.Count > 0 Then
                ' Brujah
                frmClansData.txtBrujah.Text = dgvDLG2.Rows(rowindex).Cells(6).Value

                ' Gangrel
                frmClansData.txtGangrel.Text = dgvDLG2.Rows(rowindex).Cells(7).Value

                ' Nosferatu
                frmClansData.txtNosferatu.Text = dgvDLG2.Rows(rowindex).Cells(8).Value

                ' Toreador
                frmClansData.txtToreador.Text = dgvDLG2.Rows(rowindex).Cells(9).Value

                ' Tremere
                frmClansData.txtTremere.Text = dgvDLG2.Rows(rowindex).Cells(10).Value

                ' Ventrue
                frmClansData.txtVentrue.Text = dgvDLG2.Rows(rowindex).Cells(11).Value

                ' Malkavian
                frmClansData.txtMalkavian.Text = dgvDLG2.Rows(rowindex).Cells(12).Value

                frmClansData.txt_lnum.Text = dgvDLG2.Rows(rowindex).Cells(0).Value
            End If
        End If

        EditClansActive = True

        frmClansData.Show()
        frmClansData.BringToFront()
        frmClansData.txtBrujahENG.Focus()

        ' Prepare texts for Undo
        frmClansData.PrepareUndoText()
    End Sub


    Function DataInClansRow() As Boolean
        Dim result As Boolean = False

        If dgvDLG1.Rows(dgvDLG1.CurrentRow.Index).Cells(6).Value.Length > 0 Or
           dgvDLG1.Rows(dgvDLG1.CurrentRow.Index).Cells(7).Value.Length > 0 Or
           dgvDLG1.Rows(dgvDLG1.CurrentRow.Index).Cells(8).Value.Length > 0 Or
           dgvDLG1.Rows(dgvDLG1.CurrentRow.Index).Cells(9).Value.Length > 0 Or
           dgvDLG1.Rows(dgvDLG1.CurrentRow.Index).Cells(10).Value.Length > 0 Or
           dgvDLG1.Rows(dgvDLG1.CurrentRow.Index).Cells(11).Value.Length > 0 Or
           dgvDLG1.Rows(dgvDLG1.CurrentRow.Index).Cells(12).Value.Length > 0 Then

            result = True
        End If

        Return result
    End Function

    Private Sub btnUpdateLips_Click(sender As Object, e As EventArgs) Handles btnUpdateLips.Click
        LipsUpdaterActive = True

        frmLipsUpdater.Show()
        frmLipsUpdater.BringToFront()
        frmLipsUpdater.btnCheck.Focus()
    End Sub

    Private Sub dgvDLG1_CellMouseDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvDLG1.CellMouseDoubleClick
        If numRowsDLG1 > 0 Then
            If dgvDLG1.CurrentCell.ColumnIndex > 5 Then
                If DataInClansRow() Then btnEditClans.PerformClick()
            Else
                btnEditEveryone.PerformClick()
            End If
        End If
    End Sub


    Private Sub dgvDLG2_CellMouseDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvDLG2.CellMouseDoubleClick
        If numRowsDLG2 > 0 Then
            If dgvDLG2.CurrentCell.ColumnIndex > 5 Then
                If DataInClansRow() Then btnEditClans.PerformClick()
            Else
                btnEditEveryone.PerformClick()
            End If
        End If
    End Sub


    Private Sub tsmiCopy_Click(sender As Object, e As EventArgs) Handles tsmiCopy.Click
        ' Get Male Text of clicked item and put in Clipboard
        If dgvDLG1.Rows(rightclickRow).Cells(1).Value IsNot Nothing Then
            Clipboard.SetText(dgvDLG1.Rows(rightclickRow).Cells(1).Value)
        End If
    End Sub

    Private Sub btnIndividualLipsEditor_Click(sender As Object, e As EventArgs) Handles btnIndividualLipsEditor.Click
        IndividualLipsEditorActive = True

        frmIndividualLipsEditor.Show()
        frmIndividualLipsEditor.BringToFront()
        'frmIndividualLipsEditor.btnCheck.Focus()
    End Sub

    Private Sub btnGTCL_Click(sender As Object, e As EventArgs) Handles btnGTCL.Click
        If numRowsDLG1 > 0 Then
            frmGTCL_FS.Tag = 1    ' Option 1: Go To Code Line
            frmGTCL_FS.txtGTCL_FS.SelectAll()

            frmGTCL_FS.ShowDialog()
        End If
    End Sub


    Private Sub btnFS_Click(sender As Object, e As EventArgs) Handles btnFS.Click
        If numRowsDLG1 > 0 Then
            searchRow = 0
            oldsearchRow = 0

            frmGTCL_FS.Tag = 2   ' Option 2: Find String
            frmGTCL_FS.ShowDialog()

            If searchText <> "" Then
                frmGTCL_FS.txtGTCL_FS.SelectAll()
                frmGTCL_FS.subFS(searchRow)
            End If
        End If
    End Sub


    Private Sub tsmiFSE_Click(sender As Object, e As EventArgs) Handles tsmiFSE.Click
        If numRowsDLG1 > 0 And searchText <> "" Then
            oldsearchRow = searchRow
            searchRow = searchRow + 1
            frmGTCL_FS.Tag = 3   ' Option 3: Find Next String
            frmGTCL_FS.subFS(searchRow)
        End If
    End Sub


    Private Sub tsmiGTCL_Click(sender As Object, e As EventArgs) Handles tsmiGTCL.Click
        ' Go To Code Line
        btnGTCL.PerformClick()
    End Sub


    Private Sub tsmiFS_Click(sender As Object, e As EventArgs) Handles tsmiFS.Click
        ' Go To Code Line
        btnFS.PerformClick()
    End Sub


    Private Sub dgvDLG1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDLG1.CellMouseDown
        ' Get Row of clicked item
        If e.Button = MouseButtons.Right Then
            rightclickRow = e.RowIndex
        End If
    End Sub


    Private Sub frmVtMBTranslator_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.S And e.Control Then
            btnSaveDLG1.Tag = " "
            btnSaveDLG1.PerformClick()
        ElseIf e.KeyCode = Keys.G And e.Control Then
            btnGTCL.PerformClick()
        ElseIf e.KeyCode = Keys.F And e.Control Then
            btnFS.PerformClick()
        ElseIf e.KeyCode = Keys.C And e.Control And dgvDLG1.Focused() Then
            If Not dgvDLG1.CurrentRow Is Nothing Then
                If dgvDLG1.CurrentRow.Index < numRowsDLG1 Then
                    rightclickRow = dgvDLG1.CurrentRow.Index
                    tsmiCopy.PerformClick()
                End If
            End If
        ElseIf e.KeyCode = Keys.F3 Then
            tsmiFSE.PerformClick()
        End If
    End Sub


    Private Sub frmVtMBTranslator_Activate(sender As Object, e As EventArgs) Handles Me.Activated
        If EditEveryoneActive Then
            frmEveryoneData.Opacity = 0.35
        End If

        If EditClansActive Then
            frmClansData.Opacity = 0.35
        End If

        If LipsUpdaterActive Then
            frmLipsUpdater.Opacity = 0.35
        End If

        If LookUpReferentsActive Then
            frmLookUpReferents.Opacity = 0.35
        End If

        If IndividualLipsEditorActive Then
            frmIndividualLipsEditor.Opacity = 0.35
        End If
    End Sub


    Private Sub frmVtMBTranslator_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If (formLoaded) Then
            If Me.WindowState = FormWindowState.Maximized Then
                splcontDGV.SplitterDistance = 'dgvDLG1.Columns(0).Width +
                                              dgvDLG1.Columns(1).Width +
                                              dgvDLG1.Columns(2).Width +
                                              dgvDLG1.Columns(3).Width +
                                              dgvDLG1.Columns(4).Width +
                                              dgvDLG1.Columns(5).Width +
                                              dgvDLG1.Columns(6).Width +
                                              dgvDLG1.Columns(7).Width +
                                              dgvDLG1.Columns(8).Width +
                                              dgvDLG1.Columns(9).Width +
                                              dgvDLG1.Columns(10).Width +
                                              dgvDLG1.Columns(11).Width +
                                              dgvDLG1.Columns(12).Width + 10 + 80

                FT.bMaximized = True
                FT.WriteCFGFile()
            ElseIf Me.WindowState = FormWindowState.Normal Then
                splcontDGV.SplitterDistance = (splcontDGV.Width / 2) - (splcontDGV.SplitterWidth / 2)

                FT.bMaximized = False
                FT.WriteCFGFile()
            End If

        End If

    End Sub

    Private Sub btnDGV2Clear_Click(sender As Object, e As EventArgs) Handles btnDGV2Clear.Click
        dgvDLG2.Rows.Clear()

        scrollDLG2 = False
        btnCompEveryone.Enabled = False
        btnCompClans.Enabled = False
        frmGTCL_FS.cbSearchSecondary.Enabled = False

        txtDLG2.Text = ""
        numRowsDLG2 = 0
    End Sub

    Public Function TranslateDEEPL(strInputText As String) As String
        Dim strResult As String
        Dim srtInputTextOriginal As String = strInputText

        strResult = TranslateDEEPLAsync(strInputText).Result

        If strResult = "Error with the DeepL request." Or
           strResult = "No DEEPL Authorization Key" Then
            strResult = strResult + vbCrLf + srtInputTextOriginal
        End If

        Return strResult
    End Function


    Public Async Function TranslateDEEPLAsync(strInputText As String) As Task(Of String)
        Dim authKey, sourceLanguage, targetLanguage As String
        Dim client As HttpClient
        Dim responseBody As String

        If File.Exists(".\\authkey.txt") Then
            authKey = File.ReadAllText(".\\authkey.txt")

            sourceLanguage = "EN"
            targetLanguage = FT.strTargetLang

            Try
                client = New HttpClient()

                Dim content = New FormUrlEncodedContent(
                              {
                               New KeyValuePair(Of String, String)("auth_key", authKey),
                               New KeyValuePair(Of String, String)("text", strInputText),
                               New KeyValuePair(Of String, String)("detected_source_language", sourceLanguage),
                               New KeyValuePair(Of String, String)("target_lang", targetLanguage)
                              })

                Using client
                    Dim response As HttpResponseMessage =
                        Await client.PostAsync("https://api-free.deepl.com/v2/translate", content).ConfigureAwait(False)

                    responseBody =
                        Await response.Content.ReadAsStringAsync().ConfigureAwait(False)
                End Using

                Dim options As New JsonSerializerOptions() With {.IncludeFields = True}

                Return JsonSerializer.Deserialize(Of DeepResponse)(responseBody, options).translations(0).text
            Catch ex As Exception
                Return "Error with the DeepL request."
            End Try
        Else
            MessageBox.Show("There Is no 'authkey.txt' file with the DEEPL authorization key for do free translations. " +
                "Please, get a key, create the file authkey.txt with it inside and put it where " +
                "Conversation Editor for POE2 executable is.", "Info", MessageBoxButtons.OK)

            Return "No DEEPL Authorization Key"
        End If
    End Function

    Private Sub cbEncoding_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbEncoding.SelectedValueChanged
        If Not formLoaded Then Return

        FT.bUnicode = cbEncoding.SelectedIndex
        FT.WriteCFGFile()
    End Sub

    Private Sub cbCodepage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCodepage.SelectedIndexChanged
        If (formLoaded) Then
            FT.iCodepageDLGLanguage = cbCodepage.Items(cbCodepage.SelectedIndex)
            FT.WriteCFGFile()
        End If
    End Sub

    Private Sub dgvDLG1_ColumnWidthChanged(sender As Object, e As DataGridViewColumnEventArgs) Handles dgvDLG1.ColumnWidthChanged
        If (formLoaded) Then
            FT.PrepareColumnsdgvDLG1Widths()
            FT.WriteCFGFile()
        End If
    End Sub

    Private Sub dgvDLG1_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDLG1.CellMouseEnter
        Dim iTest As Integer

        If (formLoaded) Then
            If (e.RowIndex > -1 And e.ColumnIndex = 3) Then
                If (Integer.TryParse(dgvDLG1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, iTest)) Then
                    If (dgvDLG1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value < dgvDLG1.RowCount And
                        dgvDLG1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value > 0) Then

                        dgvDLG1.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText =
                            dgvDLG1.Rows(dgvDLG1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value - 1).Cells(1).Value

                    End If
                End If
            End If
        End If
    End Sub


End Class
