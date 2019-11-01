Imports Logica

Public Class VerLavados

    Private VIN As String

    Friend Sub CargarDatos(VIN As String)
        Me.VIN = VIN
        DataGridView1.DataSource = MObtenerLavadoVIN(VIN)
        lblLavadoTitulo.Text = _Lang.ObtenerKey("VerLavados", 1)+": " + VIN
    End Sub

    Private Sub BtCerrar_Click(sender As Object, e As EventArgs) Handles btCerrar.Click
        ParentForm.Close
    End Sub

    Private Sub BtnNuevoLavado_Click(sender As Object, e As EventArgs) Handles btnNuevoLavado.Click
        Dim DialogoLavado As DialogResult = MessageBox.Show(_Lang.ObtenerKey("VerLavados", 5), _Lang.ObtenerKey("VerLavados", 2), MessageBoxButtons.YesNo)
        If DialogoLavado = DialogResult.Yes
            Try
                MInsertarLavado(VIN)
                DataGridView1.DataSource = MObtenerLavadoVIN(VIN)
            Catch ex As Exception
                Serilog.Log.Error(ex, "Imposible crear registro de lavado.")
                MessageBox.Show("Surgio un error al intentar crear el lavado. Vea el LOG para mas informacion.")
            End Try
        End If
    End Sub

    Protected _Lang As LangManager  = New LangManager
    Protected Sub UpdateLang
        ParentForm.Text = _Lang.ObtenerKey("VerLavados", 0)
        btnNuevoLavado.Text = _Lang.ObtenerKey("VerLavados", 2)
        btCerrar.Text = _Lang.ObtenerKey("VerLavados", 4)
    End Sub

    Private Sub VerLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateLang
    End Sub
End Class
