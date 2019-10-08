<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.pnMenuAutitos = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'pnMenuAutitos
        '
        Me.pnMenuAutitos.BackColor = System.Drawing.Color.Bisque
        Me.pnMenuAutitos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnMenuAutitos.Location = New System.Drawing.Point(0, 556)
        Me.pnMenuAutitos.Name = "pnMenuAutitos"
        Me.pnMenuAutitos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pnMenuAutitos.Size = New System.Drawing.Size(937, 65)
        Me.pnMenuAutitos.TabIndex = 2
        '
        'Transporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 621)
        Me.Controls.Add(Me.pnMenuAutitos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Transporte"
        Me.Text = "Transporte"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnMenuAutitos As Panel
End Class
