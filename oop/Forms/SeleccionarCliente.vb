Imports Logica

Public Class SeleccionarCliente
    Private ParentFormClass As Agregar_Lote
    Private FacadeRef As Facade

    Private Seleccion As Integer


    Friend Sub cargar(AgLote As Agregar_Lote, facade As Facade)
        ParentFormClass = AgLote
        FacadeRef = facade
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        Seleccion = Int32.Parse(lst_clientes.SelectedItems(0).Group.Name.ToString)

        ParentFormClass.CargarCliente(Seleccion)

        Me.Close()
    End Sub

    Private Sub SeleccionarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show(FacadeRef.ObtenerClientes().Count.ToString)
        For Each item As Cliente In FacadeRef.ObtenerClientes()
            Dim lvitem = New ListViewItem(item.ClienteNombre + " " + item.ClienteApellido)
            lvitem.Group = New ListViewGroup(item.ClienteID.ToString, item.ClienteID.ToString)
            lst_clientes.Items.Add(lvitem)
        Next

    End Sub
End Class