Public Class FDoctorType

    Private Sub FDoctorType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As New KrDataSetTableAdapters.dt_DoctorTypeTableAdapter
        da.Fill(Kremen.dt_DoctorType)
        da.Dispose()
        g_type.AutoGenerateColumns = False
        g_type.DataSource = Kremen.dt_DoctorType
    End Sub

    Private Sub FDoctorType_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class