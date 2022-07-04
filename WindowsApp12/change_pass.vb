Imports WindowsApp12.login
Imports WindowsApp12.SQLConn
Imports MySql.Data.MySqlClient
Public Class change_pass
    Dim suc As New Success
    Dim mess As New Error_message
    Private Sub change_pass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)


        oldpass.Select()
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        oldpass.Text = ""
        newpass.Text = ""
        repass.Text = ""
        Me.Close()
    End Sub

    Private Sub saveData_Click(sender As Object, e As EventArgs) Handles saveData.Click

        If Not oldpass.Text.Equals(pass) Then
            mess.messageERROR("Invalid Password!")
        ElseIf Not newpass.Text.Equals(repass.Text) Then
            mess.messageERROR("Invalid Password!")
        Else
            Using sqlcommand As New MySqlCommand()
                With sqlcommand
                    .CommandText = "UPDATE accounts SET Password = @pass WHERE ID = @id "
                    .Parameters.AddWithValue("@id", idpass)
                    .Parameters.AddWithValue("@pass", newpass.Text)
                    .Connection = SQLString

                End With
                Try
                    ConnectSQL()
                    sqlcommand.ExecuteNonQuery()
                    suc.messageSuccess("Password Changed!!")

                    oldpass.Text = ""
                    newpass.Text = ""
                    repass.Text = ""
                    Me.Close()
                Catch ex As Exception
                    mess.messageERROR(ex.Message)
                End Try
            End Using
        End If
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click

        oldpass.Text = ""
        newpass.Text = ""
        repass.Text = ""
        Me.Close()
    End Sub

    Private Sub GunaGradient2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles GunaGradient2Panel2.Paint

    End Sub
End Class