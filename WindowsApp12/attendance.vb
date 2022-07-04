Imports WindowsApp12.SQLConn
Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class attendance
    Dim en As CultureInfo = CultureInfo.GetCultureInfo("en-US")
    Dim er As New Error_message
    Private Sub attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        PrintData(attendance_table, "SELECT No,ID,Name,Time_In,Time_Out FROM attendance")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        date_lbl.Text = Date.Now.ToString("dddd, MMMM dd, yyyy", en)
        time_lbl.Text = Date.Now.ToString("hh:mm:ss tt", en)
    End Sub

    Private Sub SearchItem_TextChanged(sender As Object, e As EventArgs) Handles SearchItem.TextChanged
        If Id_radio.Checked = True Then


            Using sqlcommand As New MySqlCommand()
                Dim dataAdapter As New MySqlDataAdapter
                Dim dataTable As New DataTable

                With sqlcommand
                    .CommandText = "SELECT * FROM attendance"
                    .Connection = SQLString
                End With

                Try
                    dataAdapter.SelectCommand = sqlcommand
                    dataTable.Clear()
                    dataAdapter.Fill(dataTable)
                    attendance_table.DataSource = dataTable
                Catch ex As Exception
                    er.messageError(ex.Message)
                End Try

                Dim view As New DataView(dataTable)

                Try
                    view.RowFilter = String.Format("Convert(ID,'System.String') Like '%{0}%'", SearchItem.Text)
                    attendance_table.DataSource = view

                Catch ex As Exception
                    er.messageError(ex.Message)
                End Try
            End Using
        ElseIf name_radio.Checked = True Then

            Using sqlcommand As New MySqlCommand()
                Dim dataAdapter As New MySqlDataAdapter
                Dim dataTable As New DataTable

                With sqlcommand
                    .CommandText = "SELECT * FROM attendance"
                    .Connection = SQLString
                End With

                Try
                    dataAdapter.SelectCommand = sqlcommand
                    dataTable.Clear()
                    dataAdapter.Fill(dataTable)
                    attendance_table.DataSource = dataTable
                Catch ex As Exception
                End Try
                Dim view As New DataView(dataTable)
                Dim source As New BindingSource
                source.DataSource = view
                attendance_table.DataSource = source
                source.Filter = String.Format("Name like '*" & SearchItem.Text & "*'", Me.SearchItem.Text)
            End Using


        End If
    End Sub

    Private Sub SearchItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchItem.KeyPress
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
