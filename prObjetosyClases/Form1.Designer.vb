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
        Me.btnPerro1 = New System.Windows.Forms.Button()
        Me.btnPerro2 = New System.Windows.Forms.Button()
        Me.btnPerro3 = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnPerro1
        '
        Me.btnPerro1.Location = New System.Drawing.Point(120, 56)
        Me.btnPerro1.Name = "btnPerro1"
        Me.btnPerro1.Size = New System.Drawing.Size(120, 60)
        Me.btnPerro1.TabIndex = 0
        Me.btnPerro1.Text = "Perro 1"
        Me.btnPerro1.UseVisualStyleBackColor = True
        '
        'btnPerro2
        '
        Me.btnPerro2.Location = New System.Drawing.Point(120, 138)
        Me.btnPerro2.Name = "btnPerro2"
        Me.btnPerro2.Size = New System.Drawing.Size(120, 60)
        Me.btnPerro2.TabIndex = 1
        Me.btnPerro2.Text = "Perro 2"
        Me.btnPerro2.UseVisualStyleBackColor = True
        '
        'btnPerro3
        '
        Me.btnPerro3.Location = New System.Drawing.Point(120, 218)
        Me.btnPerro3.Name = "btnPerro3"
        Me.btnPerro3.Size = New System.Drawing.Size(120, 60)
        Me.btnPerro3.TabIndex = 2
        Me.btnPerro3.Text = "Perro 3"
        Me.btnPerro3.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(36, 334)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(286, 20)
        Me.txtResultado.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 415)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.btnPerro3)
        Me.Controls.Add(Me.btnPerro2)
        Me.Controls.Add(Me.btnPerro1)
        Me.Name = "Form1"
        Me.Text = "Clases y Objetos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPerro1 As Button
    Friend WithEvents btnPerro2 As Button
    Friend WithEvents btnPerro3 As Button
    Friend WithEvents txtResultado As TextBox
End Class
