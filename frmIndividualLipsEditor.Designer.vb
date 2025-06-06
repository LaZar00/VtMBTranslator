<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndividualLipsEditor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
        Me.tvLipsEditor = New System.Windows.Forms.TreeView()
        Me.scLipsEditor = New System.Windows.Forms.SplitContainer()
        Me.tablelayoutPanelLip = New System.Windows.Forms.TableLayoutPanel()
        Me.lblBrujah = New System.Windows.Forms.Label()
        Me.txtTranslatePHRASE = New System.Windows.Forms.TextBox()
        Me.txtOriginalPHRASE = New System.Windows.Forms.TextBox()
        Me.btnTranslateDeepL = New System.Windows.Forms.Button()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.txtSpeakerName = New System.Windows.Forms.TextBox()
        Me.lblSpeakerName = New System.Windows.Forms.Label()
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.btnLipsPath = New System.Windows.Forms.Button()
        Me.txtIndividualLipsPath = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.scLipsEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scLipsEditor.Panel1.SuspendLayout()
        Me.scLipsEditor.Panel2.SuspendLayout()
        Me.scLipsEditor.SuspendLayout()
        Me.tablelayoutPanelLip.SuspendLayout()
        Me.SuspendLayout()
        '
        'tvLipsEditor
        '
        Me.tvLipsEditor.BackColor = System.Drawing.Color.AliceBlue
        Me.tvLipsEditor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvLipsEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvLipsEditor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.tvLipsEditor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tvLipsEditor.Location = New System.Drawing.Point(0, 0)
        Me.tvLipsEditor.Name = "tvLipsEditor"
        Me.tvLipsEditor.Size = New System.Drawing.Size(377, 550)
        Me.tvLipsEditor.TabIndex = 0
        '
        'scLipsEditor
        '
        Me.scLipsEditor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scLipsEditor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.scLipsEditor.Location = New System.Drawing.Point(12, 12)
        Me.scLipsEditor.Name = "scLipsEditor"
        '
        'scLipsEditor.Panel1
        '
        Me.scLipsEditor.Panel1.Controls.Add(Me.tvLipsEditor)
        Me.scLipsEditor.Panel1MinSize = 369
        '
        'scLipsEditor.Panel2
        '
        Me.scLipsEditor.Panel2.Controls.Add(Me.tablelayoutPanelLip)
        Me.scLipsEditor.Panel2.Controls.Add(Me.btnTranslateDeepL)
        Me.scLipsEditor.Panel2.Controls.Add(Me.lblFile)
        Me.scLipsEditor.Panel2.Controls.Add(Me.txtFilePath)
        Me.scLipsEditor.Panel2.Controls.Add(Me.txtSpeakerName)
        Me.scLipsEditor.Panel2.Controls.Add(Me.lblSpeakerName)
        Me.scLipsEditor.Panel2.Controls.Add(Me.btnValidate)
        Me.scLipsEditor.Panel2.Controls.Add(Me.btnLipsPath)
        Me.scLipsEditor.Panel2.Controls.Add(Me.txtIndividualLipsPath)
        Me.scLipsEditor.Panel2.Controls.Add(Me.btnClose)
        Me.scLipsEditor.Panel2MinSize = 630
        Me.scLipsEditor.Size = New System.Drawing.Size(1038, 554)
        Me.scLipsEditor.SplitterDistance = 381
        Me.scLipsEditor.TabIndex = 1
        '
        'tablelayoutPanelLip
        '
        Me.tablelayoutPanelLip.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tablelayoutPanelLip.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.tablelayoutPanelLip.ColumnCount = 1
        Me.tablelayoutPanelLip.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutPanelLip.Controls.Add(Me.lblBrujah, 0, 0)
        Me.tablelayoutPanelLip.Controls.Add(Me.txtTranslatePHRASE, 0, 1)
        Me.tablelayoutPanelLip.Controls.Add(Me.txtOriginalPHRASE, 0, 2)
        Me.tablelayoutPanelLip.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tablelayoutPanelLip.Location = New System.Drawing.Point(7, 81)
        Me.tablelayoutPanelLip.Margin = New System.Windows.Forms.Padding(0)
        Me.tablelayoutPanelLip.Name = "tablelayoutPanelLip"
        Me.tablelayoutPanelLip.RowCount = 3
        Me.tablelayoutPanelLip.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tablelayoutPanelLip.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelayoutPanelLip.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelayoutPanelLip.Size = New System.Drawing.Size(635, 369)
        Me.tablelayoutPanelLip.TabIndex = 35
        '
        'lblBrujah
        '
        Me.lblBrujah.AutoSize = True
        Me.lblBrujah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblBrujah.Location = New System.Drawing.Point(4, 4)
        Me.lblBrujah.Margin = New System.Windows.Forms.Padding(2)
        Me.lblBrujah.Name = "lblBrujah"
        Me.lblBrujah.Size = New System.Drawing.Size(73, 16)
        Me.lblBrujah.TabIndex = 1
        Me.lblBrujah.Text = "PHRASE:"
        '
        'txtTranslatePHRASE
        '
        Me.txtTranslatePHRASE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTranslatePHRASE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTranslatePHRASE.Location = New System.Drawing.Point(2, 24)
        Me.txtTranslatePHRASE.Margin = New System.Windows.Forms.Padding(0)
        Me.txtTranslatePHRASE.Multiline = True
        Me.txtTranslatePHRASE.Name = "txtTranslatePHRASE"
        Me.txtTranslatePHRASE.Size = New System.Drawing.Size(631, 170)
        Me.txtTranslatePHRASE.TabIndex = 17
        '
        'txtOriginalPHRASE
        '
        Me.txtOriginalPHRASE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOriginalPHRASE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOriginalPHRASE.Location = New System.Drawing.Point(2, 196)
        Me.txtOriginalPHRASE.Margin = New System.Windows.Forms.Padding(0)
        Me.txtOriginalPHRASE.Multiline = True
        Me.txtOriginalPHRASE.Name = "txtOriginalPHRASE"
        Me.txtOriginalPHRASE.ReadOnly = True
        Me.txtOriginalPHRASE.Size = New System.Drawing.Size(631, 171)
        Me.txtOriginalPHRASE.TabIndex = 19
        Me.txtOriginalPHRASE.TabStop = False
        '
        'btnTranslateDeepL
        '
        Me.btnTranslateDeepL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTranslateDeepL.BackgroundImage = Global.VtMBTranslator.My.Resources.Resources.deepl
        Me.btnTranslateDeepL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTranslateDeepL.Location = New System.Drawing.Point(8, 455)
        Me.btnTranslateDeepL.Name = "btnTranslateDeepL"
        Me.btnTranslateDeepL.Size = New System.Drawing.Size(44, 44)
        Me.btnTranslateDeepL.TabIndex = 34
        Me.btnTranslateDeepL.UseVisualStyleBackColor = True
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(8, 57)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(32, 16)
        Me.lblFile.TabIndex = 24
        Me.lblFile.Text = "File:"
        '
        'txtFilePath
        '
        Me.txtFilePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilePath.Location = New System.Drawing.Point(46, 54)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.ReadOnly = True
        Me.txtFilePath.Size = New System.Drawing.Size(596, 22)
        Me.txtFilePath.TabIndex = 23
        '
        'txtSpeakerName
        '
        Me.txtSpeakerName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSpeakerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpeakerName.Location = New System.Drawing.Point(173, 462)
        Me.txtSpeakerName.Name = "txtSpeakerName"
        Me.txtSpeakerName.Size = New System.Drawing.Size(290, 30)
        Me.txtSpeakerName.TabIndex = 22
        '
        'lblSpeakerName
        '
        Me.lblSpeakerName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSpeakerName.AutoSize = True
        Me.lblSpeakerName.Location = New System.Drawing.Point(65, 472)
        Me.lblSpeakerName.Name = "lblSpeakerName"
        Me.lblSpeakerName.Size = New System.Drawing.Size(102, 16)
        Me.lblSpeakerName.TabIndex = 21
        Me.lblSpeakerName.Text = "Speaker Name:"
        '
        'btnValidate
        '
        Me.btnValidate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnValidate.Location = New System.Drawing.Point(8, 502)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(456, 44)
        Me.btnValidate.TabIndex = 20
        Me.btnValidate.Text = "Validate"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'btnLipsPath
        '
        Me.btnLipsPath.Location = New System.Drawing.Point(8, 3)
        Me.btnLipsPath.Name = "btnLipsPath"
        Me.btnLipsPath.Size = New System.Drawing.Size(123, 44)
        Me.btnLipsPath.TabIndex = 6
        Me.btnLipsPath.Text = "Individual Lips Global Path"
        Me.btnLipsPath.UseVisualStyleBackColor = True
        '
        'txtIndividualLipsPath
        '
        Me.txtIndividualLipsPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIndividualLipsPath.Location = New System.Drawing.Point(137, 14)
        Me.txtIndividualLipsPath.Name = "txtIndividualLipsPath"
        Me.txtIndividualLipsPath.ReadOnly = True
        Me.txtIndividualLipsPath.Size = New System.Drawing.Size(505, 22)
        Me.txtIndividualLipsPath.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(492, 502)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 44)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmIndividualLipsEditor
        '
        Me.AcceptButton = Me.btnValidate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1062, 578)
        Me.Controls.Add(Me.scLipsEditor)
        Me.DoubleBuffered = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1080, 625)
        Me.Name = "frmIndividualLipsEditor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Individual Lips Editor"
        Me.TransparencyKey = System.Drawing.Color.MediumSpringGreen
        Me.scLipsEditor.Panel1.ResumeLayout(False)
        Me.scLipsEditor.Panel2.ResumeLayout(False)
        Me.scLipsEditor.Panel2.PerformLayout()
        CType(Me.scLipsEditor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scLipsEditor.ResumeLayout(False)
        Me.tablelayoutPanelLip.ResumeLayout(False)
        Me.tablelayoutPanelLip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tvLipsEditor As TreeView
    Friend WithEvents scLipsEditor As SplitContainer
    Friend WithEvents btnClose As Button
    Friend WithEvents btnLipsPath As Button
    Friend WithEvents txtIndividualLipsPath As TextBox
    Friend WithEvents txtOriginalPHRASE As TextBox
    Friend WithEvents btnValidate As Button
    Friend WithEvents txtSpeakerName As TextBox
    Friend WithEvents lblSpeakerName As Label
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents lblFile As Label
    Friend WithEvents btnTranslateDeepL As Button
    Friend WithEvents tablelayoutPanelLip As TableLayoutPanel
    Friend WithEvents lblBrujah As Label
    Friend WithEvents txtTranslatePHRASE As TextBox
End Class
