Public Class frmHelp
    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHelp.Text = "Any questions or help, please contact the creator of the app by email." & vbCrLf &
            "jvnguyen92@gmail.com"
    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Me.Close()
    End Sub
End Class