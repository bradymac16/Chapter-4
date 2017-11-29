Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim Intage As Integer

        Try
            Intage = txtAgeInput.Text

            If Intage < 10 Then
                lblResult.Text = "Can you even Read?"
                ElseIf 
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtAgeInput.TextChanged

    End Sub
End Class
