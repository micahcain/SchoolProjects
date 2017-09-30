Public Class Shpere
    Inherits ThreeDimShapes
    Private _radius As Decimal

    Sub New(ByVal theRadius As Decimal)
        Radius = theRadius
    End Sub
    Public Property Radius() As Decimal
        Get
            Return _radius
        End Get
        Set(ByVal value As Decimal)
            _radius = value
        End Set
    End Property
    Overrides Function calcArea() As Object
        Return 4 * Math.PI * Radius ^ 2
    End Function

    Overrides Function calcVolume() As Object
        Return 4 / 3 * Math.PI * Radius ^ 2
    End Function

    Public Overrides Function ToString() As String
        Return "Radius of shpere: " & Radius & System.Environment.NewLine _
        & "Volume of Sphere: " & calcVolume() & System.Environment.NewLine _
        & "Surface Area of Sphere: " & calcArea()
    End Function
End Class
