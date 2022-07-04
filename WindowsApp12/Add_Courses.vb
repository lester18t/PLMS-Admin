Public Class Add_Courses
    Dim suc As New Success
    Dim er As New Error_message
    Dim selectedAddCourse As String = ""
    Dim selectedDelCourse As String = ""
    Private Sub Add_Courses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)

        MetroTabControl1.SelectedTab = MetroTabPage1

        'add program
        college_combox.Items.Clear()
        For Each item As String In My.Settings.Colleges
            college_combox.Items.Add(item.Remove(0, 4))
        Next

        'del college
        del_coll_combox.Items.Clear()
        For Each item As String In My.Settings.Colleges
            del_coll_combox.Items.Add(item.Remove(0, 4))
        Next

        'del prog
        del_coll_prog_combox.Items.Clear()
        del_prog_combox.Items.Clear()
        For Each item As String In My.Settings.Colleges
            del_coll_prog_combox.Items.Add(item.Remove(0, 4))
        Next
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Me.Close()
    End Sub

    Private Sub lname_box_KeyPress(sender As Object, e As KeyPressEventArgs) Handles add_col_init.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GunaTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles add_col_name.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GunaTextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles add_prog_init.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GunaTextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles add_prog_name.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub lname_box_Leave(sender As Object, e As EventArgs) Handles add_col_init.Leave
        add_col_init.Text = add_col_init.Text.ToUpper.Trim
    End Sub

    Private Sub GunaTextBox1_Leave(sender As Object, e As EventArgs) Handles add_col_name.Leave
        add_col_name.Text = StrConv(add_col_name.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub GunaTextBox3_Leave(sender As Object, e As EventArgs) Handles add_prog_init.Leave
        add_prog_init.Text = add_prog_init.Text.ToUpper.Trim
    End Sub

    Private Sub GunaTextBox2_Leave(sender As Object, e As EventArgs) Handles add_prog_name.Leave
        add_prog_name.Text = StrConv(add_prog_name.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        If Not add_col_init.Text.Trim = "" And Not add_col_name.Text.Trim = "" Then
            Dim dialog As DialogResult = MessageBox.Show(String.Format("Add {0} - {1} to the list of colleges?",
                                                                   add_col_init.Text.Trim,
                                                                   add_col_name.Text.Trim),
                                                     "Add College",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)

            If dialog = DialogResult.Yes Then
                My.Settings.Colleges.Add(String.Format("{0} {1} - {2}",
                                                               (My.Settings.Colleges.Count + 1).ToString("000"),
                                                               add_col_init.Text.Trim,
                                                               add_col_name.Text.Trim))
                suc.messageSuccess("Added!")
                add_col_init.Text = ""
                add_col_name.Text = ""
            End If

            Add_Courses_Load(sender, e)
        Else
            er.messageERROR("Fill up all fields first!")
        End If
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles add_prog.Click
        If Not add_prog_init.Text.Trim = "" And Not add_prog_name.Text.Trim = "" And Not college_combox.SelectedIndex = -1 Then

            Dim dialog As DialogResult = MessageBox.Show(String.Format("Add {0} - {1} to the programs under {2}?",
                                                                       add_prog_init.Text.Trim,
                                                                       add_prog_name.Text.Trim,
                                                                       college_combox.SelectedItem.ToString),
                                                     "Add Program",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)

            If dialog = DialogResult.Yes Then
                My.Settings.Programs.Add(String.Format("{0} {1} - {2}", selectedAddCourse,
                                                               add_prog_init.Text.Trim,
                                                               add_prog_name.Text.Trim))
                suc.messageSuccess("Added!")
                add_prog_init.Text = ""
                add_prog_name.Text = ""
            End If
            Add_Courses_Load(sender, e)
        Else
            er.messageERROR("Fill up all fields first!")
        End If
    End Sub

    Private Sub college_combox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles college_combox.SelectedIndexChanged
        For Each item As String In My.Settings.Colleges
            If item.Contains(college_combox.SelectedItem) Then
                selectedAddCourse = item.Substring(0, 3)
            End If
        Next
    End Sub

    Private Sub del_coll_prog_combox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles del_coll_prog_combox.SelectedIndexChanged
        del_prog_combox.Items.Clear()

        For Each item As String In My.Settings.Colleges
            If item.Contains(del_coll_prog_combox.SelectedItem) Then
                selectedDelCourse = item.Substring(0, 3)
            End If
        Next

        For Each item As String In My.Settings.Programs
            If item.Contains(selectedDelCourse.ToString) Then
                del_prog_combox.Items.Add(item.Remove(0, 4))
            End If
        Next
    End Sub

    Private Sub del_coll_butt_Click(sender As Object, e As EventArgs) Handles del_coll_butt.Click
        If Not del_coll_combox.Text = "" Then
            Dim dialog As DialogResult = MessageBox.Show(String.Format("Delete {0} from the list of colleges?", del_coll_combox.SelectedItem.ToString),
                                                     "Delete College",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)

            If dialog = DialogResult.Yes Then
                Dim index As Integer
                Dim sel As String = ""
                For Each item As String In My.Settings.Colleges
                    If item.Contains(del_coll_combox.SelectedItem.ToString) Then
                        sel = item.Substring(0, 3)
                    End If
                Next

                For x As Integer = 0 To My.Settings.Programs.Count - 1
                    If x < My.Settings.Programs.Count AndAlso My.Settings.Programs.Item(x).ToString.Contains(sel) Then
                        My.Settings.Programs.RemoveAt(x)
                        x = x - 1
                    End If
                Next

                For Each item As String In My.Settings.Colleges
                    If item.Contains(del_coll_combox.SelectedItem.ToString) Then
                        index = My.Settings.Colleges.IndexOf(item)
                    End If
                Next

                My.Settings.Colleges.RemoveAt(index)
                suc.messageSuccess("Deleted!")
            End If

            Add_Courses_Load(sender, e)

        Else
            er.messageERROR("Fill up all fields first!")
        End If
    End Sub

    Private Sub del_prog_butt_Click(sender As Object, e As EventArgs) Handles del_prog_butt.Click
        If Not del_coll_prog_combox.SelectedIndex = -1 And Not del_prog_combox.SelectedIndex = -1 Then
            Dim dialog As DialogResult = MessageBox.Show(String.Format("Delete {0} from {1}?",
                                                                       del_prog_combox.SelectedItem.ToString,
                                                                       del_coll_prog_combox.SelectedItem.ToString),
                                                     "Delete College",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)

            If dialog = DialogResult.Yes Then
                Dim index As Integer
                For Each item As String In My.Settings.Programs
                    If item.Contains(del_prog_combox.SelectedItem.ToString) Then
                        index = My.Settings.Programs.IndexOf(item)
                    End If
                Next
                My.Settings.Programs.RemoveAt(index)
                suc.messageSuccess("Deleted!")
            End If

            Add_Courses_Load(sender, e)
        Else
            er.messageERROR("Fill up all fields first!")
        End If
    End Sub

End Class