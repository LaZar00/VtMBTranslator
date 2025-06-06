<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVtMBTranslator
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmsdgvDLG1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiGTCL = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiFS = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiFSE = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtDLG1 = New System.Windows.Forms.TextBox()
        Me.btnLoadDLG1 = New System.Windows.Forms.Button()
        Me.loadDLG = New System.Windows.Forms.OpenFileDialog()
        Me.btnLoadDLG2 = New System.Windows.Forms.Button()
        Me.txtDLG2 = New System.Windows.Forms.TextBox()
        Me.dgvDLG2 = New System.Windows.Forms.DataGridView()
        Me.cNum2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMale2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cFemale2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cJump2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCondition2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cExePy2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cBrujah2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cGangrel2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNosferatu2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cToreador2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTremere2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cVentrue2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMalkavian2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEditClans = New System.Windows.Forms.Button()
        Me.btnCompEveryone = New System.Windows.Forms.Button()
        Me.txtReport = New System.Windows.Forms.TextBox()
        Me.btnOPENTE = New System.Windows.Forms.Button()
        Me.btnRefresh1 = New System.Windows.Forms.Button()
        Me.btnRefresh2 = New System.Windows.Forms.Button()
        Me.lbSections = New System.Windows.Forms.Label()
        Me.txtSections = New System.Windows.Forms.TextBox()
        Me.lbLineCounter = New System.Windows.Forms.Label()
        Me.txtLoadingLine = New System.Windows.Forms.TextBox()
        Me.btnEditEveryone = New System.Windows.Forms.Button()
        Me.btnSaveAsDLG1 = New System.Windows.Forms.Button()
        Me.saveDLG = New System.Windows.Forms.SaveFileDialog()
        Me.btnSaveDLG1 = New System.Windows.Forms.Button()
        Me.btnGTCL = New System.Windows.Forms.Button()
        Me.btnFS = New System.Windows.Forms.Button()
        Me.btnCompClans = New System.Windows.Forms.Button()
        Me.panelLOWER = New System.Windows.Forms.Panel()
        Me.lbEncoding = New System.Windows.Forms.Label()
        Me.cbEncoding = New System.Windows.Forms.ComboBox()
        Me.btnIndividualLipsEditor = New System.Windows.Forms.Button()
        Me.btnUpdateLips = New System.Windows.Forms.Button()
        Me.splcontDGV = New System.Windows.Forms.SplitContainer()
        Me.dgvDLG1 = New System.Windows.Forms.DataGridView()
        Me.cNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cFemale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cJump = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCondition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cExecPy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cBrujah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cGangrel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNosferatu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cToreador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTremere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cVentrue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMalkavian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelUP = New System.Windows.Forms.Panel()
        Me.btnDGV2Clear = New System.Windows.Forms.Button()
        Me.cmsdgvDLG1.SuspendLayout()
        CType(Me.dgvDLG2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLOWER.SuspendLayout()
        CType(Me.splcontDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splcontDGV.Panel1.SuspendLayout()
        Me.splcontDGV.Panel2.SuspendLayout()
        Me.splcontDGV.SuspendLayout()
        CType(Me.dgvDLG1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelUP.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmsdgvDLG1
        '
        Me.cmsdgvDLG1.Enabled = False
        Me.cmsdgvDLG1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsdgvDLG1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiCopy, Me.tsmiGTCL, Me.tsmiFS, Me.tsmiFSE})
        Me.cmsdgvDLG1.Name = "cmsdgvDLG1"
        Me.cmsdgvDLG1.Size = New System.Drawing.Size(255, 100)
        Me.cmsdgvDLG1.Text = "Copy (CTRL + C)"
        '
        'tsmiCopy
        '
        Me.tsmiCopy.Enabled = False
        Me.tsmiCopy.Name = "tsmiCopy"
        Me.tsmiCopy.Size = New System.Drawing.Size(254, 24)
        Me.tsmiCopy.Text = "Copy (CTRL+C)"
        '
        'tsmiGTCL
        '
        Me.tsmiGTCL.Enabled = False
        Me.tsmiGTCL.Name = "tsmiGTCL"
        Me.tsmiGTCL.Size = New System.Drawing.Size(254, 24)
        Me.tsmiGTCL.Text = "Go To Code Line (CTRL+G)"
        '
        'tsmiFS
        '
        Me.tsmiFS.Enabled = False
        Me.tsmiFS.Name = "tsmiFS"
        Me.tsmiFS.Size = New System.Drawing.Size(254, 24)
        Me.tsmiFS.Text = "Find String (CTRL+F)"
        '
        'tsmiFSE
        '
        Me.tsmiFSE.Enabled = False
        Me.tsmiFSE.Name = "tsmiFSE"
        Me.tsmiFSE.Size = New System.Drawing.Size(254, 24)
        Me.tsmiFSE.Text = "Find Next String (F3)"
        '
        'txtDLG1
        '
        Me.txtDLG1.Location = New System.Drawing.Point(10, 9)
        Me.txtDLG1.Name = "txtDLG1"
        Me.txtDLG1.ReadOnly = True
        Me.txtDLG1.Size = New System.Drawing.Size(516, 22)
        Me.txtDLG1.TabIndex = 1
        '
        'btnLoadDLG1
        '
        Me.btnLoadDLG1.Location = New System.Drawing.Point(530, 4)
        Me.btnLoadDLG1.Name = "btnLoadDLG1"
        Me.btnLoadDLG1.Size = New System.Drawing.Size(126, 34)
        Me.btnLoadDLG1.TabIndex = 2
        Me.btnLoadDLG1.Text = "Load Primary"
        Me.btnLoadDLG1.UseVisualStyleBackColor = True
        '
        'btnLoadDLG2
        '
        Me.btnLoadDLG2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLoadDLG2.Enabled = False
        Me.btnLoadDLG2.Location = New System.Drawing.Point(1288, 4)
        Me.btnLoadDLG2.Name = "btnLoadDLG2"
        Me.btnLoadDLG2.Size = New System.Drawing.Size(126, 34)
        Me.btnLoadDLG2.TabIndex = 5
        Me.btnLoadDLG2.Text = "Load Secondary"
        Me.btnLoadDLG2.UseVisualStyleBackColor = True
        '
        'txtDLG2
        '
        Me.txtDLG2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDLG2.Location = New System.Drawing.Point(768, 10)
        Me.txtDLG2.Name = "txtDLG2"
        Me.txtDLG2.ReadOnly = True
        Me.txtDLG2.Size = New System.Drawing.Size(516, 22)
        Me.txtDLG2.TabIndex = 4
        '
        'dgvDLG2
        '
        Me.dgvDLG2.AllowUserToAddRows = False
        Me.dgvDLG2.AllowUserToDeleteRows = False
        Me.dgvDLG2.AllowUserToResizeRows = False
        Me.dgvDLG2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvDLG2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvDLG2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvDLG2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDLG2.ColumnHeadersHeight = 29
        Me.dgvDLG2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDLG2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cNum2, Me.cMale2, Me.cFemale2, Me.cJump2, Me.cCondition2, Me.cExePy2, Me.cBrujah2, Me.cGangrel2, Me.cNosferatu2, Me.cToreador2, Me.cTremere2, Me.cVentrue2, Me.cMalkavian2})
        Me.dgvDLG2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDLG2.Location = New System.Drawing.Point(0, 0)
        Me.dgvDLG2.MultiSelect = False
        Me.dgvDLG2.Name = "dgvDLG2"
        Me.dgvDLG2.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvDLG2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDLG2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvDLG2.RowTemplate.Height = 24
        Me.dgvDLG2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDLG2.Size = New System.Drawing.Size(734, 541)
        Me.dgvDLG2.TabIndex = 3
        '
        'cNum2
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.NullValue = Nothing
        Me.cNum2.DefaultCellStyle = DataGridViewCellStyle2
        Me.cNum2.Frozen = True
        Me.cNum2.HeaderText = "Num"
        Me.cNum2.MinimumWidth = 6
        Me.cNum2.Name = "cNum2"
        Me.cNum2.ReadOnly = True
        Me.cNum2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cNum2.Width = 60
        '
        'cMale2
        '
        Me.cMale2.HeaderText = "Male"
        Me.cMale2.MinimumWidth = 6
        Me.cMale2.Name = "cMale2"
        Me.cMale2.ReadOnly = True
        Me.cMale2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cMale2.Width = 88
        '
        'cFemale2
        '
        Me.cFemale2.HeaderText = "Female"
        Me.cFemale2.MinimumWidth = 6
        Me.cFemale2.Name = "cFemale2"
        Me.cFemale2.ReadOnly = True
        Me.cFemale2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cFemale2.Width = 88
        '
        'cJump2
        '
        Me.cJump2.HeaderText = "Jump"
        Me.cJump2.MinimumWidth = 6
        Me.cJump2.Name = "cJump2"
        Me.cJump2.ReadOnly = True
        Me.cJump2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cJump2.Width = 88
        '
        'cCondition2
        '
        Me.cCondition2.HeaderText = "Condition"
        Me.cCondition2.MinimumWidth = 6
        Me.cCondition2.Name = "cCondition2"
        Me.cCondition2.ReadOnly = True
        Me.cCondition2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cCondition2.Width = 88
        '
        'cExePy2
        '
        Me.cExePy2.HeaderText = "ExecPy"
        Me.cExePy2.MinimumWidth = 6
        Me.cExePy2.Name = "cExePy2"
        Me.cExePy2.ReadOnly = True
        Me.cExePy2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cExePy2.Width = 88
        '
        'cBrujah2
        '
        Me.cBrujah2.HeaderText = "Brujah"
        Me.cBrujah2.MinimumWidth = 6
        Me.cBrujah2.Name = "cBrujah2"
        Me.cBrujah2.ReadOnly = True
        Me.cBrujah2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cBrujah2.Width = 88
        '
        'cGangrel2
        '
        Me.cGangrel2.HeaderText = "Gangrel"
        Me.cGangrel2.MinimumWidth = 6
        Me.cGangrel2.Name = "cGangrel2"
        Me.cGangrel2.ReadOnly = True
        Me.cGangrel2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cGangrel2.Width = 88
        '
        'cNosferatu2
        '
        Me.cNosferatu2.HeaderText = "Nosferatu"
        Me.cNosferatu2.MinimumWidth = 6
        Me.cNosferatu2.Name = "cNosferatu2"
        Me.cNosferatu2.ReadOnly = True
        Me.cNosferatu2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cNosferatu2.Width = 88
        '
        'cToreador2
        '
        Me.cToreador2.HeaderText = "Toreador"
        Me.cToreador2.MinimumWidth = 6
        Me.cToreador2.Name = "cToreador2"
        Me.cToreador2.ReadOnly = True
        Me.cToreador2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cToreador2.Width = 88
        '
        'cTremere2
        '
        Me.cTremere2.HeaderText = "Tremere"
        Me.cTremere2.MinimumWidth = 6
        Me.cTremere2.Name = "cTremere2"
        Me.cTremere2.ReadOnly = True
        Me.cTremere2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cTremere2.Width = 88
        '
        'cVentrue2
        '
        Me.cVentrue2.HeaderText = "Ventrue"
        Me.cVentrue2.MinimumWidth = 6
        Me.cVentrue2.Name = "cVentrue2"
        Me.cVentrue2.ReadOnly = True
        Me.cVentrue2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cVentrue2.Width = 88
        '
        'cMalkavian2
        '
        Me.cMalkavian2.HeaderText = "Malkavian"
        Me.cMalkavian2.MinimumWidth = 6
        Me.cMalkavian2.Name = "cMalkavian2"
        Me.cMalkavian2.ReadOnly = True
        Me.cMalkavian2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cMalkavian2.Width = 88
        '
        'btnEditClans
        '
        Me.btnEditClans.Enabled = False
        Me.btnEditClans.Location = New System.Drawing.Point(324, 7)
        Me.btnEditClans.Name = "btnEditClans"
        Me.btnEditClans.Size = New System.Drawing.Size(135, 52)
        Me.btnEditClans.TabIndex = 9
        Me.btnEditClans.Text = "Edit Clans"
        Me.btnEditClans.UseVisualStyleBackColor = True
        '
        'btnCompEveryone
        '
        Me.btnCompEveryone.Enabled = False
        Me.btnCompEveryone.Location = New System.Drawing.Point(465, 7)
        Me.btnCompEveryone.Name = "btnCompEveryone"
        Me.btnCompEveryone.Size = New System.Drawing.Size(135, 52)
        Me.btnCompEveryone.TabIndex = 10
        Me.btnCompEveryone.Text = "Compare Everyone"
        Me.btnCompEveryone.UseVisualStyleBackColor = True
        '
        'txtReport
        '
        Me.txtReport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReport.Location = New System.Drawing.Point(12, 65)
        Me.txtReport.Multiline = True
        Me.txtReport.Name = "txtReport"
        Me.txtReport.ReadOnly = True
        Me.txtReport.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtReport.Size = New System.Drawing.Size(1471, 125)
        Me.txtReport.TabIndex = 12
        Me.txtReport.WordWrap = False
        '
        'btnOPENTE
        '
        Me.btnOPENTE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOPENTE.Enabled = False
        Me.btnOPENTE.Location = New System.Drawing.Point(1172, 7)
        Me.btnOPENTE.Name = "btnOPENTE"
        Me.btnOPENTE.Size = New System.Drawing.Size(91, 52)
        Me.btnOPENTE.TabIndex = 13
        Me.btnOPENTE.Text = "Open in Text Editor"
        Me.btnOPENTE.UseVisualStyleBackColor = True
        '
        'btnRefresh1
        '
        Me.btnRefresh1.BackgroundImage = Global.VtMBTranslator.My.Resources.Resources.refresh
        Me.btnRefresh1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh1.Location = New System.Drawing.Point(656, 4)
        Me.btnRefresh1.Name = "btnRefresh1"
        Me.btnRefresh1.Size = New System.Drawing.Size(34, 34)
        Me.btnRefresh1.TabIndex = 14
        Me.btnRefresh1.UseVisualStyleBackColor = True
        '
        'btnRefresh2
        '
        Me.btnRefresh2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh2.BackgroundImage = Global.VtMBTranslator.My.Resources.Resources.refresh
        Me.btnRefresh2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh2.Location = New System.Drawing.Point(1414, 4)
        Me.btnRefresh2.Name = "btnRefresh2"
        Me.btnRefresh2.Size = New System.Drawing.Size(34, 34)
        Me.btnRefresh2.TabIndex = 15
        Me.btnRefresh2.UseVisualStyleBackColor = True
        '
        'lbSections
        '
        Me.lbSections.AutoSize = True
        Me.lbSections.Location = New System.Drawing.Point(39, 10)
        Me.lbSections.Name = "lbSections"
        Me.lbSections.Size = New System.Drawing.Size(62, 16)
        Me.lbSections.TabIndex = 16
        Me.lbSections.Text = "Sections:"
        '
        'txtSections
        '
        Me.txtSections.Location = New System.Drawing.Point(105, 7)
        Me.txtSections.Name = "txtSections"
        Me.txtSections.ReadOnly = True
        Me.txtSections.Size = New System.Drawing.Size(56, 22)
        Me.txtSections.TabIndex = 17
        Me.txtSections.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbLineCounter
        '
        Me.lbLineCounter.AutoSize = True
        Me.lbLineCounter.Location = New System.Drawing.Point(12, 37)
        Me.lbLineCounter.Name = "lbLineCounter"
        Me.lbLineCounter.Size = New System.Drawing.Size(88, 16)
        Me.lbLineCounter.TabIndex = 18
        Me.lbLineCounter.Text = "Loaded lines:"
        '
        'txtLoadingLine
        '
        Me.txtLoadingLine.Location = New System.Drawing.Point(105, 34)
        Me.txtLoadingLine.Name = "txtLoadingLine"
        Me.txtLoadingLine.ReadOnly = True
        Me.txtLoadingLine.Size = New System.Drawing.Size(56, 22)
        Me.txtLoadingLine.TabIndex = 19
        Me.txtLoadingLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEditEveryone
        '
        Me.btnEditEveryone.Enabled = False
        Me.btnEditEveryone.Location = New System.Drawing.Point(183, 7)
        Me.btnEditEveryone.Name = "btnEditEveryone"
        Me.btnEditEveryone.Size = New System.Drawing.Size(135, 52)
        Me.btnEditEveryone.TabIndex = 20
        Me.btnEditEveryone.Text = "Edit Everyone"
        Me.btnEditEveryone.UseVisualStyleBackColor = True
        '
        'btnSaveAsDLG1
        '
        Me.btnSaveAsDLG1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveAsDLG1.Enabled = False
        Me.btnSaveAsDLG1.Location = New System.Drawing.Point(1065, 7)
        Me.btnSaveAsDLG1.Name = "btnSaveAsDLG1"
        Me.btnSaveAsDLG1.Size = New System.Drawing.Size(105, 52)
        Me.btnSaveAsDLG1.TabIndex = 21
        Me.btnSaveAsDLG1.Text = "Save As..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Primary DLG"
        Me.btnSaveAsDLG1.UseVisualStyleBackColor = True
        '
        'btnSaveDLG1
        '
        Me.btnSaveDLG1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveDLG1.Enabled = False
        Me.btnSaveDLG1.Location = New System.Drawing.Point(945, 7)
        Me.btnSaveDLG1.Name = "btnSaveDLG1"
        Me.btnSaveDLG1.Size = New System.Drawing.Size(118, 52)
        Me.btnSaveDLG1.TabIndex = 22
        Me.btnSaveDLG1.Text = "Save Primary" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DLG (CTRL+S)"
        Me.btnSaveDLG1.UseVisualStyleBackColor = True
        '
        'btnGTCL
        '
        Me.btnGTCL.Enabled = False
        Me.btnGTCL.Location = New System.Drawing.Point(749, 7)
        Me.btnGTCL.Name = "btnGTCL"
        Me.btnGTCL.Size = New System.Drawing.Size(87, 25)
        Me.btnGTCL.TabIndex = 24
        Me.btnGTCL.Text = "Go to line"
        Me.btnGTCL.UseVisualStyleBackColor = True
        '
        'btnFS
        '
        Me.btnFS.Enabled = False
        Me.btnFS.Location = New System.Drawing.Point(749, 33)
        Me.btnFS.Name = "btnFS"
        Me.btnFS.Size = New System.Drawing.Size(87, 26)
        Me.btnFS.TabIndex = 25
        Me.btnFS.Text = "Find string"
        Me.btnFS.UseVisualStyleBackColor = True
        '
        'btnCompClans
        '
        Me.btnCompClans.Enabled = False
        Me.btnCompClans.Location = New System.Drawing.Point(606, 7)
        Me.btnCompClans.Name = "btnCompClans"
        Me.btnCompClans.Size = New System.Drawing.Size(135, 52)
        Me.btnCompClans.TabIndex = 26
        Me.btnCompClans.Text = "Compare Clans"
        Me.btnCompClans.UseVisualStyleBackColor = True
        '
        'panelLOWER
        '
        Me.panelLOWER.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelLOWER.AutoSize = True
        Me.panelLOWER.Controls.Add(Me.lbEncoding)
        Me.panelLOWER.Controls.Add(Me.cbEncoding)
        Me.panelLOWER.Controls.Add(Me.btnIndividualLipsEditor)
        Me.panelLOWER.Controls.Add(Me.btnUpdateLips)
        Me.panelLOWER.Controls.Add(Me.btnCompClans)
        Me.panelLOWER.Controls.Add(Me.btnFS)
        Me.panelLOWER.Controls.Add(Me.btnGTCL)
        Me.panelLOWER.Controls.Add(Me.btnSaveDLG1)
        Me.panelLOWER.Controls.Add(Me.btnSaveAsDLG1)
        Me.panelLOWER.Controls.Add(Me.btnEditEveryone)
        Me.panelLOWER.Controls.Add(Me.txtLoadingLine)
        Me.panelLOWER.Controls.Add(Me.lbLineCounter)
        Me.panelLOWER.Controls.Add(Me.txtSections)
        Me.panelLOWER.Controls.Add(Me.lbSections)
        Me.panelLOWER.Controls.Add(Me.btnOPENTE)
        Me.panelLOWER.Controls.Add(Me.txtReport)
        Me.panelLOWER.Controls.Add(Me.btnCompEveryone)
        Me.panelLOWER.Controls.Add(Me.btnEditClans)
        Me.panelLOWER.Location = New System.Drawing.Point(1, 596)
        Me.panelLOWER.Name = "panelLOWER"
        Me.panelLOWER.Size = New System.Drawing.Size(1497, 198)
        Me.panelLOWER.TabIndex = 27
        '
        'lbEncoding
        '
        Me.lbEncoding.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbEncoding.AutoSize = True
        Me.lbEncoding.Location = New System.Drawing.Point(1267, 11)
        Me.lbEncoding.Name = "lbEncoding"
        Me.lbEncoding.Size = New System.Drawing.Size(67, 16)
        Me.lbEncoding.TabIndex = 31
        Me.lbEncoding.Text = "Encoding:"
        '
        'cbEncoding
        '
        Me.cbEncoding.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbEncoding.CausesValidation = False
        Me.cbEncoding.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbEncoding.FormattingEnabled = True
        Me.cbEncoding.Items.AddRange(New Object() {"Char", "Unicode"})
        Me.cbEncoding.Location = New System.Drawing.Point(1268, 32)
        Me.cbEncoding.Name = "cbEncoding"
        Me.cbEncoding.Size = New System.Drawing.Size(105, 24)
        Me.cbEncoding.TabIndex = 30
        Me.cbEncoding.Text = "Char"
        '
        'btnIndividualLipsEditor
        '
        Me.btnIndividualLipsEditor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIndividualLipsEditor.Location = New System.Drawing.Point(1379, 7)
        Me.btnIndividualLipsEditor.Name = "btnIndividualLipsEditor"
        Me.btnIndividualLipsEditor.Size = New System.Drawing.Size(105, 52)
        Me.btnIndividualLipsEditor.TabIndex = 29
        Me.btnIndividualLipsEditor.Text = "Individual Lips Editor"
        Me.btnIndividualLipsEditor.UseVisualStyleBackColor = True
        '
        'btnUpdateLips
        '
        Me.btnUpdateLips.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateLips.Enabled = False
        Me.btnUpdateLips.Location = New System.Drawing.Point(839, 7)
        Me.btnUpdateLips.Name = "btnUpdateLips"
        Me.btnUpdateLips.Size = New System.Drawing.Size(104, 52)
        Me.btnUpdateLips.TabIndex = 28
        Me.btnUpdateLips.Text = "Update Lips"
        Me.btnUpdateLips.UseVisualStyleBackColor = True
        '
        'splcontDGV
        '
        Me.splcontDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splcontDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.splcontDGV.Location = New System.Drawing.Point(7, 45)
        Me.splcontDGV.Name = "splcontDGV"
        '
        'splcontDGV.Panel1
        '
        Me.splcontDGV.Panel1.Controls.Add(Me.dgvDLG1)
        '
        'splcontDGV.Panel2
        '
        Me.splcontDGV.Panel2.Controls.Add(Me.dgvDLG2)
        Me.splcontDGV.Size = New System.Drawing.Size(1480, 545)
        Me.splcontDGV.SplitterDistance = 738
        Me.splcontDGV.TabIndex = 28
        '
        'dgvDLG1
        '
        Me.dgvDLG1.AllowUserToAddRows = False
        Me.dgvDLG1.AllowUserToDeleteRows = False
        Me.dgvDLG1.AllowUserToResizeRows = False
        Me.dgvDLG1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvDLG1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvDLG1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvDLG1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDLG1.ColumnHeadersHeight = 29
        Me.dgvDLG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDLG1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cNum, Me.cMale, Me.cFemale, Me.cJump, Me.cCondition, Me.cExecPy, Me.cBrujah, Me.cGangrel, Me.cNosferatu, Me.cToreador, Me.cTremere, Me.cVentrue, Me.cMalkavian})
        Me.dgvDLG1.ContextMenuStrip = Me.cmsdgvDLG1
        Me.dgvDLG1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDLG1.Location = New System.Drawing.Point(0, 0)
        Me.dgvDLG1.MultiSelect = False
        Me.dgvDLG1.Name = "dgvDLG1"
        Me.dgvDLG1.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvDLG1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDLG1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvDLG1.RowTemplate.Height = 24
        Me.dgvDLG1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDLG1.Size = New System.Drawing.Size(734, 541)
        Me.dgvDLG1.TabIndex = 0
        '
        'cNum
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.NullValue = Nothing
        Me.cNum.DefaultCellStyle = DataGridViewCellStyle5
        Me.cNum.Frozen = True
        Me.cNum.HeaderText = "Num"
        Me.cNum.MinimumWidth = 6
        Me.cNum.Name = "cNum"
        Me.cNum.ReadOnly = True
        Me.cNum.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cNum.Width = 60
        '
        'cMale
        '
        Me.cMale.HeaderText = "Male"
        Me.cMale.MinimumWidth = 6
        Me.cMale.Name = "cMale"
        Me.cMale.ReadOnly = True
        Me.cMale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cMale.Width = 88
        '
        'cFemale
        '
        Me.cFemale.HeaderText = "Female"
        Me.cFemale.MinimumWidth = 6
        Me.cFemale.Name = "cFemale"
        Me.cFemale.ReadOnly = True
        Me.cFemale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cFemale.Width = 88
        '
        'cJump
        '
        Me.cJump.HeaderText = "Jump"
        Me.cJump.MinimumWidth = 6
        Me.cJump.Name = "cJump"
        Me.cJump.ReadOnly = True
        Me.cJump.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cJump.Width = 88
        '
        'cCondition
        '
        Me.cCondition.HeaderText = "Condition"
        Me.cCondition.MinimumWidth = 6
        Me.cCondition.Name = "cCondition"
        Me.cCondition.ReadOnly = True
        Me.cCondition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cCondition.Width = 88
        '
        'cExecPy
        '
        Me.cExecPy.HeaderText = "ExecPy"
        Me.cExecPy.MinimumWidth = 6
        Me.cExecPy.Name = "cExecPy"
        Me.cExecPy.ReadOnly = True
        Me.cExecPy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cExecPy.Width = 88
        '
        'cBrujah
        '
        Me.cBrujah.HeaderText = "Brujah"
        Me.cBrujah.MinimumWidth = 6
        Me.cBrujah.Name = "cBrujah"
        Me.cBrujah.ReadOnly = True
        Me.cBrujah.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cBrujah.Width = 88
        '
        'cGangrel
        '
        Me.cGangrel.HeaderText = "Gangrel"
        Me.cGangrel.MinimumWidth = 6
        Me.cGangrel.Name = "cGangrel"
        Me.cGangrel.ReadOnly = True
        Me.cGangrel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cGangrel.Width = 88
        '
        'cNosferatu
        '
        Me.cNosferatu.HeaderText = "Nosferatu"
        Me.cNosferatu.MinimumWidth = 6
        Me.cNosferatu.Name = "cNosferatu"
        Me.cNosferatu.ReadOnly = True
        Me.cNosferatu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cNosferatu.Width = 88
        '
        'cToreador
        '
        Me.cToreador.HeaderText = "Toreador"
        Me.cToreador.MinimumWidth = 6
        Me.cToreador.Name = "cToreador"
        Me.cToreador.ReadOnly = True
        Me.cToreador.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cToreador.Width = 88
        '
        'cTremere
        '
        Me.cTremere.HeaderText = "Tremere"
        Me.cTremere.MinimumWidth = 6
        Me.cTremere.Name = "cTremere"
        Me.cTremere.ReadOnly = True
        Me.cTremere.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cTremere.Width = 88
        '
        'cVentrue
        '
        Me.cVentrue.HeaderText = "Ventrue"
        Me.cVentrue.MinimumWidth = 6
        Me.cVentrue.Name = "cVentrue"
        Me.cVentrue.ReadOnly = True
        Me.cVentrue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cVentrue.Width = 88
        '
        'cMalkavian
        '
        Me.cMalkavian.HeaderText = "Malkavian"
        Me.cMalkavian.MinimumWidth = 6
        Me.cMalkavian.Name = "cMalkavian"
        Me.cMalkavian.ReadOnly = True
        Me.cMalkavian.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cMalkavian.Width = 88
        '
        'panelUP
        '
        Me.panelUP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelUP.Controls.Add(Me.btnDGV2Clear)
        Me.panelUP.Controls.Add(Me.btnRefresh2)
        Me.panelUP.Controls.Add(Me.btnRefresh1)
        Me.panelUP.Controls.Add(Me.btnLoadDLG2)
        Me.panelUP.Controls.Add(Me.txtDLG2)
        Me.panelUP.Controls.Add(Me.btnLoadDLG1)
        Me.panelUP.Controls.Add(Me.txtDLG1)
        Me.panelUP.Location = New System.Drawing.Point(2, 2)
        Me.panelUP.Name = "panelUP"
        Me.panelUP.Size = New System.Drawing.Size(1486, 43)
        Me.panelUP.TabIndex = 29
        '
        'btnDGV2Clear
        '
        Me.btnDGV2Clear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDGV2Clear.BackgroundImage = Global.VtMBTranslator.My.Resources.Resources.EmptyDatagrid
        Me.btnDGV2Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDGV2Clear.Location = New System.Drawing.Point(1448, 4)
        Me.btnDGV2Clear.Name = "btnDGV2Clear"
        Me.btnDGV2Clear.Size = New System.Drawing.Size(34, 34)
        Me.btnDGV2Clear.TabIndex = 16
        Me.btnDGV2Clear.UseVisualStyleBackColor = True
        '
        'frmVtMBTranslator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1495, 798)
        Me.Controls.Add(Me.panelUP)
        Me.Controls.Add(Me.splcontDGV)
        Me.Controls.Add(Me.panelLOWER)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(1513, 845)
        Me.Name = "frmVtMBTranslator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VtMBTranslator"
        Me.cmsdgvDLG1.ResumeLayout(False)
        CType(Me.dgvDLG2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLOWER.ResumeLayout(False)
        Me.panelLOWER.PerformLayout()
        Me.splcontDGV.Panel1.ResumeLayout(False)
        Me.splcontDGV.Panel2.ResumeLayout(False)
        CType(Me.splcontDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splcontDGV.ResumeLayout(False)
        CType(Me.dgvDLG1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelUP.ResumeLayout(False)
        Me.panelUP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDLG1 As TextBox
    Friend WithEvents btnLoadDLG1 As Button
    Friend WithEvents loadDLG As OpenFileDialog
    Friend WithEvents btnLoadDLG2 As Button
    Friend WithEvents txtDLG2 As TextBox
    Friend WithEvents dgvDLG2 As DataGridView
    Friend WithEvents btnEditClans As Button
    Friend WithEvents btnCompEveryone As Button
    Friend WithEvents txtReport As TextBox
    Friend WithEvents btnOPENTE As Button
    Friend WithEvents btnRefresh1 As Button
    Friend WithEvents btnRefresh2 As Button
    Friend WithEvents lbSections As Label
    Friend WithEvents txtSections As TextBox
    Friend WithEvents lbLineCounter As Label
    Friend WithEvents txtLoadingLine As TextBox
    Friend WithEvents btnEditEveryone As Button
    Friend WithEvents btnSaveAsDLG1 As Button
    Friend WithEvents saveDLG As SaveFileDialog
    Friend WithEvents btnSaveDLG1 As Button
    Friend WithEvents cmsdgvDLG1 As ContextMenuStrip
    Friend WithEvents tsmiCopy As ToolStripMenuItem
    Friend WithEvents tsmiGTCL As ToolStripMenuItem
    Friend WithEvents tsmiFS As ToolStripMenuItem
    Friend WithEvents btnGTCL As Button
    Friend WithEvents btnFS As Button
    Friend WithEvents tsmiFSE As ToolStripMenuItem
    Friend WithEvents btnCompClans As Button
    Friend WithEvents panelLOWER As Panel
    Friend WithEvents splcontDGV As SplitContainer
    Friend WithEvents panelUP As Panel
    Friend WithEvents dgvDLG1 As DataGridView
    Friend WithEvents cNum2 As DataGridViewTextBoxColumn
    Friend WithEvents cMale2 As DataGridViewTextBoxColumn
    Friend WithEvents cFemale2 As DataGridViewTextBoxColumn
    Friend WithEvents cJump2 As DataGridViewTextBoxColumn
    Friend WithEvents cCondition2 As DataGridViewTextBoxColumn
    Friend WithEvents cExePy2 As DataGridViewTextBoxColumn
    Friend WithEvents cBrujah2 As DataGridViewTextBoxColumn
    Friend WithEvents cGangrel2 As DataGridViewTextBoxColumn
    Friend WithEvents cNosferatu2 As DataGridViewTextBoxColumn
    Friend WithEvents cToreador2 As DataGridViewTextBoxColumn
    Friend WithEvents cTremere2 As DataGridViewTextBoxColumn
    Friend WithEvents cVentrue2 As DataGridViewTextBoxColumn
    Friend WithEvents cMalkavian2 As DataGridViewTextBoxColumn
    Friend WithEvents cNum As DataGridViewTextBoxColumn
    Friend WithEvents cMale As DataGridViewTextBoxColumn
    Friend WithEvents cFemale As DataGridViewTextBoxColumn
    Friend WithEvents cJump As DataGridViewTextBoxColumn
    Friend WithEvents cCondition As DataGridViewTextBoxColumn
    Friend WithEvents cExecPy As DataGridViewTextBoxColumn
    Friend WithEvents cBrujah As DataGridViewTextBoxColumn
    Friend WithEvents cGangrel As DataGridViewTextBoxColumn
    Friend WithEvents cNosferatu As DataGridViewTextBoxColumn
    Friend WithEvents cToreador As DataGridViewTextBoxColumn
    Friend WithEvents cTremere As DataGridViewTextBoxColumn
    Friend WithEvents cVentrue As DataGridViewTextBoxColumn
    Friend WithEvents cMalkavian As DataGridViewTextBoxColumn
    Friend WithEvents btnUpdateLips As Button
    Friend WithEvents btnIndividualLipsEditor As Button
    Friend WithEvents btnDGV2Clear As Button
    Friend WithEvents cbEncoding As ComboBox
    Friend WithEvents lbEncoding As Label
End Class
