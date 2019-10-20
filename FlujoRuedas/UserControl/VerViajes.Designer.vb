<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerViajes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListaViajes = New BrightIdeasSoftware.FastDataListView()
        Me.panelMapa = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEntregar = New System.Windows.Forms.Button()
        CType(Me.ListaViajes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.panelMapa.SuspendLayout
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(20, 20, 20, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(20)
        Me.Label1.Size = New System.Drawing.Size(142, 65)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mis Viajes"
        '
        'ListaViajes
        '
        Me.ListaViajes.CellEditUseWholeCell = false
        Me.ListaViajes.DataSource = Nothing
        Me.ListaViajes.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListaViajes.FullRowSelect = true
        Me.ListaViajes.Location = New System.Drawing.Point(0, 65)
        Me.ListaViajes.MultiSelect = false
        Me.ListaViajes.Name = "ListaViajes"
        Me.ListaViajes.ShowGroups = false
        Me.ListaViajes.Size = New System.Drawing.Size(797, 203)
        Me.ListaViajes.TabIndex = 2
        Me.ListaViajes.UseCompatibleStateImageBehavior = false
        Me.ListaViajes.View = System.Windows.Forms.View.Details
        Me.ListaViajes.VirtualMode = true
        '
        'panelMapa
        '
        Me.panelMapa.Controls.Add(Me.Label2)
        Me.panelMapa.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMapa.Location = New System.Drawing.Point(0, 268)
        Me.panelMapa.Name = "panelMapa"
        Me.panelMapa.Size = New System.Drawing.Size(649, 314)
        Me.panelMapa.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(170, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cargando Mapa..."
        '
        'btnEntregar
        '
        Me.btnEntregar.BackColor = System.Drawing.Color.DimGray
        Me.btnEntregar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEntregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntregar.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btnEntregar.Location = New System.Drawing.Point(649, 268)
        Me.btnEntregar.Name = "btnEntregar"
        Me.btnEntregar.Size = New System.Drawing.Size(148, 41)
        Me.btnEntregar.TabIndex = 4
        Me.btnEntregar.Text = "Entregar Lote"
        Me.btnEntregar.UseVisualStyleBackColor = false
        '
        'VerViajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12!, 25!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Controls.Add(Me.btnEntregar)
        Me.Controls.Add(Me.panelMapa)
        Me.Controls.Add(Me.ListaViajes)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = true
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "VerViajes"
        Me.Size = New System.Drawing.Size(797, 582)
        CType(Me.ListaViajes,System.ComponentModel.ISupportInitialize).EndInit
        Me.panelMapa.ResumeLayout(false)
        Me.panelMapa.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListaViajes As BrightIdeasSoftware.FastDataListView
    Friend WithEvents panelMapa As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEntregar As Button
End Class
