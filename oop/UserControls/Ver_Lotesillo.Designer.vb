<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ver_Lotesillo
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
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.btCerrar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labId = New System.Windows.Forms.Label()
        Me.labCliente = New System.Windows.Forms.Label()
        Me.labRutaI = New System.Windows.Forms.Label()
        Me.labRutaF = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.riTeBoDescripcion = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridViewVehiculos = New System.Windows.Forms.DataGridView()
        Me.btnEntregar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout
        Me.TableLayoutPanel4.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.TableLayoutPanel3.SuspendLayout
        CType(Me.DataGridViewVehiculos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.27144!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(455, 522)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Controls.Add(Me.btEditar, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btCerrar, 2, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 446)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(449, 69)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'btEditar
        '
        Me.btEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btEditar.BackColor = System.Drawing.Color.DimGray
        Me.btEditar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btEditar.FlatAppearance.BorderSize = 0
        Me.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEditar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btEditar.ForeColor = System.Drawing.Color.Orange
        Me.btEditar.Location = New System.Drawing.Point(3, 8)
        Me.btEditar.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btEditar.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(143, 53)
        Me.btEditar.TabIndex = 2
        Me.btEditar.Text = "Editar"
        Me.btEditar.UseVisualStyleBackColor = false
        '
        'btCerrar
        '
        Me.btCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btCerrar.BackColor = System.Drawing.Color.DimGray
        Me.btCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btCerrar.FlatAppearance.BorderSize = 0
        Me.btCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCerrar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btCerrar.ForeColor = System.Drawing.Color.Orange
        Me.btCerrar.Location = New System.Drawing.Point(301, 8)
        Me.btCerrar.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btCerrar.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btCerrar.Name = "btCerrar"
        Me.btCerrar.Size = New System.Drawing.Size(143, 53)
        Me.btCerrar.TabIndex = 1
        Me.btCerrar.Text = "Cerrar"
        Me.btCerrar.UseVisualStyleBackColor = false
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.16279!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.83721!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.labId, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.labCliente, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.labRutaI, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.labRutaF, 1, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.70208!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.08545!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.54734!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.12702!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(449, 433)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(3, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 26)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "RUTA FINAL"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(3, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(3, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CLIENTE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(3, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "RUTA INICIAL"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labId
        '
        Me.labId.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.labId.AutoSize = true
        Me.labId.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.labId.ForeColor = System.Drawing.Color.Wheat
        Me.labId.Location = New System.Drawing.Point(142, 14)
        Me.labId.Name = "labId"
        Me.labId.Size = New System.Drawing.Size(304, 26)
        Me.labId.TabIndex = 6
        Me.labId.Text = "N/A"
        Me.labId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labCliente
        '
        Me.labCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.labCliente.AutoSize = true
        Me.labCliente.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.labCliente.ForeColor = System.Drawing.Color.Wheat
        Me.labCliente.Location = New System.Drawing.Point(142, 64)
        Me.labCliente.Name = "labCliente"
        Me.labCliente.Size = New System.Drawing.Size(304, 26)
        Me.labCliente.TabIndex = 7
        Me.labCliente.Text = "N/A"
        Me.labCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labRutaI
        '
        Me.labRutaI.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.labRutaI.AutoSize = true
        Me.labRutaI.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.labRutaI.ForeColor = System.Drawing.Color.Wheat
        Me.labRutaI.Location = New System.Drawing.Point(142, 112)
        Me.labRutaI.Name = "labRutaI"
        Me.labRutaI.Size = New System.Drawing.Size(304, 26)
        Me.labRutaI.TabIndex = 8
        Me.labRutaI.Text = "N/A"
        Me.labRutaI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labRutaF
        '
        Me.labRutaF.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.labRutaF.AutoSize = true
        Me.labRutaF.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.labRutaF.ForeColor = System.Drawing.Color.Wheat
        Me.labRutaF.Location = New System.Drawing.Point(142, 278)
        Me.labRutaF.Name = "labRutaF"
        Me.labRutaF.Size = New System.Drawing.Size(304, 26)
        Me.labRutaF.TabIndex = 9
        Me.labRutaF.Text = "N/A"
        Me.labRutaF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Orange
        Me.Label6.Location = New System.Drawing.Point(3, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(483, 26)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "VEHICULOS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(3, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(483, 26)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "DESCRIPCION"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'riTeBoDescripcion
        '
        Me.riTeBoDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.riTeBoDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.riTeBoDescripcion.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.riTeBoDescripcion.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.riTeBoDescripcion.Location = New System.Drawing.Point(7, 45)
        Me.riTeBoDescripcion.Margin = New System.Windows.Forms.Padding(7)
        Me.riTeBoDescripcion.Name = "riTeBoDescripcion"
        Me.riTeBoDescripcion.Size = New System.Drawing.Size(475, 103)
        Me.riTeBoDescripcion.TabIndex = 4
        Me.riTeBoDescripcion.Text = ""
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(956, 528)
        Me.Panel1.TabIndex = 7
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.riTeBoDescripcion, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.DataGridViewVehiculos, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.btnEntregar, 0, 5)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(464, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 6
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.941176!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.2093!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.511628!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.44186!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(489, 522)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Orange
        Me.Label7.Location = New System.Drawing.Point(3, 430)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(483, 25)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Listo Para Partir?"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridViewVehiculos
        '
        Me.DataGridViewVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVehiculos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewVehiculos.Location = New System.Drawing.Point(3, 186)
        Me.DataGridViewVehiculos.Name = "DataGridViewVehiculos"
        Me.DataGridViewVehiculos.ReadOnly = true
        Me.DataGridViewVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewVehiculos.ShowCellErrors = false
        Me.DataGridViewVehiculos.ShowCellToolTips = false
        Me.DataGridViewVehiculos.ShowEditingIcon = false
        Me.DataGridViewVehiculos.ShowRowErrors = false
        Me.DataGridViewVehiculos.Size = New System.Drawing.Size(483, 241)
        Me.DataGridViewVehiculos.TabIndex = 6
        '
        'btnEntregar
        '
        Me.btnEntregar.BackColor = System.Drawing.Color.DimGray
        Me.btnEntregar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEntregar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnEntregar.FlatAppearance.BorderSize = 0
        Me.btnEntregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntregar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnEntregar.ForeColor = System.Drawing.Color.Orange
        Me.btnEntregar.Location = New System.Drawing.Point(3, 458)
        Me.btnEntregar.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btnEntregar.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btnEntregar.Name = "btnEntregar"
        Me.btnEntregar.Size = New System.Drawing.Size(143, 53)
        Me.btnEntregar.TabIndex = 8
        Me.btnEntregar.Text = "Entregar"
        Me.btnEntregar.UseVisualStyleBackColor = false
        '
        'Ver_Lotesillo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Ver_Lotesillo"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(972, 544)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel4.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.TableLayoutPanel3.ResumeLayout(false)
        Me.TableLayoutPanel3.PerformLayout
        CType(Me.DataGridViewVehiculos,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents labId As Label
    Friend WithEvents labCliente As Label
    Friend WithEvents labRutaI As Label
    Friend WithEvents labRutaF As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents riTeBoDescripcion As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btCerrar As Button
    Friend WithEvents btEditar As Button
    Friend WithEvents DataGridViewVehiculos As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents btnEntregar As Button
End Class
