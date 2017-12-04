Public Class FConnPass
    Private Sub FConnPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       TxtBx_ConnPass.Text = ""
    End Sub

    Private Sub Btn_connPass_Click(sender As Object, e As EventArgs) Handles Btn_connPass.Click
        Close
    End Sub

    Private Sub FConnPass_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If TxtBx_ConnPass.Text <> "11111" Then
            FConnection.Close
        End If
    End Sub
End Class