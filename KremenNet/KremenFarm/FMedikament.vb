Public Class FMedikament

    Private Sub FMedikament_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g_med.AutoGenerateColumns = False
        g_med.DataSource = Kremen.dt_Medikament.DefaultView
        st_kol.Text = "0"
    End Sub


    Private Sub btn_show_med_Click(sender As Object, e As EventArgs) Handles btn_show_med.Click
        Dim da As New KrDataSetTableAdapters.dt_MedikamentTableAdapter
        da.Fill(Kremen.dt_Medikament)
        da.Dispose()
        st_kol.Text = Format(Kremen.dt_Medikament.Rows.Count, "# ##0")
    End Sub

    Private Sub FMedikament_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Kremen.dt_Medikament.Clear()
        Me.Dispose()

    End Sub
End Class