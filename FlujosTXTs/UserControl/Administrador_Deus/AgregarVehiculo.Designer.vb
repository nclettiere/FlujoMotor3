<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarVehiculo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnQuitarLote = New System.Windows.Forms.Button()
        Me.VehiculoAno = New System.Windows.Forms.DateTimePicker()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.btnExist = New System.Windows.Forms.Button()
        Me.btnLnew = New System.Windows.Forms.Button()
        Me.lblLotedesc = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbxColor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.tbxModelo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxMarca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxVin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblmodagr = New System.Windows.Forms.Label()
        Me.btncambiarlote = New System.Windows.Forms.Button()
        Me.btnremover2 = New System.Windows.Forms.Button()
        Me.btnmod = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(331, 471)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.btnmod)
        Me.Panel2.Controls.Add(Me.btnQuitarLote)
        Me.Panel2.Controls.Add(Me.btnremover2)
        Me.Panel2.Controls.Add(Me.btncambiarlote)
        Me.Panel2.Controls.Add(Me.VehiculoAno)
        Me.Panel2.Controls.Add(Me.cbxTipo)
        Me.Panel2.Controls.Add(Me.btnExist)
        Me.Panel2.Controls.Add(Me.btnLnew)
        Me.Panel2.Controls.Add(Me.lblLotedesc)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.tbxColor)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btnAgregar)
        Me.Panel2.Controls.Add(Me.tbxModelo)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.tbxMarca)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.tbxVin)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblmodagr)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(331, 471)
        Me.Panel2.TabIndex = 0
        '
        'btnQuitarLote
        '
        Me.btnQuitarLote.BackColor = System.Drawing.Color.DarkGray
        Me.btnQuitarLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnQuitarLote.ForeColor = System.Drawing.Color.Crimson
        Me.btnQuitarLote.Location = New System.Drawing.Point(99, 357)
        Me.btnQuitarLote.Name = "btnQuitarLote"
        Me.btnQuitarLote.Size = New System.Drawing.Size(214, 35)
        Me.btnQuitarLote.TabIndex = 25
        Me.btnQuitarLote.Text = "X Quitar X"
        Me.btnQuitarLote.UseVisualStyleBackColor = false
        Me.btnQuitarLote.Visible = false
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
        Me.btnExist.BackColor = System.Drawing.Color.DarkGray
        Me.btnExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnExist.ForeColor = System.Drawing.Color.Crimson
        Me.btnExist.Location = New System.Drawing.Point(209, 357)
        Me.btnExist.Name = "btnExist"
        Me.btnExist.Size = New System.Drawing.Size(104, 35)
        Me.btnExist.TabIndex = 22
        Me.btnExist.Text = "Existente"
        Me.btnExist.UseVisualStyleBackColor = false
        '
        'btnLnew
        '
        Me.btnLnew.BackColor = System.Drawing.Color.DarkGray
        Me.btnLnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnLnew.ForeColor = System.Drawing.Color.Crimson
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
        Me.lblLotedesc.ForeColor = System.Drawing.Color.Crimson
        Me.lblLotedesc.Location = New System.Drawing.Point(14, 368)
        Me.lblLotedesc.Name = "lblLotedesc"
        Me.lblLotedesc.Size = New System.Drawing.Size(79, 13)
        Me.lblLotedesc.TabIndex = 20
        Me.lblLotedesc.Text = "Lote (Opcional)"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Crimson
        Me.Label7.Location = New System.Drawing.Point(13, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Anio"
        '
        'tbxColor
        '
        Me.tbxColor.Location = New System.Drawing.Point(17, 265)
        Me.tbxColor.MaxLength = 24
        Me.tbxColor.Name = "tbxColor"
        Me.tbxColor.Size = New System.Drawing.Size(297, 20)
        Me.tbxColor.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(14, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Color"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Crimson
        Me.Label6.Location = New System.Drawing.Point(14, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Tipo"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.DarkGray
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Crimson
        Me.btnAgregar.Location = New System.Drawing.Point(16, 422)
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
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(14, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Modelo"
        '
        'tbxMarca
        '
        Me.tbxMarca.Location = New System.Drawing.Point(17, 124)
        Me.tbxMarca.MaxLength = 24
        Me.tbxMarca.Name = "tbxMarca"
        Me.tbxMarca.Size = New System.Drawing.Size(297, 20)
        Me.tbxMarca.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(14, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Marca"
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
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
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
        Me.lblmodagr.ForeColor = System.Drawing.Color.Crimson
        Me.lblmodagr.Location = New System.Drawing.Point(13, 18)
        Me.lblmodagr.Name = "lblmodagr"
        Me.lblmodagr.Size = New System.Drawing.Size(131, 20)
        Me.lblmodagr.TabIndex = 0
        Me.lblmodagr.Text = "Agregar Vehiculo"
        '
        'btncambiarlote
        '
        Me.btncambiarlote.BackColor = System.Drawing.Color.DarkGray
        Me.btncambiarlote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncambiarlote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btncambiarlote.ForeColor = System.Drawing.Color.Crimson
        Me.btncambiarlote.Location = New System.Drawing.Point(99, 357)
        Me.btncambiarlote.Name = "btncambiarlote"
        Me.btncambiarlote.Size = New System.Drawing.Size(104, 35)
        Me.btncambiarlote.TabIndex = 26
        Me.btncambiarlote.Text = "Cambiar"
        Me.btncambiarlote.UseVisualStyleBackColor = false
        Me.btncambiarlote.Visible = false
        '
        'btnremover2
        '
        Me.btnremover2.BackColor = System.Drawing.Color.DarkGray
        Me.btnremover2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnremover2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnremover2.ForeColor = System.Drawing.Color.Crimson
        Me.btnremover2.Location = New System.Drawing.Point(209, 357)
        Me.btnremover2.Name = "btnremover2"
        Me.btnremover2.Size = New System.Drawing.Size(104, 35)
        Me.btnremover2.TabIndex = 27
        Me.btnremover2.Text = "X Quitar X"
        Me.btnremover2.UseVisualStyleBackColor = false
        Me.btnremover2.Visible = false
        '
        'btnmod
        '
        Me.btnmod.BackColor = System.Drawing.Color.DarkGray
        Me.btnmod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnmod.ForeColor = System.Drawing.Color.Crimson
        Me.btnmod.Location = New System.Drawing.Point(16, 422)
        Me.btnmod.Name = "btnmod"
        Me.btnmod.Size = New System.Drawing.Size(297, 35)
        Me.btnmod.TabIndex = 28
        Me.btnmod.Text = "Modificar"
        Me.btnmod.UseVisualStyleBackColor = false
        Me.btnmod.Visible = false
        '
        'AgregarVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AgregarVehiculo"
        Me.Size = New System.Drawing.Size(331, 471)
        Me.Panel1.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnExist As Button
    Friend WithEvents btnLnew As Button
    Friend WithEvents lblLotedesc As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbxColor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents tbxModelo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxMarca As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxVin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblmodagr As Label
    Friend WithEvents cbxTipo As ComboBox
    Friend WithEvents VehiculoAno As DateTimePicker
    Friend WithEvents btnQuitarLote As Button
    Friend WithEvents btnremover2 As Button
    Friend WithEvents btncambiarlote As Button
    Friend WithEvents btnmod As Button
End Class
