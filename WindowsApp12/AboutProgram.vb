Public Class AboutProgram
    Dim x As Integer
    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Me.Close()
    End Sub

    Private Sub AboutProgram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        scrollPanel.Select()
        x = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ''x = scrollPanel.AutoScrollPosition.Y + 1
        scrollPanel.AutoScrollPosition = New Point(0, x)
        'titleLabel.Text = scrollPanel.AutoScrollPosition.ToString
        x = x + 1
    End Sub
End Class