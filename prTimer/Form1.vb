Public Class Form1

    Private num As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (num Mod 2 = 0) Then
            Label1.Visible = True
            Label2.Visible = False
        Else
            Label1.Visible = False
            Label2.Visible = True
        End If

        num = num + 1
    End Sub

    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Timer1.Enabled = True
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Enabled = False

        num = 0
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblFecha.Text = TimeOfDay

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFecha.Text = TimeOfDay
    End Sub
End Class
