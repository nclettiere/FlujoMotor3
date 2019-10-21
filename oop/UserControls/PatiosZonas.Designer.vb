<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatiosZonas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.flpPatios = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgPatio = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout
        Me.flpPatios.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.flpPatios)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Orange
        Me.GroupBox1.Location = New System.Drawing.Point(13, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(842, 629)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Lista de Patios"
        '
        'flpPatios
        '
        Me.flpPatios.AutoScroll = true
        Me.flpPatios.Controls.Add(Me.Panel1)
        Me.flpPatios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpPatios.Location = New System.Drawing.Point(3, 16)
        Me.flpPatios.Name = "flpPatios"
        Me.flpPatios.Size = New System.Drawing.Size(836, 610)
        Me.flpPatios.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(278, 161)
        Me.Panel1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightGray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Crimson
        Me.Button3.Location = New System.Drawing.Point(166, 120)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 26)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Ver Mas"
        Me.Button3.UseVisualStyleBackColor = false
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Crimson
        Me.Button2.Location = New System.Drawing.Point(16, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 26)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = false
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(13, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Direccion"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patio Nombre:"
        '
        'btnAgPatio
        '
        Me.btnAgPatio.BackColor = System.Drawing.Color.Silver
        Me.btnAgPatio.Enabled = false
        Me.btnAgPatio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgPatio.ForeColor = System.Drawing.Color.Orange
        Me.btnAgPatio.Location = New System.Drawing.Point(13, 11)
        Me.btnAgPatio.Name = "btnAgPatio"
        Me.btnAgPatio.Size = New System.Drawing.Size(210, 40)
        Me.btnAgPatio.TabIndex = 0
        Me.btnAgPatio.Text = "Agregar Patio"
        Me.btnAgPatio.UseVisualStyleBackColor = false
        '
        'PatiosZonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.Controls.Add(Me.btnAgPatio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PatiosZonas"
        Me.Size = New System.Drawing.Size(808, 708)
        Me.GroupBox1.ResumeLayout(false)
        Me.flpPatios.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents flpPatios As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgPatio As Button
End Class
