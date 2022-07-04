Imports MySql.Data.MySqlClient
Imports WindowsApp12.SQLConn
Public Class Delete_Item
    Dim item_del As New Inventory
    Dim suc As New Success
    Private Sub Delete_Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Using sqlComm As New MySqlCommand
            Dim dataAdapt As New MySqlDataAdapter
            Dim dataset As New DataSet
            Dim result As String = ""
            With sqlComm
                .CommandText = "SELECT * FROM inventory WHERE ID = @id"
                .Parameters.AddWithValue("@id", item_del.selectedItem)
                .Connection = SQLString
            End With

            Try
                dataAdapt.SelectCommand = sqlComm
                dataAdapt.Fill(dataset)
            Catch ex As Exception

            End Try

            delete_label.Text = dataset.Tables(0).Rows(0).Item(1)
        End Using
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        DeleteData("inventory", "ID", item_del.selectedItem)

        Me.Close()
        suc.messageSuccess("Deleted Successfully!")
        MainForm.GunaGradientButton1_Click(MainForm.inventorybutton, EventArgs.Empty)
    End Sub

    Private Sub Update_items_Click(sender As Object, e As EventArgs) Handles Update_items.Click
        Me.Close()
    End Sub


    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Me.Close()
    End Sub
End Class