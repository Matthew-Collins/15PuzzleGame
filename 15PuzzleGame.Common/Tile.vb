Public Class Tile
    Property Number As Integer
    Property x As Integer
    Property y As Integer
    Public Event Moved()
    Public Sub Move()
        If Me.CanMove Then

            RaiseEvent Moved()
        End If
    End Sub
    Public Function CanMove() As Boolean
        Return True
    End Function
End Class
