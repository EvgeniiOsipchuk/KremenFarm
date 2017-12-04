Public Class FMain

   
    Private Sub tsKlients_Click(sender As Object, e As EventArgs) Handles tsKlients.Click
        FKlients.ShowDialog()
    End Sub

    Private Sub FMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MsgBox(My.Settings("KremenCnStr"))
        'Globals.Connect()
        LoginForm.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub mi_MedOst_Click(sender As Object, e As EventArgs) Handles mi_MedOst.Click
        FMedOst.ShowDialog()
    End Sub

    Private Sub mi_ImportNorm_Click(sender As Object, e As EventArgs)
        FNorma.ShowDialog()
    End Sub

    Private Sub mi_Medikament_Click(sender As Object, e As EventArgs) Handles mi_Medikament.Click
        FMedikament.ShowDialog()
    End Sub

    Private Sub mi_RepAnaliz_Click(sender As Object, e As EventArgs) Handles mi_RepAnaliz.Click
        FRepAnaliz.ShowDialog()
    End Sub

    Private Sub mi_Dogovor_Click(sender As Object, e As EventArgs) Handles mi_Dogovor.Click
        FDogovor.ShowDialog()
    End Sub

    Private Sub mi_DogovorAdd_Click(sender As Object, e As EventArgs) Handles mi_DogovorAdd.Click
        FDogovorAdd.ShowDialog()
    End Sub

    Private Sub mi_MKB_Click(sender As Object, e As EventArgs) Handles mi_MKB.Click
        FMKB.ShowDialog()
    End Sub

    Private Sub mi_doctors_Click(sender As Object, e As EventArgs) Handles mi_doctors.Click
        FDoctors.ShowDialog()
    End Sub

    Private Sub mi_doctortype_Click(sender As Object, e As EventArgs) Handles mi_doctortype.Click
        FDoctorType.ShowDialog()
    End Sub

    Private Sub mi_OpenNorma_Click(sender As Object, e As EventArgs) Handles mi_OpenNorma.Click
        FOpenNorma.ShowDialog()
    End Sub

    Private Sub mi_Exit_Click(sender As Object, e As EventArgs) Handles mi_Exit.Click
        Me.Close()

    End Sub

    Private Sub mi_ImportNakl_Click(sender As Object, e As EventArgs) Handles mi_ImportNakl.Click
        FNorma.ShowDialog()
    End Sub

    Private Sub mi_svodrep_Click(sender As Object, e As EventArgs) Handles mi_svodrep.Click
        FRepVidacha.ShowDialog()
    End Sub

    Private Sub mi_repvostok_Click(sender As Object, e As EventArgs) Handles mi_repvostok.Click
        FRepVostok.ShowDialog()
    End Sub

    Private Sub СоединениеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СоединениеToolStripMenuItem.Click
        FConnection.ShowDialog()
        'FConnection.Show()
    End Sub
End Class