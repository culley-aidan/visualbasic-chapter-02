Public Class Form1
    Private Sub BtnCrown_MouseClick(sender As Object, e As MouseEventArgs) Handles btnCrown.MouseClick
        btnExit.Visible = True
    End Sub
    Private Sub BtnEarBud_Click(sender As Object, e As EventArgs) Handles btnEarBud.Click
        btnExit.Visible = True
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnExit.Visible = False
    End Sub
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
