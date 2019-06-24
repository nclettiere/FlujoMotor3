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
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_dpenency = New System.Windows.Forms.Button()
        Me.chk_depnd = New System.Windows.Forms.CheckBox()
        Me.Adjuntador = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(12, 18)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(75, 13)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Agregar Danio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripcion"
        '
        'rch_desc
        '
        Me.rch_desc.Location = New System.Drawing.Point(15, 61)
        Me.rch_desc.Name = "rch_desc"
        Me.rch_desc.Size = New System.Drawing.Size(331, 71)
        Me.rch_desc.TabIndex = 2
        Me.rch_desc.Text = ""
        '
        'btn_agregar
        '
        Me.btn_agregar.Enabled = False
        Me.btn_agregar.Location = New System.Drawing.Point(207, 255)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(139, 23)
        Me.btn_agregar.TabIndex = 5
        Me.btn_agregar.Text = "Aceptar y Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_dpenency
        '
        Me.btn_dpenency.Enabled = False
        Me.btn_dpenency.Location = New System.Drawing.Point(237, 149)
        Me.btn_dpenency.Name = "btn_dpenency"
        Me.btn_dpenency.Size = New System.Drawing.Size(109, 23)
        Me.btn_dpenency.TabIndex = 9
        Me.btn_dpenency.Text = "Asignar"
        Me.btn_dpenency.UseVisualStyleBackColor = True
        '
        'chk_depnd
        '
        Me.chk_depnd.AutoSize = True
        Me.chk_depnd.Location = New System.Drawing.Point(15, 153)
        Me.chk_depnd.Name = "chk_depnd"
        Me.chk_depnd.Size = New System.Drawing.Size(88, 17)
        Me.chk_depnd.TabIndex = 8
        Me.chk_depnd.Text = "Depende de:"
        Me.chk_depnd.UseVisualStyleBackColor = True
        '
        'AgregarInspeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 290)
        Me.Controls.Add(Me.btn_dpenency)
        Me.Controls.Add(Me.chk_depnd)
        Me.Controls.Add(Me.btn_agregar)
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
    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_dpenency As Button
    Friend WithEvents chk_depnd As CheckBox
    Friend WithEvents Adjuntador As OpenFileDialog
End Class
