<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vehiculos
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lista_lotes = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_verlote = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_AgregarLote = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnMenuAutitos = New System.Windows.Forms.Panel()
        Me.btn_ver = New System.Windows.Forms.Button()
        Me.btListarVehiculo = New System.Windows.Forms.Button()
        Me.btAgregarVehiculo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lista_vehiculos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnBuscar = New System.Windows.Forms.Panel()
        Me.pnCampoBuscador = New System.Windows.Forms.Panel()
        Me.btBuscarVehiculo = New System.Windows.Forms.Button()
        Me.txtBuscadorVehiculo = New System.Windows.Forms.TextBox()
        Me.TabVehiculos = New System.Windows.Forms.TabControl()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnMenuAutitos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnBuscar.SuspendLayout()
        Me.pnCampoBuscador.SuspendLayout()
        Me.TabVehiculos.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.lista_lotes)
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(929, 588)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lote"
        '
        'lista_lotes
        '
        Me.lista_lotes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7})
        Me.lista_lotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lista_lotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lista_lotes.HideSelection = False
        Me.lista_lotes.Location = New System.Drawing.Point(3, 73)
        Me.lista_lotes.Name = "lista_lotes"
        Me.lista_lotes.Size = New System.Drawing.Size(923, 447)
        Me.lista_lotes.TabIndex = 4
        Me.lista_lotes.UseCompatibleStateImageBehavior = False
        Me.lista_lotes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Lote"
        Me.ColumnHeader7.Width = 800
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Bisque
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(923, 70)
        Me.Panel3.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Bisque
        Me.Panel2.Controls.Add(Me.btn_verlote)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btn_AgregarLote)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 520)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel2.Size = New System.Drawing.Size(923, 65)
        Me.Panel2.TabIndex = 2
        '
        'btn_verlote
        '
        Me.btn_verlote.BackgroundImage = Global.oop.My.Resources.Resources.boton_buscar
        Me.btn_verlote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_verlote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_verlote.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_verlote.FlatAppearance.BorderSize = 0
        Me.btn_verlote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_verlote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_verlote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_verlote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_verlote.ForeColor = System.Drawing.Color.White
        Me.btn_verlote.Location = New System.Drawing.Point(264, 0)
        Me.btn_verlote.Name = "btn_verlote"
        Me.btn_verlote.Size = New System.Drawing.Size(132, 65)
        Me.btn_verlote.TabIndex = 9
        Me.btn_verlote.Text = "Ver"
        Me.btn_verlote.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.oop.My.Resources.Resources.boton_buscar
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(132, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 65)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_AgregarLote
        '
        Me.btn_AgregarLote.BackgroundImage = Global.oop.My.Resources.Resources.boton_buscar
        Me.btn_AgregarLote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_AgregarLote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_AgregarLote.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_AgregarLote.FlatAppearance.BorderSize = 0
        Me.btn_AgregarLote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_AgregarLote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_AgregarLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AgregarLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AgregarLote.ForeColor = System.Drawing.Color.White
        Me.btn_AgregarLote.Location = New System.Drawing.Point(0, 0)
        Me.btn_AgregarLote.Name = "btn_AgregarLote"
        Me.btn_AgregarLote.Size = New System.Drawing.Size(132, 65)
        Me.btn_AgregarLote.TabIndex = 7
        Me.btn_AgregarLote.Text = "Agregar"
        Me.btn_AgregarLote.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pnMenuAutitos)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.pnBuscar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(929, 588)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Vehiculo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'pnMenuAutitos
        '
        Me.pnMenuAutitos.BackColor = System.Drawing.Color.Bisque
        Me.pnMenuAutitos.Controls.Add(Me.btn_ver)
        Me.pnMenuAutitos.Controls.Add(Me.btListarVehiculo)
        Me.pnMenuAutitos.Controls.Add(Me.btAgregarVehiculo)
        Me.pnMenuAutitos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnMenuAutitos.Location = New System.Drawing.Point(3, 520)
        Me.pnMenuAutitos.Name = "pnMenuAutitos"
        Me.pnMenuAutitos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pnMenuAutitos.Size = New System.Drawing.Size(923, 65)
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
        Me.btn_ver.Location = New System.Drawing.Point(264, 0)
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
        Me.btListarVehiculo.Location = New System.Drawing.Point(132, 0)
        Me.btListarVehiculo.Name = "btListarVehiculo"
        Me.btListarVehiculo.Size = New System.Drawing.Size(132, 65)
        Me.btListarVehiculo.TabIndex = 4
        Me.btListarVehiculo.Text = "Actualizar"
        Me.btListarVehiculo.UseVisualStyleBackColor = True
        '
        'btAgregarVehiculo
        '
        Me.btAgregarVehiculo.BackgroundImage = Global.oop.My.Resources.Resources.boton_buscar
        Me.btAgregarVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btAgregarVehiculo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAgregarVehiculo.Dock = System.Windows.Forms.DockStyle.Left
        Me.btAgregarVehiculo.FlatAppearance.BorderSize = 0
        Me.btAgregarVehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btAgregarVehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btAgregarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAgregarVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAgregarVehiculo.ForeColor = System.Drawing.Color.White
        Me.btAgregarVehiculo.Location = New System.Drawing.Point(0, 0)
        Me.btAgregarVehiculo.Name = "btAgregarVehiculo"
        Me.btAgregarVehiculo.Size = New System.Drawing.Size(132, 65)
        Me.btAgregarVehiculo.TabIndex = 3
        Me.btAgregarVehiculo.Text = "Agregar"
        Me.btAgregarVehiculo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lista_vehiculos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(923, 512)
        Me.Panel1.TabIndex = 3
        '
        'lista_vehiculos
        '
        Me.lista_vehiculos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader8})
        Me.lista_vehiculos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lista_vehiculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lista_vehiculos.FullRowSelect = True
        Me.lista_vehiculos.HideSelection = False
        Me.lista_vehiculos.Location = New System.Drawing.Point(0, 0)
        Me.lista_vehiculos.Name = "lista_vehiculos"
        Me.lista_vehiculos.Size = New System.Drawing.Size(923, 512)
        Me.lista_vehiculos.TabIndex = 0
        Me.lista_vehiculos.UseCompatibleStateImageBehavior = False
        Me.lista_vehiculos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "VIN"
        Me.ColumnHeader1.Width = 168
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Marca"
        Me.ColumnHeader2.Width = 132
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Modelo"
        Me.ColumnHeader3.Width = 133
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Tipo"
        Me.ColumnHeader4.Width = 110
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Color"
        Me.ColumnHeader5.Width = 113
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Fecha Agregado"
        Me.ColumnHeader6.Width = 156
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Status"
        Me.ColumnHeader8.Width = 109
        '
        'pnBuscar
        '
        Me.pnBuscar.BackColor = System.Drawing.Color.Bisque
        Me.pnBuscar.Controls.Add(Me.pnCampoBuscador)
        Me.pnBuscar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnBuscar.Location = New System.Drawing.Point(3, 3)
        Me.pnBuscar.Name = "pnBuscar"
        Me.pnBuscar.Size = New System.Drawing.Size(923, 70)
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
        Me.pnCampoBuscador.Size = New System.Drawing.Size(923, 70)
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
        Me.btBuscarVehiculo.Location = New System.Drawing.Point(737, -57)
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
        Me.txtBuscadorVehiculo.Size = New System.Drawing.Size(590, 28)
        Me.txtBuscadorVehiculo.TabIndex = 0
        '
        'TabVehiculos
        '
        Me.TabVehiculos.Controls.Add(Me.TabPage1)
        Me.TabVehiculos.Controls.Add(Me.TabPage2)
        Me.TabVehiculos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabVehiculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabVehiculos.Location = New System.Drawing.Point(0, 0)
        Me.TabVehiculos.Multiline = True
        Me.TabVehiculos.Name = "TabVehiculos"
        Me.TabVehiculos.SelectedIndex = 0
        Me.TabVehiculos.Size = New System.Drawing.Size(937, 621)
        Me.TabVehiculos.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabVehiculos.TabIndex = 3
        '
        'Vehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 621)
        Me.Controls.Add(Me.TabVehiculos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Vehiculos"
        Me.ShowIcon = False
        Me.Text = "Vehiculos"
        Me.TabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.pnMenuAutitos.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnBuscar.ResumeLayout(False)
        Me.pnCampoBuscador.ResumeLayout(False)
        Me.pnCampoBuscador.PerformLayout()
        Me.TabVehiculos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lista_lotes As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_AgregarLote As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents pnMenuAutitos As Panel
    Friend WithEvents btListarVehiculo As Button
    Friend WithEvents btAgregarVehiculo As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lista_vehiculos As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents pnBuscar As Panel
    Friend WithEvents pnCampoBuscador As Panel
    Friend WithEvents btBuscarVehiculo As Button
    Friend WithEvents txtBuscadorVehiculo As TextBox
    Friend WithEvents TabVehiculos As TabControl
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_ver As Button
    Friend WithEvents btn_verlote As Button
    Friend WithEvents ColumnHeader8 As ColumnHeader
End Class
