<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ver_Inspeccionsilla
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
        Me.labTitulo = New System.Windows.Forms.Label()
        Me.labNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.riCheBoDescripcion = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.labNombre, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.labTitulo, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.riCheBoDescripcion, 0, 3)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 8)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.3516!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.3516!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.789474!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.68421!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(528, 475)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'labTitulo
        '
        Me.labTitulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labTitulo.AutoSize = True
        Me.labTitulo.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTitulo.ForeColor = System.Drawing.Color.Orange
        Me.labTitulo.Location = New System.Drawing.Point(3, 28)
        Me.labTitulo.Name = "labTitulo"
        Me.labTitulo.Size = New System.Drawing.Size(522, 26)
        Me.labTitulo.TabIndex = 2
        Me.labTitulo.Text = "A"
        Me.labTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labNombre
        '
        Me.labNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labNombre.AutoSize = True
        Me.labNombre.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labNombre.ForeColor = System.Drawing.Color.Orange
        Me.labNombre.Location = New System.Drawing.Point(3, 110)
        Me.labNombre.Name = "labNombre"
        Me.labNombre.Size = New System.Drawing.Size(522, 26)
        Me.labNombre.TabIndex = 3
        Me.labNombre.Text = "B"
        Me.labNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(3, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(522, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "DESCRIPCION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'riCheBoDescripcion
        '
        Me.riCheBoDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.riCheBoDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.riCheBoDescripcion.Location = New System.Drawing.Point(7, 207)
        Me.riCheBoDescripcion.Margin = New System.Windows.Forms.Padding(7)
        Me.riCheBoDescripcion.Name = "riCheBoDescripcion"
        Me.riCheBoDescripcion.Size = New System.Drawing.Size(514, 261)
        Me.riCheBoDescripcion.TabIndex = 5
        Me.riCheBoDescripcion.Text = ""
        '
        'Ver_Inspeccionsilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Ver_Inspeccionsilla"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(544, 491)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents labNombre As Label
    Friend WithEvents labTitulo As Label
    Friend WithEvents riCheBoDescripcion As RichTextBox
End Class
