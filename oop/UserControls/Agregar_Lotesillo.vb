Imports DB
Imports oop

Public Class Agregar_Lotesillo
    Private Shared _instance As Agregar_Lotesillo
    Public Shared Property Instance As Agregar_Lotesillo
        Get
            If _instance Is Nothing Then
                _instance = New Agregar_Lotesillo()
            End If
            Return _instance
        End Get
        Set(value As Agregar_Lotesillo)
            _instance = value
        End Set
    End Property

    Public Shared Property ListaVehiculosSeleccionados As List(Of String)
    Public Property FormParent As Ventanita_Seleccionar
    Public Property ParentControl As Agregar_Vehiculillo
    Public Property Conexion As DB.ODBC
    Public Property Cliente As String

    Private Sub BtnAgrExistente_Click(sender As Object, e As EventArgs) 
        DirectCast(FormParent, Ventanita_Seleccionar).GotoSection(2)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DirectCast(FormParent, Ventanita_Seleccionar).Close()
    End Sub

    Private Sub BtAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        If Not String.IsNullOrWhiteSpace(riTeBoDescripcion.Text)
            If Not String.IsNullOrWhiteSpace(txtRutaInicial.Text)
                If Not String.IsNullOrWhiteSpace(txtRutaFinal.Text)
                    Dim datos As String() = {riTeBoDescripcion.Text, txtRutaInicial.Text, txtRutaFinal.Text}
                    ParentControl.UpdateLotes(datos)
                    FormParent.Close()
                End If
            End If
        Else
            MessageBox.Show("La descripcion no debe quedar vacia.")
        End If
    End Sub

    Friend Sub CargarDatos(ventanita_Seleccionar As Ventanita_Seleccionar, parent As Object, conexion As ODBC)
        FormParent = ventanita_Seleccionar
        ParentControl = DirectCast(parent, Agregar_Vehiculillo)
        Me.Conexion = conexion
    End Sub

End Class
