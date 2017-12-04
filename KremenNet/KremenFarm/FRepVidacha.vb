Public Class FRepVidacha
    Enum Tbol_type
        BOL_ALL = 0
        BOL_OPEN = 1
        BOL_CLOSE = 2
    End Enum

    Enum Tmed_type
        MED_YES = 0
        MED_NO = 1
    End Enum

    Enum Tlech_type
        LECH_ALL = -1
        LECH_AMB = 0
    End Enum

    Private bol_type As Tbol_type
    Private lech_type As Tlech_type
    Private med_type As Tmed_type

    Private Sub FRepVidacha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As New KrDataSetTableAdapters.dt_RepPredprTableAdapter
        da.Fill(Kremen.dt_RepPredpr)
        da.Dispose()

        Globals.GetApteki()
        cb_Apteka.DataSource = Kremen.dt_Apteki

        cb_pred.DisplayMember = "predpr_name"
        cb_pred.ValueMember = "id_report"
        cb_pred.DataSource = Kremen.dt_RepPredpr

        g_RepVidach.AutoGenerateColumns = False
        g_RepVidach.DataSource = Kremen.SP_RepVidacha
        rb_All_bol.Checked = True
        rb_all_lech.Checked = True
        rb_med_yes.Checked = True
        dt_start.Value = Now
        dt_end.Value = Now
        lbl_sum.Text = "0"
        lbl_kol.Text = "0"
        progress.Visible = False
        st_info.Visible = False
    End Sub

    Private Sub rb_all_lech_CheckedChanged(sender As Object, e As EventArgs) Handles rb_all_lech.CheckedChanged
        lech_type = Tlech_type.LECH_ALL
    End Sub

    Private Sub rb_amb_lech_CheckedChanged(sender As Object, e As EventArgs) Handles rb_amb_lech.CheckedChanged
        lech_type = Tlech_type.LECH_AMB
    End Sub

    Private Sub rb_All_bol_CheckedChanged(sender As Object, e As EventArgs) Handles rb_All_bol.CheckedChanged
        bol_type = Tbol_type.BOL_ALL
    End Sub

    Private Sub rb_bol_open_CheckedChanged(sender As Object, e As EventArgs) Handles rb_bol_open.CheckedChanged
        bol_type = Tbol_type.BOL_OPEN
    End Sub

    Private Sub rb_bol_close_CheckedChanged(sender As Object, e As EventArgs) Handles rb_bol_close.CheckedChanged
        bol_type = Tbol_type.BOL_CLOSE
    End Sub

    Private Sub rb_med_yes_CheckedChanged(sender As Object, e As EventArgs) Handles rb_med_yes.CheckedChanged
        med_type = Tmed_type.MED_YES
        If rb_med_yes.Checked = True Then
            cb_Apteka.Enabled = True
        Else
            cb_Apteka.Enabled = False
        End If
    End Sub

    Private Sub rb_med_no_CheckedChanged(sender As Object, e As EventArgs) Handles rb_med_no.CheckedChanged
        med_type = Tmed_type.MED_NO
    End Sub

    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        Dim dst As Date = dt_start.Value
        Dim dend As Date = dt_end.Value
        Dim apteka_id As Integer

        Dim date_start As New System.DateTime(Year(dst), Month(dst), Microsoft.VisualBasic.DateAndTime.Day(dst), 0, 0, 0)
        Dim date_end As New System.DateTime(Year(dend), Month(dend), Microsoft.VisualBasic.DateAndTime.Day(dend), 23, 59, 59)
        Dim da As New KrDataSetTableAdapters.SP_RepVidachaTableAdapter

        If rb_med_yes.Checked = True Then
            apteka_id = cb_Apteka.SelectedValue
        Else
            apteka_id = -1
        End If

        btn_select.Text = "Ждите.."
        btn_select.Refresh()

        da.Fill(Kremen.SP_RepVidacha, date_start, date_end, bol_type, lech_type, med_type, cb_pred.SelectedValue, apteka_id)
        da.Dispose()
        lbl_kol.Text = Kremen.SP_RepVidacha.Rows.Count

        If Not Kremen.SP_RepVidacha.Rows.Count > 0 Then
            MsgBox("Не найдено информации!")
            btn_select.Text = "Выбрать"
            Exit Sub
        End If

        Dim sumObject As Object
        Try
            sumObject = Math.Round(Kremen.SP_RepVidacha.Compute("Sum(total_price)", ""), 2)
            lbl_sum.Text = Format(sumObject, "# ##0.00")
        Catch
            lbl_sum.Text = "0"
        End Try
        btn_select.Text = "Выбрать"
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        If Not Kremen.SP_RepVidacha.Rows.Count > 0 Then
            Exit Sub
        End If
        progress.Maximum = Kremen.SP_RepVidacha.Rows.Count + 1
        progress.Minimum = 0
        progress.Value = 0
        progress.Visible = True
        st_info.Visible = True
        Dim wApp As Object = CreateObject("Word.Application")
        wApp.Visible = False
        Dim wDoc As Object = wApp.Documents.Open(Application.StartupPath + "\report\repvidacha.dot")

        wDoc.Bookmarks("Predpr").Range.Text = cb_pred.Text
        wDoc.Bookmarks("date_begin").Range.Text = Format(dt_start.Value, "d")
        wDoc.Bookmarks("date_end").Range.Text = Format(dt_end.Value, "d")
        If rb_med_yes.Checked = True Then
            wDoc.Bookmarks("apteka").Range.Text = "Аптека «" + cb_Apteka.Text + "»"
        End If


        Dim count As Integer = 2

        For Each dr As DataRow In Kremen.SP_RepVidacha.Rows
            wDoc.Tables(1).Rows.Add()
            wDoc.Tables(1).Cell(count, 1).Range.Text = count - 1
            wDoc.Tables(1).Cell(count, 2).Range.Text = dr.Item("fio").ToString
            wDoc.Tables(1).Cell(count, 3).Range.Text = dr.Item("num").ToString
            wDoc.Tables(1).Cell(count, 4).Range.Text = dr.Item("bol_num").ToString
            wDoc.Tables(1).Cell(count, 5).Range.Text = dr.Item("ceh").ToString
            wDoc.Tables(1).Cell(count, 6).Range.Text = dr.Item("tabnum").ToString
            wDoc.Tables(1).Cell(count, 7).Range.Text = Format(dr.Item("bol_start"), "d")
            wDoc.Tables(1).Cell(count, 8).Range.Text = Format(dr.Item("total_price"), "# ##0.00")
            count = count + 1
            progress.Value += 1
        Next
        wDoc.Tables(1).Rows.Add()
        wDoc.Tables(1).Cell(count, 2).Range.Text = "ИТОГО"
        wDoc.Tables(1).Cell(count, 8).Range.Text = lbl_sum.Text
        wDoc.Tables(1).Cell(count, 2).Range.Font.Bold = True
        wDoc.Tables(1).Cell(count, 8).Range.Font.Bold = True
        progress.Value += 1
        progress.Visible = False
        st_info.Visible = False
        wApp.Visible = True
    End Sub

    Private Sub FRepVidacha_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Kremen.SP_RepVidacha.Clear()
        Me.Dispose()
    End Sub
End Class