<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerLavados
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btCerrar = New System.Windows.Forms.Button()
        Me.lblLavadoTitulo = New System.Windows.Forms.Label()
        Me.btnNuevoLavado = New System.Windows.Forms.Button()
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = false
        Me.DataGridView1.AllowUserToDeleteRows = false
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 45)
        Me.DataGridView1.MultiSelect = false
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(392, 235)
        Me.DataGridView1.TabIndex = 0
        '
        'btCerrar
        '
        Me.btCerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btCerrar.BackColor = System.Drawing.Color.DimGray
        Me.btCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btCerrar.FlatAppearance.BorderSize = 0
        Me.btCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCerrar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btCerrar.ForeColor = System.Drawing.Color.Crimson
        Me.btCerrar.Location = New System.Drawing.Point(246, 295)
        Me.btCerrar.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btCerrar.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btCerrar.Name = "btCerrar"
        Me.btCerrar.Size = New System.Drawing.Size(143, 53)
        Me.btCerrar.TabIndex = 2
        Me.btCerrar.Text = "Cerrar"
        Me.btCerrar.UseVisualStyleBackColor = false
        '
        'lblLavadoTitulo
        '
        Me.lblLavadoTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblLavadoTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblLavadoTitulo.ForeColor = System.Drawing.Color.Crimson
        Me.lblLavadoTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblLavadoTitulo.Name = "lblLavadoTitulo"
        Me.lblLavadoTitulo.Size = New System.Drawing.Size(392, 45)
        Me.lblLavadoTitulo.TabIndex = 3
        Me.lblLavadoTitulo.Text = "Viendo Lavados de: "
        Me.lblLavadoTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnNuevoLavado
        '
        Me.btnNuevoLavado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNuevoLavado.BackColor = System.Drawing.Color.DimGray
        Me.btnNuevoLavado.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnNuevoLavado.FlatAppearance.BorderSize = 0
        Me.btnNuevoLavado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoLavado.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnNuevoLavado.ForeColor = System.Drawing.Color.Crimson
        Me.btnNuevoLavado.Location = New System.Drawing.Point(14, 295)
        Me.btnNuevoLavado.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btnNuevoLavado.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btnNuevoLavado.Name = "btnNuevoLavado"
        Me.btnNuevoLavado.Size = New System.Drawing.Size(143, 53)
        Me.btnNuevoLavado.TabIndex = 4
        Me.btnNuevoLavado.Text = "Nuevo Lavado"
        Me.btnNuevoLavado.UseVisualStyleBackColor = false
        '
        'VerLavados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Controls.Add(Me.btnNuevoLavado)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblLavadoTitulo)
        Me.Controls.Add(Me.btCerrar)
        Me.Name = "VerLavados"
        Me.Size = New System.Drawing.Size(392, 360)
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btCerrar As Button
    Friend WithEvents lblLavadoTitulo As Label
    Friend WithEvents btnNuevoLavado As Button
End Class
