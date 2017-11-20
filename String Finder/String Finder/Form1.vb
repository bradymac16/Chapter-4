Public Class Form1

  
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim intStartIndex As Integer
        Dim intFoundIndex As Integer

        If IsNumeric(txtStartIndex.Text) Then
            If txtTofind.Text.Length > ) Then
                intStartIndex = CInt(txtStartIndex.Text)
                intFoundIndex = lblString.Text.IndexOf(txtToFind.Text, intStartIndex)
            End If
            If intFoundIndex = -1 Then
                lblResults.Text = "The string was not  found fool"
            Else
                lblResults.Text = "The String was found at Index " & intFoundIndex
            End If
        Else
            MessageBox.Show("Enter a string to search for.")
        End If

        MessageBox.Show("The index must be a number")
    End Sub
End Class
