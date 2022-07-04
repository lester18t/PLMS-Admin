Imports WindowsApp12.login
Imports WindowsApp12.SQLConn
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports System.Environment

Public Class MainForm
    Dim isCollapsed As Boolean = True
    Dim isCollapsed2 As Boolean = True
    Dim isCollapsed3 As Boolean = True
    Dim headername1 As String
    Dim headername2 As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bodypanel.Size = bodypanel.MaximumSize
        shadowpanel.Size = shadowpanel.MaximumSize
        Dim home1 As New Home
        Dim cult As CultureInfo = New CultureInfo("en-US")
        Dim weekDay = cult.DateTimeFormat.GetAbbreviatedDayName(DateTime.Now.DayOfWeek)
        home1.idleTime.Start()

        DropPanel1.Size = DropPanel1.MinimumSize
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(subinventory1, Color.Black, 50, 15, Guna.UI.WinForms.ShadowMode.Dropped)
        Dim invent As New Inventory

        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(subAccount, Color.Black, 50, 15, Guna.UI.WinForms.ShadowMode.Dropped)
        naming.Text = "Welcome  " & SearchData("LastName", "accounts", "ID", activeAccount).ToUpper + ", " + SearchData("FirstName", "accounts", "ID", activeAccount).ToUpper + "!"

        If Not weekDay = "Sun" Then
            PrintData(home1.schedules, "SELECT startTime, endTime, Code FROM schedules WHERE (" & weekDay & " = 1 And TRIM(State) = 'Sem/Term') Or
            (TRIM(DateToUse) = '" & DateTime.Now.ToString("yyyy-MM-dd") & "' And TRIM(State) = 'Make Up')")
            home1.schedules.Sort(home1.schedules.Columns(0), ListSortDirection.Ascending)
        End If

        PrintData(home1.requested_items, "SELECT UserID, Item_ID, Item_Name, Quantity, DateTime, Status FROM borrowed_item")
        PrintData(invent.inventoryItem, "SELECT * FROM inventory")
        PrintData(home1.attendance_home, "SELECT ID,Time_In,Time_Out FROM attendance")

        home1.Dock = DockStyle.Fill
        bodypanel.Controls.Add(home1)

        dashboardbutton.BaseColor1 = Color.FromArgb(51, 0, 27)
        dashboardbutton.BaseColor2 = Color.FromArgb(255, 0, 132)

        reserve_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        reserve_button.BaseColor2 = Color.Purple

        inventorybutton.BaseColor1 = Color.FromArgb(81, 74, 157)
        inventorybutton.BaseColor2 = Color.Purple

        journal_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        journal_button.BaseColor2 = Color.Purple

        registerButton.BaseColor1 = Color.FromArgb(81, 74, 157)
        registerButton.BaseColor2 = Color.Purple

        attendance_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        attendance_button.BaseColor2 = Color.Purple

        'Panel and shadow size


        'Auto move sched base on current time
        Dim homeData As DataTable = home1.schedules.DataSource
        Dim x As Integer

        If home1.schedules.RowCount > 0 Then
            For Each row As DataRowView In homeData.DefaultView
                Dim rowTime1 As DateTime = row(0)
                Dim rowTime2 As DateTime = row(1)
                Dim timeNow As DateTime = DateTime.Now.ToString("HH:mm")
                If timeNow >= rowTime1 And timeNow < rowTime2 Then
                    home1.schedules.ClearSelection()
                    home1.schedules.Rows(x).Selected = True
                    Exit For
                Else
                    home1.schedules.ClearSelection()
                End If
                x = x + 1
            Next
        End If
    End Sub


    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            'Const CS_NOCLOSE As Integer = &H200
            'cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If isCollapsed Then
            inventorybutton.Image = My.Resources.down2
            DropPanel1.Height += 15
            If DropPanel1.Size = DropPanel1.MaximumSize Then
                Timer1.Stop()
                isCollapsed = False
            End If
        Else
            inventorybutton.Image = My.Resources.icons8_chevron_left_80
            DropPanel1.Height -= 15
            If DropPanel1.Size = DropPanel1.MinimumSize Then
                Timer1.Stop()
                isCollapsed = True
            End If
        End If
    End Sub

    Public Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles inventorybutton.Click

        bodypanel.Size = bodypanel.MaximumSize
        shadowpanel.Size = shadowpanel.MaximumSize


        Dim invent As New Inventory
        invent.Dock = DockStyle.Fill
        bodypanel.Controls.Clear()
        bodypanel.Controls.Add(invent)

        PrintData(invent.inventoryItem, "SELECT * FROM inventory")

        reserve_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        reserve_button.BaseColor2 = Color.Purple

        dashboardbutton.BaseColor1 = Color.FromArgb(81, 74, 157)
        dashboardbutton.BaseColor2 = Color.Purple

        inventorybutton.BaseColor1 = Color.FromArgb(51, 0, 27)
        inventorybutton.BaseColor2 = Color.FromArgb(255, 0, 132)

        journal_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        journal_button.BaseColor2 = Color.Purple

        registerButton.BaseColor1 = Color.FromArgb(81, 74, 157)
        registerButton.BaseColor2 = Color.Purple

        attendance_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        attendance_button.BaseColor2 = Color.Purple

    End Sub

    Public Sub journal_Click(sender As Object, e As EventArgs) Handles journal_button.Click

        bodypanel.Size = bodypanel.MinimumSize
        shadowpanel.Size = shadowpanel.MinimumSize
        Dim res As New Journal_view
        res.Dock = DockStyle.Fill
        bodypanel.Controls.Clear()
        bodypanel.Controls.Add(res)

        isCollapsed = False
        isCollapsed3 = False
        Timer1.Start()
        Timer3.Start()

        res.ListBox1.Items.Clear()
        Dim appPath As String = Path.GetDirectoryName(SpecialFolder.ApplicationData)
        Dim savepath As String = appPath & "\Journals\"
        Dim usCulture As CultureInfo = CultureInfo.GetCultureInfo("en-US")
        If Not Directory.Exists(savepath) Then
            Directory.CreateDirectory(savepath)
        End If

        Dim addToList = From f In Directory.EnumerateFiles(savepath)
                        Let fileCreationTime = File.GetCreationTime(f)
                        Order By fileCreationTime
                        Select New ListViewItem(Path.GetFileName(f), f)

        Dim files As List(Of ListViewItem) = addToList.Reverse.ToList()

        For x As Integer = 0 To files.Count - 1
            Dim name As String = files.Item(x).ToString.Replace("ListViewItem: {", "").Replace(".txt}", "").Replace("~", ":")
            res.ListBox1.Items.Add(name)
        Next

        reserve_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        reserve_button.BaseColor2 = Color.Purple

        dashboardbutton.BaseColor1 = Color.FromArgb(81, 74, 157)
        dashboardbutton.BaseColor2 = Color.Purple

        inventorybutton.BaseColor1 = Color.FromArgb(81, 74, 157)
        inventorybutton.BaseColor2 = Color.Purple

        journal_button.BaseColor1 = Color.FromArgb(51, 0, 27)
        journal_button.BaseColor2 = Color.FromArgb(255, 0, 132)

        registerButton.BaseColor1 = Color.FromArgb(81, 74, 157)
        registerButton.BaseColor2 = Color.Purple

        attendance_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        attendance_button.BaseColor2 = Color.Purple
    End Sub

    Private Sub homepanel_Click(sender As Object, e As EventArgs) Handles reserve_button.Click

        bodypanel.Size = bodypanel.MaximumSize
        shadowpanel.Size = shadowpanel.MaximumSize
        Dim reser As New Reservation
        reser.Dock = DockStyle.Fill
        bodypanel.Controls.Clear()
        bodypanel.Controls.Add(reser)
        isCollapsed2 = False
        isCollapsed = False
        isCollapsed3 = False
        Timer1.Start()
        Timer3.Start()

        reserve_button.BaseColor1 = Color.FromArgb(51, 0, 27)
        reserve_button.BaseColor2 = Color.FromArgb(255, 0, 132)

        dashboardbutton.BaseColor1 = Color.FromArgb(81, 74, 157)
        dashboardbutton.BaseColor2 = Color.Purple

        inventorybutton.BaseColor1 = Color.FromArgb(81, 74, 157)
        inventorybutton.BaseColor2 = Color.Purple

        journal_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        journal_button.BaseColor2 = Color.Purple

        registerButton.BaseColor1 = Color.FromArgb(81, 74, 157)
        registerButton.BaseColor2 = Color.Purple

        attendance_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        attendance_button.BaseColor2 = Color.Purple
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If isCollapsed3 Then
            registerButton.Image = My.Resources.down2
            DropRegisterPanel.Height += 15
            If DropRegisterPanel.Size = DropRegisterPanel.MaximumSize Then

                Timer3.Stop()
                isCollapsed3 = False
            End If
        Else
            registerButton.Image = My.Resources.icons8_chevron_left_80
            DropRegisterPanel.Height -= 15
            If DropRegisterPanel.Size = DropRegisterPanel.MinimumSize Then
                Timer3.Stop()
                isCollapsed3 = True
            End If
        End If
    End Sub
    Private Sub dashboardbutton_Click(sender As Object, e As EventArgs) Handles dashboardbutton.Click
        Dim cult As CultureInfo = New CultureInfo("en-US")
        Dim weekDay = cult.DateTimeFormat.GetAbbreviatedDayName(DateTime.Now.DayOfWeek)
        Dim home1 As New Home
        home1.idleTime.Restart()

        If Not weekDay = "Sun" Then
            PrintData(home1.schedules, "SELECT startTime, endTime, Code FROM schedules WHERE (" & weekDay & " = 1 And TRIM(State) = 'Sem/Term') Or
            (TRIM(DateToUse) = '" & DateTime.Now.ToString("yyyy-MM-dd") & "' And TRIM(State) = 'Make Up')")
            home1.schedules.Sort(home1.schedules.Columns(0), ListSortDirection.Ascending)
        End If

        bodypanel.Size = bodypanel.MaximumSize
        shadowpanel.Size = shadowpanel.MaximumSize

        home1.Dock = DockStyle.Fill
        bodypanel.Controls.Clear()
        bodypanel.Controls.Add(home1)
        PrintData(home1.attendance_home, "SELECT ID,Time_In,Time_Out FROM attendance")
        PrintData(home1.requested_items, "SELECT UserID, Item_ID, Item_Name, Quantity, DateTime, Status FROM borrowed_item")
        home1.Show()


        isCollapsed2 = False
        isCollapsed = False
        isCollapsed3 = False
        Timer1.Start()
        Timer3.Start()

        dashboardbutton.BaseColor1 = Color.FromArgb(51, 0, 27)
        dashboardbutton.BaseColor2 = Color.FromArgb(255, 0, 132)

        reserve_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        reserve_button.BaseColor2 = Color.Purple

        inventorybutton.BaseColor1 = Color.FromArgb(81, 74, 157)
        inventorybutton.BaseColor2 = Color.Purple

        journal_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        journal_button.BaseColor2 = Color.Purple

        registerButton.BaseColor1 = Color.FromArgb(81, 74, 157)
        registerButton.BaseColor2 = Color.Purple

        attendance_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        attendance_button.BaseColor2 = Color.Purple

        'Auto move sched base on current time
        Dim homeData As DataTable = home1.schedules.DataSource
        Dim x As Integer
        For Each row As DataRowView In homeData.DefaultView
            Dim rowTime1 As DateTime = row(0)
            Dim rowTime2 As DateTime = row(1)
            Dim timeNow As DateTime = DateTime.Now.ToString("HH:mm")
            If timeNow >= rowTime1 And timeNow < rowTime2 Then
                home1.schedules.ClearSelection()
                home1.schedules.Rows(x).Selected = True
                Exit For
            Else
                home1.schedules.ClearSelection()
            End If
            x = x + 1
        Next

    End Sub

    Private Sub subinventory1_Click(sender As Object, e As EventArgs) Handles subinventory1.Click

        New_Item.ShowDialog()
        bodypanel.Size = bodypanel.MaximumSize
        shadowpanel.Size = shadowpanel.MaximumSize


        Dim invent As New Inventory
        invent.Dock = DockStyle.Fill
        bodypanel.Controls.Clear()
        bodypanel.Controls.Add(invent)

        PrintData(invent.inventoryItem, "SELECT * FROM inventory")

        reserve_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        reserve_button.BaseColor2 = Color.Purple

        dashboardbutton.BaseColor1 = Color.FromArgb(81, 74, 157)
        dashboardbutton.BaseColor2 = Color.Purple

        inventorybutton.BaseColor1 = Color.FromArgb(51, 0, 27)
        inventorybutton.BaseColor2 = Color.FromArgb(255, 0, 132)

        journal_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        journal_button.BaseColor2 = Color.Purple

        registerButton.BaseColor1 = Color.FromArgb(81, 74, 157)
        registerButton.BaseColor2 = Color.Purple

        attendance_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        attendance_button.BaseColor2 = Color.Purple

    End Sub


    Private Sub subinventory2_Click(sender As Object, e As EventArgs) Handles subinventory2.Click

        bodypanel.Size = bodypanel.MaximumSize
        shadowpanel.Size = shadowpanel.MaximumSize
        Dim cat As New request_Item
        cat.Dock = DockStyle.Fill
        bodypanel.Controls.Clear()
        bodypanel.Controls.Add(cat)

    End Sub


    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Public Sub GunaGradientButton3_Click(sender As Object, e As EventArgs) Handles subAccount.Click

        bodypanel.Size = bodypanel.MaximumSize
        shadowpanel.Size = shadowpanel.MaximumSize
        Dim reg As New register_accounts

        reg.Dock = DockStyle.Fill
        bodypanel.Controls.Clear()
        bodypanel.Controls.Add(reg)


        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTable As New DataTable

            With sqlcommand
                .CommandText = "SELECT ID, FirstName,LastName, College, Program FROM accounts"
                .Connection = SQLString
            End With

            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTable.Clear()
                dataAdapter.Fill(dataTable)

                For Each row As DataRow In dataTable.Rows
                    row(1) = row(1) & " " & row(2)
                Next
                dataTable.Columns.RemoveAt(2)
                reg.register_table.DataSource = dataTable

            Catch ex As Exception

            End Try
        End Using

    End Sub

    Private Sub account1_MouseClick(sender As Object, e As MouseEventArgs) Handles umbutton.MouseClick

        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextTop.Show(e.Location())
        End If
    End Sub

    Private Sub add_account_Click_1(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        bodypanel.Size = bodypanel.MaximumSize
        shadowpanel.Size = shadowpanel.MaximumSize
        Dim add_accounts As New add_account
        add_accounts.Dock = DockStyle.Fill
        bodypanel.Controls.Clear()
        bodypanel.Controls.Add(add_accounts)
    End Sub

    Private Sub GunaGradientButton4_Click_2(sender As Object, e As EventArgs) Handles attendance_button.Click
        bodypanel.Size = bodypanel.MaximumSize
        shadowpanel.Size = shadowpanel.MaximumSize
        Dim at As New attendance

        Dim ante As New attendance
        ante.Dock = DockStyle.Fill
        bodypanel.Controls.Clear()
        bodypanel.Controls.Add(ante)
        PrintData(at.attendance_table, "SELECT No,ID,Name,Time_In,Time_Out FROM attendance")
        isCollapsed2 = False
        isCollapsed = False
        isCollapsed3 = False
        Timer1.Start()
        Timer3.Start()

        reserve_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        reserve_button.BaseColor2 = Color.Purple

        dashboardbutton.BaseColor1 = Color.FromArgb(81, 74, 157)
        dashboardbutton.BaseColor2 = Color.Purple

        inventorybutton.BaseColor1 = Color.FromArgb(81, 74, 157)
        inventorybutton.BaseColor2 = Color.Purple

        journal_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        journal_button.BaseColor2 = Color.Purple

        registerButton.BaseColor1 = Color.FromArgb(81, 74, 157)
        registerButton.BaseColor2 = Color.Purple

        attendance_button.BaseColor1 = Color.FromArgb(51, 0, 27)
        attendance_button.BaseColor2 = Color.FromArgb(255, 0, 132)
    End Sub
    Private Sub inventorybutton_MouseClick(sender As Object, e As MouseEventArgs) Handles inventorybutton.MouseClick

        Dim invent As New Inventory
        invent.Dock = DockStyle.Fill
        bodypanel.Controls.Clear()
        bodypanel.Controls.Add(invent)
        isCollapsed2 = False
        isCollapsed3 = False
        Timer1.Start()
        Timer3.Start()

    End Sub

    Public Sub subAccount_MouseClick(sender As Object, e As MouseEventArgs) Handles subAccount.MouseClick

        Dim reg As New register_accounts
        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTable As New DataTable

            With sqlcommand
                .CommandText = "SELECT ID, FirstName,LastName, College, Program FROM accounts"
                .Connection = SQLString
            End With

            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTable.Clear()
                dataAdapter.Fill(dataTable)

                For Each row As DataRow In dataTable.Rows
                    row(1) = row(1) & " " & row(2)
                Next
                dataTable.Columns.RemoveAt(2)
                reg.register_table.DataSource = dataTable

            Catch ex As Exception

            End Try
        End Using
    End Sub

    Private Sub registerButton_MouseClick(sender As Object, e As MouseEventArgs) Handles registerButton.MouseClick

        isCollapsed = False
        isCollapsed2 = False
        Timer1.Start()
        Timer3.Start()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        change_pass.ShowDialog()
    End Sub

    Private Sub umbutton_Click(sender As Object, e As EventArgs) Handles umbutton.Click

        Me.ContextTop.Show(Me.umbutton, Me.umbutton.PointToClient(Cursor.Position))
    End Sub
    Private Sub AboutUsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem1.Click
        db_user.ShowDialog()
    End Sub

    Private Sub registerButton_Click(sender As Object, e As EventArgs) Handles registerButton.Click
        reserve_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        reserve_button.BaseColor2 = Color.Purple

        dashboardbutton.BaseColor1 = Color.FromArgb(81, 74, 157)
        dashboardbutton.BaseColor2 = Color.Purple

        inventorybutton.BaseColor1 = Color.FromArgb(81, 74, 157)
        inventorybutton.BaseColor2 = Color.Purple

        journal_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        journal_button.BaseColor2 = Color.Purple

        registerButton.BaseColor1 = Color.FromArgb(51, 0, 27)
        registerButton.BaseColor2 = Color.FromArgb(255, 0, 132)

        attendance_button.BaseColor1 = Color.FromArgb(81, 74, 157)
        attendance_button.BaseColor2 = Color.Purple

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim full1 As New full_view_sched
        Dim full2 As New full_view_sched
        PrintData(full1.full_view, "SELECT Code,startTime, endTime,Mon,Tue,Wed,Thu,Fri,Sat,State FROM schedules")
        full2.Dock = DockStyle.Fill
        bodypanel.Controls.Clear()
        bodypanel.Controls.Add(full2)
    End Sub



    Private Sub sub4_Click(sender As Object, e As EventArgs)
        bodypanel.Size = bodypanel.MinimumSize
        shadowpanel.Size = shadowpanel.MinimumSize
        Dim res As New Journal_view
        res.Dock = DockStyle.Fill
        bodypanel.Controls.Clear()
        bodypanel.Controls.Add(res)
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem1.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to Logout?", "Logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If dialog = DialogResult.Yes Then
            login.idBox.Text = "Administrator ID"
            login.idBox.ForeColor = Color.DimGray
            login.pwBox.Text = "Password"
            login.pwBox.ForeColor = Color.DimGray
            login.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        Dim dialog As DialogResult = MessageBox.Show("Do you want to close this application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If dialog = DialogResult.Yes Then
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        Dim about As New AboutProgram
        about.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        umbutton_Click(sender, e)
    End Sub

End Class