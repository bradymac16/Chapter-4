Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If txtPasscode.Text = "go cubs" Then
            MessageBox.Show("HELLO")
        Else
            MessageBox.Show("TRY AGAIN")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPasscode.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
