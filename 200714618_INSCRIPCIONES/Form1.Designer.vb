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
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.tcarnet = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cnivel = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ccarrera = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rtarjeta = New System.Windows.Forms.RadioButton()
        Me.refectivo = New System.Windows.Forms.RadioButton()
        Me.rtransferencia = New System.Windows.Forms.RadioButton()
        Me.rdeposito = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.t = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tnombre
        '
        Me.tnombre.Location = New System.Drawing.Point(125, 38)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(100, 20)
        Me.tnombre.TabIndex = 0
        '
        'tcarnet
        '
        Me.tcarnet.Location = New System.Drawing.Point(125, 64)
        Me.tcarnet.Name = "tcarnet"
        Me.tcarnet.Size = New System.Drawing.Size(100, 20)
        Me.tcarnet.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Carnet"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nivel"
        '
        'cnivel
        '
        Me.cnivel.FormattingEnabled = True
        Me.cnivel.Items.AddRange(New Object() {"Basico", "Diversificado"})
        Me.cnivel.Location = New System.Drawing.Point(125, 98)
        Me.cnivel.Name = "cnivel"
        Me.cnivel.Size = New System.Drawing.Size(100, 21)
        Me.cnivel.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(247, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Carrera"
        Me.Label4.Visible = False
        '
        'ccarrera
        '
        Me.ccarrera.FormattingEnabled = True
        Me.ccarrera.Items.AddRange(New Object() {"perito contador", "bachillerato", "electronica", "diseño grafico"})
        Me.ccarrera.Location = New System.Drawing.Point(294, 101)
        Me.ccarrera.Name = "ccarrera"
        Me.ccarrera.Size = New System.Drawing.Size(100, 21)
        Me.ccarrera.TabIndex = 7
        Me.ccarrera.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdeposito)
        Me.GroupBox1.Controls.Add(Me.rtransferencia)
        Me.GroupBox1.Controls.Add(Me.refectivo)
        Me.GroupBox1.Controls.Add(Me.rtarjeta)
        Me.GroupBox1.Location = New System.Drawing.Point(415, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(199, 125)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Forma Pago"
        '
        'rtarjeta
        '
        Me.rtarjeta.AutoSize = True
        Me.rtarjeta.Location = New System.Drawing.Point(36, 43)
        Me.rtarjeta.Name = "rtarjeta"
        Me.rtarjeta.Size = New System.Drawing.Size(93, 17)
        Me.rtarjeta.TabIndex = 0
        Me.rtarjeta.TabStop = True
        Me.rtarjeta.Text = "Tarjeta credito"
        Me.rtarjeta.UseVisualStyleBackColor = True
        '
        'refectivo
        '
        Me.refectivo.AutoSize = True
        Me.refectivo.Location = New System.Drawing.Point(36, 20)
        Me.refectivo.Name = "refectivo"
        Me.refectivo.Size = New System.Drawing.Size(64, 17)
        Me.refectivo.TabIndex = 1
        Me.refectivo.TabStop = True
        Me.refectivo.Text = "Efectivo"
        Me.refectivo.UseVisualStyleBackColor = True
        '
        'rtransferencia
        '
        Me.rtransferencia.AutoSize = True
        Me.rtransferencia.Location = New System.Drawing.Point(36, 65)
        Me.rtransferencia.Name = "rtransferencia"
        Me.rtransferencia.Size = New System.Drawing.Size(86, 17)
        Me.rtransferencia.TabIndex = 2
        Me.rtransferencia.TabStop = True
        Me.rtransferencia.Text = "transferencia"
        Me.rtransferencia.UseVisualStyleBackColor = True
        '
        'rdeposito
        '
        Me.rdeposito.AutoSize = True
        Me.rdeposito.Location = New System.Drawing.Point(36, 88)
        Me.rdeposito.Name = "rdeposito"
        Me.rdeposito.Size = New System.Drawing.Size(65, 17)
        Me.rdeposito.TabIndex = 3
        Me.rdeposito.TabStop = True
        Me.rdeposito.Text = "deposito"
        Me.rdeposito.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        't
        '
        Me.t.Location = New System.Drawing.Point(168, 180)
        Me.t.Name = "t"
        Me.t.Size = New System.Drawing.Size(100, 20)
        Me.t.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(363, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.t)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ccarrera)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cnivel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tcarnet)
        Me.Controls.Add(Me.tnombre)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tnombre As TextBox
    Friend WithEvents tcarnet As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cnivel As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ccarrera As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdeposito As RadioButton
    Friend WithEvents rtransferencia As RadioButton
    Friend WithEvents refectivo As RadioButton
    Friend WithEvents rtarjeta As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents t As TextBox
    Friend WithEvents Button1 As Button
End Class
