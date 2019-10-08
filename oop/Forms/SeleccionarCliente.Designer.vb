<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionarCliente
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
        Me.lst_clientes = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(268, 292)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lst_clientes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(262, 229)
        Me.Panel1.TabIndex = 0
        '
        'lst_clientes
        '
        Me.lst_clientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lst_clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_clientes.HideSelection = False
        Me.lst_clientes.Location = New System.Drawing.Point(0, 0)
        Me.lst_clientes.Name = "lst_clientes"
        Me.lst_clientes.ShowGroups = False
        Me.lst_clientes.Size = New System.Drawing.Size(262, 229)
        Me.lst_clientes.TabIndex = 0
        Me.lst_clientes.UseCompatibleStateImageBehavior = False
        Me.lst_clientes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_agregar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 238)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(262, 51)
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
        Me.btn_agregar.Size = New System.Drawing.Size(262, 51)
        Me.btn_agregar.TabIndex = 0
        Me.btn_agregar.Text = "Aceptar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'SeleccionarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 292)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "SeleccionarCliente"
        Me.ShowIcon = False
        Me.Text = "Seleccionar Cliente"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_agregar As Button
    Friend WithEvents lst_clientes As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
End Class
