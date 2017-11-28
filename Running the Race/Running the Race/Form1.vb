Public Class Form1

    Private Sub btnCalcualteResults_Click(sender As Object, e As EventArgs) Handles btnCalcualteResults.Click
        Dim dblNumber1, dblNumber2, dblNumber3 As Double

        dblNumber1 = txtNumber1.Text
        dblNumber2 = txtNumber2.Text
        dblNumber3 = txtNumber3.Text()

        If dblNumber1 < dblNumber2 And dblNumber1 < dblNumber3 Then
            lblFirst.Text = txtName1.Text
            If dblNumber2 < dblNumber3 Then
                lblSecond.Text = txtName2.Text
                lblThird.Text = txtName3.Text
            ElseIf dblNumber3 < dblNumber2 Then
                lblSecond.Text = txtName3.Text
                lblThird.Text = txtName2.Text
            End If
        End If
        If dblNumber2 < dblNumber1 And dblNumber2 < dblNumber3 Then
            lblFirst.Text = txtName2.Text
            If dblNumber1 < dblNumber3 Then
                lblSecond.Text = txtName1.Text
                lblThird.Text = txtName3.Text
            ElseIf dblNumber3 < dblNumber1 Then
                lblSecond.Text = txtName3.Text
                lblThird.Text = txtName1.Text
            End If
        End If
        If dblNumber3 < dblNumber1 And dblNumber3 < dblNumber2 Then
            lblFirst.Text = txtName3.Text
            If dblNumber2 < dblNumber1 Then
                lblSecond.Text = txtName2.Text
                lblThird.Text = txtName1.Text
            ElseIf dblNumber1 < dblNumber2 Then
                lblSecond.Text = txtName1.Text
                lblThird.Text = txtName2.Text
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblFirst.Text = ""
        lblSecond.Text = ""
        lblThird.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class