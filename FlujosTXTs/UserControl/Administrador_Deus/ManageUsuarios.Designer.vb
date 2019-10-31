<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageUsuarios
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dataLstUsuarios = New BrightIdeasSoftware.DataListView()
        Me.btnAgregarUsuario = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblOpTipo = New System.Windows.Forms.Label()
        Me.lblNroVvendidos = New System.Windows.Forms.Label()
        Me.lblNroLEntrgados = New System.Windows.Forms.Label()
        Me.lblNroLAsign = New System.Windows.Forms.Label()
        Me.lblNroLIngresados = New System.Windows.Forms.Label()
        Me.lblNroVIngresados = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblUsuer = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.Panel3.SuspendLayout
        CType(Me.dataLstUsuarios,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        Me.FlowLayoutPanel1.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(905, 672)
        Me.Panel1.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(10, 25, 3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(531, 657)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Administracion de Usuarios"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.dataLstUsuarios)
        Me.Panel3.Controls.Add(Me.btnAgregarUsuario)
        Me.Panel3.Controls.Add(Me.btnMod)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(525, 638)
        Me.Panel3.TabIndex = 0
        '
        'dataLstUsuarios
        '
        Me.dataLstUsuarios.CellEditUseWholeCell = false
        Me.dataLstUsuarios.DataSource = Nothing
        Me.dataLstUsuarios.FullRowSelect = true
        Me.dataLstUsuarios.Location = New System.Drawing.Point(12, 52)
        Me.dataLstUsuarios.Name = "dataLstUsuarios"
        Me.dataLstUsuarios.ShowGroups = false
        Me.dataLstUsuarios.Size = New System.Drawing.Size(502, 568)
        Me.dataLstUsuarios.TabIndex = 3
        Me.dataLstUsuarios.UseCompatibleStateImageBehavior = false
        Me.dataLstUsuarios.View = System.Windows.Forms.View.Details
        '
        'btnAgregarUsuario
        '
        Me.btnAgregarUsuario.BackColor = System.Drawing.Color.Gray
        Me.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarUsuario.Font = New System.Drawing.Font("Arial", 13!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0,Byte))
        Me.btnAgregarUsuario.ForeColor = System.Drawing.Color.Crimson
        Me.btnAgregarUsuario.Location = New System.Drawing.Point(358, 10)
        Me.btnAgregarUsuario.Name = "btnAgregarUsuario"
        Me.btnAgregarUsuario.Size = New System.Drawing.Size(156, 36)
        Me.btnAgregarUsuario.TabIndex = 2
        Me.btnAgregarUsuario.Text = "Agregar"
        Me.btnAgregarUsuario.UseVisualStyleBackColor = false
        '
        'btnMod
        '
        Me.btnMod.BackColor = System.Drawing.Color.Gray
        Me.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMod.Font = New System.Drawing.Font("Arial", 13!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0,Byte))
        Me.btnMod.ForeColor = System.Drawing.Color.Crimson
        Me.btnMod.Location = New System.Drawing.Point(12, 10)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(158, 36)
        Me.btnMod.TabIndex = 0
        Me.btnMod.Text = "Modificar"
        Me.btnMod.UseVisualStyleBackColor = false
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox1.Location = New System.Drawing.Point(544, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10, 25, 3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 657)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Detalles"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(355, 638)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.lblOpTipo)
        Me.Panel2.Controls.Add(Me.lblNroVvendidos)
        Me.Panel2.Controls.Add(Me.lblNroLEntrgados)
        Me.Panel2.Controls.Add(Me.lblNroLAsign)
        Me.Panel2.Controls.Add(Me.lblNroLIngresados)
        Me.Panel2.Controls.Add(Me.lblNroVIngresados)
        Me.Panel2.Controls.Add(Me.lblNombre)
        Me.Panel2.Controls.Add(Me.lblUsuer)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(13, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(327, 607)
        Me.Panel2.TabIndex = 0
        '
        'lblOpTipo
        '
        Me.lblOpTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblOpTipo.AutoSize = true
        Me.lblOpTipo.BackColor = System.Drawing.Color.Transparent
        Me.lblOpTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblOpTipo.Font = New System.Drawing.Font("Calibri", 10!)
        Me.lblOpTipo.ForeColor = System.Drawing.Color.Crimson
        Me.lblOpTipo.Location = New System.Drawing.Point(11, 67)
        Me.lblOpTipo.Name = "lblOpTipo"
        Me.lblOpTipo.Size = New System.Drawing.Size(106, 17)
        Me.lblOpTipo.TabIndex = 9
        Me.lblOpTipo.Text = "Tipo de Operario:"
        Me.lblOpTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNroVvendidos
        '
        Me.lblNroVvendidos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblNroVvendidos.AutoSize = true
        Me.lblNroVvendidos.BackColor = System.Drawing.Color.Transparent
        Me.lblNroVvendidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNroVvendidos.Font = New System.Drawing.Font("Calibri", 10!)
        Me.lblNroVvendidos.ForeColor = System.Drawing.Color.Crimson
        Me.lblNroVvendidos.Location = New System.Drawing.Point(11, 215)
        Me.lblNroVvendidos.Name = "lblNroVvendidos"
        Me.lblNroVvendidos.Size = New System.Drawing.Size(117, 17)
        Me.lblNroVvendidos.TabIndex = 8
        Me.lblNroVvendidos.Text = "Vehiculos Vendidos:"
        Me.lblNroVvendidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNroLEntrgados
        '
        Me.lblNroLEntrgados.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblNroLEntrgados.AutoSize = true
        Me.lblNroLEntrgados.BackColor = System.Drawing.Color.Transparent
        Me.lblNroLEntrgados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNroLEntrgados.Font = New System.Drawing.Font("Calibri", 10!)
        Me.lblNroLEntrgados.ForeColor = System.Drawing.Color.Crimson
        Me.lblNroLEntrgados.Location = New System.Drawing.Point(11, 181)
        Me.lblNroLEntrgados.Name = "lblNroLEntrgados"
        Me.lblNroLEntrgados.Size = New System.Drawing.Size(109, 17)
        Me.lblNroLEntrgados.TabIndex = 7
        Me.lblNroLEntrgados.Text = "Lotes Entregados:"
        Me.lblNroLEntrgados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNroLAsign
        '
        Me.lblNroLAsign.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblNroLAsign.AutoSize = true
        Me.lblNroLAsign.BackColor = System.Drawing.Color.Transparent
        Me.lblNroLAsign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNroLAsign.Font = New System.Drawing.Font("Calibri", 10!)
        Me.lblNroLAsign.ForeColor = System.Drawing.Color.Crimson
        Me.lblNroLAsign.Location = New System.Drawing.Point(11, 156)
        Me.lblNroLAsign.Name = "lblNroLAsign"
        Me.lblNroLAsign.Size = New System.Drawing.Size(101, 17)
        Me.lblNroLAsign.TabIndex = 6
        Me.lblNroLAsign.Text = "Lotes Asignados:"
        Me.lblNroLAsign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNroLIngresados
        '
        Me.lblNroLIngresados.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblNroLIngresados.AutoSize = true
        Me.lblNroLIngresados.BackColor = System.Drawing.Color.Transparent
        Me.lblNroLIngresados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNroLIngresados.Font = New System.Drawing.Font("Calibri", 10!)
        Me.lblNroLIngresados.ForeColor = System.Drawing.Color.Crimson
        Me.lblNroLIngresados.Location = New System.Drawing.Point(11, 126)
        Me.lblNroLIngresados.Name = "lblNroLIngresados"
        Me.lblNroLIngresados.Size = New System.Drawing.Size(130, 17)
        Me.lblNroLIngresados.TabIndex = 5
        Me.lblNroLIngresados.Text = "Nro Lotes Ingresados:"
        Me.lblNroLIngresados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNroVIngresados
        '
        Me.lblNroVIngresados.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblNroVIngresados.AutoSize = true
        Me.lblNroVIngresados.BackColor = System.Drawing.Color.Transparent
        Me.lblNroVIngresados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNroVIngresados.Font = New System.Drawing.Font("Calibri", 10!)
        Me.lblNroVIngresados.ForeColor = System.Drawing.Color.Crimson
        Me.lblNroVIngresados.Location = New System.Drawing.Point(11, 101)
        Me.lblNroVIngresados.Name = "lblNroVIngresados"
        Me.lblNroVIngresados.Size = New System.Drawing.Size(152, 17)
        Me.lblNroVIngresados.TabIndex = 4
        Me.lblNroVIngresados.Text = "Nro Vehiculos Ingresados:"
        Me.lblNroVIngresados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblNombre.AutoSize = true
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNombre.Font = New System.Drawing.Font("Calibri", 10!)
        Me.lblNombre.ForeColor = System.Drawing.Color.Crimson
        Me.lblNombre.Location = New System.Drawing.Point(11, 40)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsuer
        '
        Me.lblUsuer.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblUsuer.AutoSize = true
        Me.lblUsuer.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUsuer.Font = New System.Drawing.Font("Calibri", 10!)
        Me.lblUsuer.ForeColor = System.Drawing.Color.Crimson
        Me.lblUsuer.Location = New System.Drawing.Point(11, 16)
        Me.lblUsuer.Name = "lblUsuer"
        Me.lblUsuer.Size = New System.Drawing.Size(55, 17)
        Me.lblUsuer.TabIndex = 2
        Me.lblUsuer.Text = "Usuario:"
        Me.lblUsuer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ManageUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ManageUsuarios"
        Me.Size = New System.Drawing.Size(905, 672)
        Me.Panel1.ResumeLayout(false)
        Me.GroupBox2.ResumeLayout(false)
        Me.Panel3.ResumeLayout(false)
        CType(Me.dataLstUsuarios,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        Me.FlowLayoutPanel1.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dataLstUsuarios As BrightIdeasSoftware.DataListView
    Friend WithEvents btnAgregarUsuario As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblOpTipo As Label
    Friend WithEvents lblNroVvendidos As Label
    Friend WithEvents lblNroLEntrgados As Label
    Friend WithEvents lblNroLAsign As Label
    Friend WithEvents lblNroLIngresados As Label
    Friend WithEvents lblNroVIngresados As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblUsuer As Label
End Class
