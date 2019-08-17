<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ver_Inspeccionsilla
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.btVerD = New System.Windows.Forms.Button()
        Me.riTeBoD = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btVerC = New System.Windows.Forms.Button()
        Me.riTeBoC = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btVerB = New System.Windows.Forms.Button()
        Me.riTeBoB = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.btVerA = New System.Windows.Forms.Button()
        Me.riTeBoA = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labNombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel7, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 8)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.12122!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.87879!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(956, 528)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.btAceptar, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btCancelar, 1, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 462)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.Padding = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(950, 62)
        Me.TableLayoutPanel7.TabIndex = 3
        '
        'btAceptar
        '
        Me.btAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btAceptar.BackColor = System.Drawing.Color.DimGray
        Me.btAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btAceptar.FlatAppearance.BorderSize = 0
        Me.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAceptar.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAceptar.ForeColor = System.Drawing.Color.Orange
        Me.btAceptar.Location = New System.Drawing.Point(181, 8)
        Me.btAceptar.MaximumSize = New System.Drawing.Size(143, 51)
        Me.btAceptar.MinimumSize = New System.Drawing.Size(143, 51)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(143, 51)
        Me.btAceptar.TabIndex = 0
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = False
        '
        'btCancelar
        '
        Me.btCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btCancelar.BackColor = System.Drawing.Color.DimGray
        Me.btCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.btCancelar.FlatAppearance.BorderSize = 0
        Me.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancelar.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.ForeColor = System.Drawing.Color.Orange
        Me.btCancelar.Location = New System.Drawing.Point(626, 8)
        Me.btCancelar.MaximumSize = New System.Drawing.Size(143, 51)
        Me.btCancelar.MinimumSize = New System.Drawing.Size(143, 51)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(143, 51)
        Me.btCancelar.TabIndex = 1
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.10526!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.89474!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel5, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel6, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.labNombre, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(950, 453)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.81121!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.18879!))
        Me.TableLayoutPanel5.Controls.Add(Me.btVerD, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.riTeBoD, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(269, 353)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(678, 97)
        Me.TableLayoutPanel5.TabIndex = 17
        '
        'btVerD
        '
        Me.btVerD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btVerD.BackColor = System.Drawing.Color.DimGray
        Me.btVerD.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btVerD.FlatAppearance.BorderSize = 0
        Me.btVerD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btVerD.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVerD.ForeColor = System.Drawing.Color.Orange
        Me.btVerD.Location = New System.Drawing.Point(531, 22)
        Me.btVerD.MaximumSize = New System.Drawing.Size(130, 53)
        Me.btVerD.MinimumSize = New System.Drawing.Size(130, 53)
        Me.btVerD.Name = "btVerD"
        Me.btVerD.Size = New System.Drawing.Size(130, 53)
        Me.btVerD.TabIndex = 11
        Me.btVerD.Text = "Ver Daño"
        Me.btVerD.UseVisualStyleBackColor = False
        '
        'riTeBoD
        '
        Me.riTeBoD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.riTeBoD.Font = New System.Drawing.Font("Calibri", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.riTeBoD.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.riTeBoD.Location = New System.Drawing.Point(3, 3)
        Me.riTeBoD.Name = "riTeBoD"
        Me.riTeBoD.Size = New System.Drawing.Size(508, 88)
        Me.riTeBoD.TabIndex = 12
        Me.riTeBoD.Text = ""
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.81121!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.18879!))
        Me.TableLayoutPanel4.Controls.Add(Me.btVerC, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.riTeBoC, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(269, 253)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(678, 94)
        Me.TableLayoutPanel4.TabIndex = 16
        '
        'btVerC
        '
        Me.btVerC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btVerC.BackColor = System.Drawing.Color.DimGray
        Me.btVerC.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btVerC.FlatAppearance.BorderSize = 0
        Me.btVerC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btVerC.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVerC.ForeColor = System.Drawing.Color.Orange
        Me.btVerC.Location = New System.Drawing.Point(531, 20)
        Me.btVerC.MaximumSize = New System.Drawing.Size(130, 53)
        Me.btVerC.MinimumSize = New System.Drawing.Size(130, 53)
        Me.btVerC.Name = "btVerC"
        Me.btVerC.Size = New System.Drawing.Size(130, 53)
        Me.btVerC.TabIndex = 11
        Me.btVerC.Text = "Ver Daño"
        Me.btVerC.UseVisualStyleBackColor = False
        '
        'riTeBoC
        '
        Me.riTeBoC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.riTeBoC.Font = New System.Drawing.Font("Calibri", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.riTeBoC.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.riTeBoC.Location = New System.Drawing.Point(3, 3)
        Me.riTeBoC.Name = "riTeBoC"
        Me.riTeBoC.Size = New System.Drawing.Size(508, 88)
        Me.riTeBoC.TabIndex = 12
        Me.riTeBoC.Text = ""
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.81121!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.18879!))
        Me.TableLayoutPanel3.Controls.Add(Me.btVerB, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.riTeBoB, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(269, 153)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(678, 94)
        Me.TableLayoutPanel3.TabIndex = 15
        '
        'btVerB
        '
        Me.btVerB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btVerB.BackColor = System.Drawing.Color.DimGray
        Me.btVerB.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btVerB.FlatAppearance.BorderSize = 0
        Me.btVerB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btVerB.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVerB.ForeColor = System.Drawing.Color.Orange
        Me.btVerB.Location = New System.Drawing.Point(531, 20)
        Me.btVerB.MaximumSize = New System.Drawing.Size(130, 53)
        Me.btVerB.MinimumSize = New System.Drawing.Size(130, 53)
        Me.btVerB.Name = "btVerB"
        Me.btVerB.Size = New System.Drawing.Size(130, 53)
        Me.btVerB.TabIndex = 11
        Me.btVerB.Text = "Ver Daño"
        Me.btVerB.UseVisualStyleBackColor = False
        '
        'riTeBoB
        '
        Me.riTeBoB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.riTeBoB.Font = New System.Drawing.Font("Calibri", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.riTeBoB.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.riTeBoB.Location = New System.Drawing.Point(3, 3)
        Me.riTeBoB.Name = "riTeBoB"
        Me.riTeBoB.Size = New System.Drawing.Size(508, 88)
        Me.riTeBoB.TabIndex = 12
        Me.riTeBoB.Text = ""
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.81121!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.18879!))
        Me.TableLayoutPanel6.Controls.Add(Me.btVerA, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.riTeBoA, 0, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(269, 53)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(678, 94)
        Me.TableLayoutPanel6.TabIndex = 14
        '
        'btVerA
        '
        Me.btVerA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btVerA.BackColor = System.Drawing.Color.DimGray
        Me.btVerA.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btVerA.FlatAppearance.BorderSize = 0
        Me.btVerA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btVerA.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVerA.ForeColor = System.Drawing.Color.Orange
        Me.btVerA.Location = New System.Drawing.Point(531, 20)
        Me.btVerA.MaximumSize = New System.Drawing.Size(130, 53)
        Me.btVerA.MinimumSize = New System.Drawing.Size(130, 53)
        Me.btVerA.Name = "btVerA"
        Me.btVerA.Size = New System.Drawing.Size(130, 53)
        Me.btVerA.TabIndex = 11
        Me.btVerA.Text = "Ver Daño"
        Me.btVerA.UseVisualStyleBackColor = False
        '
        'riTeBoA
        '
        Me.riTeBoA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.riTeBoA.Font = New System.Drawing.Font("Calibri", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.riTeBoA.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.riTeBoA.Location = New System.Drawing.Point(3, 3)
        Me.riTeBoA.Name = "riTeBoA"
        Me.riTeBoA.Size = New System.Drawing.Size(508, 88)
        Me.riTeBoA.TabIndex = 12
        Me.riTeBoA.Text = ""
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(3, 388)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(260, 26)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "INSPECCION (D)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "VEHICULO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labNombre
        '
        Me.labNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labNombre.AutoSize = True
        Me.labNombre.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labNombre.ForeColor = System.Drawing.Color.Wheat
        Me.labNombre.Location = New System.Drawing.Point(269, 12)
        Me.labNombre.Name = "labNombre"
        Me.labNombre.Size = New System.Drawing.Size(678, 26)
        Me.labNombre.TabIndex = 7
        Me.labNombre.Text = "N/A"
        Me.labNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(3, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 26)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "INSPECCION (A)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(3, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 26)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "INSPECCION (B)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(3, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(260, 26)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "INSPECCION (C)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Ver_Inspeccionsilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Ver_Inspeccionsilla"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(972, 544)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents labNombre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents btVerD As Button
    Friend WithEvents riTeBoD As RichTextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btVerC As Button
    Friend WithEvents riTeBoC As RichTextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btVerB As Button
    Friend WithEvents riTeBoB As RichTextBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents btVerA As Button
    Friend WithEvents riTeBoA As RichTextBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents btAceptar As Button
    Friend WithEvents btCancelar As Button
End Class
