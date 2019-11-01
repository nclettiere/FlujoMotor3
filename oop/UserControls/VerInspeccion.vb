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

        AddHandler BtnVerDanios.Click , Sub(s, ea) VerDanio(s, ea, InspID, PanelContenido)
        AddHandler BtnAgDanios.Click , Sub(s, ea) AgregarDanioI(s, ea, InspID)

        BtnVerDanios.Location = New Point(450, 113)
        BtnAgDanios.Location = New Point(300, 113)

        PanelContenido.Controls.Add(LabelInspeccon)
        PanelContenido.Controls.Add(LabelFecha)
        PanelContenido.Controls.Add(LabelOperario)
        PanelContenido.Controls.Add(BtnVerDanios)
        PanelContenido.Controls.Add(BtnAgDanios)

        Return PanelContenido
    End Function

    Friend Sub ActualizarDanios()
        Throw New NotImplementedException()
    End Sub

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

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then
            ActualizarListaDanios()
        End If
    End Sub

    Private Function DrawDanio(Numero As String, Imagen As Bitmap, Desc As String) As Control
        Dim PanelContenido As Panel = New Panel
        PanelContenido.Size = New Size(690, 225)
        PanelContenido.BackColor = Color.FromArgb(134, 134, 134)
        PanelContenido.Margin = New Padding(3, 3, 3, 10)

        Dim lblNumero As Label = New Label
        Dim lblDesc As Label = New Label
        Dim PBDanio As PictureBox = New PictureBox
        Dim rchDesc As RichTextBox = New RichTextBox
        Dim btnverimg As Button = New Button

        lblNumero.AutoSize = True
        lblDesc.AutoSize = True
        PBDanio.Size = New Size(271, 219)
        rchDesc.Size = New Size(407, 120)
        btnverimg.Size = New Size(166, 35)


        lblNumero.Text = "Danio #" + Numero
        lblDesc.Text = "Descripcion"
        PBDanio.BackgroundImage = Imagen
        PBDanio.BackgroundImageLayout = ImageLayout.Stretch
        rchDesc.Text = Desc
        btnverimg.Text = "Agrandar Imagen"

        lblNumero.Location = New Point(3, 12)
        lblDesc.Location = New Point(161, 12)
        PBDanio.Location = New Point(3, 3)
        rchDesc.Location = New Point(280, 3)
        btnverimg.Location = New Point(281, 130)

        lblNumero.ForeColor = Color.Orange

        Dim fuente = New Font("Arial", 10)

        lblNumero.Font = fuente
        lblDesc.Font = fuente
        btnverimg.Font = fuente
        btnverimg.ForeColor = Color.Orange
        btnverimg.FlatStyle = FlatStyle.Flat

        rchDesc.ReadOnly = True
        rchDesc.Enabled = False

        AddHandler btnverimg.Click, Sub(s, ea) VerImg(s, ea, Imagen)

        PanelContenido.Controls.Add(lblNumero)
        PanelContenido.Controls.Add(PBDanio)
        PanelContenido.Controls.Add(rchDesc)
        PanelContenido.Controls.Add(lblDesc)
        PanelContenido.Controls.Add(btnverimg)

        Return PanelContenido
    End Function


    Friend Sub ActualizarListaDanios()

        FlowLayoutPanel1.Controls.Clear()

        Dim ListaDanios As DataTable = DObtener(VIN)

        If ListaDanios IsNot Nothing Then
            If ListaDanios.Rows.Count > 0 Then
                Dim Numero As Integer = 1
                For Each Danio As DataRow In ListaDanios.Rows
                    Dim panel As Control = DrawDanio(
                                            Numero.ToString,
                                            DObtenerFoto(Danio.Item("danioid")),
                                            Danio.Item("danioDescripcion"))

                    FlowLayoutPanel1.Controls.Add(panel)
                    Numero += 1
                Next
            End If
        End If
    End Sub

    Private Sub btnNuevoDanio_Click(sender As Object, e As EventArgs) Handles btnNuevoDanio.Click
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

    Private Function VerImg(s As Object, ea As EventArgs, image As Bitmap)
        Dim VentanaVer As Ventana_Ver = New Ventana_Ver
        Dim VerF As VerFoto = New VerFoto
        VerF.PbFoto.BackgroundImage = image
        VentanaVer.LoadControl(VerF)
        VentanaVer.ShowDialog()
        Return True
    End Function
End Class