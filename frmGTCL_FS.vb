Public Class frmGTCL_FS
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Public Sub subGTCL()
        Dim row, coderow As Integer
        Dim found As Boolean

        If txtGTCL_FS.Text <> "" Then
            If Int32.TryParse(txtGTCL_FS.Text, coderow) Then
                With frmVtMBTranslator.dgvDLG1
                    row = 0
                    found = False

                    While row < .RowCount And Not found
                        If .Rows(row).Cells(0).Value <> "" And IsNumeric(.Rows(row).Cells(0).Value) Then
                            If CInt(.Rows(row).Cells(0).Value) = coderow Then
                                found = True
                            Else
                                row = row + 1
                            End If
                        Else
                            row = row + 1
                        End If
                    End While

                    ' Go to row in DataGridView
                    If row < .RowCount Then
                        'frmVtMBTranslator.dgvDLG1.ClearSelection()
                        frmVtMBTranslator.dgvDLG1.CurrentCell = frmVtMBTranslator.dgvDLG1.Rows(row).Cells(0)

                        Me.Hide()
                    Else
                        MsgBox("The code line does not exists.",, "Warning")
                    End If
                End With
            Else
                MsgBox("The value is not numeric.",, "Warning")
            End If
        Else
            Me.Close()
        End If
    End Sub


    Private Sub btnGTCL_FS_Click(sender As Object, e As EventArgs) Handles btnGTCL_FS.Click
        If Me.Tag = 1 Then
            subGTCL()
            txtGTCL_FS.Focus()
        Else
            If cbSearchSecondary.Enabled And cbSearchSecondary.Checked Then
                frmVtMBTranslator.cbSearchEnabled = True
            Else
                frmVtMBTranslator.cbSearchEnabled = False
            End If

            frmVtMBTranslator.searchText = txtGTCL_FS.Text
            Me.Close()
        End If
    End Sub


    Private Sub frmGTCL_FS_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        Me.Owner = frmVtMBTranslator
    End Sub


    Private Sub frmGTCL_FS_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If Me.Tag = 1 Then
            ' This is for Go to Code Line option.
            Me.Text = "Go To Line Code"
            lblGTCL_FS.Text = "Go to line with line number:"
            btnGTCL_FS.Text = "Go To..."

            cbSearchSecondary.Enabled = False
            cbSearchSecondary.Visible = False
            cbCaseSensitive.Enabled = False
            cbCaseSensitive.Visible = False

            If txtGTCL_FS.Text.Length <= 0 Then txtGTCL_FS.Text = 1
        Else
            ' This is for Find English String option.
            Me.Text = "Find String"
            lblGTCL_FS.Text = "Find string:"
            btnGTCL_FS.Text = "Find..."

            cbSearchSecondary.Visible = True
            cbCaseSensitive.Visible = True
            cbCaseSensitive.Enabled = True

            cbCaseSensitive.Checked = frmVtMBTranslator.FT.bCaseSensitive

            If frmVtMBTranslator.numRowsDLG2 > 0 Then
                cbSearchSecondary.Enabled = True
            End If

            txtGTCL_FS.Text = frmVtMBTranslator.searchText
        End If

        txtGTCL_FS.Focus()
        txtGTCL_FS.SelectAll()
    End Sub


    Private Sub txtGTCL_FS_GotFocus(sender As Object, e As EventArgs) Handles txtGTCL_FS.GotFocus
        txtGTCL_FS.SelectAll()
    End Sub


    Public Sub subFS(ByRef fromRow As Integer)
        Dim found As Boolean
        Dim auxDGV As DataGridView
        Dim strMsgBox As String
        Dim cell As Integer = 0
        Dim vbCaseSensitive As CompareMethod

        If frmVtMBTranslator.searchText <> "" Then
            'If cbSearchSecondary.Checked And frmVtMBTranslator.numRowsDLG1 <> frmVtMBTranslator.numRowsDLG2 Then
            '    MsgBox("There should be the same number of rows in Primary and Secondary data to make this search.")
            '    Exit Sub
            'End If

            If frmVtMBTranslator.FT.bCaseSensitive Then
                vbCaseSensitive = CompareMethod.Binary
            Else
                vbCaseSensitive = CompareMethod.Text
            End If

            If frmVtMBTranslator.cbSearchEnabled Then
                auxDGV = frmVtMBTranslator.dgvDLG2
                strMsgBox = "The string has not been found in secondary data."
            Else
                auxDGV = frmVtMBTranslator.dgvDLG1
                strMsgBox = "The string has not been found in primary data."
            End If

            With auxDGV
                If fromRow >= .RowCount Then fromRow = 0
                found = False

                While fromRow < .RowCount And Not found
                    If .Rows(fromRow).Cells(1).Value <> "" Then
                        If InStr(.Rows(fromRow).Cells(1).Value, frmVtMBTranslator.searchText, vbCaseSensitive) Then
                            found = True
                            cell = 1
                        End If
                    End If

                    If .Rows(fromRow).Cells(2).Value <> "" And Not found Then
                        If InStr(.Rows(fromRow).Cells(2).Value, frmVtMBTranslator.searchText, vbCaseSensitive) Then
                            found = True
                            cell = 2
                        End If
                    End If

                    If .Rows(fromRow).Cells(6).Value <> "" And Not found Then
                        If InStr(.Rows(fromRow).Cells(6).Value, frmVtMBTranslator.searchText, vbCaseSensitive) Then
                            found = True
                            cell = 6
                        End If
                    End If

                    If .Rows(fromRow).Cells(7).Value <> "" And Not found Then
                        If InStr(.Rows(fromRow).Cells(7).Value, frmVtMBTranslator.searchText, vbCaseSensitive) Then
                            found = True
                            cell = 7
                        End If
                    End If

                    If .Rows(fromRow).Cells(8).Value <> "" And Not found Then
                        If InStr(.Rows(fromRow).Cells(8).Value, frmVtMBTranslator.searchText, vbCaseSensitive) Then
                            found = True
                            cell = 8
                        End If
                    End If

                    If .Rows(fromRow).Cells(9).Value <> "" And Not found Then
                        If InStr(.Rows(fromRow).Cells(9).Value, frmVtMBTranslator.searchText, vbCaseSensitive) Then
                            found = True
                            cell = 9
                        End If
                    End If

                    If .Rows(fromRow).Cells(10).Value <> "" And Not found Then
                        If InStr(.Rows(fromRow).Cells(10).Value, frmVtMBTranslator.searchText, vbCaseSensitive) Then
                            found = True
                            cell = 10
                        End If
                    End If

                    If .Rows(fromRow).Cells(11).Value <> "" And Not found Then
                        If InStr(.Rows(fromRow).Cells(11).Value, frmVtMBTranslator.searchText, vbCaseSensitive) Then
                            found = True
                            cell = 11
                        End If
                    End If

                    If .Rows(fromRow).Cells(12).Value <> "" And Not found Then
                        If InStr(.Rows(fromRow).Cells(12).Value, frmVtMBTranslator.searchText, vbCaseSensitive) Then
                            found = True
                            cell = 12
                        End If
                    End If

                    If Not found Then fromRow = fromRow + 1
                End While

                ' Go to row in DataGridView
                If found And fromRow < frmVtMBTranslator.dgvDLG1.RowCount Then
                    frmVtMBTranslator.dgvDLG1.CurrentCell = frmVtMBTranslator.dgvDLG1.Rows(fromRow).Cells(cell)
                    frmVtMBTranslator.dgvDLG1.Rows(fromRow).Cells(cell).Selected = True

                    If frmVtMBTranslator.numRowsDLG2 > 0 And fromRow < frmVtMBTranslator.dgvDLG2.RowCount Then
                        frmVtMBTranslator.dgvDLG2.CurrentCell = frmVtMBTranslator.dgvDLG2.Rows(fromRow).Cells(cell)
                        frmVtMBTranslator.dgvDLG2.Rows(fromRow).Cells(cell).Selected = True
                    End If

                    Me.Close()
                Else
                    If frmVtMBTranslator.oldsearchRow = 0 Then
                        MsgBox(strMsgBox,, "Warning")
                    End If
                End If
            End With
        Else
            Me.Close()
        End If

    End Sub

    Private Sub cbCaseSensitive_CheckedChanged(sender As Object, e As EventArgs) Handles cbCaseSensitive.CheckedChanged
        frmVtMBTranslator.FT.bCaseSensitive = cbCaseSensitive.Checked
        frmVtMBTranslator.FT.WriteCFGFile()
    End Sub

    Private Sub frmGTCL_FS_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmVtMBTranslator.BringToFront()
        frmVtMBTranslator.Focus()
    End Sub
End Class