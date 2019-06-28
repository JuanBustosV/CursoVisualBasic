Public Class Form1
    Private Sub Btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        'Declaración de variables
        Dim cant As Integer
        Dim punitario, descuento, pparcial, pneto As Single
        Dim marcades As Boolean

        'Entrada de datos
        cant = Val(txtcantidad.Text)
        punitario = Val(txtpunitario.Text)
        marcades = chkdes.Checked

        'Inicializar variable descuento
        descuento = 0
        'Proceso
        pparcial = cant * punitario
        'Evaluar si aplicamos o no un descuento
        If (marcades = True) Then
            descuento = pparcial * 7 / 100
        End If

        pneto = pparcial - descuento

        'Salida de Información
        txtpparcial.Text = pparcial
        txtdes.Text = descuento
        txtpneto.Text = pneto

    End Sub

    Private Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtcantidad.Clear()
        txtpunitario.Clear()
        txtpparcial.Clear()
        txtdes.Clear()
        txtpneto.Clear()

        chkdes.Checked = False

    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub
End Class
