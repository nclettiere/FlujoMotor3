<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelecVehiculo
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridVehiculos = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        CType(Me.DataGridVehiculos,System.ComponentModel.ISupportInitialize).BeginInit
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(-4, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.7619!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.2381!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(350, 420)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'btAceptar
        '
        Me.btAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btAceptar.BackColor = System.Drawing.Color.DimGray
        Me.btAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btAceptar.FlatAppearance.BorderSize = 0
        Me.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAceptar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btAceptar.ForeColor = System.Drawing.Color.Crimson
        Me.btAceptar.Location = New System.Drawing.Point(103, 361)
        Me.btAceptar.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btAceptar.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(143, 53)
        Me.btAceptar.TabIndex = 1
        Me.btAceptar.Text = "Seleccionar"
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
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Controls.Add(Me.DataGridVehiculos, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 341!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(344, 349)
        Me.TableLayoutPanel2.TabIndex = 0
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
        Me.DataGridVehiculos.Size = New System.Drawing.Size(338, 335)
        Me.DataGridVehiculos.TabIndex = 0
        '
        'SelecVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "SelecVehiculo"
        Me.Size = New System.Drawing.Size(343, 421)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        CType(Me.DataGridVehiculos,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btAceptar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents DataGridVehiculos As DataGridView
End Class
