Imports MySql.Data.MySqlClient
Imports WindowsApp12.SQLConn
Imports WindowsApp12.MainForm
Public Class registerupdate
    Dim reg As New register_accounts
    Dim errors As New Error_message
    Dim suc As New Success

    Private Sub registerupdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        FirstNameUpdate.Select()

        Using sqlComm As New MySqlCommand
            Dim dataAdapt As New MySqlDataAdapter
            Dim dataset As New DataSet
            Dim result As String = ""
            With sqlComm
                .CommandText = "SELECT * FROM accounts WHERE ID = @id "
                .Parameters.AddWithValue("@id", reg.selectedAcct)
                .Connection = SQLString
            End With

            Try
                dataAdapt.SelectCommand = sqlComm
                dataAdapt.Fill(dataset)
            Catch ex As Exception

            End Try
            FirstNameUpdate.Text = dataset.Tables(0).Rows(0).Item(1)
            MidleNameUpdate.Text = dataset.Tables(0).Rows(0).Item(2)
            LastNameUpdate.Text = dataset.Tables(0).Rows(0).Item(3)
            ageUpdate.Text = dataset.Tables(0).Rows(0).Item(4)
            UserTypeUpdate.SelectedItem = dataset.Tables(0).Rows(0).Item(5)
            college_Update.SelectedItem = dataset.Tables(0).Rows(0).Item(6)
            programUpdate.SelectedItem = dataset.Tables(0).Rows(0).Item(7)
            umin_account.Text = dataset.Tables(0).Rows(0).Item(8)

        End Using


    End Sub
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
    Private Sub college_Update_SelectedIndexChanged(sender As Object, e As EventArgs) Handles college_Update.SelectedIndexChanged
        programUpdate.Items.Clear()
        If college_Update.SelectedIndex = 0 Then
            programUpdate.Items.Add("Arc - Architecture")
        ElseIf college_Update.SelectedIndex = 1 Then
            programUpdate.Items.Add("CS - Computer Science")
            programUpdate.Items.Add("IT - Information Technolgy")
        ElseIf college_Update.SelectedIndex = 2 Then
            programUpdate.Items.Add("ChE - Chemical Engineering")
            programUpdate.Items.Add("CE - Civil Engineering")
            programUpdate.Items.Add("CpE - Computer Engineering")
            programUpdate.Items.Add("EE - Electrical Engineering")
            programUpdate.Items.Add("ECE - Electronics Engineering")
            programUpdate.Items.Add("ME - Mechanical Engineering")
        End If
        college_Update.BorderColor = Color.FromArgb(151, 51, 238)
    End Sub

    Private Sub GunaTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ageUpdate.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles saveData.Click
        Try

            If FirstNameUpdate.Text = String.Empty Then
                errors.messageERROR("Fill up all blanks!")
            ElseIf MidleNameUpdate.Text = String.Empty Then
                errors.messageERROR("Fill up all blanks!")
            ElseIf LastNameUpdate.Text = String.Empty Then
                errors.messageERROR("Fill up all blanks!")
            ElseIf ageUpdate.Text = String.Empty Then
                errors.messageERROR("Fill up all blanks!")
            ElseIf UserTypeUpdate.SelectedItem = String.Empty Then
                errors.messageERROR("Fill up all blanks!")
            ElseIf college_Update.SelectedItem = String.Empty Then
                errors.messageERROR("Fill up all blanks!")
            ElseIf programUpdate.SelectedItem = String.Empty Then
                errors.messageERROR("Fill up all blanks!")
            ElseIf umin_account.Text = String.Empty Then
                errors.messageERROR("Fill up all blanks!")
            Else
                Using sqlcommand As New MySqlCommand()
                    With sqlcommand
                        .CommandText = "UPDATE accounts SET FirstName = @fname, MiddleName = @mname, LastName = @lname, Age = @age, UserType = @usertype, College = @college, Program = @prog ,Umindanao_Account = @umin WHERE ID = @id"
                        .Parameters.AddWithValue("@id", reg.selectedAcct)
                        .Parameters.AddWithValue("@fname", FirstNameUpdate.Text.Trim)
                        .Parameters.AddWithValue("@mname", MidleNameUpdate.Text.Trim)
                        .Parameters.AddWithValue("@lname", LastNameUpdate.Text.Trim)
                        .Parameters.AddWithValue("@age", ageUpdate.Text.Trim)
                        .Parameters.AddWithValue("@usertype", UserTypeUpdate.SelectedItem.ToString)
                        .Parameters.AddWithValue("@college", college_Update.SelectedItem.ToString)
                        .Parameters.AddWithValue("@prog", programUpdate.SelectedItem.ToString)
                        .Parameters.AddWithValue("@umin", umin_account.Text.Trim)
                        .Connection = SQLString
                    End With
                    Try

                        ConnectSQL()
                        sqlcommand.ExecuteNonQuery()
                        suc.messageSuccess("Updated Successfully")
                        MainForm.GunaGradientButton3_Click(MainForm.subAccount, EventArgs.Empty)
                        Me.Close()
                    Catch ex As Exception
                        errors.messageERROR(ex.Message)
                    End Try
                End Using
            End If

        Catch ex1 As Exception
            errors.messageERROR(ex1.Message)
        End Try
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Me.Hide()
    End Sub

    Private Sub UserTypeUpdate_Enter(sender As Object, e As EventArgs) Handles UserTypeUpdate.Enter
        UserTypeUpdate.BorderColor = Color.FromArgb(151, 51, 238)
    End Sub

    Private Sub programUpdate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles programUpdate.SelectedIndexChanged
        programUpdate.BorderColor = Color.FromArgb(151, 51, 238)
    End Sub

    Private Sub FullNameUpdate_TextChanged(sender As Object, e As EventArgs) Handles FirstNameUpdate.TextChanged
        FirstNameUpdate.BorderColor = Color.FromArgb(151, 51, 238)
    End Sub

    Private Sub ageUpdate_TextChanged(sender As Object, e As EventArgs) Handles ageUpdate.TextChanged
        ageUpdate.BorderColor = Color.FromArgb(151, 51, 238)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub


    Private Sub UserTypeUpdate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UserTypeUpdate.SelectedIndexChanged
        UserTypeUpdate.BorderColor = Color.FromArgb(151, 51, 238)
    End Sub

    Private Sub MidleNameUpdate_TextChanged(sender As Object, e As EventArgs) Handles MidleNameUpdate.TextChanged
        MidleNameUpdate.BorderColor = Color.FromArgb(151, 51, 238)
    End Sub

    Private Sub LastNameUpdate_TextChanged(sender As Object, e As EventArgs) Handles LastNameUpdate.TextChanged
        LastNameUpdate.BorderColor = Color.FromArgb(151, 51, 238)
    End Sub



    Private Sub umin_account_TextChanged(sender As Object, e As EventArgs) Handles umin_account.TextChanged
        umin_account.BorderColor = Color.FromArgb(151, 51, 238)
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Me.Close()
    End Sub


End Class