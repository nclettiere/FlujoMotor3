<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionarVehiculos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lst_vehiculos = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.69307!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.30693!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(274, 300)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lst_vehiculos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(268, 236)
        Me.Panel1.TabIndex = 0
        '
        'lst_vehiculos
        '
        Me.lst_vehiculos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lst_vehiculos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_vehiculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_vehiculos.FormattingEnabled = True
        Me.lst_vehiculos.ItemHeight = 20
        Me.lst_vehiculos.Location = New System.Drawing.Point(0, 0)
        Me.lst_vehiculos.Name = "lst_vehiculos"
        Me.lst_vehiculos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lst_vehiculos.Size = New System.Drawing.Size(268, 236)
        Me.lst_vehiculos.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_agregar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 245)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(268, 52)
        Me.Panel2.TabIndex = 1
        '
        'btn_agregar
        '
        Me.btn_agregar.BackgroundImage = Global.oop.My.Resources.Resources.boton_buscar
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_agregar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_agregar.FlatAppearance.BorderSize = 0
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.ForeColor = System.Drawing.Color.White
        Me.btn_agregar.Location = New System.Drawing.Point(0, 0)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(268, 52)
        Me.btn_agregar.TabIndex = 0
        Me.btn_agregar.Text = "Aceptar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'SeleccionarVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(274, 300)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "SeleccionarVehiculos"
        Me.ShowIcon = False
        Me.Text = "Seleccionar Vehiculos"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lst_vehiculos As ListBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_agregar As Button
End Class
