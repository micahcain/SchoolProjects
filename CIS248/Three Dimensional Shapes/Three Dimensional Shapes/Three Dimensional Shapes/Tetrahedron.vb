Public Class Tetrahedron
    Inherits ThreeDimShapes
    Private _height As Decimal
    Private _side As Decimal
    Sub New(ByVal theSide As Decimal)
        Side = theSide
    End Sub
    Public Property Side() As Decimal
        Get
            Return _side
        End Get
        Set(ByVal value As Decimal)
            _side = value
        End Set
    End Property

    Overrides Function calcArea() As Object
        Return 4 * (0.5 * Side * Side)
    End Function

    Overrides Function calcVolume() As Object
        Return 1 / 3 * ((0.5 * Side * Side) * Side)
    End Function
    Public Overrides Function ToString() As String
        Return "Lenght of Side: " & Side & System.Environment.NewLine _
        & "Surface Area of Tetrahedron: " & calcArea() & System.Environment.NewLine _
        & "Volume of Tetrahedron: " & calcVolume()
    End Function
End Class
