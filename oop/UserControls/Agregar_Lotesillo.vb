Public Class Agregar_Lotesillo
    Private Shared _instance As Agregar_Lotesillo
    Private Shared _FormParent As Form


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

    Public Shared Property FormParent As Form
        Get
            Return _FormParent
        End Get
        Set(value As Form)
            _FormParent = value
        End Set
    End Property

    Private Sub BtSeleccionarVehiculo_Click(sender As Object, e As EventArgs) Handles btSeleccionarVehiculo.Click
        Dim Ventanita_Seleccion As Ventanita_Seleccionar = DirectCast(FormParent, Ventanita_Seleccionar)
        Ventanita_Seleccion.GoToSection(1)
    End Sub

    Private Sub OnControlAdded(sender As object, e As ControlEventArgs)
        Dim column As Integer = TableLayoutPanel3.GetPositionFromControl(e.Control).Column
        Dim row As Integer = TableLayoutPanel3.GetPositionFromControl(e.Control).Row
        e.Control.Controls.Add(Seleccionar_Vehiculillo.Instance)
        MessageBox.Show(string.Format("Column: {0}, Row: {1}", column, row))    
    End Sub

    Private Sub BtnAgrExistente_Click(sender As Object, e As EventArgs) Handles btnAgrExistente.Click
        DirectCast(FormParent, Ventanita_Seleccionar).GotoSection(2)
    End Sub
End Class
