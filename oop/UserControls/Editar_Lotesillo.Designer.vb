<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editar_Lotesillo
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
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtRutaFinal = New System.Windows.Forms.TextBox()
        Me.txtRutaInicial = New System.Windows.Forms.TextBox()
        Me.btSeleccionarCliente = New System.Windows.Forms.Button()
        Me.btSeleccionarVehiculo = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.labRutaF = New System.Windows.Forms.Label()
        Me.labRutaI = New System.Windows.Forms.Label()
        Me.labClientes = New System.Windows.Forms.Label()
        Me.labVehiculos = New System.Windows.Forms.Label()
        Me.labDescripcion = New System.Windows.Forms.Label()
        Me.labID = New System.Windows.Forms.Label()
        Me.riTeBoDescripcion = New System.Windows.Forms.RichTextBox()
        Me.cheBoNombre = New System.Windows.Forms.CheckBox()
        Me.cheBoDescripcion = New System.Windows.Forms.CheckBox()
        Me.cheBoVehiculos = New System.Windows.Forms.CheckBox()
        Me.cheBoClientes = New System.Windows.Forms.CheckBox()
        Me.cheBoRutaI = New System.Windows.Forms.CheckBox()
        Me.cheBoRutaF = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 8)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.63158!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.36842!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(376, 483)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btCancelar, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btAceptar, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 411)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.Padding = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(370, 69)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'btCancelar
        '
        Me.btCancelar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btCancelar.BackColor = System.Drawing.Color.DimGray
        Me.btCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btCancelar.FlatAppearance.BorderSize = 0
        Me.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancelar.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.ForeColor = System.Drawing.Color.Orange
        Me.btCancelar.Location = New System.Drawing.Point(196, 8)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(141, 53)
        Me.btCancelar.TabIndex = 1
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = False
        '
        'btAceptar
        '
        Me.btAceptar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btAceptar.BackColor = System.Drawing.Color.DimGray
        Me.btAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btAceptar.FlatAppearance.BorderSize = 0
        Me.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAceptar.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAceptar.ForeColor = System.Drawing.Color.Orange
        Me.btAceptar.Location = New System.Drawing.Point(33, 8)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(143, 53)
        Me.btAceptar.TabIndex = 0
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.82301!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.17699!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtRutaFinal, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.txtRutaInicial, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.btSeleccionarCliente, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btSeleccionarVehiculo, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtID, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.labRutaF, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.labRutaI, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.labClientes, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.labVehiculos, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.labDescripcion, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.labID, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.riTeBoDescripcion, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cheBoNombre, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cheBoDescripcion, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cheBoVehiculos, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.cheBoClientes, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.cheBoRutaI, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.cheBoRutaF, 2, 5)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.31915!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.83732!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67943!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.31915!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.31915!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.31915!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(370, 402)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'txtRutaFinal
        '
        Me.txtRutaFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRutaFinal.BackColor = System.Drawing.Color.White
        Me.txtRutaFinal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRutaFinal.Enabled = False
        Me.txtRutaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutaFinal.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtRutaFinal.Location = New System.Drawing.Point(148, 359)
        Me.txtRutaFinal.Margin = New System.Windows.Forms.Padding(10)
        Me.txtRutaFinal.MaxLength = 17
        Me.txtRutaFinal.Name = "txtRutaFinal"
        Me.txtRutaFinal.Size = New System.Drawing.Size(190, 22)
        Me.txtRutaFinal.TabIndex = 22
        Me.txtRutaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRutaInicial
        '
        Me.txtRutaInicial.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRutaInicial.BackColor = System.Drawing.Color.White
        Me.txtRutaInicial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRutaInicial.Enabled = False
        Me.txtRutaInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutaInicial.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtRutaInicial.Location = New System.Drawing.Point(148, 296)
        Me.txtRutaInicial.Margin = New System.Windows.Forms.Padding(10)
        Me.txtRutaInicial.MaxLength = 17
        Me.txtRutaInicial.Name = "txtRutaInicial"
        Me.txtRutaInicial.Size = New System.Drawing.Size(190, 22)
        Me.txtRutaInicial.TabIndex = 21
        Me.txtRutaInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btSeleccionarCliente
        '
        Me.btSeleccionarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSeleccionarCliente.BackColor = System.Drawing.Color.DimGray
        Me.btSeleccionarCliente.Enabled = False
        Me.btSeleccionarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btSeleccionarCliente.FlatAppearance.BorderSize = 0
        Me.btSeleccionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSeleccionarCliente.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSeleccionarCliente.ForeColor = System.Drawing.Color.Orange
        Me.btSeleccionarCliente.Location = New System.Drawing.Point(178, 223)
        Me.btSeleccionarCliente.Margin = New System.Windows.Forms.Padding(40, 5, 40, 5)
        Me.btSeleccionarCliente.Name = "btSeleccionarCliente"
        Me.btSeleccionarCliente.Size = New System.Drawing.Size(130, 46)
        Me.btSeleccionarCliente.TabIndex = 20
        Me.btSeleccionarCliente.Text = "Seleccionar"
        Me.btSeleccionarCliente.UseVisualStyleBackColor = False
        '
        'btSeleccionarVehiculo
        '
        Me.btSeleccionarVehiculo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSeleccionarVehiculo.BackColor = System.Drawing.Color.DimGray
        Me.btSeleccionarVehiculo.Enabled = False
        Me.btSeleccionarVehiculo.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btSeleccionarVehiculo.FlatAppearance.BorderSize = 0
        Me.btSeleccionarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSeleccionarVehiculo.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSeleccionarVehiculo.ForeColor = System.Drawing.Color.Orange
        Me.btSeleccionarVehiculo.Location = New System.Drawing.Point(178, 170)
        Me.btSeleccionarVehiculo.Margin = New System.Windows.Forms.Padding(40, 5, 40, 5)
        Me.btSeleccionarVehiculo.Name = "btSeleccionarVehiculo"
        Me.btSeleccionarVehiculo.Size = New System.Drawing.Size(130, 41)
        Me.btSeleccionarVehiculo.TabIndex = 19
        Me.btSeleccionarVehiculo.Text = "Seleccionar"
        Me.btSeleccionarVehiculo.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtID.BackColor = System.Drawing.Color.White
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtID.Location = New System.Drawing.Point(148, 19)
        Me.txtID.Margin = New System.Windows.Forms.Padding(10)
        Me.txtID.MaxLength = 17
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(190, 22)
        Me.txtID.TabIndex = 17
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labRutaF
        '
        Me.labRutaF.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labRutaF.AutoSize = True
        Me.labRutaF.Enabled = False
        Me.labRutaF.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labRutaF.ForeColor = System.Drawing.Color.Orange
        Me.labRutaF.Location = New System.Drawing.Point(3, 357)
        Me.labRutaF.Name = "labRutaF"
        Me.labRutaF.Size = New System.Drawing.Size(132, 26)
        Me.labRutaF.TabIndex = 16
        Me.labRutaF.Text = "RUTA FINAL"
        Me.labRutaF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labRutaI
        '
        Me.labRutaI.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labRutaI.AutoSize = True
        Me.labRutaI.Enabled = False
        Me.labRutaI.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labRutaI.ForeColor = System.Drawing.Color.Orange
        Me.labRutaI.Location = New System.Drawing.Point(3, 294)
        Me.labRutaI.Name = "labRutaI"
        Me.labRutaI.Size = New System.Drawing.Size(132, 26)
        Me.labRutaI.TabIndex = 10
        Me.labRutaI.Text = "RUTA INICIAL"
        Me.labRutaI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labClientes
        '
        Me.labClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labClientes.AutoSize = True
        Me.labClientes.Enabled = False
        Me.labClientes.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labClientes.ForeColor = System.Drawing.Color.Orange
        Me.labClientes.Location = New System.Drawing.Point(3, 233)
        Me.labClientes.Name = "labClientes"
        Me.labClientes.Size = New System.Drawing.Size(132, 26)
        Me.labClientes.TabIndex = 8
        Me.labClientes.Text = "CLIENTES"
        Me.labClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labVehiculos
        '
        Me.labVehiculos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labVehiculos.AutoSize = True
        Me.labVehiculos.Enabled = False
        Me.labVehiculos.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labVehiculos.ForeColor = System.Drawing.Color.Orange
        Me.labVehiculos.Location = New System.Drawing.Point(3, 177)
        Me.labVehiculos.Name = "labVehiculos"
        Me.labVehiculos.Size = New System.Drawing.Size(132, 26)
        Me.labVehiculos.TabIndex = 6
        Me.labVehiculos.Text = "VEHICULOS"
        Me.labVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labDescripcion
        '
        Me.labDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labDescripcion.AutoSize = True
        Me.labDescripcion.Enabled = False
        Me.labDescripcion.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDescripcion.ForeColor = System.Drawing.Color.Orange
        Me.labDescripcion.Location = New System.Drawing.Point(3, 100)
        Me.labDescripcion.Name = "labDescripcion"
        Me.labDescripcion.Size = New System.Drawing.Size(132, 26)
        Me.labDescripcion.TabIndex = 4
        Me.labDescripcion.Text = "DESCRIPCION"
        Me.labDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labID
        '
        Me.labID.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labID.AutoSize = True
        Me.labID.Enabled = False
        Me.labID.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labID.ForeColor = System.Drawing.Color.Orange
        Me.labID.Location = New System.Drawing.Point(3, 17)
        Me.labID.Name = "labID"
        Me.labID.Size = New System.Drawing.Size(132, 26)
        Me.labID.TabIndex = 2
        Me.labID.Text = "ID"
        Me.labID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'riTeBoDescripcion
        '
        Me.riTeBoDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.riTeBoDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.riTeBoDescripcion.Enabled = False
        Me.riTeBoDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.riTeBoDescripcion.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.riTeBoDescripcion.Location = New System.Drawing.Point(148, 77)
        Me.riTeBoDescripcion.Margin = New System.Windows.Forms.Padding(10)
        Me.riTeBoDescripcion.Name = "riTeBoDescripcion"
        Me.riTeBoDescripcion.Size = New System.Drawing.Size(190, 72)
        Me.riTeBoDescripcion.TabIndex = 18
        Me.riTeBoDescripcion.Text = ""
        '
        'cheBoNombre
        '
        Me.cheBoNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cheBoNombre.AutoSize = True
        Me.cheBoNombre.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cheBoNombre.ForeColor = System.Drawing.Color.Orange
        Me.cheBoNombre.Location = New System.Drawing.Point(351, 25)
        Me.cheBoNombre.Name = "cheBoNombre"
        Me.cheBoNombre.Size = New System.Drawing.Size(16, 11)
        Me.cheBoNombre.TabIndex = 23
        Me.cheBoNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoNombre.UseVisualStyleBackColor = True
        '
        'cheBoDescripcion
        '
        Me.cheBoDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cheBoDescripcion.AutoSize = True
        Me.cheBoDescripcion.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cheBoDescripcion.ForeColor = System.Drawing.Color.Orange
        Me.cheBoDescripcion.Location = New System.Drawing.Point(351, 107)
        Me.cheBoDescripcion.Name = "cheBoDescripcion"
        Me.cheBoDescripcion.Size = New System.Drawing.Size(16, 11)
        Me.cheBoDescripcion.TabIndex = 24
        Me.cheBoDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoDescripcion.UseVisualStyleBackColor = True
        '
        'cheBoVehiculos
        '
        Me.cheBoVehiculos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cheBoVehiculos.AutoSize = True
        Me.cheBoVehiculos.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cheBoVehiculos.ForeColor = System.Drawing.Color.Orange
        Me.cheBoVehiculos.Location = New System.Drawing.Point(351, 185)
        Me.cheBoVehiculos.Name = "cheBoVehiculos"
        Me.cheBoVehiculos.Size = New System.Drawing.Size(16, 11)
        Me.cheBoVehiculos.TabIndex = 25
        Me.cheBoVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoVehiculos.UseVisualStyleBackColor = True
        '
        'cheBoClientes
        '
        Me.cheBoClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cheBoClientes.AutoSize = True
        Me.cheBoClientes.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cheBoClientes.ForeColor = System.Drawing.Color.Orange
        Me.cheBoClientes.Location = New System.Drawing.Point(351, 241)
        Me.cheBoClientes.Name = "cheBoClientes"
        Me.cheBoClientes.Size = New System.Drawing.Size(16, 11)
        Me.cheBoClientes.TabIndex = 26
        Me.cheBoClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoClientes.UseVisualStyleBackColor = True
        '
        'cheBoRutaI
        '
        Me.cheBoRutaI.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cheBoRutaI.AutoSize = True
        Me.cheBoRutaI.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoRutaI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cheBoRutaI.ForeColor = System.Drawing.Color.Orange
        Me.cheBoRutaI.Location = New System.Drawing.Point(351, 302)
        Me.cheBoRutaI.Name = "cheBoRutaI"
        Me.cheBoRutaI.Size = New System.Drawing.Size(16, 11)
        Me.cheBoRutaI.TabIndex = 27
        Me.cheBoRutaI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoRutaI.UseVisualStyleBackColor = True
        '
        'cheBoRutaF
        '
        Me.cheBoRutaF.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cheBoRutaF.AutoSize = True
        Me.cheBoRutaF.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoRutaF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cheBoRutaF.ForeColor = System.Drawing.Color.Orange
        Me.cheBoRutaF.Location = New System.Drawing.Point(351, 364)
        Me.cheBoRutaF.Name = "cheBoRutaF"
        Me.cheBoRutaF.Size = New System.Drawing.Size(16, 11)
        Me.cheBoRutaF.TabIndex = 28
        Me.cheBoRutaF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoRutaF.UseVisualStyleBackColor = True
        '
        'Editar_Lotesillo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Editar_Lotesillo"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(392, 499)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btCancelar As Button
    Friend WithEvents btAceptar As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txtRutaFinal As TextBox
    Friend WithEvents txtRutaInicial As TextBox
    Friend WithEvents btSeleccionarCliente As Button
    Friend WithEvents btSeleccionarVehiculo As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents labRutaF As Label
    Friend WithEvents labRutaI As Label
    Friend WithEvents labClientes As Label
    Friend WithEvents labVehiculos As Label
    Friend WithEvents labDescripcion As Label
    Friend WithEvents labID As Label
    Friend WithEvents riTeBoDescripcion As RichTextBox
    Friend WithEvents cheBoNombre As CheckBox
    Friend WithEvents cheBoDescripcion As CheckBox
    Friend WithEvents cheBoVehiculos As CheckBox
    Friend WithEvents cheBoClientes As CheckBox
    Friend WithEvents cheBoRutaI As CheckBox
    Friend WithEvents cheBoRutaF As CheckBox
End Class
