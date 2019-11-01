<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VerInspeccion
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
        Me.lblVehiculoVin = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlowInspecciones = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddInspeccion = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNuevoDanio = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblVehiculoVin
        '
        Me.lblVehiculoVin.AutoSize = True
        Me.lblVehiculoVin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehiculoVin.ForeColor = System.Drawing.Color.Orange
        Me.lblVehiculoVin.Location = New System.Drawing.Point(8, 14)
        Me.lblVehiculoVin.Name = "lblVehiculoVin"
        Me.lblVehiculoVin.Size = New System.Drawing.Size(363, 20)
        Me.lblVehiculoVin.TabIndex = 1
        Me.lblVehiculoVin.Text = "Inspecciones del Vehiculo: ##################"
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.FlowInspecciones)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.Orange
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 531)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado Inspecciones"
        '
        'FlowInspecciones
        '
        Me.FlowInspecciones.AutoScroll = True
        Me.FlowInspecciones.AutoSize = True
        Me.FlowInspecciones.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowInspecciones.Location = New System.Drawing.Point(6, 19)
        Me.FlowInspecciones.Name = "FlowInspecciones"
        Me.FlowInspecciones.Size = New System.Drawing.Size(569, 509)
        Me.FlowInspecciones.TabIndex = 0
        Me.FlowInspecciones.WrapContents = False
        '
        'btnAddInspeccion
        '
        Me.btnAddInspeccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddInspeccion.ForeColor = System.Drawing.Color.Orange
        Me.btnAddInspeccion.Location = New System.Drawing.Point(456, 8)
        Me.btnAddInspeccion.Name = "btnAddInspeccion"
        Me.btnAddInspeccion.Size = New System.Drawing.Size(148, 34)
        Me.btnAddInspeccion.TabIndex = 3
        Me.btnAddInspeccion.Text = "Agregar Inspeccion"
        Me.btnAddInspeccion.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(592, 563)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(584, 537)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inspecciones"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(584, 537)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Danios"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnNuevoDanio)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 531)
        Me.Panel1.TabIndex = 0
        '
        'btnNuevoDanio
        '
        Me.btnNuevoDanio.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNuevoDanio.ForeColor = System.Drawing.Color.Orange
        Me.btnNuevoDanio.Location = New System.Drawing.Point(427, 3)
        Me.btnNuevoDanio.Name = "btnNuevoDanio"
        Me.btnNuevoDanio.Size = New System.Drawing.Size(148, 34)
        Me.btnNuevoDanio.TabIndex = 5
        Me.btnNuevoDanio.Text = "Agregar a Danio Anterior"
        Me.btnNuevoDanio.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 43)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(572, 485)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'VerInspeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnAddInspeccion)
        Me.Controls.Add(Me.lblVehiculoVin)
        Me.Name = "VerInspeccion"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(618, 619)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub

    Friend WithEvents lblVehiculoVin As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FlowInspecciones As FlowLayoutPanel
    Friend WithEvents btnAddInspeccion As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnNuevoDanio As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
