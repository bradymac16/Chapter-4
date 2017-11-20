Public Class Form1

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblMessage.Click

    End Sub

    Private Sub btnCheckQualifications_Click(sender As Object, e As EventArgs) Handles btnCheckQualifications.Click
        ' Variables to hold unput data.
        Dim dblSalary As Double
        Dim IntYearsOnJob

        Try
            ' Get the user's input.
            dblSalary = CDbl(txtSalary.Text)
            IntYearsOnJob = CInt(txtYearsOnJob.Text)

            ' determine whether the applicat qualifies 
            ' for the special loan.
            If dblSalary > 30000 Then
                If IntYearsOnJob > 2 Then
                    lblMessage.Text = "The applicant qualifies."
                Else
                    lblMessage.Text = "The applicant does not qualify."
                End If
            Else
                If IntYearsOnJob > 5 Then
                    lblMessage.Text = "The applicant Qualifies."
                Else
                    lblMessage.Text = "The applicant does noy qualify."
                End If
            End If

        Catch ex As Exception
            ' Display an error message.
            lblMessage.Text = "Please enter numeric values."
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSalary.Text = ""
        txtYearsOnJob.Text = ""
        lblMessage.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
