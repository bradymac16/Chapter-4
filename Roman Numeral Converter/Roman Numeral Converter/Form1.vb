Public Class Form1

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        If txtInteger.Text = 1 Then
            lblRomanNumeral.Text = "I"
        ElseIf txtInteger.Text = 2 Then
            lblRomanNumeral.Text = "II"
        ElseIf txtInteger.Text = 3 Then
            lblRomanNumeral.Text = "III"
        ElseIf txtInteger.Text = 4 Then
            lblRomanNumeral.Text = "IV"
        ElseIf txtInteger.Text = 5 Then
            lblRomanNumeral.Text = "V"
        ElseIf txtInteger.Text = 6 Then
            lblRomanNumeral.Text = "VI"
        ElseIf txtInteger.Text = 7 Then
            lblRomanNumeral.Text = "VII"
        ElseIf txtInteger.Text = 8 Then
            lblRomanNumeral.Text = "VIII"
        ElseIf txtInteger.Text = 9 Then
            lblRomanNumeral.Text = "IX"
        ElseIf txtInteger.Text = 10 Then
            lblRomanNumeral.Text = "X"
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInteger.Text = ""
        lblRomanNumeral.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
