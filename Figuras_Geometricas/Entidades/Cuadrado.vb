Public Class Cuadrado
    Inherits Figura

    Dim _lado As UShort
    Public Property Lado As UShort
        Get
            Return _lado
        End Get
        Set(value As UShort)
            _lado = value
        End Set
    End Property

    Sub New(nombre As String, lado As UShort)
        MyBase.New(nombre)
        Me.Lado = lado
    End Sub

    Public Overrides Function CalcularArea() As Single
        Return (Lado * Lado) ^ 2
    End Function

End Class
