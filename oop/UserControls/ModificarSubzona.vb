Imports System.Threading
Imports DB

Public Class ModificarSubzona
    Public Property Conexion As ODBC
    Public Property SubZonaNombre As String

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim capacidad As Integer
            If Integer.TryParse(tbxCapacidad.Text, capacidad)
                Dim ContadorSubZona As DataTable = Conexion.Consultar("SELECT COUNT(*) FROM subzonas WHERE subzonanombre='" + tbxNombre.Text + "';")
                If ContadorSubZona.Rows.Count > 0
                    If Not String.Equals(SubZonaNombre, tbxNombre.Text)
                        If ContadorSubZona.Rows(0).Item(0) = 0
                            Dim Resultado As DataTable = Conexion.Consultar("UPDATE subzonas SET subzonanombre ='" + tbxNombre.Text + "', subzonacapacidad = " + tbxCapacidad.Text + " WHERE subzonanombre='" + SubZonaNombre + "';")
                        Else
                            MessageBox.Show("El nombre selccionado ya existe en otra subzona.")
                        End If
                    End If
                End If
            Else
                MessageBox.Show("El campo capacidad debe ser numerico.")
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al obtener datos de subzona.")
        End Try
    End Sub

    Private Sub OnModSubZLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lblSubZona.Text = "Modificar SubZona: " + SubZonaNombre
            Dim Resultado As DataTable = Conexion.Consultar("SELECT * FROM subzonas WHERE subzonanombre='" + SubZonaNombre + "'")
            If Resultado IsNot Nothing
                If Resultado.Rows.Count > 0
                    tbxNombre.Text = Resultado.Rows(0).Item("subzonanombre").ToString
                    tbxCapacidad.Text = Resultado.Rows(0).Item("subzonacapacidad").ToString
                Else
                    btnModificar.Enabled = False
                End If
            Else
                btnModificar.Enabled = False
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al obtener datos de subzona.")
        End Try
    End Sub
End Class
