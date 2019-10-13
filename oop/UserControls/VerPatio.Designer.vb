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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.autito = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.cbxFiltro = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbxZonaPatio = New System.Windows.Forms.ComboBox()
        Me.tbxBuscarVin = New System.Windows.Forms.TextBox()
        Me.DataGridViewVehiculos = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnPatios = New System.Windows.Forms.Button()
        Me.btnPos = New System.Windows.Forms.Button()
        Me.btnLavado = New System.Windows.Forms.Button()
        Me.btActualizarVehiculo = New System.Windows.Forms.Button()
        Me.btInfoVehiculo = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.autito.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.TableLayoutPanel3.SuspendLayout
        Me.Panel3.SuspendLayout
        CType(Me.DataGridViewVehiculos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel4.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(849, 490)
        Me.Panel1.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.autito)
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(70, 18)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(843, 484)
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
        Me.autito.Size = New System.Drawing.Size(835, 458)
        Me.autito.TabIndex = 0
        Me.autito.Text = "VEHICULOS"
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(829, 452)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.1354!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.8646!))
        Me.TableLayoutPanel3.Controls.Add(Me.btBuscar, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.cbxFiltro, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(823, 50)
        Me.TableLayoutPanel3.TabIndex = 3
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
        Me.btBuscar.Location = New System.Drawing.Point(688, 5)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(111, 40)
        Me.btBuscar.TabIndex = 2
        Me.btBuscar.Text = "Filtrar"
        Me.btBuscar.UseVisualStyleBackColor = false
        '
        'cbxFiltro
        '
        Me.cbxFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbxFiltro.FormattingEnabled = true
        Me.cbxFiltro.Items.AddRange(New Object() {"VIN", "ZONA", "PATIO"})
        Me.cbxFiltro.Location = New System.Drawing.Point(3, 14)
        Me.cbxFiltro.Name = "cbxFiltro"
        Me.cbxFiltro.Size = New System.Drawing.Size(94, 31)
        Me.cbxFiltro.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cbxZonaPatio)
        Me.Panel3.Controls.Add(Me.tbxBuscarVin)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(103, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(558, 44)
        Me.Panel3.TabIndex = 5
        '
        'cbxZonaPatio
        '
        Me.cbxZonaPatio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbxZonaPatio.FormattingEnabled = true
        Me.cbxZonaPatio.Items.AddRange(New Object() {"VIN", "ZONA", "PATIO"})
        Me.cbxZonaPatio.Location = New System.Drawing.Point(0, 7)
        Me.cbxZonaPatio.Name = "cbxZonaPatio"
        Me.cbxZonaPatio.Size = New System.Drawing.Size(527, 31)
        Me.cbxZonaPatio.TabIndex = 5
        Me.cbxZonaPatio.Visible = false
        '
        'tbxBuscarVin
        '
        Me.tbxBuscarVin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tbxBuscarVin.BackColor = System.Drawing.Color.White
        Me.tbxBuscarVin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxBuscarVin.Font = New System.Drawing.Font("Calibri", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tbxBuscarVin.Location = New System.Drawing.Point(0, 9)
        Me.tbxBuscarVin.Name = "tbxBuscarVin"
        Me.tbxBuscarVin.Size = New System.Drawing.Size(558, 27)
        Me.tbxBuscarVin.TabIndex = 4
        Me.tbxBuscarVin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.DataGridViewVehiculos.Location = New System.Drawing.Point(3, 59)
        Me.DataGridViewVehiculos.Name = "DataGridViewVehiculos"
        Me.DataGridViewVehiculos.ReadOnly = true
        Me.DataGridViewVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewVehiculos.ShowCellToolTips = false
        Me.DataGridViewVehiculos.ShowEditingIcon = false
        Me.DataGridViewVehiculos.Size = New System.Drawing.Size(823, 310)
        Me.DataGridViewVehiculos.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnPatios)
        Me.Panel4.Controls.Add(Me.btnPos)
        Me.Panel4.Controls.Add(Me.btnLavado)
        Me.Panel4.Controls.Add(Me.btActualizarVehiculo)
        Me.Panel4.Controls.Add(Me.btInfoVehiculo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 375)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(823, 74)
        Me.Panel4.TabIndex = 5
        '
        'btnPatios
        '
        Me.btnPatios.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPatios.BackColor = System.Drawing.Color.DimGray
        Me.btnPatios.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnPatios.FlatAppearance.BorderSize = 0
        Me.btnPatios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPatios.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnPatios.ForeColor = System.Drawing.Color.Orange
        Me.btnPatios.Location = New System.Drawing.Point(487, 11)
        Me.btnPatios.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btnPatios.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btnPatios.Name = "btnPatios"
        Me.btnPatios.Size = New System.Drawing.Size(143, 53)
        Me.btnPatios.TabIndex = 8
        Me.btnPatios.Text = "Lista Patios"
        Me.btnPatios.UseVisualStyleBackColor = false
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
        Me.btnPos.Location = New System.Drawing.Point(156, 11)
        Me.btnPos.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btnPos.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btnPos.Name = "btnPos"
        Me.btnPos.Size = New System.Drawing.Size(143, 53)
        Me.btnPos.TabIndex = 7
        Me.btnPos.Text = "Posicion"
        Me.btnPos.UseVisualStyleBackColor = false
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
        Me.btnLavado.Location = New System.Drawing.Point(7, 11)
        Me.btnLavado.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btnLavado.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btnLavado.Name = "btnLavado"
        Me.btnLavado.Size = New System.Drawing.Size(143, 53)
        Me.btnLavado.TabIndex = 6
        Me.btnLavado.Text = "Lavados"
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
        Me.btActualizarVehiculo.Location = New System.Drawing.Point(665, 11)
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
        Me.btInfoVehiculo.Location = New System.Drawing.Point(305, 11)
        Me.btInfoVehiculo.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btInfoVehiculo.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btInfoVehiculo.Name = "btInfoVehiculo"
        Me.btInfoVehiculo.Size = New System.Drawing.Size(143, 53)
        Me.btInfoVehiculo.TabIndex = 4
        Me.btInfoVehiculo.Text = "Informacion"
        Me.btInfoVehiculo.UseVisualStyleBackColor = false
        '
        'VerPatio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "VerPatio"
        Me.Size = New System.Drawing.Size(849, 490)
        Me.Panel1.ResumeLayout(false)
        Me.TabControl1.ResumeLayout(false)
        Me.autito.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel3.ResumeLayout(false)
        Me.Panel3.ResumeLayout(false)
        Me.Panel3.PerformLayout
        CType(Me.DataGridViewVehiculos,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel4.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents autito As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btBuscar As Button
    Friend WithEvents cbxFiltro As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cbxZonaPatio As ComboBox
    Friend WithEvents tbxBuscarVin As TextBox
    Friend WithEvents DataGridViewVehiculos As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnPatios As Button
    Friend WithEvents btnPos As Button
    Friend WithEvents btnLavado As Button
    Friend WithEvents btActualizarVehiculo As Button
    Friend WithEvents btInfoVehiculo As Button
End Class
