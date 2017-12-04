Imports System.Data.SqlClient

Public Class FInsurCase
    Private Sub show_cases()
        Dim da As New KrDataSetTableAdapters.dt_CasesTableAdapter
        da.Fill(Kremen.dt_Cases, Globals.ColValueByCurRow(FKlients.g_klients, "id"))

        da.Dispose()
    End Sub
    Private Sub FInsurCase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_fio.Text = Globals.ColValueByCurRow(FKlients.g_klients, "fio")
        g_cases.AutoGenerateColumns = False
        g_cases.DataSource = Kremen.dt_Cases
        show_cases()
    End Sub

    Private Sub btn_NewCase_Click(sender As Object, e As EventArgs) Handles btn_NewCase.Click
        Me.SuspendLayout()
        mode = type_case.NEW_CASE
        FCase.ShowDialog()
        show_cases()
        Me.ResumeLayout()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub

    Private Sub InsurCaseEdit()
        If Not Kremen.dt_Cases.Rows.Count > 0 Then
            Exit Sub
        End If
        Me.SuspendLayout()
        Dim sel_idx As Integer = g_cases.CurrentRow.Index
        mode = type_case.EDIT_CASE
        FCase.ShowDialog()
        show_cases()
        g_cases.Rows(sel_idx).Selected = True
        g_cases.CurrentCell = g_cases.Rows(sel_idx).Cells(0)
        Me.ResumeLayout()
    End Sub

    Private Sub btn_UpdCase_Click(sender As Object, e As EventArgs) Handles btn_UpdCase.Click
        InsurCaseEdit()

    End Sub

    Private Sub g_cases_DoubleClick(sender As Object, e As EventArgs) Handles g_cases.DoubleClick
        InsurCaseEdit()
    End Sub

    Private Sub FInsurCase_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btn_DelCase_Click(sender As Object, e As EventArgs) Handles btn_DelCase.Click
        If Not Kremen.dt_Cases.Rows.Count > 0 Then
            Exit Sub
        End If
        Dim dt1 = New Date(Now.Year, Now.Month, 1).AddMonths(-2)
        Dim date_close As Object = Globals.ColValueByCurRow(g_cases, "bol_end")

        If Not IsDBNull(date_close) Then
            If Convert.ToDateTime(date_close) < dt1 Then
                MsgBox("Нельзя удалить! Дата закрытия ранее чем первое число предыдущего месяца", vbInformation)
                Exit Sub
            End If
            If MsgBox("Действительно хотите удалить? Случай будет удален со всеми выдачами", vbYesNo) = MsgBoxResult.Yes Then
                Globals.RemoveCase(Globals.ColValueByCurRow(g_cases, "id"))
                show_cases()
            End If
        Else
            If MsgBox("Действительно хотите удалить? Случай будет удален со всеми выдачами", vbYesNo) = MsgBoxResult.Yes Then
                Globals.RemoveCase(Globals.ColValueByCurRow(g_cases, "id"))
                show_cases()
            End If
        End If
    End Sub

End Class