Imports System.Data.Odbc
Public Module Empleados
    Public Function Disponibilidad(Usuario As String) As Boolean
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT COUNT(*) FROM usuarios WHERE usuario='" + Usuario + "'", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Dim Result As Integer
            If Integer.TryParse(tabla.Rows(0).Item(0), Result)
                If Result > 0
                    Return False
                Else
                    Return True
                End If
            Else
                Return True
            End If
        Else
            MsgBox("Hubo un error al listar usuarios.")
            Return False
        End If
    End Function

    Public Function EInsertar(ByVal Usuario As String, ByVal Nombre As String, ByVal Apellido As String, ByVal Telefono As String, ByVal Hash As Encriptacion.HashySalt) As Boolean


        Dim Dcommand As OdbcCommand = New OdbcCommand("INSERT INTO usuarios (empleadoid,usuario,hash,salt) VALUES (?, ?, ?, ?)")
        Dim Dparameters As OdbcParameterCollection = Dcommand.Parameters

        Dparameters.Add("empleadoid", OdbcType.Int)
        Dparameters("empleadoid").Value = Metadata(0)

        Dparameters.Add("vehiculocolor", OdbcType.VarChar)
        Dparameters("vehiculocolor").Value = Metadata(1)

        Dparameters.Add("vehiculomarca", OdbcType.VarChar)
        Dparameters("vehiculomarca").Value = Metadata(2)

        Dparameters.Add("vehiculomodelo", OdbcType.VarChar)
        Dparameters("vehiculomodelo").Value = Metadata(3)

        Dparameters.Add("vehiculoanio", OdbcType.SmallInt)
        Dparameters("vehiculoanio").Value = Integer.Parse(Metadata(4))

        Dparameters.Add("vehiculotipo", OdbcType.VarChar)
        Dparameters("vehiculotipo").Value = Metadata(5)

        Dparameters.Add("operariopuertoid", OdbcType.Int)
        Dparameters("operariopuertoid").Value = 1

        Dcommand.Connection = DBConexion
        Dcommand.ExecuteNonQuery()
    End Function
End Module
