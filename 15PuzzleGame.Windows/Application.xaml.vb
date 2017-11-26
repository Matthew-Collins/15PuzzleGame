Class Application
    Private Sub Application_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
        Dim Model As New Board
        If e.Args.Contains("wpf") Then
            Dim View As New wpf.Board
            View.DataContext = Model
            View.ShowDialog()
        Else
            Dim View As New WinForm.Board
            View.Model = Model
            View.ShowDialog()
        End If
    End Sub
End Class
