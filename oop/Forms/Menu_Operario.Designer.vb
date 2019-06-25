<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Operario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.pnLateral = New System.Windows.Forms.Panel()
        Me.tlpnMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btVehiculos = New System.Windows.Forms.Button()
        Me.btPatio = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_scan_qr = New System.Windows.Forms.Button()
        Me.pnPerfil = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_perfil = New System.Windows.Forms.Button()
        Me.pnVentanas = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pnLateral.SuspendLayout()
        Me.tlpnMenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnPerfil.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnLateral
        '
        Me.pnLateral.BackColor = System.Drawing.Color.Tan
        Me.pnLateral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnLateral.Controls.Add(Me.tlpnMenu)
        Me.pnLateral.Controls.Add(Me.pnPerfil)
        Me.pnLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnLateral.Location = New System.Drawing.Point(0, 0)
        Me.pnLateral.Name = "pnLateral"
        Me.pnLateral.Size = New System.Drawing.Size(247, 661)
        Me.pnLateral.TabIndex = 1
        '
        'tlpnMenu
        '
        Me.tlpnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.tlpnMenu.ColumnCount = 1
        Me.tlpnMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpnMenu.Controls.Add(Me.Button1, 0, 5)
        Me.tlpnMenu.Controls.Add(Me.btVehiculos, 0, 0)
        Me.tlpnMenu.Controls.Add(Me.btPatio, 0, 1)
        Me.tlpnMenu.Controls.Add(Me.Panel2, 0, 4)
        Me.tlpnMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpnMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlpnMenu.Name = "tlpnMenu"
        Me.tlpnMenu.RowCount = 6
        Me.tlpnMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.13445!))
        Me.tlpnMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.09244!))
        Me.tlpnMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.77311!))
        Me.tlpnMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 276.0!))
        Me.tlpnMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.tlpnMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.tlpnMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpnMenu.Size = New System.Drawing.Size(247, 596)
        Me.tlpnMenu.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(3, 549)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(241, 44)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cerrar Sesion"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btVehiculos
        '
        Me.btVehiculos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btVehiculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btVehiculos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btVehiculos.FlatAppearance.BorderSize = 0
        Me.btVehiculos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btVehiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btVehiculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVehiculos.ForeColor = System.Drawing.Color.White
        Me.btVehiculos.Location = New System.Drawing.Point(3, 13)
        Me.btVehiculos.Name = "btVehiculos"
        Me.btVehiculos.Size = New System.Drawing.Size(241, 52)
        Me.btVehiculos.TabIndex = 6
        Me.btVehiculos.Text = " - PUERTO"
        Me.btVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btVehiculos.UseVisualStyleBackColor = True
        '
        'btPatio
        '
        Me.btPatio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btPatio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btPatio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btPatio.FlatAppearance.BorderSize = 0
        Me.btPatio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btPatio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btPatio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPatio.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPatio.ForeColor = System.Drawing.Color.White
        Me.btPatio.Location = New System.Drawing.Point(3, 87)
        Me.btPatio.Name = "btPatio"
        Me.btPatio.Size = New System.Drawing.Size(241, 52)
        Me.btPatio.TabIndex = 5
        Me.btPatio.Text = " - PATIO"
        Me.btPatio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btPatio.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_scan_qr)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 497)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(241, 46)
        Me.Panel2.TabIndex = 8
        '
        'btn_scan_qr
        '
        Me.btn_scan_qr.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btn_scan_qr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_scan_qr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_scan_qr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_scan_qr.FlatAppearance.BorderSize = 0
        Me.btn_scan_qr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_scan_qr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_scan_qr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_scan_qr.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_scan_qr.ForeColor = System.Drawing.Color.White
        Me.btn_scan_qr.Location = New System.Drawing.Point(0, 0)
        Me.btn_scan_qr.Name = "btn_scan_qr"
        Me.btn_scan_qr.Size = New System.Drawing.Size(241, 46)
        Me.btn_scan_qr.TabIndex = 8
        Me.btn_scan_qr.Text = "Escanear Codigo QR"
        Me.btn_scan_qr.UseVisualStyleBackColor = False
        '
        'pnPerfil
        '
        Me.pnPerfil.BackColor = System.Drawing.Color.Tan
        Me.pnPerfil.Controls.Add(Me.Panel1)
        Me.pnPerfil.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnPerfil.Location = New System.Drawing.Point(0, 596)
        Me.pnPerfil.Name = "pnPerfil"
        Me.pnPerfil.Size = New System.Drawing.Size(247, 65)
        Me.pnPerfil.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_perfil)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(247, 65)
        Me.Panel1.TabIndex = 0
        '
        'btn_perfil
        '
        Me.btn_perfil.BackColor = System.Drawing.Color.Goldenrod
        Me.btn_perfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_perfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_perfil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_perfil.FlatAppearance.BorderSize = 0
        Me.btn_perfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_perfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_perfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_perfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_perfil.ForeColor = System.Drawing.Color.White
        Me.btn_perfil.Location = New System.Drawing.Point(0, 0)
        Me.btn_perfil.Name = "btn_perfil"
        Me.btn_perfil.Size = New System.Drawing.Size(247, 65)
        Me.btn_perfil.TabIndex = 8
        Me.btn_perfil.Text = "Mohammed"
        Me.btn_perfil.UseVisualStyleBackColor = False
        '
        'pnVentanas
        '
        Me.pnVentanas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnVentanas.Location = New System.Drawing.Point(247, 0)
        Me.pnVentanas.Name = "pnVentanas"
        Me.pnVentanas.Size = New System.Drawing.Size(937, 661)
        Me.pnVentanas.TabIndex = 2
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Menu_Operario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.pnVentanas)
        Me.Controls.Add(Me.pnLateral)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Menu_Operario"
        Me.Text = "Menu_Operario"
        Me.pnLateral.ResumeLayout(False)
        Me.tlpnMenu.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.pnPerfil.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnLateral As Panel
    Friend WithEvents tlpnMenu As TableLayoutPanel
    Friend WithEvents btVehiculos As Button
    Friend WithEvents btPatio As Button
    Friend WithEvents pnPerfil As Panel
    Friend WithEvents pnVentanas As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_perfil As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_scan_qr As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
