Imports MySql.Data.MySqlClient
Imports WindowsApp12.SQLConn
Imports WindowsApp12.MainForm

Public Class New_Item
    Dim count As Integer
    Dim item_invent As New Inventory
    Dim errs As New Error_message
    Dim suc As New Success
    Private Sub Update_items_Click(sender As Object, e As EventArgs) Handles Update_items.Click

        If itemUpdate.Text = String.Empty Then
            errs.messageERROR("Fill up all blanks!")
        ElseIf total_quantityUpdate.Text = String.Empty Then
            errs.messageERROR("Fill up all blanks!")
            'ElseIf ItemconditionUpdate.SelectedItem = String.Empty Then
            '    errs.messageERROR("Fill up all blanks!")
        Else
            Using sqlcommand As New MySqlCommand()
                With sqlcommand
                    .CommandText = "INSERT INTO inventory (Name, Quantity, Date_added) values (@name, @quantity, @date_added)"
                    .Parameters.AddWithValue("@id", item_invent.selectedItem)
                    .Parameters.AddWithValue("@name", itemUpdate.Text.Trim)
                    .Parameters.AddWithValue("@quantity", total_quantityUpdate.Text.Trim)
                    '.Parameters.AddWithValue("@condition", ItemconditionUpdate.SelectedItem.ToString)
                    .Parameters.AddWithValue("@date_added", date_ItemUpdate.Value.ToString("yyyy-MM-dd"))
                    '.Parameters.AddWithValue("@Date_expire", expire_Item_Update.Value.ToString("yyyy-MM-dd"))
                    .Connection = SQLString
                End With
                Try

                    ConnectSQL()
                    sqlcommand.ExecuteNonQuery()

                    suc.messageSuccess("Added Successfully")
                    MainForm.GunaGradientButton1_Click(MainForm.inventorybutton, EventArgs.Empty)

                    Me.Close()
                Catch ex As Exception
                    errs.messageERROR("Duplicate Item Name")
                End Try
            End Using
        End If
    End Sub

    Private Sub New_Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        itemUpdate.Text = ""
        total_quantityUpdate.Text = ""
        itemUpdate.Select()
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Me.Close()
    End Sub

    Private Sub GunaGradientButton3_MouseCaptureChanged(sender As Object, e As EventArgs) Handles GunaGradientButton3.MouseCaptureChanged
        Dim int As Integer
        Integer.TryParse(total_quantityUpdate.Text, int)
        total_quantityUpdate.Text = (int + 1)
    End Sub

    Private Sub GunaGradientButton2_MouseCaptureChanged(sender As Object, e As EventArgs) Handles GunaGradientButton2.MouseCaptureChanged

        Dim int As Integer = 1

        If total_quantityUpdate.Text = String.Empty Then

        ElseIf total_quantityUpdate.Text < 2 Then

        Else

            Integer.TryParse(total_quantityUpdate.Text, int)
            total_quantityUpdate.Text = int - 1
        End If

    End Sub

    Private Sub total_quantityUpdate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles total_quantityUpdate.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'Private Sub expire_Item_Update_Enter(sender As Object, e As EventArgs)
    '    expire_Item_Update.MinDate = DateTime.Today.AddDays(1)
    'End Sub

End Class