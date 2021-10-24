<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tusuario = New System.Windows.Forms.TextBox()
        Me.tcontrasenia = New System.Windows.Forms.TextBox()
        Me.bingresar = New System.Windows.Forms.Button()
        Me.bregistrarse = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Bsalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(152, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USUARIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CONTRASEÑA"
        '
        'tusuario
        '
        Me.tusuario.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.tusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tusuario.Location = New System.Drawing.Point(253, 78)
        Me.tusuario.Name = "tusuario"
        Me.tusuario.Size = New System.Drawing.Size(100, 20)
        Me.tusuario.TabIndex = 2
        '
        'tcontrasenia
        '
        Me.tcontrasenia.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.tcontrasenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcontrasenia.Location = New System.Drawing.Point(253, 104)
        Me.tcontrasenia.Name = "tcontrasenia"
        Me.tcontrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tcontrasenia.Size = New System.Drawing.Size(100, 20)
        Me.tcontrasenia.TabIndex = 3
        '
        'bingresar
        '
        Me.bingresar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bingresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bingresar.Location = New System.Drawing.Point(430, 81)
        Me.bingresar.Name = "bingresar"
        Me.bingresar.Size = New System.Drawing.Size(97, 23)
        Me.bingresar.TabIndex = 4
        Me.bingresar.Text = "Ingresar"
        Me.bingresar.UseVisualStyleBackColor = False
        '
        'bregistrarse
        '
        Me.bregistrarse.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bregistrarse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bregistrarse.Location = New System.Drawing.Point(430, 106)
        Me.bregistrarse.Name = "bregistrarse"
        Me.bregistrarse.Size = New System.Drawing.Size(97, 23)
        Me.bregistrarse.TabIndex = 5
        Me.bregistrarse.Text = "Registrarse"
        Me.bregistrarse.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(562, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 52)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Probar Conexion"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Bsalir
        '
        Me.Bsalir.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Bsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsalir.Location = New System.Drawing.Point(584, 154)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Size = New System.Drawing.Size(97, 23)
        Me.Bsalir.TabIndex = 8
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Sienna
        Me.BackgroundImage = Global._200714618_PROYECTO.My.Resources.Resources.bliblio1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Bsalir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bregistrarse)
        Me.Controls.Add(Me.bingresar)
        Me.Controls.Add(Me.tcontrasenia)
        Me.Controls.Add(Me.tusuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tusuario As TextBox
    Friend WithEvents tcontrasenia As TextBox
    Friend WithEvents bingresar As Button
    Friend WithEvents bregistrarse As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Bsalir As Button
End Class
