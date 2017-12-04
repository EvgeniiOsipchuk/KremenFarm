Imports System.IO

Public Class FRepVostok

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub FRepAnaliz_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub FRepAnaliz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt_start.Value = Now
        dt_end.Value = Now

        progress.Visible = False
        st_info.Visible = False
    End Sub

    Private Sub btn_form_Click(sender As Object, e As EventArgs) Handles btn_form.Click
        Dim da As New KrDataSetTableAdapters.dt_RepVostokTableAdapter
        Dim objApp As Object
        Dim objBook As Object
        Dim objBooks As Object
        Dim objSheets As Object
        Dim objSheet As Object

        Dim DI_day As IO.DirectoryInfo = Nothing
        If Not File.Exists("Setup.ini") Then
            DI_day  = New IO.DirectoryInfo(My.Settings.VostokDir + "\" + Format(Now.Date, "d"))
        Else
            DI_day  = New IO.DirectoryInfo(FConnection.ReadIni("Path", "Path1") + "\" + Format(Now.Date, "d"))
        End If
        

        btn_form.Text = "Ждите..."
        btn_form.Refresh()

        Dim dob As DateTime = New DateTime(dt_start.Value.Year, dt_start.Value.Month, dt_start.Value.Day, 0, 0, 0)
        Dim dob2 As DateTime = New DateTime(dt_end.Value.Year, dt_end.Value.Month, dt_end.Value.Day, 23, 59, 59)

        Kremen.dt_RepVostok.PrimaryKey = Nothing
        da.Fill(Kremen.dt_RepVostok, dob, dob2)

        da.Dispose()


        If Not Kremen.dt_RepVostok.Rows.Count > 0 Then
            btn_form.Text = "Сформировать"
            btn_form.Refresh()
            MsgBox("Не найдено информации!")
            Exit Sub
        End If

        progress.Maximum = Kremen.dt_RepVostok.Rows.Count + 1
        progress.Minimum = 0
        progress.Value = 0
        progress.Visible = True
        st_info.Visible = True

        ' Instantiate Excel and start a new workbook.
        objApp = CreateObject("Excel.Application")
        objApp.Visible = False
        objApp.DisplayAlerts = False
        objBooks = objApp.Workbooks
        objBook = objBooks.Open(Application.StartupPath + "\report\naklvostok.xlt")
        objSheets = objBook.Worksheets
        objSheet = objSheets.Item(1)

        objSheet.Range("A" & 2) = "c " + Format(dt_start.Value, "d") + " по " + Format(dt_end.Value, "d")

        Dim count As Integer = 3
        Dim numb As Integer = 0
        Dim id As Int64
        Dim total_sum As Decimal
        Dim fio_sum As Decimal


        Dim i As Integer = 0
        total_sum = 0

        While i < Kremen.dt_RepVostok.Rows.Count
            id = Kremen.dt_RepVostok(i).id
            fio_sum = 0

            While id = Kremen.dt_RepVostok(i).Item("id")
                count += 1
                numb += 1
                objSheet.Range("A" & count) = numb
                objSheet.Range("B" & count) = Kremen.dt_RepVostok(i).Item("fio").ToString
                objSheet.Range("C" & count) = Kremen.dt_RepVostok(i).Item("date_enter").ToString
                objSheet.Range("D" & count) = Kremen.dt_RepVostok(i).Item("kod").ToString
                objSheet.Range("E" & count) = Kremen.dt_RepVostok(i).Item("name").ToString
                objSheet.Range("F" & count) = Kremen.dt_RepVostok(i).Item("kolvo").ToString
                objSheet.Range("G" & count) = Format(Kremen.dt_RepVostok(i).Item("price"), "# ##0.00")
                objSheet.Range("H" & count) = Format(Kremen.dt_RepVostok(i).Item("total_price"), "# ##0.00")
                fio_sum = fio_sum + Kremen.dt_RepVostok(i).Item("total_price")

                i = i + 1
                If i >= Kremen.dt_RepVostok.Rows.Count Then
                    Exit While
                End If
            End While

            count += 1
            total_sum = total_sum + fio_sum
            objSheet.Range("H" & count) = Format(fio_sum, "# ##0.00")
            objSheet.Range("H" & count).Font.Bold = True
            objSheet.Range("A" & count & ":G" & count).Merge()
            objSheet.Range("A" & count) = ""
        End While

        count += 1
        objSheet.Range("H" & count) = Format(total_sum, "# ##0.00")
        objSheet.Range("H" & count).Font.Bold = True
        objSheet.Range("A4:H" & count - 1).Borders.LineStyle = 1

        If Not DI_day.Exists Then
            DI_day.Create()
        End If
        objSheet.SaveAs(DI_day.FullName + "\" + "Восток_" + Format(Now, "d") + ".xls")

        progress.Value += 1
        progress.Visible = False
        btn_form.Text = "Сформировать"
        st_info.Visible = False
        objApp.Visible = True
        objApp.UserControl = True
    End Sub
End Class