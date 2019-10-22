<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerDanios
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
        Me.FlowInspecciones = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout
        Me.FlowInspecciones.SuspendLayout
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = true
        Me.GroupBox1.Controls.Add(Me.FlowInspecciones)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(727, 301)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Danios"
        '
        'FlowInspecciones
        '
        Me.FlowInspecciones.AutoScroll = true
        Me.FlowInspecciones.AutoSize = true
        Me.FlowInspecciones.Controls.Add(Me.Panel1)
        Me.FlowInspecciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowInspecciones.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowInspecciones.Location = New System.Drawing.Point(3, 16)
        Me.FlowInspecciones.Name = "FlowInspecciones"
        Me.FlowInspecciones.Size = New System.Drawing.Size(721, 282)
        Me.FlowInspecciones.TabIndex = 0
        Me.FlowInspecciones.WrapContents = false
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(690, 276)
        Me.Panel1.TabIndex = 0
        '
        'VerDanios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "VerDanios"
        Me.Size = New System.Drawing.Size(727, 301)
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.FlowInspecciones.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FlowInspecciones As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
End Class
