Imports WindowsApp12.forgot_pass
Public Class security_code
    Dim er As New Error_message
    Private Sub saveData_Click(sender As Object, e As EventArgs) Handles saveData.Click
        If security_cod.Text = String.Empty Then
            er.messageERROR("Invalid Code")
        ElseIf Not security_cod.Text.Equals(code_red) Then
            er.messageERROR("Invalid Code")
        Else
            reset_pass.Show()
        End If

    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Me.Close()
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Me.Close()
    End Sub

    Private Sub security_code_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub
End Class