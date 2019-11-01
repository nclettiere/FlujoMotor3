<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarLote
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxLoteId = New System.Windows.Forms.TextBox()
        Me.tbxLoteNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RCHtbxDesc = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxPatio = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListaVehiculos = New BrightIdeasSoftware.DataListView()
        Me.btnAgVehiculo = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        CType(Me.ListaVehiculos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(14, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modificar Lote"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(15, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lote ID"
        '
        'tbxLoteId
        '
        Me.tbxLoteId.Enabled = false
        Me.tbxLoteId.Location = New System.Drawing.Point(18, 74)
        Me.tbxLoteId.Name = "tbxLoteId"
        Me.tbxLoteId.Size = New System.Drawing.Size(355, 20)
        Me.tbxLoteId.TabIndex = 2
        '
        'tbxLoteNombre
        '
        Me.tbxLoteNombre.Location = New System.Drawing.Point(18, 127)
        Me.tbxLoteNombre.Name = "tbxLoteNombre"
        Me.tbxLoteNombre.Size = New System.Drawing.Size(355, 20)
        Me.tbxLoteNombre.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(15, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Lote Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(15, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Lote Descripcion"
        '
        'RCHtbxDesc
        '
        Me.RCHtbxDesc.Location = New System.Drawing.Point(18, 181)
        Me.RCHtbxDesc.Name = "RCHtbxDesc"
        Me.RCHtbxDesc.Size = New System.Drawing.Size(355, 94)
        Me.RCHtbxDesc.TabIndex = 6
        Me.RCHtbxDesc.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(15, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Patio"
        '
        'cbxPatio
        '
        Me.cbxPatio.FormattingEnabled = true
        Me.cbxPatio.Location = New System.Drawing.Point(18, 313)
        Me.cbxPatio.Name = "cbxPatio"
        Me.cbxPatio.Size = New System.Drawing.Size(355, 21)
        Me.cbxPatio.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Crimson
        Me.Label6.Location = New System.Drawing.Point(15, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Vehiculos en Lote"
        '
        'ListaVehiculos
        '
        Me.ListaVehiculos.CellEditUseWholeCell = false
        Me.ListaVehiculos.DataSource = Nothing
        Me.ListaVehiculos.Location = New System.Drawing.Point(18, 377)
        Me.ListaVehiculos.Name = "ListaVehiculos"
        Me.ListaVehiculos.ShowGroups = false
        Me.ListaVehiculos.Size = New System.Drawing.Size(355, 132)
        Me.ListaVehiculos.TabIndex = 10
        Me.ListaVehiculos.UseCompatibleStateImageBehavior = false
        Me.ListaVehiculos.View = System.Windows.Forms.View.Details
        '
        'btnAgVehiculo
        '
        Me.btnAgVehiculo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.btnAgVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAgVehiculo.ForeColor = System.Drawing.Color.Crimson
        Me.btnAgVehiculo.Location = New System.Drawing.Point(18, 516)
        Me.btnAgVehiculo.Name = "btnAgVehiculo"
        Me.btnAgVehiculo.Size = New System.Drawing.Size(178, 30)
        Me.btnAgVehiculo.TabIndex = 11
        Me.btnAgVehiculo.Text = "Agregar Vehiculo"
        Me.btnAgVehiculo.UseVisualStyleBackColor = false
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnQuitar.ForeColor = System.Drawing.Color.Crimson
        Me.btnQuitar.Location = New System.Drawing.Point(202, 516)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(171, 30)
        Me.btnQuitar.TabIndex = 12
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = false
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.Crimson
        Me.btnModificar.Location = New System.Drawing.Point(18, 562)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(355, 44)
        Me.btnModificar.TabIndex = 13
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = false
        '
        'ModificarLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgVehiculo)
        Me.Controls.Add(Me.ListaVehiculos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbxPatio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RCHtbxDesc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbxLoteNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxLoteId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ModificarLote"
        Me.Size = New System.Drawing.Size(391, 631)
        CType(Me.ListaVehiculos,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxLoteId As TextBox
    Friend WithEvents tbxLoteNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RCHtbxDesc As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbxPatio As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ListaVehiculos As BrightIdeasSoftware.DataListView
    Friend WithEvents btnAgVehiculo As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnModificar As Button
End Class
