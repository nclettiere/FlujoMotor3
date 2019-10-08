<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarDanio
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rtbx = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btAdjCamara = New System.Windows.Forms.Button()
        Me.btnAdjArchivo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PBDanio = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.Panel3.SuspendLayout
        CType(Me.PBDanio,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(13, 56)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(607, 192)
        Me.FlowLayoutPanel1.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingresar Danios"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rtbx)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(3, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(604, 76)
        Me.Panel2.TabIndex = 24
        '
        'rtbx
        '
        Me.rtbx.Location = New System.Drawing.Point(189, 0)
        Me.rtbx.Name = "rtbx"
        Me.rtbx.Size = New System.Drawing.Size(412, 69)
        Me.rtbx.TabIndex = 3
        Me.rtbx.Text = ""
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(3, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 26)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "DESCRIPCION"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btAdjCamara)
        Me.Panel3.Controls.Add(Me.btnAdjArchivo)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(3, 131)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(604, 68)
        Me.Panel3.TabIndex = 24
        '
        'btAdjCamara
        '
        Me.btAdjCamara.BackColor = System.Drawing.Color.DimGray
        Me.btAdjCamara.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btAdjCamara.FlatAppearance.BorderSize = 0
        Me.btAdjCamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAdjCamara.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btAdjCamara.ForeColor = System.Drawing.Color.Orange
        Me.btAdjCamara.Location = New System.Drawing.Point(157, 6)
        Me.btAdjCamara.Name = "btAdjCamara"
        Me.btAdjCamara.Size = New System.Drawing.Size(221, 48)
        Me.btAdjCamara.TabIndex = 4
        Me.btAdjCamara.Text = "Desde La Camara"
        Me.btAdjCamara.UseVisualStyleBackColor = false
        '
        'btnAdjArchivo
        '
        Me.btnAdjArchivo.BackColor = System.Drawing.Color.DimGray
        Me.btnAdjArchivo.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnAdjArchivo.FlatAppearance.BorderSize = 0
        Me.btnAdjArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdjArchivo.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAdjArchivo.ForeColor = System.Drawing.Color.Orange
        Me.btnAdjArchivo.Location = New System.Drawing.Point(384, 6)
        Me.btnAdjArchivo.Name = "btnAdjArchivo"
        Me.btnAdjArchivo.Size = New System.Drawing.Size(217, 48)
        Me.btnAdjArchivo.TabIndex = 5
        Me.btnAdjArchivo.Text = "Archivo"
        Me.btnAdjArchivo.UseVisualStyleBackColor = false
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(8, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Adjuntar Foto"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PBDanio
        '
        Me.PBDanio.Location = New System.Drawing.Point(29, 273)
        Me.PBDanio.Name = "PBDanio"
        Me.PBDanio.Size = New System.Drawing.Size(362, 242)
        Me.PBDanio.TabIndex = 25
        Me.PBDanio.TabStop = false
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(16, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 26)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Vehiculo: ###########"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.DimGray
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Orange
        Me.btnAgregar.Location = New System.Drawing.Point(400, 273)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(217, 48)
        Me.btnAgregar.TabIndex = 29
        Me.btnAgregar.Text = "Agregar Danio"
        Me.btnAgregar.UseVisualStyleBackColor = false
        '
        'AgregarDanio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.PBDanio)
        Me.Name = "AgregarDanio"
        Me.Size = New System.Drawing.Size(634, 535)
        Me.FlowLayoutPanel1.ResumeLayout(false)
        Me.FlowLayoutPanel1.PerformLayout
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.Panel3.ResumeLayout(false)
        Me.Panel3.PerformLayout
        CType(Me.PBDanio,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rtbx As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btAdjCamara As Button
    Friend WithEvents btnAdjArchivo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PBDanio As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnAgregar As Button
End Class
