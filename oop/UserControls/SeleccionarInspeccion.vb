Imports BrightIdeasSoftware
Imports Logica

Public Class SeleccionarInspeccion

    Friend UC_VerInspeccion As VerInspeccion
    Protected FastDataList As FastDataListView
    Friend InspeccionId As String

    Private Sub SeleccionarInspeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FastDataList = New FastDataListView
        FastDataList.ShowGroups = False
        FastDataList.Dock = DockStyle.Fill
        FastDataList.FullRowSelect = True
        FastDataList.MultiSelect = False

        AddHandler FastDataList.SelectionChanged, AddressOf CambioSeleccion

        Panel1.Controls.Add(FastDataList)

        Try
            Dim ListaDanios As DataTable = Nothing

            ListaDanios = DObtener()

            FastDataList.DataSource = ListaDanios

            For Each column As ColumnHeader In FastDataList.Columns
                column.Width = -2
            Next
        Catch ex As Exception
            Serilog.Log.Error(ex, "er..")
            MsgBox("Hubo un error al cargar la lista de danios.")
            btnSelec.Enabled = False
        End Try
    End Sub

    Private Sub CambioSeleccion(sender As Object, e As EventArgs)
        If FastDataList.SelectedIndex >= 0 Then
            btnSelec.Enabled = True
        Else
            btnSelec.Enabled = False
        End If
    End Sub

    Private Sub BtnSelec_Click(sender As Object, e As EventArgs) Handles btnSelec.Click

        Dim DanioId As String = FastDataList.SelectedItem.SubItems.Item(0).Text

        If UC_VerInspeccion IsNot Nothing Then
            UC_VerInspeccion.AgregarDanioViejo(DanioId, InspeccionId)
        End If

        ParentForm.Close()
    End Sub
End Class
