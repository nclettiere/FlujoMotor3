Imports CefSharp.WinForms
Imports FlujosTXTs

Public Class Ventana_Ver
    Friend Sub LoadControl(Ctrl As Control)
        Try
            Me.ClientSize = Ctrl.Size
            mainContent.Controls.Add(Ctrl)
            Ctrl.Dock = DockStyle.Fill
            Ctrl.BringToFront()
        Catch ex As Exception
            MsgBox("Wow. Error inesperado al cargar control. Chequee el log para mas info.")
            Serilog.Log.Error(ex, "err...")
        End Try
    End Sub

    Private Sub Ventana_Ver_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If mainContent.Controls(0).GetType Is GetType(VerPatio) Then
            CType(mainContent.Controls(0), VerPatio).ShutDown
        End If
    End Sub
End Class