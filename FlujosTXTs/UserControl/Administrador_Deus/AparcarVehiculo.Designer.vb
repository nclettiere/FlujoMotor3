<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AparcarVehiculo
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblpatio = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxSubz = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NUDColumna = New System.Windows.Forms.NumericUpDown()
        Me.NUDFila = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAparcar = New System.Windows.Forms.Button()
        CType(Me.NUDColumna,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.NUDFila,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(14, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aparcar Vehiculo"
        '
        'lblpatio
        '
        Me.lblpatio.AutoSize = true
        Me.lblpatio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblpatio.ForeColor = System.Drawing.Color.Crimson
        Me.lblpatio.Location = New System.Drawing.Point(14, 45)
        Me.lblpatio.Name = "lblpatio"
        Me.lblpatio.Size = New System.Drawing.Size(99, 15)
        Me.lblpatio.TabIndex = 1
        Me.lblpatio.Text = "Patio designado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(14, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Seleccionar SubZona:"
        '
        'cbxSubz
        '
        Me.cbxSubz.FormattingEnabled = true
        Me.cbxSubz.Location = New System.Drawing.Point(17, 100)
        Me.cbxSubz.Name = "cbxSubz"
        Me.cbxSubz.Size = New System.Drawing.Size(247, 21)
        Me.cbxSubz.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(14, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Columna:"
        '
        'NUDColumna
        '
        Me.NUDColumna.Location = New System.Drawing.Point(17, 151)
        Me.NUDColumna.Name = "NUDColumna"
        Me.NUDColumna.Size = New System.Drawing.Size(247, 20)
        Me.NUDColumna.TabIndex = 5
        '
        'NUDFila
        '
        Me.NUDFila.Location = New System.Drawing.Point(17, 205)
        Me.NUDFila.Name = "NUDFila"
        Me.NUDFila.Size = New System.Drawing.Size(247, 20)
        Me.NUDFila.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(14, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Fila:"
        '
        'btnAparcar
        '
        Me.btnAparcar.BackColor = System.Drawing.Color.Gray
        Me.btnAparcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAparcar.ForeColor = System.Drawing.Color.Crimson
        Me.btnAparcar.Location = New System.Drawing.Point(17, 257)
        Me.btnAparcar.Name = "btnAparcar"
        Me.btnAparcar.Size = New System.Drawing.Size(247, 39)
        Me.btnAparcar.TabIndex = 8
        Me.btnAparcar.Text = "Aparcar"
        Me.btnAparcar.UseVisualStyleBackColor = false
        '
        'AparcarVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.Controls.Add(Me.btnAparcar)
        Me.Controls.Add(Me.NUDFila)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NUDColumna)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbxSubz)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblpatio)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AparcarVehiculo"
        Me.Size = New System.Drawing.Size(292, 319)
        CType(Me.NUDColumna,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.NUDFila,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblpatio As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxSubz As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NUDColumna As NumericUpDown
    Friend WithEvents NUDFila As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAparcar As Button
End Class
