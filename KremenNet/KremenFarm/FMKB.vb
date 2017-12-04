Public Class FMKB


    Private Sub g_mkb_DoubleClick(sender As Object, e As EventArgs) Handles g_mkb.DoubleClick

        If Not Kremen.dt_mkb.Rows.Count > 0 Then Exit Sub
        FCase.edt_diag.Text = Globals.ColValueByCurRow(g_mkb, "kod")
        Me.Close()
    End Sub

    Private Sub FMKB_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btn_find_Click(sender As Object, e As EventArgs) Handles btn_find.Click
        Globals.GetMKB(edt_diag.Text)
    End Sub

    Private Sub FMKB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(sender.ToString)

        g_mkb.AutoGenerateColumns = False
        g_mkb.DataSource = Kremen.dt_mkb
    End Sub
End Class