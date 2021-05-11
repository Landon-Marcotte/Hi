Public Class MainForm
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        StartGame()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetAll()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close the form
        Me.Close()
    End Sub

    Private Sub MainForm_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
End Class
