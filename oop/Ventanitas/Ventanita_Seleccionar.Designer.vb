<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventanita_Seleccionar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventanita_Seleccionar))
        Me.MainContent = New System.Windows.Forms.Panel()
        Me.SuspendLayout
        '
        'MainContent
        '
        Me.MainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainContent.Location = New System.Drawing.Point(0, 0)
        Me.MainContent.Name = "MainContent"
        Me.MainContent.Size = New System.Drawing.Size(366, 436)
        Me.MainContent.TabIndex = 0
        '
        'Ventanita_Seleccionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 436)
        Me.Controls.Add(Me.MainContent)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Ventanita_Seleccionar"
        Me.Text = "Seleccionar"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents MainContent As Panel
End Class
