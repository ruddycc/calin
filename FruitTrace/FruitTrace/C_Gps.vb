Public Class C_Gps
    Inherits Object

    Public dLat As Double
    Public dLong As Double

    Public Sub New()
        Me.New(0, 0)
    End Sub

    Public Sub New(ByVal dLat As Double, ByVal dLong As Double)
        Me.dLat = dLat
        Me.dLong = dLong
    End Sub

    Overrides Function Equals(point As Object) As Boolean
        Return (CType(point, C_Gps).dLat = Me.dLat And CType(point, C_Gps).dLong = Me.dLong)
    End Function

    Overrides Function toString() As String
        Return dLat & "/" & dLong
    End Function

End Class
