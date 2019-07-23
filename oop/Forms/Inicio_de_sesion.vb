Imports Logica

Public Class Inicio_de_sesion

    Private FacadeRef As Facade
    Private Usuarios As List(Of Operario)

    Private Charged As Boolean = False
    Private ChargedForm As Menu_Operario

    'BOTON (OJITO)
    Private Sub BtMostrar_Ocultar_Click(sender As Object, e As EventArgs) Handles btMostrar_Ocultar.Click
        If (txtContraseña.UseSystemPasswordChar = True) Then
            txtContraseña.UseSystemPasswordChar = False
            btMostrar_Ocultar.BackgroundImage = My.Resources.hide_gris
        ElseIf (txtContraseña.UseSystemPasswordChar = False) Then
            txtContraseña.UseSystemPasswordChar = True
            btMostrar_Ocultar.BackgroundImage = My.Resources.ojito_gris
        End If
    End Sub

    'BOTON "INGRESAR"
    Private Sub BtIngresar_Click(sender As Object, e As EventArgs) Handles btIngresar.Click
        If (String.IsNullOrWhiteSpace(txtContraseña.Text)) And (String.IsNullOrEmpty(txtUsuario.Text)) Then
            MessageBox.Show("Nunguno de los campos puede quedar vacio", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (String.IsNullOrWhiteSpace(txtContraseña.Text)) Then
            MessageBox.Show("El campo 'contraseña' no debe quedar vacio", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (String.IsNullOrWhiteSpace(txtUsuario.Text)) Then
            MessageBox.Show("El campo 'usuario' no debe quedar vacio", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            For Each item As Operario In Usuarios
                    If String.Equals(item.Email, txtUsuario.Text) Then
                        If String.Equals(item.Password, txtContraseña.Text) Then
                            Dim menu = New Menu_Operario()
                        menu.crear(FacadeRef, Me, item, Usuarios, Charged)
                        Me.Hide()
                            menu.ShowDialog()
                            Me.Close()
                        End If
                    End If
                Next
        End If
        MessageBox.Show("Contrasena o usuario invalidos.")
    End Sub

    Private Sub btIngresar_MouseEnter(sender As Object, e As EventArgs) Handles btIngresar.MouseEnter
        btIngresar.ForeColor = Color.SandyBrown
    End Sub

    Private Sub btIngresar_MouseLeave(sender As Object, e As EventArgs) Handles btIngresar.MouseLeave
        btIngresar.ForeColor = Color.Peru
    End Sub

    Private Sub CargarClientes(archivo As String)

        Dim filePath As String = archivo
        Dim streamReader As New IO.StreamReader(filePath)
        Dim StreamText As String

        While Not streamReader.EndOfStream

            StreamText = streamReader.ReadLine()

            Dim StreamArray As String() = StreamText.Split(",")

            FacadeRef.AgregarCliente(New Cliente(Int32.Parse(StreamArray(0)),
                                                    StreamArray(1),
                                                    StreamArray(2)))
        End While

        streamReader.Dispose()

    End Sub

    Private Sub CargarVehiculos(archivo As String)

        Dim filePath As String = archivo
        Dim streamReader As New IO.StreamReader(filePath)
        Dim StreamText As String

        While Not streamReader.EndOfStream

            StreamText = streamReader.ReadLine()

            Dim StreamArray As String() = StreamText.Split(",")

            FacadeRef.AgregarVehiculo(New Vehiculo(StreamArray(0),
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

    Friend Sub cargar(menu_Operario As Menu_Operario, facadeRef As Facade)
        ChargedForm = menu_Operario
        Me.FacadeRef = facadeRef
        Charged = True
    End Sub

    Friend Sub cargar(path As String)

        Usuarios = New List(Of Operario)
        FacadeRef = New Facade

        If String.IsNullOrEmpty(path) Then
            MessageBox.Show("Error Al cargar CSV's")
            Me.Close()
        Else
            FacadeRef.CSVVehiculos = path + "\vehiculos.csv"
            FacadeRef.CSVUbicaciones = path + "\ubicaciones.csv"
            FacadeRef.CSVInspecciones = path + "\ubicaciones.csv"

            CargarUsuarios(path + "\operarios.csv")
            CargarVehiculos(path + "\vehiculos.csv")
            CargarPatios(path + "\patios.csv")
            CargarUbicaciones(path + "\ubicaciones.csv")
            CargarInspecciones(path + "\inspecciones.csv")
            CargarClientes(path + "\clientes.csv")
        End If
    End Sub

    Private Sub CargarInspecciones(strInspecciones As String)
        Dim filePath As String = strInspecciones
        Dim streamReader As New IO.StreamReader(filePath)
        Dim StreamText As String

        While Not streamReader.EndOfStream

            StreamText = streamReader.ReadLine()

            Dim StreamArray As String() = StreamText.Split(",")

            If String.IsNullOrWhiteSpace(StreamArray(5)) Then
                FacadeRef.AgregarInspeccion(New Inspeccion(Int32.Parse(StreamArray(0)),
                                                       StreamArray(1),
                                                       StreamArray(2),
                                                       Int32.Parse(StreamArray(3)),
                                                       StreamArray(4)))
            Else
                FacadeRef.AgregarInspeccion(New Inspeccion(Int32.Parse(StreamArray(0)),
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

            FacadeRef.AgregarPatio(New Patio(Int32.Parse(StreamArray(0)), StreamArray(1), Double.Parse(StreamArray(2)), Double.Parse(StreamArray(3))))

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

            FacadeRef.AgregarUbicacion(New Ubicacion(Int32.Parse(StreamArray(0)),
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

    Private Sub Inicio_de_sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Charged Then
            Dim CargarCSV = New SeleccionarCSV()
            ''CargarCSV.Cargar(Me)
            CargarCSV.ShowDialog()
        Else
            Menu_Operario.Close()
            Usuarios = FacadeRef.ObtenerOperarios()
        End If
    End Sub
End Class