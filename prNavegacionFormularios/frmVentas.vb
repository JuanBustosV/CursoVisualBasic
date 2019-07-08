Public Class frmVentas
    'Para trabajar tan solo con una sola linstancia de frmVentas
    Public Shared _instancia As frmVentas

    Public Function GetInstancia() As frmVentas
        If (_instancia Is Nothing) Then
            _instancia = New frmVentas()
        End If

        Return _instancia
    End Function

    Public Sub SetCliente(cliente As String)
        Me.txtCliente.Text = cliente
    End Sub

    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim frmVista As frmClientes = New frmClientes()

        frmVista.ShowDialog()
    End Sub

    Private Sub FrmVentas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _instancia = Nothing
    End Sub
End Class