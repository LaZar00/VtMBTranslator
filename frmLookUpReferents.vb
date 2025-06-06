Public Class frmLookUpReferents
    Dim giNumRow As Integer

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmVtMBTranslator.LookUpReferentsActive = False

        Me.Close()

        frmVtMBTranslator.BringToFront()
        frmEveryoneData.BringToFront()
    End Sub


    Public Sub SearchReferent(ByVal numRowToFind As Integer)
        Dim numRow As Integer = 0
        Dim numJumpToFind As Integer = 0
        Dim found As Boolean = False

        txtMaleText.Text = ""
        txtFemaleText.Text = ""
        txtLineNumber.Text = ""
        giNumRow = 0

        With frmVtMBTranslator.dgvDLG1
            'numRow = .CurrentRow.Index

            'If Not .Rows(numRow).Cells(1).Value Is Nothing Then
            '    If .Rows(numRow).Cells(1).Value <> "" Then
            'If .Rows(numRow).Cells(3).Value = "#" Then
            If frmEveryoneData.txt_jumplineENG.Text = "#" Then
                ' Search referent for talking NPC with Male and Female lines.
                While numRow < .RowCount And Not found
                    Int32.TryParse(.Rows(numRow).Cells(3).Value, numJumpToFind)
                    If numJumpToFind = numRowToFind Then
                        found = True
                    End If

                    If Not found Then numRow += 1
                End While

                If found Then
                    txtMaleText.Text = .Rows(numRow).Cells(1).Value
                    txtFemaleText.Text = .Rows(numRow).Cells(2).Value

                    giNumRow = numRow

                    txtLineNumber.Text = (giNumRow + 1).ToString()

                    btnGo.Enabled = True
                Else
                    txtMaleText.Text = "NOT FOUND"

                    btnGo.Enabled = False
                End If
            End If
            '    End If
            'End If
        End With

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        frmVtMBTranslator.dgvDLG1.Rows(giNumRow).Selected = True
        frmVtMBTranslator.dgvDLG1.Rows(giNumRow).Cells(0).Selected = True
    End Sub

    Private Sub frmLookUpReferents_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.Opacity = 1
    End Sub

    Private Sub frmLookUpReferents_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        Me.Owner = frmVtMBTranslator
    End Sub

    Private Sub frmLookUpReferents_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        Me.BringToFront()
    End Sub
End Class