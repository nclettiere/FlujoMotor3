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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.btnFotos = New System.Windows.Forms.Button()
        Me.lblOperario = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rchtbxDesc = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.TableLayoutPanel3.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(617, 167)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.04182!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.95818!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_name, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(617, 167)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblFecha, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.btnFotos, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lblOperario, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(372, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(242, 161)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFecha.AutoSize = true
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.Orange
        Me.lblFecha.Location = New System.Drawing.Point(3, 17)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(98, 17)
        Me.lblFecha.TabIndex = 6
        Me.lblFecha.Text = "Fecha: [fecha]"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFotos
        '
        Me.btnFotos.BackColor = System.Drawing.Color.DimGray
        Me.btnFotos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFotos.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnFotos.FlatAppearance.BorderSize = 0
        Me.btnFotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFotos.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnFotos.ForeColor = System.Drawing.Color.Orange
        Me.btnFotos.Location = New System.Drawing.Point(3, 37)
        Me.btnFotos.Name = "btnFotos"
        Me.btnFotos.Size = New System.Drawing.Size(236, 48)
        Me.btnFotos.TabIndex = 5
        Me.btnFotos.Text = "Ver Foto"
        Me.btnFotos.UseVisualStyleBackColor = false
        '
        'lblOperario
        '
        Me.lblOperario.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblOperario.AutoSize = true
        Me.lblOperario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblOperario.ForeColor = System.Drawing.Color.Orange
        Me.lblOperario.Location = New System.Drawing.Point(3, 0)
        Me.lblOperario.Name = "lblOperario"
        Me.lblOperario.Size = New System.Drawing.Size(143, 17)
        Me.lblOperario.TabIndex = 1
        Me.lblOperario.Text = "Hecha por: [operario]"
        Me.lblOperario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_name
        '
        Me.lbl_name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lbl_name.AutoSize = true
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.Orange
        Me.lbl_name.Location = New System.Drawing.Point(3, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(85, 17)
        Me.lbl_name.TabIndex = 0
        Me.lbl_name.Text = "Lote_[Index]"
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.rchtbxDesc, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(94, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.81367!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.18633!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(272, 161)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripcion"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rchtbxDesc
        '
        Me.rchtbxDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rchtbxDesc.Location = New System.Drawing.Point(3, 51)
        Me.rchtbxDesc.Name = "rchtbxDesc"
        Me.rchtbxDesc.ReadOnly = true
        Me.rchtbxDesc.Size = New System.Drawing.Size(266, 107)
        Me.rchtbxDesc.TabIndex = 2
        Me.rchtbxDesc.Text = "Sin Descripcion"
        '
        'InspeccionWidget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.Controls.Add(Me.Panel1)
        Me.Name = "InspeccionWidget"
        Me.Size = New System.Drawing.Size(617, 167)
        Me.Panel1.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.TableLayoutPanel3.ResumeLayout(false)
        Me.TableLayoutPanel3.PerformLayout
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lblOperario As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnFotos As Button
    Friend WithEvents rchtbxDesc As RichTextBox
    Friend WithEvents lblFecha As Label
End Class
