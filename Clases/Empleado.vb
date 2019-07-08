Public Class Empleado
    Inherits Persona
    'Atributos

    'Propiedades automáticas
    Public Property TipoContrato As String
    Public Property Sueldo As Double

    'Métodos
    Public Sub CalcularSueldo(sueldoBase As Double)
        If (Me.TipoContrato = "C") Then
            Me.Sueldo = sueldoBase + 350
        ElseIf (Me.TipoContrato = "N") Then
            Me.Sueldo = sueldoBase + 750
        Else
            Me.Sueldo = 0
        End If
    End Sub
End Class
