Imports WindowsApp12.SQLConn
Imports MySql.Data.MySqlClient
Imports WindowsApp12.MainForm
Imports System.Globalization

Public Class Reservation
    Dim suc As New Success
    Dim er As New Error_message

    Private Sub Accepted_Click(sender As Object, e As EventArgs) Handles Accepted.Click

        If monBox.Checked = True Or tuesBox.Checked = True Or wedBox.Checked = True Or
            thuBox.Checked = True Or friBox.Checked = True Or satBox.Checked = True Then
            Try

                Dim tester As Boolean = True
                Dim startTime1 As DateTime = DateTime.Parse(startComBox.SelectedItem.ToString)
                Dim endTime1 As DateTime = DateTime.Parse(endComBox.SelectedItem.ToString)
                Dim startTime2 As DateTime
                Dim endTime2 As DateTime
                Dim start1 As String = startTime1.ToString("HH:mm")
                Dim end1 As String = endTime1.ToString("HH:mm")
                Dim dataAdapter As New MySqlDataAdapter
                Dim dataTable As New DataTable
                Dim sqlcomm As New MySqlCommand

                'Building SQL string for filtering
                Dim stringBuild As New System.Text.StringBuilder("SELECT startTime, endTime FROM schedules WHERE ")

                If monBox.Checked Then
                    If stringBuild.Length = 47 Then
                        stringBuild.Append("Mon = " & monBox.Checked)
                    End If
                End If
                If tuesBox.Checked Then
                    If stringBuild.Length = 47 Then
                        stringBuild.Append("Tue = " & tuesBox.Checked)
                    Else
                        stringBuild.Append(" OR Tue = " & tuesBox.Checked)

                    End If
                End If
                If wedBox.Checked Then
                    If stringBuild.Length = 47 Then
                        stringBuild.Append("Wed = " & wedBox.Checked)
                    Else
                        stringBuild.Append(" OR Wed = " & wedBox.Checked)
                    End If
                End If
                If thuBox.Checked Then
                    If stringBuild.Length = 47 Then
                        stringBuild.Append("Thu = " & thuBox.Checked)
                    Else
                        stringBuild.Append(" OR Thu = " & thuBox.Checked)
                    End If
                End If
                If friBox.Checked Then
                    If stringBuild.Length = 47 Then
                        stringBuild.Append("Fri = " & friBox.Checked)
                    Else
                        stringBuild.Append(" OR Fri = " & friBox.Checked)
                    End If
                End If
                If satBox.Checked Then
                    If stringBuild.Length = 47 Then
                        stringBuild.Append("Sat = " & satBox.Checked)
                    Else
                        stringBuild.Append(" OR Sat = " & satBox.Checked)
                    End If
                End If

                'Executing SQL Command for Filtering
                With sqlcomm
                    .CommandText = stringBuild.ToString
                    .Connection = SQLString
                End With

                Try
                    dataAdapter.SelectCommand = sqlcomm
                    dataTable.Clear()
                    dataAdapter.Fill(dataTable)
                Catch ex As Exception
                    er.messageERROR(ex.Message)
                End Try

                'Scan per row
                If endTime1 > startTime1 Then
                    For Each row As DataRow In dataTable.Rows
                        startTime2 = DateTime.Parse(row("startTime"))
                        endTime2 = DateTime.Parse(row("endTime"))
                        If startTime1 < endTime2 And startTime2 < endTime1 Then
                            tester = False
                            Exit For
                        End If
                    Next
                Else
                    tester = False
                End If

                'Apply Insert command
                If codeBox.Text = String.Empty Then
                    er.messageERROR("Fill up blanks!")
                ElseIf tester = True Then
                    Using sqlcommand As New MySqlCommand()
                        With sqlcommand
                            .CommandText = "INSERT INTO schedules (Code, Mon, Tue, Wed, Thu, Fri, Sat, startTime, endTime, State) 
                                    values (@code, @mon, @tue, @wed, @thu, @fri, @sat, @start, @end, @state)"
                            .Parameters.AddWithValue("@code", codeBox.Text)
                            .Parameters.AddWithValue("@mon", monBox.Checked)
                            .Parameters.AddWithValue("@tue", tuesBox.Checked)
                            .Parameters.AddWithValue("@wed", wedBox.Checked)
                            .Parameters.AddWithValue("@thu", thuBox.Checked)
                            .Parameters.AddWithValue("@fri", friBox.Checked)
                            .Parameters.AddWithValue("@sat", satBox.Checked)
                            .Parameters.AddWithValue("@start", start1)
                            .Parameters.AddWithValue("@end", end1)
                            .Parameters.AddWithValue("@state", "Sem/Term")
                            .Connection = SQLString
                        End With
                        Try
                            ConnectSQL()
                            sqlcommand.ExecuteNonQuery()
                            suc.messageSuccess("Added Successfully!")
                            codeBox.Text = ""
                            monBox.Checked = False
                            tuesBox.Checked = False
                            wedBox.Checked = False
                            thuBox.Checked = False
                            friBox.Checked = False
                            satBox.Checked = False
                            startComBox.SelectedIndex = -1
                            endComBox.SelectedIndex = -1
                            GunaGradient2Panel2_Click(sender, Nothing)
                        Catch ex As Exception
                            er.messageERROR(ex.Message)
                        End Try
                    End Using
                Else
                    If endTime1 > startTime1 Then

                        er.messageERROR("Time Schedule Occupied!")
                    Else
                        er.messageERROR("One hour minimum required!")
                    End If
                End If
            Catch ex As Exception
                Dim ty As New Error_message
                ty.messageERROR("Invalid!!")
            End Try
        Else
            er.messageERROR("Please select day of week!")
        End If
    End Sub

    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintData(schedules, "SELECT startTime, endTime,Code FROM schedules")
        dateSelect.Value = DateTime.Now
    End Sub

    Private Sub GunaGradient2Panel2_Click(sender As Object, e As EventArgs) Handles GunaGradient2Panel2.Click
        PrintData(schedules, "SELECT startTime, endTime,Code FROM schedules")
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        monBox.Checked = False
        tuesBox.Checked = False
        wedBox.Checked = False
        thuBox.Checked = False
        friBox.Checked = False
        satBox.Checked = False
        startComBox.SelectedIndex = -1
        endComBox.SelectedIndex = -1
        codeBox.Text = ""

    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles full_view.Click
        Try
            Dim full2 As New full_view_sched
            PrintData(full2.full_view, "SELECT Code,startTime, endTime,Mon,Tue,Wed,Thu,Fri,Sat,State FROM schedules")
            full2.Dock = DockStyle.Fill
            MainForm.bodypanel.Controls.Clear()
            MainForm.bodypanel.Controls.Add(full2)

        Catch ex As Exception
            er.messageERROR(ex.Message)
        End Try

    End Sub

    Private Sub codeBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles codeBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub GunaGradientButton4_Click(sender As Object, e As EventArgs) Handles GunaGradientButton4.Click
        Dim errm As New Error_message
        If codeBox2.Text = String.Empty Then
            errm.messageERROR("Invalid!!")
        ElseIf startCombox1.SelectedItem = String.Empty Then
            errm.messageERROR("Invalid!!")
        ElseIf endCombox2.SelectedItem = String.Empty Then
            errm.messageERROR("Invalid!!")
        Else
            Dim tester As Boolean = True
            Dim startTime1 As DateTime = DateTime.Parse(startCombox1.SelectedItem.ToString)
            Dim endTime1 As DateTime = DateTime.Parse(endCombox2.SelectedItem.ToString)
            Dim startTime2 As DateTime
            Dim endTime2 As DateTime
            Dim dateToUse As DateTime
            Dim state As String
            Dim start1 As String = startTime1.ToString("HH:mm")
            Dim end1 As String = endTime1.ToString("HH:mm")
            Dim cult As CultureInfo = New CultureInfo("en-US")
            Dim weekDay = cult.DateTimeFormat.GetAbbreviatedDayName(dateSelect.Value.DayOfWeek)

            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTable As New DataTable
            Dim sqlcomm As New MySqlCommand

            If Not weekDay = "Sun" Then
                With sqlcomm
                    .CommandText = "SELECT startTime, endTime, DateToUse, State FROM schedules WHERE " & weekDay & " = 1"
                    .Connection = SQLString
                End With
                Try
                    dataAdapter.SelectCommand = sqlcomm
                    dataTable.Clear()
                    dataAdapter.Fill(dataTable)
                Catch ex As Exception
                    er.messageError(ex.Message)
                End Try
            End If

            If endTime1 > startTime1 And Not weekDay = "Sun" Then
                For Each row As DataRow In dataTable.Rows
                    startTime2 = DateTime.Parse(row("startTime"))
                    endTime2 = DateTime.Parse(row("endTime"))
                    state = row("State")
                    If state.Equals("Make Up") Then
                        dateToUse = DateTime.Parse(row("DateToUse"))
                        If startTime1 < endTime2 And startTime2 < endTime1 And dateToUse.Equals(dateSelect.Value.Date) Then
                            tester = False
                            Exit For
                        End If
                    Else
                        If startTime1 < endTime2 And startTime2 < endTime1 Then
                            tester = False
                            Exit For
                        End If
                    End If
                Next
            Else
                tester = False
            End If

            If tester = True And Not weekDay = "Sun" And Not String.IsNullOrEmpty(SearchData("ID", "schedules", "Code", codeBox2.Text)) Then
                Using sqlcommand As New MySqlCommand()
                    With sqlcommand
                        .CommandText = "INSERT INTO schedules (Code, startTime, endTime, State, DateToUse, " & weekDay &
                                       ") values (@code, @start, @end, @state, @dtu, @day)"
                        .Parameters.AddWithValue("@code", codeBox2.Text)
                        .Parameters.AddWithValue("@start", start1)
                        .Parameters.AddWithValue("@end", end1)
                        .Parameters.AddWithValue("@state", "Make Up")
                        .Parameters.AddWithValue("@dtu", dateSelect.Value.Date.ToString("yyyy/MM/dd"))
                        .Parameters.AddWithValue("@day", 1)
                        .Connection = SQLString
                    End With
                    Try
                        ConnectSQL()
                        sqlcommand.ExecuteNonQuery()
                        suc.messageSuccess("Added Successfully!")
                        codeBox2.Text = ""
                        startCombox1.SelectedIndex = -1
                        endCombox2.SelectedIndex = -1
                        GunaGradient2Panel2_Click(sender, Nothing)
                    Catch ex As Exception
                        er.messageERROR(ex.Message)
                    End Try
                End Using
            Else
                If weekDay = "Sun" Then
                    er.messageERROR("Laboratory is close during Sunday!")
                ElseIf String.IsNullOrEmpty(SearchData("ID", "schedules", "Code", codeBox2.Text)) Then
                    er.messageERROR("Code must be registered on Sem/Term to use Make Up Class.")
                ElseIf endTime1 > startTime1 Then
                    er.messageERROR("Time Schedule Occupied")
                Else
                    er.messageERROR("One hour minimum required!")
                End If
            End If
        End If
    End Sub

    Private Sub dateSelect_Enter(sender As Object, e As EventArgs) Handles dateSelect.Enter
        dateSelect.MinDate = DateTime.Today.AddDays(0)
    End Sub

    Private Sub GunaGradientButton3_Click(sender As Object, e As EventArgs) Handles GunaGradientButton3.Click
        codeBox2.Text = ""
        startCombox1.SelectedIndex = -1
        endCombox2.SelectedIndex = -1
    End Sub

    Private Sub codeBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles codeBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class
