Public Class Form1

    Private Sub btnClaculateAverage_Click(sender As Object, e As EventArgs) Handles btnClaculateAverage.Click
        Dim dblTestScore1, dblTestScore2, dblTestScore3, dblAverage As Double


        Const Num_SCORES As Integer = 3
        Const dblHIGH_SCORE As Double = 95.0

        Try
            dblTestScore1 = CDbl(txtTestScore1.Text)
            dblTestScore2 = CDbl(txtTestScore2.Text)
            dblTestScore3 = CDbl(txtTestScore3.Text)
            dblAverage = (dblTestScore1 + dblTestScore2 + dblTestScore3) / Num_SCORES

            lblAverageScore.Text = dblAverage.ToString("n2")

            'Display the letter grade.
            If dblAverage < 60 Then
                lblGrade.Text = "F"
            ElseIf dblAverage < 70 Then
                lblGrade.Text = "D"
            ElseIf dblAverage < 80 Then
                lblGrade.Text = "C"
            ElseIf dblAverage < 90 Then
                lblGrade.Text = "B"
            ElseIf dblAverage <= 100 Then
                lblGrade.Text = "A"
            Else
                lblGrade.Text = "Invalid Score"
            End If

            ' If the score is high, give the student praise.
            ' Otherwise, give some encouragement.
            If dblAverage > dblHIGH_SCORE Then
                lblMessage.Text = "Congratulations! Great Job!"
            Else
                lblMessage.Text = "Keep trying!"
            End If
        Catch ex As Exception
            lblMessage.Text = "Scores must be numeric"
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTestScore1.Text = ""
        txtTestScore2.Text = ""
        txtTestScore3.Text = ""
        lblAverageScore.Text = ""
        lblMessage.Text = String.Empty
        lblGrade.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
