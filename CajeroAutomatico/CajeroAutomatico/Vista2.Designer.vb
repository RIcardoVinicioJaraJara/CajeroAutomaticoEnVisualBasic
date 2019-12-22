<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vista2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AUTENTICACIÓN DE DATOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(257, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CEDULA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(189, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CONTRASEÑA:"
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Verdana", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtCedula.Location = New System.Drawing.Point(488, 179)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(249, 33)
        Me.txtCedula.TabIndex = 3
        Me.txtCedula.Text = "0105452171"
        '
        'txtContra
        '
        Me.txtContra.Font = New System.Drawing.Font("Verdana", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtContra.Location = New System.Drawing.Point(488, 245)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContra.Size = New System.Drawing.Size(249, 33)
        Me.txtContra.TabIndex = 4
        Me.txtContra.Text = "root"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(322, 339)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(278, 65)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "CONTINUAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Vista2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 575)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtContra)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Vista2"
        Me.Text = "Vista2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents txtContra As System.Windows.Forms.TextBox
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
