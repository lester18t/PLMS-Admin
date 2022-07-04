Imports System.ComponentModel
Imports System.Globalization
Imports WindowsApp12.SQLConn

Public Class Home
    Public idleTime As New Stopwatch
    Dim er As New Error_message

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles sched_full.Click
        Try
            Dim full2 As New full_view_sched
            PrintData(full2.full_view, "SELECT Code,startTime, endTime,Mon,Tue,Wed,Thu,Fri,Sat,State FROM schedules")
            full2.Dock = DockStyle.Fill
            MainForm.bodypanel.Controls.Clear()
            MainForm.bodypanel.Controls.Add(full2)

            MainForm.reserve_button.BaseColor1 = Color.FromArgb(51, 0, 27)
            MainForm.reserve_button.BaseColor2 = Color.FromArgb(255, 0, 132)

            MainForm.dashboardbutton.BaseColor1 = Color.FromArgb(81, 74, 157)
            MainForm.dashboardbutton.BaseColor2 = Color.Purple

            MainForm.inventorybutton.BaseColor1 = Color.FromArgb(81, 74, 157)
            MainForm.inventorybutton.BaseColor2 = Color.Purple

            MainForm.journal_button.BaseColor1 = Color.FromArgb(81, 74, 157)
            MainForm.journal_button.BaseColor2 = Color.Purple

            MainForm.registerButton.BaseColor1 = Color.FromArgb(81, 74, 157)
            MainForm.registerButton.BaseColor2 = Color.Purple

            MainForm.attendance_button.BaseColor1 = Color.FromArgb(81, 74, 157)
            MainForm.attendance_button.BaseColor2 = Color.Purple

        Catch ex As Exception
            er.messageERROR(ex.Message)
        End Try
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles att_full.Click
        Dim ante As New attendance
        ante.Dock = DockStyle.Fill
        bodyPan.Controls.Clear()
        bodyPan.Controls.Add(ante)

        PrintData(ante.attendance_table, "SELECT No,ID,Name,Time_In,Time_Out FROM attendance")
        MainForm.reserve_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        MainForm.reserve_button.BaseColor2 = Color.Purple

        MainForm.dashboardbutton.BaseColor1 = Color.FromArgb(81, 74, 157)
        MainForm.dashboardbutton.BaseColor2 = Color.Purple

        MainForm.inventorybutton.BaseColor1 = Color.FromArgb(81, 74, 157)
        MainForm.inventorybutton.BaseColor2 = Color.Purple

        MainForm.journal_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        MainForm.journal_button.BaseColor2 = Color.Purple

        MainForm.registerButton.BaseColor1 = Color.FromArgb(81, 74, 157)
        MainForm.registerButton.BaseColor2 = Color.Purple

        MainForm.attendance_button.BaseColor1 = Color.FromArgb(51, 0, 27)
        MainForm.attendance_button.BaseColor2 = Color.FromArgb(255, 0, 132)
    End Sub

    Private Sub GunaGradientButton3_Click(sender As Object, e As EventArgs)
        Dim full1 As New full_view_sched
        Dim full2 As New full_view_sched
        PrintData(full1.full_view, "SELECT Code,startTime, endTime,Mon,Tue,Wed,Thu,Fri,Sat,State FROM schedules")
        full2.Dock = DockStyle.Fill
        MainForm.bodypanel.Controls.Clear()
        MainForm.bodypanel.Controls.Add(full2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim full1 As New full_view_sched
        Dim full2 As New full_view_sched
        PrintData(full1.full_view, "SELECT Code,startTime, endTime,Mon,Tue,Wed,Thu,Fri,Sat,State FROM schedules")
        full2.Dock = DockStyle.Fill
        MainForm.bodypanel.Controls.Clear()
        MainForm.bodypanel.Controls.Add(full2)
    End Sub

    Public Sub refresher_Tick(sender As Object, e As EventArgs) Handles refresher.Tick
        Dim cult As CultureInfo = New CultureInfo("en-US")
        Dim weekDay = cult.DateTimeFormat.GetAbbreviatedDayName(DateTime.Now.DayOfWeek)

        If Not weekDay = "Sun" Then
            PrintData(schedules, "SELECT startTime, endTime, Code FROM schedules WHERE (" & weekDay & " = 1 And TRIM(State) = 'Sem/Term') Or
            (TRIM(DateToUse) = '" & DateTime.Now.ToString("yyyy-MM-dd") & "' And TRIM(State) = 'Make Up')")
            schedules.Sort(schedules.Columns(0), ListSortDirection.Ascending)
        End If

        'If schedules.RowCount > 0 Then
        '    With schedules
        '        .ClearSelection()
        '        .CurrentCell = schedules.Rows(0).Cells(0)
        '        .Rows(0).Selected = True
        '    End With
        'End If

        'Auto move sched base on current time
        Dim homeData As DataTable = schedules.DataSource
        Dim x As Integer

        If schedules.RowCount > 0 Then
            For Each row As DataRowView In homeData.DefaultView
                Dim rowTime1 As DateTime = row(0)
                Dim rowTime2 As DateTime = row(1)
                Dim timeNow As DateTime = DateTime.Now.ToString("HH:mm")
                If timeNow >= rowTime1 And timeNow < rowTime2 Then
                    schedules.Rows(x).Selected = True
                    Exit For
                Else
                    schedules.ClearSelection()
                End If
                x = x + 1
            Next
        End If
        PrintData(attendance_home, "SELECT ID,Time_In,Time_Out FROM attendance")
        PrintData(requested_items, "SELECT UserID, Item_ID, Item_Name, Quantity, DateTime, Status FROM borrowed_item")
    End Sub

    Private Sub Home_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress, bodyPan.KeyPress
        idleTime.Restart()
    End Sub

    Private Sub Home_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, schedules.MouseMove,
        attendance_home.MouseMove, requested_items.MouseMove, sched_full.MouseMove, att_full.MouseMove,
        GunaShadowPanel1.MouseMove, Label1.MouseMove, Label2.MouseMove, Label3.MouseMove

        idleTime.Restart()

    End Sub

    Private Sub idleTimerr_Tick(sender As Object, e As EventArgs) Handles idleTimerr.Tick
        Dim elapsed = idleTime.ElapsedMilliseconds / 1000

        If elapsed <= 5 Then
            refresher.Stop()
            Label4.Visible = False
        Else
            refresher.Start()
            Label4.Visible = True
            Label4.Text = String.Format("Idle for: {0} secs", CInt(elapsed))
        End If
    End Sub

    Private Sub GunaGradientButton1_Click_1(sender As Object, e As EventArgs) 
        Dim main As New MainForm
        main.bodypanel.Controls.clear()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) 
        MainForm.naming.Text = "Hello"
        MainForm.bodypanel.Controls.Clear()
        MsgBox("Hello")
    End Sub
End Class
