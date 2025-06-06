<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClansData
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTremere = New System.Windows.Forms.Label()
        Me.txtTremere = New System.Windows.Forms.TextBox()
        Me.txtTremereENG = New System.Windows.Forms.TextBox()
        Me.lblNosferatu = New System.Windows.Forms.Label()
        Me.txtNosferatu = New System.Windows.Forms.TextBox()
        Me.txtNosferatuENG = New System.Windows.Forms.TextBox()
        Me.lblToreador = New System.Windows.Forms.Label()
        Me.txtToreador = New System.Windows.Forms.TextBox()
        Me.txtToreadorENG = New System.Windows.Forms.TextBox()
        Me.txtVentrue = New System.Windows.Forms.TextBox()
        Me.txtVentrueENG = New System.Windows.Forms.TextBox()
        Me.lblVentrue = New System.Windows.Forms.Label()
        Me.txtMalkavian = New System.Windows.Forms.TextBox()
        Me.txtMalkavianENG = New System.Windows.Forms.TextBox()
        Me.lblMalkavian = New System.Windows.Forms.Label()
        Me.cbCAL = New System.Windows.Forms.CheckBox()
        Me.txt_rownum = New System.Windows.Forms.TextBox()
        Me.txt_lnum = New System.Windows.Forms.TextBox()
        Me.txt_lnumENG = New System.Windows.Forms.TextBox()
        Me.lblLineNumber = New System.Windows.Forms.Label()
        Me.lblRowNumber = New System.Windows.Forms.Label()
        Me.btnValidatePrevRow = New System.Windows.Forms.Button()
        Me.btnValidateNextRow = New System.Windows.Forms.Button()
        Me.btnCopyAndValidate = New System.Windows.Forms.Button()
        Me.btnNextRow = New System.Windows.Forms.Button()
        Me.btnPrevRow = New System.Windows.Forms.Button()
        Me.btnValidatePrev = New System.Windows.Forms.Button()
        Me.btnValidateNext = New System.Windows.Forms.Button()
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.chkJumpEmptyRows = New System.Windows.Forms.CheckBox()
        Me.tablelayoutPanelMAIN = New System.Windows.Forms.TableLayoutPanel()
        Me.tablelayoutPanelToreador = New System.Windows.Forms.TableLayoutPanel()
        Me.tablelayoutPanelNosferatu = New System.Windows.Forms.TableLayoutPanel()
        Me.tablelayoutPanelMalkavian = New System.Windows.Forms.TableLayoutPanel()
        Me.tablelayoutPanelVentrue = New System.Windows.Forms.TableLayoutPanel()
        Me.tablelayoutPanelGangrel = New System.Windows.Forms.TableLayoutPanel()
        Me.lblGangrel = New System.Windows.Forms.Label()
        Me.txtGangrel = New System.Windows.Forms.TextBox()
        Me.txtGangrelENG = New System.Windows.Forms.TextBox()
        Me.tablelayoutPanelTremere = New System.Windows.Forms.TableLayoutPanel()
        Me.panelButtons = New System.Windows.Forms.Panel()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.btnTranslateVDeepL = New System.Windows.Forms.Button()
        Me.btnTranslateMDeepL = New System.Windows.Forms.Button()
        Me.tablelayoutPanelBrujah = New System.Windows.Forms.TableLayoutPanel()
        Me.lblBrujah = New System.Windows.Forms.Label()
        Me.txtBrujah = New System.Windows.Forms.TextBox()
        Me.txtBrujahENG = New System.Windows.Forms.TextBox()
        Me.tablelayoutPanelMAIN.SuspendLayout()
        Me.tablelayoutPanelToreador.SuspendLayout()
        Me.tablelayoutPanelNosferatu.SuspendLayout()
        Me.tablelayoutPanelMalkavian.SuspendLayout()
        Me.tablelayoutPanelVentrue.SuspendLayout()
        Me.tablelayoutPanelGangrel.SuspendLayout()
        Me.tablelayoutPanelTremere.SuspendLayout()
        Me.panelButtons.SuspendLayout()
        Me.tablelayoutPanelBrujah.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(557, 129)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 44)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblTremere
        '
        Me.lblTremere.AutoSize = True
        Me.lblTremere.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblTremere.Location = New System.Drawing.Point(4, 2)
        Me.lblTremere.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTremere.Name = "lblTremere"
        Me.lblTremere.Size = New System.Drawing.Size(103, 16)
        Me.lblTremere.TabIndex = 11
        Me.lblTremere.Text = "Tremere Line:"
        '
        'txtTremere
        '
        Me.txtTremere.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTremere.BackColor = System.Drawing.SystemColors.Control
        Me.txtTremere.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTremere.Location = New System.Drawing.Point(2, 100)
        Me.txtTremere.Margin = New System.Windows.Forms.Padding(0)
        Me.txtTremere.Multiline = True
        Me.txtTremere.Name = "txtTremere"
        Me.txtTremere.ReadOnly = True
        Me.txtTremere.Size = New System.Drawing.Size(713, 79)
        Me.txtTremere.TabIndex = 17
        '
        'txtTremereENG
        '
        Me.txtTremereENG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTremereENG.BackColor = System.Drawing.SystemColors.Window
        Me.txtTremereENG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTremereENG.Location = New System.Drawing.Point(2, 20)
        Me.txtTremereENG.Margin = New System.Windows.Forms.Padding(0)
        Me.txtTremereENG.Multiline = True
        Me.txtTremereENG.Name = "txtTremereENG"
        Me.txtTremereENG.Size = New System.Drawing.Size(713, 78)
        Me.txtTremereENG.TabIndex = 16
        '
        'lblNosferatu
        '
        Me.lblNosferatu.AutoSize = True
        Me.lblNosferatu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblNosferatu.Location = New System.Drawing.Point(4, 2)
        Me.lblNosferatu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNosferatu.Name = "lblNosferatu"
        Me.lblNosferatu.Size = New System.Drawing.Size(111, 16)
        Me.lblNosferatu.TabIndex = 18
        Me.lblNosferatu.Text = "Nosferatu Line:"
        '
        'txtNosferatu
        '
        Me.txtNosferatu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNosferatu.BackColor = System.Drawing.SystemColors.Control
        Me.txtNosferatu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNosferatu.Location = New System.Drawing.Point(2, 100)
        Me.txtNosferatu.Margin = New System.Windows.Forms.Padding(0)
        Me.txtNosferatu.Multiline = True
        Me.txtNosferatu.Name = "txtNosferatu"
        Me.txtNosferatu.ReadOnly = True
        Me.txtNosferatu.Size = New System.Drawing.Size(712, 79)
        Me.txtNosferatu.TabIndex = 20
        '
        'txtNosferatuENG
        '
        Me.txtNosferatuENG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNosferatuENG.BackColor = System.Drawing.SystemColors.Window
        Me.txtNosferatuENG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNosferatuENG.Location = New System.Drawing.Point(2, 20)
        Me.txtNosferatuENG.Margin = New System.Windows.Forms.Padding(0)
        Me.txtNosferatuENG.Multiline = True
        Me.txtNosferatuENG.Name = "txtNosferatuENG"
        Me.txtNosferatuENG.Size = New System.Drawing.Size(712, 78)
        Me.txtNosferatuENG.TabIndex = 19
        '
        'lblToreador
        '
        Me.lblToreador.AutoSize = True
        Me.lblToreador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblToreador.Location = New System.Drawing.Point(4, 2)
        Me.lblToreador.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblToreador.Name = "lblToreador"
        Me.lblToreador.Size = New System.Drawing.Size(109, 16)
        Me.lblToreador.TabIndex = 21
        Me.lblToreador.Text = "Toreador Line:"
        '
        'txtToreador
        '
        Me.txtToreador.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtToreador.BackColor = System.Drawing.SystemColors.Control
        Me.txtToreador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToreador.Location = New System.Drawing.Point(2, 102)
        Me.txtToreador.Margin = New System.Windows.Forms.Padding(0)
        Me.txtToreador.Multiline = True
        Me.txtToreador.Name = "txtToreador"
        Me.txtToreador.ReadOnly = True
        Me.txtToreador.Size = New System.Drawing.Size(712, 80)
        Me.txtToreador.TabIndex = 23
        '
        'txtToreadorENG
        '
        Me.txtToreadorENG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtToreadorENG.BackColor = System.Drawing.SystemColors.Window
        Me.txtToreadorENG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToreadorENG.Location = New System.Drawing.Point(2, 20)
        Me.txtToreadorENG.Margin = New System.Windows.Forms.Padding(0)
        Me.txtToreadorENG.Multiline = True
        Me.txtToreadorENG.Name = "txtToreadorENG"
        Me.txtToreadorENG.Size = New System.Drawing.Size(712, 80)
        Me.txtToreadorENG.TabIndex = 22
        '
        'txtVentrue
        '
        Me.txtVentrue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVentrue.BackColor = System.Drawing.SystemColors.Control
        Me.txtVentrue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentrue.Location = New System.Drawing.Point(2, 100)
        Me.txtVentrue.Margin = New System.Windows.Forms.Padding(0)
        Me.txtVentrue.Multiline = True
        Me.txtVentrue.Name = "txtVentrue"
        Me.txtVentrue.ReadOnly = True
        Me.txtVentrue.Size = New System.Drawing.Size(713, 79)
        Me.txtVentrue.TabIndex = 26
        '
        'txtVentrueENG
        '
        Me.txtVentrueENG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVentrueENG.BackColor = System.Drawing.SystemColors.Window
        Me.txtVentrueENG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentrueENG.Location = New System.Drawing.Point(2, 20)
        Me.txtVentrueENG.Margin = New System.Windows.Forms.Padding(0)
        Me.txtVentrueENG.Multiline = True
        Me.txtVentrueENG.Name = "txtVentrueENG"
        Me.txtVentrueENG.Size = New System.Drawing.Size(713, 78)
        Me.txtVentrueENG.TabIndex = 25
        '
        'lblVentrue
        '
        Me.lblVentrue.AutoSize = True
        Me.lblVentrue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblVentrue.Location = New System.Drawing.Point(4, 2)
        Me.lblVentrue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVentrue.Name = "lblVentrue"
        Me.lblVentrue.Size = New System.Drawing.Size(97, 16)
        Me.lblVentrue.TabIndex = 24
        Me.lblVentrue.Text = "Ventrue Line:"
        '
        'txtMalkavian
        '
        Me.txtMalkavian.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMalkavian.BackColor = System.Drawing.SystemColors.Control
        Me.txtMalkavian.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMalkavian.Location = New System.Drawing.Point(2, 100)
        Me.txtMalkavian.Margin = New System.Windows.Forms.Padding(0)
        Me.txtMalkavian.Multiline = True
        Me.txtMalkavian.Name = "txtMalkavian"
        Me.txtMalkavian.ReadOnly = True
        Me.txtMalkavian.Size = New System.Drawing.Size(713, 79)
        Me.txtMalkavian.TabIndex = 29
        '
        'txtMalkavianENG
        '
        Me.txtMalkavianENG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMalkavianENG.BackColor = System.Drawing.SystemColors.Window
        Me.txtMalkavianENG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMalkavianENG.Location = New System.Drawing.Point(2, 20)
        Me.txtMalkavianENG.Margin = New System.Windows.Forms.Padding(0)
        Me.txtMalkavianENG.Multiline = True
        Me.txtMalkavianENG.Name = "txtMalkavianENG"
        Me.txtMalkavianENG.Size = New System.Drawing.Size(713, 78)
        Me.txtMalkavianENG.TabIndex = 28
        '
        'lblMalkavian
        '
        Me.lblMalkavian.AutoSize = True
        Me.lblMalkavian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblMalkavian.Location = New System.Drawing.Point(4, 2)
        Me.lblMalkavian.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMalkavian.Name = "lblMalkavian"
        Me.lblMalkavian.Size = New System.Drawing.Size(115, 16)
        Me.lblMalkavian.TabIndex = 27
        Me.lblMalkavian.Text = "Malkavian Line:"
        '
        'cbCAL
        '
        Me.cbCAL.CausesValidation = False
        Me.cbCAL.Checked = True
        Me.cbCAL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCAL.Location = New System.Drawing.Point(266, 16)
        Me.cbCAL.Name = "cbCAL"
        Me.cbCAL.Size = New System.Drawing.Size(126, 24)
        Me.cbCAL.TabIndex = 34
        Me.cbCAL.Tag = ""
        Me.cbCAL.Text = "Change all lines"
        Me.cbCAL.UseVisualStyleBackColor = True
        '
        'txt_rownum
        '
        Me.txt_rownum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_rownum.Location = New System.Drawing.Point(636, 16)
        Me.txt_rownum.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_rownum.Name = "txt_rownum"
        Me.txt_rownum.ReadOnly = True
        Me.txt_rownum.Size = New System.Drawing.Size(67, 22)
        Me.txt_rownum.TabIndex = 33
        Me.txt_rownum.TabStop = False
        '
        'txt_lnum
        '
        Me.txt_lnum.Location = New System.Drawing.Point(177, 16)
        Me.txt_lnum.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_lnum.Name = "txt_lnum"
        Me.txt_lnum.ReadOnly = True
        Me.txt_lnum.Size = New System.Drawing.Size(67, 22)
        Me.txt_lnum.TabIndex = 32
        Me.txt_lnum.TabStop = False
        '
        'txt_lnumENG
        '
        Me.txt_lnumENG.Location = New System.Drawing.Point(106, 16)
        Me.txt_lnumENG.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_lnumENG.Name = "txt_lnumENG"
        Me.txt_lnumENG.ReadOnly = True
        Me.txt_lnumENG.Size = New System.Drawing.Size(67, 22)
        Me.txt_lnumENG.TabIndex = 31
        Me.txt_lnumENG.TabStop = False
        '
        'lblLineNumber
        '
        Me.lblLineNumber.AutoSize = True
        Me.lblLineNumber.Location = New System.Drawing.Point(10, 19)
        Me.lblLineNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLineNumber.Name = "lblLineNumber"
        Me.lblLineNumber.Size = New System.Drawing.Size(86, 16)
        Me.lblLineNumber.TabIndex = 30
        Me.lblLineNumber.Text = "Line Number:"
        '
        'lblRowNumber
        '
        Me.lblRowNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRowNumber.AutoSize = True
        Me.lblRowNumber.Location = New System.Drawing.Point(544, 19)
        Me.lblRowNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRowNumber.Name = "lblRowNumber"
        Me.lblRowNumber.Size = New System.Drawing.Size(88, 16)
        Me.lblRowNumber.TabIndex = 35
        Me.lblRowNumber.Text = "Row Number:"
        '
        'btnValidatePrevRow
        '
        Me.btnValidatePrevRow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnValidatePrevRow.Location = New System.Drawing.Point(52, 70)
        Me.btnValidatePrevRow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnValidatePrevRow.Name = "btnValidatePrevRow"
        Me.btnValidatePrevRow.Size = New System.Drawing.Size(120, 44)
        Me.btnValidatePrevRow.TabIndex = 44
        Me.btnValidatePrevRow.Text = "Validate Prev Row"
        Me.btnValidatePrevRow.UseVisualStyleBackColor = True
        '
        'btnValidateNextRow
        '
        Me.btnValidateNextRow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnValidateNextRow.Location = New System.Drawing.Point(296, 70)
        Me.btnValidateNextRow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnValidateNextRow.Name = "btnValidateNextRow"
        Me.btnValidateNextRow.Size = New System.Drawing.Size(120, 44)
        Me.btnValidateNextRow.TabIndex = 43
        Me.btnValidateNextRow.Text = "Validate Next Row"
        Me.btnValidateNextRow.UseVisualStyleBackColor = True
        '
        'btnCopyAndValidate
        '
        Me.btnCopyAndValidate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCopyAndValidate.Location = New System.Drawing.Point(174, 128)
        Me.btnCopyAndValidate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCopyAndValidate.Name = "btnCopyAndValidate"
        Me.btnCopyAndValidate.Size = New System.Drawing.Size(120, 44)
        Me.btnCopyAndValidate.TabIndex = 42
        Me.btnCopyAndValidate.Text = "Copy && Validate"
        Me.btnCopyAndValidate.UseVisualStyleBackColor = True
        '
        'btnNextRow
        '
        Me.btnNextRow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNextRow.Location = New System.Drawing.Point(419, 70)
        Me.btnNextRow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNextRow.Name = "btnNextRow"
        Me.btnNextRow.Size = New System.Drawing.Size(37, 102)
        Me.btnNextRow.TabIndex = 39
        Me.btnNextRow.Text = ">>"
        Me.btnNextRow.UseVisualStyleBackColor = True
        '
        'btnPrevRow
        '
        Me.btnPrevRow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrevRow.Location = New System.Drawing.Point(12, 70)
        Me.btnPrevRow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrevRow.Name = "btnPrevRow"
        Me.btnPrevRow.Size = New System.Drawing.Size(37, 102)
        Me.btnPrevRow.TabIndex = 40
        Me.btnPrevRow.Text = "<<"
        Me.btnPrevRow.UseVisualStyleBackColor = True
        '
        'btnValidatePrev
        '
        Me.btnValidatePrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnValidatePrev.Location = New System.Drawing.Point(52, 128)
        Me.btnValidatePrev.Margin = New System.Windows.Forms.Padding(2)
        Me.btnValidatePrev.Name = "btnValidatePrev"
        Me.btnValidatePrev.Size = New System.Drawing.Size(120, 44)
        Me.btnValidatePrev.TabIndex = 37
        Me.btnValidatePrev.Text = "Copy && Validate " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Prev Row"
        Me.btnValidatePrev.UseVisualStyleBackColor = True
        '
        'btnValidateNext
        '
        Me.btnValidateNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnValidateNext.Location = New System.Drawing.Point(296, 128)
        Me.btnValidateNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnValidateNext.Name = "btnValidateNext"
        Me.btnValidateNext.Size = New System.Drawing.Size(120, 44)
        Me.btnValidateNext.TabIndex = 36
        Me.btnValidateNext.Text = "Copy && Validate Next Row"
        Me.btnValidateNext.UseVisualStyleBackColor = True
        '
        'btnValidate
        '
        Me.btnValidate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnValidate.Location = New System.Drawing.Point(174, 70)
        Me.btnValidate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(120, 44)
        Me.btnValidate.TabIndex = 38
        Me.btnValidate.Text = "Validate"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'chkJumpEmptyRows
        '
        Me.chkJumpEmptyRows.AutoSize = True
        Me.chkJumpEmptyRows.Checked = True
        Me.chkJumpEmptyRows.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkJumpEmptyRows.Location = New System.Drawing.Point(398, 18)
        Me.chkJumpEmptyRows.Name = "chkJumpEmptyRows"
        Me.chkJumpEmptyRows.Size = New System.Drawing.Size(133, 20)
        Me.chkJumpEmptyRows.TabIndex = 45
        Me.chkJumpEmptyRows.Text = "Jump empty rows"
        Me.chkJumpEmptyRows.UseVisualStyleBackColor = True
        '
        'tablelayoutPanelMAIN
        '
        Me.tablelayoutPanelMAIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tablelayoutPanelMAIN.ColumnCount = 2
        Me.tablelayoutPanelMAIN.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelayoutPanelMAIN.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelayoutPanelMAIN.Controls.Add(Me.tablelayoutPanelToreador, 0, 3)
        Me.tablelayoutPanelMAIN.Controls.Add(Me.tablelayoutPanelNosferatu, 0, 2)
        Me.tablelayoutPanelMAIN.Controls.Add(Me.tablelayoutPanelMalkavian, 1, 2)
        Me.tablelayoutPanelMAIN.Controls.Add(Me.tablelayoutPanelVentrue, 1, 1)
        Me.tablelayoutPanelMAIN.Controls.Add(Me.tablelayoutPanelGangrel, 0, 1)
        Me.tablelayoutPanelMAIN.Controls.Add(Me.tablelayoutPanelTremere, 1, 0)
        Me.tablelayoutPanelMAIN.Controls.Add(Me.panelButtons, 1, 3)
        Me.tablelayoutPanelMAIN.Controls.Add(Me.tablelayoutPanelBrujah, 0, 0)
        Me.tablelayoutPanelMAIN.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tablelayoutPanelMAIN.Location = New System.Drawing.Point(2, 0)
        Me.tablelayoutPanelMAIN.Name = "tablelayoutPanelMAIN"
        Me.tablelayoutPanelMAIN.RowCount = 4
        Me.tablelayoutPanelMAIN.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablelayoutPanelMAIN.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablelayoutPanelMAIN.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablelayoutPanelMAIN.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablelayoutPanelMAIN.Size = New System.Drawing.Size(1433, 727)
        Me.tablelayoutPanelMAIN.TabIndex = 46
        '
        'tablelayoutPanelToreador
        '
        Me.tablelayoutPanelToreador.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tablelayoutPanelToreador.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.tablelayoutPanelToreador.ColumnCount = 1
        Me.tablelayoutPanelToreador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutPanelToreador.Controls.Add(Me.lblToreador, 0, 0)
        Me.tablelayoutPanelToreador.Controls.Add(Me.txtToreador, 0, 2)
        Me.tablelayoutPanelToreador.Controls.Add(Me.txtToreadorENG, 0, 1)
        Me.tablelayoutPanelToreador.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tablelayoutPanelToreador.Location = New System.Drawing.Point(0, 543)
        Me.tablelayoutPanelToreador.Margin = New System.Windows.Forms.Padding(0)
        Me.tablelayoutPanelToreador.Name = "tablelayoutPanelToreador"
        Me.tablelayoutPanelToreador.RowCount = 3
        Me.tablelayoutPanelToreador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.tablelayoutPanelToreador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelayoutPanelToreador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelayoutPanelToreador.Size = New System.Drawing.Size(716, 184)
        Me.tablelayoutPanelToreador.TabIndex = 24
        '
        'tablelayoutPanelNosferatu
        '
        Me.tablelayoutPanelNosferatu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tablelayoutPanelNosferatu.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.tablelayoutPanelNosferatu.ColumnCount = 1
        Me.tablelayoutPanelNosferatu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutPanelNosferatu.Controls.Add(Me.lblNosferatu, 0, 0)
        Me.tablelayoutPanelNosferatu.Controls.Add(Me.txtNosferatu, 0, 2)
        Me.tablelayoutPanelNosferatu.Controls.Add(Me.txtNosferatuENG, 0, 1)
        Me.tablelayoutPanelNosferatu.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tablelayoutPanelNosferatu.Location = New System.Drawing.Point(0, 362)
        Me.tablelayoutPanelNosferatu.Margin = New System.Windows.Forms.Padding(0)
        Me.tablelayoutPanelNosferatu.Name = "tablelayoutPanelNosferatu"
        Me.tablelayoutPanelNosferatu.RowCount = 3
        Me.tablelayoutPanelNosferatu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.tablelayoutPanelNosferatu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelayoutPanelNosferatu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelayoutPanelNosferatu.Size = New System.Drawing.Size(716, 181)
        Me.tablelayoutPanelNosferatu.TabIndex = 21
        '
        'tablelayoutPanelMalkavian
        '
        Me.tablelayoutPanelMalkavian.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tablelayoutPanelMalkavian.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.tablelayoutPanelMalkavian.ColumnCount = 1
        Me.tablelayoutPanelMalkavian.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutPanelMalkavian.Controls.Add(Me.lblMalkavian, 0, 0)
        Me.tablelayoutPanelMalkavian.Controls.Add(Me.txtMalkavian, 0, 2)
        Me.tablelayoutPanelMalkavian.Controls.Add(Me.txtMalkavianENG, 0, 1)
        Me.tablelayoutPanelMalkavian.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tablelayoutPanelMalkavian.Location = New System.Drawing.Point(716, 362)
        Me.tablelayoutPanelMalkavian.Margin = New System.Windows.Forms.Padding(0)
        Me.tablelayoutPanelMalkavian.Name = "tablelayoutPanelMalkavian"
        Me.tablelayoutPanelMalkavian.RowCount = 3
        Me.tablelayoutPanelMalkavian.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.tablelayoutPanelMalkavian.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelayoutPanelMalkavian.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelayoutPanelMalkavian.Size = New System.Drawing.Size(717, 181)
        Me.tablelayoutPanelMalkavian.TabIndex = 30
        '
        'tablelayoutPanelVentrue
        '
        Me.tablelayoutPanelVentrue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tablelayoutPanelVentrue.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.tablelayoutPanelVentrue.ColumnCount = 1
        Me.tablelayoutPanelVentrue.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutPanelVentrue.Controls.Add(Me.lblVentrue, 0, 0)
        Me.tablelayoutPanelVentrue.Controls.Add(Me.txtVentrue, 0, 2)
        Me.tablelayoutPanelVentrue.Controls.Add(Me.txtVentrueENG, 0, 1)
        Me.tablelayoutPanelVentrue.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tablelayoutPanelVentrue.Location = New System.Drawing.Point(716, 181)
        Me.tablelayoutPanelVentrue.Margin = New System.Windows.Forms.Padding(0)
        Me.tablelayoutPanelVentrue.Name = "tablelayoutPanelVentrue"
        Me.tablelayoutPanelVentrue.RowCount = 3
        Me.tablelayoutPanelVentrue.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.tablelayoutPanelVentrue.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelayoutPanelVentrue.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelayoutPanelVentrue.Size = New System.Drawing.Size(717, 181)
        Me.tablelayoutPanelVentrue.TabIndex = 27
        '
        'tablelayoutPanelGangrel
        '
        Me.tablelayoutPanelGangrel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tablelayoutPanelGangrel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.tablelayoutPanelGangrel.ColumnCount = 1
        Me.tablelayoutPanelGangrel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutPanelGangrel.Controls.Add(Me.lblGangrel, 0, 0)
        Me.tablelayoutPanelGangrel.Controls.Add(Me.txtGangrel, 0, 2)
        Me.tablelayoutPanelGangrel.Controls.Add(Me.txtGangrelENG, 0, 1)
        Me.tablelayoutPanelGangrel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tablelayoutPanelGangrel.Location = New System.Drawing.Point(0, 181)
        Me.tablelayoutPanelGangrel.Margin = New System.Windows.Forms.Padding(0)
        Me.tablelayoutPanelGangrel.Name = "tablelayoutPanelGangrel"
        Me.tablelayoutPanelGangrel.RowCount = 3
        Me.tablelayoutPanelGangrel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.tablelayoutPanelGangrel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelayoutPanelGangrel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelayoutPanelGangrel.Size = New System.Drawing.Size(716, 181)
        Me.tablelayoutPanelGangrel.TabIndex = 16
        '
        'lblGangrel
        '
        Me.lblGangrel.AutoSize = True
        Me.lblGangrel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblGangrel.Location = New System.Drawing.Point(4, 2)
        Me.lblGangrel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGangrel.Name = "lblGangrel"
        Me.lblGangrel.Size = New System.Drawing.Size(99, 16)
        Me.lblGangrel.TabIndex = 13
        Me.lblGangrel.Text = "Gangrel Line:"
        '
        'txtGangrel
        '
        Me.txtGangrel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGangrel.BackColor = System.Drawing.SystemColors.Control
        Me.txtGangrel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGangrel.Location = New System.Drawing.Point(2, 100)
        Me.txtGangrel.Margin = New System.Windows.Forms.Padding(0)
        Me.txtGangrel.Multiline = True
        Me.txtGangrel.Name = "txtGangrel"
        Me.txtGangrel.ReadOnly = True
        Me.txtGangrel.Size = New System.Drawing.Size(712, 79)
        Me.txtGangrel.TabIndex = 15
        '
        'txtGangrelENG
        '
        Me.txtGangrelENG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGangrelENG.BackColor = System.Drawing.SystemColors.Window
        Me.txtGangrelENG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGangrelENG.Location = New System.Drawing.Point(2, 20)
        Me.txtGangrelENG.Margin = New System.Windows.Forms.Padding(0)
        Me.txtGangrelENG.Multiline = True
        Me.txtGangrelENG.Name = "txtGangrelENG"
        Me.txtGangrelENG.Size = New System.Drawing.Size(712, 78)
        Me.txtGangrelENG.TabIndex = 14
        '
        'tablelayoutPanelTremere
        '
        Me.tablelayoutPanelTremere.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tablelayoutPanelTremere.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.tablelayoutPanelTremere.ColumnCount = 1
        Me.tablelayoutPanelTremere.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutPanelTremere.Controls.Add(Me.lblTremere, 0, 0)
        Me.tablelayoutPanelTremere.Controls.Add(Me.txtTremere, 0, 2)
        Me.tablelayoutPanelTremere.Controls.Add(Me.txtTremereENG, 0, 1)
        Me.tablelayoutPanelTremere.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tablelayoutPanelTremere.Location = New System.Drawing.Point(716, 0)
        Me.tablelayoutPanelTremere.Margin = New System.Windows.Forms.Padding(0)
        Me.tablelayoutPanelTremere.Name = "tablelayoutPanelTremere"
        Me.tablelayoutPanelTremere.RowCount = 3
        Me.tablelayoutPanelTremere.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.tablelayoutPanelTremere.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelayoutPanelTremere.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelayoutPanelTremere.Size = New System.Drawing.Size(717, 181)
        Me.tablelayoutPanelTremere.TabIndex = 18
        '
        'panelButtons
        '
        Me.panelButtons.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelButtons.Controls.Add(Me.btnUndo)
        Me.panelButtons.Controls.Add(Me.btnTranslateVDeepL)
        Me.panelButtons.Controls.Add(Me.btnTranslateMDeepL)
        Me.panelButtons.Controls.Add(Me.lblLineNumber)
        Me.panelButtons.Controls.Add(Me.chkJumpEmptyRows)
        Me.panelButtons.Controls.Add(Me.btnClose)
        Me.panelButtons.Controls.Add(Me.btnValidatePrevRow)
        Me.panelButtons.Controls.Add(Me.txt_lnumENG)
        Me.panelButtons.Controls.Add(Me.btnValidateNextRow)
        Me.panelButtons.Controls.Add(Me.txt_lnum)
        Me.panelButtons.Controls.Add(Me.btnCopyAndValidate)
        Me.panelButtons.Controls.Add(Me.txt_rownum)
        Me.panelButtons.Controls.Add(Me.btnNextRow)
        Me.panelButtons.Controls.Add(Me.cbCAL)
        Me.panelButtons.Controls.Add(Me.btnPrevRow)
        Me.panelButtons.Controls.Add(Me.lblRowNumber)
        Me.panelButtons.Controls.Add(Me.btnValidatePrev)
        Me.panelButtons.Controls.Add(Me.btnValidate)
        Me.panelButtons.Controls.Add(Me.btnValidateNext)
        Me.panelButtons.Location = New System.Drawing.Point(716, 543)
        Me.panelButtons.Margin = New System.Windows.Forms.Padding(0)
        Me.panelButtons.Name = "panelButtons"
        Me.panelButtons.Size = New System.Drawing.Size(717, 184)
        Me.panelButtons.TabIndex = 7
        '
        'btnUndo
        '
        Me.btnUndo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUndo.BackgroundImage = Global.VtMBTranslator.My.Resources.Resources.undo
        Me.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUndo.Location = New System.Drawing.Point(483, 129)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(44, 44)
        Me.btnUndo.TabIndex = 48
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'btnTranslateVDeepL
        '
        Me.btnTranslateVDeepL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTranslateVDeepL.BackgroundImage = Global.VtMBTranslator.My.Resources.Resources.deeplV
        Me.btnTranslateVDeepL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTranslateVDeepL.Location = New System.Drawing.Point(609, 70)
        Me.btnTranslateVDeepL.Name = "btnTranslateVDeepL"
        Me.btnTranslateVDeepL.Size = New System.Drawing.Size(44, 44)
        Me.btnTranslateVDeepL.TabIndex = 47
        Me.btnTranslateVDeepL.UseVisualStyleBackColor = True
        '
        'btnTranslateMDeepL
        '
        Me.btnTranslateMDeepL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTranslateMDeepL.BackgroundImage = Global.VtMBTranslator.My.Resources.Resources.deeplM
        Me.btnTranslateMDeepL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTranslateMDeepL.Location = New System.Drawing.Point(659, 70)
        Me.btnTranslateMDeepL.Name = "btnTranslateMDeepL"
        Me.btnTranslateMDeepL.Size = New System.Drawing.Size(44, 44)
        Me.btnTranslateMDeepL.TabIndex = 46
        Me.btnTranslateMDeepL.UseVisualStyleBackColor = True
        '
        'tablelayoutPanelBrujah
        '
        Me.tablelayoutPanelBrujah.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tablelayoutPanelBrujah.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.tablelayoutPanelBrujah.ColumnCount = 1
        Me.tablelayoutPanelBrujah.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutPanelBrujah.Controls.Add(Me.lblBrujah, 0, 0)
        Me.tablelayoutPanelBrujah.Controls.Add(Me.txtBrujah, 0, 2)
        Me.tablelayoutPanelBrujah.Controls.Add(Me.txtBrujahENG, 0, 1)
        Me.tablelayoutPanelBrujah.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tablelayoutPanelBrujah.Location = New System.Drawing.Point(0, 0)
        Me.tablelayoutPanelBrujah.Margin = New System.Windows.Forms.Padding(0)
        Me.tablelayoutPanelBrujah.Name = "tablelayoutPanelBrujah"
        Me.tablelayoutPanelBrujah.RowCount = 3
        Me.tablelayoutPanelBrujah.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.tablelayoutPanelBrujah.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelayoutPanelBrujah.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelayoutPanelBrujah.Size = New System.Drawing.Size(716, 181)
        Me.tablelayoutPanelBrujah.TabIndex = 13
        '
        'lblBrujah
        '
        Me.lblBrujah.AutoSize = True
        Me.lblBrujah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblBrujah.Location = New System.Drawing.Point(4, 2)
        Me.lblBrujah.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBrujah.Name = "lblBrujah"
        Me.lblBrujah.Size = New System.Drawing.Size(88, 16)
        Me.lblBrujah.TabIndex = 1
        Me.lblBrujah.Text = "Brujah Line:"
        '
        'txtBrujah
        '
        Me.txtBrujah.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBrujah.BackColor = System.Drawing.SystemColors.Control
        Me.txtBrujah.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrujah.Location = New System.Drawing.Point(2, 100)
        Me.txtBrujah.Margin = New System.Windows.Forms.Padding(0)
        Me.txtBrujah.Multiline = True
        Me.txtBrujah.Name = "txtBrujah"
        Me.txtBrujah.ReadOnly = True
        Me.txtBrujah.Size = New System.Drawing.Size(712, 79)
        Me.txtBrujah.TabIndex = 12
        '
        'txtBrujahENG
        '
        Me.txtBrujahENG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBrujahENG.BackColor = System.Drawing.SystemColors.Window
        Me.txtBrujahENG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrujahENG.Location = New System.Drawing.Point(2, 20)
        Me.txtBrujahENG.Margin = New System.Windows.Forms.Padding(0)
        Me.txtBrujahENG.Multiline = True
        Me.txtBrujahENG.Name = "txtBrujahENG"
        Me.txtBrujahENG.Size = New System.Drawing.Size(712, 78)
        Me.txtBrujahENG.TabIndex = 10
        '
        'frmClansData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1438, 729)
        Me.Controls.Add(Me.tablelayoutPanelMAIN)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1456, 771)
        Me.Name = "frmClansData"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clans Data"
        Me.TransparencyKey = System.Drawing.Color.MediumSpringGreen
        Me.tablelayoutPanelMAIN.ResumeLayout(False)
        Me.tablelayoutPanelToreador.ResumeLayout(False)
        Me.tablelayoutPanelToreador.PerformLayout()
        Me.tablelayoutPanelNosferatu.ResumeLayout(False)
        Me.tablelayoutPanelNosferatu.PerformLayout()
        Me.tablelayoutPanelMalkavian.ResumeLayout(False)
        Me.tablelayoutPanelMalkavian.PerformLayout()
        Me.tablelayoutPanelVentrue.ResumeLayout(False)
        Me.tablelayoutPanelVentrue.PerformLayout()
        Me.tablelayoutPanelGangrel.ResumeLayout(False)
        Me.tablelayoutPanelGangrel.PerformLayout()
        Me.tablelayoutPanelTremere.ResumeLayout(False)
        Me.tablelayoutPanelTremere.PerformLayout()
        Me.panelButtons.ResumeLayout(False)
        Me.panelButtons.PerformLayout()
        Me.tablelayoutPanelBrujah.ResumeLayout(False)
        Me.tablelayoutPanelBrujah.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents lblTremere As Label
    Friend WithEvents txtTremere As TextBox
    Friend WithEvents txtTremereENG As TextBox
    Friend WithEvents lblNosferatu As Label
    Friend WithEvents txtNosferatu As TextBox
    Friend WithEvents txtNosferatuENG As TextBox
    Friend WithEvents lblToreador As Label
    Friend WithEvents txtToreador As TextBox
    Friend WithEvents txtToreadorENG As TextBox
    Friend WithEvents txtVentrue As TextBox
    Friend WithEvents txtVentrueENG As TextBox
    Friend WithEvents lblVentrue As Label
    Friend WithEvents txtMalkavian As TextBox
    Friend WithEvents txtMalkavianENG As TextBox
    Friend WithEvents lblMalkavian As Label
    Friend WithEvents cbCAL As CheckBox
    Friend WithEvents txt_rownum As TextBox
    Friend WithEvents txt_lnum As TextBox
    Friend WithEvents txt_lnumENG As TextBox
    Friend WithEvents lblLineNumber As Label
    Friend WithEvents lblRowNumber As Label
    Friend WithEvents btnValidatePrevRow As Button
    Friend WithEvents btnValidateNextRow As Button
    Friend WithEvents btnCopyAndValidate As Button
    Friend WithEvents btnNextRow As Button
    Friend WithEvents btnPrevRow As Button
    Friend WithEvents btnValidatePrev As Button
    Friend WithEvents btnValidateNext As Button
    Friend WithEvents btnValidate As Button
    Friend WithEvents chkJumpEmptyRows As CheckBox
    Friend WithEvents tablelayoutPanelMAIN As TableLayoutPanel
    Friend WithEvents panelButtons As Panel
    Friend WithEvents tablelayoutPanelBrujah As TableLayoutPanel
    Friend WithEvents lblBrujah As Label
    Friend WithEvents txtBrujah As TextBox
    Friend WithEvents txtBrujahENG As TextBox
    Friend WithEvents tablelayoutPanelTremere As TableLayoutPanel
    Friend WithEvents tablelayoutPanelGangrel As TableLayoutPanel
    Friend WithEvents lblGangrel As Label
    Friend WithEvents txtGangrel As TextBox
    Friend WithEvents txtGangrelENG As TextBox
    Friend WithEvents tablelayoutPanelNosferatu As TableLayoutPanel
    Friend WithEvents tablelayoutPanelToreador As TableLayoutPanel
    Friend WithEvents tablelayoutPanelVentrue As TableLayoutPanel
    Friend WithEvents tablelayoutPanelMalkavian As TableLayoutPanel
    Friend WithEvents btnTranslateMDeepL As Button
    Friend WithEvents btnTranslateVDeepL As Button
    Friend WithEvents btnUndo As Button
End Class
