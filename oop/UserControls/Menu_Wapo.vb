Imports DB
Imports oop

Public Class Menu_Wapo

    Private Shared _instance As Menu_Wapo

    Public Shared Property Instance As Menu_Wapo
        Get
            If _instance Is Nothing Then
                _instance = New Menu_Wapo()
            End If
            Return _instance
        End Get
        Set(value As Menu_Wapo)
            _instance = value
        End Set
    End Property

    Public Property FormParent As Menu
    Public Property Conexion As ODBC

    Private Sub BtPuerto_Click(sender As Object, e As EventArgs) Handles btPuerto.Click
        btPatio.Font = New Font(btPatio.Font.FontFamily, 14)
        piBoPatio.Size = New Size(56, 30)
        btPatio.BackColor = Color.Transparent
        btPuerto.BackColor = Color.DarkGray
        btPuerto.Font = New Font(btPuerto.Font.FontFamily, 17)
        piBoPuerto.Size = New Size(56, 70)

    End Sub

    Private Sub BtPatio_Click(sender As Object, e As EventArgs) Handles btPatio.Click
        btPuerto.Font = New Font(btPuerto.Font.FontFamily, 14)
        piBoPuerto.Size = New Size(56, 30)
        btPuerto.BackColor = Color.Transparent
        btPatio.BackColor = Color.DarkGray
        btPatio.Font = New Font(btPatio.Font.FontFamily, 17)
        piBoPatio.Size = New Size(56, 70)

    End Sub

    Private Sub BtnVerVehicle_Click(sender As Object, e As EventArgs) Handles btnVerVehicle.Click
        GoToSection(0)
    End Sub

    Private Sub OnLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateVehiculos() 

        Me.AutoSize = true
        Me.AutoSizeMode = AutoSizeMode.GrowOnly
    End Sub

    Private Sub BtnAddVehicle_Click(sender As Object, e As EventArgs) Handles btnAddVehicle.Click
        GoToSection(1)
    End Sub

    ''' <summary>
    ''' Metodo usado para cambiar dinamicamente el contenido del MainContent
    ''' </summary>
    ''' <param name="Section">Integer que especifica el ID de la seccion.</param>
    Private Sub GoToSection(ByVal Section As Integer)
        '' Section => {0=>"VerVehiculos";1=>AgregarVehiculos};

        Dim Selection As Object

        Select Case Section
            Case 0
                Selection = Info_de_Autillos.Instance
                Info_de_Autillos.Instance.FormParent = Me
                btnAddVehicle.BackColor = Color.DimGray
                btnVerVehicle.BackColor = Color.DarkGray
            Case 1
                Selection = Agregar_Vehiculillo.Instance
                Agregar_Vehiculillo.Instance.FormParent = Me
                btnVerVehicle.BackColor = Color.DimGray
                btnAddVehicle.BackColor = Color.DarkGray
            Case Else
                Selection = Info_de_Autillos.Instance
                Info_de_Autillos.Instance.FormParent = Me
                btnAddVehicle.BackColor = Color.DimGray
                btnVerVehicle.BackColor = Color.DarkGray
        End Select

        If Not mainContent.Contains(Selection) Then
            MainContent.Controls.Add(Selection.Instance)
            Selection.Instance.Dock = DockStyle.Fill
            Selection.Instance.BringToFront()
        Else
            Selection.Instance.BringToFront()
        End If
    End Sub

    Friend Sub UpdateVehiculos()
        Dim resultado As DataTable = Conexion.consultar("SELECT COUNT(*) FROM vehiculos")

        If resultado IsNot Nothing
            lblTotalVehiculos.Text = "Total de Vehiculos Ingresados: " + resultado.Rows(0).Item(0).ToString
        Else
            MessageBox.Show("Error Al cargar datos. Vea el Log para mas informacion.")
        End If
    End Sub
End Class
