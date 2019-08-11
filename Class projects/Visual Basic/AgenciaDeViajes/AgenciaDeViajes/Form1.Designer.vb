<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lbDestinos = New System.Windows.Forms.ListBox()
        Me.txtNinos = New System.Windows.Forms.TextBox()
        Me.txtAdultos = New System.Windows.Forms.TextBox()
        Me.txtDestinos = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(630, 410)
        Me.txtImporte.Multiline = True
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(100, 20)
        Me.txtImporte.TabIndex = 26
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(582, 413)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(42, 13)
        Me.label5.TabIndex = 25
        Me.label5.Text = "Importe"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(627, 225)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(99, 63)
        Me.btnSalir.TabIndex = 24
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(627, 156)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(99, 63)
        Me.btnLimpiar.TabIndex = 23
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(627, 87)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(99, 63)
        Me.btnCalcular.TabIndex = 22
        Me.btnCalcular.Text = "Calcular importe"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lbDestinos
        '
        Me.lbDestinos.FormattingEnabled = True
        Me.lbDestinos.Items.AddRange(New Object() {"Aguascalientes", "Guadalarajara", "Mexico"})
        Me.lbDestinos.Location = New System.Drawing.Point(342, 126)
        Me.lbDestinos.Name = "lbDestinos"
        Me.lbDestinos.Size = New System.Drawing.Size(188, 147)
        Me.lbDestinos.TabIndex = 21
        '
        'txtNinos
        '
        Me.txtNinos.Location = New System.Drawing.Point(70, 216)
        Me.txtNinos.Multiline = True
        Me.txtNinos.Name = "txtNinos"
        Me.txtNinos.Size = New System.Drawing.Size(131, 39)
        Me.txtNinos.TabIndex = 20
        '
        'txtAdultos
        '
        Me.txtAdultos.Location = New System.Drawing.Point(70, 171)
        Me.txtAdultos.Multiline = True
        Me.txtAdultos.Name = "txtAdultos"
        Me.txtAdultos.Size = New System.Drawing.Size(131, 39)
        Me.txtAdultos.TabIndex = 19
        '
        'txtDestinos
        '
        Me.txtDestinos.Location = New System.Drawing.Point(70, 126)
        Me.txtDestinos.Multiline = True
        Me.txtDestinos.Name = "txtDestinos"
        Me.txtDestinos.Size = New System.Drawing.Size(131, 39)
        Me.txtDestinos.TabIndex = 18
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(383, 20)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(132, 20)
        Me.label4.TabIndex = 17
        Me.label4.Text = "Agencia de viajes"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(216, 225)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(34, 13)
        Me.label3.TabIndex = 16
        Me.label3.Text = "Ninos"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(216, 181)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(42, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Adultos"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(216, 139)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(48, 13)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Destinos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lbDestinos)
        Me.Controls.Add(Me.txtNinos)
        Me.Controls.Add(Me.txtAdultos)
        Me.Controls.Add(Me.txtDestinos)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtImporte As TextBox
    Private WithEvents label5 As Label
    Private WithEvents btnSalir As Button
    Private WithEvents btnLimpiar As Button
    Private WithEvents btnCalcular As Button
    Private WithEvents lbDestinos As ListBox
    Private WithEvents txtNinos As TextBox
    Private WithEvents txtAdultos As TextBox
    Private WithEvents txtDestinos As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
