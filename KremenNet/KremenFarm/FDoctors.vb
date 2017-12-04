Public Class FDoctors

    Private Sub FDoctors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As New KrDataSetTableAdapters.dt_nsi_doctorsTableAdapter
        da.Fill(Kremen.dt_nsi_doctors)
        da.Dispose()
        g_doctors.AutoGenerateColumns = False
        g_doctors.DataSource = Kremen.dt_nsi_doctors
    End Sub

    Private Sub FDoctors_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btn_add_doctor_Click(sender As Object, e As EventArgs) Handles btn_add_doctor.Click
        FAddDoctor.ShowDialog()
    End Sub
End Class