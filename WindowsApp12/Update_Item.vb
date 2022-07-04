Imports MySql.Data.MySqlClient
Imports WindowsApp12.SQLConn
Imports WindowsApp12.MainForm
Public Class Update_Item
    Dim count As Integer
    Dim item_invent As New Inventory
    Dim err As Error_message
    Dim suc As New Success
    Dim isvalue As Integer
    Private Sub Update_Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Using sqlComm As New MySqlCommand
            Dim dataAdapt As New MySqlDataAdapter
            Dim dataset As New DataSet
            Dim result As String = ""
            With sqlComm
                .CommandText = "SELECT * FROM inventory WHERE ID = @id"
                .Parameters.AddWithValue("@id", item_invent.selectedItem)
                .Connection = SQLString
            End With
            Try
                dataAdapt.SelectCommand = sqlComm
                dataAdapt.Fill(dataset)
            Catch ex As Exception
            End Try
            itemUpdate.Text = dataset.Tables(0).Rows(0).Item(1)
            total_quantityUpdate.Text = dataset.Tables(0).Rows(0).Item(2)
            'ItemconditionUpdate.Text = dataset.Tables(0).Rows(0).Item(3)

            date_ItemUpdate.Value = dataset.Tables(0).Rows(0).Item(3)
            'expire_Item_Update.Value = dataset.Tables(0).Rows(0).Item(5)
        End Using
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Me.Hide()
    End Sub
    Private Sub total_quantityUpdate_TextChanged(sender As Object, e As EventArgs) Handles total_quantityUpdate.TextChanged
        total_quantityUpdate.BorderColor = Color.FromArgb(151, 51, 238)
    End Sub

    Private Sub itemUpdate_TextChanged(sender As Object, e As EventArgs) Handles itemUpdate.TextChanged
        itemUpdate.BorderColor = Color.FromArgb(151, 51, 238)
    End Sub

    Private Sub ItemconditionUpdate_SelectedIndexChanged(sender As Object, e As EventArgs)
        'ItemconditionUpdate.BorderColor = Color.FromArgb(151, 51, 238)
    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub GunaGradientButton3_MouseCaptureChanged(sender As Object, e As EventArgs) Handles GunaGradientButton3.MouseCaptureChanged
        Dim cons As Integer
        cons = total_quantityUpdate.Text
        cons += 1
        total_quantityUpdate.Text = CStr(cons)
    End Sub

    Private Sub GunaGradientButton2_MouseCaptureChanged(sender As Object, e As EventArgs) Handles GunaGradientButton2.MouseCaptureChanged
        Dim cons As Integer
        cons = total_quantityUpdate.Text
        If cons < 1 Then

        Else

            cons -= 1
            total_quantityUpdate.Text = CStr(cons)
        End If

    End Sub

    Private Sub Update_items_Click(sender As Object, e As EventArgs) Handles Update_items.Click

        If itemUpdate.Text = String.Empty Then
            err.messageERROR("Fill up all blanks!")
        ElseIf total_quantityUpdate.Text = String.Empty Then
            err.messageERROR("Fill up all blanks!")
            'ElseIf ItemconditionUpdate.SelectedItem = String.Empty Then
            '    err.messageERROR("Fill up all blanks!")
        Else
            Using sqlcommand As New MySqlCommand()
                With sqlcommand
                    .CommandText = "UPDATE inventory SET Name = @name, Quantity = @quantity, Date_Added = @added WHERE ID = @id"
                    .Parameters.AddWithValue("@id", item_invent.selectedItem)
                    .Parameters.AddWithValue("@name", itemUpdate.Text.Trim)
                    .Parameters.AddWithValue("@quantity", total_quantityUpdate.Text.Trim)
                    '.Parameters.AddWithValue("@state", ItemconditionUpdate.SelectedItem.ToString)
                    .Parameters.AddWithValue("@added", date_ItemUpdate.Value.ToString("yyyy-MM-dd"))
                    '.Parameters.AddWithValue("@expire", expire_Item_Update.Value.ToString("yyyy-MM-dd"))
                    .Connection = SQLString
                End With
                Try
                    ConnectSQL()
                    sqlcommand.ExecuteNonQuery()
                    suc.messageSuccess("Updated Successfully")
                    MainForm.GunaGradientButton1_Click(MainForm.inventorybutton, EventArgs.Empty)

                    Me.Close()
                Catch ex As Exception
                    err.messageERROR(ex.Message.ToString)
                End Try
            End Using
        End If
    End Sub
    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Me.Close()
    End Sub

    Private Sub total_quantityUpdate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles total_quantityUpdate.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class