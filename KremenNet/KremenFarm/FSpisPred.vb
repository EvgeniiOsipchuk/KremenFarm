Imports System.IO

Public Class FSpisPred
    Private type_search As Integer = 0

    Private Sub ShowPredpr()
        If Not Kremen.dt_Predpr.Rows.Count > 0 Then
            Exit Sub
        End If
        If Not Kremen.dt_god_strax_predpr.Rows.Count > 0 Then
            Exit Sub
        End If
        Dim da As New KrDataSetTableAdapters.SP_GetPredprTableAdapter

        da.Fill(Kremen.SP_GetPredpr, type_search, cb_pred.SelectedValue, cb_god_strax.SelectedValue)
        da.Dispose()
        st_kol.Text = Kremen.SP_GetPredpr.Rows.Count
    End Sub

    Private Sub cb_god_strax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_god_strax.SelectedIndexChanged
        ShowPredpr()
    End Sub


    Private Sub FSpisPred_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rb_strax.Checked = True

        Dim da As New KrDataSetTableAdapters.dt_PredprTableAdapter
        da.Fill(Kremen.dt_Predpr)
        da.Dispose()
        g_predpr.AutoGenerateColumns = False
        cb_pred.DataSource = Kremen.dt_Predpr
        g_predpr.DataSource = Kremen.SP_GetPredpr
        edt_summa_za.Text = "20"
        edt_summa_tr.Text = "10"
        dt_start.Value = New Date(Now.Year, Now.Month, 8)
        dt_end.Value = dt_start.Value.AddMonths(1)
    End Sub

    Private Sub FSpisPred_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub cb_pred_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_pred.SelectedIndexChanged
        If Not Kremen.dt_Predpr.Rows.Count > 0 Then
            Exit Sub
        End If
        Dim da As New KrDataSetTableAdapters.dt_god_strax_predprTableAdapter

        da.Fill(Kremen.dt_god_strax_predpr, cb_pred.SelectedValue)
        da.Dispose()

        cb_god_strax.DataSource = Kremen.dt_god_strax_predpr
        ShowPredpr()
    End Sub

    Private Sub rb_strax_CheckedChanged(sender As Object, e As EventArgs) Handles rb_strax.CheckedChanged
        type_search = 0
        ShowPredpr()
    End Sub

    Private Sub rb_all_CheckedChanged(sender As Object, e As EventArgs) Handles rb_all.CheckedChanged
        type_search = 1
        ShowPredpr()
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Dim DI_day As IO.DirectoryInfo = Nothing
        If Not File.Exists("Setup.ini") Then
            DI_day  = New IO.DirectoryInfo(My.Settings.Spis)
        Else 
            DI_day  = New IO.DirectoryInfo(FConnection.ReadIni("Path", "Path3"))
        End If

        If Not Kremen.SP_GetPredpr.Rows.Count > 0 Then
            Exit Sub
        End If

        Dim wApp As Object = CreateObject("Word.Application")
        wApp.Visible = False

        Dim wDoc As Object = wApp.Documents.Open(Application.StartupPath + "\report\predpr.dot")
        wApp.DisplayAlerts = False

        wDoc.Bookmarks("Predpr").Range.Text = cb_pred.Text
        wDoc.Bookmarks("date_begin").Range.Text = Format(dt_start.Value, "d")
        wDoc.Bookmarks("date_end").Range.Text = Format(dt_end.Value, "d")

        Dim count As Integer = 2
        For Each dr As DataRow In Kremen.SP_GetPredpr.Rows
            wDoc.Tables(1).Rows.Add()
            wDoc.Tables(1).Cell(count, 1).Range.Text = count - 1
            wDoc.Tables(1).Cell(count, 2).Range.Text = dr.Item("fio").ToString
            wDoc.Tables(1).Cell(count, 3).Range.Text = dr.Item("inn").ToString
            count = count + 1
        Next

        If Not DI_day.Exists Then
            DI_day.Create()
        End If
        Try
            wDoc.SaveAs(DI_day.FullName + "\" + cb_pred.Text + ".doc")
            wApp.Visible = True
        Catch
            MsgBox("Невозможно сохранить! Сначала закройте файл " + DI_day.FullName + "\" + cb_pred.Text + ".doc")
            wApp.Quit()
        End Try

    End Sub

    Private Sub Klient_Action(ByVal status As String)
        Dim sel_idx As Integer = g_predpr.CurrentRow.Index
        cmd.UvolKlient(status, Globals.ColValueByCurRow(g_predpr, "id"))
        ShowPredpr()
        g_predpr.Rows(sel_idx).Selected = True
        g_predpr.CurrentCell = g_predpr.Rows(sel_idx).Cells(0)
    End Sub

    Private Sub Btn_Uvol_Click(sender As Object, e As EventArgs) Handles Btn_Uvol.Click
        Klient_Action("УВОЛЕН")
    End Sub

    Private Sub btn_Priem_Click(sender As Object, e As EventArgs) Handles btn_Priem.Click
        Klient_Action("")
    End Sub

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        FKlientKard.Mode = FKlientKard.e_mode.NEW_FROM_SPIS
        FKlientKard.ShowDialog()
        ShowPredpr()
    End Sub

    Private Sub Btn_Plat_Click(sender As Object, e As EventArgs) Handles Btn_Plat.Click
        If MsgBox("Начислить платеж?", vbYesNo) = MsgBoxResult.Yes Then
            If Trim(edt_summa_za.Text) = "" Then
                edt_summa_za.Focus()
                MsgBox("Укажите сумму предприятия!")
                Exit Sub
            End If
            If Trim(edt_summa_tr.Text) = "" Then
                edt_summa_tr.Focus()
                MsgBox("Укажите сумму клиента!")
                Exit Sub
            End If
            cmd.UpdatePlatPredpr(Trim(edt_summa_za.Text), Trim(edt_summa_tr.Text), cb_god_strax.SelectedValue, cb_pred.SelectedValue)
            ShowPredpr()
        End If
    End Sub

    Private Sub btn_print_all_Click(sender As Object, e As EventArgs) Handles btn_print_all.Click
        'Dim DI_day As IO.DirectoryInfo = New IO.DirectoryInfo(My.Settings.Spis)
        Dim DI_day As IO.DirectoryInfo = Nothing
        If Not File.Exists("Setup.ini") Then
            DI_day  = New IO.DirectoryInfo(My.Settings.Spis)
        Else 
            DI_day  = New IO.DirectoryInfo(FConnection.ReadIni("Path", "Path3"))
        End If

        If Not Kremen.dt_Predpr.Rows.Count > 0 Then
            Exit Sub
        End If

        If MsgBox("Будут сформированы все списки (в том числе и неактивных предпритятий) без предварительного просмотра" & vbCrLf &
                  "Вы сможете распечатать их позднее из каталога " & DI_day.FullName, vbYesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        btn_print_all.Text = "Ждите..."

        Dim da As New KrDataSetTableAdapters.dt_god_strax_predprTableAdapter
        Dim dt_god As New KrDataSet.dt_god_strax_predprDataTable
        Dim da1 As New KrDataSetTableAdapters.SP_GetPredprTableAdapter
        Dim dt_predpr As New KrDataSet.SP_GetPredprDataTable

        For Each dr As DataRow In Kremen.dt_Predpr.Rows

            da.Fill(dt_god, dr.Item("id"))
            da.Dispose()

            If Not dt_god.Rows.Count > 0 Then
                Exit Sub
            End If

            da1.Fill(dt_predpr, 0, dr.Item("id"), dt_god(0).Item("god_strax"))
            da1.Dispose()


            Dim wApp As Object = CreateObject("Word.Application")
            wApp.Visible = False

            Dim wDoc As Object = wApp.Documents.Open(Application.StartupPath + "\report\predpr.dot")
            wApp.DisplayAlerts = False

            wDoc.Bookmarks("Predpr").Range.Text = dr.Item("predpr_name")
            wDoc.Bookmarks("date_begin").Range.Text = Format(dt_start.Value, "d")
            wDoc.Bookmarks("date_end").Range.Text = Format(dt_end.Value, "d")

            Dim count As Integer = 2
            For Each dr1 As DataRow In dt_predpr.Rows
                wDoc.Tables(1).Rows.Add()
                wDoc.Tables(1).Cell(count, 1).Range.Text = count - 1
                wDoc.Tables(1).Cell(count, 2).Range.Text = dr1.Item("fio").ToString
                wDoc.Tables(1).Cell(count, 3).Range.Text = dr1.Item("inn").ToString
                count = count + 1
            Next

            If Not DI_day.Exists Then
                DI_day.Create()
            End If
            Try
                wDoc.SaveAs(DI_day.FullName + "\" + dr.Item("predpr_name") + ".doc")
                wDoc.Close()
                wApp.Quit()
            Catch
                MsgBox("Невозможно сохранить! Сначала закройте файл " + DI_day.FullName + "\" + dr.Item("predpr_name") + ".doc")
                wDoc.Close()
                wApp.Quit()

            End Try
            wDoc = Nothing
            wApp = Nothing

        Next
        btn_print_all.Text = "Формировать все"
        FSpisPred_Load(Me, Nothing)
        MsgBox("Сформировано в  " + DI_day.FullName)
    End Sub

    Private Sub btn_updDBF_Click(sender As Object, e As EventArgs) Handles btn_updDBF.Click
        FUpdDBF.ShowDialog()
        cb_pred_SelectedIndexChanged(Me, e)
    End Sub

    Private Sub btn_new_year_Click(sender As Object, e As EventArgs) Handles btn_new_year.Click
        If Not Kremen.SP_GetPredpr.Rows.Count > 0 Then
            Exit Sub
        End If


        If MsgBox("Скопировать всех работающих сотрудников предприятия " & cb_pred.Text & " новый " & cb_god_strax.SelectedValue + 1 & " год ?", vbYesNo) = MsgBoxResult.No Then
            Exit Sub
        End If


        Dim status As Integer
        Dim new_god As Integer = cb_god_strax.SelectedValue + 1

        For Each dr As DataRow In Kremen.SP_GetPredpr.Rows

            Dim inn As String = IIf(IsDBNull(dr("inn")), "", dr("inn"))
            Dim fio As String = IIf(IsDBNull(dr("fio")), "", dr("fio"))
            Dim ceh As String = IIf(IsDBNull(dr("ceh")), "", dr("ceh"))
            Dim nazvan As String = IIf(IsDBNull(dr("nazvan")), "", dr("nazvan"))
            Dim tabnum As String = IIf(IsDBNull(dr("tabnum")), "", dr("tabnum"))
            Dim date_birth As DateTime = IIf(IsDBNull(dr("date_birth")), DateTime.Now, dr("date_birth"))
            Dim paspser As String = IIf(IsDBNull(dr("paspser")), "", dr("paspser"))
            Dim paspnom As Integer = IIf(IsDBNull(dr("paspnom")), 0, dr("paspnom"))
            Dim paspdat As DateTime = IIf(IsDBNull(dr("paspdat")), DateTime.Now, dr("paspdat"))
            Dim kemvidan As String = IIf(IsDBNull(dr("kemvidan")), "", dr("kemvidan"))
            Dim address As String = IIf(IsDBNull(dr("address")), "", dr("address"))
            Dim telefon As String = IIf(IsDBNull(dr("telefon")), "", dr("telefon"))
            Dim dogovor As Integer = dr("dogovor")
            Dim schet As String = IIf(IsDBNull(dr("schet")), "", dr("schet"))
            Dim nasled As String = IIf(IsDBNull(dr("nasled")), "", dr("nasled"))
            Dim nasladr As String = IIf(IsDBNull(dr("nasladr")), "", dr("nasladr"))
            Dim naslrogd As DateTime = IIf(IsDBNull(dr("naslrogd")), DateTime.Now, dr("naslrogd"))
            Dim date_dog_begin As DateTime = dt_start.Value
            Dim date_dog_end As DateTime = dt_end.Value

            cmd.SP_KlientsInsert(inn, fio, ceh, nazvan, tabnum, date_birth, paspser, paspnom, paspdat, kemvidan,
                                 address, telefon, dogovor, "", schet, nasled, nasladr, naslrogd, "", 0, 0, 0, 0, date_dog_begin, date_dog_end,
                                    cb_pred.SelectedValue, My.User.Name, status, new_god)


        Next
        cb_pred_SelectedIndexChanged(Me, e)
        MessageBox.Show("Успешно скопировано")
    End Sub
End Class