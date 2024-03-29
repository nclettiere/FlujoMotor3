﻿Imports System.IO
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing
Imports ZXing.Aztec

Public Class QRScan
    Private CaptureDevice As FilterInfoCollection
    Private FinalFrame As VideoCaptureDevice

    Public Sub New()
        InitializeComponent
    End Sub

    Private Sub QRScan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CaptureDevice = New FilterInfoCollection(FilterCategory.VideoInputDevice)

            For Each Device As FilterInfo In CaptureDevice
                comboBox1.Items.Add(Device.Name)
            Next

            comboBox1.SelectedIndex = 0
            FinalFrame = New VideoCaptureDevice()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        FinalFrame = New VideoCaptureDevice(CaptureDevice(comboBox1.SelectedIndex).MonikerString)
        AddHandler FinalFrame.NewFrame, AddressOf FinalFrame_NewFrame
        FinalFrame.Start()
    End Sub

    Private Sub FinalFrame_NewFrame(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        pictureBox1.Image = CType(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        Dim Reader As BarcodeReader = New BarcodeReader()
        Dim result As Result = Reader.Decode(CType(pictureBox1.Image, Bitmap))

        Try
            Dim decoded As String = result.ToString().Trim()

            If decoded <> "" Then
                timer1.[Stop]()
                MessageBox.Show(decoded)
                'Dim form As Form2 = New Form2()
                'form.Show()
                'Me.Hide()
            End If

        Catch ex As Exception
        End Try
    End Sub
End Class
