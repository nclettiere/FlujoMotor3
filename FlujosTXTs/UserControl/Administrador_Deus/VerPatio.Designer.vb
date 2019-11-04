<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerPatio
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                Chromium.Dispose
                components.Dispose
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.flpSubZonas = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelMapa = New System.Windows.Forms.Panel()
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.btnAgZona = New System.Windows.Forms.Button()
        Me.btnAgSubZona = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout
        Me.flpSubZonas.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.panelMapa.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.Panel3.SuspendLayout
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = true
        Me.GroupBox1.Controls.Add(Me.flpSubZonas)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox1.Location = New System.Drawing.Point(3, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 702)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "SubZonas Del Patio"
        '
        'flpSubZonas
        '
        Me.flpSubZonas.AutoScroll = true
        Me.flpSubZonas.BackColor = System.Drawing.Color.LightGray
        Me.flpSubZonas.Controls.Add(Me.Panel1)
        Me.flpSubZonas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpSubZonas.Location = New System.Drawing.Point(3, 16)
        Me.flpSubZonas.Name = "flpSubZonas"
        Me.flpSubZonas.Size = New System.Drawing.Size(252, 683)
        Me.flpSubZonas.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(236, 127)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(136, 91)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 28)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Eliminar"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(3, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Capacidad: 20 Vehiculos"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(3, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre: A_12"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ZonaId: #1"
        '
        'panelMapa
        '
        Me.panelMapa.BackColor = System.Drawing.Color.Gainsboro
        Me.panelMapa.Controls.Add(Me.lblLoading)
        Me.panelMapa.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMapa.Location = New System.Drawing.Point(0, 0)
        Me.panelMapa.Name = "panelMapa"
        Me.panelMapa.Size = New System.Drawing.Size(1040, 771)
        Me.panelMapa.TabIndex = 1
        '
        'lblLoading
        '
        Me.lblLoading.AutoSize = True
        Me.lblLoading.BackColor = System.Drawing.Color.Gray
        Me.lblLoading.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoading.ForeColor = System.Drawing.SystemColors.Control
        Me.lblLoading.Location = New System.Drawing.Point(203, 298)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(288, 39)
        Me.lblLoading.TabIndex = 0
        Me.lblLoading.Text = "Cargando Mapa..."
        '
        'btnAgZona
        '
        Me.btnAgZona.BackColor = System.Drawing.Color.Silver
        Me.btnAgZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgZona.ForeColor = System.Drawing.Color.Crimson
        Me.btnAgZona.Location = New System.Drawing.Point(17, 3)
        Me.btnAgZona.Name = "btnAgZona"
        Me.btnAgZona.Size = New System.Drawing.Size(120, 38)
        Me.btnAgZona.TabIndex = 5
        Me.btnAgZona.Text = "Agregar Zona"
        Me.btnAgZona.UseVisualStyleBackColor = false
        '
        'btnAgSubZona
        '
        Me.btnAgSubZona.BackColor = System.Drawing.Color.Silver
        Me.btnAgSubZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgSubZona.ForeColor = System.Drawing.Color.Crimson
        Me.btnAgSubZona.Location = New System.Drawing.Point(142, 3)
        Me.btnAgSubZona.Name = "btnAgSubZona"
        Me.btnAgSubZona.Size = New System.Drawing.Size(116, 38)
        Me.btnAgSubZona.TabIndex = 6
        Me.btnAgSubZona.Text = "Agregar SubZona"
        Me.btnAgSubZona.UseVisualStyleBackColor = false
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(1040, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(309, 771)
        Me.Panel2.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.AutoSize = true
        Me.Panel3.Controls.Add(Me.btnAgZona)
        Me.Panel3.Controls.Add(Me.btnAgSubZona)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(309, 44)
        Me.Panel3.TabIndex = 7
        '
        'VerPatio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panelMapa)
        Me.Name = "VerPatio"
        Me.Size = New System.Drawing.Size(1349, 771)
        Me.GroupBox1.ResumeLayout(false)
        Me.flpSubZonas.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.panelMapa.ResumeLayout(false)
        Me.panelMapa.PerformLayout
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.Panel3.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents panelMapa As Panel
    Friend WithEvents lblLoading As Label
    Friend WithEvents flpSubZonas As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAgZona As Button
    Friend WithEvents btnAgSubZona As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
