<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seleccionar_Lotesillo
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
        Me.DataGridViewLotes = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btSelecc = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.DataGridViewLotes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridViewLotes, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 8)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.7619!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.2381!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(350, 420)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'DataGridViewLotes
        '
        Me.DataGridViewLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewLotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewLotes.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewLotes.MultiSelect = false
        Me.DataGridViewLotes.Name = "DataGridViewLotes"
        Me.DataGridViewLotes.ReadOnly = true
        Me.DataGridViewLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewLotes.Size = New System.Drawing.Size(344, 349)
        Me.DataGridViewLotes.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.btSelecc)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 358)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 59)
        Me.Panel1.TabIndex = 3
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.DimGray
        Me.btnBack.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Orange
        Me.btnBack.Location = New System.Drawing.Point(201, 0)
        Me.btnBack.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btnBack.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(143, 53)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Ir Atras"
        Me.btnBack.UseVisualStyleBackColor = false
        '
        'btSelecc
        '
        Me.btSelecc.BackColor = System.Drawing.Color.DimGray
        Me.btSelecc.Dock = System.Windows.Forms.DockStyle.Left
        Me.btSelecc.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btSelecc.FlatAppearance.BorderSize = 0
        Me.btSelecc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSelecc.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btSelecc.ForeColor = System.Drawing.Color.Orange
        Me.btSelecc.Location = New System.Drawing.Point(0, 0)
        Me.btSelecc.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btSelecc.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btSelecc.Name = "btSelecc"
        Me.btSelecc.Size = New System.Drawing.Size(143, 53)
        Me.btSelecc.TabIndex = 2
        Me.btSelecc.Text = "Seleccionar"
        Me.btSelecc.UseVisualStyleBackColor = false
        '
        'Seleccionar_Lotesillo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Seleccionar_Lotesillo"
        Me.Size = New System.Drawing.Size(366, 436)
        Me.TableLayoutPanel1.ResumeLayout(false)
        CType(Me.DataGridViewLotes,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DataGridViewLotes As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents btSelecc As Button
End Class
