Imports WindowsApp12.SQLConn
Imports MySql.Data.MySqlClient

Public Class register_accounts
    Public Shared selectedAcct As String
    Dim dbdata As New DataTable
    Dim suc As New Success
    Dim er As New Error_message
    Private Sub register_table_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles register_table.CellContentDoubleClick
        Dim accountmupdate As New registerupdate
        Dim selectedRow As DataGridViewRow
        If e.RowIndex >= 0 Then
            selectedRow = register_table.Rows(e.RowIndex)
            selectedAcct = selectedRow.Cells(0).Value.ToString
            accountmupdate.ShowDialog()
        End If
    End Sub

    Private Sub GunaTextBox3_TextChanged(sender As Object, e As EventArgs) Handles Search_account.TextChanged

        Search_account.Select()
        If Id_radio.Checked = True Then


            Using sqlcommand As New MySqlCommand()
                Dim dataAdapter As New MySqlDataAdapter
                Dim dataTable As New DataTable

                With sqlcommand
                    .CommandText = "SELECT ID, FirstName,LastName, College, Program FROM accounts"
                    .Connection = SQLString
                End With

                Try
                    dataAdapter.SelectCommand = sqlcommand
                    dataTable.Clear()
                    dataAdapter.Fill(dataTable)

                    For Each row As DataRow In dataTable.Rows
                        row(1) = row(1) & " " & row(2)
                    Next
                    dataTable.Columns.RemoveAt(2)
                    register_table.DataSource = dataTable
                Catch ex As Exception

                End Try

                Dim view As New DataView(dataTable)

                Try
                    view.RowFilter = String.Format("Convert(ID,'System.String') Like '%{0}%'", Search_account.Text)
                    register_table.DataSource = view
                Catch ex As Exception
                    er.messageError(ex.Message)
                End Try

            End Using
        ElseIf name_radio.Checked = True Then

            Using sqlcommand As New MySqlCommand()
                Dim dataAdapter As New MySqlDataAdapter
                Dim dataTable As New DataTable

                With sqlcommand
                    .CommandText = "SELECT ID, FirstName,LastName, College, Program FROM accounts"
                    .Connection = SQLString
                End With

                Try
                    dataAdapter.SelectCommand = sqlcommand
                    dataTable.Clear()
                    dataAdapter.Fill(dataTable)

                    For Each row As DataRow In dataTable.Rows
                        row(1) = row(1) & " " & row(2)
                    Next
                    dataTable.Columns.RemoveAt(2)
                    register_table.DataSource = dataTable
                Catch ex As Exception

                End Try

                Dim view As New DataView(dataTable)
                Dim source As New BindingSource

                source.DataSource = view
                register_table.DataSource = source
                source.Filter = String.Format("FirstName like '*" & Search_account.Text & "*'", Me.Search_account.Text)

            End Using

        End If
    End Sub

    Private Sub register_table_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles register_table.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If e.RowIndex >= 0 Then
                register_table.CurrentCell = register_table.Rows(e.RowIndex).Cells(0)
                Me.GunaContextMenuStrip1.Show(Me.register_table, Me.register_table.PointToClient(Cursor.Position))
            End If
        End If
    End Sub

    Private Sub register_table_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles register_table.CellDoubleClick
        Dim accountmupdate As New registerupdate
        Dim selectedRow As DataGridViewRow
        If e.RowIndex >= 0 Then
            selectedRow = register_table.Rows(e.RowIndex)
            selectedAcct = selectedRow.Cells(0).Value.ToString
            accountmupdate.ShowDialog()
        End If
    End Sub

    Private Sub Search_account_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Search_account.KeyPress
        If Id_radio.Checked = True Then
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        ElseIf name_radio.Checked = True Then
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim accountmupdate As New registerupdate
        Dim selectedRow As DataGridViewRow
        selectedRow = register_table.CurrentRow
        selectedAcct = selectedRow.Cells(0).Value.ToString
        Delete_Account.ShowDialog()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim accountmupdate As New registerupdate
        Dim selectedRow As DataGridViewRow
        selectedRow = register_table.CurrentRow
        selectedAcct = selectedRow.Cells(0).Value.ToString
        accountmupdate.ShowDialog()
    End Sub
End Class
