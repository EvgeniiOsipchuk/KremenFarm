Public Class FKlientKard
    Public Enum e_mode
        NEW_KLIENT = 0
        UPDATE_KLIENT = 1
        NEW_FROM_SPIS = 3
    End Enum

    Public Mode As e_mode

    Private Sub FKlientKard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As New KrDataSetTableAdapters.dt_DogovorTableAdapter
        da.Fill(Kremen.dt_Dogovor)
        da.Dispose()

        cb_dogovor.DataSource = Kremen.dt_Dogovor

        If Mode = e_mode.NEW_KLIENT Then
            edt_inn.Text = ""
            edt_fio.Text = ""
            edt_ceh.Text = ""
            edt_cehname.Text = ""
            edt_tabnum.Text = ""
            edt_paspser.Text = ""
            edt_pasp_num.Text = "0"
            edt_kemvidan.Text = ""
            edt_adr.Text = ""
            edt_schet.Text = ""
            edt_naslfio.Text = ""
            edt_nasladr.Text = ""
            edt_inn.Focus()
        End If
        If Mode = e_mode.NEW_FROM_SPIS Then
            edt_inn.Text = ""
            edt_fio.Text = ""
            edt_ceh.Text = ""
            edt_cehname.Text = ""
            edt_tabnum.Text = ""
            edt_paspser.Text = ""
            edt_pasp_num.Text = "0"
            edt_kemvidan.Text = ""
            edt_adr.Text = ""
            edt_schet.Text = ""
            edt_naslfio.Text = ""
            edt_nasladr.Text = ""
            cb_dogovor.SelectedValue = Globals.ColValueByCurRow(FSpisPred.g_predpr, "dogovor")
            cb_god_strax.SelectedValue = FSpisPred.cb_god_strax.SelectedValue
            edt_inn.Focus()
        End If

        If Mode = e_mode.UPDATE_KLIENT Then
            edt_inn.Text = Globals.ColValueByCurRow(FKlients.g_klients, "inn")
            edt_fio.Text = Globals.ColValueByCurRow(FKlients.g_klients, "fio")
            dt_datrog.Value = Globals.ColValueByCurRow(FKlients.g_klients, "date_birth")
            cb_dogovor.SelectedValue = Globals.ColValueByCurRow(FKlients.g_klients, "dogovor")
            cb_god_strax.SelectedValue = Globals.ColValueByCurRow(FKlients.g_klients, "god_strax")
            dt_dogdate.Value = Globals.ColValueByCurRow(FKlients.g_klients, "date_dog_begin")
            edt_ceh.Text = Globals.ColValueByCurRow(FKlients.g_klients, "ceh")
            edt_cehname.Text = Globals.ColValueByCurRow(FKlients.g_klients, "nazvan")
            edt_tabnum.Text = Globals.ColValueByCurRow(FKlients.g_klients, "tabnum")
            edt_paspser.Text = Globals.ColValueByCurRow(FKlients.g_klients, "paspser")
            edt_pasp_num.Text = Globals.ColValueByCurRow(FKlients.g_klients, "paspnom")
            edt_kemvidan.Text = Globals.ColValueByCurRow(FKlients.g_klients, "kemvidan")
            edt_adr.Text = Globals.ColValueByCurRow(FKlients.g_klients, "address")
            edt_schet.Text = Globals.ColValueByCurRow(FKlients.g_klients, "schet")
            edt_naslfio.Text = Globals.ColValueByCurRow(FKlients.g_klients, "nasled")
            edt_nasladr.Text = Globals.ColValueByCurRow(FKlients.g_klients, "nasladr")
            dt_naslgord.Value = Globals.ColValueByCurRow(FKlients.g_klients, "naslrogd")
            edt_inn.Focus()
        End If
    End Sub

    Private Sub cb_dogovor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_dogovor.SelectedIndexChanged
        If Not Kremen.dt_Dogovor.Rows.Count > 0 Then
            Exit Sub
        End If
        Dim da As New KrDataSetTableAdapters.dt_god_straxTableAdapter
        Dim dr As DataRow() = Kremen.dt_Dogovor.Select("id=" & cb_dogovor.SelectedValue)

        da.Fill(Kremen.dt_god_strax, dr(0).Item("id"), dr(0).Item("predpr_id"))
        da.Dispose()

        cb_god_strax.DataSource = Kremen.dt_god_strax
    End Sub

    Private Sub FKlientKard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Dim status As Integer
        Dim paspnum As Double

        If Trim(edt_inn.Text) = "" Then
            MsgBox("Введите ИНН")
            Exit Sub
        End If
        If Trim(edt_fio.Text) = "" Then
            MsgBox("Введите ФИО")
            Exit Sub
        End If
        If Trim(cb_dogovor.Text) = "" Then
            MsgBox("Выберите договор страхования")
            Exit Sub
        End If
        If Not IsNumeric(edt_pasp_num.Text) Then
            paspnum = 0
        Else
            paspnum = Trim(edt_pasp_num.Text)
        End If

        Dim dr As DataRow() = Kremen.dt_Dogovor.Select("id=" & cb_dogovor.SelectedValue)

        If (Mode = e_mode.NEW_KLIENT) Or (Mode = e_mode.NEW_FROM_SPIS) Then
            cmd.SP_KlientsInsert(Trim(edt_inn.Text), Trim(edt_fio.Text), Trim(edt_ceh.Text), Trim(edt_cehname.Text), Trim(edt_tabnum.Text),
                                 dt_datrog.Value, Trim(edt_paspser.Text), paspnum, dt_paspdate.Value, Trim(edt_kemvidan.Text), Trim(edt_adr.Text), "",
                                 cb_dogovor.SelectedValue, "", Trim(edt_schet.Text), Trim(edt_naslfio.Text), Trim(edt_nasladr.Text),
                                 dt_naslgord.Value, "", 0, 0, 0, 0, dt_dogdate.Value, DateAdd(DateInterval.Month, 1, dt_dogdate.Value),
                                 dr(0).Item("predpr_id"), My.User.Name, status, cb_god_strax.Text)
            If status = 0 Then
                edt_inn.Text = ""
                edt_fio.Text = ""
                edt_ceh.Text = ""
                edt_cehname.Text = ""
                edt_tabnum.Text = ""
                edt_paspser.Text = ""
                edt_pasp_num.Text = "0"
                edt_kemvidan.Text = ""
                edt_adr.Text = ""
                edt_schet.Text = ""
                edt_naslfio.Text = ""
                edt_nasladr.Text = ""
                edt_inn.Focus()
            End If
            'If Mode = e_mode.NEW_FROM_SPIS Then
            '    Me.Close()
            'End If
        Else
            cmd.SP_UpdateKlient(Globals.ColValueByCurRow(FKlients.g_klients, "id"), Trim(edt_fio.Text), Trim(edt_ceh.Text), Trim(edt_cehname.Text), Trim(edt_tabnum.Text),
                                 dt_datrog.Value, Trim(edt_paspser.Text), paspnum, dt_paspdate.Value, Trim(edt_kemvidan.Text), Trim(edt_adr.Text), "",
                                 Trim(edt_schet.Text), Trim(edt_naslfio.Text), Trim(edt_nasladr.Text), dt_naslgord.Value, dr(0).Item("predpr_id"), cb_dogovor.SelectedValue, Trim(cb_god_strax.Text),
                                 dt_dogdate.Value, DateAdd(DateInterval.Month, 1, dt_dogdate.Value))
            MsgBox("Изменения сохранены")
        End If


    End Sub

    Private Sub btn_CLose_Click(sender As Object, e As EventArgs) Handles btn_CLose.Click
        Me.Close()
    End Sub
End Class