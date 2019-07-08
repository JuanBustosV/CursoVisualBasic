<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Seleccione Cliente:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(180, 82)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(255, 20)
        Me.txtCliente.TabIndex = 2
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Location = New System.Drawing.Point(480, 80)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarCliente.TabIndex = 3
        Me.btnBuscarCliente.Text = "Buscar"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 203)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmVentas"
        Me.Text = "Ventas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents btnBuscarCliente As Button
End Class
