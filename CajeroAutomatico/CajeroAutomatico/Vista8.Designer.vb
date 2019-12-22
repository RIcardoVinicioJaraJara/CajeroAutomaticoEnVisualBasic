<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vista8
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
        Me.txtAntiagua = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNew1 = New System.Windows.Forms.TextBox()
        Me.txtNew2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAntiagua
        '
        Me.txtAntiagua.Font = New System.Drawing.Font("Verdana", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtAntiagua.Location = New System.Drawing.Point(463, 142)
        Me.txtAntiagua.Name = "txtAntiagua"
        Me.txtAntiagua.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAntiagua.Size = New System.Drawing.Size(249, 33)
        Me.txtAntiagua.TabIndex = 11
        Me.txtAntiagua.Text = "root"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "CONTRASEÑA ANTIGUA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "CONTRASEÑA NUEVA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(367, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "REPETIR CONTRASEÑA NUEVA"
        '
        'txtNew1
        '
        Me.txtNew1.Font = New System.Drawing.Font("Verdana", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtNew1.Location = New System.Drawing.Point(463, 208)
        Me.txtNew1.Name = "txtNew1"
        Me.txtNew1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNew1.Size = New System.Drawing.Size(249, 33)
        Me.txtNew1.TabIndex = 15
        Me.txtNew1.Text = "root"
        '
        'txtNew2
        '
        Me.txtNew2.Font = New System.Drawing.Font("Verdana", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtNew2.Location = New System.Drawing.Point(463, 272)
        Me.txtNew2.Name = "txtNew2"
        Me.txtNew2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNew2.Size = New System.Drawing.Size(249, 33)
        Me.txtNew2.TabIndex = 16
        Me.txtNew2.Text = "root"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(320, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(221, 63)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "ACEPTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtMensaje
        '
        Me.txtMensaje.AutoSize = True
        Me.txtMensaje.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.Location = New System.Drawing.Point(279, 47)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(373, 35)
        Me.txtMensaje.TabIndex = 21
        Me.txtMensaje.Text = "CAMBIO DE CONTRASEÑA"
        '
        'Vista8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 575)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtNew2)
        Me.Controls.Add(Me.txtNew1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAntiagua)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Vista8"
        Me.Text = "Vista8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAntiagua As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNew1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNew2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtMensaje As System.Windows.Forms.Label
End Class
