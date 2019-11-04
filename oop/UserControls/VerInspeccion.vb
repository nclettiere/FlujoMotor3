Imports System.Threading
Imports Logica


Public Class VerInspeccion
    Private Shared _instance As VerInspeccion

    Public Shared Property Instance As VerInspeccion
        Get
            If _instance Is Nothing Then
                _instance = New VerInspeccion()
            End If
            Return _instance
        End Get
        Set(value As VerInspeccion)
            _instance = value
        End Set
    End Property

    Public Property FormParent As Ventana_Ver
    Private VIN As String

    Friend Sub Populate(VIN As String)
        Me.VIN = VIN
        lblVehiculoVin.Text = _Lang.ObtenerKey("VerInspecciones", 1)+": " + VIN
        Dim Contador As Integer = 1
        Try
            For Each Inspeccion As DataRow In IObtenerVIN(VIN).Rows
                FlowInspecciones.Controls.Add(DrawInspeccion(
                                              Inspeccion.Item("inspeccionID"),
                                              Contador.ToString, 
                                              Inspeccion.Item("inspeccionFecha").ToString,
                                              Consultar("SELECT empleadonombre FROM empleados WHERE empleadoid="+Inspeccion.Item("operarioid").ToString).Rows(0).Item(0)
                                              ))
                Contador += 1
            Next
        Catch ex As Exception

        End Try
    End Sub

    Friend Sub AgregarDanioViejo(danioId As String, InspeccionId As String)
        If IDInsertar(danioId, InspeccionId) Then
            MsgBox("El danio se agrego correctamente.")
        Else
            MsgBox("Parece que la inspeccion ya tiene ese danio. Intente con otro danio.")
        End If
    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs)
        FormParent.GoToSection(1)
    End Sub

    Private Function DrawInspeccion(InspID As String, Numero As String, InspeccionFecha As String, Operario As String) As Control
        Dim PanelContenido As Panel = New Panel
        PanelContenido.Size = New Size(574, 148)
        PanelContenido.BackColor = Color.DimGray
        PanelContenido.Margin = New Padding(3, 3, 3, 10)

        Dim LabelInspeccon As Label = New Label
        Dim LabelFecha As Label = New Label
        Dim LabelOperario As Label = New Label

        LabelInspeccon.AutoSize = True
        LabelFecha.AutoSize = True
        LabelOperario.AutoSize = True

        LabelInspeccon.Text = _Lang.ObtenerKey("VerInspecciones", 3)+" #"+ Numero
        LabelFecha.Text = _Lang.ObtenerKey("VerInspecciones", 4)+": "+ InspeccionFecha
        LabelOperario.Text = _Lang.ObtenerKey("VerInspecciones", 5)+": "+ Operario

        LabelInspeccon.Location = New Point(3, 9)
        LabelFecha.Location = New Point(3, 38)
        LabelOperario.Location = New Point(3, 69)

        LabelInspeccon.ForeColor = Color.Orange
        LabelFecha.ForeColor = Color.Orange
        LabelOperario.ForeColor = Color.Orange

        Dim fuente = New Font("Arial", 10)

        LabelInspeccon.Font = fuente
        LabelFecha.Font = fuente
        LabelOperario.Font = fuente

        Dim BtnAgregarDanioAnterior As Button = New Button
        BtnAgregarDanioAnterior.Size = New Size(200, 33)
        BtnAgregarDanioAnterior.Font = fuente
        BtnAgregarDanioAnterior.ForeColor = Color.Orange
        BtnAgregarDanioAnterior.Text = "Agregar Danio Anterior"

        Dim BtnVerDanios As Button = New Button
        BtnVerDanios.Size = New Size(111, 33)
        BtnVerDanios.Font = fuente
        BtnVerDanios.ForeColor = Color.Orange
        BtnVerDanios.Text = _Lang.ObtenerKey("VerInspecciones", 8)

        Dim BtnAgDanios As Button = New Button
        BtnAgDanios.Size = New Size(150, 33)
        BtnAgDanios.Font = fuente
        BtnAgDanios.ForeColor = Color.Orange
        BtnAgDanios.Text = _Lang.ObtenerKey("VerInspecciones", 7)

        AddHandler BtnAgregarDanioAnterior.Click, Sub(s, ea) AgregarDanioAnterior(s, ea, InspID, PanelContenido)
        AddHandler BtnVerDanios.Click, Sub(s, ea) VerDanio(s, ea, InspID, PanelContenido)
        AddHandler BtnAgDanios.Click , Sub(s, ea) AgregarDanioI(s, ea, InspID)

        BtnAgregarDanioAnterior.Location = New Point(100, 113)
        BtnVerDanios.Location = New Point(450, 113)
        BtnAgDanios.Location = New Point(300, 113)

        PanelContenido.Controls.Add(LabelInspeccon)
        PanelContenido.Controls.Add(LabelFecha)
        PanelContenido.Controls.Add(LabelOperario)
        PanelContenido.Controls.Add(BtnAgregarDanioAnterior)
        PanelContenido.Controls.Add(BtnVerDanios)
        PanelContenido.Controls.Add(BtnAgDanios)

        Return PanelContenido
    End Function

    Private Sub VerDanio(s As Object, ea As EventArgs, InspID As String, PanelC As Panel)
        If DIObtenerCount(InspID) > 0 Then
            Dim Ventana As Ventana_Ver = New Ventana_Ver
            Dim danios As VerDanios = New VerDanios
            danios.CrearDanios(InspID)
            Ventana.LoadControl(danios)
            Ventana.ShowDialog()
        Else
            MsgBox(_Lang.ObtenerKey("VerInspecciones", 11))
        End If
    End Sub

    Private Sub AgregarDanioAnterior(s As Object, ea As EventArgs, InspID As String, PanelC As Panel)
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim SLCD As SeleccionarInspeccion = New SeleccionarInspeccion
        SLCD.UC_VerInspeccion = Me
        SLCD.InspeccionId = InspID
        Ventana.LoadControl(SLCD)
        Ventana.ShowDialog()
    End Sub
    Private Sub AgregarDanioI(s As Object, ea As EventArgs, InspID As String)
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim AgrDanio As AgregarDanio = New AgregarDanio
        AgrDanio.VIN = VIN
        AgrDanio.InspeccionID = InspID
        Ventana.LoadControl(AgrDanio)
        Ventana.ShowDialog
    End Sub

    Private Sub BtnAddInspeccion_Click(sender As Object, e As EventArgs) Handles btnAddInspeccion.Click
        If MessageBox.Show(_Lang.ObtenerKey("VerInspecciones", 10), "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                IInsertar(VIN, ObtenerOpId)
                FlowInspecciones.Controls.Clear
                Populate(VIN)
            Catch ex As Exception
                Serilog.Log.Error(ex, "Error al insertar inspeccion.")
            End Try
        End If
    End Sub

    Protected _Lang As LangManager  = New LangManager
    Protected Sub UpdateLang
        ParentForm.Text = _Lang.ObtenerKey("VerInspecciones", 0)
        GroupBox1.Text = _Lang.ObtenerKey("VerInspecciones", 2)
        btnAddInspeccion.Text = _Lang.ObtenerKey("VerInspecciones", 6)
    End Sub

    Private Sub VerInspeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateLang
    End Sub

    Private Sub btnNuevoDanio_Click(sender As Object, e As EventArgs)
        If IObtenerCount(VIN) > 0 Then
            Dim Inspecciones = IObtenerVIN(VIN)
            Dim VentanaVer As Ventana_Ver = New Ventana_Ver
            Dim AgregarD As AgregarDanio = New AgregarDanio
            AgregarD.UC_VerInspeccion = Me
            AgregarD.VIN = VIN
            AgregarD.InspeccionID = Inspecciones.Rows(Inspecciones.Rows.Count - 1).Item("inspeccionid").ToString
            VentanaVer.LoadControl(AgregarD)
            VentanaVer.ShowDialog()
        Else
            MsgBox("No existen danios, cree uno en la pestana inspecciones para continuar.")
        End If
    End Sub
End Class