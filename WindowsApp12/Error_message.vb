
Public Class Error_message
    Dim trueMess As String

    Sub messageERROR(message As String)
        trueMess = message
        Me.ShowDialog()
        Me.TopMost = True
    End Sub
    Private Sub Error_message_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Label1.Text = trueMess
    End Sub
    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles back_error.Click
        Me.Close()
    End Sub

End Class