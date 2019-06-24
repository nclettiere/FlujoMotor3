<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio_de_sesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio_de_sesion))
        Me.labContraseña = New System.Windows.Forms.Label()
        Me.labUsuario = New System.Windows.Forms.Label()
        Me.btIngresar = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.btMostrar_Ocultar = New System.Windows.Forms.Button()
        Me.labOperario = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'labContraseña
        '
        Me.labContraseña.AutoSize = True
        Me.labContraseña.BackColor = System.Drawing.Color.Transparent
        Me.labContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labContraseña.Font = New System.Drawing.Font("Agency FB", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labContraseña.ForeColor = System.Drawing.Color.White
        Me.labContraseña.Location = New System.Drawing.Point(241, 243)
        Me.labContraseña.Name = "labContraseña"
        Me.labContraseña.Size = New System.Drawing.Size(114, 33)
        Me.labContraseña.TabIndex = 1
        Me.labContraseña.Text = "Contraseña:"
        '
        'labUsuario
        '
        Me.labUsuario.AutoSize = True
        Me.labUsuario.BackColor = System.Drawing.Color.Transparent
        Me.labUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labUsuario.Font = New System.Drawing.Font("Agency FB", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labUsuario.ForeColor = System.Drawing.Color.White
        Me.labUsuario.Location = New System.Drawing.Point(275, 148)
        Me.labUsuario.Name = "labUsuario"
        Me.labUsuario.Size = New System.Drawing.Size(83, 33)
        Me.labUsuario.TabIndex = 2
        Me.labUsuario.Text = "Usuario:"
        '
        'btIngresar
        '
        Me.btIngresar.BackColor = System.Drawing.Color.Transparent
        Me.btIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btIngresar.FlatAppearance.BorderSize = 0
        Me.btIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btIngresar.Font = New System.Drawing.Font("Agency FB", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btIngresar.ForeColor = System.Drawing.Color.Peru
        Me.btIngresar.Location = New System.Drawing.Point(264, 365)
        Me.btIngresar.Name = "btIngresar"
        Me.btIngresar.Size = New System.Drawing.Size(104, 43)
        Me.btIngresar.TabIndex = 3
        Me.btIngresar.Text = "Ingresar"
        Me.btIngresar.UseVisualStyleBackColor = False
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Arial Narrow", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.DarkGray
        Me.txtUsuario.Location = New System.Drawing.Point(120, 187)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(208, 30)
        Me.txtUsuario.TabIndex = 4
        '
        'txtContraseña
        '
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContraseña.Font = New System.Drawing.Font("Arial Narrow", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.Color.DarkGray
        Me.txtContraseña.Location = New System.Drawing.Point(120, 278)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(200, 30)
        Me.txtContraseña.TabIndex = 5
        Me.txtContraseña.UseSystemPasswordChar = True
        '
        'btMostrar_Ocultar
        '
        Me.btMostrar_Ocultar.BackColor = System.Drawing.Color.Transparent
        Me.btMostrar_Ocultar.BackgroundImage = Global.oop.My.Resources.Resources.ojito_gris
        Me.btMostrar_Ocultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btMostrar_Ocultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btMostrar_Ocultar.FlatAppearance.BorderSize = 0
        Me.btMostrar_Ocultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btMostrar_Ocultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btMostrar_Ocultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btMostrar_Ocultar.Location = New System.Drawing.Point(326, 278)
        Me.btMostrar_Ocultar.Name = "btMostrar_Ocultar"
        Me.btMostrar_Ocultar.Size = New System.Drawing.Size(32, 32)
        Me.btMostrar_Ocultar.TabIndex = 6
        Me.btMostrar_Ocultar.UseVisualStyleBackColor = False
        '
        'labOperario
        '
        Me.labOperario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labOperario.AutoSize = True
        Me.labOperario.BackColor = System.Drawing.Color.Transparent
        Me.labOperario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labOperario.Font = New System.Drawing.Font("Agency FB", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labOperario.ForeColor = System.Drawing.Color.White
        Me.labOperario.Location = New System.Drawing.Point(103, 523)
        Me.labOperario.Name = "labOperario"
        Me.labOperario.Size = New System.Drawing.Size(192, 65)
        Me.labOperario.TabIndex = 8
        Me.labOperario.Text = "OPERARIO"
        Me.labOperario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'Inicio_de_sesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.oop.My.Resources.Resources.log_in_Operario_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(399, 630)
        Me.Controls.Add(Me.labOperario)
        Me.Controls.Add(Me.btMostrar_Ocultar)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.btIngresar)
        Me.Controls.Add(Me.labUsuario)
        Me.Controls.Add(Me.labContraseña)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inicio_de_sesion"
        Me.Text = "Log in"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labContraseña As Label
    Friend WithEvents labUsuario As Label
    Friend WithEvents btIngresar As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents btMostrar_Ocultar As Button
    Friend WithEvents labOperario As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
