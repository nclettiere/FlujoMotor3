<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pnCOntenedor = New System.Windows.Forms.Panel()
        Me.TableLayoutPanelSesion = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btLotes = New System.Windows.Forms.Button()
        Me.btViajes = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.piBoPuerto = New System.Windows.Forms.PictureBox()
        Me.piBoPatio = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanelOpciones = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanelSesion.SuspendLayout
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.piBoPuerto,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.piBoPatio,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanelOpciones.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(75, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(195, 51)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = true
        '
        'pnCOntenedor
        '
        Me.pnCOntenedor.AutoSize = true
        Me.pnCOntenedor.BackColor = System.Drawing.Color.Transparent
        Me.pnCOntenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnCOntenedor.Location = New System.Drawing.Point(279, 0)
        Me.pnCOntenedor.Name = "pnCOntenedor"
        Me.pnCOntenedor.Size = New System.Drawing.Size(921, 700)
        Me.pnCOntenedor.TabIndex = 0
        '
        'TableLayoutPanelSesion
        '
        Me.TableLayoutPanelSesion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanelSesion.ColumnCount = 2
        Me.TableLayoutPanelSesion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.44231!))
        Me.TableLayoutPanelSesion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.55769!))
        Me.TableLayoutPanelSesion.Controls.Add(Me.PictureBox3, 0, 1)
        Me.TableLayoutPanelSesion.Controls.Add(Me.Button2, 1, 1)
        Me.TableLayoutPanelSesion.Location = New System.Drawing.Point(3, 486)
        Me.TableLayoutPanelSesion.Name = "TableLayoutPanelSesion"
        Me.TableLayoutPanelSesion.RowCount = 2
        Me.TableLayoutPanelSesion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanelSesion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanelSesion.Size = New System.Drawing.Size(273, 211)
        Me.TableLayoutPanelSesion.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackgroundImage = Global.FlujoRuedas.My.Resources.Resources.logoutsss
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(3, 137)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(66, 41)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = false
        '
        'btLotes
        '
        Me.btLotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btLotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btLotes.FlatAppearance.BorderSize = 0
        Me.btLotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btLotes.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btLotes.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btLotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btLotes.Location = New System.Drawing.Point(64, 25)
        Me.btLotes.Name = "btLotes"
        Me.btLotes.Size = New System.Drawing.Size(206, 62)
        Me.btLotes.TabIndex = 0
        Me.btLotes.Text = "LOTES"
        Me.btLotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btLotes.UseVisualStyleBackColor = true
        '
        'btViajes
        '
        Me.btViajes.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btViajes.BackColor = System.Drawing.Color.Transparent
        Me.btViajes.FlatAppearance.BorderSize = 0
        Me.btViajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btViajes.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btViajes.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btViajes.Location = New System.Drawing.Point(64, 142)
        Me.btViajes.Name = "btViajes"
        Me.btViajes.Size = New System.Drawing.Size(206, 55)
        Me.btViajes.TabIndex = 2
        Me.btViajes.Text = "VIAJES"
        Me.btViajes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btViajes.UseVisualStyleBackColor = false
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.59615!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.40385!))
        Me.TableLayoutPanel1.Controls.Add(Me.btLotes, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.piBoPuerto, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btViajes, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.piBoPatio, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(273, 227)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'piBoPuerto
        '
        Me.piBoPuerto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.piBoPuerto.BackgroundImage = Global.FlujoRuedas.My.Resources.Resources.next_1aaaaa
        Me.piBoPuerto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.piBoPuerto.Location = New System.Drawing.Point(3, 41)
        Me.piBoPuerto.Name = "piBoPuerto"
        Me.piBoPuerto.Size = New System.Drawing.Size(55, 30)
        Me.piBoPuerto.TabIndex = 1
        Me.piBoPuerto.TabStop = false
        '
        'piBoPatio
        '
        Me.piBoPatio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.piBoPatio.BackgroundImage = Global.FlujoRuedas.My.Resources.Resources.next_1aaaaa
        Me.piBoPatio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.piBoPatio.Location = New System.Drawing.Point(3, 155)
        Me.piBoPatio.Name = "piBoPatio"
        Me.piBoPatio.Size = New System.Drawing.Size(55, 30)
        Me.piBoPatio.TabIndex = 3
        Me.piBoPatio.TabStop = false
        '
        'TableLayoutPanelOpciones
        '
        Me.TableLayoutPanelOpciones.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanelOpciones.ColumnCount = 1
        Me.TableLayoutPanelOpciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanelOpciones.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanelOpciones.Controls.Add(Me.TableLayoutPanelSesion, 0, 2)
        Me.TableLayoutPanelOpciones.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanelOpciones.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelOpciones.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanelOpciones.Name = "TableLayoutPanelOpciones"
        Me.TableLayoutPanelOpciones.RowCount = 3
        Me.TableLayoutPanelOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.8209!))
        Me.TableLayoutPanelOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.97015!))
        Me.TableLayoutPanelOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanelOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanelOpciones.Size = New System.Drawing.Size(279, 700)
        Me.TableLayoutPanelOpciones.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnCOntenedor)
        Me.Panel1.Controls.Add(Me.TableLayoutPanelOpciones)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 700)
        Me.Panel1.TabIndex = 2
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MenuPrincipal"
        Me.Size = New System.Drawing.Size(1200, 700)
        Me.TableLayoutPanelSesion.ResumeLayout(false)
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanel1.ResumeLayout(false)
        CType(Me.piBoPuerto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.piBoPatio,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanelOpciones.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents pnCOntenedor As Panel
    Friend WithEvents TableLayoutPanelSesion As TableLayoutPanel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btLotes As Button
    Friend WithEvents piBoPuerto As PictureBox
    Friend WithEvents btViajes As Button
    Friend WithEvents piBoPatio As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanelOpciones As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
End Class
