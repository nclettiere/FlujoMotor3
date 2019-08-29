<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionarVehiculo
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
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridVehiculos = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblSeleccionVin = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tbxColumna = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbxFila = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout
        Me.Panel1.SuspendLayout
        CType(Me.DataGridVehiculos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanel2.SuspendLayout
        Me.FlowLayoutPanel1.SuspendLayout
        Me.FlowLayoutPanel2.SuspendLayout
        Me.Panel3.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Controls.Add(Me.btAceptar, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 8)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.7619!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.2381!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(350, 420)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btAceptar
        '
        Me.btAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btAceptar.BackColor = System.Drawing.Color.DimGray
        Me.btAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btAceptar.FlatAppearance.BorderSize = 0
        Me.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAceptar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btAceptar.ForeColor = System.Drawing.Color.Orange
        Me.btAceptar.Location = New System.Drawing.Point(103, 361)
        Me.btAceptar.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btAceptar.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(143, 53)
        Me.btAceptar.TabIndex = 1
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = false
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 349)
        Me.Panel1.TabIndex = 2
        '
        'DataGridVehiculos
        '
        Me.DataGridVehiculos.AllowUserToAddRows = false
        Me.DataGridVehiculos.AllowUserToDeleteRows = false
        Me.DataGridVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridVehiculos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridVehiculos.Location = New System.Drawing.Point(3, 3)
        Me.DataGridVehiculos.MultiSelect = false
        Me.DataGridVehiculos.Name = "DataGridVehiculos"
        Me.DataGridVehiculos.ReadOnly = true
        Me.DataGridVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridVehiculos.Size = New System.Drawing.Size(338, 255)
        Me.DataGridVehiculos.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Controls.Add(Me.DataGridVehiculos, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 261!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(344, 349)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.lblSeleccionVin)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 264)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(338, 82)
        Me.FlowLayoutPanel1.TabIndex = 1
        Me.FlowLayoutPanel1.WrapContents = false
        '
        'lblSeleccionVin
        '
        Me.lblSeleccionVin.AutoSize = true
        Me.lblSeleccionVin.Location = New System.Drawing.Point(13, 10)
        Me.lblSeleccionVin.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.lblSeleccionVin.Name = "lblSeleccionVin"
        Me.lblSeleccionVin.Size = New System.Drawing.Size(220, 13)
        Me.lblSeleccionVin.TabIndex = 0
        Me.lblSeleccionVin.Text = "Vehiculo Seleccionado: ##############"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = true
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(13, 36)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(177, 35)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.tbxColumna)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(95, 29)
        Me.Panel3.TabIndex = 4
        '
        'tbxColumna
        '
        Me.tbxColumna.Location = New System.Drawing.Point(57, 6)
        Me.tbxColumna.Name = "tbxColumna"
        Me.tbxColumna.Size = New System.Drawing.Size(31, 20)
        Me.tbxColumna.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Columna"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tbxFila)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(104, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(70, 29)
        Me.Panel2.TabIndex = 3
        '
        'tbxFila
        '
        Me.tbxFila.Location = New System.Drawing.Point(32, 6)
        Me.tbxFila.Name = "tbxFila"
        Me.tbxFila.Size = New System.Drawing.Size(31, 20)
        Me.tbxFila.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fila"
        '
        'SeleccionarVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "SeleccionarVehiculo"
        Me.Size = New System.Drawing.Size(366, 436)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        CType(Me.DataGridVehiculos,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.FlowLayoutPanel1.ResumeLayout(false)
        Me.FlowLayoutPanel1.PerformLayout
        Me.FlowLayoutPanel2.ResumeLayout(false)
        Me.Panel3.ResumeLayout(false)
        Me.Panel3.PerformLayout
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btAceptar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents DataGridVehiculos As DataGridView
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblSeleccionVin As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tbxColumna As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbxFila As TextBox
    Friend WithEvents Label2 As Label
End Class
