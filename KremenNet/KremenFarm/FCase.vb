Imports System.Data.SqlClient

Public Class FCase
   
    Private SaveFlag As Integer = 0

    Enum enum_lech
        AMB = 1
        STAC = 2
        ALLSTAC = 3
        NETRUD = 4
        DEATH = 5
    End Enum

    Public lech As enum_lech
    Public OldSum_ByAllVidach As Decimal

    Private Sub GetLechenie(ByVal typ_lech As Integer)

        Dim da As New KrDataSetTableAdapters.dt_lechenieTableAdapter
        da.Fill(Kremen.dt_lechenie, typ_lech)
        da.Dispose()
        Dim drNewRow As DataRow = Kremen.dt_lechenie.NewRow
        drNewRow.Item("id") = 0
        drNewRow("lechenie") = ""
        drNewRow("limit") = 0
        drNewRow("type_lech") = 0
        Kremen.dt_lechenie.Rows.InsertAt(drNewRow, 0)

    End Sub

    Public Function CheckMoney(Optional ByVal new_vidacha As Boolean = False, Optional ByVal sum_new_vidach As Decimal = 0) As Boolean
        Dim klient_limit As Decimal = Globals.ColValueByCurRow(FKlients.g_klients, "limit")

        Dim new_limit As Decimal = Convert.ToDecimal(DirectCast(cb_lech.SelectedItem, DataRowView).Item("limit").ToString)

        Dim klient_ostatok As Decimal = Convert.ToDecimal(FKlients.st_label_fakt.Text)
        Dim new_food_price As Decimal = Convert.ToDecimal(edt_sumfood.Text)
        Dim new_price As Decimal = Convert.ToDecimal(edt_sum.Text)
        Dim Sum_Vidach As Decimal = Convert.ToDecimal(lbl_vidano.Text)

        Dim old_limit As Decimal = 0
        Dim old_food_price As Decimal = 0
        Dim old_price As Decimal = 0

        Dim raznica_price As Decimal = 0
        Dim raznica_food_price As Decimal = 0
        Dim raznica_vidach As Decimal = 0

        If mode = type_case.EDIT_CASE Then
            old_limit = Kremen.dt_insurcase(0).limit
            old_food_price = Kremen.dt_insurcase(0).food_price
            old_price = Kremen.dt_insurcase(0).total_price
        End If

        If (new_price > old_price) Then
            raznica_price = new_price - old_price
        End If

        If (new_food_price > old_food_price) Then
            raznica_food_price = new_food_price - old_food_price
        End If

        If new_vidacha = True Then
            If (sum_new_vidach > OldSum_ByAllVidach) Then
                raznica_vidach = sum_new_vidach - OldSum_ByAllVidach
            End If
        Else
            If (Sum_Vidach > OldSum_ByAllVidach) Then
                raznica_vidach = Sum_Vidach - OldSum_ByAllVidach
            End If
        End If


        Dim Raznica As Decimal = raznica_price + raznica_food_price + raznica_vidach

        If klient_ostatok < Raznica Then
            CheckMoney = False
        Else
            CheckMoney = True
        End If
    End Function

    Private Sub FCase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_lpu.DataSource = Kremen.dt_lpu
        cb_lech.DataSource = Kremen.dt_lechenie
        cb_doctor.DataSource = Kremen.dt_doctors
        cb_otdel.DataSource = Kremen.dt_otdel
        g_vidach.AutoGenerateColumns = False
        g_vidach.DataSource = Kremen.dt_AllVidachByInsurCase
        st_label_fakt.Text = FKlients.st_label_fakt.Text

        Globals.GetLpu()
        Globals.GetDoctors()
        Globals.GetOtdel()

       

        If mode = type_case.NEW_CASE Then
            rb_amb.Checked = True
            edt_diagtype.Text = "Неопределенный диагноз"
            dt_bolstart.Value = Now
            dt_bolend.Value = Now
            lbl_sumfood.Visible = False
            edt_sumfood.Visible = False
            rb_amb.Checked = True
            lbl_vidano.Text = "0"
            lbl_ost.Text = "0"
            cb_lech.SelectedValue = 0
            cb_doctor.SelectedValue = 0
            cb_otdel.SelectedValue = 0
            edt_diag.Text = ""
            Kremen.dt_AllVidachByInsurCase.Clear()
            OldSum_ByAllVidach = 0
        End If

        If mode = type_case.EDIT_CASE Then
            gl_insurcase_id = Globals.ColValueByCurRow(FInsurCase.g_cases, "id")
            Globals.GetInsurCaseEdit(gl_insurcase_id)
            GetAllVidach()
            OldSum_ByAllVidach = Convert.ToDecimal(lbl_vidano.Text)

            btn_addVidach.Enabled = True
            btn_printvidach.Enabled = True
            btn_delvidach.Enabled = True
            btn_showvid.Enabled = True

            Select Case Kremen.dt_insurcase(0).method
                Case 1 : rb_amb.Checked = True
                Case 2 : rb_stac.Checked = True
                Case 3 : rb_allstac.Checked = True
                Case 4 : rb_netrud.Checked = True
                Case 5 : rb_death.Checked = True
            End Select

            cb_lpu.SelectedValue = Kremen.dt_insurcase(0).lpu_id
            cb_lech.SelectedValue = Kremen.dt_insurcase(0).lechenie_id
            cb_doctor.SelectedValue = Kremen.dt_insurcase(0).doctors_id
            cb_otdel.SelectedValue = Kremen.dt_insurcase(0).otdel_id
            edt_sum.Text = Kremen.dt_insurcase(0).total_price
            edt_sumfood.Text = Kremen.dt_insurcase(0).food_price

            edt_numbol.DataBindings.Add("text", Kremen.dt_insurcase, "bol_num")
            dt_bolstart.DataBindings.Add("text", Kremen.dt_insurcase, "bol_start")
            dt_bolend.DataBindings.Add("text", Kremen.dt_insurcase, "bol_end")
            edt_diag.DataBindings.Add("text", Kremen.dt_insurcase, "kod")

            Select Case Kremen.dt_insurcase(0).bol_close
                Case 0 : c_zakr.Checked = False
                    dt_bolend.Value = dt_bolstart.Value.AddDays(1)
                Case 1 : c_zakr.Checked = True
                    Dim dt1 = New Date(Now.Year, Now.Month, 1).AddMonths(-2)
                    If dt_bolend.Value < dt1 Then
                        btn_addVidach.Enabled = False
                        btn_delvidach.Enabled = False
                        btn_getdiag.Enabled = False
                        Btn_Save.Enabled = False
                    End If
            End Select

        End If

    End Sub

    Private Sub rb_amb_CheckedChanged(sender As Object, e As EventArgs) Handles rb_amb.CheckedChanged
        cb_lech.BeginUpdate()
        lech = enum_lech.AMB
        GetLechenie(lech)
        SetVidachOnly()
        cb_lech.SelectedValue = 0
        cb_lech.EndUpdate()
    End Sub

    Private Sub rb_stac_CheckedChanged(sender As Object, e As EventArgs) Handles rb_stac.CheckedChanged
        cb_lech.BeginUpdate()
        lech = enum_lech.STAC

        GetLechenie(lech)
        SetVidachOnly()
        cb_lech.SelectedValue = 0
        cb_lech.EndUpdate()
    End Sub

    Private Sub rb_allstac_CheckedChanged(sender As Object, e As EventArgs) Handles rb_allstac.CheckedChanged
        cb_lech.BeginUpdate()
        lech = enum_lech.ALLSTAC

        GetLechenie(lech)
        cb_lech.SelectedValue = 0
        cb_lech.EndUpdate()

        lbl_sumfood.Visible = True
        edt_sumfood.Text = "0"
        edt_sumfood.Visible = True

        edt_sum.Text = "0"
        edt_sum.Enabled = True

        If cb_lpu.SelectedIndex = 1 Then cb_lpu.SelectedIndex = 0
        cb_lpu.Enabled = True
    End Sub

    Private Sub rb_netrud_CheckedChanged(sender As Object, e As EventArgs) Handles rb_netrud.CheckedChanged
        cb_lech.BeginUpdate()
        lech = enum_lech.NETRUD
        GetLechenie(lech)
        SetViplatOnly()
        cb_lech.SelectedValue = 0
        cb_lech.EndUpdate()
    End Sub

    Private Sub rb_death_CheckedChanged(sender As Object, e As EventArgs) Handles rb_death.CheckedChanged
        cb_lech.BeginUpdate()
        lech = enum_lech.DEATH
        GetLechenie(lech)
        SetViplatOnly()
        cb_lech.SelectedValue = 0
        cb_lech.EndUpdate()
    End Sub

    Private Sub edt_diag_TextChanged(sender As Object, e As EventArgs) Handles edt_diag.TextChanged
        Globals.GetDiag(edt_diag.Text)
        edt_diagname.Text = Kremen.dt_diag(0).diag 'DataBindings.Add("text", Kremen.dt_diag, "diag")
        edt_diagtype.Text = Kremen.dt_diag(0).type_diag
        ' edt_diagtype.DataBindings.Add("text", Kremen.dt_diag, "type_diag")
    End Sub

    Private Sub cb_lech_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_lech.SelectedIndexChanged
        If Not Kremen.dt_lechenie.Rows.Count > 0 Then
            lbl_limit.Text = "0"
            lbl_msch.Text = "0"
            lbl_ost.Text = "0"
            Exit Sub
        End If


        lbl_limit.Text = Kremen.dt_lechenie(cb_lech.SelectedIndex).limit
        lbl_msch.Text = Math.Round(10 * Val(lbl_limit.Text) / 100, 2)
        lbl_ost.Text = Val(lbl_limit.Text) - Val(lbl_vidano.Text)

        If (cb_lech.Text = "Протезирование зубов") And (lech = enum_lech.AMB) Then
            edt_sum.Text = "0"
            edt_sum.Enabled = True
        Else
            If (lech = enum_lech.ALLSTAC) Or (lech = enum_lech.NETRUD) Or (lech = enum_lech.DEATH) Then
                edt_sum.Enabled = True
            Else
                edt_sum.Enabled = False
            End If
        End If
    End Sub


    Private Sub c_zakr_CheckedChanged(sender As Object, e As EventArgs) Handles c_zakr.CheckedChanged
        dt_bolend.Enabled = Not c_zakr.Checked
    End Sub

    Private Sub cb_lpu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_lpu.SelectedIndexChanged
        Dim lpu_id As Integer = cb_lpu.SelectedValue

        If (lpu_id = 0) Or (lpu_id = 1) Or (lpu_id = 6) Then
            lbl_sumfood.Visible = False
            edt_sumfood.Visible = False
            edt_sumfood.Text = "0"
        Else
            'Сумма на питание вводится только для 
            ' - Больница 8 - скорая
            ' - МСЧ 8
            ' - Больница 7
            ' - Больница 9
            lbl_sumfood.Visible = True
            edt_sumfood.Visible = True
            edt_sumfood.Text = "0"
        End If

    End Sub

    Private Sub btn_addVidach_Click(sender As Object, e As EventArgs) Handles btn_addVidach.Click
        FVidacha.ShowDialog()
        st_label_fakt.Text = Globals.Get_ost
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Dim bolclose As Integer
        Dim Arr = New Object(13) {}
        Dim ArrUpd = New Object(17) {}

        If Trim(edt_diagtype.Text) = "Неопределенный диагноз" Then
            MsgBox("Введите диагноз!")
            edt_diag.Focus()
            Exit Sub
        End If
        If cb_lech.SelectedIndex = 0 Then
            MsgBox("Введите лечение!")
            cb_lech.Focus()
            Exit Sub
        End If
        If cb_lpu.SelectedIndex = 0 Then
            MsgBox("Введите ЛПУ!")
            cb_lpu.Focus()
            Exit Sub
        End If
        If cb_doctor.SelectedIndex = 0 Then
            MsgBox("Введите врача!")
            cb_doctor.Focus()
            Exit Sub
        End If
        If cb_otdel.SelectedIndex = 0 Then
            MsgBox("Введите отделение!")
            cb_otdel.Focus()
            Exit Sub
        End If
        If Not IsNumeric(edt_sum.Text) Then
            MsgBox("Введите правильную сумму!")
            edt_sum.Focus()
            Exit Sub
        End If

        If mode = type_case.NEW_CASE Then

            If c_zakr.Checked Then
                bolclose = 1
            Else : bolclose = 0
            End If


            If SaveFlag = 0 Then
                If Not CheckMoney() Then
                    MsgBox("У клиента недостаточно средств!", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                cmd.SP_InsurCaseInsert(Globals.ColValueByCurRow(FKlients.g_klients, "id"),
                             Kremen.dt_diag(0).id,
                             cb_lech.SelectedValue,
                             cb_doctor.SelectedValue,
                             Trim(edt_numbol.Text),
                             dt_bolstart.Value,
                             bolclose,
                             dt_bolend.Value,
                             cb_lpu.SelectedValue,
                             cb_otdel.SelectedValue,
                             lech,
                             Convert.ToDecimal((Trim(edt_sum.Text))),
                             Convert.ToDecimal((Trim(edt_sumfood.Text))),
                             gl_insurcase_id)
                GetAllVidach()
                btn_addVidach.Enabled = True
                btn_printvidach.Enabled = True
                st_label_fakt.Text = Globals.Get_ost

                If lech = enum_lech.AMB Or lech = enum_lech.STAC Or lech = enum_lech.ALLSTAC Then
                    Dim flag As MsgBoxResult = MsgBox("Будем выдавать медикаменты?", MsgBoxStyle.YesNo)
                    If flag = MsgBoxResult.No Then
                        Me.Dispose()
                    Else
                        FVidacha.ShowDialog()
                        st_label_fakt.Text = Globals.Get_ost
                    End If
                End If
                SaveFlag = 1
            Else
                Me.Dispose()
            End If

        End If

        If mode = type_case.EDIT_CASE Then

            If (lech = enum_lech.NETRUD) Or (lech = enum_lech.DEATH) Then
                If Kremen.dt_AllVidachByInsurCase.Rows.Count > 0 Then
                    MsgBox("Для ""Нетрудоспособность"" и ""Cмерть"" не допускаются выдачи!" & vbNewLine &
                           "Удалите выдачи или выберите ""Амбулаторное"", ""Дневной Стационар"" или ""Круглосуточный стационар""")
                    Exit Sub
                End If
            End If
            If c_zakr.Checked Then
                bolclose = 1
            Else : bolclose = 0
            End If
            If Not CheckMoney() Then
                MsgBox("У клиента недостаточно средств!", MsgBoxStyle.Critical)
                Exit Sub
            End If
            cmd.SP_InsurCaseUpdate(Kremen.dt_insurcase(0).id,
                                   Kremen.dt_diag(0).id,
                                   cb_doctor.SelectedValue,
                                   Trim(edt_numbol.Text),
                                   dt_bolstart.Value,
                                   bolclose,
                                   dt_bolend.Value,
                                   cb_otdel.SelectedValue,
                                   lech,
                                   cb_lech.SelectedValue,
                                   cb_lpu.SelectedValue,
                                   Globals.ColValueByCurRow(FKlients.g_klients, "id"),
                                   Kremen.dt_insurcase(0).method,
                                   Convert.ToDecimal(Trim(edt_sum.Text)),
                                   Kremen.dt_insurcase(0).limit,
                                   Kremen.dt_insurcase(0).food_price,
                                   Convert.ToDecimal(Trim(edt_sumfood.Text)))

            st_label_fakt.Text = Globals.Get_ost
            MsgBox("Изменения сохранены!")

        End If



    End Sub

    Public Sub GetAllVidach()
        Dim sumObject As Object

        Globals.GetAllVidachByInsurCase(gl_insurcase_id)

        Try
            sumObject = Math.Round(Kremen.dt_AllVidachByInsurCase.Compute("Sum(total_price)", ""), 2)
            lbl_vidano.Text = sumObject.ToString
            lbl_ost.Text = Val(lbl_limit.Text) - Val(lbl_vidano.Text)
        Catch
            sumObject = Nothing
            lbl_vidano.Text = "0"
            lbl_ost.Text = "0"
        End Try

    End Sub

    Private Sub btn_printvidach_Click(sender As Object, e As EventArgs) Handles btn_printvidach.Click
        If Kremen.dt_AllVidachByInsurCase.Rows.Count > 0 Then
            btn_printvidach.Text = "Ждите..."
            btn_printvidach.Refresh()
            Dim sel_idx As Integer = g_vidach.CurrentRow.Index
            PrintVidach()
            g_vidach.Rows(sel_idx).Selected = True
            g_vidach.CurrentCell = g_vidach.Rows(sel_idx).Cells(0)
            btn_printvidach.Text = "Печать"
        End If
    End Sub

    Private Sub FCase_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Public Sub PrintVidach()

        Dim vid_id As Integer = Globals.ColValueByCurRow(g_vidach, "id")
        Dim VidachTotal As DataRow() = Kremen.dt_AllVidachByInsurCase.Select("id=" & vid_id)
        Dim kol_nakl As Integer
        Dim total_price As Decimal

        Globals.GetVidachaDetail(vid_id)

        'Узнаем сколько печатать накладных
        kol_nakl = Kremen.dt_VidachaDetail(0).kol_nakl
        'Запоминаем в массив попавшиеся значения apteka_id
        Dim apteka() As Integer
        ReDim apteka(kol_nakl - 1)

        Dim jj As Integer = 0
        apteka(jj) = Kremen.dt_VidachaDetail(0).apteka_id

        For i As Integer = 0 To Kremen.dt_VidachaDetail.Rows.Count - 1
            If Kremen.dt_VidachaDetail(i).apteka_id = apteka(jj) Then
                Continue For
            Else
                jj = jj + 1
                apteka(jj) = Kremen.dt_VidachaDetail(i).apteka_id
            End If
           
        Next


        For Each apteka_idx In apteka

            Dim wApp As Object = CreateObject("Word.Application")
            Dim wDoc As Object = wApp.Documents.Open(Application.StartupPath + "\report\nakl.dot")


            wDoc.Bookmarks("treb_nom").Range.Text = VidachTotal(0).Item("id")
            wDoc.Bookmarks("treb_date").Range.Text = VidachTotal(0).Item("date_enter")
            wDoc.Bookmarks("fio").Range.Text = Globals.ColValueByCurRow(FKlients.g_klients, "fio")
            wDoc.Bookmarks("inn").Range.Text = Globals.ColValueByCurRow(FKlients.g_klients, "inn")
            wDoc.Bookmarks("ceh").Range.Text = Globals.ColValueByCurRow(FKlients.g_klients, "ceh")
            wDoc.Bookmarks("tabnum").Range.Text = Globals.ColValueByCurRow(FKlients.g_klients, "tabnum")
            wDoc.Bookmarks("diag").Range.Text = edt_diagname.Text
            wDoc.Bookmarks("doctor").Range.Text = cb_doctor.Text
            wDoc.Bookmarks("date_begin").Range.Text = dt_bolstart.Value
            Dim foundRows() As DataRow = Kremen.dt_VidachaDetail.Select("apteka_id=" + apteka_idx.ToString)
            wDoc.Bookmarks("apteka_treb").Range.Text = foundRows(0).Item("apteka_name")
            wDoc.Bookmarks("apteka_nakl").Range.Text = foundRows(0).Item("apteka_name")

            Dim count As Integer = 2
            total_price = 0
            For i As Integer = 0 To Kremen.dt_VidachaDetail.Rows.Count - 1
                If Kremen.dt_VidachaDetail(i).apteka_id = apteka_idx Then
                    
                    wDoc.Tables(1).Rows.Add()
                    wDoc.Tables(1).Cell(count, 1).Range.Text = count - 1
                    wDoc.Tables(1).Cell(count, 2).Range.Text = Kremen.dt_VidachaDetail(i).kod
                    wDoc.Tables(1).Cell(count, 3).Range.Text = Kremen.dt_VidachaDetail(i).medname
                    wDoc.Tables(1).Cell(count, 4).Range.Text = Kremen.dt_VidachaDetail(i).upak
                    wDoc.Tables(1).Cell(count, 5).Range.Text = Kremen.dt_VidachaDetail(i).kolvo
                    wDoc.Tables(1).Cell(count, 6).Range.Text = Format(Kremen.dt_VidachaDetail(i).price, "# ##0.00")
                    total_price = total_price + Convert.ToDecimal(Kremen.dt_VidachaDetail(i).price * Kremen.dt_VidachaDetail(i).kolvo)
                    wDoc.Tables(1).Cell(count, 7).Range.Text = Format(Convert.ToDecimal(Kremen.dt_VidachaDetail(i).price * Kremen.dt_VidachaDetail(i).kolvo), "# ##0.00")
                    count = count + 1
                End If
            Next
            wDoc.Tables(1).Rows.Add()
            wDoc.Tables(1).Cell(count, 3).Range.Text = "ИТОГО:"
            wDoc.Tables(1).Cell(count, 7).Range.Text = Format(total_price, "# ##0.00")
            wDoc.Tables(1).Cell(count, 3).Range.Font.Bold = True
            wDoc.Tables(1).Cell(count, 7).Range.Font.Bold = True

            wDoc.Bookmarks("exp_date").Range.Text = VidachTotal(0)("date_enter")
            wDoc.Bookmarks("exp_diag").Range.Text = edt_diagname.Text
            wDoc.Bookmarks("nakl_date").Range.Text = VidachTotal(0)("date_enter")
            wDoc.Bookmarks("nakl_nom").Range.Text = VidachTotal(0)("id")

            wDoc.Bookmarks("nakl_fio").Range.Text = Globals.ColValueByCurRow(FKlients.g_klients, "fio")
            wDoc.Bookmarks("nakl_pasp").Range.Text = Globals.ColValueByCurRow(FKlients.g_klients, "paspser") & "" & Globals.ColValueByCurRow(FKlients.g_klients, "paspnom")
            wDoc.Bookmarks("nakl_inn").Range.Text = Globals.ColValueByCurRow(FKlients.g_klients, "inn")
            wDoc.Bookmarks("nakl_ceh").Range.Text = Globals.ColValueByCurRow(FKlients.g_klients, "ceh")
            wDoc.Bookmarks("nakl_tabnom").Range.Text = Globals.ColValueByCurRow(FKlients.g_klients, "tabnum")
            wDoc.Bookmarks("nakl_diag").Range.Text = edt_diagname.Text
            wDoc.Bookmarks("nakl_vrach").Range.Text = cb_doctor.Text
            wDoc.Bookmarks("nakl_begin").Range.Text = Format(dt_bolstart.Value, "dd/mm/yyyy")

            count = 2
            total_price = 0
            For i As Integer = 0 To Kremen.dt_VidachaDetail.Rows.Count - 1
                If Kremen.dt_VidachaDetail(i).apteka_id = apteka_idx Then
                    
                    wDoc.Tables(3).Rows.Add()
                    wDoc.Tables(3).Cell(count, 1).Range.Text = count - 1
                    wDoc.Tables(3).Cell(count, 2).Range.Text = Kremen.dt_VidachaDetail(i).kod 'Item("kod")
                    wDoc.Tables(3).Cell(count, 3).Range.Text = Kremen.dt_VidachaDetail(i).medname 'Item("medname")
                    wDoc.Tables(3).Cell(count, 4).Range.Text = Kremen.dt_VidachaDetail(i).upak 'Item("upak")
                    wDoc.Tables(3).Cell(count, 5).Range.Text = Kremen.dt_VidachaDetail(i).kolvo 'Item("kolvo")
                    wDoc.Tables(3).Cell(count, 6).Range.Text = Format(Kremen.dt_VidachaDetail(i).price, "# ##0.00")
                    total_price = total_price + Convert.ToDecimal(Kremen.dt_VidachaDetail(i).price * Kremen.dt_VidachaDetail(i).kolvo)
                    wDoc.Tables(3).Cell(count, 7).Range.Text = Format(Convert.ToDecimal(Kremen.dt_VidachaDetail(i).price * Kremen.dt_VidachaDetail(i).kolvo), "# ##0.00")
                    count = count + 1
                End If
            Next
            wDoc.Tables(3).Rows.Add()
            wDoc.Tables(3).Cell(count, 3).Range.Text = "ИТОГО:"
            wDoc.Tables(3).Cell(count, 7).Range.Text = Format(total_price, "# ##0.00")
            wDoc.Tables(3).Cell(count, 3).Range.Font.Bold = True
            wDoc.Tables(3).Cell(count, 7).Range.Font.Bold = True
            wDoc.Bookmarks("nakl_sum").Range.Text = SummaPropis.ProcM3_SummaProp(Format(total_price, "# ##0.00"))

            wApp.visible = True

        Next

    End Sub


    Private Sub btn_showvid_Click(sender As Object, e As EventArgs) Handles btn_showvid.Click
        If Kremen.dt_AllVidachByInsurCase.Rows.Count > 0 Then
            btn_showvid.Text = "Ждите..."
            btn_showvid.Refresh()
            Dim sel_idx As Integer = g_vidach.CurrentRow.Index

            FVidachaView.ShowDialog()
            g_vidach.Rows(sel_idx).Selected = True
            g_vidach.CurrentCell = g_vidach.Rows(sel_idx).Cells(0)
            btn_showvid.Text = "Просмотр"
        End If
    End Sub

    Private Sub btn_delvidach_Click(sender As Object, e As EventArgs) Handles btn_delvidach.Click
        If Kremen.dt_AllVidachByInsurCase.Rows.Count > 0 Then
            If MsgBox("Удалить выдачу медикаментов № " & Globals.ColValueByCurRow(g_vidach, "id"), vbYesNo) = MsgBoxResult.Yes Then
                cmd.SP_DelVidacha(Globals.ColValueByCurRow(g_vidach, "id"))
                GetAllVidach()
                st_label_fakt.Text = Globals.Get_ost
            End If
        End If
    End Sub

    Private Sub SetVidachOnly()
        lbl_sumfood.Visible = False
        edt_sumfood.Text = "0"
        edt_sumfood.Visible = False

        edt_sum.Text = "0"
        edt_sum.Enabled = False

        cb_lpu.SelectedIndex = 1
        cb_lpu.Enabled = False

    End Sub
    Private Sub SetViplatOnly()
        lbl_sumfood.Visible = False
        edt_sumfood.Text = "0"
        edt_sumfood.Visible = False

        edt_sum.Text = "0"
        edt_sum.Enabled = True

        If cb_lpu.SelectedIndex = 1 Then cb_lpu.SelectedIndex = 0
        cb_lpu.Enabled = True
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub btn_getdiag_Click(sender As Object, e As EventArgs) Handles btn_getdiag.Click
        Me.SuspendLayout()
        FMKB.ShowDialog()
        Me.ResumeLayout()
    End Sub

    Private Sub edt_diag_Enter(sender As Object, e As EventArgs) Handles edt_diag.Enter
        ' Меняем раскладку на английский язык
        System.Windows.Forms.InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.GetCultureInfo(1033))

    End Sub

    Private Sub edt_diag_Leave(sender As Object, e As EventArgs) Handles edt_diag.Leave
        ' Меняем раскладку на русский язык
        System.Windows.Forms.InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.GetCultureInfo(1049))

    End Sub
End Class