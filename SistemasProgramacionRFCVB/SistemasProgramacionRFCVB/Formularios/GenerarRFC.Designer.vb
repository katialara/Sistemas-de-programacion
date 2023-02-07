<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarRFC
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.btnGenerarRFC = New System.Windows.Forms.Button()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.dateTimePickerFNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtMaterno = New System.Windows.Forms.TextBox()
        Me.txtPaterno = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.Error1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.groupBox1.SuspendLayout()
        CType(Me.Error1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.txtRFC)
        Me.groupBox1.Controls.Add(Me.btnNuevo)
        Me.groupBox1.Controls.Add(Me.txtCorreo)
        Me.groupBox1.Controls.Add(Me.btnGenerarRFC)
        Me.groupBox1.Controls.Add(Me.txtTelefono)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.dateTimePickerFNacimiento)
        Me.groupBox1.Controls.Add(Me.txtMaterno)
        Me.groupBox1.Controls.Add(Me.txtPaterno)
        Me.groupBox1.Controls.Add(Me.txtNombre)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(27, 53)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(390, 336)
        Me.groupBox1.TabIndex = 19
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Ingresa tus datos"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(82, 257)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(27, 14)
        Me.label7.TabIndex = 28
        Me.label7.Text = "RFC"
        '
        'txtRFC
        '
        Me.txtRFC.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtRFC.Enabled = False
        Me.txtRFC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRFC.Location = New System.Drawing.Point(115, 254)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.ReadOnly = True
        Me.txtRFC.Size = New System.Drawing.Size(234, 20)
        Me.txtRFC.TabIndex = 27
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnNuevo.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(137, 294)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(99, 23)
        Me.btnNuevo.TabIndex = 15
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(115, 217)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(234, 20)
        Me.txtCorreo.TabIndex = 26
        '
        'btnGenerarRFC
        '
        Me.btnGenerarRFC.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnGenerarRFC.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarRFC.Location = New System.Drawing.Point(250, 294)
        Me.btnGenerarRFC.Name = "btnGenerarRFC"
        Me.btnGenerarRFC.Size = New System.Drawing.Size(99, 23)
        Me.btnGenerarRFC.TabIndex = 12
        Me.btnGenerarRFC.Text = "Obtener RFC"
        Me.btnGenerarRFC.UseVisualStyleBackColor = False
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(115, 180)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(234, 20)
        Me.txtTelefono.TabIndex = 25
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(69, 220)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(40, 14)
        Me.label6.TabIndex = 24
        Me.label6.Text = "Correo"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(61, 183)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(48, 14)
        Me.label5.TabIndex = 23
        Me.label5.Text = "Teléfono"
        '
        'dateTimePickerFNacimiento
        '
        Me.dateTimePickerFNacimiento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimePickerFNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateTimePickerFNacimiento.Location = New System.Drawing.Point(115, 143)
        Me.dateTimePickerFNacimiento.Name = "dateTimePickerFNacimiento"
        Me.dateTimePickerFNacimiento.Size = New System.Drawing.Size(234, 20)
        Me.dateTimePickerFNacimiento.TabIndex = 22
        '
        'txtMaterno
        '
        Me.txtMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMaterno.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterno.Location = New System.Drawing.Point(115, 107)
        Me.txtMaterno.Name = "txtMaterno"
        Me.txtMaterno.Size = New System.Drawing.Size(234, 20)
        Me.txtMaterno.TabIndex = 21
        '
        'txtPaterno
        '
        Me.txtPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaterno.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaterno.Location = New System.Drawing.Point(115, 71)
        Me.txtPaterno.Name = "txtPaterno"
        Me.txtPaterno.Size = New System.Drawing.Size(234, 20)
        Me.txtPaterno.TabIndex = 20
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(115, 35)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(234, 20)
        Me.txtNombre.TabIndex = 19
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(18, 146)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(91, 14)
        Me.label4.TabIndex = 18
        Me.label4.Text = "Fecha nacimiento"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(22, 110)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(87, 14)
        Me.label3.TabIndex = 17
        Me.label3.Text = "Apellido materno"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(24, 74)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(85, 14)
        Me.label2.TabIndex = 16
        Me.label2.Text = "Apellido paterno"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(65, 38)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(44, 14)
        Me.label1.TabIndex = 15
        Me.label1.Text = "Nombre"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(109, 19)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(245, 13)
        Me.label8.TabIndex = 18
        Me.label8.Text = "Registro Federal de Contribuyentes"
        '
        'Error1
        '
        Me.Error1.ContainerControl = Me
        '
        'GenerarRFC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 416)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.label8)
        Me.Name = "GenerarRFC"
        Me.Text = "GenerarRFC"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.Error1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents label7 As Label
    Private WithEvents txtRFC As TextBox
    Private WithEvents btnNuevo As Button
    Private WithEvents txtCorreo As TextBox
    Private WithEvents btnGenerarRFC As Button
    Private WithEvents txtTelefono As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Protected WithEvents dateTimePickerFNacimiento As DateTimePicker
    Private WithEvents txtMaterno As TextBox
    Private WithEvents txtPaterno As TextBox
    Protected WithEvents txtNombre As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents label8 As Label
    Friend WithEvents Error1 As ErrorProvider
End Class
