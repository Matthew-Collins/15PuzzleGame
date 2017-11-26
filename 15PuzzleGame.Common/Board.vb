Public Class Board
    Public Tiles(15) As Tile
    Public Sub New()
        Dim Number As Integer
        For y = 0 To 3
            For x = 0 To 3
                Dim Tile As New Tile
                Tile.Number = Number
                Tile.x = x
                Tile.y = y
                Me.Tiles(Number) = Tile
                Number += 1
            Next
        Next
    End Sub
End Class
