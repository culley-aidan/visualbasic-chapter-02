' Program Name: Latte Selection
' Developer:    Aidan Culley
' Date:         August 26st, 2019
' Purpose:      Displays a welcome screen about the Campus Music Cafe Performance

Public Class frmCampusMusicCafe
    Private Sub BtnDate_Click(sender As Object, e As EventArgs) Handles btnDate.Click
        ' executes with btnDate click
        ' enables lblDate disables lblDetails

        lblDate.Visible = True
        lblDetails.Visible = False
        btnExit.Enabled = True
    End Sub

    Private Sub BtnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        ' executes with btnDetails click
        ' enables lblDetails disables lblDate

        lblDate.Visible = False
        lblDetails.Visible = True
        btnExit.Enabled = True
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' executes with btnExit click
        ' exits the program

        Close()
    End Sub

End Class
