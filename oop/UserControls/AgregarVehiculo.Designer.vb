﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarVehiculo
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
        Me.btnmod = New System.Windows.Forms.Button()
        Me.btnQuitarLote = New System.Windows.Forms.Button()
        Me.btnremover2 = New System.Windows.Forms.Button()
        Me.btncambiarlote = New System.Windows.Forms.Button()
        Me.VehiculoAno = New System.Windows.Forms.DateTimePicker()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.btnExist = New System.Windows.Forms.Button()
        Me.btnLnew = New System.Windows.Forms.Button()
        Me.lblLotedesc = New System.Windows.Forms.Label()
        Me.lblano = New System.Windows.Forms.Label()
        Me.tbxColor = New System.Windows.Forms.TextBox()
        Me.lblcolor = New System.Windows.Forms.Label()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.tbxModelo = New System.Windows.Forms.TextBox()
        Me.lblmodelo = New System.Windows.Forms.Label()
        Me.tbxMarca = New System.Windows.Forms.TextBox()
        Me.lblmarca = New System.Windows.Forms.Label()
        Me.tbxVin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblmodagr = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkInspeccion = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.SuspendLayout
        '
        'btnmod
        '
        Me.btnmod.BackColor = System.Drawing.Color.DimGray
        Me.btnmod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnmod.ForeColor = System.Drawing.Color.Orange
        Me.btnmod.Location = New System.Drawing.Point(16, 439)
        Me.btnmod.Name = "btnmod"
        Me.btnmod.Size = New System.Drawing.Size(297, 35)
        Me.btnmod.TabIndex = 28
        Me.btnmod.Text = "Modificar"
        Me.btnmod.UseVisualStyleBackColor = false
        Me.btnmod.Visible = false
        '
        'btnQuitarLote
        '
        Me.btnQuitarLote.BackColor = System.Drawing.Color.DimGray
        Me.btnQuitarLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnQuitarLote.ForeColor = System.Drawing.Color.Orange
        Me.btnQuitarLote.Location = New System.Drawing.Point(99, 357)
        Me.btnQuitarLote.Name = "btnQuitarLote"
        Me.btnQuitarLote.Size = New System.Drawing.Size(214, 35)
        Me.btnQuitarLote.TabIndex = 25
        Me.btnQuitarLote.Text = "X Quitar X"
        Me.btnQuitarLote.UseVisualStyleBackColor = false
        Me.btnQuitarLote.Visible = false
        '
        'btnremover2
        '
        Me.btnremover2.BackColor = System.Drawing.Color.DimGray
        Me.btnremover2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnremover2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnremover2.ForeColor = System.Drawing.Color.Orange
        Me.btnremover2.Location = New System.Drawing.Point(209, 357)
        Me.btnremover2.Name = "btnremover2"
        Me.btnremover2.Size = New System.Drawing.Size(104, 35)
        Me.btnremover2.TabIndex = 27
        Me.btnremover2.Text = "X Quitar X"
        Me.btnremover2.UseVisualStyleBackColor = false
        Me.btnremover2.Visible = false
        '
        'btncambiarlote
        '
        Me.btncambiarlote.BackColor = System.Drawing.Color.DimGray
        Me.btncambiarlote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncambiarlote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btncambiarlote.ForeColor = System.Drawing.Color.Orange
        Me.btncambiarlote.Location = New System.Drawing.Point(99, 357)
        Me.btncambiarlote.Name = "btncambiarlote"
        Me.btncambiarlote.Size = New System.Drawing.Size(104, 35)
        Me.btncambiarlote.TabIndex = 26
        Me.btncambiarlote.Text = "Cambiar"
        Me.btncambiarlote.UseVisualStyleBackColor = false
        Me.btncambiarlote.Visible = false
        '
        'VehiculoAno
        '
        Me.VehiculoAno.Location = New System.Drawing.Point(17, 309)
        Me.VehiculoAno.Name = "VehiculoAno"
        Me.VehiculoAno.Size = New System.Drawing.Size(296, 20)
        Me.VehiculoAno.TabIndex = 24
        '
        'cbxTipo
        '
        Me.cbxTipo.FormattingEnabled = true
        Me.cbxTipo.Items.AddRange(New Object() {"Auto", "Camion", "Van", "Minivan", "SUV"})
        Me.cbxTipo.Location = New System.Drawing.Point(16, 222)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(297, 21)
        Me.cbxTipo.TabIndex = 23
        '
        'btnExist
        '
        Me.btnExist.BackColor = System.Drawing.Color.DimGray
        Me.btnExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnExist.ForeColor = System.Drawing.Color.Orange
        Me.btnExist.Location = New System.Drawing.Point(209, 357)
        Me.btnExist.Name = "btnExist"
        Me.btnExist.Size = New System.Drawing.Size(104, 35)
        Me.btnExist.TabIndex = 22
        Me.btnExist.Text = "Existente"
        Me.btnExist.UseVisualStyleBackColor = false
        '
        'btnLnew
        '
        Me.btnLnew.BackColor = System.Drawing.Color.DimGray
        Me.btnLnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnLnew.ForeColor = System.Drawing.Color.Orange
        Me.btnLnew.Location = New System.Drawing.Point(99, 357)
        Me.btnLnew.Name = "btnLnew"
        Me.btnLnew.Size = New System.Drawing.Size(104, 35)
        Me.btnLnew.TabIndex = 21
        Me.btnLnew.Text = "Nuevo"
        Me.btnLnew.UseVisualStyleBackColor = false
        '
        'lblLotedesc
        '
        Me.lblLotedesc.AutoSize = true
        Me.lblLotedesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblLotedesc.ForeColor = System.Drawing.Color.Orange
        Me.lblLotedesc.Location = New System.Drawing.Point(14, 368)
        Me.lblLotedesc.Name = "lblLotedesc"
        Me.lblLotedesc.Size = New System.Drawing.Size(79, 13)
        Me.lblLotedesc.TabIndex = 20
        Me.lblLotedesc.Text = "Lote (Opcional)"
        '
        'lblano
        '
        Me.lblano.AutoSize = true
        Me.lblano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblano.ForeColor = System.Drawing.Color.Orange
        Me.lblano.Location = New System.Drawing.Point(13, 293)
        Me.lblano.Name = "lblano"
        Me.lblano.Size = New System.Drawing.Size(28, 13)
        Me.lblano.TabIndex = 18
        Me.lblano.Text = "Anio"
        '
        'tbxColor
        '
        Me.tbxColor.Location = New System.Drawing.Point(17, 265)
        Me.tbxColor.MaxLength = 24
        Me.tbxColor.Name = "tbxColor"
        Me.tbxColor.Size = New System.Drawing.Size(297, 20)
        Me.tbxColor.TabIndex = 17
        '
        'lblcolor
        '
        Me.lblcolor.AutoSize = true
        Me.lblcolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblcolor.ForeColor = System.Drawing.Color.Orange
        Me.lblcolor.Location = New System.Drawing.Point(14, 248)
        Me.lblcolor.Name = "lblcolor"
        Me.lblcolor.Size = New System.Drawing.Size(31, 13)
        Me.lblcolor.TabIndex = 16
        Me.lblcolor.Text = "Color"
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = true
        Me.lbltipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbltipo.ForeColor = System.Drawing.Color.Orange
        Me.lbltipo.Location = New System.Drawing.Point(14, 205)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(28, 13)
        Me.lbltipo.TabIndex = 14
        Me.lbltipo.Text = "Tipo"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.DimGray
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Orange
        Me.btnAgregar.Location = New System.Drawing.Point(16, 439)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(297, 35)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = false
        '
        'tbxModelo
        '
        Me.tbxModelo.Location = New System.Drawing.Point(17, 175)
        Me.tbxModelo.MaxLength = 24
        Me.tbxModelo.Name = "tbxModelo"
        Me.tbxModelo.Size = New System.Drawing.Size(297, 20)
        Me.tbxModelo.TabIndex = 6
        '
        'lblmodelo
        '
        Me.lblmodelo.AutoSize = true
        Me.lblmodelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblmodelo.ForeColor = System.Drawing.Color.Orange
        Me.lblmodelo.Location = New System.Drawing.Point(14, 158)
        Me.lblmodelo.Name = "lblmodelo"
        Me.lblmodelo.Size = New System.Drawing.Size(42, 13)
        Me.lblmodelo.TabIndex = 5
        Me.lblmodelo.Text = "Modelo"
        '
        'tbxMarca
        '
        Me.tbxMarca.Location = New System.Drawing.Point(17, 124)
        Me.tbxMarca.MaxLength = 24
        Me.tbxMarca.Name = "tbxMarca"
        Me.tbxMarca.Size = New System.Drawing.Size(297, 20)
        Me.tbxMarca.TabIndex = 4
        '
        'lblmarca
        '
        Me.lblmarca.AutoSize = true
        Me.lblmarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblmarca.ForeColor = System.Drawing.Color.Orange
        Me.lblmarca.Location = New System.Drawing.Point(14, 107)
        Me.lblmarca.Name = "lblmarca"
        Me.lblmarca.Size = New System.Drawing.Size(37, 13)
        Me.lblmarca.TabIndex = 3
        Me.lblmarca.Text = "Marca"
        '
        'tbxVin
        '
        Me.tbxVin.Location = New System.Drawing.Point(16, 75)
        Me.tbxVin.MaxLength = 17
        Me.tbxVin.Name = "tbxVin"
        Me.tbxVin.Size = New System.Drawing.Size(297, 20)
        Me.tbxVin.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(13, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "VIN"
        '
        'lblmodagr
        '
        Me.lblmodagr.AutoSize = true
        Me.lblmodagr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblmodagr.ForeColor = System.Drawing.Color.Orange
        Me.lblmodagr.Location = New System.Drawing.Point(13, 18)
        Me.lblmodagr.Name = "lblmodagr"
        Me.lblmodagr.Size = New System.Drawing.Size(131, 20)
        Me.lblmodagr.TabIndex = 0
        Me.lblmodagr.Text = "Agregar Vehiculo"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 490)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.chkInspeccion)
        Me.Panel2.Controls.Add(Me.btnmod)
        Me.Panel2.Controls.Add(Me.btnQuitarLote)
        Me.Panel2.Controls.Add(Me.btnremover2)
        Me.Panel2.Controls.Add(Me.btncambiarlote)
        Me.Panel2.Controls.Add(Me.VehiculoAno)
        Me.Panel2.Controls.Add(Me.cbxTipo)
        Me.Panel2.Controls.Add(Me.btnExist)
        Me.Panel2.Controls.Add(Me.btnLnew)
        Me.Panel2.Controls.Add(Me.lblLotedesc)
        Me.Panel2.Controls.Add(Me.lblano)
        Me.Panel2.Controls.Add(Me.tbxColor)
        Me.Panel2.Controls.Add(Me.lblcolor)
        Me.Panel2.Controls.Add(Me.lbltipo)
        Me.Panel2.Controls.Add(Me.btnAgregar)
        Me.Panel2.Controls.Add(Me.tbxModelo)
        Me.Panel2.Controls.Add(Me.lblmodelo)
        Me.Panel2.Controls.Add(Me.tbxMarca)
        Me.Panel2.Controls.Add(Me.lblmarca)
        Me.Panel2.Controls.Add(Me.tbxVin)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblmodagr)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(322, 490)
        Me.Panel2.TabIndex = 0
        '
        'chkInspeccion
        '
        Me.chkInspeccion.AutoSize = true
        Me.chkInspeccion.Checked = true
        Me.chkInspeccion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkInspeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkInspeccion.ForeColor = System.Drawing.Color.Orange
        Me.chkInspeccion.Location = New System.Drawing.Point(126, 409)
        Me.chkInspeccion.Name = "chkInspeccion"
        Me.chkInspeccion.Size = New System.Drawing.Size(187, 17)
        Me.chkInspeccion.TabIndex = 29
        Me.chkInspeccion.Text = "Crear Inspeccion automaticamente"
        Me.chkInspeccion.UseVisualStyleBackColor = true
        '
        'AgregarVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AgregarVehiculo"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(332, 500)
        Me.Panel1.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents btnmod As Button
    Friend WithEvents btnQuitarLote As Button
    Friend WithEvents btnremover2 As Button
    Friend WithEvents btncambiarlote As Button
    Friend WithEvents VehiculoAno As DateTimePicker
    Friend WithEvents cbxTipo As ComboBox
    Friend WithEvents btnExist As Button
    Friend WithEvents btnLnew As Button
    Friend WithEvents lblLotedesc As Label
    Friend WithEvents lblano As Label
    Friend WithEvents tbxColor As TextBox
    Friend WithEvents lblcolor As Label
    Friend WithEvents lbltipo As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents tbxModelo As TextBox
    Friend WithEvents lblmodelo As Label
    Friend WithEvents tbxMarca As TextBox
    Friend WithEvents lblmarca As Label
    Friend WithEvents tbxVin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblmodagr As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents chkInspeccion As CheckBox
End Class
