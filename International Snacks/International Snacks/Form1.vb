' Program Name: International Snacks
' Developer:    Aidan Culley
' Date:         August 26, 2019
' Purpose:      Allows the selection of different international snacks

Public Class frmSnack
    Private Sub BtnBean_Click(sender As Object, e As EventArgs) Handles btnBean.Click
        ' Executes when bean is selected
        ' displays bean image and hides other images

        lblInstructions.Visible = False
        picBean.Visible = True
        picFalafel.Visible = False
        picGreek.Visible = False
        picSpring.Visible = False
        btnConfirm.Visible = True
        btnConfirm.Enabled = True
        lblCInstructions.Visible = True
    End Sub

    Private Sub BtnFalafel_Click(sender As Object, e As EventArgs) Handles btnFalafel.Click
        ' Executes when falafel is selected
        ' displays falafel image and hides other images

        lblInstructions.Visible = False
        picBean.Visible = False
        picFalafel.Visible = True
        picGreek.Visible = False
        picSpring.Visible = False
        btnConfirm.Visible = True
        btnConfirm.Enabled = True
        lblCInstructions.Visible = True
    End Sub

    Private Sub BtnGreek_Click(sender As Object, e As EventArgs) Handles btnGreek.Click
        ' Executes when greek is selected
        ' displays greek image and hides other images

        lblInstructions.Visible = False
        picBean.Visible = False
        picFalafel.Visible = False
        picGreek.Visible = True
        picSpring.Visible = False
        btnConfirm.Visible = True
        btnConfirm.Enabled = True
        lblCInstructions.Visible = True
    End Sub

    Private Sub BtnSpring_Click(sender As Object, e As EventArgs) Handles btnSpring.Click
        ' Executes when spring is selected
        ' displays spring image and hides other images

        lblInstructions.Visible = False
        picBean.Visible = False
        picFalafel.Visible = False
        picGreek.Visible = False
        picSpring.Visible = True
        btnConfirm.Visible = True
        btnConfirm.Enabled = True
        lblCInstructions.Visible = True
    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        ' executes when the user has made a selection
        ' confirms the choice and enables exit button

        btnExit.Visible = True
        btnExit.Enabled = True
        btnBean.Enabled = False
        btnFalafel.Enabled = False
        btnGreek.Enabled = False
        btnSpring.Enabled = False
        btnConfirm.Enabled = False
        lblCInstructions.Visible = False
    End Sub
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Executes when clicked
        ' closes the program
        Close()
    End Sub
End Class
