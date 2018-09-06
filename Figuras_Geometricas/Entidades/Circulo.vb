Public Class Circulo
    Inherits Figura

    Dim _radio As UShort
    Public Property Radio As UShort
        Get
            Return _radio
        End Get
        Set(value As UShort)
            _radio = value
        End Set
    End Property

    Sub New(nombre As String, radio As UShort)
        MyBase.New(nombre)
        Me.Radio = radio

    End Sub
    Public Overrides Function CalcularArea() As Single
        Return (Math.PI * Radio) ^ 2
    End Function

End Class
