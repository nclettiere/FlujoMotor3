<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerZonas
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
        Me.lblPatioInfo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FPContenido = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1.SuspendLayout
        Me.FPContenido.SuspendLayout
        Me.SuspendLayout
        '
        'lblPatioInfo
        '
        Me.lblPatioInfo.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblPatioInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPatioInfo.ForeColor = System.Drawing.Color.Orange
        Me.lblPatioInfo.Location = New System.Drawing.Point(0, 0)
        Me.lblPatioInfo.Name = "lblPatioInfo"
        Me.lblPatioInfo.Size = New System.Drawing.Size(497, 45)
        Me.lblPatioInfo.TabIndex = 0
        Me.lblPatioInfo.Text = "Viendo Zonas de Patio: "
        Me.lblPatioInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Panel1.Controls.Add(Me.lblPatioInfo)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(571, 45)
        Me.Panel1.TabIndex = 0
        '
        'FPContenido
        '
        Me.FPContenido.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FPContenido.Controls.Add(Me.Panel1)
        Me.FPContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FPContenido.Location = New System.Drawing.Point(0, 0)
        Me.FPContenido.MaximumSize = New System.Drawing.Size(500, 0)
        Me.FPContenido.Name = "FPContenido"
        Me.FPContenido.Size = New System.Drawing.Size(500, 285)
        Me.FPContenido.TabIndex = 1
        '
        'VerZonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FPContenido)
        Me.Name = "VerZonas"
        Me.Size = New System.Drawing.Size(503, 285)
        Me.Panel1.ResumeLayout(false)
        Me.FPContenido.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents lblPatioInfo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FPContenido As FlowLayoutPanel
End Class
