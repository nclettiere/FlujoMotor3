<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerInspeccion
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
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.rch_desc = New System.Windows.Forms.RichTextBox()
        Me.lbl_ubicacion = New System.Windows.Forms.Label()
        Me.lbl_actualizacion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(13, 13)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(39, 13)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Label1"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(13, 39)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(39, 13)
        Me.lbl_name.TabIndex = 1
        Me.lbl_name.Text = "Label2"
        '
        'rch_desc
        '
        Me.rch_desc.Enabled = False
        Me.rch_desc.Location = New System.Drawing.Point(16, 106)
        Me.rch_desc.Name = "rch_desc"
        Me.rch_desc.Size = New System.Drawing.Size(401, 128)
        Me.rch_desc.TabIndex = 3
        Me.rch_desc.Text = ""
        '
        'lbl_ubicacion
        '
        Me.lbl_ubicacion.AutoSize = True
        Me.lbl_ubicacion.Location = New System.Drawing.Point(13, 90)
        Me.lbl_ubicacion.Name = "lbl_ubicacion"
        Me.lbl_ubicacion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_ubicacion.TabIndex = 4
        Me.lbl_ubicacion.Text = "Descripcion"
        '
        'lbl_actualizacion
        '
        Me.lbl_actualizacion.AutoSize = True
        Me.lbl_actualizacion.Location = New System.Drawing.Point(13, 61)
        Me.lbl_actualizacion.Name = "lbl_actualizacion"
        Me.lbl_actualizacion.Size = New System.Drawing.Size(0, 13)
        Me.lbl_actualizacion.TabIndex = 5
        '
        'VerInspeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 246)
        Me.Controls.Add(Me.lbl_actualizacion)
        Me.Controls.Add(Me.lbl_ubicacion)
        Me.Controls.Add(Me.rch_desc)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "VerInspeccion"
        Me.ShowIcon = False
        Me.Text = "Ver Daño"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents rch_desc As RichTextBox
    Friend WithEvents lbl_ubicacion As Label
    Friend WithEvents lbl_actualizacion As Label
End Class
