Imports WindowsApp12.SQLConn
Imports MySql.Data.MySqlClient
Public Class full_view_sched

    Dim er As New Error_message
    Dim suc As New Success

    Private Sub full_view_sched_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintData(full_view, "SELECT ID,Code,startTime,endTime,Mon,Tue,Wed,Thu,Fri,Sat,State,DateToUse FROM schedules")
    End Sub


    Private Sub SearchItem_TextChanged(sender As Object, e As EventArgs) Handles SearchItem.TextChanged
        
        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTable As New DataTable

            With sqlcommand
                .CommandText = "SELECT * FROM schedules "
                .Connection = SQLString
            End With

            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTable.Clear()
                dataAdapter.Fill(dataTable)
                dataTable.Columns.RemoveAt(0)
                full_view.DataSource = dataTable
            Catch ex As Exception
                er.messageError(ex.Message)
            End Try

            Dim view As New DataView(dataTable)

            Try
                view.RowFilter = String.Format("Convert(Code,'System.String') Like '%{0}%'", SearchItem.Text)
                full_view.DataSource = view

            Catch ex As Exception
                er.messageError(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub GunaCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles allCheckBox.CheckedChanged

        If allCheckBox.Checked = True Then
            For Each row As DataGridViewRow In full_view.Rows
                row.Cells(0).Value = True
            Next
        Else
            For Each row As DataGridViewRow In full_view.Rows
                row.Cells(0).Value = False
            Next
        End If
    End Sub

    Private Sub save_butt_Click(sender As Object, e As EventArgs) Handles save_butt.Click
        Dim prompt As DialogResult = MessageBox.Show("Do you want to delete selected items?",
                                                     "Delete Selected",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim x As Integer = 0
        If prompt = DialogResult.Yes Then
            For Each row As DataGridViewRow In full_view.Rows
                If row.Cells(0).Value = True Then
                    DeleteData("schedules", "ID", row.Cells(1).Value.ToString)
                    x = x + 1
                End If
            Next
            If x > 0 Then
                suc.messageSuccess("Deleted Successfully!")
            Else
                er.messageERROR("Select items first!")
            End If

        End If

        full_view_sched_Load(sender, e)
    End Sub
End Class
