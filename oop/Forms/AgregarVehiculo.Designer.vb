<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarVehiculo
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
        Me.txtVIN = New System.Windows.Forms.TextBox()
        Me.labVIN = New System.Windows.Forms.Label()
        Me.gpboInformacion = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.labMarca = New System.Windows.Forms.Label()
        Me.labTipo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbx_tipo = New System.Windows.Forms.ComboBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.gpboCaracteristicas = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.labColor = New System.Windows.Forms.Label()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.labAno = New System.Windows.Forms.Label()
        Me.labModelo = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.gpboInformacion.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.gpboCaracteristicas.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtVIN
        '
        Me.txtVIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVIN.BackColor = System.Drawing.Color.White
        Me.txtVIN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVIN.Font = New System.Drawing.Font("Arial Narrow", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVIN.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtVIN.Location = New System.Drawing.Point(204, 16)
        Me.txtVIN.MaxLength = 17
        Me.txtVIN.Name = "txtVIN"
        Me.txtVIN.Size = New System.Drawing.Size(195, 27)
        Me.txtVIN.TabIndex = 2
        '
        'labVIN
        '
        Me.labVIN.AutoSize = True
        Me.labVIN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labVIN.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labVIN.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.labVIN.Location = New System.Drawing.Point(3, 0)
        Me.labVIN.Name = "labVIN"
        Me.labVIN.Size = New System.Drawing.Size(195, 59)
        Me.labVIN.TabIndex = 3
        Me.labVIN.Text = "V.I.N.  :"
        Me.labVIN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gpboInformacion
        '
        Me.gpboInformacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpboInformacion.Controls.Add(Me.TableLayoutPanel1)
        Me.gpboInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gpboInformacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpboInformacion.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.gpboInformacion.Location = New System.Drawing.Point(12, 12)
        Me.gpboInformacion.Name = "gpboInformacion"
        Me.gpboInformacion.Size = New System.Drawing.Size(408, 245)
        Me.gpboInformacion.TabIndex = 4
        Me.gpboInformacion.TabStop = False
        Me.gpboInformacion.Text = "INFORMACION"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblCliente, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.labMarca, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.labTipo, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.labVIN, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCliente, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtMarca, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtVIN, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(402, 217)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblCliente.Location = New System.Drawing.Point(3, 177)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(195, 20)
        Me.lblCliente.TabIndex = 10
        Me.lblCliente.Text = "CLIENTE  :"
        Me.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labMarca
        '
        Me.labMarca.AutoSize = True
        Me.labMarca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labMarca.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labMarca.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.labMarca.Location = New System.Drawing.Point(3, 118)
        Me.labMarca.Name = "labMarca"
        Me.labMarca.Size = New System.Drawing.Size(195, 59)
        Me.labMarca.TabIndex = 6
        Me.labMarca.Text = "MARCA  :"
        Me.labMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labTipo
        '
        Me.labTipo.AutoSize = True
        Me.labTipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labTipo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTipo.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.labTipo.Location = New System.Drawing.Point(3, 59)
        Me.labTipo.Name = "labTipo"
        Me.labTipo.Size = New System.Drawing.Size(195, 59)
        Me.labTipo.TabIndex = 4
        Me.labTipo.Text = "TIPO  :"
        Me.labTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbx_tipo)
        Me.Panel2.Location = New System.Drawing.Point(204, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(195, 42)
        Me.Panel2.TabIndex = 8
        '
        'cbx_tipo
        '
        Me.cbx_tipo.FormattingEnabled = True
        Me.cbx_tipo.Items.AddRange(New Object() {"Auto", "Camion", "SUV", "VAN", "Minivan"})
        Me.cbx_tipo.Location = New System.Drawing.Point(3, 5)
        Me.cbx_tipo.Name = "cbx_tipo"
        Me.cbx_tipo.Size = New System.Drawing.Size(192, 32)
        Me.cbx_tipo.TabIndex = 0
        '
        'txtCliente
        '
        Me.txtCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCliente.Font = New System.Drawing.Font("Arial Narrow", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCliente.Location = New System.Drawing.Point(204, 180)
        Me.txtCliente.MaxLength = 16
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(195, 27)
        Me.txtCliente.TabIndex = 7
        '
        'txtMarca
        '
        Me.txtMarca.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMarca.Font = New System.Drawing.Font("Arial Narrow", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtMarca.Location = New System.Drawing.Point(204, 134)
        Me.txtMarca.MaxLength = 16
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(195, 27)
        Me.txtMarca.TabIndex = 9
        '
        'gpboCaracteristicas
        '
        Me.gpboCaracteristicas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpboCaracteristicas.Controls.Add(Me.TableLayoutPanel2)
        Me.gpboCaracteristicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gpboCaracteristicas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpboCaracteristicas.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.gpboCaracteristicas.Location = New System.Drawing.Point(12, 275)
        Me.gpboCaracteristicas.Name = "gpboCaracteristicas"
        Me.gpboCaracteristicas.Size = New System.Drawing.Size(408, 172)
        Me.gpboCaracteristicas.TabIndex = 5
        Me.gpboCaracteristicas.TabStop = False
        Me.gpboCaracteristicas.Text = "CARACTERISTICAS"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.labColor, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtAno, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.labAno, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.labModelo, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtModelo, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtColor, 1, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 25)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(402, 144)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'labColor
        '
        Me.labColor.AutoSize = True
        Me.labColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labColor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labColor.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.labColor.Location = New System.Drawing.Point(3, 96)
        Me.labColor.Name = "labColor"
        Me.labColor.Size = New System.Drawing.Size(195, 48)
        Me.labColor.TabIndex = 6
        Me.labColor.Text = "COLOR  :"
        Me.labColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAno
        '
        Me.txtAno.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAno.BackColor = System.Drawing.Color.White
        Me.txtAno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAno.Font = New System.Drawing.Font("Arial Narrow", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAno.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtAno.Location = New System.Drawing.Point(204, 58)
        Me.txtAno.MaxLength = 4
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(195, 27)
        Me.txtAno.TabIndex = 5
        '
        'labAno
        '
        Me.labAno.AutoSize = True
        Me.labAno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labAno.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labAno.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.labAno.Location = New System.Drawing.Point(3, 48)
        Me.labAno.Name = "labAno"
        Me.labAno.Size = New System.Drawing.Size(195, 48)
        Me.labAno.TabIndex = 4
        Me.labAno.Text = "AÑO  :"
        Me.labAno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labModelo
        '
        Me.labModelo.AutoSize = True
        Me.labModelo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labModelo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labModelo.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.labModelo.Location = New System.Drawing.Point(3, 0)
        Me.labModelo.Name = "labModelo"
        Me.labModelo.Size = New System.Drawing.Size(195, 48)
        Me.labModelo.TabIndex = 3
        Me.labModelo.Text = "MODELO  :"
        Me.labModelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtModelo
        '
        Me.txtModelo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtModelo.BackColor = System.Drawing.Color.White
        Me.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtModelo.Font = New System.Drawing.Font("Arial Narrow", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtModelo.Location = New System.Drawing.Point(204, 10)
        Me.txtModelo.MaxLength = 32
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(195, 27)
        Me.txtModelo.TabIndex = 2
        '
        'txtColor
        '
        Me.txtColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtColor.Font = New System.Drawing.Font("Arial Narrow", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtColor.Location = New System.Drawing.Point(204, 106)
        Me.txtColor.MaxLength = 16
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(195, 27)
        Me.txtColor.TabIndex = 7
        '
        'btAceptar
        '
        Me.btAceptar.BackgroundImage = Global.oop.My.Resources.Resources.boton_buscar
        Me.btAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAceptar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btAceptar.FlatAppearance.BorderSize = 0
        Me.btAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAceptar.ForeColor = System.Drawing.Color.White
        Me.btAceptar.Location = New System.Drawing.Point(242, 0)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(190, 72)
        Me.btAceptar.TabIndex = 6
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btCancelar)
        Me.Panel1.Controls.Add(Me.btAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 489)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(432, 72)
        Me.Panel1.TabIndex = 6
        '
        'btCancelar
        '
        Me.btCancelar.BackgroundImage = Global.oop.My.Resources.Resources.boton_buscar
        Me.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCancelar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btCancelar.FlatAppearance.BorderSize = 0
        Me.btCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.ForeColor = System.Drawing.Color.White
        Me.btCancelar.Location = New System.Drawing.Point(0, 0)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(190, 72)
        Me.btCancelar.TabIndex = 7
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'AgregarVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(432, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gpboCaracteristicas)
        Me.Controls.Add(Me.gpboInformacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AgregarVehiculo"
        Me.Text = "Agregar Vehiculo"
        Me.gpboInformacion.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.gpboCaracteristicas.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtVIN As TextBox
    Friend WithEvents labVIN As Label
    Friend WithEvents gpboInformacion As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents labMarca As Label
    Friend WithEvents labTipo As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents gpboCaracteristicas As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents labColor As Label
    Friend WithEvents txtAno As TextBox
    Friend WithEvents labAno As Label
    Friend WithEvents labModelo As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtColor As TextBox
    Friend WithEvents btAceptar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btCancelar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbx_tipo As ComboBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents txtMarca As TextBox
End Class
