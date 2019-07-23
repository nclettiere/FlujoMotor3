Imports Logica
Imports oop

Public Class Login

    Private Shared _instance As Login

    Private Usuarios As List(Of Operario)

    Private facade As Facade
    Private main As MainWindow

    Private OperarioId As Integer

    Public Shared Property Instance As Login
        Get
            If _instance Is Nothing Then
                _instance = New Login()
            End If
            Return _instance
        End Get
        Set(value As Login)
            _instance = value
        End Set
    End Property

    Friend Sub LoadData(main As MainWindow, facade As Facade)
        Me.facade = facade
        Me.main = main
    End Sub

    Function verifyLogin() As Boolean

        For Each operario As Operario In Usuarios
            If String.Equals(operario.Email, tbx_user.Text) Then
                If String.Equals(operario.Password, tbx_passwd.Text) Then
                    OperarioId = operario.Id
                    Return True
                End If
            End If
        Next

        Return False

    End Function

    Private Sub SizeChng(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Panel1.Left = (Me.ClientSize.Width - Panel1.Width) / 2
        Panel1.Top = (Me.ClientSize.Height - Panel1.Height) / 2
    End Sub

    Private Sub Btn_LogIn_Click_1(sender As Object, e As EventArgs) Handles btn_LogIn.Click
        If verifyLogin() Then
            main.ChangeControlSummary(OperarioId)
        Else
            MessageBox.Show("Nombre de Usuario o Contrasena Invalidos.")
        End If
    End Sub

    Friend Sub cargar(path As String)

        Usuarios = New List(Of Operario)

        If String.IsNullOrEmpty(path) Then
            MessageBox.Show("Error Al cargar CSV's")
        Else
            facade.CSVVehiculos = path + "\vehiculos.csv"
            facade.CSVUbicaciones = path + "\ubicaciones.csv"
            facade.CSVInspecciones = path + "\ubicaciones.csv"

            CargarUsuarios(path + "\operarios.csv")
            CargarVehiculos(path + "\vehiculos.csv")
            CargarPatios(path + "\patios.csv")
            CargarUbicaciones(path + "\ubicaciones.csv")
            CargarInspecciones(path + "\inspecciones.csv")
            CargarClientes(path + "\clientes.csv")
        End If
    End Sub

    Private Sub CargarVehiculos(archivo As String)

        Dim filePath As String = archivo
        Dim streamReader As New IO.StreamReader(filePath)
        Dim StreamText As String

        While Not streamReader.EndOfStream

            StreamText = streamReader.ReadLine()

            Dim StreamArray As String() = StreamText.Split(",")

            facade.AgregarVehiculo(New Vehiculo(StreamArray(0),
                                                    StreamArray(1),
                                                    StreamArray(2),
                                                    StreamArray(3),
                                                    StreamArray(4),
                                                    Short.Parse(StreamArray(5)),
                                                    StreamArray(6),
                                                    0,
                                                    Int32.Parse(StreamArray(7)),
                                                    Int32.Parse(StreamArray(9)),
                                                    StreamArray(10)))
        End While

        streamReader.Dispose()

    End Sub

    Private Sub CargarClientes(archivo As String)

        Dim filePath As String = archivo
        Dim streamReader As New IO.StreamReader(filePath)
        Dim StreamText As String

        While Not streamReader.EndOfStream

            StreamText = streamReader.ReadLine()

            Dim StreamArray As String() = StreamText.Split(",")

            facade.AgregarCliente(New Cliente(Int32.Parse(StreamArray(0)),
                                                    StreamArray(1),
                                                    StreamArray(2)))
        End While

        streamReader.Dispose()

    End Sub

    Private Sub CargarInspecciones(strInspecciones As String)
        Dim filePath As String = strInspecciones
        Dim streamReader As New IO.StreamReader(filePath)
        Dim StreamText As String

        While Not streamReader.EndOfStream

            StreamText = streamReader.ReadLine()

            Dim StreamArray As String() = StreamText.Split(",")

            If String.IsNullOrWhiteSpace(StreamArray(5)) Then
                facade.AgregarInspeccion(New Inspeccion(Int32.Parse(StreamArray(0)),
                                                       StreamArray(1),
                                                       StreamArray(2),
                                                       Int32.Parse(StreamArray(3)),
                                                       StreamArray(4)))
            Else
                facade.AgregarInspeccion(New Inspeccion(Int32.Parse(StreamArray(0)),
                                       StreamArray(1),
                                       StreamArray(2),
                                       Int32.Parse(StreamArray(3)),
                                       StreamArray(4),
                                       Int32.Parse(StreamArray(5))))
            End If

        End While

        streamReader.Dispose()
    End Sub

    Private Sub CargarPatios(archivo As String)

        Dim filePath As String = archivo
        Dim streamReader As New IO.StreamReader(filePath)
        Dim StreamText As String

        While Not streamReader.EndOfStream

            StreamText = streamReader.ReadLine()

            Dim StreamArray As String() = StreamText.Split(",")

            facade.AgregarPatio(New Patio(Int32.Parse(StreamArray(0)), StreamArray(1), Double.Parse(StreamArray(2)), Double.Parse(StreamArray(3))))

        End While

        streamReader.Dispose()
    End Sub

    Private Sub CargarUbicaciones(archivo As String)

        Dim filePath As String = archivo
        Dim streamReader As New IO.StreamReader(filePath)
        Dim StreamText As String

        While Not streamReader.EndOfStream

            StreamText = streamReader.ReadLine()

            Dim StreamArray As String() = StreamText.Split(",")

            facade.AgregarUbicacion(New Ubicacion(Int32.Parse(StreamArray(0)),
                                                  Double.Parse(StreamArray(1)),
                                                  Double.Parse(StreamArray(2)),
                                                  StreamArray(3),
                                                  Integer.Parse(StreamArray(4))))
        End While

        streamReader.Dispose()

    End Sub

    Private Sub CargarUsuarios(archivo As String)

        Dim filePath As String = archivo
        Dim streamReader As New IO.StreamReader(filePath)
        Dim StreamText As String

        While Not streamReader.EndOfStream

            StreamText = streamReader.ReadLine()

            If Not String.IsNullOrEmpty(StreamText) Then
                Dim StreamArray As String() = StreamText.Split(",")
                Dim OperarioNuevo = New Operario(StreamArray(0),
                                      StreamArray(1),
                                      StreamArray(2),
                                      StreamArray(3),
                                      StreamArray(4),
                                      StreamArray(5),
                                      Int32.Parse(StreamArray(6)),
                                      Int32.Parse(StreamArray(7)))
                Usuarios.Add(OperarioNuevo)
            Else
                MessageBox.Show("Error al cargar los usaurios. Asegurese de que la ruta del csv sea correcta.")
            End If

        End While
        streamReader.Dispose()
    End Sub

    Private Sub onLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim seleccionarCSV As New SeleccionarCSV()
        seleccionarCSV.Cargar(Me)

        seleccionarCSV.ShowDialog()
    End Sub
End Class
