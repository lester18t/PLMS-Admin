Imports MySql.Data.MySqlClient
Public Class SQLConn
    Public Shared er As New Error_message
    Public Shared SQLString As New MySqlConnection("Server = " & My.Settings.Server & "; Database = project_lab; Uid = " & My.Settings.User & "; Password = " & My.Settings.Pass & ";")

    Shared Sub ConnectSQL()
        Try
            If Not SQLString.State = ConnectionState.Open Then
                SQLString.Open()
            End If

        Catch ex As Exception
            er.messageERROR(ex.Message)
        End Try
    End Sub


    Shared Sub PrintData(tbl As DataGridView, cmd As String)
        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTable As New DataTable

            With sqlcommand
                .CommandText = cmd
                .Connection = SQLString
            End With

            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTable.Clear()
                dataAdapter.Fill(dataTable)
                tbl.DataSource = dataTable
                tbl.Refresh()
            Catch ex As Exception
                er.messageERROR(ex.Message)
            End Try
        End Using
    End Sub

    Shared Function SearchData(itemToSearch As String, tbl As String, whereToSearch As String, value As String) As String
        Using sqlComm As New MySqlCommand
            Dim dataAdapt As New MySqlDataAdapter
            Dim dataset As New DataSet
            Dim result As String = ""
            With sqlComm
                .CommandText = "SELECT " & itemToSearch & " FROM " & tbl & " WHERE " & whereToSearch & " = " & value
                .Connection = SQLString
            End With

            Try
                dataAdapt.SelectCommand = sqlComm
                dataAdapt.Fill(dataset)
                If dataset.Tables(0).Rows.Count < 1 Then
                    result = ""
                Else
                    result = dataset.Tables(0).Rows(0).Item(0).ToString
                End If
            Catch ex As Exception
                er.messageERROR(ex.Message)
            End Try

            Return result
        End Using
    End Function

    Shared Sub DeleteData(tableName As String, columnName As String, id As String)
        Using sqlcommand As New MySqlCommand()
            With sqlcommand
                .CommandText = "DELETE FROM " & tableName & " WHERE " & columnName & " = @id"
                .Parameters.AddWithValue("@id", id)
                .Connection = SQLString
            End With
            Try
                sqlcommand.ExecuteNonQuery()
            Catch ex As Exception
                er.messageERROR(ex.Message)
            End Try
        End Using
    End Sub

    Shared Sub PrintAccount()
        Dim reg As New register_accounts
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
                reg.register_table.DataSource = dataTable

            Catch ex As Exception
                er.messageERROR(ex.Message)
            End Try
        End Using
    End Sub

    Shared Sub PrintItem(tbl As DataGridView, itemToDisplay As String, tableName As String, Optional condition As String = "1")
        Dim er As New Error_message
        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTable As New DataTable
            With sqlcommand
                .CommandText = "SELECT " & itemToDisplay & " FROM " & tableName & " WHERE " & condition
                .Connection = SQLString
            End With

            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTable.Clear()
                dataAdapter.Fill(dataTable)
                tbl.DataSource = dataTable
                tbl.Refresh()
            Catch ex As Exception
                er.messageError(ex.Message)
            End Try
        End Using
    End Sub

End Class
