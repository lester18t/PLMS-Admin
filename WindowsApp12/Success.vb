Public Class Success
    Dim trueMess As String
    Sub messageSuccess(message As String)
        trueMess = message
        Me.ShowDialog()
        Me.TopMost = True
    End Sub
    Private Sub Success_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Label2.Text = trueMess
    End Sub

    Private Sub loginButton_Click_1(sender As Object, e As EventArgs) Handles success_button.Click
        Me.Close()
    End Sub

End Class