Public Class Persona
    Public nombre As String
    Public apellidopaterno As String
    Public apellidomaterno As String
    Public fechanacimiento As DateTime

    'Declaración de propiedades
    Public Property NombreP() As String
        Get  'obtiene los valores de los atributos
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property ApellidoPaternoP() As String
        Get  'obtiene los valores de los atributos
            Return apellidopaterno
        End Get
        Set(value As String)
            apellidopaterno = value
        End Set
    End Property

    Public Property ApellidoMaternoP() As String
        Get  'obtiene los valores de los atributos
            Return apellidomaterno
        End Get
        Set(value As String)
            apellidomaterno = value
        End Set
    End Property

    Public Property FechaNacimientoP() As DateTime
        Get  'obtiene los valores de los atributos
            Return fechanacimiento
        End Get
        Set(value As DateTime)
            fechanacimiento = value
        End Set
    End Property

    'Método constructor
    Public Sub Persona(ByVal nombrePersona As String, ByVal apPaternoPersona As String, ByVal apMaternoPersona As String, ByVal fechaNacimientoPersona As DateTime)
        nombre = nombrePersona
        apellidopaterno = apPaternoPersona
        apellidomaterno = apMaternoPersona
        fechanacimiento = fechaNacimientoPersona
    End Sub

    Public ReadOnly Property ObtenerRFC() As String
        Get
            'Dim digito1, digito3, digito4 As String
            'Dim digito2 As Char

            'digito1 = Mid(apellidopaterno, 1, 1)
            ''apellidopaterno.Substring(0, 1)
            ''digito2 = apellidopaterno.Chars(1)
            'digito3 = apellidomaterno.Substring(0, 1)
            'digito4 = nombre.Substring(0, 1)

            ''Si el digito es una Ñ, reemplaza por una X
            'If digito1 = "Ñ" Then
            '    digito1 = "X"
            'End If

            'If digito2 = "Ñ" Then
            '    digito2 = "X"
            'End If

            ''Dígito 2: Toma la primera vocal del primer apellido, si no pone una X
            'Dim paterno() As Char = apellidopaterno.ToCharArray()
            'Dim vocales() As Char = {"A"c, "E"c, "I"c, "O"c, "U"c}

            'Dim i, j As Integer
            'j = 1

            'For i = 0 To vocales.Length Step 1
            '    If vocales(i) = paterno(j) Then
            '        digito2 = paterno(j)
            '    End If
            '    j += 1
            '    While (j < paterno.Length And digito2 <> "A" And digito2 <> "E" And digito2 <> "i" And digito2 <> "u" And digito2 <> "U")
            '        If vocales(i) = paterno(j) Then
            '            digito2 = paterno(j)
            '        End If
            '        j += 1
            '    End While
            '    j = 0
            'Next i

            Dim rfc As String
            'rfc = nombre + apellidopaterno + ApellidoMaternoP + NombreP + FechaNacimientoP.ToString("yyMMdd")
            rfc = NombreP
            Return rfc
        End Get
    End Property
End Class
