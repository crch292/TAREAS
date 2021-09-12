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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tcantidad = New System.Windows.Forms.TextBox()
        Me.vender = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbfuncion = New System.Windows.Forms.ComboBox()
        Me.cbcine = New System.Windows.Forms.ComboBox()
        Me.ListaPrecios = New System.Windows.Forms.ListBox()
        Me.listadescuentos1 = New System.Windows.Forms.ListBox()
        Me.listadescuentos2 = New System.Windows.Forms.ListBox()
        Me.listatotales = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.blimpiar = New System.Windows.Forms.Button()
        Me.bsalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tcantidad)
        Me.GroupBox1.Controls.Add(Me.vender)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbfuncion)
        Me.GroupBox1.Controls.Add(Me.cbcine)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 162)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TAQUILLA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cantidad boletos"
        '
        'tcantidad
        '
        Me.tcantidad.Location = New System.Drawing.Point(153, 19)
        Me.tcantidad.Name = "tcantidad"
        Me.tcantidad.Size = New System.Drawing.Size(107, 20)
        Me.tcantidad.TabIndex = 5
        '
        'vender
        '
        Me.vender.Location = New System.Drawing.Point(208, 115)
        Me.vender.Name = "vender"
        Me.vender.Size = New System.Drawing.Size(105, 27)
        Me.vender.TabIndex = 4
        Me.vender.Text = "Vender"
        Me.vender.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Funcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cine"
        '
        'cbfuncion
        '
        Me.cbfuncion.FormattingEnabled = True
        Me.cbfuncion.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cbfuncion.Location = New System.Drawing.Point(153, 71)
        Me.cbfuncion.Name = "cbfuncion"
        Me.cbfuncion.Size = New System.Drawing.Size(107, 21)
        Me.cbfuncion.TabIndex = 1
        '
        'cbcine
        '
        Me.cbcine.FormattingEnabled = True
        Me.cbcine.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cbcine.Location = New System.Drawing.Point(153, 44)
        Me.cbcine.Name = "cbcine"
        Me.cbcine.Size = New System.Drawing.Size(107, 21)
        Me.cbcine.TabIndex = 0
        '
        'ListaPrecios
        '
        Me.ListaPrecios.Enabled = False
        Me.ListaPrecios.FormattingEnabled = True
        Me.ListaPrecios.Location = New System.Drawing.Point(45, 231)
        Me.ListaPrecios.Name = "ListaPrecios"
        Me.ListaPrecios.Size = New System.Drawing.Size(62, 95)
        Me.ListaPrecios.TabIndex = 1
        '
        'listadescuentos1
        '
        Me.listadescuentos1.Enabled = False
        Me.listadescuentos1.FormattingEnabled = True
        Me.listadescuentos1.Location = New System.Drawing.Point(113, 231)
        Me.listadescuentos1.Name = "listadescuentos1"
        Me.listadescuentos1.Size = New System.Drawing.Size(62, 95)
        Me.listadescuentos1.TabIndex = 4
        '
        'listadescuentos2
        '
        Me.listadescuentos2.Enabled = False
        Me.listadescuentos2.FormattingEnabled = True
        Me.listadescuentos2.Location = New System.Drawing.Point(181, 231)
        Me.listadescuentos2.Name = "listadescuentos2"
        Me.listadescuentos2.Size = New System.Drawing.Size(62, 95)
        Me.listadescuentos2.TabIndex = 5
        '
        'listatotales
        '
        Me.listatotales.Enabled = False
        Me.listatotales.FormattingEnabled = True
        Me.listatotales.Location = New System.Drawing.Point(249, 231)
        Me.listatotales.Name = "listatotales"
        Me.listatotales.Size = New System.Drawing.Size(62, 95)
        Me.listatotales.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Subtotal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(110, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Descuento 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(178, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Descuento 2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(246, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Total"
        '
        'blimpiar
        '
        Me.blimpiar.Location = New System.Drawing.Point(396, 52)
        Me.blimpiar.Name = "blimpiar"
        Me.blimpiar.Size = New System.Drawing.Size(123, 23)
        Me.blimpiar.TabIndex = 11
        Me.blimpiar.Text = "Limpiar Listas"
        Me.blimpiar.UseVisualStyleBackColor = True
        '
        'bsalir
        '
        Me.bsalir.Location = New System.Drawing.Point(396, 88)
        Me.bsalir.Name = "bsalir"
        Me.bsalir.Size = New System.Drawing.Size(123, 23)
        Me.bsalir.TabIndex = 12
        Me.bsalir.Text = "Salir"
        Me.bsalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bsalir)
        Me.Controls.Add(Me.blimpiar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.listatotales)
        Me.Controls.Add(Me.listadescuentos2)
        Me.Controls.Add(Me.listadescuentos1)
        Me.Controls.Add(Me.ListaPrecios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents vender As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbfuncion As ComboBox
    Friend WithEvents cbcine As ComboBox
    Friend WithEvents ListaPrecios As ListBox
    Friend WithEvents listadescuentos1 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tcantidad As TextBox
    Friend WithEvents listadescuentos2 As ListBox
    Friend WithEvents listatotales As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents blimpiar As Button
    Friend WithEvents bsalir As Button
End Class
