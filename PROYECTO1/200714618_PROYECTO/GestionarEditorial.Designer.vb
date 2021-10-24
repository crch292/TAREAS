<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarEditorial
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tnombreeditorial = New System.Windows.Forms.TextBox()
        Me.tdireccioneditorial = New System.Windows.Forms.TextBox()
        Me.datagestionareditorial = New System.Windows.Forms.DataGridView()
        Me.Clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgregarEditorial = New System.Windows.Forms.Button()
        Me.ModificarEditorial = New System.Windows.Forms.Button()
        Me.Eliminareditorial = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ttelefonoeditorial = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.datagestionareditorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Direccion"
        '
        'tnombreeditorial
        '
        Me.tnombreeditorial.Location = New System.Drawing.Point(109, 17)
        Me.tnombreeditorial.Name = "tnombreeditorial"
        Me.tnombreeditorial.Size = New System.Drawing.Size(191, 20)
        Me.tnombreeditorial.TabIndex = 2
        '
        'tdireccioneditorial
        '
        Me.tdireccioneditorial.Location = New System.Drawing.Point(109, 43)
        Me.tdireccioneditorial.Name = "tdireccioneditorial"
        Me.tdireccioneditorial.Size = New System.Drawing.Size(191, 20)
        Me.tdireccioneditorial.TabIndex = 3
        '
        'datagestionareditorial
        '
        Me.datagestionareditorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagestionareditorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Clave, Me.Nombre, Me.Telefono, Me.Direccion})
        Me.datagestionareditorial.Location = New System.Drawing.Point(40, 180)
        Me.datagestionareditorial.Name = "datagestionareditorial"
        Me.datagestionareditorial.ReadOnly = True
        Me.datagestionareditorial.Size = New System.Drawing.Size(476, 129)
        Me.datagestionareditorial.TabIndex = 4
        '
        'Clave
        '
        Me.Clave.HeaderText = "Clave"
        Me.Clave.Name = "Clave"
        Me.Clave.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        '
        'AgregarEditorial
        '
        Me.AgregarEditorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarEditorial.Location = New System.Drawing.Point(539, 75)
        Me.AgregarEditorial.Name = "AgregarEditorial"
        Me.AgregarEditorial.Size = New System.Drawing.Size(112, 23)
        Me.AgregarEditorial.TabIndex = 5
        Me.AgregarEditorial.Text = "Agregar"
        Me.AgregarEditorial.UseVisualStyleBackColor = True
        '
        'ModificarEditorial
        '
        Me.ModificarEditorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificarEditorial.Location = New System.Drawing.Point(539, 101)
        Me.ModificarEditorial.Name = "ModificarEditorial"
        Me.ModificarEditorial.Size = New System.Drawing.Size(112, 23)
        Me.ModificarEditorial.TabIndex = 6
        Me.ModificarEditorial.Text = "Modificar"
        Me.ModificarEditorial.UseVisualStyleBackColor = True
        '
        'Eliminareditorial
        '
        Me.Eliminareditorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminareditorial.Location = New System.Drawing.Point(539, 127)
        Me.Eliminareditorial.Name = "Eliminareditorial"
        Me.Eliminareditorial.Size = New System.Drawing.Size(112, 23)
        Me.Eliminareditorial.TabIndex = 7
        Me.Eliminareditorial.Text = "Eliminar"
        Me.Eliminareditorial.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(539, 286)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Regresar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ttelefonoeditorial
        '
        Me.ttelefonoeditorial.Location = New System.Drawing.Point(109, 72)
        Me.ttelefonoeditorial.Name = "ttelefonoeditorial"
        Me.ttelefonoeditorial.Size = New System.Drawing.Size(191, 20)
        Me.ttelefonoeditorial.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Telefono"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ttelefonoeditorial)
        Me.GroupBox1.Controls.Add(Me.tnombreeditorial)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tdireccioneditorial)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(95, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 123)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Nuevo"
        '
        'GestionarEditorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._200714618_PROYECTO.My.Resources.Resources.bliblio1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Eliminareditorial)
        Me.Controls.Add(Me.ModificarEditorial)
        Me.Controls.Add(Me.AgregarEditorial)
        Me.Controls.Add(Me.datagestionareditorial)
        Me.Name = "GestionarEditorial"
        Me.Text = "GestionarEditorial"
        CType(Me.datagestionareditorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tnombreeditorial As TextBox
    Friend WithEvents tdireccioneditorial As TextBox
    Friend WithEvents datagestionareditorial As DataGridView
    Friend WithEvents AgregarEditorial As Button
    Friend WithEvents ModificarEditorial As Button
    Friend WithEvents Eliminareditorial As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ttelefonoeditorial As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Clave As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
End Class
