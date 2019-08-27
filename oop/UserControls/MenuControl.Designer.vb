<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuControl
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
        Me.TableLayoutPanelOpciones = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btPuerto = New System.Windows.Forms.Button()
        Me.piBoPuerto = New System.Windows.Forms.PictureBox()
        Me.btPatio = New System.Windows.Forms.Button()
        Me.piBoPatio = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanelSesion = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ContenidoPrincipal = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout
        Me.TableLayoutPanelOpciones.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        CType(Me.piBoPuerto,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.piBoPatio,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanelSesion.SuspendLayout
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanelOpciones, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ContenidoPrincipal, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(753, 389)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanelOpciones
        '
        Me.TableLayoutPanelOpciones.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanelOpciones.ColumnCount = 1
        Me.TableLayoutPanelOpciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanelOpciones.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanelOpciones.Controls.Add(Me.TableLayoutPanelSesion, 0, 2)
        Me.TableLayoutPanelOpciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelOpciones.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelOpciones.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanelOpciones.Name = "TableLayoutPanelOpciones"
        Me.TableLayoutPanelOpciones.RowCount = 3
        Me.TableLayoutPanelOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.8209!))
        Me.TableLayoutPanelOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.97015!))
        Me.TableLayoutPanelOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanelOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanelOpciones.Size = New System.Drawing.Size(250, 389)
        Me.TableLayoutPanelOpciones.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.59615!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.40385!))
        Me.TableLayoutPanel2.Controls.Add(Me.btPuerto, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.piBoPuerto, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btPatio, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.piBoPatio, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(244, 123)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'btPuerto
        '
        Me.btPuerto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btPuerto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btPuerto.FlatAppearance.BorderSize = 0
        Me.btPuerto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPuerto.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btPuerto.ForeColor = System.Drawing.Color.Orange
        Me.btPuerto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btPuerto.Location = New System.Drawing.Point(58, 3)
        Me.btPuerto.Name = "btPuerto"
        Me.btPuerto.Size = New System.Drawing.Size(183, 55)
        Me.btPuerto.TabIndex = 0
        Me.btPuerto.Text = "PUERTO"
        Me.btPuerto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btPuerto.UseVisualStyleBackColor = true
        '
        'piBoPuerto
        '
        Me.piBoPuerto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.piBoPuerto.BackgroundImage = Global.Menu.My.Resources.Resources.next_1aaaa
        Me.piBoPuerto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.piBoPuerto.Location = New System.Drawing.Point(3, 15)
        Me.piBoPuerto.Name = "piBoPuerto"
        Me.piBoPuerto.Size = New System.Drawing.Size(49, 30)
        Me.piBoPuerto.TabIndex = 1
        Me.piBoPuerto.TabStop = false
        '
        'btPatio
        '
        Me.btPatio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btPatio.BackColor = System.Drawing.Color.Transparent
        Me.btPatio.FlatAppearance.BorderSize = 0
        Me.btPatio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPatio.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btPatio.ForeColor = System.Drawing.Color.Orange
        Me.btPatio.Location = New System.Drawing.Point(58, 64)
        Me.btPatio.Name = "btPatio"
        Me.btPatio.Size = New System.Drawing.Size(183, 55)
        Me.btPatio.TabIndex = 2
        Me.btPatio.Text = "PATIO"
        Me.btPatio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btPatio.UseVisualStyleBackColor = false
        '
        'piBoPatio
        '
        Me.piBoPatio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.piBoPatio.BackgroundImage = Global.Menu.My.Resources.Resources.next_1aaaa
        Me.piBoPatio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.piBoPatio.Location = New System.Drawing.Point(3, 77)
        Me.piBoPatio.Name = "piBoPatio"
        Me.piBoPatio.Size = New System.Drawing.Size(49, 30)
        Me.piBoPatio.TabIndex = 3
        Me.piBoPatio.TabStop = false
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
        Me.TableLayoutPanelSesion.Controls.Add(Me.btnSalir, 1, 1)
        Me.TableLayoutPanelSesion.Location = New System.Drawing.Point(3, 271)
        Me.TableLayoutPanelSesion.Name = "TableLayoutPanelSesion"
        Me.TableLayoutPanelSesion.RowCount = 2
        Me.TableLayoutPanelSesion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanelSesion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanelSesion.Size = New System.Drawing.Size(244, 115)
        Me.TableLayoutPanelSesion.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackgroundImage = Global.Menu.My.Resources.Resources.logoutss
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(3, 65)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(58, 41)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = false
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Calibri", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Orange
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(67, 60)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(174, 51)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.UseVisualStyleBackColor = true
        '
        'ContenidoPrincipal
        '
        Me.ContenidoPrincipal.BackColor = System.Drawing.Color.DimGray
        Me.ContenidoPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContenidoPrincipal.Location = New System.Drawing.Point(253, 3)
        Me.ContenidoPrincipal.Name = "ContenidoPrincipal"
        Me.ContenidoPrincipal.Size = New System.Drawing.Size(497, 383)
        Me.ContenidoPrincipal.TabIndex = 1
        '
        'MenuControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "MenuControl"
        Me.Size = New System.Drawing.Size(753, 389)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanelOpciones.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        CType(Me.piBoPuerto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.piBoPatio,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanelSesion.ResumeLayout(false)
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ContenidoPrincipal As Panel
    Friend WithEvents TableLayoutPanelOpciones As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btPuerto As Button
    Friend WithEvents piBoPuerto As PictureBox
    Friend WithEvents btPatio As Button
    Friend WithEvents piBoPatio As PictureBox
    Friend WithEvents TableLayoutPanelSesion As TableLayoutPanel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnSalir As Button
End Class
