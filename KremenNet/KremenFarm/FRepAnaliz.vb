Public Class FRepAnaliz

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub FRepAnaliz_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub FRepAnaliz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt_start.Value = Now
        dt_end.Value = Now
        Dim da_analiz As New KrDataSetTableAdapters.dt_analiz_bolTableAdapter
        da_analiz.Fill(Kremen.dt_analiz_bol)
        '  da_analiz.Dispose()
        cb_lpu.DataSource = Kremen.dt_analiz_bol 'Kremen.dt_lpu
        'cb_lpu.DataSource = Kremen.dt_lpu
        ' Globals.GetLpu()

        Dim da As New KrDataSetTableAdapters.dt_RepPredprTableAdapter
        da.Fill(Kremen.dt_RepPredpr)
        da.Dispose()
        cb_pred.DataSource = Kremen.dt_RepPredpr

        progress.Visible = False
        st_info.Visible = False
    End Sub

    Private Sub btn_form_Click(sender As Object, e As EventArgs) Handles btn_form.Click
        Dim da As New KrDataSetTableAdapters.SP_RepAnalizTableAdapter

        btn_form.Text = "Ждите..."
        btn_form.Refresh()

        Dim dob As DateTime = New DateTime(dt_start.Value.Year, dt_start.Value.Month, dt_start.Value.Day, 0, 0, 0)
        Dim dob2 As DateTime = New DateTime(dt_end.Value.Year, dt_end.Value.Month, dt_end.Value.Day, 23, 59, 59)

        Kremen.SP_RepAnaliz.PrimaryKey = Nothing
        da.Fill(Kremen.SP_RepAnaliz, dob, dob2, CType(cb_lpu.SelectedValue, Integer), CType(cb_pred.SelectedValue, Integer))
        da.Dispose()

        If Not Kremen.SP_RepAnaliz.Rows.Count > 0 Then
            btn_form.Text = "Сформировать"
            btn_form.Refresh()
            MsgBox("Не найдено информации!")
            Exit Sub
        End If

        Dim sumObject As Object
        Try
            sumObject = Math.Round(Kremen.SP_RepAnaliz.Compute("Sum(price)", ""), 2)
        Catch
            sumObject = 0
        End Try

        progress.Maximum = Kremen.SP_RepAnaliz.Rows.Count + 1
        progress.Minimum = 0
        progress.Value = 0
        progress.Visible = True
        st_info.Visible = True
        Dim wApp As Object = CreateObject("Word.Application")
        wApp.Visible = False
        Dim wDoc As Object = wApp.Documents.Open(Application.StartupPath + "\report\repanaliz.dot")

        wDoc.Bookmarks("lpu").Range.Text = cb_lpu.Text
        wDoc.Bookmarks("date_begin").Range.Text = Format(dt_start.Value, "d")
        wDoc.Bookmarks("date_end").Range.Text = Format(dt_end.Value, "d")

        Dim count As Integer = 2
        For Each dr As DataRow In Kremen.SP_RepAnaliz.Rows
            wDoc.Tables(2).Rows.Add()
            wDoc.Tables(2).Cell(count, 1).Range.Text = count - 1
            wDoc.Tables(2).Cell(count, 2).Range.Text = dr.Item("fio").ToString
            wDoc.Tables(2).Cell(count, 3).Range.Text = dr.Item("nom_napr").ToString
            wDoc.Tables(2).Cell(count, 4).Range.Text = dr.Item("analiz").ToString
            wDoc.Tables(2).Cell(count, 5).Range.Text = "1 от 08.06.2005"
            wDoc.Tables(2).Cell(count, 6).Range.Text = cb_pred.Text
            wDoc.Tables(2).Cell(count, 7).Range.Text = Format(dr.Item("price"), "# ##0.00")
            count = count + 1
            progress.Value += 1
        Next
        wDoc.Tables(2).Rows.Add()
        wDoc.Tables(2).Cell(count, 2).Range.Text = "ИТОГО"
        wDoc.Tables(2).Cell(count, 7).Range.Text = Format(sumObject, "# ##0.00")
        wDoc.Tables(2).Cell(count, 2).Range.Font.Bold = True
        wDoc.Tables(2).Cell(count, 7).Range.Font.Bold = True
        progress.Value += 1
        progress.Visible = False
        btn_form.Text = "Сформировать"
        st_info.Visible = False
        wApp.Visible = True
    End Sub
End Class