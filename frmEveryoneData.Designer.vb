<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEveryoneData
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblLineNumber = New System.Windows.Forms.Label()
        Me.lblMaleText = New System.Windows.Forms.Label()
        Me.lblFemaleText = New System.Windows.Forms.Label()
        Me.lblCondition = New System.Windows.Forms.Label()
        Me.lblJumpToLine = New System.Windows.Forms.Label()
        Me.lblExecPyAction = New System.Windows.Forms.Label()
        Me.txt_lnumENG = New System.Windows.Forms.TextBox()
        Me.txt_mtextENG = New System.Windows.Forms.TextBox()
        Me.txt_ftextENG = New System.Windows.Forms.TextBox()
        Me.txt_lconditionENG = New System.Windows.Forms.TextBox()
        Me.txt_jumplineENG = New System.Windows.Forms.TextBox()
        Me.txt_setflagsENG = New System.Windows.Forms.TextBox()
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txt_mtext = New System.Windows.Forms.TextBox()
        Me.txt_ftext = New System.Windows.Forms.TextBox()
        Me.txt_lcondition = New System.Windows.Forms.TextBox()
        Me.txt_setflags = New System.Windows.Forms.TextBox()
        Me.txt_lnum = New System.Windows.Forms.TextBox()
        Me.txt_jumpline = New System.Windows.Forms.TextBox()
        Me.lblRowNumber = New System.Windows.Forms.Label()
        Me.txt_rownum = New System.Windows.Forms.TextBox()
        Me.btnValidateNext = New System.Windows.Forms.Button()
        Me.btnValidatePrev = New System.Windows.Forms.Button()
        Me.btnPrevRow = New System.Windows.Forms.Button()
        Me.btnNextRow = New System.Windows.Forms.Button()
        Me.cbCAL = New System.Windows.Forms.CheckBox()
        Me.btnCopyAndValidate = New System.Windows.Forms.Button()
        Me.btnValidateNextRow = New System.Windows.Forms.Button()
        Me.btnValidatePrevRow = New System.Windows.Forms.Button()
        Me.chkJumpEmptyRows = New System.Windows.Forms.CheckBox()
        Me.btnLookUpReferents = New System.Windows.Forms.Button()
        Me.btnTranslateDeepL = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLineNumber
        '
        Me.lblLineNumber.AutoSize = True
        Me.lblLineNumber.Location = New System.Drawing.Point(10, 9)
        Me.lblLineNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLineNumber.Name = "lblLineNumber"
        Me.lblLineNumber.Size = New System.Drawing.Size(86, 16)
        Me.lblLineNumber.TabIndex = 0
        Me.lblLineNumber.Text = "Line Number:"
        '
        'lblMaleText
        '
        Me.lblMaleText.AutoSize = True
        Me.lblMaleText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblMaleText.Location = New System.Drawing.Point(10, 38)
        Me.lblMaleText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMaleText.Name = "lblMaleText"
        Me.lblMaleText.Size = New System.Drawing.Size(79, 16)
        Me.lblMaleText.TabIndex = 1
        Me.lblMaleText.Text = "Male Text:"
        '
        'lblFemaleText
        '
        Me.lblFemaleText.AutoSize = True
        Me.lblFemaleText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblFemaleText.Location = New System.Drawing.Point(10, 324)
        Me.lblFemaleText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFemaleText.Name = "lblFemaleText"
        Me.lblFemaleText.Size = New System.Drawing.Size(97, 16)
        Me.lblFemaleText.TabIndex = 2
        Me.lblFemaleText.Text = "Female Text:"
        '
        'lblCondition
        '
        Me.lblCondition.AutoSize = True
        Me.lblCondition.Location = New System.Drawing.Point(7, 610)
        Me.lblCondition.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCondition.Name = "lblCondition"
        Me.lblCondition.Size = New System.Drawing.Size(66, 16)
        Me.lblCondition.TabIndex = 4
        Me.lblCondition.Text = "Condition:"
        '
        'lblJumpToLine
        '
        Me.lblJumpToLine.AutoSize = True
        Me.lblJumpToLine.Location = New System.Drawing.Point(447, 9)
        Me.lblJumpToLine.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblJumpToLine.Name = "lblJumpToLine"
        Me.lblJumpToLine.Size = New System.Drawing.Size(85, 16)
        Me.lblJumpToLine.TabIndex = 5
        Me.lblJumpToLine.Text = "Jump to Line:"
        '
        'lblExecPyAction
        '
        Me.lblExecPyAction.AutoSize = True
        Me.lblExecPyAction.Location = New System.Drawing.Point(7, 682)
        Me.lblExecPyAction.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblExecPyAction.Name = "lblExecPyAction"
        Me.lblExecPyAction.Size = New System.Drawing.Size(142, 16)
        Me.lblExecPyAction.TabIndex = 6
        Me.lblExecPyAction.Text = "Execute Python Action:"
        '
        'txt_lnumENG
        '
        Me.txt_lnumENG.Location = New System.Drawing.Point(104, 6)
        Me.txt_lnumENG.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_lnumENG.Name = "txt_lnumENG"
        Me.txt_lnumENG.ReadOnly = True
        Me.txt_lnumENG.Size = New System.Drawing.Size(67, 22)
        Me.txt_lnumENG.TabIndex = 7
        Me.txt_lnumENG.TabStop = False
        '
        'txt_mtextENG
        '
        Me.txt_mtextENG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_mtextENG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mtextENG.Location = New System.Drawing.Point(10, 55)
        Me.txt_mtextENG.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_mtextENG.Multiline = True
        Me.txt_mtextENG.Name = "txt_mtextENG"
        Me.txt_mtextENG.Size = New System.Drawing.Size(938, 130)
        Me.txt_mtextENG.TabIndex = 0
        '
        'txt_ftextENG
        '
        Me.txt_ftextENG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ftextENG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ftextENG.Location = New System.Drawing.Point(10, 341)
        Me.txt_ftextENG.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_ftextENG.Multiline = True
        Me.txt_ftextENG.Name = "txt_ftextENG"
        Me.txt_ftextENG.Size = New System.Drawing.Size(938, 130)
        Me.txt_ftextENG.TabIndex = 1
        '
        'txt_lconditionENG
        '
        Me.txt_lconditionENG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_lconditionENG.Location = New System.Drawing.Point(10, 628)
        Me.txt_lconditionENG.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_lconditionENG.Multiline = True
        Me.txt_lconditionENG.Name = "txt_lconditionENG"
        Me.txt_lconditionENG.ReadOnly = True
        Me.txt_lconditionENG.Size = New System.Drawing.Size(938, 25)
        Me.txt_lconditionENG.TabIndex = 2
        '
        'txt_jumplineENG
        '
        Me.txt_jumplineENG.Location = New System.Drawing.Point(537, 6)
        Me.txt_jumplineENG.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_jumplineENG.Name = "txt_jumplineENG"
        Me.txt_jumplineENG.ReadOnly = True
        Me.txt_jumplineENG.Size = New System.Drawing.Size(67, 22)
        Me.txt_jumplineENG.TabIndex = 5
        '
        'txt_setflagsENG
        '
        Me.txt_setflagsENG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_setflagsENG.Location = New System.Drawing.Point(10, 700)
        Me.txt_setflagsENG.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_setflagsENG.Name = "txt_setflagsENG"
        Me.txt_setflagsENG.ReadOnly = True
        Me.txt_setflagsENG.Size = New System.Drawing.Size(938, 22)
        Me.txt_setflagsENG.TabIndex = 3
        '
        'btnValidate
        '
        Me.btnValidate.Location = New System.Drawing.Point(503, 749)
        Me.btnValidate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(82, 44)
        Me.btnValidate.TabIndex = 8
        Me.btnValidate.Text = "Validate"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(842, 749)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(106, 44)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txt_mtext
        '
        Me.txt_mtext.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_mtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mtext.Location = New System.Drawing.Point(10, 189)
        Me.txt_mtext.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_mtext.Multiline = True
        Me.txt_mtext.Name = "txt_mtext"
        Me.txt_mtext.ReadOnly = True
        Me.txt_mtext.Size = New System.Drawing.Size(938, 130)
        Me.txt_mtext.TabIndex = 16
        Me.txt_mtext.TabStop = False
        '
        'txt_ftext
        '
        Me.txt_ftext.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ftext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ftext.Location = New System.Drawing.Point(10, 475)
        Me.txt_ftext.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_ftext.Multiline = True
        Me.txt_ftext.Name = "txt_ftext"
        Me.txt_ftext.ReadOnly = True
        Me.txt_ftext.Size = New System.Drawing.Size(938, 130)
        Me.txt_ftext.TabIndex = 17
        Me.txt_ftext.TabStop = False
        '
        'txt_lcondition
        '
        Me.txt_lcondition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_lcondition.Location = New System.Drawing.Point(10, 655)
        Me.txt_lcondition.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_lcondition.Multiline = True
        Me.txt_lcondition.Name = "txt_lcondition"
        Me.txt_lcondition.ReadOnly = True
        Me.txt_lcondition.Size = New System.Drawing.Size(938, 25)
        Me.txt_lcondition.TabIndex = 19
        Me.txt_lcondition.TabStop = False
        '
        'txt_setflags
        '
        Me.txt_setflags.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_setflags.Location = New System.Drawing.Point(10, 724)
        Me.txt_setflags.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_setflags.Name = "txt_setflags"
        Me.txt_setflags.ReadOnly = True
        Me.txt_setflags.Size = New System.Drawing.Size(938, 22)
        Me.txt_setflags.TabIndex = 20
        Me.txt_setflags.TabStop = False
        '
        'txt_lnum
        '
        Me.txt_lnum.Location = New System.Drawing.Point(175, 6)
        Me.txt_lnum.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_lnum.Name = "txt_lnum"
        Me.txt_lnum.ReadOnly = True
        Me.txt_lnum.Size = New System.Drawing.Size(67, 22)
        Me.txt_lnum.TabIndex = 21
        Me.txt_lnum.TabStop = False
        '
        'txt_jumpline
        '
        Me.txt_jumpline.Location = New System.Drawing.Point(608, 6)
        Me.txt_jumpline.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_jumpline.Name = "txt_jumpline"
        Me.txt_jumpline.ReadOnly = True
        Me.txt_jumpline.Size = New System.Drawing.Size(67, 22)
        Me.txt_jumpline.TabIndex = 23
        Me.txt_jumpline.TabStop = False
        '
        'lblRowNumber
        '
        Me.lblRowNumber.AutoSize = True
        Me.lblRowNumber.Location = New System.Drawing.Point(446, 30)
        Me.lblRowNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRowNumber.Name = "lblRowNumber"
        Me.lblRowNumber.Size = New System.Drawing.Size(88, 16)
        Me.lblRowNumber.TabIndex = 24
        Me.lblRowNumber.Text = "Row Number:"
        '
        'txt_rownum
        '
        Me.txt_rownum.Location = New System.Drawing.Point(537, 29)
        Me.txt_rownum.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_rownum.Name = "txt_rownum"
        Me.txt_rownum.ReadOnly = True
        Me.txt_rownum.Size = New System.Drawing.Size(67, 22)
        Me.txt_rownum.TabIndex = 25
        Me.txt_rownum.TabStop = False
        '
        'btnValidateNext
        '
        Me.btnValidateNext.Location = New System.Drawing.Point(295, 749)
        Me.btnValidateNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnValidateNext.Name = "btnValidateNext"
        Me.btnValidateNext.Size = New System.Drawing.Size(120, 44)
        Me.btnValidateNext.TabIndex = 6
        Me.btnValidateNext.Text = "Copy && Validate Next Row"
        Me.btnValidateNext.UseVisualStyleBackColor = True
        '
        'btnValidatePrev
        '
        Me.btnValidatePrev.Location = New System.Drawing.Point(49, 749)
        Me.btnValidatePrev.Margin = New System.Windows.Forms.Padding(2)
        Me.btnValidatePrev.Name = "btnValidatePrev"
        Me.btnValidatePrev.Size = New System.Drawing.Size(122, 44)
        Me.btnValidatePrev.TabIndex = 7
        Me.btnValidatePrev.Text = "Copy && Validate " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Prev Row"
        Me.btnValidatePrev.UseVisualStyleBackColor = True
        '
        'btnPrevRow
        '
        Me.btnPrevRow.Location = New System.Drawing.Point(8, 749)
        Me.btnPrevRow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrevRow.Name = "btnPrevRow"
        Me.btnPrevRow.Size = New System.Drawing.Size(37, 44)
        Me.btnPrevRow.TabIndex = 10
        Me.btnPrevRow.Text = "<<"
        Me.btnPrevRow.UseVisualStyleBackColor = True
        '
        'btnNextRow
        '
        Me.btnNextRow.Location = New System.Drawing.Point(674, 749)
        Me.btnNextRow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNextRow.Name = "btnNextRow"
        Me.btnNextRow.Size = New System.Drawing.Size(37, 44)
        Me.btnNextRow.TabIndex = 9
        Me.btnNextRow.Text = ">>"
        Me.btnNextRow.UseVisualStyleBackColor = True
        '
        'cbCAL
        '
        Me.cbCAL.CausesValidation = False
        Me.cbCAL.Checked = True
        Me.cbCAL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCAL.Location = New System.Drawing.Point(289, 6)
        Me.cbCAL.Name = "cbCAL"
        Me.cbCAL.Size = New System.Drawing.Size(131, 24)
        Me.cbCAL.TabIndex = 27
        Me.cbCAL.Tag = ""
        Me.cbCAL.Text = "Change all lines"
        Me.cbCAL.UseVisualStyleBackColor = True
        '
        'btnCopyAndValidate
        '
        Me.btnCopyAndValidate.Location = New System.Drawing.Point(173, 749)
        Me.btnCopyAndValidate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCopyAndValidate.Name = "btnCopyAndValidate"
        Me.btnCopyAndValidate.Size = New System.Drawing.Size(120, 44)
        Me.btnCopyAndValidate.TabIndex = 28
        Me.btnCopyAndValidate.Text = "Copy && Validate"
        Me.btnCopyAndValidate.UseVisualStyleBackColor = True
        '
        'btnValidateNextRow
        '
        Me.btnValidateNextRow.Location = New System.Drawing.Point(588, 749)
        Me.btnValidateNextRow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnValidateNextRow.Name = "btnValidateNextRow"
        Me.btnValidateNextRow.Size = New System.Drawing.Size(82, 44)
        Me.btnValidateNextRow.TabIndex = 29
        Me.btnValidateNextRow.Text = "Validate Next Row"
        Me.btnValidateNextRow.UseVisualStyleBackColor = True
        '
        'btnValidatePrevRow
        '
        Me.btnValidatePrevRow.Location = New System.Drawing.Point(418, 749)
        Me.btnValidatePrevRow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnValidatePrevRow.Name = "btnValidatePrevRow"
        Me.btnValidatePrevRow.Size = New System.Drawing.Size(82, 44)
        Me.btnValidatePrevRow.TabIndex = 30
        Me.btnValidatePrevRow.Text = "Validate Prev Row"
        Me.btnValidatePrevRow.UseVisualStyleBackColor = True
        '
        'chkJumpEmptyRows
        '
        Me.chkJumpEmptyRows.AutoSize = True
        Me.chkJumpEmptyRows.Checked = True
        Me.chkJumpEmptyRows.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkJumpEmptyRows.Location = New System.Drawing.Point(289, 29)
        Me.chkJumpEmptyRows.Name = "chkJumpEmptyRows"
        Me.chkJumpEmptyRows.Size = New System.Drawing.Size(133, 20)
        Me.chkJumpEmptyRows.TabIndex = 31
        Me.chkJumpEmptyRows.Text = "Jump empty rows"
        Me.chkJumpEmptyRows.UseVisualStyleBackColor = True
        '
        'btnLookUpReferents
        '
        Me.btnLookUpReferents.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLookUpReferents.Location = New System.Drawing.Point(759, 5)
        Me.btnLookUpReferents.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLookUpReferents.Name = "btnLookUpReferents"
        Me.btnLookUpReferents.Size = New System.Drawing.Size(188, 44)
        Me.btnLookUpReferents.TabIndex = 32
        Me.btnLookUpReferents.Text = "Look Up Referent (#)"
        Me.btnLookUpReferents.UseVisualStyleBackColor = True
        '
        'btnTranslateDeepL
        '
        Me.btnTranslateDeepL.BackgroundImage = Global.VtMBTranslator.My.Resources.Resources.deepl
        Me.btnTranslateDeepL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTranslateDeepL.Location = New System.Drawing.Point(710, 5)
        Me.btnTranslateDeepL.Name = "btnTranslateDeepL"
        Me.btnTranslateDeepL.Size = New System.Drawing.Size(44, 44)
        Me.btnTranslateDeepL.TabIndex = 33
        Me.btnTranslateDeepL.UseVisualStyleBackColor = True
        '
        'frmEveryoneData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(959, 797)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnTranslateDeepL)
        Me.Controls.Add(Me.btnLookUpReferents)
        Me.Controls.Add(Me.chkJumpEmptyRows)
        Me.Controls.Add(Me.btnValidatePrevRow)
        Me.Controls.Add(Me.btnValidateNextRow)
        Me.Controls.Add(Me.btnCopyAndValidate)
        Me.Controls.Add(Me.cbCAL)
        Me.Controls.Add(Me.btnNextRow)
        Me.Controls.Add(Me.btnPrevRow)
        Me.Controls.Add(Me.btnValidatePrev)
        Me.Controls.Add(Me.btnValidateNext)
        Me.Controls.Add(Me.txt_rownum)
        Me.Controls.Add(Me.lblRowNumber)
        Me.Controls.Add(Me.txt_jumpline)
        Me.Controls.Add(Me.txt_lnum)
        Me.Controls.Add(Me.txt_setflags)
        Me.Controls.Add(Me.txt_lcondition)
        Me.Controls.Add(Me.txt_ftext)
        Me.Controls.Add(Me.txt_mtext)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnValidate)
        Me.Controls.Add(Me.txt_setflagsENG)
        Me.Controls.Add(Me.txt_jumplineENG)
        Me.Controls.Add(Me.txt_lconditionENG)
        Me.Controls.Add(Me.txt_ftextENG)
        Me.Controls.Add(Me.txt_mtextENG)
        Me.Controls.Add(Me.txt_lnumENG)
        Me.Controls.Add(Me.lblExecPyAction)
        Me.Controls.Add(Me.lblJumpToLine)
        Me.Controls.Add(Me.lblCondition)
        Me.Controls.Add(Me.lblFemaleText)
        Me.Controls.Add(Me.lblMaleText)
        Me.Controls.Add(Me.lblLineNumber)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1200, 844)
        Me.MinimumSize = New System.Drawing.Size(977, 844)
        Me.Name = "frmEveryoneData"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Everyone Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLineNumber As Label
    Friend WithEvents lblMaleText As Label
    Friend WithEvents lblFemaleText As Label
    Friend WithEvents lblCondition As Label
    Friend WithEvents lblJumpToLine As Label
    Friend WithEvents lblExecPyAction As Label
    Friend WithEvents txt_lnumENG As TextBox
    Friend WithEvents txt_mtextENG As TextBox
    Friend WithEvents txt_ftextENG As TextBox
    Friend WithEvents txt_lconditionENG As TextBox
    Friend WithEvents txt_jumplineENG As TextBox
    Friend WithEvents txt_setflagsENG As TextBox
    Friend WithEvents btnValidate As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txt_mtext As TextBox
    Friend WithEvents txt_ftext As TextBox
    Friend WithEvents txt_lcondition As TextBox
    Friend WithEvents txt_setflags As TextBox
    Friend WithEvents txt_lnum As TextBox
    Friend WithEvents txt_jumpline As TextBox
    Friend WithEvents lblRowNumber As Label
    Friend WithEvents txt_rownum As TextBox
    Friend WithEvents btnValidateNext As Button
    Friend WithEvents btnValidatePrev As Button
    Friend WithEvents btnPrevRow As Button
    Friend WithEvents btnNextRow As Button
    Friend WithEvents cbCAL As CheckBox
    Friend WithEvents btnCopyAndValidate As Button
    Friend WithEvents btnValidateNextRow As Button
    Friend WithEvents btnValidatePrevRow As Button
    Friend WithEvents chkJumpEmptyRows As CheckBox
    Friend WithEvents btnLookUpReferents As Button
    Friend WithEvents btnTranslateDeepL As Button
End Class
