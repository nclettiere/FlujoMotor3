<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionarCSV
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.lbl_ub = New System.Windows.Forms.Label()
        Me.btn_ub = New System.Windows.Forms.Button()
        Me.lbl_pa = New System.Windows.Forms.Label()
        Me.btn_pa = New System.Windows.Forms.Button()
        Me.lbl_veh = New System.Windows.Forms.Label()
        Me.btn_ve = New System.Windows.Forms.Button()
        Me.lbl_op = New System.Windows.Forms.Label()
        Me.btn_op = New System.Windows.Forms.Button()
        Me.AbrirCSV = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btn_aceptar)
        Me.Panel1.Controls.Add(Me.lbl_ub)
        Me.Panel1.Controls.Add(Me.btn_ub)
        Me.Panel1.Controls.Add(Me.lbl_pa)
        Me.Panel1.Controls.Add(Me.btn_pa)
        Me.Panel1.Controls.Add(Me.lbl_veh)
        Me.Panel1.Controls.Add(Me.btn_ve)
        Me.Panel1.Controls.Add(Me.lbl_op)
        Me.Panel1.Controls.Add(Me.btn_op)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 246)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(284, 52)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Selecciona los CSV correspondientes"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Enabled = False
        Me.btn_aceptar.Location = New System.Drawing.Point(16, 211)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(256, 23)
        Me.btn_aceptar.TabIndex = 17
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'lbl_ub
        '
        Me.lbl_ub.AutoSize = True
        Me.lbl_ub.Location = New System.Drawing.Point(13, 151)
        Me.lbl_ub.Name = "lbl_ub"
        Me.lbl_ub.Size = New System.Drawing.Size(90, 13)
        Me.lbl_ub.TabIndex = 16
        Me.lbl_ub.Text = "CSV Ubicaciones"
        '
        'btn_ub
        '
        Me.btn_ub.Location = New System.Drawing.Point(197, 142)
        Me.btn_ub.Name = "btn_ub"
        Me.btn_ub.Size = New System.Drawing.Size(75, 23)
        Me.btn_ub.TabIndex = 15
        Me.btn_ub.Text = "Seleccionar"
        Me.btn_ub.UseVisualStyleBackColor = True
        '
        'lbl_pa
        '
        Me.lbl_pa.AutoSize = True
        Me.lbl_pa.Location = New System.Drawing.Point(13, 122)
        Me.lbl_pa.Name = "lbl_pa"
        Me.lbl_pa.Size = New System.Drawing.Size(60, 13)
        Me.lbl_pa.TabIndex = 14
        Me.lbl_pa.Text = "CSV Patios"
        '
        'btn_pa
        '
        Me.btn_pa.Location = New System.Drawing.Point(197, 113)
        Me.btn_pa.Name = "btn_pa"
        Me.btn_pa.Size = New System.Drawing.Size(75, 23)
        Me.btn_pa.TabIndex = 13
        Me.btn_pa.Text = "Seleccionar"
        Me.btn_pa.UseVisualStyleBackColor = True
        '
        'lbl_veh
        '
        Me.lbl_veh.AutoSize = True
        Me.lbl_veh.Location = New System.Drawing.Point(13, 93)
        Me.lbl_veh.Name = "lbl_veh"
        Me.lbl_veh.Size = New System.Drawing.Size(77, 13)
        Me.lbl_veh.TabIndex = 12
        Me.lbl_veh.Text = "CSV Vehiculos"
        '
        'btn_ve
        '
        Me.btn_ve.Location = New System.Drawing.Point(197, 84)
        Me.btn_ve.Name = "btn_ve"
        Me.btn_ve.Size = New System.Drawing.Size(75, 23)
        Me.btn_ve.TabIndex = 11
        Me.btn_ve.Text = "Seleccionar"
        Me.btn_ve.UseVisualStyleBackColor = True
        '
        'lbl_op
        '
        Me.lbl_op.AutoSize = True
        Me.lbl_op.Location = New System.Drawing.Point(13, 64)
        Me.lbl_op.Name = "lbl_op"
        Me.lbl_op.Size = New System.Drawing.Size(76, 13)
        Me.lbl_op.TabIndex = 10
        Me.lbl_op.Text = "CSV Operarios"
        '
        'btn_op
        '
        Me.btn_op.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_op.Location = New System.Drawing.Point(197, 55)
        Me.btn_op.Name = "btn_op"
        Me.btn_op.Size = New System.Drawing.Size(75, 23)
        Me.btn_op.TabIndex = 9
        Me.btn_op.Text = "Seleccionar"
        Me.btn_op.UseVisualStyleBackColor = True
        '
        'AbrirCSV
        '
        Me.AbrirCSV.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "CSV Inspecciones"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(197, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Seleccionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SeleccionarCSV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 246)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SeleccionarCSV"
        Me.Text = "Seleccione los CSV"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents lbl_ub As Label
    Friend WithEvents btn_ub As Button
    Friend WithEvents lbl_pa As Label
    Friend WithEvents btn_pa As Button
    Friend WithEvents lbl_veh As Label
    Friend WithEvents btn_ve As Button
    Friend WithEvents lbl_op As Label
    Friend WithEvents btn_op As Button
    Friend WithEvents AbrirCSV As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
