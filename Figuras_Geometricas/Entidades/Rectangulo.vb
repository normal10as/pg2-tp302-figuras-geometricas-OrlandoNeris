Public Class Rectangulo
    Inherits Figura

    Dim _base As UShort
    Public Property Base As UShort
        Get
            Return _base
        End Get
        Set(value As UShort)
            _base = value
        End Set
    End Property

    Dim _altura As UShort

    Public Property altura As UShort
        Get
            Return _altura
        End Get
        Set(value As UShort)
            _altura = value
        End Set
    End Property

    Sub New(nombre As String, base As UShort, altura As UShort)
        MyBase.New(nombre)
        Me.Base = base
        Me.altura = altura
    End Sub

    Public Overrides Function CalcularArea() As Single
        Return Base * altura
    End Function


End Class
