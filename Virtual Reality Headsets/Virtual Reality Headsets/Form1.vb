' Program Name: VR Forward
' Developer:    Aidan Culley
' Date:         August 22, 2019
' Purpose:      Displays an order screen for two types of virtual reality headsets

Public Class frmVRForward
    Private Sub BtnCrown_Click(sender As Object, e As EventArgs) Handles btnCrown.Click
        ' Executes when btnCrown is clicked
        ' Displays crown picture, hides Earbud picture and enables the exit button

        picCrown.Visible = True
        picEarBud.Visible = False
        btnExit.Enabled = True
    End Sub

    Private Sub BtnEarBud_Click(sender As Object, e As EventArgs) Handles btnEarBud.Click
        ' Executes when btnEarBud is clicked
        ' Displays earbud picture, hides crown picture and enables the exit button

        picCrown.Visible = False
        picEarBud.Visible = True
        btnExit.Enabled = True
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Executes when btnExit is clicked
        ' Exits the program

        Close()
    End Sub
End Class
