Public Class FVidacha
    
    'Public dt_med As New DataTable
    Public dt_sel As New DataTable

    Private Sub FVidacha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dc As New DataColumn("total_price")
        Dim ac As New DataColumn("auto_inc")

        Dim limit As Decimal = Convert.ToDecimal(DirectCast(FCase.cb_lech.SelectedItem, DataRowView).Item("limit").ToString)
        Dim total_price As Decimal = Convert.ToDecimal(FCase.edt_sum.Text)
        Dim food_price As Decimal = Convert.ToDecimal(FCase.edt_sumfood.Text)
        Dim vidach_price As Decimal = Convert.ToDecimal(FCase.lbl_vidano.Text)

        g_med.AutoGenerateColumns = False
        g_med.DataSource = Kremen.dt_GetMed
        st_limit.Text = limit
        st_total_price.Text = total_price
        st_food_price.Text = food_price
        st_vidach.Text = vidach_price
        With dc
            .Expression = "price * kolvo"
            .DataType = System.Type.GetType("System.Decimal")
        End With

        With ac
            .AutoIncrement = True
            .AutoIncrementSeed = 0
            .AutoIncrementStep = 1
            .DataType = System.Type.GetType("System.Int32")
        End With

        lbl_itogo.Text = "0"
        dt_sel = Kremen.dt_GetMed.Clone 'Globals.GetMed("___").Clone

        dt_sel.Columns.Add(dc)
        dt_sel.Columns.Add(ac)
        dt_sel.PrimaryKey = Nothing
        g_select.AutoGenerateColumns = False
        g_select.DataSource = dt_sel
        
    End Sub


    Public Sub find_med()
        Globals.GetMed(edt_medfind.Text)
       
    End Sub

    Private Sub edt_medfind_TextChanged(sender As Object, e As EventArgs) Handles edt_medfind.TextChanged
        find_med()
    End Sub


    Private Sub g_med_DoubleClick(sender As Object, e As EventArgs) Handles g_med.DoubleClick
        AddMed()
    End Sub

    Private Sub RemoveMed()
        Dim sumObject As Object
        If Not dt_sel.Rows.Count > 0 Then
            Exit Sub
        End If

        Dim id = Globals.ColValueByCurRow(g_select, "auto_inc")

        Dim curRow As DataRow() = dt_sel.Select("auto_inc=" & id)
        dt_sel.Rows.Remove(curRow(0))
        Try
            sumObject = Math.Round(dt_sel.Compute("Sum(total_price)", ""), 2)
            lbl_itogo.Text = sumObject.ToString
        Catch
            sumObject = Nothing
            lbl_itogo.Text = "0"
        End Try
        CheckLimit()
    End Sub

    Private Sub AddMed()
        If Not Kremen.dt_GetMed.Rows.Count > 0 Then
            Exit Sub
        End If

        Dim id = Globals.ColValueByCurRow(g_med, "id")
        Dim curRow As DataRow() = Kremen.dt_GetMed.Select("id=" & id)
        Dim sumObject As Object
        Dim ImpRow As DataRow = dt_sel.NewRow()

        Dim AddKolvo As String = InputBox("Введите необходимое кол-во медикамента", "Добавление медикамета", 1)
        If AddKolvo <> "" Then
            If Not IsNumeric(AddKolvo) Then
                MsgBox("Неверное кол-во медикамента")
                Exit Sub
            End If
            If Val(AddKolvo) > curRow(0)("kolvo") Then
                MsgBox("Запрашиваемое кол-во больше остатка в аптеке")
                Exit Sub
            End If

            ImpRow("id") = curRow(0)("id")
            ImpRow("kod") = curRow(0)("kod")
            ImpRow("medname") = curRow(0)("medname")
            ImpRow("kolvo") = AddKolvo
            ImpRow("price") = curRow(0)("price")
            ImpRow("upak") = curRow(0)("upak")
            ImpRow("apteka_name") = curRow(0)("apteka_name")

            dt_sel.Rows.Add(ImpRow)
            g_select.AutoResizeColumns()
            sumObject = Math.Round(dt_sel.Compute("Sum(total_price)", ""), 2)
            lbl_itogo.Text = sumObject.ToString
        End If
        CheckLimit()
    End Sub
    Function CheckLimit() As Boolean
        If Convert.ToDecimal(st_limit.Text) < Convert.ToDecimal(lbl_itogo.Text) Then
            lbl_itogo.ForeColor = Color.Red
            CheckLimit = False
        Else
            lbl_itogo.ForeColor = Color.Black
            CheckLimit = True
        End If
    End Function
    Private Sub g_select_DoubleClick(sender As Object, e As EventArgs) Handles g_select.DoubleClick
        RemoveMed()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim Vidach_id As Integer
        Dim insurcase_id As Integer
        Dim status As Integer
        Dim sum_vidach As Decimal

        If Not dt_sel.Rows.Count > 0 Then
            Exit Sub
        End If


        sum_vidach = Convert.ToDecimal(lbl_itogo.Text)

        If Not FCase.CheckMoney(True, sum_vidach) = True Then
            MsgBox("У клиента недостаточно средств!", vbCritical)
            Exit Sub
        End If

        If Not CheckLimit() Then
            MsgBox("Сумма выдачи больше размера страхового лимита!", vbCritical)
            Exit Sub
        End If

        If mode = type_case.EDIT_CASE Then
            insurcase_id = Kremen.dt_insurcase(0).id
        Else
            insurcase_id = gl_insurcase_id
        End If
        cmd.SP_VidachaInsert(Globals.ColValueByCurRow(FKlients.g_klients, "id"), insurcase_id,
                        sum_vidach, Vidach_id)

        For i As Integer = 0 To dt_sel.Rows.Count - 1
            cmd.SP_VidachaDetailInsert(Vidach_id, dt_sel.Rows(i).Item("id"), dt_sel.Rows(i).Item("kolvo"),
                                       dt_sel.Rows(i).Item("price"), status)
        Next


        FCase.GetAllVidach()
        Me.Close()

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_separate_Click(sender As Object, e As EventArgs) Handles btn_separate.Click
        delit()
    End Sub

    Private Sub delit()
        If Not Kremen.dt_GetMed.Rows.Count > 0 Then
            Exit Sub
        End If
        FVidachaDelit.ShowDialog()
    End Sub


    Private Sub g_med_MouseDown(sender As Object, e As MouseEventArgs) Handles g_med.MouseDown
        If (e.Button = MouseButtons.Right) Then
            Dim h = g_med.HitTest(e.X, e.Y)
            If (h.Type = DataGridViewHitTestType.Cell) Then
                g_med.Rows(h.RowIndex).Selected = True
            End If
        End If
    End Sub

    Private Sub mi_add_Click(sender As Object, e As EventArgs) Handles mi_add.Click
        AddMed()
    End Sub

    Private Sub mi_delit_Click(sender As Object, e As EventArgs) Handles mi_delit.Click
        delit()
    End Sub

    Private Sub mi_Remove_Click(sender As Object, e As EventArgs) Handles mi_Remove.Click
        RemoveMed()
    End Sub

    Private Sub FVidacha_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Kremen.dt_GetMed.Clear()
        Me.Dispose()
    End Sub

    Private Sub g_select_MouseDown(sender As Object, e As MouseEventArgs) Handles g_select.MouseDown
        If (e.Button = MouseButtons.Right) Then
            Dim h = g_select.HitTest(e.X, e.Y)
            If (h.Type = DataGridViewHitTestType.Cell) Then
                g_select.Rows(h.RowIndex).Selected = True
            End If
        End If
    End Sub

    Private Sub btn_AddMed_Click(sender As Object, e As EventArgs) Handles btn_AddMed.Click
        AddMed()
    End Sub

    Private Sub btn_RemoveMed_Click(sender As Object, e As EventArgs) Handles btn_RemoveMed.Click
        RemoveMed()
    End Sub

    Private Sub g_med_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles g_med.CellContentClick

    End Sub
End Class