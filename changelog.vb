Public Class changelog

    Private Sub changelog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "You have successfully updated to  version " & System.Reflection.Assembly.GetEntryAssembly.GetName().Version.ToString & ". Read below for latest changes"
    End Sub

    Private Sub ReactorButton1_Click(sender As Object, e As EventArgs) Handles ReactorButton1.Click
        Me.Close()
    End Sub
End Class