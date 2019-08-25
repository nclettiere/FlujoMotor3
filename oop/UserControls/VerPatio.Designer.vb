<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerPatio
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
        Me.lote = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridViewVehiculos = New System.Windows.Forms.DataGridView()
        Me.tbxBuscarVin = New System.Windows.Forms.TextBox()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnLavado = New System.Windows.Forms.Button()
        Me.btActualizarVehiculo = New System.Windows.Forms.Button()
        Me.btInfoVehiculo = New System.Windows.Forms.Button()
        Me.autito = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPos = New System.Windows.Forms.Button()
        Me.lote.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.TableLayoutPanel4.SuspendLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel2.SuspendLayout
        CType(Me.DataGridViewVehiculos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanel1.SuspendLayout
        Me.TableLayoutPanel3.SuspendLayout
        Me.Panel4.SuspendLayout
        Me.autito.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'lote
        '
        Me.lote.BackColor = System.Drawing.Color.Gray
        Me.lote.Controls.Add(Me.TableLayoutPanel2)
        Me.lote.Location = New System.Drawing.Point(4, 22)
        Me.lote.Name = "lote"
        Me.lote.Padding = New System.Windows.Forms.Padding(3)
        Me.lote.Size = New System.Drawing.Size(734, 458)
        Me.lote.TabIndex = 1
        Me.lote.Text = "LOTES"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DataGridView1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.39093!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.13274!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.47788!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(728, 452)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.13541!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.8646!))
        Me.TableLayoutPanel4.Controls.Add(Me.TextBox1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Button2, 1, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(722, 50)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBox1.Location = New System.Drawing.Point(3, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(558, 27)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = System.Drawing.Color.DimGray
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Orange
        Me.Button2.Location = New System.Drawing.Point(587, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 40)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Buscar ID"
        Me.Button2.UseVisualStyleBackColor = false
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.EnableHeadersVisualStyles = false
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.Location = New System.Drawing.Point(3, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = true
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellToolTips = false
        Me.DataGridView1.ShowEditingIcon = false
        Me.DataGridView1.Size = New System.Drawing.Size(722, 310)
        Me.DataGridView1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 375)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(722, 74)
        Me.Panel2.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.BackColor = System.Drawing.Color.DimGray
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Orange
        Me.Button3.Location = New System.Drawing.Point(289, 11)
        Me.Button3.MaximumSize = New System.Drawing.Size(143, 53)
        Me.Button3.MinimumSize = New System.Drawing.Size(143, 53)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(143, 53)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Hacer Lavado"
        Me.Button3.UseVisualStyleBackColor = false
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.BackColor = System.Drawing.Color.DimGray
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Orange
        Me.Button4.Location = New System.Drawing.Point(103, 11)
        Me.Button4.MaximumSize = New System.Drawing.Size(143, 53)
        Me.Button4.MinimumSize = New System.Drawing.Size(143, 53)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(143, 53)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Actualizar"
        Me.Button4.UseVisualStyleBackColor = false
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.BackColor = System.Drawing.Color.DimGray
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Orange
        Me.Button5.Location = New System.Drawing.Point(476, 11)
        Me.Button5.MaximumSize = New System.Drawing.Size(143, 53)
        Me.Button5.MinimumSize = New System.Drawing.Size(143, 53)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(143, 53)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Posicion"
        Me.Button5.UseVisualStyleBackColor = false
        '
        'DataGridViewVehiculos
        '
        Me.DataGridViewVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVehiculos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewVehiculos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewVehiculos.EnableHeadersVisualStyles = false
        Me.DataGridViewVehiculos.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridViewVehiculos.Location = New System.Drawing.Point(3, 59)
        Me.DataGridViewVehiculos.Name = "DataGridViewVehiculos"
        Me.DataGridViewVehiculos.ReadOnly = true
        Me.DataGridViewVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewVehiculos.ShowCellToolTips = false
        Me.DataGridViewVehiculos.ShowEditingIcon = false
        Me.DataGridViewVehiculos.Size = New System.Drawing.Size(722, 310)
        Me.DataGridViewVehiculos.TabIndex = 4
        '
        'tbxBuscarVin
        '
        Me.tbxBuscarVin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tbxBuscarVin.BackColor = System.Drawing.Color.White
        Me.tbxBuscarVin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxBuscarVin.Font = New System.Drawing.Font("Calibri", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tbxBuscarVin.Location = New System.Drawing.Point(3, 11)
        Me.tbxBuscarVin.Name = "tbxBuscarVin"
        Me.tbxBuscarVin.Size = New System.Drawing.Size(558, 27)
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
        Me.btBuscar.Location = New System.Drawing.Point(587, 5)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(111, 40)
        Me.btBuscar.TabIndex = 2
        Me.btBuscar.Text = "Buscar VIN"
        Me.btBuscar.UseVisualStyleBackColor = false
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridViewVehiculos, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.39093!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.13274!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.47788!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(728, 452)
        Me.TableLayoutPanel1.TabIndex = 0
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
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(722, 50)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnPos)
        Me.Panel4.Controls.Add(Me.btnLavado)
        Me.Panel4.Controls.Add(Me.btActualizarVehiculo)
        Me.Panel4.Controls.Add(Me.btInfoVehiculo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 375)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(722, 74)
        Me.Panel4.TabIndex = 5
        '
        'btnLavado
        '
        Me.btnLavado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLavado.BackColor = System.Drawing.Color.DimGray
        Me.btnLavado.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnLavado.FlatAppearance.BorderSize = 0
        Me.btnLavado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLavado.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnLavado.ForeColor = System.Drawing.Color.Orange
        Me.btnLavado.Location = New System.Drawing.Point(13, 11)
        Me.btnLavado.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btnLavado.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btnLavado.Name = "btnLavado"
        Me.btnLavado.Size = New System.Drawing.Size(143, 53)
        Me.btnLavado.TabIndex = 6
        Me.btnLavado.Text = "Hacer Lavado"
        Me.btnLavado.UseVisualStyleBackColor = false
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
        Me.btActualizarVehiculo.Location = New System.Drawing.Point(566, 11)
        Me.btActualizarVehiculo.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btActualizarVehiculo.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btActualizarVehiculo.Name = "btActualizarVehiculo"
        Me.btActualizarVehiculo.Size = New System.Drawing.Size(143, 53)
        Me.btActualizarVehiculo.TabIndex = 5
        Me.btActualizarVehiculo.Text = "Actualizar"
        Me.btActualizarVehiculo.UseVisualStyleBackColor = false
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
        Me.btInfoVehiculo.Location = New System.Drawing.Point(311, 11)
        Me.btInfoVehiculo.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btInfoVehiculo.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btInfoVehiculo.Name = "btInfoVehiculo"
        Me.btInfoVehiculo.Size = New System.Drawing.Size(143, 53)
        Me.btInfoVehiculo.TabIndex = 4
        Me.btInfoVehiculo.Text = "Informacion"
        Me.btInfoVehiculo.UseVisualStyleBackColor = false
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
        Me.autito.Size = New System.Drawing.Size(734, 458)
        Me.autito.TabIndex = 0
        Me.autito.Text = "VEHICULOS"
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
        Me.TabControl1.Size = New System.Drawing.Size(742, 484)
        Me.TabControl1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(748, 490)
        Me.Panel1.TabIndex = 1
        '
        'btnPos
        '
        Me.btnPos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPos.BackColor = System.Drawing.Color.DimGray
        Me.btnPos.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnPos.FlatAppearance.BorderSize = 0
        Me.btnPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPos.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnPos.ForeColor = System.Drawing.Color.Orange
        Me.btnPos.Location = New System.Drawing.Point(162, 11)
        Me.btnPos.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btnPos.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btnPos.Name = "btnPos"
        Me.btnPos.Size = New System.Drawing.Size(143, 53)
        Me.btnPos.TabIndex = 7
        Me.btnPos.Text = "Posicion"
        Me.btnPos.UseVisualStyleBackColor = false
        '
        'VerPatio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "VerPatio"
        Me.Size = New System.Drawing.Size(748, 490)
        Me.lote.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel4.ResumeLayout(false)
        Me.TableLayoutPanel4.PerformLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel2.ResumeLayout(false)
        CType(Me.DataGridViewVehiculos,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel3.ResumeLayout(false)
        Me.TableLayoutPanel3.PerformLayout
        Me.Panel4.ResumeLayout(false)
        Me.autito.ResumeLayout(false)
        Me.TabControl1.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents lote As TabPage
    Friend WithEvents DataGridViewVehiculos As DataGridView
    Friend WithEvents tbxBuscarVin As TextBox
    Friend WithEvents btBuscar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents autito As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnLavado As Button
    Friend WithEvents btActualizarVehiculo As Button
    Friend WithEvents btInfoVehiculo As Button
    Friend WithEvents btnPos As Button
End Class
