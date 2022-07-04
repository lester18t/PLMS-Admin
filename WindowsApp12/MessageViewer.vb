Imports System.IO
Imports WindowsApp12.Journal_view

Public Class MessageViewer
    Private Sub MessageViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        titleLabel.Text = title
        compose_journal.BackColor = Color.White
        Dim fs As New StreamReader(filepath)
        compose_journal.Text = My.Computer.FileSystem.ReadAllText(filepath)
        fs.Close()
        compose_journal.Select()
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Me.Close()
    End Sub

End Class