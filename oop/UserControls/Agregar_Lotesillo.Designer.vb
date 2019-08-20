<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Lotesillo
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtRutaFinal = New System.Windows.Forms.TextBox()
        Me.txtRutaInicial = New System.Windows.Forms.TextBox()
        Me.btSeleccionarCliente = New System.Windows.Forms.Button()
        Me.btSeleccionarVehiculo = New System.Windows.Forms.Button()
        Me.labRutaF = New System.Windows.Forms.Label()
        Me.labRutaI = New System.Windows.Forms.Label()
        Me.labClientes = New System.Windows.Forms.Label()
        Me.labDescripcion = New System.Windows.Forms.Label()
        Me.riTeBoDescripcion = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.labVehiculos = New System.Windows.Forms.Label()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout
        Me.TableLayoutPanel3.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.TableLayoutPanel4.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(535, 489)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.63158!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.36842!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(529, 483)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.77135!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.22865!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtRutaFinal, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.txtRutaInicial, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.btSeleccionarCliente, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btSeleccionarVehiculo, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.labRutaF, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.labRutaI, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.labClientes, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.labDescripcion, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.riTeBoDescripcion, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.238806!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.63184!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.89055!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.14428!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.31915!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.31915!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(523, 402)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'txtRutaFinal
        '
        Me.txtRutaFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtRutaFinal.BackColor = System.Drawing.Color.White
        Me.txtRutaFinal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRutaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtRutaFinal.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtRutaFinal.Location = New System.Drawing.Point(223, 359)
        Me.txtRutaFinal.Margin = New System.Windows.Forms.Padding(10)
        Me.txtRutaFinal.MaxLength = 17
        Me.txtRutaFinal.Name = "txtRutaFinal"
        Me.txtRutaFinal.Size = New System.Drawing.Size(290, 22)
        Me.txtRutaFinal.TabIndex = 22
        Me.txtRutaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRutaInicial
        '
        Me.txtRutaInicial.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtRutaInicial.BackColor = System.Drawing.Color.White
        Me.txtRutaInicial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRutaInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtRutaInicial.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtRutaInicial.Location = New System.Drawing.Point(223, 296)
        Me.txtRutaInicial.Margin = New System.Windows.Forms.Padding(10)
        Me.txtRutaInicial.MaxLength = 17
        Me.txtRutaInicial.Name = "txtRutaInicial"
        Me.txtRutaInicial.Size = New System.Drawing.Size(290, 22)
        Me.txtRutaInicial.TabIndex = 21
        Me.txtRutaInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btSeleccionarCliente
        '
        Me.btSeleccionarCliente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btSeleccionarCliente.BackColor = System.Drawing.Color.DimGray
        Me.btSeleccionarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btSeleccionarCliente.FlatAppearance.BorderSize = 0
        Me.btSeleccionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSeleccionarCliente.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btSeleccionarCliente.ForeColor = System.Drawing.Color.Orange
        Me.btSeleccionarCliente.Location = New System.Drawing.Point(296, 209)
        Me.btSeleccionarCliente.Margin = New System.Windows.Forms.Padding(40, 5, 40, 5)
        Me.btSeleccionarCliente.Name = "btSeleccionarCliente"
        Me.btSeleccionarCliente.Size = New System.Drawing.Size(143, 51)
        Me.btSeleccionarCliente.TabIndex = 20
        Me.btSeleccionarCliente.Text = "Seleccionar"
        Me.btSeleccionarCliente.UseVisualStyleBackColor = false
        '
        'btSeleccionarVehiculo
        '
        Me.btSeleccionarVehiculo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btSeleccionarVehiculo.BackColor = System.Drawing.Color.DimGray
        Me.btSeleccionarVehiculo.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btSeleccionarVehiculo.FlatAppearance.BorderSize = 0
        Me.btSeleccionarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSeleccionarVehiculo.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btSeleccionarVehiculo.ForeColor = System.Drawing.Color.Orange
        Me.btSeleccionarVehiculo.Location = New System.Drawing.Point(296, 122)
        Me.btSeleccionarVehiculo.Margin = New System.Windows.Forms.Padding(40, 5, 40, 5)
        Me.btSeleccionarVehiculo.Name = "btSeleccionarVehiculo"
        Me.btSeleccionarVehiculo.Size = New System.Drawing.Size(143, 51)
        Me.btSeleccionarVehiculo.TabIndex = 19
        Me.btSeleccionarVehiculo.Text = "Seleccionar"
        Me.btSeleccionarVehiculo.UseVisualStyleBackColor = false
        '
        'labRutaF
        '
        Me.labRutaF.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.labRutaF.AutoSize = true
        Me.labRutaF.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.labRutaF.ForeColor = System.Drawing.Color.Orange
        Me.labRutaF.Location = New System.Drawing.Point(3, 357)
        Me.labRutaF.Name = "labRutaF"
        Me.labRutaF.Size = New System.Drawing.Size(207, 26)
        Me.labRutaF.TabIndex = 16
        Me.labRutaF.Text = "RUTA FINAL"
        Me.labRutaF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labRutaI
        '
        Me.labRutaI.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.labRutaI.AutoSize = true
        Me.labRutaI.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.labRutaI.ForeColor = System.Drawing.Color.Orange
        Me.labRutaI.Location = New System.Drawing.Point(3, 294)
        Me.labRutaI.Name = "labRutaI"
        Me.labRutaI.Size = New System.Drawing.Size(207, 26)
        Me.labRutaI.TabIndex = 10
        Me.labRutaI.Text = "RUTA INICIAL"
        Me.labRutaI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labClientes
        '
        Me.labClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.labClientes.AutoSize = true
        Me.labClientes.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.labClientes.ForeColor = System.Drawing.Color.Orange
        Me.labClientes.Location = New System.Drawing.Point(3, 221)
        Me.labClientes.Name = "labClientes"
        Me.labClientes.Size = New System.Drawing.Size(207, 26)
        Me.labClientes.TabIndex = 8
        Me.labClientes.Text = "CLIENTES"
        Me.labClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labDescripcion
        '
        Me.labDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.labDescripcion.AutoSize = true
        Me.labDescripcion.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.labDescripcion.ForeColor = System.Drawing.Color.Orange
        Me.labDescripcion.Location = New System.Drawing.Point(3, 43)
        Me.labDescripcion.Name = "labDescripcion"
        Me.labDescripcion.Size = New System.Drawing.Size(207, 26)
        Me.labDescripcion.TabIndex = 4
        Me.labDescripcion.Text = "DESCRIPCION"
        Me.labDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'riTeBoDescripcion
        '
        Me.riTeBoDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.riTeBoDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.riTeBoDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.riTeBoDescripcion.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.riTeBoDescripcion.Location = New System.Drawing.Point(223, 19)
        Me.riTeBoDescripcion.Margin = New System.Windows.Forms.Padding(10)
        Me.riTeBoDescripcion.Name = "riTeBoDescripcion"
        Me.riTeBoDescripcion.Size = New System.Drawing.Size(290, 75)
        Me.riTeBoDescripcion.TabIndex = 18
        Me.riTeBoDescripcion.Text = ""
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Controls.Add(Me.btAgregar, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnCancelar, 1, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(96, 411)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(336, 69)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'btAgregar
        '
        Me.btAgregar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btAgregar.BackColor = System.Drawing.Color.DimGray
        Me.btAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btAgregar.FlatAppearance.BorderSize = 0
        Me.btAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAgregar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btAgregar.ForeColor = System.Drawing.Color.Orange
        Me.btAgregar.Location = New System.Drawing.Point(12, 9)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(143, 51)
        Me.btAgregar.TabIndex = 1
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = false
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancelar.BackColor = System.Drawing.Color.DimGray
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Orange
        Me.btnCancelar.Location = New System.Drawing.Point(180, 9)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(143, 51)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = false
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblSelected)
        Me.Panel1.Controls.Add(Me.labVehiculos)
        Me.Panel1.Location = New System.Drawing.Point(3, 124)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 20, 3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 65)
        Me.Panel1.TabIndex = 23
        '
        'labVehiculos
        '
        Me.labVehiculos.Dock = System.Windows.Forms.DockStyle.Top
        Me.labVehiculos.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.labVehiculos.ForeColor = System.Drawing.Color.Orange
        Me.labVehiculos.Location = New System.Drawing.Point(0, 0)
        Me.labVehiculos.Margin = New System.Windows.Forms.Padding(3, 20, 3, 0)
        Me.labVehiculos.Name = "labVehiculos"
        Me.labVehiculos.Size = New System.Drawing.Size(200, 26)
        Me.labVehiculos.TabIndex = 7
        Me.labVehiculos.Text = "VEHICULOS"
        Me.labVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSelected
        '
        Me.lblSelected.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSelected.Font = New System.Drawing.Font("Calibri", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblSelected.ForeColor = System.Drawing.Color.Orange
        Me.lblSelected.Location = New System.Drawing.Point(0, 26)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(200, 17)
        Me.lblSelected.TabIndex = 8
        Me.lblSelected.Text = "0 Seleccionados"
        Me.lblSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Agregar_Lotesillo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Agregar_Lotesillo"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(545, 499)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel3.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.TableLayoutPanel4.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txtRutaFinal As TextBox
    Friend WithEvents txtRutaInicial As TextBox
    Friend WithEvents btSeleccionarCliente As Button
    Friend WithEvents btSeleccionarVehiculo As Button
    Friend WithEvents labRutaF As Label
    Friend WithEvents labRutaI As Label
    Friend WithEvents labClientes As Label
    Friend WithEvents labDescripcion As Label
    Friend WithEvents riTeBoDescripcion As RichTextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btAgregar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSelected As Label
    Friend WithEvents labVehiculos As Label
End Class
