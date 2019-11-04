<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionarInspeccion
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSelec = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 290)
        Me.Panel1.TabIndex = 0
        '
        'btnSelec
        '
        Me.btnSelec.BackColor = System.Drawing.Color.DimGray
        Me.btnSelec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelec.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelec.ForeColor = System.Drawing.Color.Crimson
        Me.btnSelec.Location = New System.Drawing.Point(131, 321)
        Me.btnSelec.Name = "btnSelec"
        Me.btnSelec.Size = New System.Drawing.Size(163, 50)
        Me.btnSelec.TabIndex = 1
        Me.btnSelec.Text = "Seleccionar"
        Me.btnSelec.UseVisualStyleBackColor = False
        '
        'SeleccionarInspeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.btnSelec)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SeleccionarInspeccion"
        Me.Size = New System.Drawing.Size(437, 409)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSelec As Button
End Class
