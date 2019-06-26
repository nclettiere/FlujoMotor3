<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerLote
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.rch_desc = New System.Windows.Forms.RichTextBox()
        Me.lst_vin = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_rutaA = New System.Windows.Forms.Label()
        Me.lbl_rutaB = New System.Windows.Forms.Label()
        Me.lbl_client = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_name.Location = New System.Drawing.Point(8, 9)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(84, 24)
        Me.lbl_name.TabIndex = 0
        Me.lbl_name.Text = "Nombre:"
        '
        'rch_desc
        '
        Me.rch_desc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rch_desc.Enabled = False
        Me.rch_desc.Location = New System.Drawing.Point(6, 28)
        Me.rch_desc.Name = "rch_desc"
        Me.rch_desc.Size = New System.Drawing.Size(396, 102)
        Me.rch_desc.TabIndex = 1
        Me.rch_desc.Text = ""
        '
        'lst_vin
        '
        Me.lst_vin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lst_vin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lst_vin.FormattingEnabled = True
        Me.lst_vin.ItemHeight = 24
        Me.lst_vin.Location = New System.Drawing.Point(6, 32)
        Me.lst_vin.Name = "lst_vin"
        Me.lst_vin.Size = New System.Drawing.Size(396, 144)
        Me.lst_vin.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lst_vin)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Location = New System.Drawing.Point(12, 336)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 192)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "VEHICULOS EN LOTE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rch_desc)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox2.Location = New System.Drawing.Point(12, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 121)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DESCRIPCION"
        '
        'lbl_rutaA
        '
        Me.lbl_rutaA.AutoSize = True
        Me.lbl_rutaA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rutaA.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_rutaA.Location = New System.Drawing.Point(8, 99)
        Me.lbl_rutaA.Name = "lbl_rutaA"
        Me.lbl_rutaA.Size = New System.Drawing.Size(105, 24)
        Me.lbl_rutaA.TabIndex = 7
        Me.lbl_rutaA.Text = "Ruta Inicial:"
        '
        'lbl_rutaB
        '
        Me.lbl_rutaB.AutoSize = True
        Me.lbl_rutaB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rutaB.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_rutaB.Location = New System.Drawing.Point(8, 137)
        Me.lbl_rutaB.Name = "lbl_rutaB"
        Me.lbl_rutaB.Size = New System.Drawing.Size(104, 24)
        Me.lbl_rutaB.TabIndex = 8
        Me.lbl_rutaB.Text = "Ruta Final: "
        '
        'lbl_client
        '
        Me.lbl_client.AutoSize = True
        Me.lbl_client.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_client.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_client.Location = New System.Drawing.Point(8, 55)
        Me.lbl_client.Name = "lbl_client"
        Me.lbl_client.Size = New System.Drawing.Size(78, 24)
        Me.lbl_client.TabIndex = 9
        Me.lbl_client.Text = "Cliente: "
        '
        'VerLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(432, 540)
        Me.Controls.Add(Me.lbl_client)
        Me.Controls.Add(Me.lbl_rutaB)
        Me.Controls.Add(Me.lbl_rutaA)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_name)
        Me.Name = "VerLote"
        Me.Text = "VerLote"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_name As Label
    Friend WithEvents rch_desc As RichTextBox
    Friend WithEvents lst_vin As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_rutaA As Label
    Friend WithEvents lbl_rutaB As Label
    Friend WithEvents lbl_client As Label
End Class
