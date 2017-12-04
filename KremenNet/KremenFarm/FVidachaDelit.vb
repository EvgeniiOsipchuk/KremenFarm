Public Class FVidachaDelit
    Private med_id As Integer = Globals.ColValueByCurRow(FVidacha.g_med, "id")
    Private curRow As DataRow() = Kremen.dt_GetMed.Select("id=" & med_id)
    Private check_kolvo As Integer = curRow(0)("kolvo")
    Private check_price As Double = curRow(0)("price")

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Dispose()
    End Sub

    Private Sub FVidachaDelit_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub FVidachaDelit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_medname.Text = curRow(0)("medname")
        lbl_ostorig.Text = ""
        lbl_newtovar.Text = ""
        lbl_price.Text = ""
    End Sub

    Private Sub btn_prover_Click(sender As Object, e As EventArgs) Handles btn_prover.Click
        lbl_ostorig.Text = check_kolvo - 1
        lbl_newtovar.Text = edt_delit.Text
        lbl_price.Text = Math.Round(check_price / Val(edt_delit.Text), 2)
    End Sub

    Private Sub btn_delit_Click(sender As Object, e As EventArgs) Handles btn_delit.Click
        cmd.SP_delit(med_id, Math.Round(check_price / Val(edt_delit.Text), 2), edt_delit.Text)
        FVidacha.find_med()
        Me.Dispose()
    End Sub

End Class