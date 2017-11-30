Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim Intage As Integer

        Try
            Intage = txtAgeInput.Text

            If Intage < 10 Then
                lblResult.Text = "Can you even Read?"
            ElseIf Intage >= 10 And Intage < 14 Then
                lblResult.Text = "There are no words to express how naive you are."
            ElseIf Intage >= 14 And Intage < 18 Then
                lblResult.Text = "You have no clue how the real world works."
            ElseIf Intage >= 18 And Intage < 24 Then
                lblResult.Text = "You wont make it."
            ElseIf Intage >= 24 And Intage < 30 Then
                lblResult.Text = "Try to keep a steady job."
            ElseIf Intage >= 30 And Intage < 40 Then
                lblResult.Text = "You're almost over the hill."
            ElseIf Intage >= 40 And Intage < 60 Then
                lblResult.Text = "You've made it over the hill."
            ElseIf Intage >= 60 Then
                lblResult.Text = "Don't fall, you might need life alert."
            End If
        Catch ex As Exception
            lblMessage.Text = "Enter a numeric Value"
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblMessage.Text = ""
        lblResult.Text = ""
        txtAgeInput.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
