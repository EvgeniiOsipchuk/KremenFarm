Public Class FAnaliz

    Private Sub FAnaliz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As New KrDataSetTableAdapters.dt_analiz_bolTableAdapter
        da.Fill(Kremen.dt_analiz_bol)
        da.Dispose()

        cb_bol.DisplayMember = "analiz_bol"
        cb_bol.ValueMember = "id"
        cb_bol.DataSource = Kremen.dt_analiz_bol

        g_diag.AutoGenerateColumns = False
        Kremen.dt_analiz.Columns.Add("CB", Type.GetType("System.Boolean"))
        g_diag.DataSource = Kremen.dt_analiz
        lbl_price.Text = "0"
        lbl_count.Text = "0"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim da As New KrDataSetTableAdapters.dt_analizTableAdapter
        da.Fill(Kremen.dt_analiz, cb_bol.SelectedValue)
        da.Dispose()
        lbl_price.Text = "0"
        lbl_count.Text = "0"
    End Sub

    Private Sub FAnaliz_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Kremen.dt_analiz.Columns.Remove("CB")
        Me.Dispose()
    End Sub

  
    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If Not Kremen.dt_analiz.Rows.Count > 0 Then
            MsgBox("Не выбран ни один анализ!")
            Exit Sub
        End If

        Dim analiz_id As Long
        cmd.SP_AnalizKlient(dt_napr.Value, edt_num_napr.Text, dt_akt.Value, edn_num_akt.Text, Convert.ToDecimal(lbl_price.Text),
                            Globals.ColValueByCurRow(FKlients.g_klients, "id"), analiz_id)

        'For Each dr As DataGridViewRow In g_diag.Rows
        '    If dr.Cells.Item(0).Value = True Then
        '        MsgBox(dr.Cells.Item(1).Value & " " & dr.Cells.Item(2).Value)
        '    End If
        'Next
        For Each dr As DataRow In Kremen.dt_analiz.Rows
            If dr.Item("CB").ToString = "True" Then
                cmd.AddAnalizDetail(analiz_id, dr.Item("id"))
                'MsgBox(dr.Item("id").ToString & " " & dr.Item("analiz").ToString)
            End If
        Next
        Me.Close()
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub g_diag_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles g_diag.CellClick

        If Not Kremen.dt_analiz.Rows.Count > 0 Then
            Exit Sub
        End If

        Dim sum_analiz As Decimal = 0
        Dim count As Integer = 0
       
        If e.ColumnIndex = 0 Then 'Считаем что столбец с галочками всегда первый
            If Kremen.dt_analiz.Rows(e.RowIndex).Item("CB").ToString = "True" Then
                Kremen.dt_analiz.Rows(e.RowIndex).Item("CB") = False
            Else
                Kremen.dt_analiz.Rows(e.RowIndex).Item("CB") = True
            End If

            Dim sumRow As DataRow() = Kremen.dt_analiz.Select("cb=" & True)

            For Each dr As DataRow In sumRow
                If dr.Item("CB").ToString = "True" Then
                    count = count + 1
                    sum_analiz = sum_analiz + dr.Item("price")
                    ' MsgBox(dr.Item("id").ToString & " " & dr.Item("analiz").ToString)
                End If
            Next
            lbl_count.Text = Convert.ToString(count)
            lbl_price.Text = Convert.ToString(sum_analiz)
        End If
    End Sub


    Private Sub cb_bol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_bol.SelectedIndexChanged
        Dim da As New KrDataSetTableAdapters.dt_analizTableAdapter
        da.Fill(Kremen.dt_analiz, cb_bol.SelectedValue)
        da.Dispose()
        lbl_price.Text = "0"
        lbl_count.Text = "0"
    End Sub
End Class