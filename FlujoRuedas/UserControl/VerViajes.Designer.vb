<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerViajes
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.DataGridViewLotes = New System.Windows.Forms.DataGridView()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.btEntregar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1.SuspendLayout
        CType(Me.DataGridViewLotes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(20, 20, 20, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(977, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mis Viajes"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.btEntregar)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(797, 451)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'DataGridViewLotes
        '
        Me.DataGridViewLotes.AllowUserToAddRows = false
        Me.DataGridViewLotes.AllowUserToDeleteRows = false
        Me.DataGridViewLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewLotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewLotes.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewLotes.MultiSelect = false
        Me.DataGridViewLotes.Name = "DataGridViewLotes"
        Me.DataGridViewLotes.ReadOnly = true
        Me.DataGridViewLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewLotes.Size = New System.Drawing.Size(1011, 284)
        Me.DataGridViewLotes.TabIndex = 1
        '
        'btEntregar
        '
        Me.btEntregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.btEntregar.BackColor = System.Drawing.Color.DimGray
        Me.btEntregar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btEntregar.FlatAppearance.BorderSize = 0
        Me.btEntregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEntregar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btEntregar.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btEntregar.Location = New System.Drawing.Point(329, 390)
        Me.btEntregar.Margin = New System.Windows.Forms.Padding(3, 15, 3, 3)
        Me.btEntregar.Name = "btEntregar"
        Me.btEntregar.Size = New System.Drawing.Size(358, 40)
        Me.btEntregar.TabIndex = 3
        Me.btEntregar.Text = "Entregar Lote"
        Me.btEntregar.UseVisualStyleBackColor = false
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridViewLotes)
        Me.Panel1.Location = New System.Drawing.Point(3, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1011, 284)
        Me.Panel1.TabIndex = 4
        '
        'VerViajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12!, 25!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.DoubleBuffered = true
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "VerViajes"
        Me.Size = New System.Drawing.Size(797, 451)
        Me.FlowLayoutPanel1.ResumeLayout(false)
        Me.FlowLayoutPanel1.PerformLayout
        CType(Me.DataGridViewLotes,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents DataGridViewLotes As DataGridView
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents btEntregar As Button
    Friend WithEvents Panel1 As Panel
End Class
