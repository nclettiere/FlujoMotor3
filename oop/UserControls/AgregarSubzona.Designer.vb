<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarSubzona
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxZonas = New System.Windows.Forms.ComboBox()
        Me.NUDCapacidad = New System.Windows.Forms.NumericUpDown()
        CType(Me.NUDCapacidad,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(3, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Capacidad:"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.DarkGray
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Crimson
        Me.btnAgregar.Location = New System.Drawing.Point(6, 214)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(250, 36)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = false
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(3, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Subzona Nombre:"
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = true
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.Crimson
        Me.lbltitulo.Location = New System.Drawing.Point(3, 17)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(121, 17)
        Me.lbltitulo.TabIndex = 7
        Me.lbltitulo.Text = "Agregar SubZona"
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(6, 66)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(250, 20)
        Me.tbxNombre.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(3, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Zona ID:"
        '
        'cbxZonas
        '
        Me.cbxZonas.FormattingEnabled = true
        Me.cbxZonas.Location = New System.Drawing.Point(6, 164)
        Me.cbxZonas.Name = "cbxZonas"
        Me.cbxZonas.Size = New System.Drawing.Size(250, 21)
        Me.cbxZonas.TabIndex = 14
        '
        'NUDCapacidad
        '
        Me.NUDCapacidad.Location = New System.Drawing.Point(6, 118)
        Me.NUDCapacidad.Name = "NUDCapacidad"
        Me.NUDCapacidad.Size = New System.Drawing.Size(250, 20)
        Me.NUDCapacidad.TabIndex = 15
        '
        'AgregarSubzona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.NUDCapacidad)
        Me.Controls.Add(Me.cbxZonas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.tbxNombre)
        Me.Name = "AgregarSubzona"
        Me.Size = New System.Drawing.Size(261, 263)
        CType(Me.NUDCapacidad,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lbltitulo As Label
    Friend WithEvents tbxNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxZonas As ComboBox
    Friend WithEvents NUDCapacidad As NumericUpDown
End Class
