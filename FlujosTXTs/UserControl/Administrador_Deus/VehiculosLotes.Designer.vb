<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VehiculosLotes
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.btnAparcar = New System.Windows.Forms.Button()
        Me.btnInsp = New System.Windows.Forms.Button()
        Me.btnElim = New System.Windows.Forms.Button()
        Me.btnMngLote = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnLavado = New System.Windows.Forms.Button()
        Me.btnAgrVehculo = New System.Windows.Forms.Button()
        Me.PbQR = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblVin = New System.Windows.Forms.Label()
        Me.lblOpIngresado = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lbllote = New System.Windows.Forms.Label()
        Me.listaVehiculos = New BrightIdeasSoftware.FastDataListView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnquitarv = New System.Windows.Forms.Button()
        Me.btnagvl = New System.Windows.Forms.Button()
        Me.listaLV = New BrightIdeasSoftware.FastDataListView()
        Me.btnEntreado = New System.Windows.Forms.Button()
        Me.btnEntregarT = New System.Windows.Forms.Button()
        Me.btnElimL = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblloteid = New System.Windows.Forms.Label()
        Me.lblopL = New System.Windows.Forms.Label()
        Me.lblLFecha = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListaLotes = New BrightIdeasSoftware.FastDataListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.Panel1.SuspendLayout
        CType(Me.PbQR,System.ComponentModel.ISupportInitialize).BeginInit
        Me.FlowLayoutPanel1.SuspendLayout
        CType(Me.listaVehiculos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage2.SuspendLayout
        Me.Panel2.SuspendLayout
        CType(Me.listaLV,System.ComponentModel.ISupportInitialize).BeginInit
        Me.FlowLayoutPanel2.SuspendLayout
        CType(Me.ListaLotes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(886, 577)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gray
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.listaVehiculos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(878, 551)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Vehiculos"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnVender)
        Me.Panel1.Controls.Add(Me.btnAparcar)
        Me.Panel1.Controls.Add(Me.btnInsp)
        Me.Panel1.Controls.Add(Me.btnElim)
        Me.Panel1.Controls.Add(Me.btnMngLote)
        Me.Panel1.Controls.Add(Me.btnMod)
        Me.Panel1.Controls.Add(Me.btnLavado)
        Me.Panel1.Controls.Add(Me.btnAgrVehculo)
        Me.Panel1.Controls.Add(Me.PbQR)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 217)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(872, 331)
        Me.Panel1.TabIndex = 5
        '
        'btnVender
        '
        Me.btnVender.BackColor = System.Drawing.Color.Gray
        Me.btnVender.Enabled = false
        Me.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVender.ForeColor = System.Drawing.Color.Crimson
        Me.btnVender.Location = New System.Drawing.Point(804, 11)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(111, 34)
        Me.btnVender.TabIndex = 10
        Me.btnVender.Text = "Vender"
        Me.btnVender.UseVisualStyleBackColor = false
        '
        'btnAparcar
        '
        Me.btnAparcar.BackColor = System.Drawing.Color.Gray
        Me.btnAparcar.Enabled = false
        Me.btnAparcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAparcar.ForeColor = System.Drawing.Color.Crimson
        Me.btnAparcar.Location = New System.Drawing.Point(687, 11)
        Me.btnAparcar.Name = "btnAparcar"
        Me.btnAparcar.Size = New System.Drawing.Size(111, 34)
        Me.btnAparcar.TabIndex = 9
        Me.btnAparcar.Text = "Estacionamiento"
        Me.btnAparcar.UseVisualStyleBackColor = false
        '
        'btnInsp
        '
        Me.btnInsp.BackColor = System.Drawing.Color.Gray
        Me.btnInsp.Enabled = false
        Me.btnInsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsp.ForeColor = System.Drawing.Color.Crimson
        Me.btnInsp.Location = New System.Drawing.Point(570, 11)
        Me.btnInsp.Name = "btnInsp"
        Me.btnInsp.Size = New System.Drawing.Size(111, 34)
        Me.btnInsp.TabIndex = 8
        Me.btnInsp.Text = "Inspecciones"
        Me.btnInsp.UseVisualStyleBackColor = false
        '
        'btnElim
        '
        Me.btnElim.BackColor = System.Drawing.Color.Gray
        Me.btnElim.Enabled = false
        Me.btnElim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnElim.ForeColor = System.Drawing.Color.Crimson
        Me.btnElim.Location = New System.Drawing.Point(223, 11)
        Me.btnElim.Name = "btnElim"
        Me.btnElim.Size = New System.Drawing.Size(84, 34)
        Me.btnElim.TabIndex = 3
        Me.btnElim.Text = "Eliminar"
        Me.btnElim.UseVisualStyleBackColor = false
        '
        'btnMngLote
        '
        Me.btnMngLote.BackColor = System.Drawing.Color.Gray
        Me.btnMngLote.Enabled = false
        Me.btnMngLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMngLote.ForeColor = System.Drawing.Color.Crimson
        Me.btnMngLote.Location = New System.Drawing.Point(432, 11)
        Me.btnMngLote.Name = "btnMngLote"
        Me.btnMngLote.Size = New System.Drawing.Size(132, 34)
        Me.btnMngLote.TabIndex = 7
        Me.btnMngLote.Text = "Ingresar/Cambiar Lote"
        Me.btnMngLote.UseVisualStyleBackColor = false
        '
        'btnMod
        '
        Me.btnMod.BackColor = System.Drawing.Color.Gray
        Me.btnMod.Enabled = false
        Me.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMod.ForeColor = System.Drawing.Color.Crimson
        Me.btnMod.Location = New System.Drawing.Point(133, 11)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(84, 34)
        Me.btnMod.TabIndex = 2
        Me.btnMod.Text = "Modificar"
        Me.btnMod.UseVisualStyleBackColor = false
        '
        'btnLavado
        '
        Me.btnLavado.BackColor = System.Drawing.Color.Gray
        Me.btnLavado.Enabled = false
        Me.btnLavado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLavado.ForeColor = System.Drawing.Color.Crimson
        Me.btnLavado.Location = New System.Drawing.Point(327, 11)
        Me.btnLavado.Name = "btnLavado"
        Me.btnLavado.Size = New System.Drawing.Size(99, 34)
        Me.btnLavado.TabIndex = 6
        Me.btnLavado.Text = "Hacer Lavado"
        Me.btnLavado.UseVisualStyleBackColor = false
        '
        'btnAgrVehculo
        '
        Me.btnAgrVehculo.BackColor = System.Drawing.Color.Gray
        Me.btnAgrVehculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgrVehculo.ForeColor = System.Drawing.Color.Crimson
        Me.btnAgrVehculo.Location = New System.Drawing.Point(3, 11)
        Me.btnAgrVehculo.Name = "btnAgrVehculo"
        Me.btnAgrVehculo.Size = New System.Drawing.Size(124, 34)
        Me.btnAgrVehculo.TabIndex = 1
        Me.btnAgrVehculo.Text = "Agregar Vehiculo"
        Me.btnAgrVehculo.UseVisualStyleBackColor = false
        '
        'PbQR
        '
        Me.PbQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbQR.Location = New System.Drawing.Point(397, 51)
        Me.PbQR.Name = "PbQR"
        Me.PbQR.Size = New System.Drawing.Size(250, 250)
        Me.PbQR.TabIndex = 5
        Me.PbQR.TabStop = false
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.DarkGray
        Me.FlowLayoutPanel1.Controls.Add(Me.lblVin)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblOpIngresado)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblFecha)
        Me.FlowLayoutPanel1.Controls.Add(Me.lbllote)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 51)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(330, 261)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'lblVin
        '
        Me.lblVin.AutoSize = true
        Me.lblVin.Location = New System.Drawing.Point(13, 20)
        Me.lblVin.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblVin.Name = "lblVin"
        Me.lblVin.Size = New System.Drawing.Size(25, 13)
        Me.lblVin.TabIndex = 0
        Me.lblVin.Text = "VIN"
        '
        'lblOpIngresado
        '
        Me.lblOpIngresado.AutoSize = true
        Me.lblOpIngresado.Location = New System.Drawing.Point(13, 43)
        Me.lblOpIngresado.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblOpIngresado.Name = "lblOpIngresado"
        Me.lblOpIngresado.Size = New System.Drawing.Size(76, 13)
        Me.lblOpIngresado.TabIndex = 1
        Me.lblOpIngresado.Text = "Ingresado Por:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = true
        Me.lblFecha.Location = New System.Drawing.Point(13, 66)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "Fecha:"
        '
        'lbllote
        '
        Me.lbllote.AutoSize = true
        Me.lbllote.Location = New System.Drawing.Point(13, 89)
        Me.lbllote.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lbllote.Name = "lbllote"
        Me.lbllote.Size = New System.Drawing.Size(122, 13)
        Me.lbllote.TabIndex = 3
        Me.lbllote.Text = "Vendido: NO/SI [Fecha]"
        '
        'listaVehiculos
        '
        Me.listaVehiculos.CellEditUseWholeCell = false
        Me.listaVehiculos.DataSource = Nothing
        Me.listaVehiculos.Dock = System.Windows.Forms.DockStyle.Top
        Me.listaVehiculos.FullRowSelect = true
        Me.listaVehiculos.Location = New System.Drawing.Point(3, 3)
        Me.listaVehiculos.Name = "listaVehiculos"
        Me.listaVehiculos.ShowGroups = false
        Me.listaVehiculos.Size = New System.Drawing.Size(872, 214)
        Me.listaVehiculos.TabIndex = 0
        Me.listaVehiculos.UseCompatibleStateImageBehavior = false
        Me.listaVehiculos.View = System.Windows.Forms.View.Details
        Me.listaVehiculos.VirtualMode = true
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.ListaLotes)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(878, 551)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lotes"
        Me.TabPage2.UseVisualStyleBackColor = true
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.btnquitarv)
        Me.Panel2.Controls.Add(Me.btnagvl)
        Me.Panel2.Controls.Add(Me.listaLV)
        Me.Panel2.Controls.Add(Me.btnEntreado)
        Me.Panel2.Controls.Add(Me.btnEntregarT)
        Me.Panel2.Controls.Add(Me.btnElimL)
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 217)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(872, 331)
        Me.Panel2.TabIndex = 7
        '
        'btnquitarv
        '
        Me.btnquitarv.BackColor = System.Drawing.Color.DimGray
        Me.btnquitarv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnquitarv.ForeColor = System.Drawing.Color.Crimson
        Me.btnquitarv.Location = New System.Drawing.Point(632, 280)
        Me.btnquitarv.Name = "btnquitarv"
        Me.btnquitarv.Size = New System.Drawing.Size(124, 28)
        Me.btnquitarv.TabIndex = 10
        Me.btnquitarv.Text = "Quitar"
        Me.btnquitarv.UseVisualStyleBackColor = false
        '
        'btnagvl
        '
        Me.btnagvl.BackColor = System.Drawing.Color.DimGray
        Me.btnagvl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnagvl.ForeColor = System.Drawing.Color.Crimson
        Me.btnagvl.Location = New System.Drawing.Point(339, 280)
        Me.btnagvl.Name = "btnagvl"
        Me.btnagvl.Size = New System.Drawing.Size(124, 28)
        Me.btnagvl.TabIndex = 9
        Me.btnagvl.Text = "Agregar Vehiculo"
        Me.btnagvl.UseVisualStyleBackColor = false
        '
        'listaLV
        '
        Me.listaLV.CellEditUseWholeCell = false
        Me.listaLV.DataSource = Nothing
        Me.listaLV.FullRowSelect = true
        Me.listaLV.Location = New System.Drawing.Point(339, 60)
        Me.listaLV.Name = "listaLV"
        Me.listaLV.ShowGroups = false
        Me.listaLV.Size = New System.Drawing.Size(567, 214)
        Me.listaLV.TabIndex = 8
        Me.listaLV.UseCompatibleStateImageBehavior = false
        Me.listaLV.View = System.Windows.Forms.View.Details
        Me.listaLV.VirtualMode = true
        '
        'btnEntreado
        '
        Me.btnEntreado.BackColor = System.Drawing.Color.DimGray
        Me.btnEntreado.Enabled = false
        Me.btnEntreado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntreado.ForeColor = System.Drawing.Color.Crimson
        Me.btnEntreado.Location = New System.Drawing.Point(500, 11)
        Me.btnEntreado.Name = "btnEntreado"
        Me.btnEntreado.Size = New System.Drawing.Size(155, 28)
        Me.btnEntreado.TabIndex = 6
        Me.btnEntreado.Text = "Marcar Como Entregado"
        Me.btnEntreado.UseVisualStyleBackColor = false
        '
        'btnEntregarT
        '
        Me.btnEntregarT.BackColor = System.Drawing.Color.DimGray
        Me.btnEntregarT.Enabled = false
        Me.btnEntregarT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntregarT.ForeColor = System.Drawing.Color.Crimson
        Me.btnEntregarT.Location = New System.Drawing.Point(339, 11)
        Me.btnEntregarT.Name = "btnEntregarT"
        Me.btnEntregarT.Size = New System.Drawing.Size(155, 28)
        Me.btnEntregarT.TabIndex = 5
        Me.btnEntregarT.Text = "Entregar a Transportista"
        Me.btnEntregarT.UseVisualStyleBackColor = false
        '
        'btnElimL
        '
        Me.btnElimL.BackColor = System.Drawing.Color.DimGray
        Me.btnElimL.Enabled = false
        Me.btnElimL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnElimL.ForeColor = System.Drawing.Color.Crimson
        Me.btnElimL.Location = New System.Drawing.Point(133, 11)
        Me.btnElimL.Name = "btnElimL"
        Me.btnElimL.Size = New System.Drawing.Size(84, 28)
        Me.btnElimL.TabIndex = 3
        Me.btnElimL.Text = "Eliminar"
        Me.btnElimL.UseVisualStyleBackColor = false
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.DimGray
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.Color.Crimson
        Me.Button8.Location = New System.Drawing.Point(3, 11)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(124, 28)
        Me.Button8.TabIndex = 1
        Me.Button8.Text = "Agregar Lote"
        Me.Button8.UseVisualStyleBackColor = false
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.DarkGray
        Me.FlowLayoutPanel2.Controls.Add(Me.lblloteid)
        Me.FlowLayoutPanel2.Controls.Add(Me.lblopL)
        Me.FlowLayoutPanel2.Controls.Add(Me.lblLFecha)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 40)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(10)
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(330, 234)
        Me.FlowLayoutPanel2.TabIndex = 4
        '
        'lblloteid
        '
        Me.lblloteid.AutoSize = true
        Me.lblloteid.Location = New System.Drawing.Point(13, 20)
        Me.lblloteid.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblloteid.Name = "lblloteid"
        Me.lblloteid.Size = New System.Drawing.Size(37, 13)
        Me.lblloteid.TabIndex = 0
        Me.lblloteid.Text = "LoteId"
        '
        'lblopL
        '
        Me.lblopL.AutoSize = true
        Me.lblopL.Location = New System.Drawing.Point(13, 43)
        Me.lblopL.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblopL.Name = "lblopL"
        Me.lblopL.Size = New System.Drawing.Size(76, 13)
        Me.lblopL.TabIndex = 1
        Me.lblopL.Text = "Ingresado Por:"
        '
        'lblLFecha
        '
        Me.lblLFecha.AutoSize = true
        Me.lblLFecha.Location = New System.Drawing.Point(13, 66)
        Me.lblLFecha.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblLFecha.Name = "lblLFecha"
        Me.lblLFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblLFecha.TabIndex = 2
        Me.lblLFecha.Text = "Fecha:"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.ForeColor = System.Drawing.Color.Crimson
        Me.Label8.Location = New System.Drawing.Point(339, 44)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Vehiculos en lote:"
        '
        'ListaLotes
        '
        Me.ListaLotes.CellEditUseWholeCell = false
        Me.ListaLotes.DataSource = Nothing
        Me.ListaLotes.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListaLotes.FullRowSelect = true
        Me.ListaLotes.Location = New System.Drawing.Point(3, 3)
        Me.ListaLotes.Name = "ListaLotes"
        Me.ListaLotes.ShowGroups = false
        Me.ListaLotes.Size = New System.Drawing.Size(872, 214)
        Me.ListaLotes.TabIndex = 6
        Me.ListaLotes.UseCompatibleStateImageBehavior = false
        Me.ListaLotes.View = System.Windows.Forms.View.Details
        Me.ListaLotes.VirtualMode = true
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Crimson
        Me.Button1.Location = New System.Drawing.Point(515, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 34)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Guardar QR..."
        Me.Button1.UseVisualStyleBackColor = false
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DimGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Crimson
        Me.Button2.Location = New System.Drawing.Point(469, 280)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 28)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Agregar Vehiculo Existente"
        Me.Button2.UseVisualStyleBackColor = false
        '
        'VehiculosLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "VehiculosLotes"
        Me.Size = New System.Drawing.Size(886, 577)
        Me.TabControl1.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        CType(Me.PbQR,System.ComponentModel.ISupportInitialize).EndInit
        Me.FlowLayoutPanel1.ResumeLayout(false)
        Me.FlowLayoutPanel1.PerformLayout
        CType(Me.listaVehiculos,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage2.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        CType(Me.listaLV,System.ComponentModel.ISupportInitialize).EndInit
        Me.FlowLayoutPanel2.ResumeLayout(false)
        Me.FlowLayoutPanel2.PerformLayout
        CType(Me.ListaLotes,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnInsp As Button
    Friend WithEvents btnMngLote As Button
    Friend WithEvents btnLavado As Button
    Friend WithEvents PbQR As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblVin As Label
    Friend WithEvents lblOpIngresado As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lbllote As Label
    Friend WithEvents btnElim As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents btnAgrVehculo As Button
    Friend WithEvents listaVehiculos As BrightIdeasSoftware.FastDataListView
    Friend WithEvents btnAparcar As Button
    Friend WithEvents btnVender As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEntreado As Button
    Friend WithEvents btnEntregarT As Button
    Friend WithEvents btnElimL As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents lblloteid As Label
    Friend WithEvents lblopL As Label
    Friend WithEvents lblLFecha As Label
    Friend WithEvents ListaLotes As BrightIdeasSoftware.FastDataListView
    Friend WithEvents btnquitarv As Button
    Friend WithEvents btnagvl As Button
    Friend WithEvents listaLV As BrightIdeasSoftware.FastDataListView
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
