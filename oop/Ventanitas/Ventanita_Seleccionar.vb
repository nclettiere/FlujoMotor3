Imports DB

Public Class Ventanita_Seleccionar
    Public Property ParentLoad As AgregarVehiculo

    Public Property SelectedLote As String
        Get
            Return _SelectedLote
        End Get
        Set(value As String)
            _SelectedLote = value
        End Set
    End Property

    Private _SelectedLote As String

    ''' <summary>
    ''' Metodo usado para cambiar dinamicamente el contenido del MainContent
    ''' </summary>
    ''' <param name="Section">Integer que especifica el ID de la seccion.</param>
    Friend Sub GoToSection(ByVal Section As Integer)
        Dim Selection As Object

        Select Case Section
            Case 0
                Selection = AgregarLote.Instance
            Case 1
                Selection = SeleccionarVehiculo.Instance
                Selection.FormParent = Me
            Case 2
                Selection = SeleccionarLotes.Instance
                Selection.FormParent = Me
                
            Case Else
                Selection = AgregarLote.Instance
        End Select

        If Not mainContent.Contains(Selection) Then
            MainContent.Controls.Add(Selection.Instance)
            Selection.Instance.Dock = DockStyle.Fill
            Selection.Instance.BringToFront()
        Else
            Selection.Instance.BringToFront()
        End If
    End Sub

    Public Shared Sub UpdateLotes()
       
    End Sub

    Friend Sub GoToSection(ByVal Section As Integer, Parent As Object)
        Dim Selection As Object
        Select Case Section
            Case 0
                Selection = AgregarLote.Instance
            Case 1
                Selection = SeleccionarVehiculo.Instance
                Selection.FormParent = DirectCast(Parent, AgregarLote)
            Case 2
                Selection = SeleccionarLotes.Instance
            Case Else
                Selection = AgregarLote.Instance
        End Select

        If Not mainContent.Contains(Selection) Then
            MainContent.Controls.Add(Selection.Instance)
            Selection.Instance.Dock = DockStyle.Fill
            Selection.Instance.BringToFront()
        Else
            Selection.Instance.BringToFront()
        End If
    End Sub

    Friend Sub GoToSection(ByVal Section As Integer, Parent As Object, conexion As ODBC)
        Dim Selection As Object
        Select Case Section
            Case 0
                Selection = AgregarLote.Instance
                Me.ClientSize = Selection.Size
                AgregarLote.Instance.CargarDatos(Me, Parent, conexion)
            Case 1
                Selection = SeleccionarVehiculo.Instance
                Me.ClientSize = Selection.Size
                Selection.FormParent = DirectCast(Parent, AgregarLote)
            Case 2
                Selection = SeleccionarLotes.Instance
                Me.ClientSize = Selection.Size
                SeleccionarLotes.Instance.CargarDatos(Me, Parent, conexion)
            Case Else
                Selection = AgregarLote.Instance
        End Select

        If Not mainContent.Contains(Selection) Then
            MainContent.Controls.Add(Selection.Instance)
            Selection.Instance.Dock = DockStyle.Fill
            Selection.Instance.BringToFront()
        Else
            Selection.Instance.BringToFront()
        End If
    End Sub

    Private Sub Ventanita_Seleccionar_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class