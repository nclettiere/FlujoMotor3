<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DependencySelector
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
        Me.lst_inspecciones = New System.Windows.Forms.ListBox()
        Me.btn_asignar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lst_inspecciones
        '
        Me.lst_inspecciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_inspecciones.FormattingEnabled = True
        Me.lst_inspecciones.Location = New System.Drawing.Point(0, 0)
        Me.lst_inspecciones.Name = "lst_inspecciones"
        Me.lst_inspecciones.Size = New System.Drawing.Size(333, 185)
        Me.lst_inspecciones.TabIndex = 0
        '
        'btn_asignar
        '
        Me.btn_asignar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_asignar.Location = New System.Drawing.Point(0, 185)
        Me.btn_asignar.Name = "btn_asignar"
        Me.btn_asignar.Size = New System.Drawing.Size(333, 23)
        Me.btn_asignar.TabIndex = 1
        Me.btn_asignar.Text = "Asignar"
        Me.btn_asignar.UseVisualStyleBackColor = True
        '
        'DependencySelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 208)
        Me.Controls.Add(Me.lst_inspecciones)
        Me.Controls.Add(Me.btn_asignar)
        Me.Name = "DependencySelector"
        Me.Text = "DependencySelector"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lst_inspecciones As ListBox
    Friend WithEvents btn_asignar As Button
End Class
