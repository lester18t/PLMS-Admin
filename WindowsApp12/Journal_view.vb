Imports WindowsApp12.MainForm
Imports System.IO
Imports System.Text
Imports System.Globalization
Imports WindowsApp12.SQLConn
Imports WindowsApp12.login
Imports System.Environment

Public Class Journal_view
    Public Shared filepath As String
    Public Shared title As String
    Dim er As New Error_message
    Dim suc As New Success
    Dim appPath As String = Path.GetDirectoryName(SpecialFolder.ApplicationData)
    Dim savepath As String = appPath & "\Journals\"
    Dim usCulture As CultureInfo = CultureInfo.GetCultureInfo("en-US")
    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles save_butt.Click
        Dim dayWeek As String = usCulture.DateTimeFormat.AbbreviatedDayNames(DateTime.Now.DayOfWeek)
        Dim monthName As String = usCulture.DateTimeFormat.AbbreviatedMonthNames(DateTime.Now.Month)
        Dim filename As String = dayWeek & " - " & monthName & DateTime.Now.ToString(" dd yyyy - hh~mm tt") & ".txt"
        If Not Directory.Exists(savepath) Then
            Directory.CreateDirectory(savepath)
        End If
        Try
            If Not compose_journal.Text = "Compose New Journal..." Then
                Dim main As New MainForm
                Dim fs As New StreamWriter(savepath + filename)
                fs.Write(compose_journal.Text)
                fs.WriteLine(vbCrLf)
                fs.WriteLine(String.Format("By: {0} {1} {2}", SearchData("FirstName", "accounts", "ID", activeAccount),
                                           SearchData("MiddleName", "accounts", "ID", activeAccount),
                                           SearchData("LastName", "accounts", "ID", activeAccount)))
                fs.WriteLine("Date: " & DateTime.Now.ToString("MMMM dd, yyyy", usCulture))
                fs.WriteLine("Time: " & DateTime.Now.ToString("hh:mm:ss tt", usCulture))
                fs.Close()
                compose_journal.Text = "Compose New Journal..."

                Dim addToList = From f In Directory.EnumerateFiles(savepath)
                                Let fileCreationTime = File.GetCreationTime(f)
                                Order By fileCreationTime
                                Select New ListViewItem(Path.GetFileName(f), f)
                ListBox1.Items.Clear()
                Dim files As List(Of ListViewItem) = addToList.Reverse.ToList()
                For x As Integer = 0 To files.Count - 1
                    Dim name As String = files.Item(x).ToString.Replace("ListViewItem: {", "").Replace(".txt}", "").Replace("~", ":")
                    ListBox1.Items.Add(name)
                Next

                suc.messageSuccess("Saved!")
            Else
                er.messageERROR("Compose text first!")
            End If
        Catch ex As Exception
            er.messageERROR(ex.Message)
        End Try
    End Sub

    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDoubleClick
        If ListBox1.SelectedIndex <> -1 Then
            title = ListBox1.SelectedItem.ToString
            Dim filename As String = ListBox1.SelectedItem.ToString.Replace(":", "~") & ".txt"
            Dim viewer As New MessageViewer
            filepath = savepath + filename
            viewer.ShowDialog()
        End If
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs)
        ListBox1.Items.Clear()

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
            ListBox1.Items.Add(name)
        Next
    End Sub

    Private Sub Search_account_Enter(sender As Object, e As EventArgs) Handles compose_journal.Enter
        GunaShadowPanel2.BaseColor = Color.FromArgb(224, 188, 231)
        compose_journal.ForeColor = Color.Black
        If compose_journal.Text = "Compose New Journal..." Then
            compose_journal.Text = ""
        End If
    End Sub

    Private Sub Search_account_Leave(sender As Object, e As EventArgs) Handles compose_journal.Leave
        GunaShadowPanel2.BaseColor = Color.Purple
        compose_journal.ForeColor = Color.Silver
        If compose_journal.Text.Trim.Length = 0 Then
            compose_journal.Text = "Compose New Journal..."
        End If
    End Sub

    Private Sub ListBox1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles ListBox1.DrawItem
        If e.Index < 0 Then Return

        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            e = New DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State Xor DrawItemState.Selected, e.ForeColor, Color.FromArgb(224, 188, 231))
        End If

        e.DrawBackground()
        e.Graphics.DrawString(ListBox1.Items(e.Index).ToString, e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault)
        e.DrawFocusRectangle()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MainForm.bodypanel.Controls.Clear()
        MainForm.bodypanel.Size = MainForm.bodypanel.MaximumSize
    End Sub
End Class
