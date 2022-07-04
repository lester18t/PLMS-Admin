Imports MySql.Data.MySqlClient
Imports WindowsApp12.SQLConn
Imports WindowsApp12.MainForm
Public Class Delete_Account
    Dim acc As New register_accounts
    Dim suc As New Success
    Private Sub Label7_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Delete_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Using sqlComm As New MySqlCommand
            Dim dataAdapt As New MySqlDataAdapter
            Dim dataset As New DataSet
            Dim result As String = ""
            With sqlComm
                .CommandText = "SELECT * FROM accounts WHERE ID = @id"
                .Parameters.AddWithValue("@id", acc.selectedAcct)
                .Connection = SQLString
            End With
            Try
                dataAdapt.SelectCommand = sqlComm
                dataAdapt.Fill(dataset)
            Catch ex As Exception
            End Try
            delete_label.Text = dataset.Tables(0).Rows(0).Item(1) + " " + dataset.Tables(0).Rows(0).Item(3)
        End Using
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        DeleteData("accounts", "ID", acc.selectedAcct)
        PrintData(acc.register_table, "SELECT ID, FirstName,LastName, College, Program FROM accounts")
        Me.Close()
        suc.messageSuccess("Deleted Successfully!")
        MainForm.GunaGradientButton3_Click(MainForm.subAccount, EventArgs.Empty)
    End Sub



    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Me.Close()
    End Sub

    Private Sub Update_items_Click(sender As Object, e As EventArgs) Handles Update_items.Click
        Me.Close()
    End Sub
End Class