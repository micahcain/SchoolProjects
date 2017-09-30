Public MustInherit Class ThreeDimShapes
    Private _surfaceArea
    Private _volume

    Property surfaceArea() As Decimal
        Get
            Return _surfaceArea()
        End Get
        Set(ByVal value As Decimal)
            _surfaceArea = value
        End Set
    End Property
    Property volume() As Decimal
        Get
            Return _volume
        End Get
        Set(ByVal value As Decimal)
            _volume = value
        End Set
    End Property
    MustOverride Function calcArea()

    MustOverride Function calcVolume()

    Public Overrides Function ToString() As String
        Return "Area: " & surfaceArea & System.Environment.NewLine _
        & "Volume: " & volume
    End Function
End Class
