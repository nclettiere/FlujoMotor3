<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Agregar_Vehiculillo
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.TableLayoutPanelMain = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.VehiculoAno = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnNuevoLote = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnLoteExistente = New System.Windows.Forms.Button()
        Me.TableLayoutPanelMain.SuspendLayout
        Me.TableLayoutPanel5.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.Panel3.SuspendLayout
        Me.Panel4.SuspendLayout
        Me.SuspendLayout
        '
        'TableLayoutPanelMain
        '
        Me.TableLayoutPanelMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanelMain.ColumnCount = 1
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanelMain.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanelMain.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanelMain.Location = New System.Drawing.Point(8, 8)
        Me.TableLayoutPanelMain.Name = "TableLayoutPanelMain"
        Me.TableLayoutPanelMain.RowCount = 2
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.47205!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.52795!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanelMain.Size = New System.Drawing.Size(529, 483)
        Me.TableLayoutPanelMain.TabIndex = 0
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel5.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel5.Controls.Add(Me.btnAgregar, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btCancelar, 1, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(82, 412)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.Padding = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(364, 67)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.BackColor = System.Drawing.Color.DimGray
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Orange
        Me.btnAgregar.Location = New System.Drawing.Point(33, 8)
        Me.btnAgregar.MaximumSize = New System.Drawing.Size(143, 51)
        Me.btnAgregar.MinimumSize = New System.Drawing.Size(143, 51)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(143, 51)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = false
        '
        'btCancelar
        '
        Me.btCancelar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btCancelar.BackColor = System.Drawing.Color.DimGray
        Me.btCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.btCancelar.FlatAppearance.BorderSize = 0
        Me.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancelar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btCancelar.ForeColor = System.Drawing.Color.Orange
        Me.btCancelar.Location = New System.Drawing.Point(188, 8)
        Me.btCancelar.MaximumSize = New System.Drawing.Size(143, 51)
        Me.btCancelar.MinimumSize = New System.Drawing.Size(143, 51)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(143, 51)
        Me.btCancelar.TabIndex = 1
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = false
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.48948!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.51051!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtColor, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtModelo, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtMarca, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtVin, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbxTipo, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(523, 402)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(3, 359)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 26)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "LOTE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtColor
        '
        Me.txtColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtColor.BackColor = System.Drawing.Color.White
        Me.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtColor.Location = New System.Drawing.Point(158, 302)
        Me.txtColor.Margin = New System.Windows.Forms.Padding(10)
        Me.txtColor.MaxLength = 16
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(355, 22)
        Me.txtColor.TabIndex = 18
        Me.txtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtModelo
        '
        Me.txtModelo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtModelo.BackColor = System.Drawing.Color.White
        Me.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtModelo.Location = New System.Drawing.Point(158, 188)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(10)
        Me.txtModelo.MaxLength = 32
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(355, 22)
        Me.txtModelo.TabIndex = 16
        Me.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMarca
        '
        Me.txtMarca.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtMarca.BackColor = System.Drawing.Color.White
        Me.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMarca.Location = New System.Drawing.Point(158, 131)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(10)
        Me.txtMarca.MaxLength = 16
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(355, 22)
        Me.txtMarca.TabIndex = 15
        Me.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = true
        Me.Label10.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Orange
        Me.Label10.Location = New System.Drawing.Point(3, 300)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 26)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "COLOR"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Orange
        Me.Label8.Location = New System.Drawing.Point(3, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 26)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "AÑO"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Orange
        Me.Label6.Location = New System.Drawing.Point(3, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 26)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "MODELO"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(3, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "MARCA"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(3, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "TIPO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVin
        '
        Me.txtVin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtVin.BackColor = System.Drawing.Color.White
        Me.txtVin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtVin.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtVin.Location = New System.Drawing.Point(158, 17)
        Me.txtVin.Margin = New System.Windows.Forms.Padding(10)
        Me.txtVin.MaxLength = 17
        Me.txtVin.Name = "txtVin"
        Me.txtVin.Size = New System.Drawing.Size(355, 22)
        Me.txtVin.TabIndex = 0
        Me.txtVin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(3, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "V.I.N."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxTipo
        '
        Me.cbxTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbxTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbxTipo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.cbxTipo.FormattingEnabled = true
        Me.cbxTipo.Items.AddRange(New Object() {"Auto", "Camion", "Camioneta", "Mini van", "Van", "SUV"})
        Me.cbxTipo.Location = New System.Drawing.Point(158, 73)
        Me.cbxTipo.Margin = New System.Windows.Forms.Padding(10)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(355, 24)
        Me.cbxTipo.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.VehiculoAno)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(151, 231)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(369, 51)
        Me.Panel1.TabIndex = 21
        '
        'VehiculoAno
        '
        Me.VehiculoAno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.VehiculoAno.CalendarFont = New System.Drawing.Font("Calibri", 13!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.VehiculoAno.CalendarForeColor = System.Drawing.SystemColors.WindowFrame
        Me.VehiculoAno.Font = New System.Drawing.Font("Calibri", 13!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.VehiculoAno.Location = New System.Drawing.Point(7, 15)
        Me.VehiculoAno.Name = "VehiculoAno"
        Me.VehiculoAno.Size = New System.Drawing.Size(355, 29)
        Me.VehiculoAno.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(151, 345)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(369, 54)
        Me.Panel2.TabIndex = 22
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel4, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(369, 54)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnNuevoLote)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(178, 48)
        Me.Panel3.TabIndex = 0
        '
        'btnNuevoLote
        '
        Me.btnNuevoLote.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNuevoLote.BackColor = System.Drawing.Color.DimGray
        Me.btnNuevoLote.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnNuevoLote.FlatAppearance.BorderSize = 0
        Me.btnNuevoLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoLote.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnNuevoLote.ForeColor = System.Drawing.Color.Orange
        Me.btnNuevoLote.Location = New System.Drawing.Point(18, -2)
        Me.btnNuevoLote.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btnNuevoLote.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btnNuevoLote.Name = "btnNuevoLote"
        Me.btnNuevoLote.Size = New System.Drawing.Size(143, 53)
        Me.btnNuevoLote.TabIndex = 21
        Me.btnNuevoLote.Text = "Nuevo Lote"
        Me.btnNuevoLote.UseVisualStyleBackColor = false
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnLoteExistente)
        Me.Panel4.Location = New System.Drawing.Point(187, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(179, 48)
        Me.Panel4.TabIndex = 1
        '
        'btnLoteExistente
        '
        Me.btnLoteExistente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLoteExistente.BackColor = System.Drawing.Color.DimGray
        Me.btnLoteExistente.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnLoteExistente.FlatAppearance.BorderSize = 0
        Me.btnLoteExistente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoteExistente.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnLoteExistente.ForeColor = System.Drawing.Color.Orange
        Me.btnLoteExistente.Location = New System.Drawing.Point(18, -2)
        Me.btnLoteExistente.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btnLoteExistente.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btnLoteExistente.Name = "btnLoteExistente"
        Me.btnLoteExistente.Size = New System.Drawing.Size(143, 53)
        Me.btnLoteExistente.TabIndex = 21
        Me.btnLoteExistente.Text = "Lote Existente"
        Me.btnLoteExistente.UseVisualStyleBackColor = false
        '
        'Agregar_Vehiculillo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.TableLayoutPanelMain)
        Me.Name = "Agregar_Vehiculillo"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(545, 499)
        Me.TableLayoutPanelMain.ResumeLayout(false)
        Me.TableLayoutPanel5.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.Panel3.ResumeLayout(false)
        Me.Panel4.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TableLayoutPanelMain As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtColor As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtVin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxTipo As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents VehiculoAno As DateTimePicker
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnNuevoLote As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnLoteExistente As Button
End Class
