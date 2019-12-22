<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vista5
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
        Me.Button7 = New System.Windows.Forms.Button()
        Me.tabla = New System.Windows.Forms.DataGridView()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(769, 507)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(210, 56)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "SALIR >>"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'tabla
        '
        Me.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla.Location = New System.Drawing.Point(156, 39)
        Me.tabla.Name = "tabla"
        Me.tabla.Size = New System.Drawing.Size(658, 420)
        Me.tabla.TabIndex = 22
        '
        'Vista5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 575)
        Me.Controls.Add(Me.tabla)
        Me.Controls.Add(Me.Button7)
        Me.Name = "Vista5"
        Me.Text = "Vista5"
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents tabla As System.Windows.Forms.DataGridView
End Class
