Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class frmEveryoneData
    Public txtChanged As Boolean = False
    Public maleString As String = String.Empty
    Public femaleString As String = String.Empty


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If txtChanged Then

            If MsgBox("Male or Female texts had been changed. Do you want to close Everyone Data form?", vbOKCancel, "Warning") = vbCancel Then
                Exit Sub
            End If
        End If

        ' Close other forms
        frmGTCL_FS.Hide()
        frmLookUpReferents.Hide()

        frmVtMBTranslator.EditEveryoneActive = False
        Me.Close()
    End Sub


    Public Sub Update_DGV()
        With frmVtMBTranslator.dgvDLG1
            .Rows(txt_rownum.Text - 1).Cells(1).Value = txt_mtextENG.Text
            .Rows(txt_rownum.Text - 1).Cells(2).Value = txt_ftextENG.Text
        End With

        frmVtMBTranslator.dgvDLG1Changed = True

        txtChanged = False
    End Sub


    Public Sub Update_DGVSameLines()
        Dim numRow, selectedRow, numCol As Integer
        Dim strtmpmaleString As String = maleString

        selectedRow = txt_rownum.Text - 1

        If txt_mtextENG.Text.Length > 2 Then
            With frmVtMBTranslator.dgvDLG1
                For numRow = 0 To .RowCount - 1

                    ' Male/Female lines
                    If .Rows(numRow).Cells(1).Value = strtmpmaleString And maleString <> "" Then
                        If numRow <> selectedRow Then
                            frmVtMBTranslator.dgvDLG1.Rows(numRow).Cells(1).Value = txt_mtextENG.Text

                            ' Female
                            If .Rows(numRow).Cells(2).Value <> "" And
                               .Rows(numRow).Cells(2).Value = femaleString And femaleString <> "" Then
                                frmVtMBTranslator.dgvDLG1.Rows(numRow).Cells(2).Value = txt_ftextENG.Text
                            End If
                        End If
                    End If

                    ' Clans lines
                    For numCol = 6 To 12
                        If .Rows(numRow).Cells(numCol).Value = strtmpmaleString And strtmpmaleString <> "" Then
                            frmVtMBTranslator.dgvDLG1.Rows(numRow).Cells(numCol).Value = txt_mtextENG.Text
                        End If
                    Next
                Next
            End With
        End If
    End Sub


    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Update_DGV()

        If cbCAL.Checked Then
            Update_DGVSameLines()
        End If

        maleString = txt_mtextENG.Text
        femaleString = txt_ftextENG.Text

    End Sub


    Function NextRowWithData(ByVal rowIndex As Integer) As Integer
        Dim found As Boolean = False

        While rowIndex < frmVtMBTranslator.dgvDLG1.RowCount And Not found
            If frmVtMBTranslator.dgvDLG1.Rows(rowIndex).Cells(1).Value <> Nothing Then
                found = True
            End If

            If (Not found) Then rowIndex = rowIndex + 1
        End While

        Return rowIndex
    End Function


    Function PrevRowWithData(ByVal rowIndex As Integer) As Integer
        Dim found As Boolean = False

        While rowIndex > 0 And Not found
            If frmVtMBTranslator.dgvDLG1.Rows(rowIndex).Cells(1).Value <> Nothing Then
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
            frmVtMBTranslator.dgvDLG1.CurrentCell = frmVtMBTranslator.dgvDLG1.Rows(rowindex).Cells(0)
            frmVtMBTranslator.dgvDLG1.Rows(rowindex).Selected = True

            If rowindex < frmVtMBTranslator.dgvDLG2.Rows.Count Then
                frmVtMBTranslator.dgvDLG2.ClearSelection()
                frmVtMBTranslator.dgvDLG2.CurrentCell = frmVtMBTranslator.dgvDLG2.Rows(rowindex).Cells(0)
                frmVtMBTranslator.dgvDLG2.Rows(rowindex).Selected = True
            End If

            txt_rownum.Text = rowindex + 1

            frmVtMBTranslator.btnEditEveryone.PerformClick()
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
            frmVtMBTranslator.dgvDLG1.CurrentCell = frmVtMBTranslator.dgvDLG1.Rows(rowindex).Cells(0)
            frmVtMBTranslator.dgvDLG1.Rows(rowindex).Selected = True

            If rowindex < frmVtMBTranslator.dgvDLG2.Rows.Count Then
                frmVtMBTranslator.dgvDLG2.ClearSelection()
                frmVtMBTranslator.dgvDLG2.CurrentCell = frmVtMBTranslator.dgvDLG2.Rows(rowindex).Cells(0)
                frmVtMBTranslator.dgvDLG2.Rows(rowindex).Selected = True
            End If

            txt_rownum.Text = rowindex + 1

            frmVtMBTranslator.btnEditEveryone.PerformClick()
        End If
    End Sub


    Private Sub btnValidateNext_Click(sender As Object, e As EventArgs) Handles btnValidateNext.Click
        btnCopyAndValidate.PerformClick()

        ReadNextRow_DGV()

        txt_mtextENG.Focus()
    End Sub


    Private Sub btnValidatePrev_Click(sender As Object, e As EventArgs) Handles btnValidatePrev.Click
        btnCopyAndValidate.PerformClick()

        ReadPrevRow_DGV()

        txt_mtextENG.Focus()
    End Sub


    Private Sub btnNextRow_Click(sender As Object, e As EventArgs) Handles btnNextRow.Click
        If txtChanged Then
            If MsgBox("Male or Female texts had been changed. Do you want to go to the next row?", vbOKCancel, "Warning") = vbOK Then
                txtChanged = False
            Else
                Exit Sub
            End If
        End If

        ReadNextRow_DGV()
    End Sub


    Private Sub btnPrevRow_Click(sender As Object, e As EventArgs) Handles btnPrevRow.Click
        If txtChanged Then
            If MsgBox("Male or Female texts had been changed. Do you want to go to the previous row?", vbOKCancel, "Warning") = vbOK Then
                txtChanged = False
            Else
                Exit Sub
            End If
        End If

        ReadPrevRow_DGV()
    End Sub


    Private Sub txt_mtext_Leave(sender As Object, e As EventArgs) Handles txt_mtextENG.Leave
        If maleString <> txt_mtextENG.Text Then
            txtChanged = True
        End If
    End Sub


    Private Sub txt_ftext_Leave(sender As Object, e As EventArgs) Handles txt_ftextENG.Leave
        If femaleString <> txt_ftextENG.Text Then
            txtChanged = True
        End If
    End Sub


    Private Sub txt_mtext_GotFocus(sender As Object, e As EventArgs) Handles txt_mtextENG.GotFocus
        txt_mtextENG.SelectAll()

        If txt_jumplineENG.Text = "#" Then
            btnLookUpReferents.Enabled = True
        Else
            btnLookUpReferents.Enabled = False
        End If
    End Sub


    Private Sub txt_ftext_GotFocus(sender As Object, e As EventArgs) Handles txt_ftextENG.GotFocus
        txt_ftextENG.SelectAll()
    End Sub


    Private Sub txt_mtext_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_mtextENG.KeyDown
        If e.KeyCode = Keys.PageDown Then
            If maleString <> txt_mtext.Text Then
                txtChanged = True
            End If

            btnNextRow.PerformClick()
        ElseIf e.KeyCode = Keys.PageUp Then
            If maleString <> txt_mtext.Text Then
                txtChanged = True
            End If

            btnPrevRow.PerformClick()
        End If
    End Sub


    Private Sub txt_ftext_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ftextENG.KeyDown
        If e.KeyCode = Keys.PageDown Then
            If femaleString <> txt_ftext.Text Then
                txtChanged = True
            End If

            btnNextRow.PerformClick()
        ElseIf e.KeyCode = Keys.PageUp Then
            If femaleString <> txt_ftext.Text Then
                txtChanged = True
            End If

            btnPrevRow.PerformClick()
        End If
    End Sub


    Private Sub frmEveryoneData_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        Me.Owner = frmVtMBTranslator
        Me.Location = New Point(Me.Location.X + 200, Me.Location.Y)
    End Sub


    Private Sub frmEveryoneData_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        If frmVtMBTranslator.LookUpReferentsActive Then Return
        Me.BringToFront()
    End Sub


    Private Sub frmEveryoneData_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.S And e.Control Then
            btnValidate.PerformClick()
            frmVtMBTranslator.btnSaveDLG1.Tag = " "
            frmVtMBTranslator.btnSaveDLG1.PerformClick()

            e.SuppressKeyPress = True
        End If
    End Sub


    Private Sub frmEveryoneData_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Opacity = 1
        frmGTCL_FS.Hide()
    End Sub

    Private Sub btnCopyAndValidate_Click(sender As Object, e As EventArgs) Handles btnCopyAndValidate.Click
        txt_mtextENG.Text = txt_mtext.Text
        txt_ftextENG.Text = txt_ftext.Text

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

    Private Sub btnLookUpReferents_Click(sender As Object, e As EventArgs) Handles btnLookUpReferents.Click
        If txt_mtextENG.Text.Length > 0 And txt_jumplineENG.Text = "#" Then
            frmLookUpReferents.txt_mtext.Text = txt_mtextENG.Text

            frmLookUpReferents.SearchReferent(CInt(txt_rownum.Text))

            frmVtMBTranslator.LookUpReferentsActive = True

            frmLookUpReferents.Show()
            frmLookUpReferents.BringToFront()
            frmLookUpReferents.btnClose.Focus()
        End If
    End Sub

    Private Sub btnTranslateDeepL_Click(sender As Object, e As EventArgs) Handles btnTranslateDeepL.Click
        Dim strTranslatedResult As String = ""

        If txt_mtextENG.Text.Length > 0 Then
            strTranslatedResult = frmVtMBTranslator.TranslateDEEPL(txt_mtextENG.Text)
        End If

        txt_mtextENG.Text = strTranslatedResult
    End Sub
End Class