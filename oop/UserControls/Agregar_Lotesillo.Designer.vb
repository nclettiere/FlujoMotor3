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
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtRutaFinal = New System.Windows.Forms.TextBox()
        Me.txtRutaInicial = New System.Windows.Forms.TextBox()
        Me.btSeleccionarCliente = New System.Windows.Forms.Button()
        Me.btSeleccionarVehiculo = New System.Windows.Forms.Button()
        Me.txtVin = New System.Windows.Forms.TextBox()
        Me.labRutaF = New System.Windows.Forms.Label()
        Me.labRutaI = New System.Windows.Forms.Label()
        Me.labClientes = New System.Windows.Forms.Label()
        Me.labVehiculos = New System.Windows.Forms.Label()
        Me.labDescripcion = New System.Windows.Forms.Label()
        Me.labNombre = New System.Windows.Forms.Label()
        Me.riTeBoDescripcion = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 8)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.63158!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.36842!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(369, 475)
        Me.TableLayoutPanel1.TabIndex = 0
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
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 404)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.Padding = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(363, 68)
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
        Me.btCancelar.Location = New System.Drawing.Point(189, 8)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(141, 52)
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
        Me.btAceptar.Size = New System.Drawing.Size(143, 52)
        Me.btAceptar.TabIndex = 0
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = False
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
        Me.TableLayoutPanel2.Controls.Add(Me.txtVin, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.labRutaF, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.labRutaI, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.labClientes, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.labVehiculos, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.labDescripcion, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.labNombre, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.riTeBoDescripcion, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.31915!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.40426!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.31915!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.31915!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.31915!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.31915!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(363, 395)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'txtRutaFinal
        '
        Me.txtRutaFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRutaFinal.BackColor = System.Drawing.Color.White
        Me.txtRutaFinal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRutaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutaFinal.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtRutaFinal.Location = New System.Drawing.Point(158, 352)
        Me.txtRutaFinal.Margin = New System.Windows.Forms.Padding(10)
        Me.txtRutaFinal.MaxLength = 17
        Me.txtRutaFinal.Name = "txtRutaFinal"
        Me.txtRutaFinal.Size = New System.Drawing.Size(195, 22)
        Me.txtRutaFinal.TabIndex = 22
        '
        'txtRutaInicial
        '
        Me.txtRutaInicial.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRutaInicial.BackColor = System.Drawing.Color.White
        Me.txtRutaInicial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRutaInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutaInicial.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtRutaInicial.Location = New System.Drawing.Point(158, 291)
        Me.txtRutaInicial.Margin = New System.Windows.Forms.Padding(10)
        Me.txtRutaInicial.MaxLength = 17
        Me.txtRutaInicial.Name = "txtRutaInicial"
        Me.txtRutaInicial.Size = New System.Drawing.Size(195, 22)
        Me.txtRutaInicial.TabIndex = 21
        '
        'btSeleccionarCliente
        '
        Me.btSeleccionarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSeleccionarCliente.BackColor = System.Drawing.Color.DimGray
        Me.btSeleccionarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btSeleccionarCliente.FlatAppearance.BorderSize = 0
        Me.btSeleccionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSeleccionarCliente.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSeleccionarCliente.ForeColor = System.Drawing.Color.Orange
        Me.btSeleccionarCliente.Location = New System.Drawing.Point(188, 219)
        Me.btSeleccionarCliente.Margin = New System.Windows.Forms.Padding(40, 5, 40, 5)
        Me.btSeleccionarCliente.Name = "btSeleccionarCliente"
        Me.btSeleccionarCliente.Size = New System.Drawing.Size(135, 46)
        Me.btSeleccionarCliente.TabIndex = 20
        Me.btSeleccionarCliente.Text = "Seleccionar"
        Me.btSeleccionarCliente.UseVisualStyleBackColor = False
        '
        'btSeleccionarVehiculo
        '
        Me.btSeleccionarVehiculo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSeleccionarVehiculo.BackColor = System.Drawing.Color.DimGray
        Me.btSeleccionarVehiculo.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btSeleccionarVehiculo.FlatAppearance.BorderSize = 0
        Me.btSeleccionarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSeleccionarVehiculo.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSeleccionarVehiculo.ForeColor = System.Drawing.Color.Orange
        Me.btSeleccionarVehiculo.Location = New System.Drawing.Point(188, 159)
        Me.btSeleccionarVehiculo.Margin = New System.Windows.Forms.Padding(40, 5, 40, 5)
        Me.btSeleccionarVehiculo.Name = "btSeleccionarVehiculo"
        Me.btSeleccionarVehiculo.Size = New System.Drawing.Size(135, 46)
        Me.btSeleccionarVehiculo.TabIndex = 19
        Me.btSeleccionarVehiculo.Text = "Seleccionar"
        Me.btSeleccionarVehiculo.UseVisualStyleBackColor = False
        '
        'txtVin
        '
        Me.txtVin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVin.BackColor = System.Drawing.Color.White
        Me.txtVin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVin.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtVin.Location = New System.Drawing.Point(158, 19)
        Me.txtVin.Margin = New System.Windows.Forms.Padding(10)
        Me.txtVin.MaxLength = 17
        Me.txtVin.Name = "txtVin"
        Me.txtVin.Size = New System.Drawing.Size(195, 22)
        Me.txtVin.TabIndex = 17
        '
        'labRutaF
        '
        Me.labRutaF.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labRutaF.AutoSize = True
        Me.labRutaF.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labRutaF.ForeColor = System.Drawing.Color.Orange
        Me.labRutaF.Location = New System.Drawing.Point(3, 350)
        Me.labRutaF.Name = "labRutaF"
        Me.labRutaF.Size = New System.Drawing.Size(142, 26)
        Me.labRutaF.TabIndex = 16
        Me.labRutaF.Text = "RUTA FINAL"
        Me.labRutaF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labRutaI
        '
        Me.labRutaI.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labRutaI.AutoSize = True
        Me.labRutaI.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labRutaI.ForeColor = System.Drawing.Color.Orange
        Me.labRutaI.Location = New System.Drawing.Point(3, 289)
        Me.labRutaI.Name = "labRutaI"
        Me.labRutaI.Size = New System.Drawing.Size(142, 26)
        Me.labRutaI.TabIndex = 10
        Me.labRutaI.Text = "RUTA INICIAL"
        Me.labRutaI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labClientes
        '
        Me.labClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labClientes.AutoSize = True
        Me.labClientes.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labClientes.ForeColor = System.Drawing.Color.Orange
        Me.labClientes.Location = New System.Drawing.Point(3, 229)
        Me.labClientes.Name = "labClientes"
        Me.labClientes.Size = New System.Drawing.Size(142, 26)
        Me.labClientes.TabIndex = 8
        Me.labClientes.Text = "CLIENTES"
        Me.labClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labVehiculos
        '
        Me.labVehiculos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labVehiculos.AutoSize = True
        Me.labVehiculos.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labVehiculos.ForeColor = System.Drawing.Color.Orange
        Me.labVehiculos.Location = New System.Drawing.Point(3, 169)
        Me.labVehiculos.Name = "labVehiculos"
        Me.labVehiculos.Size = New System.Drawing.Size(142, 26)
        Me.labVehiculos.TabIndex = 6
        Me.labVehiculos.Text = "VEHICULOS"
        Me.labVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labDescripcion
        '
        Me.labDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labDescripcion.AutoSize = True
        Me.labDescripcion.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDescripcion.ForeColor = System.Drawing.Color.Orange
        Me.labDescripcion.Location = New System.Drawing.Point(3, 93)
        Me.labDescripcion.Name = "labDescripcion"
        Me.labDescripcion.Size = New System.Drawing.Size(142, 26)
        Me.labDescripcion.TabIndex = 4
        Me.labDescripcion.Text = "DESCRIPCION"
        Me.labDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labNombre
        '
        Me.labNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labNombre.AutoSize = True
        Me.labNombre.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labNombre.ForeColor = System.Drawing.Color.Orange
        Me.labNombre.Location = New System.Drawing.Point(3, 17)
        Me.labNombre.Name = "labNombre"
        Me.labNombre.Size = New System.Drawing.Size(142, 26)
        Me.labNombre.TabIndex = 2
        Me.labNombre.Text = "NOMBRE"
        Me.labNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'riTeBoDescripcion
        '
        Me.riTeBoDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.riTeBoDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.riTeBoDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.riTeBoDescripcion.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.riTeBoDescripcion.Location = New System.Drawing.Point(158, 70)
        Me.riTeBoDescripcion.Margin = New System.Windows.Forms.Padding(10)
        Me.riTeBoDescripcion.Name = "riTeBoDescripcion"
        Me.riTeBoDescripcion.Size = New System.Drawing.Size(195, 72)
        Me.riTeBoDescripcion.TabIndex = 18
        Me.riTeBoDescripcion.Text = ""
        '
        'Agregar_L
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Agregar_L"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(385, 491)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents labRutaI As Label
    Friend WithEvents labClientes As Label
    Friend WithEvents labVehiculos As Label
    Friend WithEvents labDescripcion As Label
    Friend WithEvents labNombre As Label
    Friend WithEvents labRutaF As Label
    Friend WithEvents txtVin As TextBox
    Friend WithEvents riTeBoDescripcion As RichTextBox
    Friend WithEvents btSeleccionarVehiculo As Button
    Friend WithEvents btSeleccionarCliente As Button
    Friend WithEvents txtRutaFinal As TextBox
    Friend WithEvents txtRutaInicial As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btCancelar As Button
    Friend WithEvents btAceptar As Button
End Class
