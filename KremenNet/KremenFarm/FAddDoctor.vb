Public Class FAddDoctor

    Private Sub FAddDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As New KrDataSetTableAdapters.dt_DoctorTypeTableAdapter
        da.Fill(Kremen.dt_DoctorType)
        da.Dispose()

        cb_doctortype.DataSource = Kremen.dt_DoctorType
    End Sub

    Private Sub FAddDoctor_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub btn_add_doctor_Click(sender As Object, e As EventArgs) Handles btn_add_doctor.Click
        If Trim(edt_last_name.Text) = "" Then
            MsgBox("Введите фамилию")
            Exit Sub
        End If
        If Trim(edt_first_name.Text) = "" Then
            MsgBox("Введите имя")
            Exit Sub
        End If
        If Trim(edt_sekond_name.Text) = "" Then
            MsgBox("Введите отчество")
            Exit Sub
        End If
        If Trim(cb_doctortype.Text) = "" Then
            MsgBox("Выберите специальность")
            Exit Sub
        End If

        cmd.AddDoctor(edt_first_name.Text, edt_sekond_name.Text, edt_last_name.Text, cb_doctortype.SelectedValue)

        MsgBox("Врач добавлен в справочник")
        edt_last_name.Text = ""
        edt_first_name.Text = ""
        edt_sekond_name.Text = ""
    End Sub
End Class