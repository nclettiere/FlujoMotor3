<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Editar_Vehiculillo
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cheBoColor = New System.Windows.Forms.CheckBox()
        Me.cheBoAno = New System.Windows.Forms.CheckBox()
        Me.cheBoModelo = New System.Windows.Forms.CheckBox()
        Me.cheBoMarca = New System.Windows.Forms.CheckBox()
        Me.cheBoTipo = New System.Windows.Forms.CheckBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.coBoTipo = New System.Windows.Forms.ComboBox()
        Me.cheBoVIN = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.TableLayoutPanelMain.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanelMain
        '
        Me.TableLayoutPanelMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanelMain.ColumnCount = 1
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelMain.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanelMain.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanelMain.Location = New System.Drawing.Point(8, 8)
        Me.TableLayoutPanelMain.Name = "TableLayoutPanelMain"
        Me.TableLayoutPanelMain.RowCount = 2
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.47205!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.52795!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMain.Size = New System.Drawing.Size(403, 475)
        Me.TableLayoutPanelMain.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.78237!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.21763!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cheBoColor, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cheBoAno, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cheBoModelo, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cheBoMarca, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cheBoTipo, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtColor, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAno, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtModelo, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtMarca, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtVin, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.coBoTipo, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cheBoVIN, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(397, 395)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'cheBoColor
        '
        Me.cheBoColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cheBoColor.AutoSize = True
        Me.cheBoColor.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cheBoColor.ForeColor = System.Drawing.Color.Orange
        Me.cheBoColor.Location = New System.Drawing.Point(364, 354)
        Me.cheBoColor.Name = "cheBoColor"
        Me.cheBoColor.Size = New System.Drawing.Size(30, 11)
        Me.cheBoColor.TabIndex = 24
        Me.cheBoColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoColor.UseVisualStyleBackColor = True
        '
        'cheBoAno
        '
        Me.cheBoAno.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cheBoAno.AutoSize = True
        Me.cheBoAno.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cheBoAno.ForeColor = System.Drawing.Color.Orange
        Me.cheBoAno.Location = New System.Drawing.Point(364, 287)
        Me.cheBoAno.Name = "cheBoAno"
        Me.cheBoAno.Size = New System.Drawing.Size(30, 11)
        Me.cheBoAno.TabIndex = 23
        Me.cheBoAno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoAno.UseVisualStyleBackColor = True
        '
        'cheBoModelo
        '
        Me.cheBoModelo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cheBoModelo.AutoSize = True
        Me.cheBoModelo.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cheBoModelo.ForeColor = System.Drawing.Color.Orange
        Me.cheBoModelo.Location = New System.Drawing.Point(364, 222)
        Me.cheBoModelo.Name = "cheBoModelo"
        Me.cheBoModelo.Size = New System.Drawing.Size(30, 11)
        Me.cheBoModelo.TabIndex = 22
        Me.cheBoModelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoModelo.UseVisualStyleBackColor = True
        '
        'cheBoMarca
        '
        Me.cheBoMarca.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cheBoMarca.AutoSize = True
        Me.cheBoMarca.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cheBoMarca.ForeColor = System.Drawing.Color.Orange
        Me.cheBoMarca.Location = New System.Drawing.Point(364, 157)
        Me.cheBoMarca.Name = "cheBoMarca"
        Me.cheBoMarca.Size = New System.Drawing.Size(30, 11)
        Me.cheBoMarca.TabIndex = 21
        Me.cheBoMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoMarca.UseVisualStyleBackColor = True
        '
        'cheBoTipo
        '
        Me.cheBoTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cheBoTipo.AutoSize = True
        Me.cheBoTipo.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cheBoTipo.ForeColor = System.Drawing.Color.Orange
        Me.cheBoTipo.Location = New System.Drawing.Point(364, 92)
        Me.cheBoTipo.Name = "cheBoTipo"
        Me.cheBoTipo.Size = New System.Drawing.Size(30, 11)
        Me.cheBoTipo.TabIndex = 20
        Me.cheBoTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoTipo.UseVisualStyleBackColor = True
        '
        'txtColor
        '
        Me.txtColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtColor.BackColor = System.Drawing.Color.White
        Me.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtColor.Enabled = False
        Me.txtColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.Location = New System.Drawing.Point(128, 349)
        Me.txtColor.Margin = New System.Windows.Forms.Padding(10)
        Me.txtColor.MaxLength = 16
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(223, 22)
        Me.txtColor.TabIndex = 18
        '
        'txtAno
        '
        Me.txtAno.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAno.BackColor = System.Drawing.Color.White
        Me.txtAno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAno.Enabled = False
        Me.txtAno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAno.Location = New System.Drawing.Point(128, 281)
        Me.txtAno.Margin = New System.Windows.Forms.Padding(10)
        Me.txtAno.MaxLength = 4
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(223, 22)
        Me.txtAno.TabIndex = 17
        '
        'txtModelo
        '
        Me.txtModelo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtModelo.BackColor = System.Drawing.Color.White
        Me.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtModelo.Enabled = False
        Me.txtModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(128, 216)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(10)
        Me.txtModelo.MaxLength = 32
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(223, 22)
        Me.txtModelo.TabIndex = 16
        '
        'txtMarca
        '
        Me.txtMarca.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMarca.BackColor = System.Drawing.Color.White
        Me.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMarca.Enabled = False
        Me.txtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(128, 151)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(10)
        Me.txtMarca.MaxLength = 16
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(223, 22)
        Me.txtMarca.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Orange
        Me.Label10.Location = New System.Drawing.Point(3, 347)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 26)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "COLOR"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Orange
        Me.Label8.Location = New System.Drawing.Point(3, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 26)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "AÑO"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Orange
        Me.Label6.Location = New System.Drawing.Point(3, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 26)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "MODELO"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(3, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "MARCA"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(3, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "TIPO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVin
        '
        Me.txtVin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVin.BackColor = System.Drawing.Color.White
        Me.txtVin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVin.Enabled = False
        Me.txtVin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVin.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtVin.Location = New System.Drawing.Point(128, 21)
        Me.txtVin.Margin = New System.Windows.Forms.Padding(10)
        Me.txtVin.MaxLength = 17
        Me.txtVin.Name = "txtVin"
        Me.txtVin.Size = New System.Drawing.Size(223, 22)
        Me.txtVin.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "V.I.N."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'coBoTipo
        '
        Me.coBoTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.coBoTipo.Enabled = False
        Me.coBoTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.coBoTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coBoTipo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.coBoTipo.FormattingEnabled = True
        Me.coBoTipo.Items.AddRange(New Object() {"Auto", "Camion", "Camioneta", "Mini van", "Van", "SUV"})
        Me.coBoTipo.Location = New System.Drawing.Point(128, 85)
        Me.coBoTipo.Margin = New System.Windows.Forms.Padding(10)
        Me.coBoTipo.Name = "coBoTipo"
        Me.coBoTipo.Size = New System.Drawing.Size(223, 24)
        Me.coBoTipo.TabIndex = 14
        '
        'cheBoVIN
        '
        Me.cheBoVIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cheBoVIN.AutoSize = True
        Me.cheBoVIN.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoVIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cheBoVIN.ForeColor = System.Drawing.Color.Orange
        Me.cheBoVIN.Location = New System.Drawing.Point(364, 27)
        Me.cheBoVIN.Name = "cheBoVIN"
        Me.cheBoVIN.Size = New System.Drawing.Size(30, 11)
        Me.cheBoVIN.TabIndex = 19
        Me.cheBoVIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheBoVIN.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btAceptar, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btCancelar, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(16, 404)
        Me.TableLayoutPanel2.MaximumSize = New System.Drawing.Size(370, 69)
        Me.TableLayoutPanel2.MinimumSize = New System.Drawing.Size(370, 69)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(370, 69)
        Me.TableLayoutPanel2.TabIndex = 1
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
        Me.btAceptar.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btAceptar.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(143, 53)
        Me.btAceptar.TabIndex = 0
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = False
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
        Me.btCancelar.Location = New System.Drawing.Point(194, 8)
        Me.btCancelar.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btCancelar.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(143, 53)
        Me.btCancelar.TabIndex = 1
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = False
        '
        'Editar_Vehiculillo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.TableLayoutPanelMain)
        Me.Name = "Editar_Vehiculillo"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(419, 491)
        Me.TableLayoutPanelMain.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelMain As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btAceptar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtColor As TextBox
    Friend WithEvents txtAno As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtVin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents coBoTipo As ComboBox
    Friend WithEvents cheBoVIN As CheckBox
    Friend WithEvents cheBoColor As CheckBox
    Friend WithEvents cheBoAno As CheckBox
    Friend WithEvents cheBoModelo As CheckBox
    Friend WithEvents cheBoMarca As CheckBox
    Friend WithEvents cheBoTipo As CheckBox
End Class
