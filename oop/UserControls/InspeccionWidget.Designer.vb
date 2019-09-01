<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InspeccionWidget
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
        Me.FlowContent = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblId = New System.Windows.Forms.Label()
        Me.rchtbxDesc = New System.Windows.Forms.RichTextBox()
        Me.btnFoto = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblOp = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.FlowContent.SuspendLayout
        Me.SuspendLayout
        '
        'FlowContent
        '
        Me.FlowContent.AutoSize = true
        Me.FlowContent.Controls.Add(Me.lblId)
        Me.FlowContent.Controls.Add(Me.rchtbxDesc)
        Me.FlowContent.Controls.Add(Me.btnFoto)
        Me.FlowContent.Controls.Add(Me.Button1)
        Me.FlowContent.Controls.Add(Me.lblOp)
        Me.FlowContent.Controls.Add(Me.lblfecha)
        Me.FlowContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowContent.Location = New System.Drawing.Point(0, 0)
        Me.FlowContent.Name = "FlowContent"
        Me.FlowContent.Size = New System.Drawing.Size(500, 181)
        Me.FlowContent.TabIndex = 0
        '
        'lblId
        '
        Me.lblId.AutoSize = true
        Me.lblId.Location = New System.Drawing.Point(3, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(39, 13)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "Label1"
        '
        'rchtbxDesc
        '
        Me.rchtbxDesc.Location = New System.Drawing.Point(48, 3)
        Me.rchtbxDesc.Name = "rchtbxDesc"
        Me.rchtbxDesc.Size = New System.Drawing.Size(336, 96)
        Me.rchtbxDesc.TabIndex = 1
        Me.rchtbxDesc.Text = ""
        '
        'btnFoto
        '
        Me.btnFoto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnFoto.BackColor = System.Drawing.Color.DimGray
        Me.btnFoto.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnFoto.FlatAppearance.BorderSize = 0
        Me.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoto.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnFoto.ForeColor = System.Drawing.Color.Orange
        Me.btnFoto.Location = New System.Drawing.Point(3, 105)
        Me.btnFoto.MaximumSize = New System.Drawing.Size(143, 51)
        Me.btnFoto.MinimumSize = New System.Drawing.Size(143, 51)
        Me.btnFoto.Name = "btnFoto"
        Me.btnFoto.Size = New System.Drawing.Size(143, 51)
        Me.btnFoto.TabIndex = 2
        Me.btnFoto.Text = "foto"
        Me.btnFoto.UseVisualStyleBackColor = false
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Orange
        Me.Button1.Location = New System.Drawing.Point(152, 105)
        Me.Button1.MaximumSize = New System.Drawing.Size(143, 51)
        Me.Button1.MinimumSize = New System.Drawing.Size(143, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 51)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "danio"
        Me.Button1.UseVisualStyleBackColor = false
        '
        'lblOp
        '
        Me.lblOp.AutoSize = true
        Me.lblOp.Location = New System.Drawing.Point(301, 102)
        Me.lblOp.Name = "lblOp"
        Me.lblOp.Size = New System.Drawing.Size(39, 13)
        Me.lblOp.TabIndex = 4
        Me.lblOp.Text = "Label2"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = true
        Me.lblfecha.Location = New System.Drawing.Point(346, 102)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(39, 13)
        Me.lblfecha.TabIndex = 5
        Me.lblfecha.Text = "Label3"
        '
        'InspeccionWidget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.Controls.Add(Me.FlowContent)
        Me.MaximumSize = New System.Drawing.Size(500, 250)
        Me.MinimumSize = New System.Drawing.Size(300, 150)
        Me.Name = "InspeccionWidget"
        Me.Size = New System.Drawing.Size(500, 181)
        Me.FlowContent.ResumeLayout(false)
        Me.FlowContent.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents FlowContent As FlowLayoutPanel
    Friend WithEvents lblId As Label
    Friend WithEvents rchtbxDesc As RichTextBox
    Friend WithEvents btnFoto As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblOp As Label
    Friend WithEvents lblfecha As Label
End Class
