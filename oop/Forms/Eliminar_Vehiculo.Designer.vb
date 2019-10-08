<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Eliminar_Vehiculo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.gpboInformacion = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.labVIN = New System.Windows.Forms.Label()
        Me.txtVIN = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.gpboInformacion.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btCancelar)
        Me.Panel1.Controls.Add(Me.btAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(413, 72)
        Me.Panel1.TabIndex = 7
        '
        'btCancelar
        '
        Me.btCancelar.BackgroundImage = Global.oop.My.Resources.Resources.boton_buscar
        Me.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCancelar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btCancelar.FlatAppearance.BorderSize = 0
        Me.btCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancelar.Font = New System.Drawing.Font("Agency FB", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.ForeColor = System.Drawing.Color.White
        Me.btCancelar.Location = New System.Drawing.Point(223, 0)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(190, 72)
        Me.btCancelar.TabIndex = 7
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'btAceptar
        '
        Me.btAceptar.BackgroundImage = Global.oop.My.Resources.Resources.boton_buscar
        Me.btAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAceptar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btAceptar.FlatAppearance.BorderSize = 0
        Me.btAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAceptar.Font = New System.Drawing.Font("Agency FB", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAceptar.ForeColor = System.Drawing.Color.White
        Me.btAceptar.Location = New System.Drawing.Point(0, 0)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(190, 72)
        Me.btAceptar.TabIndex = 6
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'gpboInformacion
        '
        Me.gpboInformacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpboInformacion.Controls.Add(Me.TableLayoutPanel1)
        Me.gpboInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gpboInformacion.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpboInformacion.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.gpboInformacion.Location = New System.Drawing.Point(3, 12)
        Me.gpboInformacion.Name = "gpboInformacion"
        Me.gpboInformacion.Size = New System.Drawing.Size(408, 88)
        Me.gpboInformacion.TabIndex = 8
        Me.gpboInformacion.TabStop = False
        Me.gpboInformacion.Text = "INFORMACION"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.04975!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.95025!))
        Me.TableLayoutPanel1.Controls.Add(Me.labVIN, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtVIN, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 26)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(402, 59)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'labVIN
        '
        Me.labVIN.AutoSize = True
        Me.labVIN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labVIN.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labVIN.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.labVIN.Location = New System.Drawing.Point(3, 0)
        Me.labVIN.Name = "labVIN"
        Me.labVIN.Size = New System.Drawing.Size(155, 59)
        Me.labVIN.TabIndex = 3
        Me.labVIN.Text = "V.I.N.  :"
        Me.labVIN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVIN
        '
        Me.txtVIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVIN.BackColor = System.Drawing.Color.White
        Me.txtVIN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVIN.Font = New System.Drawing.Font("Arial Narrow", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVIN.Location = New System.Drawing.Point(164, 16)
        Me.txtVIN.MaxLength = 17
        Me.txtVIN.Name = "txtVIN"
        Me.txtVIN.Size = New System.Drawing.Size(235, 27)
        Me.txtVIN.TabIndex = 2
        '
        'Eliminar_Vehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(413, 191)
        Me.Controls.Add(Me.gpboInformacion)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Eliminar_Vehiculo"
        Me.ShowIcon = False
        Me.Text = "Eliminar Vehiculo"
        Me.Panel1.ResumeLayout(False)
        Me.gpboInformacion.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btCancelar As Button
    Friend WithEvents btAceptar As Button
    Friend WithEvents gpboInformacion As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents labVIN As Label
    Friend WithEvents txtVIN As TextBox
End Class
