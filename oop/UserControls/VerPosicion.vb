Imports DB

Public Class VerPosicion
    Private Shared _instance As VerPosicion

    Public Shared Property Instance As VerPosicion
        Get
            If _instance Is Nothing Then
                _instance = New VerPosicion()
            End If
            Return _instance
        End Get
        Set(value As VerPosicion)
            _instance = value
        End Set
    End Property

    Public Property FormParent As Menu_Wapo
    Public Property Conexion As DB.ODBC
    Public Property VIN As String
    Public Property TieneSubzona As Boolean

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim Fila As Integer = Nothing
        Dim Columna As Integer = Nothing
        If Integer.TryParse(tbxFila.Text , Fila) Then
            If Integer.TryParse(tbxColumna.Text , Columna) Then
                If TieneSubzona
                    Try
                        Conexion.consultar("UPDATE vehiculosubzona SET fila ="+ Fila.ToString +", columna ="+ Columna.ToString  +" WHERE vehiculovin='"+ VIN +"' AND zonaid='")  
                    Catch ex As Exception
                        Serilog.Log.Error(ex, "Error al actualizar Subzona.")
                    End Try
                Else
                    Try
                        Conexion.consultar("UPDATE vehiculosubzona SET fila ="+ Fila.ToString +", columna ="+ Columna.ToString  +" WHERE vehiculovin='"+ VIN +"'")  
                    Catch ex As Exception
                        Serilog.Log.Error(ex, "Error al actualizar Subzona.")
                    End Try
                End If
            Else
                MessageBox.Show("El campo 'Columna' debe ser numerico.")
            End If
        Else
          MessageBox.Show("El campo 'Fila' debe ser numerico.")
        End If
    End Sub

    Friend Sub CargarDatos(Conexion As ODBC)
        Me.Conexion = Conexion
        Try
            Dim SubZonaContador As String = Conexion.consultar("SELECT COUNT(*) FROM vehiculosubzona WHERE vehiculovin='" + VIN +"';").Rows(0).Item(0).ToString
            If String.Equals("0", SubZonaContador)
                TieneSubzona = True
            Else
                TieneSubzona = False
            End If
        Catch ex As Exception
            Serilog.Log.Warning(ex, "Exception")
        End Try
    End Sub

    Private Sub OnLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim LoteId As String = Conexion.consultar("SELECT loteid FROM vehiculos WHERE vehiculovin='" + VIN + "'").Rows(0).Item(0).ToString
            Dim PatioId As String = Conexion.consultar("SELECT patioid FROM lotes WHERE loteid=" + LoteId).Rows(0).Item(0).ToString
            Dim SubZonas As DataRowCollection = Conexion.consultar("SELECT * FROM subzonas WHERE patioid=" + PatioId).Rows()

            If SubZonas.Count > 0
                Dim ConsultaPatios As DataTable = Conexion.consultar("SELECT * FROM patios")
                For Each item As DataRow In SubZonas
                    cbxZona.Items.Add(item("subzonanombre").ToString)
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
