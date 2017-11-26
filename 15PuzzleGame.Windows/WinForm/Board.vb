Namespace WinForm
    Public Class Board
        Public Property Model As Common.Board
        Private Sub Board_Load(sender As Object, e As EventArgs) Handles Me.Load
            For Each Item In Model.Tiles
                Me.Controls.Add(New Tile(Item))
            Next
        End Sub
    End Class
End Namespace