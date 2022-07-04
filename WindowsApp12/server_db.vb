Public Class server_db
    Dim er As New Error_message
    Private Sub saveData_Click(sender As Object, e As EventArgs) Handles saveData.Click
        If server.Text = String.Empty Then
            er.messageERROR("Invalid Client Account")
        ElseIf user.Text = String.Empty Then
            er.messageERROR("Invalid Client Account")
        Else
            My.Settings.Server = server.Text
            My.Settings.User = user.Text
            My.Settings.Pass = pass.Text
            Application.Restart()
        End If
    End Sub

    Private Sub server_db_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        server.Select()
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        server.Text = ""
        user.Text = ""
        pass.Text = ""
        Me.Close()
    End Sub
End Class