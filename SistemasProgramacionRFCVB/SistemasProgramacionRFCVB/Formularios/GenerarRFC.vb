Public Class GenerarRFC
    Private Sub btnGenerarRFC_Click(sender As Object, e As EventArgs) Handles btnGenerarRFC.Click
        'Validar que no se deje el nombre en blanco
        If txtNombre.Text = "" Then
            Error1.SetError(txtNombre, "No se puede dejar el espacio en blanco")
            txtNombre.Focus()
            Return
        End If
        Error1.SetError(txtNombre, "")

        'Validar que no se deje el apellido paterno en blanco
        If (txtPaterno.Text = "") Then
            Error1.SetError(txtPaterno, "No puede dejar el espacio en blanco")
            txtPaterno.Focus()
            Return
        End If
        Error1.SetError(txtPaterno, "")

        'Validar que no se deje el apellido materno en blanco
        If (txtMaterno.Text = "") Then
            Error1.SetError(txtMaterno, "No puede dejar el espacio en blanco")
            txtMaterno.Focus()
            Return
        End If
        Error1.SetError(txtMaterno, "")

        'Validar que sea numero y de 10 digitos
        If IsNumeric(txtTelefono.Text) Then
            If txtTelefono.TextLength < 10 Then
                Error1.SetError(txtTelefono, "El número telefónico debe contener 10 dígitos")
            End If
        Else
            Error1.SetError(txtMaterno, "Debe ingresar solo dígitos")
            txtMaterno.Focus()
            Return
        End If
        Error1.SetError(txtMaterno, "")

        Dim nombre As String = Me.txtNombre.Text
        Dim paterno As String = Me.txtPaterno.Text
        Dim materno As String = Me.txtMaterno.Text
        Dim fechanacimiento As DateTime = DateTime.Parse(Me.dateTimePickerFNacimiento.Text)
        Dim telefono As Long = Long.Parse(Me.txtTelefono.Text)
        Dim correo As String = Me.txtCorreo.Text

        Dim PersonaP As Persona
        PersonaP = New Persona()
        txtRFC.Text = PersonaP.ObtenerRFC()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombre.Clear()
        txtPaterno.Clear()
        txtMaterno.Clear()
        dateTimePickerFNacimiento.ResetText()
        txtTelefono.Clear()
        txtCorreo.Clear()
        txtRFC.Clear()
    End Sub
End Class