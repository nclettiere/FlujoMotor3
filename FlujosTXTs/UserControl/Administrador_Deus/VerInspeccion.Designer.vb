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
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'lblVehiculoVin
        '
        Me.lblVehiculoVin.AutoSize = true
        Me.lblVehiculoVin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblVehiculoVin.ForeColor = System.Drawing.Color.Crimson
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
        Me.GroupBox1.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox1.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(592, 557)
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
        Me.FlowInspecciones.Size = New System.Drawing.Size(580, 519)
        Me.FlowInspecciones.TabIndex = 0
        Me.FlowInspecciones.WrapContents = False
        '
        'btnAddInspeccion
        '
        Me.btnAddInspeccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddInspeccion.ForeColor = System.Drawing.Color.Crimson
        Me.btnAddInspeccion.Location = New System.Drawing.Point(456, 8)
        Me.btnAddInspeccion.Name = "btnAddInspeccion"
        Me.btnAddInspeccion.Size = New System.Drawing.Size(148, 34)
        Me.btnAddInspeccion.TabIndex = 3
        Me.btnAddInspeccion.Text = "Agregar Inspeccion"
        Me.btnAddInspeccion.UseVisualStyleBackColor = false
        '
        'VerInspeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Controls.Add(Me.btnAddInspeccion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblVehiculoVin)
        Me.Name = "VerInspeccion"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(618, 619)
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents lblVehiculoVin As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FlowInspecciones As FlowLayoutPanel
    Friend WithEvents btnAddInspeccion As Button
End Class
