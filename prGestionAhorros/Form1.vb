Public Class Form1
    'Propiedad
    Public Property Monto As Double

    'Procedimientos
    Private Sub ActivarControles()
        txtCliente.Enabled = False
        txtMonto.Enabled = False
        btnAbrir.Enabled = False
        txtSaldo.Enabled = True
        btnRetiros.Enabled = True
        btnDepositos.Enabled = True
    End Sub

    Private Sub DesactivarControles()
        txtCliente.Enabled = True
        txtMonto.Enabled = True
        btnAbrir.Enabled = True
        txtSaldo.Enabled = False
        btnRetiros.Enabled = False
        btnDepositos.Enabled = False
    End Sub

    Private Sub Mostrar()
        txtSaldo.Text = Monto
    End Sub

    'Funciones
    Private Function Leer(mensaje As String) As Double
        Dim cantidad As Double
        cantidad = InputBox("Ingrese monto a " + mensaje + ": ", "Gestión de Ahorros", "0", 100, 0)

        Return cantidad
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesactivarControles()
    End Sub

    Private Sub BtnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        Dim cliente As String
        cliente = txtCliente.Text

        Monto = txtMonto.Text

        If (Monto >= 0) Then
            ActivarControles()
        Else
            MessageBox.Show("El monto no puede ser inferior a cero", "Gestión de Ahorros", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnDepositos_Click(sender As Object, e As EventArgs) Handles btnDepositos.Click
        Dim deposito As Double
        deposito = Leer("Depositar")
        Monto += deposito

        lstDepositos.Items.Add(deposito)
        Mostrar()
    End Sub

    Private Sub BtnRetiros_Click(sender As Object, e As EventArgs) Handles btnRetiros.Click
        Dim retiro As Double

        retiro = Leer("Retirar")

        If (retiro <= Monto) Then
            Monto -= retiro
            lstRetiros.Items.Add(retiro)
            Mostrar()
        Else
            MessageBox.Show("No se puede retirar una cantidad mayor al monto actual", "Gestión de Ahorros", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        DesactivarControles()
        lstDepositos.Items.Clear()
        lstRetiros.Items.Clear()
        txtMonto.Clear()
        txtCliente.Clear()
        txtSaldo.Clear()

    End Sub
End Class
