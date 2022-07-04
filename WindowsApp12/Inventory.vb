Imports MySql.Data.MySqlClient
Imports WindowsApp12.SQLConn
Public Class Inventory
    Dim er As New Error_message
    Public Shared selectedItem As String
    Private Sub inventoryItem_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles inventoryItem.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Dim updates As New Update_Item
            Dim selectedRow As DataGridViewRow
            selectedRow = inventoryItem.Rows(e.RowIndex)
            selectedItem = selectedRow.Cells(0).Value.ToString
            Update_Item.ShowDialog()
        End If

    End Sub


    Private Sub GunaTextBox3_TextChanged(sender As Object, e As EventArgs) Handles SearchItem.TextChanged
        If Id_radio.Checked = True Then

            Using sqlcommand As New MySqlCommand()
                Dim dataAdapter As New MySqlDataAdapter
                Dim dataTable As New DataTable

                With sqlcommand
                    .CommandText = "SELECT * FROM inventory "
                    .Connection = SQLString
                End With
                Try
                    dataAdapter.SelectCommand = sqlcommand
                    dataTable.Clear()
                    dataAdapter.Fill(dataTable)
                    inventoryItem.DataSource = dataTable
                Catch ex As Exception
                    er.messageError(ex.Message)
                End Try
                Dim view As New DataView(dataTable)
                Try
                    view.RowFilter = String.Format("Convert(ID,'System.String') Like '%{0}%'", SearchItem.Text)
                    inventoryItem.DataSource = view

                Catch ex As Exception
                    er.messageError(ex.Message)
                End Try
            End Using

        ElseIf name_radio.Checked = True Then

            Using sqlcommand As New MySqlCommand()
                Dim dataAdapter As New MySqlDataAdapter
                Dim dataTable As New DataTable

                With sqlcommand
                    .CommandText = "SELECT * FROM inventory "
                    .Connection = SQLString
                End With

                Try
                    dataAdapter.SelectCommand = sqlcommand
                    dataTable.Clear()
                    dataAdapter.Fill(dataTable)
                    inventoryItem.DataSource = dataTable
                Catch ex As Exception
                End Try
                Dim view As New DataView(dataTable)
                Dim source As New BindingSource

                source.DataSource = view
                inventoryItem.DataSource = source
                source.Filter = String.Format("Name like '*" & SearchItem.Text & "*'", Me.SearchItem.Text)
            End Using

        End If
    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintData(inventoryItem, "SELECT * FROM inventory")
    End Sub

    Private Sub inventoryItem_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles inventoryItem.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If e.RowIndex >= 0 Then
                inventoryItem.CurrentCell = inventoryItem.Rows(e.RowIndex).Cells(0)
                Me.GunaContextMenuStrip1.Show(Me.inventoryItem, Me.inventoryItem.PointToClient(Cursor.Position))
            End If
        End If
    End Sub

    Private Sub SearchItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchItem.KeyPress
        If Id_radio.Checked = True Then
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim invent As New Inventory
        Dim selectedRow As DataGridViewRow
        selectedRow = inventoryItem.CurrentRow
        selectedItem = selectedRow.Cells(0).Value.ToString
        Delete_Item.ShowDialog()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim updates As New Update_Item
        Dim selectedRow As DataGridViewRow
        selectedRow = inventoryItem.CurrentRow
        selectedItem = selectedRow.Cells(0).Value.ToString
        Update_Item.ShowDialog()
    End Sub

End Class
