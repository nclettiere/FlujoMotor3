<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerLotes
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btCerrar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbxPatios = New System.Windows.Forms.ComboBox()
        Me.lblPatio = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DateTimeSalida = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaSalida = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DateTimeLlegada = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaLlegada = New System.Windows.Forms.Label()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.lblentregar = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblpatio2 = New System.Windows.Forms.Label()
        Me.labId = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEntregar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.riTeBoDescripcion = New System.Windows.Forms.RichTextBox()
        Me.lblLlegada = New System.Windows.Forms.Label()
        Me.lblSALIDA = New System.Windows.Forms.Label()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnAgregarVehiculo = New System.Windows.Forms.Button()
        Me.lblVehiculos = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridViewVehiculos = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout
        Me.TableLayoutPanel4.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.Panel6.SuspendLayout
        Me.Panel5.SuspendLayout
        Me.Panel4.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.Panel3.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.TableLayoutPanel3.SuspendLayout
        CType(Me.DataGridViewVehiculos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanel5.SuspendLayout
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.27144!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(455, 522)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnModificar, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btCerrar, 2, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 446)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(449, 69)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnModificar.BackColor = System.Drawing.Color.DimGray
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.Orange
        Me.btnModificar.Location = New System.Drawing.Point(3, 8)
        Me.btnModificar.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btnModificar.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(143, 53)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = false
        '
        'btCerrar
        '
        Me.btCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btCerrar.BackColor = System.Drawing.Color.DimGray
        Me.btCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btCerrar.FlatAppearance.BorderSize = 0
        Me.btCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCerrar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btCerrar.ForeColor = System.Drawing.Color.Orange
        Me.btCerrar.Location = New System.Drawing.Point(301, 8)
        Me.btCerrar.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btCerrar.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btCerrar.Name = "btCerrar"
        Me.btCerrar.Size = New System.Drawing.Size(143, 53)
        Me.btCerrar.TabIndex = 1
        Me.btCerrar.Text = "Cerrar"
        Me.btCerrar.UseVisualStyleBackColor = false
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = true
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.19376!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.80624!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel6, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel5, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel4, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.lbldesc, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblentregar, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblID, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblpatio2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.labId, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblLlegada, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.lblSALIDA, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.btnMod, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.btnAgregarVehiculo, 1, 6)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(449, 433)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.AutoSize = true
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Controls.Add(Me.cbxPatios)
        Me.Panel6.Controls.Add(Me.lblPatio)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(169, 29)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(277, 26)
        Me.Panel6.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.Button1.AutoSize = true
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Orange
        Me.Button1.Location = New System.Drawing.Point(53, -14)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 20, 3, 3)
        Me.Button1.MaximumSize = New System.Drawing.Size(999, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 55)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Aceptar y Modificar"
        Me.Button1.UseVisualStyleBackColor = false
        Me.Button1.Visible = false
        '
        'cbxPatios
        '
        Me.cbxPatios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxPatios.FormattingEnabled = true
        Me.cbxPatios.Location = New System.Drawing.Point(0, 26)
        Me.cbxPatios.Name = "cbxPatios"
        Me.cbxPatios.Size = New System.Drawing.Size(277, 21)
        Me.cbxPatios.TabIndex = 19
        Me.cbxPatios.Visible = false
        '
        'lblPatio
        '
        Me.lblPatio.AutoSize = true
        Me.lblPatio.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPatio.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPatio.ForeColor = System.Drawing.Color.Wheat
        Me.lblPatio.Location = New System.Drawing.Point(0, 0)
        Me.lblPatio.Name = "lblPatio"
        Me.lblPatio.Size = New System.Drawing.Size(45, 26)
        Me.lblPatio.TabIndex = 18
        Me.lblPatio.Text = "N/A"
        Me.lblPatio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.AutoSize = true
        Me.Panel5.Controls.Add(Me.DateTimeSalida)
        Me.Panel5.Controls.Add(Me.lblFechaSalida)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(169, 248)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(277, 26)
        Me.Panel5.TabIndex = 19
        '
        'DateTimeSalida
        '
        Me.DateTimeSalida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimeSalida.Location = New System.Drawing.Point(0, 26)
        Me.DateTimeSalida.Name = "DateTimeSalida"
        Me.DateTimeSalida.Size = New System.Drawing.Size(277, 20)
        Me.DateTimeSalida.TabIndex = 20
        Me.DateTimeSalida.Visible = false
        '
        'lblFechaSalida
        '
        Me.lblFechaSalida.AutoSize = true
        Me.lblFechaSalida.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFechaSalida.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblFechaSalida.ForeColor = System.Drawing.Color.Wheat
        Me.lblFechaSalida.Location = New System.Drawing.Point(0, 0)
        Me.lblFechaSalida.Name = "lblFechaSalida"
        Me.lblFechaSalida.Size = New System.Drawing.Size(45, 26)
        Me.lblFechaSalida.TabIndex = 18
        Me.lblFechaSalida.Text = "N/A"
        Me.lblFechaSalida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.AutoSize = true
        Me.Panel4.Controls.Add(Me.DateTimeLlegada)
        Me.Panel4.Controls.Add(Me.lblFechaLlegada)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(169, 280)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(277, 26)
        Me.Panel4.TabIndex = 18
        '
        'DateTimeLlegada
        '
        Me.DateTimeLlegada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimeLlegada.Location = New System.Drawing.Point(0, 26)
        Me.DateTimeLlegada.Name = "DateTimeLlegada"
        Me.DateTimeLlegada.Size = New System.Drawing.Size(277, 20)
        Me.DateTimeLlegada.TabIndex = 19
        Me.DateTimeLlegada.Visible = false
        '
        'lblFechaLlegada
        '
        Me.lblFechaLlegada.AutoSize = true
        Me.lblFechaLlegada.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFechaLlegada.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblFechaLlegada.ForeColor = System.Drawing.Color.Wheat
        Me.lblFechaLlegada.Location = New System.Drawing.Point(0, 0)
        Me.lblFechaLlegada.Name = "lblFechaLlegada"
        Me.lblFechaLlegada.Size = New System.Drawing.Size(45, 26)
        Me.lblFechaLlegada.TabIndex = 18
        Me.lblFechaLlegada.Text = "N/A"
        Me.lblFechaLlegada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldesc
        '
        Me.lbldesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lbldesc.AutoSize = true
        Me.lbldesc.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbldesc.ForeColor = System.Drawing.Color.Orange
        Me.lbldesc.Location = New System.Drawing.Point(3, 179)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(160, 26)
        Me.lbldesc.TabIndex = 12
        Me.lbldesc.Text = "DESCRIPCION"
        Me.lbldesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblentregar
        '
        Me.lblentregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblentregar.AutoSize = true
        Me.lblentregar.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblentregar.ForeColor = System.Drawing.Color.Orange
        Me.lblentregar.Location = New System.Drawing.Point(3, 72)
        Me.lblentregar.Name = "lblentregar"
        Me.lblentregar.Size = New System.Drawing.Size(160, 52)
        Me.lblentregar.TabIndex = 8
        Me.lblentregar.Text = "ENTREGAR A TRNSPORTISTA"
        Me.lblentregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblID
        '
        Me.lblID.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblID.AutoSize = true
        Me.lblID.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblID.ForeColor = System.Drawing.Color.Orange
        Me.lblID.Location = New System.Drawing.Point(3, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(160, 26)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "ID"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblpatio2
        '
        Me.lblpatio2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblpatio2.AutoSize = true
        Me.lblpatio2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblpatio2.ForeColor = System.Drawing.Color.Orange
        Me.lblpatio2.Location = New System.Drawing.Point(3, 29)
        Me.lblpatio2.Name = "lblpatio2"
        Me.lblpatio2.Size = New System.Drawing.Size(160, 26)
        Me.lblpatio2.TabIndex = 3
        Me.lblpatio2.Text = "PATIO"
        Me.lblpatio2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labId
        '
        Me.labId.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.labId.AutoSize = true
        Me.labId.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.labId.ForeColor = System.Drawing.Color.Wheat
        Me.labId.Location = New System.Drawing.Point(169, 0)
        Me.labId.Name = "labId"
        Me.labId.Size = New System.Drawing.Size(277, 26)
        Me.labId.TabIndex = 6
        Me.labId.Text = "N/A"
        Me.labId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnEntregar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(169, 61)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(277, 75)
        Me.Panel2.TabIndex = 9
        '
        'btnEntregar
        '
        Me.btnEntregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnEntregar.BackColor = System.Drawing.Color.DimGray
        Me.btnEntregar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnEntregar.FlatAppearance.BorderSize = 0
        Me.btnEntregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntregar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnEntregar.ForeColor = System.Drawing.Color.Orange
        Me.btnEntregar.Location = New System.Drawing.Point(81, 11)
        Me.btnEntregar.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btnEntregar.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btnEntregar.Name = "btnEntregar"
        Me.btnEntregar.Size = New System.Drawing.Size(143, 53)
        Me.btnEntregar.TabIndex = 2
        Me.btnEntregar.Text = "Entregar"
        Me.btnEntregar.UseVisualStyleBackColor = false
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.riTeBoDescripcion)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(169, 142)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(277, 100)
        Me.Panel3.TabIndex = 11
        '
        'riTeBoDescripcion
        '
        Me.riTeBoDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.riTeBoDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.riTeBoDescripcion.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.riTeBoDescripcion.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.riTeBoDescripcion.Location = New System.Drawing.Point(0, 0)
        Me.riTeBoDescripcion.Margin = New System.Windows.Forms.Padding(7)
        Me.riTeBoDescripcion.Name = "riTeBoDescripcion"
        Me.riTeBoDescripcion.ReadOnly = true
        Me.riTeBoDescripcion.Size = New System.Drawing.Size(277, 100)
        Me.riTeBoDescripcion.TabIndex = 5
        Me.riTeBoDescripcion.Text = ""
        '
        'lblLlegada
        '
        Me.lblLlegada.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblLlegada.AutoSize = true
        Me.lblLlegada.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblLlegada.ForeColor = System.Drawing.Color.Orange
        Me.lblLlegada.Location = New System.Drawing.Point(3, 280)
        Me.lblLlegada.Name = "lblLlegada"
        Me.lblLlegada.Size = New System.Drawing.Size(160, 26)
        Me.lblLlegada.TabIndex = 15
        Me.lblLlegada.Text = "Fecha Llegada"
        Me.lblLlegada.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSALIDA
        '
        Me.lblSALIDA.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblSALIDA.AutoSize = true
        Me.lblSALIDA.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblSALIDA.ForeColor = System.Drawing.Color.Orange
        Me.lblSALIDA.Location = New System.Drawing.Point(3, 248)
        Me.lblSALIDA.Name = "lblSALIDA"
        Me.lblSALIDA.Size = New System.Drawing.Size(160, 26)
        Me.lblSALIDA.TabIndex = 13
        Me.lblSALIDA.Text = "Fecha Salida"
        Me.lblSALIDA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnMod
        '
        Me.btnMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.btnMod.AutoSize = true
        Me.btnMod.BackColor = System.Drawing.Color.DimGray
        Me.btnMod.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnMod.FlatAppearance.BorderSize = 0
        Me.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMod.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnMod.ForeColor = System.Drawing.Color.Orange
        Me.btnMod.Location = New System.Drawing.Point(222, 382)
        Me.btnMod.Margin = New System.Windows.Forms.Padding(3, 20, 3, 3)
        Me.btnMod.MaximumSize = New System.Drawing.Size(999, 55)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(171, 48)
        Me.btnMod.TabIndex = 21
        Me.btnMod.Text = "Aceptar y Modificar"
        Me.btnMod.UseVisualStyleBackColor = false
        Me.btnMod.Visible = false
        '
        'btnAgregarVehiculo
        '
        Me.btnAgregarVehiculo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAgregarVehiculo.AutoSize = true
        Me.btnAgregarVehiculo.BackColor = System.Drawing.Color.DimGray
        Me.btnAgregarVehiculo.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnAgregarVehiculo.FlatAppearance.BorderSize = 0
        Me.btnAgregarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarVehiculo.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAgregarVehiculo.ForeColor = System.Drawing.Color.Orange
        Me.btnAgregarVehiculo.Location = New System.Drawing.Point(222, 309)
        Me.btnAgregarVehiculo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgregarVehiculo.MaximumSize = New System.Drawing.Size(999, 55)
        Me.btnAgregarVehiculo.Name = "btnAgregarVehiculo"
        Me.btnAgregarVehiculo.Size = New System.Drawing.Size(171, 53)
        Me.btnAgregarVehiculo.TabIndex = 23
        Me.btnAgregarVehiculo.Text = "Agregar Vehiculo"
        Me.btnAgregarVehiculo.UseVisualStyleBackColor = false
        '
        'lblVehiculos
        '
        Me.lblVehiculos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblVehiculos.AutoSize = true
        Me.lblVehiculos.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblVehiculos.ForeColor = System.Drawing.Color.Orange
        Me.lblVehiculos.Location = New System.Drawing.Point(3, 0)
        Me.lblVehiculos.Name = "lblVehiculos"
        Me.lblVehiculos.Size = New System.Drawing.Size(483, 26)
        Me.lblVehiculos.TabIndex = 5
        Me.lblVehiculos.Text = "VEHICULOS"
        Me.lblVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(956, 528)
        Me.Panel1.TabIndex = 7
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblVehiculos, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DataGridViewVehiculos, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 0, 2)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(464, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(489, 522)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'DataGridViewVehiculos
        '
        Me.DataGridViewVehiculos.AllowUserToAddRows = false
        Me.DataGridViewVehiculos.AllowUserToDeleteRows = false
        Me.DataGridViewVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVehiculos.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridViewVehiculos.Location = New System.Drawing.Point(3, 29)
        Me.DataGridViewVehiculos.MultiSelect = false
        Me.DataGridViewVehiculos.Name = "DataGridViewVehiculos"
        Me.DataGridViewVehiculos.ReadOnly = true
        Me.DataGridViewVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewVehiculos.ShowCellErrors = false
        Me.DataGridViewVehiculos.ShowCellToolTips = false
        Me.DataGridViewVehiculos.ShowEditingIcon = false
        Me.DataGridViewVehiculos.ShowRowErrors = false
        Me.DataGridViewVehiculos.Size = New System.Drawing.Size(483, 362)
        Me.DataGridViewVehiculos.TabIndex = 6
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel5.Controls.Add(Me.btneliminar, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 397)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(483, 122)
        Me.TableLayoutPanel5.TabIndex = 7
        '
        'btneliminar
        '
        Me.btneliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btneliminar.AutoSize = true
        Me.btneliminar.BackColor = System.Drawing.Color.DimGray
        Me.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btneliminar.FlatAppearance.BorderSize = 0
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btneliminar.ForeColor = System.Drawing.Color.Orange
        Me.btneliminar.Location = New System.Drawing.Point(0, 33)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.btneliminar.MaximumSize = New System.Drawing.Size(999, 55)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(483, 55)
        Me.btneliminar.TabIndex = 24
        Me.btneliminar.Text = "Eliminar Seleccionado"
        Me.btneliminar.UseVisualStyleBackColor = false
        Me.btneliminar.Visible = false
        '
        'VerLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.Panel1)
        Me.Name = "VerLotes"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(972, 544)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.TableLayoutPanel4.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.Panel6.ResumeLayout(false)
        Me.Panel6.PerformLayout
        Me.Panel5.ResumeLayout(false)
        Me.Panel5.PerformLayout
        Me.Panel4.ResumeLayout(false)
        Me.Panel4.PerformLayout
        Me.Panel2.ResumeLayout(false)
        Me.Panel3.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.TableLayoutPanel3.ResumeLayout(false)
        Me.TableLayoutPanel3.PerformLayout
        CType(Me.DataGridViewVehiculos,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanel5.ResumeLayout(false)
        Me.TableLayoutPanel5.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblID As Label
    Friend WithEvents lblpatio2 As Label
    Friend WithEvents labId As Label
    Friend WithEvents lblVehiculos As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btCerrar As Button
    Friend WithEvents DataGridViewVehiculos As DataGridView
    Friend WithEvents lblentregar As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEntregar As Button
    Friend WithEvents lbldesc As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents riTeBoDescripcion As RichTextBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents lblLlegada As Label
    Friend WithEvents lblSALIDA As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblFechaSalida As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblFechaLlegada As Label
    Friend WithEvents DateTimeSalida As DateTimePicker
    Friend WithEvents DateTimeLlegada As DateTimePicker
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cbxPatios As ComboBox
    Friend WithEvents lblPatio As Label
    Friend WithEvents btnMod As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAgregarVehiculo As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents btneliminar As Button
End Class
