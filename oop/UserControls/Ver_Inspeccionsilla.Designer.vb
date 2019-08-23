<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ver_Inspeccionsilla
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
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblVehiculoVin = New System.Windows.Forms.Label()
        Me.MainWidgets = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout
        Me.TableLayoutPanel7.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.Panel1.SuspendLayout
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
        Me.TableLayoutPanel7.Controls.Add(Me.btAceptar, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btCancelar, 1, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 462)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.Padding = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(950, 62)
        Me.TableLayoutPanel7.TabIndex = 3
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
        Me.btAceptar.Location = New System.Drawing.Point(181, 8)
        Me.btAceptar.MaximumSize = New System.Drawing.Size(143, 51)
        Me.btAceptar.MinimumSize = New System.Drawing.Size(143, 51)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(143, 51)
        Me.btAceptar.TabIndex = 0
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = false
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
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = false
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.MainWidgets, 0, 1)
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
        'MainWidgets
        '
        Me.MainWidgets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainWidgets.Location = New System.Drawing.Point(3, 54)
        Me.MainWidgets.Name = "MainWidgets"
        Me.MainWidgets.Size = New System.Drawing.Size(944, 396)
        Me.MainWidgets.TabIndex = 1
        '
        'Ver_Inspeccionsilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Ver_Inspeccionsilla"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(972, 544)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel7.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents btAceptar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblVehiculoVin As Label
    Friend WithEvents MainWidgets As Panel
End Class
