<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Deus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Deus))
        Me.TableLayoutPanelMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelOpciones = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btOperario = New System.Windows.Forms.Button()
        Me.piBoPuerto = New System.Windows.Forms.PictureBox()
        Me.btTransportista = New System.Windows.Forms.Button()
        Me.piBoPatio = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanelInfoUsuario = New System.Windows.Forms.TableLayoutPanel()
        Me.labUsuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanelSesion = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAgregarUsuario = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dataLstUsuarios = New BrightIdeasSoftware.DataListView()
        Me.TableLayoutPanelMenu.SuspendLayout
        Me.TableLayoutPanelOpciones.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.piBoPuerto,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.piBoPatio,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanelInfoUsuario.SuspendLayout
        Me.TableLayoutPanelSesion.SuspendLayout
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.Panel3.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.FlowLayoutPanel1.SuspendLayout
        Me.Panel2.SuspendLayout
        CType(Me.dataLstUsuarios,System.ComponentModel.ISupportInitialize).BeginInit
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
        Me.TableLayoutPanelMenu.Controls.Add(Me.TableLayoutPanelOpciones, 0, 0)
        Me.TableLayoutPanelMenu.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanelMenu.Name = "TableLayoutPanelMenu"
        Me.TableLayoutPanelMenu.RowCount = 1
        Me.TableLayoutPanelMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanelMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanelMenu.Size = New System.Drawing.Size(1200, 700)
        Me.TableLayoutPanelMenu.TabIndex = 3
        '
        'TableLayoutPanelOpciones
        '
        Me.TableLayoutPanelOpciones.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanelOpciones.ColumnCount = 1
        Me.TableLayoutPanelOpciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanelOpciones.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanelOpciones.Controls.Add(Me.TableLayoutPanelInfoUsuario, 0, 1)
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
        Me.TableLayoutPanel1.Controls.Add(Me.btOperario, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.piBoPuerto, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btTransportista, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.piBoPatio, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(273, 227)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btOperario
        '
        Me.btOperario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btOperario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btOperario.FlatAppearance.BorderSize = 0
        Me.btOperario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btOperario.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btOperario.ForeColor = System.Drawing.Color.Crimson
        Me.btOperario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btOperario.Location = New System.Drawing.Point(64, 25)
        Me.btOperario.Name = "btOperario"
        Me.btOperario.Size = New System.Drawing.Size(206, 62)
        Me.btOperario.TabIndex = 0
        Me.btOperario.Text = "OPERARIOS"
        Me.btOperario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btOperario.UseVisualStyleBackColor = true
        '
        'piBoPuerto
        '
        Me.piBoPuerto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.piBoPuerto.BackgroundImage = CType(resources.GetObject("piBoPuerto.BackgroundImage"),System.Drawing.Image)
        Me.piBoPuerto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.piBoPuerto.Location = New System.Drawing.Point(3, 41)
        Me.piBoPuerto.Name = "piBoPuerto"
        Me.piBoPuerto.Size = New System.Drawing.Size(55, 30)
        Me.piBoPuerto.TabIndex = 1
        Me.piBoPuerto.TabStop = false
        '
        'btTransportista
        '
        Me.btTransportista.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btTransportista.BackColor = System.Drawing.Color.Transparent
        Me.btTransportista.FlatAppearance.BorderSize = 0
        Me.btTransportista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btTransportista.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btTransportista.ForeColor = System.Drawing.Color.Crimson
        Me.btTransportista.Location = New System.Drawing.Point(64, 142)
        Me.btTransportista.Name = "btTransportista"
        Me.btTransportista.Size = New System.Drawing.Size(206, 55)
        Me.btTransportista.TabIndex = 2
        Me.btTransportista.Text = "TRANSPORTISTAS"
        Me.btTransportista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btTransportista.UseVisualStyleBackColor = false
        '
        'piBoPatio
        '
        Me.piBoPatio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.piBoPatio.BackgroundImage = CType(resources.GetObject("piBoPatio.BackgroundImage"),System.Drawing.Image)
        Me.piBoPatio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.piBoPatio.Location = New System.Drawing.Point(3, 155)
        Me.piBoPatio.Name = "piBoPatio"
        Me.piBoPatio.Size = New System.Drawing.Size(55, 30)
        Me.piBoPatio.TabIndex = 3
        Me.piBoPatio.TabStop = false
        '
        'TableLayoutPanelInfoUsuario
        '
        Me.TableLayoutPanelInfoUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanelInfoUsuario.ColumnCount = 1
        Me.TableLayoutPanelInfoUsuario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanelInfoUsuario.Controls.Add(Me.labUsuario, 0, 2)
        Me.TableLayoutPanelInfoUsuario.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanelInfoUsuario.Location = New System.Drawing.Point(3, 236)
        Me.TableLayoutPanelInfoUsuario.Name = "TableLayoutPanelInfoUsuario"
        Me.TableLayoutPanelInfoUsuario.RowCount = 3
        Me.TableLayoutPanelInfoUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.35135!))
        Me.TableLayoutPanelInfoUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.40541!))
        Me.TableLayoutPanelInfoUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.7027!))
        Me.TableLayoutPanelInfoUsuario.Size = New System.Drawing.Size(273, 244)
        Me.TableLayoutPanelInfoUsuario.TabIndex = 1
        '
        'labUsuario
        '
        Me.labUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.labUsuario.AutoSize = true
        Me.labUsuario.BackColor = System.Drawing.Color.Transparent
        Me.labUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labUsuario.Font = New System.Drawing.Font("Calibri", 12!)
        Me.labUsuario.ForeColor = System.Drawing.Color.Pink
        Me.labUsuario.Location = New System.Drawing.Point(3, 187)
        Me.labUsuario.Name = "labUsuario"
        Me.labUsuario.Size = New System.Drawing.Size(267, 19)
        Me.labUsuario.TabIndex = 0
        Me.labUsuario.Text = "N/A"
        Me.labUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10!)
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(3, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.PictureBox3.BackgroundImage = Global.FlujosTXTs.My.Resources.Resources.logoutssss
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
        Me.Button2.ForeColor = System.Drawing.Color.Crimson
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(75, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(195, 51)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(282, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(915, 694)
        Me.Panel1.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Location = New System.Drawing.Point(375, 25)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(10, 25, 3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(537, 657)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Administracion de Usuarios"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.dataLstUsuarios)
        Me.Panel3.Controls.Add(Me.btnAgregarUsuario)
        Me.Panel3.Controls.Add(Me.btnEliminar)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(531, 638)
        Me.Panel3.TabIndex = 0
        '
        'btnAgregarUsuario
        '
        Me.btnAgregarUsuario.Location = New System.Drawing.Point(358, 10)
        Me.btnAgregarUsuario.Name = "btnAgregarUsuario"
        Me.btnAgregarUsuario.Size = New System.Drawing.Size(156, 36)
        Me.btnAgregarUsuario.TabIndex = 2
        Me.btnAgregarUsuario.Text = "Agregar"
        Me.btnAgregarUsuario.UseVisualStyleBackColor = true
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(186, 10)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(156, 36)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = true
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 10)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(158, 36)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Modificar"
        Me.Button4.UseVisualStyleBackColor = true
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 22)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10, 25, 3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 657)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Usuarios Conectados"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(346, 638)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(13, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(321, 134)
        Me.Panel2.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(14, 99)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Cerrar Sesion"
        Me.Button3.UseVisualStyleBackColor = true
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(196, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Ver Mas"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = true
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10!)
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(11, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Ultima Conexion:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = true
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10!)
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(11, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10!)
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(11, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Usuario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dataLstUsuarios
        '
        Me.dataLstUsuarios.CellEditUseWholeCell = false
        Me.dataLstUsuarios.DataSource = Nothing
        Me.dataLstUsuarios.FullRowSelect = true
        Me.dataLstUsuarios.Location = New System.Drawing.Point(12, 52)
        Me.dataLstUsuarios.Name = "dataLstUsuarios"
        Me.dataLstUsuarios.ShowGroups = false
        Me.dataLstUsuarios.Size = New System.Drawing.Size(502, 568)
        Me.dataLstUsuarios.TabIndex = 3
        Me.dataLstUsuarios.UseCompatibleStateImageBehavior = false
        Me.dataLstUsuarios.View = System.Windows.Forms.View.Details
        '
        'Main_Deus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelMenu)
        Me.Name = "Main_Deus"
        Me.Size = New System.Drawing.Size(1200, 700)
        Me.TableLayoutPanelMenu.ResumeLayout(false)
        Me.TableLayoutPanelOpciones.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        CType(Me.piBoPuerto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.piBoPatio,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanelInfoUsuario.ResumeLayout(false)
        Me.TableLayoutPanelInfoUsuario.PerformLayout
        Me.TableLayoutPanelSesion.ResumeLayout(false)
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.GroupBox2.ResumeLayout(false)
        Me.Panel3.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.FlowLayoutPanel1.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        CType(Me.dataLstUsuarios,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TableLayoutPanelMenu As TableLayoutPanel
    Friend WithEvents TableLayoutPanelOpciones As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btOperario As Button
    Friend WithEvents piBoPuerto As PictureBox
    Friend WithEvents btTransportista As Button
    Friend WithEvents piBoPatio As PictureBox
    Friend WithEvents TableLayoutPanelInfoUsuario As TableLayoutPanel
    Friend WithEvents labUsuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanelSesion As TableLayoutPanel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAgregarUsuario As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dataLstUsuarios As BrightIdeasSoftware.DataListView
End Class
