Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class frmClansData
    Public txtClansChanged As Boolean = False
    Public brujahString As String = String.Empty
    Public gangrelString As String = String.Empty
    Public nosferatuString As String = String.Empty
    Public toreadorString As String = String.Empty
    Public tremereString As String = String.Empty
    Public ventrueString As String = String.Empty
    Public malkavianString As String = String.Empty
    Public brujahUndoString As String = String.Empty
    Public gangrelUndoString As String = String.Empty
    Public nosferatuUndoString As String = String.Empty
    Public toreadorUndoString As String = String.Empty
    Public tremereUndoString As String = String.Empty
    Public ventrueUndoString As String = String.Empty
    Public malkavianUndoString As String = String.Empty
    Public formLoaded As Boolean = False

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If txtClansChanged Then

            If MsgBox("Clans texts had been changed. Do you want to close Clans Data form?", vbOKCancel, "Warning") = vbCancel Then
                Exit Sub
            End If
        End If

        frmVtMBTranslator.EditClansActive = False
        Me.Close()
    End Sub


    Public Sub Update_DGV()
        With frmVtMBTranslator.dgvDLG1
            .Rows(txt_rownum.Text - 1).Cells(6).Value = txtBrujahENG.Text
            .Rows(txt_rownum.Text - 1).Cells(7).Value = txtGangrelENG.Text
            .Rows(txt_rownum.Text - 1).Cells(8).Value = txtNosferatuENG.Text
            .Rows(txt_rownum.Text - 1).Cells(9).Value = txtToreadorENG.Text
            .Rows(txt_rownum.Text - 1).Cells(10).Value = txtTremereENG.Text
            .Rows(txt_rownum.Text - 1).Cells(11).Value = txtVentrueENG.Text
            .Rows(txt_rownum.Text - 1).Cells(12).Value = txtMalkavianENG.Text
        End With

        frmVtMBTranslator.dgvDLG1Changed = True

        txtClansChanged = False
    End Sub


    Public Sub Update_DGVSameLines()
        Dim numRow, selectedRow As Integer
        Dim updateBrujah, updateGangrel, updateNosferatu, updateToreador As Boolean
        Dim updateTremere, updateVentrue, updateMalkavian As Boolean

        updateBrujah = False
        updateGangrel = False
        updateNosferatu = False
        updateToreador = False
        updateTremere = False
        updateVentrue = False
        updateMalkavian = False

        selectedRow = txt_rownum.Text - 1

        If txtBrujahENG.Text.Length > 2 Then updateBrujah = True
        If txtGangrelENG.Text.Length > 2 Then updateGangrel = True
        If txtNosferatuENG.Text.Length > 2 Then updateNosferatu = True
        If txtToreadorENG.Text.Length > 2 Then updateToreador = True
        If txtTremereENG.Text.Length > 2 Then updateTremere = True
        If txtVentrueENG.Text.Length > 2 Then updateVentrue = True
        If txtMalkavianENG.Text.Length > 2 Then updateMalkavian = True

        With frmVtMBTranslator.dgvDLG1
            For numRow = 0 To .RowCount - 1
                If numRow <> selectedRow Then
                    If updateBrujah Then
                        If .Rows(numRow).Cells(6).Value = brujahString And brujahString <> "" Then
                            frmVtMBTranslator.dgvDLG1.Rows(numRow).Cells(6).Value = txtBrujahENG.Text
                        End If
                    End If

                    If updateGangrel Then
                        If .Rows(numRow).Cells(7).Value = gangrelString And gangrelString <> "" Then
                            frmVtMBTranslator.dgvDLG1.Rows(numRow).Cells(7).Value = txtGangrelENG.Text
                        End If
                    End If

                    If updateNosferatu Then
                        If .Rows(numRow).Cells(8).Value = nosferatuString And nosferatuString <> "" Then
                            frmVtMBTranslator.dgvDLG1.Rows(numRow).Cells(8).Value = txtNosferatuENG.Text
                        End If
                    End If

                    If updateToreador Then
                        If .Rows(numRow).Cells(9).Value = toreadorString And toreadorString <> "" Then
                            frmVtMBTranslator.dgvDLG1.Rows(numRow).Cells(9).Value = txtToreadorENG.Text
                        End If
                    End If

                    If updateTremere Then
                        If .Rows(numRow).Cells(10).Value = tremereString And tremereString <> "" Then
                            frmVtMBTranslator.dgvDLG1.Rows(numRow).Cells(10).Value = txtTremereENG.Text
                        End If
                    End If

                    If updateVentrue Then
                        If .Rows(numRow).Cells(11).Value = ventrueString And ventrueString <> "" Then
                            frmVtMBTranslator.dgvDLG1.Rows(numRow).Cells(11).Value = txtVentrueENG.Text
                        End If
                    End If

                    If updateMalkavian Then
                        If .Rows(numRow).Cells(12).Value = malkavianString And malkavianString <> "" Then
                            frmVtMBTranslator.dgvDLG1.Rows(numRow).Cells(12).Value = txtMalkavianENG.Text
                        End If
                    End If
                End If
            Next
        End With
    End Sub


    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Update_DGV()

        If cbCAL.Checked Then
            Update_DGVSameLines()
        End If

        brujahString = txtBrujahENG.Text
        gangrelString = txtGangrelENG.Text
        nosferatuString = txtNosferatuENG.Text
        toreadorString = txtToreadorENG.Text
        tremereString = txtTremereENG.Text
        ventrueString = txtVentrueENG.Text
        malkavianString = txtMalkavianENG.Text

    End Sub


    Function NextRowWithData(ByVal rowIndex As Integer) As Integer
        Dim found As Boolean = False

        While rowIndex < frmVtMBTranslator.dgvDLG1.RowCount And Not found
            If frmVtMBTranslator.dgvDLG1.Rows(rowIndex).Cells(6).Value <> Nothing Or
               frmVtMBTranslator.dgvDLG1.Rows(rowIndex).Cells(7).Value <> Nothing Or
               frmVtMBTranslator.dgvDLG1.Rows(rowIndex).Cells(8).Value <> Nothing Or
               frmVtMBTranslator.dgvDLG1.Rows(rowIndex).Cells(9).Value <> Nothing Or
               frmVtMBTranslator.dgvDLG1.Rows(rowIndex).Cells(10).Value <> Nothing Or
               frmVtMBTranslator.dgvDLG1.Rows(rowIndex).Cells(11).Value <> Nothing Or
               frmVtMBTranslator.dgvDLG1.Rows(rowIndex).Cells(12).Value <> Nothing Then
                found = True
            End If

            If (Not found) Then rowIndex = rowIndex + 1
        End While

        Return rowIndex
    End Function


    Function PrevRowWithData(ByVal rowIndex As Integer) As Integer
        Dim found As Boolean = False

        While rowIndex > 0 And Not found
            If frmVtMBTranslator.dgvDLG1.Rows(rowIndex).Cells(6).Value <> Nothing Or
               frmVtMBTranslator.dgvDLG1.Rows(rowIndex).Cells(7).Value <> Nothing Or
               frmVtMBTranslator.dgvDLG1.Rows(rowIndex).Cells(8).Value <> Nothing Or
               frmVtMBTranslator.dgvDLG1.Rows(rowIndex).Cells(9).Value <> Nothing Or
               frmVtMBTranslator.dgvDLG1.Rows(rowIndex).Cells(10).Value <> Nothing Or
               frmVtMBTranslator.dgvDLG1.Rows(rowIndex).Cells(11).Value <> Nothing Or
               frmVtMBTranslator.dgvDLG1.Rows(rowIndex).Cells(12).Value <> Nothing Then
                found = True
            End If

            If (Not found) Then rowIndex = rowIndex - 1
        End While

        Return rowIndex
    End Function


    Public Sub ReadNextRow_DGV()
        Dim rowindex As Integer
        'rowindex = frmVtMBTranslator.dgvDLG1.CurrentRow.Index
        'rowindex = rowindex + 1
        rowindex = txt_rownum.Text

        ' Find Next row with data
        If chkJumpEmptyRows.Checked Then rowindex = NextRowWithData(rowindex)

        If rowindex < frmVtMBTranslator.dgvDLG1.Rows.Count Then
            frmVtMBTranslator.dgvDLG1.ClearSelection()
            frmVtMBTranslator.dgvDLG1.CurrentCell = frmVtMBTranslator.dgvDLG1.Rows(rowindex).Cells(12)
            frmVtMBTranslator.dgvDLG1.Rows(rowindex).Selected = True

            If rowindex < frmVtMBTranslator.dgvDLG2.Rows.Count Then
                frmVtMBTranslator.dgvDLG2.ClearSelection()
                frmVtMBTranslator.dgvDLG2.CurrentCell = frmVtMBTranslator.dgvDLG2.Rows(rowindex).Cells(12)
                frmVtMBTranslator.dgvDLG2.Rows(rowindex).Selected = True
            End If

            txt_rownum.Text = rowindex + 1

            frmVtMBTranslator.btnEditClans.PerformClick()

            ' Set new text for Undo operation
            PrepareUndoText()
        End If
    End Sub


    Public Sub ReadPrevRow_DGV()
        Dim rowindex As Integer
        'rowindex = frmVtMBTranslator.dgvDLG1.CurrentRow.Index
        rowindex = txt_rownum.Text - 1
        rowindex = rowindex - 1

        ' Find Previous row with data
        If chkJumpEmptyRows.Checked Then rowindex = PrevRowWithData(rowindex)

        If rowindex >= 0 Then
            frmVtMBTranslator.dgvDLG1.ClearSelection()
            frmVtMBTranslator.dgvDLG1.CurrentCell = frmVtMBTranslator.dgvDLG1.Rows(rowindex).Cells(12)
            frmVtMBTranslator.dgvDLG1.Rows(rowindex).Selected = True

            If rowindex < frmVtMBTranslator.dgvDLG2.Rows.Count Then
                frmVtMBTranslator.dgvDLG2.ClearSelection()
                frmVtMBTranslator.dgvDLG2.CurrentCell = frmVtMBTranslator.dgvDLG2.Rows(rowindex).Cells(12)
                frmVtMBTranslator.dgvDLG2.Rows(rowindex).Selected = True
            End If

            txt_rownum.Text = rowindex + 1

            frmVtMBTranslator.btnEditClans.PerformClick()

            ' Set new text for Undo operation
            PrepareUndoText()
        End If
    End Sub


    Private Sub btnValidateNext_Click(sender As Object, e As EventArgs) Handles btnValidateNext.Click
        btnCopyAndValidate.PerformClick()

        ReadNextRow_DGV()

        txtBrujahENG.Focus()
    End Sub


    Private Sub btnValidatePrev_Click(sender As Object, e As EventArgs) Handles btnValidatePrev.Click
        btnCopyAndValidate.PerformClick()

        ReadPrevRow_DGV()

        txtBrujahENG.Focus()
    End Sub


    Private Sub btnNextRow_Click(sender As Object, e As EventArgs) Handles btnNextRow.Click
        If txtClansChanged Then
            If MsgBox("Clans texts had been changed. Do you want to go to the next row?", vbOKCancel, "Warning") = vbOK Then
                txtClansChanged = False
            Else
                Exit Sub
            End If
        End If

        ReadNextRow_DGV()
    End Sub


    Private Sub btnPrevRow_Click(sender As Object, e As EventArgs) Handles btnPrevRow.Click
        If txtClansChanged Then
            If MsgBox("Clans texts had been changed. Do you want to go to the previous row?", vbOKCancel, "Warning") = vbOK Then
                txtClansChanged = False
            Else
                Exit Sub
            End If
        End If

        ReadPrevRow_DGV()
    End Sub


    Private Sub txtBrujahtext_Leave(sender As Object, e As EventArgs) Handles txtBrujahENG.Leave
        If brujahString <> txtBrujahENG.Text Then
            txtClansChanged = True
        End If
    End Sub

    Private Sub txtGangreltext_Leave(sender As Object, e As EventArgs) Handles txtGangrelENG.Leave
        If gangrelString <> txtGangrelENG.Text Then
            txtClansChanged = True
        End If
    End Sub

    Private Sub txtNosferatutext_Leave(sender As Object, e As EventArgs) Handles txtNosferatuENG.Leave
        If nosferatuString <> txtNosferatuENG.Text Then
            txtClansChanged = True
        End If
    End Sub

    Private Sub txtToreadortext_Leave(sender As Object, e As EventArgs) Handles txtToreadorENG.Leave
        If toreadorString <> txtToreadorENG.Text Then
            txtClansChanged = True
        End If
    End Sub

    Private Sub txtTremeretext_Leave(sender As Object, e As EventArgs) Handles txtTremereENG.Leave
        If tremereString <> txtTremereENG.Text Then
            txtClansChanged = True
        End If
    End Sub

    Private Sub txtVentruetext_Leave(sender As Object, e As EventArgs) Handles txtVentrueENG.Leave
        If ventrueString <> txtVentrueENG.Text Then
            txtClansChanged = True
        End If
    End Sub

    Private Sub txtMalkaviantext_Leave(sender As Object, e As EventArgs) Handles txtMalkavianENG.Leave
        If malkavianString <> txtMalkavianENG.Text Then
            txtClansChanged = True
        End If
    End Sub


    Private Sub txtBrujahtext_GotFocus(sender As Object, e As EventArgs) Handles txtBrujahENG.GotFocus
        txtBrujahENG.SelectAll()
    End Sub

    Private Sub txtGangreltext_GotFocus(sender As Object, e As EventArgs) Handles txtGangrelENG.GotFocus
        txtGangrelENG.SelectAll()
    End Sub
    Private Sub txtNosferatutext_GotFocus(sender As Object, e As EventArgs) Handles txtNosferatuENG.GotFocus
        txtNosferatuENG.SelectAll()
    End Sub
    Private Sub txtToreadortext_GotFocus(sender As Object, e As EventArgs) Handles txtToreadorENG.GotFocus
        txtToreadorENG.SelectAll()
    End Sub
    Private Sub txtTremeretext_GotFocus(sender As Object, e As EventArgs) Handles txtTremereENG.GotFocus
        txtTremereENG.SelectAll()
    End Sub
    Private Sub txtVentruetext_GotFocus(sender As Object, e As EventArgs) Handles txtVentrueENG.GotFocus
        txtVentrueENG.SelectAll()
    End Sub
    Private Sub txtMalkaviantext_GotFocus(sender As Object, e As EventArgs) Handles txtMalkavianENG.GotFocus
        txtMalkavianENG.SelectAll()
    End Sub

    Private Sub frmClansData_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        Me.Owner = frmVtMBTranslator
        'Me.Location = New Point(Me.Location.X + 100, Me.Location.Y)
    End Sub

    Private Sub frmClansData_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        Me.BringToFront()
    End Sub

    Private Sub frmClansData_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.S And e.Control Then
            btnValidate.PerformClick()
            frmVtMBTranslator.btnSaveDLG1.Tag = " "
            frmVtMBTranslator.btnSaveDLG1.PerformClick()

            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub frmClansData_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Opacity = 1
        frmGTCL_FS.Hide()
    End Sub

    Private Sub btnCopyAndValidate_Click(sender As Object, e As EventArgs) Handles btnCopyAndValidate.Click
        txtBrujahENG.Text = txtBrujah.Text
        txtGangrelENG.Text = txtGangrel.Text
        txtNosferatuENG.Text = txtNosferatu.Text
        txtToreadorENG.Text = txtToreador.Text
        txtTremereENG.Text = txtTremere.Text
        txtVentrueENG.Text = txtVentrue.Text
        txtMalkavianENG.Text = txtMalkavian.Text

        btnValidate.PerformClick()
    End Sub


    Private Sub btnValidateNextRow_Click(sender As Object, e As EventArgs) Handles btnValidateNextRow.Click
        btnValidate.PerformClick()

        btnNextRow.PerformClick()
    End Sub

    Private Sub btnValidatePrevRow_Click(sender As Object, e As EventArgs) Handles btnValidatePrevRow.Click
        btnValidate.PerformClick()

        btnPrevRow.PerformClick()
    End Sub

    Public Sub PrepareUndoText()
        brujahUndoString = txtBrujahENG.Text
        gangrelUndoString = txtGangrelENG.Text
        nosferatuUndoString = txtNosferatuENG.Text
        toreadorUndoString = txtToreadorENG.Text
        tremereUndoString = txtTremereENG.Text
        ventrueUndoString = txtVentrueENG.Text
        malkavianUndoString = txtMalkavianENG.Text
    End Sub

    Private Sub UndoText()
        txtBrujahENG.Text = brujahUndoString
        txtGangrelENG.Text = gangrelUndoString
        txtNosferatuENG.Text = nosferatuUndoString
        txtToreadorENG.Text = toreadorUndoString
        txtTremereENG.Text = tremereUndoString
        txtVentrueENG.Text = ventrueUndoString
        txtMalkavianENG.Text = malkavianUndoString
    End Sub

    Private Sub frmClansData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set Icon
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)

        ' Set config values
        Me.Width = frmVtMBTranslator.FT.iClansDataWidth
        Me.Height = frmVtMBTranslator.FT.iClansDataHeight

        If frmVtMBTranslator.FT.iClansDataXPos <> -1 And frmVtMBTranslator.FT.iClansDataYPos <> -1 Then
            Me.StartPosition = FormStartPosition.Manual
            Me.Location = New Point(frmVtMBTranslator.FT.iClansDataXPos, frmVtMBTranslator.FT.iClansDataYPos)
        Else
            Me.StartPosition = FormStartPosition.CenterScreen
        End If

        formLoaded = True
    End Sub

    Private Sub frmClansData_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
        If Not formLoaded Then Return

        ' Save values in settings
        If Me.Location.X > 0 Then frmVtMBTranslator.FT.iClansDataXPos = Me.Location.X
        If Me.Location.Y > 0 Then frmVtMBTranslator.FT.iClansDataYPos = Me.Location.Y

        frmVtMBTranslator.FT.WriteCFGFile()
    End Sub

    Private Sub frmClansData_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Not formLoaded Then Return

        ' Save values in settings
        If Me.Width > 0 Then frmVtMBTranslator.FT.iClansDataWidth = Me.Width
        If Me.Height > 0 Then frmVtMBTranslator.FT.iClansDataHeight = Me.Height

        frmVtMBTranslator.FT.WriteCFGFile()
    End Sub

    Private Sub btnTranslateMDeepL_Click(sender As Object, e As EventArgs) Handles btnTranslateMDeepL.Click
        Dim strTranslatedResult As String = ""

        If txtMalkavianENG.Text.Length > 0 Then
            strTranslatedResult = frmVtMBTranslator.TranslateDEEPL(txtMalkavianENG.Text)
        End If

        txtMalkavianENG.Text = strTranslatedResult
    End Sub

    Private Sub btnTranslateVDeepL_Click(sender As Object, e As EventArgs) Handles btnTranslateVDeepL.Click
        Dim strTranslatedResult As String = ""

        If txtVentrueENG.Text.Length > 0 Then
            strTranslatedResult = frmVtMBTranslator.TranslateDEEPL(txtVentrueENG.Text)
        End If

        txtVentrueENG.Text = strTranslatedResult
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        UndoText()

        If brujahString = brujahUndoString And
           gangrelString = gangrelUndoString And
           nosferatuString = nosferatuUndoString And
           toreadorString = toreadorUndoString And
           tremereString = tremereUndoString And
           ventrueString = ventrueUndoString And
            malkavianString = malkavianUndoString Then
            txtClansChanged = False
        End If
    End Sub
End Class