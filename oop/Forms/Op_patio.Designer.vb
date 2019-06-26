<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Op_patio
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
        Me.tacoVehiculo = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnMenuAutitos = New System.Windows.Forms.Panel()
        Me.btn_ver = New System.Windows.Forms.Button()
        Me.btListarVehiculo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lista_vehiculos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnBuscar = New System.Windows.Forms.Panel()
        Me.pnCampoBuscador = New System.Windows.Forms.Panel()
        Me.btBuscarVehiculo = New System.Windows.Forms.Button()
        Me.txtBuscadorVehiculo = New System.Windows.Forms.TextBox()
        Me.tacoVehiculo.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnMenuAutitos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnBuscar.SuspendLayout()
        Me.pnCampoBuscador.SuspendLayout()
        Me.SuspendLayout()
        '
        'tacoVehiculo
        '
        Me.tacoVehiculo.Controls.Add(Me.TabPage1)
        Me.tacoVehiculo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tacoVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tacoVehiculo.Location = New System.Drawing.Point(0, 0)
        Me.tacoVehiculo.Multiline = True
        Me.tacoVehiculo.Name = "tacoVehiculo"
        Me.tacoVehiculo.SelectedIndex = 0
        Me.tacoVehiculo.Size = New System.Drawing.Size(921, 582)
        Me.tacoVehiculo.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tacoVehiculo.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pnMenuAutitos)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.pnBuscar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(913, 549)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Vehiculos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'pnMenuAutitos
        '
        Me.pnMenuAutitos.BackColor = System.Drawing.Color.Bisque
        Me.pnMenuAutitos.Controls.Add(Me.btn_ver)
        Me.pnMenuAutitos.Controls.Add(Me.btListarVehiculo)
        Me.pnMenuAutitos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnMenuAutitos.Location = New System.Drawing.Point(3, 481)
        Me.pnMenuAutitos.Name = "pnMenuAutitos"
        Me.pnMenuAutitos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pnMenuAutitos.Size = New System.Drawing.Size(907, 65)
        Me.pnMenuAutitos.TabIndex = 1
        '
        'btn_ver
        '
        Me.btn_ver.BackgroundImage = Global.oop.My.Resources.Resources.boton_buscar
        Me.btn_ver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_ver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ver.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_ver.FlatAppearance.BorderSize = 0
        Me.btn_ver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_ver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ver.ForeColor = System.Drawing.Color.White
        Me.btn_ver.Location = New System.Drawing.Point(132, 0)
        Me.btn_ver.Name = "btn_ver"
        Me.btn_ver.Size = New System.Drawing.Size(132, 65)
        Me.btn_ver.TabIndex = 5
        Me.btn_ver.Text = "Ver"
        Me.btn_ver.UseVisualStyleBackColor = True
        '
        'btListarVehiculo
        '
        Me.btListarVehiculo.BackgroundImage = Global.oop.My.Resources.Resources.boton_buscar
        Me.btListarVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btListarVehiculo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btListarVehiculo.Dock = System.Windows.Forms.DockStyle.Left
        Me.btListarVehiculo.FlatAppearance.BorderSize = 0
        Me.btListarVehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btListarVehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btListarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btListarVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btListarVehiculo.ForeColor = System.Drawing.Color.White
        Me.btListarVehiculo.Location = New System.Drawing.Point(0, 0)
        Me.btListarVehiculo.Name = "btListarVehiculo"
        Me.btListarVehiculo.Size = New System.Drawing.Size(132, 65)
        Me.btListarVehiculo.TabIndex = 4
        Me.btListarVehiculo.Text = "Actualizar"
        Me.btListarVehiculo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lista_vehiculos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(907, 473)
        Me.Panel1.TabIndex = 3
        '
        'lista_vehiculos
        '
        Me.lista_vehiculos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader7, Me.ColumnHeader3})
        Me.lista_vehiculos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lista_vehiculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lista_vehiculos.FullRowSelect = True
        Me.lista_vehiculos.HideSelection = False
        Me.lista_vehiculos.Location = New System.Drawing.Point(0, 0)
        Me.lista_vehiculos.Name = "lista_vehiculos"
        Me.lista_vehiculos.Size = New System.Drawing.Size(907, 473)
        Me.lista_vehiculos.TabIndex = 0
        Me.lista_vehiculos.UseCompatibleStateImageBehavior = False
        Me.lista_vehiculos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "VIN"
        Me.ColumnHeader1.Width = 226
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Latitud"
        Me.ColumnHeader2.Width = 184
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Longitud"
        Me.ColumnHeader7.Width = 177
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Patio"
        Me.ColumnHeader3.Width = 166
        '
        'pnBuscar
        '
        Me.pnBuscar.BackColor = System.Drawing.Color.Bisque
        Me.pnBuscar.Controls.Add(Me.pnCampoBuscador)
        Me.pnBuscar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnBuscar.Location = New System.Drawing.Point(3, 3)
        Me.pnBuscar.Name = "pnBuscar"
        Me.pnBuscar.Size = New System.Drawing.Size(907, 70)
        Me.pnBuscar.TabIndex = 2
        '
        'pnCampoBuscador
        '
        Me.pnCampoBuscador.BackgroundImage = Global.oop.My.Resources.Resources.barra__buscador
        Me.pnCampoBuscador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnCampoBuscador.Controls.Add(Me.btBuscarVehiculo)
        Me.pnCampoBuscador.Controls.Add(Me.txtBuscadorVehiculo)
        Me.pnCampoBuscador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnCampoBuscador.Location = New System.Drawing.Point(0, 0)
        Me.pnCampoBuscador.Name = "pnCampoBuscador"
        Me.pnCampoBuscador.Size = New System.Drawing.Size(907, 70)
        Me.pnCampoBuscador.TabIndex = 0
        '
        'btBuscarVehiculo
        '
        Me.btBuscarVehiculo.BackColor = System.Drawing.Color.Transparent
        Me.btBuscarVehiculo.BackgroundImage = Global.oop.My.Resources.Resources.boton_buscar
        Me.btBuscarVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btBuscarVehiculo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btBuscarVehiculo.FlatAppearance.BorderSize = 0
        Me.btBuscarVehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btBuscarVehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btBuscarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBuscarVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscarVehiculo.ForeColor = System.Drawing.Color.White
        Me.btBuscarVehiculo.Location = New System.Drawing.Point(730, -57)
        Me.btBuscarVehiculo.Name = "btBuscarVehiculo"
        Me.btBuscarVehiculo.Size = New System.Drawing.Size(192, 181)
        Me.btBuscarVehiculo.TabIndex = 0
        Me.btBuscarVehiculo.Text = "BUSCAR"
        Me.btBuscarVehiculo.UseVisualStyleBackColor = False
        '
        'txtBuscadorVehiculo
        '
        Me.txtBuscadorVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscadorVehiculo.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscadorVehiculo.ForeColor = System.Drawing.Color.DarkGray
        Me.txtBuscadorVehiculo.Location = New System.Drawing.Point(47, 20)
        Me.txtBuscadorVehiculo.Name = "txtBuscadorVehiculo"
        Me.txtBuscadorVehiculo.Size = New System.Drawing.Size(727, 28)
        Me.txtBuscadorVehiculo.TabIndex = 0
        '
        'Op_patio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(921, 582)
        Me.Controls.Add(Me.tacoVehiculo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Op_patio"
        Me.ShowIcon = False
        Me.Text = "Op_patio"
        Me.tacoVehiculo.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.pnMenuAutitos.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnBuscar.ResumeLayout(False)
        Me.pnCampoBuscador.ResumeLayout(False)
        Me.pnCampoBuscador.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tacoVehiculo As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents pnMenuAutitos As Panel
    Friend WithEvents btListarVehiculo As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lista_vehiculos As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents pnBuscar As Panel
    Friend WithEvents pnCampoBuscador As Panel
    Friend WithEvents btBuscarVehiculo As Button
    Friend WithEvents txtBuscadorVehiculo As TextBox
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents btn_ver As Button
End Class
