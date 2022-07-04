Imports WindowsApp12.security_code
Imports WindowsApp12.SQLConn
Imports MySql.Data.MySqlClient
Imports WindowsApp12.forgot_pass
Public Class reset_pass
    Dim mess As New Error_message
    Dim suc As New Success
    Private Sub reset_pass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        security_code.Hide()
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Sub saveData_Click(sender As Object, e As EventArgs) Handles saveData.Click

        If Not newpass.Text.Equals(repass.Text) Then
            mess.messageERROR("Invalid Password!")
        ElseIf newpass.Text = String.Empty Then
            mess.messageERROR("Invalid Password!")
        ElseIf repass.Text = String.Empty Then
            mess.messageERROR("Invalid Password!")
        Else
            Using sqlcommand As New MySqlCommand()
                With sqlcommand
                    .CommandText = "UPDATE accounts SET Password = @pass WHERE Umindanao_Account = @ac "
                    .Parameters.AddWithValue("@ac", email_code)
                    .Parameters.AddWithValue("@pass", newpass.Text)
                    .Connection = SQLString
                End With
                Try
                    ConnectSQL()
                    sqlcommand.ExecuteNonQuery()
                    suc.messageSuccess("Password Changed!!")
                    newpass.Text = ""
                    repass.Text = ""
                    Me.Close()
                Catch ex As Exception
                    mess.messageERROR(ex.Message)
                End Try
            End Using
        End If
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Me.Close()
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Me.Close()
    End Sub
End Class