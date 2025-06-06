<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGTCL_FS
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
        Me.lblGTCL_FS = New System.Windows.Forms.Label()
        Me.txtGTCL_FS = New System.Windows.Forms.TextBox()
        Me.btnGTCL_FS = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cbSearchSecondary = New System.Windows.Forms.CheckBox()
        Me.cbCaseSensitive = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblGTCL_FS
        '
        Me.lblGTCL_FS.AutoSize = True
        Me.lblGTCL_FS.Location = New System.Drawing.Point(12, 12)
        Me.lblGTCL_FS.Name = "lblGTCL_FS"
        Me.lblGTCL_FS.Size = New System.Drawing.Size(149, 16)
        Me.lblGTCL_FS.TabIndex = 0
        Me.lblGTCL_FS.Text = "Go to line with code line:"
        '
        'txtGTCL_FS
        '
        Me.txtGTCL_FS.Location = New System.Drawing.Point(12, 32)
        Me.txtGTCL_FS.Name = "txtGTCL_FS"
        Me.txtGTCL_FS.Size = New System.Drawing.Size(264, 22)
        Me.txtGTCL_FS.TabIndex = 1
        '
        'btnGTCL_FS
        '
        Me.btnGTCL_FS.Location = New System.Drawing.Point(12, 136)
        Me.btnGTCL_FS.Name = "btnGTCL_FS"
        Me.btnGTCL_FS.Size = New System.Drawing.Size(128, 34)
        Me.btnGTCL_FS.TabIndex = 3
        Me.btnGTCL_FS.Text = "Go To..."
        Me.btnGTCL_FS.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(148, 136)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(128, 34)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cbSearchSecondary
        '
        Me.cbSearchSecondary.AutoSize = True
        Me.cbSearchSecondary.Enabled = False
        Me.cbSearchSecondary.Location = New System.Drawing.Point(50, 66)
        Me.cbSearchSecondary.Name = "cbSearchSecondary"
        Me.cbSearchSecondary.Size = New System.Drawing.Size(184, 20)
        Me.cbSearchSecondary.TabIndex = 2
        Me.cbSearchSecondary.Text = "Search in Secondary data"
        Me.cbSearchSecondary.UseVisualStyleBackColor = True
        '
        'cbCaseSensitive
        '
        Me.cbCaseSensitive.AutoSize = True
        Me.cbCaseSensitive.Location = New System.Drawing.Point(50, 92)
        Me.cbCaseSensitive.Name = "cbCaseSensitive"
        Me.cbCaseSensitive.Size = New System.Drawing.Size(119, 20)
        Me.cbCaseSensitive.TabIndex = 5
        Me.cbCaseSensitive.Text = "Case Sensitive"
        Me.cbCaseSensitive.UseVisualStyleBackColor = True
        '
        'frmGTCL_FS
        '
        Me.AcceptButton = Me.btnGTCL_FS
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(292, 177)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbCaseSensitive)
        Me.Controls.Add(Me.cbSearchSecondary)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnGTCL_FS)
        Me.Controls.Add(Me.txtGTCL_FS)
        Me.Controls.Add(Me.lblGTCL_FS)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGTCL_FS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Go To Code Line"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGTCL_FS As Label
    Friend WithEvents txtGTCL_FS As TextBox
    Friend WithEvents btnGTCL_FS As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents cbSearchSecondary As CheckBox
    Friend WithEvents cbCaseSensitive As CheckBox
End Class
