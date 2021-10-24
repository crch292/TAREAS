<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultas
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
        Me.tnitconsulta = New System.Windows.Forms.TextBox()
        Me.dconsulta = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bbuscar = New System.Windows.Forms.Button()
        Me.bregresar = New System.Windows.Forms.Button()
        CType(Me.dconsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nit a buscar"
        '
        'tnitconsulta
        '
        Me.tnitconsulta.Location = New System.Drawing.Point(118, 42)
        Me.tnitconsulta.Name = "tnitconsulta"
        Me.tnitconsulta.Size = New System.Drawing.Size(100, 20)
        Me.tnitconsulta.TabIndex = 1
        '
        'dconsulta
        '
        Me.dconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dconsulta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Column8})
        Me.dconsulta.Location = New System.Drawing.Point(12, 79)
        Me.dconsulta.Name = "dconsulta"
        Me.dconsulta.Size = New System.Drawing.Size(735, 170)
        Me.dconsulta.TabIndex = 3
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
        Me.Column7.HeaderText = "parcial"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "total"
        Me.Column8.Name = "Column8"
        '
        'bbuscar
        '
        Me.bbuscar.Location = New System.Drawing.Point(242, 39)
        Me.bbuscar.Name = "bbuscar"
        Me.bbuscar.Size = New System.Drawing.Size(98, 23)
        Me.bbuscar.TabIndex = 4
        Me.bbuscar.Text = "Buscar"
        Me.bbuscar.UseVisualStyleBackColor = True
        '
        'bregresar
        '
        Me.bregresar.Location = New System.Drawing.Point(346, 39)
        Me.bregresar.Name = "bregresar"
        Me.bregresar.Size = New System.Drawing.Size(98, 23)
        Me.bregresar.TabIndex = 5
        Me.bregresar.Text = "Regresar"
        Me.bregresar.UseVisualStyleBackColor = True
        '
        'Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bregresar)
        Me.Controls.Add(Me.bbuscar)
        Me.Controls.Add(Me.dconsulta)
        Me.Controls.Add(Me.tnitconsulta)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Consultas"
        Me.Text = "Consultas"
        CType(Me.dconsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tnitconsulta As TextBox
    Friend WithEvents dconsulta As DataGridView
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents bbuscar As Button
    Friend WithEvents bregresar As Button
End Class
