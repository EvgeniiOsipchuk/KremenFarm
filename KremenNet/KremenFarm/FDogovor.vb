Public Class FDogovor

    Private Sub FDogovor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As New KrDataSetTableAdapters.dt_DogovorTableAdapter
        da.Fill(Kremen.dt_Dogovor)
        da.Dispose()
        g_dogovor.AutoGenerateColumns = False
        g_dogovor.DataSource = Kremen.dt_Dogovor
    End Sub

    Private Sub FDogovor_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class