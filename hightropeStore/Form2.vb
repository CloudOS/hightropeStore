Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub settingsButton2_Click(sender As Object, e As EventArgs) Handles settingsButton2.Click
        Form1.Panel1.Enabled = False
        Form1.Panel1.Visible = False
        Close()
    End Sub
End Class