<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarPatio
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
        Me.tbxPatioNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxDir = New System.Windows.Forms.TextBox()
        Me.SuspendLayout
        '
        'tbxPatioNombre
        '
        Me.tbxPatioNombre.Location = New System.Drawing.Point(16, 72)
        Me.tbxPatioNombre.Name = "tbxPatioNombre"
        Me.tbxPatioNombre.Size = New System.Drawing.Size(250, 20)
        Me.tbxPatioNombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Agregar Patio"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(13, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Patio Nombre:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Crimson
        Me.Button1.Location = New System.Drawing.Point(16, 149)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 36)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = false
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(13, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Direccion (Google Maps):"
        '
        'tbxDir
        '
        Me.tbxDir.Location = New System.Drawing.Point(16, 113)
        Me.tbxDir.Name = "tbxDir"
        Me.tbxDir.Size = New System.Drawing.Size(250, 20)
        Me.tbxDir.TabIndex = 4
        '
        'AgregarPatio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxDir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbxPatioNombre)
        Me.Name = "AgregarPatio"
        Me.Size = New System.Drawing.Size(290, 204)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents tbxPatioNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxDir As TextBox
End Class
