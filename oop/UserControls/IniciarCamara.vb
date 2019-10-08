Imports Logica
Imports WebCam_Capture
Imports MessagingToolkit.QRCode.Codec
Imports System.Threading

Public Class IniciarCamara
    WithEvents MyWebcam As WebCamCapture

    Dim Reader As QRCodeDecoder
    Private QRDetectado As Boolean = False
    Friend Modo As Integer = 0 '' 0=> QR Scan 1=> Sacar Fotos

    Friend InspeccionRef As AgregarDanio

    Private Sub MyWebcam_ImageCaptured(source As Object, e As WebcamEventArgs) Handles MyWebcam.ImageCaptured
        PictureBox1.Image = e.WebCamImage

    End Sub

    Private Sub StartWebcam()
        Try
            StopWebcam()
            MyWebcam = New WebCamCapture
            MyWebcam.Start(0)
            MyWebcam.Start(0)
        Catch ex As Exception

        End Try
    End Sub

    Friend Sub StopWebcam()
        Try
            MyWebcam.Stop()
            MyWebcam.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        StopWebcam()
    End Sub

    Private Sub OnCameraLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        StartWebcam()
        DirectCast(ParentForm, Ventana_Ver).CameraActiva = True

        If Modo = 0
            timer2.Start
        Else
            btnTomatFoto.Visible = True
            Panel1.BackColor = Color.AliceBlue
            timer2.Stop
        End If
    End Sub

    Private Sub DetectarQR()
        Panel1.BackColor = Color.SkyBlue
        Try
            timer2.Stop
            StopWebcam()
            Reader = New QRCodeDecoder
            Dim Ventana As Ventana_Ver = New Ventana_Ver
            Dim verVh As VerVehiculo = New VerVehiculo
            verVh.Data(Reader.decode(New Data.QRCodeBitmapImage(PictureBox1.Image)))
            Ventana.LoadControl(verVh)
            Ventana.Show
            Ventana.TopMost = True
            Panel1.BackColor = Color.Green
            QRDetectado = True
        Catch ex As Exception
            timer2.Stop
            StartWebcam()
            Panel1.BackColor = Color.Red
        End Try
    End Sub

    Private Sub OnTimerTick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Modo = 0
            DetectarQR()
            If Not QRDetectado
                timer2.Start
            Else
                StopWebcam()
                DirectCast(ParentForm, Ventana_Ver).Close
            End If
        End If
    End Sub

    Private Sub BtnTomatFoto_Click(sender As Object, e As EventArgs) Handles btnTomatFoto.Click
        Try
            StopWebcam
            InspeccionRef.CargarImagen(PictureBox1.Image)
            ParentForm.Close
        Catch ex As Exception
            Serilog.Log.Information(ex, "Fatal Error?")
            MessageBox.Show("Error al cargar la imagen tomada. Vea el Log porfavor lol.")
        End Try
    End Sub
End Class
