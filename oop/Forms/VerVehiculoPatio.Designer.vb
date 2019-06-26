<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VerVehiculoPatio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lst_inspecciones = New System.Windows.Forms.ListBox()
        Me.btn_inspeccion = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.pnGuardar = New System.Windows.Forms.Panel()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.labVIN = New System.Windows.Forms.Label()
        Me.tbx_posA = New System.Windows.Forms.TextBox()
        Me.txb_PosB = New System.Windows.Forms.TextBox()
        Me.cbx_patios = New System.Windows.Forms.ComboBox()
        Me.chk_3 = New System.Windows.Forms.CheckBox()
        Me.chk_1 = New System.Windows.Forms.CheckBox()
        Me.chk_2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tabVehiculo = New System.Windows.Forms.TableLayoutPanel()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.pnGuardar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabVehiculo.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lst_inspecciones
        '
        Me.lst_inspecciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lst_inspecciones.FormattingEnabled = True
        Me.lst_inspecciones.ItemHeight = 20
        Me.lst_inspecciones.Location = New System.Drawing.Point(0, 126)
        Me.lst_inspecciones.Name = "lst_inspecciones"
        Me.lst_inspecciones.Size = New System.Drawing.Size(452, 184)
        Me.lst_inspecciones.TabIndex = 2
        '
        'btn_inspeccion
        '
        Me.btn_inspeccion.BackgroundImage = Global.oop.My.Resources.Resources.boton_buscar
        Me.btn_inspeccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_inspeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inspeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inspeccion.ForeColor = System.Drawing.Color.White
        Me.btn_inspeccion.Location = New System.Drawing.Point(-47, 0)
        Me.btn_inspeccion.Name = "btn_inspeccion"
        Me.btn_inspeccion.Size = New System.Drawing.Size(272, 71)
        Me.btn_inspeccion.TabIndex = 0
        Me.btn_inspeccion.Text = "Nueva Inspeccion"
        Me.btn_inspeccion.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lst_inspecciones)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btn_inspeccion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(452, 310)
        Me.Panel2.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Historial De Inspecciones"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(458, 316)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Inspecciones"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'pnGuardar
        '
        Me.pnGuardar.Controls.Add(Me.btn_guardar)
        Me.pnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnGuardar.Location = New System.Drawing.Point(3, 235)
        Me.pnGuardar.Name = "pnGuardar"
        Me.pnGuardar.Size = New System.Drawing.Size(452, 78)
        Me.pnGuardar.TabIndex = 19
        '
        'btn_guardar
        '
        Me.btn_guardar.BackgroundImage = Global.oop.My.Resources.Resources.boton_buscar
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_guardar.FlatAppearance.BorderSize = 0
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Location = New System.Drawing.Point(0, 0)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(452, 78)
        Me.btn_guardar.TabIndex = 18
        Me.btn_guardar.Text = "GUARDAR"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label7.Location = New System.Drawing.Point(3, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 54)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "PATIO  :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label6.Location = New System.Drawing.Point(3, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 54)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "POSICION B  :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labVIN
        '
        Me.labVIN.AutoSize = True
        Me.labVIN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labVIN.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labVIN.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.labVIN.Location = New System.Drawing.Point(3, 0)
        Me.labVIN.Name = "labVIN"
        Me.labVIN.Size = New System.Drawing.Size(140, 54)
        Me.labVIN.TabIndex = 18
        Me.labVIN.Text = "POSICION A  :"
        Me.labVIN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_posA
        '
        Me.tbx_posA.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_posA.Enabled = False
        Me.tbx_posA.Font = New System.Drawing.Font("Arial Narrow", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_posA.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.tbx_posA.Location = New System.Drawing.Point(149, 10)
        Me.tbx_posA.Name = "tbx_posA"
        Me.tbx_posA.Size = New System.Drawing.Size(244, 34)
        Me.tbx_posA.TabIndex = 12
        '
        'txb_PosB
        '
        Me.txb_PosB.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txb_PosB.Enabled = False
        Me.txb_PosB.Font = New System.Drawing.Font("Arial Narrow", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_PosB.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txb_PosB.Location = New System.Drawing.Point(149, 64)
        Me.txb_PosB.Name = "txb_PosB"
        Me.txb_PosB.Size = New System.Drawing.Size(244, 34)
        Me.txb_PosB.TabIndex = 13
        '
        'cbx_patios
        '
        Me.cbx_patios.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbx_patios.Enabled = False
        Me.cbx_patios.Font = New System.Drawing.Font("Arial Narrow", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_patios.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.cbx_patios.FormattingEnabled = True
        Me.cbx_patios.Location = New System.Drawing.Point(149, 117)
        Me.cbx_patios.Name = "cbx_patios"
        Me.cbx_patios.Size = New System.Drawing.Size(244, 35)
        Me.cbx_patios.TabIndex = 14
        '
        'chk_3
        '
        Me.chk_3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_3.AutoSize = True
        Me.chk_3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk_3.Location = New System.Drawing.Point(399, 128)
        Me.chk_3.Name = "chk_3"
        Me.chk_3.Size = New System.Drawing.Size(38, 14)
        Me.chk_3.TabIndex = 17
        Me.chk_3.UseVisualStyleBackColor = True
        '
        'chk_1
        '
        Me.chk_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_1.AutoSize = True
        Me.chk_1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk_1.Location = New System.Drawing.Point(399, 20)
        Me.chk_1.Name = "chk_1"
        Me.chk_1.Size = New System.Drawing.Size(38, 14)
        Me.chk_1.TabIndex = 15
        Me.chk_1.UseVisualStyleBackColor = True
        '
        'chk_2
        '
        Me.chk_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_2.AutoSize = True
        Me.chk_2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk_2.Location = New System.Drawing.Point(399, 74)
        Me.chk_2.Name = "chk_2"
        Me.chk_2.Size = New System.Drawing.Size(38, 14)
        Me.chk_2.TabIndex = 16
        Me.chk_2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.tabVehiculo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 190)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "VEHICULO"
        '
        'tabVehiculo
        '
        Me.tabVehiculo.ColumnCount = 3
        Me.tabVehiculo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tabVehiculo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.18654!))
        Me.tabVehiculo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.785933!))
        Me.tabVehiculo.Controls.Add(Me.Label7, 0, 2)
        Me.tabVehiculo.Controls.Add(Me.Label6, 0, 1)
        Me.tabVehiculo.Controls.Add(Me.labVIN, 0, 0)
        Me.tabVehiculo.Controls.Add(Me.tbx_posA, 1, 0)
        Me.tabVehiculo.Controls.Add(Me.txb_PosB, 1, 1)
        Me.tabVehiculo.Controls.Add(Me.cbx_patios, 1, 2)
        Me.tabVehiculo.Controls.Add(Me.chk_3, 2, 2)
        Me.tabVehiculo.Controls.Add(Me.chk_1, 2, 0)
        Me.tabVehiculo.Controls.Add(Me.chk_2, 2, 1)
        Me.tabVehiculo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabVehiculo.Location = New System.Drawing.Point(3, 25)
        Me.tabVehiculo.Name = "tabVehiculo"
        Me.tabVehiculo.RowCount = 3
        Me.tabVehiculo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tabVehiculo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tabVehiculo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tabVehiculo.Size = New System.Drawing.Size(440, 162)
        Me.tabVehiculo.TabIndex = 20
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.pnGuardar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(458, 316)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ubicacion"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(466, 349)
        Me.TabControl1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(466, 349)
        Me.Panel1.TabIndex = 1
        '
        'VerVehiculoPatio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 349)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "VerVehiculoPatio"
        Me.ShowIcon = False
        Me.Text = "Ver Vehiculo en el Patio"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.pnGuardar.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.tabVehiculo.ResumeLayout(False)
        Me.tabVehiculo.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lst_inspecciones As ListBox
    Friend WithEvents btn_inspeccion As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents pnGuardar As Panel
    Friend WithEvents btn_guardar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents labVIN As Label
    Friend WithEvents tbx_posA As TextBox
    Friend WithEvents txb_PosB As TextBox
    Friend WithEvents cbx_patios As ComboBox
    Friend WithEvents chk_3 As CheckBox
    Friend WithEvents chk_1 As CheckBox
    Friend WithEvents chk_2 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tabVehiculo As TableLayoutPanel
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Panel1 As Panel
End Class
