<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InfoLotes
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.lotesito = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btActualizarVehiculo = New System.Windows.Forms.Button()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.btInfoVehiculo = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbxBuscarVin = New System.Windows.Forms.TextBox()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.DataGridViewLotes = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.lotesito.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.TableLayoutPanel3.SuspendLayout
        CType(Me.DataGridViewLotes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.AutoSize = true
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(927, 611)
        Me.Panel1.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.lotesito)
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(70, 18)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(924, 605)
        Me.TabControl1.TabIndex = 0
        '
        'lotesito
        '
        Me.lotesito.BackColor = System.Drawing.Color.Gray
        Me.lotesito.Controls.Add(Me.TableLayoutPanel1)
        Me.lotesito.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lotesito.ForeColor = System.Drawing.Color.Orange
        Me.lotesito.ImageKey = "(ninguno)"
        Me.lotesito.Location = New System.Drawing.Point(4, 22)
        Me.lotesito.Name = "lotesito"
        Me.lotesito.Padding = New System.Windows.Forms.Padding(3)
        Me.lotesito.Size = New System.Drawing.Size(916, 579)
        Me.lotesito.TabIndex = 0
        Me.lotesito.Text = "LOTES"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridViewLotes, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.39093!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.04363!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.56544!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(910, 573)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.btActualizarVehiculo, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnIniciar, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btInfoVehiculo, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(391, 504)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(516, 66)
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
        Me.btActualizarVehiculo.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btActualizarVehiculo.Location = New System.Drawing.Point(186, 8)
        Me.btActualizarVehiculo.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btActualizarVehiculo.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btActualizarVehiculo.Name = "btActualizarVehiculo"
        Me.btActualizarVehiculo.Size = New System.Drawing.Size(143, 53)
        Me.btActualizarVehiculo.TabIndex = 2
        Me.btActualizarVehiculo.Text = "Actualizar"
        Me.btActualizarVehiculo.UseVisualStyleBackColor = false
        '
        'btnIniciar
        '
        Me.btnIniciar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnIniciar.BackColor = System.Drawing.Color.DimGray
        Me.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnIniciar.FlatAppearance.BorderSize = 0
        Me.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnIniciar.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btnIniciar.Location = New System.Drawing.Point(34, 8)
        Me.btnIniciar.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btnIniciar.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(143, 53)
        Me.btnIniciar.TabIndex = 0
        Me.btnIniciar.Text = "Iniciar Viaje"
        Me.btnIniciar.UseVisualStyleBackColor = false
        '
        'btInfoVehiculo
        '
        Me.btInfoVehiculo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btInfoVehiculo.BackColor = System.Drawing.Color.DimGray
        Me.btInfoVehiculo.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btInfoVehiculo.FlatAppearance.BorderSize = 0
        Me.btInfoVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btInfoVehiculo.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btInfoVehiculo.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btInfoVehiculo.Location = New System.Drawing.Point(338, 8)
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
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(904, 65)
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
        Me.tbxBuscarVin.Size = New System.Drawing.Size(700, 27)
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
        Me.btBuscar.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btBuscar.Location = New System.Drawing.Point(733, 12)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(143, 40)
        Me.btBuscar.TabIndex = 2
        Me.btBuscar.Text = "Buscar Lote"
        Me.btBuscar.UseVisualStyleBackColor = false
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
        Me.DataGridViewLotes.Location = New System.Drawing.Point(3, 74)
        Me.DataGridViewLotes.MultiSelect = false
        Me.DataGridViewLotes.Name = "DataGridViewLotes"
        Me.DataGridViewLotes.ReadOnly = true
        Me.DataGridViewLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewLotes.ShowCellToolTips = false
        Me.DataGridViewLotes.ShowEditingIcon = false
        Me.DataGridViewLotes.Size = New System.Drawing.Size(904, 424)
        Me.DataGridViewLotes.TabIndex = 4
        '
        'InfoLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.Panel1)
        Me.Name = "InfoLotes"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(937, 621)
        Me.Panel1.ResumeLayout(false)
        Me.TabControl1.ResumeLayout(false)
        Me.lotesito.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel3.ResumeLayout(false)
        Me.TableLayoutPanel3.PerformLayout
        CType(Me.DataGridViewLotes,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents lotesito As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btActualizarVehiculo As Button
    Friend WithEvents btnIniciar As Button
    Friend WithEvents btInfoVehiculo As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents tbxBuscarVin As TextBox
    Friend WithEvents btBuscar As Button
    Friend WithEvents DataGridViewLotes As DataGridView
End Class
