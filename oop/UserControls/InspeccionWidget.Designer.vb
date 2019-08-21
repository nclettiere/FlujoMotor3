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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rchtbxDesc = New System.Windows.Forms.RichTextBox()
        Me.btnVerDan = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.Panel3.SuspendLayout
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.93421!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.06579!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(742, 96)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_name)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(170, 90)
        Me.Panel1.TabIndex = 0
        '
        'lbl_name
        '
        Me.lbl_name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_name.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.Orange
        Me.lbl_name.Location = New System.Drawing.Point(0, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(170, 90)
        Me.lbl_name.TabIndex = 9
        Me.lbl_name.Text = "INSPECCION (A)"
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnVerDan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(590, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(149, 90)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rchtbxDesc)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(179, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(405, 90)
        Me.Panel3.TabIndex = 2
        '
        'rchtbxDesc
        '
        Me.rchtbxDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rchtbxDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rchtbxDesc.Font = New System.Drawing.Font("Calibri", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rchtbxDesc.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.rchtbxDesc.Location = New System.Drawing.Point(0, 0)
        Me.rchtbxDesc.Name = "rchtbxDesc"
        Me.rchtbxDesc.ReadOnly = true
        Me.rchtbxDesc.Size = New System.Drawing.Size(405, 90)
        Me.rchtbxDesc.TabIndex = 13
        Me.rchtbxDesc.Text = ""
        '
        'btnVerDan
        '
        Me.btnVerDan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnVerDan.BackColor = System.Drawing.Color.DimGray
        Me.btnVerDan.Enabled = false
        Me.btnVerDan.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnVerDan.FlatAppearance.BorderSize = 0
        Me.btnVerDan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerDan.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnVerDan.ForeColor = System.Drawing.Color.Orange
        Me.btnVerDan.Location = New System.Drawing.Point(9, 19)
        Me.btnVerDan.MaximumSize = New System.Drawing.Size(130, 53)
        Me.btnVerDan.MinimumSize = New System.Drawing.Size(130, 53)
        Me.btnVerDan.Name = "btnVerDan"
        Me.btnVerDan.Size = New System.Drawing.Size(130, 53)
        Me.btnVerDan.TabIndex = 12
        Me.btnVerDan.Text = "Ver Daño"
        Me.btnVerDan.UseVisualStyleBackColor = false
        '
        'InspeccionWidget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "InspeccionWidget"
        Me.Size = New System.Drawing.Size(742, 96)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        Me.Panel3.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_name As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents rchtbxDesc As RichTextBox
    Friend WithEvents btnVerDan As Button
End Class
