Public Class FAnalizKlient

    Private Sub FAnalizKlient_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub FAnalizKlient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g_analiz_klient.AutoGenerateColumns = False
        g_analiz_klient.DataSource = Kremen.dt_Analiz_klient
        lbl_klient.Text = Globals.ColValueByCurRow(FKlients.g_klients, "inn") & "     " & Globals.ColValueByCurRow(FKlients.g_klients, "fio")
        ShowAllAnaliz()
    End Sub

    Private Sub btn_add_analiz_klient_Click(sender As Object, e As EventArgs) Handles btn_add_analiz_klient.Click
        FAnaliz.ShowDialog()
        ShowAllAnaliz()
    End Sub


    Private Sub ShowAllAnaliz()
        Dim da As New KrDataSetTableAdapters.dt_Analiz_klientTableAdapter
        da.Fill(Kremen.dt_Analiz_klient, Globals.ColValueByCurRow(FKlients.g_klients, "id"))
        da.Dispose()
    End Sub

    Private Sub btn_del_analiz_Click(sender As Object, e As EventArgs) Handles btn_del_analiz.Click
        If Not Kremen.dt_Analiz_klient.Rows.Count > 0 Then
            Exit Sub
        End If
        If MsgBox("Вы действительно хотите удалить данные по анализам?", vbYesNo) = MsgBoxResult.Yes Then
            cmd.DeleteAnaliz(Globals.ColValueByCurRow(g_analiz_klient, "id"))
            ShowAllAnaliz()
        End If
    End Sub

    Private Sub retAnalizDetail()
        Dim da As New KrDataSetTableAdapters.dt_RetAnalizDetailTableAdapter
        da.Fill(Kremen.dt_RetAnalizDetail, Globals.ColValueByCurRow(g_analiz_klient, "id"))
        da.Dispose()
    End Sub
    Private Sub btn_print_analiz_Click(sender As Object, e As EventArgs) Handles btn_print_analiz.Click
        If Not Kremen.dt_Analiz_klient.Rows.Count > 0 Then
            Exit Sub
        End If
        retAnalizDetail()

        Dim wApp As Object = CreateObject("Word.Application")
        wApp.Visible = True
        Dim wDoc As Object = wApp.Documents.Open(Application.StartupPath + "\report\analiz.doc")

        wDoc.Bookmarks("fio").Range.Text = Globals.ColValueByCurRow(FKlients.g_klients, "inn") & "     " &
                                           Globals.ColValueByCurRow(FKlients.g_klients, "fio")
        wDoc.Bookmarks("nom_napr").Range.Text = Globals.ColValueByCurRow(g_analiz_klient, "nom_napr")
        wDoc.Bookmarks("date_napr").Range.Text = Globals.ColValueByCurRow(g_analiz_klient, "date_napr")
        wDoc.Bookmarks("nom_akt").Range.Text = Globals.ColValueByCurRow(g_analiz_klient, "nom_akt")
        wDoc.Bookmarks("date_akt").Range.Text = Globals.ColValueByCurRow(g_analiz_klient, "date_akt")

        Dim count As Integer = 2
        Dim total_price As Decimal = 0


        For Each dr As DataRow In Kremen.dt_RetAnalizDetail.Rows
            wDoc.Tables(1).Rows.Add()
            wDoc.Tables(1).Cell(count, 1).Range.Text = dr.Item("Analiz").ToString
            wDoc.Tables(1).Cell(count, 2).Range.Text = Format(dr.Item("price"), "# ##0.00")
            total_price = total_price + dr.Item("price")
            count = count + 1
        Next

        wDoc.Tables(1).Rows.Add()
        wDoc.Tables(1).Cell(count, 1).Range.Text = "ИТОГО"
        wDoc.Tables(1).Cell(count, 2).Range.Text = Format(total_price, "# ##0.00")
        wDoc.Tables(1).Cell(count, 1).Range.Bold = True
        wDoc.Tables(1).Cell(count, 2).Range.Bold = True
    End Sub

    Private Sub btn_analiz_prosm_Click(sender As Object, e As EventArgs)
        If Not Kremen.dt_Analiz_klient.Rows.Count > 0 Then
            Exit Sub
        End If
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub
End Class