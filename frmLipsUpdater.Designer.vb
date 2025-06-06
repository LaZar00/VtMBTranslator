<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLipsUpdater
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
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnLipsPath = New System.Windows.Forms.Button()
        Me.txtLipsPath = New System.Windows.Forms.TextBox()
        Me.btnVCDPath = New System.Windows.Forms.Button()
        Me.txtVCDPath = New System.Windows.Forms.TextBox()
        Me.btnResultPath = New System.Windows.Forms.Button()
        Me.txtResultPath = New System.Windows.Forms.TextBox()
        Me.txtReport = New System.Windows.Forms.TextBox()
        Me.btnTranslateLips = New System.Windows.Forms.Button()
        Me.lblSpeakerName = New System.Windows.Forms.Label()
        Me.txtSpeakerName = New System.Windows.Forms.TextBox()
        Me.txtMP3Path = New System.Windows.Forms.TextBox()
        Me.btnMP3Path = New System.Windows.Forms.Button()
        Me.txtSpeakerNameTrans = New System.Windows.Forms.TextBox()
        Me.btnCopySpeakerName = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(639, 586)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 44)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(11, 586)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(150, 44)
        Me.btnCheck.TabIndex = 2
        Me.btnCheck.Text = "Check Preprocess"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnLipsPath
        '
        Me.btnLipsPath.Location = New System.Drawing.Point(12, 12)
        Me.btnLipsPath.Name = "btnLipsPath"
        Me.btnLipsPath.Size = New System.Drawing.Size(123, 32)
        Me.btnLipsPath.TabIndex = 4
        Me.btnLipsPath.Text = "Lips Path"
        Me.btnLipsPath.UseVisualStyleBackColor = True
        '
        'txtLipsPath
        '
        Me.txtLipsPath.Location = New System.Drawing.Point(141, 17)
        Me.txtLipsPath.Name = "txtLipsPath"
        Me.txtLipsPath.ReadOnly = True
        Me.txtLipsPath.Size = New System.Drawing.Size(648, 22)
        Me.txtLipsPath.TabIndex = 3
        '
        'btnVCDPath
        '
        Me.btnVCDPath.Location = New System.Drawing.Point(12, 50)
        Me.btnVCDPath.Name = "btnVCDPath"
        Me.btnVCDPath.Size = New System.Drawing.Size(123, 32)
        Me.btnVCDPath.TabIndex = 5
        Me.btnVCDPath.Text = "VCD Path"
        Me.btnVCDPath.UseVisualStyleBackColor = True
        '
        'txtVCDPath
        '
        Me.txtVCDPath.Location = New System.Drawing.Point(141, 55)
        Me.txtVCDPath.Name = "txtVCDPath"
        Me.txtVCDPath.ReadOnly = True
        Me.txtVCDPath.Size = New System.Drawing.Size(647, 22)
        Me.txtVCDPath.TabIndex = 6
        '
        'btnResultPath
        '
        Me.btnResultPath.Location = New System.Drawing.Point(12, 126)
        Me.btnResultPath.Name = "btnResultPath"
        Me.btnResultPath.Size = New System.Drawing.Size(123, 32)
        Me.btnResultPath.TabIndex = 7
        Me.btnResultPath.Text = "Result Path"
        Me.btnResultPath.UseVisualStyleBackColor = True
        '
        'txtResultPath
        '
        Me.txtResultPath.Location = New System.Drawing.Point(141, 131)
        Me.txtResultPath.Name = "txtResultPath"
        Me.txtResultPath.ReadOnly = True
        Me.txtResultPath.Size = New System.Drawing.Size(647, 22)
        Me.txtResultPath.TabIndex = 8
        '
        'txtReport
        '
        Me.txtReport.Location = New System.Drawing.Point(12, 178)
        Me.txtReport.Multiline = True
        Me.txtReport.Name = "txtReport"
        Me.txtReport.ReadOnly = True
        Me.txtReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReport.Size = New System.Drawing.Size(777, 364)
        Me.txtReport.TabIndex = 13
        Me.txtReport.WordWrap = False
        '
        'btnTranslateLips
        '
        Me.btnTranslateLips.Enabled = False
        Me.btnTranslateLips.Location = New System.Drawing.Point(165, 586)
        Me.btnTranslateLips.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTranslateLips.Name = "btnTranslateLips"
        Me.btnTranslateLips.Size = New System.Drawing.Size(470, 44)
        Me.btnTranslateLips.TabIndex = 14
        Me.btnTranslateLips.Text = "Translate Lip files and Generate VCD/MP3 files if needed"
        Me.btnTranslateLips.UseVisualStyleBackColor = True
        '
        'lblSpeakerName
        '
        Me.lblSpeakerName.AutoSize = True
        Me.lblSpeakerName.Location = New System.Drawing.Point(59, 560)
        Me.lblSpeakerName.Name = "lblSpeakerName"
        Me.lblSpeakerName.Size = New System.Drawing.Size(102, 16)
        Me.lblSpeakerName.TabIndex = 15
        Me.lblSpeakerName.Text = "Speaker Name:"
        '
        'txtSpeakerName
        '
        Me.txtSpeakerName.Enabled = False
        Me.txtSpeakerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpeakerName.Location = New System.Drawing.Point(165, 550)
        Me.txtSpeakerName.Name = "txtSpeakerName"
        Me.txtSpeakerName.Size = New System.Drawing.Size(252, 30)
        Me.txtSpeakerName.TabIndex = 16
        '
        'txtMP3Path
        '
        Me.txtMP3Path.Location = New System.Drawing.Point(141, 93)
        Me.txtMP3Path.Name = "txtMP3Path"
        Me.txtMP3Path.ReadOnly = True
        Me.txtMP3Path.Size = New System.Drawing.Size(647, 22)
        Me.txtMP3Path.TabIndex = 18
        '
        'btnMP3Path
        '
        Me.btnMP3Path.Location = New System.Drawing.Point(12, 88)
        Me.btnMP3Path.Name = "btnMP3Path"
        Me.btnMP3Path.Size = New System.Drawing.Size(123, 32)
        Me.btnMP3Path.TabIndex = 17
        Me.btnMP3Path.Text = "MP3 Path"
        Me.btnMP3Path.UseVisualStyleBackColor = True
        '
        'txtSpeakerNameTrans
        '
        Me.txtSpeakerNameTrans.Enabled = False
        Me.txtSpeakerNameTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpeakerNameTrans.Location = New System.Drawing.Point(536, 550)
        Me.txtSpeakerNameTrans.Name = "txtSpeakerNameTrans"
        Me.txtSpeakerNameTrans.Size = New System.Drawing.Size(252, 30)
        Me.txtSpeakerNameTrans.TabIndex = 19
        '
        'btnCopySpeakerName
        '
        Me.btnCopySpeakerName.Enabled = False
        Me.btnCopySpeakerName.Location = New System.Drawing.Point(484, 550)
        Me.btnCopySpeakerName.Name = "btnCopySpeakerName"
        Me.btnCopySpeakerName.Size = New System.Drawing.Size(48, 31)
        Me.btnCopySpeakerName.TabIndex = 20
        Me.btnCopySpeakerName.Text = "<-"
        Me.btnCopySpeakerName.UseVisualStyleBackColor = True
        '
        'frmLipsUpdater
        '
        Me.AcceptButton = Me.btnCheck
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(800, 637)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCopySpeakerName)
        Me.Controls.Add(Me.txtSpeakerNameTrans)
        Me.Controls.Add(Me.txtMP3Path)
        Me.Controls.Add(Me.btnMP3Path)
        Me.Controls.Add(Me.txtSpeakerName)
        Me.Controls.Add(Me.lblSpeakerName)
        Me.Controls.Add(Me.btnTranslateLips)
        Me.Controls.Add(Me.txtReport)
        Me.Controls.Add(Me.txtResultPath)
        Me.Controls.Add(Me.btnResultPath)
        Me.Controls.Add(Me.txtVCDPath)
        Me.Controls.Add(Me.btnVCDPath)
        Me.Controls.Add(Me.btnLipsPath)
        Me.Controls.Add(Me.txtLipsPath)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnClose)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(818, 684)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(818, 684)
        Me.Name = "frmLipsUpdater"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lips Updater"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnLipsPath As Button
    Friend WithEvents txtLipsPath As TextBox
    Friend WithEvents btnVCDPath As Button
    Friend WithEvents txtVCDPath As TextBox
    Friend WithEvents btnResultPath As Button
    Friend WithEvents txtResultPath As TextBox
    Friend WithEvents txtReport As TextBox
    Friend WithEvents btnTranslateLips As Button
    Friend WithEvents lblSpeakerName As Label
    Friend WithEvents txtSpeakerName As TextBox
    Friend WithEvents txtMP3Path As TextBox
    Friend WithEvents btnMP3Path As Button
    Friend WithEvents txtSpeakerNameTrans As TextBox
    Friend WithEvents btnCopySpeakerName As Button
End Class
