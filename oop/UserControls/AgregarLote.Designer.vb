﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarLote
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
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.labRutaF = New System.Windows.Forms.Label()
        Me.labDescripcion = New System.Windows.Forms.Label()
        Me.riTeBoDescripcion = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxPatio = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout
        Me.TableLayoutPanel3.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.TableLayoutPanel4.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.AutoSize = true
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(403, 494)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = true
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 389!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.63158!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.36842!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(397, 488)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.77135!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.22865!))
        Me.TableLayoutPanel2.Controls.Add(Me.labRutaF, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.labDescripcion, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.riTeBoDescripcion, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.cbxPatio, 1, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.830189!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.87422!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.40443!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.90859!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(383, 407)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'labRutaF
        '
        Me.labRutaF.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.labRutaF.AutoSize = true
        Me.labRutaF.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.labRutaF.ForeColor = System.Drawing.Color.Orange
        Me.labRutaF.Location = New System.Drawing.Point(3, 252)
        Me.labRutaF.Name = "labRutaF"
        Me.labRutaF.Size = New System.Drawing.Size(150, 26)
        Me.labRutaF.TabIndex = 16
        Me.labRutaF.Text = "PATIO"
        Me.labRutaF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labDescripcion
        '
        Me.labDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.labDescripcion.AutoSize = true
        Me.labDescripcion.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.labDescripcion.ForeColor = System.Drawing.Color.Orange
        Me.labDescripcion.Location = New System.Drawing.Point(3, 51)
        Me.labDescripcion.Name = "labDescripcion"
        Me.labDescripcion.Size = New System.Drawing.Size(150, 26)
        Me.labDescripcion.TabIndex = 4
        Me.labDescripcion.Text = "DESCRIPCION"
        Me.labDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'riTeBoDescripcion
        '
        Me.riTeBoDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.riTeBoDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.riTeBoDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.riTeBoDescripcion.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.riTeBoDescripcion.Location = New System.Drawing.Point(166, 27)
        Me.riTeBoDescripcion.Margin = New System.Windows.Forms.Padding(10)
        Me.riTeBoDescripcion.Name = "riTeBoDescripcion"
        Me.riTeBoDescripcion.Size = New System.Drawing.Size(207, 74)
        Me.riTeBoDescripcion.TabIndex = 18
        Me.riTeBoDescripcion.Text = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 364)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 40)
        Me.Panel1.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Calibri", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 40)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "*Se agregara el vahiculo anterior al lote"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxPatio
        '
        Me.cbxPatio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbxPatio.FormattingEnabled = true
        Me.cbxPatio.Location = New System.Drawing.Point(166, 255)
        Me.cbxPatio.Margin = New System.Windows.Forms.Padding(10)
        Me.cbxPatio.Name = "cbxPatio"
        Me.cbxPatio.Size = New System.Drawing.Size(207, 21)
        Me.cbxPatio.TabIndex = 25
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Controls.Add(Me.btAgregar, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnCancelar, 1, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(26, 416)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(336, 69)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'btAgregar
        '
        Me.btAgregar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btAgregar.BackColor = System.Drawing.Color.DimGray
        Me.btAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btAgregar.FlatAppearance.BorderSize = 0
        Me.btAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAgregar.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btAgregar.ForeColor = System.Drawing.Color.Orange
        Me.btAgregar.Location = New System.Drawing.Point(12, 9)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(143, 51)
        Me.btAgregar.TabIndex = 1
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = false
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
        Me.btnCancelar.Location = New System.Drawing.Point(180, 9)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(143, 51)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = false
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Calibri", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 40)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Podras agregar mas vehiculos luego."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(159, 364)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(221, 40)
        Me.Panel2.TabIndex = 24
        '
        'Agregar_Lotesillo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Agregar_Lotesillo"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(403, 499)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.TableLayoutPanel3.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.TableLayoutPanel4.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btAgregar As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents labDescripcion As Label
    Friend WithEvents riTeBoDescripcion As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents labRutaF As Label
    Friend WithEvents cbxPatio As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
End Class