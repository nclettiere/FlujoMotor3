Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing
Imports Logica

Public Class EscanearQR

    Private CaptureDevice As FilterInfoCollection
    Private FinalFrame As VideoCaptureDevice
    Private Reader As BarcodeReader = New BarcodeReader()

    Public Sub New()
        InitializeComponent
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        CaptureDevice = New FilterInfoCollection(FilterCategory.VideoInputDevice)

        For Each Device As FilterInfo In CaptureDevice
            comboBox1.Items.Add(Device.Name)
        Next

        If CaptureDevice.Count > 0
            comboBox1.SelectedIndex = 0
            FinalFrame = New VideoCaptureDevice()

            FinalFrame = New VideoCaptureDevice(CaptureDevice(comboBox1.SelectedIndex).MonikerString)
            AddHandler FinalFrame.NewFrame, Sub(s, ea) FinalFrame_NewFrame(s, ea)
            FinalFrame.Start()
        Else
            MsgBox("No se detecto ninguna camara. Conecte la camara y vuelva a intentar.")
            btnScan.Enabled = False
            Me.Close
        End If
    End Sub

    Private Sub FinalFrame_NewFrame(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        pictureBox1.Image = CType(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        Try
            If pictureBox1.Image IsNot Nothing
                Dim bitmapVin As Bitmap = New Bitmap(pictureBox1.Image)
                If bitmapVin IsNot Nothing
                    Dim resultado As Result = Reader.Decode(New Bitmap(pictureBox1.Image))
                    Dim CodigoVIN As String = resultado.ToString.Trim

                    If CodigoVIN <> "" Then
                        timer1.[Stop]()
                        
                        If VCheckVIN(CodigoVIN) > 0
                            Try
                                ShutDown
                                Dim VentanaVer As Ventana_Ver = New Ventana_Ver
                                Dim VerVehiculo As VerVehiculo = New VerVehiculo
                                VerVehiculo.Data(CodigoVIN)
                                VentanaVer.LoadControl(VerVehiculo)
                                VentanaVer.TopMost = True
                                VentanaVer.Show()
                                Me.Close
                            Catch ex As Exception
                                Serilog.Log.Warning(ex, "InfoAutos")
                            End Try
                        Else
                            MsgBox("No se encontro el vehiculo deseado. Intentalo de nuevo.")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
        If FinalFrame.IsRunning = True Then
            FinalFrame.[Stop]()
        End If
    End Sub

    Private Sub BtnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        timer1.Enabled = True
        timer1.Start()
    End Sub

    Private Sub EscanearQR_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ShutDown
    End Sub

    Private Sub ShutDown
        timer1.Enabled = False
        timer1.[Stop]
        If FinalFrame IsNot Nothing
            If FinalFrame.IsRunning = True Then
                FinalFrame.[Stop]
            End If
        End If
    End Sub
End Class