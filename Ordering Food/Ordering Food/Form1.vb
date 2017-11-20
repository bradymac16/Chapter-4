Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim dblHamBurger As Double = 5.99
        Dim dblCheseeBurger As Double = 6.99
        Dim dblChickenPatty As Double = 6.5
        Dim dblHamandTurkey As Double = 5.99
        Dim dblTomato As Double = 0.5
        Dim dblLettuce As Double = 0.5
        Dim dblMayo As Double = 0.5
        Dim dblJalopeneos As Double = 0.5
        Dim dblFries As Double = 1.99
        Dim dblFriedGreenBeans As Double = 1.99
        Dim dblFrings As Double = 1.99
        Dim Total As Double
        If rdCheseeburger.Checked = True Then
            lblResult.Text = "You selected CheeseBurger"
            Total = dblCheseeBurger + Total
        ElseIf rdChickenPatty.Checked = True Then
            lblResult.Text = "You selected Chicken Patty"
            Total = dblChickenPatty + Total
        ElseIf rdHamburger.Checked = True Then
            lblResult.Text = "You selected Hamburger"
            Total = dblHamburger + Total
        ElseIf RdHamandTurkeySandwhich.Checked = True Then
            lblResult.Text = "You selected ham and turkey"
            Total = dblHamandTurkey + Total
        End If

        If chkTomato.Checked = True Then
            lblResult.Text &= ", and Tomato"
            Total = dblTomato + Total
        End If
        If chkLettuce.Checked = True Then
            lblResult.Text &= ", and Lettuce"
            Total = dblLettuce + Total
        End If
        If chkMayo.Checked = True Then
            lblResult.Text &= ", and Mayo"
            Total = dblMayo + Total
        End If
        If chkJalepenos.Checked = True Then
            lblResult.Text &= ", and Jalepenos"
            Total = dblJalopeneos + Total
        End If

        If rdFries.Checked = True Then
            lblResult.Text &= "MMM Fries"
            Total = dblFries + Total
        ElseIf rdFriedGreenBeans.Checked = True Then
            lblResult.Text &= "MMM Fried Green Beans"
            Total = dblFriedGreenBeans + Total
        ElseIf rdFrings.Checked = True Then
            lblResult.Text &= "MMM Frings"
            Total = dblFrings + Total
        End If
        lblTotal.text = Total.ToString("c")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblResult.Text = ""
        lblTotal.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
