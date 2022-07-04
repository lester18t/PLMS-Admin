Imports MySql.Data.MySqlClient
Imports WindowsApp12.SQLConn
Imports WindowsApp12.forgot_pass
Public Class login
    Public Shared activeAccount As String
    Dim conn As SQLConn = New SQLConn
    Dim err As New Error_message
    Public Shared idpass As String
    Public Shared pass As String

    Private Sub GunaTextBox1_Enter(sender As Object, e As EventArgs) Handles idBox.Enter
        If idBox.Text = "Administrator ID" Then
            idBox.Text = ""
            idBox.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub idBox_Leave(sender As Object, e As EventArgs) Handles idBox.Leave
        If idBox.Text = "" Then
            idBox.Text = "Administrator ID"
            idBox.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idBox.Text = "Administrator ID"
        idBox.ForeColor = Color.DimGray
        pwBox.Text = "Password"
        pwBox.ForeColor = Color.DimGray
    End Sub

    Private Sub pwBox_Enter(sender As Object, e As EventArgs) Handles pwBox.Enter
        If pwBox.Text = "Password" Then
            pwBox.Text = ""
            pwBox.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub pwBox_Leave(sender As Object, e As EventArgs) Handles pwBox.Leave
        If pwBox.Text = "" Then
            pwBox.Text = "Password"
            pwBox.ForeColor = Color.DimGray

        End If
    End Sub

    Private Sub idBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles idBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles login_button.Click
        Dim sqlcommand As New MySqlCommand()
        With sqlcommand
            .CommandText = "SELECT * FROM accounts WHERE ID = @id and Password = @pass"
            .Parameters.AddWithValue("@id", idBox.Text)
            .Parameters.AddWithValue("@pass", pwBox.Text)
            .Connection = SQLString
        End With
        Try
            ConnectSQL()
            Dim da As String = ""
            Dim ds As String = ""

            Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader
                While dataReader.Read
                    ds = dataReader.GetString(0)
                    da = dataReader.GetString(5)
                End While
            End Using

            If Not idBox.Text().Equals(ds) Then
                err.messageERROR("Invalid Credentials!")
            ElseIf (da.Equals("Admin")) Then
                activeAccount = idBox.Text
                idpass = activeAccount
                pass = SearchData("Password", "accounts", "ID", idpass)
                idBox.Text = ""
                pwBox.Text = ""
                MainForm.naming.Text = "Welcome  " & SearchData("LastName", "accounts", "ID", activeAccount).ToUpper + ", " + SearchData("FirstName", "accounts", "ID", activeAccount).ToUpper + "!"
                MainForm.Show()
                Me.Hide()
            Else
                err.messageERROR("Invalid Credentials!")
            End If
        Catch ex As Exception
            err.messageERROR(ex.Message)
        End Try
    End Sub

    Private Sub GunaLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel1.LinkClicked
        forgot_pass.ShowDialog()
        forgot_pass.emailbox.Text = "Enter email account"
        forgot_pass.emailbox.ForeColor = Color.DimGray
    End Sub
    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        server_db.Show()
    End Sub

    Private Sub login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        Dim dialog As DialogResult = MessageBox.Show("Do you want to close this application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If dialog = DialogResult.Yes Then
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub
End Class