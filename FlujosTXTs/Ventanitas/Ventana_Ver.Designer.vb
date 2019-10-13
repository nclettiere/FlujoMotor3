<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana_Ver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventana_Ver))
        Me.mainContent = New System.Windows.Forms.Panel()
        Me.SuspendLayout
        '
        'mainContent
        '
        Me.mainContent.AutoScroll = true
        Me.mainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainContent.Location = New System.Drawing.Point(0, 0)
        Me.mainContent.Name = "mainContent"
        Me.mainContent.Size = New System.Drawing.Size(972, 452)
        Me.mainContent.TabIndex = 0
        '
        'Ventana_Ver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 452)
        Me.Controls.Add(Me.mainContent)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Ventana_Ver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informacion"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents mainContent As Panel
End Class
