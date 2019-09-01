<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VerInspeccion
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblVehiculoVin = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridInspecciones = New System.Windows.Forms.DataGridView()
        Me.DataGridDanios = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout
        Me.TableLayoutPanel7.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.TabPage2.SuspendLayout
        CType(Me.DataGridInspecciones,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataGridDanios,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel7, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TableLayoutPanel1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 8)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.12122!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.87879!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(956, 528)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel7.Controls.Add(Me.btCancelar, 1, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 462)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.Padding = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(950, 62)
        Me.TableLayoutPanel7.TabIndex = 3
        '
        'btCancelar
        '
        Me.btCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btCancelar.BackColor = System.Drawing.Color.DimGray
        Me.btCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.btCancelar.FlatAppearance.BorderSize = 0
        Me.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancelar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btCancelar.ForeColor = System.Drawing.Color.Orange
        Me.btCancelar.Location = New System.Drawing.Point(626, 8)
        Me.btCancelar.MaximumSize = New System.Drawing.Size(143, 51)
        Me.btCancelar.MinimumSize = New System.Drawing.Size(143, 51)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(143, 51)
        Me.btCancelar.TabIndex = 1
        Me.btCancelar.Text = "Ir Atras"
        Me.btCancelar.UseVisualStyleBackColor = false
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.25828!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.74172!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(950, 453)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblVehiculoVin)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(944, 45)
        Me.Panel1.TabIndex = 0
        '
        'lblVehiculoVin
        '
        Me.lblVehiculoVin.AutoSize = true
        Me.lblVehiculoVin.ForeColor = System.Drawing.Color.Orange
        Me.lblVehiculoVin.Location = New System.Drawing.Point(21, 11)
        Me.lblVehiculoVin.Name = "lblVehiculoVin"
        Me.lblVehiculoVin.Size = New System.Drawing.Size(304, 23)
        Me.lblVehiculoVin.TabIndex = 0
        Me.lblVehiculoVin.Text = "Viendo Vehiculo: ##################"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 54)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(944, 396)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridInspecciones)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(936, 360)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inspecciones"
        Me.TabPage1.UseVisualStyleBackColor = true
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridDanios)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(936, 360)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Danios"
        Me.TabPage2.UseVisualStyleBackColor = true
        '
        'DataGridInspecciones
        '
        Me.DataGridInspecciones.AllowUserToAddRows = false
        Me.DataGridInspecciones.AllowUserToDeleteRows = false
        Me.DataGridInspecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridInspecciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridInspecciones.Location = New System.Drawing.Point(3, 3)
        Me.DataGridInspecciones.Name = "DataGridInspecciones"
        Me.DataGridInspecciones.Size = New System.Drawing.Size(930, 354)
        Me.DataGridInspecciones.TabIndex = 0
        '
        'DataGridDanios
        '
        Me.DataGridDanios.AllowUserToAddRows = false
        Me.DataGridDanios.AllowUserToDeleteRows = false
        Me.DataGridDanios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridDanios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridDanios.Location = New System.Drawing.Point(3, 3)
        Me.DataGridDanios.Name = "DataGridDanios"
        Me.DataGridDanios.Size = New System.Drawing.Size(930, 354)
        Me.DataGridDanios.TabIndex = 1
        '
        'VerInspeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "VerInspeccion"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(972, 544)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel7.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.TabControl1.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        Me.TabPage2.ResumeLayout(false)
        CType(Me.DataGridInspecciones,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataGridDanios,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents btCancelar As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblVehiculoVin As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridInspecciones As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridDanios As DataGridView
End Class
