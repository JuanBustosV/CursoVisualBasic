Public Class frmClientes
    Private Sub CboClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClientes.SelectedIndexChanged
        Dim frm As frmVentas = frmVentas.GetInstancia() 'No crear nuevas instancias siempre
        Dim pCli As String = cboClientes.Text

        frm.SetCliente(pCli)
        Me.Hide()

    End Sub
End Class