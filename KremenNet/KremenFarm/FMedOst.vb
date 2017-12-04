Public Class FMedOst

    Private Sub FMedOst_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Kremen.dt_RepApteka.Clear()
        Me.Dispose()
    End Sub

    Private Sub btn_ost_Click(sender As Object, e As EventArgs) Handles btn_ost.Click
        Dim da As New KrDataSetTableAdapters.dt_RepAptekaTableAdapter

        btn_ost.Text = "Ждите..."
        btn_ost.Refresh()

        da.Fill(Kremen.dt_RepApteka, cb_Apteka.SelectedValue)
        da.Dispose()

        If Not Kremen.dt_RepApteka.Rows.Count > 0 Then
            btn_ost.Text = "Сформировать"
            btn_ost.Refresh()
            MsgBox("Не найдено информации!")
            Exit Sub
        End If
        Dim sumObject As Object

        Try
            sumObject = Math.Round(Kremen.dt_RepApteka.Compute("Sum(summa)", ""), 2)
        Catch
            sumObject = 0
        End Try
        btn_close.Enabled = False
        progress.Maximum = Kremen.dt_RepApteka.Rows.Count + 1
        progress.Minimum = 0
        progress.Value = 0
        progress.Visible = True
        st_info.Visible = True
        Dim wApp As Object = CreateObject("Word.Application")
        wApp.Visible = False
        Dim wDoc As Object = wApp.Documents.Open(Application.StartupPath + "\report\repapteka.dot")

        wDoc.Bookmarks("apteka").Range.Text = cb_Apteka.Text
        wDoc.Bookmarks("date").Range.Text = Now

        Dim count As Integer = 2

        For Each dr As DataRow In Kremen.dt_RepApteka.Rows
            wDoc.Tables(1).Rows.Add()
            wDoc.Tables(1).Cell(count, 1).Range.Text = count - 1
            wDoc.Tables(1).Cell(count, 2).Range.Text = dr.Item("Name").ToString
            wDoc.Tables(1).Cell(count, 3).Range.Text = dr.Item("KOD").ToString
            wDoc.Tables(1).Cell(count, 4).Range.Text = dr.Item("upak").ToString
            wDoc.Tables(1).Cell(count, 5).Range.Text = dr.Item("kolvo").ToString
            wDoc.Tables(1).Cell(count, 6).Range.Text = Format(dr.Item("price"), "# ##0.00")
            wDoc.Tables(1).Cell(count, 7).Range.Text = Format(dr.Item("summa"), "# ##0.00")
            count = count + 1
            progress.Value += 1
        Next
        wDoc.Tables(1).Rows.Add()
        wDoc.Tables(1).Cell(count, 2).Range.Text = "ИТОГО"
        wDoc.Tables(1).Cell(count, 7).Range.Text = Format(sumObject, "# ##0.00")
        wDoc.Tables(1).Cell(count, 2).Range.Font.Bold = True
        wDoc.Tables(1).Cell(count, 7).Range.Font.Bold = True

        progress.Value += 1
        progress.Visible = False
        btn_ost.Text = "Сформировать"
        st_info.Visible = False
        btn_close.Enabled = True
        wApp.Visible = True
    End Sub


    Private Sub FMedOst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        progress.Visible = False
        st_info.Visible = False
        Globals.GetApteki()
        cb_Apteka.DataSource = Kremen.dt_Apteki
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class