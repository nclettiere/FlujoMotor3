<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarInspeccion
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rch_desc = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbx_ubicacion = New System.Windows.Forms.TextBox()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.tbx_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(12, 18)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(99, 13)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Agregar Inspeccion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripcion"
        '
        'rch_desc
        '
        Me.rch_desc.Location = New System.Drawing.Point(15, 127)
        Me.rch_desc.Name = "rch_desc"
        Me.rch_desc.Size = New System.Drawing.Size(331, 71)
        Me.rch_desc.TabIndex = 2
        Me.rch_desc.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ubicacion:"
        '
        'tbx_ubicacion
        '
        Me.tbx_ubicacion.Location = New System.Drawing.Point(76, 204)
        Me.tbx_ubicacion.Name = "tbx_ubicacion"
        Me.tbx_ubicacion.Size = New System.Drawing.Size(270, 20)
        Me.tbx_ubicacion.TabIndex = 4
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(206, 255)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(139, 23)
        Me.btn_agregar.TabIndex = 5
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'tbx_name
        '
        Me.tbx_name.Location = New System.Drawing.Point(76, 61)
        Me.tbx_name.Name = "tbx_name"
        Me.tbx_name.Size = New System.Drawing.Size(270, 20)
        Me.tbx_name.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nombre"
        '
        'AgregarInspeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 290)
        Me.Controls.Add(Me.tbx_name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.tbx_ubicacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rch_desc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "AgregarInspeccion"
        Me.Text = "AgregarInspeccion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rch_desc As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbx_ubicacion As TextBox
    Friend WithEvents btn_agregar As Button
    Friend WithEvents tbx_name As TextBox
    Friend WithEvents Label1 As Label
End Class
