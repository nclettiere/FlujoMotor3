<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionarTransportista
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ListaTransportistas = New BrightIdeasSoftware.FastDataListView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.ListaTransportistas,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ListaTransportistas
        '
        Me.ListaTransportistas.BackColor = System.Drawing.Color.White
        Me.ListaTransportistas.CellEditUseWholeCell = false
        Me.ListaTransportistas.DataSource = Nothing
        Me.ListaTransportistas.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListaTransportistas.Location = New System.Drawing.Point(0, 0)
        Me.ListaTransportistas.Name = "ListaTransportistas"
        Me.ListaTransportistas.ShowGroups = false
        Me.ListaTransportistas.Size = New System.Drawing.Size(341, 375)
        Me.ListaTransportistas.TabIndex = 0
        Me.ListaTransportistas.UseCompatibleStateImageBehavior = false
        Me.ListaTransportistas.View = System.Windows.Forms.View.Details
        Me.ListaTransportistas.VirtualMode = true
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Crimson
        Me.Button1.Location = New System.Drawing.Point(88, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Seleccionar"
        Me.Button1.UseVisualStyleBackColor = false
        '
        'SeleccionarTransportista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListaTransportistas)
        Me.Name = "SeleccionarTransportista"
        Me.Size = New System.Drawing.Size(341, 443)
        CType(Me.ListaTransportistas,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents ListaTransportistas As BrightIdeasSoftware.FastDataListView
    Friend WithEvents Button1 As Button
End Class
