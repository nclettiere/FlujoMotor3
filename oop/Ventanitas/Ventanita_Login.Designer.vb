﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventanita_Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.MainContent = New System.Windows.Forms.Panel()
        Me.SuspendLayout
        '
        'MainContent
        '
        Me.MainContent.AutoSize = true
        Me.MainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainContent.Location = New System.Drawing.Point(0, 0)
        Me.MainContent.Name = "MainContent"
        Me.MainContent.Size = New System.Drawing.Size(385, 435)
        Me.MainContent.TabIndex = 0
        '
        'Ventanita_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 435)
        Me.Controls.Add(Me.MainContent)
        Me.Name = "Ventanita_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Operario"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents MainContent As Panel
End Class
