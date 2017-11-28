Public Class Form1



    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strInput As String ' Hold selected from list

        If listColor.SelectedIndex = -1 Then
            ' No color selected
            MessageBox.Show("please select a color.")

        ElseIf listEst.SelectedIndex = -1 Then
            ' No word ending in est
            MessageBox.Show("No word ending in est.")

        ElseIf listNumber.SelectedIndex = -1 Then
            ' No number was selected
            MessageBox.Show("Please select a number.")

        ElseIf listBodyPart.SelectedIndex = -1 Then
            ' No body part was selected
            MessageBox.Show("Please select a body part.")

        ElseIf listAnmial.SelectedIndex = -1 Then
            ' No animal was selected
            MessageBox.Show("Please select a animal.")

        ElseIf listNoun.SelectedIndex = -1 Then
            ' No noun was selected
            MessageBox.Show("Please select a noun.")

        ElseIf listPluralNoun.SelectedIndex = -1 Then
            ' No Plural noun was selected
            MessageBox.Show("Please select a plural noun.")

        Else
            'Get the selected list from above to place into a message box
            strInput = listColor.SelectedItem.ToString() & " Dragon is the " & listEst.SelectedItem.ToString() & " Dragon of all. It has " &
            listNumber.SelectedItem.ToString() & " " & listBodyPart.SelectedItem.ToString() & ", and a(n) " &
            listAnmial.SelectedItem.ToString() & " Shaped like a " & listNoun.SelectedItem.ToString() & ", It loves to eat " &
            listPluralNoun.SelectedItem.ToString()
            MessageBox.Show("The" & strInput & ", although it will feast on nearly anything.")

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        listAnmial.ClearSelected()
        listBodyPart.ClearSelected()
        listColor.ClearSelected()
        listEst.ClearSelected()
        listNoun.ClearSelected()
        listNumber.ClearSelected()
        listPluralNoun.ClearSelected()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
