<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seleccionar_Vehiculillo
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
        Me.lisBoVehiculos = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btAceptar, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lisBoVehiculos, 0, 0)
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
        Me.btAceptar.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAceptar.ForeColor = System.Drawing.Color.Orange
        Me.btAceptar.Location = New System.Drawing.Point(103, 361)
        Me.btAceptar.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btAceptar.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(143, 53)
        Me.btAceptar.TabIndex = 1
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = False
        '
        'lisBoVehiculos
        '
        Me.lisBoVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lisBoVehiculos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lisBoVehiculos.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lisBoVehiculos.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lisBoVehiculos.FormattingEnabled = True
        Me.lisBoVehiculos.ItemHeight = 23
        Me.lisBoVehiculos.Location = New System.Drawing.Point(5, 5)
        Me.lisBoVehiculos.Margin = New System.Windows.Forms.Padding(5)
        Me.lisBoVehiculos.Name = "lisBoVehiculos"
        Me.lisBoVehiculos.Size = New System.Drawing.Size(340, 345)
        Me.lisBoVehiculos.TabIndex = 2
        '
        'Seleccionar_Vehiculillo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Seleccionar_Vehiculillo"
        Me.Size = New System.Drawing.Size(366, 436)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btAceptar As Button
    Friend WithEvents lisBoVehiculos As ListBox
End Class
