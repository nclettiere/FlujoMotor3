<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarLote
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
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rtbDesc = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxPatios = New System.Windows.Forms.ComboBox()
        Me.Panel2.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.DarkGray
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Crimson
        Me.btnAgregar.Location = New System.Drawing.Point(17, 313)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(297, 35)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = false
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(14, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Descripcion"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.cbxPatios)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.rtbDesc)
        Me.Panel2.Controls.Add(Me.btnAgregar)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.tbxNombre)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(329, 364)
        Me.Panel2.TabIndex = 0
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(16, 75)
        Me.tbxNombre.MaxLength = 24
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(297, 20)
        Me.tbxNombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(13, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lote Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(13, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agregar Lote"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(329, 364)
        Me.Panel1.TabIndex = 2
        '
        'rtbDesc
        '
        Me.rtbDesc.Location = New System.Drawing.Point(17, 132)
        Me.rtbDesc.Name = "rtbDesc"
        Me.rtbDesc.Size = New System.Drawing.Size(296, 85)
        Me.rtbDesc.TabIndex = 23
        Me.rtbDesc.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(13, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Patio"
        '
        'cbxPatios
        '
        Me.cbxPatios.FormattingEnabled = true
        Me.cbxPatios.Location = New System.Drawing.Point(16, 257)
        Me.cbxPatios.Name = "cbxPatios"
        Me.cbxPatios.Size = New System.Drawing.Size(297, 21)
        Me.cbxPatios.TabIndex = 25
        '
        'AgregarLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AgregarLote"
        Me.Size = New System.Drawing.Size(329, 364)
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbxPatios As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents rtbDesc As RichTextBox
    Friend WithEvents tbxNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
