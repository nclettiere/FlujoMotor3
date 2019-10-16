<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionarLote
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
        Me.listaLotes = New BrightIdeasSoftware.FastDataListView()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        CType(Me.listaLotes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'listaLotes
        '
        Me.listaLotes.CellEditUseWholeCell = false
        Me.listaLotes.DataSource = Nothing
        Me.listaLotes.Dock = System.Windows.Forms.DockStyle.Top
        Me.listaLotes.FullRowSelect = true
        Me.listaLotes.Location = New System.Drawing.Point(0, 0)
        Me.listaLotes.Name = "listaLotes"
        Me.listaLotes.ShowGroups = false
        Me.listaLotes.Size = New System.Drawing.Size(303, 335)
        Me.listaLotes.TabIndex = 0
        Me.listaLotes.UseCompatibleStateImageBehavior = false
        Me.listaLotes.View = System.Windows.Forms.View.Details
        Me.listaLotes.VirtualMode = true
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.Color.DarkGray
        Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSeleccionar.ForeColor = System.Drawing.Color.Crimson
        Me.btnSeleccionar.Location = New System.Drawing.Point(0, 333)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(303, 44)
        Me.btnSeleccionar.TabIndex = 26
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = false
        Me.btnSeleccionar.Visible = false
        '
        'SeleccionarLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.listaLotes)
        Me.Name = "SeleccionarLote"
        Me.Size = New System.Drawing.Size(303, 377)
        CType(Me.listaLotes,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents listaLotes As BrightIdeasSoftware.FastDataListView
    Friend WithEvents btnSeleccionar As Button
End Class
