Imports MySql.Data.MySqlClient
Imports WindowsApp12.SQLConn
Public Class add_account
    Dim mess As New Error_message
    Dim suc As New Success
    Dim das As String
    Dim dis As String
    Dim existedID As New Error_message
    Dim existed_email As New Error_message
    Private Sub GunaComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles college_combox.SelectedIndexChanged
        program_combox.Items.Clear()

        Dim selectedCourse As String = ""
        If college_combox.SelectedIndex >= 0 Then
            For Each item As String In My.Settings.Colleges
                If item.Contains(college_combox.SelectedItem.ToString) Then
                    selectedCourse = item.Substring(0, 3)
                End If
            Next

            For Each item As String In My.Settings.Programs
                If item.Contains(selectedCourse.ToString) Then
                    program_combox.Items.Add(item.Remove(0, 4))
                End If
            Next
        End If

    End Sub

    Private Sub GunaTextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles age_box.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub GunaTextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles id_box.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Dim sqlcommand1 As New MySqlCommand()
        With sqlcommand1

            .CommandText = "SELECT * FROM accounts WHERE Umindanao_Account = @ac Or ID = @id "
            .Parameters.AddWithValue("@ac", account_umin.Text.Trim)
            .Parameters.AddWithValue("@id", id_box.Text.Trim)
            .Connection = SQLString
        End With
        Try
            ConnectSQL()
            Using dataReader4 As MySqlDataReader = sqlcommand1.ExecuteReader

                While dataReader4.Read
                    dis = dataReader4.GetString(0)
                    das = dataReader4.GetString(8)
                End While

            End Using
        Catch ex As Exception
            mess.messageERROR(ex.Message)
        End Try
        If newpass_box.Text.Equals(confirm_box.Text) Then
                    If lname_box.Text = String.Empty Then
                        mess.messageERROR("Fill up the blanks")
                    ElseIf id_box.Text = String.Empty Then
                        mess.messageERROR("Fill up the blanks")
                    ElseIf fname_box.Text = String.Empty Then
                        mess.messageERROR("Fill up the blanks")
                    ElseIf mname_box.Text = String.Empty Then
                        mess.messageERROR("Fill up the blanks")
                    ElseIf age_box.Text = String.Empty Then
                        mess.messageERROR("Fill up the blanks")
                    ElseIf confirm_box.Text = String.Empty Then
                        mess.messageERROR("Fill up the blanks")
                    ElseIf usertype_combo.SelectedItem = String.Empty Then
                        mess.messageERROR("Fill up the blanks")
                    ElseIf college_combox.SelectedItem = String.Empty Then
                        mess.messageERROR("Fill up the blanks")
                    ElseIf program_combox.SelectedItem = String.Empty Then
                        mess.messageERROR("Fill up the blanks")
                    ElseIf account_umin.Text = String.Empty Then
                        mess.messageERROR("Fill up the blanks")
                    ElseIf account_umin.Text.Equals(das) Then
                        existed_email.messageERROR("Email Already Exist!")
                    ElseIf id_box.Text.Equals(dis) Then
                        existedID.messageERROR("ID Already Exist!")
                    Else
                        Dim dialog As DialogResult
                dialog = MessageBox.Show("Add " & fname_box.Text.Trim & " " & mname_box.Text.Trim & " " & lname_box.Text.Trim & " As " & usertype_combo.SelectedItem.ToString & "?",
                                                 "Add New Account",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question)
                If dialog = DialogResult.Yes Then
                            Using sqlcommand As New MySqlCommand()
                                With sqlcommand
                            .CommandText = "INSERT INTO accounts (ID, FirstName, MiddleName, LastName, Age, UserType, College, Program, Umindanao_Account,Password) 
                                values (@id, @firstname, @mname, @lastname, @age, @usertype, @college, @prog,@umin, @pass)"
                            .Parameters.AddWithValue("@id", id_box.Text.Trim)
                            .Parameters.AddWithValue("@firstname", fname_box.Text.Trim)
                            .Parameters.AddWithValue("@mname", mname_box.Text.Trim)
                            .Parameters.AddWithValue("@lastname", lname_box.Text.Trim)
                            .Parameters.AddWithValue("@age", age_box.Text.Trim)
                            .Parameters.AddWithValue("@usertype", usertype_combo.SelectedItem.ToString)
                            .Parameters.AddWithValue("@college", college_combox.SelectedItem.ToString)
                            .Parameters.AddWithValue("@prog", program_combox.SelectedItem.ToString)
                            .Parameters.AddWithValue("@umin", account_umin.Text.Trim)
                            .Parameters.AddWithValue("@pass", confirm_box.Text.Trim)
                            .Connection = SQLString

                        End With
                                Try
                                    ConnectSQL()
                                    sqlcommand.ExecuteNonQuery()
                                    suc.messageSuccess("Registered Successfully")
                                Catch ex As Exception
                            mess.messageERROR(ex.Message)
                        End Try
                            End Using
                            lname_box.Text = ""
                            fname_box.Text = ""
                            mname_box.Text = ""
                            confirm_box.Text = ""
                            newpass_box.Text = ""
                            age_box.Text = ""
                            college_combox.SelectedIndex = -1
                            program_combox.SelectedIndex = -1
                            usertype_combo.SelectedIndex = -1
                            id_box.Text = ""
                            account_umin.Text = ""
                        Else


                        End If

                    End If
                Else
                    mess.messageERROR("Invalid Password")
                End If



    End Sub



    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        lname_box.Text = ""
        fname_box.Text = ""
        mname_box.Text = ""
        confirm_box.Text = ""
        newpass_box.Text = ""
        age_box.Text = ""
        account_umin.Text = ""
        id_box.Text = ""
        college_combox.SelectedIndex = -1
        program_combox.SelectedIndex = -1
        usertype_combo.SelectedIndex = -1
        account_umin.Text = ""

    End Sub

    Private Sub lname_box_Leave(sender As Object, e As EventArgs) Handles lname_box.Leave
        lname_box.Text = StrConv(lname_box.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub fname_box_Leave(sender As Object, e As EventArgs) Handles fname_box.Leave
        fname_box.Text = StrConv(fname_box.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub mname_box_Leave(sender As Object, e As EventArgs) Handles mname_box.Leave
        mname_box.Text = StrConv(mname_box.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub lname_box_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lname_box.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub fname_box_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fname_box.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub mname_box_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mname_box.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub account_umin_Leave(sender As Object, e As EventArgs) Handles account_umin.Leave
        account_umin.Text = account_umin.Text.ToLower
    End Sub

    Private Sub add_account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        college_combox.Items.Clear()
        For Each item As String In My.Settings.Colleges
            college_combox.Items.Add(item.Remove(0, 4))
        Next
    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        Dim edd As New Add_Courses
        edd.ShowDialog()
        refresh_Label.Visible = True
    End Sub

    Private Sub refresh_Label_Click(sender As Object, e As EventArgs) Handles refresh_Label.Click
        add_account_Load(sender, e)
        refresh_Label.Visible = False
    End Sub

    Private Sub refresh_Label_MouseEnter(sender As Object, e As EventArgs) Handles refresh_Label.MouseEnter
        refresh_Label.ForeColor = Color.FromArgb(208, 78, 214)
    End Sub

    Private Sub refresh_Label_MouseLeave(sender As Object, e As EventArgs) Handles refresh_Label.MouseLeave
        refresh_Label.ForeColor = Color.FromArgb(252, 0, 255)
    End Sub

    Private Sub confirm_box_KeyDown(sender As Object, e As KeyEventArgs) Handles confirm_box.KeyDown
        If e.KeyCode = Keys.Enter Then
            loginButton_Click(sender, e)
            e.Handled = True
        End If
    End Sub
End Class
