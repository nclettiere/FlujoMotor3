<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Deus
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_LogIn = New System.Windows.Forms.Button()
        Me.cbxIdioma = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblpswd = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.tbx_user = New System.Windows.Forms.TextBox()
        Me.tbx_passwd = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_LogIn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 379)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(370, 71)
        Me.Panel1.TabIndex = 3
        '
        'btn_LogIn
        '
        Me.btn_LogIn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_LogIn.BackColor = System.Drawing.Color.Gray
        Me.btn_LogIn.FlatAppearance.BorderSize = 0
        Me.btn_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_LogIn.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btn_LogIn.ForeColor = System.Drawing.Color.Crimson
        Me.btn_LogIn.Location = New System.Drawing.Point(114, 9)
        Me.btn_LogIn.MaximumSize = New System.Drawing.Size(143, 53)
        Me.btn_LogIn.MinimumSize = New System.Drawing.Size(143, 53)
        Me.btn_LogIn.Name = "btn_LogIn"
        Me.btn_LogIn.Size = New System.Drawing.Size(143, 53)
        Me.btn_LogIn.TabIndex = 15
        Me.btn_LogIn.Text = "Iniciar Sesion"
        Me.btn_LogIn.UseVisualStyleBackColor = false
        '
        'cbxIdioma
        '
        Me.cbxIdioma.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbxIdioma.BackColor = System.Drawing.Color.White
        Me.cbxIdioma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxIdioma.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.cbxIdioma.FormattingEnabled = True
        Me.cbxIdioma.Items.AddRange(New Object() {"Español", "English"})
        Me.cbxIdioma.Location = New System.Drawing.Point(112, 456)
        Me.cbxIdioma.Name = "cbxIdioma"
        Me.cbxIdioma.Size = New System.Drawing.Size(151, 21)
        Me.cbxIdioma.TabIndex = 4
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblpswd, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lbluser, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tbx_user, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tbx_passwd, 0, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 154)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(370, 219)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'lblpswd
        '
        Me.lblpswd.BackColor = System.Drawing.Color.Transparent
        Me.lblpswd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblpswd.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblpswd.ForeColor = System.Drawing.Color.Crimson
        Me.lblpswd.Location = New System.Drawing.Point(3, 137)
        Me.lblpswd.Margin = New System.Windows.Forms.Padding(3)
        Me.lblpswd.Name = "lblpswd"
        Me.lblpswd.Size = New System.Drawing.Size(364, 22)
        Me.lblpswd.TabIndex = 15
        Me.lblpswd.Text = "CONTRASEÑA"
        Me.lblpswd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lbluser
        '
        Me.lbluser.BackColor = System.Drawing.Color.Transparent
        Me.lbluser.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbluser.Font = New System.Drawing.Font("Calibri", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbluser.ForeColor = System.Drawing.Color.Crimson
        Me.lbluser.Location = New System.Drawing.Point(3, 29)
        Me.lbluser.Margin = New System.Windows.Forms.Padding(3)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(364, 22)
        Me.lbluser.TabIndex = 12
        Me.lbluser.Text = "USUARIO"
        Me.lbluser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbx_user
        '
        Me.tbx_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tbx_user.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbx_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tbx_user.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.tbx_user.Location = New System.Drawing.Point(50, 70)
        Me.tbx_user.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.tbx_user.Name = "tbx_user"
        Me.tbx_user.Size = New System.Drawing.Size(270, 22)
        Me.tbx_user.TabIndex = 13
        Me.tbx_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbx_passwd
        '
        Me.tbx_passwd.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tbx_passwd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbx_passwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tbx_passwd.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.tbx_passwd.Location = New System.Drawing.Point(50, 179)
        Me.tbx_passwd.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.tbx_passwd.Name = "tbx_passwd"
        Me.tbx_passwd.Size = New System.Drawing.Size(270, 22)
        Me.tbx_passwd.TabIndex = 16
        Me.tbx_passwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbx_passwd.UseSystemPasswordChar = true
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cbxIdioma, 0, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 8)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.28456!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.59766!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.11778!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(376, 482)
        Me.TableLayoutPanel1.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.FlujosTXTs.My.Resources.Resources.administrador_Iconillo1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(370, 145)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = false
        '
        'Login_Deus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Login_Deus"
        Me.Size = New System.Drawing.Size(392, 499)
        Me.Panel1.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.TableLayoutPanel1.ResumeLayout(false)
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_LogIn As Button
    Friend WithEvents cbxIdioma As ComboBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblpswd As Label
    Friend WithEvents lbluser As Label
    Friend WithEvents tbx_user As TextBox
    Friend WithEvents tbx_passwd As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
