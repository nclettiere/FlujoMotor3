<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerPatio
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.GeckoWebBrowser3 = New Gecko.GeckoWebBrowser()
        Me.SuspendLayout
        '
        'GeckoWebBrowser3
        '
        Me.GeckoWebBrowser3.ConsoleMessageEventReceivesConsoleLogCalls = true
        Me.GeckoWebBrowser3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GeckoWebBrowser3.FrameEventsPropagateToMainWindow = false
        Me.GeckoWebBrowser3.Location = New System.Drawing.Point(0, 0)
        Me.GeckoWebBrowser3.Name = "GeckoWebBrowser3"
        Me.GeckoWebBrowser3.Size = New System.Drawing.Size(591, 640)
        Me.GeckoWebBrowser3.TabIndex = 0
        Me.GeckoWebBrowser3.UseHttpActivityObserver = false
        '
        'VerPatio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GeckoWebBrowser3)
        Me.Name = "VerPatio"
        Me.Size = New System.Drawing.Size(833, 640)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents GeckoWebBrowser1 As Gecko.GeckoWebBrowser
    Friend WithEvents GeckoWebBrowser2 As Gecko.GeckoWebBrowser
    Friend WithEvents GeckoWebBrowser3 As Gecko.GeckoWebBrowser
End Class
