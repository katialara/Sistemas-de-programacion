Public Class Contacto
    Inherits Persona
    Public telefono As Long
    Public correo As String

    Public Property TelefonoP() As Long
        Get
            Return telefono
        End Get
        Set(value As Long)
            telefono = value
        End Set
    End Property

    Public Property CorreoP() As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set
    End Property

    'Método constructor
    Public Sub Contacto(ByVal nombrePersona As String, ByVal apPaternoPersona As String, ByVal apMaternoPersona As String, ByVal fechaNacimientoPersona As DateTime, ByVal telefonoPersona As Long, ByVal correoPersona As String)
        NombreP = nombrePersona
        ApellidoPaternoP = apPaternoPersona
        ApellidoMaternoP = apMaternoPersona
        FechaNacimientoP = fechaNacimientoPersona
        TelefonoP = telefonoPersona
        CorreoP = correoPersona
    End Sub
End Class
