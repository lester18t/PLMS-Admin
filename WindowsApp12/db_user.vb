Imports MySql.Data.MySqlClient
Imports WindowsApp12.SQLConn
Public Class db_user
    Dim er1 As New Error_message
    Dim suc As New Success
    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        user.Text = ""
        pass.Text = ""
        Me.Close()
    End Sub



    Private Sub db_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        pcName.Text = My.Computer.Name
        hostname.Text = System.Net.Dns.GetHostName
        ipAddress.Text = System.Net.Dns.GetHostByName(hostname.Text).AddressList(0).ToString
    End Sub

    Private Sub saveData_Click(sender As Object, e As EventArgs) Handles saveData.Click
        If user.Text = String.Empty Then
            er1.messageERROR("Invalid Client Account")
        ElseIf pass.Text = String.Empty Then
            er1.messageERROR("Invalid Client Account")
        Else
            Using sqlcommand As New MySqlCommand
                With sqlcommand
                    .CommandText = "GRANT ALL PRIVILEGES ON *.* TO '" & user.Text & "'@'%' IDENTIFIED BY '" & pass.Text & "';"
                    .Connection = SQLString
                    ConnectSQL()
                    .ExecuteNonQuery()
                    suc.messageSuccess("Client Account Created!!")
                    user.Text = ""
                    pass.Text = " "
                    Close()
                End With
            End Using
        End If
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs)

    End Sub
End Class