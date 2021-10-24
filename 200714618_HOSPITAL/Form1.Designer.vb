<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatrizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Datos = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.combopago = New System.Windows.Forms.ComboBox()
        Me.combohabitacion = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.thonorarios = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Nit = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.tdias = New System.Windows.Forms.TextBox()
        Me.tnit = New System.Windows.Forms.TextBox()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.dvista = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.Datos.SuspendLayout()
        CType(Me.dvista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarToolStripMenuItem, Me.CerrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MostrarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.EstadisticasToolStripMenuItem})
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.CalcularToolStripMenuItem.Text = "INICIO"
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'EstadisticasToolStripMenuItem
        '
        Me.EstadisticasToolStripMenuItem.Name = "EstadisticasToolStripMenuItem"
        Me.EstadisticasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EstadisticasToolStripMenuItem.Text = "Estadisticas"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MatrizToolStripMenuItem, Me.EstadisticasToolStripMenuItem1})
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.LimpiarToolStripMenuItem.Text = "LIMPIAR"
        '
        'MatrizToolStripMenuItem
        '
        Me.MatrizToolStripMenuItem.Name = "MatrizToolStripMenuItem"
        Me.MatrizToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.MatrizToolStripMenuItem.Text = "Matriz"
        '
        'EstadisticasToolStripMenuItem1
        '
        Me.EstadisticasToolStripMenuItem1.Name = "EstadisticasToolStripMenuItem1"
        Me.EstadisticasToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.EstadisticasToolStripMenuItem1.Text = "Estadisticas"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CerrarToolStripMenuItem.Text = "CERRAR"
        '
        'Datos
        '
        Me.Datos.Controls.Add(Me.Button2)
        Me.Datos.Controls.Add(Me.Button1)
        Me.Datos.Controls.Add(Me.combopago)
        Me.Datos.Controls.Add(Me.combohabitacion)
        Me.Datos.Controls.Add(Me.Label5)
        Me.Datos.Controls.Add(Me.Label2)
        Me.Datos.Controls.Add(Me.thonorarios)
        Me.Datos.Controls.Add(Me.Label4)
        Me.Datos.Controls.Add(Me.Label3)
        Me.Datos.Controls.Add(Me.Nit)
        Me.Datos.Controls.Add(Me.Nombre)
        Me.Datos.Controls.Add(Me.tdias)
        Me.Datos.Controls.Add(Me.tnit)
        Me.Datos.Controls.Add(Me.tnombre)
        Me.Datos.Location = New System.Drawing.Point(26, 39)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(532, 137)
        Me.Datos.TabIndex = 1
        Me.Datos.TabStop = False
        Me.Datos.Text = "Datos Paciente"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(382, 94)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(277, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'combopago
        '
        Me.combopago.FormattingEnabled = True
        Me.combopago.Items.AddRange(New Object() {"efectivo", "transferencia ACH", "deposito bancario", "tarjeta credito", "seguro medico"})
        Me.combopago.Location = New System.Drawing.Point(360, 44)
        Me.combopago.Name = "combopago"
        Me.combopago.Size = New System.Drawing.Size(121, 21)
        Me.combopago.TabIndex = 12
        '
        'combohabitacion
        '
        Me.combohabitacion.FormattingEnabled = True
        Me.combohabitacion.Items.AddRange(New Object() {"privada", "semiprivada", "no privada"})
        Me.combohabitacion.Location = New System.Drawing.Point(360, 18)
        Me.combohabitacion.Name = "combohabitacion"
        Me.combohabitacion.Size = New System.Drawing.Size(121, 21)
        Me.combohabitacion.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Forma pago"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tipo habitacion"
        '
        'thonorarios
        '
        Me.thonorarios.Location = New System.Drawing.Point(136, 100)
        Me.thonorarios.Name = "thonorarios"
        Me.thonorarios.Size = New System.Drawing.Size(118, 20)
        Me.thonorarios.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Honorarios"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "# dias hospitalizado"
        '
        'Nit
        '
        Me.Nit.AutoSize = True
        Me.Nit.Location = New System.Drawing.Point(36, 52)
        Me.Nit.Name = "Nit"
        Me.Nit.Size = New System.Drawing.Size(20, 13)
        Me.Nit.TabIndex = 4
        Me.Nit.Text = "Nit"
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(36, 26)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(44, 13)
        Me.Nombre.TabIndex = 3
        Me.Nombre.Text = "Nombre"
        '
        'tdias
        '
        Me.tdias.Location = New System.Drawing.Point(136, 71)
        Me.tdias.Name = "tdias"
        Me.tdias.Size = New System.Drawing.Size(118, 20)
        Me.tdias.TabIndex = 2
        '
        'tnit
        '
        Me.tnit.Location = New System.Drawing.Point(136, 45)
        Me.tnit.Name = "tnit"
        Me.tnit.Size = New System.Drawing.Size(118, 20)
        Me.tnit.TabIndex = 1
        '
        'tnombre
        '
        Me.tnombre.Location = New System.Drawing.Point(136, 19)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(118, 20)
        Me.tnombre.TabIndex = 0
        '
        'dvista
        '
        Me.dvista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Column8})
        Me.dvista.Location = New System.Drawing.Point(29, 198)
        Me.dvista.Name = "dvista"
        Me.dvista.Size = New System.Drawing.Size(735, 170)
        Me.dvista.TabIndex = 2
        Me.dvista.Visible = False
        '
        'Column6
        '
        Me.Column6.HeaderText = "paciente"
        Me.Column6.Name = "Column6"
        '
        'Column1
        '
        Me.Column1.HeaderText = "nit"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "dias"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "honorarios"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "habitacion"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "pago"
        Me.Column5.Name = "Column5"
        '
        'Column7
        '
        Me.Column7.HeaderText = "parcial Q"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "total Q"
        Me.Column8.Name = "Column8"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dvista)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Datos.ResumeLayout(False)
        Me.Datos.PerformLayout()
        CType(Me.dvista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadisticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MatrizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadisticasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Datos As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents thonorarios As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Nit As Label
    Friend WithEvents Nombre As Label
    Friend WithEvents tdias As TextBox
    Friend WithEvents tnit As TextBox
    Friend WithEvents tnombre As TextBox
    Friend WithEvents combopago As ComboBox
    Friend WithEvents combohabitacion As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dvista As DataGridView
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
