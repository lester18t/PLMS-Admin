Imports WindowsApp12.SQLConn
Imports MySql.Data.MySqlClient
Public Class request_Item
    Dim accept As New Success
    Dim er As New Error_message
    Dim retr As New Success
    Private Sub GunaComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles categoryComBox.SelectedIndexChanged
        If categoryComBox.SelectedItem = "All" Then
            PrintItem(borrowTbl, " ID, UserID, Item_ID, Item_Name, Quantity, DateTime, Status ", "borrowed_item")
        Else
            PrintItem(borrowTbl, " ID, UserID, Item_ID, Item_Name, Quantity, DateTime, Status", "borrowed_item", "TRIM(Status) = '" & categoryComBox.SelectedItem & "'")
        End If
    End Sub



    Private Sub GunaGradientButton3_Click(sender As Object, e As EventArgs) Handles Accepted.Click

        For Each row As DataGridViewRow In borrowTbl.Rows
            If row.Cells(0).Value = True Then
                If row.Cells(7).Value.ToString = "Pending" Then
                    Using sqlcommand As New MySqlCommand()
                        With sqlcommand
                            .CommandText = "UPDATE borrowed_item SET Status = @stat WHERE ID = @id"
                            .Parameters.AddWithValue("@stat", "Accepted")
                            .Parameters.AddWithValue("@id", row.Cells(1).Value.ToString)
                            .Connection = SQLString
                        End With
                        Try
                            ConnectSQL()
                            sqlcommand.ExecuteNonQuery()
                            accept.messageSuccess("Reservation Accepted")
                            GunaComboBox1_SelectedIndexChanged(sender, e)
                            allCheckBox.Checked = False
                        Catch ex As Exception
                            er.messageERROR(ex.Message)
                        End Try
                    End Using
                Else
                    er.messageERROR("Only PENDING request can be Accepted!")
                    allCheckBox.Checked = False
                End If
            End If
        Next
    End Sub



    Private Sub request_Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        categoryComBox.SelectedIndex = 0
        GunaComboBox1_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub allCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles allCheckBox.CheckedChanged
        If allCheckBox.Checked Then
            For Each row As DataGridViewRow In borrowTbl.Rows
                row.Cells(0).Value = True
            Next
        Else
            For Each row As DataGridViewRow In borrowTbl.Rows
                row.Cells(0).Value = False
            Next

        End If
    End Sub


    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles Deny.Click
        For Each row As DataGridViewRow In borrowTbl.Rows

            If row.Cells(0).Value = True Then
                If row.Cells(7).Value.ToString = "Pending" Then
                    Dim sqlcommand2 As New MySqlCommand
                    Dim newQty As Integer = SearchData("Quantity", "inventory", "ID", row.Cells(3).Value) + row.Cells(5).Value
                    With sqlcommand2
                        .CommandText = "UPDATE inventory SET Quantity = @qty WHERE ID = @id"
                        .Parameters.AddWithValue("@qty", newQty)
                        .Parameters.AddWithValue("@id", row.Cells(3).Value)
                        .Connection = SQLString
                    End With
                    Try
                        ConnectSQL()
                        sqlcommand2.ExecuteNonQuery()
                        DeleteData("borrowed_item", "ID", row.Cells(1).Value)
                        GunaComboBox1_SelectedIndexChanged(sender, e)
                        allCheckBox.Checked = False
                        accept.messageSuccess("Item Denied!")
                    Catch ex As Exception

                    End Try
                Else
                    er.messageERROR("Only PENDING request can be declined!")
                    allCheckBox.Checked = False
                End If
            End If
        Next

    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles Returned_item.Click
        For Each row As DataGridViewRow In borrowTbl.Rows

            If row.Cells(0).Value Then
                If row.Cells(7).Value.ToString.Equals("Accepted") Then
                    Dim sqlcommand1 As New MySqlCommand
                    Dim sqlcommand2 As New MySqlCommand
                    Dim newQty As Integer = SearchData("Quantity", "inventory", "ID", row.Cells(3).Value) + row.Cells(5).Value
                    With sqlcommand1
                        .CommandText = "UPDATE borrowed_item SET Status = @stat WHERE ID = @id"
                        .Parameters.AddWithValue("@stat", "Returned")
                        .Parameters.AddWithValue("@id", row.Cells(1).Value.ToString)
                        .Connection = SQLString
                    End With
                    With sqlcommand2
                        .CommandText = "UPDATE inventory SET Quantity = @qty WHERE ID = @id"
                        .Parameters.AddWithValue("@qty", newQty)
                        .Parameters.AddWithValue("@id", row.Cells(3).Value)
                        .Connection = SQLString
                    End With
                    Try

                        ConnectSQL()
                        sqlcommand1.ExecuteNonQuery()
                        sqlcommand2.ExecuteNonQuery()
                        retr.messageSuccess("Returned Successfully!")
                        GunaComboBox1_SelectedIndexChanged(sender, e)
                        allCheckBox.Checked = False
                    Catch ex As Exception
                        er.messageERROR(ex.Message)
                    End Try
                Else
                    allCheckBox.Checked = False
                    er.messageERROR("Only ACCEPTED item can be returned!")
                End If
            End If
        Next
    End Sub

    Private Sub GunaTextBox3_TextChanged(sender As Object, e As EventArgs) Handles search_req.TextChanged
        If Id_radio.Checked = True Then
            Using sqlcommand As New MySqlCommand()
                Dim dataAdapter As New MySqlDataAdapter
                Dim dataTable As New DataTable

                With sqlcommand
                    .CommandText = "SELECT * FROM borrowed_item "
                    .Connection = SQLString
                End With
                Try
                    dataAdapter.SelectCommand = sqlcommand
                    dataTable.Clear()
                    dataAdapter.Fill(dataTable)
                    borrowTbl.DataSource = dataTable
                Catch ex As Exception
                    er.messageError(ex.Message)
                End Try
                Dim view As New DataView(dataTable)
                Try
                    view.RowFilter = String.Format("Convert(UserID,'System.String') Like '%{0}%'", search_req.Text)
                    borrowTbl.DataSource = view
                Catch ex As Exception
                    er.messageError(ex.Message)
                End Try
            End Using

        ElseIf name_radio.Checked = True Then

            Using sqlcommand As New MySqlCommand()
                Dim dataAdapter As New MySqlDataAdapter
                Dim dataTable As New DataTable

                With sqlcommand
                    .CommandText = "SELECT * FROM borrowed_item "
                    .Connection = SQLString
                End With

                Try
                    dataAdapter.SelectCommand = sqlcommand
                    dataTable.Clear()
                    dataAdapter.Fill(dataTable)
                    borrowTbl.DataSource = dataTable
                Catch ex As Exception

                End Try

                Dim view As New DataView(dataTable)
                Dim source As New BindingSource

                source.DataSource = view
                borrowTbl.DataSource = source
                source.Filter = String.Format("Item_Name like '*" & search_req.Text & "*'", Me.search_req.Text)
            End Using

        End If


    End Sub




    Private Sub search_req_KeyPress(sender As Object, e As KeyPressEventArgs) Handles search_req.KeyPress
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
End Class
