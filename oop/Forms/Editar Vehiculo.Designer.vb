<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editar_Vehiculo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.gpboCaracteristicas = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.labColor = New System.Windows.Forms.Label()
        Me.labAno = New System.Windows.Forms.Label()
        Me.labModelo = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.cheboModelo = New System.Windows.Forms.CheckBox()
        Me.cheboAnio = New System.Windows.Forms.CheckBox()
        Me.cheboColor = New System.Windows.Forms.CheckBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.gpboInformacion = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.labMarca = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.labTipo = New System.Windows.Forms.Label()
        Me.labVIN = New System.Windows.Forms.Label()
        Me.txtVIN = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.cheboTipo = New System.Windows.Forms.CheckBox()
        Me.cheboVIN = New System.Windows.Forms.CheckBox()
        Me.cheboMarca = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.gpboCaracteristicas.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.gpboInformacion.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btCancelar)
        Me.Panel1.Controls.Add(Me.btAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 471)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(422, 72)
        Me.Panel1.TabIndex = 9
        '
        'btCancelar
        '
        Me.btCancelar.BackgroundImage = Global.oop.My.Resources.Resources.boton_buscar
        Me.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCancelar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btCancelar.FlatAppearance.BorderSize = 0
        Me.btCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancelar.Font = New System.Drawing.Font("Agency FB", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.ForeColor = System.Drawing.Color.White
        Me.btCancelar.Location = New System.Drawing.Point(232, 0)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(190, 72)
        Me.btCancelar.TabIndex = 7
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'btAceptar
        '
        Me.btAceptar.BackgroundImage = Global.oop.My.Resources.Resources.boton_buscar
        Me.btAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAceptar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btAceptar.FlatAppearance.BorderSize = 0
        Me.btAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAceptar.Font = New System.Drawing.Font("Agency FB", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAceptar.ForeColor = System.Drawing.Color.White
        Me.btAceptar.Location = New System.Drawing.Point(0, 0)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(190, 72)
        Me.btAceptar.TabIndex = 6
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'gpboCaracteristicas
        '
        Me.gpboCaracteristicas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpboCaracteristicas.Controls.Add(Me.TableLayoutPanel2)
        Me.gpboCaracteristicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gpboCaracteristicas.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpboCaracteristicas.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.gpboCaracteristicas.Location = New System.Drawing.Point(12, 230)
        Me.gpboCaracteristicas.Name = "gpboCaracteristicas"
        Me.gpboCaracteristicas.Size = New System.Drawing.Size(398, 229)
        Me.gpboCaracteristicas.TabIndex = 8
        Me.gpboCaracteristicas.TabStop = False
        Me.gpboCaracteristicas.Text = "CARACTERISTICAS"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.21891!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.69652!))
        Me.TableLayoutPanel2.Controls.Add(Me.labColor, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.labAno, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.labModelo, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtModelo, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtAno, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.cheboModelo, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cheboAnio, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cheboColor, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtColor, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 26)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(392, 200)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'labColor
        '
        Me.labColor.AutoSize = True
        Me.labColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labColor.Enabled = False
        Me.labColor.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labColor.ForeColor = System.Drawing.Color.Silver
        Me.labColor.Location = New System.Drawing.Point(3, 132)
        Me.labColor.Name = "labColor"
        Me.labColor.Size = New System.Drawing.Size(124, 68)
        Me.labColor.TabIndex = 6
        Me.labColor.Text = "COLOR  :"
        Me.labColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labAno
        '
        Me.labAno.AutoSize = True
        Me.labAno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labAno.Enabled = False
        Me.labAno.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labAno.ForeColor = System.Drawing.Color.Silver
        Me.labAno.Location = New System.Drawing.Point(3, 66)
        Me.labAno.Name = "labAno"
        Me.labAno.Size = New System.Drawing.Size(124, 66)
        Me.labAno.TabIndex = 4
        Me.labAno.Text = "AÑO  :"
        Me.labAno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labModelo
        '
        Me.labModelo.AutoSize = True
        Me.labModelo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labModelo.Enabled = False
        Me.labModelo.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labModelo.ForeColor = System.Drawing.Color.Silver
        Me.labModelo.Location = New System.Drawing.Point(3, 0)
        Me.labModelo.Name = "labModelo"
        Me.labModelo.Size = New System.Drawing.Size(124, 66)
        Me.labModelo.TabIndex = 3
        Me.labModelo.Text = "MODELO  :"
        Me.labModelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtModelo
        '
        Me.txtModelo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtModelo.BackColor = System.Drawing.Color.White
        Me.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtModelo.Enabled = False
        Me.txtModelo.Font = New System.Drawing.Font("Arial Narrow", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(133, 19)
        Me.txtModelo.MaxLength = 32
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(213, 27)
        Me.txtModelo.TabIndex = 2
        '
        'txtAno
        '
        Me.txtAno.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAno.BackColor = System.Drawing.Color.White
        Me.txtAno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAno.Enabled = False
        Me.txtAno.Font = New System.Drawing.Font("Arial Narrow", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAno.Location = New System.Drawing.Point(133, 152)
        Me.txtAno.MaxLength = 4
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(213, 27)
        Me.txtAno.TabIndex = 5
        '
        'cheboModelo
        '
        Me.cheboModelo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cheboModelo.AutoSize = True
        Me.cheboModelo.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheboModelo.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheboModelo.Location = New System.Drawing.Point(352, 26)
        Me.cheboModelo.Name = "cheboModelo"
        Me.cheboModelo.Size = New System.Drawing.Size(37, 14)
        Me.cheboModelo.TabIndex = 10
        Me.cheboModelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheboModelo.UseVisualStyleBackColor = True
        '
        'cheboAnio
        '
        Me.cheboAnio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cheboAnio.AutoSize = True
        Me.cheboAnio.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheboAnio.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheboAnio.Location = New System.Drawing.Point(352, 92)
        Me.cheboAnio.Name = "cheboAnio"
        Me.cheboAnio.Size = New System.Drawing.Size(37, 14)
        Me.cheboAnio.TabIndex = 11
        Me.cheboAnio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheboAnio.UseVisualStyleBackColor = True
        '
        'cheboColor
        '
        Me.cheboColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cheboColor.AutoSize = True
        Me.cheboColor.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheboColor.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheboColor.Location = New System.Drawing.Point(352, 159)
        Me.cheboColor.Name = "cheboColor"
        Me.cheboColor.Size = New System.Drawing.Size(37, 14)
        Me.cheboColor.TabIndex = 12
        Me.cheboColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheboColor.UseVisualStyleBackColor = True
        '
        'txtColor
        '
        Me.txtColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtColor.Enabled = False
        Me.txtColor.Font = New System.Drawing.Font("Arial Narrow", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.Location = New System.Drawing.Point(133, 85)
        Me.txtColor.MaxLength = 16
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(213, 27)
        Me.txtColor.TabIndex = 7
        '
        'gpboInformacion
        '
        Me.gpboInformacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpboInformacion.Controls.Add(Me.TableLayoutPanel1)
        Me.gpboInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gpboInformacion.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpboInformacion.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.gpboInformacion.Location = New System.Drawing.Point(12, 3)
        Me.gpboInformacion.Name = "gpboInformacion"
        Me.gpboInformacion.Size = New System.Drawing.Size(398, 221)
        Me.gpboInformacion.TabIndex = 7
        Me.gpboInformacion.TabStop = False
        Me.gpboInformacion.Text = "INFORMACION"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.61224!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.22449!))
        Me.TableLayoutPanel1.Controls.Add(Me.labMarca, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTipo, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.labTipo, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.labVIN, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtVIN, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtMarca, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cheboTipo, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cheboVIN, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cheboMarca, 2, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 26)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(392, 192)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'labMarca
        '
        Me.labMarca.AutoSize = True
        Me.labMarca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labMarca.Enabled = False
        Me.labMarca.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labMarca.ForeColor = System.Drawing.Color.Silver
        Me.labMarca.Location = New System.Drawing.Point(3, 128)
        Me.labMarca.Name = "labMarca"
        Me.labMarca.Size = New System.Drawing.Size(124, 64)
        Me.labMarca.TabIndex = 6
        Me.labMarca.Text = "MARCA  :"
        Me.labMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTipo
        '
        Me.txtTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTipo.BackColor = System.Drawing.Color.White
        Me.txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTipo.Enabled = False
        Me.txtTipo.Font = New System.Drawing.Font("Arial Narrow", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo.Location = New System.Drawing.Point(133, 82)
        Me.txtTipo.MaxLength = 7
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(211, 27)
        Me.txtTipo.TabIndex = 5
        '
        'labTipo
        '
        Me.labTipo.AutoSize = True
        Me.labTipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labTipo.Enabled = False
        Me.labTipo.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTipo.ForeColor = System.Drawing.Color.Silver
        Me.labTipo.Location = New System.Drawing.Point(3, 64)
        Me.labTipo.Name = "labTipo"
        Me.labTipo.Size = New System.Drawing.Size(124, 64)
        Me.labTipo.TabIndex = 4
        Me.labTipo.Text = "TIPO  :"
        Me.labTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labVIN
        '
        Me.labVIN.AutoSize = True
        Me.labVIN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labVIN.Enabled = False
        Me.labVIN.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labVIN.ForeColor = System.Drawing.Color.Silver
        Me.labVIN.Location = New System.Drawing.Point(3, 0)
        Me.labVIN.Name = "labVIN"
        Me.labVIN.Size = New System.Drawing.Size(124, 64)
        Me.labVIN.TabIndex = 3
        Me.labVIN.Text = "V.I.N.  :"
        Me.labVIN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVIN
        '
        Me.txtVIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVIN.BackColor = System.Drawing.Color.White
        Me.txtVIN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVIN.Enabled = False
        Me.txtVIN.Font = New System.Drawing.Font("Arial Narrow", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVIN.Location = New System.Drawing.Point(133, 18)
        Me.txtVIN.MaxLength = 17
        Me.txtVIN.Name = "txtVIN"
        Me.txtVIN.Size = New System.Drawing.Size(211, 27)
        Me.txtVIN.TabIndex = 2
        '
        'txtMarca
        '
        Me.txtMarca.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMarca.Enabled = False
        Me.txtMarca.Font = New System.Drawing.Font("Arial Narrow", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(133, 146)
        Me.txtMarca.MaxLength = 16
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(211, 27)
        Me.txtMarca.TabIndex = 7
        '
        'cheboTipo
        '
        Me.cheboTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cheboTipo.AutoSize = True
        Me.cheboTipo.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheboTipo.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheboTipo.Location = New System.Drawing.Point(350, 89)
        Me.cheboTipo.Name = "cheboTipo"
        Me.cheboTipo.Size = New System.Drawing.Size(39, 14)
        Me.cheboTipo.TabIndex = 11
        Me.cheboTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheboTipo.UseVisualStyleBackColor = True
        '
        'cheboVIN
        '
        Me.cheboVIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cheboVIN.AutoSize = True
        Me.cheboVIN.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheboVIN.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheboVIN.Location = New System.Drawing.Point(350, 25)
        Me.cheboVIN.Name = "cheboVIN"
        Me.cheboVIN.Size = New System.Drawing.Size(39, 14)
        Me.cheboVIN.TabIndex = 12
        Me.cheboVIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheboVIN.UseVisualStyleBackColor = True
        '
        'cheboMarca
        '
        Me.cheboMarca.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cheboMarca.AutoSize = True
        Me.cheboMarca.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheboMarca.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheboMarca.Location = New System.Drawing.Point(350, 153)
        Me.cheboMarca.Name = "cheboMarca"
        Me.cheboMarca.Size = New System.Drawing.Size(39, 14)
        Me.cheboMarca.TabIndex = 13
        Me.cheboMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cheboMarca.UseVisualStyleBackColor = True
        '
        'Editar_Vehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(422, 543)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gpboCaracteristicas)
        Me.Controls.Add(Me.gpboInformacion)
        Me.Name = "Editar_Vehiculo"
        Me.ShowIcon = False
        Me.Text = "Editar Vehiculo"
        Me.Panel1.ResumeLayout(False)
        Me.gpboCaracteristicas.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.gpboInformacion.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btCancelar As Button
    Friend WithEvents btAceptar As Button
    Friend WithEvents gpboCaracteristicas As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents labColor As Label
    Friend WithEvents txtAno As TextBox
    Friend WithEvents labAno As Label
    Friend WithEvents labModelo As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtColor As TextBox
    Friend WithEvents gpboInformacion As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents labMarca As Label
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents labTipo As Label
    Friend WithEvents labVIN As Label
    Friend WithEvents txtVIN As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents cheboModelo As CheckBox
    Friend WithEvents cheboAnio As CheckBox
    Friend WithEvents cheboColor As CheckBox
    Friend WithEvents cheboTipo As CheckBox
    Friend WithEvents cheboVIN As CheckBox
    Friend WithEvents cheboMarca As CheckBox
End Class
