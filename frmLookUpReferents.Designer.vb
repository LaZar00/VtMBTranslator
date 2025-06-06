<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLookUpReferents
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_mtext = New System.Windows.Forms.TextBox()
        Me.txtMaleText = New System.Windows.Forms.TextBox()
        Me.lblMaleText = New System.Windows.Forms.Label()
        Me.txtFemaleText = New System.Windows.Forms.TextBox()
        Me.lblFemaleText = New System.Windows.Forms.Label()
        Me.txtLineNumber = New System.Windows.Forms.TextBox()
        Me.lblJumpToLine = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(10, 470)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(866, 40)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Editing Line:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 176)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Referent:"
        '
        'txt_mtext
        '
        Me.txt_mtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mtext.Location = New System.Drawing.Point(10, 28)
        Me.txt_mtext.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_mtext.Multiline = True
        Me.txt_mtext.Name = "txt_mtext"
        Me.txt_mtext.ReadOnly = True
        Me.txt_mtext.Size = New System.Drawing.Size(866, 132)
        Me.txt_mtext.TabIndex = 10
        '
        'txtMaleText
        '
        Me.txtMaleText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMaleText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaleText.Location = New System.Drawing.Point(10, 215)
        Me.txtMaleText.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaleText.Multiline = True
        Me.txtMaleText.Name = "txtMaleText"
        Me.txtMaleText.ReadOnly = True
        Me.txtMaleText.Size = New System.Drawing.Size(866, 100)
        Me.txtMaleText.TabIndex = 11
        '
        'lblMaleText
        '
        Me.lblMaleText.AutoSize = True
        Me.lblMaleText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblMaleText.Location = New System.Drawing.Point(10, 198)
        Me.lblMaleText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMaleText.Name = "lblMaleText"
        Me.lblMaleText.Size = New System.Drawing.Size(69, 16)
        Me.lblMaleText.TabIndex = 12
        Me.lblMaleText.Text = "Male Text:"
        '
        'txtFemaleText
        '
        Me.txtFemaleText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFemaleText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFemaleText.Location = New System.Drawing.Point(10, 348)
        Me.txtFemaleText.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFemaleText.Multiline = True
        Me.txtFemaleText.Name = "txtFemaleText"
        Me.txtFemaleText.ReadOnly = True
        Me.txtFemaleText.Size = New System.Drawing.Size(866, 100)
        Me.txtFemaleText.TabIndex = 13
        '
        'lblFemaleText
        '
        Me.lblFemaleText.AutoSize = True
        Me.lblFemaleText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblFemaleText.Location = New System.Drawing.Point(11, 330)
        Me.lblFemaleText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFemaleText.Name = "lblFemaleText"
        Me.lblFemaleText.Size = New System.Drawing.Size(85, 16)
        Me.lblFemaleText.TabIndex = 14
        Me.lblFemaleText.Text = "Female Text:"
        '
        'txtLineNumber
        '
        Me.txtLineNumber.Location = New System.Drawing.Point(260, 173)
        Me.txtLineNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLineNumber.Name = "txtLineNumber"
        Me.txtLineNumber.ReadOnly = True
        Me.txtLineNumber.Size = New System.Drawing.Size(67, 22)
        Me.txtLineNumber.TabIndex = 15
        '
        'lblJumpToLine
        '
        Me.lblJumpToLine.AutoSize = True
        Me.lblJumpToLine.Location = New System.Drawing.Point(94, 176)
        Me.lblJumpToLine.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblJumpToLine.Name = "lblJumpToLine"
        Me.lblJumpToLine.Size = New System.Drawing.Size(156, 16)
        Me.lblJumpToLine.TabIndex = 16
        Me.lblJumpToLine.Text = "Jump From Line Number:"
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(332, 172)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(52, 23)
        Me.btnGo.TabIndex = 17
        Me.btnGo.Text = "Go..."
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'frmLookUpReferents
        '
        Me.AcceptButton = Me.btnClose
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(884, 517)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtLineNumber)
        Me.Controls.Add(Me.lblJumpToLine)
        Me.Controls.Add(Me.txtFemaleText)
        Me.Controls.Add(Me.lblFemaleText)
        Me.Controls.Add(Me.txtMaleText)
        Me.Controls.Add(Me.lblMaleText)
        Me.Controls.Add(Me.txt_mtext)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLookUpReferents"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Look Up Referent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_mtext As TextBox
    Friend WithEvents txtMaleText As TextBox
    Friend WithEvents lblMaleText As Label
    Friend WithEvents txtFemaleText As TextBox
    Friend WithEvents lblFemaleText As Label
    Friend WithEvents txtLineNumber As TextBox
    Friend WithEvents lblJumpToLine As Label
    Friend WithEvents btnGo As Button
End Class
