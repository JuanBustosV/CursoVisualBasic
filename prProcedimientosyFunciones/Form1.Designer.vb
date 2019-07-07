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
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.btnRestar = New System.Windows.Forms.Button()
        Me.btnSumar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtNumero2 = New System.Windows.Forms.TextBox()
        Me.txtNumero1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEstructura = New System.Windows.Forms.Button()
        Me.btnPropiedades = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDividir)
        Me.GroupBox1.Controls.Add(Me.btnMultiplicar)
        Me.GroupBox1.Controls.Add(Me.btnRestar)
        Me.GroupBox1.Controls.Add(Me.btnSumar)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.txtNumero2)
        Me.GroupBox1.Controls.Add(Me.txtNumero1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 176)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese Datos"
        '
        'btnDividir
        '
        Me.btnDividir.Location = New System.Drawing.Point(287, 120)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(75, 23)
        Me.btnDividir.TabIndex = 8
        Me.btnDividir.Text = "Dividir"
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.Location = New System.Drawing.Point(287, 91)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(75, 23)
        Me.btnMultiplicar.TabIndex = 7
        Me.btnMultiplicar.Text = "Multiplicar"
        Me.btnMultiplicar.UseVisualStyleBackColor = True
        '
        'btnRestar
        '
        Me.btnRestar.Location = New System.Drawing.Point(287, 61)
        Me.btnRestar.Name = "btnRestar"
        Me.btnRestar.Size = New System.Drawing.Size(75, 23)
        Me.btnRestar.TabIndex = 6
        Me.btnRestar.Text = "Restar"
        Me.btnRestar.UseVisualStyleBackColor = True
        '
        'btnSumar
        '
        Me.btnSumar.Location = New System.Drawing.Point(287, 31)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(75, 23)
        Me.btnSumar.TabIndex = 5
        Me.btnSumar.Text = "Sumar"
        Me.btnSumar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(21, 120)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'txtNumero2
        '
        Me.txtNumero2.Location = New System.Drawing.Point(135, 72)
        Me.txtNumero2.Name = "txtNumero2"
        Me.txtNumero2.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero2.TabIndex = 3
        '
        'txtNumero1
        '
        Me.txtNumero1.Location = New System.Drawing.Point(135, 42)
        Me.txtNumero1.Name = "txtNumero1"
        Me.txtNumero1.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Número 2:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número 1:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEstructura)
        Me.GroupBox2.Controls.Add(Me.btnPropiedades)
        Me.GroupBox2.Controls.Add(Me.txtResultado)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 195)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 148)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'btnEstructura
        '
        Me.btnEstructura.Location = New System.Drawing.Point(287, 83)
        Me.btnEstructura.Name = "btnEstructura"
        Me.btnEstructura.Size = New System.Drawing.Size(75, 23)
        Me.btnEstructura.TabIndex = 3
        Me.btnEstructura.Text = "Estructura"
        Me.btnEstructura.UseVisualStyleBackColor = True
        '
        'btnPropiedades
        '
        Me.btnPropiedades.Location = New System.Drawing.Point(287, 40)
        Me.btnPropiedades.Name = "btnPropiedades"
        Me.btnPropiedades.Size = New System.Drawing.Size(75, 23)
        Me.btnPropiedades.TabIndex = 2
        Me.btnPropiedades.Text = "Propiedades"
        Me.btnPropiedades.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(135, 62)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Resultado:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(428, 352)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = ".:. Procedimientos Y Funciones .:."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDividir As Button
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents btnRestar As Button
    Friend WithEvents btnSumar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtNumero2 As TextBox
    Friend WithEvents txtNumero1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEstructura As Button
    Friend WithEvents btnPropiedades As Button
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label3 As Label
End Class
