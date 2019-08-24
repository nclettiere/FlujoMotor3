Imports Serilog

Public Class InspeccionWidget
    Private Shared _instance As InspeccionWidget

    Public Shared Property Instance As InspeccionWidget
        Get
            If _instance Is Nothing Then
                _instance = New InspeccionWidget()
            End If
            Return _instance
        End Get
        Set(value As InspeccionWidget)
            _instance = value
        End Set
    End Property

    Friend Sub CargarDatos(ByVal inspeccionId As String, ByRef Conexion As DB.ODBC, ByVal index As Integer)
        Try
            Dim resultadoInspeccion As DataTable = Conexion.consultar("SELECT * FROM inspecciones WHERE inspeccionid='"+ inspeccionId +"'")
            If resultadoInspeccion IsNot Nothing
                Dim resultadoInspeccionDanio As DataTable = Conexion.consultar("SELECT * FROM inspeccionDanio WHERE inspeccionid='"+ inspeccionId +"'")
                If resultadoInspeccionDanio IsNot Nothing
                    Dim resultadoDanio As DataTable = Conexion.consultar("SELECT danioid, daniodescripcion FROM danios WHERE danioid=1")
                    If resultadoDanio IsNot Nothing
                        Try
                            lbl_name.Text = "INSPECCION_" + resultadoDanio.Rows(0).Item("danioid").ToString
                            rchtbxDesc.Text = resultadoDanio.Rows(0).Item("daniodescripcion").ToString
                        Catch ex As Exception
                            Log.Information(ex, "Error InspeccionWidget")
                        End Try
                        
                    End If
                End If
            End If
        Catch ex As Exception
            Log.Fatal(ex, "Error al procesar datos en InspeccionWidget.CargarDatos().")
            #If DEBUG
                MessageBox.Show("Error: " + ex.Message)
            #Else
                MessageBox.Show("Error al cargar datos. Vea el Log para mas informacion.")
            #End If

        End Try
    End Sub

    Private Sub BtnVerDan_Click(sender As Object, e As EventArgs) 

    End Sub
End Class
