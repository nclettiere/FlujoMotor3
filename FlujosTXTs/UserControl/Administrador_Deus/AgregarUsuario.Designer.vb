<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarUsuario
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbxTel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbOpTransportista = New System.Windows.Forms.RadioButton()
        Me.rbOpPatio = New System.Windows.Forms.RadioButton()
        Me.rbOpPuerto = New System.Windows.Forms.RadioButton()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.tbxApell = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RBAdmin = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(274, 365)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.RBAdmin)
        Me.Panel2.Controls.Add(Me.tbxTel)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.rbOpTransportista)
        Me.Panel2.Controls.Add(Me.rbOpPatio)
        Me.Panel2.Controls.Add(Me.rbOpPuerto)
        Me.Panel2.Controls.Add(Me.btnAgregar)
        Me.Panel2.Controls.Add(Me.tbxApell)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.tbxNombre)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.tbxUsername)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(274, 365)
        Me.Panel2.TabIndex = 0
        '
        'tbxTel
        '
        Me.tbxTel.Location = New System.Drawing.Point(17, 222)
        Me.tbxTel.MaxLength = 24
        Me.tbxTel.Name = "tbxTel"
        Me.tbxTel.Size = New System.Drawing.Size(231, 20)
        Me.tbxTel.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Crimson
        Me.Label6.Location = New System.Drawing.Point(14, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Telefono"
        '
        'rbOpTransportista
        '
        Me.rbOpTransportista.AutoSize = true
        Me.rbOpTransportista.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.rbOpTransportista.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson
        Me.rbOpTransportista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbOpTransportista.Location = New System.Drawing.Point(17, 280)
        Me.rbOpTransportista.Name = "rbOpTransportista"
        Me.rbOpTransportista.Size = New System.Drawing.Size(85, 17)
        Me.rbOpTransportista.TabIndex = 12
        Me.rbOpTransportista.TabStop = true
        Me.rbOpTransportista.Text = "Transportista"
        Me.rbOpTransportista.UseVisualStyleBackColor = true
        '
        'rbOpPatio
        '
        Me.rbOpPatio.AutoSize = true
        Me.rbOpPatio.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.rbOpPatio.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson
        Me.rbOpPatio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbOpPatio.Location = New System.Drawing.Point(157, 257)
        Me.rbOpPatio.Name = "rbOpPatio"
        Me.rbOpPatio.Size = New System.Drawing.Size(91, 17)
        Me.rbOpPatio.TabIndex = 11
        Me.rbOpPatio.TabStop = true
        Me.rbOpPatio.Text = "Operario Patio"
        Me.rbOpPatio.UseVisualStyleBackColor = true
        '
        'rbOpPuerto
        '
        Me.rbOpPuerto.AutoSize = true
        Me.rbOpPuerto.Checked = true
        Me.rbOpPuerto.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.rbOpPuerto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson
        Me.rbOpPuerto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbOpPuerto.Location = New System.Drawing.Point(17, 257)
        Me.rbOpPuerto.Name = "rbOpPuerto"
        Me.rbOpPuerto.Size = New System.Drawing.Size(98, 17)
        Me.rbOpPuerto.TabIndex = 10
        Me.rbOpPuerto.TabStop = true
        Me.rbOpPuerto.Text = "Operario Puerto"
        Me.rbOpPuerto.UseVisualStyleBackColor = true
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.DarkGray
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Crimson
        Me.btnAgregar.Location = New System.Drawing.Point(17, 313)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(243, 35)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = false
        '
        'tbxApell
        '
        Me.tbxApell.Location = New System.Drawing.Point(17, 175)
        Me.tbxApell.MaxLength = 24
        Me.tbxApell.Name = "tbxApell"
        Me.tbxApell.Size = New System.Drawing.Size(231, 20)
        Me.tbxApell.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(14, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Primer Apellido"
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(17, 124)
        Me.tbxNombre.MaxLength = 24
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(231, 20)
        Me.tbxNombre.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(14, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Primer Nombre"
        '
        'tbxUsername
        '
        Me.tbxUsername.Location = New System.Drawing.Point(16, 75)
        Me.tbxUsername.MaxLength = 24
        Me.tbxUsername.Name = "tbxUsername"
        Me.tbxUsername.Size = New System.Drawing.Size(231, 20)
        Me.tbxUsername.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(13, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre de Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(13, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agregar Usuario"
        '
        'RBAdmin
        '
        Me.RBAdmin.AutoSize = true
        Me.RBAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.RBAdmin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson
        Me.RBAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RBAdmin.Location = New System.Drawing.Point(157, 280)
        Me.RBAdmin.Name = "RBAdmin"
        Me.RBAdmin.Size = New System.Drawing.Size(53, 17)
        Me.RBAdmin.TabIndex = 16
        Me.RBAdmin.TabStop = true
        Me.RBAdmin.Text = "Admin"
        Me.RBAdmin.UseVisualStyleBackColor = true
        '
        'AgregarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AgregarUsuario"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(294, 385)
        Me.Panel1.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbxApell As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rbOpTransportista As RadioButton
    Friend WithEvents rbOpPatio As RadioButton
    Friend WithEvents rbOpPuerto As RadioButton
    Friend WithEvents btnAgregar As Button
    Friend WithEvents tbxTel As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RBAdmin As RadioButton
End Class
