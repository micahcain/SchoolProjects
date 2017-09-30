Public Class Cube
    Inherits ThreeDimShapes
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
        Return 2 * (Side * Side + Side * Side + Side * Side)
    End Function

    Overrides Function calcVolume() As Object
        Return Side ^ 3
    End Function
    Public Overrides Function ToString() As String
        Return "Length of Side: " & Side & System.Environment.NewLine _
        & "Surface Area of Cube: " & calcArea() & System.Environment.NewLine _
        & "Volume of Cube: " & calcVolume()
    End Function
End Class
