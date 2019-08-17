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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddVehicle = New System.Windows.Forms.Button()
        Me.btnVerVehicle = New System.Windows.Forms.Button()
        Me.TableLayoutPanelOpciones = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btPuerto = New System.Windows.Forms.Button()
        Me.piBoPuerto = New System.Windows.Forms.PictureBox()
        Me.btPatio = New System.Windows.Forms.Button()
        Me.piBoPatio = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanelInfoUsuario = New System.Windows.Forms.TableLayoutPanel()
        Me.labUsuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanelSesion = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MainContent = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelMenu.SuspendLayout()
        Me.pnCOntenedor.SuspendLayout()
        Me.TableLayoutPanelOpciones.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.piBoPuerto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piBoPatio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanelInfoUsuario.SuspendLayout()
        Me.TableLayoutPanelSesion.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanelMenu
        '
        Me.TableLayoutPanelMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanelMenu.ColumnCount = 2
        Me.TableLayoutPanelMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.28042!))
        Me.TableLayoutPanelMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.71957!))
        Me.TableLayoutPanelMenu.Controls.Add(Me.TableLayoutPanelOpciones, 0, 0)
        Me.TableLayoutPanelMenu.Controls.Add(Me.pnCOntenedor, 1, 0)
        Me.TableLayoutPanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelMenu.Name = "TableLayoutPanelMenu"
        Me.TableLayoutPanelMenu.RowCount = 1
        Me.TableLayoutPanelMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
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
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(57, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(329, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total de Vehiculos Ingresados: 0"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(79, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Vehiculos Pendientes: 0"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddVehicle
        '
        Me.btnAddVehicle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddVehicle.BackColor = System.Drawing.Color.DimGray
        Me.btnAddVehicle.FlatAppearance.BorderSize = 0
        Me.btnAddVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddVehicle.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddVehicle.ForeColor = System.Drawing.Color.Orange
        Me.btnAddVehicle.Location = New System.Drawing.Point(255, 6)
        Me.btnAddVehicle.Name = "btnAddVehicle"
        Me.btnAddVehicle.Size = New System.Drawing.Size(156, 53)
        Me.btnAddVehicle.TabIndex = 1
        Me.btnAddVehicle.Text = "Ingresar Vehiculo"
        Me.btnAddVehicle.UseVisualStyleBackColor = False
        '
        'btnVerVehicle
        '
        Me.btnVerVehicle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnVerVehicle.BackColor = System.Drawing.Color.DimGray
        Me.btnVerVehicle.FlatAppearance.BorderSize = 0
        Me.btnVerVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerVehicle.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerVehicle.ForeColor = System.Drawing.Color.Orange
        Me.btnVerVehicle.Location = New System.Drawing.Point(28, 6)
        Me.btnVerVehicle.Name = "btnVerVehicle"
        Me.btnVerVehicle.Size = New System.Drawing.Size(165, 53)
        Me.btnVerVehicle.TabIndex = 0
        Me.btnVerVehicle.Text = "Ver Vehiculos"
        Me.btnVerVehicle.UseVisualStyleBackColor = False
        '
        'TableLayoutPanelOpciones
        '
        Me.TableLayoutPanelOpciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanelOpciones.ColumnCount = 1
        Me.TableLayoutPanelOpciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelOpciones.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanelOpciones.Controls.Add(Me.TableLayoutPanelInfoUsuario, 0, 1)
        Me.TableLayoutPanelOpciones.Controls.Add(Me.TableLayoutPanelSesion, 0, 2)
        Me.TableLayoutPanelOpciones.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanelOpciones.Name = "TableLayoutPanelOpciones"
        Me.TableLayoutPanelOpciones.RowCount = 3
        Me.TableLayoutPanelOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.8209!))
        Me.TableLayoutPanelOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.97015!))
        Me.TableLayoutPanelOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelOpciones.Size = New System.Drawing.Size(273, 694)
        Me.TableLayoutPanelOpciones.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(267, 225)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btPuerto
        '
        Me.btPuerto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btPuerto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btPuerto.FlatAppearance.BorderSize = 0
        Me.btPuerto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPuerto.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPuerto.ForeColor = System.Drawing.Color.Orange
        Me.btPuerto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btPuerto.Location = New System.Drawing.Point(63, 25)
        Me.btPuerto.Name = "btPuerto"
        Me.btPuerto.Size = New System.Drawing.Size(201, 62)
        Me.btPuerto.TabIndex = 0
        Me.btPuerto.Text = "PUERTO"
        Me.btPuerto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btPuerto.UseVisualStyleBackColor = True
        '
        'piBoPuerto
        '
        Me.piBoPuerto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.piBoPuerto.BackgroundImage = Global.oop.My.Resources.Resources.next_1aaaa
        Me.piBoPuerto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.piBoPuerto.Location = New System.Drawing.Point(3, 41)
        Me.piBoPuerto.Name = "piBoPuerto"
        Me.piBoPuerto.Size = New System.Drawing.Size(54, 30)
        Me.piBoPuerto.TabIndex = 1
        Me.piBoPuerto.TabStop = False
        '
        'btPatio
        '
        Me.btPatio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btPatio.BackColor = System.Drawing.Color.Transparent
        Me.btPatio.FlatAppearance.BorderSize = 0
        Me.btPatio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPatio.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPatio.ForeColor = System.Drawing.Color.Orange
        Me.btPatio.Location = New System.Drawing.Point(63, 141)
        Me.btPatio.Name = "btPatio"
        Me.btPatio.Size = New System.Drawing.Size(201, 55)
        Me.btPatio.TabIndex = 2
        Me.btPatio.Text = "PATIO"
        Me.btPatio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btPatio.UseVisualStyleBackColor = False
        '
        'piBoPatio
        '
        Me.piBoPatio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.piBoPatio.BackgroundImage = Global.oop.My.Resources.Resources.next_1aaaa
        Me.piBoPatio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.piBoPatio.Location = New System.Drawing.Point(3, 153)
        Me.piBoPatio.Name = "piBoPatio"
        Me.piBoPatio.Size = New System.Drawing.Size(54, 30)
        Me.piBoPatio.TabIndex = 3
        Me.piBoPatio.TabStop = False
        '
        'TableLayoutPanelInfoUsuario
        '
        Me.TableLayoutPanelInfoUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanelInfoUsuario.ColumnCount = 1
        Me.TableLayoutPanelInfoUsuario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelInfoUsuario.Controls.Add(Me.labUsuario, 0, 2)
        Me.TableLayoutPanelInfoUsuario.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanelInfoUsuario.Location = New System.Drawing.Point(3, 234)
        Me.TableLayoutPanelInfoUsuario.Name = "TableLayoutPanelInfoUsuario"
        Me.TableLayoutPanelInfoUsuario.RowCount = 3
        Me.TableLayoutPanelInfoUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.35135!))
        Me.TableLayoutPanelInfoUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.40541!))
        Me.TableLayoutPanelInfoUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.7027!))
        Me.TableLayoutPanelInfoUsuario.Size = New System.Drawing.Size(267, 242)
        Me.TableLayoutPanelInfoUsuario.TabIndex = 1
        '
        'labUsuario
        '
        Me.labUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labUsuario.AutoSize = True
        Me.labUsuario.BackColor = System.Drawing.Color.Transparent
        Me.labUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labUsuario.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.labUsuario.ForeColor = System.Drawing.Color.Wheat
        Me.labUsuario.Location = New System.Drawing.Point(3, 185)
        Me.labUsuario.Name = "labUsuario"
        Me.labUsuario.Size = New System.Drawing.Size(261, 19)
        Me.labUsuario.TabIndex = 0
        Me.labUsuario.Text = "N/A"
        Me.labUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(3, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanelSesion
        '
        Me.TableLayoutPanelSesion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanelSesion.ColumnCount = 2
        Me.TableLayoutPanelSesion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.44231!))
        Me.TableLayoutPanelSesion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.55769!))
        Me.TableLayoutPanelSesion.Controls.Add(Me.PictureBox3, 0, 1)
        Me.TableLayoutPanelSesion.Controls.Add(Me.Button2, 1, 1)
        Me.TableLayoutPanelSesion.Location = New System.Drawing.Point(3, 482)
        Me.TableLayoutPanelSesion.Name = "TableLayoutPanelSesion"
        Me.TableLayoutPanelSesion.RowCount = 2
        Me.TableLayoutPanelSesion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelSesion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelSesion.Size = New System.Drawing.Size(267, 209)
        Me.TableLayoutPanelSesion.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackgroundImage = Global.oop.My.Resources.Resources.logoutss
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(3, 136)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 41)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Orange
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(73, 131)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(191, 51)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MainContent
        '
        Me.MainContent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainContent.BackColor = System.Drawing.Color.Gainsboro
        Me.MainContent.Location = New System.Drawing.Point(4, 4)
        Me.MainContent.Name = "MainContent"
        Me.MainContent.Size = New System.Drawing.Size(901, 602)
        Me.MainContent.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.MainContent, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.62974!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.37026!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(909, 688)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(4, 612)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(901, 72)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnVerVehicle, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnAddVehicle, 1, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(444, 66)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(453, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(444, 66)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'Menu_Wapo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.TableLayoutPanelMenu)
        Me.Name = "Menu_Wapo"
        Me.Size = New System.Drawing.Size(1200, 700)
        Me.TableLayoutPanelMenu.ResumeLayout(False)
        Me.pnCOntenedor.ResumeLayout(False)
        Me.TableLayoutPanelOpciones.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.piBoPuerto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piBoPatio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanelInfoUsuario.ResumeLayout(False)
        Me.TableLayoutPanelInfoUsuario.PerformLayout()
        Me.TableLayoutPanelSesion.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelMenu As TableLayoutPanel
    Friend WithEvents TableLayoutPanelOpciones As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btPuerto As Button
    Friend WithEvents piBoPuerto As PictureBox
    Friend WithEvents btPatio As Button
    Friend WithEvents piBoPatio As PictureBox
    Friend WithEvents TableLayoutPanelInfoUsuario As TableLayoutPanel
    Friend WithEvents labUsuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanelSesion As TableLayoutPanel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents pnCOntenedor As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddVehicle As Button
    Friend WithEvents btnVerVehicle As Button
    Friend WithEvents MainContent As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
End Class
