<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Wapo
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
        Me.TableLayoutPanelMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.pnCOntenedor = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.MainContent = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalVehiculos = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnVerVehicle = New System.Windows.Forms.Button()
        Me.btnAddVehicle = New System.Windows.Forms.Button()
        Me.TableLayoutPanelOpciones = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btPuerto = New System.Windows.Forms.Button()
        Me.piBoPuerto = New System.Windows.Forms.PictureBox()
        Me.btPatio = New System.Windows.Forms.Button()
        Me.piBoPatio = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanelSesion = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanelMenu.SuspendLayout
        Me.pnCOntenedor.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.TableLayoutPanel3.SuspendLayout
        Me.TableLayoutPanel5.SuspendLayout
        Me.TableLayoutPanel4.SuspendLayout
        Me.TableLayoutPanelOpciones.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.piBoPuerto,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.piBoPatio,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanelSesion.SuspendLayout
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'TableLayoutPanelMenu
        '
        Me.TableLayoutPanelMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanelMenu.BackColor = System.Drawing.Color.LightGray
        Me.TableLayoutPanelMenu.ColumnCount = 2
        Me.TableLayoutPanelMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.28042!))
        Me.TableLayoutPanelMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.71957!))
        Me.TableLayoutPanelMenu.Controls.Add(Me.pnCOntenedor, 1, 0)
        Me.TableLayoutPanelMenu.Controls.Add(Me.TableLayoutPanelOpciones, 0, 0)
        Me.TableLayoutPanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanelMenu.Name = "TableLayoutPanelMenu"
        Me.TableLayoutPanelMenu.RowCount = 1
        Me.TableLayoutPanelMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanelMenu.Size = New System.Drawing.Size(1200, 700)
        Me.TableLayoutPanelMenu.TabIndex = 1
        '
        'pnCOntenedor
        '
        Me.pnCOntenedor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnCOntenedor.BackColor = System.Drawing.Color.Transparent
        Me.pnCOntenedor.Controls.Add(Me.TableLayoutPanel2)
        Me.pnCOntenedor.Location = New System.Drawing.Point(282, 3)
        Me.pnCOntenedor.Name = "pnCOntenedor"
        Me.pnCOntenedor.Size = New System.Drawing.Size(915, 694)
        Me.pnCOntenedor.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel2.Controls.Add(Me.MainContent, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.62974!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.37026!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(909, 694)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'MainContent
        '
        Me.MainContent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.MainContent.BackColor = System.Drawing.Color.Gainsboro
        Me.MainContent.Location = New System.Drawing.Point(4, 4)
        Me.MainContent.Name = "MainContent"
        Me.MainContent.Size = New System.Drawing.Size(901, 607)
        Me.MainContent.TabIndex = 2
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(4, 617)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(901, 73)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.lblTotalVehiculos, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(453, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(444, 66)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15!)
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(79, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Vehiculos Pendientes: 0"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalVehiculos
        '
        Me.lblTotalVehiculos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalVehiculos.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotalVehiculos.Font = New System.Drawing.Font("Calibri", 15!)
        Me.lblTotalVehiculos.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblTotalVehiculos.Location = New System.Drawing.Point(57, 1)
        Me.lblTotalVehiculos.Name = "lblTotalVehiculos"
        Me.lblTotalVehiculos.Size = New System.Drawing.Size(329, 30)
        Me.lblTotalVehiculos.TabIndex = 3
        Me.lblTotalVehiculos.Text = "Total de Vehiculos Ingresados: 0"
        Me.lblTotalVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnVerVehicle, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnAddVehicle, 1, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(444, 67)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'btnVerVehicle
        '
        Me.btnVerVehicle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnVerVehicle.BackColor = System.Drawing.Color.DimGray
        Me.btnVerVehicle.FlatAppearance.BorderSize = 0
        Me.btnVerVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerVehicle.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnVerVehicle.ForeColor = System.Drawing.Color.Orange
        Me.btnVerVehicle.Location = New System.Drawing.Point(28, 7)
        Me.btnVerVehicle.Name = "btnVerVehicle"
        Me.btnVerVehicle.Size = New System.Drawing.Size(165, 53)
        Me.btnVerVehicle.TabIndex = 0
        Me.btnVerVehicle.Text = "Ver Vehiculos"
        Me.btnVerVehicle.UseVisualStyleBackColor = false
        '
        'btnAddVehicle
        '
        Me.btnAddVehicle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddVehicle.BackColor = System.Drawing.Color.DimGray
        Me.btnAddVehicle.FlatAppearance.BorderSize = 0
        Me.btnAddVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddVehicle.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAddVehicle.ForeColor = System.Drawing.Color.Orange
        Me.btnAddVehicle.Location = New System.Drawing.Point(255, 7)
        Me.btnAddVehicle.Name = "btnAddVehicle"
        Me.btnAddVehicle.Size = New System.Drawing.Size(156, 53)
        Me.btnAddVehicle.TabIndex = 1
        Me.btnAddVehicle.Text = "Ingresar Vehiculo"
        Me.btnAddVehicle.UseVisualStyleBackColor = false
        '
        'TableLayoutPanelOpciones
        '
        Me.TableLayoutPanelOpciones.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanelOpciones.ColumnCount = 1
        Me.TableLayoutPanelOpciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanelOpciones.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanelOpciones.Controls.Add(Me.TableLayoutPanelSesion, 0, 2)
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.59615!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.40385!))
        Me.TableLayoutPanel1.Controls.Add(Me.btPuerto, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.piBoPuerto, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btPatio, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.piBoPatio, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(273, 227)
        Me.TableLayoutPanel1.TabIndex = 0
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
        Me.btPuerto.Location = New System.Drawing.Point(64, 25)
        Me.btPuerto.Name = "btPuerto"
        Me.btPuerto.Size = New System.Drawing.Size(206, 62)
        Me.btPuerto.TabIndex = 0
        Me.btPuerto.Text = "PUERTO"
        Me.btPuerto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btPuerto.UseVisualStyleBackColor = true
        '
        'piBoPuerto
        '
        Me.piBoPuerto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.piBoPuerto.BackgroundImage = Global.oop.My.Resources.Resources.next_1aaaa
        Me.piBoPuerto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.piBoPuerto.Location = New System.Drawing.Point(3, 41)
        Me.piBoPuerto.Name = "piBoPuerto"
        Me.piBoPuerto.Size = New System.Drawing.Size(55, 30)
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
        Me.btPatio.Location = New System.Drawing.Point(64, 142)
        Me.btPatio.Name = "btPatio"
        Me.btPatio.Size = New System.Drawing.Size(206, 55)
        Me.btPatio.TabIndex = 2
        Me.btPatio.Text = "PATIO"
        Me.btPatio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btPatio.UseVisualStyleBackColor = false
        '
        'piBoPatio
        '
        Me.piBoPatio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.piBoPatio.BackgroundImage = Global.oop.My.Resources.Resources.next_1aaaa
        Me.piBoPatio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.piBoPatio.Location = New System.Drawing.Point(3, 155)
        Me.piBoPatio.Name = "piBoPatio"
        Me.piBoPatio.Size = New System.Drawing.Size(55, 30)
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
        Me.PictureBox3.BackgroundImage = Global.oop.My.Resources.Resources.logoutss
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(3, 137)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(66, 41)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = false
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Orange
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(75, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(195, 51)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Menu_Wapo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.TableLayoutPanelMenu)
        Me.Name = "Menu_Wapo"
        Me.Size = New System.Drawing.Size(1200, 700)
        Me.TableLayoutPanelMenu.ResumeLayout(false)
        Me.pnCOntenedor.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel3.ResumeLayout(false)
        Me.TableLayoutPanel5.ResumeLayout(false)
        Me.TableLayoutPanel4.ResumeLayout(false)
        Me.TableLayoutPanelOpciones.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        CType(Me.piBoPuerto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.piBoPatio,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanelSesion.ResumeLayout(false)
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TableLayoutPanelMenu As TableLayoutPanel
    Friend WithEvents TableLayoutPanelOpciones As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btPuerto As Button
    Friend WithEvents piBoPuerto As PictureBox
    Friend WithEvents btPatio As Button
    Friend WithEvents piBoPatio As PictureBox
    Friend WithEvents TableLayoutPanelSesion As TableLayoutPanel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents pnCOntenedor As Panel
    Friend WithEvents lblTotalVehiculos As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddVehicle As Button
    Friend WithEvents btnVerVehicle As Button
    Friend WithEvents MainContent As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
End Class
