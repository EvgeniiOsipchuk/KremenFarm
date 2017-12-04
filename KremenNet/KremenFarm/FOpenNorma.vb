Public Class FOpenNorma

    Private Sub FOpenNorma_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btn_norm_Click(sender As Object, e As EventArgs) Handles btn_norm.Click
        Dim objApp As Object
        Dim objBook As Object
        Dim objBooks As Object
        Dim objSheets As Object
        Dim objSheet As Object
        Dim DI_day As IO.DirectoryInfo = New IO.DirectoryInfo(My.Settings.OpenCase)

        Dim da As New KrDataSetTableAdapters.SP_OpenVidachaTableAdapter
        btn_norm.Text = "Ждите..."
        btn_norm.Refresh()
        da.Fill(Kremen.SP_OpenVidacha, cb_Apteka.SelectedValue)
        da.Dispose()

        If Not Kremen.SP_OpenVidacha.Rows.Count > 0 Then
            btn_norm.Text = "Сформировать"
            MsgBox("Открытых по аптеке """ + cb_Apteka.Text + """ нет!")
            Exit Sub
        End If

        Dim s_total_price As Decimal = 0
        Try
            s_total_price = Convert.ToDecimal(Kremen.SP_OpenVidacha.Compute("Sum(total_price)", ""))
        Catch
            s_total_price = 0
        End Try

        ' Instantiate Excel and start a new workbook.
        objApp = CreateObject("Excel.Application")
        objApp.Visible = False
        objBooks = objApp.Workbooks
        objBook = objBooks.Open(Application.StartupPath + "\report\open_norma.xlt")
        objApp.DisplayAlerts = False
        objSheets = objBook.Worksheets
        objSheet = objSheets.Item(1)

        objSheet.Range("A1") = objSheet.Range("A1").Value & cb_Apteka.Text
        objSheet.Range("A2") = objSheet.Range("A2").Value & Format(Now, "G")

        Dim count As Integer = 4
        Dim numb As Integer = 1

        btn_close.Enabled = False
        progress.Maximum = Kremen.SP_OpenVidacha.Rows.Count + 1
        progress.Minimum = 0
        progress.Value = 0
        progress.Visible = True
        st_info.Visible = True

        For Each dr As DataRow In Kremen.SP_OpenVidacha.Rows
            objSheet.Range("A" & count) = numb
            objSheet.Range("B" & count) = dr.Item("fio").ToString
            objSheet.Range("C" & count) = dr.Item("tabnum").ToString
            objSheet.Range("D" & count) = dr.Item("bol_num").ToString
            objSheet.Range("E" & count) = dr.Item("date_enter").ToString
            objSheet.Range("F" & count) = dr.Item("total_price").ToString

            count += 1
            numb += 1
            progress.Value += 1
        Next

        objSheet.Range("F" & count) = s_total_price
        objSheet.Range("F" & count).Font.Bold = True
        objSheet.Range("A4:F" & count - 1).Borders.LineStyle = 1

        If Not DI_day.Exists Then
            DI_day.Create()
        End If
        objSheet.SaveAs(DI_day.FullName + "\Открытые_по_" + cb_Apteka.Text + ".xls")

        objApp.Visible = True
        objApp.UserControl = True
        progress.Value += 1
        progress.Visible = False
        st_info.Visible = False
        btn_close.Enabled = True
        btn_norm.Text = "Сформировать"

    End Sub


    Private Sub FOpenNorma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        progress.Visible = False
        st_info.Visible = False
        Globals.GetApteki()
        cb_Apteka.DataSource = Kremen.dt_Apteki
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class