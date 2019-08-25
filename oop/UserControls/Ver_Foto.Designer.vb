<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ver_Foto
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
        Me.PbFoto = New System.Windows.Forms.PictureBox()
        CType(Me.PbFoto,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PbFoto
        '
        Me.PbFoto.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbFoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbFoto.Location = New System.Drawing.Point(0, 0)
        Me.PbFoto.Name = "PbFoto"
        Me.PbFoto.Size = New System.Drawing.Size(150, 150)
        Me.PbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PbFoto.TabIndex = 0
        Me.PbFoto.TabStop = false
        '
        'Ver_Foto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.Controls.Add(Me.PbFoto)
        Me.Name = "Ver_Foto"
        CType(Me.PbFoto,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PbFoto As PictureBox
End Class
