Imports System.Drawing
Public Class Tile
    Inherits Forms.Button
    Public SizeX As Integer = 100
    Public SizeY As Integer = 100
    Public WithEvents Model As Common.Tile
    Public Sub New(Model As Common.Tile)
        Me.Model = Model
        If Me.Model.Number > 0 Then
            Me.Text = Me.Model.Number
        End If
        Me.Model_Moved()
        Me.Size = New Size(SizeX, SizeY)
        Me.Font = New Font(Me.Font.FontFamily, 30)
    End Sub
    Private Sub Tile_Click(sender As Object, e As EventArgs) Handles Me.Click
        Me.Model.Move()
    End Sub
    Private Sub Model_Moved() Handles Model.Moved
        Me.Location = New Point(Model.x * (SizeX + 10), Model.y * (SizeY + 10))
    End Sub
End Class
