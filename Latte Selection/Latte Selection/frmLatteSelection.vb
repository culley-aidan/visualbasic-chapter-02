' Program Name: Latte Selection
' Developer:    Aidan Culley
' Date:         August 21st, 2019
' Purpose:      This application allows the user to select between two lattes


Public Class frmLatteSelection

    Private Sub BtnPumpkin_Click(sender As Object, e As EventArgs) Handles btnPumpkin.Click
        ' This code executes when the Pumpkin Spice button is clicked, It will display the pumpkin picture,
        ' hide the mocha piture and enables btnSelectLatte

        picPumpkin.Visible = True
        picMocha.Visible = False
        btnSelectLatte.Enabled = True
    End Sub

    Private Sub BtnMocha_Click(sender As Object, e As EventArgs) Handles btnMocha.Click
        ' This code executes when the Mocha button is clicked, displays mocha picture
        ' hides pumpkin picture and enables btnSelectLatte

        picMocha.Visible = True
        picPumpkin.Visible = False
        btnSelectLatte.Enabled = True
    End Sub

    Private Sub BtnSelectLatte_Click(sender As Object, e As EventArgs) Handles btnSelectLatte.Click
        ' This code executes when the Select Latte button is clicked, disables pumpkin and mocha button along
        ' with itself, will also hide the instructions.

        btnPumpkin.Enabled = False
        btnMocha.Enabled = False
        btnSelectLatte.Enabled = False
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
        btnExit.Enabled = True
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This code executes when the Exit Window button is clicked
        ' Exits the program

        Close()
    End Sub

End Class
