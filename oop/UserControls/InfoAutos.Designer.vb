<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoAutos
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.autito = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btActualizarVehiculo = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btInfoVehiculo = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbxBuscarVin = New System.Windows.Forms.TextBox()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.DataGridViewVehiculos = New System.Windows.Forms.DataGridView()
        Me.lote = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridViewLotes = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btVerLote = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.autito.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.TableLayoutPanel3.SuspendLayout
        CType(Me.DataGridViewVehiculos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.lote.SuspendLayout
        Me.TableLayoutPanel4.SuspendLayout
        Me.Panel2.SuspendLayout
        CType(Me.DataGridViewLotes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel3.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(927, 611)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.autito)
        Me.TabControl1.Controls.Add(Me.lote)
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(70, 18)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(921, 605)
        Me.TabControl1.TabIndex = 0
        '
        'autito
        '
        Me.autito.BackColor = System.Drawing.Color.Gray
        Me.autito.Controls.Add(Me.TableLayoutPanel1)
        Me.autito.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.autito.ForeColor = System.Drawing.Color.Orange
        Me.autito.ImageKey = "(ninguno)"
        Me.autito.Location = New System.Drawing.Point(4, 22)
        Me.autito.Name = "autito"
        Me.autito.Padding = New System.Windows.Forms.Padding(3)
        Me.autito.Size = New System.Drawing.Size(913, 579)
        Me.autito.TabIndex = 0
        Me.autito.Text = "VEHICULOS"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridViewVehiculos, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.39093!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.04363!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.56544!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(907, 573)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.4887!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.09869!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.btActualizarVehiculo, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnIngresar, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btInfoVehiculo, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 504)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(901, 66)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'btActualizarVehiculo
        '
        Me.btActualizarVehiculo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btActualizarVehiculo.BackColor = System.Drawing.Color.DimGray
        Me.btActualizarVehiculo.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btActualizarVehiculo.FlatAppearance.BorderSize = 0
        Me.btActualizarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btActualizarVehiculo.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btActualizarVehiculo.ForeColor = System.Drawing.Color.Orange
        Me.btActualizarVehiculo.Location = New System.Drawing.Point(362, 8)
        Me.btActualizarVehiculo.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btActualizarVehiculo.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btActualizarVehiculo.Name = "btActualizarVehiculo"
        Me.btActualizarVehiculo.Size = New System.Drawing.Size(143, 53)
        Me.btActualizarVehiculo.TabIndex = 2
        Me.btActualizarVehiculo.Text = "Actualizar"
        Me.btActualizarVehiculo.UseVisualStyleBackColor = false
        '
        'btnIngresar
        '
        Me.btnIngresar.AutoSize = true
        Me.btnIngresar.BackColor = System.Drawing.Color.DimGray
        Me.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnIngresar.FlatAppearance.BorderSize = 0
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnIngresar.ForeColor = System.Drawing.Color.Orange
        Me.btnIngresar.Location = New System.Drawing.Point(33, 8)
        Me.btnIngresar.MaximumSize = New System.Drawing.Size(0, 53)
        Me.btnIngresar.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(162, 53)
        Me.btnIngresar.TabIndex = 0
        Me.btnIngresar.Text = "Ingresar Vehiculos"
        Me.btnIngresar.UseVisualStyleBackColor = false
        '
        'btInfoVehiculo
        '
        Me.btInfoVehiculo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btInfoVehiculo.BackColor = System.Drawing.Color.DimGray
        Me.btInfoVehiculo.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btInfoVehiculo.FlatAppearance.BorderSize = 0
        Me.btInfoVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btInfoVehiculo.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btInfoVehiculo.ForeColor = System.Drawing.Color.Orange
        Me.btInfoVehiculo.Location = New System.Drawing.Point(659, 8)
        Me.btInfoVehiculo.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btInfoVehiculo.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btInfoVehiculo.Name = "btInfoVehiculo"
        Me.btInfoVehiculo.Size = New System.Drawing.Size(143, 53)
        Me.btInfoVehiculo.TabIndex = 1
        Me.btInfoVehiculo.Text = "Informacion"
        Me.btInfoVehiculo.UseVisualStyleBackColor = false
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.13541!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.8646!))
        Me.TableLayoutPanel3.Controls.Add(Me.tbxBuscarVin, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btBuscar, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(901, 65)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'tbxBuscarVin
        '
        Me.tbxBuscarVin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tbxBuscarVin.BackColor = System.Drawing.Color.White
        Me.tbxBuscarVin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxBuscarVin.Font = New System.Drawing.Font("Calibri", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tbxBuscarVin.Location = New System.Drawing.Point(3, 19)
        Me.tbxBuscarVin.Name = "tbxBuscarVin"
        Me.tbxBuscarVin.Size = New System.Drawing.Size(697, 27)
        Me.tbxBuscarVin.TabIndex = 3
        Me.tbxBuscarVin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btBuscar
        '
        Me.btBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btBuscar.BackColor = System.Drawing.Color.DimGray
        Me.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btBuscar.FlatAppearance.BorderSize = 0
        Me.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBuscar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btBuscar.ForeColor = System.Drawing.Color.Orange
        Me.btBuscar.Location = New System.Drawing.Point(730, 12)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(143, 40)
        Me.btBuscar.TabIndex = 2
        Me.btBuscar.Text = "Buscar VIN"
        Me.btBuscar.UseVisualStyleBackColor = false
        '
        'DataGridViewVehiculos
        '
        Me.DataGridViewVehiculos.AllowUserToAddRows = false
        Me.DataGridViewVehiculos.AllowUserToDeleteRows = false
        Me.DataGridViewVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVehiculos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewVehiculos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewVehiculos.EnableHeadersVisualStyles = false
        Me.DataGridViewVehiculos.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridViewVehiculos.Location = New System.Drawing.Point(3, 74)
        Me.DataGridViewVehiculos.MultiSelect = false
        Me.DataGridViewVehiculos.Name = "DataGridViewVehiculos"
        Me.DataGridViewVehiculos.ReadOnly = true
        Me.DataGridViewVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewVehiculos.ShowCellToolTips = false
        Me.DataGridViewVehiculos.ShowEditingIcon = false
        Me.DataGridViewVehiculos.ShowRowErrors = false
        Me.DataGridViewVehiculos.Size = New System.Drawing.Size(901, 424)
        Me.DataGridViewVehiculos.TabIndex = 4
        Me.DataGridViewVehiculos.TabStop = false
        '
        'lote
        '
        Me.lote.BackColor = System.Drawing.Color.Gray
        Me.lote.Controls.Add(Me.TableLayoutPanel4)
        Me.lote.Location = New System.Drawing.Point(4, 22)
        Me.lote.Name = "lote"
        Me.lote.Padding = New System.Windows.Forms.Padding(3)
        Me.lote.Size = New System.Drawing.Size(913, 579)
        Me.lote.TabIndex = 1
        Me.lote.Text = "LOTES"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel4.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel3, 0, 2)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.26062!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.02909!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.376964!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(907, 573)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridViewLotes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(901, 424)
        Me.Panel2.TabIndex = 7
        '
        'DataGridViewLotes
        '
        Me.DataGridViewLotes.AllowUserToAddRows = false
        Me.DataGridViewLotes.AllowUserToDeleteRows = false
        Me.DataGridViewLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewLotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewLotes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewLotes.EnableHeadersVisualStyles = false
        Me.DataGridViewLotes.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridViewLotes.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewLotes.Name = "DataGridViewLotes"
        Me.DataGridViewLotes.ReadOnly = true
        Me.DataGridViewLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewLotes.ShowCellToolTips = false
        Me.DataGridViewLotes.ShowEditingIcon = false
        Me.DataGridViewLotes.Size = New System.Drawing.Size(901, 424)
        Me.DataGridViewLotes.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btVerLote)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 511)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(901, 59)
        Me.Panel3.TabIndex = 8
        '
        'btVerLote
        '
        Me.btVerLote.BackColor = System.Drawing.Color.DimGray
        Me.btVerLote.Dock = System.Windows.Forms.DockStyle.Right
        Me.btVerLote.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btVerLote.FlatAppearance.BorderSize = 0
        Me.btVerLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btVerLote.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btVerLote.ForeColor = System.Drawing.Color.Orange
        Me.btVerLote.Location = New System.Drawing.Point(758, 0)
        Me.btVerLote.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.btVerLote.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btVerLote.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btVerLote.Name = "btVerLote"
        Me.btVerLote.Size = New System.Drawing.Size(143, 53)
        Me.btVerLote.TabIndex = 3
        Me.btVerLote.Text = "Ver"
        Me.btVerLote.UseVisualStyleBackColor = false
        '
        'InfoAutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.Panel1)
        Me.Name = "InfoAutos"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(937, 621)
        Me.Panel1.ResumeLayout(false)
        Me.TabControl1.ResumeLayout(false)
        Me.autito.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.TableLayoutPanel3.ResumeLayout(false)
        Me.TableLayoutPanel3.PerformLayout
        CType(Me.DataGridViewVehiculos,System.ComponentModel.ISupportInitialize).EndInit
        Me.lote.ResumeLayout(false)
        Me.TableLayoutPanel4.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        CType(Me.DataGridViewLotes,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel3.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents autito As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btActualizarVehiculo As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btInfoVehiculo As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents tbxBuscarVin As TextBox
    Friend WithEvents btBuscar As Button
    Friend WithEvents DataGridViewVehiculos As DataGridView
    Friend WithEvents lote As TabPage
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewLotes As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btVerLote As Button
End Class
