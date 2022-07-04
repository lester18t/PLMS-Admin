Imports WindowsApp12.SQLConn
Imports MySql.Data.MySqlClient
Imports System.Net.Mail

Public Class forgot_pass
    Public Shared email_code As String
    Public Shared code_red As String
    Dim er As New Error_message
    Dim sucs As New Success
    Dim das As String
    Private Sub oldpass_Leave(sender As Object, e As EventArgs) Handles emailbox.Leave
        If emailbox.Text = "" Then
            emailbox.Text = "Enter email account"
            emailbox.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub emailbox_Enter(sender As Object, e As EventArgs) Handles emailbox.Enter
        If emailbox.Text = "Enter email account" Then
            emailbox.Text = ""
            emailbox.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub forgot_pass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        emailbox.Text = "Enter email account"
        emailbox.ForeColor = Color.DimGray
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Me.Close()
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Me.Close()
    End Sub

    Private Sub saveData_Click(sender As Object, e As EventArgs) Handles saveData.Click
        Dim ser_code As New Random
        code_red = ser_code.Next(999999)
        email_code = emailbox.Text.ToLower
        Dim sqlcommand As New MySqlCommand()
        With sqlcommand
            .CommandText = "SELECT * FROM accounts WHERE TRIM(Umindanao_Account) = @ac"
            .Parameters.AddWithValue("@ac", emailbox.Text.ToLower)
            .Connection = SQLString
        End With
        Try
            ConnectSQL()
            Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader
                While dataReader.Read
                    das = dataReader.GetString(8)
                End While

                If emailbox.Text.ToLower = String.Empty Then
                    er.messageERROR("Email Not Found!")
                ElseIf Not emailbox.Text.ToLower.Equals(das) Then
                    er.messageERROR("Email Not Found!")
                Else
                    Try
                        loadbar.Visible = True
                        Dim Stmp_server As New SmtpClient
                        Dim e_mail As New MailMessage
                        Dim mess As String
                        mess = "Physics Laboratory Reservation"
                        Stmp_server.UseDefaultCredentials = False
                        Stmp_server.Credentials = New Net.NetworkCredential("umindanao.ph@gmail.com", "baste123")
                        Stmp_server.Port = 587
                        Stmp_server.EnableSsl = True
                        Stmp_server.Host = "smtp.gmail.com"
                        e_mail = New MailMessage
                        e_mail.From = New MailAddress("umindanao.ph@gmail.com")
                        e_mail.To.Add(email_code)
                        e_mail.IsBodyHtml = True
                        e_mail.Subject = mess
                        e_mail.Body = ("Your Security Code Here:" & vbCrLf & code_red)
                        Stmp_server.Send(e_mail)
                        Hide()
                        security_code.Show()
                    Catch ex As Exception
                        er.messageERROR(ex.Message)
                        loadbar.Visible = False
                    End Try
                End If

            End Using
        Catch ex As Exception
            er.messageERROR(ex.Message)
        End Try


    End Sub
End Class