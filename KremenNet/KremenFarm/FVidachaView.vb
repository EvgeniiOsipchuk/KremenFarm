Public Class FVidachaView

    Private vid_id As Integer = Globals.ColValueByCurRow(FCase.g_vidach, "id")


    Private Sub FVidachaView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Globals.GetVidachaDetail(vid_id)
        g_vidach.AutoGenerateColumns = False
        g_vidach.DataSource = Kremen.dt_VidachaDetail
    End Sub

    Private Sub FVidachaView_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class