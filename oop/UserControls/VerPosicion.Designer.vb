<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerPosicion
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxZona = New System.Windows.Forms.ComboBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxFila = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxColumna = New System.Windows.Forms.TextBox()
        Me.lblPatio = New System.Windows.Forms.Label()
        Me.lblVehiculoPos = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.Panel3.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.Panel4.SuspendLayout
        Me.FlowLayoutPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.btnAceptar)
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Controls.Add(Me.lblPatio)
        Me.Panel2.Controls.Add(Me.lblVehiculoPos)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(370, 222)
        Me.Panel2.TabIndex = 2
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAceptar.BackColor = System.Drawing.Color.DimGray
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Orange
        Me.btnAceptar.Location = New System.Drawing.Point(68, 156)
        Me.btnAceptar.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btnAceptar.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(143, 53)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Actualizar"
        Me.btnAceptar.UseVisualStyleBackColor = false
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancelar.BackColor = System.Drawing.Color.DimGray
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Orange
        Me.btnCancelar.Location = New System.Drawing.Point(217, 156)
        Me.btnCancelar.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btnCancelar.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(143, 53)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = false
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = true
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cbxZona, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(10, 64)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(350, 69)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.AutoSize = true
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 34)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(126, 32)
        Me.Panel3.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.AutoSize = true
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(126, 32)
        Me.Panel1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(20, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Posicion"
        '
        'Panel4
        '
        Me.Panel4.AutoSize = true
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(126, 25)
        Me.Panel4.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(20, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Zona:"
        '
        'cbxZona
        '
        Me.cbxZona.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbxZona.FormattingEnabled = true
        Me.cbxZona.Location = New System.Drawing.Point(135, 5)
        Me.cbxZona.Name = "cbxZona"
        Me.cbxZona.Size = New System.Drawing.Size(212, 21)
        Me.cbxZona.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = true
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.tbxFila)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.tbxColumna)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(132, 34)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(218, 32)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(10, 5)
        Me.Label3.Margin = New System.Windows.Forms.Padding(10, 5, 10, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fila"
        '
        'tbxFila
        '
        Me.tbxFila.Location = New System.Drawing.Point(53, 3)
        Me.tbxFila.Name = "tbxFila"
        Me.tbxFila.Size = New System.Drawing.Size(30, 20)
        Me.tbxFila.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(96, 5)
        Me.Label4.Margin = New System.Windows.Forms.Padding(10, 5, 10, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Columna"
        '
        'tbxColumna
        '
        Me.tbxColumna.Location = New System.Drawing.Point(172, 3)
        Me.tbxColumna.Name = "tbxColumna"
        Me.tbxColumna.Size = New System.Drawing.Size(30, 20)
        Me.tbxColumna.TabIndex = 3
        '
        'lblPatio
        '
        Me.lblPatio.AutoSize = true
        Me.lblPatio.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPatio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPatio.ForeColor = System.Drawing.Color.Orange
        Me.lblPatio.Location = New System.Drawing.Point(10, 37)
        Me.lblPatio.Margin = New System.Windows.Forms.Padding(10)
        Me.lblPatio.Name = "lblPatio"
        Me.lblPatio.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblPatio.Size = New System.Drawing.Size(48, 27)
        Me.lblPatio.TabIndex = 7
        Me.lblPatio.Text = "Patio: "
        '
        'lblVehiculoPos
        '
        Me.lblVehiculoPos.AutoSize = true
        Me.lblVehiculoPos.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblVehiculoPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblVehiculoPos.ForeColor = System.Drawing.Color.Orange
        Me.lblVehiculoPos.Location = New System.Drawing.Point(10, 10)
        Me.lblVehiculoPos.Margin = New System.Windows.Forms.Padding(10)
        Me.lblVehiculoPos.Name = "lblVehiculoPos"
        Me.lblVehiculoPos.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblVehiculoPos.Size = New System.Drawing.Size(150, 27)
        Me.lblVehiculoPos.TabIndex = 8
        Me.lblVehiculoPos.Text = "Posicion del Vehiculo: "
        '
        'VerPosicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Name = "VerPosicion"
        Me.Size = New System.Drawing.Size(370, 222)
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.Panel3.ResumeLayout(false)
        Me.Panel3.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.Panel4.ResumeLayout(false)
        Me.Panel4.PerformLayout
        Me.FlowLayoutPanel1.ResumeLayout(false)
        Me.FlowLayoutPanel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxZona As ComboBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxFila As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxColumna As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblPatio As Label
    Friend WithEvents lblVehiculoPos As Label
End Class
